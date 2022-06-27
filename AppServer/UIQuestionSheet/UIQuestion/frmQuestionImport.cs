using L2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace AppServer.UIQuestionSheet.UIQuestion
{
    public partial class frmQuestionImport : L3.BaseForm
    {        
        public int QSheetId { get; set; }
        //
        public frmQuestionImport()
        {
            InitializeComponent();
        }

        //*** LOAD, UNLOAD ****
        private void frmQuestionImport_Load(object sender, EventArgs e)
        {
            pnConfig.Visible = true;
            pnProcessing.Visible = false;
        }

        private void frmQuestionImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = btnCancel.Text == "Đóng" ?
                System.Windows.Forms.DialogResult.OK :
                System.Windows.Forms.DialogResult.Cancel;
        }

        //*** OPEN FILE ****
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MS Word 2007|*.docx| MS Word 2003|*.doc";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    txtFilePath.Text = openFileDialog.FileName;
            }
        }
        //*** OK, CANCEL ***
        private void btnOK_Click(object sender, EventArgs e)
        {            
            if (!File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Tệp tin câu hỏi không tồn tại. Vui lòng chọn lại đường dẫn tệp tin", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn nhập câu hỏi từ tập tin được chọn?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {                
                _terminateWordProcesses(0);

                // GUI 
                btnOK.Enabled = false;
                btnCancel.Enabled = false;

                // Panel GUI
                pnConfig.Visible = false;
                pnProcessing.Visible = true;

                // ---------
                Import(txtFilePath.Text);

                // GUI
                btnOK.Enabled = true;
                btnCancel.Enabled = true;

                if (chkAutoClose.Checked)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bộ đề đã được nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // hide pn processing
                    pnProcessing.Visible = false;
                    lblStatus.Text = "";
                    lblPercentage.Text = "";
                    lblProcessedLine.Text = "";
                    lblQuestionNumber.Text = "";
                    lblTotalLine.Text = "";
                    progressBar1.Value = progressBar1.Minimum;
                    
                    // show import again
                    pnConfig.Visible = true;
                    txtFilePath.Text = "";                    
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _updateUI(Action a)
        {
            Invoke(a);
        }

        /// <summary>
        /// I. Flags:
        ///  + {{version:n}} : a flag indicate version of document format
        ///  + {{begin}} : a flag indicate that we will begin to parse question
        ///  + {{q:n}} : a flag indicate that begin of question, n : 0 = no shullfe, 1 = shuffle
        ///  + {{a:A}} : a flag indicate that begin of answer, A : A = A, B = B, C = C, D = D
        ///  + {{guide}} : a flag indicate that begin read guide.
        ///  + {{end}} : a flag indicate that we will terminate to parse question, everything is done.        
        ///  
        /// II. Important note:
        ///  + No blank line added
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private void Import(string filePath)
        {
            Word.Application word = null;
            Word.Document doc = null;
            object miss = Type.Missing;
           
            try
            {
                L1.Logger.LogLevel1("Initial word application...");
                _updateUI(() => { lblStatus.Text = "Đang mở tệp tin " + filePath + "..."; });            
                word = new Word.Application();
                L1.Logger.LogLevel1("Word application initialized.");
                word.Visible = false;
                L1.Logger.LogLevel1("Openning document " + filePath);
                doc = word.Documents.Open(filePath, ReadOnly: true, Visible: false);
                doc.Activate();
                L1.Logger.LogLevel1("Document " + filePath + " openned.");
            }
            catch (Exception openException)
            {
                _updateUI(() =>
                {
                    MessageBox.Show(
                        "Đã có lỗi xảy ra trong quá trình mở tệp tin." + Environment.NewLine +
                        "Chi tiết lỗi: " + openException.Message,
                        "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
                // stop processing
                return;
            }
           
            try
            {
                L1.Logger.LogLevel1("Processing word document...");
                _updateUI(() => { lblStatus.Text = "Xử lý tệp tin..."; });

                // update total line
                int maxLine = doc.Paragraphs.Count;
                lblTotalLine.Text = maxLine.ToString();
                if (maxLine != 0)
                    progressBar1.Maximum = maxLine;

                // read parse version
                // default parser version
                string version = "1.0.0";
                int line = 1;
                string uniText;
                while (line <= maxLine)
                {
                    var paragraph = _getParagraph(doc, line);
                    uniText = (string)_getUnicodeData(paragraph);
                    line++;

                    if (uniText.StartsWith("{{version:"))
                    {
                        version = uniText.Substring(10, uniText.IndexOf('}') - 10);
                        break;
                    }
                }

                switch (version)
                {
                    case "1.0.0":
                    default:
                        L1.Logger.LogLevel1("Detect sample version 1.0.0");
                        _parse_v1_0_0(doc);
                        break;
                }
            }
            finally
            {
                try
                {
                    _updateUI(() =>
                    {
                        lblProcessedLine.Text = doc.Paragraphs.Count.ToString();
                        lblPercentage.Text = "100%";
                        progressBar1.Value = progressBar1.Maximum;
                    });

                    if (doc != null)
                    {
                        L1.Logger.LogLevel1("Closing document...");
                        _updateUI(() =>
                        {
                            lblStatus.Text = "Đóng tệp tin...";
                        });
                        var temp = Path.GetTempFileName();
                        File.Delete(temp);
                        doc.SaveAs(temp);
                        doc.Close(ref miss, ref miss, ref miss);
                        doc = null;
                        L1.Logger.LogLevel1("Doument closed.");
                    }
                    if (word != null)
                    {
                        L1.Logger.LogLevel1("Quitting word...");
                        word.Quit(ref miss, ref miss, ref miss);
                        word = null;
                        L1.Logger.LogLevel1("Word quited.");
                    }

                    GC.Collect();
                }
                catch (Exception ex)
                {
                    L1.Logger.Log(ex);
                }
            }
        }
        
        private void _parse_v1_0_0(Word.Document doc)
        {
            Question question = null;
            L3.ExRichText exRich = new L3.ExRichText();
            int line = 1;
            int maxLine = doc.Paragraphs.Count;
            int questionCount = 0;
            // 
            string uniText = string.Empty;
            string rtf = string.Empty;
            // jump to begin section
            L1.Logger.LogLevel3("Scan {{begin}}...");
            while (line <= maxLine)
            {
                var paragraph = _getParagraph(doc, line);
                uniText = (string)_getUnicodeData(paragraph);
                if (uniText.StartsWith("{{begin}}", StringComparison.OrdinalIgnoreCase))
                    break;
                else
                    line++;
            }

            L1.Logger.LogLevel1("Scan {{begin}} completed.");
            // skip {{begin}} line
            line++;

            // read question
            while (true)
            {               
                var paragraph = _getParagraph(doc, line);
                uniText = (string)_getUnicodeData(paragraph);

                // terminate if meet end
                if (uniText.StartsWith("{{end}}"))
                    return;
                
                // find question signature
                // {{q:1}} question allow shuffle
                // {{q:0}} question and not allow shuffle
                while (!uniText.StartsWith("{{q"))
                {
                    L1.Logger.LogLevel1("Scanning {{q");
                    // terminate if meet end
                    if (uniText.StartsWith("{{end}}"))
                        return;
                    paragraph = _getParagraph(doc, ++line);
                    uniText = (string)_getUnicodeData(paragraph);
                    continue;
                }

                // init default question
                exRich.Clear();
                question = new Question()
                {
                    QuestionSheetId = QSheetId,
                    CorrectAnswer = -1,
                    ShuffleAnswer = uniText.StartsWith("{{q}}") || (uniText.Length > 4 && uniText[4] != '0')
                };

                paragraph = _getParagraph(doc, ++line);
                uniText = (string)_getUnicodeData(paragraph);

                L1.Logger.LogLevel1("Found {{q.");
                
                // {{a:A}} Answer correct is A
                // {{a:B}} Answer correct is B
                // {{a:C}} Answer correct is C
                // {{a:D}} Answer correct is D
                // {{a:}} // no answer
                while (!uniText.StartsWith("{{a"))
                {
                    L1.Logger.LogLevel1("Reading question. Scanning {{a");
                    // terminate if meet end
                    if (uniText.StartsWith("{{end}}"))
                        return;
                    exRich.SelectedRtf = (string)_getRtfData(paragraph);
                    paragraph = _getParagraph(doc, ++line);
                    uniText = (string)_getUnicodeData(paragraph);
                }

                L1.Logger.LogLevel1("Found {{a.");
                // save question content
                question.Content = exRich.Rtf;
                int correctAns = -1;
                if (uniText.Length >= 5)
                {
                    correctAns = 
                        uniText[4] == 'A' ? 0 :
                        uniText[4] == 'B' ? 1 :
                        uniText[4] == 'C' ? 2 :
                        uniText[4] == 'D' ? 3 : -1;
                }
                question.CorrectAnswer = correctAns;
                L1.Logger.LogLevel1("Reading answer A");
                // read answer
                // current line already point to the A answer
                paragraph = _getParagraph(doc, ++line);
                question.A = (string)_getRtfData(paragraph);

                L1.Logger.LogLevel1("Reading answer B");
                // read B answer
                paragraph = _getParagraph(doc, ++line);
                question.B = (string)_getRtfData(paragraph);

                L1.Logger.LogLevel1("Reading answer C");
                // read C answer
                paragraph = _getParagraph(doc, ++line);
                question.C = (string)_getRtfData(paragraph);

                L1.Logger.LogLevel1("Reading answer D");
                // read D answer
                paragraph = _getParagraph(doc, ++line);
                question.D = (string)_getRtfData(paragraph);                           

                // store question
                L1.Logger.LogLevel1("Saving question into database");
                App.Db.Table<Question>().Insert(question);
                L1.Logger.LogLevel1("Question saved.");
                // update question count
                questionCount++;

                _updateUI(() =>
                {
                    lblQuestionNumber.Text = questionCount.ToString();

                    // update all progress
                    lblProcessedLine.Text = line.ToString();
                    lblPercentage.Text = (line * 100 / maxLine).ToString() + "%";
                    progressBar1.Value = line;
                });
            }
        }

        /// <summary>
        /// Kill all word process
        /// </summary>
        private void _terminateWordProcesses(int wait)
        {            
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(wait);
                L1.Logger.LogLevel3("Force close word process");

                Process[] ps = Process.GetProcesses();
                for (int i = 0; i < ps.Length; i++)
                {
                    if (ps[i].ProcessName.StartsWith("Microsoft Word") || ps[i].ProcessName.StartsWith("WINWORD"))
                    {
                        try
                        {
                            L1.Logger.LogLevel3("Killing word process...");
                            ps[i].Kill();
                            L1.Logger.LogLevel3("Word process killed.");
                        }
                        catch (Exception ex)
                        {
                            L1.Logger.Log(ex);
                        }
                    }
                }
                
            });            
        }

        /// <summary>
        /// Get paragraph style
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool _isBold(Word.Paragraph p)
        {
            var isBold = false;
            try
            {
                isBold = p.Range.Bold != 0;
            }
            catch (Exception ex)
            {
                L1.Logger.Log(ex);
            }
            return isBold;
        }
        private bool _isItalic(Word.Paragraph p)
        {
            var isItalic = false;
            try
            {
                isItalic = p.Range.Italic != 0;
            }
            catch (Exception ex)
            {
                L1.Logger.Log(ex);
            }
            return isItalic;
        }
        private bool _isUnderline(Word.Paragraph p)
        {
            var isUnderline = false;
            try
            {
                isUnderline = p.Range.Underline != Word.WdUnderline.wdUnderlineNone;
            }
            catch (Exception ex)
            {
                L1.Logger.Log(ex);
            }
            return isUnderline;
        }
        
        /// <summary>
        /// Get data from paragraph
        /// </summary>
        /// <param name="paragraph"></param>
        /// <returns></returns>
        private string _getUnicodeData(Word.Paragraph paragraph)
        {
            return _getData(paragraph, DataFormats.UnicodeText);
        }
        private string _getRtfData(Word.Paragraph paragraph)
        {
            
            return _getData(paragraph, DataFormats.Rtf);
        }       
        private string _getData(Word.Paragraph paragraph, string type)
        {
            try
            {
                paragraph.Range.Copy();
                return Clipboard.GetDataObject().GetData(type).ToString();
            }
            catch (Exception ex)
            {
                L1.Logger.Log(ex);
                return string.Empty;
            }
        }

        private Word.Paragraph _getParagraph(Word.Document doc, int line)
        {
            if (doc.Paragraphs.Count < line)
                throw new Exception("Index out of range");
            else
                return doc.Paragraphs[line];
        }
    }
}

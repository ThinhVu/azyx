using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace L3
{
    public partial class frmPortraitReport<TModel, TCard> : BaseForm
        where TModel : L2.IReportModel, new()
        where TCard : Control, IReportCard<TModel>, new()
    {
        private frmPortraitReport()
        {
            InitializeComponent();
            this.Icon = L3.Properties.Resources.icons8_print_50;
            this.MinimumSize = new Size(840, Screen.PrimaryScreen.Bounds.Height);
            this.MaximumSize = new Size(840, Screen.PrimaryScreen.Bounds.Height);
        }
        //
        public static void ShowReport(TModel model)
        {
            try
            {
                var card = new TCard();
                var frmReport = new frmPortraitReport<TModel, TCard>();
                frmReport._pnHost.Controls.Add(card);
                card.SetModel(model);
                frmReport._nudPage.Minimum = 1;
                frmReport._nudPage.Maximum = card.TotalPages; // base 1
                frmReport._lblPageiOfn.Text = "Trang 1/" + card.TotalPages.ToString();
                card.ShowPage(0);
                frmReport.ShowDialog();
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        // 
        private void _nudPage_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var card = (_pnHost.Controls[0] as IReportCard<TModel>);
                var index = (int)_nudPage.Value;
                this._lblPageiOfn.Text = "Trang " + index + "/" + card.TotalPages.ToString();
                card.ShowPage((int)index - 1);
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        // -   
        private void _btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _saveOrPrint(false);
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void _btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                _saveOrPrint(true);
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        //
        private void _saveOrPrint(bool print)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                // setup filter
                string filter = "";
                if (print)
                    filter = "PDF(*.pdf)|*.pdf";
                else
                    filter = "PDF(*.pdf)|*.pdf|BMP(*.BMP)|*.BMP|JPEG(*.JPG)|*.JPG|PNG(*.png)|*.png";
                saveFileDialog.Filter = filter;
                saveFileDialog.FileName = "Report";


                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _btnSave.Enabled = false;

                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                    var dir = Path.GetDirectoryName(saveFileDialog.FileName);
                    var extension = Path.GetExtension(saveFileDialog.FileName);

                    // un register
                    _nudPage.ValueChanged -= _nudPage_ValueChanged;

                    _lblSaving.Text = "Đang lưu...";

                    // save images
                    var card = (_pnHost.Controls[0] as IReportCard<TModel>);
                    bool pdfExport = extension.ToLower() == ".pdf";
                    // mapping temp and real path
                    Dictionary<string, string> tempPaths = null;
                    if (pdfExport)
                        tempPaths = new Dictionary<string, string>();

                    for (int i = 1; i <= _nudPage.Maximum; i++)
                    {
                        _lblSaving.Text = "Đang lưu trang " + i + "/" + _nudPage.Maximum;

                        try
                        {
                            card.ShowPage(i - 1);

                            // create image
                            var b = new Bitmap(_pnHost.Width, _pnHost.Height);
                            _pnHost.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));

                            // save to temp file
                            if (pdfExport)
                            {
                                var tempPath = Path.GetTempFileName();
                                b.Save(tempPath);
                                tempPaths[dir + Path.DirectorySeparatorChar + fileNameWithoutExt + i + extension] = tempPath;
                            }
                            else // image format
                            {
                                b.Save(dir + Path.DirectorySeparatorChar + fileNameWithoutExt + i + extension);
                            }

                            b.Dispose();
                            b = null;
                        }
                        catch (Exception ex)
                        {
                            L1.Logger.Log(ex);
                        }
                    }

                    PdfDocument pdf = null;
                    // process pdf 
                    if (pdfExport)
                    {
                        _lblSaving.Text = "Đang tạo pdf...";
                        try
                        {
                            pdf = new PdfDocument();
                            foreach (var kvp in tempPaths)
                            {

                                // create newpage
                                PdfPage pdfPage = pdf.AddPage();
                                using (XGraphics graph = XGraphics.FromPdfPage(pdfPage))
                                using (XImage image = XImage.FromFile(kvp.Value))
                                {
                                    graph.DrawImage(image, 0, 0);
                                }
                                File.Delete(kvp.Value);
                            }
                            pdf.Save(saveFileDialog.FileName);

                            if (print)
                            {
                                _printPdf(saveFileDialog.FileName);
                            }

                            MessageBox.Show("Tạo báo cáo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra. Thông tin lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            L1.Logger.Log(ex);
                        }
                    }
                    else // image
                    {
                        MessageBox.Show("Tạo báo cáo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // save or print completed, register again to allow user re-view report.
                    _nudPage.ValueChanged += _nudPage_ValueChanged;

                    _lblSaving.Text = string.Empty;
                    _btnSave.Enabled = true;
                }
            }
        }
        private bool _printPdf(string filePath)
        {
            try
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    Verb = "print",
                    FileName = filePath
                };
                p.Start();
                p.WaitForExit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                L1.Logger.Log(ex);
                return false;
            }
        }
    }
}
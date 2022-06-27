using ClientApp.Properties;
using L2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class frmDoExam : L3.BaseForm
    {
        private TimeSpan _totalTime;
        private TimeSpan _remainingTime;
        //--
        private TheTest _theTest;
        private TestResult _testResult;
        //--
        private List<QuestionAnswerData> _questionAnswerData;
        private bool _submitOrSavedSucceed;
        // --
        private int _theTestAnswerId;
        //--
        public frmDoExam(TheTest theTest, int theTestAnswerId)
        {
            InitializeComponent();
            //----------------------------
            this.Icon = ClientApp.Properties.Resources.ico_signature;
            this.MinimumSize = new Size((int)(Screen.PrimaryScreen.WorkingArea.Width / 2), Screen.PrimaryScreen.WorkingArea.Height);                  
            // ----------------------------
            try
            {
                _theTest = theTest;
                _theTestAnswerId = theTestAnswerId;
                _totalTime = TimeSpan.FromMinutes(_getTestTime(theTest.QuestionSheetId));                

                string answerSheet = _getSavedAnswer(_theTestAnswerId);
                if (answerSheet != string.Empty)
                {
                    _questionAnswerData = _initQuestionAnswer(answerSheet);
                    var timeSpent = _getTimeSpent(_theTestAnswerId);
                    _remainingTime = _totalTime - TimeSpan.FromMinutes(timeSpent);
                }
                else
                {
                    // select question in current sheet
                    // select all data of question will make this query very slow 
                    // => select Id, CorrectAnswer, ShuffleAnswer from question where Id = @Id
                    // 1 record return
                    var questions = Program.Database.Table<Question>().Engine.SelectFields(
                        fields: new List<string> { "Id", "CorrectAnswer", "ShuffleAnswer" },
                        where: new List<L1.BaseField> { new L1.EqField("QuestionSheetId", theTest.QuestionSheetId) }
                    );
                    _questionAnswerData = _initQuestionAnswer(questions);
                    _remainingTime = _totalTime;
                }                
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        //--
        private void frmDoExam_Load(object sender, EventArgs e)
        {
            try
            {
                // get subject info
                var subject = Program.Database.Table<Subject>().Get(_theTest.SubjectId);

                this.Text = string.Format(
                    "Bài thi: {0} -- Thí sinh: {1} -- Môn thi: {2} -- Mã đề: {3}",
                    _theTest.Name, Program.Student.Name, subject.Name, _theTest.QuestionSheetId);

                // init button list
                btnList.InitButtton(_questionAnswerData);
                btnList.OnButtonClicked = (index) =>
                {
                    _pnLoading.Visible = true;
                    _grbQuestion.Text = "Câu hỏi số " + (index + 1);

                    var qad = _questionAnswerData[index];                    
                    var content = qad.GetQuestionContent();
                    questionCard1.SetContent(content);
                    questionCard1.SetA(qad.GetARtf());
                    questionCard1.SetB(qad.GetBRtf());
                    questionCard1.SetC(qad.GetCRtf());
                    questionCard1.SetD(qad.GetDRtf());
                    questionCard1.RePositionRtb();
                    // show user answer
                    _abcd.SetValue(qad.UserAnswer);

                    // anti-closure
                    var ii = index;
                    // set handle when user change answer
                    _abcd.OnCheckedChanged = (value) =>
                    {
                        // store user answer
                        qad.UserAnswer = value;

                        // mark current question is done
                        _questionAnswerData[ii].State = QuestionState.Done;
                        btnList.SetState(ii, QuestionState.Done);
                    };

                    // display correct
                    _lblCorrectAnswer.Text = qad.GetCorrect();
                    _pnLoading.Visible = false;
                };

                if (_questionAnswerData.Count > 0)
                {
                    // display the first question
                    btnList.PerformClick(0);

                    // and start countdown
                    timerCountdown.Tick += TimerCountdown_Tick;
                    timerCountdown.Interval = 1000;
                    timerCountdown.Start();
                }
                else
                {
                    MessageBox.Show("Không có thông tin câu hỏi. Vui lòng kiểm tra lại đề bài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }
        private void frmDoExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            // prevent user close form when not submit
            if (!_submitOrSavedSucceed)
            {
                MessageBox.Show(
                    "Bạn chưa nộp bài hoặc lưu lại bài. Hãy nộp bài hoặc lưu lại bài trước khi thoát.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                e.Cancel = true;
            }            
        }
        //--
        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
            if (_remainingTime.TotalSeconds <= 0)
            {
                timerCountdown.Stop();
                MessageBox.Show(
                    "Đã hết thời gian làm bài. Bài thi sẽ được nộp tự động.",
                    "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    _submitAndDisplayResult();
                }
                catch (Exception ex)
                {
                    L3.ExceptionDisplayer.ShowOkError(ex);
                }
            }
            else
            {
                // countdown and update time label.
                _remainingTime = _remainingTime.Subtract(TimeSpan.FromSeconds(1));
                _lblRemainingTime.Text = _remainingTime.ToString("hh\\:mm\\:ss");

                // display hour glass
                if (_remainingTime.TotalSeconds > 0.5 * _totalTime.TotalSeconds)
                    _picHourGlass.Image = Resources.hourglass_full32;
                else if (0 < _remainingTime.TotalSeconds && _remainingTime.TotalSeconds < 0.5 * _totalTime.TotalSeconds)
                    _picHourGlass.Image = Resources.hourglass32;
                else
                    _picHourGlass.Image = Resources.hourglass_empty32;
            }
        }
        //--
        private void _btnOpenCalc_Click(object sender, EventArgs e)
        {
            try
            {
                var vinacal = ".\\Calc\\Vinacal570ESPLUS.exe";
                // trying open FX570 VNPlus
                if (File.Exists(".\\Calc\\Vinacal570ESPLUS.exe"))
                {
                    Process.Start(vinacal);
                }
                else
                {
                    // start default calc
                    Process.Start("calc");
                }                
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);                
            }
        }
        private void _btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn nộp bài?", "Nộp bài", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                    
                    timerCountdown.Stop();
                    _submitAndDisplayResult();
                }
            }
            catch (Exception ex)
            {
                L3.ExceptionDisplayer.ShowOkError(ex);
            }
        }        
        private void _btnTemporySave_Click(object sender, EventArgs e)
        {
            _btnTemporySave.Enabled = false;            
            _submitOrSave(false);
            MessageBox.Show(
                "Kết quả đã được lưu tạm thời. Bạn có thể tiếp tục làm ngay bây giờ hoặc làm lại sau.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            _btnTemporySave.Enabled = true;
        }
       
        /// <summary>
        /// Shuffle questions and answers
        /// </summary>
        private List<QuestionAnswerData> _initQuestionAnswer(List<Question> questions)
        {
            L1.Logger.LogLevel2("QuestionSheet answer initializing...");
            var questionAnswerData = new List<QuestionAnswerData>();
            foreach (var question in questions)
                questionAnswerData.Add(new QuestionAnswerData(question));
            L1.Logger.LogLevel2("QuestionSheet answer initialized.");

            L1.Logger.LogLevel2("Question index shuffle...");
            var randomizer = new Random();
            QuestionAnswerData temp;
            // run through all item in list to ensure all item will be swap
            for (int i = 0, count = questionAnswerData.Count; i < count; i++)
            {
                int j = randomizer.Next(count);
                // swap
                temp = questionAnswerData[i];
                questionAnswerData[i] = questionAnswerData[j];
                questionAnswerData[j] = temp;
            }
            L1.Logger.LogLevel2("Question index shuffle completed.");
            return questionAnswerData;
        }

        private List<QuestionAnswerData> _initQuestionAnswer(string answerSheet)
        {
            var results = new List<QuestionAnswerData>();
            var ss = answerSheet.Split('.');
            for (int i = 0; i < ss.Length; i++)
                results.Add(QuestionAnswerData.Parse(ss[i]));
            return results;
        }

        /// <summary>
        /// Submit then display result
        /// </summary>
        private void _submitAndDisplayResult()
        {
            btnSubmit.Enabled = false;
            _computeResult();
            _submitOrSave(true);
            btnSubmit.Visible = false;
            btnOpenCalc.Visible = false;
        }

        /// <summary>
        /// Save to db
        /// </summary>
        private void _submitOrSave(bool submit)
        {
            var testAnswer = new TheTestResult();
            testAnswer.Id = _theTestAnswerId;
            testAnswer.TheTestId = _theTest.Id;
            testAnswer.StudentId = Program.Student.Id;
            
            testAnswer.AnswerSheet = _buildAnswerSheet();
            testAnswer.TimeSpent = (int)(_totalTime.TotalMinutes - _remainingTime.TotalMinutes);

            if (submit)
            {
                testAnswer.Correct = _testResult.Correct;
                testAnswer.Incorrect = _testResult.Incorrect;
                testAnswer.NotDone = _testResult.NotDone;                
            }            
            
            testAnswer.Submitted = submit;

            // submit result
            Program.Database.Table<TheTestResult>().Update(testAnswer);

            _submitOrSavedSucceed = true;
        }

        /// <summary>
        /// Build answer sheet
        /// </summary>
        /// <returns></returns>
        private string _buildAnswerSheet()
        {
            var sb = new List<string>();
            for (int i = 0; i < _questionAnswerData.Count; i++)
                sb.Add(_questionAnswerData[i].ToString());
            return string.Join(".", sb.ToArray());
        }

        /// <summary>
        /// Compute result and display button list state
        /// </summary>
        private void _computeResult()
        {
            _lblCorrectAnswer.Visible = true;
            _abcd.Enabled = false;

            int @true = 0;
            int @false = 0;
            int notDone = 0;

            for (int i = 0; i < _questionAnswerData.Count; i++)
            {
                var qMatrix = _questionAnswerData[i];
                if (qMatrix.CorrectAnswer == qMatrix.UserAnswer)
                {
                    @true++;
                    btnList.SetState(i, QuestionState.Correct);
                }
                else if (qMatrix.UserAnswer < 0 || qMatrix.UserAnswer > 3)
                {
                    notDone++;
                    btnList.SetState(i, QuestionState.NotDone);
                }
                else
                {
                    @false++;
                    btnList.SetState(i, QuestionState.Incorrect);
                }
            }

            _lblScore.Text = Math.Round((10.0 / _questionAnswerData.Count) * @true, 2, MidpointRounding.AwayFromZero).ToString();
            _lblTrue.Text = @true.ToString();
            _lblFalse.Text = @false.ToString();
            _lblNotDone.Text = notDone.ToString();

            //-- use later
            _testResult = new TestResult
            {
                Correct = @true,
                Incorrect = @false,
                NotDone = notDone
            };
        }
        private int _getTestTime(int questionSheetId)
        {
            return Program.Database.Table<QuestionSheet>().Get(questionSheetId).TestTime;
        }
        private string _getSavedAnswer(int theTestAnswerId)
        {
            var theTestAnswer = Program.Database.Table<TheTestResult>().Get(theTestAnswerId);
            if (theTestAnswer == null)
                return string.Empty;
            else
                return theTestAnswer.AnswerSheet;
        }
        private int _getTimeSpent(int theTestAnswerId)
        {
            var theTestAnswer = Program.Database.Table<TheTestResult>().Get(theTestAnswerId);
            if (theTestAnswer == null)
                return -1;
            else
                return theTestAnswer.TimeSpent;
        }
    }

    public class QuestionAnswerData
    {
        private static string[] _abcd = new string[] { "A", "B", "C", "D" };

        // --- editable
        public int UserAnswer { get; set; }
        public QuestionState State { get; set; }
        // --- non editable
        public int QuestionId { get; private set; }
        public int CorrectAnswer { get; private set; }
        public int APos { get; private set; }
        public int BPos { get; private set; }
        public int CPos { get; private set; }
        public int DPos { get; private set; }
        // ---
        public QuestionAnswerData()
        {

        }
        public QuestionAnswerData(Question questionInfor)
        {
            // init default state for QuestionAnswerData
            UserAnswer = -1;
            State = QuestionState.NotDone;

            // -----            
            QuestionId = questionInfor.Id;

            // shuffle answer
            if (questionInfor.ShuffleAnswer)
            {
                var answerPos = _shuffleAnswer();
                APos = answerPos[0];
                BPos = answerPos[1];
                CPos = answerPos[2];
                DPos = answerPos[3];

                // cause we move the answer so we need to move correct answer position too
                for (int i = 0; i < answerPos.Length; i++)
                {
                    if (answerPos[i] == questionInfor.CorrectAnswer)
                    {
                        CorrectAnswer = i;
                        break;
                    }
                }
            }
            else
            {
                // no shuffle no swap no translate
                APos = 0;
                BPos = 1;
                CPos = 2;
                DPos = 3;
                CorrectAnswer = questionInfor.CorrectAnswer;
            }
        }
        // ---
        public string GetQuestionContent()
        {
            return _queryQuestionInfo("Content").Content;
        }
        public string GetARtf()
        {
            return _getQuestionAnswerData(APos);
        }
        public string GetBRtf()
        {
            return _getQuestionAnswerData(BPos);
        }
        public string GetCRtf()
        {
            return _getQuestionAnswerData(CPos);
        }
        public string GetDRtf()
        {
            return _getQuestionAnswerData(DPos);
        }
        public string GetCorrect()
        {
            if (0 <= CorrectAnswer && CorrectAnswer <= 3)
                return _abcd[CorrectAnswer];
            else
                return "X";
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return UserAnswer + ":" + State + ":" + QuestionId + ":" + CorrectAnswer + ":" + APos + ":" + BPos + ":" + CPos + ":" + DPos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static QuestionAnswerData Parse(string s)
        {
            var ss = s.Split(':');
            var rs = new QuestionAnswerData();
            rs.UserAnswer = int.Parse(ss[0]);
            rs.State = (QuestionState) Enum.Parse(typeof(QuestionState), ss[1]);
            rs.QuestionId = int.Parse(ss[2]);
            rs.CorrectAnswer = int.Parse(ss[3]);
            rs.APos = int.Parse(ss[4]);
            rs.BPos = int.Parse(ss[5]);
            rs.CPos = int.Parse(ss[6]);
            rs.DPos = int.Parse(ss[7]);
            return rs;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int[] _shuffleAnswer()
        {
            var randomizer = new Random();
            var answerPos = new int[] { 0, 1, 2, 3 };
            for (int i = 0; i < 4; i++)
            {
                // pick random position
                int a1 = randomizer.Next(4);
                // then swap current item for the item in random position
                int temp = answerPos[i];
                answerPos[i] = answerPos[a1];
                answerPos[a1] = temp;
            }
            return answerPos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private string _getQuestionAnswerData(int position)
        {
            if (position < 0 || position > 3)
                return string.Empty;

            switch (position)
            {
                case 0:
                    return _queryQuestionInfo("A").A;
                case 1:
                    return _queryQuestionInfo("B").B;
                case 2:
                    return _queryQuestionInfo("C").C;
                case 3:
                    return _queryQuestionInfo("D").D;
            }

            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private Question _queryQuestionInfo(string fieldName)
        {
            return Program.Database.Table<Question>().Engine.SelectFields(
                new List<string> { fieldName },
                new List<L1.BaseField> { new L1.EqField("Id", QuestionId) })[0];
        }
    }

    public enum QuestionState
    {
        NotDone,
        Done,
        Correct,
        Incorrect
    }

    public class TestResult
    {
        public int Correct { get; set; }
        public int Incorrect { get; set; }
        public int NotDone { get; set; }
    }
}
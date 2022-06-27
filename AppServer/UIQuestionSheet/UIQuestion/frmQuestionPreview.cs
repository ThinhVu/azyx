using System.Collections.Generic;
using System.Windows.Forms;

using L2;
using L2.Models;

namespace AppServer.UIQuestionSheet.UIQuestion
{
    public partial class frmQuestionPreview : L3.BaseForm
    {
        private QuestionSheet _sheet;
        private List<int> _questionIds;

        public frmQuestionPreview(QuestionSheet sheet)
        {
            InitializeComponent();
            _sheet = sheet;
        }

        private void QuestionList_Load(object sender, System.EventArgs e)
        {
            this.Text = string.Format("Thông tin câu hỏi -- Mã đề: {0}", _sheet.Id);

            var questions = App.Db.Table<Question>().Engine.SelectFields(               
                fields: new List<string>{ "Id" },
                where: new List<L1.BaseField>{ new L1.EqField("QuestionSheetId", _sheet.Id) });

            if (questions.Count == 0)
            {
                navigation.Maximum = 0;
                navigation.Minimum = 0;
                return;
            }
                

            _questionIds = new List<int>();
            for (int i = 0, count = questions.Count; i < count; i++)
                _questionIds.Add(questions[i].Id);

            // setup navigation
            navigation.ChangeIndex = DisplayQuestion;
            navigation.Maximum = _questionIds.Count;
            navigation.Minimum = 1;
            // load
            navigation.Current = 1;
        }        

        private void DisplayQuestion(int i)
        {
            try
            {
                var question = App.Db.Table<Question>().Get(_questionIds[i - 1]);
                if (question != null)
                    questionCard.SetModel(question);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra. Thông tin lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                L1.Logger.Log(ex);
            }
        }
    }
}

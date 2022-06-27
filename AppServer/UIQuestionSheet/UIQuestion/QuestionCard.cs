using L2.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using L3;
using System;

namespace AppServer.UIQuestionSheet.UIQuestion
{
    public partial class QuestionCard : L3.BaseUserControl, L3.IAddEditCard<Question>
    {
        private Question _model;
        private int _id;
        private int _mode;
        // TODO : How to set?
        private int _questionSheetId;

        public string Title
        {
            get { return "Câu hỏi"; }
        }

        public QuestionCard()
        {
            InitializeComponent();
            PrepareViewModel();
        }

        public Question GetModel()
        {            
            return new Question
            {
                Id = _id,
                QuestionSheetId = _questionSheetId,
                Content = _rtbContent.Rtf,
                Guide = _brtbGuide.Rtf,
                A = _rtbA.Rtf,
                B = _rtbB.Rtf,
                C = _rtbC.Rtf,
                D = _rtbD.Rtf,
                CorrectAnswer = _abcd1.GetValue(),
                ShuffleAnswer = _chkShuffle.Checked
            };
        }
        public void SetModel(Question model)            
        {
            _mode = 1;
            _model = model;
            _id = model.Id;
            _questionSheetId = model.QuestionSheetId;
            _rtbContent.Rtf = model.Content;
            _brtbGuide.Rtf = model.Guide;
            _rtbA.Rtf = model.A;
            _rtbB.Rtf = model.B;
            _rtbC.Rtf = model.C;
            _rtbD.Rtf = model.D;
            _abcd1.SetValue(model.CorrectAnswer);
            _chkShuffle.Checked = model.ShuffleAnswer;
        }
        public void PrepareViewModel()
        {            
        }
        public void PrepareEditModel(Question model)
        {
            _mode = 1;            
        }
        public void PrepareAddModel()
        {
            _mode = 2;            
        }

        private void rtb_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            var rictex = (RichTextBox)sender;
            int newHeight = e.NewRectangle.Height;
            // scale height depend on content
            newHeight = Math.Max(newHeight, rictex.Font.Height);
            // prevent richtextbox pass the bottom of form
            // newHeight = Math.Min(newHeight, this.ClientSize.Height - 10 - rictex.Top);
            // investigate...
            newHeight += rictex.Height - rictex.ClientSize.Height + 1;
            rictex.Height = newHeight;
        }

        private void rtb_SizeChanged(object sender, EventArgs e)
        {   
            // A)
            _positionNextRichTextBox(_rtbContent, _rtbA, _lblA, 10);            

            // B)
            _positionNextRichTextBox(_rtbA, _rtbB, _lblB);

            // C)
            _positionNextRichTextBox(_rtbB, _rtbC, _lblC);

            // D)
            _positionNextRichTextBox(_rtbC, _rtbD, _lblD);

            // increase if needed
            if (_rtbD.Top + _rtbD.Height + 10 > _pnHost.Top + _pnHost.Height)
                _pnHost.Height = _rtbD.Top + _rtbD.Height + 10;
            else
                _pnHost.Height = _pnHost.Parent.Height - 5;
        }

        private void _positionNextRichTextBox(ExRichText before, ExRichText next, Label nextLabel, int topOffset = 0)
        {
            next.Top = before.Top + before.Height + topOffset;
            nextLabel.Top = next.Top + (next.Height - nextLabel.Height) / 2 - next.Margin.Top;
        }

        private void QuestionCard_Load(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case 0: // view
                    _rtbContent.ReadOnly = 
                        _rtbA.ReadOnly = 
                        _rtbB.ReadOnly = 
                        _rtbC.ReadOnly = 
                        _rtbD.ReadOnly = 
                        _brtbGuide.ReadOnly = false;
                    _pnAnswer.Enabled = false;
                    _pnShuffleAnswer.Enabled = false;
                    break;
                case 1: // edit
                    // get question info
                    var qSheetUsed = App.Db.Table<QuestionSheet>().Engine.SelectFields(
                        fields: new List<string> { "Used" },
                        where: new List<L1.BaseField> { new L1.EqField("Id", _model.QuestionSheetId) })[0].Used;

                    // edit if not used
                    //_rtbContent.ReadOnly =
                    //    _rtbA.ReadOnly =
                    //    _rtbB.ReadOnly =
                    //    _rtbC.ReadOnly =
                    //    _rtbD.ReadOnly =
                    //    brtbGuide.ReadOnly = qSheetUsed;

                    //_pnAnswer.Enabled = !qSheetUsed;
                    //_pnShuffleAnswer.Enabled = !qSheetUsed;

                    // allow edit all
                    break;
                case 2: // add
                    _rtbContent.ReadOnly = 
                        _rtbA.ReadOnly = 
                        _rtbB.ReadOnly = 
                        _rtbC.ReadOnly = 
                        _rtbD.ReadOnly = 
                        _brtbGuide.ReadOnly = false;

                    _pnAnswer.Enabled = true;
                    _pnShuffleAnswer.Enabled = true;
                    break;
            }
        }
    }
}

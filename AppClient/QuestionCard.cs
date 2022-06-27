using L2.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using L3;
using System;
using ClientApp;

namespace ClientApp.UIQuestion
{
    public partial class QuestionCard : L3.BaseUserControl
    {
        // workaround way to change fucking stupid rich text box height
        private int[] _richTextHeights = new int[5];
        private bool _controlLoaded = false;
        private List<Subject> _subjects;
        private Question _model;
        private int _id;
        private int _mode;        

        public QuestionCard()
        {
            InitializeComponent();
        }

        public void SetContent(string rtf)
        {
            _rtbContent.ReadOnly = false;
            _rtbContent.Rtf = rtf;
        }

        public void SetA(string rtf)
        {
            _rtbA.ReadOnly = false;
            _rtbA.Rtf = rtf;
        }

        public void SetB(string rtf)
        {
            _rtbB.ReadOnly = false;
            _rtbB.Rtf = rtf;
        }

        public void SetC(string rtf)
        {
            _rtbC.ReadOnly = false;
            _rtbC.Rtf = rtf;      
        }

        public void SetD(string rtf)
        {
            _rtbD.ReadOnly = false;
            _rtbD.Rtf = rtf;            
        }


        private void rtb_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            var rictex = (RichTextBox)sender;

            // cache height
            if (rictex == _rtbContent)
                _richTextHeights[0] = Math.Max(e.NewRectangle.Height, rictex.Font.Height) + rictex.Height - rictex.ClientSize.Height + 1;
            else if (rictex == _rtbA)
                _richTextHeights[1] = Math.Max(e.NewRectangle.Height, rictex.Font.Height) + rictex.Height - rictex.ClientSize.Height + 1;
            else if (rictex == _rtbB)
                _richTextHeights[2] = Math.Max(e.NewRectangle.Height, rictex.Font.Height) + rictex.Height - rictex.ClientSize.Height + 1;
            else if (rictex == _rtbC)
                _richTextHeights[3] = Math.Max(e.NewRectangle.Height, rictex.Font.Height) + rictex.Height - rictex.ClientSize.Height + 1;
            else if (rictex == _rtbD)
                _richTextHeights[4] = Math.Max(e.NewRectangle.Height, rictex.Font.Height) + rictex.Height - rictex.ClientSize.Height + 1;          
        }
       
        private void _positionNextRichTextBox(ExRichText before, ExRichText next, Label nextLabel, int topOffset = 0)
        {
            next.Top = before.Top + before.Height + topOffset;
            nextLabel.Top = next.Top + (next.Height - nextLabel.Height) / 2 - next.Margin.Top;
        }

        private void QuestionCard_Load(object sender, EventArgs e)
        {
            _controlLoaded = true;
        }

        private void scrollableControl1_SizeChanged(object sender, EventArgs e)
        {
            if (!_controlLoaded)
                return;
            RePositionRtb();
        }

        /// <summary>
        /// Reposition richtextbox content
        /// </summary>
        public void RePositionRtb()
        {
            // un-register content sizechange
            _rtbContent.ContentsResized -= rtb_ContentsResized;
            _rtbA.ContentsResized -= rtb_ContentsResized;
            _rtbB.ContentsResized -= rtb_ContentsResized;
            _rtbC.ContentsResized -= rtb_ContentsResized;
            _rtbD.ContentsResized -= rtb_ContentsResized;

            // set new height
            _rtbContent.Height = _richTextHeights[0];
            _rtbA.Height = _richTextHeights[1];
            _rtbB.Height = _richTextHeights[2];
            _rtbC.Height = _richTextHeights[3];
            _rtbD.Height = _richTextHeights[4];

            // re-position
            // A)
            _positionNextRichTextBox(_rtbContent, _rtbA, _lblA, 10);

            // B)
            _positionNextRichTextBox(_rtbA, _rtbB, _lblB);

            // C)
            _positionNextRichTextBox(_rtbB, _rtbC, _lblC);

            // D)
            _positionNextRichTextBox(_rtbC, _rtbD, _lblD);

            // increase if needed
            _pnHost.Height = _rtbD.Top + _rtbD.Height + 10;
            //if (_rtbD.Top + _rtbD.Height + 10 > _pnHost.Top + _pnHost.Height)
            //    _pnHost.Height = _rtbD.Top + _rtbD.Height + 10;
            //else
            //    _pnHost.Height = _rtbD.Top + _rtbD.Height + 10;

            // register content sizechange
            _rtbContent.ContentsResized += rtb_ContentsResized;
            _rtbA.ContentsResized += rtb_ContentsResized;
            _rtbB.ContentsResized += rtb_ContentsResized;
            _rtbC.ContentsResized += rtb_ContentsResized;
            _rtbD.ContentsResized += rtb_ContentsResized;
        }
    }
}

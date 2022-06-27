using ClientApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ButtonList : UserControl
    {
        // store states of button
        private List<QuestionState> _states;
        //--
        public Action<int> OnButtonClicked;        
        public int SelectedIndex { get; private set; }
        //--
        public ButtonList()
        {
            InitializeComponent();
        }
        //--
        /// <summary>
        /// Init button in list
        /// Set default state to QuestionState.NotDone
        /// </summary>
        /// <param name="total"></param>
        public void InitButtton(List<QuestionAnswerData> answerData)
        {            
            flpButtonContainer.Controls.Clear();

            int total = answerData.Count;
            _states = new List<QuestionState>(total);
            for (int i = 0; i < total; i++)
            {
                int ii = i;
                var button = new Button();
                button.Width = 80;              
                button.Text = "Câu " + (i + 1);
                button.Image = Resources.dots_clear;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Moccasin;
                button.ForeColor = Color.Black;
                button.FlatAppearance.BorderColor = Color.Orange;
                button.FlatAppearance.MouseDownBackColor = Color.Orange;
                button.FlatAppearance.MouseOverBackColor = Color.Orange;
                button.Enter += (_, __) => button.BackColor = Color.Orange;
                button.Leave += (_, __) => button.BackColor = Color.Moccasin;
                button.Click += (_, __) =>
                {
                    if (OnButtonClicked != null)
                        OnButtonClicked(ii);
                };                
                flpButtonContainer.Controls.Add(button);

                _states.Add(answerData[i].State);
                _displayButtonUI(i);
            }
        }
        /// <summary>
        /// Perform click on specified butotn
        /// </summary>
        /// <param name="index"></param>
        public void PerformClick(int index)
        {
            if (index > flpButtonContainer.Controls.Count)
                return;
            (flpButtonContainer.Controls[index] as Button).PerformClick();
        }
        /// <summary>
        /// Set state for specified button
        /// </summary>
        /// <param name="index"></param>
        /// <param name="state"></param>
        public void SetState(int index, QuestionState state)
        {
            _states[index] = state;
            _displayButtonUI(index);
        }
        // --
        /// <summary>
        /// display ui depend on state
        /// </summary>
        /// <param name="index"></param>
        private void _displayButtonUI(int index)
        {
            var button = flpButtonContainer.Controls[index] as Button;

            switch (_states[index])
            {
                case QuestionState.NotDone:
                    button.Image = Resources.dots_clear;
                    break;
                case QuestionState.Done:
                    button.Image = Resources.dot;
                    break;
                case QuestionState.Correct:
                    button.Image = Resources.dot_true;
                    break;
                case QuestionState.Incorrect:
                    button.Image = Resources.dot_false;
                    break;
            }
        }
    }
}

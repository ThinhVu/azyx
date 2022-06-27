using System;
using System.Windows.Forms;

namespace L3
{   
    public partial class AddEditBox<TModel, TCard> : L3.BaseForm
        where TModel : L1.BaseRecord
        where TCard : Control, IAddEditCard<TModel>, new()     
    {
        private Func<TModel, bool> _function;

        private AddEditBox()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            L1.Logger.LogLevel1("Continue proceed.");
            if (_function != null)
            {
                if (_function((this.pnHost.Controls[0] as TCard).GetModel()))
                {
                    L1.Logger.LogLevel1("Handler succeeded.");
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    L1.Logger.LogLevel1("Handler terminated.");
                }
            }
            else
            {
                L1.Logger.LogLevel1("No handler.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            L1.Logger.LogLevel1("Cancelled by user.");
            this.Close();
        }
        //
        public static DialogResult Add(Func<TModel, bool> addFunction) 
        {            
            var card = new TCard();
            L1.Logger.LogLevel1("Add model " + card.Title);
            var frm = new AddEditBox<TModel, TCard>();
            frm.Text = "Thêm " + card.Title;
            frm._function = addFunction;
            frm.pnHost.Controls.Add(card);
            card.PrepareAddModel();
            return frm.ShowDialog();
        }
        public static DialogResult Edit(TModel model, Func<TModel, bool> editFunction)
        {            
            var card = new TCard();
            L1.Logger.LogLevel2("Edit model " + card.Title);
            L1.Logger.LogLevel3(model.ToString());
            var frm = new AddEditBox<TModel, TCard>();
            frm.Text = "Sửa " + card.Title;
            frm._function = editFunction;
            frm.pnHost.Controls.Add(card);
            card.PrepareEditModel(model);
            card.SetModel(model);
            return frm.ShowDialog();
        }
        //
        private static DialogResult _do(string title, TCard card, Func<TModel, bool> function)
        {
            var frm = new AddEditBox<TModel, TCard>();
            frm.Text = title + " " + card.Title;
            frm.pnHost.Controls.Add(card);
            frm._function = function;
            return frm.ShowDialog();
        }
    }
}

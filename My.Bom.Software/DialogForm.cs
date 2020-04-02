using My.Bom.Software.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace My.Bom.Software
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
            this.mainPanel.Dock = DockStyle.Fill;
            this.KeyPreview = true;
        }

        private void DialogForm_Shown(object sender, EventArgs e)
        {
            var controls=this.mainPanel.Controls.OfType<UserControl>();
            foreach (UserControl control in controls)
            {
                var text = control.Controls.OfType<TextBox>().OrderBy(c => c.TabIndex).FirstOrDefault();
                if (text != null)
                    text.Focus();
            }
        }

        private void DialogForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Escape)
            {
                var uc = mainPanel.Controls.OfType<UserControl>().FirstOrDefault();
                var button = uc?.GetAll(typeof(Button)).OfType<Button>().FirstOrDefault(b => b.Name.Equals("btnCancel"));
                button?.PerformClick();
            }
        }
    }
}

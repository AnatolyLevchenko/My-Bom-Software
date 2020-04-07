using System.Text;
using System.Windows.Forms;

namespace My.Bom.Software.Helpers
{
    public static class MessageHelper
    {
        public static void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DisplayDone(string message)
        {
            MessageBox.Show(message, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult AskForConfirmation(string line1, string line2 = "", string line3 = "", string line4 = "")
        {

            StringBuilder msg = new StringBuilder();
            msg.AppendLine(line1);
            if (!string.IsNullOrWhiteSpace(line2))
                msg.AppendLine(line2);
            if (!string.IsNullOrWhiteSpace(line3))
                msg.AppendLine(line3);
            if (!string.IsNullOrWhiteSpace(line4))
                msg.AppendLine(line4);

            return MessageBox.Show(msg.ToString(),"INFO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
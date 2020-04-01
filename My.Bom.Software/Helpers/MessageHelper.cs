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
    }
}
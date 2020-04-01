using System.Windows.Forms;

namespace My.Bom.Software.Helpers
{
    public static class Extensions
    {
        public static void TryCloseFrom(this UserControl uc)
        {
            Form tmp = uc.FindForm();
            tmp.Close();
            tmp.Dispose();
        }
    }
}

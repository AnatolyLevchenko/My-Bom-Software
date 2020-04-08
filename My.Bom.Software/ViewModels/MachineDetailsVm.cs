using System.Globalization;

namespace My.Bom.Software.ViewModels
{
    public class MachineDetailsVm
    {
        public int MachineId { get; set; }
        public int DetailId { get; set; }

		public string Machine { get; set; }
		public string Detail { get; set; }
		public int Qty { get; set; }
		public decimal Price { get; set; }

        public decimal TotalPrice => Price * Qty;

        public string PriceStr => TotalPrice.ToString("c", new CultureInfo("nl-BE"));

        public string UnSign => "Remove";

        public string BtnQty => "Set Qty";
        public string Remark { get; set; }
        public string Material { get; set; }
    }
}
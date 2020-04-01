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
		public int Price { get; set; }

        public string PriceStr => Price.ToString("c", new CultureInfo("nl-BE"));

        public string BtnQty => "Set Qty";
    }
}
using System.Globalization;

namespace My.Bom.Software.ViewModels
{
    class MachineDetailsVm
    {
		public string Machine { get; set; }
		public string Detail { get; set; }
		public int Qty { get; set; }
		public int Price { get; set; }

        public string PriceStr => Price.ToString("c", new CultureInfo("nl-BE"));
    }
}
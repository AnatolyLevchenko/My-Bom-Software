using My.Bom.Software.Domain;
using System;
using System.Globalization;

namespace My.Bom.Software.ViewModels
{
    public class PriceHistoryVm
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public int Operation { get; set; }

        public string OperationValue => Enum.GetName(typeof(Operation), Operation);
        public string PriceStr => Price.ToString("c", new CultureInfo("nl-BE"));
    }
}

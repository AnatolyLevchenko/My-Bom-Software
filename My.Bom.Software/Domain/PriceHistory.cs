using System;

namespace My.Bom.Software.Domain
{
    public class PriceHistory:BaseEntity
    {
        public int DetailId { get; set; }
        public decimal Price { get; set; }
        public Operation Operation { get; set; }
        public DateTime Date { get; set; }
    }
}

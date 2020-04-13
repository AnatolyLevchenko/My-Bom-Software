using System.ComponentModel;

namespace My.Bom.Software.Domain
{
    public class Detail : BaseEntity
    {
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public decimal? Price { get; set; }
        public string Remark { get; set; }
        public string Material { get; set; }
        public double Length { get; set; }

        [Description("ignore")]
        public bool Checked { get; set; }


        protected bool Equals(Detail other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Detail)obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
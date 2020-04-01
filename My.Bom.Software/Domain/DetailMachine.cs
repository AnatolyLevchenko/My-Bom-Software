namespace My.Bom.Software.Domain
{
    public class DetailMachine:BaseEntity
    {
        public int MachineId { get; set; }
        public int DetailId { get; set; }
        public int Qty { get; set; }
    }
}

﻿namespace My.Bom.Software.Domain
{
    public class Detail : BaseEntity
    {
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public decimal? Price { get; set; }
    }
}
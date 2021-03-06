﻿using System;
using System.ComponentModel;

namespace My.Bom.Software.Domain
{
    public class Machine:BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public bool Deleted { get; set; }


        protected bool Equals(Machine other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Machine) obj);
        }

        [Description("ignore")]
        public int Number { get; set; }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}

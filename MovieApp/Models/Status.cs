using System;
using System.Collections.Generic;

namespace MovieApp.Models
{
    public partial class Status
    {
        public Status()
        {
            this.Episodes = new List<Episode>();
            this.Features = new List<Feature>();
            this.Features1 = new List<Feature>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Feature> Features1 { get; set; }
    }
}

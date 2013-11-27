using System;
using System.Collections.Generic;

namespace MovieApp.Models
{
    public partial class Actor
    {
        public Actor()
        {
            this.Features = new List<Feature>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MovieApp.Models
{
    public partial class Episode
    {
        public int id { get; set; }
        public int movie_id { get; set; }
        public int status_id { get; set; }
        public Nullable<int> season { get; set; }
        public Nullable<int> episode1 { get; set; }
        public Nullable<int> title { get; set; }
        public string plot { get; set; }
        public Nullable<decimal> rating { get; set; }
        public string imdb_id { get; set; }
        public Nullable<int> my_rating { get; set; }
        public Nullable<bool> on_disk { get; set; }
        public string file_path { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual Status Status { get; set; }
    }
}

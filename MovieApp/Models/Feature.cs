using System;
using System.Collections.Generic;

namespace MovieApp.Models
{
    public partial class Feature
    {
        public Feature()
        {
            this.Episodes = new List<Episode>();
            this.Actors1 = new List<Actor>();
            this.Genres = new List<Genre>();
        }

        public int id { get; set; }
        public int my_status_id { get; set; }
        public int feature_status_id { get; set; }
        public int type_id { get; set; }
        public string title { get; set; }
        public Nullable<int> year { get; set; }
        public string run_time { get; set; }
        public string genre { get; set; }
        public string director { get; set; }
        public string actors { get; set; }
        public string plot { get; set; }
        public string poster_url { get; set; }
        public Nullable<decimal> rating { get; set; }
        public string imdb_id { get; set; }
        public Nullable<int> my_rating { get; set; }
        public Nullable<bool> on_disk { get; set; }
        public string file_path { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual Status Status { get; set; }
        public virtual Status Status1 { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<Actor> Actors1 { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}

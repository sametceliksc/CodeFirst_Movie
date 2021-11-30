using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Movie_CodeFirst.ORM.Entity
{
    public class Movie:BaseEntity
    {
        public string MovieName { get; set; }
        public DateTime DisplayDate { get; set; }
        public decimal  Revenue { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Director> Directors { get; set; }


    }
}

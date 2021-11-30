using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Movie_CodeFirst.ORM.Entity
{
     public class Actor:BaseEntity
    {
        public string ActorName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Movie_CodeFirst.ORM.Entity
{
   public class Director:BaseEntity
    {
        public string  DirectorName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}

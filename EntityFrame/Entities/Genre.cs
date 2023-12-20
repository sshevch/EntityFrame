using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame.Entities
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Description { get; set; }
        public List<Manga> Mangas { get; set; }
    }
}

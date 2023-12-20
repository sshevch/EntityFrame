using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame.Entities
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public List<Manga> Mangas { get; set; }
    }
}

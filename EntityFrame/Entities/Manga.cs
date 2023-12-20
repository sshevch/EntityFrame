using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame.Entities
{
    public class Manga
    {
        public int MangaID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public DateTime PublicationDate { get; set; }
        public int GenreID { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

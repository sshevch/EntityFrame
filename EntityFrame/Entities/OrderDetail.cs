using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrame.Entities
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int MangaID { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerItem { get; set; }

        public Order Order { get; set; }
        public Manga Manga { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }   
        public string ProductImg { get; set; }
        public int? ProductOrder { get; set; }
        public decimal ProductOldPrice { get; set; }
        public DateTime ProductDate { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<BestSeller>? BestSeller { get; set; }
        public List<Comment>? Comment { get; set; }


    }
}

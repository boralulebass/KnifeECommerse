using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool CommentStatus { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}

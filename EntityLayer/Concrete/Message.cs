using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageText { get; set; }
        public string MessageEmail { get; set; }
        public DateTime MessageDate { get; set; }
    }
}

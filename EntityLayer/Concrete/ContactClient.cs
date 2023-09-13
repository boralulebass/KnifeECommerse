using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class ContactClient
	{
        public int ContactClientID { get; set; }
		public string Description { get; set; }
		public string EmailAddress { get; set; }
		public DateTime? Date { get; set; }
    }
}

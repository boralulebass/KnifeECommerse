﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class BestSeller
	{
        public int BestSellerID { get; set; }
		public int ProductID { get; set; }
		public Product Product { get; set; }
    }
}

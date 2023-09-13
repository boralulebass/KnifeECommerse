namespace KnifeECommerse.Models
{
    public class ResultProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImg { get; set; }
        public int? ProductOrder { get; set; }
        public decimal? ProductOldPrice { get; set; }
        public DateTime ProductDate { get; set; }
        public int CategoryID { get; set; }
    }
}

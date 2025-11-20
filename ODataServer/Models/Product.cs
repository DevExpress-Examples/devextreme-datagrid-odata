using System.ComponentModel.DataAnnotations;

namespace ODataServer.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }
        public string? Product_Name { get; set; }
        public bool Product_Available { get; set; }
        public int Product_Current_Inventory { get; set; }
        public string? Product_Cost { get; set; }
        public string? Product_Sale_Price { get; set; }
        public string? Product_Retail_Price { get; set; }
        public double Product_Consumer_Rating { get; set; }
        public string? Product_Category { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Product
    {
        [Key]    public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public Category ProductCategory { get; set; }
    }

    public class Category
    {
        [Key]  public int CatID { get; set; } 
        public string CategoryName { get; set; }
        
        public string CategoryDescription { get; set; }


    }
}

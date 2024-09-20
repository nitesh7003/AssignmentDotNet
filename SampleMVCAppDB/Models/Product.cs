using System.ComponentModel.DataAnnotations;

namespace SampleMVCAppDB.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }  // Primary key, no validation needed

        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Product Name must be between 2 and 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 10000.00, ErrorMessage = "Price must be between 0.01 and 10,000")]
        public decimal Price { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string Description { get; set; }
    }
}

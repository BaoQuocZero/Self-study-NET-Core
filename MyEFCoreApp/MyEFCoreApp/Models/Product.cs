using System.ComponentModel.DataAnnotations;

namespace MyEFCoreApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)] // Giới hạn độ dài tối đa là 255 ký tự
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
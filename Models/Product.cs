using System.ComponentModel.DataAnnotations;

namespace TKPM.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        // Đường dẫn ảnh sản phẩm
        public string ImageUrl { get; set; } = "/images/default.png";

        // Thuộc tính chỉ quản trị viên nhập
        public string? Gift { get; set; } // Cho phép null nếu không bắt buộc
    }
}

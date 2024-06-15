using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category name")]
        public string Name { get; set; }
        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }
    }
}

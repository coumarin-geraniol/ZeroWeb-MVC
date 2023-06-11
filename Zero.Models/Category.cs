using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zero.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [Required]

        [DisplayName("Kategori Adı")]
        [MaxLength(30)]
        public string Name { get; set; }

        [DisplayName("Görüntüleme Sırası")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Zero.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık gereklidir.")]
        [MaxLength(30)]
        [DisplayName("Başlık")]
        public string Title { get; set; }

        public string Description { get; set; }

        [MaxLength(30)]
        public string ISBN { get; set; }

        [MaxLength(80)]
        [DisplayName("Yazar")]
        public string Author { get; set; }

        [DisplayName("Adet Fiyat")]
        [Range(1, 1000, ErrorMessage = "Liste Fiyatı 1 ile 1000 arasında olmalıdır.")]
        public int ListPrice { get; set; }

        [DisplayName("1-50 tane arasi sipariş edilen kitap için Fiyat")]
        [Range(1, 1000, ErrorMessage = "1-50 için Fiyat 1 ile 1000 arasında olmalıdır.")]
        public int Price { get; set; }

        [DisplayName("50'den fazla sipariş edilen kitap için Fiyat")]
        [Range(1, 1000, ErrorMessage = "50+'lık Fiyat 1 ile 1000 arasında olmalıdır.")]
        public int Price50 { get; set; }

        [DisplayName("Kategori")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [ValidateNever]
        [DisplayName("Resim")]
        public string ImageUrl { get; set; }

    }
}

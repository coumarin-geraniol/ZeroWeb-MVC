using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Adı Soyadı")]
        public string Name { get; set; }

        [DisplayName("Cadde Adresi")]
        public string? StreetAddress { get; set; }

        [DisplayName("İl")]
        public string? State { get; set; }

        [Phone]
        [Display(Name = "Telefon Numarası")]
        public string? PhoneNumber { get; set; }

    }
}

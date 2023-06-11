using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]

        [DisplayName("Kullanıcı İsmi")]
        public string Name { get; set; }

        [DisplayName("Cadde/Sokak Adresi")]
        public string? StreetAddress { get; set; }

        [DisplayName("İl")]
        public string? State { get; set; }

        [DisplayName("Şirket ID")]
        public int? CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        [ValidateNever]
        [DisplayName("Şirket")]
        public Company? Company { get; set; }

        [NotMapped]
        [DisplayName("Rol")]
        public string Role { get; set; }

    }
}

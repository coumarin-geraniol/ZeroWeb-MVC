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
    public class OrderHeader
    {
        public int Id { get; set; }

        [DisplayName("Kullanıcı Kimlik Numarası")]
        public string ApplicationUserId { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        [DisplayName("Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }

        [DisplayName("Kargo Tarihi")]
        public DateTime ShippingDate { get; set; }

        [DisplayName("Sipariş Toplamı")]
        public double OrderTotal { get; set; }

        [DisplayName("Sipariş Durumu")]
        public string? OrderStatus { get; set; }

        [DisplayName("Ödeme Durumu")]
        public string? PaymentStatus { get; set; }

        [DisplayName("Takip Numarası")]
        public string? TrackingNumber { get; set; }

        [DisplayName("Kargo Şirketi")]
        public string? Carrier { get; set; }

        [DisplayName("Ödeme Tarihi")]
        public DateTime PaymentDate { get; set; }

        [DisplayName("Ödeme Son Tarihi")]
        public DateTime PaymentDueDate { get; set; }

        [DisplayName("Oturum Kimliği")]
        public string? SessionId { get; set; }

        [DisplayName("Ödeme Talep Kimliği")]
        public string? PaymentIntentId { get; set; }

        [Required(ErrorMessage = "Telefon Numarası gereklidir.")]
        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Cadde Adresi gereklidir.")]
        [DisplayName("Cadde Adresi")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "İl gereklidir.")]
        [DisplayName("İl")]
        public string State { get; set; }
      
        [Required(ErrorMessage = "Ad gereklidir.")]
        [DisplayName("Ad")]
        public string Name { get; set; }


    }
}

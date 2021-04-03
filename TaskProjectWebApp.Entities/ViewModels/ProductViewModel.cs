using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TaskProjectWebApp.Entities.Concrete;

namespace TaskProjectWebApp.Models
{
    public class ProductViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [HiddenInput]
        public int CategoryId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }

        
        [DisplayName("Açıklama")]
        public string Description { get; set; }
    }
}

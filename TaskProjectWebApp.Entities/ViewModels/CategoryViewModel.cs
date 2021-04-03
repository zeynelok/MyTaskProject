using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TaskProjectWebApp.Entities.Concrete;

namespace TaskProjectWebApp.Entities.ViewModels
{
    public class CategoryViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }

     
       
        [DisplayName("Açıklama")]
        public string Description { get; set; }
    }
}

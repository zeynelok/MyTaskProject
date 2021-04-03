using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TaskProjectWebApp.Entities.Concrete
{
    public class Product
    {

        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Fİyatı")]
        public decimal Price { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Eklenme Tarihi")]
        public DateTime CreateDate { get; set; }
       
        public int CategoryId { get; set; }
    }
}

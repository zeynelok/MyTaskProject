using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.DataAccess.Concrete.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = _ids[0], Name = "Yüzüklerin Efendisi", Description = "Yüzüğün Büyüsü", Price = 15, CreateDate = DateTime.Now, CategoryId = 1 },

             new Product { Id = _ids[1], Name = "Hobbit", Description = "Ejderhanın Hazinesi", Price = 15, CreateDate = DateTime.Now, CategoryId = 1 },

             new Product { Id = _ids[2], Name = "Alice Harikalar Diyarında", Description = "Alice'in Maceraları", Price = 15, CreateDate = DateTime.Now, CategoryId = 1 },



             new Product { Id = _ids[3], Name = "Buz Dolabı", Description = "Çift Kapılı", Price = 10000, CreateDate = DateTime.Now, CategoryId = 2 },

              new Product { Id = _ids[4], Name = "Çamaşır Makinesi", Description = "9 Kg Kapasiteli", Price = 7000, CreateDate = DateTime.Now, CategoryId = 2 },

               new Product { Id = _ids[5], Name = "Bulaşık Makinesi", Description = "Su Tasarruflu", Price = 5000, CreateDate = DateTime.Now, CategoryId = 2 },



                new Product { Id = _ids[6], Name = "Tişört", Description = "Desenli", Price = 20, CreateDate = DateTime.Now, CategoryId = 3 },

                new Product { Id = _ids[7], Name = "Kazak", Description = "%100 Yün", Price = 100, CreateDate = DateTime.Now, CategoryId = 3 },

                 new Product { Id = _ids[8], Name = "Gömlek", Description = "Oduncu Gömleği", Price = 60, CreateDate = DateTime.Now, CategoryId = 3 }
         );
        }


    }
}

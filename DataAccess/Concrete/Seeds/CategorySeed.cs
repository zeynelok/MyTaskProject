using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.DataAccess.Concrete.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = _ids[0], Name = "Kitap", Description = "Kitap Kategorisi Açıklaması", CreateDate = DateTime.Now },

             new Category { Id = _ids[1], Name = "Beyaz Eşya", Description = "Beyaz Eşya Kategorisi Açıklaması",  CreateDate = DateTime.Now},

             new Category { Id = _ids[2], Name = "Giyim", Description = "Giyim Kategorisi Açıklaması",  CreateDate = DateTime.Now}
             
         );
        }


    }
}

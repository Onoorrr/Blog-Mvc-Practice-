using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("E254375B-48F8-4E57-9B49-3F1664EC14AE"),
                Name = "Test",
                CreatedBy = "Onur",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {


                Id = Guid.Parse("0CA6F76F-FC1C-4C77-B688-BD76EFAD6082"),
                Name = "Test2",
                CreatedBy = "Onur",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }
            );

        }
    }
}

using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Image> builder)
        {
            builder.HasData
                (
                new Image
                {
                    Id = Guid.Parse("1DF68064-F397-4711-A73D-66FE21CD4060"),
                    FileName = "Test",
                    FileType = "jpg",
                    CreatedBy = "Onur",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false

                },
                   new Image
                 {
                     Id = Guid.Parse("5995A9B0-A15B-4882-8CE5-44E3847B8BD1"),
                     FileName = "Test2",
                     FileType = "jpg",
                     CreatedBy = "Onur",
                     CreatedDate = DateTime.Now,
                     IsDeleted = false
                 }
                );
        }
    }
}

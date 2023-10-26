using Blog.Core.Entities;
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
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            #region
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 1",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. " +
                "Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo." +
                " Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum." +
                " Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus." +
                " Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi." +
                " Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.",
                ViewCount = 15,
                CategoryId = Guid.Parse("E254375B-48F8-4E57-9B49-3F1664EC14AE"),               
                ImageId = Guid.Parse("1DF68064-F397-4711-A73D-66FE21CD4060"),
                CreatedBy = "Onur",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Article
            {

                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi 2",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. " +
                "Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo." +
                " Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum." +
                " Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus." +
                " Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi." +
                " Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.",
                ViewCount = 15,
                CategoryId = Guid.Parse("0CA6F76F-FC1C-4C77-B688-BD76EFAD6082"),               
                ImageId = Guid.Parse("5995A9B0-A15B-4882-8CE5-44E3847B8BD1"),
                CreatedBy = "Onur",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }

            ); ;; ;

        }
        #endregion
    }
}

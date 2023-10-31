﻿using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) // Model oluşturulmadan önce ayarlama yapılmasını sağlar.
        {
            //builder.Entity<Article>().Property(x => x.Title).HasMaxLength(150); Bu kodla her birinin özelliklerini tek tek değiştirebiliyoruz fakat hepsi için alttaki kodu kullanırız.
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Bu, veritabanımızı modelinizi kod tabanlı olarak yapılandırmak ve güncellemek için kullanılar bir yöntemdir.
        }

    }
}

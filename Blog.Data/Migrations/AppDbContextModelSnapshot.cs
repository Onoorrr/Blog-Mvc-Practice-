﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("53a5d1e7-0fcf-4719-8cbd-8268228a81da"),
                            CategoryId = new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"),
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo. Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum. Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus. Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi. Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.",
                            CreatedBy = "Onur",
                            CreatedDate = new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(5762),
                            ImageId = new Guid("1df68064-f397-4711-a73d-66fe21cd4060"),
                            IsDeleted = false,
                            Title = "Asp.net Core Deneme Makalesi 1",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("90bd1df0-5562-4c98-8eed-210839d1c6e1"),
                            CategoryId = new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"),
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio ac justo suscipit suscipit in id tortor. Sed euismod ultrices purus, id commodo nisi. Maecenas sed luctus mi. Phasellus auctor vestibulum ante, nec consectetur justo. Sed fermentum vehicula tortor, et egestas velit auctor eu. Donec nec efficitur turpis. Sed sollicitudin est at eros viverra, non tristique elit dictum. Aliquam convallis, lectus a condimentum dapibus, metus neque sagittis purus, eget gravida libero mauris et purus. Vivamus cursus, lectus vel malesuada feugiat, metus orci pharetra velit, vel hendrerit turpis tortor non mi. Nullam sem dolor, viverra ut tincidunt id, dignissim ac justo. Etiam non felis a tellus varius pulvinar.",
                            CreatedBy = "Onur",
                            CreatedDate = new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(5772),
                            ImageId = new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"),
                            IsDeleted = false,
                            Title = "Asp.net Core Deneme Makalesi 2",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e254375b-48f8-4e57-9b49-3f1664ec14ae"),
                            CreatedBy = "Onur",
                            CreatedDate = new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6125),
                            IsDeleted = false,
                            Name = "Test"
                        },
                        new
                        {
                            Id = new Guid("0ca6f76f-fc1c-4c77-b688-bd76efad6082"),
                            CreatedBy = "Onur",
                            CreatedDate = new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6130),
                            IsDeleted = false,
                            Name = "Test2"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1df68064-f397-4711-a73d-66fe21cd4060"),
                            CreatedBy = "Onur",
                            CreatedDate = new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6457),
                            FileName = "Test",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("5995a9b0-a15b-4882-8ce5-44e3847b8bd1"),
                            CreatedBy = "Onur",
                            CreatedDate = new DateTime(2023, 10, 26, 17, 47, 21, 50, DateTimeKind.Local).AddTicks(6461),
                            FileName = "Test2",
                            FileType = "jpg",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}

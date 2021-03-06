﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PlaceIMG.Data.Models.Context;

namespace PlaceIMG.Data.Migrations
{
    [DbContext(typeof(ImageContext))]
    [Migration("20210113122833_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("PlaceIMG.Data.Models.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("CatName")
                        .HasColumnType("text");

                    b.Property<int>("TopCatID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PlaceIMG.Data.Models.Entities.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("CatID")
                        .HasColumnType("integer");

                    b.Property<string>("ImgPath")
                        .HasColumnType("text");

                    b.Property<double>("Ratio")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.HasIndex("CatID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("PlaceIMG.Data.Models.Entities.Image", b =>
                {
                    b.HasOne("PlaceIMG.Data.Models.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CatID");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

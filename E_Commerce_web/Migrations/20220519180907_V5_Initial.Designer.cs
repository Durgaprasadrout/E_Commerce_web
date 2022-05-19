﻿// <auto-generated />
using E_Commerce_web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce_web.Migrations
{
    [DbContext(typeof(CategoryContext))]
    [Migration("20220519180907_V5_Initial")]
    partial class V5_Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce_web.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("Varchar(300)");

                    b.HasKey("categoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("E_Commerce_web.Models.Customers", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("deliveryAddress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("emailAddress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("customerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("E_Commerce_web.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderDate")
                        .HasColumnType("int");

                    b.Property<double>("ShipDate")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_Commerce_web.Models.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<int>("ModelNumber")
                        .HasColumnType("int");

                    b.Property<double>("Unitcost")
                        .HasColumnType("float");

                    b.HasKey("ProductsId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
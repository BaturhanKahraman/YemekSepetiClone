﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YemekSepetiClone.DataAccess.Concrete.EntityFrameworkCore.Context;

namespace YemekSepetiClone.Migrations
{
    [DbContext(typeof(YemekSepetiContext))]
    partial class YemekSepetiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YemekSepetiClone.Models.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BasketId")
                        .HasColumnType("int");

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("MealId");

                    b.ToTable("BasketItem");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BasketId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryMethod")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShopId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.User.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.User.Customer", b =>
                {
                    b.HasBaseType("YemekSepetiClone.Models.User.User");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.User.Shop", b =>
                {
                    b.HasBaseType("YemekSepetiClone.Models.User.User");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.BasketItem", b =>
                {
                    b.HasOne("YemekSepetiClone.Models.Basket", null)
                        .WithMany("BasketItems")
                        .HasForeignKey("BasketId");

                    b.HasOne("YemekSepetiClone.Models.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.Category", b =>
                {
                    b.HasOne("YemekSepetiClone.Models.User.Shop", null)
                        .WithMany("Categories")
                        .HasForeignKey("ShopId");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.Meal", b =>
                {
                    b.HasOne("YemekSepetiClone.Models.Category", "Category")
                        .WithMany("Meals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.Order", b =>
                {
                    b.HasOne("YemekSepetiClone.Models.Basket", "Basket")
                        .WithMany()
                        .HasForeignKey("BasketId");

                    b.HasOne("YemekSepetiClone.Models.User.Customer", null)
                        .WithMany("GivenOrders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("YemekSepetiClone.Models.User.Shop", null)
                        .WithMany("RecievedOrders")
                        .HasForeignKey("ShopId");

                    b.Navigation("Basket");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.User.Customer", b =>
                {
                    b.HasOne("YemekSepetiClone.Models.User.User", null)
                        .WithOne()
                        .HasForeignKey("YemekSepetiClone.Models.User.Customer", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YemekSepetiClone.Models.User.Shop", b =>
                {
                    b.HasOne("YemekSepetiClone.Models.User.User", null)
                        .WithOne()
                        .HasForeignKey("YemekSepetiClone.Models.User.Shop", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YemekSepetiClone.Models.Basket", b =>
                {
                    b.Navigation("BasketItems");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.Category", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.User.Customer", b =>
                {
                    b.Navigation("GivenOrders");
                });

            modelBuilder.Entity("YemekSepetiClone.Models.User.Shop", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("RecievedOrders");
                });
#pragma warning restore 612, 618
        }
    }
}

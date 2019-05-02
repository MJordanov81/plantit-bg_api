﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Api.Data.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20181022183031_PArtnerIndexProperty")]
    partial class PArtnerIndexProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.Domain.Entities.CarouselItem", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(500);

                    b.Property<string>("Heading")
                        .HasMaxLength(150);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("CarouselItems");
                });

            modelBuilder.Entity("Api.Domain.Entities.Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Api.Domain.Entities.CategoryProduct", b =>
                {
                    b.Property<string>("CategoryId");

                    b.Property<string>("ProductId");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoryProducts");
                });

            modelBuilder.Entity("Api.Domain.Entities.CustomerData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CustomerData");
                });

            modelBuilder.Entity("Api.Domain.Entities.DeliveryData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments")
                        .HasMaxLength(2500);

                    b.Property<string>("CustomerDataId")
                        .IsRequired();

                    b.Property<bool>("DeliveredToAnOffice");

                    b.Property<string>("HomeDeliveryDataId");

                    b.Property<string>("OfficeDeliveryDataId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerDataId");

                    b.HasIndex("HomeDeliveryDataId");

                    b.HasIndex("OfficeDeliveryDataId");

                    b.ToTable("DeliveryData");
                });

            modelBuilder.Entity("Api.Domain.Entities.DiscountedProductPromotion", b =>
                {
                    b.Property<string>("ProductId");

                    b.Property<string>("PromotionId");

                    b.HasKey("ProductId", "PromotionId");

                    b.HasIndex("PromotionId");

                    b.ToTable("DiscountedProductsPromotions");
                });

            modelBuilder.Entity("Api.Domain.Entities.HomeContent", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArticleContent")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("ArticleHeading")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("SectionContent")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("SectionHeading")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("HomeContent");
                });

            modelBuilder.Entity("Api.Domain.Entities.HomeDeliveryData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apartment")
                        .HasMaxLength(10);

                    b.Property<string>("Block")
                        .HasMaxLength(10);

                    b.Property<string>("City")
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .HasMaxLength(100);

                    b.Property<string>("District")
                        .HasMaxLength(100);

                    b.Property<string>("Entrance")
                        .HasMaxLength(10);

                    b.Property<string>("Floor")
                        .HasMaxLength(10);

                    b.Property<string>("PostCode")
                        .HasMaxLength(4);

                    b.Property<string>("Street")
                        .HasMaxLength(100);

                    b.Property<string>("StreetNumber")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("HomeDeliveryData");
                });

            modelBuilder.Entity("Api.Domain.Entities.Image", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<string>("ProductId");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Api.Domain.Entities.InvoiceData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("InvoiceData");
                });

            modelBuilder.Entity("Api.Domain.Entities.News", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(5000);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Api.Domain.Entities.Numerator", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderCurrentValue");

                    b.Property<int>("ProductCurrentValue");

                    b.HasKey("Id");

                    b.ToTable("Numerator");
                });

            modelBuilder.Entity("Api.Domain.Entities.OfficeDeliveryData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<string>("City")
                        .HasMaxLength(150);

                    b.Property<string>("Code");

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("OfficeDeliveryData");
                });

            modelBuilder.Entity("Api.Domain.Entities.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeliveryDataId")
                        .IsRequired();

                    b.Property<string>("InvoiceDataId");

                    b.Property<bool>("IsConfirmationMailSent");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<int>("Number");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasAlternateKey("Number");

                    b.HasIndex("DeliveryDataId");

                    b.HasIndex("InvoiceDataId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Api.Domain.Entities.OrderLog", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("OrderId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderLogs");
                });

            modelBuilder.Entity("Api.Domain.Entities.Partner", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Index");

                    b.Property<string>("LogoUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("WebUrl");

                    b.HasKey("Id");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("Api.Domain.Entities.PartnerLocation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PartnerId");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.ToTable("PartnerLocations");
                });

            modelBuilder.Entity("Api.Domain.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<bool>("IsBlocked");

                    b.Property<bool>("IsTopSeller");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Number");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasAlternateKey("Number");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductOrder", b =>
                {
                    b.Property<string>("ProductId");

                    b.Property<string>("OrderId");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductPromoDiscount", b =>
                {
                    b.Property<string>("ProductId");

                    b.Property<string>("PromoDiscountId");

                    b.HasKey("ProductId", "PromoDiscountId");

                    b.HasIndex("PromoDiscountId");

                    b.ToTable("ProductPromoDiscounts");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductPromotion", b =>
                {
                    b.Property<string>("ProductId");

                    b.Property<string>("PromotionId");

                    b.HasKey("ProductId", "PromotionId");

                    b.HasIndex("PromotionId");

                    b.ToTable("ProductsPromotions");
                });

            modelBuilder.Entity("Api.Domain.Entities.PromoDiscount", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Discount");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("PromoDiscounts");
                });

            modelBuilder.Entity("Api.Domain.Entities.Promotion", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Discount");

                    b.Property<int>("DiscountedProductsCount");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IncludePriceDiscounts");

                    b.Property<bool>("IsAccumulative");

                    b.Property<bool>("IsInclusive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("ProductsCount");

                    b.Property<string>("PromoCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Quota");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("UsedQuota");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("Api.Domain.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Api.Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<string>("PasswordHash")
                        .IsRequired();

                    b.Property<string>("RoleId");

                    b.Property<string>("Surname")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Api.Domain.Entities.Video", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Index");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("Api.Domain.Entities.CategoryProduct", b =>
                {
                    b.HasOne("Api.Domain.Entities.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Domain.Entities.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Api.Domain.Entities.DeliveryData", b =>
                {
                    b.HasOne("Api.Domain.Entities.CustomerData", "CustomerData")
                        .WithMany()
                        .HasForeignKey("CustomerDataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Domain.Entities.HomeDeliveryData", "HomeDeliveryData")
                        .WithMany()
                        .HasForeignKey("HomeDeliveryDataId");

                    b.HasOne("Api.Domain.Entities.OfficeDeliveryData", "OfficeDeliveryData")
                        .WithMany()
                        .HasForeignKey("OfficeDeliveryDataId");
                });

            modelBuilder.Entity("Api.Domain.Entities.DiscountedProductPromotion", b =>
                {
                    b.HasOne("Api.Domain.Entities.Product", "Product")
                        .WithMany("DiscountedProductsPromotions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Domain.Entities.Promotion", "Promotion")
                        .WithMany("DiscountedProductsPromotions")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Api.Domain.Entities.Image", b =>
                {
                    b.HasOne("Api.Domain.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Api.Domain.Entities.Order", b =>
                {
                    b.HasOne("Api.Domain.Entities.DeliveryData", "DeliveryData")
                        .WithMany()
                        .HasForeignKey("DeliveryDataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Domain.Entities.InvoiceData", "InvoiceData")
                        .WithMany()
                        .HasForeignKey("InvoiceDataId");

                    b.HasOne("Api.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Api.Domain.Entities.OrderLog", b =>
                {
                    b.HasOne("Api.Domain.Entities.Order", "Order")
                        .WithMany("OrderLogs")
                        .HasForeignKey("OrderId");

                    b.HasOne("Api.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Api.Domain.Entities.PartnerLocation", b =>
                {
                    b.HasOne("Api.Domain.Entities.Partner", "Partner")
                        .WithMany("PartnerLocations")
                        .HasForeignKey("PartnerId");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductOrder", b =>
                {
                    b.HasOne("Api.Domain.Entities.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Domain.Entities.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductPromoDiscount", b =>
                {
                    b.HasOne("Api.Domain.Entities.Product", "Product")
                        .WithMany("ProductPromoDiscounts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Domain.Entities.PromoDiscount", "PromoDiscount")
                        .WithMany("ProductPromoDiscounts")
                        .HasForeignKey("PromoDiscountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductPromotion", b =>
                {
                    b.HasOne("Api.Domain.Entities.Product", "Product")
                        .WithMany("ProductsPromotions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Api.Domain.Entities.Promotion", "Promotion")
                        .WithMany("ProductsPromotions")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Api.Domain.Entities.User", b =>
                {
                    b.HasOne("Api.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}

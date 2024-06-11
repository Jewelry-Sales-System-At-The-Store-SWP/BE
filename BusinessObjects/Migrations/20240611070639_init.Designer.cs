﻿// <auto-generated />
using System;
using BusinessObjects.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObjects.Migrations
{
    [DbContext(typeof(JssatsContext))]
    [Migration("20240611070639_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObjects.Models.Bill", b =>
                {
                    b.Property<string>("BillId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("CounterId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<DateTime?>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(20)");

                    b.HasKey("BillId");

                    b.HasIndex("CounterId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("BusinessObjects.Models.BillJewelry", b =>
                {
                    b.Property<string>("BillJewelryId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("BillId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("JewelryId")
                        .HasColumnType("NVARCHAR(20)");

                    b.HasKey("BillJewelryId");

                    b.HasIndex("BillId");

                    b.HasIndex("JewelryId");

                    b.ToTable("BillJewelries");
                });

            modelBuilder.Entity("BusinessObjects.Models.BillPromotion", b =>
                {
                    b.Property<string>("BillPromotionId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("BillId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("PromotionId")
                        .HasColumnType("NVARCHAR(20)");

                    b.HasKey("BillPromotionId");

                    b.HasIndex("BillId");

                    b.HasIndex("PromotionId");

                    b.ToTable("BillPromotions");
                });

            modelBuilder.Entity("BusinessObjects.Models.Counter", b =>
                {
                    b.Property<string>("CounterId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.HasKey("CounterId");

                    b.ToTable("Counters");
                });

            modelBuilder.Entity("BusinessObjects.Models.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Point")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BusinessObjects.Models.GoldPrice", b =>
                {
                    b.Property<string>("GoldPriceId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<float>("BuyPrice")
                        .HasColumnType("real");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<float>("SellPrice")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoldPriceId");

                    b.ToTable("GoldPrices");
                });

            modelBuilder.Entity("BusinessObjects.Models.Jewelry", b =>
                {
                    b.Property<string>("JewelryId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsSold")
                        .HasColumnType("bit");

                    b.Property<string>("JewelryTypeId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<double?>("LaborCost")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JewelryId");

                    b.HasIndex("JewelryTypeId");

                    b.ToTable("Jewelries");
                });

            modelBuilder.Entity("BusinessObjects.Models.JewelryMaterial", b =>
                {
                    b.Property<string>("JewelryMaterialId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GoldPriceId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<float>("GoldQuantity")
                        .HasColumnType("real");

                    b.Property<string>("JewelryId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("StonePriceId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<float>("StoneQuantity")
                        .HasColumnType("real");

                    b.HasKey("JewelryMaterialId");

                    b.HasIndex("GoldPriceId");

                    b.HasIndex("JewelryId");

                    b.HasIndex("StonePriceId");

                    b.ToTable("JewelryMaterials");
                });

            modelBuilder.Entity("BusinessObjects.Models.JewelryType", b =>
                {
                    b.Property<string>("JewelryTypeId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JewelryTypeId");

                    b.ToTable("JewelryTypes");
                });

            modelBuilder.Entity("BusinessObjects.Models.MasterPrice", b =>
                {
                    b.Property<string>("MasterPriceId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("GoldPriceId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<float>("GoldStorePrice")
                        .HasColumnType("real");

                    b.Property<string>("StonePriceId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<float>("StoneStorePrice")
                        .HasColumnType("real");

                    b.HasKey("MasterPriceId");

                    b.HasIndex("GoldPriceId");

                    b.HasIndex("StonePriceId");

                    b.ToTable("MasterPrices");
                });

            modelBuilder.Entity("BusinessObjects.Models.Promotion", b =>
                {
                    b.Property<string>("PromotionId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("ApproveManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("DiscountRate")
                        .HasColumnType("float");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PromotionId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("BusinessObjects.Models.Purchase", b =>
                {
                    b.Property<string>("PurchaseId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<int?>("IsBuyBack")
                        .HasColumnType("int");

                    b.Property<string>("JewelryId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(20)");

                    b.HasKey("PurchaseId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("JewelryId");

                    b.HasIndex("UserId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("BusinessObjects.Models.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BusinessObjects.Models.StonePrice", b =>
                {
                    b.Property<string>("StonePriceId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<float>("BuyPrice")
                        .HasColumnType("real");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<float>("SellPrice")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StonePriceId");

                    b.ToTable("StonePrices");
                });

            modelBuilder.Entity("BusinessObjects.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("CounterId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CounterId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BusinessObjects.Models.Warranty", b =>
                {
                    b.Property<string>("WarrantyId")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JewelryId")
                        .HasColumnType("NVARCHAR(20)");

                    b.HasKey("WarrantyId");

                    b.HasIndex("JewelryId")
                        .IsUnique()
                        .HasFilter("[JewelryId] IS NOT NULL");

                    b.ToTable("Warranties");
                });

            modelBuilder.Entity("BusinessObjects.Models.Bill", b =>
                {
                    b.HasOne("BusinessObjects.Models.Counter", "Counter")
                        .WithMany("Bills")
                        .HasForeignKey("CounterId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Counter");

                    b.Navigation("Customer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Models.BillJewelry", b =>
                {
                    b.HasOne("BusinessObjects.Models.Bill", "Bill")
                        .WithMany("BillJewelries")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.Jewelry", "Jewelry")
                        .WithMany("BillJewelries")
                        .HasForeignKey("JewelryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Bill");

                    b.Navigation("Jewelry");
                });

            modelBuilder.Entity("BusinessObjects.Models.BillPromotion", b =>
                {
                    b.HasOne("BusinessObjects.Models.Bill", "Bill")
                        .WithMany("BillPromotions")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.Promotion", "Promotion")
                        .WithMany("BillPromotions")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Bill");

                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("BusinessObjects.Models.Jewelry", b =>
                {
                    b.HasOne("BusinessObjects.Models.JewelryType", "JewelryType")
                        .WithMany("Jewelries")
                        .HasForeignKey("JewelryTypeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("JewelryType");
                });

            modelBuilder.Entity("BusinessObjects.Models.JewelryMaterial", b =>
                {
                    b.HasOne("BusinessObjects.Models.GoldPrice", "GoldPrice")
                        .WithMany("JewelryMaterials")
                        .HasForeignKey("GoldPriceId");

                    b.HasOne("BusinessObjects.Models.Jewelry", "Jewelry")
                        .WithMany("JewelryMaterials")
                        .HasForeignKey("JewelryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.StonePrice", "StonePrice")
                        .WithMany("JewelryMaterials")
                        .HasForeignKey("StonePriceId");

                    b.Navigation("GoldPrice");

                    b.Navigation("Jewelry");

                    b.Navigation("StonePrice");
                });

            modelBuilder.Entity("BusinessObjects.Models.MasterPrice", b =>
                {
                    b.HasOne("BusinessObjects.Models.GoldPrice", "GoldPrice")
                        .WithMany("MasterPrices")
                        .HasForeignKey("GoldPriceId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.StonePrice", "StonePrice")
                        .WithMany("MasterPrices")
                        .HasForeignKey("StonePriceId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("GoldPrice");

                    b.Navigation("StonePrice");
                });

            modelBuilder.Entity("BusinessObjects.Models.Purchase", b =>
                {
                    b.HasOne("BusinessObjects.Models.Customer", "Customer")
                        .WithMany("Purchases")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.Jewelry", "Jewelry")
                        .WithMany("Purchases")
                        .HasForeignKey("JewelryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Customer");

                    b.Navigation("Jewelry");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Models.User", b =>
                {
                    b.HasOne("BusinessObjects.Models.Counter", "Counter")
                        .WithMany("Users")
                        .HasForeignKey("CounterId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("BusinessObjects.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Counter");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BusinessObjects.Models.Warranty", b =>
                {
                    b.HasOne("BusinessObjects.Models.Jewelry", "Jewelry")
                        .WithOne("Warranty")
                        .HasForeignKey("BusinessObjects.Models.Warranty", "JewelryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Jewelry");
                });

            modelBuilder.Entity("BusinessObjects.Models.Bill", b =>
                {
                    b.Navigation("BillJewelries");

                    b.Navigation("BillPromotions");
                });

            modelBuilder.Entity("BusinessObjects.Models.Counter", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BusinessObjects.Models.Customer", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("BusinessObjects.Models.GoldPrice", b =>
                {
                    b.Navigation("JewelryMaterials");

                    b.Navigation("MasterPrices");
                });

            modelBuilder.Entity("BusinessObjects.Models.Jewelry", b =>
                {
                    b.Navigation("BillJewelries");

                    b.Navigation("JewelryMaterials");

                    b.Navigation("Purchases");

                    b.Navigation("Warranty");
                });

            modelBuilder.Entity("BusinessObjects.Models.JewelryType", b =>
                {
                    b.Navigation("Jewelries");
                });

            modelBuilder.Entity("BusinessObjects.Models.Promotion", b =>
                {
                    b.Navigation("BillPromotions");
                });

            modelBuilder.Entity("BusinessObjects.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BusinessObjects.Models.StonePrice", b =>
                {
                    b.Navigation("JewelryMaterials");

                    b.Navigation("MasterPrices");
                });

            modelBuilder.Entity("BusinessObjects.Models.User", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
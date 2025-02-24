﻿// <auto-generated />
using System;
using DineGO_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DineGO_Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DineGO_Api.Model.Admin", b =>
                {
                    b.Property<int>("ad_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ad_id"));

                    b.Property<DateTime>("ad_birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("ad_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ad_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ad_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ad_password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ad_username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ad_id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("DineGO_Api.Model.Blog", b =>
                {
                    b.Property<int>("blog_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("blog_id"));

                    b.Property<DateTime>("blog_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("blog_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blog_information")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blog_title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("res_id")
                        .HasColumnType("int");

                    b.HasKey("blog_id");

                    b.HasIndex("res_id");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("DineGO_Api.Model.Category", b =>
                {
                    b.Property<int>("cate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cate_id"));

                    b.Property<string>("cate_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cate_type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("res_id")
                        .HasColumnType("int");

                    b.HasKey("cate_id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("DineGO_Api.Model.Customer", b =>
                {
                    b.Property<int>("cus_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cus_id"));

                    b.Property<string>("cus_address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("cus_birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("cus_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cus_gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cus_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cus_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("cus_password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("cus_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cus_username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("cus_id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("DineGO_Api.Model.Notification", b =>
                {
                    b.Property<int>("noti_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("noti_id"));

                    b.Property<int>("cus_id")
                        .HasColumnType("int");

                    b.Property<string>("noti_content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("noti_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("noti_status")
                        .HasColumnType("bit");

                    b.Property<string>("noti_title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("noti_type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("re_id")
                        .HasColumnType("int");

                    b.HasKey("noti_id");

                    b.HasIndex("cus_id");

                    b.HasIndex("re_id");

                    b.ToTable("notifications");
                });

            modelBuilder.Entity("DineGO_Api.Model.Reservation", b =>
                {
                    b.Property<int>("re_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("re_id"));

                    b.Property<int>("cus_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("re_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("re_note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("re_quantity")
                        .HasColumnType("int");

                    b.Property<string>("re_status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("res_id")
                        .HasColumnType("int");

                    b.HasKey("re_id");

                    b.HasIndex("cus_id");

                    b.HasIndex("res_id");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("DineGO_Api.Model.Restaurant", b =>
                {
                    b.Property<int>("res_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("res_id"));

                    b.Property<int>("cate_id")
                        .HasColumnType("int");

                    b.Property<string>("res_address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("res_discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("res_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("res_information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("res_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("res_password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("res_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("res_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("res_rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("res_type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("res_username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("res_id");

                    b.HasIndex("cate_id");

                    b.ToTable("restaurants");
                });

            modelBuilder.Entity("DineGO_Api.Model.Blog", b =>
                {
                    b.HasOne("DineGO_Api.Model.Restaurant", "restaurant")
                        .WithMany()
                        .HasForeignKey("res_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("restaurant");
                });

            modelBuilder.Entity("DineGO_Api.Model.Notification", b =>
                {
                    b.HasOne("DineGO_Api.Model.Customer", "customer")
                        .WithMany("notifications")
                        .HasForeignKey("cus_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DineGO_Api.Model.Reservation", "reservation")
                        .WithMany("notifications")
                        .HasForeignKey("re_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("reservation");
                });

            modelBuilder.Entity("DineGO_Api.Model.Reservation", b =>
                {
                    b.HasOne("DineGO_Api.Model.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("cus_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DineGO_Api.Model.Restaurant", "restaurant")
                        .WithMany()
                        .HasForeignKey("res_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("restaurant");
                });

            modelBuilder.Entity("DineGO_Api.Model.Restaurant", b =>
                {
                    b.HasOne("DineGO_Api.Model.Category", "category")
                        .WithMany("restaurants")
                        .HasForeignKey("cate_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("DineGO_Api.Model.Category", b =>
                {
                    b.Navigation("restaurants");
                });

            modelBuilder.Entity("DineGO_Api.Model.Customer", b =>
                {
                    b.Navigation("notifications");
                });

            modelBuilder.Entity("DineGO_Api.Model.Reservation", b =>
                {
                    b.Navigation("notifications");
                });
#pragma warning restore 612, 618
        }
    }
}

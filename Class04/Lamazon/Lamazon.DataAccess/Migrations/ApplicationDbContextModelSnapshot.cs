﻿// <auto-generated />
using System;
using Lamazon.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lamazon.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lamazon.Domain.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("InvoiceStatusId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceStatusId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.InvoiceLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("OrderLineItemId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("ProductPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("OrderLineItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceLineItems");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.InvoiceStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("InvoiceStatuses");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CountryFlagUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.OrderLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("ProductPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrdersLineItems");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("OrdersStatuses");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountPercentage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFeatured")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductStatusId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Even bad code can function. But if code isn’t clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn’t have to be that way.\r\n\r\nNoted software expert Robert C. Martin, presents a revolutionary paradigm with Clean Code: A Handbook of Agile Software Craftsmanship. Martin, who has helped bring agile principles from a practitioner’s point of view to tens of thousands of programmers, has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code “on the fly” into a book that will instill within you the values of software craftsman, and make you a better programmer―but only if you work at it.\r\n\r\nWhat kind of work will you be doing? You’ll be reading code―lots of code. And you will be challenged to think about what’s right about that code, and what’s wrong with it. More importantly you will be challenged to reassess your professional values and your commitment to your craft.\r\n\r\nClean Code is divided into three parts. The first describes the principles, patterns, and practices of writing clean code. The second part consists of several case studies of increasing complexity. Each case study is an exercise in cleaning up code―of transforming a code base that has some problems into one that is sound and efficient. The third part is the payoff: a single chapter containing a list of heuristics and “smells” gathered while creating the case studies. The result is a knowledge base that describes the way we think when we write, read, and clean code.\r\n",
                            DiscountPercentage = 10,
                            ImageUrl = "https://m.media-amazon.com/images/I/51E2055ZGUL._SY522_.jpg",
                            IsFeatured = true,
                            Name = "Clean Code",
                            Price = 55m,
                            ProductCategoryId = 3,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ward Cunningham Straight from the programming trenches, The Pragmatic Programmer cuts through the increasing specialization and technicalities of modern software development to examine the core process--taking a requirement and producing working, maintainable code that delights its users. It covers topics ranging from personal responsibility and career development to architectural techniques for keeping your code flexible and easy to adapt and reuse. Read this book, and you’ll learn how to Fight software rot; Avoid the trap of duplicating knowledge; Write flexible, dynamic, and adaptable code; Avoid programming by coincidence; Bullet-proof your code with contracts, assertions, and exceptions; Capture real requirements; Test ruthlessly and effectively; Delight your users; Build teams of pragmatic programmers; and Make your developments more precise with automation.",
                            DiscountPercentage = 15,
                            ImageUrl = "https://m.media-amazon.com/images/I/61ztlXgCmpL._SY522_.jpg",
                            IsFeatured = false,
                            Name = "The Pragmatic Programmer",
                            Price = 50.99m,
                            ProductCategoryId = 3,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "A comprehensive update of the leading algorithms text, with new material on matchings in bipartite graphs, online algorithms, machine learning, and other topics.",
                            DiscountPercentage = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/61Mw06x2XcL._AC_UY327_FMwebp_QL65_.jpg",
                            IsFeatured = false,
                            Name = "Introduction to Algorithms",
                            Price = 60.99m,
                            ProductCategoryId = 3,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "OEM IS TO BE INSTALLED ON A NEW PC with no prior version of Windows installed and cannot be transferred to another machine.",
                            DiscountPercentage = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/61JfosHunyL._AC_SX679_.jpg",
                            IsFeatured = false,
                            Name = "Windоws 11 Home",
                            Price = 119.99m,
                            ProductCategoryId = 4,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "AHEAD OF THE PACK- Breathtakingly light and insanely powerful, the ThinkPad T14s Gen 6 sets the new industry-leading standard for AI PCs.\r\nBETTER THAN THE BEST - The Snapdragon X Elite processor is engineered to fulfill the needs of today’s IT teams and hybrid workforce. Meet one of the most powerful, intuitive, and efficient Windows platforms.\r\nGLITTERING GRAPHICS - Enjoy vibrant visuals and sharp details in the sunniest of spots with the Eyesafe Certified, anti-glare WUXGA IPS panel. The energy-efficient display delivers vivid hues and stark contrasts.\r\nSEAMLESS CONNECTION - For relentless on-the-go productivity, Qualcomm Wi-Fi 7 ensures faster bandwidth usage.",
                            DiscountPercentage = 0,
                            ImageUrl = "https://m.media-amazon.com/images/I/71EYq-mmleL._AC_SX679_.jpg",
                            IsFeatured = true,
                            Name = "Lenovo ThinkPad T14s Gen 6-2024",
                            Price = 1711.99m,
                            ProductCategoryId = 5,
                            ProductStatusId = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "SMOOTH MULTITASKING — Powered by the Intel Pentium N6000 4-Core Processor, enabling decent multitasking experience\r\nTOUCHSCREEN VERSATILITY — 14-inch FHD 1920x1080 NanoEdge 360-degree flippable touchscreen display\r\nWORK AND PLAY FROM ANY ANGLE — Convertible 2-in-1 design with four different work modes: traditional clamshell, tent, stand, tablet mode\r\nLIGHTWEIGHT YET DURABLE — Durable and built to US Military Grade standard MIL- STD 810H weighing just 3.59 lbs",
                            DiscountPercentage = 7,
                            ImageUrl = "https://m.media-amazon.com/images/I/61UucaPmVtL._AC_SX679_.jpg",
                            IsFeatured = false,
                            Name = "ASUS Chromebook Flip CX1 Convertible Laptop, 14\" FHD",
                            Price = 350m,
                            ProductCategoryId = 5,
                            ProductStatusId = 1
                        });
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProductCategoryStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryStatusId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Food",
                            ProductCategoryStatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drinks",
                            ProductCategoryStatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Books",
                            ProductCategoryStatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Software",
                            ProductCategoryStatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Computers",
                            ProductCategoryStatusId = 1
                        });
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.ProductCategoryStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategoryStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Active"
                        },
                        new
                        {
                            Id = 255,
                            Name = "Deleted"
                        });
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.ProductStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ProductStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Active"
                        },
                        new
                        {
                            Id = 255,
                            Name = "Deleted"
                        });
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Role", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Key");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Key = "admin",
                            Name = "Administrator"
                        },
                        new
                        {
                            Key = "user",
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("RoleKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleKey");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@outlook.com",
                            FullName = "Admin User",
                            PasswordHash = "AQAAAAEAACcQAAAAECJCSH7Y7+DSAD+UKEnb6fjgOROzppnUpop5/kVMcBDjzOVaLz0vts978iw4ooBhhQ==",
                            RoleKey = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user@outlook.com",
                            FullName = "Normal User",
                            PasswordHash = "AQAAAAEAACcQAAAAEH2PV/R1HciXgHqwrYcEp/32IrxaQ44wcbBnM6EHK2FXA5wZRYXN6pddtVKNqTpTxg==",
                            RoleKey = "user"
                        });
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Invoice", b =>
                {
                    b.HasOne("Lamazon.Domain.Entities.InvoiceStatus", "InvoiceStatus")
                        .WithMany("Invoices")
                        .HasForeignKey("InvoiceStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Invoice_InvoiceStatus");

                    b.HasOne("Lamazon.Domain.Entities.Order", "Order")
                        .WithMany("Invoices")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Invoice_Order");

                    b.HasOne("Lamazon.Domain.Entities.User", "User")
                        .WithMany("Invoices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Invoice_User");

                    b.Navigation("InvoiceStatus");

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.InvoiceLineItem", b =>
                {
                    b.HasOne("Lamazon.Domain.Entities.Invoice", "Invoice")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceLineItem_Invoice");

                    b.HasOne("Lamazon.Domain.Entities.OrderLineItem", "OrderLineItem")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("OrderLineItemId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceLineItem_OrderLineItem");

                    b.HasOne("Lamazon.Domain.Entities.Product", "Product")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_InvoiceLineItem_Product");

                    b.Navigation("Invoice");

                    b.Navigation("OrderLineItem");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Order", b =>
                {
                    b.HasOne("Lamazon.Domain.Entities.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Order_OrderStatus");

                    b.HasOne("Lamazon.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.OrderLineItem", b =>
                {
                    b.HasOne("Lamazon.Domain.Entities.Order", "Order")
                        .WithMany("OrderLineItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_OrderLineItem_Order");

                    b.HasOne("Lamazon.Domain.Entities.Product", "Product")
                        .WithMany("OrderLineItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_OrderLineItem_Product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Product", b =>
                {
                    b.HasOne("Lamazon.Domain.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Product_ProductCategory");

                    b.HasOne("Lamazon.Domain.Entities.ProductStatus", "ProductStatus")
                        .WithMany("Products")
                        .HasForeignKey("ProductStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Product_ProductStatus");

                    b.Navigation("ProductCategory");

                    b.Navigation("ProductStatus");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("Lamazon.Domain.Entities.ProductCategoryStatus", "ProductCategoryStatus")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductCategoryStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_ProductCategory_ProductCategoryStatus");

                    b.Navigation("ProductCategoryStatus");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.User", b =>
                {
                    b.HasOne("Lamazon.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleKey")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_User_Role");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Invoice", b =>
                {
                    b.Navigation("InvoiceLineItems");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.InvoiceStatus", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Order", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("OrderLineItems");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.OrderLineItem", b =>
                {
                    b.Navigation("InvoiceLineItems");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Product", b =>
                {
                    b.Navigation("InvoiceLineItems");

                    b.Navigation("OrderLineItems");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.ProductCategoryStatus", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.ProductStatus", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Lamazon.Domain.Entities.User", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eGameShop.Data;

#nullable disable

namespace eGameShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eGameShop.Models.DistributionPlatform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DistributionPlatforms");
                });

            modelBuilder.Entity("eGameShop.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistributionPlatformId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndOfSale")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameCategory")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartOfSale")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DistributionPlatformId");

                    b.HasIndex("PlatformId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("eGameShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eGameShop.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("eGameShop.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("eGameShop.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("eGameShop.Models.Producer_Game", b =>
                {
                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("ProducerId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("Producers_Games");
                });

            modelBuilder.Entity("eGameShop.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("eGameShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("eGameShop.Models.Game", b =>
                {
                    b.HasOne("eGameShop.Models.DistributionPlatform", "DistributionPlatform")
                        .WithMany("Games")
                        .HasForeignKey("DistributionPlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGameShop.Models.Platform", "Platform")
                        .WithMany("Games")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGameShop.Models.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DistributionPlatform");

                    b.Navigation("Platform");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("eGameShop.Models.OrderItem", b =>
                {
                    b.HasOne("eGameShop.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGameShop.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("eGameShop.Models.Producer_Game", b =>
                {
                    b.HasOne("eGameShop.Models.Game", "Game")
                        .WithMany("Producers_Games")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eGameShop.Models.Producer", "Producer")
                        .WithMany("Producers_Games")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("eGameShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("eGameShop.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("eGameShop.Models.DistributionPlatform", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("eGameShop.Models.Game", b =>
                {
                    b.Navigation("Producers_Games");
                });

            modelBuilder.Entity("eGameShop.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("eGameShop.Models.Platform", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("eGameShop.Models.Producer", b =>
                {
                    b.Navigation("Producers_Games");
                });

            modelBuilder.Entity("eGameShop.Models.Publisher", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}

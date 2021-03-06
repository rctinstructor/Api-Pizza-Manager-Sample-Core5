﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaApiManager.DataAccess;

namespace PizzaApiManager.Migrations
{
    [DbContext(typeof(PizzaDataContext))]
    partial class PizzaDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("PizzaApiManager.DataAccess.Pizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("PersonalRating")
                        .HasColumnType("int");

                    b.Property<int?>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SizeID");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaApiManager.DataAccess.PizzaSize", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("PizzaApiManager.DataAccess.Pizza", b =>
                {
                    b.HasOne("PizzaApiManager.DataAccess.PizzaSize", "Size")
                        .WithMany("Pizzas")
                        .HasForeignKey("SizeID");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("PizzaApiManager.DataAccess.PizzaSize", b =>
                {
                    b.Navigation("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsApi.Models;

namespace ProductsApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20201102183034_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("ProductsApi.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Water",
                            Price = 0.5,
                            ValidFrom = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            ValidTo = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Blouse",
                            Price = 50.0,
                            ValidFrom = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            ValidTo = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Jeans",
                            Price = 120.0,
                            ValidFrom = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            ValidTo = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hat",
                            Price = 20.0,
                            ValidFrom = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            ValidTo = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 5,
                            Name = "Laptop",
                            Price = 2310.0,
                            ValidFrom = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            ValidTo = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 6,
                            Name = "Mug",
                            Price = 12.0,
                            ValidFrom = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            ValidTo = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 7,
                            Name = "Fork",
                            Price = 1.5,
                            ValidFrom = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            ValidTo = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 8,
                            Name = "Spoon",
                            Price = 2.5,
                            ValidFrom = new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            ValidTo = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApplication.DataAccess;

namespace TestApplication.DataAccess.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20220717045512_seeddata")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestApplication.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("due")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            created = new DateTime(2022, 7, 17, 10, 25, 12, 349, DateTimeKind.Local).AddTicks(739),
                            description = " test descriptions",
                            due = new DateTime(2022, 7, 19, 10, 25, 12, 350, DateTimeKind.Local).AddTicks(8384),
                            status = 1,
                            title = "test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

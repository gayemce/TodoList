﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoListWebApi.Context;

#nullable disable

namespace TodoListWebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231018165145_mg2")]
    partial class mg2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TodoListWebApi.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Work")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5863),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5851),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Get to work"
                        },
                        new
                        {
                            Id = 2,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5865),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5865),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Pick up groceries"
                        },
                        new
                        {
                            Id = 3,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5867),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5867),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Go home"
                        },
                        new
                        {
                            Id = 4,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5869),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5869),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Fall asleep"
                        },
                        new
                        {
                            Id = 5,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5871),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5871),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Get Up"
                        },
                        new
                        {
                            Id = 6,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5873),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5873),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Brush teeth"
                        },
                        new
                        {
                            Id = 7,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5875),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5874),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Take a shower"
                        },
                        new
                        {
                            Id = 8,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5877),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5876),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Check e-mail"
                        },
                        new
                        {
                            Id = 9,
                            CompletedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5879),
                            CreatedDate = new DateTime(2023, 10, 18, 19, 51, 45, 557, DateTimeKind.Local).AddTicks(5878),
                            IsCompleted = false,
                            IsDeleted = false,
                            Work = "Walk dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

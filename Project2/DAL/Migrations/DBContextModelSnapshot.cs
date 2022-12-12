﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.DAL;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BooksCollections", b =>
                {
                    b.Property<int>("booksId")
                        .HasColumnType("int");

                    b.Property<int>("collectionsId")
                        .HasColumnType("int");

                    b.HasKey("booksId", "collectionsId");

                    b.HasIndex("collectionsId");

                    b.ToTable("BookToCollection", (string)null);
                });

            modelBuilder.Entity("Project2.DAL.Entities.Authors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("birth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("death")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            bio = "Some 1st bio",
                            birth = new DateTime(2022, 12, 10, 15, 40, 3, 160, DateTimeKind.Local).AddTicks(5877),
                            death = new DateTime(2022, 12, 10, 15, 40, 3, 160, DateTimeKind.Local).AddTicks(5912),
                            name = "Name 1",
                            rating = 100
                        });
                });

            modelBuilder.Entity("Project2.DAL.Entities.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("author_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("author_id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            description = "No info 1",
                            genre = "Preview genre 1",
                            name = "Preview book 1",
                            rating = 2
                        },
                        new
                        {
                            Id = 2,
                            description = "No info 2",
                            genre = "Preview genre 2",
                            name = "Preview book 2",
                            rating = 90
                        });
                });

            modelBuilder.Entity("Project2.DAL.Entities.Collections", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("rating")
                        .HasColumnType("int");

                    b.Property<string>("user_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("Project2.DAL.Entities.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("book_id")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("user_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("book_id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BooksCollections", b =>
                {
                    b.HasOne("Project2.DAL.Entities.Books", null)
                        .WithMany()
                        .HasForeignKey("booksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project2.DAL.Entities.Collections", null)
                        .WithMany()
                        .HasForeignKey("collectionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project2.DAL.Entities.Books", b =>
                {
                    b.HasOne("Project2.DAL.Entities.Authors", "author")
                        .WithMany("books")
                        .HasForeignKey("author_id");

                    b.Navigation("author");
                });

            modelBuilder.Entity("Project2.DAL.Entities.Comments", b =>
                {
                    b.HasOne("Project2.DAL.Entities.Books", "book")
                        .WithMany("comments")
                        .HasForeignKey("book_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");
                });

            modelBuilder.Entity("Project2.DAL.Entities.Authors", b =>
                {
                    b.Navigation("books");
                });

            modelBuilder.Entity("Project2.DAL.Entities.Books", b =>
                {
                    b.Navigation("comments");
                });
#pragma warning restore 612, 618
        }
    }
}

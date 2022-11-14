﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WizLib_DataAccess.Data;

#nullable disable

namespace WizLib_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221107161143_AddSprocAndView")]
    partial class AddSprocAndView
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WizLib_Model.Models.Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("WizLib_Model.Models.Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_Id"), 1L, 1);

                    b.Property<int?>("BookDetail_Id")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_Id");

                    b.HasIndex("BookDetail_Id")
                        .IsUnique()
                        .HasFilter("[BookDetail_Id] IS NOT NULL");

                    b.HasIndex("Publisher_Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("WizLib_Model.Models.BookAuthor", b =>
                {
                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.HasKey("Author_Id", "Book_Id");

                    b.HasIndex("Book_Id");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("WizLib_Model.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_Id"), 1L, 1);

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("WizLib_Model.Models.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CategoryName");

                    b.HasKey("Category_Id");

                    b.ToTable("tbl_category", (string)null);
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_Id");

                    b.ToTable("Fluent_Author");
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_Id"), 1L, 1);

                    b.Property<int>("BookDetail_Id")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_Id");

                    b.HasIndex("BookDetail_Id")
                        .IsUnique();

                    b.HasIndex("Publisher_Id");

                    b.ToTable("Fluent_Book");
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_BookAuthor", b =>
                {
                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.HasKey("Author_Id", "Book_Id");

                    b.HasIndex("Book_Id");

                    b.ToTable("Fluent_BookAuthor");
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_Id"), 1L, 1);

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("Fluent_BookDetails");
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Fluent_Publisher");
                });

            modelBuilder.Entity("WizLib_Model.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("GenreId");

                    b.ToTable("tb_Genre");
                });

            modelBuilder.Entity("WizLib_Model.Models.Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("WizLib_Model.Models.Book", b =>
                {
                    b.HasOne("WizLib_Model.Models.BookDetail", "BookDetail")
                        .WithOne("Book")
                        .HasForeignKey("WizLib_Model.Models.Book", "BookDetail_Id");

                    b.HasOne("WizLib_Model.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookDetail");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("WizLib_Model.Models.BookAuthor", b =>
                {
                    b.HasOne("WizLib_Model.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WizLib_Model.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_Book", b =>
                {
                    b.HasOne("WizLib_Model.Models.Fluent_BookDetail", "Fluent_BookDetail")
                        .WithOne("Fluent_Book")
                        .HasForeignKey("WizLib_Model.Models.Fluent_Book", "BookDetail_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WizLib_Model.Models.Fluent_Publisher", "Fluent_Publisher")
                        .WithMany("Fluent_Book")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fluent_BookDetail");

                    b.Navigation("Fluent_Publisher");
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_BookAuthor", b =>
                {
                    b.HasOne("WizLib_Model.Models.Fluent_Author", "Fluent_Author")
                        .WithMany("Fluent_BookAuthors")
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WizLib_Model.Models.Fluent_Book", "Fluent_Book")
                        .WithMany("Fluent_BookAuthors")
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fluent_Author");

                    b.Navigation("Fluent_Book");
                });

            modelBuilder.Entity("WizLib_Model.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("WizLib_Model.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("WizLib_Model.Models.BookDetail", b =>
                {
                    b.Navigation("Book")
                        .IsRequired();
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_Author", b =>
                {
                    b.Navigation("Fluent_BookAuthors");
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_Book", b =>
                {
                    b.Navigation("Fluent_BookAuthors");
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_BookDetail", b =>
                {
                    b.Navigation("Fluent_Book")
                        .IsRequired();
                });

            modelBuilder.Entity("WizLib_Model.Models.Fluent_Publisher", b =>
                {
                    b.Navigation("Fluent_Book");
                });

            modelBuilder.Entity("WizLib_Model.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using IRRIGATION.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace IRRIGATIONDLL.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("IRRIGATIONDLL.Models.CONSTANTINDEX", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("TYPE")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.ToTable("CONSTANTINDEX");
                });

            modelBuilder.Entity("IRRIGATIONDLL.Models.SETTING", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasAnnotation("Comment", "test");

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("TITLE")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.Property<string>("VALUE")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("SETTING");
                });
#pragma warning restore 612, 618
        }
    }
}

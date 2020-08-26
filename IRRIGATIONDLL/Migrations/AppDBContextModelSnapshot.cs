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

            modelBuilder.Entity("IRRIGATION.Models.AGRIDEP", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AGRIDIRId");

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("AGRIDIRId");

                    b.HasIndex("GOVId");

                    b.ToTable("AGRIDEP");
                });

            modelBuilder.Entity("IRRIGATION.Models.AGRIDIR", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("GOVId");

                    b.ToTable("AGRIDIR");
                });

            modelBuilder.Entity("IRRIGATION.Models.AGRISEC", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AGRIDEPId");

                    b.Property<decimal>("AGRIDIRId");

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("SIDEId");

                    b.Property<decimal>("USERNB");

                    b.Property<decimal>("ZONEId");

                    b.HasKey("Id");

                    b.HasIndex("AGRIDEPId");

                    b.HasIndex("AGRIDIRId");

                    b.HasIndex("GOVId");

                    b.HasIndex("SIDEId");

                    b.HasIndex("ZONEId");

                    b.ToTable("AGRISEC");
                });

            modelBuilder.Entity("IRRIGATION.Models.AREA", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("GOVId");

                    b.ToTable("AREA");
                });

            modelBuilder.Entity("IRRIGATION.Models.BRANCH", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("HEADNAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("GOVId");

                    b.ToTable("BRANCH");
                });

            modelBuilder.Entity("IRRIGATION.Models.CIRCLE", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BRANCHId");

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("HEADNAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("BRANCHId");

                    b.HasIndex("GOVId");

                    b.ToTable("CIRCLE");
                });

            modelBuilder.Entity("IRRIGATION.Models.COMPANY", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ADDRESS")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<decimal>("ADJId");

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<string>("FAX")
                        .HasMaxLength(30);

                    b.Property<decimal>("GOVId");

                    b.Property<string>("MOBILE")
                        .HasMaxLength(30);

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("PHONE")
                        .HasMaxLength(30);

                    b.Property<decimal>("STAId");

                    b.Property<decimal>("STRId");

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("ADJId");

                    b.HasIndex("GOVId");

                    b.HasIndex("STAId");

                    b.HasIndex("STRId");

                    b.ToTable("COMPANY");
                });

            modelBuilder.Entity("IRRIGATION.Models.CONSTANT", b =>
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

                    b.ToTable("CONSTANT");
                });

            modelBuilder.Entity("IRRIGATION.Models.GOVERNORATE", b =>
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

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.ToTable("GOVERNORATE");
                });

            modelBuilder.Entity("IRRIGATION.Models.INDIC", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AGRISECId");

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("SIDEId");

                    b.Property<decimal>("USERNB");

                    b.Property<decimal>("VILId");

                    b.Property<decimal>("ZONEId");

                    b.HasKey("Id");

                    b.HasIndex("AGRISECId");

                    b.HasIndex("GOVId");

                    b.HasIndex("SIDEId");

                    b.HasIndex("VILId");

                    b.HasIndex("ZONEId");

                    b.ToTable("INDIC");
                });

            modelBuilder.Entity("IRRIGATION.Models.PRODUCT", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("KINDId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("NOTE")
                        .HasMaxLength(500);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("KINDId");

                    b.ToTable("PRODUCT");
                });

            modelBuilder.Entity("IRRIGATION.Models.SECTION", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BRANCHId");

                    b.Property<decimal>("CIRCLEId");

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("HEADNAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("BRANCHId");

                    b.HasIndex("CIRCLEId");

                    b.HasIndex("GOVId");

                    b.ToTable("SECTION");
                });

            modelBuilder.Entity("IRRIGATION.Models.SETTING", b =>
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

            modelBuilder.Entity("IRRIGATION.Models.SIDE", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.Property<decimal>("ZONEId");

                    b.HasKey("Id");

                    b.HasIndex("GOVId");

                    b.HasIndex("ZONEId");

                    b.ToTable("SIDE");
                });

            modelBuilder.Entity("IRRIGATION.Models.VILLAGE", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("SIDEId");

                    b.Property<decimal>("USERNB");

                    b.Property<decimal>("ZONEId");

                    b.HasKey("Id");

                    b.HasIndex("GOVId");

                    b.HasIndex("SIDEId");

                    b.HasIndex("ZONEId");

                    b.ToTable("VILLAGE");
                });

            modelBuilder.Entity("IRRIGATION.Models.ZONE", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CREATION_DATE");

                    b.Property<decimal>("GOVId");

                    b.Property<string>("NAME")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NOTE")
                        .HasMaxLength(300);

                    b.Property<string>("ORDER")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("USERNB");

                    b.HasKey("Id");

                    b.HasIndex("GOVId");

                    b.ToTable("ZONE");
                });

            modelBuilder.Entity("IRRIGATION.Models.AGRIDEP", b =>
                {
                    b.HasOne("IRRIGATION.Models.AGRIDIR", "AGRIDIR")
                        .WithMany("AGRIDEP")
                        .HasForeignKey("AGRIDIRId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.AGRIDIR", b =>
                {
                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.AGRISEC", b =>
                {
                    b.HasOne("IRRIGATION.Models.AGRIDEP", "AGRIDEP")
                        .WithMany("AGRISEC")
                        .HasForeignKey("AGRIDEPId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.AGRIDIR", "AGRIDIR")
                        .WithMany()
                        .HasForeignKey("AGRIDIRId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.SIDE", "SIDE")
                        .WithMany()
                        .HasForeignKey("SIDEId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.ZONE", "ZONE")
                        .WithMany()
                        .HasForeignKey("ZONEId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.AREA", b =>
                {
                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.BRANCH", b =>
                {
                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany("BRANCH")
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.CIRCLE", b =>
                {
                    b.HasOne("IRRIGATION.Models.BRANCH", "BRANCH")
                        .WithMany("CIRCLE")
                        .HasForeignKey("BRANCHId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.COMPANY", b =>
                {
                    b.HasOne("IRRIGATION.Models.CONSTANT", "ADJECTIVE")
                        .WithMany()
                        .HasForeignKey("ADJId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.CONSTANT", "STATUS")
                        .WithMany()
                        .HasForeignKey("STAId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.CONSTANT", "STRUCTTYPE")
                        .WithMany()
                        .HasForeignKey("STRId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.INDIC", b =>
                {
                    b.HasOne("IRRIGATION.Models.AGRISEC", "AGRISEC")
                        .WithMany()
                        .HasForeignKey("AGRISECId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.SIDE", "SIDE")
                        .WithMany()
                        .HasForeignKey("SIDEId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.VILLAGE", "VILLAGE")
                        .WithMany()
                        .HasForeignKey("VILId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.ZONE", "ZONE")
                        .WithMany()
                        .HasForeignKey("ZONEId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.PRODUCT", b =>
                {
                    b.HasOne("IRRIGATION.Models.CONSTANT", "PRODUCTKIND")
                        .WithMany()
                        .HasForeignKey("KINDId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.SECTION", b =>
                {
                    b.HasOne("IRRIGATION.Models.BRANCH", "BRANCH")
                        .WithMany()
                        .HasForeignKey("BRANCHId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.CIRCLE", "CIRCLE")
                        .WithMany()
                        .HasForeignKey("CIRCLEId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.SIDE", b =>
                {
                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.ZONE", "ZONE")
                        .WithMany("SIDE")
                        .HasForeignKey("ZONEId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.VILLAGE", b =>
                {
                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany()
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.SIDE", "SIDE")
                        .WithMany("VILLAGE")
                        .HasForeignKey("SIDEId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("IRRIGATION.Models.ZONE", "ZONE")
                        .WithMany()
                        .HasForeignKey("ZONEId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("IRRIGATION.Models.ZONE", b =>
                {
                    b.HasOne("IRRIGATION.Models.GOVERNORATE", "GOVERNORATE")
                        .WithMany("ZONE")
                        .HasForeignKey("GOVId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OkulEFAppProject;

#nullable disable

namespace OkulEFAppProject.Migrations
{
    [DbContext(typeof(OgrenciModel))]
    [Migration("20241229171225_MyMigration1")]
    partial class MyMigration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OkulEFAppProject.Ders", b =>
                {
                    b.Property<int>("DersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersId"));

                    b.Property<string>("DersAd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("DersKod")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar");

                    b.HasKey("DersId");

                    b.HasIndex("DersKod")
                        .IsUnique();

                    b.ToTable("tblDersler");
                });

            modelBuilder.Entity("OkulEFAppProject.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<int>("SinifId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.HasKey("OgrenciId");

                    b.HasIndex("Numara")
                        .IsUnique();

                    b.HasIndex("SinifId");

                    b.ToTable("tblOgrenciler");
                });

            modelBuilder.Entity("OkulEFAppProject.OgrenciDers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DersId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("tblOgrenciDers");
                });

            modelBuilder.Entity("OkulEFAppProject.Sinif", b =>
                {
                    b.Property<int>("SinifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinifId"));

                    b.Property<int>("Kontenjan")
                        .HasColumnType("int");

                    b.Property<string>("SinifAd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.HasKey("SinifId");

                    b.HasIndex("SinifAd")
                        .IsUnique();

                    b.ToTable("tblSiniflar");
                });

            modelBuilder.Entity("OkulEFAppProject.Ogrenci", b =>
                {
                    b.HasOne("OkulEFAppProject.Sinif", "Sinif")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("SinifId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("OkulEFAppProject.OgrenciDers", b =>
                {
                    b.HasOne("OkulEFAppProject.Ders", "Ders")
                        .WithMany("OgrenciDers")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OkulEFAppProject.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDers")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("OkulEFAppProject.Ders", b =>
                {
                    b.Navigation("OgrenciDers");
                });

            modelBuilder.Entity("OkulEFAppProject.Ogrenci", b =>
                {
                    b.Navigation("OgrenciDers");
                });

            modelBuilder.Entity("OkulEFAppProject.Sinif", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateApp.Infrastructure.Persistence.Contexts;

#nullable disable

namespace RealEstateApp.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240528115552_AddedTwoTable")]
    partial class AddedTwoTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ImprovementsProperties", b =>
                {
                    b.Property<int>("ImprovementsId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("ImprovementsId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("ImprovementsProperties");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Agents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfProperties")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("AreaSize")
                        .HasColumnType("real");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("BathCount")
                        .HasColumnType("int");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BuildingCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<bool>("Garage")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRepaired")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NeighborhoodNoise")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Improvements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Improvements", (string)null);
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Properties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AgentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AgentsId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePathFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePathOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePathThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePathTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandSize")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfBathrooms")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TypeOfPropertyId")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfSaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgentsId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("TypeOfPropertyId");

                    b.HasIndex("TypeOfSaleId");

                    b.ToTable("Properties", (string)null);
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.PropertiesImprovements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImprovementId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImprovementId");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertiesImprovements");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.TypeOfProperties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfProperties", (string)null);
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.TypeOfSales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfSales", (string)null);
                });

            modelBuilder.Entity("ImprovementsProperties", b =>
                {
                    b.HasOne("RealEstateApp.Core.Domain.Entities.Improvements", null)
                        .WithMany()
                        .HasForeignKey("ImprovementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateApp.Core.Domain.Entities.Properties", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Announcement", b =>
                {
                    b.HasOne("RealEstateApp.Core.Domain.Entities.Categories", "Categories")
                        .WithMany("Announcements")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Properties", b =>
                {
                    b.HasOne("RealEstateApp.Core.Domain.Entities.Agents", "Agents")
                        .WithMany("Properties")
                        .HasForeignKey("AgentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateApp.Core.Domain.Entities.TypeOfProperties", "TypeOfProperty")
                        .WithMany("Properties")
                        .HasForeignKey("TypeOfPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateApp.Core.Domain.Entities.TypeOfSales", "TypeOfSale")
                        .WithMany("Properties")
                        .HasForeignKey("TypeOfSaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agents");

                    b.Navigation("TypeOfProperty");

                    b.Navigation("TypeOfSale");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.PropertiesImprovements", b =>
                {
                    b.HasOne("RealEstateApp.Core.Domain.Entities.Improvements", "Improvement")
                        .WithMany("PropertiesImprovements")
                        .HasForeignKey("ImprovementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateApp.Core.Domain.Entities.Properties", "Property")
                        .WithMany("PropertiesImprovements")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Improvement");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Agents", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Categories", b =>
                {
                    b.Navigation("Announcements");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Improvements", b =>
                {
                    b.Navigation("PropertiesImprovements");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.Properties", b =>
                {
                    b.Navigation("PropertiesImprovements");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.TypeOfProperties", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RealEstateApp.Core.Domain.Entities.TypeOfSales", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}

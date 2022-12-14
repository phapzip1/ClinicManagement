﻿// <auto-generated />
using System;
using ClinicManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicManagement.Migrations
{
    [DbContext(typeof(ClinicDbContext))]
    partial class ClinicDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClinicManagement.DTOs.IllnessDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symptom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Illness");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.MedicalNoteDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateIn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IllnessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IllnessId");

                    b.HasIndex("PatientId");

                    b.ToTable("MedicalNotes");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.MedicalNoteDetailDTO", b =>
                {
                    b.Property<Guid>("MedicineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MedicalNoteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MethodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint");

                    b.HasKey("MedicineId", "MedicalNoteId");

                    b.HasIndex("MedicalNoteId");

                    b.HasIndex("MethodId");

                    b.ToTable("MedicalNoteDetail");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.MedicineDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<long>("Stock")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UnitId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.MethodDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Methods");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.PatientDTO", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.UnitDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.MedicalNoteDTO", b =>
                {
                    b.HasOne("ClinicManagement.DTOs.IllnessDTO", "Illness")
                        .WithMany()
                        .HasForeignKey("IllnessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicManagement.DTOs.PatientDTO", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Illness");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.MedicalNoteDetailDTO", b =>
                {
                    b.HasOne("ClinicManagement.DTOs.MedicalNoteDTO", "MedicalNote")
                        .WithMany()
                        .HasForeignKey("MedicalNoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicManagement.DTOs.MedicineDTO", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClinicManagement.DTOs.MethodDTO", "Method")
                        .WithMany()
                        .HasForeignKey("MethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalNote");

                    b.Navigation("Medicine");

                    b.Navigation("Method");
                });

            modelBuilder.Entity("ClinicManagement.DTOs.MedicineDTO", b =>
                {
                    b.HasOne("ClinicManagement.DTOs.UnitDTO", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });
#pragma warning restore 612, 618
        }
    }
}

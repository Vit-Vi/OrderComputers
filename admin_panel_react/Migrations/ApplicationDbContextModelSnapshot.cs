﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using admin_panel_react.Models;

#nullable disable

namespace admin_panel_react.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("admin_panel_react.Models.AssemblyPeripheries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ComputerAssemblyId")
                        .HasColumnType("integer");

                    b.Property<int>("PeripheryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ComputerAssemblyId");

                    b.HasIndex("PeripheryId");

                    b.ToTable("AssemblyPeripheries");
                });

            modelBuilder.Entity("admin_panel_react.Models.CompBody", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FormFactor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("CompBodies");
                });

            modelBuilder.Entity("admin_panel_react.Models.CompProcessor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountCores")
                        .HasColumnType("integer");

                    b.Property<int>("CountThreads")
                        .HasColumnType("integer");

                    b.Property<int>("Frequency")
                        .HasColumnType("integer");

                    b.Property<bool>("HaveVideoCard")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Socket")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TurboTechnology")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypeRam")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CompProcessors");
                });

            modelBuilder.Entity("admin_panel_react.Models.ComputerAssembly", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompBodyId")
                        .HasColumnType("integer");

                    b.Property<int>("CompProcessorId")
                        .HasColumnType("integer");

                    b.Property<double>("CostPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MotherCardId")
                        .HasColumnType("integer");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int>("PowerSupplyUnitId")
                        .HasColumnType("integer");

                    b.Property<int>("RAMMemoryId")
                        .HasColumnType("integer");

                    b.Property<int>("StorageDeviceId")
                        .HasColumnType("integer");

                    b.Property<string>("TypeComputerAssembly")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VideoCardId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CompBodyId");

                    b.HasIndex("CompProcessorId");

                    b.HasIndex("MotherCardId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PowerSupplyUnitId");

                    b.HasIndex("RAMMemoryId");

                    b.HasIndex("StorageDeviceId");

                    b.HasIndex("VideoCardId");

                    b.ToTable("ComputerAssemblies");
                });

            modelBuilder.Entity("admin_panel_react.Models.MotherCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("HaveBluetoothModul")
                        .HasColumnType("boolean");

                    b.Property<bool>("HaveWiFiModul")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Socket")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MotherCards");
                });

            modelBuilder.Entity("admin_panel_react.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ComputerAssemblyId")
                        .HasColumnType("integer");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("double precision");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ComputerAssemblyId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("admin_panel_react.Models.Periphery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Peripheries");
                });

            modelBuilder.Entity("admin_panel_react.Models.PowerSupplyUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FormFactor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Power")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("PowerSupplyUnits");
                });

            modelBuilder.Entity("admin_panel_react.Models.RAMMemory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<int>("Frequency")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RAMMemories");
                });

            modelBuilder.Entity("admin_panel_react.Models.StorageDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Count")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("StorageDevices");
                });

            modelBuilder.Entity("admin_panel_react.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypeUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("admin_panel_react.Models.VideoCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Generation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Series")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VideoCards");
                });

            modelBuilder.Entity("admin_panel_react.Models.AssemblyPeripheries", b =>
                {
                    b.HasOne("admin_panel_react.Models.ComputerAssembly", "ComputerAssembly")
                        .WithMany("AssemblyPeripheries")
                        .HasForeignKey("ComputerAssemblyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("admin_panel_react.Models.Periphery", "Periphery")
                        .WithMany()
                        .HasForeignKey("PeripheryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComputerAssembly");

                    b.Navigation("Periphery");
                });

            modelBuilder.Entity("admin_panel_react.Models.ComputerAssembly", b =>
                {
                    b.HasOne("admin_panel_react.Models.CompBody", "CompBody")
                        .WithMany()
                        .HasForeignKey("CompBodyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("admin_panel_react.Models.CompProcessor", "CompProcessor")
                        .WithMany()
                        .HasForeignKey("CompProcessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("admin_panel_react.Models.MotherCard", "MotherCard")
                        .WithMany()
                        .HasForeignKey("MotherCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("admin_panel_react.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("admin_panel_react.Models.PowerSupplyUnit", "PowerSupplyUnit")
                        .WithMany()
                        .HasForeignKey("PowerSupplyUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("admin_panel_react.Models.RAMMemory", "RAMMemory")
                        .WithMany()
                        .HasForeignKey("RAMMemoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("admin_panel_react.Models.StorageDevice", "StorageDevice")
                        .WithMany()
                        .HasForeignKey("StorageDeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("admin_panel_react.Models.VideoCard", "VideoCard")
                        .WithMany()
                        .HasForeignKey("VideoCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompBody");

                    b.Navigation("CompProcessor");

                    b.Navigation("MotherCard");

                    b.Navigation("Owner");

                    b.Navigation("PowerSupplyUnit");

                    b.Navigation("RAMMemory");

                    b.Navigation("StorageDevice");

                    b.Navigation("VideoCard");
                });

            modelBuilder.Entity("admin_panel_react.Models.Order", b =>
                {
                    b.HasOne("admin_panel_react.Models.ComputerAssembly", "ComputerAssembly")
                        .WithMany()
                        .HasForeignKey("ComputerAssemblyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("admin_panel_react.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComputerAssembly");

                    b.Navigation("User");
                });

            modelBuilder.Entity("admin_panel_react.Models.ComputerAssembly", b =>
                {
                    b.Navigation("AssemblyPeripheries");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiProject1.Data;

namespace WebApiProject1.Migrations
{
    [DbContext(typeof(PortDbContext))]
    [Migration("20220722053254_Initialcreate")]
    partial class Initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiProject1.Data.PortSlots", b =>
                {
                    b.Property<int>("Slotid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Cost")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Enddate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ruid")
                        .HasColumnType("int");

                    b.Property<int?>("Sluid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Startdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Slotid");

                    b.ToTable("PortSlots");
                });

            modelBuilder.Entity("WebApiProject1.Data.PortUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Cost")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Enddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Phone")
                        .HasColumnType("bigint");

                    b.Property<int>("Sluid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Startdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usertype")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PortUsers");
                });
#pragma warning restore 612, 618
        }
    }
}

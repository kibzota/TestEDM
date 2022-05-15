﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestEDM.Infra.Persistence.EF;

#nullable disable

namespace TestEDM.Infra.Migrations
{
    [DbContext(typeof(TestEDMDBContext))]
    [Migration("20220515162430_migration01")]
    partial class migration01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TestEDM.Domain.Entities.Notas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<int>("NotasDeCem")
                        .HasColumnType("int");

                    b.Property<int>("NotasDeCinquenta")
                        .HasColumnType("int");

                    b.Property<int>("NotasDeDez")
                        .HasColumnType("int");

                    b.Property<int>("NotasDeVinte")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}
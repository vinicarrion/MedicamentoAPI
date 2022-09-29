﻿// <auto-generated />
using Medicamento.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CartoesAPI.Migrations
{
    [DbContext(typeof(MedicamentoContext))]
    [Migration("20220929230529_createDatabse")]
    partial class createDatabse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Medicamento.Model.MedicamentoModel", b =>
                {
                    b.Property<int>("IdMedicamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnoVencimento")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.Property<int>("Fabricante")
                        .HasColumnType("int");

                    b.Property<string>("Lote")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MesVencimento")
                        .HasColumnType("int");

                    b.HasKey("IdMedicamento");

                    b.ToTable("Medicamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
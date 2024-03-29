﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tienda.Data;

#nullable disable

namespace Tienda.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Tienda.Modelos.Articulos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasMaxLength(240)
                        .HasColumnType("varchar(240)");

                    b.Property<int>("marca_id")
                        .HasColumnType("int");

                    b.Property<int>("modelo_id")
                        .HasColumnType("int");

                    b.Property<int>("nro_serie_id")
                        .HasColumnType("int");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.Property<int>("tipo_prod_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Tienda.Modelos.Modelo_Abm_Marca", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Tienda.Modelos.Modelo_Abm_TipoProd", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TipoProd")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("TipoProds");
                });

            modelBuilder.Entity("Tienda.Modelos.Modelo_ModelodeProductos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext");

                    b.Property<int>("marca_id")
                        .HasColumnType("int");

                    b.Property<int>("tipo_prod_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("ModelodeProductos");
                });
#pragma warning restore 612, 618
        }
    }
}

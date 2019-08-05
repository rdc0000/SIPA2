﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SIPA.Migrations
{
    [DbContext(typeof(SIPAContext))]
    [Migration("20190801211510_Inicial2")]
    partial class Inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SIPA.Models.Articulo", b =>
                {
                    b.Property<int>("ArticuloID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cantidad");

                    b.Property<string>("Nombre");

                    b.Property<int>("PrecioProveedor");

                    b.Property<int>("PrecioVenta");

                    b.Property<int>("ProveedorID");

                    b.HasKey("ArticuloID");

                    b.HasIndex("ProveedorID");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("SIPA.Models.Autoservicio", b =>
                {
                    b.Property<int>("AutoservicioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<bool>("Estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("AutoservicioID");

                    b.ToTable("Autoservicio");
                });

            modelBuilder.Entity("SIPA.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos");

                    b.Property<string>("Direccion");

                    b.Property<string>("Email");

                    b.Property<string>("Nombres");

                    b.Property<string>("Telefono");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SIPA.Models.Empleado", b =>
                {
                    b.Property<int>("EmpleadoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Cargo")
                        .IsRequired();

                    b.Property<string>("Documento")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("EmpleadoID");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("SIPA.Models.Proveedor", b =>
                {
                    b.Property<int>("ProveedorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.HasKey("ProveedorID");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("SIPA.Models.Articulo", b =>
                {
                    b.HasOne("SIPA.Models.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
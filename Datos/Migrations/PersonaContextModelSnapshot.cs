﻿// <auto-generated />
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(PersonaContext))]
    partial class PersonaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Persona", b =>
                {
                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Identificacion");

                    b.ToTable("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}

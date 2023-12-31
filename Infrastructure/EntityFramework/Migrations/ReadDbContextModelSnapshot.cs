﻿// <auto-generated />
using System;
using Infrastructure.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    partial class ReadDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.Archivos.ArchivoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("fileId");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("extension");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("fileName");

                    b.Property<bool>("IsTemp")
                        .HasColumnType("bit")
                        .HasColumnName("isTemp");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)")
                        .HasColumnName("location");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("mimeType");

                    b.Property<int>("TimesUsed")
                        .HasColumnType("int")
                        .HasColumnName("timesUsed");

                    b.Property<DateTime>("UploadedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("uploadedOn");

                    b.HasKey("Id");

                    b.ToTable("archivo", "app");
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.Proyectos.ProyectoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("CreadorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creadorId");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("estado");

                    b.Property<Guid>("TipoProyectoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("tipoProyectoId");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.HasIndex("TipoProyectoId");

                    b.ToTable("Proyecto", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.Proyectos.RequisitoProyectoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("ArchivoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("archivoId");

                    b.Property<Guid>("ProyectoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("proyectoId");

                    b.Property<Guid>("RequerimientoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("requerimientoId");

                    b.HasKey("Id");

                    b.HasIndex("ArchivoId");

                    b.HasIndex("ProyectoId");

                    b.HasIndex("RequerimientoId");

                    b.ToTable("RequisitoProyecto", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.Requerimientos.RequerimientoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Requerimiento", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.TiposProyectos.RequerimientoTipoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<bool>("Obligatorio")
                        .HasColumnType("bit")
                        .HasColumnName("obligatorio");

                    b.Property<Guid>("RequerimientoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("requerimientoId");

                    b.Property<Guid>("TipoProyectoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("tipoProyectoId");

                    b.HasKey("Id");

                    b.HasIndex("RequerimientoId");

                    b.HasIndex("TipoProyectoId");

                    b.ToTable("RequerimientoTipo", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.TiposProyectos.TipoProyectoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("TipoProyecto", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.Proyectos.ProyectoReadModel", b =>
                {
                    b.HasOne("Infrastructure.EntityFramework.ReadModel.TiposProyectos.TipoProyectoReadModel", "TipoProyecto")
                        .WithMany()
                        .HasForeignKey("TipoProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProyecto");
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.Proyectos.RequisitoProyectoReadModel", b =>
                {
                    b.HasOne("Infrastructure.EntityFramework.ReadModel.Archivos.ArchivoReadModel", "Archivo")
                        .WithMany()
                        .HasForeignKey("ArchivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.EntityFramework.ReadModel.Proyectos.ProyectoReadModel", "Proyecto")
                        .WithMany("Requisitos")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.EntityFramework.ReadModel.Requerimientos.RequerimientoReadModel", "Requerimiento")
                        .WithMany()
                        .HasForeignKey("RequerimientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Archivo");

                    b.Navigation("Proyecto");

                    b.Navigation("Requerimiento");
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.TiposProyectos.RequerimientoTipoReadModel", b =>
                {
                    b.HasOne("Infrastructure.EntityFramework.ReadModel.Requerimientos.RequerimientoReadModel", "Requerimiento")
                        .WithMany()
                        .HasForeignKey("RequerimientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.EntityFramework.ReadModel.TiposProyectos.TipoProyectoReadModel", "TipoProyecto")
                        .WithMany("RequerimientosTipos")
                        .HasForeignKey("TipoProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Requerimiento");

                    b.Navigation("TipoProyecto");
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.Proyectos.ProyectoReadModel", b =>
                {
                    b.Navigation("Requisitos");
                });

            modelBuilder.Entity("Infrastructure.EntityFramework.ReadModel.TiposProyectos.TipoProyectoReadModel", b =>
                {
                    b.Navigation("RequerimientosTipos");
                });
#pragma warning restore 612, 618
        }
    }
}

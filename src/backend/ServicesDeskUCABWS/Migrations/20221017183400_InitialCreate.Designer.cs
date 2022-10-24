﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicesDeskUCABWS.Data;

#nullable disable

namespace ServicesDeskUCABWS.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221017183400_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartamentoTipo_Ticket", b =>
                {
                    b.Property<Guid>("DepartamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Tipo_TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DepartamentoId", "Tipo_TicketId");

                    b.HasIndex("Tipo_TicketId");

                    b.ToTable("DepartamentoTipo_Ticket");
                });

            modelBuilder.Entity("ProyectD.Models.Departamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_elim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ult_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("ProyectD.Models.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("ProyectD.Models.Flujo_Aprobacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OrdenAprobacion")
                        .HasColumnType("int");

                    b.Property<Guid?>("Tipo_CargoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Tipo_TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Tipo_CargoId");

                    b.HasIndex("Tipo_TicketId");

                    b.ToTable("Flujos_Aprobaciones");
                });

            modelBuilder.Entity("ProyectD.Models.Prioridad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_descripcion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prioridades");
                });

            modelBuilder.Entity("ProyectD.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EstadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PrioridadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Tipo_TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("PrioridadId");

                    b.HasIndex("Tipo_TicketId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ProyectD.Models.Tipo_Cargo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ult_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nivel_jerarquia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipos_Cargos");
                });

            modelBuilder.Entity("ProyectD.Models.Tipo_Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_elim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ult_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipos_Tickets");
                });

            modelBuilder.Entity("ProyectD.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primer_apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primer_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundo_apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundo_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectD.Models.Votos_Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("aprobado")
                        .HasColumnType("bit");

                    b.Property<string>("comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Votos_Ticket");
                });

            modelBuilder.Entity("DepartamentoTipo_Ticket", b =>
                {
                    b.HasOne("ProyectD.Models.Departamento", null)
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectD.Models.Tipo_Ticket", null)
                        .WithMany()
                        .HasForeignKey("Tipo_TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectD.Models.Flujo_Aprobacion", b =>
                {
                    b.HasOne("ProyectD.Models.Tipo_Cargo", "Tipo_Cargo")
                        .WithMany("Flujo_Aprobacion")
                        .HasForeignKey("Tipo_CargoId");

                    b.HasOne("ProyectD.Models.Tipo_Ticket", "Tipo_Ticket")
                        .WithMany("Flujo_Aprobacion")
                        .HasForeignKey("Tipo_TicketId");

                    b.Navigation("Tipo_Cargo");

                    b.Navigation("Tipo_Ticket");
                });

            modelBuilder.Entity("ProyectD.Models.Ticket", b =>
                {
                    b.HasOne("ProyectD.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId");

                    b.HasOne("ProyectD.Models.Prioridad", "Prioridad")
                        .WithMany()
                        .HasForeignKey("PrioridadId");

                    b.HasOne("ProyectD.Models.Tipo_Ticket", "Tipo_Ticket")
                        .WithMany()
                        .HasForeignKey("Tipo_TicketId");

                    b.Navigation("Estado");

                    b.Navigation("Prioridad");

                    b.Navigation("Tipo_Ticket");
                });

            modelBuilder.Entity("ProyectD.Models.Votos_Ticket", b =>
                {
                    b.HasOne("ProyectD.Models.Ticket", "Ticket")
                        .WithMany("Votos_Ticket")
                        .HasForeignKey("TicketId");

                    b.HasOne("ProyectD.Models.Usuario", "Usuario")
                        .WithMany("Votos_Ticket")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Ticket");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProyectD.Models.Ticket", b =>
                {
                    b.Navigation("Votos_Ticket");
                });

            modelBuilder.Entity("ProyectD.Models.Tipo_Cargo", b =>
                {
                    b.Navigation("Flujo_Aprobacion");
                });

            modelBuilder.Entity("ProyectD.Models.Tipo_Ticket", b =>
                {
                    b.Navigation("Flujo_Aprobacion");
                });

            modelBuilder.Entity("ProyectD.Models.Usuario", b =>
                {
                    b.Navigation("Votos_Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}

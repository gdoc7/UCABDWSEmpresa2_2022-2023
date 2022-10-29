﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicesDeskUCABWS.Data;

#nullable disable

namespace ServicesDeskUCABWS.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("EtiquetaTipo_Estado", b =>
                {
                    b.Property<Guid>("EtiquetaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ListaEstadosrelacionadosId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EtiquetaId", "ListaEstadosrelacionadosId");

                    b.HasIndex("ListaEstadosrelacionadosId");

                    b.ToTable("EtiquetaTipo_Estado");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Bitacora_Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EstadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Fecha_Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Inicio")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("TicketId");

                    b.ToTable("Bitacora_Tickets");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Cargo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DepartamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre_departamental")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Departamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GrupoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DepartamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Estado_PadreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("Estado_PadreId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Etiqueta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Familia_Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Familia_Tickets");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Flujo_Aprobacion", b =>
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

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Grupo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.PlantillaNotificacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TipoEstadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TipoEstadoId");

                    b.ToTable("PlantillasNotificaciones");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Prioridad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("fecha_descripcion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prioridades");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Departamento_DestinoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmpleadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EstadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Familia_TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("IDEstado")
                        .HasColumnType("int");

                    b.Property<Guid>("PrioridadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Ticket_PadreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Tipo_TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("Departamento_DestinoId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("Familia_TicketId");

                    b.HasIndex("PrioridadId");

                    b.HasIndex("Ticket_PadreId");

                    b.HasIndex("Tipo_TicketId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Tipo_Cargo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CargoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ult_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nivel_jerarquia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("Tipos_Cargos");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Tipo_Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Estado");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Tipo_Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Minimo_Aprobado")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_elim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ult_edic")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tipos_Tickets");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_eliminacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_ultima_edicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primer_apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("primer_nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("segundo_apellido")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("segundo_nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Votos_Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmpleadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("aprobado")
                        .HasColumnType("int");

                    b.Property<string>("comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("TicketId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Votos_Tickets");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Administrador", b =>
                {
                    b.HasBaseType("ServicesDeskUCABWS.Models.Usuario");

                    b.Property<int>("NumeroDeCuentasBloqueadas")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Cliente", b =>
                {
                    b.HasBaseType("ServicesDeskUCABWS.Models.Usuario");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Empleado", b =>
                {
                    b.HasBaseType("ServicesDeskUCABWS.Models.Usuario");

                    b.Property<Guid?>("CargoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("CargoId");

                    b.HasDiscriminator().HasValue("Empleado");
                });

            modelBuilder.Entity("DepartamentoTipo_Ticket", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Departamento", null)
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServicesDeskUCABWS.Models.Tipo_Ticket", null)
                        .WithMany()
                        .HasForeignKey("Tipo_TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EtiquetaTipo_Estado", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Etiqueta", null)
                        .WithMany()
                        .HasForeignKey("EtiquetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServicesDeskUCABWS.Models.Tipo_Estado", null)
                        .WithMany()
                        .HasForeignKey("ListaEstadosrelacionadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Bitacora_Ticket", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Estado", "Estado")
                        .WithMany("Bitacora_Tickets")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServicesDeskUCABWS.Models.Ticket", "Ticket")
                        .WithMany("Bitacora_Tickets")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Cargo", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Departamento", null)
                        .WithMany("Cargo")
                        .HasForeignKey("DepartamentoId");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Departamento", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Grupo", "Grupo")
                        .WithMany("Departamento")
                        .HasForeignKey("GrupoId");

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Estado", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Departamento", null)
                        .WithMany("Estado")
                        .HasForeignKey("DepartamentoId");

                    b.HasOne("ServicesDeskUCABWS.Models.Tipo_Estado", "Estado_Padre")
                        .WithMany()
                        .HasForeignKey("Estado_PadreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado_Padre");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Flujo_Aprobacion", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Tipo_Cargo", "Tipo_Cargo")
                        .WithMany("Flujo_Aprobacion")
                        .HasForeignKey("Tipo_CargoId");

                    b.HasOne("ServicesDeskUCABWS.Models.Tipo_Ticket", "Tipo_Ticket")
                        .WithMany("Flujo_Aprobacion")
                        .HasForeignKey("Tipo_TicketId");

                    b.Navigation("Tipo_Cargo");

                    b.Navigation("Tipo_Ticket");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.PlantillaNotificacion", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Tipo_Estado", "TipoEstado")
                        .WithMany()
                        .HasForeignKey("TipoEstadoId");

                    b.Navigation("TipoEstado");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Ticket", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Departamento", "Departamento_Destino")
                        .WithMany("ListaTickets")
                        .HasForeignKey("Departamento_DestinoId");

                    b.HasOne("ServicesDeskUCABWS.Models.Empleado", null)
                        .WithMany("Lista_Ticket")
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("ServicesDeskUCABWS.Models.Estado", "Estado")
                        .WithMany("ListaTickets")
                        .HasForeignKey("EstadoId");

                    b.HasOne("ServicesDeskUCABWS.Models.Familia_Ticket", "Familia_Ticket")
                        .WithMany("Lista_Ticket")
                        .HasForeignKey("Familia_TicketId");

                    b.HasOne("ServicesDeskUCABWS.Models.Prioridad", "Prioridad")
                        .WithMany()
                        .HasForeignKey("PrioridadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServicesDeskUCABWS.Models.Ticket", "Ticket_Padre")
                        .WithMany()
                        .HasForeignKey("Ticket_PadreId");

                    b.HasOne("ServicesDeskUCABWS.Models.Tipo_Ticket", "Tipo_Ticket")
                        .WithMany()
                        .HasForeignKey("Tipo_TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento_Destino");

                    b.Navigation("Estado");

                    b.Navigation("Familia_Ticket");

                    b.Navigation("Prioridad");

                    b.Navigation("Ticket_Padre");

                    b.Navigation("Tipo_Ticket");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Tipo_Cargo", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Cargo", null)
                        .WithMany("Tipo_Cargo")
                        .HasForeignKey("CargoId");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Votos_Ticket", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Empleado", null)
                        .WithMany("Votos_Ticket")
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("ServicesDeskUCABWS.Models.Ticket", "Ticket")
                        .WithMany("Votos_Ticket")
                        .HasForeignKey("TicketId");

                    b.HasOne("ServicesDeskUCABWS.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Ticket");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Empleado", b =>
                {
                    b.HasOne("ServicesDeskUCABWS.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Cargo", b =>
                {
                    b.Navigation("Tipo_Cargo");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Departamento", b =>
                {
                    b.Navigation("Cargo");

                    b.Navigation("Estado");

                    b.Navigation("ListaTickets");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Estado", b =>
                {
                    b.Navigation("Bitacora_Tickets");

                    b.Navigation("ListaTickets");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Familia_Ticket", b =>
                {
                    b.Navigation("Lista_Ticket");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Grupo", b =>
                {
                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Ticket", b =>
                {
                    b.Navigation("Bitacora_Tickets");

                    b.Navigation("Votos_Ticket");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Tipo_Cargo", b =>
                {
                    b.Navigation("Flujo_Aprobacion");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Tipo_Ticket", b =>
                {
                    b.Navigation("Flujo_Aprobacion");
                });

            modelBuilder.Entity("ServicesDeskUCABWS.Models.Empleado", b =>
                {
                    b.Navigation("Lista_Ticket");

                    b.Navigation("Votos_Ticket");
                });
#pragma warning restore 612, 618
        }
    }
}

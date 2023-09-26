using System;
using System.Collections.Generic;
using ESFE.ControlBoletos.EN;
using Microsoft.EntityFrameworkCore;

namespace ESFE.ControlBoletos.DAL.DataContext;

 public partial class ControlDeVentaBoletosContext : DbContext
{
    public ControlDeVentaBoletosContext()
    {
    }

    public ControlDeVentaBoletosContext(DbContextOptions<ControlDeVentaBoletosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asignacion> Asignacions { get; set; }

    public virtual DbSet<Boleto> Boletos { get; set; }

    public virtual DbSet<BoletosVendido> BoletosVendidos { get; set; }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<Docente> Docentes { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asignacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Asignaci__3214EC073F6AB210");

            entity.ToTable("Asignacion");

            entity.Property(e => e.CantBoletosAsignados)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsig).HasColumnType("datetime");

            entity.HasOne(d => d.IdBoletoNavigation).WithMany(p => p.Asignacions)
                .HasForeignKey(d => d.IdBoleto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__IdBol__45F365D3");

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.Asignacions)
                .HasForeignKey(d => d.IdDocente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__IdDoc__46E78A0C");
        });

        modelBuilder.Entity<Boleto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Boleto__3214EC079DA5A0B2");

            entity.ToTable("Boleto");

            entity.Property(e => e.Years)
                .HasColumnType("datetime")
                .HasColumnName("years");
        });

        modelBuilder.Entity<BoletosVendido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BoletosV__3214EC072DE725FF");

            entity.Property(e => e.CantidadVendida)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FechaReporte).HasColumnType("datetime");

            entity.HasOne(d => d.IdBoletoNavigation).WithMany(p => p.BoletosVendidos)
                .HasForeignKey(d => d.IdBoleto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoletosVe__IdBol__4D94879B");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.BoletosVendidos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoletosVe__IdUsu__4E88ABD4");
        });

        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Carrera__3214EC0795338F9A");

            entity.ToTable("Carrera");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Docente__3214EC070844D0F0");

            entity.ToTable("Docente");

            entity.Property(e => e.Grupo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estado__3214EC074AC5D53C");

            entity.ToTable("Estado");

            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Grupo__3214EC072B4986A6");

            entity.ToTable("Grupo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAsignacionNavigation).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.IdAsignacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grupo__IdAsignac__4AB81AF0");

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.IdDocente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grupo__IdDocente__49C3F6B7");
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Turno__3214EC076E1D8346");

            entity.ToTable("Turno");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC079429FF65");

            entity.ToTable("Usuario");

            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

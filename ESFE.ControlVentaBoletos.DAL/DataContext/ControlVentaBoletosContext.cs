using System;
using System.Collections.Generic;
using ESFE.ControlVentaBoletos.EN;
using Microsoft.EntityFrameworkCore;

namespace ESFE.ControlVentaBoletos.DAL.DataContext;

public partial class ControlVentaBoletosContext : DbContext
{
    public ControlVentaBoletosContext()
    {
    }

    public ControlVentaBoletosContext(DbContextOptions<ControlVentaBoletosContext> options)
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
            entity.HasKey(e => e.Id).HasName("PK__Asignaci__3214EC07A4327C4E");

            entity.ToTable("Asignacion");

            entity.Property(e => e.CantBoletosAsignados)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsig).HasColumnType("datetime");

            entity.HasOne(d => d.IdBoletoNavigation).WithMany(p => p.Asignacions)
                .HasForeignKey(d => d.IdBoleto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__IdBol__44FF419A");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.Asignacions)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__IdGru__45F365D3");
        });

        modelBuilder.Entity<Boleto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Boleto__3214EC078E8E4A26");

            entity.ToTable("Boleto");

            entity.Property(e => e.Years)
                .HasColumnType("datetime")
                .HasColumnName("years");
        });

        modelBuilder.Entity<BoletosVendido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BoletosV__3214EC0727237CB3");

            entity.Property(e => e.CantidadVendida)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FechaReporte).HasColumnType("datetime");

            entity.HasOne(d => d.IdAsignacionNavigation).WithMany(p => p.BoletosVendidos)
                .HasForeignKey(d => d.IdAsignacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoletosVe__IdAsi__49C3F6B7");

            entity.HasOne(d => d.IdBoletoNavigation).WithMany(p => p.BoletosVendidos)
                .HasForeignKey(d => d.IdBoleto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoletosVe__IdBol__48CFD27E");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.BoletosVendidos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BoletosVe__IdUsu__4AB81AF0");
        });

        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Carrera__3214EC07968B3F7A");

            entity.ToTable("Carrera");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Docente__3214EC07866EE67A");

            entity.ToTable("Docente");

            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estado__3214EC077553C7A2");

            entity.ToTable("Estado");

            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Grupo__3214EC07D41DD947");

            entity.ToTable("Grupo");

            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.Grupos)
                .HasForeignKey(d => d.IdDocente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Grupo__IdDocente__4222D4EF");
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Turno__3214EC071DA65579");

            entity.ToTable("Turno");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC073595E25D");

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

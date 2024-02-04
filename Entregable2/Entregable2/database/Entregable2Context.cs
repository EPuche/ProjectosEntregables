﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Entregable2.models;

namespace Entregable2.database
{
    public partial class Entregable2Context : DbContext
    {
        public Entregable2Context()
        {
        }

        public Entregable2Context(DbContextOptions<Entregable2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<ProductoVendido> ProductoVendidos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Venta> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost; Database=coderhouse; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Producto");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Producto_Usuario");
            });

            modelBuilder.Entity<ProductoVendido>(entity =>
            {
                entity.ToTable("ProductoVendido");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductoVendidos)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductoVendido_Producto");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.ProductoVendidos)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductoVendido_Venta");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Mail).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Venta_Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

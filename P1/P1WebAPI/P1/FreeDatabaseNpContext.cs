﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace P1;

public partial class FreeDatabaseNpContext : DbContext
{
    public FreeDatabaseNpContext()
    {
    }

    public FreeDatabaseNpContext(DbContextOptions<FreeDatabaseNpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Gunpla> Gunplas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("ConnectionStrings:dbconncetionstring");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Grade__3213E83F62AD0618");

            entity.ToTable("Grade");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Grade1)
                .HasMaxLength(5)
                .HasColumnName("grade");
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Models__3213E83F1752BD9D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(400)
                .HasColumnName("description");
            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .HasColumnName("grade");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Status__3213E83F8D32F4D5");

            entity.ToTable("Status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status1)
                .HasMaxLength(10)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Gunpla>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.ToView("Gunpla");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnName("description");
            entity.Property(e => e.Grade)
                .HasColumnName("grade");
            entity.Property(e => e.Name)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasColumnName("type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using ApplicationTracker.PL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationTracker.PL.Data;

public partial class ApplicationTrackerEntities : DbContext
{

    public virtual DbSet<tblApplication> ApplicationTrackers { get; set; }
    public ApplicationTrackerEntities()
    {
    }

    public ApplicationTrackerEntities(DbContextOptions<ApplicationTrackerEntities> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ApplicationTracker.DB;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);

        CreateApplications();
    }

    private void CreateApplications(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblApplication_Id");

            entity.ToTable("tblApplication");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .IsRequired()
                .HasColumnType("datetime")
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

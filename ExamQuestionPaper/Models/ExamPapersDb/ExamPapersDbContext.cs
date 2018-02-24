using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExamQuestionPaper.Models.ExamPapersDb
{
    public partial class ExamPapersDbContext : DbContext
    {
        public virtual DbSet<TblConstants> TblConstants { get; set; }
        public virtual DbSet<TblQuestionPapers> TblQuestionPapers { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }

        public ExamPapersDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblConstants>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("tblConstants");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ValueString)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQuestionPapers>(entity =>
            {
                entity.ToTable("tblQuestionPapers");

                entity.Property(e => e.ChunkHash)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.ToTable("tblUsers");

                entity.HasIndex(e => e.Username)
                    .HasName("UQ__tblUsers__536C85E4D881D26B")
                    .IsUnique();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}

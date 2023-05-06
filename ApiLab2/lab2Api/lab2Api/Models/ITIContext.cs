using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lab2Api.Models
{
    public partial class ITIContext : DbContext
    {
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }

        public ITIContext(DbContextOptions<ITIContext> options) : base(options)
        {
        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CrsId).ValueGeneratedNever();

                entity.HasOne(d => d.Top)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.TopId)
                    .HasConstraintName("FK_Course_Topic");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.TopId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

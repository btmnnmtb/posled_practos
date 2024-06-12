using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Models
{
    public partial class ExampleeContext : DbContext
    {
        public ExampleeContext()
        {
        }

        public ExampleeContext(DbContextOptions<ExampleeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Colour> Colours { get; set; } = null!;
        public virtual DbSet<Human> Humans { get; set; } = null!;

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colour>(entity =>
            {
                entity.ToTable("Colour");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kod");

                entity.Property(e => e.NameColor)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name_color");
            });

            modelBuilder.Entity<Human>(entity =>
            {
                entity.ToTable("Human");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColorId).HasColumnName("color_id");

                entity.Property(e => e.NameMan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_man");

               
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TriviaWebService.Models
{
    public partial class Trivia_App_DatabaseContext : DbContext
    {
        public Trivia_App_DatabaseContext()
        {
        }

        public Trivia_App_DatabaseContext(DbContextOptions<Trivia_App_DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tadcityweathers> Tadcityweathers { get; set; }
        public virtual DbSet<TadcountryPopulations> TadcountryPopulations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Yoga-T;Database=Trivia_App_Database;Trusted_Connection=True;integrated security=false;user=accessor;password=Only4theaccessor");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Tadcityweathers>(entity =>
            {
                entity.ToTable("TADcityweathers");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TadcountryPopulations>(entity =>
            {
                entity.ToTable("TADcountry_populations");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.TestColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}

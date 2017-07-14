using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HousingManager.Data.Library.Model1
{
    public partial class HousingManagerDBContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=mya-sqltraining.cyefvq57nyy3.us-east-2.rds.amazonaws.com;Initial Catalog=HousingManagerDB;User ID=admin;Password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "Apartment");

                entity.Property(e => e.AptNum)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StreetName)
                    .IsRequired()
                    .HasMaxLength(200);
            });
        }
    }
}
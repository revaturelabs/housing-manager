using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HousingManager.Data.Library.EFModels
{
    public partial class HousingManager_DB_SqlServerContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ApartmentComplex> ApartmentComplex { get; set; }
        public virtual DbSet<ApartmentRequest> ApartmentRequest { get; set; }
        public virtual DbSet<ApartmentSupplyRequest> ApartmentSupplyRequest { get; set; }
        public virtual DbSet<ApartmentUnit> ApartmentUnit { get; set; }
        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<BatchType> BatchType { get; set; }
        public virtual DbSet<ContactInfo> ContactInfo { get; set; }
        public virtual DbSet<HouseKeeping> HouseKeeping { get; set; }
        public virtual DbSet<MaintenanceRequest> MaintenanceRequest { get; set; }
        public virtual DbSet<MaintenanceType> MaintenanceType { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonContactInfo> PersonContactInfo { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderContactInfo> ProviderContactInfo { get; set; }
        public virtual DbSet<ProviderSupplyRequest> ProviderSupplyRequest { get; set; }
        public virtual DbSet<Supply> Supply { get; set; }
        public virtual DbSet<TenantInfo> TenantInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=HousingManager.DB.SqlServer;Trusted_Connection=True;");
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

            modelBuilder.Entity<ApartmentComplex>(entity =>
            {
                entity.ToTable("ApartmentComplex", "Apartment");

                entity.Property(e => e.ApartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WalkingDistance).HasDefaultValueSql("1");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ApartmentComplex)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Apartment_ApartmentComplex_AddressId");
            });

            modelBuilder.Entity<ApartmentRequest>(entity =>
            {
                entity.ToTable("ApartmentRequest", "Request");

                entity.Property(e => e.Submitted).HasColumnType("datetime");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ApartmentRequest)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_ApartmentRequest_ManagerId");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ApartmentRequest)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_ApartmentRequest_ProviderId");
            });

            modelBuilder.Entity<ApartmentSupplyRequest>(entity =>
            {
                entity.HasKey(e => e.SupplyRequestId)
                    .HasName("PK__Apartmen__63400C5EDB48761F");

                entity.ToTable("ApartmentSupplyRequest", "Request");

                entity.Property(e => e.Submitted).HasColumnType("datetime");

                entity.HasOne(d => d.ApartmentUnit)
                    .WithMany(p => p.ApartmentSupplyRequest)
                    .HasForeignKey(d => d.ApartmentUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_ApartmentSupplyRequest_ApartmentUnitId");

                entity.HasOne(d => d.Supply)
                    .WithMany(p => p.ApartmentSupplyRequest)
                    .HasForeignKey(d => d.SupplyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_ApartmentSupplyRequest_SupplyId");
            });

            modelBuilder.Entity<ApartmentUnit>(entity =>
            {
                entity.ToTable("ApartmentUnit", "Apartment");

                entity.HasIndex(e => e.AddressId)
                    .HasName("UQ__Apartmen__091C2AFA54FD1F31")
                    .IsUnique();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.ApartmentUnit)
                    .HasForeignKey<ApartmentUnit>(d => d.AddressId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Apartment_ApartmentUnit_ApartmentId");

                entity.HasOne(d => d.ApartmentComplex)
                    .WithMany(p => p.ApartmentUnit)
                    .HasForeignKey(d => d.ApartmentComplexId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Apartment_ApartmentUnit_ApartmentComplexId");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ApartmentUnit)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Apartment_ApartmentUnit_ProviderId");
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.ToTable("Batch", "Batch");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StarDate).HasColumnType("datetime");

                entity.HasOne(d => d.BatchType)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.BatchTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Batch_Batch_BatchType");
            });

            modelBuilder.Entity<BatchType>(entity =>
            {
                entity.ToTable("BatchType", "Batch");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.ToTable("ContactInfo", "Person");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HouseKeeping>(entity =>
            {
                entity.ToTable("HouseKeeping", "Apartment");

                entity.HasIndex(e => e.ApartmentUnitId)
                    .HasName("UQ__HouseKee__446DA741760A3A53")
                    .IsUnique();

                entity.Property(e => e.LastCleaning).HasColumnType("date");

                entity.Property(e => e.NextCleaning).HasColumnType("date");
            });

            modelBuilder.Entity<MaintenanceRequest>(entity =>
            {
                entity.ToTable("MaintenanceRequest", "Request");

                entity.Property(e => e.Desctiption)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MaintenanceTypeId).HasColumnName("MaintenanceTypeID");

                entity.Property(e => e.Submitted).HasColumnType("datetime");

                entity.HasOne(d => d.ApartmentUnit)
                    .WithMany(p => p.MaintenanceRequestApartmentUnit)
                    .HasForeignKey(d => d.ApartmentUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_MaintenanceRequest_ApartmentUnitId");

                entity.HasOne(d => d.MaintenanceType)
                    .WithMany(p => p.MaintenanceRequestMaintenanceType)
                    .HasForeignKey(d => d.MaintenanceTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_MaintenanceRequest_MaintenanceRequestTypeID");
            });

            modelBuilder.Entity<MaintenanceType>(entity =>
            {
                entity.ToTable("MaintenanceType", "Request");

                entity.Property(e => e.Issue)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person", "Person");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PersonContactInfo>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.ContactInfoId })
                    .HasName("PK_Person_PersonContactInfo_PersonId_ContactInfoId");

                entity.ToTable("PersonContactInfo", "Person");

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.PersonContactInfo)
                    .HasForeignKey(d => d.ContactInfoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_PersonContactInfo_ContactInfoId");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonContactInfo)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_PersonContactInfo_PersonId");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider", "Person");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProviderContactInfo>(entity =>
            {
                entity.HasKey(e => new { e.ProviderId, e.ContactInfoId })
                    .HasName("PK_Person_ProviderContactInfo_ProviderId_ContactInfoId");

                entity.ToTable("ProviderContactInfo", "Person");

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.ProviderContactInfo)
                    .HasForeignKey(d => d.ContactInfoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_ProviderContactInfo_ContactInfoId");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderContactInfo)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_ProviderContactInfo_ProviderId");
            });

            modelBuilder.Entity<ProviderSupplyRequest>(entity =>
            {
                entity.HasKey(e => e.SupplyRequestId)
                    .HasName("PK__Provider__63400C5E8A3D9DFF");

                entity.ToTable("ProviderSupplyRequest", "Request");

                entity.Property(e => e.Submitted).HasColumnType("datetime");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ProviderSupplyRequest)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_ProviderSupplyRequest_ManagerId");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderSupplyRequest)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_ProviderSupplyRequest_ProviderId");

                entity.HasOne(d => d.Supply)
                    .WithMany(p => p.ProviderSupplyRequest)
                    .HasForeignKey(d => d.SupplyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Request_ProviderSupplyRequest_SupplyId");
            });

            modelBuilder.Entity<Supply>(entity =>
            {
                entity.ToTable("Supply", "Request");

                entity.Property(e => e.SupplyId).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TenantInfo>(entity =>
            {
                entity.HasKey(e => e.TenantInfo1)
                    .HasName("PK__TenantIn__5496378A513CAF41");

                entity.ToTable("TenantInfo", "Person");

                entity.HasIndex(e => e.PersonId)
                    .HasName("UQ__TenantIn__AA2FFBE46BD69E04")
                    .IsUnique();

                entity.Property(e => e.TenantInfo1).HasColumnName("TenantInfo");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MoveInDate).HasColumnType("datetime");

                entity.Property(e => e.MoveOutDate).HasColumnType("datetime");

                entity.HasOne(d => d.ApartmentUnit)
                    .WithMany(p => p.TenantInfo)
                    .HasForeignKey(d => d.ApartmentUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_TenantInfo_ApartmentUnitId");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.TenantInfo)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_TenantInfo_BatchId");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.TenantInfo)
                    .HasForeignKey<TenantInfo>(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Person_TenantInfo_PersonId");
            });
        }
    }
}
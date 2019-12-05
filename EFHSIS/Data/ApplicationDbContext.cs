using System;
using System.Collections.Generic;
using System.Text;
using EFHSIS.Models;
using EFHSIS.Models.EFHSISModels;
using EFHSIS.Models.GraphModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFHSIS.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<User,IdentityRole<int>,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Barangay> Barangay { get; set; }
        public virtual DbSet<ChildCare> ChildCare { get; set; }
        public virtual DbSet<CopyOfProvDate1> CopyOfProvDate1 { get; set; }
        public virtual DbSet<DemographicProfile> DemographicProfile { get; set; }
        public virtual DbSet<DentalHealth> DentalHealth { get; set; }
        public virtual DbSet<EnvironmentalHealth> EnvironmentalHealth { get; set; }
        public virtual DbSet<FacilityProfile> FacilityProfile { get; set; }
        public virtual DbSet<FamilyPlanning> FamilyPlanning { get; set; }
        public virtual DbSet<Fhud1> Fhud1 { get; set; }
        public virtual DbSet<Fhud2> Fhud2 { get; set; }
        public virtual DbSet<Fhud5> Fhud5 { get; set; }
        public virtual DbSet<Filariasis> Filariasis { get; set; }
        public virtual DbSet<Icd10code> Icd10code { get; set; }
        public virtual DbSet<Leprocy> Leprocy { get; set; }
        public virtual DbSet<M2Bhs> M2Bhs { get; set; }
        public virtual DbSet<Malaria> Malaria { get; set; }
        public virtual DbSet<MaternalCare> MaternalCare { get; set; }
        public virtual DbSet<Month> Month { get; set; }
        public virtual DbSet<MortBhs> MortBhs { get; set; }
        public virtual DbSet<Mortality> Mortality { get; set; }
        public virtual DbSet<MunPopulation> MunPopulation { get; set; }
        public virtual DbSet<Muncity> Muncity { get; set; }
        public virtual DbSet<NameAutoCorrectSaveFailures> NameAutoCorrectSaveFailures { get; set; }
        public virtual DbSet<Natality> Natality { get; set; }
        public virtual DbSet<NatalityLcr> NatalityLcr { get; set; }
        public virtual DbSet<NatalityTcl> NatalityTcl { get; set; }
        public virtual DbSet<OtherIndicators> OtherIndicators { get; set; }
        public virtual DbSet<OtherPrograms> OtherPrograms { get; set; }
        public virtual DbSet<PasteErrors> PasteErrors { get; set; }
        public virtual DbSet<Population> Population { get; set; }
        public virtual DbSet<PrintOut> PrintOut { get; set; }
        public virtual DbSet<ProvDate> ProvDate { get; set; }
        public virtual DbSet<ProvDate1> ProvDate1 { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Schistosomiasis> Schistosomiasis { get; set; }
        public virtual DbSet<Sti> Sti { get; set; }
        public virtual DbSet<SwitchboardItems> SwitchboardItems { get; set; }
        public virtual DbSet<Tuberculosis> Tuberculosis { get; set; }
        public virtual DbSet<Useraccounts> Useraccounts { get; set; }
        public virtual DbSet<ChildCareGraph> ChildCareGraph { get; set; }
        public virtual DbSet<Consolidated> Consolidated { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ROCKY\\SQLEXPRESS;Initial Catalog=EFHSIS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Barangay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.BgyDesc).IsUnicode(false);

                entity.Property(e => e.Field1).IsUnicode(false);

                entity.Property(e => e.Hc).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);
            });

            modelBuilder.Entity<ChildCare>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<ChildCareGraph>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PROV_CODE).IsUnicode(false);
            });

            modelBuilder.Entity<Consolidated>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<CopyOfProvDate1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvDesc).IsUnicode(false);

                entity.Property(e => e.RegDesc).IsUnicode(false);
            });

            modelBuilder.Entity<DemographicProfile>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.BgyDesc).IsUnicode(false);

                entity.Property(e => e.Field1).IsUnicode(false);

                entity.Property(e => e.Hc).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);
            });

            modelBuilder.Entity<DentalHealth>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<EnvironmentalHealth>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);

                entity.Property(e => e.YearEnv).IsUnicode(false);
            });

            modelBuilder.Entity<FacilityProfile>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);

                entity.Property(e => e.Year).IsUnicode(false);
            });

            modelBuilder.Entity<FamilyPlanning>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Fhud1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.MunDesc).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);
            });

            modelBuilder.Entity<Fhud2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.BgyDesc).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);
            });

            modelBuilder.Entity<Fhud5>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.BgyDesc).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Filariasis>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Icd10code>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code).IsUnicode(false);
            });

            modelBuilder.Entity<Leprocy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<M2Bhs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Malaria>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<MaternalCare>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Month>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.Month1).IsUnicode(false);
            });

            modelBuilder.Entity<MortBhs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Mortality>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<MunPopulation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.PopYear).IsUnicode(false);
            });

            modelBuilder.Entity<Muncity>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cat).IsUnicode(false);

                entity.Property(e => e.Ilhz).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.MunDesc).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);
            });

            modelBuilder.Entity<NameAutoCorrectSaveFailures>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FailureReason).IsUnicode(false);

                entity.Property(e => e.ObjectName).IsUnicode(false);

                entity.Property(e => e.ObjectType).IsUnicode(false);
            });

            modelBuilder.Entity<Natality>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<NatalityLcr>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<NatalityTcl>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<OtherIndicators>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActInd).IsUnicode(false);

                entity.Property(e => e.Program).IsUnicode(false);
            });

            modelBuilder.Entity<OtherPrograms>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.Program).IsUnicode(false);
            });

            modelBuilder.Entity<PasteErrors>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Field0).IsUnicode(false);
            });

            modelBuilder.Entity<Population>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.PopYear).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<PrintOut>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PrtOut).IsUnicode(false);
            });

            modelBuilder.Entity<ProvDate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvDesc).IsUnicode(false);

                entity.Property(e => e.RegDesc).IsUnicode(false);
            });

            modelBuilder.Entity<ProvDate1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvDesc).IsUnicode(false);

                entity.Property(e => e.RegDesc).IsUnicode(false);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.ProvDesc).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RegCode).IsUnicode(false);

                entity.Property(e => e.RegDesc).IsUnicode(false);
            });

            modelBuilder.Entity<Schistosomiasis>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Sti>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<SwitchboardItems>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Argument).IsUnicode(false);

                entity.Property(e => e.Command).IsUnicode(false);

                entity.Property(e => e.ItemText).IsUnicode(false);
            });

            modelBuilder.Entity<Tuberculosis>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BgyCode).IsUnicode(false);

                entity.Property(e => e.MunCode).IsUnicode(false);

                entity.Property(e => e.ProvCode).IsUnicode(false);

                entity.Property(e => e.RegCode).IsUnicode(false);
            });

            modelBuilder.Entity<Useraccounts>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Aclev).IsUnicode(false);

                entity.Property(e => e.Pwd).IsUnicode(false);

                entity.Property(e => e.Usname).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

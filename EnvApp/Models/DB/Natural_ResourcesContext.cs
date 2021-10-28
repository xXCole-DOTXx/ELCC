using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EnvApp.Models.DB
{
    public partial class Natural_ResourcesContext : DbContext
    {
        public Natural_ResourcesContext()
        {
        }

        public Natural_ResourcesContext(DbContextOptions<Natural_ResourcesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NR_User> NR_Users { get; set; }
        public virtual DbSet<Project_Screen> Project_Screen { get; set; }
        public virtual DbSet<TypeOne> TypeOne { get; set; }

     /*   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=dotb6gisdbst01;Initial Catalog=Natural_Resources ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<NrUser>(entity =>
            {
                entity.ToTable("NR_Users");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdNumber)
                    .HasMaxLength(10)
                    .HasColumnName("AD_Number");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .HasColumnName("Email_Address");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserType)
                    .HasMaxLength(30)
                    .HasColumnName("User_Type");
            });

            modelBuilder.Entity<ProjectScreen>(entity =>
            {
                entity.ToTable("Project_Screen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adduser).HasMaxLength(20);

                entity.Property(e => e.ArchaeologyPm)
                    .HasMaxLength(50)
                    .HasColumnName("Archaeology_PM");

                entity.Property(e => e.Authorization).HasMaxLength(50);

                entity.Property(e => e.BatHabitat).HasColumnName("Bat_Habitat");

                entity.Property(e => e.County).HasMaxLength(50);

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("Date_Added");

                entity.Property(e => e.DsnPm)
                    .HasMaxLength(50)
                    .HasColumnName("DSN_PM");

                entity.Property(e => e.EsaKey).HasColumnName("ESA_Key");

                entity.Property(e => e.FederalProjectNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Federal_Project_Number");

                entity.Property(e => e.From).HasMaxLength(50);

                entity.Property(e => e.HistoryPm)
                    .HasMaxLength(50)
                    .HasColumnName("History_PM");

                entity.Property(e => e.MemoDate)
                    .HasColumnType("date")
                    .HasColumnName("Memo_Date");

                entity.Property(e => e.MusselHabitat).HasColumnName("Mussel_Habitat");

                entity.Property(e => e.Nleb4d).HasColumnName("NLEB_4D");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Name");

                entity.Property(e => e.ReviewExemptA).HasColumnName("Review_Exempt_A");

                entity.Property(e => e.ReviewExemptH).HasColumnName("Review_Exempt_H");

                entity.Property(e => e.ShpoApprovalA).HasColumnName("SHPO_Approval_A");

                entity.Property(e => e.ShpoApprovalH).HasColumnName("SHPO_Approval_H");

                entity.Property(e => e.StateProjectNumber)
                    .HasMaxLength(50)
                    .HasColumnName("State_Project_Number");

                entity.Property(e => e.Usfws).HasColumnName("USFWS");
            });

            modelBuilder.Entity<TypeOne>(entity =>
            {
                entity.ToTable("Type_One");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessControl).HasColumnName("Access_Control");

                entity.Property(e => e.Adduser).HasMaxLength(20);

                entity.Property(e => e.AgencyCoordination).HasColumnName("Agency_Coordination");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.CeCategory)
                    .HasMaxLength(50)
                    .HasColumnName("CE_Category");

                entity.Property(e => e.CloseRoad).HasColumnName("Close_Road");

                entity.Property(e => e.County).HasMaxLength(50);

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("Date_Added");

                entity.Property(e => e.EnvGisScreen).HasColumnName("Env_GIS_Screen");

                entity.Property(e => e.FederalAid).HasColumnName("Federal_Aid");

                entity.Property(e => e.FederalProjectNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Federal_Project_Number");

                entity.Property(e => e.GisScreen).HasColumnName("GIS_Screen");

                entity.Property(e => e.GroundDisturbance).HasColumnName("Ground_Disturbance");

                entity.Property(e => e.Latitude).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PceProjectVerification).HasColumnName("PCE_Project_Verification");

                entity.Property(e => e.PreparedBy)
                    .HasMaxLength(20)
                    .HasColumnName("Prepared_By");

                entity.Property(e => e.ProjectDescription).HasColumnName("Project_Description");

                entity.Property(e => e.RouteNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Route_Number");

                entity.Property(e => e.RowAcquisition).HasColumnName("ROW_Acquisition");

                entity.Property(e => e.Section404Permit).HasColumnName("Section_404_Permit");

                entity.Property(e => e.SpecialUsePermit).HasColumnName("Special_Use_Permit");

                entity.Property(e => e.StateProjectId).HasColumnName("State_ProjectID");

                entity.Property(e => e.ThroughLanes).HasColumnName("Through_Lanes");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(50)
                    .HasColumnName("Work_Type");

                entity.Property(e => e._50YearStructure).HasColumnName("50_Year_Structure");

                entity.HasOne(d => d.StateProject)
                    .WithMany(p => p.TypeOnes)
                    .HasForeignKey(d => d.StateProjectId)
                    .HasConstraintName("FK_Type_One_Project_Screen");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        */
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    } 
}

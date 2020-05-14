using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SampleApplication.Models;

namespace SampleApplication.DbContexts
{
    public partial class CrsContext : DbContext
    {
        public CrsContext()
        {
        }

        public CrsContext(DbContextOptions<CrsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessAuthentication> AccessAuthentication { get; set; }
        public virtual DbSet<ActionMaster> ActionMaster { get; set; }
        public virtual DbSet<AppTechnology> AppTechnology { get; set; }
        public virtual DbSet<Associate> Associate { get; set; }
        public virtual DbSet<AssociateRole> AssociateRole { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Facility> Facility { get; set; }
        public virtual DbSet<Functions> Functions { get; set; }
        public virtual DbSet<LocationMaster> LocationMaster { get; set; }
        public virtual DbSet<Port> Port { get; set; }
        public virtual DbSet<ProjectDetail> ProjectDetail { get; set; }
        public virtual DbSet<PublishTypeOther> PublishTypeOther { get; set; }
        public virtual DbSet<PublishTypeOtherValue> PublishTypeOtherValue { get; set; }
        public virtual DbSet<RequestCategoryMaster> RequestCategoryMaster { get; set; }
        public virtual DbSet<RequestCategoryMaster1> RequestCategoryMaster1 { get; set; }
        public virtual DbSet<RequestDetail> RequestDetail { get; set; }
        public virtual DbSet<RequestDetailStatus> RequestDetailStatus { get; set; }
        public virtual DbSet<RequestHeader> RequestHeader { get; set; }
        public virtual DbSet<RequestHeader1> RequestHeader1 { get; set; }
        public virtual DbSet<RequestTypeMaster> RequestTypeMaster { get; set; }
        public virtual DbSet<RequestTypeMaster1> RequestTypeMaster1 { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<ServerLocation> ServerLocation { get; set; }
        public virtual DbSet<ServerType> ServerType { get; set; }
        public virtual DbSet<StatusMaster> StatusMaster { get; set; }
        public virtual DbSet<StatusMaster1> StatusMaster1 { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Worklog> Worklog { get; set; }
        public virtual DbSet<Worklog1> Worklog1 { get; set; }

//        protected override void 
//            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=ctsinazmyaccessdb.database.windows.net;Database=MyAccess;Trusted_Connection=False;Encrypt=True;User Id=myaccessadmin; Password=one+two#3;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessAuthentication>(entity =>
            {
                entity.HasKey(e => e.AccessAuthId);

                entity.ToTable("AccessAuthentication", "Master");

                entity.Property(e => e.AccessAuthId).HasColumnName("AccessAuthID");

                entity.Property(e => e.AccessAuthName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActionMaster>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK__ActionMa__FFE3F4B98A1F35C3");

                entity.ToTable("ActionMaster", "Workflow");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppTechnology>(entity =>
            {
                entity.HasKey(e => e.AppTechId)
                    .HasName("PK_AppTechnlolgy");

                entity.ToTable("AppTechnology", "Master");

                entity.Property(e => e.AppTechId).HasColumnName("AppTechID");

                entity.Property(e => e.AppTechName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Associate>(entity =>
            {
                entity.ToTable("Associate", "CRS");

                entity.Property(e => e.AssociateId)
                    .HasColumnName("AssociateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssociateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssociateRole>(entity =>
            {
                entity.ToTable("AssociateRole", "CRS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssociateId).HasColumnName("AssociateID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City", "Master");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "Master");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.ToTable("Facility", "Master");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.CityId)
                    .IsRequired()
                    .HasColumnName("CityID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityHcmcode)
                    .IsRequired()
                    .HasColumnName("FacilityHCMCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityHcmdescription)
                    .IsRequired()
                    .HasColumnName("FacilityHCMDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GsmsbuildingId)
                    .HasColumnName("GSMSBuildingID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GsmsbuildingName)
                    .HasColumnName("GSMSBuildingName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MyAccessLocationId)
                    .HasColumnName("MyAccessLocationID")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Functions>(entity =>
            {
                entity.HasKey(e => e.FunctionName)
                    .HasName("PK__Function__7A54611A10BC9A9F");

                entity.ToTable("Functions", "Stub");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocationMaster>(entity =>
            {
                entity.ToTable("LocationMaster", "Master");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CityId)
                    .HasColumnName("CityID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GsmsbuildingId).HasColumnName("GSMSBuildingID");

                entity.Property(e => e.GsmsbuildingName)
                    .HasColumnName("GSMSBuildingName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HcmlocationDescription)
                    .HasColumnName("HCMLocationDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MyAccessLocationId)
                    .HasColumnName("MyAccessLocationID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewHcmlocationCode)
                    .HasColumnName("NewHCMLocationCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Port>(entity =>
            {
                entity.ToTable("Port", "Master");

                entity.Property(e => e.PortId).HasColumnName("PortID");

                entity.Property(e => e.PortDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Protocol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectDetail>(entity =>
            {
                entity.HasKey(e => e.AssociateId)
                    .HasName("PK__ProjectD__AC40220FD3E6082D");

                entity.ToTable("ProjectDetail", "CRS");

                entity.Property(e => e.AssociateId)
                    .HasColumnName("AssociateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectEndDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalId).HasColumnName("VerticalID");

                entity.Property(e => e.VerticalName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PublishTypeOther>(entity =>
            {
                entity.ToTable("PublishTypeOther", "Master");

                entity.Property(e => e.PublishTypeOtherId).HasColumnName("PublishTypeOtherID");

                entity.Property(e => e.PublishTypeOtherName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PublishTypeOtherValue>(entity =>
            {
                entity.ToTable("PublishTypeOtherValue", "Master");

                entity.Property(e => e.PublishTypeOtherValueId).HasColumnName("PublishTypeOtherValueID");

                entity.Property(e => e.PublishTypeOtherId).HasColumnName("PublishTypeOtherID");

                entity.Property(e => e.PublishTypeOtherValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequestCategoryMaster>(entity =>
            {
                entity.HasKey(e => e.ReqCategoryId)
                    .HasName("PK__RequestC__C4B41ADD60CBD0EA");

                entity.ToTable("RequestCategoryMaster", "Provision");

                entity.Property(e => e.ReqCategoryId)
                    .HasColumnName("ReqCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReqCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequestCategoryMaster1>(entity =>
            {
                entity.HasKey(e => e.ReqCategoryId)
                    .HasName("PK__RequestC__C4B41ADDDC6EA1B8");

                entity.ToTable("RequestCategoryMaster", "Workflow");

                entity.Property(e => e.ReqCategoryId)
                    .HasColumnName("ReqCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReqCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequestDetail>(entity =>
            {
                entity.HasKey(e => e.ReqDetailId)
                    .HasName("PK__RequestD__00EC42EDE071B37D");

                entity.ToTable("RequestDetail", "Provision");

                entity.Property(e => e.ReqDetailId)
                    .HasColumnName("ReqDetailID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestIp)
                    .IsRequired()
                    .HasColumnName("DestIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Facility)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.Property(e => e.SourceIp)
                    .IsRequired()
                    .HasColumnName("SourceIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<RequestDetailStatus>(entity =>
            {
                entity.HasKey(e => e.ReqDetailId)
                    .HasName("PK__RequestD__00EC42ED62346B1C");

                entity.ToTable("RequestDetailStatus", "Workflow");

                entity.Property(e => e.ReqDetailId).HasColumnName("ReqDetailID");

                entity.Property(e => e.LastActionId).HasColumnName("LastActionID");

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<RequestHeader>(entity =>
            {
                entity.HasKey(e => e.ReqId)
                    .HasName("PK__RequestH__28A9A3A24438695E");

                entity.ToTable("RequestHeader", "Provision");

                entity.Property(e => e.ReqId)
                    .HasColumnName("ReqID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssociateId).HasColumnName("AssociateID");

                entity.Property(e => e.AssociateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmid).HasColumnName("PMID");

                entity.Property(e => e.ProjectId)
                    .IsRequired()
                    .HasColumnName("ProjectID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ReqCategoryId).HasColumnName("ReqCategoryID");

                entity.Property(e => e.ReqDate).HasColumnType("datetime");

                entity.Property(e => e.ReqTypeId).HasColumnName("ReqTypeID");
            });

            modelBuilder.Entity<RequestHeader1>(entity =>
            {
                entity.HasKey(e => e.ReqId)
                    .HasName("PK__RequestH__28A9A3A21F23F34B");

                entity.ToTable("RequestHeader", "Workflow");

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.Property(e => e.AssociateId).HasColumnName("AssociateID");

                entity.Property(e => e.Pmid).HasColumnName("PMID");

                entity.Property(e => e.ReqCategoryId).HasColumnName("ReqCategoryID");

                entity.Property(e => e.ReqDate).HasColumnType("datetime");

                entity.Property(e => e.ReqTypeId).HasColumnName("ReqTypeID");
            });

            modelBuilder.Entity<RequestTypeMaster>(entity =>
            {
                entity.HasKey(e => e.ReqTypeId)
                    .HasName("PK__RequestT__AC88A47E2EAED04B");

                entity.ToTable("RequestTypeMaster", "Provision");

                entity.Property(e => e.ReqTypeId)
                    .HasColumnName("ReqTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReqTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequestTypeMaster1>(entity =>
            {
                entity.HasKey(e => e.ReqTypeId)
                    .HasName("PK__RequestT__AC88A47EEE8586DD");

                entity.ToTable("RequestTypeMaster", "Workflow");

                entity.Property(e => e.ReqTypeId)
                    .HasColumnName("ReqTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReqTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "Master");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__RoleMast__8AFACE3AF86EFF6C");

                entity.ToTable("RoleMaster", "CRS");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServerLocation>(entity =>
            {
                entity.ToTable("ServerLocation", "Master");

                entity.Property(e => e.ServerLocationId).HasColumnName("ServerLocationID");

                entity.Property(e => e.ServerLocationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServerType>(entity =>
            {
                entity.ToTable("ServerType", "Master");

                entity.Property(e => e.ServerTypeId).HasColumnName("ServerTypeID");

                entity.Property(e => e.ServerTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusMaster>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__StatusMa__C8EE20435BC5BA28");

                entity.ToTable("StatusMaster", "Provision");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusMaster1>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__StatusMa__C8EE20432C4DFB7F");

                entity.ToTable("StatusMaster", "Workflow");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole", "Master");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssociateId).HasColumnName("AssociateID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Worklog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("Worklog", "Master");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Worklog1>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__Worklog__5E5499A86DFD7645");

                entity.ToTable("Worklog", "Workflow");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDetailId).HasColumnName("ReqDetailID");

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

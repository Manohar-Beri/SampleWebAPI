using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SampleWebAPI.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<IlJaobdtl> IlJaobdtl { get; set; }
        public virtual DbSet<IlJaobhdr> IlJaobhdr { get; set; }
        public virtual DbSet<IlJastgdtl> IlJastgdtl { get; set; }
        public virtual DbSet<LogRequest> LogRequest { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Thumbnail> Thumbnail { get; set; }
        public virtual DbSet<Tutorials> Tutorials { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        //public DbQuery<Tutorials> Tutorials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=INHYDLMBERI;Database=Test;Trusted_Connection=True;Persist Security Info=True;User ID=sa;Password=p@ssw0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.City)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Custid)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderReceived)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                   // .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IlJaobdtl>(entity =>
            {
                entity.HasKey(e => e.Fobdid)
                    .HasName("PK__IL_JAOBD__5D0C9B73FFA9E267");

                entity.ToTable("IL_JAOBDTL");

                entity.Property(e => e.Fobdid)
                    .HasColumnName("FOBDID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Associatedflag)
                    .HasColumnName("ASSOCIATEDFLAG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Batchid)
                    .HasColumnName("BATCHID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batchname)
                    .HasColumnName("BATCHNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datemodified)
                    .HasColumnName("DATEMODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ftob).HasColumnName("FTOB");

                entity.Property(e => e.Interfaceid).HasColumnName("INTERFACEID");

                entity.Property(e => e.Interfacerefid).HasColumnName("INTERFACEREFID");

                entity.Property(e => e.Interfacerefno)
                    .HasColumnName("INTERFACEREFNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Interfacetype)
                    .HasColumnName("INTERFACETYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("MODIFIEDBY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ownerlocid)
                    .HasColumnName("OWNERLOCID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ownerorgid)
                    .HasColumnName("OWNERORGID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Stateid)
                    .HasColumnName("STATEID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statuscode)
                    .HasColumnName("STATUSCODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Statusmessages)
                    .HasColumnName("STATUSMESSAGES")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IlJaobhdr>(entity =>
            {
                entity.HasKey(e => e.Ftob)
                    .HasName("PK__IL_JAOBH__9C9250BF6A914F67");

                entity.ToTable("IL_JAOBHDR");

                entity.Property(e => e.Ftob).HasColumnName("FTOB");

                entity.Property(e => e.Accountingperiod)
                    .HasColumnName("ACCOUNTINGPERIOD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Archivefilename)
                    .HasColumnName("ARCHIVEFILENAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Batchcategory)
                    .HasColumnName("BATCHCATEGORY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Batchdatetime)
                    .HasColumnName("BATCHDATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Batchid)
                    .HasColumnName("BATCHID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batchname)
                    .HasColumnName("BATCHNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batchsource)
                    .HasColumnName("BATCHSOURCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Btchtransmittedtime)
                    .HasColumnName("BTCHTRANSMITTEDTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Chargelinecount).HasColumnName("CHARGELINECOUNT");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnName("DATECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datemodified)
                    .HasColumnName("DATEMODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Displaystatus)
                    .HasColumnName("DISPLAYSTATUS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Entitycode)
                    .HasColumnName("ENTITYCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entityid).HasColumnName("ENTITYID");

                entity.Property(e => e.Failurereason)
                    .HasColumnName("FAILUREREASON")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IlJastatus)
                    .HasColumnName("IL_JASTATUS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Interfacetypeid).HasColumnName("INTERFACETYPEID");

                entity.Property(e => e.Mntrvalfuncurrency)
                    .HasColumnName("MNTRVALFUNCURRENCY")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("MODIFIEDBY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Numoftransactions).HasColumnName("NUMOFTRANSACTIONS");

                entity.Property(e => e.Partnerid)
                    .HasColumnName("PARTNERID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Queuetoken)
                    .HasColumnName("QUEUETOKEN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Receiverid)
                    .HasColumnName("RECEIVERID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Scheduledatetime)
                    .HasColumnName("SCHEDULEDATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Scheduleid)
                    .HasColumnName("SCHEDULEID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Schedulemode)
                    .HasColumnName("SCHEDULEMODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Senderid)
                    .HasColumnName("SENDERID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stateid)
                    .HasColumnName("STATEID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statuscode)
                    .HasColumnName("STATUSCODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Statusmessage)
                    .HasColumnName("STATUSMESSAGE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statusmessages)
                    .HasColumnName("STATUSMESSAGES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Taxlinecount).HasColumnName("TAXLINECOUNT");

                entity.Property(e => e.Versionnumber)
                    .HasColumnName("VERSIONNUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IlJastgdtl>(entity =>
            {
                entity.HasKey(e => e.Interfaceid)
                    .HasName("PK__IL_JASTG__59D1EF349061FC45");

                entity.ToTable("IL_JASTGDTL");

                entity.Property(e => e.Interfaceid).HasColumnName("INTERFACEID");

                entity.Property(e => e.Accountingperiod)
                    .HasColumnName("ACCOUNTINGPERIOD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Createdtimezone)
                    .HasColumnName("CREATEDTIMEZONE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .IsRequired()
                    .HasColumnName("DATECREATED")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Entitycode)
                    .HasColumnName("ENTITYCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Interfacemessage)
                    .HasColumnName("INTERFACEMESSAGE")
                    .HasColumnType("xml");

                entity.Property(e => e.Interfacerefid).HasColumnName("INTERFACEREFID");

                entity.Property(e => e.Interfacerefno)
                    .HasColumnName("INTERFACEREFNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Interfacetype)
                    .HasColumnName("INTERFACETYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Interfacetypeid).HasColumnName("INTERFACETYPEID");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Statuscode)
                    .HasColumnName("STATUSCODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Transactiontype)
                    .HasColumnName("TRANSACTIONTYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogRequest>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Log).IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BatchCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDelivered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Thumbnail>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Tutorials>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserMast__1788CCAC4893B930");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserEmailId)
                    .HasColumnName("UserEmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRoles)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

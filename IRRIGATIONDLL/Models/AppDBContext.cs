﻿using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IRRIGATIONDLL.Models
{
    public partial class AppDBContext : DbContext
    {
        private IConfiguration _config;
        private HttpContext _httpContext;
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options, IConfiguration config, IHttpContextAccessor httpContextAccessor)
        : base(options)
        {
            _config = config;
            _httpContext = httpContextAccessor.HttpContext;

            Database.EnsureCreated();
        }
        #region Indexes

        public virtual DbSet<FINANCE> FINANCE { get; set; }
        public virtual DbSet<SETTING> SETTING { get; set; }
        public virtual DbSet<CONSTANT> CONSTANT { get; set; }
        public virtual DbSet<PRODUCT> PRODUCT { get; set; }
        public virtual DbSet<GOVERNORATE> GOVERNORATE { get; set; }
        public virtual DbSet<AREA> AREA { get; set; }
        public virtual DbSet<ZONE> ZONE { get; set; }
        public virtual DbSet<SIDE> SIDE { get; set; }
        public virtual DbSet<VILLAGE> VILLAGE { get; set; }
        public virtual DbSet<BRANCH> BRANCH { get; set; }
        public virtual DbSet<CIRCLE> CIRCLE { get; set; }
        public virtual DbSet<SECTION> SECTION { get; set; }
        public virtual DbSet<AGRIDIR> AGRIDIR { get; set; }
        public virtual DbSet<AGRIDEP> AGRIDEP { get; set; }
        public virtual DbSet<AGRISEC> AGRISEC { get; set; }
        public virtual DbSet<INDIC> INDIC { get; set; }
        public virtual DbSet<COMPANY> COMPANY { get; set; }
        public virtual DbSet<SANCTION> SANCTION { get; set; }
        public virtual DbSet<DECISION> DECISION { get; set; }
        public virtual DbSet<CLASSY> CLASSY { get; set; }
        public virtual DbSet<BBRANCH> BBRANCH { get; set; }
        public virtual DbSet<CREDIT> CREDIT { get; set; }
        public virtual DbSet<LOGACT> LOGACT { get; set; }
        public virtual DbSet<LOGERR> LOGERR { get; set; }
        public virtual DbSet<BENEFICIAL> BENEFICIAL { get; set; }
        public virtual DbSet<DOCTYPES> DOCTYPES { get; set; }
        public virtual DbSet<DOCS> DOCS { get; set; }
        public virtual DbSet<LOANORDER> LOANORDER { get; set; }
        public virtual DbSet<SCANPROCESS> SCANPROCESS { get; set; }

        public virtual DbSet<FINCOND> FINCOND { get; set; }



        public virtual DbSet<PERMISSION> PERMISSION { get; set; }
        public virtual DbSet<ROLE> ROLE { get; set; }
        public virtual DbSet<USER> USER { get; set; }

        public virtual DbSet<ROLEPERMISSIONS> ROLEPERMISSIONS { get; set; }

        public virtual DbSet<BILLITEMS> BILLITEMS { get; set; }
        public virtual DbSet<BILLS> BILLS { get; set; }
        public virtual DbSet<ITEMCOMPANY> ITEMCOMPANY { get; set; }
        public virtual DbSet<ITEMPRICE> ITEMPRICE { get; set; }
        public virtual DbSet<ITEMS> ITEMS { get; set; }
        public virtual DbSet<LASERCOMMIT> LASERCOMMIT { get; set; }
        public virtual DbSet<LASERORDER> LASERORDER { get; set; }
        public virtual DbSet<ORDERSTATUS> ORDERSTATUS { get; set; }


        //04/09/2020
        public virtual DbSet<ITEMATTRIBUTE> ITEMATTRIBUTE { get; set; }

        public virtual DbSet<LOANPAYMENTS> LOANPAYMENTS { get; set; }

        public virtual DbSet<ATTRIBUTES> ATTRIBUTES { get; set; }

        public virtual DbSet<CREDITHISTORY> CREDITHISTORY { get; set; }

        public virtual DbSet<ENTRY> ENTRY { get; set; }

        public virtual DbSet<ENTRYDETAILS> ENTRYDETAILS { get; set; }

        public virtual DbSet<ACCBRANCHMATCH> ACCBRANCHMATCH { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = _config.GetConnectionString("DefaultConnection"); // Your connection string logic here
                optionsBuilder.UseOracle(connString, b =>
                b.UseOracleSQLCompatibility("11"));//.MigrationsAssembly("IRRIGATIONAPP")
                //optionsBuilder.UseLazyLoadingProxies();
                //optionsBuilder.UseLazyLoadingProxies();
                //optionsBuilder.UseOracle("User Id = QUALIFYDLL;Password=q;Data Source = 192.168.1.184:1521/ORCL;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure Column
            //modelBuilder.Entity<SETTING>()
            //           .Property(e => e.NAME).HasColumnName("").has

            modelBuilder.Entity<SETTING>().Property(c => c.NAME).HasAnnotation("Comment", "test");

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                //entityType.Relational().DiscriminatorProperty
                // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                //entityType.Relational().TableName = entityType.DisplayName();
                //entityType.Relational().TableName = entityType.DisplayName();
                //var y = entityType.DisplayName();
                // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                // and modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
                //var tt = entityType.GetDeclaredProperties();
                //modelBuilder.Entity
                //entityType.get

                entityType.GetForeignKeys()
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                .ToList()
                .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }
            //EntityTypeBuilder.Ignore();
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");
            
            //.HasAnnotation("Relational:DefaultSchema", "QUALIFYDLL");
        }
    }
}

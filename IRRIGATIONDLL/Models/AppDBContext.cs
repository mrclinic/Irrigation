using System;
using System.Linq;
using IRRIGATIONDLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

namespace IRRIGATION.Models
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
        public virtual DbSet<SETTING> SETTING { get; set; }
        public virtual DbSet<CONSTANTINDEX> CONSTANTINDEX { get; set; }
        /*public virtual DbSet<TRAINTYP> TRAINTYP { get; set; }
        public virtual DbSet<FLAG> FLAG { get; set; }
        public virtual DbSet<TRAIN> TRAIN { get; set; }
        public virtual DbSet<EQUALIZER> EQUALIZER { get; set; }
        public virtual DbSet<TRAINCOND> TRAINCOND { get; set; }
        public virtual DbSet<SPECDET> SPECDET { get; set; }

        public virtual DbSet<SSPECDET> SSPECDET { get; set; }

        public virtual DbSet<NOMINATIONSUNITS> NOMINATIONSUNITS { get; set; }
        public virtual DbSet<NOMINATIONS> NOMINATIONS { get; set; }

        public virtual DbSet<NOMINATIONSINFO> NOMINATIONSINFO { get; set; }
        public virtual DbSet<APPROVAL_ENTITY_TYPE> APPROVAL_ENTITY_TYPE { get; set; }
        public virtual DbSet<APPROVAL_ENTITY_OBJECT> APPROVAL_ENTITY_OBJECT { get; set; }

        public virtual DbSet<APPROVAL_USERS> APPROVAL_USERS { get; set; }

        public virtual DbSet<CONFIG> CONFIG { get; set; }

        public virtual DbSet<TRAINRESULT> TRAINRESULT { get; set; }
        public virtual DbSet<TRAINRESULTCODE> TRAINRESULTCODE { get; set; }

        public virtual DbSet<CONFIGDB> CONFIGDB { get; set; }*/

        /*
        public virtual DbSet<MLAK_LIST> MLAK_LIST { get; set; }
        public virtual DbSet<NAMEDLIST_ORDER> NAMEDLIST_ORDER { get; set; }
        public virtual DbSet<NOTESHOW> NOTESHOW { get; set; }
        public virtual DbSet<PLANBOOK> PLANBOOK { get; set; }
        public virtual DbSet<SISSIONTYP> SISSIONTYP { get; set; }
        public virtual DbSet<SISSION> SISSION { get; set; }
        public virtual DbSet<MISSIONSLIST> MISSIONSLIST { get; set; }
        public virtual DbSet<DISPATCH_OREDRTYPE> DISPATCH_OREDRTYPE { get; set; }
        public virtual DbSet<QUALIFYTYP> QUALIFYTYP { get; set; }

        public virtual DbSet<QUALIFY_TYP> QUALIFY_TYP { get; set; }
        public virtual DbSet<CERTIFICATES> CERTIFICATES { get; set; }




        public virtual DbSet<EMPLOYEE_CLASS> EMPLOYEE_CLASS { get; set; }
        public virtual DbSet<RANK_CLASS> RANK_CLASS { get; set; }

        public virtual DbSet<KASHF> KASHF { get; set; }
        public virtual DbSet<RANK> RANK { get; set; }
        public virtual DbSet<DRAFT> DRAFT { get; set; }
        public virtual DbSet<DRAFT_TYPE> DRAFT_TYPE { get; set; }

        public virtual DbSet<MILITARY_UNIT> MILITARY_UNIT { get; set; }
        public virtual DbSet<SPECIALIZATION> SPECIALIZATION { get; set; }
        public virtual DbSet<SUBSPECIALIZATION> SUBSPECIALIZATION { get; set; }
        public virtual DbSet<SUBSPECIALIZATION_DETAILS> SUBSPECIALIZATION_DETAILS { get; set; }

        */
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = _config.GetConnectionString("DefaultConnection"); // Your connection string logic here
                optionsBuilder.UseOracle(connString, b =>
                b.UseOracleSQLCompatibility("11"));

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

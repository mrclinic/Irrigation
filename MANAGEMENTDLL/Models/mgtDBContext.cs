using System.Linq;
using MANAGEMENTDLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MANAGEMENT.Models
{
    public partial class mgtDBContext : DbContext
    {
        private IConfiguration _config;
        private HttpContext _httpContext;
        public mgtDBContext()
        {
        }

        public mgtDBContext(DbContextOptions<mgtDBContext> options, IConfiguration config, IHttpContextAccessor httpContextAccessor)
        : base(options)
        {
            _config = config;
            _httpContext = httpContextAccessor.HttpContext;

            Database.EnsureCreated();
        }
        #region Indexes
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
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = _config.GetConnectionString("MGTConnection"); // Your connection string logic here
                optionsBuilder.UseOracle(connString, b =>
                b.UseOracleSQLCompatibility("11"));//MigrationsAssembly("IRRIGATIONAPP").

                //optionsBuilder.UseLazyLoadingProxies();
                //optionsBuilder.UseOracle("User Id = QUALIFYDLL;Password=q;Data Source = 192.168.1.184:1521/ORCL;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure Column
            //modelBuilder.Entity<SETTING>()
            //           .Property(e => e.NAME).HasColumnName("").has

            //modelBuilder.Entity<SETTING>().Property(c => c.NAME).HasAnnotation("Comment", "test");

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

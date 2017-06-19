using Microsoft.EntityFrameworkCore;
using Neon.POF.Data.Models;

namespace Neon.POF.Data
{
    public class NeonDbContext : DbContext
    {
        public NeonDbContext(DbContextOptions<NeonDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<DepartmentEmployee> DepartmentEmployee { get; set; }
        public DbSet<Template> Template { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<TemplateQuestion> TemplateQuestion { get; set; }
        public DbSet<Respondent> Respondent { get; set; }
        public DbSet<RespondentAnswer> RespondentAnswer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(k => k.Id);
            modelBuilder.Entity<Employee>().Property(p => p.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.Email).HasMaxLength(250).IsRequired();

            modelBuilder.Entity<Department>().HasKey(k => k.Id);
            modelBuilder.Entity<Department>().Property(p => p.Name).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<DepartmentEmployee>()
                .HasKey( k => new{k.DepartmentId,k.EmployeeId});
            

            //Configure domain classes using modelBuilder here
            //  var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            //.Where(type => !String.IsNullOrEmpty(type.Namespace))
            //.Where(type => type.BaseType != null && type.BaseType.IsGenericType
            //     && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            //  foreach (var type in typesToRegister)
            //  {
            //      dynamic configurationInstance = Activator.CreateInstance(type);
            //      modelBuilder.Configurations.Add(configurationInstance);
            //  }

            base.OnModelCreating(modelBuilder);
        }
    }
}
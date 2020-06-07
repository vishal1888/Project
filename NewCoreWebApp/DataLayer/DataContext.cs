using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class DataContext : DbContext
    {
        private string _connectionString;

        public DataContext()
        {
        }

        public DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<EmployeeLogin> EmployeeLogins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(_connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Department>(d =>
            {
                d.ToTable("Departments");
                d.HasKey(id => id.DepartmentId);

            });
            builder.Entity<Employee>()
            .HasOne<Department>(s => s.department)
            .WithMany(e => e.employees)
            .HasForeignKey(fk => fk.deptId);

            builder.Entity<State>(s =>
            {
                s.ToTable("States");
                s.HasKey(id => id.Id);
            });
            builder.Entity<City>()
            .HasOne<State>(s => s.state)
            .WithMany(c => c.cities)
            .HasForeignKey(fk => fk.StateId);

            builder.Entity<EmployeeLogin>(d =>
            {
                d.ToTable("EmployeeLogins");
                d.HasKey(id => id.Id);

            });
            builder.Entity<Employee>()
            .HasOne<EmployeeLogin>(s => s.empLogin)
            .WithOne(ad => ad.employee)
            .HasForeignKey<EmployeeLogin>(b => b.RefLoginId);

        }

    }
}

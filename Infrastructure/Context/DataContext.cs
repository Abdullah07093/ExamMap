using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebApi.Entities;

namespace WebApi.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Salary> Salarys { get; set; }
    public DbSet<DepartmentEmployee> DepartmentEmployees { get; set; }
    public DbSet<DepartmentManager> DepartmentManagers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartmentEmployee>().HasKey(k => new { k.EmployeeId, k.DepatrmentId });
        modelBuilder.Entity<DepartmentManager>().HasKey(k => new { k.EmployeeId, k.ManagerId });
        base.OnModelCreating(modelBuilder);
    }
}
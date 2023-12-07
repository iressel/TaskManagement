using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Aggregates.DepartmentAggregate;

namespace TaskManagement.Infrastructure.Context
{
    public class ApplicationUser : IdentityUser
    {
        public string? UserRole { get; set; }

        public string? Flgeli { get; set; }
    }

    public class TaskManagementDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options) : base(options)
        {
         
        }

        // DB TABLES
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Domain.Aggregates.DepartmentAggregate.Task> Tasks { get; set; }
    }
}

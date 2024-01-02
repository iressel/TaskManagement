using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Aggregates.DepartmentAggregate;
using TaskManagement.Domain.Aggregates.PersonAggregate;
using TaskManagement.Domain.Shared.Enums;

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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Department>()
            //   .HasMany(d => d.Employees)
            //   .WithOne(e => e.Department)
            //   .HasForeignKey(e => e.DepartmentId)
            //   .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department)
            //    .WithMany(d => d.Employees)
            //    .HasForeignKey(e => e.DepartmentId)
            //    .OnDelete(DeleteBehavior.Restrict);

            var departmentPAMId = Guid.NewGuid();
            var employeeISMAINId = Guid.NewGuid();
            var addressISMAINLaPlataId = Guid.NewGuid();
            var addressISMAINPatagonesId = Guid.NewGuid();
            var ticketISMAINPSS1Id = Guid.NewGuid();
            var ticketISMAINPSS2Id = Guid.NewGuid();

            var departmentDBAId = Guid.NewGuid();
            var employeeGONZALOId = Guid.NewGuid();
            var addressGONZALOMendozaId = Guid.NewGuid();
            var employeeCARLAId = Guid.NewGuid();
            var addressCARLABAId = Guid.NewGuid();
            var ticketGONZALODBA1Id = Guid.NewGuid();
            var ticketGONZALODBA2Id = Guid.NewGuid();
            var ticketCARLADBA3Id = Guid.NewGuid();
            var ticketCARLADBA4Id = Guid.NewGuid();

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = departmentPAMId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Name = "PAM",
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = employeeISMAINId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Name = "ISMAIN",
                    Lastname = "RESSEL",
                    DocumentNumber = "36192398",
                    DateOfBirth = new DateTime(1991, 9, 10),
                    Email = "i.ressel@ptytechnologies.com",
                    EnrollmentDate = new DateTime(2022, 8, 22),
                    DepartmentId = departmentPAMId,
                });

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = addressISMAINLaPlataId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Country = "Argentina",
                    State = "BA",
                    City = "La Plata",
                    Street = "16",
                    AddressNumber = "1440",
                    IsOnTheGroundFloor = false,
                    DepartmentNumber = "2",
                    DepartmentLetter = "A",
                    ZipCode = "1900",
                    DetailedAddress = "Calle 16 1440 e/ 61 y 62 2A",
                    EmployeeId = employeeISMAINId,
                });

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = addressISMAINPatagonesId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Country = "Argentina",
                    State = "BA",
                    City = "Carmen de Patagones",
                    Street = "Harosteguy",
                    AddressNumber = "225",
                    IsOnTheGroundFloor = true,
                    ZipCode = "8504",
                    DetailedAddress = "Harosteguy 225, Casa",
                    EmployeeId = employeeISMAINId,
                });

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = ticketISMAINPSS1Id,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Title = "PSS-1",
                    Description = "Implementar Customer Emails",
                    DeliveryDate = new DateTime(2023, 11, 10),
                    Status = TicketStatus.Done,
                    EmployeeId = employeeISMAINId,
                });

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = ticketISMAINPSS2Id,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Title = "PSS-2",
                    Description = "Explicar EF",
                    DeliveryDate = new DateTime(2023, 12, 15),
                    Status = TicketStatus.InDev,
                    EmployeeId = employeeISMAINId,
                });

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = departmentDBAId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Name = "DBA",
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = employeeGONZALOId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Name = "GONZALO",
                    Lastname = "PRADO",
                    DocumentNumber = "36185222",
                    DateOfBirth = new DateTime(1991, 5, 4),
                    Email = "g.prado@ptytechnologies.com",
                    EnrollmentDate = new DateTime(2020, 5, 30),
                    DepartmentId = departmentDBAId,
                });

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = addressGONZALOMendozaId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Country = "Argentina",
                    State = "MZA",
                    City = "Mendoza",
                    Street = "Perón",
                    AddressNumber = "1953",
                    IsOnTheGroundFloor = true,
                    ZipCode = "M5500",
                    DetailedAddress = "Perón 1953, casa",
                    EmployeeId = employeeGONZALOId,
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = employeeCARLAId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Name = "CARLA",
                    Lastname = "GUELPA",
                    DocumentNumber = "38111222",
                    DateOfBirth = new DateTime(1994, 10, 5),
                    Email = "c.guelpa@ptytechnologies.com",
                    EnrollmentDate = new DateTime(2023, 2, 1),
                    DepartmentId = departmentDBAId,
                });

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = addressCARLABAId,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Country = "Argentina",
                    State = "BA",
                    City = "Buenos Aires",
                    Street = "ALEM",
                    AddressNumber = "442",
                    IsOnTheGroundFloor = false,
                    DepartmentNumber = "7",
                    DepartmentLetter = "B",
                    ZipCode = "B1228",
                    DetailedAddress = "Alem 442 7B",
                    EmployeeId = employeeCARLAId,
                });

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = ticketGONZALODBA1Id,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Title = "DBA-1",
                    Description = "Soporte a PSS",
                    DeliveryDate = new DateTime(2023, 11, 10),
                    Status = TicketStatus.Done,
                    EmployeeId = employeeGONZALOId,
                });

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = ticketGONZALODBA2Id,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Title = "DBA-2",
                    Description = "Soporte a Cashier",
                    DeliveryDate = new DateTime(2023, 12, 15),
                    Status = TicketStatus.InDev,
                    EmployeeId = employeeGONZALOId,
                });

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = ticketCARLADBA3Id,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Title = "DBA-3",
                    Description = "Soporte a PSS",
                    DeliveryDate = new DateTime(2023, 11, 15),
                    Status = TicketStatus.Done,
                    EmployeeId = employeeCARLAId,
                });

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = ticketCARLADBA4Id,
                    CreatedBy = "iressel",
                    UpdatedBy = "iressel",
                    UpdatedDate = DateTime.Now,
                    Title = "DBA-4",
                    Description = "Soporte a PSS",
                    DeliveryDate = new DateTime(2024, 1, 5),
                    Status = TicketStatus.InDev,
                    EmployeeId = employeeCARLAId,
                });
        }
    }
}

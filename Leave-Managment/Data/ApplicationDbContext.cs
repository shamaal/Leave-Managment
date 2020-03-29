using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Leave_Managment.Models;

namespace Leave_Managment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<Leave_Managment.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }
        public DbSet<Leave_Managment.Models.EmployeeVM> EmployeeVM { get; set; }
        public DbSet<Leave_Managment.Models.LeaveAllocationVM> LeaveAllocationVM { get; set; }
        public DbSet<Leave_Managment.Models.EditLeaveAllocationVM> EditLeaveAllocationVM { get; set; }
       
    }
}

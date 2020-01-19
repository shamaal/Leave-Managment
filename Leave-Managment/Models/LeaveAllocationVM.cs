using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Leave_Managment.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeID { get; set; }

        public IEnumerable<SelectListItem> Employees { get; set; }
        public IEnumerable<SelectListItem> Leaveypes { get; set; }
    }
}

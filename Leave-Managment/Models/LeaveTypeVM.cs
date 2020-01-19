using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Leave_Managment.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }
    }

   
}

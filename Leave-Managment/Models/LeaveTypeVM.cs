using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Leave_Managment.Models
{
    public class DetailsLeaveTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
       
        [Required]
        public string Name { get; set; }
       
    }
}

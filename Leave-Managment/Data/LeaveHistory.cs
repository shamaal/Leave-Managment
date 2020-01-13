﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment.Data
{
    public class LeaveHistory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RequestingEmployeeId")]
        public Employee RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DataRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        [ForeignKey("ApprovedByID")]
        public Employee ApprovedBy { get; set; }
        public string ApprovedByID { get; set; }

    }
}

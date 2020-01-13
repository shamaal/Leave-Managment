using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Leave_Managment.Contracts;
using Leave_Managment.Data;

namespace Leave_Managment.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        //Constructor - Initiali when class is call
        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db; // Dependancy Injection
        }
        public bool Create(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveAllocation FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}

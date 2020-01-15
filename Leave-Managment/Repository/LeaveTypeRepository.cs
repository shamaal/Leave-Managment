using Leave_Managment.Contracts;
using Leave_Managment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        //Constructor - Initiali when class is call
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db; // Dependancy Injection
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();        
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _db.LeaveTypes.ToList();
            return leaveTypes;
        }

        public LeaveType FindById(int id)
        {
            var leaveTypes = _db.LeaveTypes.Find(id);
            return leaveTypes;
        }

        public ICollection<LeaveType> GetEmployeesFromLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveType entity)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Leave_Managment.Contracts;
using Leave_Managment.Data;


namespace Leave_Managment.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        //Constructor - Initiali when class is call
        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db; // Dependancy Injection
        }
        public bool Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> FindAll()
        {
            throw new NotImplementedException();
        }

        public Employee FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool isExist(int id)
        {
            var exists = _db.Employees.Any(x => x.Id == id.ToString());
            return exists;
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}

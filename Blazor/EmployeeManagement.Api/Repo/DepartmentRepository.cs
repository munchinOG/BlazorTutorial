using EmployeeManagement.Api.EF;
using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Api.Repo
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public DepartmentRepository( EmployeeDbContext employeeDbContext )
        {
            _employeeDbContext = employeeDbContext;
        }
        public IEnumerable<Department> GetDepartments( )
        {
            return _employeeDbContext.Departments;
        }

        public Department GetDepartment( int departmentId )
        {
            return _employeeDbContext.Departments
                .FirstOrDefault( d => d.DepartmentId == departmentId );
        }
    }
}

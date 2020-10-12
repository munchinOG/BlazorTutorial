using EmployeeManagement.Api.EF;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Repo
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public DepartmentRepository( EmployeeDbContext employeeDbContext )
        {
            _employeeDbContext = employeeDbContext;
        }
        public async Task<IEnumerable<Department>> GetDepartments( )
        {
            return await _employeeDbContext.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartment( int departmentId )
        {
            return await _employeeDbContext.Departments
                .FirstOrDefaultAsync( d => d.DepartmentId == departmentId );
        }
    }
}

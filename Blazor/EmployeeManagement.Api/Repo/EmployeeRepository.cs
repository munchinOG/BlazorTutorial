using EmployeeManagement.Api.EF;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeRepository( EmployeeDbContext employeeDbContext )
        {
            _employeeDbContext = employeeDbContext;
        }
        public async Task<IEnumerable<Employee>> GetEmployees( )
        {
            return await _employeeDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee( int employeeId )
        {
            return await _employeeDbContext.Employees
                .FirstOrDefaultAsync( e => e.EmployeeId == employeeId );
        }

        public async Task<Employee> GetEmployeeByEmail( string email )
        {
            return await _employeeDbContext.Employees
                .FirstOrDefaultAsync( e => e.Email == email );
        }

        public async Task<Employee> AddEmployee( Employee employee )
        {
            var result = await _employeeDbContext.Employees.AddAsync( employee );
            await _employeeDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> UpdateEmployee( Employee employee )
        {
            var result = await _employeeDbContext.Employees
                .FirstOrDefaultAsync( e => e.EmployeeId == employee.EmployeeId );

            if(result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;

                await _employeeDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<Employee> DeleteEmployee( int employeeId )
        {
            var result = await _employeeDbContext.Employees
                .FirstOrDefaultAsync( e => e.EmployeeId == employeeId );
            if(result != null)
            {
                _employeeDbContext.Employees.Remove( result );
                await _employeeDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }
    }
}

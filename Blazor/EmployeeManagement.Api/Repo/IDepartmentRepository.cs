using EmployeeManagement.Models;
using System.Collections.Generic;

namespace EmployeeManagement.Api.Repo
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments( );
        Department GetDepartment( int departmentId );
    }
}

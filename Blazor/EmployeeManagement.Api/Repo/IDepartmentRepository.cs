﻿using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Repo
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments( );
        Task<Department> GetDepartment( int departmentId );
    }
}

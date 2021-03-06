﻿using EmployeeManagement.Models;
using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        private Employee Employee { get; set; } = new Employee();

        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        //public Guid DepartmentId { get; set; }
        //public string DepartmentId { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync( )
        {
            Employee = await EmployeeService.GetEmployee( int.Parse( Id ) );
            Departments = (await DepartmentService.GetDepartments()).ToList();

            EditEmployeeModel.EmployeeId = Employee.EmployeeId;
            EditEmployeeModel.FirstName = Employee.FirstName;
            EditEmployeeModel.LastName = Employee.LastName;
            EditEmployeeModel.Email = Employee.Email;
            EditEmployeeModel.ConfirmEmail = Employee.Email;
            EditEmployeeModel.DateOfBirth = Employee.DateOfBirth;
            EditEmployeeModel.Gender = Employee.Gender;
            EditEmployeeModel.PhotoPath = Employee.PhotoPath;
            EditEmployeeModel.DepartmentId = Employee.DepartmentId;
            EditEmployeeModel.Department = Employee.Department;
            //DepartmentId = Employee.DepartmentId.ToString();
            //DepartmentId = Guid.NewGuid();
        }

        protected void HandleValidSubmit( )
        {

        }
    }
}

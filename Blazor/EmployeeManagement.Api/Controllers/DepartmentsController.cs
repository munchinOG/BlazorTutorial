﻿using EmployeeManagement.Api.Repo;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController( IDepartmentRepository departmentRepository )
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetDepartments( )
        {
            try
            {
                return Ok( await _departmentRepository.GetDepartments() );
            }
            catch(Exception)
            {
                return StatusCode( StatusCodes.Status500InternalServerError,
                    "Error retrieveing data from the database" );
            }
        }

        [HttpGet( "{id:int}" )]
        public async Task<ActionResult<Department>> GetDepartment( int Id )
        {
            try
            {
                var result = await _departmentRepository.GetDepartment( Id );

                if(result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch(Exception)
            {
                return StatusCode( StatusCodes.Status500InternalServerError,
                    "Error retrieveing data from the database" );
            }
        }
    }
}

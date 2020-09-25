using EmployeeManagement.Api.Repo;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController( IEmployeeRepository employeeRepository )
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees( )
        {
            try
            {
                return Ok( await _employeeRepository.GetEmployees() );
            }
            catch(Exception)
            {
                return StatusCode( StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database" );
            }
        }

        [HttpGet( "{id:int}" )]
        public async Task<ActionResult<Employee>> GetEmployee( int id )
        {
            try
            {
                var result = await _employeeRepository.GetEmployee( id );

                if(result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch(Exception)
            {
                return StatusCode( StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database" );
            }
        }

        public async Task<ActionResult<Employee>> CreateEmployee( Employee employee )
        {
            try
            {
                if(employee == null)
                {
                    return BadRequest();
                }

                var emp = _employeeRepository.GetEmployeeByEmail( employee.Email );

                if(emp != null)
                {
                    ModelState.AddModelError( "email", "Employee email already in use" );
                    return BadRequest( ModelState );
                }

                var createEmployee = await _employeeRepository.AddEmployee( employee );

                return CreatedAtAction( nameof( GetEmployee ), new { id = createEmployee.EmployeeId },
                    createEmployee );
            }
            catch(Exception)
            {
                return StatusCode( StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database" );
            }
        }
    }
}

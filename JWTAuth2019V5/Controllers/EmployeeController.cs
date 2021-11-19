using JWTAuth2019V5.Context;
using JWTAuth2019V5.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuth2019V5.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly databaseContext _context;

		public EmployeeController(databaseContext context)
		{
			_context = context;
		}

		// GET: api/<EmployeeController>
		[HttpGet]
		[Route("GetEmployees")]
		public async Task<IActionResult> GetEmployees()
		{
			return Ok(await _context.employees.ToListAsync());
		}

		// GET api/<EmployeeController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<EmployeeController>
		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[HttpPost]
		[Route("SaveEmployee")]
		public async Task<IActionResult> SaveEmployee([FromBody] EmployeeViewModel model)
		{
			var employee = new Employee
			{
				id = model.id,
				name = model.name,
				phone = model.phone
			};
			_context.employees.Add(employee);
			await _context.SaveChangesAsync();

			return Ok(employee);
		}

		// PUT api/<EmployeeController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<EmployeeController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}

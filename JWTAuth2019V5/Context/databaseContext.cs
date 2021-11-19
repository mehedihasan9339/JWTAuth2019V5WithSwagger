using JWTAuth2019V5.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuth2019V5.Context
{
	public class databaseContext:IdentityDbContext<ApplicationUser>
	{
		public databaseContext(DbContextOptions<databaseContext> options):base(options)
		{

		}
		public DbSet<Employee> employees { get; set; }
	}
}

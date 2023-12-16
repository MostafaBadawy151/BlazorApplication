using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedData.Models;

namespace WebAPI.Model
{
	public class BlazorDbContext: IdentityDbContext
	{
        public BlazorDbContext()
        {
            
        }
        public BlazorDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }

	}
}

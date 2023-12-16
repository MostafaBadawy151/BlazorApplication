using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedData.Models
{
	public class Employee
	{
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3, ErrorMessage ="Name Must Be Greater than 3 char")]
        public string Name { get; set; }
        [Required]
        [Range(2000,10000)]
        public int Salary { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

		public override string ToString()
		{
            return $" Name: {Name} and Salary is {Salary}";

		}
	}
}

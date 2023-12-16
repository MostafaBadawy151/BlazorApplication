using SharedData.Models;
using System.Collections.Generic;
using System.Net.Http;// http Client
using System.Net.Http.Json; //extention method http client Json

using System.Threading.Tasks;

namespace BlazorWebAPI.WASM.Services
{
	public class EmployeeService : IService<Employee>
	{
		private readonly HttpClient httpClient;

		public EmployeeService(HttpClient httpClient ) // Register
        {
			this.httpClient = httpClient;
		}
        public async Task Delete(int id)
		{
			await httpClient.DeleteAsync("/api/Employees/" + id);
		}

		public async Task<List<Employee>> GetAll()
		{
			List<Employee> EmpList = await  httpClient.GetFromJsonAsync<List<Employee>>("/api/Employees");
			return EmpList;
		}

		public async Task<Employee> GetById(int id)
		{
			Employee employee = await httpClient.GetFromJsonAsync<Employee>("/api/Employees/" + id);
			return employee;
		}
		
		public async Task Insert(Employee item)
		{
			await httpClient.PostAsJsonAsync<Employee>("/api/Employees", item);
		}

		public async Task Update(int id, Employee item)
		{
			await httpClient.PutAsJsonAsync<Employee>("/api/Employees/" + id, item);
		}
	}
}

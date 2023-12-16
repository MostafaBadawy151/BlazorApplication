using SharedData.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;

using System.Threading.Tasks;

namespace BlazorWebAPI.WASM.Services
{
	public class DepartmentService:IService<Department>
	{
		private readonly HttpClient httpClient;

		public DepartmentService(HttpClient httpClient) // Register
		{
			this.httpClient = httpClient;
		}
		public async Task Delete(int id)
		{
			await httpClient.DeleteAsync("/api/Departments" + id);
		}

		public async Task<List<Department>> GetAll()
		{
			List<Department> DeptList = await httpClient.GetFromJsonAsync<List<Department>>("/api/Departments");
			return DeptList;
		}

		public async Task<Department> GetById(int id)
		{
			Department department = await httpClient.GetFromJsonAsync<Department>("/api/Departments/" + id);
			return department;
		}

		public async Task Insert(Department item)
		{
			await httpClient.PostAsJsonAsync<Department>("/api/Departments", item);
		}

		public async Task Update(int id, Department item)
		{
			await httpClient.PutAsJsonAsync<Department>("/api/Departments" + id, item);
		}
	}
}


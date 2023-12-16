using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebAPI.WASM.Services
{
	public interface IService<T>
	{
		Task<List<T>> GetAll();
		Task<T> GetById(int id);

		Task Insert(T item);
		Task Update(int id, T item);
		Task Delete(int id);
	}
}

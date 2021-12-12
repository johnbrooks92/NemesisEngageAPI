using System.Collections.Generic;
using System.Threading.Tasks;
using NemesisEngage.API.Models;

namespace NemesisEngage.API.Repositories.Interfaces
{
    public interface IMongoRepository<T> where T : BaseResource
    {
        public Task<List<T>> GetAll();
        public Task<T> GetById(string id);
        public Task<T> Create(T data);
        public Task<T> Update(string id, T data);
        public Task Delete(string id, bool hardDelete = false);
    }
}
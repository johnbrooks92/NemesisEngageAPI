using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using NemesisEngage.API.Models;
using NemesisEngage.API.Repositories.Interfaces;
using MongoDB.Driver.Linq;

namespace NemesisEngage.API.Repositories
{
    public class CharacterRepository : IMongoRepository<Character>
    {
        private readonly IMongoClient _mongoClient;
        
        public CharacterRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        } 
        public Task<List<Character>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Character> GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Character> Create(Character data)
        {
            data.CreatedAt = DateTime.UtcNow;
            data.UpdatedAt = DateTime.UtcNow;
            await GetCollection().InsertOneAsync(data);
            var userList = await GetCollection().AsQueryable().ToListAsync();
            return userList.FirstOrDefault(x => x.Id == data.Id);
        }

        public Task<Character> Update(string id, Character data)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(string id, bool hardDelete = false)
        {
            throw new System.NotImplementedException();
        }
        
        private IMongoCollection<Character> GetCollection()
        {
            IMongoDatabase database = _mongoClient.GetDatabase("nemesisengage");
            IMongoCollection<Character> collection = database.GetCollection<Character>("characters");
            return collection;
        }
    }
}
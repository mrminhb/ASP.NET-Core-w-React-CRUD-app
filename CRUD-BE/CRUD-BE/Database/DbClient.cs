using CRUD_BE.Business;
using CRUD_BE.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRUD_BE.Database;

public class DbClient : IDbClient
{
    private readonly IMongoDatabase _database;
        
    public DbClient(IOptions<DbConfig> dbConfig)
    {
        var client = new MongoClient(dbConfig.Value.ConnectionString);
        _database = client.GetDatabase(dbConfig.Value.DbName);
    }
    public IMongoCollection<Card> GetCardCollection()
    {
        return _database.GetCollection<Card>("Cards"); 
    }
}


using CRUD_BE.Models;
using MongoDB.Driver;

namespace CRUD_BE.Business;

public interface IDbClient
{
    IMongoCollection<Card> GetCardCollection();
}
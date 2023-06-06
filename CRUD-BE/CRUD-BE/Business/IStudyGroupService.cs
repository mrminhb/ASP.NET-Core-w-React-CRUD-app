using CRUD_BE.Models;

namespace CRUD_BE.Business;

public interface IStudyGroupService
{
    void Add(List<Card> cards);
}
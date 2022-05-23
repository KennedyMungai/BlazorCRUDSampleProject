namespace SimpleToDoModels.Models;

public interface ISimpleToDoService
{
    Task Create(SimpleToDoModels model);
    Task<SimpleToDoModels> Retrieve(int id);
    Task<List<SimpleToDoModels>> RetrieveAll();
    Task Update(int id, SimpleToDoModels model);
    Task Delete(int id);
}
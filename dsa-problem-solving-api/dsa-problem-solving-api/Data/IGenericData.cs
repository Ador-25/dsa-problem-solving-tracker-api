namespace dsa_problem_solving_api.Data
{
    public interface IGenericData<T>
    {
          List<T> GetAll();
        T Add(T platform);
        T Get(Guid Id);
        T Edit(Guid Id,T platform);
    }
}
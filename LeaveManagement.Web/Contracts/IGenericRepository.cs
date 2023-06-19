namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetAsync(int? id);

        Task<List<T>> GetAllAysnc();

        Task<T> AddAsync(T eneity);

        Task AddRangeAsync(List<T> entities);

        Task<bool> Exists(int id);

        Task DeleteAsync(int id);

        Task UpdateAsync(T entity);
    }
}

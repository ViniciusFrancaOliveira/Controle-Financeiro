namespace ControleFinanceiro.Services.Interface
{
    public interface IRepository<T>
    {
        Task<T> GetAllRevenues();
        Task<T> GetById(int id);
        Task<T> Insert(T entity);
        Task<T> UpdateById(T entity);
        Task<T> DeleteById(int id);
    }
}

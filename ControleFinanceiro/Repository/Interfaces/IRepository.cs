using System.Linq.Expressions;

namespace ControleFinanceiro.Repository.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        Task<T> GetById(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

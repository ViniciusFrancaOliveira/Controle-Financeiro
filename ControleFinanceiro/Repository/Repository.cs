using ControleFinanceiro.Data;
using ControleFinanceiro.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ControleFinanceiro.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected FinancialContext _context;

        public Repository(FinancialContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(predicate);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
        }
    }
}

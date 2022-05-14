using ControleFinanceiro.Data;
using ControleFinanceiro.Repository.Interfaces;

namespace ControleFinanceiro.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private RevenueRepository? _revenueRepository;
        public FinancialContext _context;
        public UnitOfWork(FinancialContext context)
        {
            _context = context;
        }

        public IRevenueRepository RevenueRepository
        {
            get 
            {
                return _revenueRepository ??= new RevenueRepository(_context);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

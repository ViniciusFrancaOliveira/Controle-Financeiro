using ControleFinanceiro.Data;
using ControleFinanceiro.Models;
using ControleFinanceiro.Repository.Interfaces;

namespace ControleFinanceiro.Repository
{
    public class RevenueRepository : Repository<Revenue>, IRevenueRepository
    {
        public RevenueRepository(FinancialContext context) : base(context)
        {
        }
    }
}

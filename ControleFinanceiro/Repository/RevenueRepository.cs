using ControleFinanceiro.Models;
using ControleFinanceiro.Services.Interface;

namespace ControleFinanceiro.Repository
{
    public class RevenueRepository : IRepository<Revenue>
    {
        public Task<Revenue> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Revenue> GetAllRevenues()
        {
            throw new NotImplementedException();
        }

        public Task<Revenue> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Revenue> Insert(Revenue entity)
        {
            throw new NotImplementedException();
        }

        public Task<Revenue> UpdateById(Revenue entity)
        {
            throw new NotImplementedException();
        }
    }
}

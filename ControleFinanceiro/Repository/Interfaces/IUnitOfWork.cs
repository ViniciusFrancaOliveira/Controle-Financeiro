namespace ControleFinanceiro.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IRevenueRepository RevenueRepository { get; }
        Task SaveChangesAsync();
        void Dispose();
    }
}

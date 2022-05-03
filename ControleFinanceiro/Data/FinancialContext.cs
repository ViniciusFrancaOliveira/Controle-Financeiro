using ControleFinanceiro.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Data
{
    public class FinancialContext : DbContext
    {
        public FinancialContext(DbContextOptions options) : base(options) { }

        public DbSet<Expenditure> Expenditure { get; set; }
        public DbSet<Revenue> Revenue { get; set; }
    }
}

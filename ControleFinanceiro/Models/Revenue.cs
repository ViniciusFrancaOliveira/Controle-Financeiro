using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiro.Models
{
    public class Revenue
    {
        [Key]
        public int ExpenditureId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,4)")]
        public decimal Value { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}


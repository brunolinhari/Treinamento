using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraAPI.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        
        [Required (ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength (10, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 4)]
        public string Descricao { get; set; }

        [Range (1, 100, ErrorMessage = "O valor deve estar entre {1} e {2}!")]
        public decimal Valor { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudCliente.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }

        public int Telefone { get; set; }
    }
}

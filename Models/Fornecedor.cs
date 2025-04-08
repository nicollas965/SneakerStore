using System.ComponentModel.DataAnnotations;

namespace SneakerStore.Models 
{
    public class Fornecedor
    {
        public int Id { get; set; }

        [Required]
        public string?Nome { get; set; }

        public string?CNPJ { get; set; }

        public string?Email { get; set; }
        public string?Telefone { get; set; }
    }
}

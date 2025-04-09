using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SneakerStore.Models;

namespace SneakerStore.Models;

public class Produto
{
    public int Id { get; set; }

    [Required]
    public string? Nome { get; set; }

    public string? Marca { get; set; }

    [Required]
    public decimal Preco { get; set; }
    public int FornecedorId { get; set; }

    [ForeignKey("FornecedorId")]
    public Fornecedor?Fornecedor{ get; set; }
}

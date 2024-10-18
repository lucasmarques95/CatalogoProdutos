using System.ComponentModel.DataAnnotations;

namespace CatalogoProdutos.Models;

public class Produto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O preço de venda é obrigatório")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
    public decimal PrecoVenda { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "A quantidade é obrigatória")]
    [Range(0, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero")]
    public int Quantidade { get; set; }

    [Required(ErrorMessage = "A data de cadastro é obrigatória")]
    public DateTime DataCadastro { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "O tipo do produto é obrigatório")]
    public string TipoProduto { get; set; } = string.Empty;

    public decimal ValorTotal => PrecoVenda * Quantidade;
}

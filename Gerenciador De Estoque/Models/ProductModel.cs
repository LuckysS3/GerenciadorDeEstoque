namespace Gerenciamento_De_Estoque.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public ProductCategory? Category { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
}

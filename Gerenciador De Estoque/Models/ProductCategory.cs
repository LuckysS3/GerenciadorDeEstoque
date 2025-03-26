using System.Text.Json.Serialization;

namespace Gerenciamento_De_Estoque.Models;

public class ProductCategory
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
}

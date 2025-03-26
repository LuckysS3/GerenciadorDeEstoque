using Gerenciamento_De_Estoque.Models;
using System.Text.Json;

namespace Gerenciamento_De_Estoque.Utils;

class FileManager
{
    private string GetJsonPath()
    {
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

        return Path.Combine(currentDirectory, "Produtos.json");
    }

    public List<ProductModel> Carregamento()
    {
        if (!File.Exists(GetJsonPath()))
        {
            return new List<ProductModel>();
        }

        string json = File.ReadAllText(GetJsonPath());
        return JsonSerializer.Deserialize<List<ProductModel>>(json) ?? new List<ProductModel>();
    }

    public void Salvamento(List<ProductModel> Products)
    {

        var json = JsonSerializer.Serialize(Products, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(GetJsonPath(), json);
    }
}

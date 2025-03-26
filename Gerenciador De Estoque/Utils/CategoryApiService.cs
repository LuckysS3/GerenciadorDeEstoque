using Gerenciamento_De_Estoque.Models;
using System.Text.Json;

namespace Gerenciamento_De_Estoque.Utils;

public class CategoryApiService
{
    private static readonly HttpClient client = new();

    public async Task<List<ProductCategory>> GetCategoryAsync()
    {
        string url = "https://api.mercadolibre.com/sites/MLB/categories";
        try
        {
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var category = await response.Content.ReadAsStringAsync();

                var categories = JsonSerializer.Deserialize<List<ProductCategory>>(category);

                return categories;
            }
            else
            {
                Console.WriteLine($"Erro ao acessar API: Status {response.StatusCode} - {response.ReasonPhrase}");
                return null;
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            return null;
        }
    }

}

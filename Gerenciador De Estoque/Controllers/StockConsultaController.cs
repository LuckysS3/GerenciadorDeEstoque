using Gerenciamento_De_Estoque.Controllers;
using Gerenciamento_De_Estoque.Models;

namespace Gerenciador_De_Estoque.Controllers;

class StockConsultaController
{
    private StockControlle _controller = new();
    private List<ProductModel> products = new();

    public StockConsultaController(StockControlle controller)
    {
        _controller = controller;
        products = _controller.GetListaProdutos();
    }

    public void ListaTodosProdutos()
    {
        Console.Clear();
        if (products == null)
        {
            Console.WriteLine("A lista de produto esta vazia cadastre um produto primeiro");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("-------------------- Lista de Produtos -------------------");
        foreach (var pro in products)
        {
            Console.WriteLine($"Id: {pro.Id}");
            Console.WriteLine($"Nome: {pro.Nome}");
            Console.WriteLine($"Categoria: {pro.Category.Nome}");
            Console.WriteLine($"Quantidade: {pro.Quantidade}");
            Console.WriteLine($"Preço: {pro.Preco}");
            Console.WriteLine("-----------------------------------------------");
        }

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadKey();
    }

    public void ConsultaPorId()
    {
        Console.Clear();

        if (products == null)
        {
            Console.WriteLine("A lista de produto esta vazia cadastre um produto primeiro");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("-------------------- Consulta Produto Por Id -------------------");
        Console.WriteLine("Digite o id do produto: ");
        try
        {
            int id = int.Parse(Console.ReadLine()!);
            ProductModel product = products.FirstOrDefault(p => p.Id == id);
            Console.Clear();
            if (product == null)
            {
                Console.WriteLine("O id digitado nao existe");
                return;
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Id: {product.Id}");
            Console.WriteLine($"Nome: {product.Nome}");
            Console.WriteLine($"Categoria: {product.Category.Nome}");
            Console.WriteLine($"Quantidade: {product.Quantidade}");
            Console.WriteLine($"Preço: {product.Preco}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nId digitado esta incorreto ");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();
        }
    }

    public void ConsultaPorNome()
    {
        Console.Clear();

        if (products == null)
        {
            Console.WriteLine("A lista de produto esta vazia cadastre um produto primeiro");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("-------------------- Consulta Produto Pelo Nome -------------------");
        Console.WriteLine("Digite o nome do produto: ");
        try
        {
            string nome = Console.ReadLine()!;
            ProductModel product = products.FirstOrDefault(p => p.Nome == nome);

            Console.Clear();
            if (product == null)
            {
                Console.WriteLine("O nome digitado nao existe");
                return;
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Id: {product.Id}");
            Console.WriteLine($"Nome: {product.Nome}");
            Console.WriteLine($"Categoria: {product.Category.Nome}");
            Console.WriteLine($"Quantidade: {product.Quantidade}");
            Console.WriteLine($"Preço: {product.Preco}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();
        }

    }
}

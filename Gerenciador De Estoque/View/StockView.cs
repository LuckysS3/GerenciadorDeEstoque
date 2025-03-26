using Gerenciamento_De_Estoque.Controllers;

namespace Gerenciamento_De_Estoque.View;

class StockView
{
    private StockControlle _controller = new StockControlle();

    public void MenuIncial()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------------------- Menu -------------------");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Lista Categorias");
            Console.WriteLine("3 - Consultar Produtos");
            Console.WriteLine("4 - Editar Produto");
            Console.WriteLine("5 - Remover Produto");
            Console.WriteLine("6 - Gerar Relatórios");
            Console.WriteLine("7 - Sair");

            string escolher = Console.ReadLine()!;

            switch (escolher)
            {
                case "1":
                    AdicionarProduto();
                    break;
                case "2":
                    ListrarCategoria();
                    break;
                case "7":
                    Console.WriteLine("Tchau");
                    return;
                default:
                    Console.WriteLine("Opção digita não existe");
                    break;
            }
        }
    }

    private void AdicionarProduto()
    {
        Console.Clear();
        Console.WriteLine("-------------------- Adicionar Produto -------------------");
        Console.WriteLine("Digite o nome do produto");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Digite a categoria");
        string categoria = Console.ReadLine()!;

        Console.WriteLine("Digite a quantidade");
        int quantidade = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o preço");
        double preco = double.Parse(Console.ReadLine()!);

        string resp = _controller.AddProduto(nome, categoria, quantidade, preco);

        Console.WriteLine(resp);
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadKey();
    }
    private void ListrarCategoria()
    {
        Console.Clear();

        Console.WriteLine("-------------------- Lista de Categorias -------------------");

        var categoria = _controller.GetCategories();

        foreach (var car in categoria)
        {
            Console.WriteLine($"Nome: {car.Nome}");
        }

        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadKey();
    }
}

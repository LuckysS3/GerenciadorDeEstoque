using Gerenciador_De_Estoque.Controllers;
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
                case "3":
                    ConsultasProduto();
                    break;
                case "4":
                    EditarProdutoMenu();
                    break;
                case "5":
                    RemoverProduto();
                    break;
                case "6":
                    GerarRelatorio();
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

    private void ConsultasProduto()
    {
        StockConsultaController _consultaController = new(_controller);
        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------------------- Consultas -------------------");
            Console.WriteLine("1 - Listar todos os produto");
            Console.WriteLine("2 - Consulta produto por id");
            Console.WriteLine("3 - Consulta produto pelo nome");
            Console.WriteLine("4 - Voltar para o menu inicial");
            switch (Console.ReadLine())
            {
                case "1":
                    _consultaController.ListaTodosProdutos();
                    break;
                case "2":
                    _consultaController.ConsultaPorId();
                    break;
                case "3":
                    _consultaController.ConsultaPorNome();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opeção escolhida não existe");
                    break;
            }
        }
    }

    private void EditarProdutoMenu()
    {
        Console.Clear();
        Console.WriteLine("-------------------- Editar Produto -------------------");
        Console.WriteLine("Digite o id do produto: ");
        try
        {
            int id = int.Parse(Console.ReadLine()!);
            _controller.EditProdutoController(id);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nDigite apenas numero");
            Console.WriteLine("Deseja volta para o menu");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            while (true)
            {
                string escolha = Console.ReadLine()!;

                if (escolha == "1")
                {
                    return;
                }
                else if (escolha == "2")
                {
                    EditarProdutoMenu();
                    return;
                }
                else
                {
                    Console.WriteLine("Digite apenas 1 ou 2 ");
                }
            }

        }
        finally
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();
        }
    }

    private void RemoverProduto()
    {
        Console.Clear();
        Console.WriteLine("-------------------- Remover Produto -------------------");
        Console.WriteLine("Digite o id do produto: ");
        try
        {
            int id = int.Parse(Console.ReadLine()!);
            _controller.RemoveProduto(id);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nDigite apenas numero");
            Console.WriteLine("Deseja volta para o menu");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            while (true)
            {
                string escolha = Console.ReadLine()!;

                if (escolha == "1")
                {
                    return;
                }
                else if (escolha == "2")
                {
                    RemoverProduto();
                    return;
                }
                else
                {
                    Console.WriteLine("Digite apenas 1 ou 2 ");
                }
            }
        }
        finally
        {
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadKey();
        }
    }

    private void GerarRelatorio()
    {
        Console.Clear();
        Console.WriteLine("-------------------- Gerar Relatórios -------------------");
        _controller.GerarDocumento();
        Console.WriteLine("Relatório gerado com susseso");
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadKey();
    }
}

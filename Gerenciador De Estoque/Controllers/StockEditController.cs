using Gerenciamento_De_Estoque.Models;
using System.Diagnostics.Contracts;

namespace Gerenciador_De_Estoque.Controllers;

class StockEditController
{
    private static ProductModel Product = new();
    private static List<ProductCategory> Categories = new();

   public static ProductModel EditProduto(ProductModel product, List<ProductCategory> categories)
    {
        Product = product;
        Categories = categories;

        Console.WriteLine("\n\n----------------------------------------------------");
        Console.WriteLine("Escolha o que deseja edita-lo");
        Console.WriteLine("1 - Nome");
        Console.WriteLine("2 - Categoria");
        Console.WriteLine("3 - Quantidade");
        Console.WriteLine("4 - Preço");
        while (true)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    EditProdutoNome();
                    return Product;
                case "2":
                    EditProdutoCategoria();
                    return Product;
                case "3":
                    EditProdutoQuantidade();
                    return Product;
                default:
                    Console.WriteLine("Opeção escolhida não existe");
                    break;
            }
        }
    }

    private static void EditProdutoNome()
    {
        Console.WriteLine("\n\n----------------------------------------------------");
        Console.WriteLine("Digite o nome: ");
        string nome = Console.ReadLine()!;

        Console.WriteLine("Produto editado com susseso");
        Product.Nome = nome;
    }

    private static void EditProdutoCategoria()
    {
        Console.WriteLine("\n\n----------------------------------------------------");
        Console.WriteLine("Digite o nome da categoria: ");
        string categoria = Console.ReadLine()!;

        var categoriaVerificada = Categories.FirstOrDefault(c => c.Nome == categoria);

        if (categoriaVerificada == null)
        {
            Console.WriteLine("Categoria digitada não existe");
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
                    EditProdutoCategoria();
                    return;
                }
                else
                {
                    Console.WriteLine("Digite apenas 1 ou 2 ");
                }
            }
        }
        Console.WriteLine("Produto editado com susseso");
        Product.Category = categoriaVerificada;
    }

    private static void EditProdutoQuantidade()
    {
        Console.WriteLine("\n\n----------------------------------------------------");
        Console.WriteLine("Digite a quantidade: ");

        try
        {
            int quantidade = int.Parse(Console.ReadLine()!);

            Product.Quantidade = quantidade;
            Console.WriteLine("Produto editado com susseso");
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
                    EditProdutoQuantidade();
                    return;
                }
                else
                {
                    Console.WriteLine("Digite apenas 1 ou 2 ");
                }
            }
        }
    }
}

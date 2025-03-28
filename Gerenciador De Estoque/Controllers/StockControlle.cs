using Gerenciador_De_Estoque.Controllers;
using Gerenciamento_De_Estoque.Models;
using Gerenciamento_De_Estoque.Utils;

namespace Gerenciamento_De_Estoque.Controllers;

class StockControlle
{
    public List<ProductModel> Products { get; private set; }
    public List<ProductCategory> Categories { get; private set; }

    private FileManager _fileManager = new FileManager();

    private CategoryApiService _apiService = new CategoryApiService();

    public StockControlle()
    {
        Carregamento();
    }

    private async Task Carregamento()
    {
        Products = _fileManager.Carregamento();
        Categories = await _apiService.GetCategoryAsync();
    }

    public string AddProduto(string nome, string categoria, int quantidade, double preco)
    {
        if (Products == null) return "teste";
        int id = Products.Count > 0 ? Products[^1].Id + 1 : 1;

        if (nome.Length < 1 || categoria.Length < 1) return "Erro: O nome e categoria do produto não pode estar vazio.";
        if (nome.Length > 50) return "Erro: O nome do produto não pode conter mais do que 50 caracteres";
        ProductCategory categoriaEscolhida = Categories.FirstOrDefault(c => c.Nome == categoria);
        if (categoriaEscolhida == null) return "Erro: A categoria escolhida não e reconhecida.";
        if (quantidade < 0 || preco <= 0) return "Erro: A quantidade e preço não pode ser nergativo";


        ProductModel produto = new ProductModel { Id = id, Nome = nome, Category = categoriaEscolhida, Preco = preco };
        Products.Add(produto);

        _fileManager.Salvamento(Products);
        return "Produto adicionada!";
    }

    public List<ProductCategory> GetCategories()
    {
        return Categories;
    }

    public List<ProductModel> GetListaProdutos()
    {
        return Products;
    }

    public void EditProdutoController(int id)
    {
        int index = Products.FindIndex(p => p.Id == id);

        if (index == -1)
        {
            Console.WriteLine("Produto digitado não foi entrado no banco de dados");
            return;
        }

        ProductModel product = Products[index];

        while (true){
            Console.Clear();
            Console.WriteLine("------------------------- Informção do produto ---------------------------");
            Console.WriteLine($"Id: {product.Id}");
            Console.WriteLine($"Nome: {product.Nome}");
            Console.WriteLine($"Categoria: {product.Category.Nome}");
            Console.WriteLine($"Quantidade: {product.Quantidade}");
            Console.WriteLine($"Preço: {product.Preco}");

            Console.WriteLine("\n Você deseja edita-lo ? ");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            switch (Console.ReadLine()!)
            {
                case "1":
                    ProductModel productEdit = StockEditController.EditProduto(product, Categories);
                    Products[index] = productEdit;
                    _fileManager.Salvamento(Products);
                    return;
                case "2":
                    return;
                default:
                    Console.WriteLine("Porfavor digite apenas 1 ou 2");
                    break;
            }
        } 
    }
}

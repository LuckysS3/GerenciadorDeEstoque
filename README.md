
# Gerenciador de Estoque 📦 

Um sistema de gerenciamento de estoque desenvolvido em C# com .NET 8, projetado para facilitar o controle de produtos e categorias em pequenas e médias empresas.

---

## Funcionalidades 🚀

- **Cadastro de Produtos:** Permite adicionar, editar e excluir produtos do estoque.
- **Categorias de Produtos:** Integra-se com uma API para obter uma lista de categorias.
- **Persistência de Dados:** Os dados são armazenados localmente em arquivos JSON.
- **Interface Simples:** Fácil de usar, com mensagens claras para interação no console.
- **Validação:** Verifica a consistência dos dados e impede duplicatas.

---




## Tecnologias Utilizadas 🛠️
- **Linguagem:** C#
- **Framework:** .NET 8
- **Persistência de Dados:** JSON
- **HTTP Requests:** Biblioteca HttpClient para comunicação com APIs externas

---
## Como Executar o Projeto 🚀

1. **Clone o repositório:**

    ```bash
   git clone https://github.com/seu-usuario/gerenciador-de-estoque.git
   ```

2. **Navegue até o diretório do projeto:**

   ```bash
   cd gerenciador-de-estoque
   ```

3. **Restaure as dependências:**

   ```bash
   dotnet restore
   ```

4.  **Execute o projeto:**

    ```bash
    dotnet run
    ```

---
## Integração com API de Categorias

O sistema faz uma requisição GET para obter categorias de produtos:

- **URL da API:** [https://api.mercadolibre.com/sites/MLB/categories](https://api.mercadolibre.com/sites/MLB/categories)
- **Resposta esperada:** Uma lista de categorias com ID e nome.

Caso não seja possível acessar a API, o sistema lida com erros e fornece uma mensagem clara ao usuário.

---
## Estrutura do Projeto 📦 

``` 
Gerenciador_De_Estoque/
├── Controllers/
│   ├── StockController.cs
│   └── CategoryApiService.cs
├── Models/
│   ├── ProductModel.cs
│   └── ProductCategory.cs
├── Utils/
│   ├── FileManager.cs
├── Program.cs
└── README.md
```

---
## Exemplos de Uso 📖

### Adicionar Produto

1. Informe o nome do produto.
2. Selecione a categoria.
3. Informe a quantidade.

### Visualizar Categorias
Categorias obtidas da API serão exibidas automaticamente no console para facilitar o gerenciamento.

---
## Contribuições 🧑‍💻

Contribuições são bem-vindas! Para contribuir:

1. Fork este repositório.
2. Crie uma branch para sua feature:
   ```bash
   git checkout -b minha-feature
   ```
3. Envie suas alterações:
   ```bash
   git push origin minha-feature
   ```
4. Abra um Pull Request.
## Melhorias Futuras 🚧
- Adicionar interface gráfica com WPF ou Blazor.
- Implementar autenticação de usuário para diferentes níveis de acesso.
- Melhorar o sistema de relatórios, com exportação para PDF ou Excel.
- Criar integração com banco de dados para escalabilidade.
- Implementar testes automatizados com xUnit.

---
## Licença 📄

Este projeto está licenciado sob a [Licença MIT](https://opensource.org/licenses/MIT).
Gerenciador de Estoque 📦
O Gerenciador de Estoque é um software desenvolvido em C# que auxilia no controle e gerenciamento de produtos e categorias em estoque. Ele permite o registro, organização e acompanhamento de itens, integrando-se a APIs para listar categorias de produtos de forma dinâmica.

Funcionalidades 🚀
Gerenciamento de Produtos: Cadastro, listagem, atualização e exclusão de produtos.

Categorias de Produtos: Integração com APIs públicas para obter e organizar categorias.

Persistência de Dados: Armazenamento local de informações em arquivos JSON.

Validações Inteligentes: Confirmação de categorias e consistência de dados.

Interface Simples: Foco na funcionalidade com console interativo.

Tecnologias Utilizadas 🛠️
C#

.NET

JSON para persistência de dados

HttpClient para requisições HTTP

System.Text.Json para serialização/deserialização

Arquitetura Modular: Separação clara entre serviços e controle de dados

Como Funciona? 🤔
Carregamento Inicial:

Os produtos são carregados de um arquivo local (products.json).

As categorias são buscadas dinamicamente através de uma API pública.

Gerenciamento de Produtos:

Produtos podem ser adicionados, editados ou removidos.

As categorias de cada produto são validadas com base na lista obtida da API.

Validações:

Verifica se o arquivo JSON existe antes de carregar os dados.

Garante que produtos só sejam cadastrados com categorias válidas.

Pré-requisitos 🛠️
.NET SDK 6.0 ou superior

Conexão com a internet para buscar as categorias via API

Sistema operacional compatível com a CLI do .NET (Windows, Linux ou macOS)

Como Executar? 🏃‍♂️
Clone o repositório:

bash
Copiar
Editar
git clone https://github.com/seu-usuario/gerenciador-de-estoque.git
Acesse o diretório do projeto:

bash
Copiar
Editar
cd gerenciador-de-estoque
Restaure os pacotes necessários:

bash
Copiar
Editar
dotnet restore
Execute o projeto:

bash
Copiar
Editar
dotnet run
Melhorias Futuras 🚧
Adicionar interface gráfica com WPF ou Blazor.

Implementar autenticação de usuário para diferentes níveis de acesso.

Melhorar o sistema de relatórios, com exportação para PDF ou Excel.

Criar integração com banco de dados para escalabilidade.

Implementar testes automatizados com xUnit.

Contribua! 🤝
Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

Licença 📜
Este projeto é licenciado sob a MIT License.


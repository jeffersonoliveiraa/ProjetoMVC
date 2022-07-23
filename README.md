# ProjetoMVC

Projeto criado para testar habilidades em desenvolvimento WEB com as tecnologias Asp.Net MVC + EF Core + SQL Server + Azure.

## 🚀 Começando

Essas instruções permitirão que você obtenha uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e teste.

### 📋 Pré-requisitos

Para executar você precisara do Visual Studio e SQL Server Express.  

### 🔧 Instalação

Como essa etapa será:

Primeiro: Você ira realizar o clone do projeto em sua máquina.
Segundo: Abrir o arquivo **"ProjetoMVC.sln"** selecionando seu VS como programa responsável por isto.

Caso deseje criar o banco e utilizar localmente você devera identificar a string de conexão do seu servidor de banco de dados local.
Para alterar você deve ir à pasta **models** e abrir o arquivo Context.cs, dentro dele você devera alterar a **connectionString**.
Após o passo acima você deve ir no **console de gerenciamento de pacotes** e executar o comando **Update-Database**, assim será criado um banco local para a aplicação.

Após estes dois passos é somente iniciar a depuração.

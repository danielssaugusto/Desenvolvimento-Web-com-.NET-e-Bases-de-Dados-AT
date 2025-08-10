# Desenvolvimento Web com .NET e Bases de Dados AT

## Descrição

Este projeto é uma aplicação web desenvolvida utilizando o framework .NET, com foco em práticas de desenvolvimento web e integração com bases de dados.

## Tecnologias Utilizadas

* C#
* ASP.NET Core
* Entity Framework Core
* SQL Server
* Docker

## Como Rodar o Projeto

### No Terminal

1. Clone este repositório:

   ```bash
   git clone https://github.com/danielssaugusto/Desenvolvimento-Web-com-.NET-e-Bases-de-Dados-AT.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd Desenvolvimento-Web-com-.NET-e-Bases-de-Dados-AT
   ```

3. Restaure as dependências do projeto:

   ```bash
   dotnet restore
   ```

4. Aplique as migrações do banco de dados:

   ```bash
   dotnet ef database update
   ```

5. Execute o projeto:

   ```bash
   dotnet run
   ```

O aplicativo estará disponível em `http://localhost:5000`.

### Usando Docker

Para rodar o projeto utilizando Docker, siga os passos abaixo:

1. Clone este repositório:

   ```bash
   git clone https://github.com/danielssaugusto/Desenvolvimento-Web-com-.NET-e-Bases-de-Dados-AT.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd Desenvolvimento-Web-com-.NET-e-Bases-de-Dados-AT
   ```

3. Crie a imagem Docker:

   ```bash
   docker build -t agencia-turismo .
   ```

4. Execute o container:

   ```bash
   docker run -d -p 5000:80 agencia-turismo
   ```

O aplicativo estará disponível em `http://localhost:5000`.

## Contribuindo

Contribuições são bem-vindas! Para contribuir:

1. Fork este repositório.
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`).
3. Faça commit das suas alterações (`git commit -am 'Adiciona nova feature'`).
4. Push para a branch (`git push origin feature/nova-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.

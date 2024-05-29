# TodoSolution

## Descrição

TodoSolution é um sistema de controle de tarefas inteligente desenvolvido com ASP.NET Core no backend e React com ViteJS e TypeScript no frontend. O objetivo do projeto é criar uma aplicação robusta e escalável com uma arquitetura de código limpa (Clean Code). O sistema permitirá aos usuários gerenciar suas tarefas de forma eficiente, com funcionalidades de autenticação e associação de tarefas a usuários específicos.

## Funcionalidades Principais

### Usuários
- **Registro de Usuário:** Permite que novos usuários se registrem no sistema.
- **Autenticação de Usuário:** Usuários podem fazer login e logout do sistema.
- **Gerenciamento de Perfil:** Usuários podem atualizar suas informações de perfil.

### Tarefas
- **Criação de Tarefas:** Usuários podem criar novas tarefas.
- **Edição de Tarefas:** Usuários podem editar tarefas existentes.
- **Exclusão de Tarefas:** Usuários podem excluir tarefas.
- **Listagem de Tarefas:** Usuários podem visualizar a lista de suas tarefas.
- **Filtragem e Pesquisa:** Usuários podem filtrar e pesquisar tarefas por status, data e outras propriedades.


## Configuração e Execução

### Backend

1. **Clone o Repositório:**
```sh
$ cd TodoSolution
```

2. **Restaurar Dependências:**
```sh
$ dotnet restore
```
3. **Executar Migrações do Banco de Dados:**
```sh
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```
4. **Executar a Aplicação:**
```sh
$ dotnet run --project TodoSolution.Api
```
### Frontend
1. **Navegar para o Diretório do Frontend:**
```sh
$ cd frontend
```
2. **Instalar Dependências:**

```sh
$ npm install
```
3. **Executar a Aplicação:**

```sh
$ npm run dev
```

## Executar Testes
### Backend
Para executar os testes unitários, utilize o comando:

```sh
$ dotnet test
```
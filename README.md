#  APIREST-Receitas
## Sobre o projeto
  API REST para controle dos serviços para meu site de receitas. Montada utilizando .NET CORE e .NET Framework.
<br>
 - [Respositório front-end](https://github.com/GabriellPassos/Receitas)

## :mag_right: Visão geral
## Rotas
### Receita
  | Método     | Rota           | Descrição|
| :---       |:---           |:---|
| `POST`      | /recipe/new    |Cria um novo usuário.|
| `GET`     | /recipe/search      | Busca receitas vinculadas ao ID de usuário.|
| `GET`      | /recipe/searchByRecipe      | Busca uma receita pora ID. |
| `DELETE`   | /recipe/delete       |  Remove um usuário por ID.|
#### Exemplo:
  ```json
{
    "name":"receita",
    "portions":1,
    "time":"00:05h",
    "stepByStep":"modo de preparo",
    "ingredients":[{
      "name":"ingrediente",
      "quantity":1,
      "unitMesure":"unidade"
    }],
    "tags":["massa","almoco"],
    "pictures":[]
}
```
### Tag de Filtragem
  | Método     | Rota           | Descrição|
| :---       |:---           |:---|
| `POST`      | /recipe/create    |Cria uma nova tag.|
| `GET`     | /recipe/getAll      | Busca todas as tags registradas.|
| `GET`      | /recipe/getById      | Busca tag por ID. |
| `DELETE`   | /recipe/delete       |  Remove uma tag por nome.|
#### Exemplo:
  ```json
{
    "name":"tag",
}
```
### Controle de Tag nas receitas
  | Método     | Rota           | Descrição|
| :---       |:---           |:---|
| `POST`      | /recipe_filterTag/new    |Vincula uma nova tag a receita.|
| `GET`     | /recipe/recipeByTagName      | Busca receitas pela tag.|
| `GET`      | /recipe/tagByRecipeId      | Busca uma tag pelo ID da receita. |
| `DELETE`   | /recipe/remove       |  Desvincula tag da receita.|
#### Exemplo:
  ```json
{
  "recipeId":"1",
  "filterTagId":1,
}
```
### Fotos
  | Método     | Rota           | Descrição|
| :---       |:---           |:---|
| `GET`      | /api/picture      | Busca as imagens vinculadas ao ID da receita |
| `DELETE`   | /api/picture        |  Exclui uma foto por ID.|
#### Exemplo:
  ```json
{
  "recipeId":"1",
  "base64Image":"zzzz",
}
```
### Autenticação
  A autenticação é feita através de cookies carregados com o JWT, que são trafegados a cada requisição.
  | Método     | Rota           | Descrição|
| :---       |:---           |:---|
| `GET`      | /authentication/register      | Registra um novo usuário |
| `GET`      | /authentication/login       | Inicia a sessão do usuário |
| `GET`      | /authentication/userCheck       | verifica se o token do usuário continua válido |
| `GET`      | /authentication/logout       | Encerra a sessão do usuário |

## :hammer_and_wrench: Tecnologias utilizadas
### Back end
- ASP.NET Core
- .NET Framework
- Pomelo
- JWT Bearer
### Banco de dados
- MySQL

## :rocket: Executando o projeto

### Back-End
```bash
# clone o repositório da APIREST
gh repo clone GabriellPassos/APIREST-Receitas

# Na raiz do projeto abra o terminal e acesse seu usuario mysql
mysql -u [seu-usuario] -p
# Em seguida digite sua senha

# Para importar o banco de dados
source [caminho-raiz-do-projeto]/BKPReceitasdb.sql;

# Importação completa, retorne a raiz do projeto
exit;

# Execute o projeto com o seguinte comando
dotnet run --url="http://http://localhost:5232/"
```
# Autor


[Gabriel Silva Passos](https://www.linkedin.com/in/gabrielsilvapassos/)

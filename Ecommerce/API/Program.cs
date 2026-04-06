//CONTRUIR A APLICAÇÃO BASE
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Endpoints - ADICIONAR FUNCIONALIDADES NA APLICAÇÃO
//Requisição
// - URL
// - Método HTTP
// - Listar/buscar (Retrive) dados: Método HTTP GET
// - Cadastrar (Create) dados: Método HTTP GET
app.MapGet("/", () => "API de Produtos!");

//GET: /api/produto/listar
app.MapGet("/api/produto/listar", () =>
{
    return "Lista de produtos";
});

//RODAR A APLICAÇÃO
app.Run();

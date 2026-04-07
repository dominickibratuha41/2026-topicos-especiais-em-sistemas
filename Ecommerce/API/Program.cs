//CONTRUIR A APLICAÇÃO BASE
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var produtos = new List<Produto>
{
    new Produto { Nome = "Teclado Mecânico RGB" },
    new Produto { Nome = "Mouse Gamer 12000 DPI" },
    new Produto { Nome = "Monitor 144Hz" },
    new Produto { Nome = "Headset 7.1 Surround" },
    new Produto { Nome = "Cadeira Ergonômica" },
    new Produto { Nome = "Webcam Full HD" },
    new Produto { Nome = "Microfone Condensador" },
    new Produto { Nome = "SSD NVMe 1TB" },
    new Produto { Nome = "Placa de Vídeo RTX" },
    new Produto { Nome = "Memória RAM 16GB DDR4" }
        };

//Endpoints - ADICIONAR FUNCIONALIDADES NA APLICAÇÃO
//Requisição
// - URL
// - Método HTTP
// - Listar/buscar (Retrive) dados: Método HTTP GET
// - Cadastrar (Create) dados: Método HTTP GET
app.MapGet("/", () => "API de Produtos!");

//GET: /api/produto/listar
app.MapPost("/api/produto/listar", () =>
{
    return produtos;
});


//POST: /api/produto/cadastrar
app.MapPost("/api/produto/cadastrar", (Produto produtos) =>
{
    Produtos.Add(Produtos);
});


//RODAR A APLICAÇÃO
app.Run();

public class Produto 
{
    public string? Nome { get; set; }
}

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

// Lista inicializada já com a classe corrigida
List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Teclado Mecânico RGB" },
    new Produto { Nome = "Mouse Gamer 12000 DPI" }
};

app.MapGet("/", () => "API de Produtos!");

app.MapGet("/api/produto/listar", ([FromServices] AppDataContext ctx) => 
{
    if (ctx.Produtos.Any())
    {
        return Results.Ok(ctx.Produtos.ToList());
    }
    return Results.Ok(produtos);
});

app.MapPost("/api/produto/cadastrar", (Produto produto) =>
{
    produtos.Add(produto);
    return Results.Created($"/api/produto/{produto.Id}", produto);
});

// GET: /api/produto/buscar/{id}
app.MapGet("/api/produto/buscar/{id}", (string id) =>
{
    foreach (Produto produtoCadastrado in produtos)
    {
        if (produtoCadastrado.Id == id)
        {
            return Results.Ok(produtoCadastrado);
        }
    }
    // CORREÇÃO: Adicionado o ';' que faltava
    return Results.NotFound("Produto não encontrado!");
});

app.Run();

// CORREÇÃO: A classe precisa ter o Id e o construtor para gerar o Guid
public class Produto 
{
    public string Id { get; set; }
    public string? Nome { get; set; }

    public Produto()
    {
        Id = Guid.NewGuid().ToString();
    }
}
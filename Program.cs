using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=app.db"));
var app = builder.Build();

//Get Listar todos os produtos.
app.MapGet("/produtos", (AppDbContext db) =>
{
    return Results.Ok(db.Produtos.ToList());
});
// Get que busca por id.
app.MapGet("/produtos/{id}", (int id, AppDbContext db) =>
{
    var produto = db.Produtos.Find(id);
    return produto != null ? Results.Ok(produto) : Results.NotFound();
});
//post criar produto
app.MapPost("/produtos", (Produto produto, AppDbContext db) =>
{
    db.Produtos.Add(produto);
    db.SaveChanges();
    return Results.Created($"/produtos/{produto.Id}", produto);
});
// Delete produto
app.MapDelete("/produtos/{id}", (int id, AppDbContext db) =>
{
    var produto = db.Produtos.Find(id);
    if (produto == null) return Results.NotFound();
    db.Produtos.Remove(produto);
    db.SaveChanges();
    return Results.NoContent();
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseHttpsRedirection();


app.Run();


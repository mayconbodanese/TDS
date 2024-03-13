using Microsoft.OpenApi.Models;
using ProductStore.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product API", Description = "Best products very cheap", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Products API V1");
});

app.MapGet      ("/products/{id}",  (int id)            => ProductDB.GetProduct(id));
app.MapGet      ("/products",       ()                  => ProductDB.GetProducts());
app.MapPost     ("/products",       (Product product)   => ProductDB.CreateProduct(product));
app.MapPut      ("/products",       (Product product)   => ProductDB.UpdateProduct(product));
app.MapDelete   ("/products/{id}",  (int id)            => ProductDB.RemoveProduct(id));

app.Run();
using TutoStore.Api.Entities;

List<Product> products = new()
{
    new Product(){
        Id = 1,
        Name = "USB-Driver",
        Genre = "Tech",
        Price = 19.99M,
        ReleaseDate = new DateTime(2024, 2, 1),
        ImageUri = "http://placehold.co/100"
    },

    new Product(){
        Id = 2,
        Name = "Cable-type C",
        Genre = "Tech",
        Price = 12.99M,
        ReleaseDate = new DateTime(2024, 2, 11),
        ImageUri = "http://placehold.co/100"
    },

     new Product(){
        Id = 3,
        Name = "Sounds2 pro",
        Genre = "Tech",
        Price = 20.89M,
        ReleaseDate = new DateTime(2024, 2, 22),
        ImageUri = "http://placehold.co/100"
    },
};




var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapGet("/products", () => products);

app.MapGet("products/{id}", (int id) => products.Find(product => product.Id == id));

app.Run();

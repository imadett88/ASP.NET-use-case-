namespace TutoStore.Api.Entities;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; } //string? => null(without do string name = "imm")
    public required string Genre { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public required string ImageUri { get; set; }


}
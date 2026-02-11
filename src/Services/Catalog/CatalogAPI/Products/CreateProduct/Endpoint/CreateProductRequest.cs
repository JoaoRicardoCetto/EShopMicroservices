namespace CatalogAPI.Products.CreateProduct.Endpoint
{
    public record CreateProductRequest
        (string Name, List<string> Category, string Description, string imageFile, decimal price)
    {
    }
}

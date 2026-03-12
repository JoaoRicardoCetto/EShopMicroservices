namespace CatalogAPI.Products.UpdateProduct.Endpoint
{
    public record UpdateProductRequest(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    {
    }
}

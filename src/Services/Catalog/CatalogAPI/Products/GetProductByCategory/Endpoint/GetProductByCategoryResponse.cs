namespace CatalogAPI.Products.GetProductByCategory.Endpoint
{
    public record GetProductByCategoryResponse(IEnumerable<Product> Products)
    {
    }
}

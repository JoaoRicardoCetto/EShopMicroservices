namespace CatalogAPI.Products.GetProducts.Endpoint
{
    public record GetProductsResponse(IEnumerable<Product> Products)
    {
    }
}

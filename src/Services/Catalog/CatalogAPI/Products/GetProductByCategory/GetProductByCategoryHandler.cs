namespace CatalogAPI.Products.GetProductByCategory
{
    public class GetProductByCategoryHandler(IDocumentSession session, ILogger<GetProductByCategoryHandler> logger) 
        : IQueryHandler<GetProductByCategoryQuery, GetProductByCategoryResult>
    {
        public async Task<GetProductByCategoryResult> Handle(GetProductByCategoryQuery query, CancellationToken cancellationToken)
        {
            var products = await session.Query<Product>()
                .Where(p => p.Category.Contains(query.Category))
                .ToListAsync(cancellationToken);

            logger.LogInformation("GetProductByCategoryHandler.Handler called with {Count} products for category '{Category}'", products.Count, query.Category);

            return new GetProductByCategoryResult(products);
        }
    }
}

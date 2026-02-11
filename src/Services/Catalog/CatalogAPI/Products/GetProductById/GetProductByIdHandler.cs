namespace CatalogAPI.Products.GetProductById
{
    public class GetProductByIdHandler(IDocumentSession session, ILogger<GetProductByIdHandler> logger)
        : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
    {
        public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            logger.LogInformation("GetProductsByIdQueryHandler.Handler called with {@Query}", query);

            var product = await session.LoadAsync<Product>(query.Id, cancellationToken);

            if(product is null)
            {
                throw new ProductNotFoundException();
            }

            return new GetProductByIdResult(product);
        }
    }
}

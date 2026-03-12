
namespace CatalogAPI.Products.DeleteProduct
{
    public class DeleteProductHandler(IDocumentSession session, ILogger<DeleteProductHandler> logger)
        : ICommandHandler<DeleteProductCommand, DeleteProductResult>
    {
        public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            logger.LogInformation("Handling DeleteProductCommand for product with id: {id}", command.Id);

            session.Delete<Product>(command.Id);
            await session.SaveChangesAsync(cancellationToken);
        
            return new DeleteProductResult(true);
        }
    }
}

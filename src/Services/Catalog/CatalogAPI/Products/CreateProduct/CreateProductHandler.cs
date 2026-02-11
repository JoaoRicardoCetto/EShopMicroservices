namespace CatalogAPI.Products.CreateProduct;

public class CreateProductHandler(IDocumentSession session) : ICommandHandler<CreateProductCommand, CreateProdutResult>
{
    public async Task<CreateProdutResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);


        return new CreateProdutResult(product.Id);
    }
}

using BuildingBlocks.CQRS;
using MediatR;

namespace CatalogAPI.Products.CreateProduct;

public record CreateProductCommand(
    string Name,
    List<string> Category,
    string Description,
    string ImageFile,
    decimal Price
    ) : ICommand<CreateProdutResult>;


namespace CatalogAPI.Products.GetProducts.Endpoint;

public class GetProductsEndpoint : ICarterModule
{

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products", async (ISender sender) =>
        {
            var result = await sender.Send(new GetProductsQuery());

            var response = result.Adapt<GetProductsResponse>();

            return Results.Ok(response);
        }).WithName("GetProducts")
          .Produces<GetProductsResponse>(StatusCodes.Status200OK)
          .ProducesProblem(StatusCodes.Status400BadRequest)
          .WithSummary("Get a list of products")
          .WithDescription("Retrieves a list of products from the catalog.");
    }
}

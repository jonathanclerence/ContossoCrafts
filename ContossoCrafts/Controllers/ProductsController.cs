using ContossoCrafts.Models;
using ContossoCrafts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContossoCrafts.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    public ProductsController(JsonFileProductService productService) => ProductService = productService;
    public JsonFileProductService ProductService { get; }

    [HttpGet]
    public IEnumerable<Product> Get() => ProductService.GetProducts();
}
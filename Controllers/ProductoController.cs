using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiDinet.Models;
using webApiDinet.Repository.Contracts;

namespace webApiDinet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IProductoRepository _productoRepository;

        public ProductoController(ILogger<WeatherForecastController> logger, IProductoRepository productoRepository)
        {
            _logger = logger;
            _productoRepository = productoRepository;
        }
        [HttpGet]
        public Task<IEnumerable<Producto>> Get()
        {
            return _productoRepository.GetProductos();
        }
        [HttpPost]
        public Task<int> Post(Producto obj)
        {
            return _productoRepository.CreateProducto(obj);
        }
    }
}

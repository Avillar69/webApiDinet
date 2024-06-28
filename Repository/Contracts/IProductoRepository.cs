using webApiDinet.Models;

namespace webApiDinet.Repository.Contracts
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetProductos();
        Task<int> CreateProducto(Producto obj);
    }
}

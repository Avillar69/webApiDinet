using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;
using webApiDinet.Models;
using webApiDinet.Repository.Contracts;

namespace webApiDinet.Repository.Implementations
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly DinetDbContext _dbContext;
        public ProductoRepository(DinetDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Producto>> GetProductos()
        {
            return await _dbContext.Productos.ToListAsync();
        }
        public async Task<int> CreateProducto(Producto obj)
        {
            obj.FechaCreacion = DateTime.Now;
            _dbContext.Productos.Add(obj);
            return await _dbContext.SaveChangesAsync();
        }
    }
}

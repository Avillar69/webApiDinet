﻿namespace webApiDinet.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

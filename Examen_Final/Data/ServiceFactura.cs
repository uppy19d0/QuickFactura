using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Examen_Final.Data
{
    public class ServiceFactura
    {
        private ApplicationDbContext _dbContext;

        public ServiceFactura(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Obtener Factura
        public async Task<List<Factura>> GetFacturaAsync() => await _dbContext.facturas.Include(f => f.Cliente).Include(f => f.facturas_detalle).Include(f => f.producto).ToListAsync();

        //FacturaSingle
        public async Task<Factura> GetFacturaSingleAsync(int idFactura) => await _dbContext.facturas.Include(f => f.Cliente).Include(f => f.facturas_detalle).Include(f => f.producto).FirstOrDefaultAsync(f => f.FacturaID == idFactura);

        //public async Task SubtractionStockAsync(int idProducto, double ctvendido_producto)
        //{
        //    try
        //    {
        //        Producto producto = await _dbContext.productos.FirstOrDefaultAsync(p => p.ProductoID == idProducto);
        //        _ = producto.Cantidad - ctvendido_producto;
        //        _dbContext.Update(producto);
        //        await _dbContext.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //Crear Factura
        public async Task<Factura> AddFacturaAsync(Factura factura)
        {
            try
            {
                for (var i = 0; i < factura.facturas_detalle.Count; i++)
                {
                    var indice = i;
                    var producto = factura.facturas_detalle[i];

                    Producto producto1 = await _dbContext.productos.FirstOrDefaultAsync(p => p.ProductoID == producto.ProductoID);
                    if (producto1.Servicio == false)
                    {
                        producto1.Cantidad = producto1.Cantidad - producto.Cantidad;
                        _dbContext.Update(producto1);
                    }

                }
                _dbContext.facturas.Add(factura);
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }


        //Actualizar Factura
        public async Task<Factura> UpdateFacturaAsync(Factura factura)
        {
            try
            {
                var secretExist = _dbContext.facturas.FirstOrDefaultAsync(_factura => _factura.FacturaID == factura.FacturaID);
                if (secretExist != null)
                {
                    if (factura.Cancelada)
                    {
                        for (var i = 0; i < factura.facturas_detalle.Count; i++)
                        {
                            var indice = i;
                            var producto = factura.facturas_detalle[i];


                            Producto producto1 = await _dbContext.productos.FirstOrDefaultAsync(p => p.ProductoID == producto.ProductoID);
                            if (producto1.Servicio == false)
                            {
                                producto1.Cantidad = producto1.Cantidad + producto.Cantidad;
                                _dbContext.Update(producto1);
                            }
                        }

                    }
                    else
                    {
                        for (var i = 0; i < factura.facturas_detalle.Count; i++)
                        {
                            var indice = i;
                            var producto = factura.facturas_detalle[i];


                            Producto producto1 = await _dbContext.productos.FirstOrDefaultAsync(p => p.ProductoID == producto.ProductoID);
                            if (producto1.Servicio == false)
                            {
                                producto1.Cantidad = producto1.Cantidad - producto.Cantidad;
                                _dbContext.Update(producto1);
                            }
                        }
                    }
                    _dbContext.Update(factura);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }
        //Borrar Factura
        public async Task DeleteFacturaAsync(Factura factura)
        {
            try
            {
                _dbContext.facturas.Remove(factura);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

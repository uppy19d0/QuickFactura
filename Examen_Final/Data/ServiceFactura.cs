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
        public async Task<List<Factura>> GetFacturaAsync() => await _dbContext.facturas.ToListAsync();


        //Crear Factura
        public async Task<Factura> AddFacturaAsync(Factura factura)
        {
            try
            {
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

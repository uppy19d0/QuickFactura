using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Examen_Final.Data
{
    public class ServiceCliente
    {
        private ApplicationDbContext _dbContext;

        public ServiceCliente(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
         //Obtener Cliente
        public async Task<List<Cliente>> GetClientesAsync() => await _dbContext.clientes.ToListAsync();


        //Crear Cliente
        public async Task<Cliente> AddClienteAsync(Cliente cliente)
        {
            try
            {
                _dbContext.clientes.Add(cliente);
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
            return cliente;
        }

        //Actualizar Cliente
        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            try
            {
                var clientExist = _dbContext.clientes.FirstOrDefaultAsync(_cliente => _cliente.ClienteId == cliente.ClienteId);
                if (clientExist != null)
                {
                    _dbContext.Update(cliente);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cliente;
        }
        //Borrar Cliente
        // public async Task DeleteClienteAsync(Factura factura)
        // {
        //     try
        //     {
        //         _dbContext.facturas.Remove(factura);
        //         await _dbContext.SaveChangesAsync();
        //     }
        //     catch (Exception)
        //     {
        //         throw;
        //     }
        // }
    }
}

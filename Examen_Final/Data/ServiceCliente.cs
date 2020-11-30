using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Examen_Final.Data
{
    public class ServiceCliente
    {
        private ApplicationDbContext _dbContext;
        // private readonly IWebHostEnvironment _webHostEnvironment;
        public ServiceCliente(ApplicationDbContext dbContext,
         IWebHostEnvironment Environment
         )
        {
            _dbContext = dbContext;
            // _webHostEnvironment = Environment;
        }
        //Obtener Cliente
        public async Task<List<Cliente>> GetClientesAsync() => await _dbContext.clientes.ToListAsync();


        //Crear Cliente
        public async Task<Cliente> AddClienteAsync(Cliente cliente
        // IFileListEntry file
        )
        {
            try
            {
                // var path = Path.Combine(_webHostEnvironment.ContentRootPath, "./wwwroot/Clientes", file.Name);
                // var streamwriter = new MemoryStream();
                // await file.Data.CopyToAsync(streamwriter);
                // FileStream files = new FileStream(path, FileMode.Create, FileAccess.Write);
                // {
                //    streamwriter.WriteTo(files);
                //    cliente.Foto = path.Substring(path.LastIndexOf("Clientes"));
                // }
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
                var clientExist = _dbContext.clientes.FirstOrDefaultAsync(_cliente => _cliente.ClienteID == cliente.ClienteID);
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
        // Desactivar Cliente
        public async Task DesactivarClienteAsync(Factura factura)
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

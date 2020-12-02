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
    public class ServiceProducto
    {
        
        private ApplicationDbContext _dbContext;
        //private readonly IWebHostEnvironment _webHostEnvironment;  
        public ServiceProducto(ApplicationDbContext dbContext
            //IWebHostEnvironment Environment
            )
        {
            _dbContext = dbContext;
            //_webHostEnvironment = Environment;

        }
         //Obtener Producto
        public async Task<List<Producto>> GetProductoAsync() => await _dbContext.productos.ToListAsync();

        public async Task<Producto> GetProductoSingleAsync(int idProducto) => await _dbContext.productos.FirstOrDefaultAsync(p => p.ProductoID == idProducto);
        
        //Crear Producto
        public async Task<Producto> AddProductoAsync(Producto producto
            //IFileListEntry file
            )
        {
            try
            {
               //var path = Path.Combine(_webHostEnvironment.ContentRootPath,"./wwwroot/Productos",file.Name);
               //var streamwriter = new MemoryStream();
               //await file.Data.CopyToAsync(streamwriter);
               // FileStream files=new FileStream(path,FileMode.Create,FileAccess.Write);
               // {
               //     streamwriter.WriteTo(files);
               //     producto.img =path.Substring(path.LastIndexOf("Productos"));
               // }
                _dbContext.productos.Add(producto);
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        //Actualizar Producto
        public async Task<Producto> UpdateProductoAsync(Producto producto)
        {
            try
            {
                var secretExist = _dbContext.productos.FirstOrDefaultAsync(_producto => _producto.ProductoID == producto.ProductoID);
                if (secretExist != null)
                {
                    _dbContext.Update(producto);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }
        //Borrar Producto
        // public async Task DeleteProductoAsync(Producto producto)
        // {
        //     try
        //     {
        //         _dbContext.productos.Remove(producto);
        //         await _dbContext.SaveChangesAsync();
        //     }
        //     catch (Exception)
        //     {
        //         throw;
        //     }
        // }

    }
}

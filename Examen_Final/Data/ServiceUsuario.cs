using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Examen_Final.Data
{
    public class ServiceUsuario
    {
        
    private ApplicationDbContext _dbContext;

    public ServiceUsuario(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
         //Obtener mi informacion
        public async Task<Usuario> getInformation(string Name_search) => await _dbContext.usuarios.FirstOrDefaultAsync(Usuario => Usuario.UserName == Name_search);
    }
}

using EntityFrameworkIntro.Data;
using EntityFrameworkIntro.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityFrameworkIntro.servicios
{
    public class ServicioCliente : IServicioCliente
    {
        private readonly EFIntroContext _context;
        public ServicioCliente(EFIntroContext context)
        {
            _context = context;
        }

        public async Task<Clients> Detalles(int? id)
        {
            var clients = await _context.Clients
                .FirstOrDefaultAsync(m => m.Id == id);
            return clients;
        }

        public async Task<List<Clients>> ListarClientes()
        {
            return await _context.Clients.ToListAsync();
        }
       
    }
}

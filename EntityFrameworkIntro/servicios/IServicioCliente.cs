using EntityFrameworkIntro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityFrameworkIntro.servicios
{
    public interface IServicioCliente
    {
        Task<List<Clients>> ListarClientes();
        Task<Clients> Detalles(int? id);
        
    }


}

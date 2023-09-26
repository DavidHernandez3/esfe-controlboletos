using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public interface IGrupoService
    {
        Task<bool> Insertar(Grupo model);
        Task<bool> Actualizar(Grupo model);
        Task<bool> Eliminar(int id);
        Task<Grupo> Obtener(int id);
        Task<IQueryable<Grupo>> ObtenerTodos();
    }
}

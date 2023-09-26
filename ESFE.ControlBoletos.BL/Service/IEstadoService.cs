using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public interface IEstadoService
    {
        Task<bool> Insertar(Estado model);
        Task<bool> Actualizar(Estado model);
        Task<bool> Eliminar(int id);
        Task<Estado> Obtener(int id);
        Task<IQueryable<Estado>> ObtenerTodos();
    }
}

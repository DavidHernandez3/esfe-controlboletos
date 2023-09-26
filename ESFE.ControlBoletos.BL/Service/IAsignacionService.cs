using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public interface IAsignacionService
    {
        Task<bool> Insertar(Asignacion model);
        Task<bool> Actualizar(Asignacion model);
        Task<bool> Eliminar(int id);
        Task<Asignacion> Obtener(int id);
        Task<IQueryable<Asignacion>> ObtenerTodos();
    }
}

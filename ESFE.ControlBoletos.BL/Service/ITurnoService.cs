using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public interface ITurnoService
    {
        Task<bool> Insertar(Turno model);
        Task<bool> Actualizar(Turno model);
        Task<bool> Eliminar(int id);
        Task<Turno> Obtener(int id);
        Task<IQueryable<Turno>> ObtenerTodos();
    }
}

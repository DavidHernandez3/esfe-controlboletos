using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public interface IDocenteService
    {
        Task<bool> Insertar(Docente model);
        Task<bool> Actualizar(Docente model);
        Task<bool> Eliminar(int id);
        Task<Docente> Obtener(int id);
        Task<IQueryable<Docente>> ObtenerTodos();
    }
}

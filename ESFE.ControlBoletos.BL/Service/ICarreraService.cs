using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public interface ICarreraService
    {
        Task<bool> Insertar(Carrera model);
        Task<bool> Actualizar(Carrera model);
        Task<bool> Eliminar(int id);
        Task<Carrera> Obtener(int id);
        Task<IQueryable<Carrera>> ObtenerTodos();
    }
}

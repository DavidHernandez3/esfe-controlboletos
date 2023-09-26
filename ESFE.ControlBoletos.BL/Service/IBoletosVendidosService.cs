using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public interface IBoletosVendidosService
    {
        Task<bool> Insertar(BoletosVendido model);
        Task<bool> Actualizar(BoletosVendido model);
        Task<bool> Eliminar(int id);
        Task<BoletosVendido> Obtener(int id);
        Task<IQueryable<BoletosVendido>> ObtenerTodos();
    }
}

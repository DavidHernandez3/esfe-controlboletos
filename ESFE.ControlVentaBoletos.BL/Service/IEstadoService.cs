using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public interface IEstadoService
	{
		Task<bool> Insertar(Estado modelo);
		Task<bool> Actualizar(Estado modelo);
		Task<bool> Eliminar(int id);
		Task<Estado> Obtener(int id);
		Task<IQueryable<Estado>> ObtenerTodos();
	}
}

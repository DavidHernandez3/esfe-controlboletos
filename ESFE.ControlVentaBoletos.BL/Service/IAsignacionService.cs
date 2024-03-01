using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public interface IAsignacionService
	{
		Task<bool> Insertar(Asignacion modelo);
		Task<bool> Actualizar(Asignacion modelo);
		Task<bool> Eliminar(int id);
		Task<Asignacion> Obtener(int id);
		Task<IQueryable<Asignacion>> ObtenerTodos();
	}
}

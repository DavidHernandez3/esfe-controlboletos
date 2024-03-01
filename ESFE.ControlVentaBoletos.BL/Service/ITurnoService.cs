using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public interface ITurnoService
	{
		Task<bool> Insertar(Turno modelo);
		Task<bool> Actualizar(Turno modelo);
		Task<bool> Eliminar(int id);
		Task<Turno> Obtener(int id);
		Task<IQueryable<Turno>> ObtenerTodos();
	}
}

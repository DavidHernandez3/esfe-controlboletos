using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public interface IDocenteService
	{
		Task<bool> Insertar(Docente modelo);
		Task<bool> Actualizar(Docente modelo);
		Task<bool> Eliminar(int id);
		Task<Docente> Obtener(int id);
		Task<IQueryable<Docente>> ObtenerTodos();
	}
}
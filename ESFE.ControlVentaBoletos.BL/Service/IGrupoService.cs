using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public interface IGrupoService 
	{
		Task<bool> Insertar(Grupo modelo);
		Task<bool> Actualizar(Grupo modelo);
		Task<bool> Eliminar(int id);
		Task<Grupo> Obtener(int id);
		Task<IQueryable<Grupo>> ObtenerTodos();
	}
}

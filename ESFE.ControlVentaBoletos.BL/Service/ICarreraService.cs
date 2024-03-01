using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public interface ICarreraService
	{
		Task<bool> Insertar(Carrera modelo);
		Task<bool> Actualizar(Carrera modelo);
		Task<bool> Eliminar(int id);
		Task<Carrera> Obtener(int id);
		Task<IQueryable<Carrera>> ObtenerTodos();
	}
}

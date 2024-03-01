using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public interface IBoletosVendidoService
	{
		Task<bool> Insertar(BoletosVendido modelo);
		Task<bool> Actualizar(BoletosVendido modelo);
		Task<bool> Eliminar(int id);
		Task<BoletosVendido> Obtener(int id);
		Task<IQueryable<BoletosVendido>> ObtenerTodos();
	}
}

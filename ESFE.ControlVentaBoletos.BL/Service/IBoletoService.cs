using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public interface IBoletoService
	{
		Task<bool> Insertar(Boleto modelo);
		Task<bool> Actualizar(Boleto modelo);
		Task<bool> Eliminar(int id);
		Task<Boleto> Obtener(int id);
		Task<IQueryable<Boleto>> ObtenerTodos();
	}
}

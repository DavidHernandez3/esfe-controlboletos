using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public class AsignacionService:IAsignacionService
	{

		private readonly IGenericRepository<Asignacion> _AsignacionRepo;

		public AsignacionService(IGenericRepository<Asignacion> asignacionrepo)
		{
			_AsignacionRepo = asignacionrepo;
		}

		public async Task<bool> Actualizar(Asignacion modelo)
		{
			return await _AsignacionRepo.Actualizar(modelo);
		}

		public async Task<bool> Eliminar(int id)
		{
			return await _AsignacionRepo.Eliminar(id);
		}

		public async Task<bool> Insertar(Asignacion modelo)
		{
			return await _AsignacionRepo.Insertar(modelo);
		}

		public async Task<Asignacion> Obtener(int id)
		{
			return await _AsignacionRepo.Obtener(id);
		}

		public async Task<IQueryable<Asignacion>> ObtenerTodos()
		{
			return await _AsignacionRepo.ObtenerTodos();
		}
	}
}

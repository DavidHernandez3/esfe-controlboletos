using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public class GrupoService : IGrupoService
	{
		private readonly IGenericRepository<Grupo> _GrupoRepo;

		public GrupoService(IGenericRepository<Grupo> gruporepo)
		{
			_GrupoRepo = gruporepo;
		}

		public async Task<bool> Actualizar(Grupo modelo)
		{
			return await _GrupoRepo.Actualizar(modelo);
		}

		public async Task<bool> Eliminar(int id)
		{
			return await _GrupoRepo.Eliminar(id);
		}

		public async Task<bool> Insertar(Grupo modelo)
		{
			return await _GrupoRepo.Actualizar(modelo);
		}

		public async Task<Grupo> Obtener(int id)
		{
			return await _GrupoRepo.Obtener(id);
		}

		public async Task<IQueryable<Grupo>> ObtenerTodos()
		{
			return await _GrupoRepo.ObtenerTodos();
		}
	}
}

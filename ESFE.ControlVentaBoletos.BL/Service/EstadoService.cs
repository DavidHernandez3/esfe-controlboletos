using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public class EstadoService : IEstadoService
	{
		private readonly IGenericRepository<Estado> _EstadoRepo;

        public EstadoService( IGenericRepository <Estado> estadorepo)
        {
			_EstadoRepo = estadorepo;
        }
        public async Task<bool> Actualizar(Estado modelo)
		{
			return await _EstadoRepo.Actualizar(modelo);
		}	

		public async Task<bool> Eliminar(int id)
		{
			return await _EstadoRepo.Eliminar(id);
		}

		public async Task<bool> Insertar(Estado modelo)
		{
			return await _EstadoRepo.Insertar(modelo);
		}

		public async Task<Estado> Obtener(int id)
		{
			return await _EstadoRepo.Obtener(id);
		}	

		public async Task<IQueryable<Estado>> ObtenerTodos()
		{
			return await _EstadoRepo.ObtenerTodos();
		}
	}
}

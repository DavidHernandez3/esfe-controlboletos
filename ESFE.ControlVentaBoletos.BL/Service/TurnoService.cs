using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public class TurnoService : ITurnoService
	{
		private readonly IGenericRepository<Turno> _TurnoRepo; 

        public TurnoService( IGenericRepository<Turno> turnorepo)
        {
			_TurnoRepo = turnorepo;
        }
        public async Task<bool> Actualizar(Turno modelo)
		{
			return await _TurnoRepo.Actualizar(modelo);
		}

		public async  Task<bool> Eliminar(int id)
		{
			return await _TurnoRepo.Eliminar(id);
		}

		public async Task<bool> Insertar(Turno modelo)
		{
			return await _TurnoRepo.Actualizar(modelo);
		}

		public async Task<Turno> Obtener(int id)
		{
			return await _TurnoRepo.Obtener(id);
		}

		public async Task<IQueryable<Turno>> ObtenerTodos()
		{
			return await _TurnoRepo.ObtenerTodos();
		}
	}
}

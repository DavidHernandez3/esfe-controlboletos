using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public class DocenteService : IDocenteService
	{
		private readonly IGenericRepository<Docente> _DocenteRepo;
        public DocenteService(IGenericRepository<Docente> docenterepo)
        {
			_DocenteRepo = docenterepo; 
        }
        public async Task<bool> Actualizar(Docente modelo)
		{
			return await _DocenteRepo.Actualizar(modelo);
		}

		public async Task<bool> Eliminar(int id)
		{
			return await _DocenteRepo.Eliminar(id);
		}

		public async Task<bool> Insertar(Docente modelo)
		{
			return await _DocenteRepo.Actualizar(modelo);
		}

		public async Task<Docente> Obtener(int id)
		{
			return await _DocenteRepo.Obtener(id);
		}

		public async Task<IQueryable<Docente>> ObtenerTodos()
		{
			return await _DocenteRepo.ObtenerTodos();
		}
	}
}

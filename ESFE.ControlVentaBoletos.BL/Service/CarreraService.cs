using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public class CarreraService : ICarreraService
	{
		private readonly IGenericRepository <Carrera> _CarreraRepo;

        public CarreraService(IGenericRepository<Carrera> carreraservice)
        {
			_CarreraRepo = carreraservice;
        }
        public async Task<bool> Actualizar(Carrera modelo)
		{
			return await _CarreraRepo.Actualizar(modelo);
		}

		public async Task<bool> Eliminar(int id)
		{
			return await _CarreraRepo.Eliminar(id);
		}

		public async Task<bool> Insertar(Carrera modelo)
		{
			return await _CarreraRepo.Insertar(modelo);
		}

		public async Task<Carrera> Obtener(int id)
		{
			return await _CarreraRepo.Obtener(id);
		}

		public async Task<IQueryable<Carrera>> ObtenerTodos()
		{
			return await _CarreraRepo.ObtenerTodos();
		}
	}
}

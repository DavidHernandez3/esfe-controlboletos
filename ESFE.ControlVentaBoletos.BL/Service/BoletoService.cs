using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public class BoletoService : IBoletoService
	{
		private readonly IGenericRepository<Boleto> _BoletoRepo;

		public BoletoService(IGenericRepository<Boleto> boletorepo)
		{
			_BoletoRepo = boletorepo;
        }

        public async Task<bool> Actualizar(Boleto modelo)
		{
			return await _BoletoRepo.Actualizar(modelo);
		}

		public async Task<bool> Eliminar(int id)
		{
			return await _BoletoRepo.Eliminar(id);
		}

		public async Task<bool> Insertar(Boleto modelo)
		{
			return await _BoletoRepo.Insertar(modelo);
		}

		public async Task<Boleto> Obtener(int id)
		{
			return await _BoletoRepo.Obtener(id);
		}

		public async Task<IQueryable<Boleto>> ObtenerTodos()
		{
			return await _BoletoRepo.ObtenerTodos();
		}
	}
}

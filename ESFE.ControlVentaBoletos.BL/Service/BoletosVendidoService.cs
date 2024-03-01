using ESFE.ControlVentaBoletos.DAL.Repositorio;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.BL.Service
{
	public class BoletosVendidoService : IBoletosVendidoService
	{
		private readonly IGenericRepository<BoletosVendido> _BoletoVendidoRepo;

        public BoletosVendidoService(IGenericRepository <BoletosVendido> boletosevendidosrepo)
        {
            _BoletoVendidoRepo = boletosevendidosrepo;
        }

        public async Task<bool> Actualizar(BoletosVendido modelo)
		{
			return await _BoletoVendidoRepo.Actualizar(modelo);
		}

		public async Task<bool> Eliminar(int id)
		{
			return await _BoletoVendidoRepo.Eliminar(id);
		}

		public async Task<bool> Insertar(BoletosVendido modelo)
		{
			return await _BoletoVendidoRepo.Insertar(modelo);
		}

		public async Task<BoletosVendido> Obtener(int id)
		{
			return await _BoletoVendidoRepo.Obtener(id);
		}

		public async Task<IQueryable<BoletosVendido>> ObtenerTodos()
		{
			return await _BoletoVendidoRepo.ObtenerTodos();
		}	
	}
}

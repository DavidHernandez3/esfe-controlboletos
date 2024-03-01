using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class BoletoRepository : IGenericRepository<Boleto>
	{
		private readonly ControlVentaBoletosContext _BoletoRepo;

        public BoletoRepository(ControlVentaBoletosContext boletorepo)
        {
            _BoletoRepo = boletorepo;
        }

        public async Task<bool> Actualizar(Boleto modelo)
		{
			_BoletoRepo.Boletos.Update(modelo);
			await _BoletoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			Boleto Model = _BoletoRepo.Boletos.First(c => c.Id == id);
			_BoletoRepo.Remove(Model);
			await _BoletoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(Boleto modelo)
		{
			_BoletoRepo.Boletos.Add(modelo);
			await _BoletoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<Boleto> Obtener(int id)
		{
			return await _BoletoRepo.Boletos.FindAsync(id);
		}

		public async Task<IQueryable<Boleto>> ObtenerTodos()
		{
			IQueryable<Boleto> queryBoletoSQL = _BoletoRepo.Boletos;
			return queryBoletoSQL;
		}
	}
}

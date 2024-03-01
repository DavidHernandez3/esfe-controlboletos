using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class BoletosVendidoRepository : IGenericRepository<BoletosVendido>
	{
		private readonly ControlVentaBoletosContext _BoletovendidoRepo;

        public BoletosVendidoRepository(ControlVentaBoletosContext boletovendidorepo)
        {
			_BoletovendidoRepo = boletovendidorepo; 
        }

        public async  Task<bool> Actualizar(BoletosVendido modelo)
		{
			_BoletovendidoRepo.BoletosVendidos.Update(modelo);
			await _BoletovendidoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			BoletosVendido Model = _BoletovendidoRepo.BoletosVendidos.First(c => c.Id == id);
			_BoletovendidoRepo.Remove(Model);
			await _BoletovendidoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(BoletosVendido modelo)
		{
			_BoletovendidoRepo.BoletosVendidos.Add(modelo);
			await _BoletovendidoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<BoletosVendido> Obtener(int id)
		{
			return await _BoletovendidoRepo.BoletosVendidos.FindAsync(id);
		}

		public async Task<IQueryable<BoletosVendido>> ObtenerTodos()
		{
			IQueryable<BoletosVendido> queryBoletosVendidoSQL = _BoletovendidoRepo.BoletosVendidos;
			return queryBoletosVendidoSQL;
		}
	}
}

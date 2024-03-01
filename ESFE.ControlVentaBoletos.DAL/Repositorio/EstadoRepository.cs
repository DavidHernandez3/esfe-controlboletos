using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class EstadoRepository : IGenericRepository<Estado>
	{
		private readonly ControlVentaBoletosContext _EstadoRepo;

        public EstadoRepository(ControlVentaBoletosContext estadorepo)
        {
			_EstadoRepo = estadorepo;
        }
        public async Task<bool> Actualizar(Estado modelo)
		{
			_EstadoRepo.Estados.Update(modelo);
			await _EstadoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			Estado Model = _EstadoRepo.Estados.First(c => c.Id == id);
			_EstadoRepo.Remove(Model);
			await _EstadoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(Estado modelo)
		{
			_EstadoRepo.Estados.Add(modelo);
			await _EstadoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<Estado> Obtener(int id)
		{
			return await _EstadoRepo.Estados.FindAsync(id);
		}

		public async Task<IQueryable<Estado>> ObtenerTodos()
		{
			IQueryable<Estado> queryEstadoSQL = _EstadoRepo.Estados;
			return queryEstadoSQL;
		}
	}
}

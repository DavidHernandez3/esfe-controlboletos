using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class AsignacionRepository : IGenericRepository<Asignacion>
	{
		private readonly ControlVentaBoletosContext _AsignacionRepo;

        public AsignacionRepository(ControlVentaBoletosContext asignacionrepo)
        {
			_AsignacionRepo = asignacionrepo;
		}

        public async Task<bool> Actualizar(Asignacion modelo)
		{
			_AsignacionRepo.Asignacions.Update(modelo);
			await _AsignacionRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			Asignacion Model = _AsignacionRepo.Asignacions.First(c => c.Id == id);
			_AsignacionRepo.Remove(Model);
			await _AsignacionRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(Asignacion modelo)
		{
			_AsignacionRepo.Asignacions.Add(modelo);
			await _AsignacionRepo.SaveChangesAsync();
			return true;
		}

		public async Task<Asignacion> Obtener(int id)
		{
			return await _AsignacionRepo.Asignacions.FindAsync(id);
		}

		public async Task<IQueryable<Asignacion>> ObtenerTodos()
		{
			IQueryable<Asignacion> queryAsignacionSQL = _AsignacionRepo.Asignacions;
			return queryAsignacionSQL;
		}
	}
}

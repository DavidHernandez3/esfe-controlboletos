using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class DocenteRepository : IGenericRepository<Docente>
	{
		private readonly ControlVentaBoletosContext _DocenteRepo;

        public DocenteRepository(ControlVentaBoletosContext docenterepo)
        {
            _DocenteRepo = docenterepo;
        }

        public async Task<bool> Actualizar(Docente modelo)
		{
			_DocenteRepo.Docentes.Update(modelo);
			await _DocenteRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			Docente Model = _DocenteRepo.Docentes.First(c => c.Id == id);
			_DocenteRepo.Remove(Model);
			await _DocenteRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(Docente modelo)
		{
			_DocenteRepo.Docentes.Add(modelo);
			await _DocenteRepo.SaveChangesAsync();
			return true;
		}

		public async Task<Docente> Obtener(int id)
		{
			return await _DocenteRepo.Docentes.FindAsync(id);
		}

		public async Task<IQueryable<Docente>> ObtenerTodos()
		{
			IQueryable<Docente> queryDocenteSQL = _DocenteRepo.Docentes;
			return queryDocenteSQL;
		}
	}
}

using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class CarreraRepository : IGenericRepository<Carrera>
	{
		private readonly ControlVentaBoletosContext _CarreraRepo;
        public CarreraRepository(ControlVentaBoletosContext carrerepo)
        {
            _CarreraRepo = carrerepo;
        }

        public async Task<bool> Actualizar(Carrera modelo)
		{
			_CarreraRepo.Carreras.Update(modelo);
			await _CarreraRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			Carrera Model = _CarreraRepo.Carreras.First(c => c.Id == id);
			_CarreraRepo.Remove(Model);
			await _CarreraRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(Carrera modelo)
		{
			_CarreraRepo.Carreras.Add(modelo);
			await _CarreraRepo.SaveChangesAsync();
			return true;
		}

		public async Task<Carrera> Obtener(int id)
		{
			return await _CarreraRepo.Carreras.FindAsync(id);
		}

		public async Task<IQueryable<Carrera>> ObtenerTodos()
		{
			IQueryable<Carrera> queryCarreraSQL = _CarreraRepo.Carreras;
			return queryCarreraSQL;
		}
	}
}

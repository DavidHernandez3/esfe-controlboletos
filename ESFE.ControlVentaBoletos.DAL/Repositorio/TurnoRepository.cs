using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class TurnoRepository : IGenericRepository<Turno>
	{
		private readonly ControlVentaBoletosContext _TurnoRepo;

        public TurnoRepository(ControlVentaBoletosContext turnorepo)
        {
			_TurnoRepo = turnorepo;  
        }
        public async Task<bool> Actualizar(Turno modelo)
		{
			_TurnoRepo.Turnos.Update(modelo);
			await _TurnoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			Turno Model = _TurnoRepo.Turnos.First(c => c.Id == id);
			_TurnoRepo.Remove(Model);
			await _TurnoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(Turno modelo)
		{
			_TurnoRepo.Turnos.Add(modelo);
			await _TurnoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<Turno> Obtener(int id)
		{
			return await _TurnoRepo.Turnos.FindAsync(id);
		}

		public async Task<IQueryable<Turno>> ObtenerTodos()
		{
			IQueryable<Turno> queryTurnoSQL = _TurnoRepo.Turnos;
			return queryTurnoSQL;
		}
	}
}

using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class GrupoRepository : IGenericRepository<Grupo>
	{
		private readonly ControlVentaBoletosContext _GrupoRepo;

        public GrupoRepository(ControlVentaBoletosContext gruporepo)
        {
            _GrupoRepo = gruporepo;
        }
        public async Task<bool> Actualizar(Grupo modelo)
		{
			_GrupoRepo.Grupos.Update(modelo);
			await _GrupoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			Grupo Model = _GrupoRepo.Grupos.First(c => c.Id == id);
			_GrupoRepo.Remove(Model);
			await _GrupoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(Grupo modelo)
		{
			_GrupoRepo.Grupos.Add(modelo);
			await _GrupoRepo.SaveChangesAsync();
			return true;
		}

		public async Task<Grupo> Obtener(int id)
		{
			return await _GrupoRepo.Grupos.FindAsync(id);
		}

		public async Task<IQueryable<Grupo>> ObtenerTodos()
		{
			IQueryable<Grupo> queryGrupoSQL = _GrupoRepo.Grupos;
			return queryGrupoSQL;
		}
	}
}

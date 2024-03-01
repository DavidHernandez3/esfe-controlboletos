using ESFE.ControlVentaBoletos.DAL.DataContext;
using ESFE.ControlVentaBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlVentaBoletos.DAL.Repositorio
{
	public class UsuarioRepository : IGenericRepository<Usuario>
	{
		private readonly ControlVentaBoletosContext _UsuarioRepo;

        public UsuarioRepository(ControlVentaBoletosContext usuariorepo)
        {
            _UsuarioRepo = usuariorepo;
        }

        public async Task<bool> Actualizar(Usuario modelo)
		{
			_UsuarioRepo.Usuarios.Update(modelo);
			await _UsuarioRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Eliminar(int id)
		{
			Usuario Model = _UsuarioRepo.Usuarios.First(c => c.Id == id);
			_UsuarioRepo.Remove(Model);
			await _UsuarioRepo.SaveChangesAsync();
			return true;
		}

		public async Task<bool> Insertar(Usuario modelo)
		{
			_UsuarioRepo.Usuarios.Add(modelo);
			await _UsuarioRepo.SaveChangesAsync();
			return true;
		}

		public async Task<Usuario> Obtener(int id)
		{
			return await _UsuarioRepo.Usuarios.FindAsync(id);
		}

		public async Task<IQueryable<Usuario>> ObtenerTodos()
		{
			IQueryable<Usuario> queryUsuarioSQL = _UsuarioRepo.Usuarios;
			return queryUsuarioSQL;
		}
	}
}

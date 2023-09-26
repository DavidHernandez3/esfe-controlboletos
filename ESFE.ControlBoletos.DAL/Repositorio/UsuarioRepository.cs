using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
    public class UsuarioRepository : IGenericRepository<Usuario>
    {
        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public UsuarioRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
            _ControlBoletosContext = ControlBoletos;
        }

        public async Task<bool> Actualizar(Usuario model)
        {
            _ControlBoletosContext.Usuarios.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Usuario Model = _ControlBoletosContext.Usuarios.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Usuario model)
        {
            _ControlBoletosContext.Usuarios.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<Usuario> Obtener(int id)
        {
            return await _ControlBoletosContext.Usuarios.FindAsync(id);
        }

        public async Task<IQueryable<Usuario>> ObtenerTodos()
        {
            IQueryable<Usuario> queryUsuarioSQL = _ControlBoletosContext.Usuarios;
            return queryUsuarioSQL;
        }
    }
}

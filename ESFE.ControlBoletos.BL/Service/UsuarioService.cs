using ESFE.ControlBoletos.DAL.Repositorio;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepository<Usuario> _UsuarionRepo;

        public UsuarioService(IGenericRepository <Usuario> usuariorepo)
        {
            _UsuarionRepo = usuariorepo;
        }

        public async Task<bool> Actualizar(Usuario model)
        {
            return await _UsuarionRepo.Actualizar(model);
        }

        public async Task<bool> Eliminar(int id)
        {
           return await _UsuarionRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Usuario model)
        {
            return await _UsuarionRepo.Insertar(model);
        }

        public async Task<Usuario> Obtener(int id)
        {
            return await _UsuarionRepo.Obtener(id);
        }

        public async Task<IQueryable<Usuario>> ObtenerTodos()
        {
           return await _UsuarionRepo.ObtenerTodos();
        }
    }
}

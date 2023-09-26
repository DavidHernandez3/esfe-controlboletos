using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
     public class GrupoRepository : IGenericRepository<Grupo>
    {
        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public GrupoRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
          _ControlBoletosContext = ControlBoletos;
        }

        public async Task<bool> Actualizar(Grupo model)
        {
            _ControlBoletosContext.Grupos.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Grupo Model = _ControlBoletosContext.Grupos.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Grupo model)
        {
            _ControlBoletosContext.Grupos.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<Grupo> Obtener(int id)
        {
            return await _ControlBoletosContext.Grupos.FindAsync(id);
        }

        public async Task<IQueryable<Grupo>> ObtenerTodos()
        {
            IQueryable<Grupo> queryGrupoSQL = _ControlBoletosContext.Grupos;
            return queryGrupoSQL;
        }
    }
}

using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
    public class AsignaicionRepository : IGenericRepository<Asignacion>
    {

        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public AsignaicionRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
            _ControlBoletosContext = ControlBoletos;
        }

        public async Task<bool> Actualizar(Asignacion model)
        {
            _ControlBoletosContext.Asignacions.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
          Asignacion Model = _ControlBoletosContext.Asignacions.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Asignacion model)
        {
            _ControlBoletosContext.Asignacions.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<Asignacion> Obtener(int id)
        {
            return await _ControlBoletosContext.Asignacions.FindAsync(id);
        }

        public async Task<IQueryable<Asignacion>> ObtenerTodos()
        {
            IQueryable<Asignacion> queryAsignacionSQL = _ControlBoletosContext.Asignacions;
            return queryAsignacionSQL;
        }
    }
}

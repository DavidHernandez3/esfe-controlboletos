using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
    public class TurnoRepository : IGenericRepository<Turno>
    {
        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public TurnoRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
           _ControlBoletosContext = ControlBoletos;
        }

        public async Task<bool> Actualizar(Turno model)
        {
            _ControlBoletosContext.Turnos.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Turno Model = _ControlBoletosContext.Turnos.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Turno model)
        {
            _ControlBoletosContext.Turnos.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<Turno> Obtener(int id)
        {
            return await _ControlBoletosContext.Turnos.FindAsync(id);
        }

        public async Task<IQueryable<Turno>> ObtenerTodos()
        {
            IQueryable<Turno> queryTurnoSQL = _ControlBoletosContext.Turnos;
            return queryTurnoSQL;
        }
    }
}

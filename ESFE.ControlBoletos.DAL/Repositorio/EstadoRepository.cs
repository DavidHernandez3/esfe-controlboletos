using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
    public class EstadoRepository : IGenericRepository<Estado>
    {
        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public EstadoRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
            _ControlBoletosContext = ControlBoletos;
        }

        public async Task<bool> Actualizar(Estado model)
        {
            _ControlBoletosContext.Estados.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Estado Model = _ControlBoletosContext.Estados.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Estado model)
        {
            _ControlBoletosContext.Estados.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<Estado> Obtener(int id)
        {
            return await _ControlBoletosContext.Estados.FindAsync(id);
        }

        public async Task<IQueryable<Estado>> ObtenerTodos()
        {
            IQueryable<Estado> queryEstadoSQL = _ControlBoletosContext.Estados;
            return queryEstadoSQL;
        }
    }
}

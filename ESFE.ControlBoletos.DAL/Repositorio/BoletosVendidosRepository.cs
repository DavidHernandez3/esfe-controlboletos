using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
    
    internal class BoletosVendidosRepository : IGenericRepository<BoletosVendido>
    {
        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public BoletosVendidosRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
            _ControlBoletosContext= ControlBoletos;
        }
        public async Task<bool> Actualizar(BoletosVendido model)
        {
            _ControlBoletosContext.BoletosVendidos.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            BoletosVendido Model = _ControlBoletosContext.BoletosVendidos.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(BoletosVendido model)
        {
            _ControlBoletosContext.BoletosVendidos.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<BoletosVendido> Obtener(int id)
        {
            return await _ControlBoletosContext.BoletosVendidos.FindAsync(id);
        }

        public async Task<IQueryable<BoletosVendido>> ObtenerTodos()
        {
            IQueryable<BoletosVendido> queryBoletosVendidoSQL = _ControlBoletosContext.BoletosVendidos;
            return queryBoletosVendidoSQL;
        }
    }
}

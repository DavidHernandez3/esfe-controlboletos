using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
    public class BoletoRepository : IGenericRepository<Boleto>
    {
        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public BoletoRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
            _ControlBoletosContext = ControlBoletos;
        }

        public async Task<bool> Actualizar(Boleto model)
        {
            _ControlBoletosContext.Boletos.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Boleto Model = _ControlBoletosContext.Boletos.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Boleto model)
        {
            _ControlBoletosContext.Boletos.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<Boleto> Obtener(int id)
        {
            return await _ControlBoletosContext.Boletos.FindAsync(id);
        }

        public async Task<IQueryable<Boleto>> ObtenerTodos()
        {

            IQueryable<Boleto> queryBoletoSQL = _ControlBoletosContext.Boletos;
            return queryBoletoSQL;
        }
    }
}

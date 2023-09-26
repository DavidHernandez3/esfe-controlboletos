using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
    public class DocenteRepository : IGenericRepository<Docente>
    {
        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public DocenteRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
           _ControlBoletosContext = ControlBoletos;
        }

        public async Task<bool> Actualizar(Docente model)
        {
           _ControlBoletosContext.Docentes.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Docente Model = _ControlBoletosContext.Docentes.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Docente model)
        {
            _ControlBoletosContext.Docentes.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<Docente> Obtener(int id)
        {
            return await _ControlBoletosContext.Docentes.FindAsync(id);
        }

        public async Task<IQueryable<Docente>> ObtenerTodos()
        {
            IQueryable<Docente> queryDocenteSQL = _ControlBoletosContext.Docentes;
            return queryDocenteSQL;
        }
    }
}

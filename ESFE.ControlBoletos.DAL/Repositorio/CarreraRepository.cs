using ESFE.ControlBoletos.DAL.DataContext;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.DAL.Repositorio
{
    public class CarreraRepository : IGenericRepository<Carrera>
    {
        private readonly ControlDeVentaBoletosContext _ControlBoletosContext;

        public CarreraRepository(ControlDeVentaBoletosContext ControlBoletos)
        {
            _ControlBoletosContext = ControlBoletos;
        }
        public async Task<bool> Actualizar(Carrera model)
        {
            _ControlBoletosContext.Carreras.Update(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Carrera Model = _ControlBoletosContext.Carreras.First(c => c.Id == id);
            _ControlBoletosContext.Remove(Model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Carrera model)
        {
            _ControlBoletosContext.Carreras.Add(model);
            await _ControlBoletosContext.SaveChangesAsync();
            return true;
        }

        public async Task<Carrera> Obtener(int id)
        {
           return await _ControlBoletosContext.Carreras.FindAsync(id);
        }

        public async Task<IQueryable<Carrera>> ObtenerTodos()
        {
            IQueryable<Carrera> queryCarreraSQL = _ControlBoletosContext.Carreras;
            return queryCarreraSQL;
        }
    }
}

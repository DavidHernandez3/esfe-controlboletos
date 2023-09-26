using ESFE.ControlBoletos.DAL.Repositorio;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public class TurnoService : ITurnoService
    {
        private readonly IGenericRepository<Turno> _TurnoRepo;

        public TurnoService(IGenericRepository <Turno> turnorepo)
        {
            _TurnoRepo = turnorepo;
        }

        public async Task<bool> Actualizar(Turno model)
        {
            return await _TurnoRepo.Actualizar(model);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _TurnoRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Turno model)
        {
           return await _TurnoRepo.Insertar(model);
        }

        public async Task<Turno> Obtener(int id)
        {
            return await _TurnoRepo.Obtener(id);
        }

        public async Task<IQueryable<Turno>> ObtenerTodos()
        {
           return await _TurnoRepo.ObtenerTodos();
        }
    }
}

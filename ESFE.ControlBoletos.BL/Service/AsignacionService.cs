using ESFE.ControlBoletos.DAL.Repositorio;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public class AsignacionService : IAsignacionService
    {
        private readonly IGenericRepository<Asignacion> _AsignacionRepo;

        public AsignacionService(IGenericRepository<Asignacion> asignacionrepo)
        {
            _AsignacionRepo = asignacionrepo;
        }

        public async Task<bool> Actualizar(Asignacion model)
        {
            return await _AsignacionRepo.Actualizar(model);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _AsignacionRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Asignacion model)
        {
            return await _AsignacionRepo.Insertar(model);
        }

        public async Task<Asignacion> Obtener(int id)
        {
            return await _AsignacionRepo.Obtener(id);
        }

        public async Task<IQueryable<Asignacion>> ObtenerTodos()
        {
            return await _AsignacionRepo.ObtenerTodos();
        }
    }
}

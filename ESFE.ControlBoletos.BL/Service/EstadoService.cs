using ESFE.ControlBoletos.DAL.Repositorio;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    internal class EstadoService : IEstadoService
    {
        private readonly IGenericRepository<Estado> _EstadoRepo;

        public EstadoService(IGenericRepository <Estado> estadorepo)
        {
            _EstadoRepo = estadorepo;
        }

        public async Task<bool> Actualizar(Estado model)
        {
            return await _EstadoRepo.Actualizar(model);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _EstadoRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Estado model)
        {
            return await _EstadoRepo.Insertar(model);
        }

        public async Task<Estado> Obtener(int id)
        {
            return await _EstadoRepo.Obtener(id);
        }

        public async Task<IQueryable<Estado>> ObtenerTodos()
        {
            return await _EstadoRepo.ObtenerTodos();
        }
    }
}

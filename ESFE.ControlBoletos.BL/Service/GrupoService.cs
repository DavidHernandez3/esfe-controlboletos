using ESFE.ControlBoletos.DAL.Repositorio;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public class GrupoService : IGrupoService
    {
        private readonly IGenericRepository<Grupo> _GrupoRepo;

        public GrupoService(IGenericRepository <Grupo> gruporepo)
        {
            _GrupoRepo = gruporepo;
        }

        public async Task<bool> Actualizar(Grupo model)
        {
            return await _GrupoRepo.Actualizar(model);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _GrupoRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Grupo model)
        {
            return await _GrupoRepo.Insertar(model);
        }

        public async Task<Grupo> Obtener(int id)
        {
            return await _GrupoRepo.Obtener(id);
        }

        public async Task<IQueryable<Grupo>> ObtenerTodos()
        {
            return await _GrupoRepo.ObtenerTodos();
        }
    }
}

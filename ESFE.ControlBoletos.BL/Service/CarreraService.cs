using ESFE.ControlBoletos.DAL.Repositorio;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public class CarreraService : ICarreraService
    {
        private readonly IGenericRepository<Carrera> _CarreraRepo;

        public CarreraService(IGenericRepository<Carrera> carrerarepo)
        {
            _CarreraRepo = carrerarepo;
        }


        public async Task<bool> Actualizar(Carrera model)
        {
            return await _CarreraRepo.Actualizar(model);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _CarreraRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Carrera model)
        {
            return await _CarreraRepo.Insertar(model);
        }

        public async Task<Carrera> Obtener(int id)
        {
            return await _CarreraRepo.Obtener(id);
        }

        public async Task<IQueryable<Carrera>> ObtenerTodos()
        {
            return await _CarreraRepo.ObtenerTodos();
        }

    }
}

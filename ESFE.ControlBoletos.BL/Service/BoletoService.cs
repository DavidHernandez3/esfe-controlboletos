using ESFE.ControlBoletos.DAL.Repositorio;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public class BoletoService: IBoletoService
    {
        private readonly IGenericRepository<Boleto> _BoletoRepo;

        public BoletoService(IGenericRepository<Boleto> boletoRepo)
        {
            _BoletoRepo = boletoRepo;
        }

        public async Task<bool> Actualizar(Boleto model)
        {
            return await _BoletoRepo.Actualizar(model);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _BoletoRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Boleto model)
        {
            return await _BoletoRepo.Insertar(model);
        }

        public async Task<Boleto> Obtener(int id)
        {
            return await _BoletoRepo.Obtener(id);
        }

        public async Task<IQueryable<Boleto>> ObtenerTodos()
        {
            return await _BoletoRepo.ObtenerTodos();
        }
    }
    
}

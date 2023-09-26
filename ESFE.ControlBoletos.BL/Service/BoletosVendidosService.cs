using ESFE.ControlBoletos.DAL.Repositorio;
using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public class BoletosVendidosService :IBoletosVendidosService
    {
        private readonly IGenericRepository<BoletosVendido>_BoletosVendidos;

        public BoletosVendidosService(IGenericRepository<BoletosVendido> boletovendido)
        {
            _BoletosVendidos = boletovendido;
        }

        public async Task<bool> Actualizar(BoletosVendido model)
        {
            return await _BoletosVendidos.Actualizar(model);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _BoletosVendidos.Eliminar(id);
        }

        public async Task<bool> Insertar(BoletosVendido model)
        {
            return await _BoletosVendidos.Insertar(model);
        }

        public async Task<BoletosVendido> Obtener(int id)
        {
            return await _BoletosVendidos.Obtener(id);
        }

        public async Task<IQueryable<BoletosVendido>> ObtenerTodos()
        {
            return await _BoletosVendidos.ObtenerTodos();
        }
    }
}

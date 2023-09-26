using ESFE.ControlBoletos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.ControlBoletos.BL.Service
{
    public interface IUsuarioService
    {
        Task<bool> Insertar(Usuario model);
        Task<bool> Actualizar(Usuario model);
        Task<bool> Eliminar(int id);
        Task<Usuario> Obtener(int id);
        Task<IQueryable<Usuario>> ObtenerTodos();
    }
}

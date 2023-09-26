using System;
using System.Collections.Generic;

namespace ESFE.ControlBoletos.EN

{
    public partial class BoletosVendido
    {
        public int Id { get; set; }

        public string CantidadVendida { get; set; } = null!;

        public DateTime FechaReporte { get; set; }

        public int IdBoleto { get; set; }

        public int IdUsuario { get; set; }

        public virtual Boleto IdBoletoNavigation { get; set; } = null!;

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}

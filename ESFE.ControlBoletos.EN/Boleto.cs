
using System;
using System.Collections.Generic;

namespace ESFE.ControlBoletos.EN

{
    public partial class Boleto
    {

        public int Id { get; set; }

        public int Codigo { get; set; }

        public DateTime Years { get; set; }

        public virtual ICollection<Asignacion> Asignacions { get; set; } = new List<Asignacion>();

        public virtual ICollection<BoletosVendido> BoletosVendidos { get; set; } = new List<BoletosVendido>();

    }
}

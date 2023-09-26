using System;
using System.Collections.Generic;

namespace ESFE.ControlBoletos.EN
{
    public partial class Asignacion
    {

        public int Id { get; set; }

        public string CantBoletosAsignados { get; set; } = null!;

        public DateTime FechaAsig { get; set; }

        public int IdBoleto { get; set; }

        public int IdDocente { get; set; }

        public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

        public virtual Boleto IdBoletoNavigation { get; set; } = null!;

        public virtual Docente IdDocenteNavigation { get; set; } = null!;
    }
}

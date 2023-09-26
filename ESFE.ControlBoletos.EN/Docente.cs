using System;
using System.Collections.Generic;

namespace ESFE.ControlBoletos.EN

{
    public partial class Docente

    {

        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Grupo { get; set; } = null!;

        public virtual ICollection<Asignacion> Asignacions { get; set; } = new List<Asignacion>();

        public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    }
}

using System;
using System.Collections.Generic;

namespace ESFE.ControlBoletos.EN

{
    public partial class Grupo
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public int IdDocente { get; set; }

        public int IdAsignacion { get; set; }

        public virtual Asignacion IdAsignacionNavigation { get; set; } = null!;

        public virtual Docente IdDocenteNavigation { get; set; } = null!;
    }
}

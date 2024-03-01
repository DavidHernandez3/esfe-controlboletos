using System;
using System.Collections.Generic;

namespace ESFE.ControlVentaBoletos.EN
{

	public partial class Grupo
	{
		public int Id { get; set; }

		public string Nombre { get; set; } = null!;

		public int IdDocente { get; set; }

		public virtual ICollection<Asignacion> Asignacions { get; set; } = new List<Asignacion>();

		public virtual Docente IdDocenteNavigation { get; set; } = null!;
	}

}
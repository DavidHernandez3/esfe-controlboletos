using System;
using System.Collections.Generic;

namespace ESFE.ControlVentaBoletos.EN
{

	public partial class Docente
	{
		public int Id { get; set; }

		public string Nombre { get; set; } = null!;

		public string Apellido { get; set; } = null!;

		public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();
	}

}
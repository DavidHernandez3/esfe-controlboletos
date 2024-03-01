using System;
using System.Collections.Generic;

namespace ESFE.ControlVentaBoletos.EN

{
	public partial class Usuario
	{
		public int Id { get; set; }

		public string Nombre { get; set; } = null!;

		public string Apellido { get; set; } = null!;

		public string Correo { get; set; } = null!;

		public string Clave { get; set; } = null!;

		public virtual ICollection<BoletosVendido> BoletosVendidos { get; set; } = new List<BoletosVendido>();
	}
}

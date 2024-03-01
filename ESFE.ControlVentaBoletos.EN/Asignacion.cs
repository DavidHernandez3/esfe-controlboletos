using System;
using System.Collections.Generic;

namespace ESFE.ControlVentaBoletos.EN
{
	public partial class Asignacion
	{
		public int Id { get; set; }

		public string CantBoletosAsignados { get; set; } = null!;

		public DateTime FechaAsig { get; set; }

		public int IdBoleto { get; set; }

		public int IdGrupo { get; set; }

		public virtual ICollection<BoletosVendido> BoletosVendidos { get; set; } = new List<BoletosVendido>();

		public virtual Boleto IdBoletoNavigation { get; set; } = null!;

		public virtual Grupo IdGrupoNavigation { get; set; } = null!;
	}

}
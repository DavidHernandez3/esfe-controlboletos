using ESFE.ControlVentaBoletos.BL.Service;
using ESFE.ControlVentaBoletos.EN;
using ESFE.ControlVentaBoletos.UI.Models;
using ESFE.ControlVentaBoletos.UI.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace ESFE.ControlVentaBoletos.UI.Controllers
{
	public class HomeController : Controller
	{
		private readonly IAsignacionService _asignacionService;

		public HomeController(IAsignacionService asignacionServ)
		{
			_asignacionService = asignacionServ;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Lista()
		{
			IQueryable<Asignacion> queryAsigancionSQL = await _asignacionService.ObtenerTodos();
			List<VMAsignacion> lista = queryAsigancionSQL 
													      
													.Select(c => new VMAsignacion()
													{ 
														Id = c.Id,
														CantBoletosAsignados = c.CantBoletosAsignados,
														FechaAsig = c.FechaAsig.ToString("dd/MM/yyyy"),
														IdBoleto = c.IdBoleto,
														IdGrupo = c.IdGrupo

													}).ToList();
			return StatusCode(StatusCodes.Status200OK, lista);
		}


		[HttpPost]
		public async Task<IActionResult> Insertar([FromBody] VMAsignacion modelo)
		{

            Asignacion nuevaAsignacion = new Asignacion
            {
                CantBoletosAsignados = modelo.CantBoletosAsignados,
                FechaAsig = DateTime.ParseExact(modelo.FechaAsig, "dd/MM/yyyy", CultureInfo.GetCultureInfo("es-SV")),
                IdBoleto = modelo.IdBoleto,
                IdGrupo = modelo.IdGrupo
            };

            bool respuesta = await _asignacionService.Insertar(nuevaAsignacion);

			return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
		}


		[HttpPut]
		public async Task<IActionResult> Actualizar([FromBody] VMAsignacion modelo)
		{

			Asignacion NuevaAsignacion = new Asignacion()
			{
				Id = modelo.Id,
				CantBoletosAsignados = modelo.CantBoletosAsignados,
				FechaAsig = DateTime.ParseExact(s: modelo.FechaAsig,
													   "dd/MM/yyyy",
													   CultureInfo.CreateSpecificCulture("es-SV")),
				IdBoleto = modelo.IdBoleto,
				IdGrupo = modelo.IdGrupo
			};

			bool respuesta = await _asignacionService.Actualizar(NuevaAsignacion);

			return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });

		}

		[HttpDelete]
		public async Task<IActionResult> Eliminar(int id)
		{

			bool respuesta = await _asignacionService.Eliminar(id);

			return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });

		}

		public IActionResult Privacy() 
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
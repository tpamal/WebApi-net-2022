using Microsoft.AspNetCore.Mvc;
using WebApiKalum.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApiKalum.Controllers
{
    [ApiController]
    [Route("v1/KalumManagament")]

    public class CarreraTecnicaController : ControllerBase
    {
        private readonly KalumDbContex DbContex;
        private readonly ILogger<CarreraTecnicaController> Logger;

        private CarreraTecnicaController(KalumDbContex _DbContex, ILogger <CarreraTecnicaController> _Logger) {
            this.DbContex = _DbContex;
            this.Logger = _Logger;
        }

        public async Task<ActionResult<List<CarreraTecnica>>> Get()
        {
            List<CarreraTecnica> carrerasTecnicas = null;
            Logger.LogDebug("Iniciando proceso de consulta");
            carrerasTecnicas = await DbContex.CarreraTecnica.Include(c = c.Aspirante).Include(c => c.Inscripciones).ToListAsync();
            if(carrerasTecnicas == null || carrerasTecnicas.Count == 0)
            {
                Logger.LogWarning("No existe carreras tecnicas");
                return new NoContentResult();
            }
            Logger.LogInformation("Se completo el proceso de manera exitosa");
            return Ok(carrerasTecnicas);
        }

        [HttpGet("{id}", Name = "GetCarreraTecnica")]
        public async Task<ActionResult<CarreraTecnica>> GetCarrerasTecnica(string id)
        {
            Logger.LogDebug("Iniciando el Proceso de busqueda id" + id);
            var carrera = await DbContex.CarreraTecnica.FirstOrDefaultAsync(ct => ct.CarraraId == id);
            if(carrera == null)
            {
                Logger.LogWarning("No existe la carrara tecnicas id" + id);
            }
            Logger.LogInformation("Finalizando el proceso de busqueda de namera exitosa");
            return Ok(carrera);
        }
    }
}

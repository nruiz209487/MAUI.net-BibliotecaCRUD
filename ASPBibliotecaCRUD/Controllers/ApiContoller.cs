using Microsoft.AspNetCore.Mvc;
using BL_Biblioteca;
using ENT_Bibloteca;

namespace ASPBibliotecaCRUD.Controllers
{
    [ApiController] // Indica que este controlador es para una API
    [Route("api/[controller]")] // Define la ruta base: api/ApiController
    public class ApiController : ControllerBase
    {
        // GET: api/ApiController
        [HttpGet]
        public IActionResult GetAll()
        {
            var datos = ClsListadosBL.ObtenerListadoDeLibrosCompleto();

            if (datos == null || datos.Count == 0)
                return NotFound(new { Mensaje = "No se encontraron libros." });

            return Ok(datos); // Devuelve una respuesta 200 con los datos
        }

        // GET: api/ApiController/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
                return BadRequest(new { Mensaje = "El ID debe ser mayor a 0." });

            var dato = ClsListadosBL.ObtenerLibro(id);
            if (dato == null)
                return NotFound(new { Mensaje = $"No se encontró un libro con ID {id}." });

            return Ok(dato); // Devuelve un 200 con los datos
        }

        // DELETE: api/ApiController/5
        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            if (id <= 0)
                return BadRequest(new { Mensaje = "El ID debe ser mayor a 0." });
            return Ok(new { Mensaje = $"Libro con ID {id} eliminado correctamente." });
        }

        // POST: api/ApiController
        [HttpPost]
        public IActionResult Post([FromBody] Libro nuevoLibro)
        {
            if (nuevoLibro == null)
                return BadRequest(new { Mensaje = "El libro enviado es inválido." });

            ClsListadosBL.AnyadirLibro(nuevoLibro);
            return CreatedAtAction(nameof(GetById), new { id = nuevoLibro.Id }, nuevoLibro); // Devuelve un 201 con el recurso creado
        }


    }
}

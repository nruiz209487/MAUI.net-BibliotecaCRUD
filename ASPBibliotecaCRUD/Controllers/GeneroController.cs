using BL_Biblioteca;
using ENT_Bibloteca;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPBibliotecaCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        // GET: api/Genero
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var generos = ClsListadosBL.ObtenerListadoGeneros(); // Método de la capa BL
                if (generos == null || generos.Count == 0)
                {
                    return NoContent(); // 204 No Content si no hay generos
                }
                return Ok(generos); // 200 OK con la lista de generos
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al obtener los generos", detalle = ex.Message });
            }
        }

        // GET api/Genero/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var genero = ClsListadosBL.ObtenerGenero(id);
                if (genero == null)
                {
                    return NotFound(new { mensaje = "Genero no encontrado" }); // 404 Not Found
                }
                return Ok(genero); // 200 OK con el genero encontrado
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al obtener el Genero", detalle = ex.Message });
            }
        }
        // POST: api/Genero
        [HttpPost]
        public IActionResult Create([FromBody] Genero nuevoGenero)
        {
            if (nuevoGenero == null)
            {
                return BadRequest(new { mensaje = "El Genero no puede ser nulo" }); // 400 Bad Request
            }

            try
            {
                ClsListadosBL.AnyadirGenero(nuevoGenero);
                return CreatedAtAction(nameof(GetById), new { id = nuevoGenero.Id }, nuevoGenero); // 201 Created
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al crear el Genero", detalle = ex.Message });
            }
        }

        // PUT: api/Genero/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Genero generoActualizado)
        {
            if (generoActualizado == null || generoActualizado.Id != id)
            {
                return BadRequest(new { mensaje = "Datos del Genero incorrectos" }); // 400 Bad Request
            }

            try
            {
                var libroExistente = ClsListadosBL.ObtenerLibro(id);
                if (libroExistente == null)
                {
                    return NotFound(new { mensaje = "Genero no encontrado" }); // 404 Not Found
                }

                ClsListadosBL.ModificarGenero(generoActualizado);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al actualizar el Genero", detalle = ex.Message });
            }
        }

        // DELETE: api/Genero/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var libro = ClsListadosBL.ObtenerGenero(id);
                if (libro == null)
                {
                    return NotFound(new { mensaje = "Genero no encontrado" }); // 404 Not Found
                }

                ClsListadosBL.EliminarGenero(id);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al eliminar el Genero", detalle = ex.Message });
            }
        }
    }
}

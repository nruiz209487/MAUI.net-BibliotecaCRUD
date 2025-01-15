using Microsoft.AspNetCore.Mvc;
using BL_Biblioteca; // Referencia a la capa de lógica de negocio
using ENT_Bibloteca; // Referencia a las entidades de datos


namespace ASPBibliotecaCRUD.Controllers
{
    [ApiController] // Indica que este controlador es para una API
    [Route("api/[controller]")] // Define la ruta base: api/ApiController
    public class LibroController : ControllerBase
    {
        // GET: api/Libro  https://localhost:7037/api/libro
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var libros = ClsListadosBL.ObtenerListadoDeLibrosCompleto(); // Método de la capa BL
                if (libros == null || libros.Count == 0)
                {
                    return NoContent(); // 204 No Content si no hay libros
                }
                return Ok(libros); // 200 OK con la lista de libros
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al obtener los libros", detalle = ex.Message });
            }
        }

        // GET: api/Libro/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var libro = ClsListadosBL.ObtenerLibro(id);
                if (libro == null)
                {
                    return NotFound(new { mensaje = "Libro no encontrado" }); // 404 Not Found
                }
                return Ok(libro); // 200 OK con el libro encontrado
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al obtener el libro", detalle = ex.Message });
            }
        }

        // POST: api/Libro
        [HttpPost]
        public IActionResult Create([FromBody] Libro nuevoLibro)
        {
            if (nuevoLibro == null)
            {
                return BadRequest(new { mensaje = "El libro no puede ser nulo" }); // 400 Bad Request
            }

            try
            {
                ClsListadosBL.AnyadirLibro(nuevoLibro);
                return CreatedAtAction(nameof(GetById), new { id = nuevoLibro.Id }, nuevoLibro); // 201 Created
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al crear el libro", detalle = ex.Message });
            }
        }

        // PUT: api/Libro/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Libro libroActualizado)
        {
            if (libroActualizado == null || libroActualizado.Id != id)
            {
                return BadRequest(new { mensaje = "Datos del libro incorrectos" }); // 400 Bad Request
            }

            try
            {
                var libroExistente = ClsListadosBL.ObtenerLibro(id);
                if (libroExistente == null)
                {
                    return NotFound(new { mensaje = "Libro no encontrado" }); // 404 Not Found
                }

                ClsListadosBL.ModificarLibro(libroActualizado);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al actualizar el libro", detalle = ex.Message });
            }
        }

        // DELETE: api/Libro/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var libro = ClsListadosBL.ObtenerLibro(id);
                if (libro == null)
                {
                    return NotFound(new { mensaje = "Libro no encontrado" }); // 404 Not Found
                }

                ClsListadosBL.EliminarLibro(id);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al eliminar el libro", detalle = ex.Message });
            }
        }
    }
}



/*
// GET: api/libros
[HttpGet]
public IActionResult Get()
{
    IActionResult salida;
    // Lista de libros definida de manera estática
    List<Libro> listadoCompleto = new List<Libro>
    {
        new Libro { Id = 1, Titulo = "El Quijote", Autor = "Miguel de Cervantes" },
        new Libro { Id = 2, Titulo = "Cien Años de Soledad", Autor = "Gabriel García Márquez" },
        new Libro { Id = 3, Titulo = "Don Juan Tenorio", Autor = "Tirso de Molina" }
    };

    // Verifica si la lista está vacía y responde de acuerdo a eso
    if (listadoCompleto.Count == 0)
    {
        salida = NoContent(); // Si no hay libros, retorna un 204 No Content
    }
    else
    {
        salida = Ok(listadoCompleto); // Si hay libros, retorna la lista con un 200 OK
    }

    return salida;
}
*/



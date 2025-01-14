using Microsoft.AspNetCore.Mvc;
using BL_Biblioteca; // Referencia a la capa de lógica de negocio
using ENT_Bibloteca; // Referencia a las entidades de datos

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
            IActionResult salida;
            List<Libro> listadoCompleto = new List<Libro>();
            try
            {
                listadoCompleto = ClsListadosBL.ObtenerListadoDeLibrosCompleto();
                if (listadoCompleto.Count == 0)
                {
                    salida = NoContent(); // Si no hay datos, devuelve un 204 No Content
                }
                else
                {
                    salida = Ok(listadoCompleto); // Si hay datos, devuelve un 200 con los datos
                }
            }
            catch
            {
                salida = BadRequest(new { Mensaje = "Hubo un error al obtener los libros." }); // Devuelve un 400 Bad Request en caso de error
            }
            return salida;
        }

        // GET: api/ApiController/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            IActionResult salida;
            Libro libro;
            try
            {
                if (id <= 0)
                    return BadRequest(new { Mensaje = "El ID debe ser mayor a 0." });

                libro = ClsListadosBL.ObtenerLibro(id);
                if (libro == null)
                {
                    salida = NotFound(new { Mensaje = $"No se encontró un libro con ID {id}." }); // Si no encuentra el libro, devuelve un 404
                }
                else
                {
                    salida = Ok(libro); // Si encuentra el libro, devuelve un 200 con los datos
                }
            }
            catch
            {
                salida = BadRequest(new { Mensaje = "Hubo un error al obtener el libro." });
            }
            return salida;
        }

        // POST: api/ApiController
        [HttpPost]
        public IActionResult Post([FromBody] Libro nuevoLibro)
        {
            IActionResult salida;
            try
            {
                if (nuevoLibro == null)
                    return BadRequest(new { Mensaje = "El libro enviado es inválido." });

                ClsListadosBL.AnyadirLibro(nuevoLibro); // Lógica para añadir el libro
                salida = CreatedAtAction(nameof(GetById), new { id = nuevoLibro.Id }, nuevoLibro); // Devuelve un 201 con la ubicación del nuevo recurso
            }
            catch
            {
                salida = BadRequest(new { Mensaje = "Hubo un error al agregar el libro." });
            }
            return salida;
        }

        // DELETE: api/ApiController/5
        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            IActionResult salida;
            try
            {
                if (id <= 0)
                    return BadRequest(new { Mensaje = "El ID debe ser mayor a 0." });

                var libroEliminado = ClsListadosBL.ObtenerLibro(id);
                if (libroEliminado == null)
                    return NotFound(new { Mensaje = $"No se encontró el libro con ID {id} para eliminar." });

                // Aquí podrías agregar la lógica para eliminar el libro
                // ClsListadosBL.EliminarLibro(id);

                salida = Ok(new { Mensaje = $"Libro con ID {id} eliminado correctamente." }); // Devuelve un 200 si todo sale bien
            }
            catch
            {
                salida = BadRequest(new { Mensaje = "Hubo un error al eliminar el libro." });
            }
            return salida;
        }
    }
}

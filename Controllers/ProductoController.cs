using LibrosAPI.Data;
using LibrosAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibrosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDBContext _db;

        public ProductoController(ApplicationDBContext db)
        {
            _db = db;
        }
        // GET: ProductoController
        [HttpGet("NuevoProducto")]
        public async Task<IActionResult> Get()
        {
            List<Producto> products = await _db.Productos.ToListAsync();
            return Ok(products); //Código de Respuesta "200"
        }

        // GET api/<ProductoController>/5
        [HttpGet("{IdProducto}")]
        public async Task<IActionResult> Get(int IdProducto)
        {
            Producto producto = await _db.Productos.FirstOrDefaultAsync(x => x.IdProducto == IdProducto);
            if (producto == null)
            {
                return BadRequest(); //Retornar un Error 102 -> El Request está mal hecho
            }
            return Ok(producto);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Producto producto)
        {
            Producto producto2 = await _db.Productos.FirstOrDefaultAsync(x => x.IdProducto == producto.IdProducto);
            if (producto2 == null && producto != null)
            {
                await _db.Productos.AddAsync(producto);
                await _db.SaveChangesAsync();
                return Ok(producto);
            }

            return BadRequest("El objeto ya existe");
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{IdProducto}")]
        public async Task<IActionResult> Put(int IdProducto, [FromBody] Producto producto)
        {
            Producto producto2 = await _db.Productos.FirstOrDefaultAsync(x => x.IdProducto == IdProducto);
            if (producto != null)
            {
                producto2.Nombre = producto.Nombre != null ? producto.Nombre : producto2.Nombre;
                producto2.Descripcion = producto.Descripcion != null ? producto.Descripcion : producto2.Descripcion;
                producto2.Cantidad = producto.Cantidad != null ? producto.Cantidad : producto2.Cantidad;
                _db.Productos.Update(producto2);
                await _db.SaveChangesAsync();
                return Ok(producto2);
            }

            return BadRequest("El producto no existe papu :'v");
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{IdProducto}")]
        public async Task<IActionResult> Delete(int IdProducto)
        {
            Producto producto = await _db.Productos.FirstOrDefaultAsync(x => x.IdProducto == IdProducto);
            if (producto != null)
            {
                _db.Productos.Remove(producto);
                await _db.SaveChangesAsync();
                return NoContent();
            }

            return BadRequest("El objeto no existe");
        }
    }
}

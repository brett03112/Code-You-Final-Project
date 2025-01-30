using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HolidayDessertStore.API.Data;
using HolidayDessertStore.API.Models;

namespace HolidayDessertStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DessertsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Constructor for the <see cref="DessertsController"/>.
        /// </summary>
        /// <param name="context">The application database context.</param>
        public DessertsController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// GET: api/Desserts
        
        /// <summary>
        /// Retrieves all desserts from the database.
        /// </summary>
        /// <returns>A list of all desserts.</returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Dessert>>> GetDesserts()
        {
            return await _context.Desserts.ToListAsync();
        }

        /// GET: api/Desserts/5
        /// <summary>
        /// Retrieves a dessert by its ID from the database.
        /// </summary>
        /// <param name="id">The ID of the dessert to retrieve.</param>
        /// <returns>The retrieved dessert, or <see cref="NotFoundResult"/> if none is found with the given ID.</returns>
        /// <returns>Status code 404 if the dessert is not found.</returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Dessert>> GetDessert(int id)
        {
            var dessert = await _context.Desserts.FindAsync(id);

            if (dessert == null)
            {
                return NotFound();
            }

            return dessert;
        }

        /// <summary>
        /// POST: api/Desserts
        /// Adds a new dessert to the database.
        /// </summary>
        /// <param name="dessert"></param>
        /// <returns>
        /// status code 201 if successful, 400 if invalid data, 500 if server error
        /// </returns>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Dessert>> PostDessert(Dessert dessert)
        {
            _context.Desserts.Add(dessert);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDessert), new { id = dessert.Id }, dessert);
        }

        /// PUT: api/Desserts/5
        /// <summary>
        /// Updates a dessert in the database.
        /// </summary>
        /// <param name="id">The ID of the dessert to update.</param>
        /// <param name="dessert">The updated dessert data.</param>
        /// <returns>
        /// Status code 204 if successful, 400 if invalid data, 404 if the dessert is not found, 500 if server error
        /// </returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutDessert(int id, Dessert dessert)
        {
            if (id != dessert.Id)
            {
                return BadRequest();
            }

            _context.Entry(dessert).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DessertExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// DELETE: api/Desserts/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status code 204 if successful, 404 if the dessert is not found</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteDessert(int id)
        {
            var dessert = await _context.Desserts.FindAsync(id);
            if (dessert == null)
            {
                return NotFound();
            }

            _context.Desserts.Remove(dessert);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Checks if a dessert exists in the database with the given ID.
        /// </summary>
        /// <param name="id">The ID of the dessert to check.</param>
        /// <returns>True if the dessert exists, false otherwise.</returns>
        private bool DessertExists(int id)
        {
            return _context.Desserts.Any(e => e.Id == id);
        }
    }
}

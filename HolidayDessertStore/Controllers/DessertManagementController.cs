using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using HolidayDessertStore.Data;
using HolidayDessertStore.Models;

namespace HolidayDessertStore.Controllers
{
    /**
    DessertManagementController handles CRUD (Create, Read, Update, Delete) operations 
    for desserts. Here's a list explaining what each method does:

    CreateDessert: Creates a new dessert in the database. It checks if the model state is valid, 
    adds the dessert to the database, and returns the created dessert with a 201 status code.

    GetDessert: Retrieves a dessert by its ID from the database. If the dessert is found, 
    it returns the dessert; otherwise, it returns a 404 status code.

    UpdateDessert: Updates an existing dessert in the database. It checks if the model state 
    is valid, updates the dessert, and returns a 204 status code. If the dessert is not found, 
    it returns a 404 status code.

    DeleteDessert: Deletes a dessert by its ID from the database. If the dessert is found, 
    it removes the dessert and returns a 204 status code; otherwise, it returns a 404 status code.

    DessertExists: Checks if a dessert with a given ID exists in the database. It returns 
    a boolean value indicating whether the dessert exists.

    Note that this controller is decorated with [Authorize(Roles = "Admin")], which means 
    that only users with the "Admin" role can access it.
    */
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class DessertManagementController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DessertManagementController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="DessertManagementController"/> class with the specified <see cref="ApplicationDbContext"/> and <see cref="ILogger{DessertManagementController}"/> instances.
        /// </summary>
        /// <param name="context">The database context.</param>
        /// <param name="logger">The logger.</param>
        public DessertManagementController(ApplicationDbContext context, ILogger<DessertManagementController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Creates a new dessert in the database. It checks if the model state is valid,
        /// adds the dessert to the database, and returns the created dessert with a 201 status code.
        /// If the model state is not valid, it returns a 400 status code. If an error occurs
        /// while creating the dessert, it returns a 500 status code.
        /// </summary>
        /// <param name="dessert">The dessert to be created.</param>
        /// <returns>The created dessert if successful; otherwise, a failure status code.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateDessert([FromBody] Dessert dessert)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _context.Desserts.Add(dessert);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetDessert), new { id = dessert.Id }, dessert);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creating dessert: {ex.Message}");
                return StatusCode(500, "An error occurred while creating the dessert");
            }
        }

        /// <summary>
        /// Gets the specified dessert by ID from the database.
        /// </summary>
        /// <param name="id">The ID of the dessert to retrieve.</param>
        /// <returns>The retrieved dessert if found; otherwise, a 404 status code.</returns>
        [HttpGet("{id}")]
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
        /// Updates the specified dessert in the database.
        /// </summary>
        /// <param name="id">The ID of the dessert to update.</param>
        /// <param name="dessert">The updated dessert.</param>
        /// <returns>The updated dessert if successful; otherwise, a 404 status code if the dessert does not exist,
        /// a 400 status code if the model state is invalid, or a 500 status code if an error occurred while updating the dessert.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDessert(int id, [FromBody] Dessert dessert)
        {
            if (id != dessert.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _context.Entry(dessert).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await DessertExists(id))
                {
                    return NotFound();
                }
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error updating dessert: {ex.Message}");
                return StatusCode(500, "An error occurred while updating the dessert");
            }

            return NoContent();
        }

        /// <summary>
        /// Deletes the specified dessert from the database.
        /// </summary>
        /// <param name="id">The ID of the dessert to delete.</param>
        /// <returns>A 204 status code if the dessert was successfully deleted; otherwise, a 404 status code if the dessert does not exist, or a 500 status code if an error occurred while deleting the dessert.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDessert(int id)
        {
            var dessert = await _context.Desserts.FindAsync(id);
            if (dessert == null)
            {
                return NotFound();
            }

            try
            {
                _context.Desserts.Remove(dessert);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error deleting dessert: {ex.Message}");
                return StatusCode(500, "An error occurred while deleting the dessert");
            }
        }

        /// <summary>
        /// Checks whether a dessert with the given ID exists in the database.
        /// </summary>
        /// <param name="id">The ID of the dessert to check.</param>
        /// <returns>True if a dessert with the given ID exists, false otherwise.</returns>
        private async Task<bool> DessertExists(int id)
        {
            return await _context.Desserts.AnyAsync(e => e.Id == id);
        }
    }
}

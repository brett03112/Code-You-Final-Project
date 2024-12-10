using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using HolidayDessertStore.Data;
using HolidayDessertStore.Models;

namespace HolidayDessertStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class DessertManagementController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DessertManagementController> _logger;

        public DessertManagementController(ApplicationDbContext context, ILogger<DessertManagementController> logger)
        {
            _context = context;
            _logger = logger;
        }

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

        private async Task<bool> DessertExists(int id)
        {
            return await _context.Desserts.AnyAsync(e => e.Id == id);
        }
    }
}

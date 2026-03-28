using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Revngo.Api.models;
using Revngo.Api.Data;
using Revngo.Api.DataBase;

namespace Revngo.Api.Controllers;

[ApiController]
[Route("api")]
public class TourController : Controller
{
    [HttpGet("tours")]
    public async Task<List<Tour?>> GetHotels([FromServices] AppDbContext db)
    {
        return await db.Tours.ToListAsync();
    }
    [HttpGet("tours/{id}")]
    public async Task<Tour?> GetById([FromServices] AppDbContext db, int id)
    {
        return await db.Tours.Where(x => x.Id == id).FirstOrDefaultAsync();
    }
    [HttpGet("Rooms")]
    public async Task<List<Room?>> GetRooms([FromServices] AppDbContext db)
    {
        return await db.Rooms.ToListAsync();
    }
    [HttpGet("filters")]
    public async Task<List<FilterSection?>> GetFilters([FromServices] AppDbContext db)
    {
        return await db.FilterSections.ToListAsync();
    }

    [HttpPost("tours/create")]
    public async Task<IActionResult> CreateTour([FromBody] Tour tour, [FromServices] AppDbContext db)
    {
        if (tour == null)
        {
            return BadRequest("Данные тура не заполнены.");
        }

        try
        {
            var exists = await db.Tours.AnyAsync(t => t.Id == tour.Id);
            if (exists)
            {
                return Conflict($"Тур с ID {tour.Id} уже существует.");
            }
            if (string.IsNullOrEmpty(tour.DescriptionHtml))
            {
                tour.DescriptionHtml = ""; 
            }
            
            await db.Tours.AddAsync(tour);
            
            await db.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateTour), new { id = tour.Id }, tour);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Ошибка при сохранении: {ex.Message}");
        }
    }
    
    [HttpPut("tours/update/{id}")]
    public async Task<IActionResult> UpdateTour(int id, [FromBody] Tour updatedTour, [FromServices] AppDbContext db)
    {
        var existingTour = await db.Tours.FirstOrDefaultAsync(t => t.Id == id);

        if (existingTour == null)
        {
            return NotFound($"Тур с ID {id} не найден.");
        }

        try
        {
            existingTour.Name = updatedTour.Name;
            existingTour.Stars = updatedTour.Stars;
            existingTour.Rating = updatedTour.Rating;
            existingTour.Price = updatedTour.Price;
            existingTour.Description = updatedTour.Description;
            existingTour.DescriptionHtml = updatedTour.DescriptionHtml ?? "";
            existingTour.HasWifi = updatedTour.HasWifi;
            existingTour.HasPool = updatedTour.HasPool;
            existingTour.FeaturesJson = updatedTour.FeaturesJson;
            
            db.Tours.Update(existingTour);
        
            await db.SaveChangesAsync();

            return Ok(existingTour);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Ошибка при обновлении: {ex.Message}");
        }
    }

    [HttpDelete("tours/delete/{id}")]
    public async Task<IActionResult> DeleteTour(int id, [FromServices] AppDbContext db)
    {
        var existingTour = await db.Tours.FirstOrDefaultAsync(t => t.Id == id);
   
        if (existingTour == null)
        {
            return NotFound($"Тур с ID {id} не найден");
        }
        try
        {
            db.Tours.Remove(existingTour);
            await db.SaveChangesAsync();
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Ошибка при удалении: {ex.Message}");
        }
       
    }
    
    
    
}
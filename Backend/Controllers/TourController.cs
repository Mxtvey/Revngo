using Microsoft.AspNetCore.Mvc;
using Revngo.Api.models;
using Revngo.Api.Data;

namespace Revngo.Api.Controllers;

[ApiController]
[Route("api")]
public class TourController : Controller
{
    [HttpGet("tours")]
    public IActionResult GetTours()
    {   
        return Ok(DataSeed.Tours);
    }
    [HttpGet("tours/{id}")]
    public IActionResult GetHotels(int id)
    {
        return Ok(DataSeed.Tours.Where(x => x.Id == id));
    }
    [HttpGet("Rooms")]
    public IActionResult GetRooms()
    {
        return Ok(DataSeed.Rooms);
    }
    [HttpGet("filters")]
    public IActionResult GetFilters()
    {
        return Ok(DataSeed.Filters);
    }
    
}
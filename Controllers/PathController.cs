namespace PathfinderVisualizerAPI.Controllers
{

    //using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using PathfinderVisualizerAPI.Data;
    using PathfinderVisualizerAPI.Models;
    using System.Runtime.CompilerServices;
    using MvcRoute = Microsoft.AspNetCore.Mvc.RouteAttribute;

    [MvcRoute("api/[controller]")]
    [ApiController]
    public class PathController : ControllerBase
    {
        private readonly ApplicationDbContext _context; // Assume you have set up your DB context

        public PathController(ApplicationDbContext context)

        {
            _context = context;
        }

        [HttpPost]
        [Route("api/savepath")]
        public async Task<IActionResult> SavePath([FromBody] PathfindingModels pathData)
        {
            if (pathData == null)
            {
                return BadRequest("Invalid path data.");
            }

            // TODO:If you have authentication, consider adding user-related data

            try
            {
                await _context.Paths.AddAsync(pathData);
                await _context.SaveChangesAsync();
                return Ok(new { success = true, message = "Path saved successfully." });
            }
            catch (Exception)
            {
                // Log the exception 
                return StatusCode(500, "Internal server error.");
            }
        }
    }
}


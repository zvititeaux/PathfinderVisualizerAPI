namespace PathfinderVisualizerAPI.Controllers
{

    //using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using PathfinderVisualizerAPI.Data;
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
        public async Task<IActionResult> SavePath([FromBody] PathfinderVisualizerAPI.Models.PathModel pathData)
        {
            if (pathData == null)
            {
                return BadRequest("Invalid path data.");
            }

            _context.AlgorithmPath.Add(pathData);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Path saved successfully!" });
        }
    }
}


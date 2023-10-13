﻿namespace Microsoft.EntityFrameworkCore;

//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PathfinderVisualizerAPI.Data;
using MvcRoute = Microsoft.AspNetCore.Mvc.RouteAttribute;

[MvcRoute("api/[controller")]
[ApiController]
    public class PathController : ControllerBase
    {
    private readonly ApplicationDbContext _context; // Assume you have set up your DB context
    
    public PathController(ApplicationDbContext context)
    {
        _context = context;
    }


}


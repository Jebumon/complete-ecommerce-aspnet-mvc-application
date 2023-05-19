using JBU_Cinemas.Data;
using JBU_Cinemas.Data.Services;
using JBU_Cinemas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JBU_Cinemas.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _service;
        public CinemasController(ICinemaService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        //GET: Cinemas/Create
        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("LogoURL,CinemaName,Description")]Cinema cinema) 
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }
    }
}

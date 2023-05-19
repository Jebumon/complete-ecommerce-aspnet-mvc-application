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

        //GET: Cinemas/Details/1
        public async Task<IActionResult> Details(int id) 
        {
            var cinemaDetails = await _service.GetByIDAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        //GET: Cinema/Edit/1
        public async Task<IActionResult> Edit(int id) 
        {
            var cinemaDetails = await _service.GetByIDAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id,[Bind("Id,LogoURL,CinemaName,Description")] Cinema cinema) 
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.UpdateAsync(Id, cinema);
            return RedirectToAction(nameof(Index));
        }

        //GET: Cinema/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _service.GetByIDAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            await _service.DeleteAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}

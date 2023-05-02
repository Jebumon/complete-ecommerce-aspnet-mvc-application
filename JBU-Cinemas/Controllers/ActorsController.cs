using JBU_Cinemas.Data;
using JBU_Cinemas.Data.Services;
using JBU_Cinemas.Models;
using Microsoft.AspNetCore.Mvc;

namespace JBU_Cinemas.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind ("FullName,ProfilePictureURL,Bio")]Actor actor) 
        {
            if (!ModelState.IsValid) 
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        //Get: Actors/details/1
        public async Task<IActionResult> Details(int id) 
        {
            var actorDetails = await _service.GetByIDAsync(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }

        //Get: Actors/Edit
        public async Task<IActionResult> Edit(int actorId)
        {
            var actorDetails = await _service.GetByIDAsync(actorId);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int actorId,[Bind("ActorId,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(actorId, actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete
        public async Task<IActionResult> Delete(int actorId)
        {
            var actorDetails = await _service.GetByIDAsync(actorId);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int actorId)
        {
            var actorDetails = await _service.GetByIDAsync(actorId);
            if (actorDetails == null) return View("NotFound");
            await _service.DeleteAsync(actorId);

            return RedirectToAction(nameof(Index));
        }
    }
}

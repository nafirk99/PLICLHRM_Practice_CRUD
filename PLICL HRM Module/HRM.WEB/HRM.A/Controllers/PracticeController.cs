using HRM.A.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRM.A.Controllers
{
    public class PracticeController : Controller
    {
        private readonly HRMContext _context;
        public PracticeController(HRMContext context)
        {
            _context = context; 
        }

        // READ
        public IActionResult Index()
        {
            var index = _context.HRM_ACTIVITY_STATs.ToList();
            return View(index);
        }

        // READ By ID
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var result = _context.HRM_ACTIVITY_STATs.FirstOrDefault(w => w.ActivityCd == id);
            if (result == null) 
            {
                return NotFound();
            }
            return View(result);
        }

        // CREATE Page
        public IActionResult Create()
        {
            return View();
        }


        // CREATE POST
        [HttpPost]
        public IActionResult Create(HRM_ACTIVITY_STAT hRM_ACTIVITY_STAT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hRM_ACTIVITY_STAT);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }


        // DELETE POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            //var result = _context.HRM_ACTIVITY_STATs.FindAsync(id);
            //_context.HRM_ACTIVITY_STATs.Remove(result);

            //_context.HRM_ACTIVITY_STATs.Remove(result);
            //_context.SaveChanges();
            //return RedirectToAction("Index");

            var hRM_ACTIVITY_STAT = await _context.HRM_ACTIVITY_STATs.FindAsync(id);
            if (hRM_ACTIVITY_STAT != null)
            {
                _context.HRM_ACTIVITY_STATs.Remove(hRM_ACTIVITY_STAT);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // UPDATE
        public IActionResult Edit(string id)
        {
            var result = _context.HRM_ACTIVITY_STATs.Where(u => u.ActivityCd == id).FirstOrDefault();
            return View(result);
        }

        //UPDATE POST
        [HttpPost]
        public IActionResult Edit(HRM_ACTIVITY_STAT hRM_ACTIVITY_STAT)
        {
            _context.Update(hRM_ACTIVITY_STAT);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

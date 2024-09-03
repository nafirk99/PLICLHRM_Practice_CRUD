using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HRM.A;
using HRM.A.Models;

namespace HRM.A.Controllers
{
    public class HRM_ACTIVITY_STATController : Controller
    {
        private readonly HRMContext _context;

        public HRM_ACTIVITY_STATController(HRMContext context)
        {
            _context = context;
        }

        // GET: HRM_ACTIVITY_STAT
        public async Task<IActionResult> Index()
        {
            return View(await _context.HRM_ACTIVITY_STATs.ToListAsync());
        }

        // GET: HRM_ACTIVITY_STAT/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRM_ACTIVITY_STAT = await _context.HRM_ACTIVITY_STATs
                .FirstOrDefaultAsync(m => m.ActivityCd == id);
            if (hRM_ACTIVITY_STAT == null)
            {
                return NotFound();
            }

            return View(hRM_ACTIVITY_STAT);
        }

        // GET: HRM_ACTIVITY_STAT/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HRM_ACTIVITY_STAT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActivityCd,ActivityNm,ShortNm,IUsr,IDt,UUsr,UDt")] HRM_ACTIVITY_STAT hRM_ACTIVITY_STAT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hRM_ACTIVITY_STAT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hRM_ACTIVITY_STAT);
        }

        // GET: HRM_ACTIVITY_STAT/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRM_ACTIVITY_STAT = await _context.HRM_ACTIVITY_STATs.FindAsync(id);
            if (hRM_ACTIVITY_STAT == null)
            {
                return NotFound();
            }
            return View(hRM_ACTIVITY_STAT);
        }

        // POST: HRM_ACTIVITY_STAT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ActivityCd,ActivityNm,ShortNm,IUsr,IDt,UUsr,UDt")] HRM_ACTIVITY_STAT hRM_ACTIVITY_STAT)
        {
            if (id != hRM_ACTIVITY_STAT.ActivityCd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hRM_ACTIVITY_STAT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HRM_ACTIVITY_STATExists(hRM_ACTIVITY_STAT.ActivityCd))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hRM_ACTIVITY_STAT);
        }

        // GET: HRM_ACTIVITY_STAT/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hRM_ACTIVITY_STAT = await _context.HRM_ACTIVITY_STATs
                .FirstOrDefaultAsync(m => m.ActivityCd == id);
            if (hRM_ACTIVITY_STAT == null)
            {
                return NotFound();
            }

            return View(hRM_ACTIVITY_STAT);
        }

        // POST: HRM_ACTIVITY_STAT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hRM_ACTIVITY_STAT = await _context.HRM_ACTIVITY_STATs.FindAsync(id);
            if (hRM_ACTIVITY_STAT != null)
            {
                _context.HRM_ACTIVITY_STATs.Remove(hRM_ACTIVITY_STAT);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HRM_ACTIVITY_STATExists(string id)
        {
            return _context.HRM_ACTIVITY_STATs.Any(e => e.ActivityCd == id);
        }
    }
}

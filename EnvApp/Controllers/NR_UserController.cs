using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnvApp.Models.DB;

namespace EnvApp.Controllers
{
    public class NR_UserController : Controller
    {
        private readonly Natural_ResourcesContext _context;

        public NR_UserController(Natural_ResourcesContext context)
        {
            _context = context;
        }

        // GET: NR_User
        public async Task<IActionResult> Index()
        {
            return View(await _context.NR_Users.ToListAsync());
        }

        // GET: NR_User/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nR_User = await _context.NR_Users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nR_User == null)
            {
                return NotFound();
            }

            return View(nR_User);
        }

        // GET: NR_User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NR_User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email_Address,Section,User_Type,AD_Number")] NR_User nR_User)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nR_User);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nR_User);
        }

        // GET: NR_User/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nR_User = await _context.NR_Users.FindAsync(id);
            if (nR_User == null)
            {
                return NotFound();
            }
            return View(nR_User);
        }

        // POST: NR_User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,Name,Email_Address,Section,User_Type,AD_Number")] NR_User nR_User)
        {
            if (id != nR_User.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nR_User);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NR_UserExists(nR_User.ID))
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
            return View(nR_User);
        }

        // GET: NR_User/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nR_User = await _context.NR_Users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nR_User == null)
            {
                return NotFound();
            }

            return View(nR_User);
        }

        // POST: NR_User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var nR_User = await _context.NR_Users.FindAsync(id);
            _context.NR_Users.Remove(nR_User);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NR_UserExists(long id)
        {
            return _context.NR_Users.Any(e => e.ID == id);
        }
    }
}

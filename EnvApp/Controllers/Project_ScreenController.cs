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
    public class Project_ScreenController : Controller
    {
        private readonly Natural_ResourcesContext _context;

        public Project_ScreenController(Natural_ResourcesContext context)
        {
            _context = context;
        }

        // GET: Project_Screen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Project_Screen.ToListAsync());
        }

        // GET: Project_Screen/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project_Screen = await _context.Project_Screen
                .FirstOrDefaultAsync(m => m.ID == id);
            if (project_Screen == null)
            {
                return NotFound();
            }

            return View(project_Screen);
        }

        // GET: Project_Screen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project_Screen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,State_Project_Number,Federal_Project_Number,Project_Name,County,Memo_Date,From,Authorization,DSN_PM,History,History_PM,Review_Exempt_H,SHPO_Approval_H,Archaeology,Archaeology_PM,Review_Exempt_A,SHPO_Approval_A,ESA_Key,Crayfish,NLEB_4D,USFWS,Mussel_Habitat,Bat_Habitat,Adduser,Date_Added")] Project_Screen project_Screen)
        {
            if (ModelState.IsValid)
            {
                project_Screen.Adduser = User.Identity.Name;
                project_Screen.Date_Added = DateTime.Today;
                _context.Add(project_Screen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project_Screen);
        }

        // GET: Project_Screen/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project_Screen = await _context.Project_Screen.FindAsync(id);
            if (project_Screen == null)
            {
                return NotFound();
            }
            return View(project_Screen);
        }

        // POST: Project_Screen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,State_Project_Number,Federal_Project_Number,Project_Name,County,Memo_Date,From,Authorization,DSN_PM,History,History_PM,Review_Exempt_H,SHPO_Approval_H,Archaeology,Archaeology_PM,Review_Exempt_A,SHPO_Approval_A,ESA_Key,Crayfish,NLEB_4D,USFWS,Mussel_Habitat,Bat_Habitat,Adduser,Date_Added")] Project_Screen project_Screen)
        {
            if (id != project_Screen.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project_Screen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Project_ScreenExists(project_Screen.ID))
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
            return View(project_Screen);
        }

        // GET: Project_Screen/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project_Screen = await _context.Project_Screen
                .FirstOrDefaultAsync(m => m.ID == id);
            if (project_Screen == null)
            {
                return NotFound();
            }

            return View(project_Screen);
        }

        // POST: Project_Screen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var project_Screen = await _context.Project_Screen.FindAsync(id);
            _context.Project_Screen.Remove(project_Screen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Project_ScreenExists(long id)
        {
            return _context.Project_Screen.Any(e => e.ID == id);
        }
    }
}

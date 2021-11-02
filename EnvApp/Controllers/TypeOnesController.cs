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
    public class TypeOnesController : Controller
    {
        private readonly Natural_ResourcesContext _context;

        public TypeOnesController(Natural_ResourcesContext context)
        {
            _context = context;
        }

        // GET: TypeOnes
        public async Task<IActionResult> Index()
        {
            var forms = from s in _context.TypeOne
                        select s;
            return View(await forms.ToListAsync());
        }

        // GET: TypeOnes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOne = await _context.TypeOne
                .FirstOrDefaultAsync(m => m.ID == id);
            if (typeOne == null)
            {
                return NotFound();
            }

            return View(typeOne);
        }

        // GET: TypeOnes/Create
        public IActionResult Create()
        {
            List<string> users = (from c in _context.NR_Users select c.Name).ToList();
            users.Insert(0, "Select");
            ViewBag.users = users;

            List<string> adminLeads = (from s in _context.NR_Users
                                      where s.User_Type == "Admin" || s.User_Type == "Unit Leader"
                                      select s.Name).ToList();
            adminLeads.Insert(0, "Select");
            ViewBag.adminLeads = adminLeads.ToList();

            List<SelectListItem> options = new()
            {
                new SelectListItem { Value = "True", Text = "Yes" },
                new SelectListItem { Value = "False", Text = "No" }
            };
            options.Insert(0, new SelectListItem { Value = "Select" });
            ViewBag.options = options;

            List <SelectListItem> reTypes = new()
            {
                new SelectListItem { Value = "Appendix A short form", Text = "Appendix A short form" },
                new SelectListItem { Value = "Review exempt", Text = "Review exempt" },
                new SelectListItem { Value = "SHPO", Text = "SHPO" },
                new SelectListItem { Value = "Programatic Agreement", Text = "Programatic Agreement" }
            };
            reTypes.Insert(0, new SelectListItem { Value = "Select", Text = "Select" });
            ViewBag.reTypes = reTypes;

            List <SelectListItem> counties = new()
            {
                new SelectListItem { Value = "Barbour", Text = "Barbour County" },
                new SelectListItem { Value = "Berkeley", Text = "Berkeley County" },
                new SelectListItem { Value = "Boone", Text = "Boone County" },
                new SelectListItem { Value = "Braxton", Text = "Braxton County" },
                new SelectListItem { Value = "Cabell", Text = "Cabell County" },
                new SelectListItem { Value = "Calhoun", Text = "Calhoun County" },
                new SelectListItem { Value = "Clay", Text = "Clay County" },
                new SelectListItem { Value = "Doddridge", Text = "Doddridge County" },
                new SelectListItem { Value = "Fayette", Text = "Fayette County" },
                new SelectListItem { Value = "Gilmer", Text = "Gilmer County" },
                new SelectListItem { Value = "Grant", Text = "Grant County" },
                new SelectListItem { Value = "Greenbrier", Text = "Greenbrier County" },
                new SelectListItem { Value = "Hampshire", Text = "Hampshire County" },
                new SelectListItem { Value = "Hancock", Text = "Hancock County" },
                new SelectListItem { Value = "Hardy", Text = "Hardy County" },
                new SelectListItem { Value = "Harrison", Text = "Harrison County" },
                new SelectListItem { Value = "Jackson", Text = "Jackson County" },
                new SelectListItem { Value = "Jefferson", Text = "Jefferson County" },
                new SelectListItem { Value = "Kanawha", Text = "Kanawha County" },
                new SelectListItem { Value = "Lewis", Text = "Lewis County" },
                new SelectListItem { Value = "Lincoln", Text = "Lincoln County" },
                new SelectListItem { Value = "Logan", Text = "Logan County" },
                new SelectListItem { Value = "Marion", Text = "Marion County" },
                new SelectListItem { Value = "Marshall", Text = "Marshall County" },
                new SelectListItem { Value = "Mason", Text = "Mason County" },
                new SelectListItem { Value = "McDowell", Text = "McDowell County" },
                new SelectListItem { Value = "Mercer", Text = "Mercer County" },
                new SelectListItem { Value = "Mineral", Text = "Mineral County" },
                new SelectListItem { Value = "Mingo", Text = "Mingo County" },
                new SelectListItem { Value = "Monongalia", Text = "Monongalia County" },
                new SelectListItem { Value = "Monroe", Text = "Monroe County" },
                new SelectListItem { Value = "Morgan", Text = "Morgan County" },
                new SelectListItem { Value = "Nicholas", Text = "Nicholas County" },
                new SelectListItem { Value = "Ohio", Text = "Ohio County" },
                new SelectListItem { Value = "Pendleton", Text = "Pendleton County" },
                new SelectListItem { Value = "Pleasants", Text = "Pleasants County" },
                new SelectListItem { Value = "Pocahontas", Text = "Pocahontas County" },
                new SelectListItem { Value = "Preston", Text = "Preston County" },
                new SelectListItem { Value = "Putnam", Text = "Putnam County" },
                new SelectListItem { Value = "Raleigh", Text = "Raleigh County" },
                new SelectListItem { Value = "Randolph", Text = "Randolph County" },
                new SelectListItem { Value = "Ritchie", Text = "Ritchie County" },
                new SelectListItem { Value = "Roane", Text = "Roane County" },
                new SelectListItem { Value = "Summers", Text = "Summers County" },
                new SelectListItem { Value = "Taylor", Text = "Taylor County" },
                new SelectListItem { Value = "Tucker", Text = "Tucker County" },
                new SelectListItem { Value = "Tyler", Text = "Tyler County" },
                new SelectListItem { Value = "Upshur", Text = "Upshur County" },
                new SelectListItem { Value = "Wayne", Text = "Wayne County" },
                new SelectListItem { Value = "Webster", Text = "Webster County" },
                new SelectListItem { Value = "Wetzel", Text = "Wetzel County" },
                new SelectListItem { Value = "Wirt", Text = "Wirt County" },
                new SelectListItem { Value = "Wood", Text = "Wood County" },
                new SelectListItem { Value = "Wyoming", Text = "Wyoming County" }
            };
            ViewBag.counties = counties;

            return View();
        }

        // POST: TypeOnes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,State_Project_Number,Federal_Project_Number,Name,Route_Number,County,Work_Type,Coordinates,Project_Description,Federal_Aid,Minimal_Project_Verification,CE_Category,Amms,Activities_Agreement,Arch_RE,Hist_RE,Arch_RE_Date,Hist_RE_Date,Through_Lanes,Close_Road,ROW_Acquisition,Access_Control,Fifty_Year_Structure,Agency_Coordination,IPAC_Screening_Zone,Section_404_Permit,Ground_Disturbance,Waterway,Special_Use_Permit,Floodplain,Prepared_By,Approved_By,Adduser,Date_Added")] TypeOne typeOne)
        {
            if (ModelState.IsValid)
            {
                typeOne.Adduser = User.Identity.Name;
                typeOne.Date_Added = DateTime.Today;
                _context.Add(typeOne);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeOne);
        }

        // GET: TypeOnes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOne = await _context.TypeOne.FindAsync(id);
            if (typeOne == null)
            {
                return NotFound();
            }
            return View(typeOne);
        }

        // POST: TypeOnes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,State_Project_Number,Federal_Project_Number,Name,Route_Number,County,Work_Type,Coordinates,Project_Description,Federal_Aid,Minimal_Project_Verification,CE_Category,Amms,Activities_Agreement,Arch_RE,Hist_RE,Arch_RE_Date,Hist_RE_Date,Through_Lanes,Close_Road,ROW_Acquisition,Access_Control,Fifty_Year_Structure,Agency_Coordination,IPAC_Screening_Zone,Section_404_Permit,Ground_Disturbance,Waterway,Special_Use_Permit,Floodplain,Prepared_By,Approved_By,Adduser,Date_Added")] TypeOne typeOne)
        {
            if (id != typeOne.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeOne);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeOneExists(typeOne.ID))
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
            return View(typeOne);
        }

        // GET: TypeOnes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOne = await _context.TypeOne
                .FirstOrDefaultAsync(m => m.ID == id);
            if (typeOne == null)
            {
                return NotFound();
            }

            return View(typeOne);
        }

        // POST: TypeOnes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var typeOne = await _context.TypeOne.FindAsync(id);
            _context.TypeOne.Remove(typeOne);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeOneExists(long id)
        {
            return _context.TypeOne.Any(e => e.ID == id);
        }
    }
}

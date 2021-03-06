using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnvApp.Models.DB;
using System.Net.Mail;
using System.Net;
using EnvApp.DTOs;

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
        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var forms = from s in _context.TypeOne
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                forms = forms.Where(s => s.State_Project_Number.Contains(searchString)
                                       || s.Name.Contains(searchString)
                                       || s.Federal_Project_Number.Contains(searchString));
            }
            int pageSize = 10;
            return View(await PaginatedList<TypeOne>.CreateAsync(forms.AsNoTracking(), pageNumber ?? 1, pageSize));
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
            DropDowns();
            return View(typeOne);
        }

        // GET: TypeOnes/Create
        public IActionResult Create()
        {
            DropDowns();

            return View();
        }

        // POST: TypeOnes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TypeOneDTO dto, string Assessment, bool? Bat)
        {
            DropDowns();

            System.Diagnostics.Debug.WriteLine("Prepared by: " + dto.Prepared_By);

            dto.Adduser = User.Identity.Name;
            dto.Date_Added = DateTime.Today;

            try
            {
                _context.Add(dto.ToCompletedTypeOne());
                await _context.SaveChangesAsync();
            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("It didn't work.");
                System.Diagnostics.Debug.WriteLine(ex);
            }
            //Send all History and Archaeology Unit Leaders an email
            List<string> histAndArchLeads = (from s in _context.NR_Users
                                        where s.User_Type == "Unit Leader" && s.Unit == "History" || s.Unit == "Archaeology"
                                        select s.Email_Address).ToList();
            string emailText1 = "<html><body><div><br>A new Type One form state project number " + dto.State_Project_Number + " has been created and you were listed as a Unit Leader. <br> Check it out here: https://dotappstest.transportation.wv.gov/environmentalapp/TypeOnes/Details/"+dto.ID+"</ div ></ body ></ html >";
            string subject1 = "ELCC: New Type One Project";
            foreach (var email in histAndArchLeads)
            {
                //SendEmail(email, emailText1, subject1);
            }
            //Send an email to Traci if project needs a Mussel or Crayfish habitat assessement (Natural resources Lead)
            if (Assessment != "No" )
            {
                string emailText2 = "<html><body><div><br>A new Type One form state project number " + dto.State_Project_Number +  " has been created that needs " + Assessment + " assessment(s). <br> Check it out here: https://dotappstest.transportation.wv.gov/environmentalapp/TypeOnes/Details/" + dto.ID + " </ div ></ body ></ html >";
                string subject2 = "ELCC: New Type One Project Needs Assessment(s).";
                //SendEmail("traci.l.cummings@wv.gov", emailText2, subject2);
            }
            //Send an email to bat lady if project needs a bat habitat assessement
            string emailText3 = "<html><body><div><br>A new Type One form state project number " + dto.State_Project_Number + " has been created that needs a bat habitat assessment. <br> Check it out here: https://dotappstest.transportation.wv.gov/environmentalapp/TypeOnes/Details/" + dto.ID + "</ div ></ body ></ html >";
            string subject3 = "ELCC: New Type One Project Needs a Bat Habitat Assessment.";
            if (Bat == true)
            {
                //SendEmail("traci.l.cummings@wv.gov", emailText3, subject3);
            }
                
            return RedirectToAction(nameof(Index));
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
            DropDowns();
            return View(typeOne);
        }

        // POST: TypeOnes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, TypeOneDTO dto)
        {
            if (id != dto.ID)
            {
                return NotFound();
            }

            DropDowns();

            try
            {
                _context.Update(dto.ToCompletedTypeOne());
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOneExists(dto.ID))
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

        public void SendEmail(string recipient, string message, string subject)
        {
            //send an e-mail to procuremnt to let them know an invalid e-mail was provided, and that the software in question is expiring.  
            MailMessage myMail = new MailMessage("DOHEnvironmentalAppSrv@wv.gov", recipient)
            {
                IsBodyHtml = true,
                Subject = subject,
                Body = message
            };
            SmtpClient client1 = new SmtpClient("relay.wv.gov")
            {
                Port = 25,
                EnableSsl = false,
                UseDefaultCredentials = false // Important: This line of code must be executed before setting the NetworkCredentials object, otherwise the setting will be reset (a bug in .NET)
            };
            NetworkCredential cred1 = new System.Net.NetworkCredential("DOHEnvironmentalAppSrv@wv.gov", "wnC6W6?C"); client1.Credentials = cred1;
            client1.Send(myMail);
        }

        public void DropDowns()
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
            options.Insert(0, new SelectListItem { Value = "", Text = "Select" });
            ViewBag.options = options;

            List<SelectListItem> assessments = new()
            {
                new SelectListItem { Value = "Mussel", Text = "Mussel" },
                new SelectListItem { Value = "Crayfish", Text = "Crayfish" },
                new SelectListItem { Value = "Both", Text = "Both" },
                new SelectListItem { Value = "No", Text = "No" }
            };
            assessments.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.assessments = assessments;

            List<SelectListItem> reTypes = new()
            {
                new SelectListItem { Value = "Appendix A short form", Text = "Appendix A short form" },
                new SelectListItem { Value = "Review exempt", Text = "Review exempt" },
                new SelectListItem { Value = "SHPO", Text = "SHPO" },
                new SelectListItem { Value = "Programatic Agreement", Text = "Programatic Agreement" }
            };
            reTypes.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.reTypes = reTypes;

            List<SelectListItem> counties = new()
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
                new SelectListItem { Value = "Wyoming", Text = "Wyoming County" },
                new SelectListItem { Value = "Various", Text = "Various Counties" }
            };
            ViewBag.counties = counties;
        }
    }
}

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
using System.Text;

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
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["DateSort"] = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            ViewData["ProjNumSort"] = sortOrder == "Num" ? "num_desc" : "Num";
            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var forms = from s in _context.Project_Screen
                        select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                forms = forms.Where(s => s.State_Project_Number.Contains(searchString)
                                       || s.Project_Name.Contains(searchString)
                                       || s.Federal_Project_Number.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "num_desc":
                    forms = forms.OrderByDescending(s => s.State_Project_Number);
                    break;
                case "Num":
                    forms = forms.OrderBy(s => s.State_Project_Number);
                    break;
                case "date_desc":
                    forms = forms.OrderByDescending(s => s.Date_Added);
                    break;
                default:
                    forms = forms.OrderBy(s => s.Date_Added);
                    break;
            }
            int pageSize = 10;
            return View(await PaginatedList<Project_Screen>.CreateAsync(forms.AsNoTracking(), pageNumber ?? 1, pageSize));
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
            DropDowns();

            return View();
        }

        // POST: Project_Screen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,State_Project_Number,Federal_Project_Number,Project_Name,County,Memo_Date,From,Authorization,DSN_PM,History,History_PM,Review_Exempt_H,SHPO_Approval_H,Archaeology,Archaeology_PM,Review_Exempt_A,SHPO_Approval_A,ESA_Key,Crayfish,Crayfish_Habitat_Assessment,NLEB_4D,USFWS,USFWS_Type,Mussel_Habitat,Mussel_Stream,Within_Airport,ToPo_Quad_Name,Bat_Habitat,Bars,Coordinates,Natural_Resources_Notes,Adduser,Date_Added,Crayfish_Notes,Mussel_Notes")] Project_Screen project_Screen)
        {
            DropDowns();
            if (ModelState.IsValid)
            {
                project_Screen.Adduser = User.Identity.Name;
                project_Screen.Date_Added = DateTime.Today;

                var unitLeads = (from s in _context.NR_Users
                                 where s.User_Type == "Unit Leader"
                                 select s.Email_Address).ToList();

                string[] leads = unitLeads.ToArray();           
                for (int i = 0; i < leads.Length; i++)
                {
                    //SendEmail(leads[i]);
                    System.Diagnostics.Debug.WriteLine(leads[i].ToString());
                }

                if (project_Screen.Bat_Habitat)
                {
                    var batLady = (from z in _context.NR_Users
                                   where z.Name == "Cole Perry"
                                   select z.Email_Address);
                    foreach (var email in batLady)
                        System.Diagnostics.Debug.WriteLine(email);
                        //SendEmail(email);
                }

                if( project_Screen.Crayfish == true || project_Screen.Crayfish_Habitat_Assessment == true || project_Screen.Mussel_Habitat == true || project_Screen.Mussel_Stream == true)
                {
                    StringBuilder message = new StringBuilder("New project, " + project_Screen.Project_Name + ", requires ");
                    if (project_Screen.Crayfish)
                    {
                        message.Append("a crayfish survey, ");
                    }
                    if (project_Screen.Crayfish_Habitat_Assessment)
                    {
                        message.Append("a crayfish habitat assessment, ");
                    }
                    if (project_Screen.Mussel_Habitat)
                    {
                        message.Append("a mussel habitat assessment, ");
                    }
                    if (project_Screen.Mussel_Stream)
                    {
                        message.Append("a mussel stream survey, ");
                    }
                    message.Append("and requires your attention.");
                    System.Diagnostics.Debug.WriteLine(message);
                    //SendEmail("e096752@wv.gov");
                }

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

            DropDowns();

            return View(project_Screen);
        }

        // POST: Project_Screen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,State_Project_Number,Federal_Project_Number,Project_Name,County,Memo_Date,From,Authorization,DSN_PM,History,History_PM,Review_Exempt_H,SHPO_Approval_H,Archaeology,Archaeology_PM,Review_Exempt_A,SHPO_Approval_A,ESA_Key,Crayfish,Crayfish_Habitat_Assessment,NLEB_4D,USFWS,USFWS_Type,Mussel_Habitat,Mussel_Stream,Within_Airport,ToPo_Quad_Name,Bat_Habitat,Bars,Coordinates,Natural_Resources_Notes,Adduser,Date_Added,Crayfish_Notes,Mussel_Notes")] Project_Screen project_Screen)
        {
            DropDowns();
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
                //If all 3 managers are not null then send an email to the DSN_PM
                if(project_Screen.Archaeology_PM != null){
                    if (project_Screen.History_PM != null)
                    {
                        if (project_Screen.DSN_PM != null)
                        {
                            var projManager = (from s in _context.NR_Users where s.Name == project_Screen.DSN_PM select s.Email_Address);
                            foreach (var email in projManager)
                                SendEmail(email);
                                //System.Diagnostics.Debug.WriteLine(email);
                        }
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

        public void SendEmail(string recipient)
        {
            //send an e-mail to procuremnt to let them know an invalid e-mail was provided, and that the software in question is expiring.  
            string emailText = "<html><body><div><br>A new project has been added and you were listed as one of the managers.</ div ></ body ></ html >";
            MailMessage myMail = new MailMessage("DOHEnvironmentalAppSrv@wv.gov", recipient);
            myMail.IsBodyHtml = true;
            myMail.Subject = "New ELCC Project";
            myMail.Body = emailText;
            SmtpClient client1 = new SmtpClient("relay.wv.gov");
            client1.Port = 25;
            client1.EnableSsl = false;
            client1.UseDefaultCredentials = false; // Important: This line of code must be executed before setting the NetworkCredentials object, otherwise the setting will be reset (a bug in .NET)
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
            options.Insert(0, new SelectListItem { Value = null, Text = "Select" });
            ViewBag.options = options;

            List<SelectListItem> assessments = new()
            {
                new SelectListItem { Value = "Mussel", Text = "Mussel" },
                new SelectListItem { Value = "Crayfish", Text = "Crayfish" },
                new SelectListItem { Value = "Both", Text = "Both" },
                new SelectListItem { Value = "No", Text = "No" }
            };
            assessments.Insert(0, new SelectListItem { Value = null, Text= "Select" });
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
                new SelectListItem { Value = "Wyoming", Text = "Wyoming County" }
            };
            ViewBag.counties = counties;
        }
    }
}

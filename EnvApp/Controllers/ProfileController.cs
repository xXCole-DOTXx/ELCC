using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EnvApp.ViewModels;
using EnvApp.Models.DB;

namespace EnvApp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly Natural_ResourcesContext _context;

        public ProfileController(Natural_ResourcesContext context)
        {
            _context = context;
        }
        // GET: Profile
        public IActionResult Index()
        {
            string userAD = User.Identity.Name;
            string eNum = userAD.Substring(userAD.IndexOf('\\') + 1).ToLower();
            System.Diagnostics.Debug.WriteLine("eNum: " + eNum);
            var user = _context.NR_Users.Where(x => x.AD_Number == eNum).Select(s => s.Name).SingleOrDefault();

            var viewModel = new MyProjectsViewModel();

            viewModel.Project_Screen = _context.Project_Screen.Where(x => x.DSN_PM == user);
            viewModel.TypeOne = _context.TypeOne.Where(x => x.Name == user);

            return View(viewModel);
        }
    }
}

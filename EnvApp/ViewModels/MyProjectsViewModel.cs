using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnvApp.Models;
using EnvApp.Models.DB;

namespace EnvApp.ViewModels
{
    public class MyProjectsViewModel
    {
        public IEnumerable<Project_Screen> Project_Screen { get; set; }
        public IEnumerable<TypeOne> TypeOne { get; set; }
    }
}

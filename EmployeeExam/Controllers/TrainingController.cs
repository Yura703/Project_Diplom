using EmployeeExam.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Controllers
{
    public class TrainingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TrainingController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Training(int var)
        {
            var quests = _context.Questions.Where(d => d.Var == var).ToList();
            if (quests.Count() == 0) return View("Error", "Введен не действующий номер варианта");

            ViewData["Var"] = var;
            ViewData["Count"] = quests.Count();
            ViewData["Number"] = 0;





            return View();
        }


    }
}

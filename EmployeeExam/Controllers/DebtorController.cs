using EmployeeExam.Data;
using EmployeeExam.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Controllers
{
    public class DebtorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DebtorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dept(DateTime data)
        {
            var employee = _context.Employees.ToList();
            List<Employee> _employee = new List<Employee>();

            foreach (var item in employee)
            {
                DateTime dataExam = (DateTime)item.Date;

                var title = _context.Titles.Where(d => d.title_id == item.title_id).First();
                DateTime _data = dataExam.AddYears(title.interval);

                if (data <= _data)
                {
                    _employee.Add(item);
                }
            }

            if (_employee.Count() != 0)
            {
                return View(_employee);
            }
            else
            {
                return View();
            }
        }
    }
}

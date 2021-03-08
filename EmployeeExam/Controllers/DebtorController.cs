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
            List<TempEmployee> _employee = new List<TempEmployee>();

            foreach (var item in employee)
            {
                TempEmployee tempEmployee = new TempEmployee();
                DateTime dataExam = (DateTime)item.Date;

                var title = _context.Titles.Where(d => d.title_id == item.title_id).First();
                DateTime _data = dataExam.AddYears(title.interval);

                if (data >= _data)
                {
                    tempEmployee.Date = item.Date;
                    tempEmployee.FIO = item.FIO;
                    tempEmployee.NamberComission = item.NamberComission;
                    tempEmployee.Tabel_id = item.Tabel_id;
                    var _title = _context.Titles.Where(e => e.title_id == item.title_id).First();
                    tempEmployee.title_id = _title.title_name;
                    var _dep = _context.Departments.Where(f => f.dep_id == item.dep_id).First();
                    tempEmployee.dep_id = _dep.dep_abvr;
                   
                    _employee.Add(tempEmployee);
                }
            }

            if (_employee.Count() != 0)
            {
                ViewData["Data"] = data;
                return View(_employee);
            }
            else
            {
                return View("DeptNo", data);
            }
        }
    }
}

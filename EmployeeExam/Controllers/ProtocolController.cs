using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeExam.Data;
using EmployeeExam.Data.Entities;

namespace EmployeeExam.Controllers
{
    public class ProtocolController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProtocolController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {            
            var employee = _context.Employees.Where(d => d.need_print == true);
            if (employee.Count() != 0)
            {
                return View(employee);
            }
            else {
                return View();
            }           
        }
    }
}

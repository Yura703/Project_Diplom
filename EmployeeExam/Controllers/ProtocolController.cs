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

        public  IActionResult Protocol()
        {
            var employee = _context.Employees.Where(d => d.need_print == true);
            List<TempEmployee> __employee = new List<TempEmployee>();
            if (employee.Count() == 0)
            {
                return View("ProtError", "Сотрудников, для включения в протокол нет");
            }
            else {
                for (int i = 0; i <= 20; i++)
                {
                    var _employee = employee.Where(e => e.NamberComission == i);
                    if (_employee.Count() == 0) continue;
                    else {
                        var comission = _context.Comissions.Where(d => d.NamberComission == i);
                        ViewData["predsedat"] = comission.Where(e => e.Role == "pred").First();
                        ViewData["member"] = comission.Where(e => e.Role == "member").ToList();
                        

                        foreach (var item in _employee) {
                            TempEmployee tempEmployee = new TempEmployee();                          
                            tempEmployee.FIO = item.FIO;                            
                            tempEmployee.Tabel_id = item.Tabel_id;
                            var _title = _context.Titles.Where(e => e.title_id == item.title_id).First();
                            tempEmployee.title_id = _title.title_name;
                            var _dep = _context.Departments.Where(f => f.dep_id == item.dep_id).First();
                            tempEmployee.dep_id = _dep.dep_abvr;
                                __employee.Add(tempEmployee);

                            item.need_print = false;
                            _context.Update(item);
                            //await _context.SaveChangesAsync();
                        }                       
                        }
                }
                return View(__employee);
            }
        }
    }

}


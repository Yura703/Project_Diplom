﻿using System;
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
    public class ExamController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExamController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Exam
        public async Task<IActionResult> Index()
        {     
            return View();
        }

       
        public async Task<IActionResult> Exam(int Tabel_id)
        {
            if (_context.Employees.Where(d => d.Tabel_id == Tabel_id).Count() == 0)
            {
                return View("Error", "Введен не существующий табельный номер.");
            }

            var employee = _context.Employees.Where(d => d.Tabel_id == Tabel_id).First();
                ViewData["FIO"] = employee.FIO;
                ViewData["Tabel_id"] = employee.Tabel_id;

            var title = _context.Titles.Where(d => d.title_id == employee.title_id).First();
                ViewData["Title"] = title.title_name;
                ViewData["Variant"] = title.var_id ;
            
            var quests = _context.Tests.Where(d => d.Variant == title.var_id).ToList();
            if (quests.Count() == 0)
            {
                return View("Error", "Вопросы данного варианта отсутствуют");
            }

            Random random = new Random();
            int numb= random.Next(0, quests.Count());
            ViewData["NumTest"] = numb;
            var questAll = quests[numb];
            ViewData["test_id"] = questAll.Tests_id;
            ViewData["NumTicket"] = 0;
            ViewData["TestExam"] = _context.Questions.Where(d => d.Questions_id == questAll.Questions_1).First();

            return View();
        }

        public async Task<IActionResult> Examen(int answer, int Tabel_id, int NumTicket, int NumTest, int test_id, int Quest_id)
        {
            //_context.Questions.Where(r => r.Questions_id == Quest_id).First().Answer;
            if (answer != _context.Questions.Where(r => r.Questions_id == Quest_id).First().Answer)
            {
                return View("Error", "Экзамен завершен. Ответ не верный. Удачи в следующий раз.");
            }

            if (NumTicket > 3) {
                return View("Error", "Экзамен сдан");
            }

            var employee = _context.Employees.Where(d => d.Tabel_id == Tabel_id).First();
            ViewData["FIO"] = employee.FIO;
            ViewData["Tabel_id"] = employee.Tabel_id;
            var title = _context.Titles.Where(d => d.title_id == employee.title_id).First();
            ViewData["Title"] = title.title_name;
            ViewData["Variant"] = title.var_id;
            ViewData["NumTest"] = NumTest;
            ViewData["NumTicket"] = NumTicket;
            ViewData["test_id"] = test_id;
            
            var quests = _context.Tests.Where(d => d.Tests_id == test_id).First(); 
            switch (NumTicket)
            {
                case 0:
                    ViewData["TestExam"] = _context.Questions.Where(d => d.Questions_id == quests.Questions_2).First();
                    break;
                case 1:
                    ViewData["TestExam"] = _context.Questions.Where(d => d.Questions_id == quests.Questions_3).First();
                    break;
                case 2:
                    ViewData["TestExam"] = _context.Questions.Where(d => d.Questions_id == quests.Questions_4).First();
                    break;
            }
            return View("Exam");



        }
    }
}

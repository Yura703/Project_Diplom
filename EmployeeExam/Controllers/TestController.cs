using EmployeeExam.Data;
using EmployeeExam.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;
       

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public ActionResult _TestPartial(string variant, int numberAnswer, int allAnswer, int posAnswer)
        public ActionResult _TestPartial(string variant, TestQuest quest)
        {
            TestQuest _quest = new TestQuest();

            if (variant != null)//первый запуск после выбора варианта
            {
                _quest.Var = Convert.ToInt32(variant);
                if (_context.Questions.Where(d => d.Var == _quest.Var).Count() != 0)
                {
                    _quest.allAnswer = _context.Questions.Where(d => d.Var == _quest.Var).Count();
                    var qst = _context.Questions.Where(d => d.Var == _quest.Var).First();
                    _quest.Quest = qst.Quest;
                    _quest.Variant1 = qst.Variant1;
                    _quest.Variant2 = qst.Variant2;
                    _quest.Variant3 = qst.Variant3;
                    _quest.Answer = qst.Answer;
                    _quest.Reference = qst.Reference;
                    ViewData["quest"] = _quest;
                    return PartialView();
                }

                else return PartialView();//        нет вопросов данного варианта -------------------доделать---------------
            }

            else
            {
                _quest = quest;               
                if (_quest.allAnswer <= _quest.numberAnswer) _quest.numberAnswer = 0;
                _quest.numberAnswer++;
                var qst = _context.Questions.Where(d => d.Var == _quest.Var).ToList()[_quest.numberAnswer-1];

                _quest.Quest = qst.Quest;
                _quest.Variant1 = qst.Variant1;
                _quest.Variant2 = qst.Variant2;
                _quest.Variant3 = qst.Variant3;
                _quest.Answer = qst.Answer;
                _quest.Reference = qst.Reference;
                ViewData["quest"] = _quest;
                return PartialView();
            }
        }

        public IActionResult Exam()
        {
            return View();
        }

        public ActionResult _ExamPartial(int Tabel_id, int NumTicket, int NumTest)
        {
            if (NumTicket == 4)
            {
                ViewData["Message"] = "Экзамен сдан";
                return PartialView("_ErrorTabel");
            }

           try
            {
                var employee = _context.Employees.Where(d => d.Tabel_id == Tabel_id).First();
                ViewData["FIO"] = employee.FIO;

                var title = _context.Titles.Where(d => d.title_id == employee.title_id).ToList();
                foreach (var item in title)
                {
                    ViewData["Title"] = item.title_name;
                    ViewData["Variant"] = item.var_id;
                }
                var quests = _context.Tests.Where(d => d.Variant == (int)ViewData["Variant"]).ToList();
                int countQuests = quests.Count();
                if (countQuests == 0)
                {
                    ViewData["Message"] = "Вопросы данного варианта отсутствуют";
                    return PartialView("_ErrorTabel");
                }
                else
                {
                    Random random = new Random();
                    ViewData["NumTest"] = random.Next(0, countQuests);
                    var questAll = quests[(int)ViewData["NumTest"]];
                    switch (NumTicket)
                    {
                        case 0: 
                            ViewData["TestExam"] = _context.Questions.Where(d => d.Questions_id == questAll.Questions_1).First();
                            break;
                        case 1:
                            ViewData["TestExam"] = _context.Questions.Where(d => d.Questions_id == questAll.Questions_2).First();
                            break;
                        case 2:
                            ViewData["TestExam"] = _context.Questions.Where(d => d.Questions_id == questAll.Questions_3).First();
                            break;
                        case 3:
                            ViewData["TestExam"] = _context.Questions.Where(d => d.Questions_id == questAll.Questions_4).First();
                            break;
                    }

                    ViewData["NumTicket"] = NumTicket + 1;






                }

            }

            catch
            {
                ViewData["Message"] = "Табельный номер " + Tabel_id.ToString() + " отсутствует";               
                return PartialView("_ErrorTabel");               
            }           
            
            return PartialView();
        }
    }
}

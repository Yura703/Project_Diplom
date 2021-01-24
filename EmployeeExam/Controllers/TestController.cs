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
                _quest.numberAnswer++;
                if (_quest.allAnswer <= _quest.numberAnswer) _quest.numberAnswer = 0;
                var qst = _context.Questions.Where(d => d.Var == _quest.Var).ToList()[_quest.numberAnswer];
              
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
    }
}

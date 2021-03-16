using EmployeeExam.Data;
using EmployeeExam.Data.Entities;
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
            TestQuest _quest = new TestQuest();
            var quests = _context.Questions.Where(d => d.Var == var).ToList();
            if (quests.Count() == 0) { return View("Error", "Введен не действующий номер варианта"); }
            var qst = quests.First();
            _quest.Var = var;
            _quest.allAnswer = quests.Count();
            _quest.numberAnswer = 0;
            _quest.Quest = qst.Quest;
            _quest.Variant1 = qst.Variant1;
            _quest.Variant2 = qst.Variant2;
            _quest.Variant3 = qst.Variant3;
            _quest.Answer = qst.Answer;
            _quest.Reference = qst.Reference;
            ViewData["quest"] = _quest;    
            return View();
        }

        public IActionResult TrainingTwo(int answer, int var, int number, int posAnswer, int allAnswer, int questAnswer)
        {
            TestQuest _quest = new TestQuest();
            var quests = _context.Questions.Where(d => d.Var == var).ToList();
            _quest.numberAnswer = number + 1;
            _quest.allAnswer = allAnswer;
            if(answer == questAnswer) _quest.posAnswer = posAnswer + 1;
            else _quest.posAnswer = posAnswer;
            if (quests.Count() <= (number + 1)) { _quest.numberAnswer = 0; }
            var qst = quests[_quest.numberAnswer];//---------------------------------quest.count ===0
            _quest.Quest = qst.Quest;
            _quest.Variant1 = qst.Variant1;
            _quest.Variant2 = qst.Variant2;
            _quest.Variant3 = qst.Variant3;
            _quest.Answer = qst.Answer;
            _quest.Reference = qst.Reference;
            _quest.Var = var;
            ViewData["quest"] = _quest;
            return View("Training");
        }


    }
}

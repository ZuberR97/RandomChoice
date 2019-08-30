using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using randomGame.Models;
using Microsoft.AspNetCore.Http;

namespace randomGame.Controllers
{
    public class HomeController : Controller
    {
        private Choice Mychoices;

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("choice") == null)
            {
                HttpContext.Session.SetString("choice", "");
            }
            
            ViewBag.Choice = HttpContext.Session.GetString("choice");
            return View();
        }

        [Route("process")]
        [HttpPost]
        public IActionResult Process(Choice Mychoices)
        {
            List<string> choices = new List<string>();
            // foreach(Choice choice in Mychoices))
            // {
            //     string val = "choice" + x.ToString;
            //     choices.Insert(Mychoices.choice[x]);
            // }
            if(ModelState.IsValid)
            {
                if(Mychoices.choice1 != null)
                {
                    choices.Add(Mychoices.choice1);
                }
                if(Mychoices.choice2 != null)
                {
                    choices.Add(Mychoices.choice2);
                }
                if(Mychoices.choice3 != null)
                {
                    choices.Add(Mychoices.choice3);
                }
                if(Mychoices.choice4 != null)
                {
                    choices.Add(Mychoices.choice4);
                }
                if(Mychoices.choice5 != null)
                {
                    choices.Add(Mychoices.choice5);
                }
                if(Mychoices.choice6 != null)
                {
                    choices.Add(Mychoices.choice6);
                }
                if(Mychoices.choice7 != null)
                {
                    choices.Add(Mychoices.choice7);
                }
                if(Mychoices.choice8 != null)
                {
                    choices.Add(Mychoices.choice8);
                }
                if(Mychoices.choice9 != null)
                {
                    choices.Add(Mychoices.choice9);
                }
                if(Mychoices.choice10 != null)
                {
                    choices.Add(Mychoices.choice10);
                }
                if(Mychoices.choice11 != null)
                {
                    choices.Add(Mychoices.choice11);
                }
                if(Mychoices.choice12 != null)
                {
                    choices.Add(Mychoices.choice12);
                }
                if(Mychoices.choice13 != null)
                {
                    choices.Add(Mychoices.choice13);
                }
                if(Mychoices.choice14 != null)
                {
                    choices.Add(Mychoices.choice14);
                }
                if(Mychoices.choice15 != null)
                {
                    choices.Add(Mychoices.choice15);
                }
                Random rand = new Random();
                int thischoice = rand.Next(1, choices.Count);
                HttpContext.Session.SetString("choice", choices[thischoice]);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}

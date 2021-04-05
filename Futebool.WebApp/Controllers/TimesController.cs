using Futebool.WebApp.Models;
using Futebool.WebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Controllers
{
    public class TimesController : Controller
    {
        private readonly TimesRepository timesRepository;

        public TimesController(TimesRepository timesRepository)
        {
            this.timesRepository = timesRepository;
        }

        public IActionResult ListaTimes()
        {
            return View(timesRepository.ListaTimes());
        }
        public IActionResult CadastrarTime()
        {
            var model = new Times();

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarTime(Times times)
        {
            if (times == null)
            {
                return RedirectToAction("ListaTimes");
            }
            var result = timesRepository.CadastroTime(times);
            
            if (result)
            {
                return RedirectToAction("ListaTimes");
            }
            return RedirectToAction("ErroAoCadastrar");
        }

        [HttpGet]
        public IActionResult UpdateTime(int id)
        {
            var result = timesRepository.GetTime(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTime(Times time)
        {
            if (time == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = timesRepository.AtualizarTime(time);

            if (result == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaTimes");
        }

        public IActionResult DeleteTime(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = timesRepository.DeletarTime(id);

            if (!result)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaTimes");
        }
    }
}

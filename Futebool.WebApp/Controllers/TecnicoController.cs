using Futebool.WebApp.Models;
using Futebool.WebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Controllers
{
    public class TecnicoController : Controller
    {
        private readonly TecnicosRepository tecnicosRepository;

        public TecnicoController(TecnicosRepository tecnicosRepository)
        {
            this.tecnicosRepository = tecnicosRepository;
        }

        public IActionResult ListaTecnico()
        {
            return View(tecnicosRepository.ListaTecnicos());
        }
        public IActionResult CadastrarTecnico()
        {
            var model = new Tecnico();

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarTecnico(Tecnico tecnico)
        {
            if (tecnico == null)
            {
                return RedirectToAction("ListaTecnico");
            }
            var result = tecnicosRepository.CadastroTecnicos(tecnico);

            if (result)
            {
                return RedirectToAction("ListaTecnico");
            }
            return RedirectToAction("ErroAoCadastrar");
        }


        [HttpGet]
        public IActionResult UpdateTecnico(int id)
        {
            var result = tecnicosRepository.GetTecnico(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTecnico(Tecnico tecnico)
        {
            if (tecnico == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = tecnicosRepository.AtualizarTecnico(tecnico);

            if (result == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaTecnico");
        }

        public IActionResult DeleteTecnico(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = tecnicosRepository.DeletarTecnico(id);

            if (!result)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaTecnico");
        }
    }
}


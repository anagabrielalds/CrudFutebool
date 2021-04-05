using Futebool.WebApp.Models;
using Futebool.WebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Controllers
{
    public class CampoController : Controller
    {

        private readonly CampoRepository campoRepository;

        public CampoController(CampoRepository campoRepository)
        {
            this.campoRepository = campoRepository;
        }

        public IActionResult ListaCampo()
        {
            return View(campoRepository.ListaCampos());
        }

        public IActionResult CadastrarCampo()
        {
            var model = new Campo();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarCampo(Campo campo)
        {
            if (campo == null)
            {
                return RedirectToAction("ListaTecnico");
            }
            var result = campoRepository.CadastroCampo(campo);

            if (result)
            {
                return RedirectToAction("ListaCampo");
            }
            return RedirectToAction("ErroAoCadastrar");
        }

        [HttpGet]
        public IActionResult UpdateCampo(int id)
        {
            var result = campoRepository.GetCampo(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCampo(Campo campo)
        {
            if (campo == null)
            {
                return RedirectToAction("ListaCampo");
            }
            var result = campoRepository.atualizaCampo(campo);

            if (result.Id == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaCampo");
        }
        
        public IActionResult DeleteCampo(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = campoRepository.DeletarCampo(id);

            if (!result)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaCampo");
        }

    }
}


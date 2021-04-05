using Futebool.WebApp.Models;
using Futebool.WebApp.Models.dto;
using Futebool.WebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebool.WebApp.Controllers
{
    public class JogoController : Controller
    {

        private readonly JogoRepository jogoRepository;
        public JogoController(JogoRepository jogoRepository)
        {
            this.jogoRepository = jogoRepository;
        }

        public IActionResult ListaJogo()
        {
            return View(jogoRepository.ListaJogo());
        }

        public IActionResult ErroAoCadastrar()
        {
            return View();
        }

        public IActionResult CadastrarJogo()
        {
            var model = new CadastroJogo();
            var listaTimes = jogoRepository.ListarTimes();
            var campo = jogoRepository.GetCampo();
            model.Campo = campo;
            model.ListaTimes = listaTimes;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarJogo(Jogo jogo)
        {
            if (jogo == null)
            {
                return RedirectToAction("ListaJogo");
            }
            var result = jogoRepository.CadastroJogo(jogo);

            if (result)
            {
                return RedirectToAction("ListaJogo");
            }
            return RedirectToAction("ErroAoCadastrar");
        }

        [HttpGet]
        public IActionResult UpdateJogo(int id)
        {
            var result = jogoRepository.GetJogo(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateJogo(Jogo jogo)
        {
            if (jogo == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = jogoRepository.atualizarJogo(jogo);

            if (result == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaJogo");
        }

        public IActionResult DeleteJogo(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = jogoRepository.DeletarJogo(id);

            if (!result)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaJogo");
        }
    }
}

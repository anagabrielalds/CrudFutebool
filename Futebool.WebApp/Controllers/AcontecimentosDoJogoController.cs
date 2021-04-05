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
    public class AcontecimentosDoJogoController : Controller
    {

        private readonly AcontecimentosDoJogoRepository acontecimentosDoJogoRepository;

        public AcontecimentosDoJogoController(AcontecimentosDoJogoRepository acontecimentosDoJogoRepository)
        {
            this.acontecimentosDoJogoRepository = acontecimentosDoJogoRepository;
        }

        public IActionResult ListaAcontecimento()
        {
            return View(acontecimentosDoJogoRepository.ListaAcontecimento());
        }

        public IActionResult ErroAoCadastrar()
        {
            return View();
        }

        public IActionResult CadastrarAcontecimento()
        {
            var model = new CadastroAcontecimentos();
            var listaTimes = acontecimentosDoJogoRepository.ListarTimes();
            var listaJogadores = acontecimentosDoJogoRepository.ListarJogadores();
            var listaJogos = acontecimentosDoJogoRepository.ListarJogos();
            model.ListaJogadores = listaJogadores;
            model.ListaJogos = listaJogos;
            model.ListaTimes = listaTimes;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarAcontecimento(CadastroAcontecimentos acontecimentos)
        {
            if (acontecimentos == null)
            {
                return RedirectToAction("ListaAcontecimento");
            }
            var result = acontecimentosDoJogoRepository.CadastroAcontecimento(acontecimentos);

            if (result)
            {
                return RedirectToAction("ListaAcontecimento");
            }
            return RedirectToAction("ErroAoCadastrar");
        }

        [HttpGet]
        public IActionResult UpdateAcontecimento(int id)
        {
            var result = acontecimentosDoJogoRepository.GetAcontecimentos(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateAcontecimento(int id,CadastroAcontecimentos acontecimentos)
        {
            if (acontecimentos == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            acontecimentos.Acontecimento.Id = id;
            var result = acontecimentosDoJogoRepository.AtualizarAcontecimento(acontecimentos.Acontecimento);

            if (result == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaAcontecimento");
        }

        public IActionResult DeleteAcontecimento(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = acontecimentosDoJogoRepository.DeletarAcontecimento(id);

            if (!result)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaAcontecimento");
        }
    }
}

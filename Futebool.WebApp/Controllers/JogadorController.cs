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
    public class JogadorController : Controller
    {
        private readonly JogadorRepository jogadorRepository;

        public JogadorController(JogadorRepository jogadorRepository)
        {
            this.jogadorRepository = jogadorRepository;
        }

        public IActionResult ListaJogadores()
        {
            return View(jogadorRepository.ListaJogadores());
        }

        
        public IActionResult Cadastrar()
        {
            var model = new Jogador();
            var getTimes = jogadorRepository.ListarTimeDeJogador();
            var modelTime =  new CadastroJogador();
            modelTime.Jogador = model;
            modelTime.ListaDeTimes = getTimes;
            
            return View(modelTime);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(CadastroJogador cjogador)
        {
            if (cjogador == null)
            {
                return RedirectToAction("ListaJogadores");
            }
            var result = jogadorRepository.Cadastro(cjogador);
            if (result)
            {
                return RedirectToAction("ListaJogadores"); 
            }
            return RedirectToAction("ErroAoCadastrar");
        }


        [HttpGet]
        public IActionResult UpdateJogador(int id)
        {
            var result = jogadorRepository.GetJogador(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateJogador(Jogador jogador)
        {
            if (jogador == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = jogadorRepository.atualizarJogador(jogador);

            if (result.Id == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaJogadores");
        }

        public IActionResult DeleteJogador(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            var result = jogadorRepository.DeletarJogador(id);

            if (!result)
            {
                return RedirectToAction("ErroAoCadastrar");
            }
            return RedirectToAction("ListaJogadores");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Aula7.Models; // temos que ter a referença 


namespace Aula7.Controllers
{
    public class UsuarioController : Controller
    {
        private static UsuarioTeste _usuarios = new UsuarioTeste();// isto nao se faze se trabalhamos com Banco de dados
        public IActionResult Index()
        {
           
            return View(_usuarios.listaUsuario);
        }
        public IActionResult AdicionaUsuario() // Metodo Get
        {
            return View();
        }

        [HttpPost] // acinatura Post do Usuario asima
        public IActionResult AdicionaUsuario(UsuarioModel usuarioModel) // Metodo Post
        {
            _usuarios.CriaUsuario(usuarioModel);
            return View();
        }

        public ViewResult DeletaUsuario(string id)
        {
            return View(_usuarios.GetUsuario(id));
        }

        [HttpPost]
        public RedirectToRouteResult DeletaUsuario(string id, FormCollection collection)
        {
            _usuarios.DeletarUsuario(id);
            return RedirectToRoute("Index");

        }

    }
}
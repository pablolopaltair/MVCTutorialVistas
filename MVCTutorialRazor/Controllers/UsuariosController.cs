using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MVCTutorialRazor.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaUsuarios()
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Pablo López");
            listaUsuarios.Add("Jesús Patricio");
            listaUsuarios.Add("Javi Mena");
            listaUsuarios.Add("Juan Carlos Bada");
            listaUsuarios.Add("Javi Cano");
            listaUsuarios.Add("Alberto Talamino");
            return View(listaUsuarios);
        }
    }
}

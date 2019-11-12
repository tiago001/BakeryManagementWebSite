using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WPFBakery.Models;

namespace BakeryManagement.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View(_categoriaDAO.ListarTodos());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Cadastrar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (_categoriaDAO.Cadastrar(categoria))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Essa categoria já existe");
            }
            return View(categoria);
        }
    }
}
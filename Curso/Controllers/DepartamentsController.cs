using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Curso.Models;

namespace Curso.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Nome = "tarefa" });
            list.Add(new Departament { Id = 2, Nome = "Lazer" });
            return View(list);
        }
    }
}
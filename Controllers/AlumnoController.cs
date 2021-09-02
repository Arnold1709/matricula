using Microsoft.AspNetCore.Mvc;
using matricula.Models;
namespace matricula.Controllers

{
    public class AlumnoController:Controller
    {
        
        
          public IActionResult Index()
        {
            return View();
        }

         public IActionResult Create()
        {
            ViewData["Message"] = "El alumno ya esta registrado";
            return View("Index");
        }

    }
}
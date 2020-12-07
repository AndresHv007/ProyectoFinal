using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.RazorPages;

using CalificacionesContext;
using CalificacionesContext.Models;

namespace CalificacionesWeb.pages
{
    public class MateriasModel : PageModel
    {
        public IEnumerable<Materia> Materias { get; set; }
        private Calificaciones database;

        public MateriasModel(Calificaciones injectedDatabase)
        {
            database = injectedDatabase;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Materias Page";
            Materias = database.Materia;
        }
    } 
}
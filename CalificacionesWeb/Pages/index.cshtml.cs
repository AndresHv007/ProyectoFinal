using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CalificacionesContext;
using CalificacionesContext.Models;
using System.ComponentModel.DataAnnotations;
using CalificacionesWeb.Helpers;


namespace CalificacionesWeb.pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Cuenta { get; set; }

        [BindProperty]
        [DataType(DataType.Contraseña)]
        public string Contraseña { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool Error { get; set; }

        private Calificaciones database;

        public IndexModel(Calificaciones injectedDatabase)
        {
            database = injectedDatabase;
        }

        public IActionResult OnGet()
        {
            Profesor Profesor = SessionHelper.GetObjectFromJson<Profesor>(HttpContext.Session, "Profesor");

            if (Profesor != null)
            {
                return RedirectToPage("/menu");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                int verificarNum = 0;
                if (int.TryParse(Cuenta, out verificarNum))
                {
                    IEnumerable<Profesor> Profesors = database.Profesor;
                    foreach (var Profesor in Profesors)
                    {
                        if (Profesor.Nomina == verificarNum && Profesor.Contraseña == Contraseña)
                        {
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "Profesor", Profesor);
                            return RedirectToPage("/menu"); 
                        }
                    }
                }
            }
            Error = true;
            return RedirectToPage("/index", new { Error } );
        }
    } 
}
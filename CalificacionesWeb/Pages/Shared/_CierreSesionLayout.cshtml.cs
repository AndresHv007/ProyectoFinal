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
    public class _CierreSesionLayoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Profesor", null);
            return RedirectToPage("/index");  
        }       
    }   
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;


namespace ConsolasExito.App.Presentacion.Pages
{
    public class CambioPasswordModel : PageModel
    {

        [BindProperty]
        public string Contrasenia { get; set; }
        [BindProperty]
        public string RepeatContrasenia { get; set; }

        [BindProperty]
        public string MensajeContrasenia { get; set; }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Conexion conexion = new Conexion();
            var Username = HttpContext.Session.GetString("username");
            Empleado empleado = conexion.Empleados.FirstOrDefault(e => e.Usuario == Username);
            if (!Contrasenia.Equals(RepeatContrasenia))
            {
                MensajeContrasenia = "Las contraseñas no coinciden";
                return Page();
            }else
            {
                empleado.Password=Contrasenia;
                empleado.PrimerIngreso=false;
                conexion.SaveChanges();
                return RedirectToPage("../Index");
            }
        }
    }
}

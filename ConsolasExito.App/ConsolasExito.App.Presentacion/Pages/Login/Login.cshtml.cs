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
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string MensajeUsuario { get; set; }
        [BindProperty]
        public string MensajePassword { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Conexion conexion = new Conexion();
            Empleado empleado = conexion.Empleados.FirstOrDefault(e => e.Usuario == Usuario);

            if (empleado != null)
            {

                if (empleado.PrimerIngreso && empleado.Password.Equals(empleado.Identidad) && empleado.Password.Equals(Password))
                {
                    HttpContext.Session.SetString("username", Usuario);
                    return RedirectToPage("../CambioPassword/CambioPassword");
                }

                if (empleado.Password.Equals(Password))
                {
                    return RedirectToPage("../Index");
                }
                else
                {
                    MensajePassword = "La contraseña no es correcta";
                    return Page();
                }

            }
            else
            {
                MensajeUsuario = "El usuario no ha sido encontrado";
                return Page();
            }


        }

    }
}

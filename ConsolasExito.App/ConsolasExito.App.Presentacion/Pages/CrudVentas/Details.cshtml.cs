using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;

namespace ConsolasExito.App.Presentacion.Pages.CrudVentas
{
    public class DetailsModel : PageModel
    {
        private readonly ConsolasExito.App.Persistencia.Conexion _context;

        public DetailsModel(ConsolasExito.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public Venta Venta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Venta = await _context.Ventas.FirstOrDefaultAsync(m => m.Id == id);

            if (Venta == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

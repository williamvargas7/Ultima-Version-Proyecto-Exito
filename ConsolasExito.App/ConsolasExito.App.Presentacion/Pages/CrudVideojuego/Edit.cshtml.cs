using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConsolasExito.App.Dominio;
using ConsolasExito.App.Persistencia;

namespace ConsolasExito.App.Presentacion.Pages.CrudVideojuego
{
    public class EditModel : PageModel
    {
        private readonly ConsolasExito.App.Persistencia.Conexion _context;

        public EditModel(ConsolasExito.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Videojuego Videojuego { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Videojuego = await _context.Videojuegos.FirstOrDefaultAsync(m => m.Id == id);

            if (Videojuego == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Videojuego).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideojuegoExists(Videojuego.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VideojuegoExists(int id)
        {
            return _context.Videojuegos.Any(e => e.Id == id);
        }
    }
}

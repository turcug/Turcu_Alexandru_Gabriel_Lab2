﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turcu_Alexandru_Gabriel_Lab2.Data;
using Turcu_Alexandru_Gabriel_Lab2.Models;

namespace Turcu_Alexandru_Gabriel_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Turcu_Alexandru_Gabriel_Lab2.Data.Turcu_Alexandru_Gabriel_Lab2Context _context;

        public IndexModel(Turcu_Alexandru_Gabriel_Lab2.Data.Turcu_Alexandru_Gabriel_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;
        public List<Author> Authors { get; private set; }
        public List<Publisher> Publishers { get; private set; }

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b => b.Author).ToListAsync();
                Authors = await _context.Author.ToListAsync();
                Book = await _context.Book.Include(e => e.Publisher).ToListAsync();
                Publishers = await _context.Publisher.ToListAsync();
            }
        }
    }
}

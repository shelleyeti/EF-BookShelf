using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models.ViewModels
{
    public class BookAuthorViewModel
    {
        public List<SelectListItem> Authors { get; set; }
        public Book Book { get; set; }

    }
}

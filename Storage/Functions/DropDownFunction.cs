using Microsoft.AspNetCore.Mvc.Rendering;
using Storage.Data;
using Storage.Models;
using Storage.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Functions
{
    public class DropDownFunction
    {
        private  readonly StorageContext _context;

        public DropDownFunction(StorageContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> CategoryDrop()
        {
            var xcat = new List<CatDropDown>() { };
            xcat.Clear();

            var cat = _context.Product.Select(p =>
            new Product
            {
                Id = p.Id,
                Category = p.Category

            }).AsEnumerable().GroupBy(c => c.Category).Select(y => y.First());

                foreach (var i in cat)
                {
                    xcat.Add(new CatDropDown { CategoryName = i.Category, Id = i.Id });
                }

            return xcat.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.CategoryName });
        }
    }


}

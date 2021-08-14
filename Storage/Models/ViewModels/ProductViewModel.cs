using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }
        public IEnumerable<SelectListItem> CategoryDropDown { get; set; }
    }

    public class CatDropDown
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
     
    }
}

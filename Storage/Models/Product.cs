using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(25, ErrorMessage = "Max 25 tecken")]
        [Display(Name = "Namn")]
        public string Name { get; set; }
        [Range(0, 10000)]
        [Display(Name = "Pris")]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Orderdatum")]
        public DateTime Orderdate { get; set; }
        [Required]
        [Display(Name = "Kategori")]
        public string Category { get; set; }
        [Display(Name = "Lagerplats")]
        public string Shelf { get; set; }
        [Display(Name= "Antal")]
        public int Count { get; set; }
        [Display(Name= "Description")]
        public string Description { get; set; }
    }
}

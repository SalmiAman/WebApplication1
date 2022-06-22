using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.ViewModels
{
    public class Menu
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public Nullable<int> MenuId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string ParentName { get; set; }

        [Required]
        public string MenuName { get; set; }
        public Nullable<int> MenuOrder { get; set; }

        [Required]
        public string MenuIcon { get; set; }

    }
}

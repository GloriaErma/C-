using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTodo.Models.ViewModels
{
    // GECS: los elementos de la tabla
    public class TodoViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public bool Done { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }

    }
}

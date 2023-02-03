using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTodo.Models
{
    public class MyDBContext : DbContext
    {
        // GECS: la cadena de conexión=opciones es enviado al padre
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }
        // GECS: la tabla Todo pertenece a esta base datos
        public DbSet<Todo> Todo { get; set; }
    }
    // GECS: representar la tabla Todo
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descripcion { get; set; }
        public bool Done{ get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

}

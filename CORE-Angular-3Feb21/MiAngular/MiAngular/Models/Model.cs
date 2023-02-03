using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAngular.Models
{
    public class MyDbContext : DbContext
    {
        // constructor opciones q reciba se envian a su padre
        // option es cadena de conexión
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Message> Message { get; set; } //tabla pertenece a esta BD.
    }
    // representa tabla
    public class Message
    {
        public int Id { get; set; }         // Key de Tabla 
        public string Name { get; set; }    // quien manda
        public string Text { get; set; }    // texto msg
    }
}

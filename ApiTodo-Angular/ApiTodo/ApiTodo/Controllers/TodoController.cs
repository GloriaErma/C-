using ApiTodo.Models;
using ApiTodo.Models.Response;
using ApiTodo.Models.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTodo.Controllers
{
    /// <summary>
    ///  // GECS:
    // el programa C# backend esta en D:\GECS-DEV\ProyectoBDprueba\ApiTodo-Angular
    // // ANGULAR ES C:\Users\Gloria Erma\Angular\Angular7
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private Models.MyDBContext db;  // contexto

        public TodoController(Models.MyDBContext context)
        {
            db = context;
        }
        // GECS: prueba con Postman public IActionResult Todo()
        // GECS X ERROR de bloqueo po CORS policy: 
        // NO "Access-Control-Allow-Origin" header is present on the request resource
        [EnableCors("PolicyGECS")]
        [HttpGet("[action]")]
        public IActionResult Text()
        {
            List<Models.Todo> lst = null;
            lst = db.Todo.ToList();
            return Json(lst);
            ////return View();
        }
        // GECS: conexion de un Angular a este backend
        [EnableCors("PolicyGECS")]
        [HttpGet("[action]")]
        public IEnumerable<TodoViewModel> List()
        {
            List<TodoViewModel> L = (from d in db.Todo
                                        select new TodoViewModel
                                        {
                                            Id = d.Id,
                                            Title = d.Title,
                                            Descripcion = d.Descripcion,
                                            Done = d.Done,
                                            CreatedDate = d.CreatedDate,
                                            UpdatedDate = d.UpdatedDate,
                                        }).ToList();
            return L;
        }
        [EnableCors("PolicyGECS")]
        [HttpGet("[action]/{id}")]
        public async Task<Response> UnoAsy(int id)
        {
            Response r = new Response();
            Models.Todo U = await db.Todo.FindAsync(id);
            if(U == null)
            {
                r.Error = 1;
                r.Mensaje = "Registro No Encontrado";
                r.Data = null;
                return r;
            }
            r.Error = 0;
            r.Mensaje = "Transacción Exitosa";
            r.Data = U;
            return r;
        }
        [EnableCors("AllowOrigin")]
        [HttpPost("[action]")]
        public Response Add([FromBody]TodoViewModel model)
        {
            Response oR = new Response();
            try
            {
                Models.Todo oTodo = new Models.Todo();
                oTodo.Title = model.Title;
                oTodo.Descripcion = model.Descripcion;
                oTodo.Done = model.Done;
                oTodo.CreatedDate = model.CreatedDate;
                oTodo.UpdatedDate = model.UpdatedDate;
                db.Todo.Add(oTodo);
                db.SaveChanges();
                oR.Error = 0;
                oR.Mensaje = "Transacción Exitosa";
                oR.Data = oTodo;
            }
            catch(Exception ex)
            {
                oR.Error = 1;
                oR.Mensaje = ex.Message;
            }
            return oR;
        }
        [EnableCors("AllowOrigin")]
        [HttpPut("[action]/{id}")]
        public Response Put(int id, [FromBody]TodoViewModel model)
        {
            Response oR = new Response();
            try
            {
                var reg = db.Todo.FirstOrDefault(x => x.Id == id);
                reg.Title = model.Title;
                reg.Descripcion = model.Descripcion;
                reg.Done = model.Done;
                reg.CreatedDate = model.CreatedDate;
                reg.UpdatedDate = DateTime.Now;
                db.Entry<Todo>(reg).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                oR.Error = 0;
                oR.Mensaje = "Transacción Exitosa";
                oR.Data = reg;
            }
            catch (Exception ex)
            {
                oR.Error = 1;
                oR.Mensaje = ex.Message;
            }
            return oR;
        }
        [EnableCors("AllowOrigin")]
        [HttpDelete("[action]/{id}")]
        public async Task<Response> Del(int id)
        {
            Response r = new Response();
            var reg = await db.Todo.FindAsync(id);
            if (reg == null)
            {
                r.Error = 1;
                r.Mensaje = "Registro No Encontrado";
                r.Data = null;
                return r;
            }
            db.Todo.Remove(reg);
            await db.SaveChangesAsync();
            r.Error = 0;
            r.Mensaje = "Transacción Exitosa";
            r.Data = reg;
            return r;
        }
        // public IActionResult Patch(int id, [FromBody] JsonPatchDocument<VideoGame> patchEntity)
        // Todo es la tabla
        [EnableCors("AllowOrigin")]
        [HttpPatch("[action]/{id}")]
        public Response Pat(int id, [FromBody]JsonPatchDocument<Todo> model)
        {
            Response r = new Response();
            var reg = db.Todo.FirstOrDefault(x => x.Id == id);
            if (reg == null)
            {
                r.Error = 1;
                r.Mensaje = "Registro No Encontrado";
                r.Data = null;
                return r;
            }
            model.ApplyTo(reg, ModelState); // Must have Microsoft.AspNetCore.Mvc.NewtonsoftJson installed
            db.Entry<Todo>(reg).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            if (!ModelState.IsValid)
            {
                r.Error = 1;
                r.Mensaje = "Error aplicando Patch";
                r.Data = null;
                return r;
            }
            r.Error = 0;
            r.Mensaje = "Transacción Exitosa";
            r.Data = reg;
            return r;
        }
    }
}

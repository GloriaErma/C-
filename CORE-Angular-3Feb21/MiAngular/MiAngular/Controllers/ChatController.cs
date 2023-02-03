using MiAngular.Models.Response;
using MiAngular.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAngular.Controllers
{
    [Route("api/[controller]")]
    public class ChatController : Controller
    {
        private Models.MyDbContext db;

        public ChatController(Models.MyDbContext context)
        {
            db = context;
        }
        [HttpGet("[action]")]

        // era la prueba con Postman public IActionResult Message()
        //public IActionResult Message()
        //{
        //    List<Models.Message> lst = null;
        //    lst = db.Message.ToList();
        //    return Json(lst);
        //    //return View();
        //}
        // se cambia XXXXXXXXXXXXXXXXXXX
        // conexion de un Angular a este backend
        public IEnumerable<MessageViewModel> Message()
        {
            List<MessageViewModel> L = (from d in db.Message
                                        orderby d.Id descending
                                        select new MessageViewModel
                                        {
                                            Id = d.Id,
                                            Name = d.Name,
                                            Text = d.Text
                                        }).ToList();
            return L;
        }
        // servicio video #8
        // Solicitud  post
        [HttpPost("[action]")]
        public Response Add([FromBody]MessageViewModel model)
        {
            Response oR = new Response();
            try
            {
                Models.Message oMessage = new Models.Message();
                oMessage.Name = model.Name;
                oMessage.Text = model.Text;
                db.Message.Add(oMessage);
                db.SaveChanges();
                oR.Success = 1;
            }
            catch(Exception ex)
            {
                oR.Success = 0;
                oR.Message = ex.Message;
            }
            return oR;
        }

    }
}

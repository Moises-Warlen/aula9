using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TISelvagem.Aplicacao;

namespace TISelvagem.UI.Web.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        private readonly LoginAplicacao _loginAplicacao;

        public LoginController( LoginAplicacao loginAplicacao)
        {
            _loginAplicacao = loginAplicacao;
        }
        public ActionResult Index() 
        {
            return View();
        }
                       
        public ActionResult Login(string Email, string senha)
        {
            var login = _loginAplicacao.Login( Email,  senha);
            if (login == null )
            {
                return HttpNotFound();
            }


                return  new HttpStatusCodeResult(HttpStatusCode.OK);
        }
      

    }
}

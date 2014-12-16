using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APVM.Models.Usuario;
using Entidades.Basicas;
using Microsoft.Web.WebPages.OAuth;
using Negocios.Negocios;
using WebMatrix.WebData;

namespace APVM.Controllers.Usuario
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModels model, string returnUrl)
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            
            if (ModelState.IsValid && usuarioNegocios.Autenticar(model.Usuario))
            {
                return RedirectToAction("About","Home");
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(model);
        }

        public ActionResult Register()
        {
            //ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModels model)
        {
            if (ModelState.IsValid)
            {
               // Attempt to register the user
                try
                {
                    UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                    usuarioNegocios.Inserir(model.Usuario);
                   
                    return RedirectToAction("Login", "Usuario");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
      

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Voltar()
        {
            return RedirectToAction("Login", "Usuario");
        }

    }
}

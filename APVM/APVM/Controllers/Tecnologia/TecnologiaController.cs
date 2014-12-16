using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APVM.Models.Tecnologia;
using Negocios.Negocios;
using Entidades.Basicas;

namespace APVM.Controllers.Tecnologia
{
    public class TecnologiaController : Controller
    {
        //
        // GET: /Tecnologia/

        public ActionResult PesquisarTecnologia(PesquisarTecnologiaModels model)
        {               
            return View(model);
        }

        public ActionResult CadastroTecnologia()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroTecnologia(CadastroTecnologiaModels model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    TecnologiaNegocios tecnologiaNegocios = new TecnologiaNegocios();
                    tecnologiaNegocios.Inserir(model.Tecnologia);

                    return RedirectToAction("CadastroTecnologia", "Tecnologia");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public ActionResult Pesquisar(PesquisarTecnologiaModels model)
        {
            return RedirectToAction("Login", "Usuario");
        }

    }
}

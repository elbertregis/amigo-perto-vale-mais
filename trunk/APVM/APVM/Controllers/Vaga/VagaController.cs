using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APVM.Models.Vaga;

namespace APVM.Controllers.Vaga
{
    public class VagaController : Controller
    {
        //
        // GET: /Vaga/

        public ActionResult RegisterVaga(RegisterModels model )
        {
            return View(model);
        }

    }
}

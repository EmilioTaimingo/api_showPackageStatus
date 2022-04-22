using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using api_showPackageStatus.Context;
using api_showPackageStatus.Models;

namespace api_showPackageStatus.Controllers
{
    public class showStatusPackageController : ApiController
    
    {
        // GET api/values/5
        public Reply Get([FromBody] NumGuia guia_paquete)
        {
          
            var respuesta= showStatusPackageCommands.mostrar_Status_Paquete(guia_paquete);
            return respuesta;
        }
    }
}
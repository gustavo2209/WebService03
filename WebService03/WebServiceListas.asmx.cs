using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService03
{
    /// <summary>
    /// Descripción breve de WebServiceListas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceListas : System.Web.Services.WebService
    {

        [WebMethod]
        public List<int> ListaSimple()
        {
            List<int> list = new List<int>();

            list.Add(24);
            list.Add(36);
            list.Add(55);
            list.Add(42);
            list.Add(29);

            return list;
        }
    }
}

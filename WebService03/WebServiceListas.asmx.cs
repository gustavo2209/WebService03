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

        [WebMethod]
        public List<object[]> ListaDeArreglos()
        {
            List<object[]> list = new List<object[]>();

            list.Add(new object[] { 1, "aaa", 13.6 });
            list.Add(new object[] { 2, "bbb", 14.2 });
            list.Add(new object[] { 3, "ccc", 11.9 });
            list.Add(new object[] { 4, "ddd", 18.6 });
            list.Add(new object[] { 5, "eee", 15.5 });

            return list;
        }
    }
}

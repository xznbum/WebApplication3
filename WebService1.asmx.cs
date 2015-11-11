using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication3
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]
        public int Summ(Input item)
        {
            return item.summ();
        }
    }

    public class Input
    {
        private int item1;
        private int item2;

        public Input()
        {
            item1 = 0;
            item2 = 0;
        }
        public int summ()
        {
            return item1 + item2;
        }

        public int Item1 { get { return item1; } set { item1 = value; } }
        public int Item2 { get { return item2; } set { item2 = value; } }
    }
}

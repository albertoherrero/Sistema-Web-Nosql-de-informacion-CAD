﻿using System.Web;
using System.Web.Mvc;

namespace Sistema_Web_Nosql_de_informacion_CAD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

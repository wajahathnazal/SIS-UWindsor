﻿using System.Web;
using System.Web.Mvc;

namespace S2G6_SISAPPP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

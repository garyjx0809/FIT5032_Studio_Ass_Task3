﻿using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week08B
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

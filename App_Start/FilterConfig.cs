﻿using System.Web;
using System.Web.Mvc;

namespace WebAppMVC1GitBranch
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

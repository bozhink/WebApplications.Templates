﻿using System.Web;
using System.Web.Mvc;

namespace WebApplication.Mvc.Template.WindowsAuth
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

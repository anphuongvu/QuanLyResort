﻿using System.Web;
using System.Web.Mvc;

namespace Nhom3_QuanLyResort_HQTCSDL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

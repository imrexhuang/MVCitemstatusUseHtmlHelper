using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCitemstatus.Helper
{
    public static class DisplayItemsHelper
    {
        public static HtmlString DisplayItemsStatus(this HtmlHelper htmlHelper, string status)
        {
            var rtnString = "";
            if (status == "00")
            {
                rtnString = "成功";
            }
            else
            {
                rtnString = "失敗";
            }
            return new MvcHtmlString(rtnString);
        }
    }
}
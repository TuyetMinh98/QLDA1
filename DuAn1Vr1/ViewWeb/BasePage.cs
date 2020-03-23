using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewWeb
{  // Kế thừa lại giao diện của trang web
    public class BasePage: System.Web.UI.Page
    {
        protected override void OnInitComplete(EventArgs e)
        {
            base.OnInitComplete(e);
            // Chưa login trả về lại trang login
            if(Session["Currentuser"] == null)
            {
                Response.Redirect("/login.aspx");
            }
        }
    }
}
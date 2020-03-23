using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewWeb
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["Currentuser"] != null)
                {
                    TblNguoiDung user = Session["Currentuser"] as TblNguoiDung;
                    if(user != null)
                    {
                        lbUserName.Text = user.TenDangNhap;
                        // hoăc họ tên nhân viên


                    //lbUserName.Text = string.Format("{0} {1}", user.ho)
                    }
                }
            }
        }
        protected void btn_Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("login.aspx");
        }



    }
}
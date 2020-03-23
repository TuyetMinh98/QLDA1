using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussiness;
using Public;

namespace ViewWeb
{
    public partial class VanPhongView : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            List<TblVanPhong> lstVanPhong = VanPhongBussiness.GetListVanPhong();
            nv.DataSource = lstVanPhong;
            nv.DataBind();
        }

        protected void add(object sender, EventArgs e)
        {
            Response.Redirect("VanPhongAdd.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String a = txtSearch.Text;
            List<TblVanPhong> lstVanPhong = VanPhongBussiness.SearchListVanPhong(a);
            nv.DataSource = lstVanPhong;
            nv.DataBind();
        }

        public string curentld
        {
            get
            {
                return Request.QueryString["Id"];
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                Response.Redirect(string.Format("/VanPhongAdd.aspx?Id={0}", btn.CommandArgument));
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                VanPhongBussiness.DeleteVanPhong(btn.CommandArgument);
                nv.DataBind();
            }
            Response.Redirect("VanPhongView.aspx");
        }
    }
}
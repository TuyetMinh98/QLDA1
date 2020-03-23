using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SubSonic;
using Bussiness;
using Public;

namespace ViewWeb
{
    public partial class KhachHangView : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            List<TblKhachHang> lstKhachHang = KhachHangBussiness.GetListKhachHang();
            nv.DataSource = lstKhachHang;
            nv.DataBind();
        }
        protected void add(object sender, EventArgs e)
        {
            Response.Redirect("KhachHangAdd.aspx");
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String a = txtSearch.Text;
            List<TblKhachHang> lstKhachHang = KhachHangBussiness.SearchListKhachHang(a);
            nv.DataSource = lstKhachHang;
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
                Response.Redirect(string.Format("/KhachHangAdd.aspx?Id={0}", btn.CommandArgument));
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                KhachHangBussiness.DeleteKhachHang(btn.CommandArgument);
                nv.DataBind();
            }
            Response.Redirect("KhachHangView.aspx");
        }
    }
}
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
    public partial class NguoiDungView : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            List<TblNguoiDung> lstNguoiDung = NguoiDungBussiness.GetListNguoiDung();
            nv.DataSource = lstNguoiDung;
            nv.DataBind();
        }
        protected void add(object sender, EventArgs e)
        {
            Response.Redirect("NguoiDungAdd.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String a = txtSearch.Text;
            List<TblNguoiDung> lstNguoiDung = NguoiDungBussiness.SearchListNguoiDung(a);
            nv.DataSource = lstNguoiDung;
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
                Response.Redirect(string.Format("/NguoiDungAdd.aspx?Id={0}", btn.CommandArgument));
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                NguoiDungBussiness.DeleteNguoiDung(btn.CommandArgument);
                nv.DataBind();
            }
            Response.Redirect("NguoiDungView.aspx");
        }
        protected void nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
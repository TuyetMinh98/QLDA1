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
    public partial class BinhLuanView : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            List<TblBinhLuan> lstBinhLuan = BinhLuanBussiness.GetListBinhLuan();
            nv.DataSource = lstBinhLuan;
            nv.DataBind();
        }
        protected void add(object sender, EventArgs e)
        {
            Response.Redirect("BinhLuanAdd.aspx");
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                //  ShowErrorMessage = "Nhập ThônG Tin Cần Tìm";
                Response.Write("<script>alert('Bạn Phải Nhập Từ Khoá Trước Khi Tìm...')</script>");
            }
            else
            {
                String a = txtSearch.Text;
                List<TblBinhLuan> lstBinhLuan = BinhLuanBussiness.SearchListBinhLuan(a);
                nv.DataSource = lstBinhLuan;
                nv.DataBind();
            }
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
                Response.Redirect(string.Format("/BinhLuanAdd.aspx?Id={0}", btn.CommandArgument));
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                BinhLuanBussiness.DeleteBinhLuan(btn.CommandArgument);
                nv.DataBind();
            }
            Response.Redirect("BinhLuanAdd.aspx");
        }
    }
}
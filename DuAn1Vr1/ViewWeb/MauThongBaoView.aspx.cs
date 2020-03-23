using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussiness;
using SubSonic;
using Public;

namespace ViewWeb
{
    public partial class ThongBaoView : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            List<TblMauThongBao> lstThongBao = MauThongBaoBussiness.GetListMauThongBao();
            nv.DataSource = lstThongBao;
            nv.DataBind();
        }
        protected void add(object sender, EventArgs e)
        {
            Response.Redirect("ThongBaoAdd.aspx");
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String a = txtSearch.Text;
            List<TblMauThongBao> lstThongBao = MauThongBaoBussiness.SearchListMauThongBao(a);
            nv.DataSource = lstThongBao;
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
                Response.Redirect(string.Format("/ThongBaoAdd.aspx?Id={0}", btn.CommandArgument));
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                MauThongBaoBussiness.DeleteMauThongBao(btn.CommandArgument);
                nv.DataBind();
            }
            Response.Redirect("ThongBaoView.aspx");
        }
    }
}
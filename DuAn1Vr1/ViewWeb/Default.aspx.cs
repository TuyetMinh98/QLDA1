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
    // BasePage là 1 lớp cơ sở do mình tự tạo.
    // Đây là kế thừa 
    public partial class Default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            List<TblThongBao> lst = ThongBaoBussiness.GetListTopThongBao();
            lv_ThongBao.DataSource = lst;
            BindListView();
            lv_ThongBao.DataBind();
        }
        public string CurentId
        {
            get
            {
                return Request.QueryString["Id"];
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                Response.Redirect(string.Format("/BinhLuanAdd.aspx?Id={0}", btn.CommandArgument));
            }
        }
        protected void lv_OnPagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager dp = (lv_ThongBao.FindControl("dp") as DataPager);
            dp.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            BindListView();
        }
        protected void BindListView()
        {
            List<TblThongBao> lst = ThongBaoBussiness.GetListTopThongBao();
            lv_ThongBao.DataSource = lst;
            lv_ThongBao.DataBind();
        }



    }
}
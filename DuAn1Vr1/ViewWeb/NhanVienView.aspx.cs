using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussiness;
using Public;
using System.Data;

namespace ViewWeb
{
    public partial class NhanVienView : BasePage
    {
        // Tính chất kế thừa, thay vì trang nào ta cũng kiểm tra. 
        //Sẽ bị lập đi lập lại.
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // trang nào ta cũng viết như vậy thì thừa, và tổ chức code tốt. khó bảo trì
                // Vì vậy ta cần tạo ra 1 lớp chung gọi là lớp BasePage.  Kế thừa nó lại là được
                // trong basePage này nó có chức năng kiểm tra session
 

                List<TblNhanVien> lstNhanVien = NhanVienBussiness.GetListNhanVien();
                nv.DataSource = lstNhanVien;
                CustomBindData();
                nv.DataBind();
                               
            }          
        }

        protected void add(object sender, EventArgs e)
        {
            Response.Redirect("NhanVienAdd.aspx");
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
                List<TblNhanVien> lstNhanVien = NhanVienBussiness.SearchListNhanVien(a);
                nv.DataSource = lstNhanVien;
                nv.DataBind();
            }
        }
      //  public string ShowErrorMessage { get; private set; }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                Response.Redirect(string.Format("/NhanVienAdd.aspx?Id={0}", btn.CommandArgument));
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !string.IsNullOrEmpty(btn.CommandArgument))
            {
                NhanVienBussiness.DeleteNhanVien(btn.CommandArgument);
                nv.DataBind();
            }
            Response.Redirect("NhanVienView.aspx");
        }
        protected void Gridv_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CustomBindData();
            nv.PageIndex = e.NewPageIndex;
            nv.DataBind();
        }
        protected void CustomBindData()
        {
            List<TblNhanVien> lstNhanVien = NhanVienBussiness.GetListNhanVien();
            nv.DataSource = lstNhanVien;
            nv.DataBind();
        }
        }
}
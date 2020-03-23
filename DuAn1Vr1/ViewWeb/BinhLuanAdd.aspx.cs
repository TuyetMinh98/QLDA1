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
    public partial class BinhLuanAdd : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDDLNhanVien();
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(CurentId))
                {
                    if (IsPostBack) return;

                    TblThongBao nv = ThongBaoBussiness.GwtThongBaoById(CurentId);
                    if (nv != null)
                    {
                        LoadBinhLuan();
                        LoadThongBao();
                    }
                }
                else
                {

                }
            }
        }
        public string CurentId
        {
            get
            {
                return Request.QueryString["Id"];
            }
        }
        private void LoadDDLNhanVien()
        {
            List<TblNhanVien> lstNhanVien = NhanVienBussiness.GetListNhanVien();
            //ddlNhanVien.DataTextField = TblNhanVien.Columns.TenNhanVien;
            //ddlNhanVien.DataValueField = TblNhanVien.Columns.Id;
            //ddlNhanVien.DataSource = lstNhanVien;
            //ddlNhanVien.DataBind();

            foreach (var item in lstNhanVien)
            {
                ListItem listItem = new ListItem();
                listItem.Text = item.HoNhanVien + " " + item.TenNhanVien;
                listItem.Value = item.Id.ToString();
                ddlNhanVien.Items.Add(listItem);

            }
        }
        private void LoadThongBao()
        {

            List<TblThongBao> lst = ThongBaoBussiness.GetViewListThongBao(CurentId);
            lv_ThongBao.DataSource = lst;
            lv_ThongBao.DataBind();
        }
        private void LoadBinhLuan()
        {

            List<TblBinhLuan> lst = BinhLuanBussiness.GetAddListBinhLuan(CurentId);
            list_bl.DataSource = lst;
            list_bl.DataBind();

        }
        protected void addnv_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(CurentId))
            {
                if (string.IsNullOrEmpty(text_nd.InnerText.Trim()))
                {
                    lbbinhluan.Visible = true;
                    lbbinhluan.Text = "Vui Lòng Nhập Bình Luận";
                }
                //insert
                else
                {
                    TblBinhLuan nv = new TblBinhLuan();
                    string nhanvien = ddlNhanVien.SelectedItem.Text;
                    string idNhanVien = ddlNhanVien.SelectedItem.Value;
                    string idNhanVien2 = ddlNhanVien.SelectedValue;

                    nv.IdNguoiBinhLuan = Guid.Parse(idNhanVien);

                    nv.Id = Guid.NewGuid();
                    nv.NoiDung = text_nd.InnerText;

                    nv.IdThongBao = Guid.Parse(CurentId);
                    nv.NgayTao = DateTime.Now;

                    nv = BinhLuanBussiness.InssertBinhLuan(nv);
                    Response.Redirect(string.Format("/BinhLuanAdd.aspx?Id={0}", CurentId));
                }

            }
            else
            {


            }
        }

    }
}
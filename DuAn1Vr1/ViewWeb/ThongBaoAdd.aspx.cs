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
    public partial class ThongBaoAdd1 : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDDLNhanVien();
            LoadDDLVanPhong();
            LoadDDLMauThongBao();
            LoadDDLKhachHang();
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(curentId))
                {
                    TblNguoiDung nd = NguoiDungBussiness.GwtNguoiDungById(curentId);
                    if (nd != null)
                    {
                        
                        ddlNhanVien.Enabled = false;
                        cbTrangThai.Checked = nd.TrangThai;
                    }
                }
                else
                {
                }
            }
        }
        public string curentId
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
        private void LoadDDLVanPhong()
        {
            List<TblVanPhong> lstVanPhong = VanPhongBussiness.GetListVanPhong();
            //ddlNhanVien.DataTextField = TblNhanVien.Columns.TenNhanVien;
            //ddlNhanVien.DataValueField = TblNhanVien.Columns.Id;
            //ddlNhanVien.DataSource = lstNhanVien;
            //ddlNhanVien.DataBind();
            foreach (var item in lstVanPhong)
            {
                ListItem listItem = new ListItem();
                listItem.Text = item.TenVanPhong;
                listItem.Value = item.Id.ToString();
                ddlVanPhong.Items.Add(listItem);
            }
        }
        private void LoadDDLKhachHang()
        {
            List<TblKhachHang> lstKhachhang = KhachHangBussiness.GetListKhachHang();
            foreach (var item in lstKhachhang)
            {
                ListItem listItem = new ListItem();
                listItem.Text = item.HoTen;
                listItem.Value = item.Id.ToString();
                ddlKhachHang.Items.Add(listItem);
            }
        }
        private void LoadDDLMauThongBao()
        {
            List<TblMauThongBao> lstMauThongBao = MauThongBaoBussiness.GetListMauThongBao();
            foreach (var item in lstMauThongBao)
            {
                ListItem listItem = new ListItem();
                listItem.Text = item.TenMauThongBao ;
                listItem.Value = item.Id.ToString();
                ddlMoTa.Items.Add(listItem);
            }
        }
        protected void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(curentId))
            {
                // eidt
                Guid id = Guid.Parse(curentId);
                TblThongBao updatend = ThongBaoBussiness.GwtThongBaoById(id);
                if (updatend != null)
                {
                    string nhanvien = ddlNhanVien.SelectedItem.Text;
                    string idNhanVien = ddlNhanVien.SelectedItem.Value;
                    string idNhanVien2 = ddlNhanVien.SelectedValue;
                    string idVanPhong = ddlVanPhong.SelectedItem.Value;
                    string vanphong = ddlVanPhong.SelectedItem.Text;
                    string idTenMauThongBao = ddlMoTa.SelectedItem.Value;
                    string MauThongBao = ddlMoTa.SelectedItem.Text;
                    string idKhachHang = ddlKhachHang.SelectedItem.Value;
                    string khachHang = ddlKhachHang.SelectedItem.Text;

                    updatend.IdNhanVien = Guid.Parse(idNhanVien);
                    updatend.IdKhachhang = Guid.Parse(idKhachHang);
                    updatend.IdVanPhong = Guid.Parse(idVanPhong);
                    updatend.MoTa = Guid.Parse(idTenMauThongBao);
                    updatend.NgayTao = DateTime.Now;
                    if (cbTrangThai.Checked)
                    {
                        updatend.TrangThai = true;
                    }
                    updatend.NguoiCapNhat = txtNguoiTao.Text;
                    updatend.ThoiGian = DateTime.Now;
                    updatend.NgayCapNhat = DateTime.Now;
                    updatend = ThongBaoBussiness.UpdateThongBao(updatend);
                }
            }
            else
            {
                //insert
                TblThongBao nd = new TblThongBao();
                nd.Id = Guid.NewGuid();
                //    nv.IdNhanVien = Guid.TryParse(txtname).ToString();
                //  nv.TblVaiTro = txtvaitro.Text;
                string nhanvien = ddlNhanVien.SelectedItem.Text;
                string idNhanVien = ddlNhanVien.SelectedItem.Value;
                string idNhanVien2 = ddlNhanVien.SelectedValue;
                string idVanPhong = ddlVanPhong.SelectedItem.Value;
                string vanphong = ddlVanPhong.SelectedItem.Text;
                string idTenMauThongBao = ddlMoTa.SelectedItem.Value;
                string mota = ddlMoTa.SelectedItem.Text;
                nd.IdNhanVien = Guid.Parse(idNhanVien);
                nd.IdVanPhong = Guid.Parse(idVanPhong);
                nd.MoTa = Guid.Parse(idTenMauThongBao);
                nd.ThoiGian = DateTime.Now;
                //  nv.IdNhanVien = ddlNhanVien.SelectedItem.
                nd.NguoiTao = txtNguoiTao.Text;
                nd.NgayTao = DateTime.Now;
                if (cbTrangThai.Checked)
                {
                    nd.TrangThai = true;
                }
                nd = ThongBaoBussiness.InssertThongBao(nd);
            }
            Response.Redirect("ThongBaoView.aspx");
        }







        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongBaoView.aspx");
        }
    }
}
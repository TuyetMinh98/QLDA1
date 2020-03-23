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
    public partial class KhachHangAdd : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(curentId))
                {
                    TblKhachHang nv = KhachHangBussiness.GwtKhachHangById(curentId);
                    if (nv != null)
                    {
                        txtHoTen.Text = nv.HoTen;
                        txtDiaChi.Text = nv.DiaChi;
                        txtDiaChi.Text = nv.DiaChi;
                        txtSDT.Text = nv.Sdt;
                        cbTrangThai.Checked = nv.TrangThai;
                    }
                }
                else
                {
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(curentId))
            {
                Guid id = Guid.Parse(curentId);
                TblKhachHang updatekh = KhachHangBussiness.GwtKhachHangById(id);
                if (updatekh != null)
                {
                    updatekh.HoTen = txtHoTen.Text;
                    updatekh.DiaChi = txtDiaChi.Text;
                    updatekh.Sdt = txtSDT.Text;
                    updatekh.NguoiCapNhat = txtNguoiTao.Text;
                    updatekh.NgayCapNhat = DateTime.Now;
                    updatekh = KhachHangBussiness.UpDateKhachHang(updatekh);
                }
            }
            else
            {
                TblKhachHang kh = new TblKhachHang();
                kh.Id = Guid.NewGuid();
                kh.HoTen = txtHoTen.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Sdt = txtSDT.Text;
                kh.NgayTao = DateTime.Now;
                kh.NguoiTao = txtNguoiTao.Text;
                if (cbTrangThai.Checked)
                {
                    kh.TrangThai = true;
                }
                kh = KhachHangBussiness.InsertKhachHang(kh);
            }
            Response.Redirect("KhachHangView.aspx");
        }
        public string curentId
        {
            get
            {
                return Request.QueryString["Id"];
            }
        }
        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("KhachHangView.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using SubSonic;
using Bussiness;
using Public;

namespace ViewWeb
{
    public partial class NhanVienAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //   date_birthday.Text = DateTime.UtcNow.ToString("yyyy-MM-dd");
            if (!IsPostBack)
            {
                if (Session["Currentuser"] == null)
                {
                    Response.Redirect("/login.aspx");
                }
                if (!string.IsNullOrEmpty(curentId))
                {
                    TblNhanVien nv = NhanVienBussiness.GwtNhanViebById(curentId);
                    if (nv != null)
                    {
                        txtHo.Text = nv.HoNhanVien;
                        txtTen.Text = nv.TenNhanVien;
                        date_birthday.Text = nv.NamSinh.ToString("yyyy-MM-dd");
                        date_word.Text = nv.NgayVaoLam.ToString("yyyy-MM-dd"); ;
                        txtSDT.Text = nv.Sdt;
                        txtDiaChi.Text = nv.DiaChi;
                        txtEmail.Text = nv.Email;
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
                // eidt
                Guid id = Guid.Parse(curentId);
                TblNhanVien updatenv = NhanVienBussiness.GwtNhanViebById(id);
                if (updatenv != null)
                {
                    // updatenv.Email = txtEmail.Text;

                    updatenv.HoNhanVien = txtHo.Text;
                    updatenv.TenNhanVien = txtTen.Text;
                    if (!string.IsNullOrEmpty(date_birthday.Text))
                        updatenv.NamSinh = DateTime.Parse(date_birthday.Text);
                    if (!string.IsNullOrEmpty(date_word.Text))
                        updatenv.NgayVaoLam = DateTime.Parse(date_word.Text);
                    updatenv.Sdt = txtSDT.Text;
                    updatenv.Email = txtEmail.Text;
                    updatenv.DiaChi = txtDiaChi.Text;
                    updatenv.NguoiCapNhat = txtNguoiTao.Text;
                    updatenv.NgayCapNhat = DateTime.Now;
                    updatenv = NhanVienBussiness.UpdateNhanVien(updatenv);
                }
            }
            else
            {
                TblNhanVien nv = new TblNhanVien();
                nv.Id = Guid.NewGuid();
                nv.HoNhanVien = txtHo.Text;
                nv.TenNhanVien = txtTen.Text;
                //bool a = false;
                //if (!a)
                //{

                //}
                if (!string.IsNullOrEmpty(date_birthday.Text))
                    nv.NamSinh = DateTime.Parse(date_birthday.Text);
                if (!string.IsNullOrEmpty(date_word.Text))
                    nv.NgayVaoLam = DateTime.Parse(date_word.Text);
                nv.Sdt = txtSDT.Text;
                nv.Email = txtEmail.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.NgayTao = DateTime.Now;
                nv.NguoiTao = txtNguoiTao.Text;
                if (cbTrangThai.Checked)
                {
                    nv.TrangThai = true;
                }
                nv = NhanVienBussiness.InssertNhanVien(nv);
            }
            Response.Redirect("NhanvienView.aspx");
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
            Response.Redirect("NhanVienView.aspx");
        }
    }
}
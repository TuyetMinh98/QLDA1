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
    public partial class NguoiDungAdd : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDDLNhanVien();
            LoadDDLVaiTro();
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(curentId))
                {
                    TblNguoiDung nd = NguoiDungBussiness.GwtNguoiDungById(curentId);
                    if (nd != null)
                    {
                        txtTenDangNhap.Text = nd.TenDangNhap;
                        ddlNhanVien.Enabled = false;
                        txtPass.Text = nd.Pass;
                        cbKichHoat.Checked = nd.KichHoat;
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
        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("NguoiDungView.aspx");
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
        private void LoadDDLVaiTro()
        {
            List<TblVaiTro> lstvaitro = VaiTroBussiness.GetListVaiTro();
            //ddlNhanVien.DataTextField = TblNhanVien.Columns.TenNhanVien;
            //ddlNhanVien.DataValueField = TblNhanVien.Columns.Id;
            //ddlNhanVien.DataSource = lstNhanVien;
            //ddlNhanVien.DataBind();
            foreach (var item in lstvaitro)
            {
                ListItem listItem = new ListItem();
                listItem.Text = item.VaiTro;
                listItem.Value = item.Id.ToString();
                ddlMaVaiTro.Items.Add(listItem);
            }
        }
        protected void addnv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(curentId))
            {
                // eidt
                Guid id = Guid.Parse(curentId);
                TblNguoiDung updatend = NguoiDungBussiness.GwtNguoiDungById(id);
                if (updatend != null)
                {
                    string nhanvien = ddlNhanVien.SelectedItem.Text;
                    string idNhanVien = ddlNhanVien.SelectedItem.Value;
                    string idNhanVien2 = ddlNhanVien.SelectedValue;
                    string idVaitro = ddlMaVaiTro.SelectedItem.Value;
                    string vaitro = ddlMaVaiTro.SelectedItem.Text;
                    updatend.IdNhanVien = Guid.Parse(idNhanVien);
                    updatend.TenDangNhap = txtTenDangNhap.Text;
                    updatend.IdVaiTro = Guid.Parse(idVaitro);
                    if (cbKichHoat.Checked == true)
                    {
                        updatend.KichHoat = true;
                    }
                    else
                    {
                        updatend.KichHoat = false;
                    }
                    updatend.NgayTao = DateTime.Now;
                    if (cbTrangThai.Checked)
                    {
                        updatend.TrangThai = true;

                    }
                    updatend.Pass = txtPass.Text;
                    updatend.NguoiCapNhat = txtNguoiTao.Text;

                    updatend.NgayCapNhat = DateTime.Now;
                    updatend = NguoiDungBussiness.UpDateNguoiDung(updatend);
                }
            }
            else
            {
                //insert
                TblNguoiDung nd = new TblNguoiDung();
                nd.Id = Guid.NewGuid();
                //    nv.IdNhanVien = Guid.TryParse(txtname).ToString();
                nd.TenDangNhap = txtTenDangNhap.Text;
                nd.Pass = txtPass.Text;
                //  nv.TblVaiTro = txtvaitro.Text;
                string nhanvien = ddlNhanVien.SelectedItem.Text;
                string idNhanVien = ddlNhanVien.SelectedItem.Value;
                string idNhanVien2 = ddlNhanVien.SelectedValue;
                string idVaitro = ddlMaVaiTro.SelectedItem.Value;
                string vaitro = ddlMaVaiTro.SelectedItem.Text;
                nd.IdNhanVien = Guid.Parse(idNhanVien);
                nd.IdVaiTro = Guid.Parse(idVaitro);
                //  nv.IdNhanVien = ddlNhanVien.SelectedItem.
                if (cbKichHoat.Checked == true)
                {
                    nd.KichHoat = true;
                }
                else
                {
                    nd.KichHoat = false;
                }
                nd.NguoiTao = txtNguoiTao.Text;
                nd.NgayTao = DateTime.Now;
                if (cbTrangThai.Checked)
                {
                    nd.TrangThai = true;
                }
                nd = NguoiDungBussiness.InsertNguoiDung(nd);
            }
            Response.Redirect("NguoiDungView.aspx");
        }
    }
}

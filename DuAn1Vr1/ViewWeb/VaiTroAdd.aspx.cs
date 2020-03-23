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
    public partial class VaiTroAdd : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(curentId))
                {
                    TblVaiTro vt = VaiTroBussiness.GwtVaiTroById(curentId);
                    if (vt != null)
                    {
                        txtVaiTro.Text = vt.VaiTro;
                        txtNguoiTao.Text = vt.NguoiTao;
                        if (vt.QuyenThem == true)
                        {
                            cbThem.Checked = true;
                        }
                        else
                        {
                            cbThem.Checked = false;
                        }
                      
                        if (vt.QuyenSua == true)
                        {
                            cbSua.Checked = true;
                        }
                        else
                        {
                            cbSua.Checked = false;
                        }
                   
                        if (vt.QuyenXoa == true)
                        {
                            cbXoa.Checked = true;
                        }
                        else
                        {
                            cbXoa.Checked = false;
                        }
          
                        if (vt.TrangThai == true)
                        {
                            cbTrangThai.Checked = true;
                        }
                        else
                        {
                            cbTrangThai.Checked = false;
                        }
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
            Response.Redirect("VaiTroView.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(curentId))
            {
                Guid id = Guid.Parse(curentId);
                TblVaiTro updatevt = VaiTroBussiness.GwtVaiTroById(id);
                if (updatevt != null)
                {
                    updatevt.VaiTro = txtVaiTro.Text;
                    updatevt.NguoiCapNhat = txtNguoiTao.Text;
                    updatevt.QuyenThem = cbThem.Checked;
                    updatevt.QuyenSua = cbSua.Checked;
                    updatevt.QuyenXoa = cbXoa.Checked;
                    updatevt.NgayCapNhat = DateTime.Now;
                    if (cbTrangThai.Checked == true)
                    {
                        updatevt.TrangThai = true;
                    }
                    else
                    {
                        updatevt.TrangThai = false;
                    }
                    updatevt = VaiTroBussiness.UpdateVaiTro(updatevt);
                }
            }
            else
            {
                TblVaiTro vt = new TblVaiTro();
                vt.Id = Guid.NewGuid();
                vt.VaiTro = txtVaiTro.Text;
                vt.QuyenThem = cbThem.Checked;
                vt.QuyenSua = cbSua.Checked;
                vt.QuyenXoa = cbXoa.Checked;
                vt.NgayTao = DateTime.Now;
                vt.NguoiTao = txtNguoiTao.Text;
                if (cbTrangThai.Checked)
                {
                    vt.TrangThai = true;
                }
                vt = VaiTroBussiness.InssertVaiTro(vt);
            }
            Response.Redirect("VaiTroView.aspx");
        }
    }
}
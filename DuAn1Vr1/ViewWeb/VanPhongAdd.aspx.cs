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
    public partial class VanPhong : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(curentId))
                {
                    TblVanPhong vp = VanPhongBussiness.GwtVanPhongById(curentId);
                    if (vp != null)
                    {
                        txtTenVanPhong.Text = vp.TenVanPhong;
                        txtNguoiTao.Text = vp.NguoiTao;
                        cbTrangThai.Checked = vp.TrangThai;
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
            Response.Redirect("VanPhongView.aspx");
        }

        protected void btThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(curentId))
            {
                // eidt
                Guid id = Guid.Parse(curentId);
                TblVanPhong updatevp = VanPhongBussiness.GwtVanPhongById(id);
                if (updatevp != null)
                {
                    // updatevp.Email = txtEmail.Text;

                    updatevp.TenVanPhong = txtTenVanPhong.Text;
                    updatevp.NguoiCapNhat = txtNguoiTao.Text;
                    updatevp.NgayCapNhat = DateTime.Now;
                    updatevp = VanPhongBussiness.UpdateVanPhong(updatevp);
                }
            }

            else
            {
                TblVanPhong vp = new TblVanPhong();
                vp.Id = Guid.NewGuid();
                vp.TenVanPhong = txtTenVanPhong.Text;
                vp.NgayTao = DateTime.Now;
                vp.NguoiTao = txtNguoiTao.Text;
                if (cbTrangThai.Checked)
                {
                    vp.TrangThai = true;
                }
                vp = VanPhongBussiness.InsertVanPhong(vp);

            }
            Response.Redirect("VanPhongView.aspx");
        }
    }
}
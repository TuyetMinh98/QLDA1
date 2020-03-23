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
    public partial class ThongBaoAdd : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(curentId))
                {
                    TblMauThongBao tb = MauThongBaoBussiness.GwtMauThongBaoById(curentId);
                    if (tb != null)
                    {
                        txtTen.Text = tb.TenMauThongBao;
                        txtNoiDung.Text = tb.NoiDung;
                        txtNguoiTao.Text = tb.NguoiTao;
                        if(tb.TrangThai == true)
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
        protected void btThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(curentId))
            {
                // eidt
                Guid id = Guid.Parse(curentId);
                TblMauThongBao updatetb = MauThongBaoBussiness.GwtMauThongBaoById(id);
                if (updatetb != null)
                {
                    updatetb.TenMauThongBao = txtTen.Text;
                    updatetb.NoiDung = txtNoiDung.Text;
                    updatetb.TrangThai = cbTrangThai.Checked;
                    updatetb.NguoiCapNhat = txtNguoiTao.Text;
                    updatetb.NgayCapNhat = DateTime.Now;
                    updatetb = MauThongBaoBussiness.UpdateMauThongBao(updatetb);
                }
            }
            else
            {
                TblMauThongBao tb = new TblMauThongBao();
                tb.Id = Guid.NewGuid();
                tb.TenMauThongBao = txtTen.Text;
                tb.NoiDung = txtNoiDung.Text;
                tb.NgayTao = DateTime.Now;
                tb.NguoiTao = txtNguoiTao.Text;
                if (cbTrangThai.Checked)
                {
                    tb.TrangThai = true;
                }
                tb = MauThongBaoBussiness.InsertMauThongBao(tb);
            }
            Response.Redirect("ThongBaoView.aspx");
        }
        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongBaoView.aspx");
        }
    }
}


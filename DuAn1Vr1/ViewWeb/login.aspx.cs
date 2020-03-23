using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussiness;
using System.Web.Security;
using Public;


namespace ViewWeb
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Ispostback sẽ không xóa các value của thẻ html
                // Tức là khi nhấn button nó sẽ không nhảy vào trong hàm iff này. 
                // Chỉ vào khi load lại trang.
                if (Request.Cookies["TenDangNhap"] != null && Request.Cookies["PassWord"] != null)
                {
                    string userName = Request.Cookies["TenDangNhap"].Value;
                    string password = Request.Cookies["PassWord"].Value;

                    TblNguoiDung user = NguoiDungBussiness.GetUserByUserName(userName);
                    if (user != null)
                    {
                        Session["Currentuser"] = user;
                    }

                //    Kiểm tra xem nếu có đăng nhập rồi thì không cần đăng nhập lại.
                  //  if (Session["Currentuser"] != null)
                  //  {
                   //     Response.Redirect("/default.aspx", false);
                   // }
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // ẩn lại các label thông báo
            lbNotiName.Visible = false;
            lbNotiPassword.Visible = false;
            bool valid = false;
            // Kiểm tra User name password có được nhập hay không
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lbNotiName.Text = "Vui lòng nhập tài khoản!";
                valid = true;
                lbNotiName.Visible = true;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                lbNotiPassword.Text = "vui lòng nhập passord!";
                valid = true;
                lbNotiPassword.Visible = true;
            }
            if (valid)
            {
                return;
            }
            else
            {
                TblNguoiDung user = NguoiDungBussiness.GetUserByUserName(txtName.Text.Trim());
                if (user != null)
                {
                    if (user.TrangThai)
                    {
                        // .Trim là loại bỏ các khoảng trắng đầu cuối
                        if (user.Pass == txtPass.Text.Trim())
                        {
                            // Chỗ này còn một bước lưu cookie, tìm hiểu rồi cập nhật thêm. 
                            // Đó là chức năng remember me
                            if (chkRemember.Checked)
                            {
                                Response.Cookies["TenDangNhap"].Value = txtName.Text;
                                Response.Cookies["PassWord"].Value = txtPass.Text;
                                Response.Cookies["TenDangNhap"].Expires = DateTime.Now.AddDays(30);
                                Response.Cookies["PassWord"].Expires = DateTime.Now.AddDays(30);
                            }
                            else
                            {
                                Response.Cookies["TenDangNhap"].Expires = DateTime.Now.AddMinutes(-1);
                                Response.Cookies["PassWord"].Expires = DateTime.Now.AddMinutes(-1);
                            }

                            // Login thành công
                            Session["Currentuser"] = user;
                            Response.Redirect("/default.aspx", false);
                        }
                        else
                        {
                            lbNotiPassword.Text = "Mật khẩu không đúng";
                            lbNotiPassword.Visible = true;
                            return;
                        }
                    }
                    else
                    {
                        lbNotiName.Text = "Tài khoản của bạn đã bị khóa";
                        lbNotiName.Visible = true;
                        return;
                    }
                }
                else
                {
                    lbNotiName.Text = "Tài khoản không đúng";
                    lbNotiName.Visible = true;
                    return;
                }


            }
        }

    }


}
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ViewWeb.login" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css">
    <title>HỆ THỐNG ĐĂNG NHẬP</title>
</head>
<body>
    <form id="form1" runat="server">

        <%-- Sử dụng Update Panel để load lại trang mỗi khi postback --%>
        <%-- Update panel là script nên cần có Script manager --%>
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <div class="login-panel panel panel default" style="margin-top: 40px; height: 40px; width: min-content">
                    <div class="panel-heading" style="background-color: chocolate; color#fff">
                        <h1 class="panel-title" style="text-align: center">ĐĂNG NHẬP</h1>
                    </div>
                    <div class="panel-body">
                        <div class="form-group">
                            <label for="emailField">TÊN ĐĂNG NHẬP</label>
                            <div class="input-group">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-user"></span></span>
                                <asp:TextBox ID="txtName" runat="server" CssClass="from-control"></asp:TextBox><br />
                            </div>
                            <%-- <Br/> là thẻ xuống dòng của html --%>
                            <%-- mặc định cho nó ẩn đi, ta dùng visible --%>
                            <asp:Label ID="lbNotiName" runat="server" Style="color: red" Visible="false" />

                        </div>
                        <div class="form-group">
                            <label for="emailField">MẬT KHẨU</label>
                            <div class="input-group">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-user"></span></span>
                                <asp:TextBox ID="txtPass" runat="server" CssClass="from-control" TextMode="Password"></asp:TextBox><br />
                            </div>
                            <asp:Label ID="lbNotiPassword" runat="server" Style="color: red" Visible="false" />

                        </div>
                        <div class="checkbox">
                            <asp:CheckBox ID="chkRemember" runat="server" style=" width:15px; height:15px; margin-left:40px; color:red" Text="Nhớ Mật Khẩu"/>
                        </div>
                        <%-- Bắt sự kiện click cho nút đăng nhập --%>
                        <asp:Button ID="btnLogin" runat="server" Text="ĐĂNG NHẬP" CssClass="btn btn-success " style="margin-left:40px" OnClick="btnLogin_Click" />
                    </div>
                </div>
            </ContentTemplate>
</asp:UpdatePanel>

    </form>

</body>
</html>
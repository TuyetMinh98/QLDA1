<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="KhachHangAdd.aspx.cs" Inherits="ViewWeb.KhachHangAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    THÊM THÔNG TIN KHÁCH HÀNG
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <div style="height: 628px"; >
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Họ Tên Khách Hàng"></asp:Label>
                    <asp:TextBox ID="txtHoTen" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
               <%--<asp:RequiredFieldValidator ID="ten" runat="server" ControlToValidate="txtHo" ErrorMessage="Please enter a password"  
                ForeColor="Red"></asp:RequiredFieldValidator> --%>

                </div>
                </div>
            <div class="col-md-6">
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Địa Chỉ"></asp:Label>
                <asp:TextBox ID="txtDiaChi" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
            </div>
                </div>
        </div>
        <div class="row">
                <div class="col-md-4">
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Số Điện Thoại"></asp:Label>
                <asp:TextBox ID="txtSDT" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
            </div>
                </div>
            <div class="col-md-4">
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Người Tạo"></asp:Label>
                <asp:TextBox ID="txtNguoiTao" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
            </div>
                </div>

                 <div class="col-md-4">
            <div class="form-group">
                <asp:Label ID="Label12" runat="server" Text="Trạng Thái"></asp:Label>
                <br />
                <asp:CheckBox ID="cbTrangThai" runat="server" Style="width:auto"/>
            </div>
           </div>
            </div>
            <div class="form-group">
            <asp:Button ID="btThem" runat="server" OnClick="Button1_Click" Text="Thêm Vào"/>
            </div>
            <div class="form-group">
            <asp:Button ID="btnThoat" runat="server" Text="THOÁT" OnClick="btnThoat_Click" />
            </div>
             </div>
            <br />
</asp:Content>


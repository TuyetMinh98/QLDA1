<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="NhanVienAdd.aspx.cs" Inherits="ViewWeb.NhanVienAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    Thêm Thông tin Nhân Viên
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <div style="height: 628px"; >
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Họ Nhân Viên"></asp:Label>
                    <asp:TextBox ID="txtHo" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
               <%--<asp:RequiredFieldValidator ID="ten" runat="server" ControlToValidate="txtHo" ErrorMessage="Please enter a password"  
                ForeColor="Red"></asp:RequiredFieldValidator> --%>

                </div>
                </div>
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Tên Nhân Viên"></asp:Label>
                    <asp:TextBox ID="txtTen" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldtxtHoten" ControlToValidate="txtTen" runat="server" ErrorMessage="* Bạn phải nhập họ tên"></asp:RequiredFieldValidator><br />--%>
              </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Năm Sinh"></asp:Label>
                    <asp:TextBox TextMode="Date" runat="server" Class="form-control form-control-navbar"  ID="date_birthday" ></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Ngày Vào Làm"></asp:Label>
                <asp:TextBox TextMode="Date" runat="server" Class="form-control form-control-navbar" ID="date_word" ></asp:TextBox>
            </div>
            </div>
        </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Số Điện Thoại"></asp:Label>
                        <asp:TextBox ID="txtSDT" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
                </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
     
                    </div>
                </div>
            </div>
        <div class="row">
                <div class="col-md-6">
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Địa Chỉ"></asp:Label>
                <asp:TextBox ID="txtDiaChi" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
            </div>
                </div>
            <div class="col-md-3">
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Người Tạo"></asp:Label>
                <asp:TextBox ID="txtNguoiTao" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
            </div>
                </div>

                 <div class="col-md-3">
            <div class="form-group">
                <asp:Label ID="Label12" runat="server" Text="Trạng Thái"></asp:Label>
                <br />
                <asp:CheckBox ID="cbTrangThai" runat="server" Style="width:auto"/>
            </div>
           </div>
            </div>
            <div class="form-group">
            <asp:Button ID="btThem" runat="server" OnClick="Button1_Click" Text="Thêm Vào"  OnClientClick="return confirm('Lưu Thông Tin Bạn Vừa Thay Đổi!')"/>
            </div>
            <div class="form-group">
            <asp:Button ID="btnThoat" runat="server" Text="THOÁT" OnClick="btnThoat_Click" />
            </div>
             </div>
            <br />
</asp:Content>

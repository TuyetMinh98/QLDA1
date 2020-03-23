﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="NguoiDungAdd.aspx.cs" Inherits="ViewWeb.NguoiDungAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    Thêm Người Dùng
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <div style="height: 628px"; >
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Tên Nhân Viên"></asp:Label><br />
                    <asp:DropDownList ID="ddlNhanVien" runat="server" Class="form-control form-control-navbar"></asp:DropDownList>
                    </div>
                </div>
              <div class="col-md-6">
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Mã Vai trò"></asp:Label>
                        <asp:DropDownList ID="ddlMaVaiTro" runat="server" Class="form-control form-control-navbar"></asp:DropDownList>
                </div>
                </div>
            </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Tên Đăng Nhập"></asp:Label>
                    <asp:TextBox ID="txtTenDangNhap" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
                </div>
                </div>
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="PassWord"></asp:Label>
                    <asp:TextBox ID="txtPass" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
              </div>
            </div>
        </div>
    <div class="row">
                <div class="col-md-4">
                <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Người Tạo"></asp:Label>
                <asp:TextBox ID="txtNguoiTao" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
            </div>
            </div>
                <div class="col-md-4">
                <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Kích Hoạt"></asp:Label>
                <asp:CheckBox ID="cbKichHoat" runat="server" Style="width:auto"/>
             </div>
              </div>
 
               <div class="col-md-4">
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Trạng Thái"></asp:Label>
                <asp:CheckBox ID="cbTrangThai" runat="server" Style="width:auto"/>
            </div>
            </div>
            </div>
            <div class="form-group">
            <asp:Button ID="btThem" runat="server" Text="Thêm Vào" OnClick="addnv_Click" OnClientClick="return confirm('Bạn Chắc Chắn Muốn Lưu Thay Đổi!')"/>
            </div>
            <div class="form-group">
            <asp:Button ID="btnThoat" runat="server" Text="THOÁT" OnClick="btnThoat_Click"  />
            </div>
             </div>
            <br />
</asp:Content>

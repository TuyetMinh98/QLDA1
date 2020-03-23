<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="VaiTroAdd.aspx.cs" Inherits="ViewWeb.VaiTroAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    Thêm Vai trò
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <div style="height: 628px"; >
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Vai Trò"></asp:Label>
                    <asp:TextBox ID="txtVaiTro" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
                </div>
                </div>  
            <div class="col-md-3">
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Người Tạo"></asp:Label>
                <asp:TextBox ID="txtNguoiTao" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
            </div>
            </div>
            <div class="col-md-3">
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Trạng Thái"></asp:Label>
                <br />
                <asp:CheckBox ID="cbTrangThai" runat="server" Style="width:auto"/>
            </div>
           </div>
            </div>
             <div class="col-md-6">
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Được Quyền:    "></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="+ Thêm"></asp:Label>
                <asp:CheckBox ID="cbThem" runat="server" Style="width:auto"/>
                <asp:Label ID="Label5" runat="server" Text="+ Sửa"></asp:Label>
                <asp:CheckBox ID="cbSua" runat="server" Style="width:auto"/>
                <asp:Label ID="Label6" runat="server" Text="+ Xóa"></asp:Label>
                <asp:CheckBox ID="cbXoa" runat="server" Style="width:auto"/>
            </div>
           </div>
        </br>
            <div class="form-group">
            <asp:Button ID="btThem" runat="server" OnClick="Button1_Click" Text="Thêm Vào"/>
            </div>
            <div class="form-group">
            <asp:Button ID="btnThoat" runat="server" Text="THOÁT" OnClick="btnThoat_Click"  />
            </div>
             </div>
            <br />
</asp:Content>

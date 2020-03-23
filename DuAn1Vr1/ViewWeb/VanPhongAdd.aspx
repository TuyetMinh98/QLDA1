<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="VanPhongAdd.aspx.cs" Inherits="ViewWeb.VanPhong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    Thêm Thông tin Văn Phòng
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <div style="height: 628px"; >
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Tên Văn Phòng"></asp:Label>
                    <asp:TextBox ID="txtTenVanPhong" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
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
            <asp:Button ID="btThem" runat="server" Text="Thêm Vào" OnClick="btThem_Click"/>
            </div>
            <div class="form-group">
            <asp:Button ID="btnThoat" runat="server" Text="THOÁT" OnClick="btnThoat_Click" />
            </div>
             </div>
            <br />
</asp:Content>


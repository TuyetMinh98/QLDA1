<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="MauThongBaoAdd.aspx.cs" Inherits="ViewWeb.ThongBaoAdd" %>


<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    Thêm Mẫu Thông Báo
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <div style="height: 628px"; >
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Tên Thông Báo"></asp:Label>
                    <asp:TextBox ID="txtTen" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
               <%--<asp:RequiredFieldValidator ID="ten" runat="server" ControlToValidate="txtHo" ErrorMessage="Please enter a password"  
                ForeColor="Red"></asp:RequiredFieldValidator> --%>
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
          <div class="form-group">
                  <asp:Label ID="Label5" runat="server" Text="Nội Dung Thông Báo"></asp:Label>
                  <asp:TextBox ID="txtNoiDung" runat="server" Class="form-control form-control-navbar"></asp:TextBox>
          </div>
            <div class="form-group">
            <asp:Button ID="btThem" runat="server"  Text="Thêm Vào" OnClick="btThem_Click"/>
            </div>
            <div class="form-group">
            <asp:Button ID="btnThoat" runat="server" Text="THOÁT" OnClick="btnThoat_Click"  />
            </div>
             </div>
            <br />
</asp:Content>

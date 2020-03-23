<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="BinhLuanView.aspx.cs" Inherits="ViewWeb.BinhLuanView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    BẢNG BÌNH LUẬN
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-md-8">
            <a href="BinhLuanAdd.aspx">
                <button type="button" class="btn btn-primary">Thêm Mới</button>
            </a>
        </div>
        <div class="col-md-4">
            <div class="input-group input-group-sm">
                <asp:TextBox ID="txtSearch" runat="server" type="search" placeholder="Search" aria-label="Search"> </asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" Text="Tìm Kiếm" type="submit" OnClick="btnSearch_Click" />
            </div>
        </div>
    </div>
    <div style="margin-top: 10px; width: auto; text-align: center">
        <asp:GridView AutoGenerateColumns="False" ID="nv" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1.2px" CellPadding="4">
            <Columns>
                <asp:TemplateField HeaderText="STT">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nhân Viên">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Eval("HoNhanVien") + " " +Eval("TenNhanVien") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Bình luận cho">
                    <ItemTemplate>
                        <asp:Label ID="Label12" runat="server" Text='<%# Eval("HoNhanVien") + " " +Eval("TenNhanVien") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Bình Luận Cho Thời Gian">
                    <ItemTemplate>
                        <asp:Label ID="lblName11" runat="server" Text='<%# Eval("ThoiGian") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nội Dung">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("NoiDung") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Bình Luận cho Bình Luận">
                    <ItemTemplate>
                        <asp:Label ID="lblName2" runat="server" Text='<%# Eval("IdBinhLuan") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ngày Tạo">
                    <ItemTemplate>
                        <asp:Label ID="lblName5" runat="server" Text='<%#DateTime.Parse(Eval("NgayTao").ToString()).ToString("hh:mm:ss"+"<br/>"+"dd/MM/yyyy") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Trạng Thái">
                    <ItemTemplate>
                        <asp:Label ID="lblName9" runat="server" Text='<%# Eval("TrangThai") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Thao Tác">
                    <ItemTemplate>
                        <asp:Button runat="server" ID="btnEdit" Text="SỬA" CommandArgument='<%# Eval("Id") %>' OnClick="btnEdit_Click" />
                        <asp:Button runat="server" ID="btnDelete" Text="XÓA" CommandArgument='<%# Eval("Id") %>' OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn Chắc Chắn Muốn Xóa!')" />
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

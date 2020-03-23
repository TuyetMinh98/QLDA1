<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="NhanVienView.aspx.cs" Inherits="ViewWeb.NhanVienView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    Thông tin Nhân Viên
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-md-8">
            <a href="NhanVienAdd.aspx">
                <button type="button" class="btn btn-primary">Thêm Mới</button>
            </a>
             
        </div>
        <div class="col-md-4">
            <div class="input-group input-group-sm">
                <asp:TextBox ID="txtSearch" runat="server" type="search" placeholder="Search" aria-label="Search"> </asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" Text="Tìm Kiếm" type="submit" OnClick="btnSearch_Click" />
            </div>
        </div>
    <div style="margin-top: 10px; width: auto; text-align: center">
        <asp:GridView AutoGenerateColumns="False" ID="nv" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1.2px" CellPadding="4"  AllowPaging="True"  OnPageIndexChanging="Gridv_OnPageIndexChanging" PageSize="5">
            <Columns>
                <asp:TemplateField HeaderText=STT>
                    <ItemTemplate> 
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="Họ Nhân Viên">
                    <ItemTemplate>
                        <asp:Label ID="lblName1" runat="server" Text='<%# Eval("HoNhanVien") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tên Nhân Viên">
                    <ItemTemplate>
                        <asp:Label ID="lblName2" runat="server" Text='<%# Eval("TenNhanVien") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Năm Sinh">
                    <ItemTemplate>
                        <asp:Label ID="lblName3" runat="server" Text='<%# DateTime.Parse(Eval("NamSinh").ToString()).ToString("dd/MM/yyyy") %>'></asp:Label>                      
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ngày Vào Làm">
                    <ItemTemplate>
                        <asp:Label ID="lblName4" runat="server" Text='<%# DateTime.Parse(Eval("NgayVaoLam").ToString()).ToString("dd/MM/yyyy") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="SDT">
                    <ItemTemplate>
                        <asp:Label ID="lblName5" runat="server" Text='<%# Eval("SDT") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label ID="lblName6" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Địa Chỉ">
                    <ItemTemplate>
                        <asp:Label ID="lblName7" runat="server" Text='<%# Eval("DiaChi") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ngày Tạo">
                    <ItemTemplate>
                        <asp:Label ID="lblName8" runat="server" Text='<%#DateTime.Parse(Eval("NgayTao").ToString()).ToString("dd/MM/yyyy" +"<br/>"+"hh:mm:ss") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Người Tạo">
                    <ItemTemplate>
                        <asp:Label ID="lblName9" runat="server" Text='<%# Eval("NguoiTao") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ngày Cập Nhập">
                    <ItemTemplate>
                         <asp:label id="lblname88" runat="server" text='<%# Eval("ngaycapnhat") %>'></asp:label>
                         <%-- <asp:Label ID="lblName8" runat="server" Text='<%#DateTime.Parse(Eval("NgayCapNhat").ToString()).ToString("dd/MM/yyyy" +"<br/>"+"hh:mm:ss") %>'></asp:Label>--%>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Người Cập Nhập">
                    <ItemTemplate>
                        <asp:Label ID="lblName11" runat="server" Text='<%# Eval("NguoiCapNhat")%>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Trạng Thái">
                    <ItemTemplate>
                        <asp:Label ID="lblName12" runat="server" Text='<%# Eval("TrangThai").Equals(true)? "√":"-" %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>              
                <asp:TemplateField HeaderText="Thao Tác">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="btnEdit" Text="SỬA" CommandArgument='<%# Eval("Id") %>' OnClick="btnEdit_Click"/>
                                     <asp:Button runat="server" ID="btnDelete" Text="XÓA" CommandArgument='<%# Eval("Id") %>' OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn Chắc Chắn Muốn Xóa!')" />
                                </ItemTemplate>
                                <FooterStyle Font-Bold="True" />
                            </asp:TemplateField>
                 </Columns>
        </asp:GridView>
    </div>
</asp:Content>

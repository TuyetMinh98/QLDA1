<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="VanPhongView.aspx.cs" Inherits="ViewWeb.VanPhongView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    Thông Tin Văn Phòng của Công Ty
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
   <div class="row">
        <div class="col-md-8">
            <a href="VanPhongAdd.aspx">
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
                <asp:TemplateField HeaderText=STT>
                    <ItemTemplate> 
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="Tên Văn Phòng">
                    <ItemTemplate>
                        <asp:Label ID="lblName2" runat="server" Text='<%# Eval("TenVanPhong") %>'></asp:Label>
                    </ItemTemplate>
                    <FooterStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ngày Tạo">
                    <ItemTemplate>
                        <asp:Label ID="lblName8" runat="server" Text='<%# Eval("NgayTao") %>'></asp:Label>
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
                        <asp:Label ID="lblName10" runat="server" Text='<%# Eval("NgayCapNhat") %>'></asp:Label>
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
                        <asp:Label ID="lblName12" runat="server" Text='<%# Eval("TrangThai") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>       
                <asp:TemplateField HeaderText="Thao Tác">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="btnEdit" Text="SỬA" CommandArgument='<%# Eval("Id") %>' OnClick="btnEdit_Click"  />
                                     <asp:Button runat="server" ID="btnDelete" Text="XÓA" CommandArgument='<%# Eval("Id") %>' OnClick="btnDelete_Click" />
                                </ItemTemplate>
                                <FooterStyle Font-Bold="True" />
                            </asp:TemplateField>
                 </Columns>
        </asp:GridView>
    </div>
</asp:Content>

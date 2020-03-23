<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ViewWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NameTable" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <div class="form-group">
        <label style="font-size: 30px; font-family: Georgia, 'Times New Roman', Times, serif" for="comment">Thông Báo</label>

        <br />
        <asp:ListView ID="lv_ThongBao" runat="server" OnPagePropertiesChanging="lv_OnPagePropertiesChanging">
            <LayoutTemplate>
                <asp:DataPager ID="dp" runat="server" PageSize="3">
                    <Fields>
                        <asp:NumericPagerField ButtonType="Button" NextPageText="more.." />
                    </Fields>
                </asp:DataPager>
                <table style="width: 100%;" cellpadding="2" cellspacing="2" border="0">
                    <tr runat="server" style="padding-top: 20px;" id="itemPlaceholder" />
                </table>
            </LayoutTemplate>

            <ItemTemplate>
                <tr style="background-color: white; border-bottom-style: inset; padding-top: 10px" runat="server">
                    <th style="text-align: inherit; padding-top: 20px; padding-bottom: 10px; }"
                        runat="server">
                        <asp:Label ID="Label1" ForeColor="blue" Font-Size="20px" runat="server" Font-Names="Times New Roman TUR"
                            Text='<%#  Eval("HoNhanVien") +" " +Eval("TenNhanVien")+" : "%>'></asp:Label>
                        <asp:Label ID="Label4" ForeColor="#007bff" Font-Size="20px" runat="server" Font-Names="Times New Roman TUR"
                            Text='<%#DateTime.Parse( Eval("ThoiGian").ToString()).ToString("hh:mm:ss"+" _ "+"dd/MM/yyyy") %>'></asp:Label>
                        <asp:Label ID="Label5" ForeColor="black" Font-Size="20px" runat="server" Font-Names="Times New Roman TUR"
                            Text='<%# "đã" %>'></asp:Label>
                        <asp:Label ID="Label3" ForeColor="red" Font-Size="20px" runat="server" Font-Names="Times New Roman TUR"
                            Text='<%#  Eval("TenMauThongBao") %>'></asp:Label>
                        <br />
                        <asp:Button runat="server" ID="btnAdd" Text="Bình Luận" CommandArgument='<%# Eval("Id") %>' OnClick="btnAdd_Click" />
                        </div>
                    </th>
                </tr>
            </ItemTemplate>


        </asp:ListView>


    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="BinhLuanAdd.aspx.cs" Inherits="ViewWeb.BinhLuanAdd" %>


<asp:Content ID="Content1" ContentPlaceHolderID="NameTable" runat="server">
    Thêm Bình Luận
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <label for="comment">Nội Dung:</label>

    <br />
    <asp:ListView ID="lv_ThongBao" runat="server">
        <LayoutTemplate>
            <table cellpadding="2" width="outo" border="0">
                <tr style="background-color: #ADD8E6" runat="server">
                    <th runat="server"></th>

                </tr>
                <tr runat="server" id="itemPlaceholder" />
            </table>
            <%-- <asp:DataPager runat="server" ID="PeopleDataPager" PageSize="12">
                    <Fields>
                        <asp:NumericPagerField ButtonCount="10" />
                    </Fields>
                </asp:DataPager>--%>
        </LayoutTemplate>

        <ItemTemplate>
            <tr style="background-color: white:" runat="server">
                <th runat="server">
                    <asp:Label ID="Label1" ForeColor="blue" Font-Size="20px" runat="server" Font-Names="Times New Roman TUR"
                        Text='<%#  Eval("HoNhanVien") +" " +Eval("TenNhanVien")+" : "%>'></asp:Label>
                    <%--  <asp:Label ID="Label2" ForeColor="black" Font-Size="20px" runat="server" Font-Names="Times New Roman TUR"
                            Text='<%# " tại văn phòng "
                         +Eval("TenVanPhong")+" vào lúc "%>'></asp:Label>--%>
                    <asp:Label ID="Label4" ForeColor="#007bff" Font-Size="25px" runat="server" Font-Names="Times New Roman TUR"
                        Text='<%#DateTime.Parse( Eval("ThoiGian").ToString()).ToString("hh:mm:ss"+" _ "+"dd/MM/yyyy") %>'></asp:Label>
                    <asp:Label ID="Label5" ForeColor="black" Font-Size="25px" runat="server" Font-Names="Times New Roman TUR"
                        Text='<%# "đã" %>'></asp:Label>
                    <asp:Label ID="Label3" ForeColor="red" Font-Size="25px" runat="server" Font-Names="Times New Roman TUR"
                        Text='<%#  Eval("TenMauThongBao") %>'></asp:Label>
                    <br />
                    <%--   <asp:Button ID="Button1"  runat="server" Text="Trả Lời" /> --%>
                    </th>
            </tr>
        </ItemTemplate>

    </asp:ListView>


    </div>
   
    <div class="form-group">

        <asp:Label ID="lblName2" ForeColor="Black" Font-Size="25px" runat="server" Font-Names="Times New Roman TUR" Text=' <%# Eval("HoNhanVien") +" "+ Eval("TenNhanVien") %>'></asp:Label>



    </div>
    <div class="form-group">
        <label for="comment">Bình Luận:</label><br />
        <asp:ListView ID="list_bl" runat="server">
            <LayoutTemplate>
                <table cellpadding="2" width="outo" border="0">
                    <tr style="background-color: #ADD8E6" runat="server">
                        <th runat="server"></th>

                    </tr>
                    <tr runat="server" id="itemPlaceholder" />
                </table>
                <%-- <asp:DataPager runat="server" ID="PeopleDataPager" PageSize="12">
                    <Fields>
                        <asp:NumericPagerField ButtonCount="10" />
                    </Fields>
                </asp:DataPager>--%>
            </LayoutTemplate>

            <ItemTemplate>
                <tr style="background-color: white:" runat="server">
                    <th runat="server">
                        <asp:Label ID="Label2" ForeColor="Blue" runat="server" Font-Names="Times New Roman TUR" Text='<%#  Eval("HoNhanVien") +" " +Eval("TenNhanVien")+":"%>'></asp:Label>

                        <asp:Label ID="Label1" Font-Names="Times New Roman TUR" runat="server" Text='<%#   Eval("NoiDung")%>'></asp:Label>
                        <br />

                        <asp:Label ID="Label3" runat="server" Font-Names="Times New Roman TUR" Font-Size="13px" Font-Italic="true" Text='<%#  Eval("NgayTao")%>' BorderStyle="None"></asp:Label>
                        <%--   <asp:Button ID="Button1"  runat="server" Text="Trả Lời" /> --%>
                    </th>

                </tr>
            </ItemTemplate>

        </asp:ListView>

    </div>
    <div class="form-group">
        <div class="form-group">
            <label for="usr">Nhân Viên:</label>
            <%--<input  type="date" id ="dsdsd" runat ="server" value="dd.MM.yyyy"/>--%>

            <br />
            <asp:DropDownList ID="ddlNhanVien" runat="server" Class="form-control form-control-navbar">
            </asp:DropDownList>
            <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NhanVienConnectionString %>" SelectCommand="SELECT [HoNhanVien], [TenNhanVien], [Id] FROM [TblNhanVien]"></asp:SqlDataSource>
                <asp:EntityDataSource ID="EntityDataSource1" runat="server">
                </asp:EntityDataSource>--%>
        </div>
        <textarea id="text_nd" runat="server" placeholder="Nhập bình luận của bạn " class="form-control form-control-navbar"></textarea>
        <asp:Label ID="lbbinhluan" runat="server" Style="color: red" Visible="false" />
        <br />
        <asp:Button ID="btn_add" Text="Trả Lời" runat="server" OnClick="addnv_Click" />

    </div>
</asp:Content>

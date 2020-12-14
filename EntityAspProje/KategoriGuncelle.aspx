<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriGuncelle.aspx.cs" Inherits="EntityAspProje.KategoriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <form runat="server" class="form-group"  >
              <div>
            <asp:TextBox ID="TxtID" runat="server" Enabled="false" CssClass="form-control" ></asp:TextBox>
        </div>

            <br />
        <div>
            <asp:TextBox ID="TxtAD" runat="server" placeholder="Kategori adını girin.." CssClass="form-control" ></asp:TextBox>
        </div>
            <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Kategori Güncelle" CssClass="btn alert-success " OnClick="Button1_Click"  />
        </div>
            
    </form>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniUrun.aspx.cs" Inherits="EntityAspProje.Urun.YeniUrun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat="server" class="form-group"  >
        <div>
            <asp:TextBox ID="TxtUrunAd" runat="server" placeholder="Ürün adını girin.." CssClass="form-control" ></asp:TextBox>
        </div>
         <br />
          <div>
            <asp:TextBox ID="TxtMarka" runat="server" placeholder="Markayı girin.." CssClass="form-control" ></asp:TextBox>
        </div>
         <br />
          <div>
              <asp:DropDownList ID="DrpKategori" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
         <br />
          <div>
            <asp:TextBox ID="TxtFiyat" runat="server" placeholder="Fiyatı girin.." CssClass="form-control" ></asp:TextBox>
        </div>
         <br />
          <div>
            <asp:TextBox ID="TxtStok" runat="server" placeholder="Stok girin.." CssClass="form-control" ></asp:TextBox>
        </div>
         <br />
      
        <div>
            <asp:Button ID="Button1" runat="server" Text="Kategori Ekle" CssClass="btn btn-primary " Height="36px" OnClick="Button1_Click"  />
        </div>
         <br />
    </form>
</asp:Content>

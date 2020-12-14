<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniSatis.aspx.cs" Inherits="EntityAspProje.Satis.YeniSatis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form runat="server" class="form-group"  >
            Ürün Seçin
            <div>
              <asp:DropDownList ID="DrpUrun" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
         <br />
      
      
         Müşteri
           <div>
              <asp:DropDownList ID="DrpMusteri" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
         <br />
         Peronel 
           <div>
              <asp:DropDownList ID="DrpPersonel" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
         <br />
         Fiyat
          <div>
            <asp:TextBox ID="TxtFiyat" runat="server" placeholder="Fiyatı girin.." CssClass="form-control" ></asp:TextBox>
        </div>
         <br />
       
        <div>
            <asp:Button ID="Button1" runat="server" Text="Satış Yap" CssClass="btn btn-success " Height="36px" Width="250px" OnClick="Button1_Click1"   />
        </div>
         <br />
    </form>
</asp:Content>

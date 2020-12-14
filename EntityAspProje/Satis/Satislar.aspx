<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="EntityAspProje.Satis.Satislar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">

        <tr>
            <th>SATIŞ ID</th>
            <th>ÜRÜN ADI</th>
            <th>PERSONEL </th>
            <th>MÜŞTERİ </th>
            <th>FİYAT </th>
           

        </tr>
        <asp:Repeater ID="Repeater1" runat="server">

            <ItemTemplate>
                <tr>

                    <td><%#Eval("SATISID") %></td>
                    <td><%#Eval("URUNAD") %></td>
                    <td><%#Eval("PERSONELADSOYAD") %></td>
                    <td><%#Eval("MUSTERI") %></td>
                    <td><%#Eval("FIYAT") %></td>
                   
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href ="YeniSatis.aspx" class="btn btn-info">Yeni Satış</a>
</asp:Content>

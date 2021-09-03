<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="RodForms.Lista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/css/Lista.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="BodyContent">
    <asp:GridView ID="dgChoc" runat="server" CssClass="tabelo"></asp:GridView>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="RodForms.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/css/Cadastro.css" rel="stylesheet" />
    <link href="Content/css/Header.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">


    <h2>CADASTRO DE DOCES</h2>
    <main>

        <div class="form-item">
            <label for="id">Id</label><asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <label for="nome">Nome</label><asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <label for="tipo">Tipo</label><asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            <label for="gra">Gramagem</label><asp:TextBox ID="txtGra" runat="server"></asp:TextBox>
        </div>
        <div calss="btnSalvar" id="Salvar">
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btnSalvar" OnClick="btnSalvar_Click" />
        </div>
        <div>
            
            <a href="Lista.aspx">Lista</a>
            <a href="Default.aspx">Menu</a>

        </div>

    </main>
        
</asp:Content>

﻿<%@ Page Title="Erro no servidor | Vtnorton" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="500.aspx.cs" Inherits="VTNORTON.erro._500" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul style="margin-left: 0px;">
        <li><a class="ativo" href="/Index.aspx">Principal</a></li>
        <li><a href="/connect/Index.aspx?=menuhome">Sua empresa tem um site?</a></li>
        <li><a href="/search/Index.aspx?=menuhome">Conheça o Search</a></li>
        <li><a href="/search/adicionarnavegador.aspx?=menuhome">Adicione o Search no sue navegador</a></li>
        <li><a href="/yolo/copa2014.aspx?=menuhome">Use nossos avatares!</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper-margin">
            <h1>Isso não deveria ter acontecido.</h1>
            <h3>Parece que estamos com um problema, mas já está sendo resolvido. Tente mais tarde.</h3>
    </div>
</asp:Content>

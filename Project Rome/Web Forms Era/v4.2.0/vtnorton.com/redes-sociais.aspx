﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="redes-sociais.aspx.cs" Inherits="VTNORTON.redes_sociais" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/sobre">Sobre</a></li>
        <li><a href="/vitor/">Biografia</a></li>
        <li><a href="/linha-do-tempo.aspx">Linha do tempo</a></li>
        <li><a class="on" href="/redes-sociais">Redes Sociais</a></li>
        <li><a href="/faq">FAQ</a></li>
        <li><a href="/contato">Contato</a></li>
        <li><a href="/suporte/status.aspx">Status do serviço</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

</asp:Content>
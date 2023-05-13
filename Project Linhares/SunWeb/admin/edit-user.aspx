﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="edit-user.aspx.cs" Inherits="SunWeb.admin.edit_user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="padding: 20px">
        <asp:TextBox ID="txtName" placeholder="Primeiro nome" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLastName" placeholder="Último nome" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtNickName" placeholder="Apelido" runat="server"></asp:TextBox><br />
        <hr />
        <asp:TextBox ID="txtEmail" placeholder="E-mail" runat="server" TextMode="Email"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtPassword" placeholder="Senha" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtPasswordRepeat" placeholder="Repetir senha" TextMode="Password" runat="server"></asp:TextBox><br />
        <hr />
        <asp:DropDownList ID="ddlFarm" runat="server">
            <asp:ListItem Enabled="true" Selected="True" Text="Selecione uma fazenda"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Nome da fazenda 1"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Nome da fazenda 2"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Nome da fazenda 3"></asp:ListItem>
        </asp:DropDownList><br /><br />
        <asp:TextBox ID="txtPhone" placeholder="Telefone" TextMode="Phone" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtAdress" placeholder="Endereço" TextMode="Phone" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtBirthday" placeholder="Aniversário" TextMode="DateTime" runat="server"></asp:TextBox><br /><br />
        <asp:RadioButtonList ID="rbtUnity" runat="server">
            <asp:ListItem Enabled="true" Selected="False" Text="Kilometros"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="True" Text="Hectares"></asp:ListItem>
            <asp:ListItem Enabled="true" Selected="False" Text="Milhas"></asp:ListItem>
        </asp:RadioButtonList><br />
        <hr />
        <asp:TextBox ID="txtCPF" placeholder="CPF" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtRG" placeholder="RG" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtPassport" placeholder="Passporte" runat="server"></asp:TextBox><br />
        <hr /><br />
        <asp:Button ID="btnNewuser" OnClick="btnNewuser_Click" runat="server" Text="Editar usuário" />
        <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

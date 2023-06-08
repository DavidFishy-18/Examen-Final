<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Examen_Final.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Eliminar Automoviles</h2>
    <p>&nbsp; Eliminar completamente los datos de un automovil.</p>
    <p>&nbsp; Seleccionar automovil&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="133px">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Eliminar" class ="btn btn-primary" OnClick="Button1_Click"/>
    </p>
</asp:Content>

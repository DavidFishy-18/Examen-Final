<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mostrar Datos.aspx.cs" Inherits="Examen_Final.Mostrar_Datos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Datos de automoviles</h2>
    <p>
        <asp:GridView ID="GridView1" runat="server" Width="246px">
        </asp:GridView>
    </p>

</asp:Content>

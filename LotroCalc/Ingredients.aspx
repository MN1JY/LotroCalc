<%@ Page Title="Lord Of The Rings Online (LOTRO) Crafting Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ingredients.aspx.cs" Inherits="LotroCalc.Ingredients" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="border-style: none; width: 99%; height: 100%; vertical-align: top;" cellpadding="0" cellspacing="0">      
        <tr>
            <td align="center">
                <h1 style="padding: 0px; margin: 0px">Shopping List Ingredients</h1>
            </td>
        </tr>
        <tr>
            <td style="height: 100%;">
                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" 
                    ZoomMode="FullPage" Height="100%" ShowPageNavigationControls="False" 
                    ShowBackButton="False" ShowRefreshButton="False" ShowFindControls="False" 
                    ShowZoomControl="True">
                </rsweb:ReportViewer>
            </td>
        </tr>
        <tr>
            <td align="left" bgcolor="#E0E0E0" 
                style="padding: 5px 5px 3px 5px;">
                <asp:Button ID="btnRecipes" runat="server" Text="<< Choose Recipes" 
                    onclick="BtnRecipesClick" ToolTip="Return to previous screen" />
            </td>
        </tr>
    </table>
    <asp:ScriptManager runat="server" />
</asp:Content>

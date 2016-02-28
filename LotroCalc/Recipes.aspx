<%@ Page Title="Lord Of The Rings Online (LOTRO) Crafting Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recipes.aspx.cs" Inherits="LotroCalc.Recipes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table style="border: 1px solid #000000; width: 100%; height: 100%;" cellpadding="0" 
        cellspacing="0">
        <tr>
            <td style="width: 250px;" valign="top">
                <table cellpadding="5" cellspacing="0" >
                    <tr>
                        <td align="left">
                            <asp:DropDownList ID="dlProfession" runat="server" style="width: 250px;" 
                                AutoPostBack="True" 
                                onselectedindexchanged="dlProfession_SelectedIndexChanged">
                                <asp:ListItem>Cook</asp:ListItem>
                                <asp:ListItem>Forester</asp:ListItem>
                                <asp:ListItem>Jeweler</asp:ListItem>
                                <asp:ListItem>Metalsmith</asp:ListItem>
                                <asp:ListItem>Prospector</asp:ListItem>
                                <asp:ListItem>Scholar</asp:ListItem>
                                <asp:ListItem>Tailor</asp:ListItem>
                                <asp:ListItem>Weaponsmith</asp:ListItem>
                                <asp:ListItem>Woodworker</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:DropDownList ID="dlTier" runat="server" style="width: 250px;" 
                                AutoPostBack="True" onselectedindexchanged="dlTier_SelectedIndexChanged">
                                <asp:ListItem>* ALL *</asp:ListItem>
                                <asp:ListItem>Apprentice</asp:ListItem>
                                <asp:ListItem>Journeyman</asp:ListItem>
                                <asp:ListItem>Expert</asp:ListItem>
                                <asp:ListItem>Artisan</asp:ListItem>
                                <asp:ListItem>Master</asp:ListItem>
                                <asp:ListItem>Supreme</asp:ListItem>
                                <asp:ListItem>Westfold</asp:ListItem>
                                <asp:ListItem>Eastemnet</asp:ListItem>
                                <asp:ListItem Selected="True">Westemnet</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:ListBox ID="lbRecipes" runat="server" style="height: 500px;" 
                                AutoPostBack="True" onselectedindexchanged="lbRecipes_SelectedIndexChanged">
                            </asp:ListBox>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 100%;" valign="top">
                <table cellpadding="0" cellspacing="0" style="width: 100%;">
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblRecipeSelected" runat="server" Font-Bold="True" 
                                Font-Size="12pt" ForeColor="Blue">Select a recipe to view the top-level ingredients</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table cellpadding="0" cellspacing="0" style="width: 100%;">
                                <tr>
                                    <td align="center" style="border: 1px solid #808080; background-color: #C0C0C0;">
                                        <asp:Label ID="lblIngTitle" runat="server" Text="Required Ingredients" 
                                            ForeColor="Black" Font-Bold="True" Visible="False"></asp:Label>  
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView ID="GridRecipeIngredients" runat="server" style="width: 100%;" Visible="False">
                                            <RowStyle ForeColor="Black" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Panel ID="pnlQuantity" runat="server" Visible="False">
                                            <table style="width: 100%;" cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td  style="width: 150px;" align="left">
                                                        Quantity&nbsp;produced:&nbsp;
                                                    </td>
                                                    <td align="left" valign="top" width="99%">
                                                        &nbsp;<asp:Label ID="lblQtyProduced" runat="server" Text="1"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td  style="width: 150px;" align="left">
                                                        Quantity&nbsp;to&nbsp;make:&nbsp;&nbsp;
                                                    </td>
                                                    <td align="left" valign="top" width="99%">
                                                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>&nbsp; &nbsp;
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                            ControlToValidate="txtQuantity" ErrorMessage="Please enter a valid number" 
                                                            Font-Bold="True" ForeColor="Red" ValidationExpression="^\d+$" 
                                                            Display="Dynamic"></asp:RegularExpressionValidator>
                                                        &nbsp; &nbsp;
                                                        <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" 
                                                            Text="Add to selected recipes" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2">
                                                        &nbsp;
                                                    </td>
                                                </tr>
                                            </table> 
                                        </asp:Panel>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="border: 1px solid #808080; background-color: #C0C0C0;">
                                        <asp:Label ID="lblClickAdd" runat="server" Font-Bold="True" 
                                            ForeColor="Black" Visible="False">Click the Add button to add this recipe to the list</asp:Label>

                                        <asp:Label ID="lblCartTitle" runat="server" Text="Selected Recipes" 
                                            ForeColor="Black" Font-Bold="True" Visible="False"></asp:Label>  
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView ID="GridRecipeCart" runat="server" style="width: 100%;" 
                                            AutoGenerateDeleteButton="True" onrowdeleting="GridRecipeCart_RowDeleting">
                                            <RowStyle ForeColor="Black" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: center;">
                                        <asp:Button ID="btnClear" runat="server" Text="Clear selected recipes" 
                                            onclick="btnClear_Click" CausesValidation="False" />                            
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr style="height: 30px;">
            <td align="left">
                <asp:Button ID="btnConfig" runat="server" Text="<< Configure Professions" 
                    onclick="btnConfig_Click" />
            </td>
            <td align="right">
                <asp:Button ID="btnIngredients" runat="server" Text="Create ingredient list >>" 
                    onclick="btnIngredients_Click" CausesValidation="False" />
            </td>
        </tr>
    </table>
</asp:Content>

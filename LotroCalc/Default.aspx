<%@ Page Title="Lord Of The Rings Online (LOTRO) Crafting Calculator" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="LotroCalc._Default" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table style="border-width: 1px; border-color: #000000; border-style: none none solid none; width: 99%; vertical-align: top;" cellpadding="0" cellspacing="0">      
        <tr>
            <td align="center">
                <h1 style="padding: 0px; margin: 0px">Crafting Professions Available</h1>
            </td>
        </tr>
        <tr>
            <td align="center">
                <b>These selections will determine what recipes are available for you to craft.</b>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 100%; color: #000000;">
                    <tr>
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkCook" runat="server" Text="Cook" Checked="True" 
                                AutoPostBack="True" oncheckedchanged="chkCook_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlCook" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlCook_SelectedIndexChanged">
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
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkJeweler" runat="server" Text="Jeweler" Checked="True" 
                                AutoPostBack="True" oncheckedchanged="chkJeweler_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlJeweler" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlJeweler_SelectedIndexChanged">
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
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkMetalsmith" runat="server" Text="Metalsmith" 
                                Checked="True" AutoPostBack="True" 
                                oncheckedchanged="chkMetalsmith_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlMetalsmith" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlMetalsmith_SelectedIndexChanged">
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
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkScholar" runat="server" Text="Scholar" Checked="True" 
                                AutoPostBack="True" oncheckedchanged="chkScholar_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlScholar" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlScholar_SelectedIndexChanged">
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
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkTailor" runat="server" Text="Tailor" Checked="True" 
                                AutoPostBack="True" oncheckedchanged="chkTailor_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlTailor" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlTailor_SelectedIndexChanged">
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
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkWeaponsmith" runat="server" Text="Weaponsmith" 
                                Checked="True" AutoPostBack="True" 
                                oncheckedchanged="chkWeaponsmith_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlWeaponsmith" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlWeaponsmith_SelectedIndexChanged">
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
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkWoodworker" runat="server" Text="Woodworker" 
                                Checked="True" AutoPostBack="True" 
                                oncheckedchanged="chkWoodworker_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlWoodworker" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlWoodworker_SelectedIndexChanged">
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
                </table>
            </td>
        </tr>  
        <tr>
            <td align="center">
                <h1>Gathering Professions Available</h1>
            </td>
        </tr>
        <tr>
            <td align="center">
                <b>These selections will determine how far to decompose gathered ingredients.</b>
                <br />
                For example if your recipe needs gold bars, checking supreme prospector will display the quantity of gold bars AND gold ore
                required. 
                <br /> 
                Unchecking prospector will only display the gold bars required without 
                any decomposition to show the ore required.
                <br />
                Ingredients will also not be decomposed if you select a tier below the crafting 
                requirement. Khazad ore, for example, cannot be refined into bars if you pick Apprentice 
                prospector.
            </td>
        </tr>
        <tr valign="top">
            <td>
                <table style="width: 100%; color: #000000;">
                    <tr>
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkForester" runat="server" Text="Forester" Checked="True" 
                                AutoPostBack="True" oncheckedchanged="chkForester_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlForester" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlForester_SelectedIndexChanged">
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
                        <td style="width: 35%; text-align: center;">
                            &nbsp;
                        </td>                            
                        <td style="width: 20%; text-align: left;">
                            <asp:CheckBox ID="chkProspector" runat="server" Text="Prospector" 
                                Checked="True" AutoPostBack="True" 
                                oncheckedchanged="chkProspector_CheckedChanged" />
                        </td>
                        <td style="width: 45%; text-align: left;">
                            <asp:DropDownList ID="dlProspector" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="dlProspector_SelectedIndexChanged">
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
                 </table> 
            </td> 
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="center">
                These settings can be automatically reloaded on your next visit if your browser allows cookies from this site.
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Button ID="btnRecipes" runat="server" Text="Choose Recipes >>" 
                    onclick="btnRecipes_Click" Font-Bold="True" />
            </td>
        </tr>
    </table>

</asp:Content>

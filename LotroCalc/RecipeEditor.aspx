<%@ Page Title="Lord Of The Rings Online (LOTRO) Crafting Calculator Editor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecipeEditor.aspx.cs" Inherits="LotroCalc.RecipeEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 99%; height: 99%;" cellpadding="0" cellspacing="0">
        <tr>
            <td style="width: 300px;" valign="top">
                <table style="width: 300px;" cellpadding="0" cellspacing="0">
                    <tr>
                        <td valign="top">   
                            <b>Simple Ingredients</b>
                        </td>
                    </tr>
                    <tr>                        
                        <td valign="top" style="padding-top: 10px">                        
                            <asp:ListBox ID="lbSimple" runat="server" 
                                onselectedindexchanged="lbSimple_SelectedIndexChanged" 
                                style="height: 240px" AutoPostBack="True"></asp:ListBox>
                        </td>                        
                    </tr>
                    <tr>
                         <td valign="top">  
                           <asp:Button ID="SimpA" runat="server" Text="A" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpB" runat="server" Text="B" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpC" runat="server" Text="C" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpD" runat="server" Text="D" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpE" runat="server" Text="E" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpF" runat="server" Text="F" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpG" runat="server" Text="G" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpH" runat="server" Text="H" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpI" runat="server" Text="I" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpJ" runat="server" Text="J" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpK" runat="server" Text="K" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpL" runat="server" Text="L" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpM" runat="server" Text="M" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />                         
                        </td>
                   </tr>
                    <tr>
                         <td valign="top">  
                           <asp:Button ID="SimpN" runat="server" Text="N" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpO" runat="server" Text="O" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpP" runat="server" Text="P" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpQ" runat="server" Text="Q" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpR" runat="server" Text="R" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpS" runat="server" Text="S" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpT" runat="server" Text="T" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpU" runat="server" Text="U" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpV" runat="server" Text="V" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpW" runat="server" Text="W" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpX" runat="server" Text="X" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpY" runat="server" Text="Y" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="SimpZ" runat="server" Text="Z" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="SimpLetter_Click" CausesValidation="False" Enabled="false" />
                        </td>
                   </tr>
                    <tr>
                         <td valign="top" style="padding-top: 10px">  
                            <b>Crafted Ingredients</b>
                        </td>
                   </tr>
                    <tr>
                        <td valign="top">                        
                            <asp:ListBox ID="lbCrafted" runat="server" 
                                onselectedindexchanged="lbCrafted_SelectedIndexChanged" 
                                style="height: 240px" AutoPostBack="True"></asp:ListBox>
                        </td>
                    </tr>
                    <tr>
                         <td valign="top">  
                           <asp:Button ID="CompA" runat="server" Text="A" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompB" runat="server" Text="B" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompC" runat="server" Text="C" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompD" runat="server" Text="D" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompE" runat="server" Text="E" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompF" runat="server" Text="F" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompG" runat="server" Text="G" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompH" runat="server" Text="H" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompI" runat="server" Text="I" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompJ" runat="server" Text="J" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompK" runat="server" Text="K" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompL" runat="server" Text="L" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompM" runat="server" Text="M" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />                         
                        </td>
                   </tr>
                    <tr>
                         <td valign="top">  
                           <asp:Button ID="CompN" runat="server" Text="N" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompO" runat="server" Text="O" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompP" runat="server" Text="P" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompQ" runat="server" Text="Q" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompR" runat="server" Text="R" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompS" runat="server" Text="S" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompT" runat="server" Text="T" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompU" runat="server" Text="U" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompV" runat="server" Text="V" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompW" runat="server" Text="W" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompX" runat="server" Text="X" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompY" runat="server" Text="Y" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                           <asp:Button ID="CompZ" runat="server" Text="Z" Font-Names="Courier New" Font-Size="7pt" Width="15px" onclick="CompLetter_Click" CausesValidation="False" Enabled="false" />
                        </td>
                   </tr>
                </table>  
            </td>
            <td style="width: 100%;" valign="top">
                <table cellpadding="0" cellspacing="0" style="width: 100%;">
                    <tr>
                        <td align="center">
                           <h2>LOTRO Recipe Editor</h2>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width: 100%;">
                                <tr>
                                    <td style="width: 150px;">
                                        Recipe name:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRecipeName" runat="server" Font-Bold="True" 
                                            Font-Size="12pt" ForeColor="Black" Width="300px" MaxLength="120"></asp:TextBox>
                                        <asp:RequiredFieldValidator
                                            ID="RequiredFieldValidator1" runat="server" 
                                            ErrorMessage="&nbsp;Name&nbsp;is&nbsp;required&nbsp;" 
                                            ControlToValidate="txtRecipeName" Font-Bold="True" Font-Size="12pt" 
                                            BackColor="Red" ForeColor="White"></asp:RequiredFieldValidator>
                                    </td>
                                </tr> 
                                <tr>
                                    <td  style="width: 150px;">
                                        Quantity produced:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtQuantityMade" runat="server" Width="150px" MaxLength="3">1</asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            BackColor="Red" Display="Dynamic" ErrorMessage="Enter a number" 
                                            Font-Bold="True" Font-Size="12pt" ForeColor="White" 
                                            ValidationExpression="^\d.*$" ControlToValidate="txtQuantityMade"> Enter a number </asp:RegularExpressionValidator>
                                            &nbsp;
                                        <asp:RequiredFieldValidator
                                            ID="RequiredFieldValidator2" runat="server" 
                                            ErrorMessage="Quantity&nbsp;is&nbsp;required&nbsp;" 
                                            ControlToValidate="txtQuantityMade" Font-Bold="True" Font-Size="12pt" 
                                            BackColor="Red" ForeColor="White"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td  style="width: 150px;">
                                       Profession:
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="dlProfession" runat="server" Width="150px" 
                                            onselectedindexchanged="dlProfession_SelectedIndexChanged" 
                                            AutoPostBack="True">
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
                                    <td  style="width: 150px;">
                                       Tier:
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="dlTier" runat="server" Width="150px">
                                            <asp:ListItem>1_Apprentice</asp:ListItem>
                                            <asp:ListItem>2_Journeyman</asp:ListItem>
                                            <asp:ListItem>3_Expert</asp:ListItem>
                                            <asp:ListItem>4_Artisan</asp:ListItem>
                                            <asp:ListItem>5_Master</asp:ListItem>
                                            <asp:ListItem>6_Supreme</asp:ListItem>
                                            <asp:ListItem>7_Westfold</asp:ListItem>
                                            <asp:ListItem>8_Eastemnet</asp:ListItem>
                                            <asp:ListItem>9_Westemnet</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td  style="width: 150px;">
                                        Crafting Experience:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtXP" runat="server" Width="150px" Text="" MaxLength="3"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                            BackColor="Red" Display="Dynamic" ErrorMessage="Enter a number" 
                                            Font-Bold="True" Font-Size="12pt" ForeColor="White" 
                                            ValidationExpression="^\d.*$" ControlToValidate="txtXP"> Enter a number </asp:RegularExpressionValidator>
                                        &nbsp;
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            BackColor="Red" ControlToValidate="txtXP" 
                                            ErrorMessage="XP&nbsp;is&nbsp;required&nbsp;" Font-Bold="True" Font-Size="12pt" 
                                            ForeColor="White"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>                                
                                <tr>
                                    <td  style="width: 150px;">
                                        Facility Required:
                                    </td>
                                    <td>
                                        <asp:RadioButton ID="rbNone" runat="server" Text="None" Checked="True" 
                                            GroupName="facility" />
                                        <asp:RadioButton ID="rbCampfire" runat="server" Text="Campfire" GroupName="facility" />
                                        <asp:RadioButton ID="rbForge" runat="server" Text="Forge" GroupName="facility" Visible="False" />
                                        <asp:RadioButton ID="rbOven" runat="server" Text="Oven" GroupName="facility" />
                                        <asp:RadioButton ID="rbStudy" runat="server" Text="Study" GroupName="facility" Visible="False"  />
                                        <asp:RadioButton ID="rbSuperiorForge" runat="server" Text="Superior Forge" GroupName="facility"  Visible="False" />
                                        <asp:RadioButton ID="rbSuperiorOven" runat="server" Text="Superior Oven" GroupName="facility" />
                                        <asp:RadioButton ID="rbSuperiorStudy" runat="server" Text="Superior Study" GroupName="facility" Visible="False"  />
                                        <asp:RadioButton ID="rbSuperiorWorkbench" runat="server" Text="Superior Workbench" GroupName="facility" Visible="False"  />
                                        <asp:RadioButton ID="rbWorkbench" runat="server" Text="Workbench" GroupName="facility" Visible="False"  />
                                    </td>
                                </tr>
                                <tr>
                                    <td  style="width: 150px;">
                                        User Recipe:
                                    </td>
                                    <td>
                                        <asp:CheckBox ID="chkUserRecipe" runat="server" Checked="True" />
                                    &nbsp; Top-level recipes only. Un-check for crafted ingredients.</td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <tr valign="top">
                        <td valign="top">
                            <asp:GridView ID="GridView1" runat="server" style="width: 100%;" 
                                AutoGenerateDeleteButton="True" 
                                onrowdeleting="GridView1_RowDeleting"
                                AutoGenerateSelectButton="True" 
                                onselectedindexchanged="GridView1_SelectedIndexChanged" 
                                ShowHeaderWhenEmpty="True" Font-Bold="True" Font-Size="12pt" ForeColor="Black">
                                <SelectedRowStyle BackColor="#FFFFCC" BorderColor="#3399FF" BorderStyle="Solid" 
                                    BorderWidth="1px" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <table cellpadding="0" cellspacing="0" style="width: 100%;">
                                <tr>
                                    <td>
                                        Change Ingredient Quantity:
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtIngQty" runat="server" MaxLength="2">2</asp:TextBox>
                                        <asp:Button ID="btnUpdateQty" runat="server" Text="Update" 
                                            onclick="BtnUpdateQtyClick" CausesValidation="False" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                            BackColor="Red" Display="Dynamic" ErrorMessage="Enter a number" 
                                            Font-Bold="True" Font-Size="12pt" ForeColor="White" 
                                            ValidationExpression="^\d.*$" ControlToValidate="txtIngQty"> Enter a number </asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" align="center">
                            <asp:Button ID="btnCreate" runat="server" Text="Send Recipe" 
                                onclick="BtnCreateClick" 
                                ToolTip="Sends your recipe correction to the author of this site" />
                            &nbsp;&nbsp;
                            &nbsp;&nbsp;

                            <asp:Button ID="btnReset" runat="server" Text="Reset List" onclick="BtnResetClick" 
                                CausesValidation="False" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>

    </table>

</asp:Content>

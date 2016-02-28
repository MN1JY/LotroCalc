using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LotroCalc.RecipeData.Ingredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc
{
    public partial class RecipeEditor : System.Web.UI.Page
    {
        //protected void Page_PreRenderComplete(object sender, EventArgs e)
        //{
        //    BindData();
        //}


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lbSimple.Attributes.Add("ondblclick", ClientScript.GetPostBackEventReference(lbSimple, "simpleDbl"));
                lbCrafted.Attributes.Add("ondblclick", ClientScript.GetPostBackEventReference(lbCrafted, "craftedDbl"));
                btnReset.Attributes.Add("onclick", "javascript:if(confirm('Clear your selected ingredients?')== false) return false;");

                var dt = new DataTable();

                dt.Columns.Add("Ingredient", typeof(string));
                dt.Columns.Add("Type", typeof(string));
                dt.Columns.Add("Quantity", typeof(string));

                ViewState.Add("dt", dt);

                var dictSimpleIngredients = new SortedDictionary<string, Ingredient>();
                SimpleIngredients.GetSimpleIngredients(ref dictSimpleIngredients);

                foreach (Ingredient ing in dictSimpleIngredients.Values)
                {
                    lbSimple.Items.Add(ing.Name);
                    switch (ing.Name.Substring(0, 1).ToUpper())
                    {
                        case "A": SimpA.Enabled = true; break;
                        case "B": SimpB.Enabled = true; break;
                        case "C": SimpC.Enabled = true; break;
                        case "D": SimpD.Enabled = true; break;
                        case "E": SimpE.Enabled = true; break;
                        case "F": SimpF.Enabled = true; break;
                        case "G": SimpG.Enabled = true; break;
                        case "H": SimpH.Enabled = true; break;
                        case "I": SimpI.Enabled = true; break;
                        case "J": SimpJ.Enabled = true; break;
                        case "K": SimpK.Enabled = true; break;
                        case "L": SimpL.Enabled = true; break;
                        case "M": SimpM.Enabled = true; break;
                        case "N": SimpN.Enabled = true; break;
                        case "O": SimpO.Enabled = true; break;
                        case "P": SimpP.Enabled = true; break;
                        case "Q": SimpQ.Enabled = true; break;
                        case "R": SimpR.Enabled = true; break;
                        case "S": SimpS.Enabled = true; break;
                        case "T": SimpT.Enabled = true; break;
                        case "U": SimpU.Enabled = true; break;
                        case "V": SimpV.Enabled = true; break;
                        case "W": SimpW.Enabled = true; break;
                        case "X": SimpX.Enabled = true; break;
                        case "Y": SimpY.Enabled = true; break;
                        case "Z": SimpZ.Enabled = true; break;
                    }
                }
                var dictCompositeIngredients = new SortedDictionary<string, Ingredient>();
                CompositeIngredients.GetCompositeIngredients(ref dictCompositeIngredients);

                foreach (Ingredient ing in dictCompositeIngredients.Values)
                {
                    lbCrafted.Items.Add(ing.Name);
                    switch (ing.Name.Substring(0, 1).ToUpper())
                    {
                        case "A": CompA.Enabled = true; break;
                        case "B": CompB.Enabled = true; break;
                        case "C": CompC.Enabled = true; break;
                        case "D": CompD.Enabled = true; break;
                        case "E": CompE.Enabled = true; break;
                        case "F": CompF.Enabled = true; break;
                        case "G": CompG.Enabled = true; break;
                        case "H": CompH.Enabled = true; break;
                        case "I": CompI.Enabled = true; break;
                        case "J": CompJ.Enabled = true; break;
                        case "K": CompK.Enabled = true; break;
                        case "L": CompL.Enabled = true; break;
                        case "M": CompM.Enabled = true; break;
                        case "N": CompN.Enabled = true; break;
                        case "O": CompO.Enabled = true; break;
                        case "P": CompP.Enabled = true; break;
                        case "Q": CompQ.Enabled = true; break;
                        case "R": CompR.Enabled = true; break;
                        case "S": CompS.Enabled = true; break;
                        case "T": CompT.Enabled = true; break;
                        case "U": CompU.Enabled = true; break;
                        case "V": CompV.Enabled = true; break;
                        case "W": CompW.Enabled = true; break;
                        case "X": CompX.Enabled = true; break;
                        case "Y": CompY.Enabled = true; break;
                        case "Z": CompZ.Enabled = true; break;
                    }
                }
            }
            else
            {
                if (Request["__EVENTARGUMENT"] != null && Request["__EVENTARGUMENT"] == "simpleDbl")
                    lbSimple_SelectedIndexChanged(null, null);

                if (Request["__EVENTARGUMENT"] != null && Request["__EVENTARGUMENT"] == "craftedDbl")
                    lbCrafted_SelectedIndexChanged(null, null);
            }
            BindData();
        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            txtIngQty.Text = row.Cells[3].Text;
        }


        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string ingName = GridView1.Rows[e.RowIndex].Cells[0].Text;

            var dt = (DataTable)ViewState["dt"];
            int rownum = e.RowIndex;
            dt.Rows[rownum].Delete();
            ViewState["dt"] = dt;
            dt.AcceptChanges();

            BindData();
        }


        private void BindData()
        {
            GridView1.DataSource = ViewState["dt"];
            GridView1.DataBind();
        }


        protected void BtnUpdateQtyClick(object sender, EventArgs e)
        {
            var dt = (DataTable)ViewState["dt"];

            //Update the values.
            GridViewRow row = GridView1.SelectedRow;
            dt.Rows[row.DataItemIndex]["Quantity"] = txtIngQty.Text;
            ViewState["dt"] = dt;
            BindData();
        }


        protected void BtnResetClick(object sender, EventArgs e)
        {
            txtRecipeName.Text = "";
            txtQuantityMade.Text = "1";
            var dt = (DataTable)ViewState["dt"];
            dt.Rows.Clear();
            ViewState["dt"] = dt;
            BindData();
        }

        protected void BtnCreateClick(object sender, EventArgs e)
        {
            if (("" == txtRecipeName.Text) || ("Recipe sent. Thank you!" == txtRecipeName.Text))
                return;

            // check for bot attacks that are bypassing client-side validation
            try
            {
                var qty = Int16.Parse(txtQuantityMade.Text);
                var xp = Int16.Parse(txtXP.Text);
            }
            catch (Exception)
            {
                Response.Redirect("~/default.aspx", true);
                return;
            }

            switch (dlTier.SelectedItem.Text)
            {
                case "1_Apprentice":
                case "2_Journeyman":
                case "3_Expert":
                case "4_Artisan":
                case "5_Master":
                case "6_Supreme":
                case "7_Westfold":
                case "8_Eastemnet":
                case "9_Westemnet":  
                    break;

                default:
                    Response.Redirect("~/default.aspx", true);
                    return;
            }

            switch (dlProfession.SelectedItem.Text)
            {
                case "Cook":
                case "Forester":
                case "Jeweler":
                case "Metalsmith":
                case "Prospector":
                case "Scholar":
                case "Tailor":
                case "Weaponsmith":
                case "Woodworker":
                    break;

                default:
                    Response.Redirect("~/default.aspx", true);
                    return;
            }

            String recipeName = HttpUtility.HtmlEncode((txtRecipeName.Text));

            var dt = (DataTable)ViewState["dt"];
            if (0 == dt.Rows.Count)
                return;

            var sb = new StringBuilder();
            string shortName = CompressName(recipeName);

            sb.Append("using System.Collections.Generic;\n");

            sb.Append("using LotroCalc.RecipeData.Ingredients.SimpleIngredients;\n");
            sb.Append("using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;\n");
            sb.Append("using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;\n");
            sb.Append("using LotroCalc.RecipeData.Ingredients.CompositeIngredients;\n");

            sb.Append("\n");

            sb.Append("namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.");
            sb.Append(dlProfession.SelectedValue + ".");
            sb.Append("_" + dlTier.SelectedValue + "\n");

            sb.Append("{\n");

            // public class PieCrust : ApprenticeRecipes
            sb.Append("    public class " + shortName + " : " + dlTier.SelectedValue.Substring(2) + "Ingredients\n");
            sb.Append("    {\n");

            // public static string DisplayName = "Pie Crust";
            sb.Append("        public static string DisplayName = \"" + recipeName + "\";\n");

            sb.Append("\n");

            // public PieCrust(int count)
            sb.Append("        public " + shortName + "(int count)\n");
            sb.Append("        {\n");

            sb.Append("            Name = DisplayName;\n");
            sb.Append("            QuantityRequested = count;\n");
            sb.Append("            QuantityProduced = " + txtQuantityMade.Text + ";\n");
            sb.Append("            CraftingExperience = " + txtXP.Text + ";\n");
            if (Request.UserHostAddress != null)
                sb.Append("            string IPRequester = " + Request.UserHostAddress + ";\n");

            if (rbCampfire.Checked)
                sb.Append("            CampFireRequired = true;\n");
            else if (rbForge.Checked)
                sb.Append("            ForgeRequired = true;\n");
            else if (rbOven.Checked)
                sb.Append("            OvenRequired = true;\n");
            else if (rbStudy.Checked)
                sb.Append("            StudyRequired = true;\n");
            else if (rbSuperiorForge.Checked)
                sb.Append("            SuperiorForgeRequired = true;\n");
            else if (rbSuperiorOven.Checked)
                sb.Append("            SuperiorOvenRequired = true;\n");
            else if (rbSuperiorStudy.Checked)
                sb.Append("            SuperiorStudyRequired = true;\n");
            else if (rbSuperiorWorkbench.Checked)
                sb.Append("            SuperiorWorkbenchRequired = true;\n");
            else if (rbWorkbench.Checked)
                sb.Append("            WorkbenchRequired = true;\n");

            sb.Append("            IsUserRecipe = " + chkUserRecipe.Checked.ToString().ToLower() + ";\n");
            sb.Append("        }\n");

            sb.Append("\n");

            sb.Append("        public override object Clone()\n");
            sb.Append("        {\n");
            sb.Append("            return new " + shortName + "(QuantityRequested);\n");
            sb.Append("        }\n");

            sb.Append("\n");

            sb.Append("        public override SortedDictionary<string, Ingredient> GetRecipeIngredients()\n");
            sb.Append("        {\n");
            sb.Append("            var recipe = new SortedDictionary<string, Ingredient>();\n");

            var dictSimpleIngredients = new SortedDictionary<string, Ingredient>();
            SimpleIngredients.GetSimpleIngredients(ref dictSimpleIngredients);

            var dictCompositeIngredients = new SortedDictionary<string, Ingredient>();
            CompositeIngredients.GetCompositeIngredients(ref dictCompositeIngredients);

            sb.Append("            Ingredient ing;\n");
            sb.Append("            string ingName;\n");
            sb.Append("\n");

            foreach (DataRow row in dt.Rows)
            {
                Ingredient ing = null;
                string ingType = (string)row["Type"];
                string ingName = (string)row["Ingredient"];
                string ingQty = (string)row["Quantity"];

                string ingNamePath;

                //string tier;

                if ("Simple" == ingType)
                {
                    ing = dictSimpleIngredients[ingName];
                    ingNamePath = CompressName(ingName);
                }
                else
                {
                    ing = dictCompositeIngredients[ingName];
                    ingNamePath = "DisplayName";
                }
                string ingClass = ing.GetType().Name;

                //string ingName = SupplierIngredients.CupOfCourseFlour;
                sb.Append("            ingName = " + ingClass + "." + ingNamePath + ";\n");

                //var ing = (Ingredient)DictSimpleIngredients[ingName].Clone();
                sb.Append("            ing = (Ingredient)Dict" + ingType + "Ingredients[ingName].Clone();\n");

                //ing.QuantityRequested = 1 * QuantityRequested;
                sb.Append("            ing.QuantityRequested = " + ingQty + " * QuantityRequested;\n");

                //recipe.Add(ingName, ing);
                sb.Append("            recipe.Add(ingName, ing);\n");

                sb.Append("\n");
            }

            sb.Append("            return recipe;\n");
            sb.Append("        }\n");
            sb.Append("    }\n");
            sb.Append("}\n");

           // txtResults.Text = sb.ToString();

            var sm = new SendMail();
            string account = ConfigurationManager.AppSettings["Account"];
            
            sm.AddSendTo(account);
            sm.Subject = "Recipe Submission - " + recipeName;
            sm.Body = sb.ToString();
            sm.SendSmtpEmail(false);

            txtRecipeName.Text = "Recipe sent. Thank you!";
        }

        private static string CompressName(string strIn)
        {
            string strOut = "";
            foreach (char c in strIn.ToCharArray())
            {
                if ((c != ' ') && (c != '\'') && (c != '(') && (c != ')') && (c != '-') && (c != ':'))
                    strOut += c;
            }
            return strOut;
            // return strIn.ToCharArray().Where(c => c != ' ').Aggregate("", (current, c) => current + c);
        }

        protected void dlProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbNone.Checked = true;

            rbOven.Visible = false;
            rbSuperiorOven.Visible = false;
            rbCampfire.Visible = false;
            rbForge.Visible = false;
            rbSuperiorForge.Visible = false;
            rbWorkbench.Visible = false;
            rbSuperiorWorkbench.Visible = false;
            rbStudy.Visible = false;
            rbSuperiorStudy.Visible = false;

            rbOven.Checked = false;
            rbSuperiorOven.Checked = false;
            rbCampfire.Checked = false;
            rbForge.Checked = false;
            rbSuperiorForge.Checked = false;
            rbWorkbench.Checked = false;
            rbSuperiorWorkbench.Checked = false;
            rbStudy.Checked = false;
            rbSuperiorStudy.Checked = false;

            switch (dlProfession.SelectedItem.Text)
            {
                case "Cook":
                    rbOven.Visible = true;
                    rbSuperiorOven.Visible = true;
                    rbCampfire.Visible = true;
                    break;

                case "Forester":
                    rbWorkbench.Visible = true;
                    rbSuperiorWorkbench.Visible = true;
                    break;

                case "Jeweler":
                    rbWorkbench.Visible = true;
                    rbSuperiorWorkbench.Visible = true;
                    break;

                case "Metalsmith":
                    rbForge.Visible = true;
                    rbSuperiorForge.Visible = true;
                    break;

                case "Prospector":
                    rbForge.Visible = true;
                    rbSuperiorForge.Visible = true;
                    break;

                case "Scholar":
                    rbStudy.Visible = true;
                    rbSuperiorStudy.Visible = true;
                    break;

                case "Tailor":
                    rbWorkbench.Visible = true;
                    rbSuperiorWorkbench.Visible = true;
                    break;

                case "Weaponsmith":
                    rbForge.Visible = true;
                    rbSuperiorForge.Visible = true;
                    break;

                case "Woodworker":
                    rbWorkbench.Visible = true;
                    rbSuperiorWorkbench.Visible = true;
                    break;

            }
        }

        protected void lbSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)ViewState["dt"];

            foreach (DataRow row in dt.Rows)
            {
                var ingName = (string) row["Ingredient"];
                if (ingName == lbSimple.SelectedValue)
                {
                    row["Quantity"] = (Convert.ToInt16(row["Quantity"]) + 1).ToString();
                    dt.AcceptChanges();
                    ViewState["dt"] = dt;

                    BindData();
                    return;
                }
            }

            var rowNew = dt.NewRow();
            rowNew["Ingredient"] = lbSimple.SelectedValue;
            rowNew["Type"] = "Simple";
            rowNew["Quantity"] = 1;
            dt.Rows.Add(rowNew);
            dt.AcceptChanges();

            ViewState["dt"] = dt;

            BindData();

            GridView1.SelectedIndex = GridView1.Rows.Count - 1;
        }

        protected void lbCrafted_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)ViewState["dt"];

            foreach (DataRow row in dt.Rows)
            {
                var ingName = (string)row["Ingredient"];
                if (ingName == lbCrafted.SelectedValue)
                {
                    row["Quantity"] = (Convert.ToInt16(row["Quantity"]) + 1).ToString();
                    dt.AcceptChanges();
                    ViewState["dt"] = dt;

                    BindData();
                    return;
                }
            }

            var rowNew = dt.NewRow();
            rowNew["Ingredient"] = lbCrafted.SelectedValue;
            rowNew["Type"] = "Crafted";
            rowNew["Quantity"] = 1;
            dt.Rows.Add(rowNew);
            dt.AcceptChanges();

            ViewState["dt"] = dt;

            BindData();

            GridView1.SelectedIndex = GridView1.Rows.Count - 1;
        }

        protected void SimpLetter_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var btn = (Button)sender;
                String letter = btn.Text;

                foreach (ListItem li in lbSimple.Items)
                {
                    string s = li.Text;
                    if (letter == s.Substring(0, 1))
                    {
                        lbSimple.SelectedValue = s;
                        return;
                    }
                }
            }
        }

        protected void CompLetter_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var btn = (Button)sender;
                String letter = btn.Text;

                foreach (ListItem li in lbCrafted.Items)
                {
                    string s = li.Text;
                    if (letter == s.Substring(0, 1))
                    {
                        lbCrafted.SelectedValue = s;
                        return;
                    }
                }
            }
        }
    }
}
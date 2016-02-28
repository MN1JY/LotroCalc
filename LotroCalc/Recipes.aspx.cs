using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using LotroCalc.RecipeData.Ingredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc
{
    public partial class Recipes : System.Web.UI.Page
    {
// ReSharper disable InconsistentNaming
        protected void Page_Load(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            if (null == Session["Cook"])
            {
                Response.Redirect("~/default.aspx");
                return;
            }

            if (Page.IsPostBack)
            {
                UpdateRecipesSelected();
                return;
            }
            
            btnClear.Attributes.Add("onclick","javascript:if(confirm('Clear your selected recipes?')== false) return false;");

            UpdateVisibleControls();

            UpdateProfessionsDisplayed();

            UpdateTiersDisplayed();

            UpdateRecipesDisplayed();

            var dtIngs = new DataTable();
            dtIngs.Columns.Add("Ingredient", typeof(string));
            dtIngs.Columns.Add("Quantity", typeof(string));
            ViewState.Add("dtIngs", dtIngs);

            if (null == Session["dtCart"])
            {
                var dtCart = new DataTable();
                dtCart.Columns.Add("Recipe", typeof (string));
                dtCart.Columns.Add("Tier", typeof (string));
                dtCart.Columns.Add("XP", typeof(int));
                dtCart.Columns.Add("Quantity", typeof(string));
                Session.Add("dtCart", dtCart);
            }

            BindData();

            UpdateRecipesSelected();
        }

        private void UpdateVisibleControls()
        {
            bool ingSelected = false;
            if ((null != ViewState["dtIngs"]) && (((DataTable)ViewState["dtIngs"]).Rows.Count > 0))
                ingSelected = true;

            bool recAdded = false;
            if ((null != Session["dtCart"]) && (((DataTable)Session["dtCart"]).Rows.Count > 0))
                recAdded = true;

            GridRecipeIngredients.Visible = ingSelected;
            pnlQuantity.Visible = ingSelected;
            btnAdd.Visible = ingSelected;
            lblIngTitle.Visible = ingSelected;

            if (ingSelected)
            {
                lblClickAdd.Visible = !recAdded;
            }
            else
            {
                lblClickAdd.Visible = false;
            }
            lblCartTitle.Visible = recAdded;
            GridRecipeCart.Visible = recAdded;
            btnIngredients.Font.Bold = recAdded;
            btnClear.Visible = recAdded;

            lblCartTitle.Text = "Selected Recipes";

            if (recAdded)
                lblCartTitle.Text += " (" + ((DataTable)Session["dtCart"]).Rows.Count + ")";
        }

        private void BindData()
        {
            GridRecipeIngredients.DataSource = ViewState["dtIngs"];                
            GridRecipeIngredients.DataBind();

            GridRecipeCart.DataSource = Session["dtCart"];
            GridRecipeCart.DataBind();
        }

        
        private void UpdateProfessionsDisplayed()
        {
            dlProfession.Items.Clear();
            if ((bool)Session["Cook"]) dlProfession.Items.Add("Cook");
            if ((bool)Session["Jeweler"]) dlProfession.Items.Add("Jeweler");
            if ((bool)Session["Metalsmith"]) dlProfession.Items.Add("Metalsmith");
            if ((bool)Session["Scholar"]) dlProfession.Items.Add("Scholar");
            if ((bool)Session["Tailor"]) dlProfession.Items.Add("Tailor");
            if ((bool)Session["Weaponsmith"]) dlProfession.Items.Add("Weaponsmith");
            if ((bool)Session["Woodworker"]) dlProfession.Items.Add("Woodworker");

            if (null == Session["ProfSelected"])
                dlProfession.SelectedIndex = 0;
            else
            {
                var prof = (string)Session["ProfSelected"];

                if (dlProfession.Items.Contains(new ListItem(prof)))
                    dlProfession.SelectedValue = prof;
                else
                    dlProfession.SelectedIndex = 0;
            }
            Session["ProfSelected"] = dlProfession.SelectedValue;
       }


        private void UpdateTiersDisplayed()
        {
            dlTier.Items.Clear();
            dlTier.Items.Add("* ALL *");

            string prof = "Cook";
            if (Session["ProfSelected"] != null)
                prof = (string)Session["ProfSelected"];

            ProfessionTierEnum tierAvail = ProfessionTierEnum.Supreme;

            switch (prof)
            {
                case "Cook":
                    tierAvail = ProfessionTier.GetTier((string)Session["CookTier"]);
                    break;
                case "Jeweler":
                    tierAvail = ProfessionTier.GetTier((string)Session["JewelerTier"]);
                    break;
                case "Metalsmith":
                    tierAvail = ProfessionTier.GetTier((string)Session["MetalsmithTier"]);
                    break;
                case "Scholar":
                    tierAvail = ProfessionTier.GetTier((string)Session["ScholarTier"]);
                    break;
                case "Tailor":
                    tierAvail = ProfessionTier.GetTier((string)Session["TailorTier"]);
                    break;
                case "Weaponsmith":
                    tierAvail = ProfessionTier.GetTier((string)Session["WeaponsmithTier"]);
                    break;
                case "Woodworker":
                    tierAvail = ProfessionTier.GetTier((string)Session["WoodworkerTier"]);
                    break;
            }

            if (tierAvail >= ProfessionTierEnum.Apprentice)
                dlTier.Items.Add("Apprentice");
            if (tierAvail >= ProfessionTierEnum.Journeyman)
                dlTier.Items.Add("Journeyman");
            if (tierAvail >= ProfessionTierEnum.Expert)
                dlTier.Items.Add("Expert");
            if (tierAvail >= ProfessionTierEnum.Artisan)
                dlTier.Items.Add("Artisan");
            if (tierAvail >= ProfessionTierEnum.Master)
                dlTier.Items.Add("Master");
            if (tierAvail >= ProfessionTierEnum.Supreme)
                dlTier.Items.Add("Supreme");
            if (tierAvail >= ProfessionTierEnum.Westfold)
                dlTier.Items.Add("Westfold");
            if (tierAvail >= ProfessionTierEnum.Eastemnet)
                dlTier.Items.Add("Eastemnet");
            if (tierAvail >= ProfessionTierEnum.Westemnet)
                dlTier.Items.Add("Westemnet");

            if (null == (Session["TierSelected"]))
                dlTier.SelectedIndex = 1;
            else
            {
                if (dlTier.Items.Contains(new ListItem((string)Session["TierSelected"])))
                    dlTier.SelectedValue = (string)Session["TierSelected"];
                else
                    dlTier.SelectedIndex = 1;
            }
            Session["TierSelected"] = dlTier.SelectedValue;
        }


        private void UpdateRecipesDisplayed()
        {
            lbRecipes.Items.Clear();

            if (null == Session["ProfSelected"])
                Session["ProfSelected"] = dlProfession.SelectedValue;
                
            var prof = (string)Session["ProfSelected"];

            int tierSelected = -1;
            if (dlTier.SelectedValue != "* ALL *")
                tierSelected = (int)ProfessionTier.GetTier(dlTier.SelectedValue);

            var recipes = (SortedDictionary<string, Ingredient>)Application["Recipes"];

            foreach (Ingredient rec in recipes.Values)
            {
                var comp = (CompositeIngredients)rec; // down-cast for tier
                if (
                    ((rec is CookIngredients) && ("Cook" == prof)) ||
                    ((rec is JewelerIngredients) && ("Jeweler" == prof)) ||
                    ((rec is MetalsmithIngredients) && ("Metalsmith" == prof)) ||
                    ((rec is ScholarCompIngredients) && ("Scholar" == prof)) ||
                    ((rec is TailorIngredients) && ("Tailor" == prof)) ||
                    ((rec is WeaponsmithIngredients) && ("Weaponsmith" == prof)) ||
                    ((rec is WoodworkerIngredients) && ("Woodworker" == prof))
                    )
                {
                    if (((tierSelected < 0) && ((int)comp.Tier < dlTier.Items.Count - 1)) || 
                        (tierSelected == (int)comp.Tier))
                            lbRecipes.Items.Add(comp.Name);
                }                
            }            
        }


        private void UpdateRecipesSelected()
        {
            // build a fast lookup of the cart
            var dtCart = (DataTable)Session["dtCart"];

            //var lst = new List<string>();
            //foreach (DataRow row in dtCart.Rows)
            //    lst.Add((string)row["Recipe"]);
            var lst = (from DataRow row in dtCart.Rows select (string) row["Recipe"]).ToList();

            // set backcolor on any selected recipes
            for (int i = 0; i < lbRecipes.Items.Count; i++)
            {
                string recName = lbRecipes.Items[i].Text;
                if (lst.Contains(recName))
                    lbRecipes.Items[i].Attributes.Add("style", "background-color: #FFFF66"); 
                else
                    lbRecipes.Items[i].Attributes.Add("style", "background-color: #FFFFFF");
            }
        }


// ReSharper disable InconsistentNaming
        protected void btnAdd_Click(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            var recipeNameSelected = lbRecipes.SelectedValue;
            if (string.IsNullOrEmpty(recipeNameSelected))
                return;

            var recs = (SortedDictionary<string, Ingredient>)Application["Recipes"];

            if (recs.ContainsKey(recipeNameSelected))
            {
                // if the recipe is already added, increment instead
                var dtCart = (DataTable)Session["dtCart"];
                var rec = (CompositeIngredients)recs[recipeNameSelected];
                int qtyToMake = Convert.ToInt32(txtQuantity.Text);

                bool bFound = false;
                foreach (DataRow row in dtCart.Rows)
                {
                    if ((string)row["Recipe"] == rec.Name)
                    {
                        row["XP"] = Convert.ToInt32(row["XP"]) * qtyToMake;
                        row["Quantity"] = Convert.ToInt32(row["Quantity"]) + qtyToMake;
                        bFound = true;
                        break;
                    }
                }

                if (!bFound)
                {
                    var rowCart = dtCart.NewRow();
                    rowCart["Recipe"] = rec.Name;
                    rowCart["Tier"] = rec.Tier;
                    rowCart["XP"] = qtyToMake * rec.CraftingExperience;
                    rowCart["Quantity"] = qtyToMake;
                    dtCart.Rows.Add(rowCart);
                    dtCart.AcceptChanges();
                }
                Session["dtCart"] = dtCart;
                BindData();
            }
            UpdateVisibleControls();
            UpdateRecipesSelected();
        }

        //protected void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    var recs = (SortedDictionary<string, Ingredient>)Application["Recipes"];

        //    if (recs.ContainsKey(lblRecipeSelected.Text))
        //    {
        //        var rec = (CompositeIngredients) recs[lblRecipeSelected.Text];
        //        SortedDictionary<string, Ingredient> subIngs = rec.GetRecipeIngredients();

        //        var dtIngs = (DataTable) ViewState["dtIngs"];
        //        dtIngs.Rows.Clear();

        //        foreach (Ingredient ing in subIngs.Values)
        //        {
        //            var rowIng = dtIngs.NewRow();
        //            rowIng["Ingredient"] = ing.Name;
        //            int qty = 1;
        //            try {
        //                if (!(String.IsNullOrEmpty(txtQuantity.Text))) qty = Convert.ToInt16(txtQuantity.Text);
        //            } catch (Exception) {}
        //            rowIng["Quantity"] = ing.QuantityRequested * qty;
        //            dtIngs.Rows.Add(rowIng);
        //            dtIngs.AcceptChanges();
        //        }
        //        ViewState["dtIngs"] = dtIngs;
        //        BindData();
        //    }
        //}

// ReSharper disable InconsistentNaming
        protected void btnConfig_Click(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            Response.Redirect("~/default.aspx");
        }

// ReSharper disable InconsistentNaming
        protected void btnIngredients_Click(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            Response.Redirect("~/Ingredients.aspx");
        }

// ReSharper disable InconsistentNaming
        protected void btnClear_Click(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            var dtCart = (DataTable)Session["dtCart"];
            dtCart.Rows.Clear();
            Session["dtCart"] = dtCart;
            BindData();
            UpdateVisibleControls();
            UpdateRecipesSelected();
        }

// ReSharper disable InconsistentNaming
        protected void GridRecipeCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
// ReSharper restore InconsistentNaming
        {
            int rowNum = e.RowIndex;
            var dtCart = (DataTable) Session["dtCart"];
            if (dtCart.Rows.Count > rowNum)
            {
                dtCart.Rows[rowNum].Delete();
                dtCart.AcceptChanges();
                Session["dtCart"] = dtCart;
                BindData();
                UpdateVisibleControls();
                UpdateRecipesSelected();
            }
        }


// ReSharper disable InconsistentNaming
        protected void dlProfession_SelectedIndexChanged(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            Session["ProfSelected"] = dlProfession.SelectedValue;

            UpdateTiersDisplayed();
            UpdateRecipesDisplayed();
            UpdateRecipesSelected();
        }

// ReSharper disable InconsistentNaming
        protected void dlTier_SelectedIndexChanged(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            Session["tierSelected"] = dlTier.SelectedValue;

            UpdateRecipesDisplayed();
            UpdateRecipesSelected();
        }

// ReSharper disable InconsistentNaming
        protected void lbRecipes_SelectedIndexChanged(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            var recipeNameSelected = lbRecipes.SelectedValue;
            if (string.IsNullOrEmpty(recipeNameSelected))
                return;

            var recs = (SortedDictionary<string, Ingredient>)Application["Recipes"];

            if (recs.ContainsKey(recipeNameSelected))
            {
                lblIngTitle.Visible = true;
                btnAdd.Enabled = true;
                // btnUpdate.Enabled = true;

                var rec = (CompositeIngredients)recs[recipeNameSelected];

                lblRecipeSelected.Text = rec.Name;
                txtQuantity.Text = rec.QuantityRequested.ToString();
                lblQtyProduced.Text = rec.QuantityProduced.ToString();

                SortedDictionary<string, Ingredient> subIngs = rec.GetRecipeIngredients();

                var dtIngs = (DataTable)ViewState["dtIngs"];
                dtIngs.Rows.Clear();

                foreach (Ingredient ing in subIngs.Values)
                {
                    var rowIng = dtIngs.NewRow();
                    rowIng["Ingredient"] = ing.Name;
                    rowIng["Quantity"] = ing.QuantityRequested;
                    dtIngs.Rows.Add(rowIng);
                    dtIngs.AcceptChanges();
                }
                ViewState["dtIngs"] = dtIngs;
                BindData();
            }
            else
            {
                btnAdd.Enabled = false;
                //btnUpdate.Enabled = false;
                lblRecipeSelected.Text = "Select a recipe to view the top-level ingredients";
                var dtIngs = (DataTable)ViewState["dtIngs"];
                dtIngs.Rows.Clear();
                ViewState["dtIngs"] = dtIngs;
                BindData();
            }
            UpdateVisibleControls();
            UpdateRecipesSelected();
        }
    }
}
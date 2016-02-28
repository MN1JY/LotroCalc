using System;
using System.Collections.Generic;
using System.Data;
using LotroCalc.RecipeData.Ingredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Weaponsmith;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.GatheringProfessions;
using LotroCalc.RecipeData.Ingredients.SimpleIngredients.Purchased;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc
{
    public partial class Ingredients : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (null == Session["Cook"])
            {
                Response.Redirect("~/default.aspx");
                return;
            }

            if (Page.IsPostBack) return;

            var dtCart = (DataTable)Session["dtCart"];
            if (null == dtCart)
            {
                dtCart = new DataTable();
                dtCart.Columns.Add("Recipe", typeof(string));
                dtCart.Columns.Add("Tier", typeof(string));
                dtCart.Columns.Add("Quantity", typeof(string));
                Session.Add("dtCart", dtCart);
            }

            var recsAll = (SortedDictionary<string, Ingredient>)Application["Recipes"];
            //var ingsAll = (SortedDictionary<string, Ingredient>)Application["Ingredients"];
            //var ds = new DataSet1();

            //var dt = ds.dtRecipe;

            long supplierTotal = 0;

            var dtRecipesUnsorted = new DataSet1.dtRecipeDataTable();
            var dtIngCraftedUnsorted = new DataSet1.dtIngCraftedDataTable();
            var dtIngGatheredUnsorted = new DataSet1.dtIngGatheredDataTable();
            var dtIngSupplierUnsorted = new DataSet1.dtIngSupplierDataTable();
            var dtCraftingXp = new DataSet1.dtCraftingXPDataTable();

            for (int i = 0; i < 9; i++)
            {
                // ProfessionTierEnum.Apprentice
                var dtCraftingXpRow = dtCraftingXp.NewdtCraftingXPRow();
                dtCraftingXpRow.Tier = ProfessionTier.FormatTier((ProfessionTierEnum)i);
                dtCraftingXpRow.Cook = 0;
                dtCraftingXpRow.Forester = 0;
                dtCraftingXpRow.Jeweler = 0;
                dtCraftingXpRow.Metalsmith = 0;
                dtCraftingXpRow.Prospector = 0;
                dtCraftingXpRow.Scholar = 0;
                dtCraftingXpRow.Tailor = 0;
                dtCraftingXpRow.Weaponsmith = 0;
                dtCraftingXpRow.Woodworker = 0;
                dtCraftingXp.Rows.Add(dtCraftingXpRow);                
            }

            foreach (DataRow dtRow in dtCart.Rows)
            {
                var recipeName = (string)dtRow["Recipe"];
                //string Tier = (string)dtRow["Tier"];
                var quantity = (string)dtRow["Quantity"];
                int quantityToMake = 1;
                try { quantityToMake = Convert.ToInt16(quantity); }
// ReSharper disable EmptyGeneralCatchClause
                catch { }
// ReSharper restore EmptyGeneralCatchClause

                var rec = (CompositeIngredients)recsAll[recipeName];
                rec.QuantityRequested = quantityToMake;

                AddRecipeToOutput(rec, ref supplierTotal,
                    ref dtRecipesUnsorted, ref dtIngCraftedUnsorted, ref dtIngGatheredUnsorted, ref dtIngSupplierUnsorted, ref dtCraftingXp);
            }

            DataSet1.dtRecipeDataTable dtRecipes = DataSetHelpers.SortRecipeDataTable(dtRecipesUnsorted);
            DataSet1.dtIngCraftedDataTable dtIngCrafted = DataSetHelpers.SortCraftedIngDataTable(dtIngCraftedUnsorted);
            DataSet1.dtIngGatheredDataTable dtIngGathered = DataSetHelpers.SortGatheredIngDataTable(dtIngGatheredUnsorted);
            DataSet1.dtIngSupplierDataTable dtIngSupplier = DataSetHelpers.SortSupplierIngDataTable(dtIngSupplierUnsorted);

            var dtSupplierCost = new DataSet1.dtSupplierTotalDataTable();
            var dtSupplierRow = dtSupplierCost.NewdtSupplierTotalRow();
            dtSupplierRow.TotalCost = FormatCost(supplierTotal);
            dtSupplierCost.AdddtSupplierTotalRow(dtSupplierRow);

            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1_dtRecipe", (DataTable)dtRecipes));
            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1_dtIngCrafted", (DataTable)dtIngCrafted));
            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1_dtIngGathered", (DataTable)dtIngGathered));
            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1_dtIngSupplier", (DataTable)dtIngSupplier));
            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1_dtSupplierCost", (DataTable)dtSupplierCost));
            ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1_dtCraftingXP", (DataTable)dtCraftingXp));

            ReportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            ReportViewer1.LocalReport.Refresh();
        }


        private void AddRecipeToOutput(CompositeIngredients rec, ref long supplierTotal,
            ref DataSet1.dtRecipeDataTable dtRecipes,
            ref DataSet1.dtIngCraftedDataTable dtIngCrafted,
            ref DataSet1.dtIngGatheredDataTable dtIngGathered,
            ref DataSet1.dtIngSupplierDataTable dtIngSupplier,
            ref DataSet1.dtCraftingXPDataTable dtCraftingXp)
        {
            bool bFound = false;

            // if already added, then sum, else create
            foreach (DataSet1.dtRecipeRow row in dtRecipes.Rows)
            {
                if (row.RecipeName == rec.Name)
                {
                    row.Quantity = Convert.ToString(Convert.ToInt32(row.Quantity) + rec.QuantityRequested);
                    bFound = true;
                    break;
                }
            }
            if (!bFound)
            {
                DataSet1.dtRecipeRow dtRow = dtRecipes.NewdtRecipeRow();
                dtRow.Quantity = rec.QuantityRequested.ToString();
                dtRow.Profession = GetProfession(rec);
                dtRow.RecipeName = rec.Name;
                dtRow.Tier = ProfessionTier.FormatTier(rec.Tier);
                dtRow.Facility = GetFacility(rec);
                dtRecipes.AdddtRecipeRow(dtRow);
            }
            addCraftingXp(rec, ref dtCraftingXp);

            // breakdown the ingredients
            foreach (Ingredient subIng in rec.GetRecipeIngredients().Values)
            {
                if (subIng is CompositeIngredients)
                {
                    var newIng = (CompositeIngredients)subIng;
                    AddComponentToOutput(newIng, ref supplierTotal, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
                }
                else
                {
                    AddSimpleToOutput(subIng, ref supplierTotal, ref dtIngGathered, ref dtIngSupplier);
                }
            }
        }


        private void AddComponentToOutput(CompositeIngredients compIng, ref long supplierTotal,
            ref DataSet1.dtIngCraftedDataTable dtIngCrafted,
            ref DataSet1.dtIngGatheredDataTable dtIngGathered,
            ref DataSet1.dtIngSupplierDataTable dtIngSupplier,
            ref DataSet1.dtCraftingXPDataTable dtCraftingXp)
        {
            bool bFound = false;

            foreach (DataSet1.dtIngCraftedRow row in dtIngCrafted.Rows)
            {
                if (row.IngredientName == compIng.Name)
                {
                    row.Quantity = Convert.ToString(Convert.ToInt32(row.Quantity) + Convert.ToInt32(compIng.QuantityRequested));
                    bFound = true;
                    break;
                }
            }
            if (!bFound)
            {
                DataSet1.dtIngCraftedRow dtRow = dtIngCrafted.NewdtIngCraftedRow();
                dtRow.Quantity = compIng.QuantityRequested.ToString();
                dtRow.Profession = GetProfession(compIng);
                dtRow.IngredientName = compIng.Name;
                dtRow.Tier = ProfessionTier.FormatTier(compIng.Tier);
                dtRow.Facility = GetFacility(compIng);
                dtIngCrafted.AdddtIngCraftedRow(dtRow);
            }
            addCraftingXp(compIng, ref dtCraftingXp);

            if (compIng is CookIngredients)
            {
                var hasProfession = (bool)Session["Cook"];
                var tierAvail = ProfessionTier.GetTier((string)Session["CookTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);

            }
            else if (compIng is ForesterCompIngredients)
            {
                var hasProfession = (bool)Session["Forester"];
                var tierAvail = ProfessionTier.GetTier((string)Session["ForesterTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
            }
            else if (compIng is JewelerIngredients)
            {
                var hasProfession = (bool)Session["Jeweler"];
                var tierAvail = ProfessionTier.GetTier((string)Session["JewelerTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
            }
            else if (compIng is MetalsmithIngredients)
            {
                var hasProfession = (bool)Session["Metalsmith"];
                var tierAvail = ProfessionTier.GetTier((string)Session["MetalsmithTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
            }
            else if (compIng is ProspectorCompIngredients)
            {
                var hasProfession = (bool)Session["Prospector"];
                var tierAvail = ProfessionTier.GetTier((string)Session["ProspectorTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
            }
            else if (compIng is ScholarCompIngredients)
            {
                var hasProfession = (bool)Session["Scholar"];
                var tierAvail = ProfessionTier.GetTier((string)Session["ScholarTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
            }
            else if (compIng is TailorIngredients)
            {
                var hasProfession = (bool)Session["Tailor"];
                var tierAvail = ProfessionTier.GetTier((string)Session["TailorTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
            }
            else if (compIng is WeaponsmithIngredients)
            {
                var hasProfession = (bool)Session["Weaponsmith"];
                var tierAvail = ProfessionTier.GetTier((string)Session["WeaponsmithTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
            }
            else if (compIng is WoodworkerIngredients)
            {
                var hasProfession = (bool)Session["Woodworker"];
                var tierAvail = ProfessionTier.GetTier((string)Session["WoodworkerTier"]);
                Deconstruct(hasProfession, tierAvail, ref supplierTotal,
                    compIng, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
            }
        }


        private void Deconstruct(bool hasProfession, ProfessionTierEnum tierAvail, ref long supplierTotal,
            CompositeIngredients compIng,
            ref DataSet1.dtIngCraftedDataTable dtIngCrafted,
            ref DataSet1.dtIngGatheredDataTable dtIngGathered,
            ref DataSet1.dtIngSupplierDataTable dtIngSupplier,
            ref DataSet1.dtCraftingXPDataTable dtCraftingXp)
        {
            if (hasProfession && (tierAvail >= compIng.Tier)) // decompose
            {
                foreach (Ingredient ing in compIng.GetRecipeIngredients().Values)
                {
                    if (ing is CompositeIngredients)
                    {
                        var newIng = (CompositeIngredients)ing;
                        AddComponentToOutput(newIng, ref supplierTotal, ref dtIngCrafted, ref dtIngGathered, ref dtIngSupplier, ref dtCraftingXp);
                    }
                    else
                    {
                        AddSimpleToOutput(ing, ref supplierTotal, ref dtIngGathered, ref dtIngSupplier);
                    }
                }
            }
            // else do nothing. this composite ing was added by caller.
        }


        private void AddSimpleToOutput(Ingredient ing, ref long supplierTotal,
            ref DataSet1.dtIngGatheredDataTable dtIngGathered,
            ref DataSet1.dtIngSupplierDataTable dtIngSupplier)
        {
            bool bFound = false;

            if ((ing is SupplierIngredients) || (ing is TraderIngredients))
            {
                long cost = 0;
                if (ing is SupplierIngredients)
                {
                    var supIng = (SupplierIngredients) ing;
                    cost = supIng.EstimatedCost;
                }
                foreach (DataSet1.dtIngSupplierRow row in dtIngSupplier.Rows)
                {
                    if (row.IngredientName == ing.Name)
                    {
                        int oldQuantity = Convert.ToInt32(row.Quantity);
                        row.Quantity = Convert.ToString(oldQuantity + ing.QuantityRequested);
                        supplierTotal += (cost * ing.QuantityRequested);
                        bFound = true;
                        break;
                    }
                }
                if (!bFound)
                {
                    DataSet1.dtIngSupplierRow dtRow = dtIngSupplier.NewdtIngSupplierRow();
                    dtRow.Quantity = ing.QuantityRequested.ToString();
                    dtRow.IngredientName = ing.Name;
                    dtRow.SupplierType = ing.FormatIngredientType();
                    if (cost > 0)
                    {
                        dtRow.Price = cost.ToString();
                        supplierTotal += (cost * ing.QuantityRequested);
                    }
                    else
                        dtRow.Price = "0";

                    dtIngSupplier.AdddtIngSupplierRow(dtRow);
                }                   
            }
            else //  gathered
            {
                var simpIng = (SimpleIngredients) ing;
                foreach (DataSet1.dtIngGatheredRow row in dtIngGathered.Rows)
                {
                    if (row.IngredientName == ing.Name)
                    {
                        row.Quantity = Convert.ToString(Convert.ToInt32(row.Quantity) + Convert.ToInt32(ing.QuantityRequested));
                        bFound = true;
                        break;
                    }
                }
                if (!bFound)
                {
                    DataSet1.dtIngGatheredRow dtRow = dtIngGathered.NewdtIngGatheredRow();
                    dtRow.Quantity = ing.QuantityRequested.ToString();
                    dtRow.IngredientName = ing.Name;
                    dtRow.Tier = ProfessionTier.FormatTier(simpIng.Tier);
                    if (ing is FarmedIngredients)
                        dtRow.Profession = "Farming";
                    else if (ing is ForesterIngredients)
                        dtRow.Profession = "Forester";
                    else if (ing is PickedIngredients)
                        dtRow.Profession = "Picked";
                    else if (ing is FishingIngredients)
                        dtRow.Profession = "Fishing";
                    else if (ing is MobDropIngredients)
                        dtRow.Profession = "Mob Drop";
                    else if (ing is ProspectorIngredients)
                        dtRow.Profession = "Prospector";
                    else if (ing is ScholarIngredients)
                        dtRow.Profession = "Scholar";

                    dtIngGathered.AdddtIngGatheredRow(dtRow);
                }
            }
        }

        private static string FormatCost(long copperCoins)
        {
            long gold = 0;
            long silver = 0;
            long remainder = copperCoins;

// ReSharper disable PossibleLossOfFraction
            double dGold = remainder / (1000 * 100);
            double modGold = (remainder % (1000 * 100)) / (1000 * 100);
            if (dGold >= 1)
            {
                gold = Convert.ToInt32(dGold - modGold);
                remainder = remainder - (gold * (1000 * 100));
            }

            double dSilver = remainder / 100;
            double modSilver = (remainder % 100) / 100;
            if (dSilver >= 1)
            {
                silver = Convert.ToInt32(dSilver - modSilver);
                remainder = remainder - (silver * 100);
            }

            string ret;
            if (gold > 0)
            {
                ret = gold + "g. " + silver + "s. " + remainder + "c.";
            }
            else if (silver > 0)
            {
                ret = silver + "s. " + remainder + "c.";
            }
            else
            {
                ret = remainder + "c.";
            }
// ReSharper restore PossibleLossOfFraction
            return ret;
        }


        private void addCraftingXp(Ingredient ing, ref DataSet1.dtCraftingXPDataTable dtCraftingXp)
        {
            if (!(ing is CompositeIngredients))
                return;

            if (ing is CookIngredients)
            {
                var compIng = (CookIngredients)ing;                           
                var hasProfession = (bool)Session["Cook"];
                var tierAvail = ProfessionTier.GetTier((string)Session["CookTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Cook += xp;
                }
            }
            else if (ing is JewelerIngredients)
            {
                var compIng = (JewelerIngredients)ing;
                var hasProfession = (bool)Session["Jeweler"];
                var tierAvail = ProfessionTier.GetTier((string)Session["JewelerTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Jeweler += xp;
                }
            }
            else if (ing is ForesterCompIngredients)
            {
                var compIng = (ForesterCompIngredients)ing;
                var hasProfession = (bool)Session["Forester"];
                var tierAvail = ProfessionTier.GetTier((string)Session["ForesterTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Forester += xp;
                }
            }
            else if (ing is MetalsmithIngredients)
            {
                var compIng = (MetalsmithIngredients)ing;
                var hasProfession = (bool)Session["Metalsmith"];
                var tierAvail = ProfessionTier.GetTier((string)Session["MetalsmithTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Metalsmith += xp;
                }
            }
            else if (ing is ProspectorCompIngredients)
            {
                var compIng = (ProspectorCompIngredients)ing;
                var hasProfession = (bool)Session["Prospector"];
                var tierAvail = ProfessionTier.GetTier((string)Session["ProspectorTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Prospector += xp;
                }
            }
            else if (ing is ScholarCompIngredients)
            {
                var compIng = (ScholarCompIngredients)ing;
                var hasProfession = (bool)Session["Scholar"];
                var tierAvail = ProfessionTier.GetTier((string)Session["ScholarTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Scholar += xp;
                }
            }
            else if (ing is TailorIngredients)
            {
                var compIng = (TailorIngredients)ing;
                var hasProfession = (bool)Session["Tailor"];
                var tierAvail = ProfessionTier.GetTier((string)Session["TailorTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Tailor += xp;
                }
            }
            else if (ing is WeaponsmithIngredients)
            {
                var compIng = (WeaponsmithIngredients)ing;
                var hasProfession = (bool)Session["Weaponsmith"];
                var tierAvail = ProfessionTier.GetTier((string)Session["WeaponsmithTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Weaponsmith += xp;
                }
            }
            else if (ing is WoodworkerIngredients)
            {
                var compIng = (WoodworkerIngredients)ing;
                var hasProfession = (bool)Session["Woodworker"];
                var tierAvail = ProfessionTier.GetTier((string)Session["WoodworkerTier"]);
                if (hasProfession && (tierAvail >= compIng.Tier)) // deconstructing so add xp
                {
                    var xp = compIng.CraftingExperience * ing.QuantityRequested;
                    var tier = (int)compIng.Tier;
                    ((DataSet1.dtCraftingXPRow)dtCraftingXp.Rows[tier]).Woodworker += xp;
                }
            }
        }

        private static string GetProfession(Ingredient ing)
        {
            if (ing is CookIngredients)
                return "Cooking";
            if (ing is ForesterCompIngredients)
                return "Forester";
            if (ing is ForesterIngredients)
                return "Forester";
            if (ing is JewelerIngredients)
                return "Jeweler";
            if (ing is MetalsmithIngredients)
                return "Metalsmith";
            if (ing is ProspectorCompIngredients)
                return "Prospector";
            if (ing is ProspectorIngredients)
                return "Prospector";
            if (ing is ScholarCompIngredients)
                return "Scholar";
            if (ing is TailorIngredients)
                return "Tailor";
            if (ing is WeaponsmithIngredients)
                return "Weaponsmith";
            if (ing is WoodworkerIngredients)
                return "Woodworker";
            return "";
        }

        private static string GetFacility(Ingredient ing)
        {
            if (ing is CookIngredients)
            {
                var rec = (CookIngredients)ing;
                if (rec.SuperiorOvenRequired)
                    return "SuperiorOven";
                if (rec.OvenRequired)
                    return "Oven";
                if (rec.CampFireRequired)
                    return "Campfire";

            }
            else if (ing is ForesterCompIngredients)
            {
                var rec = (ForesterCompIngredients)ing;
                if (rec.SuperiorWorkbenchRequired)
                    return "Superior Workbench";
                if (rec.WorkbenchRequired)
                    return "Workbench";
            }
            else if (ing is JewelerIngredients) 
            {
                var rec = (JewelerIngredients)ing;
                if (rec.SuperiorWorkbenchRequired)
                    return "Superior Workbench";
                if (rec.WorkbenchRequired)
                    return "Workbench";
            }
            else if (ing is MetalsmithIngredients)
            {
                var rec = (MetalsmithIngredients)ing;
                if (rec.SuperiorForgeRequired)
                    return "Superior Forge";
                if (rec.ForgeRequired)
                    return "Forge";
            }
            else if (ing is ProspectorCompIngredients)
            {
                var rec = (ProspectorCompIngredients)ing;
                if (rec.SuperiorForgeRequired)
                    return "Superior Forge";
                if (rec.ForgeRequired)
                    return "Forge";
            }
            else if (ing is ScholarCompIngredients)
            {
                var rec = (ScholarCompIngredients)ing;
                if (rec.SuperiorStudyRequired)
                    return "Superior Study";
                if (rec.StudyRequired)
                    return "Study";
            }  
            else if (ing is TailorIngredients)
            {
                var rec = (TailorIngredients)ing;
                if (rec.SuperiorWorkbenchRequired)
                    return "Superior Workbench";
                if (rec.WorkbenchRequired)
                    return "Workbench";
            }
            else if (ing is WeaponsmithIngredients)
            {
                var rec = (WeaponsmithIngredients)ing;
                if (rec.SuperiorForgeRequired)
                    return "Superior Forge";
                if (rec.ForgeRequired)
                    return "Forge";
            }         
            else if (ing is WoodworkerIngredients)
            {
                var rec = (WoodworkerIngredients)ing;
                if (rec.SuperiorWorkbenchRequired)
                    return "Superior Workbench";
                if (rec.WorkbenchRequired)
                    return "Workbench";
            }
            return "";
        }


        //private void AddCraftedIngredient(ref DataSet1.dtIngCraftedDataTable dtCraftedIngs, CompositeIngredients ing, string profession, ProfessionTierEnum tier, string facility)
        //{
        //    bool bFound = false;

        //    foreach (DataSet1.dtIngCraftedRow row in dtCraftedIngs.Rows)
        //    {
        //        if (row.IngredName == ing.Name)
        //        {
        //            row.Quantity = Convert.ToString(Convert.ToInt32(row.Quantity) + Convert.ToInt32(ing.QuantityRequested));
        //            bFound = true;
        //            break;
        //        }
        //    }
        //    if (!bFound)
        //    {
        //        DataSet1.dtIngCraftedRow dtRow = null;
        //        dtRow = dtCraftedIngs.NewdtIngCraftedRow();
        //        dtRow.Quantity = ing.QuantityRequested.ToString();
        //        dtRow.Profession = profession;
        //        dtRow.IngredName = ing.Name;
        //        dtRow.Tier = ProfessionTier.FormatTier(tier);
        //        dtRow.Facility = facility;
        //        dtCraftedIngs.AdddtIngCraftedRow(dtRow);
        //    }
        //}

        protected void BtnRecipesClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Recipes.aspx");
        }
    }
}
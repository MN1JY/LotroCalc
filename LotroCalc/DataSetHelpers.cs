using System.Collections.Generic;

namespace LotroCalc
{
    public class DataSetHelpers
    {

        public static DataSet1.dtRecipeDataTable SortRecipeDataTable(DataSet1.dtRecipeDataTable dtRecipesIn)
        {
            var sDict = new SortedDictionary<string, DataSet1.dtRecipeRow>();

            foreach (DataSet1.dtRecipeRow row in dtRecipesIn.Rows)
            {
                sDict.Add(row.RecipeName, row);
            }

            var dtRecipesOut = new DataSet1.dtRecipeDataTable();
            foreach (DataSet1.dtRecipeRow row in sDict.Values)
            {
                DataSet1.dtRecipeRow newRow = dtRecipesOut.NewdtRecipeRow();
                newRow.Facility = row.Facility;
                newRow.Profession = row.Profession;
                newRow.Quantity = row.Quantity;
                newRow.RecipeName = row.RecipeName;
                newRow.Tier = row.Tier;
                dtRecipesOut.AdddtRecipeRow(newRow);
            }

            return dtRecipesOut;
        }


        public static DataSet1.dtIngCraftedDataTable SortCraftedIngDataTable(DataSet1.dtIngCraftedDataTable dtIngredsIn)
        {
            var sDict = new SortedDictionary<string, DataSet1.dtIngCraftedRow>();

            foreach (DataSet1.dtIngCraftedRow row in dtIngredsIn.Rows)
            {
                sDict.Add(row.IngredientName, row);
            }

            var dtIngredsOut = new DataSet1.dtIngCraftedDataTable();
            foreach (DataSet1.dtIngCraftedRow row in sDict.Values)
            {
                DataSet1.dtIngCraftedRow newRow = dtIngredsOut.NewdtIngCraftedRow();
                newRow.Facility = row.Facility;
                newRow.Profession = row.Profession;
                newRow.Quantity = row.Quantity;
                newRow.IngredientName = row.IngredientName;
                newRow.Tier = row.Tier;
                dtIngredsOut.AdddtIngCraftedRow(newRow);
            }

            return dtIngredsOut;
        }


        public static DataSet1.dtIngGatheredDataTable SortGatheredIngDataTable(DataSet1.dtIngGatheredDataTable dtIngredsIn)
        {
            var sDict = new SortedDictionary<string, DataSet1.dtIngGatheredRow>();

            foreach (DataSet1.dtIngGatheredRow row in dtIngredsIn.Rows)
            {
                sDict.Add(row.IngredientName, row);
            }

            var dtIngredsOut = new DataSet1.dtIngGatheredDataTable();
            foreach (DataSet1.dtIngGatheredRow row in sDict.Values)
            {
                DataSet1.dtIngGatheredRow newRow = dtIngredsOut.NewdtIngGatheredRow();
                newRow.Profession = row.Profession;
                newRow.Quantity = row.Quantity;
                newRow.IngredientName = row.IngredientName;
                newRow.Tier = row.Tier;
                dtIngredsOut.AdddtIngGatheredRow(newRow);
            }

            return dtIngredsOut;
        }


        public static DataSet1.dtIngSupplierDataTable SortSupplierIngDataTable(DataSet1.dtIngSupplierDataTable dtIngredsIn)
        {
            var sDict = new SortedDictionary<string, DataSet1.dtIngSupplierRow>();

            foreach (DataSet1.dtIngSupplierRow row in dtIngredsIn.Rows)
            {
                sDict.Add(row.IngredientName, row);
            }

            var dtIngredsOut = new DataSet1.dtIngSupplierDataTable();
            foreach (DataSet1.dtIngSupplierRow row in sDict.Values)
            {
                DataSet1.dtIngSupplierRow newRow = dtIngredsOut.NewdtIngSupplierRow();
                newRow.Quantity = row.Quantity;
                newRow.IngredientName = row.IngredientName;
                newRow.SupplierType = row.SupplierType;
                newRow.Price = row.Price;
                dtIngredsOut.AdddtIngSupplierRow(newRow);
            }

            return dtIngredsOut;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LotroCalc
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;

            // full page load
            GetCookie();

            if (null == Session["Cook"]) Session["Cook"] = true; else chkCook.Checked = (bool)Session["Cook"];
            if (null == Session["Jeweler"]) Session["Jeweler"] = true; else chkJeweler.Checked = (bool)Session["Jeweler"];
            if (null == Session["Metalsmith"]) Session["Metalsmith"] = true; else chkMetalsmith.Checked = (bool)Session["Metalsmith"];
            if (null == Session["Scholar"]) Session["Scholar"] = true; else chkScholar.Checked = (bool)Session["Scholar"];
            if (null == Session["Tailor"]) Session["Tailor"] = true; else chkTailor.Checked = (bool)Session["Tailor"];
            if (null == Session["Weaponsmith"]) Session["Weaponsmith"] = true; else chkWeaponsmith.Checked = (bool)Session["Weaponsmith"];
            if (null == Session["Woodworker"]) Session["Woodworker"] = true; else chkWoodworker.Checked = (bool)Session["Woodworker"];
            if (null == Session["Forester"]) Session["Forester"] = true; else chkForester.Checked = (bool)Session["Forester"];
            if (null == Session["Prospector"]) Session["Prospector"] = true; else chkProspector.Checked = (bool)Session["Prospector"];

            if (Session["CookTier"] != null) dlCook.SelectedValue = (string) Session["CookTier"]; else Session["CookTier"] = dlCook.SelectedValue;
            if (Session["JewelerTier"] != null) dlJeweler.SelectedValue = (string)Session["JewelerTier"]; else Session["JewelerTier"] = dlJeweler.SelectedValue;
            if (Session["MetalsmithTier"] != null) dlMetalsmith.SelectedValue = (string)Session["MetalsmithTier"]; else Session["MetalsmithTier"] = dlMetalsmith.SelectedValue;
            if (Session["ScholarTier"] != null) dlScholar.SelectedValue = (string)Session["ScholarTier"]; else Session["ScholarTier"] = dlScholar.SelectedValue;
            if (Session["TailorTier"] != null) dlTailor.SelectedValue = (string)Session["TailorTier"]; else Session["TailorTier"] = dlTailor.SelectedValue;
            if (Session["WeaponsmithTier"] != null) dlWeaponsmith.SelectedValue = (string)Session["WeaponsmithTier"]; else Session["WeaponsmithTier"] = dlWeaponsmith.SelectedValue;
            if (Session["WoodworkerTier"] != null) dlWoodworker.SelectedValue = (string)Session["WoodworkerTier"]; else Session["WoodworkerTier"] = dlWoodworker.SelectedValue;
            if (Session["ForesterTier"] != null) dlForester.SelectedValue = (string)Session["ForesterTier"]; else Session["ForesterTier"] = dlForester.SelectedValue;
            if (Session["ProspectorTier"] != null) dlProspector.SelectedValue = (string)Session["ProspectorTier"]; else Session["ProspectorTier"] = dlProspector.SelectedValue;

            dlCook.Enabled = chkCook.Checked;
            dlJeweler.Enabled = chkJeweler.Checked;
            dlMetalsmith.Enabled = chkMetalsmith.Checked;
            dlScholar.Enabled = chkScholar.Checked;
            dlTailor.Enabled = chkTailor.Checked;
            dlWeaponsmith.Enabled = chkWeaponsmith.Checked;
            dlWoodworker.Enabled = chkWoodworker.Checked;
            dlForester.Enabled = chkForester.Checked;
            dlProspector.Enabled = chkProspector.Checked;
        }

        private void GetCookie()
        {
            HttpCookie c = Request.Cookies["LotroCalc"];
            if (c != null)
            {
                if (0 == c.Values.Count) return;

                try
                {
                    Session["Cook"] = Convert.ToBoolean(c.Values["Cook"]);
                    Session["Jeweler"] = Convert.ToBoolean(c.Values["Jeweler"]);
                    Session["Metalsmith"] = Convert.ToBoolean(c.Values["Metalsmith"]);
                    Session["Scholar"] = Convert.ToBoolean(c.Values["Scholar"]);
                    Session["Tailor"] = Convert.ToBoolean(c.Values["Tailor"]);
                    Session["Weaponsmith"] = Convert.ToBoolean(c.Values["Weaponsmith"]);
                    Session["Woodworker"] = Convert.ToBoolean(c.Values["Woodworker"]);
                    Session["Forester"] = Convert.ToBoolean(c.Values["Forester"]);
                    Session["Prospector"] = Convert.ToBoolean(c.Values["Prospector"]);
                }
// ReSharper disable EmptyGeneralCatchClause
                catch (Exception)
// ReSharper restore EmptyGeneralCatchClause
                {
                }

                Session["CookTier"] = c.Values["CookTier"];
                Session["JewelerTier"] = c.Values["JewelerTier"];
                Session["MetalsmithTier"] = c.Values["MetalsmithTier"];
                Session["ScholarTier"] = c.Values["ScholarTier"];
                Session["TailorTier"] = c.Values["TailorTier"];
                Session["WeaponsmithTier"] = c.Values["WeaponsmithTier"];
                Session["WoodworkerTier"] = c.Values["WoodworkerTier"];
                Session["ForesterTier"] = c.Values["ForesterTier"];
                Session["ProspectorTier"] = c.Values["ProspectorTier"];
            }
        }

        private void SetCookie()
        {
            var c = new HttpCookie("LotroCalc") {Expires = DateTime.Now.AddDays(30)};

            c.Values["Cook"] = chkCook.Checked.ToString();
            c.Values["Jeweler"] = chkJeweler.Checked.ToString();
            c.Values["Metalsmith"] = chkMetalsmith.Checked.ToString();
            c.Values["Scholar"] = chkScholar.Checked.ToString();
            c.Values["Tailor"] = chkTailor.Checked.ToString();
            c.Values["Weaponsmith"] = chkWeaponsmith.Checked.ToString();
            c.Values["Woodworker"] = chkWoodworker.Checked.ToString();
            c.Values["Forester"] = chkForester.Checked.ToString();
            c.Values["Prospector"] = chkProspector.Checked.ToString();

            c.Values["CookTier"] = dlCook.SelectedValue;
            c.Values["JewelerTier"] = dlJeweler.SelectedValue;
            c.Values["MetalsmithTier"] = dlMetalsmith.SelectedValue;
            c.Values["ScholarTier"] = dlScholar.SelectedValue;
            c.Values["TailorTier"] = dlTailor.SelectedValue;
            c.Values["WeaponsmithTier"] = dlWeaponsmith.SelectedValue;
            c.Values["WoodworkerTier"] = dlWoodworker.SelectedValue;
            c.Values["ForesterTier"] = dlForester.SelectedValue;
            c.Values["ProspectorTier"] = dlCook.SelectedValue;

            Response.Cookies.Add(c);
        }

        protected void chkCook_CheckedChanged(object sender, EventArgs e)
        {
            Session["Cook"] = chkCook.Checked;
            dlCook.Enabled = chkCook.Checked;
            SetCookie();
        }

        protected void chkJeweler_CheckedChanged(object sender, EventArgs e)
        {
            Session["Jeweler"] = chkJeweler.Checked;
            dlJeweler.Enabled = chkJeweler.Checked;
            SetCookie();
        }

        protected void chkMetalsmith_CheckedChanged(object sender, EventArgs e)
        {
            Session["Metalsmith"] = chkMetalsmith.Checked;
            dlMetalsmith.Enabled = chkMetalsmith.Checked;
            SetCookie();
        }

        protected void chkScholar_CheckedChanged(object sender, EventArgs e)
        {
            Session["Scholar"] = chkScholar.Checked;
            dlScholar.Enabled = chkScholar.Checked;
            SetCookie();
        }

        protected void chkTailor_CheckedChanged(object sender, EventArgs e)
        {
            Session["Tailor"] = chkTailor.Checked;
            dlTailor.Enabled = chkTailor.Checked;
            SetCookie();
        }

        protected void chkWeaponsmith_CheckedChanged(object sender, EventArgs e)
        {
            Session["Weaponsmith"] = chkWeaponsmith.Checked;
            dlWeaponsmith.Enabled = chkWeaponsmith.Checked;
            SetCookie();
        }

        protected void chkWoodworker_CheckedChanged(object sender, EventArgs e)
        {
            Session["Woodworker"] = chkWoodworker.Checked;
            dlWoodworker.Enabled = chkWoodworker.Checked;
            SetCookie();
        }

        protected void chkForester_CheckedChanged(object sender, EventArgs e)
        {
            Session["Forester"] = chkForester.Checked;
            dlForester.Enabled = chkForester.Checked;
            SetCookie();
        }

        protected void chkProspector_CheckedChanged(object sender, EventArgs e)
        {
            Session["Prospector"] = chkProspector.Checked;
            dlProspector.Enabled = chkProspector.Checked;
            SetCookie();
        }

        protected void dlCook_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["CookTier"] = dlCook.SelectedValue;
            SetCookie();
        }

        protected void dlJeweler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["JewelerTier"] = dlJeweler.SelectedValue;
            SetCookie();
        }

        protected void dlMetalsmith_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["MetalsmithTier"] = dlMetalsmith.SelectedValue;
            SetCookie();
        }

        protected void dlScholar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["ScholarTier"] = dlScholar.SelectedValue;
            SetCookie();
        }

        protected void dlTailor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["TailorTier"] = dlTailor.SelectedValue;
            SetCookie();
        }

        protected void dlWeaponsmith_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["WeaponsmithTier"] = dlWeaponsmith.SelectedValue;
            SetCookie();
        }

        protected void dlWoodworker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["WoodworkerTier"] = dlWoodworker.SelectedValue;
            SetCookie();
        }

        protected void dlForester_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["ForesterTier"] = dlForester.SelectedValue;
            SetCookie();
        }

        protected void dlProspector_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["ProspectorTier"] = dlProspector.SelectedValue;
            SetCookie();
        }

        protected void btnRecipes_Click(object sender, EventArgs e)
        {
            //SetCookie();
            Response.Redirect("~/Recipes.aspx");
        }
    }
}

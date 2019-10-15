using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Globalization;

/// <summary>
/// Summary description for BasePage
/// </summary>
public class BasePage : System.Web.UI.Page
{
    public BasePage()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    protected override void InitializeCulture()
    {
        string language = "en-us";

        //Detect User's Language.
        if (Request.UserLanguages != null)
        {
            //Set the Language.
            language = Request.UserLanguages[0];
        }

        //Check if PostBack is caused by Language DropDownList.
        if (Request.Form["__EVENTTARGET"] != null && Request.Form["__EVENTTARGET"].Contains("ddlLanguages"))
        {
            //Set the Language.
            language = Request.Form[Request.Form["__EVENTTARGET"]];
        }

        //Set the Culture.
        Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void check(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                famname.Text = "Data Validated successfully, saving..";
                famname.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                famname.Text = "Validation Failed, not saving..";
                famname.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
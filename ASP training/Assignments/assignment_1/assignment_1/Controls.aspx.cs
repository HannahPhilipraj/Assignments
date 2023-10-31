using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment_1
{
    public partial class Controls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Images.ImageUrl = $"~/Images/default.jpg";
            }
        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = DropDownList.SelectedValue;
            Images.ImageUrl = $"~/Images/{selected}";            
        }
 
        protected void Button_Click(object sender, EventArgs e)
        {
            string selected = DropDownList.SelectedValue;
            switch(selected)
            {
                case "dairy milk.jpg":
                    Label.Text = "$180";
                    break;
                case "kit kat.jpg":
                    Label.Text = "$150";
                    break;
                case "ferrero rocher.jpg":
                    Label.Text = "$300";
                    break;
                case "toblerone.jpg":
                    Label.Text = "$160";
                    break;
                case "snickers.jpg":
                    Label.Text = "$200";
                    break;
                default:
                    Label.Text = "$0";
                    break;
            }
        }
    }
}
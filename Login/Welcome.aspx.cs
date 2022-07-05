using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUser(ReadSession());
        }

        private void CheckUser(bool check)
        {
            if (check)
            {
                
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }

        private bool ReadSession()
        {
            if (Session["check"] == null)
            {
                return false;
            }
            return bool.Parse(Session["check"].ToString());
        }

    }
}
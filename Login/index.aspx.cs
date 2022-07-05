using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            int password = int.Parse(txtPassword.Text);
            Boolean check = false;
            if ((username == "Admin" || username == "admin") && password == 123456)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            WriteSession(username, password, check);
            CheckUser(ReadSession());

        }

        private void CheckUser(bool check)
        {
            if (check)
            {
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                Response.Write("มีบางอย่างผิดพลาด");
            }
        }

        private void WriteSession(string username, int password, bool check)
        {
            Session["username"] = username;
            Session["password"] = password;
            Session["check"] = check;
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
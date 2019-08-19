using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShakhYab
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonStart_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim().Replace("'", "");
            string password = textBoxPassword.Text.Trim().Replace("'", "");

            // Check the Username and Password textboxes
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Login to the Instagram account
                RegisterAsyncTask(new PageAsyncTask(() => Login(username, password)));
            }
        }
    }
}
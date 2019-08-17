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
            if(IsPostBack)
            {
                // If you fill both username and password and try to start ShakhYab
                if(!string.IsNullOrEmpty(textBoxUsername.Text.Trim()) && !string.IsNullOrEmpty(textBoxPassword.Text.Trim()))
                    textBoxPassword.Attributes["value"] = textBoxPassword.Text;
            }
        }

        protected void buttonStart_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim().Replace("'", "");
            string password = textBoxPassword.Text.Trim().Replace("'", "");

            // Check the Username and Password textboxes
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // Check Username textbox separately
                if (string.IsNullOrEmpty(username))
                {
                    textBoxUsername.Style.Add("border-color", "red");
                    textBoxPassword.Style.Add("border-color", "red");

                    // Show error message
                    errorMessage.InnerText = "Both username and password must be filled out";
                }
                else
                {
                    textBoxUsername.Style.Add("border-color", "#ccc");

                    // Check Password textbox separately
                    if (string.IsNullOrEmpty(password))
                    {
                        textBoxPassword.Style.Add("border-color", "red");
                        errorMessage.InnerText = "Please enter your password";
                    }
                }
            }
            else
            {
                // Reset Username and Password border-color
                textBoxUsername.Style.Add("border-color", "#ccc");
                textBoxPassword.Style.Add("border-color", "#ccc");

                // Clear error message
                errorMessage.InnerText = "";

                // Disable textboxes
                textBoxUsername.Enabled = false;
                textBoxPassword.Enabled = false;

                // Hide Start button and show Loading div
                buttonStart.Style.Add("display", "none");
                divLoading.Style.Add("display", "block");
            }
        }
    }
}
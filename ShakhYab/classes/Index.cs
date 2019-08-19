using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Threading.Tasks;

namespace ShakhYab
{
    using classes;

    public partial class Index : System.Web.UI.Page
    {
        /// <summary>
        /// Login async to the user Instagram account and send the result to the buttonStart_Click
        /// </summary>
        /// <param name="username">The Instagram username</param>
        /// <param name="password">The Instagram password</param>
        protected async Task Login(string username, string password)
        {
            // Login to the Instagram account
            ShakhYabCore shakhYabCore;
            shakhYabCore = new ShakhYabCore(username, password);
            string state = await shakhYabCore.Login();
            
            // Split the message
            string[] message = state.Split(':');

            // If message type equal to "Error"
            if (message[0] == "Error")
            {
                errorMessage.InnerText = message[1];
            }
            else
            {
                // Hide Login and show User divs
                divLogin.Style.Add("display", "none");
                divUser.Style.Add("display", "block");

                // Get logged in user information and set them
                UserInfo loggedInUserInfo = shakhYabCore.GetLoggedInUserProfile();
                SetUserProfile(loggedInUserInfo);
            }
        }

        /// <summary>
        /// Set logged in user information
        /// </summary>
        /// <param name="loggedInUserInfo">The logged in user</param>
        private void SetUserProfile(UserInfo loggedInUserInfo)
        {
            textWelcome.InnerText = String.Format("Welcome {0}!", loggedInUserInfo.Nickname);
            textUsername.InnerText = loggedInUserInfo.Username;
            divProfileImage.Style.Add("background-image", String.Format("url({0})", loggedInUserInfo.ProfileUrl));
        }
    }
}
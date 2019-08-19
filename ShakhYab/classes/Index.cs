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

                // Get shakhs list and set them
                List<UserInfo> shakhs = await shakhYabCore.GetShakhs();

                // Add shakhs list to divShakhListContainer innerHtml
                SetShakhs(shakhs);
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

        /// <summary>
        /// Set shakhs user information
        /// </summary>
        /// <param name="shakhs">The shakhs list</param>
        private void SetShakhs(List<UserInfo> shakhs)
        {
            divShakhListContainer.InnerHtml = "";

            for (int i = 0; i < shakhs.Count; i++)
            {
                // Set paragraphs and div
                string pShakhHeader = String.Format("<p class=\"normal-text\" style=\"text-align: center; font-size: 14pt; color: red; margin: 15px 0px; padding: 0px 15px;\">Shakh user #{0}</p>", i + 1);
                string divShakhProfileImage = String.Format("<div class=\"shakh-profile-image\" style=\"background-image: url({0})\"></div>", shakhs[i].ProfileUrl);
                string pShakhUsername = String.Format("<p class=\"normal-text\" style=\"text-align: center; font-size: 13pt; margin: 0px; padding: 0px 15px;\">{0}</p>", shakhs[i].Username);
                string pShakhNickname = String.Format("<p class=\"normal-text\" style=\"text-align: center; font-size: 12pt; color: #7a7a7a; margin: 0px 0px 20px 0px; padding: 0px 15px;\">{0}</p>", shakhs[i].Nickname);
                
                // Add them to container
                string divShakhContainer = String.Format("<div class=\"shakh-each-container\">{0}{1}{2}{3}</div>", pShakhHeader, divShakhProfileImage, pShakhUsername, pShakhNickname);

                // Add container between divShakhListContainer innerHtml
                divShakhListContainer.InnerHtml += divShakhContainer;
            }

            // Set the last margin
            divShakhListContainer.InnerHtml += "<p style=\"margin: 0px 0px 5px 0px;\"></p>";
        }
    }
}
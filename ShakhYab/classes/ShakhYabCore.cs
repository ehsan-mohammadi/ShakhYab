using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.API.Builder;
using InstaSharper.Logger;
using System.Threading.Tasks;

namespace ShakhYab
{
    public class ShakhYabCore
    {
        private IInstaApi api;
        private IRequestDelay delay;
        private UserSessionData user;

        /// <summary>
        /// The constructor of ShakhYabCore class
        /// </summary>
        /// <param name="username">The Instagram username</param>
        /// <param name="password">The Instagram password</param>
        public ShakhYabCore(string username, string password)
        {
            user = new UserSessionData();
            user.UserName = username;
            user.Password = password;
        }

        /// <summary>
        /// Try to login user to Instagram
        /// </summary>
        /// <returns>The login is successful or not</returns>
        public async Task<string> Login()
        {
            // Set api for user
            api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                .Build();

            // Login to Instagram
            IResult<InstaLoginResult> loginRequest = await api.LoginAsync();

            // Check the login state
            if(loginRequest.Succeeded)
            {
                return "Succeeded";
            }
            else
            {
                return String.Format("Error:{0}", loginRequest.Info.Message);
            }
        }
    }
}
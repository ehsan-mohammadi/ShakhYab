using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.API.Builder;
using InstaSharper.Logger;
using InstaSharper.Classes.Models;
using System.Threading.Tasks;

namespace ShakhYab
{
    using classes;

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

        /// <summary>
        /// Get the logged in user profile information (nickname, username and profile image) and set them
        /// </summary>
        public UserInfo GetLoggedInUserProfile()
        {
            return new UserInfo(user.LoggedInUder.FullName, user.LoggedInUder.UserName, user.LoggedInUder.ProfilePicture);
        }

        /// <summary>
        /// Get All the follower list of logged in user
        /// </summary>
        /// <returns>The follower list</returns>
        public async Task<IResult<InstaUserShortList>> GetFollowers()
        {
            IResult<InstaUserShortList> followers = await api.GetUserFollowersAsync(user.UserName, PaginationParameters.Empty);

            return followers;
        }

        /// <summary>
        /// Get All the following list of logged in user
        /// </summary>
        /// <returns>The following list</returns>
        public async Task<IResult<InstaUserShortList>> GetFollowing()
        {
            IResult<InstaUserShortList> following = await api.GetUserFollowingAsync(user.UserName, PaginationParameters.Empty);

            return following;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakhYab.classes
{
    /// <summary>
    /// A class for store Instagram user information
    /// </summary>
    public class UserInfo
    {
        public string Nickname { get; private set; }
        public string Username { get; private set; }
        public string ProfileUrl { get; private set; }

        /// <summary>
        /// The constructor of UserInfo class
        /// </summary>
        /// <param name="nickname">The Instagram nickname</param>
        /// <param name="username">The Instagram username</param>
        /// <param name="profileUrl">The Instagram profile url</param>
        public UserInfo(string nickname, string username, string profileUrl)
        {
            this.Nickname = nickname;
            this.Username = username;
            this.ProfileUrl = profileUrl;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Threading.Tasks;

namespace ShakhYab
{
    public partial class Index : System.Web.UI.Page
    {
        protected async Task Login(string username, string password)
        {
            // Login to the Instagram account
            ShakhYabCore shakhYabCore = new ShakhYabCore(username, password);
            string state = await shakhYabCore.Login();
            
            // Split the message
            string[] message = state.Split(':');

            // If message type equal to "Error"
            if (message[0] == "Error")
                errorMessage.InnerText = message[1];
        }
    }
}
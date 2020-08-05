using System;
using System.Collections.Generic;

namespace Task4
{
    /// <summary>
    /// Class for working with class Server.
    /// </summary>
    public class Server : Сonnection
    {
        /// <summary>
        /// delegate message to the client.
        /// </summary>
        public Action<string, User> CustomerNotification;
        
        /// <summary>
        /// initialize server through a ip address
        /// </summary>
        /// <param name="ip">Ip</param>
        
        public Server(string ip) : base(ip)
        {
            Message = new Dictionary<User, List<string>>();
            
            CustomerNotification += (string message, User user) =>
            {
                if (Message.ContainsKey(user))
                {
                    Message[user].Add(message);
                    
                }
                else
                {
                    var messageList = new List<string>();
                    messageList.Add(message);
                    Message.Add(user, messageList);
                }
            };
        }

        /// <summary>
        /// storing a dictionary of client message.
        /// </summary>
        public Dictionary<User, List<string>> Message
        {
            get;
            private set;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Task4
{
    /// <summary>
    /// Class for working with servers and clients.
    /// </summary>
    public class Сonnection
    {
        /// <summary>
        /// initialize a network element through a ip
        /// </summary>
        /// <param name="IP">Ip Address</param>
        public Сonnection(string ip)
        {
            IP = ip;
        }

        /// <summary>
        /// ip 
        /// </summary>
        public string IP
        {
            get;
        }


        /// <summary>
        /// message to the address.
        /// </summary>
        /// <param name="ip">Ip Address</param>
        /// <param name="message">Message</param>
        /// <param name="connection">Collection of servers and clients</param>
        public void SendMessage(string ip, string message, IEnumerable<Сonnection> connection)
        {
            foreach (Сonnection el in connection)
            {
                if (el.IP == ip && el.GetType() != GetType())
                {
                    if (el is Server)
                    {
                        var server = (Server)el;
                        server.CustomerNotification(message, (User)this);
                    }
                    else
                    {
                        var client = (User)el;
                        client.MessageАfterTransfer(message);
                    }

                    return;
                }
            }

            throw new ArgumentException();
        }

       
   
        /// <summary>
        /// equal the current object with the specified object.
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (GetType() != obj.GetType())
            {
                return false;
            }

            var connetction = (Сonnection)obj;

            return connetction.IP == IP;
        }

        /// <summary>
        /// calculates hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode() => IP.GetHashCode();


        /// <summary>
        /// creates and returns a string representation of the object.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString() => string.Format($"ip: {IP}\n");                                                               
    }
}

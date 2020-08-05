using Task4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Task4Test
{
   
    [TestClass]
    public class Test
    {
        /// <summary>
        /// tests the method SendMessage when message send to the server.
        /// </summary>
        [TestMethod]
        public void MessageSendToServerAddMessageToClient()
        {
            string message = "qwerty";
            string ipServer = "192.123.1.1";
            string ipClient = "192.123.1.3";

            List<Сonnection> connection = new List<Сonnection>()
            {
                new Server(ipServer),
                new User(ipClient)
            };

            connection[1].SendMessage(ipServer, message, connection);

            Dictionary<User, List<string>> result = ((Server)connection[0]).Message;

            Dictionary<User, List<string>> actualResult = ((Server)connection[0]).Message;

            CollectionAssert.AreEqual(result, actualResult);
        }

        /// <summary>
        /// tests the method SendMessage when message send to the non-existent server.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MessageSendToNonExistentServerGetArgumentException()
        {
            string message = "asdf";
            string ipServer = "192.123.1.1";
            string ipClient = "192.123.1.2";
            string nonExistentip = "192.123.2.2";

            List<Сonnection> networkElements = new List<Сonnection>()
            {
                new Server(ipServer),
                new User(ipClient)
            };

            networkElements[1].SendMessage(nonExistentip, message, networkElements);
        }

        /// <summary>
        /// tests method SendMessage when a message send to rhe non-existent client.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WhenMessageSendToNonExistentClientGetArgumentException()
        {
            string message = "fdjghdfugdf";
            string ipServer = "192.123.1.1";
            string ipClient = "192.123.1.2";
            string nonExistentip = "192.123.3.2";

            List<Сonnection> networkElements = new List<Сonnection>()
            {
                new Server(ipServer),
                new User(ipClient)
            };

            networkElements[0].SendMessage(nonExistentip, message, networkElements);
        }

        /// <summary>
        /// tests method SendMessage when a message send to rhe client.
        /// </summary>
        [TestMethod]
        public void WhenMessageSendToClientTranslateMessageToRussian()
        {
            string message = "papa";
            string ipServer = "192.123.1.1";
            string ipClient = "192.123.1.2";

            List<Сonnection> networkElements = new List<Сonnection>()
            {
                new Server(ipServer),
                new User(ipClient)
            };

            networkElements[0].SendMessage(ipClient, message, networkElements);
            string result = ((User)networkElements[1]).Message;
            string actualResult = "папа";

            Assert.AreEqual(result, actualResult);
        }



        /// <summary>
        /// tests method SendMessage when a message send to rhe client.
        /// </summary>
        [TestMethod]
        public void WhenMessageSendToClientTranslateMessageToEnglish()
        {
            string message = "привет";
            string ipServer = "192.123.1.1";
            string ipClient = "192.123.1.2";


            List<Сonnection> networkElements = new List<Сonnection>()
            {
                new Server(ipServer),
                new User(ipClient)
            };

            networkElements[0].SendMessage(ipClient, message, networkElements);
            string result = ((User)networkElements[1]).Message;
            string actualResult = "privet";

            Assert.AreEqual(result, actualResult);
        }

    }
}

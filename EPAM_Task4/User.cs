using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task4
{
    /// <summary>
    /// Class for working the class Client.
    /// </summary>
    public class User : Сonnection
    { 
        /// <summary>
        /// The delegate to translate message.
        /// </summary>
        public Action<string> MessageАfterTransfer;

        /// <summary>
        /// storing a message.
        /// </summary>
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ip"></param>
        public User(string ip) : base(ip)
        {
            MessageАfterTransfer += (string message) =>
            {
                message = message.ToLower();
                Interpreter interpreter = new Interpreter();

                if (Regex.IsMatch(message, @"\P{IsCyrillic}"))
                {
                    foreach (string letter in interpreter.TranslatorEnglishToRussia.Keys)
                    {
                        message = message.Replace(letter, interpreter.TranslatorEnglishToRussia[letter]);
                    }

                    Message = message;
                }
                else
                {
                    foreach (string letter in interpreter.TranslatorRussianToEnglish.Keys)
                    {
                        message = message.Replace(letter, interpreter.TranslatorRussianToEnglish[letter]);
                    }

                    Message = message;
                }        
            };
        }

       
    }
}

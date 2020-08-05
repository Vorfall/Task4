using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    /// <summary>
    /// Class for translating letters from different languages
    /// </summary>
    public class Interpreter
    {
        /// <summary>
        /// Dictionary for storing Russian letters and their translation into English.
        /// </summary>

        public Dictionary<string, string> TranslatorRussianToEnglish = new Dictionary<string, string>
        {
            ["а"]= "a",
            ["б"]= "b",
            ["в"]= "v",
            ["г"]= "g",
            ["д"]= "d",
            ["е"]= "e",
            ["ё"]= "e",
            ["ж"]= "zh",
            ["з"]= "z",
            ["и"]= "i",
            ["й"]= "i",
            ["к"]= "k",
            ["л"]= "l",
            ["м"]= "m",
            ["н"]= "n",
            ["о"]= "o",
            ["п"]= "p",
            ["р"]= "r",
            ["с"]= "s",
            ["т"]= "t",
            ["у"]= "u",
            ["ф"]= "f",
            ["х"]= "kh",
            ["ц"]= "ts",
            ["ч"]= "ch",
            ["ш"]= "sh",
            ["щ"]= "shch",
            ["ъ"]= "",
            ["ы"]= "y",
            ["ь"]= "",
            ["э"]= "e",
            ["ю"]= "iu",
            ["я"]= "ia"
        };

        /// <summary>
        /// Dictionary for storing English letters and their translation into Russian.
        /// </summary>
        public Dictionary<string, string> TranslatorEnglishToRussia = new Dictionary<string, string>
        {
            ["a"]= "а",
            ["b"]= "б", 
            ["c"]= "ц",
            ["d"]= "д", 
            ["e"]= "е", 
            ["f"]= "ф",
            ["g"]= "г",
            ["h"]= "х",
            ["i"]= "и",
            ["j"]= "дж",
            ["k"]= "к",
            ["l"]= "л",
            ["m"]= "м",
            ["n"]= "н",
            ["o"]= "о",
            ["p"]= "п",
            ["q"]= "кв",
            ["r"]= "р",
            ["s"]= "с",
            ["t"]= "т",
            ["u"]= "у",
            ["v"]= "в",
            ["w"]= "в",
            ["x"]= "кс",
            ["y"]= "и",
            ["z"]= "з"
        };
    }
}

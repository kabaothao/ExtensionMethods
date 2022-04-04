using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods //if you change the namespace name then program.cs will not recognize the namespace. what happens is if I go back to Program, that method is not recognized. So, that's a key thing you need to know about extension methods: they come to
{                                     //ExtensionMethods.Extensions 
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {   
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join("", words.Take(numberOfWords)) + "...";
        }
    }
}

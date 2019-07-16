using System;
using System.Linq;

namespace ExtensionMethods // Could change to System, to store the extension in the same place as the base
{
    /// <summary>
    /// public static class <TypeBeingExtended>Extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// String Extension method that shortens a string to the desired number of words
        /// </summary>
        /// <param name="str">Of type that is being extended</param>
        /// <param name="numberOfWords"></param>
        /// <returns></returns>
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0) throw new ArgumentOutOfRangeException("Number of words should be greater than or equal to 0");

            if (numberOfWords == 0) return "";

            var words = str.Split(' ');
            if (words.Length <= numberOfWords) return str;

            return string.Join(" ", words.Take(numberOfWords))+"...";
        }
    }
}


using System.Globalization;


namespace RodsExtensions
{
    /// <summary>
    /// General extension methods
    /// </summary>
    public static class ExtensionHelpers
    {
        /// <summary>
        /// Converts the string to title case
        /// </summary>
        /// <param name="currentString">string to convert</param>
        /// <returns></returns>
        public static string ToTitleCase(this string currentString)
        {
            if (currentString.IsNullOrEmpty())
                return "";
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            currentString = ti.ToTitleCase(currentString.ToLower());
            return currentString;
        }


        /// <summary>
        /// Neater way of checking if string is null or empty
        /// </summary>
        /// <param name="currentString"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string currentString)
        {
            return string.IsNullOrEmpty(currentString);
        }
    }
}

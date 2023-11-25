namespace AzDevOps202311.Common;

public static class StringExtensions
{
    /// <summary>
    /// Capitalizes only the first letter of the given string.
    /// </summary>
    /// <param name="str">The string to be modified.</param>
    /// <returns>A string with the first letter capitalized.</returns>
    public static string CapitalizeFirstLetter(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        if (str.Length == 1)
            return str.ToUpper();

        return char.ToUpper(str[0]) + str.Substring(1).ToLower();
    }
}

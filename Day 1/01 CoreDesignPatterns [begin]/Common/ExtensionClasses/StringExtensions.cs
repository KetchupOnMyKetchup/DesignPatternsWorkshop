namespace Common.ExtensionClasses
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value) == false;
        }

        public static string FormatWith(this string value, params object[] allParams)
        {
            return string.Format(value, allParams);
        }
    }
}
namespace vkisha.utils
{
    public static class StringOperation
    {
        public static bool IsNull (this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static string Replace1(this string value)
        {
            return value;
        }
    }
}
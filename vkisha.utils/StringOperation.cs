namespace vkisha.utils
{
    public static class StringOperation
    {
        public static bool IsNull (this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
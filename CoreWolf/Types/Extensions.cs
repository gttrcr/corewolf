namespace CoreWolf.Types
{
    public static class Extension
    {
        public static string ToString<T>(T[] array)
        {
            return '{' + string.Join(',', array) + '}';
        }

        public static string[] ToString<T>(T[][] array)
        {
            return array.Select(x => ToString(x)).ToArray();
        }
    }
}
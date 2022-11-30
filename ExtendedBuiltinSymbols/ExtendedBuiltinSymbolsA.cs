namespace NetWolf
{
    public static class ExtendedBuiltinSymbolsA
    {
        ///<summary>
        ///exports last data to a file, converting it to the format corresponding to the file extension ext.
        ///</summary>
        public static Engine ArrayQ(this Engine en, string? name = null)
        {
            return en.Execute("ArrayQ[" + en.ValidNames.Last() + "]", name);
        }
    }
}
namespace NetWolf
{
    public static class ExtendedBuiltinSymbolsE
    {
        ///<summary>
        ///exports last data to a file, converting it to the format corresponding to the file extension ext.
        ///</summary>
        public static Engine Export(this Engine en, string path, string? name = null)
        {
            return en.Execute("Export[\"" + path + "\", " + en.ValidNames.Last() + "]", name);
        }
    }
}
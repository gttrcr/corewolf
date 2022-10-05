namespace NetWolf
{
    public static class ExtensionMethodsBuiltinSymbolsE
    {
        ///<summary>
        ///export last command
        ///</summary>
        public static Engine Export(this Engine en, string path, string? name = null)
        {
            return en.Execute("Export[\"" + path + "\", " + en.ValidNames.Last() + "]", name);
        }
    }
}
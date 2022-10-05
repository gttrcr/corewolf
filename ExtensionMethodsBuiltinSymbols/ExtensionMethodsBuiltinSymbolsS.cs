namespace NetWolf
{
    public static class ExtensionMethodsBuiltinSymbolsS
    {
        ///<summary>
        ///export last command
        ///</summary>
        public static Engine Simplify(this Engine en, string? name = null)
        {
            return en.Execute("Simplify[" + en.ValidNames.Last() + "]", name);
        }
    }
}
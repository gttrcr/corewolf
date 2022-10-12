namespace NetWolf
{
    public static class ExtendedBuiltinSymbolsS
    {
        ///<summary>
        ///performs a sequence of algebraic and other transformations on expr and returns the simplest form it finds for the last expression
        ///</summary>
        public static Engine Simplify(this Engine en, Assumptions? ass = null, string? name = null)
        {
            return en.Execute("Simplify[" + en.ValidNames.Last() + (ass != null ? (", " + ass.ToString()) : "") + "]", name);
        }
    }
}
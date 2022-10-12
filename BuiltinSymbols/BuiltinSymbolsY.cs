namespace NetWolf
{
    public static class BuiltinSymbolY
    {
		///<summary>
		///gives the Yule dissimilarity between Boolean vectors u and v.
		///https://reference.wolfram.com/language/ref/YuleDissimilarity.html
		///</summary>
		public static Engine YuleDissimilarity(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("YuleDissimilarity[" + arg0 + ", " + arg1 + "]", name);
		}


    }
}
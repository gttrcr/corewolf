using System.Collections.Generic;

namespace CoreWolf
{
    public static class BuiltinFunctionY
    {
        ///<summary>
        ///gives the Yule dissimilarity between Boolean vectors u and v.
        ///https://reference.wolfram.com/language/ref/YuleDissimilarity.html
        ///</summary>
        public static Engine YuleDissimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("YuleDissimilarity[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}
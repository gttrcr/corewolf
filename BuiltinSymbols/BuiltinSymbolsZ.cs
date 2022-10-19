namespace NetWolf
{
    public static class BuiltinSymbolZ
    {
        ///<summary>
        ///gives the radial Zernike polynomial .
        ///https://reference.wolfram.com/language/ref/ZernikeR.html
        ///</summary>
        public static Engine ZernikeR(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("ZernikeR[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the symmetry of a zero tensor in the slots si.
        ///https://reference.wolfram.com/language/ref/ZeroSymmetric.html
        ///</summary>
        public static Engine ZeroSymmetric(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("ZeroSymmetric[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Riemann zeta function .
        ///https://reference.wolfram.com/language/ref/Zeta.html
        ///</summary>
        public static Engine Zeta(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("Zeta[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generalized Riemann zeta function .
        ///https://reference.wolfram.com/language/ref/Zeta.html
        ///</summary>
        public static Engine Zeta(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("Zeta[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the k zero of the Riemann zeta function on the critical line.
        ///https://reference.wolfram.com/language/ref/ZetaZero.html
        ///</summary>
        public static Engine ZetaZero(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("ZetaZero[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the k zero with imaginary part greater than .
        ///https://reference.wolfram.com/language/ref/ZetaZero.html
        ///</summary>
        public static Engine ZetaZero(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("ZetaZero[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the ZIP code entity.
        ///https://reference.wolfram.com/language/ref/ZIPCodeData.html
        ///</summary>
        public static Engine ZIPCodeData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("ZIPCodeData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified ZIP code entities.
        ///https://reference.wolfram.com/language/ref/ZIPCodeData.html
        ///</summary>
        public static Engine ZIPCodeData(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("ZIPCodeData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/ZIPCodeData.html
        ///</summary>
        public static Engine ZIPCodeData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("ZIPCodeData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a zeta distribution with parameter ρ.
        ///https://reference.wolfram.com/language/ref/ZipfDistribution.html
        ///</summary>
        public static Engine ZipfDistribution(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("ZipfDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Zipf distribution with range n.
        ///https://reference.wolfram.com/language/ref/ZipfDistribution.html
        ///</summary>
        public static Engine ZipfDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("ZipfDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the mean of the data is zero.
        ///https://reference.wolfram.com/language/ref/ZTest.html
        ///</summary>
        public static Engine ZTest(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("ZTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the means of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/ZTest.html
        ///</summary>
        public static Engine ZTest(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("ZTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///tests for zero or equal means assuming a population variance σ2.
        ///https://reference.wolfram.com/language/ref/ZTest.html
        ///</summary>
        public static Engine ZTest(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("ZTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests the mean against μ0.
        ///https://reference.wolfram.com/language/ref/ZTest.html
        ///</summary>
        public static Engine ZTest(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("ZTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/ZTest.html
        ///</summary>
        public static Engine ZTest(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("ZTest[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the Z transform of expr.
        ///https://reference.wolfram.com/language/ref/ZTransform.html
        ///</summary>
        public static Engine ZTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("ZTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Z transform of expr.
        ///https://reference.wolfram.com/language/ref/ZTransform.html
        ///</summary>
        public static Engine ZTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("ZTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }


    }
}
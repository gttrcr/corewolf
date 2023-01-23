namespace NetWolf
{
    public static class ExtendedSymbolsZ
    {
        ///<summary>
        ///represents the symmetry of a zero tensor in the slots si.
        ///https://reference.wolfram.com/language/ref/ZeroSymmetric.html
        ///</summary>
        public static Engine ZeroSymmetric(this Engine en, string? name = null)
        {
            return en.Execute("ZeroSymmetric[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Riemann zeta function .
        ///https://reference.wolfram.com/language/ref/Zeta.html
        ///</summary>
        public static Engine Zeta(this Engine en, string? name = null)
        {
            return en.Execute("Zeta[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the k zero of the Riemann zeta function on the critical line.
        ///https://reference.wolfram.com/language/ref/ZetaZero.html
        ///</summary>
        public static Engine ZetaZero(this Engine en, string? name = null)
        {
            return en.Execute("ZetaZero[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a zeta distribution with parameter ρ.
        ///https://reference.wolfram.com/language/ref/ZipfDistribution.html
        ///</summary>
        public static Engine ZipfDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ZipfDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the mean of the data is zero.
        ///https://reference.wolfram.com/language/ref/ZTest.html
        ///</summary>
        public static Engine ZTest(this Engine en, string? name = null)
        {
            return en.Execute("ZTest[" + en.ValidNames.Last() + "]", name);
        }


    }
}
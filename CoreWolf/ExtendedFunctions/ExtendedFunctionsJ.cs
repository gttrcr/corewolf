namespace CoreWolf
{
    public static class ExtendedFunctionsJ
    {
        ///<summary>
        /// tests whether data is normally distributed using the Jarque–Bera ALM test.
        /// https://reference.wolfram.com/language/ref/JarqueBeraALMTest.html
        ///</summary>
        public static Engine JarqueBeraALMTest(this Engine en, string? name = null)
        {
            return en.Execute("JarqueBeraALMTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a curve consisting of segment1 followed by segment2 etc.
        /// https://reference.wolfram.com/language/ref/JoinedCurve.html
        ///</summary>
        public static Engine JoinedCurve(this Engine en, string? name = null)
        {
            return en.Execute("JoinedCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive that specifies what type of joins should be used to connect segments of lines, tubes, edges, and related primitives.
        /// https://reference.wolfram.com/language/ref/JoinForm.html
        ///</summary>
        public static Engine JoinForm(this Engine en, string? name = null)
        {
            return en.Execute("JoinForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields the Jordan decomposition of a square matrix m. The result is a list {s,j} where s is a similarity matrix and j is the Jordan canonical form of m.
        /// https://reference.wolfram.com/language/ref/JordanDecomposition.html
        ///</summary>
        public static Engine JordanDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("JordanDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields the Jordan decomposition of the state-space model ssm.
        /// https://reference.wolfram.com/language/ref/JordanModelDecomposition.html
        ///</summary>
        public static Engine JordanModelDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("JordanModelDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of days for the specified date.
        /// https://reference.wolfram.com/language/ref/JulianDate.html
        ///</summary>
        public static Engine JulianDate(this Engine en, string? name = null)
        {
            return en.Execute("JulianDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the Julia set of the function .
        /// https://reference.wolfram.com/language/ref/JuliaSetPlot.html
        ///</summary>
        public static Engine JuliaSetPlot(this Engine en, string? name = null)
        {
            return en.Execute("JuliaSetPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a list of coordinates of points approximating the Julia set of the function .
        /// https://reference.wolfram.com/language/ref/JuliaSetPoints.html
        ///</summary>
        public static Engine JuliaSetPoints(this Engine en, string? name = null)
        {
            return en.Execute("JuliaSetPoints[" + en.ValidNames.Last() + "]", name);
        }


    }
}
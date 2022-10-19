namespace NetWolf
{
    public static class BuiltinSymbolJ
    {
        ///<summary>
        ///gives the Jaccard dissimilarity between Boolean vectors u and v.
        ///https://reference.wolfram.com/language/ref/JaccardDissimilarity.html
        ///</summary>
        public static Engine JaccardDissimilarity(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JaccardDissimilarity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the amplitude  for Jacobi elliptic functions.
        ///https://reference.wolfram.com/language/ref/JacobiAmplitude.html
        ///</summary>
        public static Engine JacobiAmplitude(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiAmplitude[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiCD.html
        ///</summary>
        public static Engine JacobiCD(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiCD[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiCN.html
        ///</summary>
        public static Engine JacobiCN(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiCN[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiCS.html
        ///</summary>
        public static Engine JacobiCS(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiCS[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiDC.html
        ///</summary>
        public static Engine JacobiDC(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiDC[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiDN.html
        ///</summary>
        public static Engine JacobiDN(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiDN[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiDS.html
        ///</summary>
        public static Engine JacobiDS(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiDS[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi epsilon function .
        ///https://reference.wolfram.com/language/ref/JacobiEpsilon.html
        ///</summary>
        public static Engine JacobiEpsilon(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiEpsilon[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiNC.html
        ///</summary>
        public static Engine JacobiNC(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiNC[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiND.html
        ///</summary>
        public static Engine JacobiND(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiND[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiNS.html
        ///</summary>
        public static Engine JacobiNS(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiNS[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi polynomial .
        ///https://reference.wolfram.com/language/ref/JacobiP.html
        ///</summary>
        public static Engine JacobiP(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("JacobiP[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiSC.html
        ///</summary>
        public static Engine JacobiSC(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiSC[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiSD.html
        ///</summary>
        public static Engine JacobiSD(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiSD[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi elliptic function .
        ///https://reference.wolfram.com/language/ref/JacobiSN.html
        ///</summary>
        public static Engine JacobiSN(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiSN[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi symbol .
        ///https://reference.wolfram.com/language/ref/JacobiSymbol.html
        ///</summary>
        public static Engine JacobiSymbol(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiSymbol[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi zeta function .
        ///https://reference.wolfram.com/language/ref/JacobiZeta.html
        ///</summary>
        public static Engine JacobiZeta(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiZeta[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jacobi zeta function .
        ///https://reference.wolfram.com/language/ref/JacobiZN.html
        ///</summary>
        public static Engine JacobiZN(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JacobiZN[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Janko group .
        ///https://reference.wolfram.com/language/ref/JankoGroupJ1.html
        ///</summary>
        public static Engine JankoGroupJ1(this Engine en, string? name = null)
        {
            return en.Execute("JankoGroupJ1[]", name);
        }

        ///<summary>
        ///represents the sporadic simple Janko group .
        ///https://reference.wolfram.com/language/ref/JankoGroupJ2.html
        ///</summary>
        public static Engine JankoGroupJ2(this Engine en, string? name = null)
        {
            return en.Execute("JankoGroupJ2[]", name);
        }

        ///<summary>
        ///represents the sporadic simple Janko group .
        ///https://reference.wolfram.com/language/ref/JankoGroupJ3.html
        ///</summary>
        public static Engine JankoGroupJ3(this Engine en, string? name = null)
        {
            return en.Execute("JankoGroupJ3[]", name);
        }

        ///<summary>
        ///represents the sporadic simple Janko group .
        ///https://reference.wolfram.com/language/ref/JankoGroupJ4.html
        ///</summary>
        public static Engine JankoGroupJ4(this Engine en, string? name = null)
        {
            return en.Execute("JankoGroupJ4[]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Jarque–Bera ALM test.
        ///https://reference.wolfram.com/language/ref/JarqueBeraALMTest.html
        ///</summary>
        public static Engine JarqueBeraALMTest(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("JarqueBeraALMTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/JarqueBeraALMTest.html
        ///</summary>
        public static Engine JarqueBeraALMTest(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JarqueBeraALMTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a bounded Johnson distribution with shape parameters γ, δ, location parameter μ, and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/JohnsonDistribution.html
        ///</summary>
        public static Engine JohnsonDistribution(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
        {
            return en.Execute("JohnsonDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///concatenates lists or other expressions that share the same head.
        ///https://reference.wolfram.com/language/ref/Join.html
        ///</summary>
        public static Engine Join(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("Join[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///joins the objects at level n in each of the listi.
        ///https://reference.wolfram.com/language/ref/Join.html
        ///</summary>
        public static Engine Join(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("Join[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a list of associations obtained by joining those pairs of associations ai and bj in which the values associated with key are the same.
        ///https://reference.wolfram.com/language/ref/JoinAcross.html
        ///</summary>
        public static Engine JoinAcross(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("JoinAcross[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///joins pairs of associations only when the values associated with all keys keyi are the same.
        ///https://reference.wolfram.com/language/ref/JoinAcross.html
        ///</summary>
        public static Engine JoinAcross(this Engine en, List<string> arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("JoinAcross[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///uses joinspec to determine when to allow associations that contain missing elements to be generated.
        ///https://reference.wolfram.com/language/ref/JoinAcross.html
        ///</summary>
        public static Engine JoinAcross(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("JoinAcross[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a curve consisting of segment1 followed by segment2 etc.
        ///https://reference.wolfram.com/language/ref/JoinedCurve.html
        ///</summary>
        public static Engine JoinedCurve(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("JoinedCurve[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is a graphics directive that specifies what type of joins should be used to connect segments of lines, tubes, edges, and related primitives.
        ///https://reference.wolfram.com/language/ref/JoinForm.html
        ///</summary>
        public static Engine JoinForm(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("JoinForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields the Jordan decomposition of a square matrix m. The result is a list {s,j} where s is a similarity matrix and j is the Jordan canonical form of m.
        ///https://reference.wolfram.com/language/ref/JordanDecomposition.html
        ///</summary>
        public static Engine JordanDecomposition(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("JordanDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields the Jordan decomposition of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/JordanModelDecomposition.html
        ///</summary>
        public static Engine JordanModelDecomposition(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("JordanModelDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the current number of days since noon on November 24, 4714 BCE in the GMT time zone.
        ///https://reference.wolfram.com/language/ref/JulianDate.html
        ///</summary>
        public static Engine JulianDate(this Engine en, string? name = null)
        {
            return en.Execute("JulianDate[]", name);
        }

        ///<summary>
        ///gives the number of days for the specified date.
        ///https://reference.wolfram.com/language/ref/JulianDate.html
        ///</summary>
        public static Engine JulianDate(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("JulianDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the variant for the specified date.
        ///https://reference.wolfram.com/language/ref/JulianDate.html
        ///</summary>
        public static Engine JulianDate(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JulianDate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Böttcher coordinate of z with respect to the quadratic Julia set Jc.
        ///https://reference.wolfram.com/language/ref/JuliaSetBoettcher.html
        ///</summary>
        public static Engine JuliaSetBoettcher(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JuliaSetBoettcher[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the number of iterations, beginning with the complex number , of the function  needed to determine whether p is in the Julia set of f.
        ///https://reference.wolfram.com/language/ref/JuliaSetIterationCount.html
        ///</summary>
        public static Engine JuliaSetIterationCount(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("JuliaSetIterationCount[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the number of iterations, beginning with the complex number , of the function  needed to determine whether p is in the Julia set of .
        ///https://reference.wolfram.com/language/ref/JuliaSetIterationCount.html
        ///</summary>
        public static Engine JuliaSetIterationCount(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JuliaSetIterationCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of the number of iterations required to determine whether each member of {p1,p2,…} is in the Julia set of f.
        ///https://reference.wolfram.com/language/ref/JuliaSetIterationCount.html
        ///</summary>
        public static Engine JuliaSetIterationCount(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("JuliaSetIterationCount[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///returns a list of the number of iterations required to determine whether each member of {p1,p2,…} is in the Julia set of .
        ///https://reference.wolfram.com/language/ref/JuliaSetIterationCount.html
        ///</summary>
        public static Engine JuliaSetIterationCount(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("JuliaSetIterationCount[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots the Julia set of the rational function f of the variable z.
        ///https://reference.wolfram.com/language/ref/JuliaSetPlot.html
        ///</summary>
        public static Engine JuliaSetPlot(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JuliaSetPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots the Julia set of the function .
        ///https://reference.wolfram.com/language/ref/JuliaSetPlot.html
        ///</summary>
        public static Engine JuliaSetPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("JuliaSetPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of coordinates approximating the real and imaginary parts of the complex numbers in the Julia set of the rational function f of the variable z.
        ///https://reference.wolfram.com/language/ref/JuliaSetPoints.html
        ///</summary>
        public static Engine JuliaSetPoints(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("JuliaSetPoints[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of coordinates of points approximating the Julia set of the function .
        ///https://reference.wolfram.com/language/ref/JuliaSetPoints.html
        ///</summary>
        public static Engine JuliaSetPoints(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("JuliaSetPoints[" + arg0 + "]", name);
        }


    }
}
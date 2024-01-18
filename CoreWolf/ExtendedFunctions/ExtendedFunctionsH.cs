namespace CoreWolf
{
    public static class ExtendedFunctionsH
    {
        ///<summary>
        /// returns an n×n Hadamard matrix.
        /// https://reference.wolfram.com/language/ref/HadamardMatrix.html
        ///</summary>
        public static Engine HadamardMatrix(this Engine en, string? name = null)
        {
            return en.Execute("HadamardMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the half-line from the point p1 through p2.
        /// https://reference.wolfram.com/language/ref/HalfLine.html
        ///</summary>
        public static Engine HalfLine(this Engine en, string? name = null)
        {
            return en.Execute("HalfLine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a half-normal distribution with scale inversely proportional to parameter θ.
        /// https://reference.wolfram.com/language/ref/HalfNormalDistribution.html
        ///</summary>
        public static Engine HalfNormalDistribution(this Engine en, string? name = null)
        {
            return en.Execute("HalfNormalDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uses the density d of shading.
        /// https://reference.wolfram.com/language/ref/HalftoneShading.html
        ///</summary>
        public static Engine HalftoneShading(this Engine en, string? name = null)
        {
            return en.Execute("HalftoneShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is Hamiltonian, and False otherwise.
        /// https://reference.wolfram.com/language/ref/HamiltonianGraphQ.html
        ///</summary>
        public static Engine HamiltonianGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("HamiltonianGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Hamming window function of x.
        /// https://reference.wolfram.com/language/ref/HammingWindow.html
        ///</summary>
        public static Engine HammingWindow(this Engine en, string? name = null)
        {
            return en.Execute("HammingWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n×n Hankel matrix with first row and first column being successive integers.
        /// https://reference.wolfram.com/language/ref/HankelMatrix.html
        ///</summary>
        public static Engine HankelMatrix(this Engine en, string? name = null)
        {
            return en.Execute("HankelMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Hann–Poisson window function of x.
        /// https://reference.wolfram.com/language/ref/HannPoissonWindow.html
        ///</summary>
        public static Engine HannPoissonWindow(this Engine en, string? name = null)
        {
            return en.Execute("HannPoissonWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Hann window function of x.
        /// https://reference.wolfram.com/language/ref/HannWindow.html
        ///</summary>
        public static Engine HannWindow(this Engine en, string? name = null)
        {
            return en.Execute("HannWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the harmonic mean of the values in list.
        /// https://reference.wolfram.com/language/ref/HarmonicMean.html
        ///</summary>
        public static Engine HarmonicMean(this Engine en, string? name = null)
        {
            return en.Execute("HarmonicMean[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n harmonic number .
        /// https://reference.wolfram.com/language/ref/HarmonicNumber.html
        ///</summary>
        public static Engine HarmonicNumber(this Engine en, string? name = null)
        {
            return en.Execute("HarmonicNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an integer hash code for the expression expr.
        /// https://reference.wolfram.com/language/ref/Hash.html
        ///</summary>
        public static Engine Hash(this Engine en, string? name = null)
        {
            return en.Execute("Hash[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uses the specified line hatching "name".
        /// https://reference.wolfram.com/language/ref/HatchFilling.html
        ///</summary>
        public static Engine HatchFilling(this Engine en, string? name = null)
        {
            return en.Execute("HatchFilling[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uses the density d of shading.
        /// https://reference.wolfram.com/language/ref/HatchShading.html
        ///</summary>
        public static Engine HatchShading(this Engine en, string? name = null)
        {
            return en.Execute("HatchShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the haversine function .
        /// https://reference.wolfram.com/language/ref/Haversine.html
        ///</summary>
        public static Engine Haversine(this Engine en, string? name = null)
        {
            return en.Execute("Haversine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the hazard function as a pure function.
        /// https://reference.wolfram.com/language/ref/HazardFunction.html
        ///</summary>
        public static Engine HazardFunction(this Engine en, string? name = null)
        {
            return en.Execute("HazardFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the head of expr.
        /// https://reference.wolfram.com/language/ref/Head.html
        ///</summary>
        public static Engine Head(this Engine en, string? name = null)
        {
            return en.Execute("Head[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the triangle distribution  which is nonzero for .
        /// https://reference.wolfram.com/language/ref/HeavisideLambda.html
        ///</summary>
        public static Engine HeavisideLambda(this Engine en, string? name = null)
        {
            return en.Execute("HeavisideLambda[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the box distribution , equal to 1 for  and 0 for .
        /// https://reference.wolfram.com/language/ref/HeavisidePi.html
        ///</summary>
        public static Engine HeavisidePi(this Engine en, string? name = null)
        {
            return en.Execute("HeavisidePi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the Heaviside theta function , equal to 0 for  and 1 for .
        /// https://reference.wolfram.com/language/ref/HeavisideTheta.html
        ///</summary>
        public static Engine HeavisideTheta(this Engine en, string? name = null)
        {
            return en.Execute("HeavisideTheta[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Hermite normal form decomposition of an integer matrix .
        /// https://reference.wolfram.com/language/ref/HermiteDecomposition.html
        ///</summary>
        public static Engine HermiteDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("HermiteDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the symmetry of a Hermitian matrix.
        /// https://reference.wolfram.com/language/ref/Hermitian.html
        ///</summary>
        public static Engine Hermitian(this Engine en, string? name = null)
        {
            return en.Execute("Hermitian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is explicitly Hermitian, and False otherwise.
        /// https://reference.wolfram.com/language/ref/HermitianMatrixQ.html
        ///</summary>
        public static Engine HermitianMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("HermitianMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Hessenberg decomposition of a numerical matrix m.
        /// https://reference.wolfram.com/language/ref/HessenbergDecomposition.html
        ///</summary>
        public static Engine HessenbergDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("HessenbergDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a filled hexahedron with corners p1, p2, …, p8.
        /// https://reference.wolfram.com/language/ref/Hexahedron.html
        ///</summary>
        public static Engine Hexahedron(this Engine en, string? name = null)
        {
            return en.Execute("Hexahedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays a highlighted version of expr.
        /// https://reference.wolfram.com/language/ref/Highlighted.html
        ///</summary>
        public static Engine Highlighted(this Engine en, string? name = null)
        {
            return en.Execute("Highlighted[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the line segments representing the n-step Hilbert curve.
        /// https://reference.wolfram.com/language/ref/HilbertCurve.html
        ///</summary>
        public static Engine HilbertCurve(this Engine en, string? name = null)
        {
            return en.Execute("HilbertCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n×n Hilbert matrix with elements of the form .
        /// https://reference.wolfram.com/language/ref/HilbertMatrix.html
        ///</summary>
        public static Engine HilbertMatrix(this Engine en, string? name = null)
        {
            return en.Execute("HilbertMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots a histogram of the values xi.
        /// https://reference.wolfram.com/language/ref/Histogram.html
        ///</summary>
        public static Engine Histogram(this Engine en, string? name = null)
        {
            return en.Execute("Histogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots 3D histograms for multiple datasets datai.
        /// https://reference.wolfram.com/language/ref/Histogram3D.html
        ///</summary>
        public static Engine Histogram3D(this Engine en, string? name = null)
        {
            return en.Execute("Histogram3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the probability distribution corresponding to a histogram of the data values xi.
        /// https://reference.wolfram.com/language/ref/HistogramDistribution.html
        ///</summary>
        public static Engine HistogramDistribution(this Engine en, string? name = null)
        {
            return en.Execute("HistogramDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of bins and histogram heights of the values xi.
        /// https://reference.wolfram.com/language/ref/HistogramList.html
        ///</summary>
        public static Engine HistogramList(this Engine en, string? name = null)
        {
            return en.Execute("HistogramList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// estimates the histogram point density function  for point data pdata.
        /// https://reference.wolfram.com/language/ref/HistogramPointDensity.html
        ///</summary>
        public static Engine HistogramPointDensity(this Engine en, string? name = null)
        {
            return en.Execute("HistogramPointDensity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// transforms pixel values of image so that its histogram is nearly flat.
        /// https://reference.wolfram.com/language/ref/HistogramTransform.html
        ///</summary>
        public static Engine HistogramTransform(this Engine en, string? name = null)
        {
            return en.Execute("HistogramTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds a function  so that the transformed values  are distributed nearly uniformly.
        /// https://reference.wolfram.com/language/ref/HistogramTransformInterpolation.html
        ///</summary>
        public static Engine HistogramTransformInterpolation(this Engine en, string? name = null)
        {
            return en.Execute("HistogramTransformInterpolation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of authority and hub centralities for the vertices in the graph g.
        /// https://reference.wolfram.com/language/ref/HITSCentrality.html
        ///</summary>
        public static Engine HITSCentrality(this Engine en, string? name = null)
        {
            return en.Execute("HITSCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Hodge dual of the tensor
        /// https://reference.wolfram.com/language/ref/HodgeDual.html
        ///</summary>
        public static Engine HodgeDual(this Engine en, string? name = null)
        {
            return en.Execute("HodgeDual[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives Hoeffding's dependence measure  for the matrix m.
        /// https://reference.wolfram.com/language/ref/HoeffdingD.html
        ///</summary>
        public static Engine HoeffdingD(this Engine en, string? name = null)
        {
            return en.Execute("HoeffdingD[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// maintains expr in an unevaluated form.
        /// https://reference.wolfram.com/language/ref/Hold.html
        ///</summary>
        public static Engine Hold(this Engine en, string? name = null)
        {
            return en.Execute("Hold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// shields expr completely from the standard Wolfram Language evaluation process, preventing even upvalues associated with expr from being used.
        /// https://reference.wolfram.com/language/ref/HoldComplete.html
        ///</summary>
        public static Engine HoldComplete(this Engine en, string? name = null)
        {
            return en.Execute("HoldComplete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints as the expression expr, with expr maintained in an unevaluated form.
        /// https://reference.wolfram.com/language/ref/HoldForm.html
        ///</summary>
        public static Engine HoldForm(this Engine en, string? name = null)
        {
            return en.Execute("HoldForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is equivalent to expr for pattern matching, but maintains expr in an unevaluated form.
        /// https://reference.wolfram.com/language/ref/HoldPattern.html
        ///</summary>
        public static Engine HoldPattern(this Engine en, string? name = null)
        {
            return en.Execute("HoldPattern[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// draws a linear gauge showing value in a range of 0 to 1.
        /// https://reference.wolfram.com/language/ref/HorizontalGauge.html
        ///</summary>
        public static Engine HorizontalGauge(this Engine en, string? name = null)
        {
            return en.Execute("HorizontalGauge[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// puts the polynomial poly in Horner form.
        /// https://reference.wolfram.com/language/ref/HornerForm.html
        ///</summary>
        public static Engine HornerForm(this Engine en, string? name = null)
        {
            return en.Execute("HornerForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the IP address for the host with the specified name.
        /// https://reference.wolfram.com/language/ref/HostLookup.html
        ///</summary>
        public static Engine HostLookup(this Engine en, string? name = null)
        {
            return en.Execute("HostLookup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an object that represents an error response to an HTTP request, with specified error code.
        /// https://reference.wolfram.com/language/ref/HTTPErrorResponse.html
        ///</summary>
        public static Engine HTTPErrorResponse(this Engine en, string? name = null)
        {
            return en.Execute("HTTPErrorResponse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an HTTP redirect to the specified uri.
        /// https://reference.wolfram.com/language/ref/HTTPRedirect.html
        ///</summary>
        public static Engine HTTPRedirect(this Engine en, string? name = null)
        {
            return en.Execute("HTTPRedirect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an HTTP request for the specified URL.
        /// https://reference.wolfram.com/language/ref/HTTPRequest.html
        ///</summary>
        public static Engine HTTPRequest(this Engine en, string? name = null)
        {
            return en.Execute("HTTPRequest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the value of the specified property of the current HTTP request.
        /// https://reference.wolfram.com/language/ref/HTTPRequestData.html
        ///</summary>
        public static Engine HTTPRequestData(this Engine en, string? name = null)
        {
            return en.Execute("HTTPRequestData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an object that represents a successful response to an HTTP request, with the specified body and default metadata.
        /// https://reference.wolfram.com/language/ref/HTTPResponse.html
        ///</summary>
        public static Engine HTTPResponse(this Engine en, string? name = null)
        {
            return en.Execute("HTTPResponse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a color in the HSB color space with hue h.
        /// https://reference.wolfram.com/language/ref/Hue.html
        ///</summary>
        public static Engine Hue(this Engine en, string? name = null)
        {
            return en.Execute("Hue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the range of values within one standard deviation of the mean for all properties of human growth at the specification spec.
        /// https://reference.wolfram.com/language/ref/HumanGrowthData.html
        ///</summary>
        public static Engine HumanGrowthData(this Engine en, string? name = null)
        {
            return en.Execute("HumanGrowthData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n-dimensional hypercube graph .
        /// https://reference.wolfram.com/language/ref/HypercubeGraph.html
        ///</summary>
        public static Engine HypercubeGraph(this Engine en, string? name = null)
        {
            return en.Execute("HypercubeGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the hyperfactorial function .
        /// https://reference.wolfram.com/language/ref/Hyperfactorial.html
        ///</summary>
        public static Engine Hyperfactorial(this Engine en, string? name = null)
        {
            return en.Execute("Hyperfactorial[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a hyperlink that jumps to the specified URI when clicked.
        /// https://reference.wolfram.com/language/ref/Hyperlink.html
        ///</summary>
        public static Engine Hyperlink(this Engine en, string? name = null)
        {
            return en.Execute("Hyperlink[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an m-phase hypoexponential distribution with rates λ1, …, λm.
        /// https://reference.wolfram.com/language/ref/HypoexponentialDistribution.html
        ///</summary>
        public static Engine HypoexponentialDistribution(this Engine en, string? name = null)
        {
            return en.Execute("HypoexponentialDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents hypothesis test data such as generated by DistributionFitTest, AndersonDarlingTest, etc.
        /// https://reference.wolfram.com/language/ref/HypothesisTestData.html
        ///</summary>
        public static Engine HypothesisTestData(this Engine en, string? name = null)
        {
            return en.Execute("HypothesisTestData[" + en.ValidNames.Last() + "]", name);
        }


    }
}
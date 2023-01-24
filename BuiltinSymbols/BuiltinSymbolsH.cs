namespace NetWolf
{
    public static class BuiltinSymbolH
    {
        ///<summary>
        ///represents a Haar wavelet.
        ///https://reference.wolfram.com/language/ref/HaarWavelet.html
        ///</summary>
        public static Engine HaarWavelet(this Engine en, string? name = null)
        {
            return en.Execute("HaarWavelet[]", name);
        }

        ///<summary>
        ///returns an n×n Hadamard matrix.
        ///https://reference.wolfram.com/language/ref/HadamardMatrix.html
        ///</summary>
        public static Engine HadamardMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HadamardMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the half-line from the point p1 through p2.
        ///https://reference.wolfram.com/language/ref/HalfLine.html
        ///</summary>
        public static Engine HalfLine(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("HalfLine[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the half-line from the point p in the direction v.
        ///https://reference.wolfram.com/language/ref/HalfLine.html
        ///</summary>
        public static Engine HalfLine(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HalfLine[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a half-normal distribution with scale inversely proportional to parameter θ.
        ///https://reference.wolfram.com/language/ref/HalfNormalDistribution.html
        ///</summary>
        public static Engine HalfNormalDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HalfNormalDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the half-plane bounded by the line through p1 and p2 and extended in the direction w.
        ///https://reference.wolfram.com/language/ref/HalfPlane.html
        ///</summary>
        public static Engine HalfPlane(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("HalfPlane[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the half-plane bounded by the line through p along v and extended in the direction w.
        ///https://reference.wolfram.com/language/ref/HalfPlane.html
        ///</summary>
        public static Engine HalfPlane(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HalfPlane[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the half-space of points  such that .
        ///https://reference.wolfram.com/language/ref/HalfSpace.html
        ///</summary>
        public static Engine HalfSpace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HalfSpace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive specifying that surfaces that follow are to be drawn with a base pattern of dots.
        ///https://reference.wolfram.com/language/ref/HalftoneShading.html
        ///</summary>
        public static Engine HalftoneShading(this Engine en, string? name = null)
        {
            return en.Execute("HalftoneShading[]", name);
        }

        ///<summary>
        ///uses the density d of shading.
        ///https://reference.wolfram.com/language/ref/HalftoneShading.html
        ///</summary>
        public static Engine HalftoneShading(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HalftoneShading[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses a fixed pattern of "shape" with the specified color col and density d.
        ///https://reference.wolfram.com/language/ref/HalftoneShading.html
        ///</summary>
        public static Engine HalftoneShading(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HalftoneShading[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is Hamiltonian, and False otherwise.
        ///https://reference.wolfram.com/language/ref/HamiltonianGraphQ.html
        ///</summary>
        public static Engine HamiltonianGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HamiltonianGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Hamming distance between strings, vectors or biomolecular sequences u and v.
        ///https://reference.wolfram.com/language/ref/HammingDistance.html
        ///</summary>
        public static Engine HammingDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HammingDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Hamming window function of x.
        ///https://reference.wolfram.com/language/ref/HammingWindow.html
        ///</summary>
        public static Engine HammingWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HammingWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Hankel function of the first kind .
        ///https://reference.wolfram.com/language/ref/HankelH1.html
        ///</summary>
        public static Engine HankelH1(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HankelH1[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Hankel function of the second kind .
        ///https://reference.wolfram.com/language/ref/HankelH2.html
        ///</summary>
        public static Engine HankelH2(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HankelH2[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the n×n Hankel matrix with first row and first column being successive integers.
        ///https://reference.wolfram.com/language/ref/HankelMatrix.html
        ///</summary>
        public static Engine HankelMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HankelMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Hankel matrix whose first column consists of elements c1, c2, ….
        ///https://reference.wolfram.com/language/ref/HankelMatrix.html
        ///</summary>
        public static Engine HankelMatrix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("HankelMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Hankel matrix with elements ci down the first column, and ri across the last row.
        ///https://reference.wolfram.com/language/ref/HankelMatrix.html
        ///</summary>
        public static Engine HankelMatrix(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HankelMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Hankel transform of order 0 for expr.
        ///https://reference.wolfram.com/language/ref/HankelTransform.html
        ///</summary>
        public static Engine HankelTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HankelTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Hankel transform of order ν for expr.
        ///https://reference.wolfram.com/language/ref/HankelTransform.html
        ///</summary>
        public static Engine HankelTransform(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HankelTransform[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a Hann–Poisson window function of x.
        ///https://reference.wolfram.com/language/ref/HannPoissonWindow.html
        ///</summary>
        public static Engine HannPoissonWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HannPoissonWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the parameter α.
        ///https://reference.wolfram.com/language/ref/HannPoissonWindow.html
        ///</summary>
        public static Engine HannPoissonWindow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HannPoissonWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Hann window function of x.
        ///https://reference.wolfram.com/language/ref/HannWindow.html
        ///</summary>
        public static Engine HannWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HannWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the parameter α.
        ///https://reference.wolfram.com/language/ref/HannWindow.html
        ///</summary>
        public static Engine HannWindow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HannWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Harada–Norton group .
        ///https://reference.wolfram.com/language/ref/HaradaNortonGroupHN.html
        ///</summary>
        public static Engine HaradaNortonGroupHN(this Engine en, string? name = null)
        {
            return en.Execute("HaradaNortonGroupHN[]", name);
        }

        ///<summary>
        ///generates the minimal k-connected graph on n vertices .
        ///https://reference.wolfram.com/language/ref/HararyGraph.html
        ///</summary>
        public static Engine HararyGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HararyGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a hard-core point process with constant intensity μ and hard-core radius rh in .
        ///https://reference.wolfram.com/language/ref/HardcorePointProcess.html
        ///</summary>
        public static Engine HardcorePointProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HardcorePointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the harmonic mean of the values in list.
        ///https://reference.wolfram.com/language/ref/HarmonicMean.html
        ///</summary>
        public static Engine HarmonicMean(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HarmonicMean[" + arg0 + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the harmonic mean value in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/HarmonicMeanFilter.html
        ///</summary>
        public static Engine HarmonicMeanFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HarmonicMeanFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses ri for filtering the dimension in data.
        ///https://reference.wolfram.com/language/ref/HarmonicMeanFilter.html
        ///</summary>
        public static Engine HarmonicMeanFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HarmonicMeanFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n harmonic number .
        ///https://reference.wolfram.com/language/ref/HarmonicNumber.html
        ///</summary>
        public static Engine HarmonicNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HarmonicNumber[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the harmonic number  of order r.
        ///https://reference.wolfram.com/language/ref/HarmonicNumber.html
        ///</summary>
        public static Engine HarmonicNumber(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HarmonicNumber[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an integer hash code for the expression expr.
        ///https://reference.wolfram.com/language/ref/Hash.html
        ///</summary>
        public static Engine Hash(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Hash[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an integer hash digest of the specified type for expr.
        ///https://reference.wolfram.com/language/ref/Hash.html
        ///</summary>
        public static Engine Hash(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Hash[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a hash code in the specified format.
        ///https://reference.wolfram.com/language/ref/Hash.html
        ///</summary>
        public static Engine Hash(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Hash[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics directive that specifies that faces of polygons and other filled graphics objects are to be drawn using closely spaced parallel lines.
        ///https://reference.wolfram.com/language/ref/HatchFilling.html
        ///</summary>
        public static Engine HatchFilling(this Engine en, string? name = null)
        {
            return en.Execute("HatchFilling[]", name);
        }

        ///<summary>
        ///uses the specified line hatching "name".
        ///https://reference.wolfram.com/language/ref/HatchFilling.html
        ///</summary>
        public static Engine HatchFilling(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HatchFilling[" + arg0 + "]", name);
        }

        ///<summary>
        ///draws parallel lines with absolute thickness r.
        ///https://reference.wolfram.com/language/ref/HatchFilling.html
        ///</summary>
        public static Engine HatchFilling(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HatchFilling[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///draws parallel lines with gaps of absolute thickness d.
        ///https://reference.wolfram.com/language/ref/HatchFilling.html
        ///</summary>
        public static Engine HatchFilling(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HatchFilling[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive specifying that objects that follow are to be drawn with closely spaced parallel lines.
        ///https://reference.wolfram.com/language/ref/HatchShading.html
        ///</summary>
        public static Engine HatchShading(this Engine en, string? name = null)
        {
            return en.Execute("HatchShading[]", name);
        }

        ///<summary>
        ///uses the density d of shading.
        ///https://reference.wolfram.com/language/ref/HatchShading.html
        ///</summary>
        public static Engine HatchShading(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HatchShading[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses lines with the specified color col and density d.
        ///https://reference.wolfram.com/language/ref/HatchShading.html
        ///</summary>
        public static Engine HatchShading(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HatchShading[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the haversine function .
        ///https://reference.wolfram.com/language/ref/Haversine.html
        ///</summary>
        public static Engine Haversine(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Haversine[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the hazard function for the distribution dist evaluated at x.
        ///https://reference.wolfram.com/language/ref/HazardFunction.html
        ///</summary>
        public static Engine HazardFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HazardFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multivariate hazard function for the distribution dist evaluated at {x1,x2,…}.
        ///https://reference.wolfram.com/language/ref/HazardFunction.html
        ///</summary>
        public static Engine HazardFunction(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HazardFunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the hazard function as a pure function.
        ///https://reference.wolfram.com/language/ref/HazardFunction.html
        ///</summary>
        public static Engine HazardFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HazardFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the head of expr.
        ///https://reference.wolfram.com/language/ref/Head.html
        ///</summary>
        public static Engine Head(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Head[" + arg0 + "]", name);
        }

        ///<summary>
        ///wraps the result with h.
        ///https://reference.wolfram.com/language/ref/Head.html
        ///</summary>
        public static Engine Head(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Head[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a thermal heat flux boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/HeatFluxValue.html
        ///</summary>
        public static Engine HeatFluxValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeatFluxValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a thermal heat flux boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/HeatFluxValue.html
        ///</summary>
        public static Engine HeatFluxValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HeatFluxValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a thermal insulation boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/HeatInsulationValue.html
        ///</summary>
        public static Engine HeatInsulationValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeatInsulationValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a thermal insulation boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/HeatInsulationValue.html
        ///</summary>
        public static Engine HeatInsulationValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HeatInsulationValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a thermal outflow boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/HeatOutflowValue.html
        ///</summary>
        public static Engine HeatOutflowValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeatOutflowValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a thermal outflow boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/HeatOutflowValue.html
        ///</summary>
        public static Engine HeatOutflowValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HeatOutflowValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a thermal radiation boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/HeatRadiationValue.html
        ///</summary>
        public static Engine HeatRadiationValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeatRadiationValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a thermal radiation boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/HeatRadiationValue.html
        ///</summary>
        public static Engine HeatRadiationValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HeatRadiationValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a thermal symmetry boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/HeatSymmetryValue.html
        ///</summary>
        public static Engine HeatSymmetryValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeatSymmetryValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a thermal symmetry boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/HeatSymmetryValue.html
        ///</summary>
        public static Engine HeatSymmetryValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HeatSymmetryValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a thermal surface boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/HeatTemperatureCondition.html
        ///</summary>
        public static Engine HeatTemperatureCondition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeatTemperatureCondition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a thermal surface boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/HeatTemperatureCondition.html
        ///</summary>
        public static Engine HeatTemperatureCondition(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HeatTemperatureCondition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///yields a heat transfer PDE term with variables vars and parameters pars.
        ///https://reference.wolfram.com/language/ref/HeatTransferPDEComponent.html
        ///</summary>
        public static Engine HeatTransferPDEComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HeatTransferPDEComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a thermal transfer boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/HeatTransferValue.html
        ///</summary>
        public static Engine HeatTransferValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeatTransferValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a thermal transfer boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/HeatTransferValue.html
        ///</summary>
        public static Engine HeatTransferValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HeatTransferValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents the triangle distribution  which is nonzero for .
        ///https://reference.wolfram.com/language/ref/HeavisideLambda.html
        ///</summary>
        public static Engine HeavisideLambda(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HeavisideLambda[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the multidimensional triangle distribution  which is nonzero for .
        ///https://reference.wolfram.com/language/ref/HeavisideLambda.html
        ///</summary>
        public static Engine HeavisideLambda(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeavisideLambda[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the box distribution , equal to 1 for  and 0 for .
        ///https://reference.wolfram.com/language/ref/HeavisidePi.html
        ///</summary>
        public static Engine HeavisidePi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HeavisidePi[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the multidimensional box distribution  which is 1 if all .
        ///https://reference.wolfram.com/language/ref/HeavisidePi.html
        ///</summary>
        public static Engine HeavisidePi(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeavisidePi[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the Heaviside theta function , equal to 0 for  and 1 for .
        ///https://reference.wolfram.com/language/ref/HeavisideTheta.html
        ///</summary>
        public static Engine HeavisideTheta(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HeavisideTheta[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the multidimensional Heaviside theta function, which is 1 only if all of the xi are positive.
        ///https://reference.wolfram.com/language/ref/HeavisideTheta.html
        ///</summary>
        public static Engine HeavisideTheta(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HeavisideTheta[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Held group .
        ///https://reference.wolfram.com/language/ref/HeldGroupHe.html
        ///</summary>
        public static Engine HeldGroupHe(this Engine en, string? name = null)
        {
            return en.Execute("HeldGroupHe[]", name);
        }

        ///<summary>
        ///yields a Helmholtz PDE term  with model variables vars and model parameters pars.
        ///https://reference.wolfram.com/language/ref/HelmholtzPDEComponent.html
        ///</summary>
        public static Engine HelmholtzPDEComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HelmholtzPDEComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Hermite normal form decomposition of an integer matrix .
        ///https://reference.wolfram.com/language/ref/HermiteDecomposition.html
        ///</summary>
        public static Engine HermiteDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HermiteDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Hermite polynomial .
        ///https://reference.wolfram.com/language/ref/HermiteH.html
        ///</summary>
        public static Engine HermiteH(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HermiteH[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the symmetry of a Hermitian matrix.
        ///https://reference.wolfram.com/language/ref/Hermitian.html
        ///</summary>
        public static Engine Hermitian(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Hermitian[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly Hermitian, and False otherwise.
        ///https://reference.wolfram.com/language/ref/HermitianMatrixQ.html
        ///</summary>
        public static Engine HermitianMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HermitianMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Hessenberg decomposition of a numerical matrix m.
        ///https://reference.wolfram.com/language/ref/HessenbergDecomposition.html
        ///</summary>
        public static Engine HessenbergDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HessenbergDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the bi-confluent Heun function.
        ///https://reference.wolfram.com/language/ref/HeunB.html
        ///</summary>
        public static Engine HeunB(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("HeunB[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the -derivative of the HeunB function.
        ///https://reference.wolfram.com/language/ref/HeunBPrime.html
        ///</summary>
        public static Engine HeunBPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("HeunBPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the confluent Heun function.
        ///https://reference.wolfram.com/language/ref/HeunC.html
        ///</summary>
        public static Engine HeunC(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("HeunC[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the -derivative of the HeunC function.
        ///https://reference.wolfram.com/language/ref/HeunCPrime.html
        ///</summary>
        public static Engine HeunCPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("HeunCPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the double-confluent Heun function.
        ///https://reference.wolfram.com/language/ref/HeunD.html
        ///</summary>
        public static Engine HeunD(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("HeunD[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the -derivative of the HeunD function.
        ///https://reference.wolfram.com/language/ref/HeunDPrime.html
        ///</summary>
        public static Engine HeunDPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("HeunDPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the general Heun function.
        ///https://reference.wolfram.com/language/ref/HeunG.html
        ///</summary>
        public static Engine HeunG(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, string? name = null)
        {
            return en.Execute("HeunG[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + "]", name);
        }

        ///<summary>
        ///gives the -derivative of the HeunG function.
        ///https://reference.wolfram.com/language/ref/HeunGPrime.html
        ///</summary>
        public static Engine HeunGPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, string? name = null)
        {
            return en.Execute("HeunGPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + "]", name);
        }

        ///<summary>
        ///gives the tri-confluent Heun function.
        ///https://reference.wolfram.com/language/ref/HeunT.html
        ///</summary>
        public static Engine HeunT(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("HeunT[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the -derivative of the HeunT function.
        ///https://reference.wolfram.com/language/ref/HeunTPrime.html
        ///</summary>
        public static Engine HeunTPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("HeunTPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///represents a filled hexahedron with corners p1, p2, …, p8.
        ///https://reference.wolfram.com/language/ref/Hexahedron.html
        ///</summary>
        public static Engine Hexahedron(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Hexahedron[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a collection of hexahedra.
        ///https://reference.wolfram.com/language/ref/Hexahedron.html
        ///</summary>
        public static Engine Hexahedron(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Hexahedron[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a discrete-time, finite-state hidden Markov process with transition matrix m, emission matrix em, and initial hidden state i0.
        ///https://reference.wolfram.com/language/ref/HiddenMarkovProcess.html
        ///</summary>
        public static Engine HiddenMarkovProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HiddenMarkovProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a hidden Markov process with emission distributions disti.
        ///https://reference.wolfram.com/language/ref/HiddenMarkovProcess.html
        ///</summary>
        public static Engine HiddenMarkovProcess(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("HiddenMarkovProcess[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///displays a highlighted version of expr.
        ///https://reference.wolfram.com/language/ref/Highlighted.html
        ///</summary>
        public static Engine Highlighted(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Highlighted[" + arg0 + "]", name);
        }

        ///<summary>
        ///highlights the ai that can be vertices, edges, or subgraphs of g.
        ///https://reference.wolfram.com/language/ref/HighlightGraph.html
        ///</summary>
        public static Engine HighlightGraph(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HighlightGraph[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/HighlightGraph.html
        ///</summary>
        public static Engine HighlightGraph(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("HighlightGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///highlights the specified region of interest roi in image.
        ///https://reference.wolfram.com/language/ref/HighlightImage.html
        ///</summary>
        public static Engine HighlightImage(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HighlightImage[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///highlights several regions of interest roii.
        ///https://reference.wolfram.com/language/ref/HighlightImage.html
        ///</summary>
        public static Engine HighlightImage(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HighlightImage[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///applies the styling bgstyle to the complement of all the regions of interest.
        ///https://reference.wolfram.com/language/ref/HighlightImage.html
        ///</summary>
        public static Engine HighlightImage(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HighlightImage[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///highlights the cells specified by cellspeci in the mesh region mr.
        ///https://reference.wolfram.com/language/ref/HighlightMesh.html
        ///</summary>
        public static Engine HighlightMesh(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HighlightMesh[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///applies a highpass filter with a cutoff frequency ωc to an array of data.
        ///https://reference.wolfram.com/language/ref/HighpassFilter.html
        ///</summary>
        public static Engine HighpassFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HighpassFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a filter kernel of length n.
        ///https://reference.wolfram.com/language/ref/HighpassFilter.html
        ///</summary>
        public static Engine HighpassFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HighpassFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies a smoothing window wfun to the filter kernel.
        ///https://reference.wolfram.com/language/ref/HighpassFilter.html
        ///</summary>
        public static Engine HighpassFilter(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HighpassFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Higman–Sims group .
        ///https://reference.wolfram.com/language/ref/HigmanSimsGroupHS.html
        ///</summary>
        public static Engine HigmanSimsGroupHS(this Engine en, string? name = null)
        {
            return en.Execute("HigmanSimsGroupHS[]", name);
        }

        ///<summary>
        ///gives the line segments representing the n-step Hilbert curve.
        ///https://reference.wolfram.com/language/ref/HilbertCurve.html
        ///</summary>
        public static Engine HilbertCurve(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HilbertCurve[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n-step Hilbert curve in dimension d.
        ///https://reference.wolfram.com/language/ref/HilbertCurve.html
        ///</summary>
        public static Engine HilbertCurve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HilbertCurve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies a Hilbert filter with a cutoff frequency ωc to an array of data.
        ///https://reference.wolfram.com/language/ref/HilbertFilter.html
        ///</summary>
        public static Engine HilbertFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HilbertFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a filter kernel of length n.
        ///https://reference.wolfram.com/language/ref/HilbertFilter.html
        ///</summary>
        public static Engine HilbertFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HilbertFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies a smoothing window wfun to the filter kernel.
        ///https://reference.wolfram.com/language/ref/HilbertFilter.html
        ///</summary>
        public static Engine HilbertFilter(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HilbertFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the n×n Hilbert matrix with elements of the form .
        ///https://reference.wolfram.com/language/ref/HilbertMatrix.html
        ///</summary>
        public static Engine HilbertMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HilbertMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the m×n Hilbert matrix.
        ///https://reference.wolfram.com/language/ref/HilbertMatrix.html
        ///</summary>
        public static Engine HilbertMatrix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("HilbertMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots a histogram of the values xi.
        ///https://reference.wolfram.com/language/ref/Histogram.html
        ///</summary>
        public static Engine Histogram(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Histogram[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots a histogram with bin width specification bspec.
        ///https://reference.wolfram.com/language/ref/Histogram.html
        ///</summary>
        public static Engine Histogram(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Histogram[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots a histogram with bin heights computed according to the specification hspec.
        ///https://reference.wolfram.com/language/ref/Histogram.html
        ///</summary>
        public static Engine Histogram(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Histogram[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots a 3D histogram of the values {xi,yi}.
        ///https://reference.wolfram.com/language/ref/Histogram3D.html
        ///</summary>
        public static Engine Histogram3D(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Histogram3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots a 3D histogram with bins specified by bspec.
        ///https://reference.wolfram.com/language/ref/Histogram3D.html
        ///</summary>
        public static Engine Histogram3D(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Histogram3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots a 3D histogram with bin heights computed according to the specification hspec.
        ///https://reference.wolfram.com/language/ref/Histogram3D.html
        ///</summary>
        public static Engine Histogram3D(this Engine en, List<object> arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Histogram3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///plots 3D histograms for multiple datasets datai.
        ///https://reference.wolfram.com/language/ref/Histogram3D.html
        ///</summary>
        public static Engine Histogram3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Histogram3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the probability distribution corresponding to a histogram of the data values xi.
        ///https://reference.wolfram.com/language/ref/HistogramDistribution.html
        ///</summary>
        public static Engine HistogramDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("HistogramDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a multivariate histogram distribution based on data values {xi,yi,…}.
        ///https://reference.wolfram.com/language/ref/HistogramDistribution.html
        ///</summary>
        public static Engine HistogramDistribution(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HistogramDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a histogram distribution with bins specified by bspec.
        ///https://reference.wolfram.com/language/ref/HistogramDistribution.html
        ///</summary>
        public static Engine HistogramDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HistogramDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of bins and histogram heights of the values xi.
        ///https://reference.wolfram.com/language/ref/HistogramList.html
        ///</summary>
        public static Engine HistogramList(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("HistogramList[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of bins and histogram heights of the values {xi,yi,…}.
        ///https://reference.wolfram.com/language/ref/HistogramList.html
        ///</summary>
        public static Engine HistogramList(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HistogramList[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of bins and histogram heights with bins specified by bspec.
        ///https://reference.wolfram.com/language/ref/HistogramList.html
        ///</summary>
        public static Engine HistogramList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HistogramList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of bins and histogram heights with bin heights computed according to the specification hspec.
        ///https://reference.wolfram.com/language/ref/HistogramList.html
        ///</summary>
        public static Engine HistogramList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HistogramList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///estimates the histogram point density function  for point data pdata.
        ///https://reference.wolfram.com/language/ref/HistogramPointDensity.html
        ///</summary>
        public static Engine HistogramPointDensity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HistogramPointDensity[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the histogram point density function  with histogram bins specified by bspec.
        ///https://reference.wolfram.com/language/ref/HistogramPointDensity.html
        ///</summary>
        public static Engine HistogramPointDensity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HistogramPointDensity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the histogram point density function  for binned data bdata.
        ///https://reference.wolfram.com/language/ref/HistogramPointDensity.html
        ///</summary>
        public static Engine HistogramPointDensity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HistogramPointDensity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///transforms pixel values of image so that its histogram is nearly flat.
        ///https://reference.wolfram.com/language/ref/HistogramTransform.html
        ///</summary>
        public static Engine HistogramTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HistogramTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///modifies pixel values of image so that its histogram would have nearly the same distribution as ref.
        ///https://reference.wolfram.com/language/ref/HistogramTransform.html
        ///</summary>
        public static Engine HistogramTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HistogramTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses n equally spaced quantiles.
        ///https://reference.wolfram.com/language/ref/HistogramTransform.html
        ///</summary>
        public static Engine HistogramTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HistogramTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///transforms values xi.
        ///https://reference.wolfram.com/language/ref/HistogramTransform.html
        ///</summary>
        public static Engine HistogramTransform(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("HistogramTransform[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a function  so that the transformed values  are distributed nearly uniformly.
        ///https://reference.wolfram.com/language/ref/HistogramTransformInterpolation.html
        ///</summary>
        public static Engine HistogramTransformInterpolation(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("HistogramTransformInterpolation[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds  so that  are distributed with distribution ref.
        ///https://reference.wolfram.com/language/ref/HistogramTransformInterpolation.html
        ///</summary>
        public static Engine HistogramTransformInterpolation(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("HistogramTransformInterpolation[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a function with n equally spaced quantiles.
        ///https://reference.wolfram.com/language/ref/HistogramTransformInterpolation.html
        ///</summary>
        public static Engine HistogramTransformInterpolation(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HistogramTransformInterpolation[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a function that reshapes the histogram of image.
        ///https://reference.wolfram.com/language/ref/HistogramTransformInterpolation.html
        ///</summary>
        public static Engine HistogramTransformInterpolation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HistogramTransformInterpolation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the historical period entity.
        ///https://reference.wolfram.com/language/ref/HistoricalPeriodData.html
        ///</summary>
        public static Engine HistoricalPeriodData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HistoricalPeriodData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified historical period entities.
        ///https://reference.wolfram.com/language/ref/HistoricalPeriodData.html
        ///</summary>
        public static Engine HistoricalPeriodData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("HistoricalPeriodData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/HistoricalPeriodData.html
        ///</summary>
        public static Engine HistoricalPeriodData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HistoricalPeriodData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the hit-or-miss transform of image with respect to the composite structuring element ker.
        ///https://reference.wolfram.com/language/ref/HitMissTransform.html
        ///</summary>
        public static Engine HitMissTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HitMissTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the union of the hit-or-miss transforms for all the structuring elements keri.
        ///https://reference.wolfram.com/language/ref/HitMissTransform.html
        ///</summary>
        public static Engine HitMissTransform(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HitMissTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///treats values above t as foreground.
        ///https://reference.wolfram.com/language/ref/HitMissTransform.html
        ///</summary>
        public static Engine HitMissTransform(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("HitMissTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of authority and hub centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/HITSCentrality.html
        ///</summary>
        public static Engine HITSCentrality(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HITSCentrality[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/HITSCentrality.html
        ///</summary>
        public static Engine HITSCentrality(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("HITSCentrality[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the Hjorth distribution with location parameter m, scale parameter s, and shape parameter f.
        ///https://reference.wolfram.com/language/ref/HjorthDistribution.html
        ///</summary>
        public static Engine HjorthDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HjorthDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Hodge dual of the tensor
        ///https://reference.wolfram.com/language/ref/HodgeDual.html
        ///</summary>
        public static Engine HodgeDual(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HodgeDual[" + arg0 + "]", name);
        }

        ///<summary>
        ///dualizes tensor in the slots with dimension dim
        ///https://reference.wolfram.com/language/ref/HodgeDual.html
        ///</summary>
        public static Engine HodgeDual(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HodgeDual[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///dualizes tensor in the given slots.
        ///https://reference.wolfram.com/language/ref/HodgeDual.html
        ///</summary>
        public static Engine HodgeDual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HodgeDual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives Hoeffding's dependence measure  for the vectors v1 and v2.
        ///https://reference.wolfram.com/language/ref/HoeffdingD.html
        ///</summary>
        public static Engine HoeffdingD(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HoeffdingD[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives Hoeffding's dependence measure  for the matrix m.
        ///https://reference.wolfram.com/language/ref/HoeffdingD.html
        ///</summary>
        public static Engine HoeffdingD(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HoeffdingD[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the  element of  for the multivariate symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/HoeffdingD.html
        ///</summary>
        public static Engine HoeffdingD(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HoeffdingD[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the vectors v1 and v2 are independent.
        ///https://reference.wolfram.com/language/ref/HoeffdingDTest.html
        ///</summary>
        public static Engine HoeffdingDTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HoeffdingDTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///maintains expr in an unevaluated form.
        ///https://reference.wolfram.com/language/ref/Hold.html
        ///</summary>
        public static Engine Hold(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Hold[" + arg0 + "]", name);
        }

        ///<summary>
        ///shields expr completely from the standard Wolfram Language evaluation process, preventing even upvalues associated with expr from being used.
        ///https://reference.wolfram.com/language/ref/HoldComplete.html
        ///</summary>
        public static Engine HoldComplete(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HoldComplete[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as the expression expr, with expr maintained in an unevaluated form.
        ///https://reference.wolfram.com/language/ref/HoldForm.html
        ///</summary>
        public static Engine HoldForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HoldForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///is equivalent to expr for pattern matching, but maintains expr in an unevaluated form.
        ///https://reference.wolfram.com/language/ref/HoldPattern.html
        ///</summary>
        public static Engine HoldPattern(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HoldPattern[" + arg0 + "]", name);
        }

        ///<summary>
        ///draws a linear gauge showing value in a range of 0 to 1.
        ///https://reference.wolfram.com/language/ref/HorizontalGauge.html
        ///</summary>
        public static Engine HorizontalGauge(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HorizontalGauge[" + arg0 + "]", name);
        }

        ///<summary>
        ///draws a linear gauge showing value in a range of min to max.
        ///https://reference.wolfram.com/language/ref/HorizontalGauge.html
        ///</summary>
        public static Engine HorizontalGauge(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HorizontalGauge[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///allows value to be set interactively using the gauge.
        ///https://reference.wolfram.com/language/ref/HorizontalGauge.html
        ///</summary>
        public static Engine HorizontalGauge(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HorizontalGauge[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///draws a gauge showing multiple values.
        ///https://reference.wolfram.com/language/ref/HorizontalGauge.html
        ///</summary>
        public static Engine HorizontalGauge(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("HorizontalGauge[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///puts the polynomial poly in Horner form.
        ///https://reference.wolfram.com/language/ref/HornerForm.html
        ///</summary>
        public static Engine HornerForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HornerForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///puts poly in Horner form with respect to the variable or variable list vars.
        ///https://reference.wolfram.com/language/ref/HornerForm.html
        ///</summary>
        public static Engine HornerForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HornerForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///puts poly1/poly2 in Horner form using the variables or variable lists vars1 and vars2 for poly1 and poly2, respectively.
        ///https://reference.wolfram.com/language/ref/HornerForm.html
        ///</summary>
        public static Engine HornerForm(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HornerForm[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the IP address for the host with the specified name.
        ///https://reference.wolfram.com/language/ref/HostLookup.html
        ///</summary>
        public static Engine HostLookup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HostLookup[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a specified property of the host.
        ///https://reference.wolfram.com/language/ref/HostLookup.html
        ///</summary>
        public static Engine HostLookup(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HostLookup[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents Hotelling's  distribution with dimensionality parameter p and m degrees of freedom.
        ///https://reference.wolfram.com/language/ref/HotellingTSquareDistribution.html
        ///</summary>
        public static Engine HotellingTSquareDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HotellingTSquareDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Hoyt distribution with shape parameter q and spread parameter ω.
        ///https://reference.wolfram.com/language/ref/HoytDistribution.html
        ///</summary>
        public static Engine HoytDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HoytDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an object that represents an error response to an HTTP request, with specified error code.
        ///https://reference.wolfram.com/language/ref/HTTPErrorResponse.html
        ///</summary>
        public static Engine HTTPErrorResponse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HTTPErrorResponse[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an HTTP redirect to the specified uri.
        ///https://reference.wolfram.com/language/ref/HTTPRedirect.html
        ///</summary>
        public static Engine HTTPRedirect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HTTPRedirect[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an HTTP redirect to uri with the specified metadata.
        ///https://reference.wolfram.com/language/ref/HTTPRedirect.html
        ///</summary>
        public static Engine HTTPRedirect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HTTPRedirect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an HTTP request for the specified URL.
        ///https://reference.wolfram.com/language/ref/HTTPRequest.html
        ///</summary>
        public static Engine HTTPRequest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HTTPRequest[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an HTTP request for the specified URL with additional elements such as headers given by assoc.
        ///https://reference.wolfram.com/language/ref/HTTPRequest.html
        ///</summary>
        public static Engine HTTPRequest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HTTPRequest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property of the current HTTP request.
        ///https://reference.wolfram.com/language/ref/HTTPRequestData.html
        ///</summary>
        public static Engine HTTPRequestData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HTTPRequestData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an association with values of properties of the current HTTP request.
        ///https://reference.wolfram.com/language/ref/HTTPRequestData.html
        ///</summary>
        public static Engine HTTPRequestData(this Engine en, string? name = null)
        {
            return en.Execute("HTTPRequestData[]", name);
        }

        ///<summary>
        ///is an object that represents a successful response to an HTTP request, with the specified body and default metadata.
        ///https://reference.wolfram.com/language/ref/HTTPResponse.html
        ///</summary>
        public static Engine HTTPResponse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HTTPResponse[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a response to an HTTP request, including the specified body and metadata.
        ///https://reference.wolfram.com/language/ref/HTTPResponse.html
        ///</summary>
        public static Engine HTTPResponse(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HTTPResponse[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a color in the HSB color space with hue h.
        ///https://reference.wolfram.com/language/ref/Hue.html
        ///</summary>
        public static Engine Hue(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Hue[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies colors in terms of hue, saturation and brightness.
        ///https://reference.wolfram.com/language/ref/Hue.html
        ///</summary>
        public static Engine Hue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Hue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies opacity a.
        ///https://reference.wolfram.com/language/ref/Hue.html
        ///</summary>
        public static Engine Hue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Hue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///returns the range of values within one standard deviation of the mean for all properties of human growth at the specification spec.
        ///https://reference.wolfram.com/language/ref/HumanGrowthData.html
        ///</summary>
        public static Engine HumanGrowthData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HumanGrowthData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the range of values within one standard deviation of the mean of a property for the specification spec.
        ///https://reference.wolfram.com/language/ref/HumanGrowthData.html
        ///</summary>
        public static Engine HumanGrowthData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HumanGrowthData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value at a specific index of a property for spec at the specified percentile.
        ///https://reference.wolfram.com/language/ref/HumanGrowthData.html
        ///</summary>
        public static Engine HumanGrowthData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HumanGrowthData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/HumpDownHump.html
        ///</summary>
        public static Engine HumpDownHump(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HumpDownHump[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x≏y≏….
        ///https://reference.wolfram.com/language/ref/HumpEqual.html
        ///</summary>
        public static Engine HumpEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HumpEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Hurwitz–Lerch transcendent .
        ///https://reference.wolfram.com/language/ref/HurwitzLerchPhi.html
        ///</summary>
        public static Engine HurwitzLerchPhi(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HurwitzLerchPhi[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Hurwitz zeta function .
        ///https://reference.wolfram.com/language/ref/HurwitzZeta.html
        ///</summary>
        public static Engine HurwitzZeta(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("HurwitzZeta[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a hyperbolic distribution with location parameter μ, scale parameter δ, shape parameter α, and skewness parameter β.
        ///https://reference.wolfram.com/language/ref/HyperbolicDistribution.html
        ///</summary>
        public static Engine HyperbolicDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("HyperbolicDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a generalized hyperbolic distribution with shape parameter λ.
        ///https://reference.wolfram.com/language/ref/HyperbolicDistribution.html
        ///</summary>
        public static Engine HyperbolicDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("HyperbolicDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///gives the n-dimensional hypercube graph .
        ///https://reference.wolfram.com/language/ref/HypercubeGraph.html
        ///</summary>
        public static Engine HypercubeGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HypercubeGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an m-phase hyperexponential distribution with phase probabilities αi and rates λi.
        ///https://reference.wolfram.com/language/ref/HyperexponentialDistribution.html
        ///</summary>
        public static Engine HyperexponentialDistribution(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("HyperexponentialDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the hyperfactorial function .
        ///https://reference.wolfram.com/language/ref/Hyperfactorial.html
        ///</summary>
        public static Engine Hyperfactorial(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Hyperfactorial[" + arg0 + "]", name);
        }

        ///<summary>
        ///is the confluent hypergeometric function .
        ///https://reference.wolfram.com/language/ref/Hypergeometric0F1.html
        ///</summary>
        public static Engine Hypergeometric0F1(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Hypergeometric0F1[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the regularized confluent hypergeometric function .
        ///https://reference.wolfram.com/language/ref/Hypergeometric0F1Regularized.html
        ///</summary>
        public static Engine Hypergeometric0F1Regularized(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Hypergeometric0F1Regularized[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the Kummer confluent hypergeometric function .
        ///https://reference.wolfram.com/language/ref/Hypergeometric1F1.html
        ///</summary>
        public static Engine Hypergeometric1F1(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Hypergeometric1F1[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the regularized confluent hypergeometric function .
        ///https://reference.wolfram.com/language/ref/Hypergeometric1F1Regularized.html
        ///</summary>
        public static Engine Hypergeometric1F1Regularized(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Hypergeometric1F1Regularized[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the hypergeometric function .
        ///https://reference.wolfram.com/language/ref/Hypergeometric2F1.html
        ///</summary>
        public static Engine Hypergeometric2F1(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Hypergeometric2F1[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///is the regularized hypergeometric function .
        ///https://reference.wolfram.com/language/ref/Hypergeometric2F1Regularized.html
        ///</summary>
        public static Engine Hypergeometric2F1Regularized(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Hypergeometric2F1Regularized[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a hypergeometric distribution.
        ///https://reference.wolfram.com/language/ref/HypergeometricDistribution.html
        ///</summary>
        public static Engine HypergeometricDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HypergeometricDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the generalized hypergeometric function .
        ///https://reference.wolfram.com/language/ref/HypergeometricPFQ.html
        ///</summary>
        public static Engine HypergeometricPFQ(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("HypergeometricPFQ[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the regularized generalized hypergeometric function .
        ///https://reference.wolfram.com/language/ref/HypergeometricPFQRegularized.html
        ///</summary>
        public static Engine HypergeometricPFQRegularized(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("HypergeometricPFQRegularized[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the confluent hypergeometric function .
        ///https://reference.wolfram.com/language/ref/HypergeometricU.html
        ///</summary>
        public static Engine HypergeometricU(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("HypergeometricU[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a hyperlink that jumps to the specified URI when clicked.
        ///https://reference.wolfram.com/language/ref/Hyperlink.html
        ///</summary>
        public static Engine Hyperlink(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Hyperlink[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a hyperlink to be displayed as label.
        ///https://reference.wolfram.com/language/ref/Hyperlink.html
        ///</summary>
        public static Engine Hyperlink(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Hyperlink[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the hyperplane with normal n passing through the point p.
        ///https://reference.wolfram.com/language/ref/Hyperplane.html
        ///</summary>
        public static Engine Hyperplane(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Hyperplane[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an m-phase hypoexponential distribution with rates λ1, …, λm.
        ///https://reference.wolfram.com/language/ref/HypoexponentialDistribution.html
        ///</summary>
        public static Engine HypoexponentialDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("HypoexponentialDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents hypothesis test data such as generated by DistributionFitTest, AndersonDarlingTest, etc.
        ///https://reference.wolfram.com/language/ref/HypothesisTestData.html
        ///</summary>
        public static Engine HypothesisTestData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("HypothesisTestData[" + arg0 + "]", name);
        }


    }
}
namespace NetWolf
{
    public static class BuiltinSymbolW
    {
        ///<summary>
        ///waits for all concurrent evaluations represented by EvaluationObject expressions in expr to finish, then returns the resulting expression obtained.
        ///https://reference.wolfram.com/language/ref/WaitAll.html
        ///</summary>
        public static Engine WaitAll(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaitAll[" + arg0 + "]", name);
        }

        ///<summary>
        ///waits until the first evaluation represented by any of the eidi finishes, then returns its result, the corresponding eidi, and the list of remaining eidk.
        ///https://reference.wolfram.com/language/ref/WaitNext.html
        ///</summary>
        public static Engine WaitNext(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WaitNext[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///wraps the head h around the result before returning it.
        ///https://reference.wolfram.com/language/ref/WaitNext.html
        ///</summary>
        public static Engine WaitNext(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WaitNext[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents Wakeby distribution with shape parameters β and δ, scale parameters α and γ, and location parameter μ.
        ///https://reference.wolfram.com/language/ref/WakebyDistribution.html
        ///</summary>
        public static Engine WakebyDistribution(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
        {
            return en.Execute("WakebyDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents a Wallenius noncentral hypergeometric distribution.
        ///https://reference.wolfram.com/language/ref/WalleniusHypergeometricDistribution.html
        ///</summary>
        public static Engine WalleniusHypergeometricDistribution(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("WalleniusHypergeometricDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents the Yule distribution with shape parameter α.
        ///https://reference.wolfram.com/language/ref/WaringYuleDistribution.html
        ///</summary>
        public static Engine WaringYuleDistribution(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaringYuleDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the Waring distribution with shape parameters α and β.
        ///https://reference.wolfram.com/language/ref/WaringYuleDistribution.html
        ///</summary>
        public static Engine WaringYuleDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaringYuleDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the time warping (DTW) similarity path between sequences s1 and s2.
        ///https://reference.wolfram.com/language/ref/WarpingCorrespondence.html
        ///</summary>
        public static Engine WarpingCorrespondence(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WarpingCorrespondence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a window specified by win for local search.
        ///https://reference.wolfram.com/language/ref/WarpingCorrespondence.html
        ///</summary>
        public static Engine WarpingCorrespondence(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WarpingCorrespondence[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the dynamic time warping (DTW) distance between sequences s1 and s2.
        ///https://reference.wolfram.com/language/ref/WarpingDistance.html
        ///</summary>
        public static Engine WarpingDistance(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WarpingDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a window specified by win for local search.
        ///https://reference.wolfram.com/language/ref/WarpingDistance.html
        ///</summary>
        public static Engine WarpingDistance(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WarpingDistance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the watershed transform of image, returning the result as an array in which positive integers label the catchment basins.
        ///https://reference.wolfram.com/language/ref/WatershedComponents.html
        ///</summary>
        public static Engine WatershedComponents(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WatershedComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses a binary image marker to indicate regions where basins may be created.
        ///https://reference.wolfram.com/language/ref/WatershedComponents.html
        ///</summary>
        public static Engine WatershedComponents(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WatershedComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Watson  test.
        ///https://reference.wolfram.com/language/ref/WatsonUSquareTest.html
        ///</summary>
        public static Engine WatsonUSquareTest(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WatsonUSquareTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is distributed according to dist using the Watson  test.
        ///https://reference.wolfram.com/language/ref/WatsonUSquareTest.html
        ///</summary>
        public static Engine WatsonUSquareTest(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WatsonUSquareTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/WatsonUSquareTest.html
        ///</summary>
        public static Engine WatsonUSquareTest(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WatsonUSquareTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the Watts–Strogatz graph distribution for n-vertex graphs with rewiring probability p.
        ///https://reference.wolfram.com/language/ref/WattsStrogatzGraphDistribution.html
        ///</summary>
        public static Engine WattsStrogatzGraphDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WattsStrogatzGraphDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Watts–Strogatz graph distribution for n-vertex graphs with rewiring probability p starting from a 2k-regular graph.
        ///https://reference.wolfram.com/language/ref/WattsStrogatzGraphDistribution.html
        ///</summary>
        public static Engine WattsStrogatzGraphDistribution(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WattsStrogatzGraphDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes a best basis representation in the DiscreteWaveletData object dwd.
        ///https://reference.wolfram.com/language/ref/WaveletBestBasis.html
        ///</summary>
        public static Engine WaveletBestBasis(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaveletBestBasis[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes a best basis representation using the cost specification cspec.
        ///https://reference.wolfram.com/language/ref/WaveletBestBasis.html
        ///</summary>
        public static Engine WaveletBestBasis(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletBestBasis[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the filter coefficients for the symbolic wavelet wave of type filt.
        ///https://reference.wolfram.com/language/ref/WaveletFilterCoefficients.html
        ///</summary>
        public static Engine WaveletFilterCoefficients(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletFilterCoefficients[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots the basis tree of wavelet image coefficients in the DiscreteWaveletData dwd.
        ///https://reference.wolfram.com/language/ref/WaveletImagePlot.html
        ///</summary>
        public static Engine WaveletImagePlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaveletImagePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots coefficients up to refinement level r.
        ///https://reference.wolfram.com/language/ref/WaveletImagePlot.html
        ///</summary>
        public static Engine WaveletImagePlot(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletImagePlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies the image function ifunc to coefficients and wavelet indexes before plotting.
        ///https://reference.wolfram.com/language/ref/WaveletImagePlot.html
        ///</summary>
        public static Engine WaveletImagePlot(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WaveletImagePlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots wavelet transform coefficients in the DiscreteWaveletData dwd.
        ///https://reference.wolfram.com/language/ref/WaveletListPlot.html
        ///</summary>
        public static Engine WaveletListPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaveletListPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots wavelet transform coefficients corresponding to the wavelet index specification wind.
        ///https://reference.wolfram.com/language/ref/WaveletListPlot.html
        ///</summary>
        public static Engine WaveletListPlot(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletListPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies func to coefficients before plotting.
        ///https://reference.wolfram.com/language/ref/WaveletListPlot.html
        ///</summary>
        public static Engine WaveletListPlot(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WaveletListPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots wavelet transform coefficients from several DiscreteWaveletData objects dwd1, dwd2, ….
        ///https://reference.wolfram.com/language/ref/WaveletListPlot.html
        ///</summary>
        public static Engine WaveletListPlot(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletListPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies the function f to the arrays of coefficients and indices of a ContinuousWaveletData or DiscreteWaveletData object.
        ///https://reference.wolfram.com/language/ref/WaveletMapIndexed.html
        ///</summary>
        public static Engine WaveletMapIndexed(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletMapIndexed[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to the DiscreteWaveletData coefficients specified by wind.
        ///https://reference.wolfram.com/language/ref/WaveletMapIndexed.html
        ///</summary>
        public static Engine WaveletMapIndexed(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WaveletMapIndexed[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots the basis tree of wavelet matrix coefficients in the DiscreteWaveletData dwd.
        ///https://reference.wolfram.com/language/ref/WaveletMatrixPlot.html
        ///</summary>
        public static Engine WaveletMatrixPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaveletMatrixPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots coefficients up to refinement level r.
        ///https://reference.wolfram.com/language/ref/WaveletMatrixPlot.html
        ///</summary>
        public static Engine WaveletMatrixPlot(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletMatrixPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies func to coefficients before plotting.
        ///https://reference.wolfram.com/language/ref/WaveletMatrixPlot.html
        ///</summary>
        public static Engine WaveletMatrixPlot(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WaveletMatrixPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the scaling function  for the symbolic wavelet wave evaluated at x.
        ///https://reference.wolfram.com/language/ref/WaveletPhi.html
        ///</summary>
        public static Engine WaveletPhi(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletPhi[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the scaling function as a pure function.
        ///https://reference.wolfram.com/language/ref/WaveletPhi.html
        ///</summary>
        public static Engine WaveletPhi(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaveletPhi[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the wavelet function  for the symbolic wavelet wave evaluated at x.
        ///https://reference.wolfram.com/language/ref/WaveletPsi.html
        ///</summary>
        public static Engine WaveletPsi(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletPsi[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the wavelet function as a pure function.
        ///https://reference.wolfram.com/language/ref/WaveletPsi.html
        ///</summary>
        public static Engine WaveletPsi(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaveletPsi[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots wavelet vector coefficients in a DiscreteWaveletData or ContinuousWaveletData object wd.
        ///https://reference.wolfram.com/language/ref/WaveletScalogram.html
        ///</summary>
        public static Engine WaveletScalogram(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaveletScalogram[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots wavelet coefficients corresponding to the wavelet index specification wind.
        ///https://reference.wolfram.com/language/ref/WaveletScalogram.html
        ///</summary>
        public static Engine WaveletScalogram(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletScalogram[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies func to coefficients before plotting.
        ///https://reference.wolfram.com/language/ref/WaveletScalogram.html
        ///</summary>
        public static Engine WaveletScalogram(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WaveletScalogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///thresholds the detail wavelet coefficients in the DiscreteWaveletData object dwd.
        ///https://reference.wolfram.com/language/ref/WaveletThreshold.html
        ///</summary>
        public static Engine WaveletThreshold(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WaveletThreshold[" + arg0 + "]", name);
        }

        ///<summary>
        ///thresholds the coefficients using the thresholding specification tspec.
        ///https://reference.wolfram.com/language/ref/WaveletThreshold.html
        ///</summary>
        public static Engine WaveletThreshold(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WaveletThreshold[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///thresholds the wavelet coefficients given by the wavelet indices wind.
        ///https://reference.wolfram.com/language/ref/WaveletThreshold.html
        ///</summary>
        public static Engine WaveletThreshold(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WaveletThreshold[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a wave equation PDE term  with model variables vars and model parameters pars.
        ///https://reference.wolfram.com/language/ref/WavePDEComponent.html
        ///</summary>
        public static Engine WavePDEComponent(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WavePDEComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the weakly connected components of the graph g.
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedComponents.html
        ///</summary>
        public static Engine WeaklyConnectedComponents(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WeaklyConnectedComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the weakly connected components that include at least one of the vertices v1, v2, ….
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedComponents.html
        ///</summary>
        public static Engine WeaklyConnectedComponents(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WeaklyConnectedComponents[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the connected components that include a vertex that matches the pattern patt.
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedComponents.html
        ///</summary>
        public static Engine WeaklyConnectedComponents(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WeaklyConnectedComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedComponents.html
        ///</summary>
        public static Engine WeaklyConnectedComponents(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WeaklyConnectedComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the weakly connected components of the graph g.
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedGraphComponents.html
        ///</summary>
        public static Engine WeaklyConnectedGraphComponents(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WeaklyConnectedGraphComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the weakly connected components that include at least one of the vertices v1, v2, … .
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedGraphComponents.html
        ///</summary>
        public static Engine WeaklyConnectedGraphComponents(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WeaklyConnectedGraphComponents[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the connected components that include a vertex that matches the pattern patt.
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedGraphComponents.html
        ///</summary>
        public static Engine WeaklyConnectedGraphComponents(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WeaklyConnectedGraphComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedGraphComponents.html
        ///</summary>
        public static Engine WeaklyConnectedGraphComponents(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WeaklyConnectedGraphComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is weakly connected, and False otherwise.
        ///https://reference.wolfram.com/language/ref/WeaklyConnectedGraphQ.html
        ///</summary>
        public static Engine WeaklyConnectedGraphQ(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WeaklyConnectedGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives conditions for the process proc to be weakly stationary.
        ///https://reference.wolfram.com/language/ref/WeakStationarity.html
        ///</summary>
        public static Engine WeakStationarity(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WeakStationarity[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the most recent measurement for the specified weather property at the location corresponding to loc.
        ///https://reference.wolfram.com/language/ref/WeatherData.html
        ///</summary>
        public static Engine WeatherData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WeatherData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives all measurements during the specified date.
        ///https://reference.wolfram.com/language/ref/WeatherData.html
        ///</summary>
        public static Engine WeatherData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WeatherData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of dates and measurements for the time interval start to end.
        ///https://reference.wolfram.com/language/ref/WeatherData.html
        ///</summary>
        public static Engine WeatherData(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("WeatherData[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the most recent forecast for all weather forecast properties for the specified location.
        ///https://reference.wolfram.com/language/ref/WeatherForecastData.html
        ///</summary>
        public static Engine WeatherForecastData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WeatherForecastData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the forecast for the property at the specified location.
        ///https://reference.wolfram.com/language/ref/WeatherForecastData.html
        ///</summary>
        public static Engine WeatherForecastData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WeatherForecastData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the forecast at the time or times specified by datespec for the property at the location.
        ///https://reference.wolfram.com/language/ref/WeatherForecastData.html
        ///</summary>
        public static Engine WeatherForecastData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WeatherForecastData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a dataset of the top web audio search results for the specified literal string.
        ///https://reference.wolfram.com/language/ref/WebAudioSearch.html
        ///</summary>
        public static Engine WebAudioSearch(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebAudioSearch[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the elements of the web audio search specified by format.
        ///https://reference.wolfram.com/language/ref/WebAudioSearch.html
        ///</summary>
        public static Engine WebAudioSearch(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WebAudioSearch[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns only audio results that satisfy crit.
        ///https://reference.wolfram.com/language/ref/WebAudioSearch.html
        ///</summary>
        public static Engine WebAudioSearch(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WebAudioSearch[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an HTML column containing the expri.
        ///https://reference.wolfram.com/language/ref/WebColumn.html
        ///</summary>
        public static Engine WebColumn(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WebColumn[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///displays with expr formatted using the specified option settings.
        ///https://reference.wolfram.com/language/ref/WebColumn.html
        ///</summary>
        public static Engine WebColumn(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WebColumn[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an element of an open webpage operated on by WebExecute.
        ///https://reference.wolfram.com/language/ref/WebElementObject.html
        ///</summary>
        public static Engine WebElementObject(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebElementObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Weber function .
        ///https://reference.wolfram.com/language/ref/WeberE.html
        ///</summary>
        public static Engine WeberE(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WeberE[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the associated Weber function .
        ///https://reference.wolfram.com/language/ref/WeberE.html
        ///</summary>
        public static Engine WeberE(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WeberE[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///executes the command cmd in a web browser.
        ///https://reference.wolfram.com/language/ref/WebExecute.html
        ///</summary>
        public static Engine WebExecute(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebExecute[" + arg0 + "]", name);
        }

        ///<summary>
        ///executes a list of commands in sequence.
        ///https://reference.wolfram.com/language/ref/WebExecute.html
        ///</summary>
        public static Engine WebExecute(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WebExecute[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///executes cmds in the specified web session.
        ///https://reference.wolfram.com/language/ref/WebExecute.html
        ///</summary>
        public static Engine WebExecute(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WebExecute[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an image of the webpage specified by url.
        ///https://reference.wolfram.com/language/ref/WebImage.html
        ///</summary>
        public static Engine WebImage(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of thumbnails of the top web image search results for the specified literal string.
        ///https://reference.wolfram.com/language/ref/WebImageSearch.html
        ///</summary>
        public static Engine WebImageSearch(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebImageSearch[" + arg0 + "]", name);
        }

        ///<summary>
        ///picks out the first n top results obtained by doing the web image search specified by form.
        ///https://reference.wolfram.com/language/ref/WebImageSearch.html
        ///</summary>
        public static Engine WebImageSearch(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WebImageSearch[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///picks out the first n elements of the web image search specified by elems.
        ///https://reference.wolfram.com/language/ref/WebImageSearch.html
        ///</summary>
        public static Engine WebImageSearch(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WebImageSearch[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an HTML element containing expr.
        ///https://reference.wolfram.com/language/ref/WebItem.html
        ///</summary>
        public static Engine WebItem(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebItem[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an HTML element formatted using the specified option settings.
        ///https://reference.wolfram.com/language/ref/WebItem.html
        ///</summary>
        public static Engine WebItem(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WebItem[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an HTML column containing the expri.
        ///https://reference.wolfram.com/language/ref/WebRow.html
        ///</summary>
        public static Engine WebRow(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WebRow[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///displays with expr formatted using the specified option settings.
        ///https://reference.wolfram.com/language/ref/WebRow.html
        ///</summary>
        public static Engine WebRow(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WebRow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a dataset of the top web search results for the specified literal string.
        ///https://reference.wolfram.com/language/ref/WebSearch.html
        ///</summary>
        public static Engine WebSearch(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebSearch[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the elements of the web search specified by elems.
        ///https://reference.wolfram.com/language/ref/WebSearch.html
        ///</summary>
        public static Engine WebSearch(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WebSearch[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a web browser session started by StartWebSession for use with WebExecute.
        ///https://reference.wolfram.com/language/ref/WebSessionObject.html
        ///</summary>
        public static Engine WebSessionObject(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebSessionObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of all active web sessions.
        ///https://reference.wolfram.com/language/ref/WebSessions.html
        ///</summary>
        public static Engine WebSessions(this Engine en, string? name = null)
        {
            return en.Execute("WebSessions[]", name);
        }

        ///<summary>
        ///represents an open window or tab in a web browser.
        ///https://reference.wolfram.com/language/ref/WebWindowObject.html
        ///</summary>
        public static Engine WebWindowObject(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WebWindowObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as x⋀y⋀….
        ///https://reference.wolfram.com/language/ref/Wedge.html
        ///</summary>
        public static Engine Wedge(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("Wedge[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Weibull distribution with shape parameter α and scale parameter β.
        ///https://reference.wolfram.com/language/ref/WeibullDistribution.html
        ///</summary>
        public static Engine WeibullDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WeibullDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Weibull distribution with shape parameter α, scale parameter β, and location parameter μ.
        ///https://reference.wolfram.com/language/ref/WeibullDistribution.html
        ///</summary>
        public static Engine WeibullDistribution(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WeibullDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value e1 of the Weierstrass elliptic function  at the half-period .
        ///https://reference.wolfram.com/language/ref/WeierstrassE1.html
        ///</summary>
        public static Engine WeierstrassE1(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassE1[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value e2 of the Weierstrass elliptic function  at the half-period .
        ///https://reference.wolfram.com/language/ref/WeierstrassE2.html
        ///</summary>
        public static Engine WeierstrassE2(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassE2[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value e3 of the Weierstrass elliptic function  at the half-period .
        ///https://reference.wolfram.com/language/ref/WeierstrassE3.html
        ///</summary>
        public static Engine WeierstrassE3(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassE3[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value η1 of the Weierstrass zeta function ζ at the half-period .
        ///https://reference.wolfram.com/language/ref/WeierstrassEta1.html
        ///</summary>
        public static Engine WeierstrassEta1(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassEta1[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value η2 of the Weierstrass zeta function ζ at the half-period .
        ///https://reference.wolfram.com/language/ref/WeierstrassEta2.html
        ///</summary>
        public static Engine WeierstrassEta2(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassEta2[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value η3 of the Weierstrass zeta function ζ at the half-period .
        ///https://reference.wolfram.com/language/ref/WeierstrassEta3.html
        ///</summary>
        public static Engine WeierstrassEta3(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassEta3[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the half‐periods {ω1,ω3} for Weierstrass elliptic functions corresponding to the invariants {g2,g3}.
        ///https://reference.wolfram.com/language/ref/WeierstrassHalfPeriods.html
        ///</summary>
        public static Engine WeierstrassHalfPeriods(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassHalfPeriods[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the half-period ω1 for Weierstrass elliptic functions corresponding to the invariants {g2,g3}.
        ///https://reference.wolfram.com/language/ref/WeierstrassHalfPeriodW1.html
        ///</summary>
        public static Engine WeierstrassHalfPeriodW1(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassHalfPeriodW1[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the half-period ω2 for the Weierstrass elliptic functions corresponding to the invariants {g2,g3}.
        ///https://reference.wolfram.com/language/ref/WeierstrassHalfPeriodW2.html
        ///</summary>
        public static Engine WeierstrassHalfPeriodW2(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassHalfPeriodW2[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the half-period ω3 for the Weierstrass elliptic functions corresponding to the invariants {g2,g3}.
        ///https://reference.wolfram.com/language/ref/WeierstrassHalfPeriodW3.html
        ///</summary>
        public static Engine WeierstrassHalfPeriodW3(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassHalfPeriodW3[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the invariant  for the Weierstrass elliptic functions corresponding to the half‐periods {ω,ω′}.
        ///https://reference.wolfram.com/language/ref/WeierstrassInvariantG2.html
        ///</summary>
        public static Engine WeierstrassInvariantG2(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassInvariantG2[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the invariant  for the Weierstrass elliptic functions corresponding to the half‐periods {ω,ω′}.
        ///https://reference.wolfram.com/language/ref/WeierstrassInvariantG3.html
        ///</summary>
        public static Engine WeierstrassInvariantG3(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassInvariantG3[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the invariants {g2,g3} for Weierstrass elliptic functions corresponding to the half‐periods {ω1,ω3}.
        ///https://reference.wolfram.com/language/ref/WeierstrassInvariants.html
        ///</summary>
        public static Engine WeierstrassInvariants(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeierstrassInvariants[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Weierstrass elliptic function .
        ///https://reference.wolfram.com/language/ref/WeierstrassP.html
        ///</summary>
        public static Engine WeierstrassP(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WeierstrassP[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Weierstrass elliptic function .
        ///https://reference.wolfram.com/language/ref/WeierstrassPPrime.html
        ///</summary>
        public static Engine WeierstrassPPrime(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WeierstrassPPrime[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Weierstrass sigma function .
        ///https://reference.wolfram.com/language/ref/WeierstrassSigma.html
        ///</summary>
        public static Engine WeierstrassSigma(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WeierstrassSigma[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Weierstrass zeta function .
        ///https://reference.wolfram.com/language/ref/WeierstrassZeta.html
        ///</summary>
        public static Engine WeierstrassZeta(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WeierstrassZeta[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the graph with weighted adjacency matrix wmat.
        ///https://reference.wolfram.com/language/ref/WeightedAdjacencyGraph.html
        ///</summary>
        public static Engine WeightedAdjacencyGraph(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WeightedAdjacencyGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the graph with vertices vi and weighted adjacency matrix wmat.
        ///https://reference.wolfram.com/language/ref/WeightedAdjacencyGraph.html
        ///</summary>
        public static Engine WeightedAdjacencyGraph(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WeightedAdjacencyGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the adjacency matrix of edge weights of the graph g.
        ///https://reference.wolfram.com/language/ref/WeightedAdjacencyMatrix.html
        ///</summary>
        public static Engine WeightedAdjacencyMatrix(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WeightedAdjacencyMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/WeightedAdjacencyMatrix.html
        ///</summary>
        public static Engine WeightedAdjacencyMatrix(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WeightedAdjacencyMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents observations xi with weights wi.
        ///https://reference.wolfram.com/language/ref/WeightedData.html
        ///</summary>
        public static Engine WeightedData(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WeightedData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents observations xi with weighting function fn.
        ///https://reference.wolfram.com/language/ref/WeightedData.html
        ///</summary>
        public static Engine WeightedData(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WeightedData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a weighted graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/WeightedGraphQ.html
        ///</summary>
        public static Engine WeightedGraphQ(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WeightedGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Welch window function of x.
        ///https://reference.wolfram.com/language/ref/WelchWindow.html
        ///</summary>
        public static Engine WelchWindow(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WelchWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the parameter α.
        ///https://reference.wolfram.com/language/ref/WelchWindow.html
        ///</summary>
        public static Engine WelchWindow(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WelchWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the wheel graph with n vertices .
        ///https://reference.wolfram.com/language/ref/WheelGraph.html
        ///</summary>
        public static Engine WheelGraph(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WheelGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies an action that occurs when the event triggers it for equations in NDSolve and related functions.
        ///https://reference.wolfram.com/language/ref/WhenEvent.html
        ///</summary>
        public static Engine WhenEvent(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WhenEvent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates each of the testi in turn, returning the value of the valuei corresponding to the first one that yields True.
        ///https://reference.wolfram.com/language/ref/Which.html
        ///</summary>
        public static Engine Which(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
        {
            return en.Execute("Which[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///evaluates test, then body, repetitively, until test first fails to give True.
        ///https://reference.wolfram.com/language/ref/While.html
        ///</summary>
        public static Engine While(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("While[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian white noise process with mean 0 and standard deviation 1.
        ///https://reference.wolfram.com/language/ref/WhiteNoiseProcess.html
        ///</summary>
        public static Engine WhiteNoiseProcess(this Engine en, string? name = null)
        {
            return en.Execute("WhiteNoiseProcess[]", name);
        }

        ///<summary>
        ///represents a Gaussian white noise process with mean 0 and standard deviation σ.
        ///https://reference.wolfram.com/language/ref/WhiteNoiseProcess.html
        ///</summary>
        public static Engine WhiteNoiseProcess(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WhiteNoiseProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Whittaker function .
        ///https://reference.wolfram.com/language/ref/WhittakerM.html
        ///</summary>
        public static Engine WhittakerM(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WhittakerM[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Whittaker function .
        ///https://reference.wolfram.com/language/ref/WhittakerW.html
        ///</summary>
        public static Engine WhittakerW(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WhittakerW[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///removes noise from data by applying a range-r Wiener filter.
        ///https://reference.wolfram.com/language/ref/WienerFilter.html
        ///</summary>
        public static Engine WienerFilter(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WienerFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///assumes an additive noise power value ns.
        ///https://reference.wolfram.com/language/ref/WienerFilter.html
        ///</summary>
        public static Engine WienerFilter(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WienerFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses radius ri at level i in data.
        ///https://reference.wolfram.com/language/ref/WienerFilter.html
        ///</summary>
        public static Engine WienerFilter(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("WienerFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Wiener process with a drift μ and volatility σ.
        ///https://reference.wolfram.com/language/ref/WienerProcess.html
        ///</summary>
        public static Engine WienerProcess(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WienerProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a standard Wiener process with drift 0 and volatility 1.
        ///https://reference.wolfram.com/language/ref/WienerProcess.html
        ///</summary>
        public static Engine WienerProcess(this Engine en, string? name = null)
        {
            return en.Execute("WienerProcess[]", name);
        }

        ///<summary>
        ///gives the Wigner D-function .
        ///https://reference.wolfram.com/language/ref/WignerD.html
        ///</summary>
        public static Engine WignerD(this Engine en, List<string> arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("WignerD[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the Wigner D-function .
        ///https://reference.wolfram.com/language/ref/WignerD.html
        ///</summary>
        public static Engine WignerD(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WignerD[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Wigner D-function .
        ///https://reference.wolfram.com/language/ref/WignerD.html
        ///</summary>
        public static Engine WignerD(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WignerD[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Wigner semicircle distribution with radius r centered at the origin.
        ///https://reference.wolfram.com/language/ref/WignerSemicircleDistribution.html
        ///</summary>
        public static Engine WignerSemicircleDistribution(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WignerSemicircleDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Wigner semicircle distribution with radius r centered at a.
        ///https://reference.wolfram.com/language/ref/WignerSemicircleDistribution.html
        ///</summary>
        public static Engine WignerSemicircleDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WignerSemicircleDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the values of the specified property for the given item.
        ///https://reference.wolfram.com/language/ref/WikidataData.html
        ///</summary>
        public static Engine WikidataData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WikidataData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives values for each of the itemi.
        ///https://reference.wolfram.com/language/ref/WikidataData.html
        ///</summary>
        public static Engine WikidataData(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WikidataData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives values for each of the propertyi.
        ///https://reference.wolfram.com/language/ref/WikidataData.html
        ///</summary>
        public static Engine WikidataData(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WikidataData[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns a list of Wikidata items whose labels include the given keywords.
        ///https://reference.wolfram.com/language/ref/WikidataSearch.html
        ///</summary>
        public static Engine WikidataSearch(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WikidataSearch[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the plain text of the specified Wikipedia article.
        ///https://reference.wolfram.com/language/ref/WikipediaData.html
        ///</summary>
        public static Engine WikipediaData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WikipediaData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property, modified by optional parameters, for the given Wikipedia article.
        ///https://reference.wolfram.com/language/ref/WikipediaData.html
        ///</summary>
        public static Engine WikipediaData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WikipediaData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a list of Wikipedia articles whose titles include the given keywords.
        ///https://reference.wolfram.com/language/ref/WikipediaSearch.html
        ///</summary>
        public static Engine WikipediaSearch(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WikipediaSearch[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of Wikipedia articles whose titles include the given keywords.
        ///https://reference.wolfram.com/language/ref/WikipediaSearch.html
        ///</summary>
        public static Engine WikipediaSearch(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WikipediaSearch[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives Wilks's  for the matrices m1 and m2.
        ///https://reference.wolfram.com/language/ref/WilksW.html
        ///</summary>
        public static Engine WilksW(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WilksW[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the matrices m1 and m2 are independent.
        ///https://reference.wolfram.com/language/ref/WilksWTest.html
        ///</summary>
        public static Engine WilksWTest(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WilksWTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the most recent measurement for wind direction near the current location.
        ///https://reference.wolfram.com/language/ref/WindDirectionData.html
        ///</summary>
        public static Engine WindDirectionData(this Engine en, string? name = null)
        {
            return en.Execute("WindDirectionData[]", name);
        }

        ///<summary>
        ///gives the wind direction value for the specified time near the current location.
        ///https://reference.wolfram.com/language/ref/WindDirectionData.html
        ///</summary>
        public static Engine WindDirectionData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WindDirectionData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value or values for the specified date and location.
        ///https://reference.wolfram.com/language/ref/WindDirectionData.html
        ///</summary>
        public static Engine WindDirectionData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WindDirectionData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives values for all specified locations on the specified dates.
        ///https://reference.wolfram.com/language/ref/WindDirectionData.html
        ///</summary>
        public static Engine WindDirectionData(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WindDirectionData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the count of the number of times a closed curve winds around a point p.
        ///https://reference.wolfram.com/language/ref/WindingCount.html
        ///</summary>
        public static Engine WindingCount(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WindingCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a polygon representing all points for which the closed contour p1,p2,…,pn,p1 winds around at least once.
        ///https://reference.wolfram.com/language/ref/WindingPolygon.html
        ///</summary>
        public static Engine WindingPolygon(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WindingPolygon[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a polygon from the closed contours p11,p12,… and p21,p22,….
        ///https://reference.wolfram.com/language/ref/WindingPolygon.html
        ///</summary>
        public static Engine WindingPolygon(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WindingPolygon[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the specified winding rule "wrule" to define the polygon.
        ///https://reference.wolfram.com/language/ref/WindingPolygon.html
        ///</summary>
        public static Engine WindingPolygon(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WindingPolygon[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the most recent measurement for wind speed near the current location.
        ///https://reference.wolfram.com/language/ref/WindSpeedData.html
        ///</summary>
        public static Engine WindSpeedData(this Engine en, string? name = null)
        {
            return en.Execute("WindSpeedData[]", name);
        }

        ///<summary>
        ///gives the wind speed value for the specified time near the current location.
        ///https://reference.wolfram.com/language/ref/WindSpeedData.html
        ///</summary>
        public static Engine WindSpeedData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WindSpeedData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value or values for the specified date and location.
        ///https://reference.wolfram.com/language/ref/WindSpeedData.html
        ///</summary>
        public static Engine WindSpeedData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WindSpeedData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives values for all specified locations on the specified dates.
        ///https://reference.wolfram.com/language/ref/WindSpeedData.html
        ///</summary>
        public static Engine WindSpeedData(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WindSpeedData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the most recent weather station measurement for wind vector near the current location.
        ///https://reference.wolfram.com/language/ref/WindVectorData.html
        ///</summary>
        public static Engine WindVectorData(this Engine en, string? name = null)
        {
            return en.Execute("WindVectorData[]", name);
        }

        ///<summary>
        ///gives the wind vector value for the specified time near the current location.
        ///https://reference.wolfram.com/language/ref/WindVectorData.html
        ///</summary>
        public static Engine WindVectorData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WindVectorData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value or values for the specified date and location.
        ///https://reference.wolfram.com/language/ref/WindVectorData.html
        ///</summary>
        public static Engine WindVectorData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WindVectorData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives values for all specified locations on the specified dates.
        ///https://reference.wolfram.com/language/ref/WindVectorData.html
        ///</summary>
        public static Engine WindVectorData(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WindVectorData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the mean of the elements in list after replacing the fraction f of the smallest and largest elements by the remaining extreme values.
        ///https://reference.wolfram.com/language/ref/WinsorizedMean.html
        ///</summary>
        public static Engine WinsorizedMean(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WinsorizedMean[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the mean when the fraction f1 of the smallest elements and the fraction f2 of the largest elements are replaced by the remaining extreme values.
        ///https://reference.wolfram.com/language/ref/WinsorizedMean.html
        ///</summary>
        public static Engine WinsorizedMean(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WinsorizedMean[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the 5% winsorized mean WinsorizedMean[list,0.05].
        ///https://reference.wolfram.com/language/ref/WinsorizedMean.html
        ///</summary>
        public static Engine WinsorizedMean(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WinsorizedMean[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the variance of the elements in list after replacing the fraction f of the smallest and largest elements by the remaining extreme values.
        ///https://reference.wolfram.com/language/ref/WinsorizedVariance.html
        ///</summary>
        public static Engine WinsorizedVariance(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WinsorizedVariance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the variance when the fraction f1 of the smallest elements and the fraction f2 of the largest elements are replaced by the remaining extreme values.
        ///https://reference.wolfram.com/language/ref/WinsorizedVariance.html
        ///</summary>
        public static Engine WinsorizedVariance(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WinsorizedVariance[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the 5% winsorized variance WinsorizedVariance[list,0.05].
        ///https://reference.wolfram.com/language/ref/WinsorizedVariance.html
        ///</summary>
        public static Engine WinsorizedVariance(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WinsorizedVariance[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Wishart matrix distribution with ν degrees of freedom and covariance matrix Σ.
        ///https://reference.wolfram.com/language/ref/WishartMatrixDistribution.html
        ///</summary>
        public static Engine WishartMatrixDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WishartMatrixDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that all occurrences of the symbols x, y, … in expr should be replaced by x0, y0, ….
        ///https://reference.wolfram.com/language/ref/With.html
        ///</summary>
        public static Engine With(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("With[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr, running cleanup before returning the result, even if an abort, throw, etc. was generated during the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/WithCleanup.html
        ///</summary>
        public static Engine WithCleanup(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WithCleanup[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates init before evaluating expr, blocking aborts, throws, etc. in both init and cleanup.
        ///https://reference.wolfram.com/language/ref/WithCleanup.html
        ///</summary>
        public static Engine WithCleanup(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WithCleanup[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///locks the file path, evaluates expr, then releases the file.
        ///https://reference.wolfram.com/language/ref/WithLock.html
        ///</summary>
        public static Engine WithLock(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WithLock[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sends query to Wolfram|Alpha and imports the output.
        ///https://reference.wolfram.com/language/ref/WolframAlpha.html
        ///</summary>
        public static Engine WolframAlpha(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WolframAlpha[" + arg0 + "]", name);
        }

        ///<summary>
        ///imports the output according to the specified format.
        ///https://reference.wolfram.com/language/ref/WolframAlpha.html
        ///</summary>
        public static Engine WolframAlpha(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WolframAlpha[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the Wolfram Language symbol entity.
        ///https://reference.wolfram.com/language/ref/WolframLanguageData.html
        ///</summary>
        public static Engine WolframLanguageData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WolframLanguageData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified Wolfram Language symbol entities.
        ///https://reference.wolfram.com/language/ref/WolframLanguageData.html
        ///</summary>
        public static Engine WolframLanguageData(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("WolframLanguageData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/WolframLanguageData.html
        ///</summary>
        public static Engine WolframLanguageData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WolframLanguageData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a word cloud graphic in which the si are sized according to their multiplicity in the list.
        ///https://reference.wolfram.com/language/ref/WordCloud.html
        ///</summary>
        public static Engine WordCloud(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WordCloud[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///also generates a word cloud in which the si are sized according to the weights wi.
        ///https://reference.wolfram.com/language/ref/WordCloud.html
        ///</summary>
        public static Engine WordCloud(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WordCloud[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///also generates a word cloud in which the si are sized according to the weights wi.
        ///https://reference.wolfram.com/language/ref/WordCloud.html
        ///</summary>
        public static Engine WordCloud(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WordCloud[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the total number of words in string.
        ///https://reference.wolfram.com/language/ref/WordCount.html
        ///</summary>
        public static Engine WordCount(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WordCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an association whose keys are the distinct words identified in string, and whose values give the number of times those words appear in string.
        ///https://reference.wolfram.com/language/ref/WordCounts.html
        ///</summary>
        public static Engine WordCounts(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WordCounts[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives counts of the distinct n-grams consisting of runs of n words in string.
        ///https://reference.wolfram.com/language/ref/WordCounts.html
        ///</summary>
        public static Engine WordCounts(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WordCounts[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified property for the English word "word".
        ///https://reference.wolfram.com/language/ref/WordData.html
        ///</summary>
        public static Engine WordData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WordData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of full word specifications representing possible uses and senses of "word".
        ///https://reference.wolfram.com/language/ref/WordData.html
        ///</summary>
        public static Engine WordData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WordData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the dictionary definitions available for "word".
        ///https://reference.wolfram.com/language/ref/WordDefinition.html
        ///</summary>
        public static Engine WordDefinition(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WordDefinition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the frequency of word in text.
        ///https://reference.wolfram.com/language/ref/WordFrequency.html
        ///</summary>
        public static Engine WordFrequency(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WordFrequency[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an association of the frequencies of each of the wordi.
        ///https://reference.wolfram.com/language/ref/WordFrequency.html
        ///</summary>
        public static Engine WordFrequency(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("WordFrequency[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the frequency of word in typical published English text.
        ///https://reference.wolfram.com/language/ref/WordFrequencyData.html
        ///</summary>
        public static Engine WordFrequencyData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WordFrequencyData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an association of frequencies of the wordi.
        ///https://reference.wolfram.com/language/ref/WordFrequencyData.html
        ///</summary>
        public static Engine WordFrequencyData(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("WordFrequencyData[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a time series for the frequency of word in typical published English text.
        ///https://reference.wolfram.com/language/ref/WordFrequencyData.html
        ///</summary>
        public static Engine WordFrequencyData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WordFrequencyData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a time series for dates specified by datespec.
        ///https://reference.wolfram.com/language/ref/WordFrequencyData.html
        ///</summary>
        public static Engine WordFrequencyData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("WordFrequencyData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of common words.
        ///https://reference.wolfram.com/language/ref/WordList.html
        ///</summary>
        public static Engine WordList(this Engine en, string? name = null)
        {
            return en.Execute("WordList[]", name);
        }

        ///<summary>
        ///gives a list of words of the specified type.
        ///https://reference.wolfram.com/language/ref/WordList.html
        ///</summary>
        public static Engine WordList(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WordList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a stemmed form of word, removing plurals, inflections, etc.
        ///https://reference.wolfram.com/language/ref/WordStem.html
        ///</summary>
        public static Engine WordStem(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("WordStem[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives translations for word into the language lang.
        ///https://reference.wolfram.com/language/ref/WordTranslation.html
        ///</summary>
        public static Engine WordTranslation(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WordTranslation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///writes the expressions expri in sequence, followed by a newline, to the specified output channel.
        ///https://reference.wolfram.com/language/ref/Write.html
        ///</summary>
        public static Engine Write(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("Write[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///writes "string" to a file, followed by a newline.
        ///https://reference.wolfram.com/language/ref/WriteLine.html
        ///</summary>
        public static Engine WriteLine(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WriteLine[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///writes "string" to a file.
        ///https://reference.wolfram.com/language/ref/WriteString.html
        ///</summary>
        public static Engine WriteString(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("WriteString[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts the expri to strings, and then writes them in sequence to the specified output channel.
        ///https://reference.wolfram.com/language/ref/WriteString.html
        ///</summary>
        public static Engine WriteString(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("WriteString[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the Wronskian determinant for the functions y1,y2,… depending on x.
        ///https://reference.wolfram.com/language/ref/Wronskian.html
        ///</summary>
        public static Engine Wronskian(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("Wronskian[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Wronskian determinant for the basis of the solutions of the linear differential equation eqn with dependent variable y and independent variable x.
        ///https://reference.wolfram.com/language/ref/Wronskian.html
        ///</summary>
        public static Engine Wronskian(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("Wronskian[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Wronskian determinant for the system of linear differential equations eqns.
        ///https://reference.wolfram.com/language/ref/Wronskian.html
        ///</summary>
        public static Engine Wronskian(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("Wronskian[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }


    }
}
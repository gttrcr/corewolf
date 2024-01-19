using System.Collections.Generic;

namespace CoreWolf
{
    public static class ExtendedFunctionsW
    {
        ///<summary>
        /// waits for all concurrent evaluations represented by EvaluationObject expressions in expr to finish, then returns the resulting expression obtained.
        /// https://reference.wolfram.com/language/ref/WaitAll.html
        ///</summary>
        public static Engine WaitAll(this Engine en, string? name = null)
        {
            return en.Execute("WaitAll[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// waits until the first evaluation represented by any of the eidi finishes, then returns its result, the corresponding eidi, and the list of remaining eidk.
        /// https://reference.wolfram.com/language/ref/WaitNext.html
        ///</summary>
        public static Engine WaitNext(this Engine en, string? name = null)
        {
            return en.Execute("WaitNext[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the Yule distribution with shape parameter α.
        /// https://reference.wolfram.com/language/ref/WaringYuleDistribution.html
        ///</summary>
        public static Engine WaringYuleDistribution(this Engine en, string? name = null)
        {
            return en.Execute("WaringYuleDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// computes the watershed transform of image, returning the result as an array in which positive integers label the catchment basins.
        /// https://reference.wolfram.com/language/ref/WatershedComponents.html
        ///</summary>
        public static Engine WatershedComponents(this Engine en, string? name = null)
        {
            return en.Execute("WatershedComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether data is normally distributed using the Watson  test.
        /// https://reference.wolfram.com/language/ref/WatsonUSquareTest.html
        ///</summary>
        public static Engine WatsonUSquareTest(this Engine en, string? name = null)
        {
            return en.Execute("WatsonUSquareTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// computes a best basis representation in the DiscreteWaveletData object dwd.
        /// https://reference.wolfram.com/language/ref/WaveletBestBasis.html
        ///</summary>
        public static Engine WaveletBestBasis(this Engine en, string? name = null)
        {
            return en.Execute("WaveletBestBasis[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the basis tree of wavelet image coefficients in the DiscreteWaveletData dwd.
        /// https://reference.wolfram.com/language/ref/WaveletImagePlot.html
        ///</summary>
        public static Engine WaveletImagePlot(this Engine en, string? name = null)
        {
            return en.Execute("WaveletImagePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots wavelet transform coefficients in the DiscreteWaveletData dwd.
        /// https://reference.wolfram.com/language/ref/WaveletListPlot.html
        ///</summary>
        public static Engine WaveletListPlot(this Engine en, string? name = null)
        {
            return en.Execute("WaveletListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the basis tree of wavelet matrix coefficients in the DiscreteWaveletData dwd.
        /// https://reference.wolfram.com/language/ref/WaveletMatrixPlot.html
        ///</summary>
        public static Engine WaveletMatrixPlot(this Engine en, string? name = null)
        {
            return en.Execute("WaveletMatrixPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the scaling function as a pure function.
        /// https://reference.wolfram.com/language/ref/WaveletPhi.html
        ///</summary>
        public static Engine WaveletPhi(this Engine en, string? name = null)
        {
            return en.Execute("WaveletPhi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the wavelet function as a pure function.
        /// https://reference.wolfram.com/language/ref/WaveletPsi.html
        ///</summary>
        public static Engine WaveletPsi(this Engine en, string? name = null)
        {
            return en.Execute("WaveletPsi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots wavelet vector coefficients in a DiscreteWaveletData or ContinuousWaveletData object wd.
        /// https://reference.wolfram.com/language/ref/WaveletScalogram.html
        ///</summary>
        public static Engine WaveletScalogram(this Engine en, string? name = null)
        {
            return en.Execute("WaveletScalogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// thresholds the detail wavelet coefficients in the DiscreteWaveletData object dwd.
        /// https://reference.wolfram.com/language/ref/WaveletThreshold.html
        ///</summary>
        public static Engine WaveletThreshold(this Engine en, string? name = null)
        {
            return en.Execute("WaveletThreshold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the weakly connected components of the graph g.
        /// https://reference.wolfram.com/language/ref/WeaklyConnectedComponents.html
        ///</summary>
        public static Engine WeaklyConnectedComponents(this Engine en, string? name = null)
        {
            return en.Execute("WeaklyConnectedComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the weakly connected components of the graph g.
        /// https://reference.wolfram.com/language/ref/WeaklyConnectedGraphComponents.html
        ///</summary>
        public static Engine WeaklyConnectedGraphComponents(this Engine en, string? name = null)
        {
            return en.Execute("WeaklyConnectedGraphComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is weakly connected, and False otherwise.
        /// https://reference.wolfram.com/language/ref/WeaklyConnectedGraphQ.html
        ///</summary>
        public static Engine WeaklyConnectedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("WeaklyConnectedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives conditions for the process proc to be weakly stationary.
        /// https://reference.wolfram.com/language/ref/WeakStationarity.html
        ///</summary>
        public static Engine WeakStationarity(this Engine en, string? name = null)
        {
            return en.Execute("WeakStationarity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the most recent forecast for all weather forecast properties for the specified location.
        /// https://reference.wolfram.com/language/ref/WeatherForecastData.html
        ///</summary>
        public static Engine WeatherForecastData(this Engine en, string? name = null)
        {
            return en.Execute("WeatherForecastData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a dataset of the top web audio search results for the specified literal string.
        /// https://reference.wolfram.com/language/ref/WebAudioSearch.html
        ///</summary>
        public static Engine WebAudioSearch(this Engine en, string? name = null)
        {
            return en.Execute("WebAudioSearch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an HTML column containing the expri.
        /// https://reference.wolfram.com/language/ref/WebColumn.html
        ///</summary>
        public static Engine WebColumn(this Engine en, string? name = null)
        {
            return en.Execute("WebColumn[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an element of an open webpage operated on by WebExecute.
        /// https://reference.wolfram.com/language/ref/WebElementObject.html
        ///</summary>
        public static Engine WebElementObject(this Engine en, string? name = null)
        {
            return en.Execute("WebElementObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// executes the command cmd in a web browser.
        /// https://reference.wolfram.com/language/ref/WebExecute.html
        ///</summary>
        public static Engine WebExecute(this Engine en, string? name = null)
        {
            return en.Execute("WebExecute[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an image of the webpage specified by url.
        /// https://reference.wolfram.com/language/ref/WebImage.html
        ///</summary>
        public static Engine WebImage(this Engine en, string? name = null)
        {
            return en.Execute("WebImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of thumbnails of the top web image search results for the specified literal string.
        /// https://reference.wolfram.com/language/ref/WebImageSearch.html
        ///</summary>
        public static Engine WebImageSearch(this Engine en, string? name = null)
        {
            return en.Execute("WebImageSearch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an HTML element containing expr.
        /// https://reference.wolfram.com/language/ref/WebItem.html
        ///</summary>
        public static Engine WebItem(this Engine en, string? name = null)
        {
            return en.Execute("WebItem[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an HTML column containing the expri.
        /// https://reference.wolfram.com/language/ref/WebRow.html
        ///</summary>
        public static Engine WebRow(this Engine en, string? name = null)
        {
            return en.Execute("WebRow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a dataset of the top web search results for the specified literal string.
        /// https://reference.wolfram.com/language/ref/WebSearch.html
        ///</summary>
        public static Engine WebSearch(this Engine en, string? name = null)
        {
            return en.Execute("WebSearch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a web browser session started by StartWebSession for use with WebExecute.
        /// https://reference.wolfram.com/language/ref/WebSessionObject.html
        ///</summary>
        public static Engine WebSessionObject(this Engine en, string? name = null)
        {
            return en.Execute("WebSessionObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an open window or tab in a web browser.
        /// https://reference.wolfram.com/language/ref/WebWindowObject.html
        ///</summary>
        public static Engine WebWindowObject(this Engine en, string? name = null)
        {
            return en.Execute("WebWindowObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the value e1 of the Weierstrass elliptic function  at the half-period .
        /// https://reference.wolfram.com/language/ref/WeierstrassE1.html
        ///</summary>
        public static Engine WeierstrassE1(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassE1[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the value e2 of the Weierstrass elliptic function  at the half-period .
        /// https://reference.wolfram.com/language/ref/WeierstrassE2.html
        ///</summary>
        public static Engine WeierstrassE2(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassE2[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the value e3 of the Weierstrass elliptic function  at the half-period .
        /// https://reference.wolfram.com/language/ref/WeierstrassE3.html
        ///</summary>
        public static Engine WeierstrassE3(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassE3[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the value η1 of the Weierstrass zeta function ζ at the half-period .
        /// https://reference.wolfram.com/language/ref/WeierstrassEta1.html
        ///</summary>
        public static Engine WeierstrassEta1(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassEta1[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the value η2 of the Weierstrass zeta function ζ at the half-period .
        /// https://reference.wolfram.com/language/ref/WeierstrassEta2.html
        ///</summary>
        public static Engine WeierstrassEta2(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassEta2[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the value η3 of the Weierstrass zeta function ζ at the half-period .
        /// https://reference.wolfram.com/language/ref/WeierstrassEta3.html
        ///</summary>
        public static Engine WeierstrassEta3(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassEta3[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the half‐periods {ω1,ω3} for Weierstrass elliptic functions corresponding to the invariants {g2,g3}.
        /// https://reference.wolfram.com/language/ref/WeierstrassHalfPeriods.html
        ///</summary>
        public static Engine WeierstrassHalfPeriods(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassHalfPeriods[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the half-period ω1 for Weierstrass elliptic functions corresponding to the invariants {g2,g3}.
        /// https://reference.wolfram.com/language/ref/WeierstrassHalfPeriodW1.html
        ///</summary>
        public static Engine WeierstrassHalfPeriodW1(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassHalfPeriodW1[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the half-period ω2 for the Weierstrass elliptic functions corresponding to the invariants {g2,g3}.
        /// https://reference.wolfram.com/language/ref/WeierstrassHalfPeriodW2.html
        ///</summary>
        public static Engine WeierstrassHalfPeriodW2(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassHalfPeriodW2[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the half-period ω3 for the Weierstrass elliptic functions corresponding to the invariants {g2,g3}.
        /// https://reference.wolfram.com/language/ref/WeierstrassHalfPeriodW3.html
        ///</summary>
        public static Engine WeierstrassHalfPeriodW3(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassHalfPeriodW3[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the invariant  for the Weierstrass elliptic functions corresponding to the half‐periods {ω,ω′}.
        /// https://reference.wolfram.com/language/ref/WeierstrassInvariantG2.html
        ///</summary>
        public static Engine WeierstrassInvariantG2(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassInvariantG2[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the invariant  for the Weierstrass elliptic functions corresponding to the half‐periods {ω,ω′}.
        /// https://reference.wolfram.com/language/ref/WeierstrassInvariantG3.html
        ///</summary>
        public static Engine WeierstrassInvariantG3(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassInvariantG3[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the invariants {g2,g3} for Weierstrass elliptic functions corresponding to the half‐periods {ω1,ω3}.
        /// https://reference.wolfram.com/language/ref/WeierstrassInvariants.html
        ///</summary>
        public static Engine WeierstrassInvariants(this Engine en, string? name = null)
        {
            return en.Execute("WeierstrassInvariants[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the graph with weighted adjacency matrix wmat.
        /// https://reference.wolfram.com/language/ref/WeightedAdjacencyGraph.html
        ///</summary>
        public static Engine WeightedAdjacencyGraph(this Engine en, string? name = null)
        {
            return en.Execute("WeightedAdjacencyGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the adjacency matrix of edge weights of the graph g.
        /// https://reference.wolfram.com/language/ref/WeightedAdjacencyMatrix.html
        ///</summary>
        public static Engine WeightedAdjacencyMatrix(this Engine en, string? name = null)
        {
            return en.Execute("WeightedAdjacencyMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is a weighted graph and False otherwise.
        /// https://reference.wolfram.com/language/ref/WeightedGraphQ.html
        ///</summary>
        public static Engine WeightedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("WeightedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Welch window function of x.
        /// https://reference.wolfram.com/language/ref/WelchWindow.html
        ///</summary>
        public static Engine WelchWindow(this Engine en, string? name = null)
        {
            return en.Execute("WelchWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the wheel graph with n vertices .
        /// https://reference.wolfram.com/language/ref/WheelGraph.html
        ///</summary>
        public static Engine WheelGraph(this Engine en, string? name = null)
        {
            return en.Execute("WheelGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Gaussian white noise process with mean 0 and standard deviation σ.
        /// https://reference.wolfram.com/language/ref/WhiteNoiseProcess.html
        ///</summary>
        public static Engine WhiteNoiseProcess(this Engine en, string? name = null)
        {
            return en.Execute("WhiteNoiseProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Wigner semicircle distribution with radius r centered at the origin.
        /// https://reference.wolfram.com/language/ref/WignerSemicircleDistribution.html
        ///</summary>
        public static Engine WignerSemicircleDistribution(this Engine en, string? name = null)
        {
            return en.Execute("WignerSemicircleDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a list of Wikidata items whose labels include the given keywords.
        /// https://reference.wolfram.com/language/ref/WikidataSearch.html
        ///</summary>
        public static Engine WikidataSearch(this Engine en, string? name = null)
        {
            return en.Execute("WikidataSearch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the plain text of the specified Wikipedia article.
        /// https://reference.wolfram.com/language/ref/WikipediaData.html
        ///</summary>
        public static Engine WikipediaData(this Engine en, string? name = null)
        {
            return en.Execute("WikipediaData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a list of Wikipedia articles whose titles include the given keywords.
        /// https://reference.wolfram.com/language/ref/WikipediaSearch.html
        ///</summary>
        public static Engine WikipediaSearch(this Engine en, string? name = null)
        {
            return en.Execute("WikipediaSearch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the wind direction value for the specified time near the current location.
        /// https://reference.wolfram.com/language/ref/WindDirectionData.html
        ///</summary>
        public static Engine WindDirectionData(this Engine en, string? name = null)
        {
            return en.Execute("WindDirectionData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a polygon representing all points for which the closed contour p1,p2,…,pn,p1 winds around at least once.
        /// https://reference.wolfram.com/language/ref/WindingPolygon.html
        ///</summary>
        public static Engine WindingPolygon(this Engine en, string? name = null)
        {
            return en.Execute("WindingPolygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the wind speed value for the specified time near the current location.
        /// https://reference.wolfram.com/language/ref/WindSpeedData.html
        ///</summary>
        public static Engine WindSpeedData(this Engine en, string? name = null)
        {
            return en.Execute("WindSpeedData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the wind vector value for the specified time near the current location.
        /// https://reference.wolfram.com/language/ref/WindVectorData.html
        ///</summary>
        public static Engine WindVectorData(this Engine en, string? name = null)
        {
            return en.Execute("WindVectorData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the 5% winsorized mean WinsorizedMean[list,0.05].
        /// https://reference.wolfram.com/language/ref/WinsorizedMean.html
        ///</summary>
        public static Engine WinsorizedMean(this Engine en, string? name = null)
        {
            return en.Execute("WinsorizedMean[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the 5% winsorized variance WinsorizedVariance[list,0.05].
        /// https://reference.wolfram.com/language/ref/WinsorizedVariance.html
        ///</summary>
        public static Engine WinsorizedVariance(this Engine en, string? name = null)
        {
            return en.Execute("WinsorizedVariance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// sends query to Wolfram|Alpha and imports the output.
        /// https://reference.wolfram.com/language/ref/WolframAlpha.html
        ///</summary>
        public static Engine WolframAlpha(this Engine en, string? name = null)
        {
            return en.Execute("WolframAlpha[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a word cloud graphic in which the si are sized according to their multiplicity in the list.
        /// https://reference.wolfram.com/language/ref/WordCloud.html
        ///</summary>
        public static Engine WordCloud(this Engine en, string? name = null)
        {
            return en.Execute("WordCloud[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the total number of words in string.
        /// https://reference.wolfram.com/language/ref/WordCount.html
        ///</summary>
        public static Engine WordCount(this Engine en, string? name = null)
        {
            return en.Execute("WordCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an association whose keys are the distinct words identified in string, and whose values give the number of times those words appear in string.
        /// https://reference.wolfram.com/language/ref/WordCounts.html
        ///</summary>
        public static Engine WordCounts(this Engine en, string? name = null)
        {
            return en.Execute("WordCounts[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of full word specifications representing possible uses and senses of "word".
        /// https://reference.wolfram.com/language/ref/WordData.html
        ///</summary>
        public static Engine WordData(this Engine en, string? name = null)
        {
            return en.Execute("WordData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the dictionary definitions available for "word".
        /// https://reference.wolfram.com/language/ref/WordDefinition.html
        ///</summary>
        public static Engine WordDefinition(this Engine en, string? name = null)
        {
            return en.Execute("WordDefinition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the frequency of word in typical published English text.
        /// https://reference.wolfram.com/language/ref/WordFrequencyData.html
        ///</summary>
        public static Engine WordFrequencyData(this Engine en, string? name = null)
        {
            return en.Execute("WordFrequencyData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of words of the specified type.
        /// https://reference.wolfram.com/language/ref/WordList.html
        ///</summary>
        public static Engine WordList(this Engine en, string? name = null)
        {
            return en.Execute("WordList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a stemmed form of word, removing plurals, inflections, etc.
        /// https://reference.wolfram.com/language/ref/WordStem.html
        ///</summary>
        public static Engine WordStem(this Engine en, string? name = null)
        {
            return en.Execute("WordStem[" + en.ValidNames.Last() + "]", name);
        }


    }
}
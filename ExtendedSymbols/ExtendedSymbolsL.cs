namespace NetWolf
{
    public static class ExtendedSymbolsL
    {
        ///<summary>
        ///returns a color from an HTML color name etc.
        ///https://reference.wolfram.com/language/ref/LABColor.html
        ///</summary>
        public static Engine LABColor(this Engine en, string? name = null)
        {
            return en.Execute("LABColor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a point in a compound expression to which control can be transferred using Goto.
        ///https://reference.wolfram.com/language/ref/Label.html
        ///</summary>
        public static Engine Label(this Engine en, string? name = null)
        {
            return en.Execute("Label[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the lambda components of the graph g.
        ///https://reference.wolfram.com/language/ref/LambdaComponents.html
        ///</summary>
        public static Engine LambdaComponents(this Engine en, string? name = null)
        {
            return en.Execute("LambdaComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Lanczos window function of x.
        ///https://reference.wolfram.com/language/ref/LanczosWindow.html
        ///</summary>
        public static Engine LanczosWindow(this Engine en, string? name = null)
        {
            return en.Execute("LanczosWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to determine what human language text in string is in, predominantly.
        ///https://reference.wolfram.com/language/ref/LanguageIdentify.html
        ///</summary>
        public static Engine LanguageIdentify(this Engine en, string? name = null)
        {
            return en.Execute("LanguageIdentify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Laplacian term  with model variables vars.
        ///https://reference.wolfram.com/language/ref/LaplacianPDETerm.html
        ///</summary>
        public static Engine LaplacianPDETerm(this Engine en, string? name = null)
        {
            return en.Execute("LaplacianPDETerm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the last element in expr.
        ///https://reference.wolfram.com/language/ref/Last.html
        ///</summary>
        public static Engine Last(this Engine en, string? name = null)
        {
            return en.Execute("Last[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the latitude in degrees of a geographic position specified by pos.
        ///https://reference.wolfram.com/language/ref/Latitude.html
        ///</summary>
        public static Engine Latitude(this Engine en, string? name = null)
        {
            return en.Execute("Latitude[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the latitude and longitude in degrees of a geographic position specified by pos.
        ///https://reference.wolfram.com/language/ref/LatitudeLongitude.html
        ///</summary>
        public static Engine LatitudeLongitude(this Engine en, string? name = null)
        {
            return en.Execute("LatitudeLongitude[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of named lattices of dimension n.
        ///https://reference.wolfram.com/language/ref/LatticeData.html
        ///</summary>
        public static Engine LatticeData(this Engine en, string? name = null)
        {
            return en.Execute("LatticeData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a reduced basis for the set of vectors vi.
        ///https://reference.wolfram.com/language/ref/LatticeReduce.html
        ///</summary>
        public static Engine LatticeReduce(this Engine en, string? name = null)
        {
            return en.Execute("LatticeReduce[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///launches n local subkernels on the current computer.
        ///https://reference.wolfram.com/language/ref/LaunchKernels.html
        ///</summary>
        public static Engine LaunchKernels(this Engine en, string? name = null)
        {
            return en.Execute("LaunchKernels[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a layered plot of the graph g.
        ///https://reference.wolfram.com/language/ref/LayeredGraphPlot.html
        ///</summary>
        public static Engine LayeredGraphPlot(this Engine en, string? name = null)
        {
            return en.Execute("LayeredGraphPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a 3D layered plot of the graph g.
        ///https://reference.wolfram.com/language/ref/LayeredGraphPlot3D.html
        ///</summary>
        public static Engine LayeredGraphPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("LayeredGraphPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a color from an HTML color name etc.
        ///https://reference.wolfram.com/language/ref/LCHColor.html
        ///</summary>
        public static Engine LCHColor(this Engine en, string? name = null)
        {
            return en.Execute("LCHColor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the total number of indivisible subexpressions in expr.
        ///https://reference.wolfram.com/language/ref/LeafCount.html
        ///</summary>
        public static Engine LeafCount(this Engine en, string? name = null)
        {
            return en.Execute("LeafCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a repeated calendar element caused by a leap period.
        ///https://reference.wolfram.com/language/ref/LeapVariant.html
        ///</summary>
        public static Engine LeapVariant(this Engine en, string? name = null)
        {
            return en.Execute("LeapVariant[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if the year corresponding to date is a leap year.
        ///https://reference.wolfram.com/language/ref/LeapYearQ.html
        ///</summary>
        public static Engine LeapYearQ(this Engine en, string? name = null)
        {
            return en.Execute("LeapYearQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a LearnedDistribution[…] that attempts to represent an underlying distribution for the examples given.
        ///https://reference.wolfram.com/language/ref/LearnDistribution.html
        ///</summary>
        public static Engine LearnDistribution(this Engine en, string? name = null)
        {
            return en.Execute("LearnDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a distribution generated by LearnDistribution.
        ///https://reference.wolfram.com/language/ref/LearnedDistribution.html
        ///</summary>
        public static Engine LearnedDistribution(this Engine en, string? name = null)
        {
            return en.Execute("LearnedDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of elements in expr.
        ///https://reference.wolfram.com/language/ref/Length.html
        ///</summary>
        public static Engine Length(this Engine en, string? name = null)
        {
            return en.Execute("Length[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x≤y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/LessEqualThan.html
        ///</summary>
        public static Engine LessEqualThan(this Engine en, string? name = null)
        {
            return en.Execute("LessEqualThan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x<y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/LessThan.html
        ///</summary>
        public static Engine LessThan(this Engine en, string? name = null)
        {
            return en.Execute("LessThan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an association whose keys are the distinct letters in string, and whose values give the number of times those letters appear in string.
        ///https://reference.wolfram.com/language/ref/LetterCounts.html
        ///</summary>
        public static Engine LetterCounts(this Engine en, string? name = null)
        {
            return en.Execute("LetterCounts[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the position of the character c in the English alphabet.
        ///https://reference.wolfram.com/language/ref/LetterNumber.html
        ///</summary>
        public static Engine LetterNumber(this Engine en, string? name = null)
        {
            return en.Execute("LetterNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if all the characters in the string are letters, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/LetterQ.html
        ///</summary>
        public static Engine LetterQ(this Engine en, string? name = null)
        {
            return en.Execute("LetterQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the variance of data is 1.
        ///https://reference.wolfram.com/language/ref/LeveneTest.html
        ///</summary>
        public static Engine LeveneTest(this Engine en, string? name = null)
        {
            return en.Execute("LeveneTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the d-dimensional Levi-Civita totally antisymmetric tensor.
        ///https://reference.wolfram.com/language/ref/LeviCivitaTensor.html
        ///</summary>
        public static Engine LeviCivitaTensor(this Engine en, string? name = null)
        {
            return en.Execute("LeviCivitaTensor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form that compares lists when applied to {a1,a2,…}, {b1,b2,…}.
        ///https://reference.wolfram.com/language/ref/LexicographicOrder.html
        ///</summary>
        public static Engine LexicographicOrder(this Engine en, string? name = null)
        {
            return en.Execute("LexicographicOrder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sorts the list of expressions ei in lexicographic order.
        ///https://reference.wolfram.com/language/ref/LexicographicSort.html
        ///</summary>
        public static Engine LexicographicSort(this Engine en, string? name = null)
        {
            return en.Execute("LexicographicSort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///specifies the data type for a LibraryFunction argument or result to be datatype.
        ///https://reference.wolfram.com/language/ref/LibraryDataType.html
        ///</summary>
        public static Engine LibraryDataType(this Engine en, string? name = null)
        {
            return en.Execute("LibraryDataType[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a function that has been loaded from a Wolfram Library.
        ///https://reference.wolfram.com/language/ref/LibraryFunction.html
        ///</summary>
        public static Engine LibraryFunction(this Engine en, string? name = null)
        {
            return en.Execute("LibraryFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns information about a LibraryFunction.
        ///https://reference.wolfram.com/language/ref/LibraryFunctionInformation.html
        ///</summary>
        public static Engine LibraryFunctionInformation(this Engine en, string? name = null)
        {
            return en.Execute("LibraryFunctionInformation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///unloads a LibraryFunction so that it cannot be used.
        ///https://reference.wolfram.com/language/ref/LibraryFunctionUnload.html
        ///</summary>
        public static Engine LibraryFunctionUnload(this Engine en, string? name = null)
        {
            return en.Execute("LibraryFunctionUnload[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///loads the dynamic library lib into the Wolfram System runtime.
        ///https://reference.wolfram.com/language/ref/LibraryLoad.html
        ///</summary>
        public static Engine LibraryLoad(this Engine en, string? name = null)
        {
            return en.Execute("LibraryLoad[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///unloads all functions that have been loaded from a Wolfram Library, then it unloads the library.
        ///https://reference.wolfram.com/language/ref/LibraryUnload.html
        ///</summary>
        public static Engine LibraryUnload(this Engine en, string? name = null)
        {
            return en.Execute("LibraryUnload[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an on-demand license entitlement.
        ///https://reference.wolfram.com/language/ref/LicenseEntitlementObject.html
        ///</summary>
        public static Engine LicenseEntitlementObject(this Engine en, string? name = null)
        {
            return en.Execute("LicenseEntitlementObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents lifting-filter data used to compute forward and inverse lifting wavelet transforms.
        ///https://reference.wolfram.com/language/ref/LiftingFilterData.html
        ///</summary>
        public static Engine LiftingFilterData(this Engine en, string? name = null)
        {
            return en.Execute("LiftingFilterData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the lifting wavelet transform (LWT) of an array of data.
        ///https://reference.wolfram.com/language/ref/LiftingWaveletTransform.html
        ///</summary>
        public static Engine LiftingWaveletTransform(this Engine en, string? name = null)
        {
            return en.Execute("LiftingWaveletTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a lighter version of the specified color.
        ///https://reference.wolfram.com/language/ref/Lighter.html
        ///</summary>
        public static Engine Lighter(this Engine en, string? name = null)
        {
            return en.Execute("Lighter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Lindley distribution with shape parameter δ.
        ///https://reference.wolfram.com/language/ref/LindleyDistribution.html
        ///</summary>
        public static Engine LindleyDistribution(this Engine en, string? name = null)
        {
            return en.Execute("LindleyDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the line segments joining a sequence for points pi.
        ///https://reference.wolfram.com/language/ref/Line.html
        ///</summary>
        public static Engine Line(this Engine en, string? name = null)
        {
            return en.Execute("Line[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents a linear fractional transformation defined by the homogeneous matrix m.
        ///https://reference.wolfram.com/language/ref/LinearFractionalTransform.html
        ///</summary>
        public static Engine LinearFractionalTransform(this Engine en, string? name = null)
        {
            return en.Execute("LinearFractionalTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics directive specifying that faces of polygons and other filled graphics objects are to be drawn using a progressive transition between colors coli along a straight horizontal line.
        ///https://reference.wolfram.com/language/ref/LinearGradientFilling.html
        ///</summary>
        public static Engine LinearGradientFilling(this Engine en, string? name = null)
        {
            return en.Execute("LinearGradientFilling[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an image with values linearly changing from left to right based on gradient color gcol.
        ///https://reference.wolfram.com/language/ref/LinearGradientImage.html
        ///</summary>
        public static Engine LinearGradientImage(this Engine en, string? name = null)
        {
            return en.Execute("LinearGradientImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents data of an AffineStateSpaceModel linearized by functions such as FeedbackLinearize and StateTransformationLinearize using transformation of variables.
        ///https://reference.wolfram.com/language/ref/LinearizingTransformationData.html
        ///</summary>
        public static Engine LinearizingTransformationData(this Engine en, string? name = null)
        {
            return en.Execute("LinearizingTransformationData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a trainable, fully connected net layer that computes  with output vector of size n.
        ///https://reference.wolfram.com/language/ref/LinearLayer.html
        ///</summary>
        public static Engine LinearLayer(this Engine en, string? name = null)
        {
            return en.Execute("LinearLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///constructs a linear model from the design matrix m and response vector v.
        ///https://reference.wolfram.com/language/ref/LinearModelFit.html
        ///</summary>
        public static Engine LinearModelFit(this Engine en, string? name = null)
        {
            return en.Execute("LinearModelFit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a LinearSolveFunction[…] that can be applied repeatedly to different b.
        ///https://reference.wolfram.com/language/ref/LinearSolve.html
        ///</summary>
        public static Engine LinearSolve(this Engine en, string? name = null)
        {
            return en.Execute("LinearSolve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a line break chart of closing prices for the financial entity "name" over the date range daterange.
        ///https://reference.wolfram.com/language/ref/LineBreakChart.html
        ///</summary>
        public static Engine LineBreakChart(this Engine en, string? name = null)
        {
            return en.Execute("LineBreakChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the line graph of the graph g.
        ///https://reference.wolfram.com/language/ref/LineGraph.html
        ///</summary>
        public static Engine LineGraph(this Engine en, string? name = null)
        {
            return en.Execute("LineGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a legend with inherited colors within visualization functions.
        ///https://reference.wolfram.com/language/ref/LineLegend.html
        ///</summary>
        public static Engine LineLegend(this Engine en, string? name = null)
        {
            return en.Execute("LineLegend[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///activates a WSTP connection, waiting for the program at the other end to respond.
        ///https://reference.wolfram.com/language/ref/LinkActivate.html
        ///</summary>
        public static Engine LinkActivate(this Engine en, string? name = null)
        {
            return en.Execute("LinkActivate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///closes an open WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkClose.html
        ///</summary>
        public static Engine LinkClose(this Engine en, string? name = null)
        {
            return en.Execute("LinkClose[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///connects to a WSTP link created by another program.
        ///https://reference.wolfram.com/language/ref/LinkConnect.html
        ///</summary>
        public static Engine LinkConnect(this Engine en, string? name = null)
        {
            return en.Execute("LinkConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a WSTP link with the specified name for another program to connect to.
        ///https://reference.wolfram.com/language/ref/LinkCreate.html
        ///</summary>
        public static Engine LinkCreate(this Engine en, string? name = null)
        {
            return en.Execute("LinkCreate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sends an interrupt to the program at the other end of the specified WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkInterrupt.html
        ///</summary>
        public static Engine LinkInterrupt(this Engine en, string? name = null)
        {
            return en.Execute("LinkInterrupt[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///starts the external program prog and opens a WSTP connection to it.
        ///https://reference.wolfram.com/language/ref/LinkLaunch.html
        ///</summary>
        public static Engine LinkLaunch(this Engine en, string? name = null)
        {
            return en.Execute("LinkLaunch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the patterns for which definitions were set up when the external program associated with the specified WSTP connection was installed.
        ///https://reference.wolfram.com/language/ref/LinkPatterns.html
        ///</summary>
        public static Engine LinkPatterns(this Engine en, string? name = null)
        {
            return en.Execute("LinkPatterns[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads one expression from the specified WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkRead.html
        ///</summary>
        public static Engine LinkRead(this Engine en, string? name = null)
        {
            return en.Execute("LinkRead[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether there is an expression ready to read from the specified WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkReadyQ.html
        ///</summary>
        public static Engine LinkReadyQ(this Engine en, string? name = null)
        {
            return en.Execute("LinkReadyQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///lists only links whose names match the specified string pattern.
        ///https://reference.wolfram.com/language/ref/Links.html
        ///</summary>
        public static Engine Links(this Engine en, string? name = null)
        {
            return en.Execute("Links[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Liouville function .
        ///https://reference.wolfram.com/language/ref/LiouvilleLambda.html
        ///</summary>
        public static Engine LiouvilleLambda(this Engine en, string? name = null)
        {
            return en.Execute("LiouvilleLambda[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates an animation whose frames are the successive expri.
        ///https://reference.wolfram.com/language/ref/ListAnimate.html
        ///</summary>
        public static Engine ListAnimate(this Engine en, string? name = null)
        {
            return en.Execute("ListAnimate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a contour plot from a three-dimensional array of values.
        ///https://reference.wolfram.com/language/ref/ListContourPlot3D.html
        ///</summary>
        public static Engine ListContourPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ListContourPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a smooth density plot from an array of values.
        ///https://reference.wolfram.com/language/ref/ListDensityPlot3D.html
        ///</summary>
        public static Engine ListDensityPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ListDensityPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///constructs an InterpolatingFunction object that represents an approximate function that interpolates the array of values given.
        ///https://reference.wolfram.com/language/ref/ListInterpolation.html
        ///</summary>
        public static Engine ListInterpolation(this Engine en, string? name = null)
        {
            return en.Execute("ListInterpolation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a line integral convolution plot of image convolved with the vector field defined by an array of vector field values.
        ///https://reference.wolfram.com/language/ref/ListLineIntegralConvolutionPlot.html
        ///</summary>
        public static Engine ListLineIntegralConvolutionPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListLineIntegralConvolutionPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots a line through the points {1,y1},{2,y2},….
        ///https://reference.wolfram.com/language/ref/ListLinePlot.html
        ///</summary>
        public static Engine ListLinePlot(this Engine en, string? name = null)
        {
            return en.Execute("ListLinePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots curves through multiple sets of {x,y,z} points.
        ///https://reference.wolfram.com/language/ref/ListLinePlot3D.html
        ///</summary>
        public static Engine ListLinePlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ListLinePlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a log-linear plot of the yi, assumed to correspond to x coordinates 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ListLogLinearPlot.html
        ///</summary>
        public static Engine ListLogLinearPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListLogLinearPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a log-log plot of the yi, assumed to correspond to x coordinates 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ListLogLogPlot.html
        ///</summary>
        public static Engine ListLogLogPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListLogLogPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a log plot of the yi, assumed to correspond to x coordinates 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ListLogPlot.html
        ///</summary>
        public static Engine ListLogPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListLogPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates an object that plays as a sound whose amplitude is given by the sequence of levels ai.
        ///https://reference.wolfram.com/language/ref/ListPlay.html
        ///</summary>
        public static Engine ListPlay(this Engine en, string? name = null)
        {
            return en.Execute("ListPlay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots points {1,y1},{2,y2},….
        ///https://reference.wolfram.com/language/ref/ListPlot.html
        ///</summary>
        public static Engine ListPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the surfaces corresponding to each of the datai.
        ///https://reference.wolfram.com/language/ref/ListPlot3D.html
        ///</summary>
        public static Engine ListPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ListPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a 3D scatter plot of points with a 2D array of height values.
        ///https://reference.wolfram.com/language/ref/ListPointPlot3D.html
        ///</summary>
        public static Engine ListPointPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ListPointPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots points equally spaced in angle at radii ri.
        ///https://reference.wolfram.com/language/ref/ListPolarPlot.html
        ///</summary>
        public static Engine ListPolarPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListPolarPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the head of expr is List, and False otherwise.
        ///https://reference.wolfram.com/language/ref/ListQ.html
        ///</summary>
        public static Engine ListQ(this Engine en, string? name = null)
        {
            return en.Execute("ListQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the values y1, y2, … in steps at points 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ListStepPlot.html
        ///</summary>
        public static Engine ListStepPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListStepPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a stream density plot from a 2D array of vector and scalar field values {{vxij,vyij},sij}.
        ///https://reference.wolfram.com/language/ref/ListStreamDensityPlot.html
        ///</summary>
        public static Engine ListStreamDensityPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListStreamDensityPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a stream plot from an array of vector field values.
        ///https://reference.wolfram.com/language/ref/ListStreamPlot.html
        ///</summary>
        public static Engine ListStreamPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListStreamPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots streamlines for the vector field given as an array of vectors.
        ///https://reference.wolfram.com/language/ref/ListStreamPlot3D.html
        ///</summary>
        public static Engine ListStreamPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ListStreamPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a vector plot from a 2D array of vector and scalar field values {{vxij,vyij},sij}.
        ///https://reference.wolfram.com/language/ref/ListVectorDensityPlot.html
        ///</summary>
        public static Engine ListVectorDensityPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListVectorDensityPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a vector plot from an array of vector field values.
        ///https://reference.wolfram.com/language/ref/ListVectorPlot.html
        ///</summary>
        public static Engine ListVectorPlot(this Engine en, string? name = null)
        {
            return en.Execute("ListVectorPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a 3D vector plot from a 3D array of vector field values.
        ///https://reference.wolfram.com/language/ref/ListVectorPlot3D.html
        ///</summary>
        public static Engine ListVectorPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ListVectorPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a literal value x for use as a type.
        ///https://reference.wolfram.com/language/ref/LiteralType.html
        ///</summary>
        public static Engine LiteralType(this Engine en, string? name = null)
        {
            return en.Execute("LiteralType[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///caches a cloud object in a local object.
        ///https://reference.wolfram.com/language/ref/LocalCache.html
        ///</summary>
        public static Engine LocalCache(this Engine en, string? name = null)
        {
            return en.Execute("LocalCache[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of local clustering coefficients of all vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/LocalClusteringCoefficient.html
        ///</summary>
        public static Engine LocalClusteringCoefficient(this Engine en, string? name = null)
        {
            return en.Execute("LocalClusteringCoefficient[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the result of evaluating expr using your current default local Wolfram Language kernel.
        ///https://reference.wolfram.com/language/ref/LocalEvaluate.html
        ///</summary>
        public static Engine LocalEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("LocalEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a local object with a given file path.
        ///https://reference.wolfram.com/language/ref/LocalObject.html
        ///</summary>
        public static Engine LocalObject(this Engine en, string? name = null)
        {
            return en.Execute("LocalObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of local objects in the local directory dir.
        ///https://reference.wolfram.com/language/ref/LocalObjects.html
        ///</summary>
        public static Engine LocalObjects(this Engine en, string? name = null)
        {
            return en.Execute("LocalObjects[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits a task to evaluate expr in a separate kernel.
        ///https://reference.wolfram.com/language/ref/LocalSubmit.html
        ///</summary>
        public static Engine LocalSubmit(this Engine en, string? name = null)
        {
            return en.Execute("LocalSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a symbol whose value is persistently stored in the local file system.
        ///https://reference.wolfram.com/language/ref/LocalSymbol.html
        ///</summary>
        public static Engine LocalSymbol(this Engine en, string? name = null)
        {
            return en.Execute("LocalSymbol[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the current local time at the geo location specified by loc.
        ///https://reference.wolfram.com/language/ref/LocalTime.html
        ///</summary>
        public static Engine LocalTime(this Engine en, string? name = null)
        {
            return en.Execute("LocalTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the current time zone for the geo location specified by loc.
        ///https://reference.wolfram.com/language/ref/LocalTimeZone.html
        ///</summary>
        public static Engine LocalTimeZone(this Engine en, string? name = null)
        {
            return en.Execute("LocalTimeZone[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the means or medians of the datai are equal.
        ///https://reference.wolfram.com/language/ref/LocationEquivalenceTest.html
        ///</summary>
        public static Engine LocationEquivalenceTest(this Engine en, string? name = null)
        {
            return en.Execute("LocationEquivalenceTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the mean or median of the data is zero.
        ///https://reference.wolfram.com/language/ref/LocationTest.html
        ///</summary>
        public static Engine LocationTest(this Engine en, string? name = null)
        {
            return en.Execute("LocationTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a locator object at position {x,y} in a graphic.
        ///https://reference.wolfram.com/language/ref/Locator.html
        ///</summary>
        public static Engine Locator(this Engine en, string? name = null)
        {
            return en.Execute("Locator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the natural logarithm of z (logarithm to base ).
        ///https://reference.wolfram.com/language/ref/Log.html
        ///</summary>
        public static Engine Log(this Engine en, string? name = null)
        {
            return en.Execute("Log[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the base-10 logarithm of x.
        ///https://reference.wolfram.com/language/ref/Log10.html
        ///</summary>
        public static Engine Log10(this Engine en, string? name = null)
        {
            return en.Execute("Log10[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the base-2 logarithm of x.
        ///https://reference.wolfram.com/language/ref/Log2.html
        ///</summary>
        public static Engine Log2(this Engine en, string? name = null)
        {
            return en.Execute("Log2[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the logarithm of the Barnes G-function .
        ///https://reference.wolfram.com/language/ref/LogBarnesG.html
        ///</summary>
        public static Engine LogBarnesG(this Engine en, string? name = null)
        {
            return en.Execute("LogBarnesG[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the logarithm of the gamma function .
        ///https://reference.wolfram.com/language/ref/LogGamma.html
        ///</summary>
        public static Engine LogGamma(this Engine en, string? name = null)
        {
            return en.Execute("LogGamma[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///expands out logical combinations of equations, inequalities, and other functions.
        ///https://reference.wolfram.com/language/ref/LogicalExpand.html
        ///</summary>
        public static Engine LogicalExpand(this Engine en, string? name = null)
        {
            return en.Execute("LogicalExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the logarithmic integral function .
        ///https://reference.wolfram.com/language/ref/LogIntegral.html
        ///</summary>
        public static Engine LogIntegral(this Engine en, string? name = null)
        {
            return en.Execute("LogIntegral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the logistic sigmoid function.
        ///https://reference.wolfram.com/language/ref/LogisticSigmoid.html
        ///</summary>
        public static Engine LogisticSigmoid(this Engine en, string? name = null)
        {
            return en.Execute("LogisticSigmoid[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///constructs a binomial logistic regression model from the design matrix m and response vector v.
        ///https://reference.wolfram.com/language/ref/LogitModelFit.html
        ///</summary>
        public static Engine LogitModelFit(this Engine en, string? name = null)
        {
            return en.Execute("LogitModelFit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests for equal hazard rates among the datai using a log-rank type test.
        ///https://reference.wolfram.com/language/ref/LogRankTest.html
        ///</summary>
        public static Engine LogRankTest(this Engine en, string? name = null)
        {
            return en.Execute("LogRankTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a logarithmic series distribution with parameter θ.
        ///https://reference.wolfram.com/language/ref/LogSeriesDistribution.html
        ///</summary>
        public static Engine LogSeriesDistribution(this Engine en, string? name = null)
        {
            return en.Execute("LogSeriesDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pattern object that matches the longest sequence consistent with the pattern p.
        ///https://reference.wolfram.com/language/ref/Longest.html
        ///</summary>
        public static Engine Longest(this Engine en, string? name = null)
        {
            return en.Execute("Longest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the longest ordered sequence of contiguous or disjoint elements in list.
        ///https://reference.wolfram.com/language/ref/LongestOrderedSequence.html
        ///</summary>
        public static Engine LongestOrderedSequence(this Engine en, string? name = null)
        {
            return en.Execute("LongestOrderedSequence[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the longitude in degrees of a geographic position specified by pos.
        ///https://reference.wolfram.com/language/ref/Longitude.html
        ///</summary>
        public static Engine Longitude(this Engine en, string? name = null)
        {
            return en.Execute("Longitude[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a trainable recurrent layer that takes a sequence of vectors and produces a sequence of vectors, each of size n.
        ///https://reference.wolfram.com/language/ref/LongShortTermMemoryLayer.html
        ///</summary>
        public static Engine LongShortTermMemoryLayer(this Engine en, string? name = null)
        {
            return en.Execute("LongShortTermMemoryLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of Lookup that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Lookup.html
        ///</summary>
        public static Engine Lookup(this Engine en, string? name = null)
        {
            return en.Execute("Lookup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g has no self-loops, and False otherwise.
        ///https://reference.wolfram.com/language/ref/LoopFreeGraphQ.html
        ///</summary>
        public static Engine LoopFreeGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("LoopFreeGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if all the characters in the string are lowercase letters, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/LowerCaseQ.html
        ///</summary>
        public static Engine LowerCaseQ(this Engine en, string? name = null)
        {
            return en.Execute("LowerCaseQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a matrix in which all but the lower triangular elements of m are replaced with zeros.
        ///https://reference.wolfram.com/language/ref/LowerTriangularize.html
        ///</summary>
        public static Engine LowerTriangularize(this Engine en, string? name = null)
        {
            return en.Execute("LowerTriangularize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts the lower triangular matrix lmat to a structured array.
        ///https://reference.wolfram.com/language/ref/LowerTriangularMatrix.html
        ///</summary>
        public static Engine LowerTriangularMatrix(this Engine en, string? name = null)
        {
            return en.Execute("LowerTriangularMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is lower triangular, and False otherwise.
        ///https://reference.wolfram.com/language/ref/LowerTriangularMatrixQ.html
        ///</summary>
        public static Engine LowerTriangularMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("LowerTriangularMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Lucas number .
        ///https://reference.wolfram.com/language/ref/LucasL.html
        ///</summary>
        public static Engine LucasL(this Engine en, string? name = null)
        {
            return en.Execute("LucasL[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Luccio–Sami components of the graph g.
        ///https://reference.wolfram.com/language/ref/LuccioSamiComponents.html
        ///</summary>
        public static Engine LuccioSamiComponents(this Engine en, string? name = null)
        {
            return en.Execute("LuccioSamiComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a representation of the LU decomposition of a square matrix m.
        ///https://reference.wolfram.com/language/ref/LUDecomposition.html
        ///</summary>
        public static Engine LUDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("LUDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the time for the next lunar eclipse after the specified date.
        ///https://reference.wolfram.com/language/ref/LunarEclipse.html
        ///</summary>
        public static Engine LunarEclipse(this Engine en, string? name = null)
        {
            return en.Execute("LunarEclipse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a color from an HTML color name etc.
        ///https://reference.wolfram.com/language/ref/LUVColor.html
        ///</summary>
        public static Engine LUVColor(this Engine en, string? name = null)
        {
            return en.Execute("LUVColor[" + en.ValidNames.Last() + "]", name);
        }


    }
}
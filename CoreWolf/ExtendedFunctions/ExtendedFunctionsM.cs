namespace CoreWolf
{
    public static class ExtendedFunctionsM
    {
        ///<summary>
        /// returns True if expr is a machine‐precision real or complex number, and returns False otherwise.
        /// https://reference.wolfram.com/language/ref/MachineNumberQ.html
        ///</summary>
        public static Engine MachineNumberQ(this Engine en, string? name = null)
        {
            return en.Execute("MachineNumberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays with expr magnified by a fixed factor.
        /// https://reference.wolfram.com/language/ref/Magnify.html
        ///</summary>
        public static Engine Magnify(this Engine en, string? name = null)
        {
            return en.Execute("Magnify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a mail folder associated with an active mail server connection.
        /// https://reference.wolfram.com/language/ref/MailFolder.html
        ///</summary>
        public static Engine MailFolder(this Engine en, string? name = null)
        {
            return en.Execute("MailFolder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an item of mail associated with an active mail server connection.
        /// https://reference.wolfram.com/language/ref/MailItem.html
        ///</summary>
        public static Engine MailItem(this Engine en, string? name = null)
        {
            return en.Execute("MailItem[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a mail receiver function that applies fun to any mail message it receives.
        /// https://reference.wolfram.com/language/ref/MailReceiverFunction.html
        ///</summary>
        public static Engine MailReceiverFunction(this Engine en, string? name = null)
        {
            return en.Execute("MailReceiverFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// searches the current default mail inbox.
        /// https://reference.wolfram.com/language/ref/MailSearch.html
        ///</summary>
        public static Engine MailSearch(this Engine en, string? name = null)
        {
            return en.Execute("MailSearch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// connects to the specified incoming mail server "server".
        /// https://reference.wolfram.com/language/ref/MailServerConnect.html
        ///</summary>
        public static Engine MailServerConnect(this Engine en, string? name = null)
        {
            return en.Execute("MailServerConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a symbolic representation of a connection to an incoming mail server.
        /// https://reference.wolfram.com/language/ref/MailServerConnection.html
        ///</summary>
        public static Engine MailServerConnection(this Engine en, string? name = null)
        {
            return en.Execute("MailServerConnection[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is the function to convert expr to StandardForm boxes.
        /// https://reference.wolfram.com/language/ref/MakeBoxes.html
        ///</summary>
        public static Engine MakeBoxes(this Engine en, string? name = null)
        {
            return en.Execute("MakeBoxes[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the positive integer ID associated with expr if it is a managed library expression and $Failed otherwise.
        /// https://reference.wolfram.com/language/ref/ManagedLibraryExpressionID.html
        ///</summary>
        public static Engine ManagedLibraryExpressionID(this Engine en, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionID[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if expr is a managed library expression and False otherwise.
        /// https://reference.wolfram.com/language/ref/ManagedLibraryExpressionQ.html
        ///</summary>
        public static Engine ManagedLibraryExpressionQ(this Engine en, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Böttcher coordinate of z with respect to the Mandelbrot set.
        /// https://reference.wolfram.com/language/ref/MandelbrotSetBoettcher.html
        ///</summary>
        public static Engine MandelbrotSetBoettcher(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetBoettcher[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// estimates the distance from c to the nearest point in the Mandelbrot set.
        /// https://reference.wolfram.com/language/ref/MandelbrotSetDistance.html
        ///</summary>
        public static Engine MandelbrotSetDistance(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetDistance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the number of iterations of the function , beginning with , that are needed to determine whether c is in the Mandelbrot set.
        /// https://reference.wolfram.com/language/ref/MandelbrotSetIterationCount.html
        ///</summary>
        public static Engine MandelbrotSetIterationCount(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetIterationCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if z is in the Mandelbrot set, and False otherwise.
        /// https://reference.wolfram.com/language/ref/MandelbrotSetMemberQ.html
        ///</summary>
        public static Engine MandelbrotSetMemberQ(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetMemberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the portion of the Mandelbrot set inside the rectangle with corners zmin and zmax.
        /// https://reference.wolfram.com/language/ref/MandelbrotSetPlot.html
        ///</summary>
        public static Engine MandelbrotSetPlot(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the von Mangoldt function .
        /// https://reference.wolfram.com/language/ref/MangoldtLambda.html
        ///</summary>
        public static Engine MangoldtLambda(this Engine en, string? name = null)
        {
            return en.Execute("MangoldtLambda[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a manipulator with setting x in the range 0 to 1.
        /// https://reference.wolfram.com/language/ref/Manipulator.html
        ///</summary>
        public static Engine Manipulator(this Engine en, string? name = null)
        {
            return en.Execute("Manipulator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the medians of data1 and data2 are equal.
        /// https://reference.wolfram.com/language/ref/MannWhitneyTest.html
        ///</summary>
        public static Engine MannWhitneyTest(this Engine en, string? name = null)
        {
            return en.Execute("MannWhitneyTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list containing the mantissa and exponent of a number x.
        /// https://reference.wolfram.com/language/ref/MantissaExponent.html
        ///</summary>
        public static Engine MantissaExponent(this Engine en, string? name = null)
        {
            return en.Execute("MantissaExponent[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MapApply that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/MapApply.html
        ///</summary>
        public static Engine MapApply(this Engine en, string? name = null)
        {
            return en.Execute("MapApply[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MapIndexed that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/MapIndexed.html
        ///</summary>
        public static Engine MapIndexed(this Engine en, string? name = null)
        {
            return en.Execute("MapIndexed[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MapThread that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/MapThread.html
        ///</summary>
        public static Engine MapThread(this Engine en, string? name = null)
        {
            return en.Execute("MapThread[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Marchenko–Pastur distribution with unit scale parameter.
        /// https://reference.wolfram.com/language/ref/MarchenkoPasturDistribution.html
        ///</summary>
        public static Engine MarchenkoPasturDistribution(this Engine en, string? name = null)
        {
            return en.Execute("MarchenkoPasturDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether data follows a MultinormalDistribution using the Mardia combined test.
        /// https://reference.wolfram.com/language/ref/MardiaCombinedTest.html
        ///</summary>
        public static Engine MardiaCombinedTest(this Engine en, string? name = null)
        {
            return en.Execute("MardiaCombinedTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether data follows a MultinormalDistribution using the Mardia kurtosis test.
        /// https://reference.wolfram.com/language/ref/MardiaKurtosisTest.html
        ///</summary>
        public static Engine MardiaKurtosisTest(this Engine en, string? name = null)
        {
            return en.Execute("MardiaKurtosisTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether data follows a MultinormalDistribution using the Mardia skewness test.
        /// https://reference.wolfram.com/language/ref/MardiaSkewnessTest.html
        ///</summary>
        public static Engine MardiaSkewnessTest(this Engine en, string? name = null)
        {
            return en.Execute("MardiaSkewnessTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a summary of properties for the finite state Markov process mproc.
        /// https://reference.wolfram.com/language/ref/MarkovProcessProperties.html
        ///</summary>
        public static Engine MarkovProcessProperties(this Engine en, string? name = null)
        {
            return en.Execute("MarkovProcessProperties[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MatchQ that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/MatchQ.html
        ///</summary>
        public static Engine MatchQ(this Engine en, string? name = null)
        {
            return en.Execute("MatchQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a three-dimensional graphics directive specifying that surfaces that follow are to be drawn with the material "material" appearance.
        /// https://reference.wolfram.com/language/ref/MaterialShading.html
        ///</summary>
        public static Engine MaterialShading(this Engine en, string? name = null)
        {
            return en.Execute("MaterialShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints as a MathML form of expr.
        /// https://reference.wolfram.com/language/ref/MathMLForm.html
        ///</summary>
        public static Engine MathMLForm(this Engine en, string? name = null)
        {
            return en.Execute("MathMLForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the domain of matrices of dimensions d1×d2.
        /// https://reference.wolfram.com/language/ref/Matrices.html
        ///</summary>
        public static Engine Matrices(this Engine en, string? name = null)
        {
            return en.Execute("Matrices[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the matrix exponential of m.
        /// https://reference.wolfram.com/language/ref/MatrixExp.html
        ///</summary>
        public static Engine MatrixExp(this Engine en, string? name = null)
        {
            return en.Execute("MatrixExp[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints with the elements of list arranged in a regular array.
        /// https://reference.wolfram.com/language/ref/MatrixForm.html
        ///</summary>
        public static Engine MatrixForm(this Engine en, string? name = null)
        {
            return en.Execute("MatrixForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the matrix logarithm of a matrix m.
        /// https://reference.wolfram.com/language/ref/MatrixLog.html
        ///</summary>
        public static Engine MatrixLog(this Engine en, string? name = null)
        {
            return en.Execute("MatrixLog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a plot that gives a visual representation of the values of elements in a matrix.
        /// https://reference.wolfram.com/language/ref/MatrixPlot.html
        ///</summary>
        public static Engine MatrixPlot(this Engine en, string? name = null)
        {
            return en.Execute("MatrixPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is a list of lists or a two-dimensional SparseArray object that can represent a matrix, and gives False otherwise.
        /// https://reference.wolfram.com/language/ref/MatrixQ.html
        ///</summary>
        public static Engine MatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("MatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the rank of the matrix m.
        /// https://reference.wolfram.com/language/ref/MatrixRank.html
        ///</summary>
        public static Engine MatrixRank(this Engine en, string? name = null)
        {
            return en.Execute("MatrixRank[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the latest date of the datei.
        /// https://reference.wolfram.com/language/ref/MaxDate.html
        ///</summary>
        public static Engine MaxDate(this Engine en, string? name = null)
        {
            return en.Execute("MaxDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a binary image in which white pixels correspond to constant extended maxima in image.
        /// https://reference.wolfram.com/language/ref/MaxDetect.html
        ///</summary>
        public static Engine MaxDetect(this Engine en, string? name = null)
        {
            return en.Execute("MaxDetect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MaximalBy that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/MaximalBy.html
        ///</summary>
        public static Engine MaximalBy(this Engine en, string? name = null)
        {
            return en.Execute("MaximalBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the maximum number of bytes used during the evaluation of expr.
        /// https://reference.wolfram.com/language/ref/MaxMemoryUsed.html
        ///</summary>
        public static Engine MaxMemoryUsed(this Engine en, string? name = null)
        {
            return en.Execute("MaxMemoryUsed[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Maxwell distribution with scale parameter σ.
        /// https://reference.wolfram.com/language/ref/MaxwellDistribution.html
        ///</summary>
        public static Engine MaxwellDistribution(this Engine en, string? name = null)
        {
            return en.Execute("MaxwellDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the statistical mean of the elements in list.
        /// https://reference.wolfram.com/language/ref/Mean.html
        ///</summary>
        public static Engine Mean(this Engine en, string? name = null)
        {
            return en.Execute("Mean[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an Around object describing the mean of the xi and its uncertainty.
        /// https://reference.wolfram.com/language/ref/MeanAround.html
        ///</summary>
        public static Engine MeanAround(this Engine en, string? name = null)
        {
            return en.Execute("MeanAround[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the mean clustering coefficient of the graph g.
        /// https://reference.wolfram.com/language/ref/MeanClusteringCoefficient.html
        ///</summary>
        public static Engine MeanClusteringCoefficient(this Engine en, string? name = null)
        {
            return en.Execute("MeanClusteringCoefficient[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of k-mean degree connectivity for the graph g for successive k=0,1,2… .
        /// https://reference.wolfram.com/language/ref/MeanDegreeConnectivity.html
        ///</summary>
        public static Engine MeanDegreeConnectivity(this Engine en, string? name = null)
        {
            return en.Execute("MeanDegreeConnectivity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the mean absolute deviation from the mean of the elements in list.
        /// https://reference.wolfram.com/language/ref/MeanDeviation.html
        ///</summary>
        public static Engine MeanDeviation(this Engine en, string? name = null)
        {
            return en.Execute("MeanDeviation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the mean distance between all pairs of vertices in the graph g.
        /// https://reference.wolfram.com/language/ref/MeanGraphDistance.html
        ///</summary>
        public static Engine MeanGraphDistance(this Engine en, string? name = null)
        {
            return en.Execute("MeanGraphDistance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of mean neighbor degrees of vertices for the graph g.
        /// https://reference.wolfram.com/language/ref/MeanNeighborDegree.html
        ///</summary>
        public static Engine MeanNeighborDegree(this Engine en, string? name = null)
        {
            return en.Execute("MeanNeighborDegree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// estimates the mean point density  from point data pdata in the observation region reg.
        /// https://reference.wolfram.com/language/ref/MeanPointDensity.html
        ///</summary>
        public static Engine MeanPointDensity(this Engine en, string? name = null)
        {
            return en.Execute("MeanPointDensity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the median of the elements in list.
        /// https://reference.wolfram.com/language/ref/Median.html
        ///</summary>
        public static Engine Median(this Engine en, string? name = null)
        {
            return en.Execute("Median[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the median absolute deviation from the median of the elements in list.
        /// https://reference.wolfram.com/language/ref/MedianDeviation.html
        ///</summary>
        public static Engine MedianDeviation(this Engine en, string? name = null)
        {
            return en.Execute("MedianDeviation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MemberQ that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/MemberQ.html
        ///</summary>
        public static Engine MemberQ(this Engine en, string? name = null)
        {
            return en.Execute("MemberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of bytes used in the Wolfram System front end.
        /// https://reference.wolfram.com/language/ref/MemoryInUse.html
        ///</summary>
        public static Engine MemoryInUse(this Engine en, string? name = null)
        {
            return en.Execute("MemoryInUse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a mesh region representing the n-step Menger sponge.
        /// https://reference.wolfram.com/language/ref/MengerMesh.html
        ///</summary>
        public static Engine MengerMesh(this Engine en, string? name = null)
        {
            return en.Execute("MengerMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an object in which selecting the menu item with label lbli displays expri.
        /// https://reference.wolfram.com/language/ref/MenuView.html
        ///</summary>
        public static Engine MenuView(this Engine en, string? name = null)
        {
            return en.Execute("MenuView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of Merge that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/Merge.html
        ///</summary>
        public static Engine Merge(this Engine en, string? name = null)
        {
            return en.Execute("Merge[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n Mersenne prime exponent.
        /// https://reference.wolfram.com/language/ref/MersennePrimeExponent.html
        ///</summary>
        public static Engine MersennePrimeExponent(this Engine en, string? name = null)
        {
            return en.Execute("MersennePrimeExponent[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if n is a Mersenne prime exponent, and False otherwise.
        /// https://reference.wolfram.com/language/ref/MersennePrimeExponentQ.html
        ///</summary>
        public static Engine MersennePrimeExponentQ(this Engine en, string? name = null)
        {
            return en.Execute("MersennePrimeExponentQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list {c0,c1,…} of counts cd of cells of dimension d in the mesh region mreg.
        /// https://reference.wolfram.com/language/ref/MeshCellCount.html
        ///</summary>
        public static Engine MeshCellCount(this Engine en, string? name = null)
        {
            return en.Execute("MeshCellCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of coordinates in the mesh region mreg.
        /// https://reference.wolfram.com/language/ref/MeshCoordinates.html
        ///</summary>
        public static Engine MeshCoordinates(this Engine en, string? name = null)
        {
            return en.Execute("MeshCoordinates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the region reg is a valid MeshRegion object and False otherwise.
        /// https://reference.wolfram.com/language/ref/MeshRegionQ.html
        ///</summary>
        public static Engine MeshRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("MeshRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints the message symbol::tag unless it has been switched off.
        /// https://reference.wolfram.com/language/ref/Message.html
        ///</summary>
        public static Engine Message(this Engine en, string? name = null)
        {
            return en.Execute("Message[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// puts up a standard message dialog that displays expr together with an OK button.
        /// https://reference.wolfram.com/language/ref/MessageDialog.html
        ///</summary>
        public static Engine MessageDialog(this Engine en, string? name = null)
        {
            return en.Execute("MessageDialog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a global object assigned to be a list of the names of messages generated during the processing of the n input line.
        /// https://reference.wolfram.com/language/ref/MessageList.html
        ///</summary>
        public static Engine MessageList(this Engine en, string? name = null)
        {
            return en.Execute("MessageList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives all the messages assigned to a particular symbol.
        /// https://reference.wolfram.com/language/ref/Messages.html
        ///</summary>
        public static Engine Messages(this Engine en, string? name = null)
        {
            return en.Execute("Messages[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the Mexican hat wavelet of width σ.
        /// https://reference.wolfram.com/language/ref/MexicanHatWavelet.html
        ///</summary>
        public static Engine MexicanHatWavelet(this Engine en, string? name = null)
        {
            return en.Execute("MexicanHatWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the Meyer wavelet of order n evaluated on the equally spaced interval {-10,10}.
        /// https://reference.wolfram.com/language/ref/MeyerWavelet.html
        ///</summary>
        public static Engine MeyerWavelet(this Engine en, string? name = null)
        {
            return en.Execute("MeyerWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the midpoint of the line segment connecting the points p1 and p2.
        /// https://reference.wolfram.com/language/ref/Midpoint.html
        ///</summary>
        public static Engine Midpoint(this Engine en, string? name = null)
        {
            return en.Execute("Midpoint[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a list of file formats that matches the MIME type mime.
        /// https://reference.wolfram.com/language/ref/MIMETypeToFormatList.html
        ///</summary>
        public static Engine MIMETypeToFormatList(this Engine en, string? name = null)
        {
            return en.Execute("MIMETypeToFormatList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the earliest date of the datei.
        /// https://reference.wolfram.com/language/ref/MinDate.html
        ///</summary>
        public static Engine MinDate(this Engine en, string? name = null)
        {
            return en.Execute("MinDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a binary image in which white pixels correspond to constant extended minima in image.
        /// https://reference.wolfram.com/language/ref/MinDetect.html
        ///</summary>
        public static Engine MinDetect(this Engine en, string? name = null)
        {
            return en.Execute("MinDetect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MinimalBy that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/MinimalBy.html
        ///</summary>
        public static Engine MinimalBy(this Engine en, string? name = null)
        {
            return en.Execute("MinimalBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the minimal state-space model of the state-space model sys.
        /// https://reference.wolfram.com/language/ref/MinimalStateSpaceModel.html
        ///</summary>
        public static Engine MinimalStateSpaceModel(this Engine en, string? name = null)
        {
            return en.Execute("MinimalStateSpaceModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the minimum time increment in the time series tseries.
        /// https://reference.wolfram.com/language/ref/MinimumTimeIncrement.html
        ///</summary>
        public static Engine MinimumTimeIncrement(this Engine en, string? name = null)
        {
            return en.Execute("MinimumTimeIncrement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives Minkowski's question mark function .
        /// https://reference.wolfram.com/language/ref/MinkowskiQuestionMark.html
        ///</summary>
        public static Engine MinkowskiQuestionMark(this Engine en, string? name = null)
        {
            return en.Execute("MinkowskiQuestionMark[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list {Min[list],Max[list]}.
        /// https://reference.wolfram.com/language/ref/MinMax.html
        ///</summary>
        public static Engine MinMax(this Engine en, string? name = null)
        {
            return en.Execute("MinMax[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the minors of a matrix m.
        /// https://reference.wolfram.com/language/ref/Minors.html
        ///</summary>
        public static Engine Minors(this Engine en, string? name = null)
        {
            return en.Execute("Minors[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays as .
        /// https://reference.wolfram.com/language/ref/MinusPlus.html
        ///</summary>
        public static Engine MinusPlus(this Engine en, string? name = null)
        {
            return en.Execute("MinusPlus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// specifies a reason for the data's being missing.
        /// https://reference.wolfram.com/language/ref/Missing.html
        ///</summary>
        public static Engine Missing(this Engine en, string? name = null)
        {
            return en.Execute("Missing[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr has head Missing.
        /// https://reference.wolfram.com/language/ref/MissingQ.html
        ///</summary>
        public static Engine MissingQ(this Engine en, string? name = null)
        {
            return en.Execute("MissingQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list {IntegerPart[expr],FractionalPart[expr]}.
        /// https://reference.wolfram.com/language/ref/MixedFractionParts.html
        ///</summary>
        public static Engine MixedFractionParts(this Engine en, string? name = null)
        {
            return en.Execute("MixedFractionParts[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is a mixed graph and False otherwise.
        /// https://reference.wolfram.com/language/ref/MixedGraphQ.html
        ///</summary>
        public static Engine MixedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("MixedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a mixed-magnitude expression consisting of values val1 through valn.
        /// https://reference.wolfram.com/language/ref/MixedMagnitude.html
        ///</summary>
        public static Engine MixedMagnitude(this Engine en, string? name = null)
        {
            return en.Execute("MixedMagnitude[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the list of bases of a numerical system in which different digits have different bases.
        /// https://reference.wolfram.com/language/ref/MixedRadix.html
        ///</summary>
        public static Engine MixedRadix(this Engine en, string? name = null)
        {
            return en.Execute("MixedRadix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a mixed-unit expression consisting of units unit1 through unitn.
        /// https://reference.wolfram.com/language/ref/MixedUnit.html
        ///</summary>
        public static Engine MixedUnit(this Engine en, string? name = null)
        {
            return en.Execute("MixedUnit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the modular lambda elliptic function .
        /// https://reference.wolfram.com/language/ref/ModularLambda.html
        ///</summary>
        public static Engine ModularLambda(this Engine en, string? name = null)
        {
            return en.Execute("ModularLambda[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Möbius function .
        /// https://reference.wolfram.com/language/ref/MoebiusMu.html
        ///</summary>
        public static Engine MoebiusMu(this Engine en, string? name = null)
        {
            return en.Execute("MoebiusMu[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the molecule corresponding to the input name.
        /// https://reference.wolfram.com/language/ref/Molecule.html
        ///</summary>
        public static Engine Molecule(this Engine en, string? name = null)
        {
            return en.Execute("Molecule[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MoleculeContainsQ that can be applied to a molecule.
        /// https://reference.wolfram.com/language/ref/MoleculeContainsQ.html
        ///</summary>
        public static Engine MoleculeContainsQ(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeContainsQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays a window that initially contains the Molecule mol.
        /// https://reference.wolfram.com/language/ref/MoleculeDraw.html
        ///</summary>
        public static Engine MoleculeDraw(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeDraw[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MoleculeFreeQ that can be applied to a molecule.
        /// https://reference.wolfram.com/language/ref/MoleculeFreeQ.html
        ///</summary>
        public static Engine MoleculeFreeQ(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeFreeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a graph constructed from the molecule mol.
        /// https://reference.wolfram.com/language/ref/MoleculeGraph.html
        ///</summary>
        public static Engine MoleculeGraph(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MoleculeMatchQ that can be applied to a molecule.
        /// https://reference.wolfram.com/language/ref/MoleculeMatchQ.html
        ///</summary>
        public static Engine MoleculeMatchQ(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeMatchQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a molecule pattern representing the largest common substructure for the input molecules.
        /// https://reference.wolfram.com/language/ref/MoleculeMaximumCommonSubstructure.html
        ///</summary>
        public static Engine MoleculeMaximumCommonSubstructure(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeMaximumCommonSubstructure[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MoleculeModify that can be applied to a molecule.
        /// https://reference.wolfram.com/language/ref/MoleculeModify.html
        ///</summary>
        public static Engine MoleculeModify(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeModify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// attempts to return the systematic chemical name for the given molecule.
        /// https://reference.wolfram.com/language/ref/MoleculeName.html
        ///</summary>
        public static Engine MoleculeName(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a molecule pattern from the input SMARTS pattern.
        /// https://reference.wolfram.com/language/ref/MoleculePattern.html
        ///</summary>
        public static Engine MoleculePattern(this Engine en, string? name = null)
        {
            return en.Execute("MoleculePattern[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a two-dimensional structure diagram of the molecule mol.
        /// https://reference.wolfram.com/language/ref/MoleculePlot.html
        ///</summary>
        public static Engine MoleculePlot(this Engine en, string? name = null)
        {
            return en.Execute("MoleculePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a three-dimensional model of the molecule mol.
        /// https://reference.wolfram.com/language/ref/MoleculePlot3D.html
        ///</summary>
        public static Engine MoleculePlot3D(this Engine en, string? name = null)
        {
            return en.Execute("MoleculePlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a property identified by pname for use in MoleculeValue.
        /// https://reference.wolfram.com/language/ref/MoleculeProperty.html
        ///</summary>
        public static Engine MoleculeProperty(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeProperty[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if mol is a valid Molecule expression, and False otherwise.
        /// https://reference.wolfram.com/language/ref/MoleculeQ.html
        ///</summary>
        public static Engine MoleculeQ(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// recognizes a molecule in image and returns it as a Molecule object.
        /// https://reference.wolfram.com/language/ref/MoleculeRecognize.html
        ///</summary>
        public static Engine MoleculeRecognize(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeRecognize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of MoleculeSubstructureCount that can be applied to a molecule.
        /// https://reference.wolfram.com/language/ref/MoleculeSubstructureCount.html
        ///</summary>
        public static Engine MoleculeSubstructureCount(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeSubstructureCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the r formal moment.
        /// https://reference.wolfram.com/language/ref/Moment.html
        ///</summary>
        public static Engine Moment(this Engine en, string? name = null)
        {
            return en.Execute("Moment[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// computes the moment of inertia matrix for the region reg relative to the center of mass.
        /// https://reference.wolfram.com/language/ref/MomentOfInertia.html
        ///</summary>
        public static Engine MomentOfInertia(this Engine en, string? name = null)
        {
            return en.Execute("MomentOfInertia[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list of all monomials in the polynomial poly.
        /// https://reference.wolfram.com/language/ref/MonomialList.html
        ///</summary>
        public static Engine MonomialList(this Engine en, string? name = null)
        {
            return en.Execute("MonomialList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives moon phase fraction of illumination for the specified date.
        /// https://reference.wolfram.com/language/ref/MoonPhase.html
        ///</summary>
        public static Engine MoonPhase(this Engine en, string? name = null)
        {
            return en.Execute("MoonPhase[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the position of the Moon for the specified date.
        /// https://reference.wolfram.com/language/ref/MoonPosition.html
        ///</summary>
        public static Engine MoonPosition(this Engine en, string? name = null)
        {
            return en.Execute("MoonPosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// chooses the lower and the upper threshold automatically.
        /// https://reference.wolfram.com/language/ref/MorphologicalBinarize.html
        ///</summary>
        public static Engine MorphologicalBinarize(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalBinarize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a version of a binary image image in which white pixels represent the morphological branch points.
        /// https://reference.wolfram.com/language/ref/MorphologicalBranchPoints.html
        ///</summary>
        public static Engine MorphologicalBranchPoints(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalBranchPoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an array in which each pixel of image is replaced by an integer index representing the connected foreground image component in which the pixel lies.
        /// https://reference.wolfram.com/language/ref/MorphologicalComponents.html
        ///</summary>
        public static Engine MorphologicalComponents(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// computes the morphological Euler number of regions in a binary image.
        /// https://reference.wolfram.com/language/ref/MorphologicalEulerNumber.html
        ///</summary>
        public static Engine MorphologicalEulerNumber(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalEulerNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a graph object that represents the connectivity of the morphological branch points and endpoints of the objects in image after applying morphological thinning.
        /// https://reference.wolfram.com/language/ref/MorphologicalGraph.html
        ///</summary>
        public static Engine MorphologicalGraph(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// picks out the morphological perimeter of regions of foreground in image.
        /// https://reference.wolfram.com/language/ref/MorphologicalPerimeter.html
        ///</summary>
        public static Engine MorphologicalPerimeter(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalPerimeter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the values of all properties for the specified demographic.
        /// https://reference.wolfram.com/language/ref/MortalityData.html
        ///</summary>
        public static Engine MortalityData(this Engine en, string? name = null)
        {
            return en.Execute("MortalityData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives expr with the last element removed.
        /// https://reference.wolfram.com/language/ref/Most.html
        ///</summary>
        public static Engine Most(this Engine en, string? name = null)
        {
            return en.Execute("Most[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the mouse position with respect to the specified coordinate system.
        /// https://reference.wolfram.com/language/ref/MousePosition.html
        ///</summary>
        public static Engine MousePosition(this Engine en, string? name = null)
        {
            return en.Execute("MousePosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// formats with the elements of list in a roughly square arrangement.
        /// https://reference.wolfram.com/language/ref/Multicolumn.html
        ///</summary>
        public static Engine Multicolumn(this Engine en, string? name = null)
        {
            return en.Execute("Multicolumn[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is a multigraph and False otherwise.
        /// https://reference.wolfram.com/language/ref/MultigraphQ.html
        ///</summary>
        public static Engine MultigraphQ(this Engine en, string? name = null)
        {
            return en.Execute("MultigraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a multivariate normal distribution with zero mean and covariance matrix Σ.
        /// https://reference.wolfram.com/language/ref/MultinormalDistribution.html
        ///</summary>
        public static Engine MultinormalDistribution(this Engine en, string? name = null)
        {
            return en.Execute("MultinormalDistribution[" + en.ValidNames.Last() + "]", name);
        }


    }
}
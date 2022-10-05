namespace NetWolf
{
    public static class BuiltinSymbolS
    {
        ///<summary>
        ///represents a weakly stationary seasonal autoregressive moving-average process with ARMA coefficients ai and bj, seasonal order s, seasonal ARMA coefficients αi and βj, and normal white noise with variance v.
        ///https://reference.wolfram.com/language/ref/SARMAProcess.html
        ///</summary>
        public static Engine SARMAProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SARMAProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns an integer that specifies the position of the current point in an open stream. 
        ///https://reference.wolfram.com/language/ref/StreamPosition.html
        ///</summary>
        public static Engine StreamPosition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StreamPosition[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns an integer that specifies the position of the current point in an open stream. 
        ///https://reference.wolfram.com/language/ref/StreamPosition.html
        ///</summary>
        public static Engine StreamPosition(this Engine en, string? name = null)
        {
            return en.Execute("StreamPosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a filled triangle with sides of length a and b and angle γ between them. 
        ///https://reference.wolfram.com/language/ref/SASTriangle.html
        ///</summary>
        public static Engine SASTriangle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SASTriangle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a video iterating through all imagei.
        ///https://reference.wolfram.com/language/ref/SlideShowVideo.html
        ///</summary>
        public static Engine SlideShowVideo(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SlideShowVideo[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a video iterating through all imagei.
        ///https://reference.wolfram.com/language/ref/SlideShowVideo.html
        ///</summary>
        public static Engine SlideShowVideo(this Engine en, string? name = null)
        {
            return en.Execute("SlideShowVideo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of all streams that are currently open. 
        ///https://reference.wolfram.com/language/ref/Streams.html
        ///</summary>
        public static Engine Streams(this Engine en, string? name = null)
        {
            return en.Execute("Streams[]", name);
        }

        ///<summary>
        ///represents an object in which the expri are set up to be displayed on successive slides. 
        ///https://reference.wolfram.com/language/ref/SlideView.html
        ///</summary>
        public static Engine SlideView(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SlideView[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an object in which the expri are set up to be displayed on successive slides. 
        ///https://reference.wolfram.com/language/ref/SlideView.html
        ///</summary>
        public static Engine SlideView(this Engine en, string? name = null)
        {
            return en.Execute("SlideView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to find a choice of variables that makes the Boolean function bf yield True.
        ///https://reference.wolfram.com/language/ref/SatisfiabilityInstances.html
        ///</summary>
        public static Engine SatisfiabilityInstances(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SatisfiabilityInstances[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to find a choice of variables that makes the Boolean function bf yield True.
        ///https://reference.wolfram.com/language/ref/SatisfiabilityInstances.html
        ///</summary>
        public static Engine SatisfiabilityInstances(this Engine en, string? name = null)
        {
            return en.Execute("SatisfiabilityInstances[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if a combination of values of variables exists that makes the Boolean function bf yield True.
        ///https://reference.wolfram.com/language/ref/SatisfiableQ.html
        ///</summary>
        public static Engine SatisfiableQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SatisfiableQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if a combination of values of variables exists that makes the Boolean function bf yield True.
        ///https://reference.wolfram.com/language/ref/SatisfiableQ.html
        ///</summary>
        public static Engine SatisfiableQ(this Engine en, string? name = null)
        {
            return en.Execute("SatisfiableQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the satellite entity.
        ///https://reference.wolfram.com/language/ref/SatelliteData.html
        ///</summary>
        public static Engine SatelliteData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SatelliteData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///counts the number of possible combinations of variable values that yield True when supplied as arguments to the Boolean function bf.
        ///https://reference.wolfram.com/language/ref/SatisfiabilityCount.html
        ///</summary>
        public static Engine SatisfiabilityCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SatisfiabilityCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///counts the number of possible combinations of variable values that yield True when supplied as arguments to the Boolean function bf.
        ///https://reference.wolfram.com/language/ref/SatisfiabilityCount.html
        ///</summary>
        public static Engine SatisfiabilityCount(this Engine en, string? name = null)
        {
            return en.Execute("SatisfiabilityCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///appends definitions associated with the specified symbol to a file. 
        ///https://reference.wolfram.com/language/ref/Save.html
        ///</summary>
        public static Engine Save(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Save[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the substrings in "string" that match the string expression patt. 
        ///https://reference.wolfram.com/language/ref/StringCases.html
        ///</summary>
        public static Engine StringCases(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringCases[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a count of the number of times "sub" appears as a substring of "string". 
        ///https://reference.wolfram.com/language/ref/StringCount.html
        ///</summary>
        public static Engine StringCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SmallCircle.html
        ///</summary>
        public static Engine SmallCircle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SmallCircle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields True if any part of string matches the string pattern patt, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/StringContainsQ.html
        ///</summary>
        public static Engine StringContainsQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringContainsQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a matrix corresponding to a smoothing kernel of radius r for performing polynomial regression of degree k. 
        ///https://reference.wolfram.com/language/ref/SavitzkyGolayMatrix.html
        ///</summary>
        public static Engine SavitzkyGolayMatrix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SavitzkyGolayMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if the string "string" might be imported as format "fmt" and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/StringFormatQ.html
        ///</summary>
        public static Engine StringFormatQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringFormatQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Smith normal form decomposition of an integer matrix .
        ///https://reference.wolfram.com/language/ref/SmithDecomposition.html
        ///</summary>
        public static Engine SmithDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SmithDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Smith normal form decomposition of an integer matrix .
        ///https://reference.wolfram.com/language/ref/SmithDecomposition.html
        ///</summary>
        public static Engine SmithDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("SmithDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the end of string matches the string pattern patt, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/StringEndsQ.html
        ///</summary>
        public static Engine StringEndsQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringEndsQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the position of a graphical object in terms of coordinates scaled to run from 0 to 1 across the whole plot range in each direction. 
        ///https://reference.wolfram.com/language/ref/Scaled.html
        ///</summary>
        public static Engine Scaled(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Scaled[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the position of a graphical object in terms of coordinates scaled to run from 0 to 1 across the whole plot range in each direction. 
        ///https://reference.wolfram.com/language/ref/Scaled.html
        ///</summary>
        public static Engine Scaled(this Engine en, string? name = null)
        {
            return en.Execute("Scaled[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the  statistic of the elements in list.
        ///https://reference.wolfram.com/language/ref/SnDispersion.html
        ///</summary>
        public static Engine SnDispersion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SnDispersion[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the  statistic of the elements in list.
        ///https://reference.wolfram.com/language/ref/SnDispersion.html
        ///</summary>
        public static Engine SnDispersion(this Engine en, string? name = null)
        {
            return en.Execute("SnDispersion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///extracts the n block of characters in string, where blocks of characters are defined as delimited by whitespace.
        ///https://reference.wolfram.com/language/ref/StringExtract.html
        ///</summary>
        public static Engine StringExtract(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringExtract[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a string with "snew" inserted starting at position  in "string". 
        ///https://reference.wolfram.com/language/ref/StringInsert.html
        ///</summary>
        public static Engine StringInsert(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StringInsert[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///estimates the point density function  for point data pdata.
        ///https://reference.wolfram.com/language/ref/SmoothPointDensity.html
        ///</summary>
        public static Engine SmoothPointDensity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SmoothPointDensity[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the point density function  for point data pdata.
        ///https://reference.wolfram.com/language/ref/SmoothPointDensity.html
        ///</summary>
        public static Engine SmoothPointDensity(this Engine en, string? name = null)
        {
            return en.Execute("SmoothPointDensity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots a smooth kernel histogram of the values {xi,yi}.
        ///https://reference.wolfram.com/language/ref/SmoothDensityHistogram.html
        ///</summary>
        public static Engine SmoothDensityHistogram(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SmoothDensityHistogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a number representing the Smith–Waterman similarity between strings, vectors or bio sequences u and v.
        ///https://reference.wolfram.com/language/ref/SmithWatermanSimilarity.html
        ///</summary>
        public static Engine SmithWatermanSimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SmithWatermanSimilarity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the matrix corresponding to scaling by a factor si along each coordinate axis.
        ///https://reference.wolfram.com/language/ref/ScalingMatrix.html
        ///</summary>
        public static Engine ScalingMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ScalingMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the matrix corresponding to scaling by a factor si along each coordinate axis.
        ///https://reference.wolfram.com/language/ref/ScalingMatrix.html
        ///</summary>
        public static Engine ScalingMatrix(this Engine en, string? name = null)
        {
            return en.Execute("ScalingMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Smith compensator for the time-delay system sys and the delay-free controller con.
        ///https://reference.wolfram.com/language/ref/SmithDelayCompensator.html
        ///</summary>
        public static Engine SmithDelayCompensator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SmithDelayCompensator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a summary video based on n snippets from video.
        ///https://reference.wolfram.com/language/ref/SnippetsVideo.html
        ///</summary>
        public static Engine SnippetsVideo(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SnippetsVideo[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a snippet of text from a document or other content object.
        ///https://reference.wolfram.com/language/ref/Snippet.html
        ///</summary>
        public static Engine Snippet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Snippet[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a snippet of text from a document or other content object.
        ///https://reference.wolfram.com/language/ref/Snippet.html
        ///</summary>
        public static Engine Snippet(this Engine en, string? name = null)
        {
            return en.Execute("Snippet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to determine what ImportString format could be used to import the string "string".
        ///https://reference.wolfram.com/language/ref/StringFormat.html
        ///</summary>
        public static Engine StringFormat(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringFormat[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to determine what ImportString format could be used to import the string "string".
        ///https://reference.wolfram.com/language/ref/StringFormat.html
        ///</summary>
        public static Engine StringFormat(this Engine en, string? name = null)
        {
            return en.Execute("StringFormat[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes string be of length n, padding it on the left with spaces or truncating it if necessary. 
        ///https://reference.wolfram.com/language/ref/StringPadLeft.html
        ///</summary>
        public static Engine StringPadLeft(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringPadLeft[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a network socket connection.
        ///https://reference.wolfram.com/language/ref/SocketObject.html
        ///</summary>
        public static Engine SocketObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SocketObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a network socket connection.
        ///https://reference.wolfram.com/language/ref/SocketObject.html
        ///</summary>
        public static Engine SocketObject(this Engine en, string? name = null)
        {
            return en.Execute("SocketObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a socket connection to the TCP host at the specified address and returns a SocketObject representing the connection.
        ///https://reference.wolfram.com/language/ref/SocketConnect.html
        ///</summary>
        public static Engine SocketConnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SocketConnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a socket connection to the TCP host at the specified address and returns a SocketObject representing the connection.
        ///https://reference.wolfram.com/language/ref/SocketConnect.html
        ///</summary>
        public static Engine SocketConnect(this Engine en, string? name = null)
        {
            return en.Execute("SocketConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots a 3D smooth kernel histogram of the values {xi,yi}.
        ///https://reference.wolfram.com/language/ref/SmoothHistogram3D.html
        ///</summary>
        public static Engine SmoothHistogram3D(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SmoothHistogram3D[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents graphics primitives g scaled by a factor s. 
        ///https://reference.wolfram.com/language/ref/Scale.html
        ///</summary>
        public static Engine Scale(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Scale[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates f applied to each element of expr in turn. 
        ///https://reference.wolfram.com/language/ref/Scan.html
        ///</summary>
        public static Engine Scan(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Scan[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether "string" matches the string pattern patt. 
        ///https://reference.wolfram.com/language/ref/StringMatchQ.html
        ///</summary>
        public static Engine StringMatchQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringMatchQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives "string" with its first n characters dropped. 
        ///https://reference.wolfram.com/language/ref/StringDrop.html
        ///</summary>
        public static Engine StringDrop(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringDrop[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields the string obtained by deleting from string all occurrences of anything matching the string pattern patt.
        ///https://reference.wolfram.com/language/ref/StringDelete.html
        ///</summary>
        public static Engine StringDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes string be of length n, padding it on the right with spaces or truncating it if necessary. 
        ///https://reference.wolfram.com/language/ref/StringPadRight.html
        ///</summary>
        public static Engine StringPadRight(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringPadRight[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a scheduled task to be evaluated on the schedule defined by timespec.
        ///https://reference.wolfram.com/language/ref/ScheduledTask.html
        ///</summary>
        public static Engine ScheduledTask(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ScheduledTask[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///partitions string into nonoverlapping substrings of length n.
        ///https://reference.wolfram.com/language/ref/StringPartition.html
        ///</summary>
        public static Engine StringPartition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringPartition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if no substring in "string" matches the string expression patt, and yields False otherwise. 
        ///https://reference.wolfram.com/language/ref/StringFreeQ.html
        ///</summary>
        public static Engine StringFreeQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringFreeQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///opens a socket that accepts TCP connections to localhost:port and returns a SocketObject representing the socket.
        ///https://reference.wolfram.com/language/ref/SocketOpen.html
        ///</summary>
        public static Engine SocketOpen(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SocketOpen[" + arg0 + "]", name);
        }

        ///<summary>
        ///opens a socket that accepts TCP connections to localhost:port and returns a SocketObject representing the socket.
        ///https://reference.wolfram.com/language/ref/SocketOpen.html
        ///</summary>
        public static Engine SocketOpen(this Engine en, string? name = null)
        {
            return en.Execute("SocketOpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of characters in a string. 
        ///https://reference.wolfram.com/language/ref/StringLength.html
        ///</summary>
        public static Engine StringLength(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringLength[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of characters in a string. 
        ///https://reference.wolfram.com/language/ref/StringLength.html
        ///</summary>
        public static Engine StringLength(this Engine en, string? name = null)
        {
            return en.Execute("StringLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the snub polyhedron of poly by truncating some corners.
        ///https://reference.wolfram.com/language/ref/SnubPolyhedron.html
        ///</summary>
        public static Engine SnubPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SnubPolyhedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the snub polyhedron of poly by truncating some corners.
        ///https://reference.wolfram.com/language/ref/SnubPolyhedron.html
        ///</summary>
        public static Engine SnubPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("SnubPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///waits until there is data ready to read on all of the socketi.
        ///https://reference.wolfram.com/language/ref/SocketWaitAll.html
        ///</summary>
        public static Engine SocketWaitAll(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SocketWaitAll[" + arg0 + "]", name);
        }

        ///<summary>
        ///waits until there is data ready to read on all of the socketi.
        ///https://reference.wolfram.com/language/ref/SocketWaitAll.html
        ///</summary>
        public static Engine SocketWaitAll(this Engine en, string? name = null)
        {
            return en.Execute("SocketWaitAll[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the starting and ending character positions at which "sub" appears as a substring of "string". 
        ///https://reference.wolfram.com/language/ref/StringPosition.html
        ///</summary>
        public static Engine StringPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///cycles the characters in string n positions to the right.
        ///https://reference.wolfram.com/language/ref/StringRotateRight.html
        ///</summary>
        public static Engine StringRotateRight(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringRotateRight[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a smooth kernel distribution based on the data values xi.
        ///https://reference.wolfram.com/language/ref/SmoothKernelDistribution.html
        ///</summary>
        public static Engine SmoothKernelDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SmoothKernelDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a smooth kernel distribution based on the data values xi.
        ///https://reference.wolfram.com/language/ref/SmoothKernelDistribution.html
        ///</summary>
        public static Engine SmoothKernelDistribution(this Engine en, string? name = null)
        {
            return en.Execute("SmoothKernelDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerGiPrime.html
        ///</summary>
        public static Engine ScorerGiPrime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ScorerGiPrime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerGiPrime.html
        ///</summary>
        public static Engine ScorerGiPrime(this Engine en, string? name = null)
        {
            return en.Execute("ScorerGiPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields the Schur decomposition for a numerical matrix m, given as a list {q,t} where q is an orthonormal matrix and t is a block upper‐triangular matrix. 
        ///https://reference.wolfram.com/language/ref/SchurDecomposition.html
        ///</summary>
        public static Engine SchurDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SchurDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields the Schur decomposition for a numerical matrix m, given as a list {q,t} where q is an orthonormal matrix and t is a block upper‐triangular matrix. 
        ///https://reference.wolfram.com/language/ref/SchurDecomposition.html
        ///</summary>
        public static Engine SchurDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("SchurDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots a smooth kernel histogram for the PDF of the values xi.
        ///https://reference.wolfram.com/language/ref/SmoothHistogram.html
        ///</summary>
        public static Engine SmoothHistogram(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SmoothHistogram[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots a smooth kernel histogram for the PDF of the values xi.
        ///https://reference.wolfram.com/language/ref/SmoothHistogram.html
        ///</summary>
        public static Engine SmoothHistogram(this Engine en, string? name = null)
        {
            return en.Execute("SmoothHistogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a socket listener created by SocketListen.
        ///https://reference.wolfram.com/language/ref/SocketListener.html
        ///</summary>
        public static Engine SocketListener(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SocketListener[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a socket listener created by SocketListen.
        ///https://reference.wolfram.com/language/ref/SocketListener.html
        ///</summary>
        public static Engine SocketListener(this Engine en, string? name = null)
        {
            return en.Execute("SocketListener[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces the characters at positions m through n in "string" by "snew". 
        ///https://reference.wolfram.com/language/ref/StringReplacePart.html
        ///</summary>
        public static Engine StringReplacePart(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StringReplacePart[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerHi.html
        ///</summary>
        public static Engine ScorerHi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ScorerHi[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerHi.html
        ///</summary>
        public static Engine ScorerHi(this Engine en, string? name = null)
        {
            return en.Execute("ScorerHi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests if there is any data immediately available to read from the specified socket. 
        ///https://reference.wolfram.com/language/ref/SocketReadyQ.html
        ///</summary>
        public static Engine SocketReadyQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SocketReadyQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests if there is any data immediately available to read from the specified socket. 
        ///https://reference.wolfram.com/language/ref/SocketReadyQ.html
        ///</summary>
        public static Engine SocketReadyQ(this Engine en, string? name = null)
        {
            return en.Execute("SocketReadyQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a string consisting of "str" repeated n times.
        ///https://reference.wolfram.com/language/ref/StringRepeat.html
        ///</summary>
        public static Engine StringRepeat(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringRepeat[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents scaling by a factor si along each coordinate axis from the origin.
        ///https://reference.wolfram.com/language/ref/ScalingTransform.html
        ///</summary>
        public static Engine ScalingTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ScalingTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents scaling by a factor si along each coordinate axis from the origin.
        ///https://reference.wolfram.com/language/ref/ScalingTransform.html
        ///</summary>
        public static Engine ScalingTransform(this Engine en, string? name = null)
        {
            return en.Execute("ScalingTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the n character in "string".
        ///https://reference.wolfram.com/language/ref/StringPart.html
        ///</summary>
        public static Engine StringPart(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringPart[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerGi.html
        ///</summary>
        public static Engine ScorerGi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ScorerGi[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerGi.html
        ///</summary>
        public static Engine ScorerGi(this Engine en, string? name = null)
        {
            return en.Execute("ScorerGi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a search index object, as created by CreateSearchIndex.
        ///https://reference.wolfram.com/language/ref/SearchIndexObject.html
        ///</summary>
        public static Engine SearchIndexObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SearchIndexObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a search index object, as created by CreateSearchIndex.
        ///https://reference.wolfram.com/language/ref/SearchIndexObject.html
        ///</summary>
        public static Engine SearchIndexObject(this Engine en, string? name = null)
        {
            return en.Execute("SearchIndexObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as the text of the controlstring, with the printed forms of the expri embedded. 
        ///https://reference.wolfram.com/language/ref/StringForm.html
        ///</summary>
        public static Engine StringForm(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StringForm[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a fully constrained solid boundary for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars. 
        ///https://reference.wolfram.com/language/ref/SolidFixedCondition.html
        ///</summary>
        public static Engine SolidFixedCondition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SolidFixedCondition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a list with all the locally stored instances of SearchIndexObject.
        ///https://reference.wolfram.com/language/ref/SearchIndices.html
        ///</summary>
        public static Engine SearchIndices(this Engine en, string? name = null)
        {
            return en.Execute("SearchIndices[]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the solar system feature entity.
        ///https://reference.wolfram.com/language/ref/SolarSystemFeatureData.html
        ///</summary>
        public static Engine SolarSystemFeatureData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SolarSystemFeatureData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a boundary load condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/SolidBoundaryLoadValue.html
        ///</summary>
        public static Engine SolidBoundaryLoadValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SolidBoundaryLoadValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///waits until there is data ready to read on any of the socketi, then returns that socket.
        ///https://reference.wolfram.com/language/ref/SocketWaitNext.html
        ///</summary>
        public static Engine SocketWaitNext(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SocketWaitNext[" + arg0 + "]", name);
        }

        ///<summary>
        ///waits until there is data ready to read on any of the socketi, then returns that socket.
        ///https://reference.wolfram.com/language/ref/SocketWaitNext.html
        ///</summary>
        public static Engine SocketWaitNext(this Engine en, string? name = null)
        {
            return en.Execute("SocketWaitNext[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields solid mechanics strain with variables vars, parameters pars and displacements displ.
        ///https://reference.wolfram.com/language/ref/SolidMechanicsStrain.html
        ///</summary>
        public static Engine SolidMechanicsStrain(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SolidMechanicsStrain[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a byte array corresponding to the UTF-8 encoding of the specified string.
        ///https://reference.wolfram.com/language/ref/StringToByteArray.html
        ///</summary>
        public static Engine StringToByteArray(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringToByteArray[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a byte array corresponding to the UTF-8 encoding of the specified string.
        ///https://reference.wolfram.com/language/ref/StringToByteArray.html
        ///</summary>
        public static Engine StringToByteArray(this Engine en, string? name = null)
        {
            return en.Execute("StringToByteArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///will strip out unnecessary boxes, spaces, and styles from a format expression.
        ///https://reference.wolfram.com/language/ref/StripBoxes.html
        ///</summary>
        public static Engine StripBoxes(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StripBoxes[" + arg0 + "]", name);
        }

        ///<summary>
        ///will strip out unnecessary boxes, spaces, and styles from a format expression.
        ///https://reference.wolfram.com/language/ref/StripBoxes.html
        ///</summary>
        public static Engine StripBoxes(this Engine en, string? name = null)
        {
            return en.Execute("StripBoxes[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to solve the system expr of equations or inequalities for the variables vars. 
        ///https://reference.wolfram.com/language/ref/Solve.html
        ///</summary>
        public static Engine Solve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Solve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns all active socket connections initiated by your current Wolfram Language session.
        ///https://reference.wolfram.com/language/ref/Sockets.html
        ///</summary>
        public static Engine Sockets(this Engine en, string? name = null)
        {
            return en.Execute("Sockets[]", name);
        }

        ///<summary>
        ///gives a sawtooth wave that varies from 0 to 1 with unit period.
        ///https://reference.wolfram.com/language/ref/SawtoothWave.html
        ///</summary>
        public static Engine SawtoothWave(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SawtoothWave[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a sawtooth wave that varies from 0 to 1 with unit period.
        ///https://reference.wolfram.com/language/ref/SawtoothWave.html
        ///</summary>
        public static Engine SawtoothWave(this Engine en, string? name = null)
        {
            return en.Execute("SawtoothWave[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///starts listening on the specified socket, asynchronously applying fun whenever data is received on the socket.
        ///https://reference.wolfram.com/language/ref/SocketListen.html
        ///</summary>
        public static Engine SocketListen(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SocketListen[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints with all real numbers in expr given in scientific notation. 
        ///https://reference.wolfram.com/language/ref/ScientificForm.html
        ///</summary>
        public static Engine ScientificForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ScientificForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with all real numbers in expr given in scientific notation. 
        ///https://reference.wolfram.com/language/ref/ScientificForm.html
        ///</summary>
        public static Engine ScientificForm(this Engine en, string? name = null)
        {
            return en.Execute("ScientificForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sorts the elements of list in the order defined by applying f to each of them. 
        ///https://reference.wolfram.com/language/ref/SortBy.html
        ///</summary>
        public static Engine SortBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SortBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a string containing the first n characters in "string". 
        ///https://reference.wolfram.com/language/ref/StringTake.html
        ///</summary>
        public static Engine StringTake(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringTake[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a sequence of n omitted characters in a string printed with Short. The standard print form for StringSkeleton is an ellipsis. 
        ///https://reference.wolfram.com/language/ref/StringSkeleton.html
        ///</summary>
        public static Engine StringSkeleton(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringSkeleton[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a sequence of n omitted characters in a string printed with Short. The standard print form for StringSkeleton is an ellipsis. 
        ///https://reference.wolfram.com/language/ref/StringSkeleton.html
        ///</summary>
        public static Engine StringSkeleton(this Engine en, string? name = null)
        {
            return en.Execute("StringSkeleton[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///retrieves a list of all instances of SecuredAuthenticationKey owned by the currently connected user. 
        ///https://reference.wolfram.com/language/ref/SecuredAuthenticationKeys.html
        ///</summary>
        public static Engine SecuredAuthenticationKeys(this Engine en, string? name = null)
        {
            return en.Execute("SecuredAuthenticationKeys[]", name);
        }

        ///<summary>
        ///creates a string by concatenating all the si, with spaces inserted between them.
        ///https://reference.wolfram.com/language/ref/StringRiffle.html
        ///</summary>
        public static Engine StringRiffle(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringRiffle[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a string by concatenating all the si, with spaces inserted between them.
        ///https://reference.wolfram.com/language/ref/StringRiffle.html
        ///</summary>
        public static Engine StringRiffle(this Engine en, string? name = null)
        {
            return en.Execute("StringRiffle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the time of the next solar eclipse.
        ///https://reference.wolfram.com/language/ref/SolarEclipse.html
        ///</summary>
        public static Engine SolarEclipse(this Engine en, string? name = null)
        {
            return en.Execute("SolarEclipse[]", name);
        }

        ///<summary>
        ///gives the Struve function . 
        ///https://reference.wolfram.com/language/ref/StruveH.html
        ///</summary>
        public static Engine StruveH(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StruveH[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the secant of z. 
        ///https://reference.wolfram.com/language/ref/Sec.html
        ///</summary>
        public static Engine Sec(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sec[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the secant of z. 
        ///https://reference.wolfram.com/language/ref/Sec.html
        ///</summary>
        public static Engine Sec(this Engine en, string? name = null)
        {
            return en.Execute("Sec[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields solid mechanics PDE terms with variables vars and parameters pars.
        ///https://reference.wolfram.com/language/ref/SolidMechanicsPDEComponent.html
        ///</summary>
        public static Engine SolidMechanicsPDEComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SolidMechanicsPDEComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject expression that represents a string template to be applied to arguments. 
        ///https://reference.wolfram.com/language/ref/StringTemplate.html
        ///</summary>
        public static Engine StringTemplate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringTemplate[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject expression that represents a string template to be applied to arguments. 
        ///https://reference.wolfram.com/language/ref/StringTemplate.html
        ///</summary>
        public static Engine StringTemplate(this Engine en, string? name = null)
        {
            return en.Execute("StringTemplate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level representation of boxes to be shown with the specified option settings. 
        ///https://reference.wolfram.com/language/ref/StyleBox.html
        ///</summary>
        public static Engine StyleBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StyleBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///trims whitespace from the beginning and end of "string".
        ///https://reference.wolfram.com/language/ref/StringTrim.html
        ///</summary>
        public static Engine StringTrim(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringTrim[" + arg0 + "]", name);
        }

        ///<summary>
        ///trims whitespace from the beginning and end of "string".
        ///https://reference.wolfram.com/language/ref/StringTrim.html
        ///</summary>
        public static Engine StringTrim(this Engine en, string? name = null)
        {
            return en.Execute("StringTrim[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is a string, and False otherwise.
        ///https://reference.wolfram.com/language/ref/StringQ.html
        ///</summary>
        public static Engine StringQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a string, and False otherwise.
        ///https://reference.wolfram.com/language/ref/StringQ.html
        ///</summary>
        public static Engine StringQ(this Engine en, string? name = null)
        {
            return en.Execute("StringQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reverses the order of the characters in "string".
        ///https://reference.wolfram.com/language/ref/StringReverse.html
        ///</summary>
        public static Engine StringReverse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringReverse[" + arg0 + "]", name);
        }

        ///<summary>
        ///reverses the order of the characters in "string".
        ///https://reference.wolfram.com/language/ref/StringReverse.html
        ///</summary>
        public static Engine StringReverse(this Engine en, string? name = null)
        {
            return en.Execute("StringReverse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///specifies that e should be collected by the nearest enclosing Reap. 
        ///https://reference.wolfram.com/language/ref/Sow.html
        ///</summary>
        public static Engine Sow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sow[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies that e should be collected by the nearest enclosing Reap. 
        ///https://reference.wolfram.com/language/ref/Sow.html
        ///</summary>
        public static Engine Sow(this Engine en, string? name = null)
        {
            return en.Execute("Sow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads the next available message on the specified socket, returning it as a byte array.
        ///https://reference.wolfram.com/language/ref/SocketReadMessage.html
        ///</summary>
        public static Engine SocketReadMessage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SocketReadMessage[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads the next available message on the specified socket, returning it as a byte array.
        ///https://reference.wolfram.com/language/ref/SocketReadMessage.html
        ///</summary>
        public static Engine SocketReadMessage(this Engine en, string? name = null)
        {
            return en.Execute("SocketReadMessage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pair of strings containing the first n characters in "string" and the remaining characters.
        ///https://reference.wolfram.com/language/ref/StringTakeDrop.html
        ///</summary>
        public static Engine StringTakeDrop(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringTakeDrop[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if the 3D region reg is a solid region and False otherwise.
        ///https://reference.wolfram.com/language/ref/SolidRegionQ.html
        ///</summary>
        public static Engine SolidRegionQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SolidRegionQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if the 3D region reg is a solid region and False otherwise.
        ///https://reference.wolfram.com/language/ref/SolidRegionQ.html
        ///</summary>
        public static Engine SolidRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("SolidRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr+.
        ///https://reference.wolfram.com/language/ref/SubPlus.html
        ///</summary>
        public static Engine SubPlus(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SubPlus[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as expr+.
        ///https://reference.wolfram.com/language/ref/SubPlus.html
        ///</summary>
        public static Engine SubPlus(this Engine en, string? name = null)
        {
            return en.Execute("SubPlus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a result from TextSearch[…] and related functions.
        ///https://reference.wolfram.com/language/ref/SearchResultObject.html
        ///</summary>
        public static Engine SearchResultObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SearchResultObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a result from TextSearch[…] and related functions.
        ///https://reference.wolfram.com/language/ref/SearchResultObject.html
        ///</summary>
        public static Engine SearchResultObject(this Engine en, string? name = null)
        {
            return en.Execute("SearchResultObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr-.
        ///https://reference.wolfram.com/language/ref/SubMinus.html
        ///</summary>
        public static Engine SubMinus(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SubMinus[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as expr-.
        ///https://reference.wolfram.com/language/ref/SubMinus.html
        ///</summary>
        public static Engine SubMinus(this Engine en, string? name = null)
        {
            return en.Execute("SubMinus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///selects components of image indicated by the label matrix lmat that satisfy crit, replacing other parts with black.
        ///https://reference.wolfram.com/language/ref/SelectComponents.html
        ///</summary>
        public static Engine SelectComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SelectComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if s is a valid SparseArray object and False otherwise.
        ///https://reference.wolfram.com/language/ref/SparseArrayQ.html
        ///</summary>
        public static Engine SparseArrayQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SparseArrayQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if s is a valid SparseArray object and False otherwise.
        ///https://reference.wolfram.com/language/ref/SparseArrayQ.html
        ///</summary>
        public static Engine SparseArrayQ(this Engine en, string? name = null)
        {
            return en.Execute("SparseArrayQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces the string expression s by sp wherever it appears in "string". 
        ///https://reference.wolfram.com/language/ref/StringReplace.html
        ///</summary>
        public static Engine StringReplace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringReplace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the angle on the celestial equator between the Sun and the local antimeridian for the current location and date.
        ///https://reference.wolfram.com/language/ref/SolarTime.html
        ///</summary>
        public static Engine SolarTime(this Engine en, string? name = null)
        {
            return en.Execute("SolarTime[]", name);
        }

        ///<summary>
        ///gives the structural importances for all components in the ReliabilityDistribution rdist.
        ///https://reference.wolfram.com/language/ref/StructuralImportance.html
        ///</summary>
        public static Engine StructuralImportance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StructuralImportance[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the structural importances for all components in the ReliabilityDistribution rdist.
        ///https://reference.wolfram.com/language/ref/StructuralImportance.html
        ///</summary>
        public static Engine StructuralImportance(this Engine en, string? name = null)
        {
            return en.Execute("StructuralImportance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a music-like sound note with the specified pitch.
        ///https://reference.wolfram.com/language/ref/SoundNote.html
        ///</summary>
        public static Engine SoundNote(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SoundNote[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a music-like sound note with the specified pitch.
        ///https://reference.wolfram.com/language/ref/SoundNote.html
        ///</summary>
        public static Engine SoundNote(this Engine en, string? name = null)
        {
            return en.Execute("SoundNote[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the hyperbolic secant distribution with location parameter μ and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/SechDistribution.html
        ///</summary>
        public static Engine SechDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SechDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the first ei for which crit[ei] is True, or Missing["NotFound"] if none is found.
        ///https://reference.wolfram.com/language/ref/SelectFirst.html
        ///</summary>
        public static Engine SelectFirst(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SelectFirst[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a sparse array with all elements zero except for values vi at positions posi.
        ///https://reference.wolfram.com/language/ref/SparseArray.html
        ///</summary>
        public static Engine SparseArray(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SparseArray[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a sparse array with all elements zero except for values vi at positions posi.
        ///https://reference.wolfram.com/language/ref/SparseArray.html
        ///</summary>
        public static Engine SparseArray(this Engine en, string? name = null)
        {
            return en.Execute("SparseArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds values of variables vars that minimize the linear objective f subject to second-order cone and/or linear constraints cons.
        ///https://reference.wolfram.com/language/ref/SecondOrderConeOptimization.html
        ///</summary>
        public static Engine SecondOrderConeOptimization(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SecondOrderConeOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the subgraph of the graph g generated by the vertices vi.
        ///https://reference.wolfram.com/language/ref/Subgraph.html
        ///</summary>
        public static Engine Subgraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Subgraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds an optimal alignment of sequences of elements in the strings, lists or biomolecular sequences s1 and s2, and yields a list of successive matching and differing sequences.
        ///https://reference.wolfram.com/language/ref/SequenceAlignment.html
        ///</summary>
        public static Engine SequenceAlignment(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SequenceAlignment[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///attempts to import a string semantically to give a Dataset object.
        ///https://reference.wolfram.com/language/ref/SemanticImportString.html
        ///</summary>
        public static Engine SemanticImportString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SemanticImportString[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to import a string semantically to give a Dataset object.
        ///https://reference.wolfram.com/language/ref/SemanticImportString.html
        ///</summary>
        public static Engine SemanticImportString(this Engine en, string? name = null)
        {
            return en.Execute("SemanticImportString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields solid mechanics stress with variables vars, parameters pars and strain strain.
        ///https://reference.wolfram.com/language/ref/SolidMechanicsStress.html
        ///</summary>
        public static Engine SolidMechanicsStress(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SolidMechanicsStress[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the space curve entity.
        ///https://reference.wolfram.com/language/ref/SpaceCurveData.html
        ///</summary>
        public static Engine SpaceCurveData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpaceCurveData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the low‐level box representation for xy in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/SubscriptBox.html
        ///</summary>
        public static Engine SubscriptBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SubscriptBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the subresultant polynomial remainder sequence of the polynomials poly1 and poly2 with respect to the variable var.
        ///https://reference.wolfram.com/language/ref/SubresultantPolynomialRemainders.html
        ///</summary>
        public static Engine SubresultantPolynomialRemainders(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SubresultantPolynomialRemainders[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of positions at which sublist appears in list in any order.
        ///https://reference.wolfram.com/language/ref/SubsetPosition.html
        ///</summary>
        public static Engine SubsetPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SubsetPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a search engine-style query in TextSearch and related functions.
        ///https://reference.wolfram.com/language/ref/SearchQueryString.html
        ///</summary>
        public static Engine SearchQueryString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SearchQueryString[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a search engine-style query in TextSearch and related functions.
        ///https://reference.wolfram.com/language/ref/SearchQueryString.html
        ///</summary>
        public static Engine SearchQueryString(this Engine en, string? name = null)
        {
            return en.Execute("SearchQueryString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///moves the current selection in an open notebook in the front end in the direction dir by the specified unit. 
        ///https://reference.wolfram.com/language/ref/SelectionMove.html
        ///</summary>
        public static Engine SelectionMove(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SelectionMove[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields an expression in which the elements ei, ej, … in the list {e1,e2,…} are replaced with the corresponding elements of the list obtained by evaluating f[{ei,ej,…}].
        ///https://reference.wolfram.com/language/ref/SubsetMap.html
        ///</summary>
        public static Engine SubsetMap(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SubsetMap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the modified Struve function . 
        ///https://reference.wolfram.com/language/ref/StruveL.html
        ///</summary>
        public static Engine StruveL(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StruveL[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerHiPrime.html
        ///</summary>
        public static Engine ScorerHiPrime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ScorerHiPrime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerHiPrime.html
        ///</summary>
        public static Engine ScorerHiPrime(this Engine en, string? name = null)
        {
            return en.Execute("ScorerHiPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if list2 is a subset of list1, and False otherwise.
        ///https://reference.wolfram.com/language/ref/SubsetQ.html
        ///</summary>
        public static Engine SubsetQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SubsetQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds values of variables vars that minimize the linear objective f subject to semidefinite constraints cons.
        ///https://reference.wolfram.com/language/ref/SemidefiniteOptimization.html
        ///</summary>
        public static Engine SemidefiniteOptimization(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SemidefiniteOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///opens an input stream for reading from a string. 
        ///https://reference.wolfram.com/language/ref/StringToStream.html
        ///</summary>
        public static Engine StringToStream(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringToStream[" + arg0 + "]", name);
        }

        ///<summary>
        ///opens an input stream for reading from a string. 
        ///https://reference.wolfram.com/language/ref/StringToStream.html
        ///</summary>
        public static Engine StringToStream(this Engine en, string? name = null)
        {
            return en.Execute("StringToStream[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the values of parameters that make the equations eqns valid for all values of the variables vars. 
        ///https://reference.wolfram.com/language/ref/SolveAlways.html
        ///</summary>
        public static Engine SolveAlways(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SolveAlways[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes the current selection in a notebook and creates a new cell containing the result obtained by evaluating the contents of the selection using the kernel. 
        ///https://reference.wolfram.com/language/ref/SelectionEvaluateCreateCell.html
        ///</summary>
        public static Engine SelectionEvaluateCreateCell(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SelectionEvaluateCreateCell[" + arg0 + "]", name);
        }

        ///<summary>
        ///takes the current selection in a notebook and creates a new cell containing the result obtained by evaluating the contents of the selection using the kernel. 
        ///https://reference.wolfram.com/language/ref/SelectionEvaluateCreateCell.html
        ///</summary>
        public static Engine SelectionEvaluateCreateCell(this Engine en, string? name = null)
        {
            return en.Execute("SelectionEvaluateCreateCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives {x1,…,xn,f[x1,…,xn,a1],f[x2,…,xn,f[x1,…,xn,a1],a2],…}.
        ///https://reference.wolfram.com/language/ref/SequenceFoldList.html
        ///</summary>
        public static Engine SequenceFoldList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SequenceFoldList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an entity class derived from class by sorting according to the values of the property prop. 
        ///https://reference.wolfram.com/language/ref/SortedEntityClass.html
        ///</summary>
        public static Engine SortedEntityClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SortedEntityClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an object that formats as . 
        ///https://reference.wolfram.com/language/ref/Subsuperscript.html
        ///</summary>
        public static Engine Subsuperscript(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Subsuperscript[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Subset.html
        ///</summary>
        public static Engine Subset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Subset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the solid entity.
        ///https://reference.wolfram.com/language/ref/SolidData.html
        ///</summary>
        public static Engine SolidData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SolidData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///cycles the characters in string n positions to the left.
        ///https://reference.wolfram.com/language/ref/StringRotateLeft.html
        ///</summary>
        public static Engine StringRotateLeft(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringRotateLeft[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a low-level representation of the contents of a style definition cell.
        ///https://reference.wolfram.com/language/ref/StyleData.html
        ///</summary>
        public static Engine StyleData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StyleData[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level representation of the contents of a style definition cell.
        ///https://reference.wolfram.com/language/ref/StyleData.html
        ///</summary>
        public static Engine StyleData(this Engine en, string? name = null)
        {
            return en.Execute("StyleData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///resets the pseudorandom generator, using s as a seed. 
        ///https://reference.wolfram.com/language/ref/SeedRandom.html
        ///</summary>
        public static Engine SeedRandom(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SeedRandom[" + arg0 + "]", name);
        }

        ///<summary>
        ///resets the pseudorandom generator, using s as a seed. 
        ///https://reference.wolfram.com/language/ref/SeedRandom.html
        ///</summary>
        public static Engine SeedRandom(this Engine en, string? name = null)
        {
            return en.Execute("SeedRandom[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a softmax net layer.
        ///https://reference.wolfram.com/language/ref/SoftmaxLayer.html
        ///</summary>
        public static Engine SoftmaxLayer(this Engine en, string? name = null)
        {
            return en.Execute("SoftmaxLayer[]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that surfaces of 3D graphics objects which follow are to be taken to have specularity s. 
        ///https://reference.wolfram.com/language/ref/Specularity.html
        ///</summary>
        public static Engine Specularity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Specularity[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that surfaces of 3D graphics objects which follow are to be taken to have specularity s. 
        ///https://reference.wolfram.com/language/ref/Specularity.html
        ///</summary>
        public static Engine Specularity(this Engine en, string? name = null)
        {
            return en.Execute("Specularity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the starting and ending positions at which sublist appears in list.
        ///https://reference.wolfram.com/language/ref/SequencePosition.html
        ///</summary>
        public static Engine SequencePosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SequencePosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the low‐level box representation for  in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/SubsuperscriptBox.html
        ///</summary>
        public static Engine SubsuperscriptBox(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SubsuperscriptBox[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots the spectrogram of list.
        ///https://reference.wolfram.com/language/ref/Spectrogram.html
        ///</summary>
        public static Engine Spectrogram(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Spectrogram[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the spectrogram of list.
        ///https://reference.wolfram.com/language/ref/Spectrogram.html
        ///</summary>
        public static Engine Spectrogram(this Engine en, string? name = null)
        {
            return en.Execute("Spectrogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a spatial distribution for graphs with n vertices uniformly distributed over the unit square and edges between vertices that are at distance at most r.
        ///https://reference.wolfram.com/language/ref/SpatialGraphDistribution.html
        ///</summary>
        public static Engine SpatialGraphDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpatialGraphDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///speaks a spoken representation of the expression expr.
        ///https://reference.wolfram.com/language/ref/Speak.html
        ///</summary>
        public static Engine Speak(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Speak[" + arg0 + "]", name);
        }

        ///<summary>
        ///speaks a spoken representation of the expression expr.
        ///https://reference.wolfram.com/language/ref/Speak.html
        ///</summary>
        public static Engine Speak(this Engine en, string? name = null)
        {
            return en.Execute("Speak[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the geometric or geographic region reg can be an observation in spatial statistics. 
        ///https://reference.wolfram.com/language/ref/SpatialObservationRegionQ.html
        ///</summary>
        public static Engine SpatialObservationRegionQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpatialObservationRegionQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the geometric or geographic region reg can be an observation in spatial statistics. 
        ///https://reference.wolfram.com/language/ref/SpatialObservationRegionQ.html
        ///</summary>
        public static Engine SpatialObservationRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("SpatialObservationRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to import a file semantically to give a Dataset object.
        ///https://reference.wolfram.com/language/ref/SemanticImport.html
        ///</summary>
        public static Engine SemanticImport(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SemanticImport[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to import a file semantically to give a Dataset object.
        ///https://reference.wolfram.com/language/ref/SemanticImport.html
        ///</summary>
        public static Engine SemanticImport(this Engine en, string? name = null)
        {
            return en.Execute("SemanticImport[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the species entity.
        ///https://reference.wolfram.com/language/ref/SpeciesData.html
        ///</summary>
        public static Engine SpeciesData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpeciesData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a power series expansion for f about the point x=x0 to order (x-x0)n, where n is an explicit integer. 
        ///https://reference.wolfram.com/language/ref/Series.html
        ///</summary>
        public static Engine Series(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Series[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the last element of SequenceFoldList[f,{x1,…,xn},{a1,a2,…}].
        ///https://reference.wolfram.com/language/ref/SequenceFold.html
        ///</summary>
        public static Engine SequenceFold(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SequenceFold[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic secant of z. 
        ///https://reference.wolfram.com/language/ref/Sech.html
        ///</summary>
        public static Engine Sech(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sech[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic secant of z. 
        ///https://reference.wolfram.com/language/ref/Sech.html
        ///</summary>
        public static Engine Sech(this Engine en, string? name = null)
        {
            return en.Execute("Sech[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the values of vars determined by the solutions of the system expr.
        ///https://reference.wolfram.com/language/ref/SolveValues.html
        ///</summary>
        public static Engine SolveValues(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SolveValues[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a sequence of arguments to be spliced automatically into any function. 
        ///https://reference.wolfram.com/language/ref/Sequence.html
        ///</summary>
        public static Engine Sequence(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Sequence[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Succeeds.html
        ///</summary>
        public static Engine Succeeds(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Succeeds[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a SequencePredictorFunction[…] based on the sequences given.
        ///https://reference.wolfram.com/language/ref/SequencePredict.html
        ///</summary>
        public static Engine SequencePredict(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SequencePredict[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a SequencePredictorFunction[…] based on the sequences given.
        ///https://reference.wolfram.com/language/ref/SequencePredict.html
        ///</summary>
        public static Engine SequencePredict(this Engine en, string? name = null)
        {
            return en.Execute("SequencePredict[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates the list {0,1/n,2/n,…,1}.
        ///https://reference.wolfram.com/language/ref/Subdivide.html
        ///</summary>
        public static Engine Subdivide(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Subdivide[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates the list {0,1/n,2/n,…,1}.
        ///https://reference.wolfram.com/language/ref/Subdivide.html
        ///</summary>
        public static Engine Subdivide(this Engine en, string? name = null)
        {
            return en.Execute("Subdivide[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the security certificate issued for a public key.
        ///https://reference.wolfram.com/language/ref/SecurityCertificate.html
        ///</summary>
        public static Engine SecurityCertificate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SecurityCertificate[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the security certificate issued for a public key.
        ///https://reference.wolfram.com/language/ref/SecurityCertificate.html
        ///</summary>
        public static Engine SecurityCertificate(this Engine en, string? name = null)
        {
            return en.Execute("SecurityCertificate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///splits list into sublists separated by sequences that match the sequence pattern patt. 
        ///https://reference.wolfram.com/language/ref/SequenceSplit.html
        ///</summary>
        public static Engine SequenceSplit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SequenceSplit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of CellObject expressions corresponding to the currently selected cells in notebook.
        ///https://reference.wolfram.com/language/ref/SelectedCells.html
        ///</summary>
        public static Engine SelectedCells(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SelectedCells[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of CellObject expressions corresponding to the currently selected cells in notebook.
        ///https://reference.wolfram.com/language/ref/SelectedCells.html
        ///</summary>
        public static Engine SelectedCells(this Engine en, string? name = null)
        {
            return en.Execute("SelectedCells[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SucceedsTilde.html
        ///</summary>
        public static Engine SucceedsTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SucceedsTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a net layer that applies an affine transformation to an input of size c×h0×w0 and returns an output of size c×h×w.
        ///https://reference.wolfram.com/language/ref/SpatialTransformationLayer.html
        ///</summary>
        public static Engine SpatialTransformationLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpatialTransformationLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that applies an affine transformation to an input of size c×h0×w0 and returns an output of size c×h×w.
        ///https://reference.wolfram.com/language/ref/SpatialTransformationLayer.html
        ///</summary>
        public static Engine SpatialTransformationLayer(this Engine en, string? name = null)
        {
            return en.Execute("SpatialTransformationLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///splits "string" into a list of substrings separated by whitespace. 
        ///https://reference.wolfram.com/language/ref/StringSplit.html
        ///</summary>
        public static Engine StringSplit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StringSplit[" + arg0 + "]", name);
        }

        ///<summary>
        ///splits "string" into a list of substrings separated by whitespace. 
        ///https://reference.wolfram.com/language/ref/StringSplit.html
        ///</summary>
        public static Engine StringSplit(this Engine en, string? name = null)
        {
            return en.Execute("StringSplit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the positions of n uniformly distributed points on the surface of a unit sphere.
        ///https://reference.wolfram.com/language/ref/SpherePoints.html
        ///</summary>
        public static Engine SpherePoints(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpherePoints[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the positions of n uniformly distributed points on the surface of a unit sphere.
        ///https://reference.wolfram.com/language/ref/SpherePoints.html
        ///</summary>
        public static Engine SpherePoints(this Engine en, string? name = null)
        {
            return en.Execute("SpherePoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits a request to be executed by an external service specified by assoc.
        ///https://reference.wolfram.com/language/ref/ServiceSubmit.html
        ///</summary>
        public static Engine ServiceSubmit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ServiceSubmit[" + arg0 + "]", name);
        }

        ///<summary>
        ///submits a request to be executed by an external service specified by assoc.
        ///https://reference.wolfram.com/language/ref/ServiceSubmit.html
        ///</summary>
        public static Engine ServiceSubmit(this Engine en, string? name = null)
        {
            return en.Execute("ServiceSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits an asynchronous task to evaluate expr in the current session.
        ///https://reference.wolfram.com/language/ref/SessionSubmit.html
        ///</summary>
        public static Engine SessionSubmit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SessionSubmit[" + arg0 + "]", name);
        }

        ///<summary>
        ///submits an asynchronous task to evaluate expr in the current session.
        ///https://reference.wolfram.com/language/ref/SessionSubmit.html
        ///</summary>
        public static Engine SessionSubmit(this Engine en, string? name = null)
        {
            return en.Execute("SessionSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a count of the number of times sub appears in any order as a sublist of list.
        ///https://reference.wolfram.com/language/ref/SubsetCount.html
        ///</summary>
        public static Engine SubsetCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SubsetCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents values vali associated with disjoint regions regi. 
        ///https://reference.wolfram.com/language/ref/SpatialBinnedPointData.html
        ///</summary>
        public static Engine SpatialBinnedPointData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpatialBinnedPointData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents values vali associated with disjoint regions regi. 
        ///https://reference.wolfram.com/language/ref/SpatialBinnedPointData.html
        ///</summary>
        public static Engine SpatialBinnedPointData(this Engine en, string? name = null)
        {
            return en.Execute("SpatialBinnedPointData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of cases of text identified as being of type form that appear in the transcription of audio.
        ///https://reference.wolfram.com/language/ref/SpeechCases.html
        ///</summary>
        public static Engine SpeechCases(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpeechCases[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the strings obtained by replacing each individual occurrence of substrings in "string" matching the string expressions si. 
        ///https://reference.wolfram.com/language/ref/StringReplaceList.html
        ///</summary>
        public static Engine StringReplaceList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringReplaceList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list of the principal subresultant coefficients of the polynomials poly1 and poly2 with respect to the variable var.
        ///https://reference.wolfram.com/language/ref/Subresultants.html
        ///</summary>
        public static Engine Subresultants(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Subresultants[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///executes "req" on an external service.
        ///https://reference.wolfram.com/language/ref/ServiceExecute.html
        ///</summary>
        public static Engine ServiceExecute(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ServiceExecute[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as expr†.
        ///https://reference.wolfram.com/language/ref/SuperDagger.html
        ///</summary>
        public static Engine SuperDagger(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SuperDagger[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as expr†.
        ///https://reference.wolfram.com/language/ref/SuperDagger.html
        ///</summary>
        public static Engine SuperDagger(this Engine en, string? name = null)
        {
            return en.Execute("SuperDagger[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///copies the contents of the current selection in a notebook into a new cell. 
        ///https://reference.wolfram.com/language/ref/SelectionCreateCell.html
        ///</summary>
        public static Engine SelectionCreateCell(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SelectionCreateCell[" + arg0 + "]", name);
        }

        ///<summary>
        ///copies the contents of the current selection in a notebook into a new cell. 
        ///https://reference.wolfram.com/language/ref/SelectionCreateCell.html
        ///</summary>
        public static Engine SelectionCreateCell(this Engine en, string? name = null)
        {
            return en.Execute("SelectionCreateCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the spherical Bessel function of the first kind . 
        ///https://reference.wolfram.com/language/ref/SphericalBesselJ.html
        ///</summary>
        public static Engine SphericalBesselJ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SphericalBesselJ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds full opacity to color.
        ///https://reference.wolfram.com/language/ref/SetAlphaChannel.html
        ///</summary>
        public static Engine SetAlphaChannel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SetAlphaChannel[" + arg0 + "]", name);
        }

        ///<summary>
        ///adds full opacity to color.
        ///https://reference.wolfram.com/language/ref/SetAlphaChannel.html
        ///</summary>
        public static Engine SetAlphaChannel(this Engine en, string? name = null)
        {
            return en.Execute("SetAlphaChannel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a function generated by SequencePredict that predicts the next elements from a sequence.
        ///https://reference.wolfram.com/language/ref/SequencePredictorFunction.html
        ///</summary>
        public static Engine SequencePredictorFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SequencePredictorFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a function generated by SequencePredict that predicts the next elements from a sequence.
        ///https://reference.wolfram.com/language/ref/SequencePredictorFunction.html
        ///</summary>
        public static Engine SequencePredictorFunction(this Engine en, string? name = null)
        {
            return en.Execute("SequencePredictorFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///synthesizes the contents of expr as an Audio object. 
        ///https://reference.wolfram.com/language/ref/SpeechSynthesize.html
        ///</summary>
        public static Engine SpeechSynthesize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpeechSynthesize[" + arg0 + "]", name);
        }

        ///<summary>
        ///synthesizes the contents of expr as an Audio object. 
        ///https://reference.wolfram.com/language/ref/SpeechSynthesize.html
        ///</summary>
        public static Engine SpeechSynthesize(this Engine en, string? name = null)
        {
            return en.Execute("SpeechSynthesize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives Spearman's rank correlation coefficient  for the vectors v1 and v2.
        ///https://reference.wolfram.com/language/ref/SpearmanRho.html
        ///</summary>
        public static Engine SpearmanRho(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpearmanRho[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the point collection pdata is distributed uniformly over the observation region.
        ///https://reference.wolfram.com/language/ref/SpatialRandomnessTest.html
        ///</summary>
        public static Engine SpatialRandomnessTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpatialRandomnessTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the point collection pdata is distributed uniformly over the observation region.
        ///https://reference.wolfram.com/language/ref/SpatialRandomnessTest.html
        ///</summary>
        public static Engine SpatialRandomnessTest(this Engine en, string? name = null)
        {
            return en.Execute("SpatialRandomnessTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of all possible subsets of list. 
        ///https://reference.wolfram.com/language/ref/Subsets.html
        ///</summary>
        public static Engine Subsets(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Subsets[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of all possible subsets of list. 
        ///https://reference.wolfram.com/language/ref/Subsets.html
        ///</summary>
        public static Engine Subsets(this Engine en, string? name = null)
        {
            return en.Execute("Subsets[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets cookies with attributes specified by the association assoc, to be used by functions such as URLExecute.
        ///https://reference.wolfram.com/language/ref/SetCookies.html
        ///</summary>
        public static Engine SetCookies(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SetCookies[" + arg0 + "]", name);
        }

        ///<summary>
        ///sets cookies with attributes specified by the association assoc, to be used by functions such as URLExecute.
        ///https://reference.wolfram.com/language/ref/SetCookies.html
        ///</summary>
        public static Engine SetCookies(this Engine en, string? name = null)
        {
            return en.Execute("SetCookies[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces sublists in list according to the specified rule or list of rules.
        ///https://reference.wolfram.com/language/ref/SubsetReplace.html
        ///</summary>
        public static Engine SubsetReplace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SubsetReplace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the spherical Hankel function of the first kind . 
        ///https://reference.wolfram.com/language/ref/SphericalHankelH1.html
        ///</summary>
        public static Engine SphericalHankelH1(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SphericalHankelH1[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as a spacer w printer's points wide.
        ///https://reference.wolfram.com/language/ref/Spacer.html
        ///</summary>
        public static Engine Spacer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Spacer[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as a spacer w printer's points wide.
        ///https://reference.wolfram.com/language/ref/Spacer.html
        ///</summary>
        public static Engine Spacer(this Engine en, string? name = null)
        {
            return en.Execute("Spacer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr+.
        ///https://reference.wolfram.com/language/ref/SuperPlus.html
        ///</summary>
        public static Engine SuperPlus(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SuperPlus[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as expr+.
        ///https://reference.wolfram.com/language/ref/SuperPlus.html
        ///</summary>
        public static Engine SuperPlus(this Engine en, string? name = null)
        {
            return en.Execute("SuperPlus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a secured authentication key with credentials and details specified by the association assoc.
        ///https://reference.wolfram.com/language/ref/SecuredAuthenticationKey.html
        ///</summary>
        public static Engine SecuredAuthenticationKey(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SecuredAuthenticationKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a secured authentication key with credentials and details specified by the association assoc.
        ///https://reference.wolfram.com/language/ref/SecuredAuthenticationKey.html
        ///</summary>
        public static Engine SecuredAuthenticationKey(this Engine en, string? name = null)
        {
            return en.Execute("SecuredAuthenticationKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the spherical Bessel function of the second kind . 
        ///https://reference.wolfram.com/language/ref/SphericalBesselY.html
        ///</summary>
        public static Engine SphericalBesselY(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SphericalBesselY[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a component of a search query that is to be treated as having weight w.
        ///https://reference.wolfram.com/language/ref/SearchAdjustment.html
        ///</summary>
        public static Engine SearchAdjustment(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SearchAdjustment[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets the current working directory used for cloud objects to dir.
        ///https://reference.wolfram.com/language/ref/SetCloudDirectory.html
        ///</summary>
        public static Engine SetCloudDirectory(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SetCloudDirectory[" + arg0 + "]", name);
        }

        ///<summary>
        ///sets the current working directory used for cloud objects to dir.
        ///https://reference.wolfram.com/language/ref/SetCloudDirectory.html
        ///</summary>
        public static Engine SetCloudDirectory(this Engine en, string? name = null)
        {
            return en.Execute("SetCloudDirectory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the spheroidal eigenvalue with degree  and order .
        ///https://reference.wolfram.com/language/ref/SpheroidalEigenvalue.html
        ///</summary>
        public static Engine SpheroidalEigenvalue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SpheroidalEigenvalue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the solid angle at the point p and spanned by the vectors u1,…,ud.
        ///https://reference.wolfram.com/language/ref/SolidAngle.html
        ///</summary>
        public static Engine SolidAngle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SolidAngle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that produces a list of indices for an input sequence.
        ///https://reference.wolfram.com/language/ref/SequenceIndicesLayer.html
        ///</summary>
        public static Engine SequenceIndicesLayer(this Engine en, string? name = null)
        {
            return en.Execute("SequenceIndicesLayer[]", name);
        }

        ///<summary>
        ///sets the value of an operating system environment variable.
        ///https://reference.wolfram.com/language/ref/SetEnvironment.html
        ///</summary>
        public static Engine SetEnvironment(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SetEnvironment[" + arg0 + "]", name);
        }

        ///<summary>
        ///sets the value of an operating system environment variable.
        ///https://reference.wolfram.com/language/ref/SetEnvironment.html
        ///</summary>
        public static Engine SetEnvironment(this Engine en, string? name = null)
        {
            return en.Execute("SetEnvironment[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the sublists in list that match the pattern patt in any order.
        ///https://reference.wolfram.com/language/ref/SubsetCases.html
        ///</summary>
        public static Engine SubsetCases(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SubsetCases[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives conditions for the sum  to be convergent.
        ///https://reference.wolfram.com/language/ref/SumConvergence.html
        ///</summary>
        public static Engine SumConvergence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SumConvergence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates the sum . 
        ///https://reference.wolfram.com/language/ref/Sum.html
        ///</summary>
        public static Engine Sum(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Sum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that sums all of its input elements.
        ///https://reference.wolfram.com/language/ref/SummationLayer.html
        ///</summary>
        public static Engine SummationLayer(this Engine en, string? name = null)
        {
            return en.Execute("SummationLayer[]", name);
        }

        ///<summary>
        ///subtracts x from each side of the equation or inequality rel.
        ///https://reference.wolfram.com/language/ref/SubtractSides.html
        ///</summary>
        public static Engine SubtractSides(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SubtractSides[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets the current working directory to dir. 
        ///https://reference.wolfram.com/language/ref/SetDirectory.html
        ///</summary>
        public static Engine SetDirectory(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SetDirectory[" + arg0 + "]", name);
        }

        ///<summary>
        ///sets the current working directory to dir. 
        ///https://reference.wolfram.com/language/ref/SetDirectory.html
        ///</summary>
        public static Engine SetDirectory(this Engine en, string? name = null)
        {
            return en.Execute("SetDirectory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the angular spheroidal function  of the second kind.
        ///https://reference.wolfram.com/language/ref/SpheroidalQS.html
        ///</summary>
        public static Engine SpheroidalQS(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SpheroidalQS[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a Student  distribution with ν degrees of freedom.
        ///https://reference.wolfram.com/language/ref/StudentTDistribution.html
        ///</summary>
        public static Engine StudentTDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StudentTDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Student  distribution with ν degrees of freedom.
        ///https://reference.wolfram.com/language/ref/StudentTDistribution.html
        ///</summary>
        public static Engine StudentTDistribution(this Engine en, string? name = null)
        {
            return en.Execute("StudentTDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a 3D plot with a spherical radius r as a function of spherical coordinates θ and ϕ.
        ///https://reference.wolfram.com/language/ref/SphericalPlot3D.html
        ///</summary>
        public static Engine SphericalPlot3D(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SphericalPlot3D[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///makes a sector chart with sector angles proportional to xi and radii yi.
        ///https://reference.wolfram.com/language/ref/SectorChart.html
        ///</summary>
        public static Engine SectorChart(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SectorChart[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a net that takes a sequence of inputs and returns the last element of the sequence.
        ///https://reference.wolfram.com/language/ref/SequenceLastLayer.html
        ///</summary>
        public static Engine SequenceLastLayer(this Engine en, string? name = null)
        {
            return en.Execute("SequenceLastLayer[]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Superset.html
        ///</summary>
        public static Engine Superset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Superset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a sound. 
        ///https://reference.wolfram.com/language/ref/Sound.html
        ///</summary>
        public static Engine Sound(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sound[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a sound. 
        ///https://reference.wolfram.com/language/ref/Sound.html
        ///</summary>
        public static Engine Sound(this Engine en, string? name = null)
        {
            return en.Execute("Sound[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a filled spherical shell centered at c with inner radius rinner and outer radius router.
        ///https://reference.wolfram.com/language/ref/SphericalShell.html
        ///</summary>
        public static Engine SphericalShell(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SphericalShell[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a prescribed displacement on a solid boundary for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/SolidDisplacementCondition.html
        ///</summary>
        public static Engine SolidDisplacementCondition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SolidDisplacementCondition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the angular spheroidal function  of the first kind.
        ///https://reference.wolfram.com/language/ref/SpheroidalPS.html
        ///</summary>
        public static Engine SpheroidalPS(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SpheroidalPS[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a list of the sublists in list that match the sequence pattern patt.
        ///https://reference.wolfram.com/language/ref/SequenceCases.html
        ///</summary>
        public static Engine SequenceCases(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SequenceCases[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sends mail consisting of body to the address specified by $CloudUserID.
        ///https://reference.wolfram.com/language/ref/SendMail.html
        ///</summary>
        public static Engine SendMail(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SendMail[" + arg0 + "]", name);
        }

        ///<summary>
        ///sends mail consisting of body to the address specified by $CloudUserID.
        ///https://reference.wolfram.com/language/ref/SendMail.html
        ///</summary>
        public static Engine SendMail(this Engine en, string? name = null)
        {
            return en.Execute("SendMail[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to give the best semantic interpretation of the specified free-form string as a Wolfram Language expression.
        ///https://reference.wolfram.com/language/ref/SemanticInterpretation.html
        ///</summary>
        public static Engine SemanticInterpretation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SemanticInterpretation[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to give the best semantic interpretation of the specified free-form string as a Wolfram Language expression.
        ///https://reference.wolfram.com/language/ref/SemanticInterpretation.html
        ///</summary>
        public static Engine SemanticInterpretation(this Engine en, string? name = null)
        {
            return en.Execute("SemanticInterpretation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Sokal–Sneath dissimilarity between Boolean vectors u and v.
        ///https://reference.wolfram.com/language/ref/SokalSneathDissimilarity.html
        ///</summary>
        public static Engine SokalSneathDissimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SokalSneathDissimilarity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets permissions for the cloud object obj to be as specified by the string pstring.
        ///https://reference.wolfram.com/language/ref/SetPermissions.html
        ///</summary>
        public static Engine SetPermissions(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetPermissions[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list of subresultant polynomials of the polynomials poly1 and poly2 with respect to the variable var.
        ///https://reference.wolfram.com/language/ref/SubresultantPolynomials.html
        ///</summary>
        public static Engine SubresultantPolynomials(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SubresultantPolynomials[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SupersetEqual.html
        ///</summary>
        public static Engine SupersetEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SupersetEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the supernova entity.
        ///https://reference.wolfram.com/language/ref/SupernovaData.html
        ///</summary>
        public static Engine SupernovaData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SupernovaData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net that reverses the order of an input sequence.
        ///https://reference.wolfram.com/language/ref/SequenceReverseLayer.html
        ///</summary>
        public static Engine SequenceReverseLayer(this Engine en, string? name = null)
        {
            return en.Execute("SequenceReverseLayer[]", name);
        }

        ///<summary>
        ///gives the spheroidal radial factor with degree  and order .
        ///https://reference.wolfram.com/language/ref/SpheroidalRadialFactor.html
        ///</summary>
        public static Engine SpheroidalRadialFactor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SpheroidalRadialFactor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SucceedsEqual.html
        ///</summary>
        public static Engine SucceedsEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SucceedsEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the derivative with respect to  of the angular spheroidal function  of the first kind.
        ///https://reference.wolfram.com/language/ref/SpheroidalPSPrime.html
        ///</summary>
        public static Engine SpheroidalPSPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SpheroidalPSPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the number of permutations of n objects that leave no object fixed.
        ///https://reference.wolfram.com/language/ref/Subfactorial.html
        ///</summary>
        public static Engine Subfactorial(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Subfactorial[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of permutations of n objects that leave no object fixed.
        ///https://reference.wolfram.com/language/ref/Subfactorial.html
        ///</summary>
        public static Engine Subfactorial(this Engine en, string? name = null)
        {
            return en.Execute("Subfactorial[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the name of the specified symbol. 
        ///https://reference.wolfram.com/language/ref/SymbolName.html
        ///</summary>
        public static Engine SymbolName(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SymbolName[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the name of the specified symbol. 
        ///https://reference.wolfram.com/language/ref/SymbolName.html
        ///</summary>
        public static Engine SymbolName(this Engine en, string? name = null)
        {
            return en.Execute("SymbolName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Suzuki group .
        ///https://reference.wolfram.com/language/ref/SuzukiGroupSuz.html
        ///</summary>
        public static Engine SuzukiGroupSuz(this Engine en, string? name = null)
        {
            return en.Execute("SuzukiGroupSuz[]", name);
        }

        ///<summary>
        ///displays as expr-.
        ///https://reference.wolfram.com/language/ref/SuperMinus.html
        ///</summary>
        public static Engine SuperMinus(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SuperMinus[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as expr-.
        ///https://reference.wolfram.com/language/ref/SuperMinus.html
        ///</summary>
        public static Engine SuperMinus(this Engine en, string? name = null)
        {
            return en.Execute("SuperMinus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets the specified default options for a symbol s. 
        ///https://reference.wolfram.com/language/ref/SetOptions.html
        ///</summary>
        public static Engine SetOptions(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SetOptions[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///is an object that formats as . 
        ///https://reference.wolfram.com/language/ref/Superscript.html
        ///</summary>
        public static Engine Superscript(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Superscript[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the time of the next sunset for the current date and location.
        ///https://reference.wolfram.com/language/ref/Sunset.html
        ///</summary>
        public static Engine Sunset(this Engine en, string? name = null)
        {
            return en.Execute("Sunset[]", name);
        }

        ///<summary>
        ///gives the survival function for the distribution dist evaluated at x.
        ///https://reference.wolfram.com/language/ref/SurvivalFunction.html
        ///</summary>
        public static Engine SurvivalFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SurvivalFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive to use in coloring 3D surfaces that specifies the spotlight of color col at position pt aimed at the center with half-angle α.
        ///https://reference.wolfram.com/language/ref/SpotLight.html
        ///</summary>
        public static Engine SpotLight(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SpotLight[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///picks out all elements ei of list for which crit[ei] is True. 
        ///https://reference.wolfram.com/language/ref/Select.html
        ///</summary>
        public static Engine Select(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Select[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the total number of seconds of real time that have elapsed since the beginning of your Wolfram System session. 
        ///https://reference.wolfram.com/language/ref/SessionTime.html
        ///</summary>
        public static Engine SessionTime(this Engine en, string? name = null)
        {
            return en.Execute("SessionTime[]", name);
        }

        ///<summary>
        ///finds the coefficient of the n -order term in a power series in the form generated by Series. 
        ///https://reference.wolfram.com/language/ref/SeriesCoefficient.html
        ///</summary>
        public static Engine SeriesCoefficient(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SeriesCoefficient[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a success of a type indicated by tag, with details given by the association assoc.
        ///https://reference.wolfram.com/language/ref/Success.html
        ///</summary>
        public static Engine Success(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Success[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the beginning of string matches the string pattern patt, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/StringStartsQ.html
        ///</summary>
        public static Engine StringStartsQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StringStartsQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces independent values of the symmetrized array sa as given by the rules posivali.
        ///https://reference.wolfram.com/language/ref/SymmetrizedReplacePart.html
        ///</summary>
        public static Engine SymmetrizedReplacePart(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SymmetrizedReplacePart[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the distribution obtained by splicing the distributions dist1, dist2, … truncated on the intervals {c0,c1}, {c1,c2}, … with weights w1, w2, … .
        ///https://reference.wolfram.com/language/ref/SplicedDistribution.html
        ///</summary>
        public static Engine SplicedDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SplicedDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///estimates the  function  for point data pdata at radius r.
        ///https://reference.wolfram.com/language/ref/SpatialJ.html
        ///</summary>
        public static Engine SpatialJ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpatialJ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the currently selected notebook in the front end. 
        ///https://reference.wolfram.com/language/ref/SelectedNotebook.html
        ///</summary>
        public static Engine SelectedNotebook(this Engine en, string? name = null)
        {
            return en.Execute("SelectedNotebook[]", name);
        }

        ///<summary>
        ///gives True if speaker features in audio match the one from reference ref and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/SpeakerMatchQ.html
        ///</summary>
        public static Engine SpeakerMatchQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpeakerMatchQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the short-time Fourier transform (STFT) of data as a ShortTimeFourierData object.
        ///https://reference.wolfram.com/language/ref/ShortTimeFourier.html
        ///</summary>
        public static Engine ShortTimeFourier(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ShortTimeFourier[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the short-time Fourier transform (STFT) of data as a ShortTimeFourierData object.
        ///https://reference.wolfram.com/language/ref/ShortTimeFourier.html
        ///</summary>
        public static Engine ShortTimeFourier(this Engine en, string? name = null)
        {
            return en.Execute("ShortTimeFourier[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SquareIntersection.html
        ///</summary>
        public static Engine SquareIntersection(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SquareIntersection[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a list of rules posivali of the symmetrized array sa.
        ///https://reference.wolfram.com/language/ref/SymmetrizedArrayRules.html
        ///</summary>
        public static Engine SymmetrizedArrayRules(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SymmetrizedArrayRules[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of rules posivali of the symmetrized array sa.
        ///https://reference.wolfram.com/language/ref/SymmetrizedArrayRules.html
        ///</summary>
        public static Engine SymmetrizedArrayRules(this Engine en, string? name = null)
        {
            return en.Execute("SymmetrizedArrayRules[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the radial spheroidal function  of the first kind.
        ///https://reference.wolfram.com/language/ref/SpheroidalS1.html
        ///</summary>
        public static Engine SpheroidalS1(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SpheroidalS1[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///creates a connection to an external service.
        ///https://reference.wolfram.com/language/ref/ServiceConnect.html
        ///</summary>
        public static Engine ServiceConnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ServiceConnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a connection to an external service.
        ///https://reference.wolfram.com/language/ref/ServiceConnect.html
        ///</summary>
        public static Engine ServiceConnect(this Engine en, string? name = null)
        {
            return en.Execute("ServiceConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the low‐level box representation for xy in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/SuperscriptBox.html
        ///</summary>
        public static Engine SuperscriptBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SuperscriptBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the spectrogram data of list.
        ///https://reference.wolfram.com/language/ref/SpectrogramArray.html
        ///</summary>
        public static Engine SpectrogramArray(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpectrogramArray[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the spectrogram data of list.
        ///https://reference.wolfram.com/language/ref/SpectrogramArray.html
        ///</summary>
        public static Engine SpectrogramArray(this Engine en, string? name = null)
        {
            return en.Execute("SpectrogramArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sorts the elements of list into canonical order. 
        ///https://reference.wolfram.com/language/ref/Sort.html
        ///</summary>
        public static Engine Sort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sort[" + arg0 + "]", name);
        }

        ///<summary>
        ///sorts the elements of list into canonical order. 
        ///https://reference.wolfram.com/language/ref/Sort.html
        ///</summary>
        public static Engine Sort(this Engine en, string? name = null)
        {
            return en.Execute("Sort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pattern object that matches the shortest sequence consistent with the pattern p. 
        ///https://reference.wolfram.com/language/ref/Shortest.html
        ///</summary>
        public static Engine Shortest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Shortest[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a pattern object that matches the shortest sequence consistent with the pattern p. 
        ///https://reference.wolfram.com/language/ref/Shortest.html
        ///</summary>
        public static Engine Shortest(this Engine en, string? name = null)
        {
            return en.Execute("Shortest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the spherical Hankel function of the second kind . 
        ///https://reference.wolfram.com/language/ref/SphericalHankelH2.html
        ///</summary>
        public static Engine SphericalHankelH2(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SphericalHankelH2[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a square wave that alternates between  and  with unit period.
        ///https://reference.wolfram.com/language/ref/SquareWave.html
        ///</summary>
        public static Engine SquareWave(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SquareWave[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a square wave that alternates between  and  with unit period.
        ///https://reference.wolfram.com/language/ref/SquareWave.html
        ///</summary>
        public static Engine SquareWave(this Engine en, string? name = null)
        {
            return en.Execute("SquareWave[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces sequences in list according to the specified rule or list of rules. 
        ///https://reference.wolfram.com/language/ref/SequenceReplace.html
        ///</summary>
        public static Engine SequenceReplace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SequenceReplace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a solid shell of a 3D region reg.
        ///https://reference.wolfram.com/language/ref/ShellRegion.html
        ///</summary>
        public static Engine ShellRegion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ShellRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a solid shell of a 3D region reg.
        ///https://reference.wolfram.com/language/ref/ShellRegion.html
        ///</summary>
        public static Engine ShellRegion(this Engine en, string? name = null)
        {
            return en.Execute("ShellRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets the value of a property "prop" for the specified format "fmt".
        ///https://reference.wolfram.com/language/ref/SetFileFormatProperties.html
        ///</summary>
        public static Engine SetFileFormatProperties(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetFileFormatProperties[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a collection of spatial locations points.
        ///https://reference.wolfram.com/language/ref/SpatialPointData.html
        ///</summary>
        public static Engine SpatialPointData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpatialPointData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a collection of spatial locations points.
        ///https://reference.wolfram.com/language/ref/SpatialPointData.html
        ///</summary>
        public static Engine SpatialPointData(this Engine en, string? name = null)
        {
            return en.Execute("SpatialPointData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Suzuki distribution with shape parameters μ and ν.
        ///https://reference.wolfram.com/language/ref/SuzukiDistribution.html
        ///</summary>
        public static Engine SuzukiDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SuzukiDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///creates a spatial prediction from values vali given at locations loci. 
        ///https://reference.wolfram.com/language/ref/SpatialEstimate.html
        ///</summary>
        public static Engine SpatialEstimate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpatialEstimate[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a spatial prediction from values vali given at locations loci. 
        ///https://reference.wolfram.com/language/ref/SpatialEstimate.html
        ///</summary>
        public static Engine SpatialEstimate(this Engine en, string? name = null)
        {
            return en.Execute("SpatialEstimate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///changes the way expr is stored internally, to try and minimize the amount of memory used. 
        ///https://reference.wolfram.com/language/ref/Share.html
        ///</summary>
        public static Engine Share(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Share[" + arg0 + "]", name);
        }

        ///<summary>
        ///changes the way expr is stored internally, to try and minimize the amount of memory used. 
        ///https://reference.wolfram.com/language/ref/Share.html
        ///</summary>
        public static Engine Share(this Engine en, string? name = null)
        {
            return en.Execute("Share[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets the members of the permissions group group to be {user1,…}.
        ///https://reference.wolfram.com/language/ref/SetUsers.html
        ///</summary>
        public static Engine SetUsers(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetUsers[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a filled triangle with sides of lengths a, b, and c.
        ///https://reference.wolfram.com/language/ref/SSSTriangle.html
        ///</summary>
        public static Engine SSSTriangle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SSSTriangle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///replaces forms and control objects such as sliders or popup menus in expr by their settings.
        ///https://reference.wolfram.com/language/ref/Setting.html
        ///</summary>
        public static Engine Setting(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Setting[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces forms and control objects such as sliders or popup menus in expr by their settings.
        ///https://reference.wolfram.com/language/ref/Setting.html
        ///</summary>
        public static Engine Setting(this Engine en, string? name = null)
        {
            return en.Execute("Setting[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///splits list into sublists consisting of runs of successive elements that give the same value when f is applied.
        ///https://reference.wolfram.com/language/ref/SplitBy.html
        ///</summary>
        public static Engine SplitBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SplitBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///resets the value for the internal system option with the specified name.
        ///https://reference.wolfram.com/language/ref/SetSystemOptions.html
        ///</summary>
        public static Engine SetSystemOptions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SetSystemOptions[" + arg0 + "]", name);
        }

        ///<summary>
        ///resets the value for the internal system option with the specified name.
        ///https://reference.wolfram.com/language/ref/SetSystemOptions.html
        ///</summary>
        public static Engine SetSystemOptions(this Engine en, string? name = null)
        {
            return en.Execute("SetSystemOptions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SubsetEqual.html
        ///</summary>
        public static Engine SubsetEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SubsetEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/ShortRightArrow.html
        ///</summary>
        public static Engine ShortRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ShortRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the spheroidal joining factor with degree  and order .
        ///https://reference.wolfram.com/language/ref/SpheroidalJoiningFactor.html
        ///</summary>
        public static Engine SpheroidalJoiningFactor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SpheroidalJoiningFactor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the expression stored under "keyname" in secure storage.
        ///https://reference.wolfram.com/language/ref/SystemCredential.html
        ///</summary>
        public static Engine SystemCredential(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemCredential[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the expression stored under "keyname" in secure storage.
        ///https://reference.wolfram.com/language/ref/SystemCredential.html
        ///</summary>
        public static Engine SystemCredential(this Engine en, string? name = null)
        {
            return en.Execute("SystemCredential[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the values of all known properties for an atomic state or state transition.
        ///https://reference.wolfram.com/language/ref/SpectralLineData.html
        ///</summary>
        public static Engine SpectralLineData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpectralLineData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the values of all known properties for an atomic state or state transition.
        ///https://reference.wolfram.com/language/ref/SpectralLineData.html
        ///</summary>
        public static Engine SpectralLineData(this Engine en, string? name = null)
        {
            return en.Execute("SpectralLineData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces the current selection in a notebook with the result obtained by evaluating the contents of the selection in the kernel. 
        ///https://reference.wolfram.com/language/ref/SelectionEvaluate.html
        ///</summary>
        public static Engine SelectionEvaluate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SelectionEvaluate[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces the current selection in a notebook with the result obtained by evaluating the contents of the selection in the kernel. 
        ///https://reference.wolfram.com/language/ref/SelectionEvaluate.html
        ///</summary>
        public static Engine SelectionEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("SelectionEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an open connection to an external service.
        ///https://reference.wolfram.com/language/ref/ServiceObject.html
        ///</summary>
        public static Engine ServiceObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ServiceObject[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as expr*.
        ///https://reference.wolfram.com/language/ref/SubStar.html
        ///</summary>
        public static Engine SubStar(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SubStar[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as expr*.
        ///https://reference.wolfram.com/language/ref/SubStar.html
        ///</summary>
        public static Engine SubStar(this Engine en, string? name = null)
        {
            return en.Execute("SubStar[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives detailed information about the Wolfram System being run. 
        ///https://reference.wolfram.com/language/ref/SystemInformation.html
        ///</summary>
        public static Engine SystemInformation(this Engine en, string? name = null)
        {
            return en.Execute("SystemInformation[]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SquareSuperset.html
        ///</summary>
        public static Engine SquareSuperset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SquareSuperset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the number of characters starting at the beginning of a string that correspond to syntactically correct input for a single Wolfram Language expression. 
        ///https://reference.wolfram.com/language/ref/SyntaxLength.html
        ///</summary>
        public static Engine SyntaxLength(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SyntaxLength[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the number of characters starting at the beginning of a string that correspond to syntactically correct input for a single Wolfram Language expression. 
        ///https://reference.wolfram.com/language/ref/SyntaxLength.html
        ///</summary>
        public static Engine SyntaxLength(this Engine en, string? name = null)
        {
            return en.Execute("SyntaxLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the result and properties of a short-time Fourier transform (STFT) of a signal.
        ///https://reference.wolfram.com/language/ref/ShortTimeFourierData.html
        ///</summary>
        public static Engine ShortTimeFourierData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ShortTimeFourierData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the result and properties of a short-time Fourier transform (STFT) of a signal.
        ///https://reference.wolfram.com/language/ref/ShortTimeFourierData.html
        ///</summary>
        public static Engine ShortTimeFourierData(this Engine en, string? name = null)
        {
            return en.Execute("ShortTimeFourierData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an interpreter object that can be applied to a speech input to try to interpret it as an object of the specified form. 
        ///https://reference.wolfram.com/language/ref/SpeechInterpreter.html
        ///</summary>
        public static Engine SpeechInterpreter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpeechInterpreter[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an interpreter object that can be applied to a speech input to try to interpret it as an object of the specified form. 
        ///https://reference.wolfram.com/language/ref/SpeechInterpreter.html
        ///</summary>
        public static Engine SpeechInterpreter(this Engine en, string? name = null)
        {
            return en.Execute("SpeechInterpreter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets the modification and access dates for a file to be the current date. 
        ///https://reference.wolfram.com/language/ref/SetFileDate.html
        ///</summary>
        public static Engine SetFileDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SetFileDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///sets the modification and access dates for a file to be the current date. 
        ///https://reference.wolfram.com/language/ref/SetFileDate.html
        ///</summary>
        public static Engine SetFileDate(this Engine en, string? name = null)
        {
            return en.Execute("SetFileDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///shows an interactive browser of system modeling example models. 
        ///https://reference.wolfram.com/language/ref/SystemModelExamples.html
        ///</summary>
        public static Engine SystemModelExamples(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelExamples[]", name);
        }

        ///<summary>
        ///gives the list of all possible subsequences of list. 
        ///https://reference.wolfram.com/language/ref/Subsequences.html
        ///</summary>
        public static Engine Subsequences(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Subsequences[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of all possible subsequences of list. 
        ///https://reference.wolfram.com/language/ref/Subsequences.html
        ///</summary>
        public static Engine Subsequences(this Engine en, string? name = null)
        {
            return en.Execute("Subsequences[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the variances of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/SiegelTukeyTest.html
        ///</summary>
        public static Engine SiegelTukeyTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SiegelTukeyTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the variances of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/SiegelTukeyTest.html
        ///</summary>
        public static Engine SiegelTukeyTest(this Engine en, string? name = null)
        {
            return en.Execute("SiegelTukeyTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr with intermediate expressions in evaluation chains included on the stack. 
        ///https://reference.wolfram.com/language/ref/StackComplete.html
        ///</summary>
        public static Engine StackComplete(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StackComplete[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr with intermediate expressions in evaluation chains included on the stack. 
        ///https://reference.wolfram.com/language/ref/StackComplete.html
        ///</summary>
        public static Engine StackComplete(this Engine en, string? name = null)
        {
            return en.Execute("StackComplete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///adds attr to the list of attributes of the symbol symbol. 
        ///https://reference.wolfram.com/language/ref/SetAttributes.html
        ///</summary>
        public static Engine SetAttributes(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetAttributes[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the derivative with respect to  of the angular spheroidal function  of the second kind.
        ///https://reference.wolfram.com/language/ref/SpheroidalQSPrime.html
        ///</summary>
        public static Engine SpheroidalQSPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SpheroidalQSPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///refers to a symbol with the specified name. 
        ///https://reference.wolfram.com/language/ref/Symbol.html
        ///</summary>
        public static Engine Symbol(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Symbol[" + arg0 + "]", name);
        }

        ///<summary>
        ///refers to a symbol with the specified name. 
        ///https://reference.wolfram.com/language/ref/Symbol.html
        ///</summary>
        public static Engine Symbol(this Engine en, string? name = null)
        {
            return en.Execute("Symbol[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an object that formats as . 
        ///https://reference.wolfram.com/language/ref/Subscript.html
        ///</summary>
        public static Engine Subscript(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Subscript[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///splits list into sublists consisting of runs of identical elements. 
        ///https://reference.wolfram.com/language/ref/Split.html
        ///</summary>
        public static Engine Split(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Split[" + arg0 + "]", name);
        }

        ///<summary>
        ///splits list into sublists consisting of runs of identical elements. 
        ///https://reference.wolfram.com/language/ref/Split.html
        ///</summary>
        public static Engine Split(this Engine en, string? name = null)
        {
            return en.Execute("Split[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Star.html
        ///</summary>
        public static Engine Star(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Star[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a linearized StateSpaceModel for model at an equilibrium. 
        ///https://reference.wolfram.com/language/ref/SystemModelLinearize.html
        ///</summary>
        public static Engine SystemModelLinearize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemModelLinearize[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a linearized StateSpaceModel for model at an equilibrium. 
        ///https://reference.wolfram.com/language/ref/SystemModelLinearize.html
        ///</summary>
        public static Engine SystemModelLinearize(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelLinearize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr*.
        ///https://reference.wolfram.com/language/ref/SuperStar.html
        ///</summary>
        public static Engine SuperStar(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SuperStar[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as expr*.
        ///https://reference.wolfram.com/language/ref/SuperStar.html
        ///</summary>
        public static Engine SuperStar(this Engine en, string? name = null)
        {
            return en.Execute("SuperStar[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the stable distribution Stype with index of stability α, skewness parameter β, location parameter μ, and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/StableDistribution.html
        ///</summary>
        public static Engine StableDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("StableDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///shifts and rescales the elements of list to have zero mean and unit sample variance.
        ///https://reference.wolfram.com/language/ref/Standardize.html
        ///</summary>
        public static Engine Standardize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Standardize[" + arg0 + "]", name);
        }

        ///<summary>
        ///shifts and rescales the elements of list to have zero mean and unit sample variance.
        ///https://reference.wolfram.com/language/ref/Standardize.html
        ///</summary>
        public static Engine Standardize(this Engine en, string? name = null)
        {
            return en.Execute("Standardize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents the displayed object  in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/SqrtBox.html
        ///</summary>
        public static Engine SqrtBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SqrtBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents the displayed object  in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/SqrtBox.html
        ///</summary>
        public static Engine SqrtBox(this Engine en, string? name = null)
        {
            return en.Execute("SqrtBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the polyhedron poly is simple and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimplePolyhedronQ.html
        ///</summary>
        public static Engine SimplePolyhedronQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SimplePolyhedronQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if the polyhedron poly is simple and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimplePolyhedronQ.html
        ///</summary>
        public static Engine SimplePolyhedronQ(this Engine en, string? name = null)
        {
            return en.Execute("SimplePolyhedronQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///simulates model and sensitivities to parameters pi following experiment settings.
        ///https://reference.wolfram.com/language/ref/SystemModelSimulateSensitivity.html
        ///</summary>
        public static Engine SystemModelSimulateSensitivity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SystemModelSimulateSensitivity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a mesh region representing the n-step Sierpiński triangle. 
        ///https://reference.wolfram.com/language/ref/SierpinskiMesh.html
        ///</summary>
        public static Engine SierpinskiMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SierpinskiMesh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a mesh region representing the n-step Sierpiński triangle. 
        ///https://reference.wolfram.com/language/ref/SierpinskiMesh.html
        ///</summary>
        public static Engine SierpinskiMesh(this Engine en, string? name = null)
        {
            return en.Execute("SierpinskiMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a net that takes a sequence of inputs and removes its last element.
        ///https://reference.wolfram.com/language/ref/SequenceMostLayer.html
        ///</summary>
        public static Engine SequenceMostLayer(this Engine en, string? name = null)
        {
            return en.Execute("SequenceMostLayer[]", name);
        }

        ///<summary>
        ///represents a source term  with source coefficient  and model variables vars.
        ///https://reference.wolfram.com/language/ref/SourcePDETerm.html
        ///</summary>
        public static Engine SourcePDETerm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SourcePDETerm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of components that are equivalent to the component comp by the symmetry sym.
        ///https://reference.wolfram.com/language/ref/SymmetrizedDependentComponents.html
        ///</summary>
        public static Engine SymmetrizedDependentComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SymmetrizedDependentComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the position of the Sun for the current date and location.
        ///https://reference.wolfram.com/language/ref/SunPosition.html
        ///</summary>
        public static Engine SunPosition(this Engine en, string? name = null)
        {
            return en.Execute("SunPosition[]", name);
        }

        ///<summary>
        ///generates a legend that associates swatches of colors coli with labels lbli.
        ///https://reference.wolfram.com/language/ref/SwatchLegend.html
        ///</summary>
        public static Engine SwatchLegend(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SwatchLegend[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if the polygon poly is simple and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimplePolygonQ.html
        ///</summary>
        public static Engine SimplePolygonQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SimplePolygonQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if the polygon poly is simple and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimplePolygonQ.html
        ///</summary>
        public static Engine SimplePolygonQ(this Engine en, string? name = null)
        {
            return en.Execute("SimplePolygonQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a count of the number of times sub appears as a sublist of list.
        ///https://reference.wolfram.com/language/ref/SequenceCount.html
        ///</summary>
        public static Engine SequenceCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SequenceCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the star entity.
        ///https://reference.wolfram.com/language/ref/StarData.html
        ///</summary>
        public static Engine StarData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StarData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all subvalues (values for f[…][…]…) defined for the symbol f.
        ///https://reference.wolfram.com/language/ref/SubValues.html
        ///</summary>
        public static Engine SubValues(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SubValues[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all subvalues (values for f[…][…]…) defined for the symbol f.
        ///https://reference.wolfram.com/language/ref/SubValues.html
        ///</summary>
        public static Engine SubValues(this Engine en, string? name = null)
        {
            return en.Execute("SubValues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sends a message to the specified channel.
        ///https://reference.wolfram.com/language/ref/SendMessage.html
        ///</summary>
        public static Engine SendMessage(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SendMessage[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a unit sphere centered at the point p.
        ///https://reference.wolfram.com/language/ref/Sphere.html
        ///</summary>
        public static Engine Sphere(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sphere[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a unit sphere centered at the point p.
        ///https://reference.wolfram.com/language/ref/Sphere.html
        ///</summary>
        public static Engine Sphere(this Engine en, string? name = null)
        {
            return en.Execute("Sphere[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a survival distribution with event times ei.
        ///https://reference.wolfram.com/language/ref/SurvivalDistribution.html
        ///</summary>
        public static Engine SurvivalDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SurvivalDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a survival distribution with event times ei.
        ///https://reference.wolfram.com/language/ref/SurvivalDistribution.html
        ///</summary>
        public static Engine SurvivalDistribution(this Engine en, string? name = null)
        {
            return en.Execute("SurvivalDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly symmetric, and False otherwise. 
        ///https://reference.wolfram.com/language/ref/SymmetricMatrixQ.html
        ///</summary>
        public static Engine SymmetricMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SymmetricMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly symmetric, and False otherwise. 
        ///https://reference.wolfram.com/language/ref/SymmetricMatrixQ.html
        ///</summary>
        public static Engine SymmetricMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("SymmetricMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a model with inputs ins and outputs outs obtained by connecting the systems models sysi using connections conxs.
        ///https://reference.wolfram.com/language/ref/SystemsConnectionsModel.html
        ///</summary>
        public static Engine SystemsConnectionsModel(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SystemsConnectionsModel[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the line segments representing the n-step Sierpiński curve.
        ///https://reference.wolfram.com/language/ref/SierpinskiCurve.html
        ///</summary>
        public static Engine SierpinskiCurve(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SierpinskiCurve[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the line segments representing the n-step Sierpiński curve.
        ///https://reference.wolfram.com/language/ref/SierpinskiCurve.html
        ///</summary>
        public static Engine SierpinskiCurve(this Engine en, string? name = null)
        {
            return en.Execute("SierpinskiCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///retrieves the lifetime distribution for model.
        ///https://reference.wolfram.com/language/ref/SystemModelReliability.html
        ///</summary>
        public static Engine SystemModelReliability(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemModelReliability[" + arg0 + "]", name);
        }

        ///<summary>
        ///retrieves the lifetime distribution for model.
        ///https://reference.wolfram.com/language/ref/SystemModelReliability.html
        ///</summary>
        public static Engine SystemModelReliability(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelReliability[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the numeric state response of the state-space model sys to input u for tmin≤t≤tmax. 
        ///https://reference.wolfram.com/language/ref/StateResponse.html
        ///</summary>
        public static Engine StateResponse(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StateResponse[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///makes a 3D sector chart with sector angle proportional to xi, radius yi, and height zi.
        ///https://reference.wolfram.com/language/ref/SectorChart3D.html
        ///</summary>
        public static Engine SectorChart3D(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SectorChart3D[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the median of data is zero. 
        ///https://reference.wolfram.com/language/ref/SignedRankTest.html
        ///</summary>
        public static Engine SignedRankTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SignedRankTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the median of data is zero. 
        ///https://reference.wolfram.com/language/ref/SignedRankTest.html
        ///</summary>
        public static Engine SignedRankTest(this Engine en, string? name = null)
        {
            return en.Execute("SignedRankTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr without modifying the evaluation stack. 
        ///https://reference.wolfram.com/language/ref/StackInhibit.html
        ///</summary>
        public static Engine StackInhibit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StackInhibit[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr without modifying the evaluation stack. 
        ///https://reference.wolfram.com/language/ref/StackInhibit.html
        ///</summary>
        public static Engine StackInhibit(this Engine en, string? name = null)
        {
            return en.Execute("StackInhibit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SucceedsSlantEqual.html
        ///</summary>
        public static Engine SucceedsSlantEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SucceedsSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a delay-free system by using approximations of order ord of the time delays in system sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelDelayApproximate.html
        ///</summary>
        public static Engine SystemsModelDelayApproximate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SystemsModelDelayApproximate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a standby distribution with component lifetime distributions disti. When component  fails, component  will become active. 
        ///https://reference.wolfram.com/language/ref/StandbyDistribution.html
        ///</summary>
        public static Engine StandbyDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StandbyDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints as the standard Wolfram Language two-dimensional representation of expr. 
        ///https://reference.wolfram.com/language/ref/StandardForm.html
        ///</summary>
        public static Engine StandardForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StandardForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as the standard Wolfram Language two-dimensional representation of expr. 
        ///https://reference.wolfram.com/language/ref/StandardForm.html
        ///</summary>
        public static Engine StandardForm(this Engine en, string? name = null)
        {
            return en.Execute("StandardForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///downloads and installs the software package pack on your machine.
        ///https://reference.wolfram.com/language/ref/SystemInstall.html
        ///</summary>
        public static Engine SystemInstall(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemInstall[" + arg0 + "]", name);
        }

        ///<summary>
        ///downloads and installs the software package pack on your machine.
        ///https://reference.wolfram.com/language/ref/SystemInstall.html
        ///</summary>
        public static Engine SystemInstall(this Engine en, string? name = null)
        {
            return en.Execute("SystemInstall[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the symbolic survival model obtained from functions like SurvivalModelFit.
        ///https://reference.wolfram.com/language/ref/SurvivalModel.html
        ///</summary>
        public static Engine SurvivalModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SurvivalModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the symbolic survival model obtained from functions like SurvivalModelFit.
        ///https://reference.wolfram.com/language/ref/SurvivalModel.html
        ///</summary>
        public static Engine SurvivalModel(this Engine en, string? name = null)
        {
            return en.Execute("SurvivalModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as a shallow form of expr. 
        ///https://reference.wolfram.com/language/ref/Shallow.html
        ///</summary>
        public static Engine Shallow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Shallow[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as a shallow form of expr. 
        ///https://reference.wolfram.com/language/ref/Shallow.html
        ///</summary>
        public static Engine Shallow(this Engine en, string? name = null)
        {
            return en.Execute("Shallow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a version of expr in which all numbers have been set to have accuracy a. 
        ///https://reference.wolfram.com/language/ref/SetAccuracy.html
        ///</summary>
        public static Engine SetAccuracy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetAccuracy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a version of expr in which all numbers have been set to have precision p. 
        ///https://reference.wolfram.com/language/ref/SetPrecision.html
        ///</summary>
        public static Engine SetPrecision(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetPrecision[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents data intended for secure credential storage. 
        ///https://reference.wolfram.com/language/ref/SystemCredentialData.html
        ///</summary>
        public static Engine SystemCredentialData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SystemCredentialData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives information used to generate syntax coloring and other advisories when f[…] is entered as input. 
        ///https://reference.wolfram.com/language/ref/SyntaxInformation.html
        ///</summary>
        public static Engine SyntaxInformation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SyntaxInformation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives information used to generate syntax coloring and other advisories when f[…] is entered as input. 
        ///https://reference.wolfram.com/language/ref/SyntaxInformation.html
        ///</summary>
        public static Engine SyntaxInformation(this Engine en, string? name = null)
        {
            return en.Execute("SyntaxInformation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if the string corresponds to syntactically correct input for a single Wolfram Language expression, and returns False otherwise. 
        ///https://reference.wolfram.com/language/ref/SyntaxQ.html
        ///</summary>
        public static Engine SyntaxQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SyntaxQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if the string corresponds to syntactically correct input for a single Wolfram Language expression, and returns False otherwise. 
        ///https://reference.wolfram.com/language/ref/SyntaxQ.html
        ///</summary>
        public static Engine SyntaxQ(this Engine en, string? name = null)
        {
            return en.Execute("SyntaxQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///shows default plots from the SystemModelSimulationData object sim.
        ///https://reference.wolfram.com/language/ref/SystemModelPlot.html
        ///</summary>
        public static Engine SystemModelPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemModelPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///shows default plots from the SystemModelSimulationData object sim.
        ///https://reference.wolfram.com/language/ref/SystemModelPlot.html
        ///</summary>
        public static Engine SystemModelPlot(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the star cluster entity.
        ///https://reference.wolfram.com/language/ref/StarClusterData.html
        ///</summary>
        public static Engine StarClusterData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StarClusterData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the standard state-space model with state matrix a, input matrix b, output matrix c, and transmission matrix d.
        ///https://reference.wolfram.com/language/ref/StateSpaceModel.html
        ///</summary>
        public static Engine StateSpaceModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StateSpaceModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the standard state-space model with state matrix a, input matrix b, output matrix c, and transmission matrix d.
        ///https://reference.wolfram.com/language/ref/StateSpaceModel.html
        ///</summary>
        public static Engine StateSpaceModel(this Engine en, string? name = null)
        {
            return en.Execute("StateSpaceModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Symlet wavelet of order 4.
        ///https://reference.wolfram.com/language/ref/SymletWavelet.html
        ///</summary>
        public static Engine SymletWavelet(this Engine en, string? name = null)
        {
            return en.Execute("SymletWavelet[]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SuchThat.html
        ///</summary>
        public static Engine SuchThat(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SuchThat[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///disconnects from an external service specified by a ServiceObject.
        ///https://reference.wolfram.com/language/ref/ServiceDisconnect.html
        ///</summary>
        public static Engine ServiceDisconnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ServiceDisconnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///disconnects from an external service specified by a ServiceObject.
        ///https://reference.wolfram.com/language/ref/ServiceDisconnect.html
        ///</summary>
        public static Engine ServiceDisconnect(this Engine en, string? name = null)
        {
            return en.Execute("ServiceDisconnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives at least one sample point in each connected component of the semialgebraic set defined by the inequalities ineqs in the variables x1, x2, ….
        ///https://reference.wolfram.com/language/ref/SemialgebraicComponentInstances.html
        ///</summary>
        public static Engine SemialgebraicComponentInstances(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SemialgebraicComponentInstances[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///starts an external session using the external evaluator sys, returning an external session object.
        ///https://reference.wolfram.com/language/ref/StartExternalSession.html
        ///</summary>
        public static Engine StartExternalSession(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StartExternalSession[" + arg0 + "]", name);
        }

        ///<summary>
        ///starts an external session using the external evaluator sys, returning an external session object.
        ///https://reference.wolfram.com/language/ref/StartExternalSession.html
        ///</summary>
        public static Engine StartExternalSession(this Engine en, string? name = null)
        {
            return en.Execute("StartExternalSession[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a matrix that corresponds to an exponential kernel of radius r. 
        ///https://reference.wolfram.com/language/ref/ShenCastanMatrix.html
        ///</summary>
        public static Engine ShenCastanMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ShenCastanMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a matrix that corresponds to an exponential kernel of radius r. 
        ///https://reference.wolfram.com/language/ref/ShenCastanMatrix.html
        ///</summary>
        public static Engine ShenCastanMatrix(this Engine en, string? name = null)
        {
            return en.Execute("ShenCastanMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a net that takes a sequence of inputs and removes its first element.
        ///https://reference.wolfram.com/language/ref/SequenceRestLayer.html
        ///</summary>
        public static Engine SequenceRestLayer(this Engine en, string? name = null)
        {
            return en.Execute("SequenceRestLayer[]", name);
        }

        ///<summary>
        ///changes model parameters, initializations or other properties in place.
        ///https://reference.wolfram.com/language/ref/SetSystemModel.html
        ///</summary>
        public static Engine SetSystemModel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetSystemModel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///extracts the subsystem of the systems model sys associated with inputs at position ini.
        ///https://reference.wolfram.com/language/ref/SystemsModelExtract.html
        ///</summary>
        public static Engine SystemsModelExtract(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SystemsModelExtract[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the vectors v1 and v2 are independent.
        ///https://reference.wolfram.com/language/ref/SpearmanRankTest.html
        ///</summary>
        public static Engine SpearmanRankTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpearmanRankTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic sine integral function . 
        ///https://reference.wolfram.com/language/ref/SinhIntegral.html
        ///</summary>
        public static Engine SinhIntegral(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SinhIntegral[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic sine integral function . 
        ///https://reference.wolfram.com/language/ref/SinhIntegral.html
        ///</summary>
        public static Engine SinhIntegral(this Engine en, string? name = null)
        {
            return en.Execute("SinhIntegral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///simulates model for the variable v with parameters pi.
        ///https://reference.wolfram.com/language/ref/SystemModelParametricSimulate.html
        ///</summary>
        public static Engine SystemModelParametricSimulate(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SystemModelParametricSimulate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a list of loaded system models.
        ///https://reference.wolfram.com/language/ref/SystemModels.html
        ///</summary>
        public static Engine SystemModels(this Engine en, string? name = null)
        {
            return en.Execute("SystemModels[]", name);
        }

        ///<summary>
        ///returns the synonyms associated with the specified word.
        ///https://reference.wolfram.com/language/ref/Synonyms.html
        ///</summary>
        public static Engine Synonyms(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Synonyms[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the synonyms associated with the specified word.
        ///https://reference.wolfram.com/language/ref/Synonyms.html
        ///</summary>
        public static Engine Synonyms(this Engine en, string? name = null)
        {
            return en.Execute("Synonyms[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents controller data generated by functions LQGRegulator, PIDTune, etc.
        ///https://reference.wolfram.com/language/ref/SystemsModelControllerData.html
        ///</summary>
        public static Engine SystemsModelControllerData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemsModelControllerData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents controller data generated by functions LQGRegulator, PIDTune, etc.
        ///https://reference.wolfram.com/language/ref/SystemsModelControllerData.html
        ///</summary>
        public static Engine SystemsModelControllerData(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelControllerData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a service request built from service, which might be a connected ServiceObject or a valid service name, and request "req".
        ///https://reference.wolfram.com/language/ref/ServiceRequest.html
        ///</summary>
        public static Engine ServiceRequest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ServiceRequest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the sine of z. 
        ///https://reference.wolfram.com/language/ref/Sin.html
        ///</summary>
        public static Engine Sin(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sin[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the sine of z. 
        ///https://reference.wolfram.com/language/ref/Sin.html
        ///</summary>
        public static Engine Sin(this Engine en, string? name = null)
        {
            return en.Execute("Sin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of possible spelling corrections for "word".
        ///https://reference.wolfram.com/language/ref/SpellingCorrectionList.html
        ///</summary>
        public static Engine SpellingCorrectionList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpellingCorrectionList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of possible spelling corrections for "word".
        ///https://reference.wolfram.com/language/ref/SpellingCorrectionList.html
        ///</summary>
        public static Engine SpellingCorrectionList(this Engine en, string? name = null)
        {
            return en.Execute("SpellingCorrectionList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a string of text corresponding to a spoken representation of the expression expr.
        ///https://reference.wolfram.com/language/ref/SpokenString.html
        ///</summary>
        public static Engine SpokenString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpokenString[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a string of text corresponding to a spoken representation of the expression expr.
        ///https://reference.wolfram.com/language/ref/SpokenString.html
        ///</summary>
        public static Engine SpokenString(this Engine en, string? name = null)
        {
            return en.Execute("SpokenString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr, starting a fresh evaluation stack. 
        ///https://reference.wolfram.com/language/ref/StackBegin.html
        ///</summary>
        public static Engine StackBegin(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StackBegin[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr, starting a fresh evaluation stack. 
        ///https://reference.wolfram.com/language/ref/StackBegin.html
        ///</summary>
        public static Engine StackBegin(this Engine en, string? name = null)
        {
            return en.Execute("StackBegin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///selects a subset of the SpatialPointData spdata according to crit.
        ///https://reference.wolfram.com/language/ref/SpatialPointSelect.html
        ///</summary>
        public static Engine SpatialPointSelect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SpatialPointSelect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the spatial median of the elements .
        ///https://reference.wolfram.com/language/ref/SpatialMedian.html
        ///</summary>
        public static Engine SpatialMedian(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpatialMedian[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the spatial median of the elements .
        ///https://reference.wolfram.com/language/ref/SpatialMedian.html
        ///</summary>
        public static Engine SpatialMedian(this Engine en, string? name = null)
        {
            return en.Execute("SpatialMedian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the right ascension of the local meridian for the current date and location.
        ///https://reference.wolfram.com/language/ref/SiderealTime.html
        ///</summary>
        public static Engine SiderealTime(this Engine en, string? name = null)
        {
            return en.Execute("SiderealTime[]", name);
        }

        ///<summary>
        ///represents a function that gives the shortest path from a source vertex s to target vertex t in a graph.
        ///https://reference.wolfram.com/language/ref/ShortestPathFunction.html
        ///</summary>
        public static Engine ShortestPathFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ShortestPathFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///connects the states of the systems model sys to the controller con and the outputs of con to the inputs of sys in feedback.
        ///https://reference.wolfram.com/language/ref/SystemsModelStateFeedbackConnect.html
        ///</summary>
        public static Engine SystemsModelStateFeedbackConnect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SystemsModelStateFeedbackConnect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if m is a square matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/SquareMatrixQ.html
        ///</summary>
        public static Engine SquareMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SquareMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m is a square matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/SquareMatrixQ.html
        ///</summary>
        public static Engine SquareMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("SquareMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Stieltjes constant . 
        ///https://reference.wolfram.com/language/ref/StieltjesGamma.html
        ///</summary>
        public static Engine StieltjesGamma(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StieltjesGamma[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Stieltjes constant . 
        ///https://reference.wolfram.com/language/ref/StieltjesGamma.html
        ///</summary>
        public static Engine StieltjesGamma(this Engine en, string? name = null)
        {
            return en.Execute("StieltjesGamma[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the spherical harmonic . 
        ///https://reference.wolfram.com/language/ref/SphericalHarmonicY.html
        ///</summary>
        public static Engine SphericalHarmonicY(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SphericalHarmonicY[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Shapiro–Wilk test.
        ///https://reference.wolfram.com/language/ref/ShapiroWilkTest.html
        ///</summary>
        public static Engine ShapiroWilkTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ShapiroWilkTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Shapiro–Wilk test.
        ///https://reference.wolfram.com/language/ref/ShapiroWilkTest.html
        ///</summary>
        public static Engine ShapiroWilkTest(this Engine en, string? name = null)
        {
            return en.Execute("ShapiroWilkTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays with expr formatted using the specified option settings. 
        ///https://reference.wolfram.com/language/ref/Style.html
        ///</summary>
        public static Engine Style(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Style[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a function generated by SpatialEstimate and predicts spatial field values from locations.
        ///https://reference.wolfram.com/language/ref/SpatialEstimatorFunction.html
        ///</summary>
        public static Engine SpatialEstimatorFunction(this Engine en, string? name = null)
        {
            return en.Execute("SpatialEstimatorFunction[]", name);
        }

        ///<summary>
        ///generates a list representing the evolution of the substitution system with the specified rule from initial condition init for t steps.
        ///https://reference.wolfram.com/language/ref/SubstitutionSystem.html
        ///</summary>
        public static Engine SubstitutionSystem(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SubstitutionSystem[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a setter button whose setting x is set to val when the button is clicked. The button is labeled with val, and appears pressed if the value of x is val, and unpressed otherwise.
        ///https://reference.wolfram.com/language/ref/Setter.html
        ///</summary>
        public static Engine Setter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Setter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the signature of the permutation needed to place the elements of list in canonical order. 
        ///https://reference.wolfram.com/language/ref/Signature.html
        ///</summary>
        public static Engine Signature(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Signature[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the signature of the permutation needed to place the elements of list in canonical order. 
        ///https://reference.wolfram.com/language/ref/Signature.html
        ///</summary>
        public static Engine Signature(this Engine en, string? name = null)
        {
            return en.Execute("Signature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a power series in the variable x about the point x0. The ai are the coefficients in the power series. The powers of (x-x0) that appear are nmin/den, (nmin+1)/den, …, nmax/den. 
        ///https://reference.wolfram.com/language/ref/SeriesData.html
        ///</summary>
        public static Engine SeriesData(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("SeriesData[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the derivative with respect to  of the radial spheroidal function  of the first kind.
        ///https://reference.wolfram.com/language/ref/SpheroidalS1Prime.html
        ///</summary>
        public static Engine SpheroidalS1Prime(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SpheroidalS1Prime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives -1, 0, or 1 depending on whether x is negative, zero, or positive. 
        ///https://reference.wolfram.com/language/ref/Sign.html
        ///</summary>
        public static Engine Sign(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sign[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives -1, 0, or 1 depending on whether x is negative, zero, or positive. 
        ///https://reference.wolfram.com/language/ref/Sign.html
        ///</summary>
        public static Engine Sign(this Engine en, string? name = null)
        {
            return en.Execute("Sign[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet where integer indicates the position at which a syntax error was detected in the input line.
        ///https://reference.wolfram.com/language/ref/SyntaxPacket.html
        ///</summary>
        public static Engine SyntaxPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SyntaxPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet where integer indicates the position at which a syntax error was detected in the input line.
        ///https://reference.wolfram.com/language/ref/SyntaxPacket.html
        ///</summary>
        public static Engine SyntaxPacket(this Engine en, string? name = null)
        {
            return en.Execute("SyntaxPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/ShortUpArrow.html
        ///</summary>
        public static Engine ShortUpArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ShortUpArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Skellam distribution with shape parameters μ1 and μ2.
        ///https://reference.wolfram.com/language/ref/SkellamDistribution.html
        ///</summary>
        public static Engine SkellamDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SkellamDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a skew-normal distribution with shape parameter α, location parameter μ, and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/SkewNormalDistribution.html
        ///</summary>
        public static Engine SkewNormalDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SkewNormalDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SquareSupersetEqual.html
        ///</summary>
        public static Engine SquareSupersetEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SquareSupersetEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Stratonovich process , where .
        ///https://reference.wolfram.com/language/ref/StratonovichProcess.html
        ///</summary>
        public static Engine StratonovichProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StratonovichProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a sequence of n omitted elements in an expression printed with Short or Shallow. The standard print form for Skeleton is n. 
        ///https://reference.wolfram.com/language/ref/Skeleton.html
        ///</summary>
        public static Engine Skeleton(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Skeleton[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a sequence of n omitted elements in an expression printed with Short or Shallow. The standard print form for Skeleton is n. 
        ///https://reference.wolfram.com/language/ref/Skeleton.html
        ///</summary>
        public static Engine Skeleton(this Engine en, string? name = null)
        {
            return en.Execute("Skeleton[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///recognizes speech in audio and returns it as a string.
        ///https://reference.wolfram.com/language/ref/SpeechRecognize.html
        ///</summary>
        public static Engine SpeechRecognize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SpeechRecognize[" + arg0 + "]", name);
        }

        ///<summary>
        ///recognizes speech in audio and returns it as a string.
        ///https://reference.wolfram.com/language/ref/SpeechRecognize.html
        ///</summary>
        public static Engine SpeechRecognize(this Engine en, string? name = null)
        {
            return en.Execute("SpeechRecognize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a sound primitive that represents a sound whose amplitude has levels ai sampled r times a second. 
        ///https://reference.wolfram.com/language/ref/SampledSoundList.html
        ///</summary>
        public static Engine SampledSoundList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SampledSoundList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///connects the systems models sys1 and sys2 in parallel.
        ///https://reference.wolfram.com/language/ref/SystemsModelParallelConnect.html
        ///</summary>
        public static Engine SystemsModelParallelConnect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SystemsModelParallelConnect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///or  gives the square root of z. 
        ///https://reference.wolfram.com/language/ref/Sqrt.html
        ///</summary>
        public static Engine Sqrt(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sqrt[" + arg0 + "]", name);
        }

        ///<summary>
        ///or  gives the square root of z. 
        ///https://reference.wolfram.com/language/ref/Sqrt.html
        ///</summary>
        public static Engine Sqrt(this Engine en, string? name = null)
        {
            return en.Execute("Sqrt[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///shows the current evaluation stack, giving a list of the tags associated with evaluations that are currently being done. 
        ///https://reference.wolfram.com/language/ref/Stack.html
        ///</summary>
        public static Engine Stack(this Engine en, string? name = null)
        {
            return en.Execute("Stack[]", name);
        }

        ///<summary>
        ///gives the list of independent components of an array of dimensions dims with the symmetry sym.
        ///https://reference.wolfram.com/language/ref/SymmetrizedIndependentComponents.html
        ///</summary>
        public static Engine SymmetrizedIndependentComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SymmetrizedIndependentComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the real-valued  root of x.
        ///https://reference.wolfram.com/language/ref/Surd.html
        ///</summary>
        public static Engine Surd(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Surd[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the simplex spanned by points pi.
        ///https://reference.wolfram.com/language/ref/Simplex.html
        ///</summary>
        public static Engine Simplex(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Simplex[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the simplex spanned by points pi.
        ///https://reference.wolfram.com/language/ref/Simplex.html
        ///</summary>
        public static Engine Simplex(this Engine en, string? name = null)
        {
            return en.Execute("Simplex[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the minimum distance from the point p to the region reg if p is outside the region and the minimum distance to the complement of reg if p is inside the region.
        ///https://reference.wolfram.com/language/ref/SignedRegionDistance.html
        ///</summary>
        public static Engine SignedRegionDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SignedRegionDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the k elementary symmetric polynomial in the variables x1,…,xn.
        ///https://reference.wolfram.com/language/ref/SymmetricPolynomial.html
        ///</summary>
        public static Engine SymmetricPolynomial(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SymmetricPolynomial[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a slider with setting x in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/Slider.html
        ///</summary>
        public static Engine Slider(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Slider[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a slider with setting x in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/Slider.html
        ///</summary>
        public static Engine Slider(this Engine en, string? name = null)
        {
            return en.Execute("Slider[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Stirling number of the second kind . 
        ///https://reference.wolfram.com/language/ref/StirlingS2.html
        ///</summary>
        public static Engine StirlingS2(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StirlingS2[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Strauss point process with constant intensity μ, interaction parameter γ and interaction radius rs in d.
        ///https://reference.wolfram.com/language/ref/StraussPointProcess.html
        ///</summary>
        public static Engine StraussPointProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("StraussPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///generates a contour plot of f over the slice surface surf as a function of x, y, and z.
        ///https://reference.wolfram.com/language/ref/SliceContourPlot3D.html
        ///</summary>
        public static Engine SliceContourPlot3D(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("SliceContourPlot3D[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents a Strauss hardcore point process with constant intensity μ, interaction parameter γ, hard-core interaction radius rh and Strauss interaction radius rs in .
        ///https://reference.wolfram.com/language/ref/StraussHardcorePointProcess.html
        ///</summary>
        public static Engine StraussHardcorePointProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("StraussHardcorePointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///evaluates expr, then compares it with each of the formi in turn, evaluating and returning the valuei corresponding to the first match found. 
        ///https://reference.wolfram.com/language/ref/Switch.html
        ///</summary>
        public static Engine Switch(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("Switch[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the stationary wavelet transform (SWT) of an array of data.
        ///https://reference.wolfram.com/language/ref/StationaryWaveletTransform.html
        ///</summary>
        public static Engine StationaryWaveletTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StationaryWaveletTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the stationary wavelet transform (SWT) of an array of data.
        ///https://reference.wolfram.com/language/ref/StationaryWaveletTransform.html
        ///</summary>
        public static Engine StationaryWaveletTransform(this Engine en, string? name = null)
        {
            return en.Execute("StationaryWaveletTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///linearizes the AffineStateSpaceModel asys by state transformation.
        ///https://reference.wolfram.com/language/ref/StateTransformationLinearize.html
        ///</summary>
        public static Engine StateTransformationLinearize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StateTransformationLinearize[" + arg0 + "]", name);
        }

        ///<summary>
        ///linearizes the AffineStateSpaceModel asys by state transformation.
        ///https://reference.wolfram.com/language/ref/StateTransformationLinearize.html
        ///</summary>
        public static Engine StateTransformationLinearize(this Engine en, string? name = null)
        {
            return en.Execute("StateTransformationLinearize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the time of the next sunrise for the current date and location.
        ///https://reference.wolfram.com/language/ref/Sunrise.html
        ///</summary>
        public static Engine Sunrise(this Engine en, string? name = null)
        {
            return en.Execute("Sunrise[]", name);
        }

        ///<summary>
        ///plots points with values vi at a sequence of dates.
        ///https://reference.wolfram.com/language/ref/StackedDateListPlot.html
        ///</summary>
        public static Engine StackedDateListPlot(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StackedDateListPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the star graph with n vertices .
        ///https://reference.wolfram.com/language/ref/StarGraph.html
        ///</summary>
        public static Engine StarGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StarGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the star graph with n vertices .
        ///https://reference.wolfram.com/language/ref/StarGraph.html
        ///</summary>
        public static Engine StarGraph(this Engine en, string? name = null)
        {
            return en.Execute("StarGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a stadium of radius r between the points {x1,y1} and {x2,y2}.
        ///https://reference.wolfram.com/language/ref/StadiumShape.html
        ///</summary>
        public static Engine StadiumShape(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StadiumShape[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents simulation data from functions such as SystemModelSimulate etc. 
        ///https://reference.wolfram.com/language/ref/SystemModelSimulationData.html
        ///</summary>
        public static Engine SystemModelSimulationData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemModelSimulationData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents simulation data from functions such as SystemModelSimulate etc. 
        ///https://reference.wolfram.com/language/ref/SystemModelSimulationData.html
        ///</summary>
        public static Engine SystemModelSimulationData(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelSimulationData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x===y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/SameAs.html
        ///</summary>
        public static Engine SameAs(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SameAs[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x===y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/SameAs.html
        ///</summary>
        public static Engine SameAs(this Engine en, string? name = null)
        {
            return en.Execute("SameAs[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the symmetry of a tensor that is symmetric in the slots si.
        ///https://reference.wolfram.com/language/ref/Symmetric.html
        ///</summary>
        public static Engine Symmetric(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Symmetric[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the symmetry of a tensor that is symmetric in the slots si.
        ///https://reference.wolfram.com/language/ref/Symmetric.html
        ///</summary>
        public static Engine Symmetric(this Engine en, string? name = null)
        {
            return en.Execute("Symmetric[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a survival model for event times ei.
        ///https://reference.wolfram.com/language/ref/SurvivalModelFit.html
        ///</summary>
        public static Engine SurvivalModelFit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SurvivalModelFit[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a survival model for event times ei.
        ///https://reference.wolfram.com/language/ref/SurvivalModelFit.html
        ///</summary>
        public static Engine SurvivalModelFit(this Engine en, string? name = null)
        {
            return en.Execute("SurvivalModelFit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a vector plot of the field {vx,vy,vz} over the slice surface surf. 
        ///https://reference.wolfram.com/language/ref/SliceVectorPlot3D.html
        ///</summary>
        public static Engine SliceVectorPlot3D(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("SliceVectorPlot3D[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/ShortLeftArrow.html
        ///</summary>
        public static Engine ShortLeftArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ShortLeftArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the Shannon wavelet evaluated on the equally spaced interval {-10,10}. 
        ///https://reference.wolfram.com/language/ref/ShannonWavelet.html
        ///</summary>
        public static Engine ShannonWavelet(this Engine en, string? name = null)
        {
            return en.Execute("ShannonWavelet[]", name);
        }

        ///<summary>
        ///gives a sharpened version of image.
        ///https://reference.wolfram.com/language/ref/Sharpen.html
        ///</summary>
        public static Engine Sharpen(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sharpen[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a sharpened version of image.
        ///https://reference.wolfram.com/language/ref/Sharpen.html
        ///</summary>
        public static Engine Sharpen(this Engine en, string? name = null)
        {
            return en.Execute("Sharpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a setter bar with setting x and with setter buttons for values vali.
        ///https://reference.wolfram.com/language/ref/SetterBar.html
        ///</summary>
        public static Engine SetterBar(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetterBar[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a stream plot of the vector field {vx,vy} as a function of x and y. 
        ///https://reference.wolfram.com/language/ref/StreamPlot.html
        ///</summary>
        public static Engine StreamPlot(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StreamPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///connects the outputs from sys to the inputs with negative feedback. 
        ///https://reference.wolfram.com/language/ref/SystemsModelFeedbackConnect.html
        ///</summary>
        public static Engine SystemsModelFeedbackConnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemsModelFeedbackConnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///connects the outputs from sys to the inputs with negative feedback. 
        ///https://reference.wolfram.com/language/ref/SystemsModelFeedbackConnect.html
        ///</summary>
        public static Engine SystemsModelFeedbackConnect(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelFeedbackConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes the subsystem of the systems model sys associated with inputs at position ini.
        ///https://reference.wolfram.com/language/ref/SystemsModelDelete.html
        ///</summary>
        public static Engine SystemsModelDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SystemsModelDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an entity class containing n entities from class.
        ///https://reference.wolfram.com/language/ref/SampledEntityClass.html
        ///</summary>
        public static Engine SampledEntityClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SampledEntityClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes the notebook corresponding to obj be the currently selected one in the front end.
        ///https://reference.wolfram.com/language/ref/SetSelectedNotebook.html
        ///</summary>
        public static Engine SetSelectedNotebook(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SetSelectedNotebook[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes the notebook corresponding to obj be the currently selected one in the front end.
        ///https://reference.wolfram.com/language/ref/SetSelectedNotebook.html
        ///</summary>
        public static Engine SetSelectedNotebook(this Engine en, string? name = null)
        {
            return en.Execute("SetSelectedNotebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Square.html
        ///</summary>
        public static Engine Square(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Square[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Square.html
        ///</summary>
        public static Engine Square(this Engine en, string? name = null)
        {
            return en.Execute("Square[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the vector-relative orders of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelVectorRelativeOrders.html
        ///</summary>
        public static Engine SystemsModelVectorRelativeOrders(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemsModelVectorRelativeOrders[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the vector-relative orders of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelVectorRelativeOrders.html
        ///</summary>
        public static Engine SystemsModelVectorRelativeOrders(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelVectorRelativeOrders[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a representation of the model "model", usable as input to other functions.
        ///https://reference.wolfram.com/language/ref/SystemModel.html
        ///</summary>
        public static Engine SystemModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a representation of the model "model", usable as input to other functions.
        ///https://reference.wolfram.com/language/ref/SystemModel.html
        ///</summary>
        public static Engine SystemModel(this Engine en, string? name = null)
        {
            return en.Execute("SystemModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the value of the property at the specified geometrical altitude for the chosen model of the standard Earth atmosphere.
        ///https://reference.wolfram.com/language/ref/StandardAtmosphereData.html
        ///</summary>
        public static Engine StandardAtmosphereData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StandardAtmosphereData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces missing values in each example by generated values.
        ///https://reference.wolfram.com/language/ref/SynthesizeMissingValues.html
        ///</summary>
        public static Engine SynthesizeMissingValues(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SynthesizeMissingValues[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces missing values in each example by generated values.
        ///https://reference.wolfram.com/language/ref/SynthesizeMissingValues.html
        ///</summary>
        public static Engine SynthesizeMissingValues(this Engine en, string? name = null)
        {
            return en.Execute("SynthesizeMissingValues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the sine integral function ). 
        ///https://reference.wolfram.com/language/ref/SinIntegral.html
        ///</summary>
        public static Engine SinIntegral(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SinIntegral[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the sine integral function ). 
        ///https://reference.wolfram.com/language/ref/SinIntegral.html
        ///</summary>
        public static Engine SinIntegral(this Engine en, string? name = null)
        {
            return en.Execute("SinIntegral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///shows graphics with the specified options added. 
        ///https://reference.wolfram.com/language/ref/Show.html
        ///</summary>
        public static Engine Show(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Show[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///simulates model according to experiment settings.
        ///https://reference.wolfram.com/language/ref/SystemModelSimulate.html
        ///</summary>
        public static Engine SystemModelSimulate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemModelSimulate[" + arg0 + "]", name);
        }

        ///<summary>
        ///simulates model according to experiment settings.
        ///https://reference.wolfram.com/language/ref/SystemModelSimulate.html
        ///</summary>
        public static Engine SystemModelSimulate(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelSimulate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SquareUnion.html
        ///</summary>
        public static Engine SquareUnion(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SquareUnion[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the radial spheroidal function  of the second kind.
        ///https://reference.wolfram.com/language/ref/SpheroidalS2.html
        ///</summary>
        public static Engine SpheroidalS2(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SpheroidalS2[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///tests whether the median of data is zero. 
        ///https://reference.wolfram.com/language/ref/SignTest.html
        ///</summary>
        public static Engine SignTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SignTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the median of data is zero. 
        ///https://reference.wolfram.com/language/ref/SignTest.html
        ///</summary>
        public static Engine SignTest(this Engine en, string? name = null)
        {
            return en.Execute("SignTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives . 
        ///https://reference.wolfram.com/language/ref/Sinc.html
        ///</summary>
        public static Engine Sinc(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sinc[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives . 
        ///https://reference.wolfram.com/language/ref/Sinc.html
        ///</summary>
        public static Engine Sinc(this Engine en, string? name = null)
        {
            return en.Execute("Sinc[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a shifted Gompertz distribution with scale parameter λ and shape parameter ξ.
        ///https://reference.wolfram.com/language/ref/ShiftedGompertzDistribution.html
        ///</summary>
        public static Engine ShiftedGompertzDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ShiftedGompertzDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the singular value decomposition for a numerical matrix m as a list of matrices {u,σ,v}, where σ is a diagonal matrix and m can be written as u.σ.ConjugateTranspose[v]. 
        ///https://reference.wolfram.com/language/ref/SingularValueDecomposition.html
        ///</summary>
        public static Engine SingularValueDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SingularValueDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the singular value decomposition for a numerical matrix m as a list of matrices {u,σ,v}, where σ is a diagonal matrix and m can be written as u.σ.ConjugateTranspose[v]. 
        ///https://reference.wolfram.com/language/ref/SingularValueDecomposition.html
        ///</summary>
        public static Engine SingularValueDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("SingularValueDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///skips one object of the specified type in an input stream. 
        ///https://reference.wolfram.com/language/ref/Skip.html
        ///</summary>
        public static Engine Skip(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Skip[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the symmetric difference of the lists listi.
        ///https://reference.wolfram.com/language/ref/SymmetricDifference.html
        ///</summary>
        public static Engine SymmetricDifference(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SymmetricDifference[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list of keys in secure storage that match patt.
        ///https://reference.wolfram.com/language/ref/SystemCredentialKeys.html
        ///</summary>
        public static Engine SystemCredentialKeys(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemCredentialKeys[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of keys in secure storage that match patt.
        ///https://reference.wolfram.com/language/ref/SystemCredentialKeys.html
        ///</summary>
        public static Engine SystemCredentialKeys(this Engine en, string? name = null)
        {
            return en.Execute("SystemCredentialKeys[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Siegel theta function  with Riemann modular matrix Ω and vector s.
        ///https://reference.wolfram.com/language/ref/SiegelTheta.html
        ///</summary>
        public static Engine SiegelTheta(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SiegelTheta[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the skeleton transform of image, in which the value of each skeleton pixel is its distance to the nearest background pixel.
        ///https://reference.wolfram.com/language/ref/SkeletonTransform.html
        ///</summary>
        public static Engine SkeletonTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SkeletonTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the skeleton transform of image, in which the value of each skeleton pixel is its distance to the nearest background pixel.
        ///https://reference.wolfram.com/language/ref/SkeletonTransform.html
        ///</summary>
        public static Engine SkeletonTransform(this Engine en, string? name = null)
        {
            return en.Execute("SkeletonTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive specifying that objects that follow are to be drawn using small dots.
        ///https://reference.wolfram.com/language/ref/StippleShading.html
        ///</summary>
        public static Engine StippleShading(this Engine en, string? name = null)
        {
            return en.Execute("StippleShading[]", name);
        }

        ///<summary>
        ///represents the stationary distribution of the process proc, when it exists. 
        ///https://reference.wolfram.com/language/ref/StationaryDistribution.html
        ///</summary>
        public static Engine StationaryDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StationaryDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the stationary distribution of the process proc, when it exists. 
        ///https://reference.wolfram.com/language/ref/StationaryDistribution.html
        ///</summary>
        public static Engine StationaryDistribution(this Engine en, string? name = null)
        {
            return en.Execute("StationaryDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a time delay of δ in a StateSpaceModel or TransferFunctionModel.
        ///https://reference.wolfram.com/language/ref/SystemsModelDelay.html
        ///</summary>
        public static Engine SystemsModelDelay(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemsModelDelay[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a time delay of δ in a StateSpaceModel or TransferFunctionModel.
        ///https://reference.wolfram.com/language/ref/SystemsModelDelay.html
        ///</summary>
        public static Engine SystemsModelDelay(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelDelay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///executes an external program, yielding a ProcessObject to represent the resulting subprocess.
        ///https://reference.wolfram.com/language/ref/StartProcess.html
        ///</summary>
        public static Engine StartProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StartProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///executes an external program, yielding a ProcessObject to represent the resulting subprocess.
        ///https://reference.wolfram.com/language/ref/StartProcess.html
        ///</summary>
        public static Engine StartProcess(this Engine en, string? name = null)
        {
            return en.Execute("StartProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a 2D slider with settings x and y in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/Slider2D.html
        ///</summary>
        public static Engine Slider2D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Slider2D[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a 2D slider with settings x and y in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/Slider2D.html
        ///</summary>
        public static Engine Slider2D(this Engine en, string? name = null)
        {
            return en.Execute("Slider2D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the matrix corresponding to shearing by θ radians along the direction of the vector v, and normal to the vector n. 
        ///https://reference.wolfram.com/language/ref/ShearingMatrix.html
        ///</summary>
        public static Engine ShearingMatrix(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ShearingMatrix[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the coefficient of skewness for the elements in list.
        ///https://reference.wolfram.com/language/ref/Skewness.html
        ///</summary>
        public static Engine Skewness(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Skewness[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the coefficient of skewness for the elements in list.
        ///https://reference.wolfram.com/language/ref/Skewness.html
        ///</summary>
        public static Engine Skewness(this Engine en, string? name = null)
        {
            return en.Execute("Skewness[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a square array of elements of type spec in an interpreter, API or form specification.
        ///https://reference.wolfram.com/language/ref/SquareRepeatingElement.html
        ///</summary>
        public static Engine SquareRepeatingElement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SquareRepeatingElement[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a square array of elements of type spec in an interpreter, API or form specification.
        ///https://reference.wolfram.com/language/ref/SquareRepeatingElement.html
        ///</summary>
        public static Engine SquareRepeatingElement(this Engine en, string? name = null)
        {
            return en.Execute("SquareRepeatingElement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the thermodynamic properties of seawater for the specified parameters.
        ///https://reference.wolfram.com/language/ref/StandardOceanData.html
        ///</summary>
        public static Engine StandardOceanData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StandardOceanData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the thermodynamic properties of seawater for the specified parameters.
        ///https://reference.wolfram.com/language/ref/StandardOceanData.html
        ///</summary>
        public static Engine StandardOceanData(this Engine en, string? name = null)
        {
            return en.Execute("StandardOceanData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///connects systems models sys1 and sys2 in series. 
        ///https://reference.wolfram.com/language/ref/SystemsModelSeriesConnect.html
        ///</summary>
        public static Engine SystemsModelSeriesConnect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SystemsModelSeriesConnect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specific property for the substance for the specified particle and the energy of that particle.
        ///https://reference.wolfram.com/language/ref/StoppingPowerData.html
        ///</summary>
        public static Engine StoppingPowerData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("StoppingPowerData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the number of inputs and outputs of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelDimensions.html
        ///</summary>
        public static Engine SystemsModelDimensions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemsModelDimensions[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of inputs and outputs of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelDimensions.html
        ///</summary>
        public static Engine SystemsModelDimensions(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelDimensions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots lines for each of the datai, with the i curve being the accumulation of values in data1 through datai.
        ///https://reference.wolfram.com/language/ref/StackedListPlot.html
        ///</summary>
        public static Engine StackedListPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StackedListPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots lines for each of the datai, with the i curve being the accumulation of values in data1 through datai.
        ///https://reference.wolfram.com/language/ref/StackedListPlot.html
        ///</summary>
        public static Engine StackedListPlot(this Engine en, string? name = null)
        {
            return en.Execute("StackedListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///performs a sequence of algebraic and other transformations on expr and returns the simplest form it finds. 
        ///https://reference.wolfram.com/language/ref/Simplify.html
        ///</summary>
        public static Engine Simplify(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Simplify[" + arg0 + "]", name);
        }

        ///<summary>
        ///performs a sequence of algebraic and other transformations on expr and returns the simplest form it finds. 
        ///https://reference.wolfram.com/language/ref/Simplify.html
        ///</summary>
        public static Engine Simplify(this Engine en, string? name = null)
        {
            return en.Execute("Simplify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a density plot of f over the slice surface surf as a function of x, y, and z.
        ///https://reference.wolfram.com/language/ref/SliceDensityPlot3D.html
        ///</summary>
        public static Engine SliceDensityPlot3D(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("SliceDensityPlot3D[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///plots streamlines for the vector field {vx,vy,vz} as functions of x, y and z.
        ///https://reference.wolfram.com/language/ref/StreamPlot3D.html
        ///</summary>
        public static Engine StreamPlot3D(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("StreamPlot3D[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the sample standard deviation of the elements in list. 
        ///https://reference.wolfram.com/language/ref/StandardDeviation.html
        ///</summary>
        public static Engine StandardDeviation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StandardDeviation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the sample standard deviation of the elements in list. 
        ///https://reference.wolfram.com/language/ref/StandardDeviation.html
        ///</summary>
        public static Engine StandardDeviation(this Engine en, string? name = null)
        {
            return en.Execute("StandardDeviation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pair of polynomials  in  such that , where  is the symmetric part and  is the remainder.
        ///https://reference.wolfram.com/language/ref/SymmetricReduction.html
        ///</summary>
        public static Engine SymmetricReduction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SymmetricReduction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays string in the status area of the current notebook when the mouse pointer is in the region where expr appears. 
        ///https://reference.wolfram.com/language/ref/StatusArea.html
        ///</summary>
        public static Engine StatusArea(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StatusArea[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a credential store.
        ///https://reference.wolfram.com/language/ref/SystemCredentialStoreObject.html
        ///</summary>
        public static Engine SystemCredentialStoreObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemCredentialStoreObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a credential store.
        ///https://reference.wolfram.com/language/ref/SystemCredentialStoreObject.html
        ///</summary>
        public static Engine SystemCredentialStoreObject(this Engine en, string? name = null)
        {
            return en.Execute("SystemCredentialStoreObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///starts SystemModeler. 
        ///https://reference.wolfram.com/language/ref/SystemModeler.html
        ///</summary>
        public static Engine SystemModeler(this Engine en, string? name = null)
        {
            return en.Execute("SystemModeler[]", name);
        }

        ///<summary>
        ///gives the values of the Racah 6‐ symbol. 
        ///https://reference.wolfram.com/language/ref/SixJSymbol.html
        ///</summary>
        public static Engine SixJSymbol(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SixJSymbol[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Singh–Maddala distribution with shape parameters q and a and scale parameter b.
        ///https://reference.wolfram.com/language/ref/SinghMaddalaDistribution.html
        ///</summary>
        public static Engine SinghMaddalaDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SinghMaddalaDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///transforms the state-space model sys using the matrices p and q. 
        ///https://reference.wolfram.com/language/ref/StateSpaceTransform.html
        ///</summary>
        public static Engine StateSpaceTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StateSpaceTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///opens the specified file, URL, or other target with the associated program on your computer system.
        ///https://reference.wolfram.com/language/ref/SystemOpen.html
        ///</summary>
        public static Engine SystemOpen(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemOpen[" + arg0 + "]", name);
        }

        ///<summary>
        ///opens the specified file, URL, or other target with the associated program on your computer system.
        ///https://reference.wolfram.com/language/ref/SystemOpen.html
        ///</summary>
        public static Engine SystemOpen(this Engine en, string? name = null)
        {
            return en.Execute("SystemOpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the squared Euclidean distance between vectors u and v.
        ///https://reference.wolfram.com/language/ref/SquaredEuclideanDistance.html
        ///</summary>
        public static Engine SquaredEuclideanDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SquaredEuclideanDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a complete maximum-length sequence for a size n linear-feedback shift register.
        ///https://reference.wolfram.com/language/ref/ShiftRegisterSequence.html
        ///</summary>
        public static Engine ShiftRegisterSequence(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ShiftRegisterSequence[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a complete maximum-length sequence for a size n linear-feedback shift register.
        ///https://reference.wolfram.com/language/ref/ShiftRegisterSequence.html
        ///</summary>
        public static Engine ShiftRegisterSequence(this Engine en, string? name = null)
        {
            return en.Execute("ShiftRegisterSequence[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///declares the symbols fi as shared functions whose downvalues are synchronized among all parallel kernels.
        ///https://reference.wolfram.com/language/ref/SetSharedFunction.html
        ///</summary>
        public static Engine SetSharedFunction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SetSharedFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a sound primitive that represents a sound whose amplitude sampled r times a second is generated by applying the function f to successive integers from 1 to n. 
        ///https://reference.wolfram.com/language/ref/SampledSoundFunction.html
        ///</summary>
        public static Engine SampledSoundFunction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SampledSoundFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a seasonal integrated autoregressive moving-average process with ARIMA coefficients ai, d, and bj; seasonal order s; seasonal ARIMA coefficients αi, δ, and βj; seasonal integration order δ; and normal white noise with variance v.
        ///https://reference.wolfram.com/language/ref/SARIMAProcess.html
        ///</summary>
        public static Engine SARIMAProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SARIMAProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the Stirling number of the first kind . 
        ///https://reference.wolfram.com/language/ref/StirlingS1.html
        ///</summary>
        public static Engine StirlingS1(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StirlingS1[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the number of ways  to represent the integer n as a sum of d squares.
        ///https://reference.wolfram.com/language/ref/SquaresR.html
        ///</summary>
        public static Engine SquaresR(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SquaresR[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the symmetric group of degree n.
        ///https://reference.wolfram.com/language/ref/SymmetricGroup.html
        ///</summary>
        public static Engine SymmetricGroup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SymmetricGroup[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the symmetric group of degree n.
        ///https://reference.wolfram.com/language/ref/SymmetricGroup.html
        ///</summary>
        public static Engine SymmetricGroup(this Engine en, string? name = null)
        {
            return en.Execute("SymmetricGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the stationary wavelet packet transform (SWPT) of an array of data.
        ///https://reference.wolfram.com/language/ref/StationaryWaveletPacketTransform.html
        ///</summary>
        public static Engine StationaryWaveletPacketTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StationaryWaveletPacketTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the stationary wavelet packet transform (SWPT) of an array of data.
        ///https://reference.wolfram.com/language/ref/StationaryWaveletPacketTransform.html
        ///</summary>
        public static Engine StationaryWaveletPacketTransform(this Engine en, string? name = null)
        {
            return en.Execute("StationaryWaveletPacketTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the derivative with respect to  of the radial spheroidal function  of the second kind.
        ///https://reference.wolfram.com/language/ref/SpheroidalS2Prime.html
        ///</summary>
        public static Engine SpheroidalS2Prime(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("SpheroidalS2Prime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a list of the nonzero singular values of a matrix m. 
        ///https://reference.wolfram.com/language/ref/SingularValueList.html
        ///</summary>
        public static Engine SingularValueList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SingularValueList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the nonzero singular values of a matrix m. 
        ///https://reference.wolfram.com/language/ref/SingularValueList.html
        ///</summary>
        public static Engine SingularValueList(this Engine en, string? name = null)
        {
            return en.Execute("SingularValueList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the distribution of the process state at time t.
        ///https://reference.wolfram.com/language/ref/SliceDistribution.html
        ///</summary>
        public static Engine SliceDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SliceDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a slider with setting x in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/SliderBox.html
        ///</summary>
        public static Engine SliderBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SliderBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a slider with setting x in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/SliderBox.html
        ///</summary>
        public static Engine SliderBox(this Engine en, string? name = null)
        {
            return en.Execute("SliderBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the standard deviations of the values in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/StandardDeviationFilter.html
        ///</summary>
        public static Engine StandardDeviationFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StandardDeviationFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the symmetrization of tensor under the symmetry sym.
        ///https://reference.wolfram.com/language/ref/Symmetrize.html
        ///</summary>
        public static Engine Symmetrize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Symmetrize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///starts a web session and returns a web session object.
        ///https://reference.wolfram.com/language/ref/StartWebSession.html
        ///</summary>
        public static Engine StartWebSession(this Engine en, string? name = null)
        {
            return en.Execute("StartWebSession[]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents a shear by θ radians along the direction of the vector v, normal to the vector n, and keeping the origin fixed.
        ///https://reference.wolfram.com/language/ref/ShearingTransform.html
        ///</summary>
        public static Engine ShearingTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ShearingTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of status centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/StatusCentrality.html
        ///</summary>
        public static Engine StatusCentrality(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("StatusCentrality[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of status centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/StatusCentrality.html
        ///</summary>
        public static Engine StatusCentrality(this Engine en, string? name = null)
        {
            return en.Execute("StatusCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the surface area of the three-dimensional region reg.
        ///https://reference.wolfram.com/language/ref/SurfaceArea.html
        ///</summary>
        public static Engine SurfaceArea(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SurfaceArea[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the surface area of the three-dimensional region reg.
        ///https://reference.wolfram.com/language/ref/SurfaceArea.html
        ///</summary>
        public static Engine SurfaceArea(this Engine en, string? name = null)
        {
            return en.Execute("SurfaceArea[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///brings up an interactive system dialog and returns the value chosen in the dialog. 
        ///https://reference.wolfram.com/language/ref/SystemDialogInput.html
        ///</summary>
        public static Engine SystemDialogInput(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemDialogInput[" + arg0 + "]", name);
        }

        ///<summary>
        ///brings up an interactive system dialog and returns the value chosen in the dialog. 
        ///https://reference.wolfram.com/language/ref/SystemDialogInput.html
        ///</summary>
        public static Engine SystemDialogInput(this Engine en, string? name = null)
        {
            return en.Execute("SystemDialogInput[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the current setting for the internal system option with the specified name.
        ///https://reference.wolfram.com/language/ref/SystemOptions.html
        ///</summary>
        public static Engine SystemOptions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemOptions[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the current setting for the internal system option with the specified name.
        ///https://reference.wolfram.com/language/ref/SystemOptions.html
        ///</summary>
        public static Engine SystemOptions(this Engine en, string? name = null)
        {
            return en.Execute("SystemOptions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as a short form of expr, less than about one line long. 
        ///https://reference.wolfram.com/language/ref/Short.html
        ///</summary>
        public static Engine Short(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Short[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as a short form of expr, less than about one line long. 
        ///https://reference.wolfram.com/language/ref/Short.html
        ///</summary>
        public static Engine Short(this Engine en, string? name = null)
        {
            return en.Execute("Short[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a stream plot of the vector field {vx,vy} as a function of x and y, superimposed on a background density plot of the scalar field s. 
        ///https://reference.wolfram.com/language/ref/StreamDensityPlot.html
        ///</summary>
        public static Engine StreamDensityPlot(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("StreamDensityPlot[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the linearity of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelLinearity.html
        ///</summary>
        public static Engine SystemsModelLinearity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemsModelLinearity[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the linearity of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelLinearity.html
        ///</summary>
        public static Engine SystemsModelLinearity(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelLinearity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is a square-free polynomial or number, and False otherwise.
        ///https://reference.wolfram.com/language/ref/SquareFreeQ.html
        ///</summary>
        public static Engine SquareFreeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SquareFreeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a square-free polynomial or number, and False otherwise.
        ///https://reference.wolfram.com/language/ref/SquareFreeQ.html
        ///</summary>
        public static Engine SquareFreeQ(this Engine en, string? name = null)
        {
            return en.Execute("SquareFreeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///declares the symbols si as shared variables whose values are synchronized among all parallel kernels.
        ///https://reference.wolfram.com/language/ref/SetSharedVariable.html
        ///</summary>
        public static Engine SetSharedVariable(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SetSharedVariable[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the underlying simple graph from the graph g.
        ///https://reference.wolfram.com/language/ref/SimpleGraph.html
        ///</summary>
        public static Engine SimpleGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SimpleGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the underlying simple graph from the graph g.
        ///https://reference.wolfram.com/language/ref/SimpleGraph.html
        ///</summary>
        public static Engine SimpleGraph(this Engine en, string? name = null)
        {
            return en.Execute("SimpleGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SquareSubset.html
        ///</summary>
        public static Engine SquareSubset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SquareSubset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents all the information needed for encryption, decryption, and other operations in a symmetric cryptographic system.
        ///https://reference.wolfram.com/language/ref/SymmetricKey.html
        ///</summary>
        public static Engine SymmetricKey(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SymmetricKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents all the information needed for encryption, decryption, and other operations in a symmetric cryptographic system.
        ///https://reference.wolfram.com/language/ref/SymmetricKey.html
        ///</summary>
        public static Engine SymmetricKey(this Engine en, string? name = null)
        {
            return en.Execute("SymmetricKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a plot of the singular values of the transfer function for the system lsys. 
        ///https://reference.wolfram.com/language/ref/SingularValuePlot.html
        ///</summary>
        public static Engine SingularValuePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SingularValuePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot of the singular values of the transfer function for the system lsys. 
        ///https://reference.wolfram.com/language/ref/SingularValuePlot.html
        ///</summary>
        public static Engine SingularValuePlot(this Engine en, string? name = null)
        {
            return en.Execute("SingularValuePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an expression that will automatically be spliced into any list in which it appears as the sequence of elements ei. 
        ///https://reference.wolfram.com/language/ref/Splice.html
        ///</summary>
        public static Engine Splice(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Splice[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an expression that will automatically be spliced into any list in which it appears as the sequence of elements ei. 
        ///https://reference.wolfram.com/language/ref/Splice.html
        ///</summary>
        public static Engine Splice(this Engine en, string? name = null)
        {
            return en.Execute("Splice[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields an array of dimensions dims whose entries are given by those in the rules posivali or through the symmetry sym.
        ///https://reference.wolfram.com/language/ref/SymmetrizedArray.html
        ///</summary>
        public static Engine SymmetrizedArray(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SymmetrizedArray[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/ShortDownArrow.html
        ///</summary>
        public static Engine ShortDownArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ShortDownArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the state feedback gains for the system specification sspec to place its closed-loop poles at pi.
        ///https://reference.wolfram.com/language/ref/StateFeedbackGains.html
        ///</summary>
        public static Engine StateFeedbackGains(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StateFeedbackGains[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the surface entity.
        ///https://reference.wolfram.com/language/ref/SurfaceData.html
        ///</summary>
        public static Engine SurfaceData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SurfaceData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///merges the systems models sysj. 
        ///https://reference.wolfram.com/language/ref/SystemsModelMerge.html
        ///</summary>
        public static Engine SystemsModelMerge(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemsModelMerge[" + arg0 + "]", name);
        }

        ///<summary>
        ///merges the systems models sysj. 
        ///https://reference.wolfram.com/language/ref/SystemsModelMerge.html
        ///</summary>
        public static Engine SystemsModelMerge(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelMerge[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a dataset of information about processes that you are running on your computer system.
        ///https://reference.wolfram.com/language/ref/SystemProcessData.html
        ///</summary>
        public static Engine SystemProcessData(this Engine en, string? name = null)
        {
            return en.Execute("SystemProcessData[]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/SquareSubsetEqual.html
        ///</summary>
        public static Engine SquareSubsetEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("SquareSubsetEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///sets the current point in an open stream. 
        ///https://reference.wolfram.com/language/ref/SetStreamPosition.html
        ///</summary>
        public static Engine SetStreamPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("SetStreamPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a simple graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimpleGraphQ.html
        ///</summary>
        public static Engine SimpleGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SimpleGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a simple graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimpleGraphQ.html
        ///</summary>
        public static Engine SimpleGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("SimpleGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic sine of z. 
        ///https://reference.wolfram.com/language/ref/Sinh.html
        ///</summary>
        public static Engine Sinh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Sinh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic sine of z. 
        ///https://reference.wolfram.com/language/ref/Sinh.html
        ///</summary>
        public static Engine Sinh(this Engine en, string? name = null)
        {
            return en.Execute("Sinh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///constructs an estimator for the StateSpaceModel ssm, with estimator gain matrix l.
        ///https://reference.wolfram.com/language/ref/StateOutputEstimator.html
        ///</summary>
        public static Engine StateOutputEstimator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("StateOutputEstimator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of processes that you are running on your computer system.
        ///https://reference.wolfram.com/language/ref/SystemProcesses.html
        ///</summary>
        public static Engine SystemProcesses(this Engine en, string? name = null)
        {
            return en.Execute("SystemProcesses[]", name);
        }

        ///<summary>
        ///gives the order of the state-space model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelOrder.html
        ///</summary>
        public static Engine SystemsModelOrder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("SystemsModelOrder[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the order of the state-space model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelOrder.html
        ///</summary>
        public static Engine SystemsModelOrder(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelOrder[" + en.ValidNames.Last() + "]", name);
        }


    }
}
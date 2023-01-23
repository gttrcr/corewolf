namespace NetWolf
{
    public static class ExtendedSymbolsV
    {
        ///<summary>
        ///gives True if a value has been defined for expr, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/ValueQ.html
        ///</summary>
        public static Engine ValueQ(this Engine en, string? name = null)
        {
            return en.Execute("ValueQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the vali in a list of rules.
        ///https://reference.wolfram.com/language/ref/Values.html
        ///</summary>
        public static Engine Values(this Engine en, string? name = null)
        {
            return en.Execute("Values[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of all independent variables in a polynomial.
        ///https://reference.wolfram.com/language/ref/Variables.html
        ///</summary>
        public static Engine Variables(this Engine en, string? name = null)
        {
            return en.Execute("Variables[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the sample variance of the elements in list.
        ///https://reference.wolfram.com/language/ref/Variance.html
        ///</summary>
        public static Engine Variance(this Engine en, string? name = null)
        {
            return en.Execute("Variance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the variances of the datai are equal.
        ///https://reference.wolfram.com/language/ref/VarianceEquivalenceTest.html
        ///</summary>
        public static Engine VarianceEquivalenceTest(this Engine en, string? name = null)
        {
            return en.Execute("VarianceEquivalenceTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the variance of the data is one.
        ///https://reference.wolfram.com/language/ref/VarianceTest.html
        ///</summary>
        public static Engine VarianceTest(this Engine en, string? name = null)
        {
            return en.Execute("VarianceTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True for vectors of length n if xi>yi for all components .
        ///https://reference.wolfram.com/language/ref/VectorGreater.html
        ///</summary>
        public static Engine VectorGreater(this Engine en, string? name = null)
        {
            return en.Execute("VectorGreater[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True for vectors of length n if xi≥yi for all components .
        ///https://reference.wolfram.com/language/ref/VectorGreaterEqual.html
        ///</summary>
        public static Engine VectorGreaterEqual(this Engine en, string? name = null)
        {
            return en.Execute("VectorGreaterEqual[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True for vectors of length n if xi<yi for all components .
        ///https://reference.wolfram.com/language/ref/VectorLess.html
        ///</summary>
        public static Engine VectorLess(this Engine en, string? name = null)
        {
            return en.Execute("VectorLess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True for vectors of length n if xi≤yi for all components .
        ///https://reference.wolfram.com/language/ref/VectorLessEqual.html
        ///</summary>
        public static Engine VectorLessEqual(this Engine en, string? name = null)
        {
            return en.Execute("VectorLessEqual[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is a list or a one‐dimensional SparseArray object, none of whose elements are themselves lists, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/VectorQ.html
        ///</summary>
        public static Engine VectorQ(this Engine en, string? name = null)
        {
            return en.Execute("VectorQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the domain of vectors of dimension d.
        ///https://reference.wolfram.com/language/ref/Vectors.html
        ///</summary>
        public static Engine Vectors(this Engine en, string? name = null)
        {
            return en.Execute("Vectors[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents expr in pattern matching, requiring that expr be matched exactly as it appears, with no substitutions for blanks or other transformations.
        ///https://reference.wolfram.com/language/ref/Verbatim.html
        ///</summary>
        public static Engine Verbatim(this Engine en, string? name = null)
        {
            return en.Execute("Verbatim[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///runs a verification test to determine whether input evaluates to True, without issuing messages.
        ///https://reference.wolfram.com/language/ref/VerificationTest.html
        ///</summary>
        public static Engine VerificationTest(this Engine en, string? name = null)
        {
            return en.Execute("VerificationTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form of VerifyDigitalSignature, suitable for application to {expr,sig} or a list of such pairs.
        ///https://reference.wolfram.com/language/ref/VerifyDigitalSignature.html
        ///</summary>
        public static Engine VerifyDigitalSignature(this Engine en, string? name = null)
        {
            return en.Execute("VerifyDigitalSignature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of VerifyFileSignature that can be applied to files.
        ///https://reference.wolfram.com/language/ref/VerifyFileSignature.html
        ///</summary>
        public static Engine VerifyFileSignature(this Engine en, string? name = null)
        {
            return en.Execute("VerifyFileSignature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the chromatic number for the vertices of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexChromaticNumber.html
        ///</summary>
        public static Engine VertexChromaticNumber(this Engine en, string? name = null)
        {
            return en.Execute("VertexChromaticNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the vertex connectivity of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexConnectivity.html
        ///</summary>
        public static Engine VertexConnectivity(this Engine en, string? name = null)
        {
            return en.Execute("VertexConnectivity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a count of the number of vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexCount.html
        ///</summary>
        public static Engine VertexCount(this Engine en, string? name = null)
        {
            return en.Execute("VertexCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of vertex degrees for all vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexDegree.html
        ///</summary>
        public static Engine VertexDegree(this Engine en, string? name = null)
        {
            return en.Execute("VertexDegree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of vertex in-degrees for all vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexInDegree.html
        ///</summary>
        public static Engine VertexInDegree(this Engine en, string? name = null)
        {
            return en.Execute("VertexInDegree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of vertices for the graph g.
        ///https://reference.wolfram.com/language/ref/VertexList.html
        ///</summary>
        public static Engine VertexList(this Engine en, string? name = null)
        {
            return en.Execute("VertexList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of vertex out-degrees for all vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexOutDegree.html
        ///</summary>
        public static Engine VertexOutDegree(this Engine en, string? name = null)
        {
            return en.Execute("VertexOutDegree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a vertex–transitive graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/VertexTransitiveGraphQ.html
        ///</summary>
        public static Engine VertexTransitiveGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("VertexTransitiveGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a vertex-weighted graph, and False otherwise.
        ///https://reference.wolfram.com/language/ref/VertexWeightedGraphQ.html
        ///</summary>
        public static Engine VertexWeightedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("VertexWeightedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///draws a linear gauge showing value in a range of 0 to 1.
        ///https://reference.wolfram.com/language/ref/VerticalGauge.html
        ///</summary>
        public static Engine VerticalGauge(this Engine en, string? name = null)
        {
            return en.Execute("VerticalGauge[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a vertical slider at position y with range 0 to 1.
        ///https://reference.wolfram.com/language/ref/VerticalSlider.html
        ///</summary>
        public static Engine VerticalSlider(this Engine en, string? name = null)
        {
            return en.Execute("VerticalSlider[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents video stored in the given file.
        ///https://reference.wolfram.com/language/ref/Video.html
        ///</summary>
        public static Engine Video(this Engine en, string? name = null)
        {
            return en.Execute("Video[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a non-blocking asynchronous interface to capture video and saves the result in var.
        ///https://reference.wolfram.com/language/ref/VideoCapture.html
        ///</summary>
        public static Engine VideoCapture(this Engine en, string? name = null)
        {
            return en.Execute("VideoCapture[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a multi-track video by combining all tracks of Video or Audio objects obji.
        ///https://reference.wolfram.com/language/ref/VideoCombine.html
        ///</summary>
        public static Engine VideoCombine(this Engine en, string? name = null)
        {
            return en.Execute("VideoCombine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates one second of video of a given model.
        ///https://reference.wolfram.com/language/ref/VideoGenerator.html
        ///</summary>
        public static Engine VideoGenerator(this Engine en, string? name = null)
        {
            return en.Execute("VideoGenerator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///pauses the playback of the VideoStream object vstream.
        ///https://reference.wolfram.com/language/ref/VideoPause.html
        ///</summary>
        public static Engine VideoPause(this Engine en, string? name = null)
        {
            return en.Execute("VideoPause[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a new VideoStream object from video and starts the playback.
        ///https://reference.wolfram.com/language/ref/VideoPlay.html
        ///</summary>
        public static Engine VideoPlay(this Engine en, string? name = null)
        {
            return en.Execute("VideoPlay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if video has the form of a valid Video object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/VideoQ.html
        ///</summary>
        public static Engine VideoQ(this Engine en, string? name = null)
        {
            return en.Execute("VideoQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a VideoStream object and records from source.
        ///https://reference.wolfram.com/language/ref/VideoRecord.html
        ///</summary>
        public static Engine VideoRecord(this Engine en, string? name = null)
        {
            return en.Execute("VideoRecord[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///captures from a screen or part of a screen specified by source.
        ///https://reference.wolfram.com/language/ref/VideoScreenCapture.html
        ///</summary>
        public static Engine VideoScreenCapture(this Engine en, string? name = null)
        {
            return en.Execute("VideoScreenCapture[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///stops the playback of the VideoStream object vstream.
        ///https://reference.wolfram.com/language/ref/VideoStop.html
        ///</summary>
        public static Engine VideoStop(this Engine en, string? name = null)
        {
            return en.Execute("VideoStop[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a new VideoStream object from source.
        ///https://reference.wolfram.com/language/ref/VideoStream.html
        ///</summary>
        public static Engine VideoStream(this Engine en, string? name = null)
        {
            return en.Execute("VideoStream[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns all properties for the specified voice.
        ///https://reference.wolfram.com/language/ref/VoiceStyleData.html
        ///</summary>
        public static Engine VoiceStyleData(this Engine en, string? name = null)
        {
            return en.Execute("VoiceStyleData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the volume of the three-dimensional region reg.
        ///https://reference.wolfram.com/language/ref/Volume.html
        ///</summary>
        public static Engine Volume(this Engine en, string? name = null)
        {
            return en.Execute("Volume[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a MeshRegion representing the Voronoi mesh from the points p1, p2, ….
        ///https://reference.wolfram.com/language/ref/VoronoiMesh.html
        ///</summary>
        public static Engine VoronoiMesh(this Engine en, string? name = null)
        {
            return en.Execute("VoronoiMesh[" + en.ValidNames.Last() + "]", name);
        }


    }
}
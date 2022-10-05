namespace NetWolf
{
    public static class BuiltinSymbolV
    {
        ///<summary>
        ///creates a multi-track video by combining all tracks of Video or Audio objects obji. 
        ///https://reference.wolfram.com/language/ref/VideoCombine.html
        ///</summary>
        public static Engine VideoCombine(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VideoCombine[" + arg0 + "]", name);
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
        ///represents video stored in the given file.
        ///https://reference.wolfram.com/language/ref/Video.html
        ///</summary>
        public static Engine Video(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Video[" + arg0 + "]", name);
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
        ///gives a list of n images extracted from video.
        ///https://reference.wolfram.com/language/ref/VideoFrameList.html
        ///</summary>
        public static Engine VideoFrameList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoFrameList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the values vali in an association.
        ///https://reference.wolfram.com/language/ref/Values.html
        ///</summary>
        public static Engine Values(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Values[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the variances of the datai are equal. 
        ///https://reference.wolfram.com/language/ref/VarianceEquivalenceTest.html
        ///</summary>
        public static Engine VarianceEquivalenceTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VarianceEquivalenceTest[" + arg0 + "]", name);
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
        ///gives the sample variance of the elements in list. 
        ///https://reference.wolfram.com/language/ref/Variance.html
        ///</summary>
        public static Engine Variance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Variance[" + arg0 + "]", name);
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
        ///generates one second of video of a given model.
        ///https://reference.wolfram.com/language/ref/VideoGenerator.html
        ///</summary>
        public static Engine VideoGenerator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VideoGenerator[" + arg0 + "]", name);
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
        ///makes a graph by adding the vertex v to the graph g.
        ///https://reference.wolfram.com/language/ref/VertexAdd.html
        ///</summary>
        public static Engine VertexAdd(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexAdd[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/VerticalTilde.html
        ///</summary>
        public static Engine VerticalTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VerticalTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the cosine similarity between vertices u and v of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexCosineSimilarity.html
        ///</summary>
        public static Engine VertexCosineSimilarity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VertexCosineSimilarity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///inserts the video new at time t.
        ///https://reference.wolfram.com/language/ref/VideoInsert.html
        ///</summary>
        public static Engine VideoInsert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoInsert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the vertex connectivity of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexConnectivity.html
        ///</summary>
        public static Engine VertexConnectivity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexConnectivity[" + arg0 + "]", name);
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
        ///contracts a collection of vertices v1, v2, … into a single vertex of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexContract.html
        ///</summary>
        public static Engine VertexContract(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexContract[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to each frame of the Video object video, returning a time series.
        ///https://reference.wolfram.com/language/ref/VideoMapTimeSeries.html
        ///</summary>
        public static Engine VideoMapTimeSeries(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoMapTimeSeries[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to partial video and audio data corresponding to one frame of video, returning a new video.
        ///https://reference.wolfram.com/language/ref/VideoMap.html
        ///</summary>
        public static Engine VideoMap(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoMap[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes the first t seconds of video.
        ///https://reference.wolfram.com/language/ref/VideoDelete.html
        ///</summary>
        public static Engine VideoDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of all independent variables in a polynomial. 
        ///https://reference.wolfram.com/language/ref/Variables.html
        ///</summary>
        public static Engine Variables(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Variables[" + arg0 + "]", name);
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
        ///returns a new VideoStream object from video and starts the playback.
        ///https://reference.wolfram.com/language/ref/VideoPlay.html
        ///</summary>
        public static Engine VideoPlay(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VideoPlay[" + arg0 + "]", name);
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
        ///gives the length of the longest shortest path from the source s to every other vertex in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexEccentricity.html
        ///</summary>
        public static Engine VertexEccentricity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexEccentricity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a vector of uncorrelated approximate numbers or quantities with values xi and uncertainties δi.
        ///https://reference.wolfram.com/language/ref/VectorAround.html
        ///</summary>
        public static Engine VectorAround(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VectorAround[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a displacement plot for the vector field {vx,vy} as a function of x and y.
        ///https://reference.wolfram.com/language/ref/VectorDisplacementPlot.html
        ///</summary>
        public static Engine VectorDisplacementPlot(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VectorDisplacementPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields True if video has the form of a valid Video object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/VideoQ.html
        ///</summary>
        public static Engine VideoQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VideoQ[" + arg0 + "]", name);
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
        ///gives the list of vertex in-degrees for all vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexInDegree.html
        ///</summary>
        public static Engine VertexInDegree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexInDegree[" + arg0 + "]", name);
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
        ///pauses the playback of all VideoStream objects.
        ///https://reference.wolfram.com/language/ref/VideoPause.html
        ///</summary>
        public static Engine VideoPause(this Engine en, string? name = null)
        {
            return en.Execute("VideoPause[]", name);
        }

        ///<summary>
        ///creates a new VideoStream object from source.
        ///https://reference.wolfram.com/language/ref/VideoStream.html
        ///</summary>
        public static Engine VideoStream(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VideoStream[" + arg0 + "]", name);
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
        ///represents the function for the variogram model specified by "model".
        ///https://reference.wolfram.com/language/ref/VariogramModel.html
        ///</summary>
        public static Engine VariogramModel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VariogramModel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the variance of the data is one. 
        ///https://reference.wolfram.com/language/ref/VarianceTest.html
        ///</summary>
        public static Engine VarianceTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VarianceTest[" + arg0 + "]", name);
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
        ///converts video to the specified format.
        ///https://reference.wolfram.com/language/ref/VideoTranscode.html
        ///</summary>
        public static Engine VideoTranscode(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoTranscode[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes a graph by deleting the vertex ν and all edges connected to v from the graph g.
        ///https://reference.wolfram.com/language/ref/VertexDelete.html
        ///</summary>
        public static Engine VertexDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces the video between t1 and t2 with the new video new.
        ///https://reference.wolfram.com/language/ref/VideoReplace.html
        ///</summary>
        public static Engine VideoReplace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoReplace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the vertices in the graph g that have a path to at least one of v1, v2, … .
        ///https://reference.wolfram.com/language/ref/VertexComponent.html
        ///</summary>
        public static Engine VertexComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the angle between the vectors u and v.
        ///https://reference.wolfram.com/language/ref/VectorAngle.html
        ///</summary>
        public static Engine VectorAngle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VectorAngle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the vertex list vlist is a vertex cover of the graph g, and False otherwise.
        ///https://reference.wolfram.com/language/ref/VertexCoverQ.html
        ///</summary>
        public static Engine VertexCoverQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexCoverQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///stops the playback of all VideoStream objects.
        ///https://reference.wolfram.com/language/ref/VideoStop.html
        ///</summary>
        public static Engine VideoStop(this Engine en, string? name = null)
        {
            return en.Execute("VideoStop[]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Vee.html
        ///</summary>
        public static Engine Vee(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Vee[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///creates a temporary interactive interface for capturing a video from an imaging device.
        ///https://reference.wolfram.com/language/ref/VideoCapture.html
        ///</summary>
        public static Engine VideoCapture(this Engine en, string? name = null)
        {
            return en.Execute("VideoCapture[]", name);
        }

        ///<summary>
        ///yields True if the graph g is a vertex–transitive graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/VertexTransitiveGraphQ.html
        ///</summary>
        public static Engine VertexTransitiveGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexTransitiveGraphQ[" + arg0 + "]", name);
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
        ///gives the Dice similarity between vertices u and v of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexDiceSimilarity.html
        ///</summary>
        public static Engine VertexDiceSimilarity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VertexDiceSimilarity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list of available voices for speech synthesis.
        ///https://reference.wolfram.com/language/ref/VoiceStyleData.html
        ///</summary>
        public static Engine VoiceStyleData(this Engine en, string? name = null)
        {
            return en.Execute("VoiceStyleData[]", name);
        }

        ///<summary>
        ///applies time stretching to video using the specified spec.
        ///https://reference.wolfram.com/language/ref/VideoTimeStretch.html
        ///</summary>
        public static Engine VideoTimeStretch(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoTimeStretch[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the domain of vectors of dimension d.
        ///https://reference.wolfram.com/language/ref/Vectors.html
        ///</summary>
        public static Engine Vectors(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Vectors[" + arg0 + "]", name);
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
        ///displays as .
        ///https://reference.wolfram.com/language/ref/VerticalBar.html
        ///</summary>
        public static Engine VerticalBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VerticalBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies f to each frame of the Video object video, returning a new Video object.
        ///https://reference.wolfram.com/language/ref/VideoFrameMap.html
        ///</summary>
        public static Engine VideoFrameMap(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoFrameMap[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Jaccard similarity between vertices u and v of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexJaccardSimilarity.html
        ///</summary>
        public static Engine VertexJaccardSimilarity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VertexJaccardSimilarity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns time intervals of video for which the criterion crit is satisfied.
        ///https://reference.wolfram.com/language/ref/VideoIntervals.html
        ///</summary>
        public static Engine VideoIntervals(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoIntervals[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces each vertex vi in the graph g by wi.
        ///https://reference.wolfram.com/language/ref/VertexReplace.html
        ///</summary>
        public static Engine VertexReplace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexReplace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a vertical slider at position y with range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/VerticalSlider.html
        ///</summary>
        public static Engine VerticalSlider(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VerticalSlider[" + arg0 + "]", name);
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
        ///creates a VideoStream object and records from source.
        ///https://reference.wolfram.com/language/ref/VideoRecord.html
        ///</summary>
        public static Engine VideoRecord(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VideoRecord[" + arg0 + "]", name);
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
        ///gives the volume of the three-dimensional region reg.
        ///https://reference.wolfram.com/language/ref/Volume.html
        ///</summary>
        public static Engine Volume(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Volume[" + arg0 + "]", name);
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
        ///gives a count of the number of vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexCount.html
        ///</summary>
        public static Engine VertexCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexCount[" + arg0 + "]", name);
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
        public static Engine VertexDegree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexDegree[" + arg0 + "]", name);
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
        ///gives the vertices in the graph g that have a directed path to at least one of v1, v2, … .
        ///https://reference.wolfram.com/language/ref/VertexInComponent.html
        ///</summary>
        public static Engine VertexInComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexInComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a displacement plot of the vector field {vx,vy,vz} as a function of x, y and z.
        ///https://reference.wolfram.com/language/ref/VectorDisplacementPlot3D.html
        ///</summary>
        public static Engine VectorDisplacementPlot3D(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("VectorDisplacementPlot3D[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///runs a verification test to determine whether input evaluates to True, without issuing messages.
        ///https://reference.wolfram.com/language/ref/VerificationTest.html
        ///</summary>
        public static Engine VerificationTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VerificationTest[" + arg0 + "]", name);
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
        ///applies f to a chunk of data corresponding to one frame from the Video object video, returning a list of results.
        ///https://reference.wolfram.com/language/ref/VideoMapList.html
        ///</summary>
        public static Engine VideoMapList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoMapList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns all existing video streams.
        ///https://reference.wolfram.com/language/ref/VideoStreams.html
        ///</summary>
        public static Engine VideoStreams(this Engine en, string? name = null)
        {
            return en.Execute("VideoStreams[]", name);
        }

        ///<summary>
        ///gives the integer index for the vertex v in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexIndex.html
        ///</summary>
        public static Engine VertexIndex(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexIndex[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if a value has been defined for expr, and gives False otherwise. 
        ///https://reference.wolfram.com/language/ref/ValueQ.html
        ///</summary>
        public static Engine ValueQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ValueQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if a value has been defined for expr, and gives False otherwise. 
        ///https://reference.wolfram.com/language/ref/ValueQ.html
        ///</summary>
        public static Engine ValueQ(this Engine en, string? name = null)
        {
            return en.Execute("ValueQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a temporary interactive interface for capturing from the main screen into a video.
        ///https://reference.wolfram.com/language/ref/VideoScreenCapture.html
        ///</summary>
        public static Engine VideoScreenCapture(this Engine en, string? name = null)
        {
            return en.Execute("VideoScreenCapture[]", name);
        }

        ///<summary>
        ///yields True if the graph g is a vertex-weighted graph, and False otherwise.
        ///https://reference.wolfram.com/language/ref/VertexWeightedGraphQ.html
        ///</summary>
        public static Engine VertexWeightedGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexWeightedGraphQ[" + arg0 + "]", name);
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
        ///represents expr in pattern matching, requiring that expr be matched exactly as it appears, with no substitutions for blanks or other transformations. 
        ///https://reference.wolfram.com/language/ref/Verbatim.html
        ///</summary>
        public static Engine Verbatim(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Verbatim[" + arg0 + "]", name);
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
        ///represents a variance‐gamma distribution with location parameter μ, skewness parameter β, and shape parameters λ and α.
        ///https://reference.wolfram.com/language/ref/VarianceGammaDistribution.html
        ///</summary>
        public static Engine VarianceGammaDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("VarianceGammaDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///verifies the digital signature sig for expr using the specified public key.
        ///https://reference.wolfram.com/language/ref/VerifyDigitalSignature.html
        ///</summary>
        public static Engine VerifyDigitalSignature(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VerifyDigitalSignature[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the volcano entity.
        ///https://reference.wolfram.com/language/ref/VolcanoData.html
        ///</summary>
        public static Engine VolcanoData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VolcanoData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the chromatic number for the vertices of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexChromaticNumber.html
        ///</summary>
        public static Engine VertexChromaticNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexChromaticNumber[" + arg0 + "]", name);
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
        ///gives the correlation similarity between vertices u and v of the graph g.
        ///https://reference.wolfram.com/language/ref/VertexCorrelationSimilarity.html
        ///</summary>
        public static Engine VertexCorrelationSimilarity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VertexCorrelationSimilarity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents Voigt distribution with parameters δ and σ.
        ///https://reference.wolfram.com/language/ref/VoigtDistribution.html
        ///</summary>
        public static Engine VoigtDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VoigtDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a vector plot of the vector field {vx,vy} as a function of x and y, superimposed on a density plot of the scalar field s. 
        ///https://reference.wolfram.com/language/ref/VectorDensityPlot.html
        ///</summary>
        public static Engine VectorDensityPlot(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("VectorDensityPlot[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///concatenates all videoi and returns a video object.
        ///https://reference.wolfram.com/language/ref/VideoJoin.html
        ///</summary>
        public static Engine VideoJoin(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VideoJoin[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///verifies that password matches the password used to generate the derived key.
        ///https://reference.wolfram.com/language/ref/VerifyDerivedKey.html
        ///</summary>
        public static Engine VerifyDerivedKey(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VerifyDerivedKey[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a vector plot of the vector field {vx,vy} as a function of x and y. 
        ///https://reference.wolfram.com/language/ref/VectorPlot.html
        ///</summary>
        public static Engine VectorPlot(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VectorPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///draws a linear gauge showing value in a range of 0 to 1.
        ///https://reference.wolfram.com/language/ref/VerticalGauge.html
        ///</summary>
        public static Engine VerticalGauge(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VerticalGauge[" + arg0 + "]", name);
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
        ///extracts a frame at time t from video.
        ///https://reference.wolfram.com/language/ref/VideoExtractFrames.html
        ///</summary>
        public static Engine VideoExtractFrames(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoExtractFrames[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a variance gamma cluster point process with density μ, cluster mean λ and shape parameters α and β in .
        ///https://reference.wolfram.com/language/ref/VarianceGammaPointProcess.html
        ///</summary>
        public static Engine VarianceGammaPointProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("VarianceGammaPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///gives the subgraph of the graph g generated by the vertices that have a directed path to at least one of v1,v2,….
        ///https://reference.wolfram.com/language/ref/VertexInComponentGraph.html
        ///</summary>
        public static Engine VertexInComponentGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexInComponentGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the vertices in the graph g that have a directed path from at least one of v1, v2, ….
        ///https://reference.wolfram.com/language/ref/VertexOutComponent.html
        ///</summary>
        public static Engine VertexOutComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexOutComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///splits video at time t.
        ///https://reference.wolfram.com/language/ref/VideoSplit.html
        ///</summary>
        public static Engine VideoSplit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoSplit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a von Mises distribution with mean μ and concentration κ.
        ///https://reference.wolfram.com/language/ref/VonMisesDistribution.html
        ///</summary>
        public static Engine VonMisesDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VonMisesDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the first t seconds of video.
        ///https://reference.wolfram.com/language/ref/VideoTrim.html
        ///</summary>
        public static Engine VideoTrim(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VideoTrim[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///verifies the digital signature sig for file using the specified public key.
        ///https://reference.wolfram.com/language/ref/VerifyFileSignature.html
        ///</summary>
        public static Engine VerifyFileSignature(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VerifyFileSignature[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of vertices for the graph g.
        ///https://reference.wolfram.com/language/ref/VertexList.html
        ///</summary>
        public static Engine VertexList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexList[" + arg0 + "]", name);
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
        ///displays as .
        ///https://reference.wolfram.com/language/ref/VerticalSeparator.html
        ///</summary>
        public static Engine VerticalSeparator(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("VerticalSeparator[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a 3D vector plot of the vector field {vx,vy,vz} as a function of x, y, and z.
        ///https://reference.wolfram.com/language/ref/VectorPlot3D.html
        ///</summary>
        public static Engine VectorPlot3D(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("VectorPlot3D[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the subgraph of the graph g generated by the vertices that have a directed path from at least one of v1,v2,….
        ///https://reference.wolfram.com/language/ref/VertexOutComponentGraph.html
        ///</summary>
        public static Engine VertexOutComponentGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexOutComponentGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a MeshRegion representing the Voronoi mesh from the points p1, p2, ….
        ///https://reference.wolfram.com/language/ref/VoronoiMesh.html
        ///</summary>
        public static Engine VoronoiMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VoronoiMesh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a MeshRegion representing the Voronoi mesh from the points p1, p2, ….
        ///https://reference.wolfram.com/language/ref/VoronoiMesh.html
        ///</summary>
        public static Engine VoronoiMesh(this Engine en, string? name = null)
        {
            return en.Execute("VoronoiMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of vertex out-degrees for all vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/VertexOutDegree.html
        ///</summary>
        public static Engine VertexOutDegree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VertexOutDegree[" + arg0 + "]", name);
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
        ///gives True if expr is a list or a one‐dimensional SparseArray object, none of whose elements are themselves lists, and gives False otherwise. 
        ///https://reference.wolfram.com/language/ref/VectorQ.html
        ///</summary>
        public static Engine VectorQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("VectorQ[" + arg0 + "]", name);
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
        ///yields True if v is a vertex in the graph g and False otherwise.
        ///https://reference.wolfram.com/language/ref/VertexQ.html
        ///</summary>
        public static Engine VertexQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("VertexQ[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}
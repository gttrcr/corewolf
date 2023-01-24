namespace NetWolf
{
    public static class BuiltinSymbolE
    {
        ///<summary>
        ///gives the value of the specified property for the earth impact crater entity.
        ///https://reference.wolfram.com/language/ref/EarthImpactData.html
        ///</summary>
        public static Engine EarthImpactData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EarthImpactData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified earth impact crater names.
        ///https://reference.wolfram.com/language/ref/EarthImpactData.html
        ///</summary>
        public static Engine EarthImpactData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EarthImpactData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/EarthImpactData.html
        ///</summary>
        public static Engine EarthImpactData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EarthImpactData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives all earthquake properties for the location corresponding to loc.
        ///https://reference.wolfram.com/language/ref/EarthquakeData.html
        ///</summary>
        public static Engine EarthquakeData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EarthquakeData[" + arg0 + "]", name);
        }

        ///<summary>
        ///restricts earthquakes returned to the magnitude range mag.
        ///https://reference.wolfram.com/language/ref/EarthquakeData.html
        ///</summary>
        public static Engine EarthquakeData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EarthquakeData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives earthquake data within the magnitude range mag during the time interval start to end.
        ///https://reference.wolfram.com/language/ref/EarthquakeData.html
        ///</summary>
        public static Engine EarthquakeData(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("EarthquakeData[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives a time series for the specific earthquake property for earthquakes within the magnitude range mag during the time interval start to end.
        ///https://reference.wolfram.com/language/ref/EarthquakeData.html
        ///</summary>
        public static Engine EarthquakeData(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("EarthquakeData[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a list of eccentricity centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/EccentricityCentrality.html
        ///</summary>
        public static Engine EccentricityCentrality(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EccentricityCentrality[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EccentricityCentrality.html
        ///</summary>
        public static Engine EccentricityCentrality(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EccentricityCentrality[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///prints expr and returns expr.
        ///https://reference.wolfram.com/language/ref/Echo.html
        ///</summary>
        public static Engine Echo(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Echo[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints expr prepending label and returns expr.
        ///https://reference.wolfram.com/language/ref/Echo.html
        ///</summary>
        public static Engine Echo(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Echo[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints f[expr] prepending label and returns expr.
        ///https://reference.wolfram.com/language/ref/Echo.html
        ///</summary>
        public static Engine Echo(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Echo[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///prints expr before evaluation, then prints the result after evaluation and returns that result.
        ///https://reference.wolfram.com/language/ref/EchoEvaluation.html
        ///</summary>
        public static Engine EchoEvaluation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EchoEvaluation[" + arg0 + "]", name);
        }

        ///<summary>
        ///prepends label when printing expr before and after evaluation.
        ///https://reference.wolfram.com/language/ref/EchoEvaluation.html
        ///</summary>
        public static Engine EchoEvaluation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EchoEvaluation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints expr before evaluation, then evaluates expr to the result res and prints f[res].
        ///https://reference.wolfram.com/language/ref/EchoEvaluation.html
        ///</summary>
        public static Engine EchoEvaluation(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EchoEvaluation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///prints f[expr] and returns expr.
        ///https://reference.wolfram.com/language/ref/EchoFunction.html
        ///</summary>
        public static Engine EchoFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EchoFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr, prints the time in seconds used and returns the result of the evaluation.
        ///https://reference.wolfram.com/language/ref/EchoTiming.html
        ///</summary>
        public static Engine EchoTiming(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EchoTiming[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints the timing, prepending label.
        ///https://reference.wolfram.com/language/ref/EchoTiming.html
        ///</summary>
        public static Engine EchoTiming(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EchoTiming[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes a graph by adding the edge e to the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeAdd.html
        ///</summary>
        public static Engine EdgeAdd(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeAdd[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds a collection of edges to g.
        ///https://reference.wolfram.com/language/ref/EdgeAdd.html
        ///</summary>
        public static Engine EdgeAdd(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EdgeAdd[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeAdd.html
        ///</summary>
        public static Engine EdgeAdd(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeAdd[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of betweenness centralities for the edges in the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeBetweennessCentrality.html
        ///</summary>
        public static Engine EdgeBetweennessCentrality(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeBetweennessCentrality[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeBetweennessCentrality.html
        ///</summary>
        public static Engine EdgeBetweennessCentrality(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EdgeBetweennessCentrality[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the chromatic number for the edges of the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeChromaticNumber.html
        ///</summary>
        public static Engine EdgeChromaticNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeChromaticNumber[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the edge connectivity of the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeConnectivity.html
        ///</summary>
        public static Engine EdgeConnectivity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeConnectivity[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the s-t edge connectivity of the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeConnectivity.html
        ///</summary>
        public static Engine EdgeConnectivity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EdgeConnectivity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeConnectivity.html
        ///</summary>
        public static Engine EdgeConnectivity(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeConnectivity[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///contracts the edge e of the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeContract.html
        ///</summary>
        public static Engine EdgeContract(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeContract[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///contracts a collection of edges e1,e2,….
        ///https://reference.wolfram.com/language/ref/EdgeContract.html
        ///</summary>
        public static Engine EdgeContract(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EdgeContract[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeContract.html
        ///</summary>
        public static Engine EdgeContract(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeContract[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a count of the number of edges in the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeCount.html
        ///</summary>
        public static Engine EdgeCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a count of the number of edges that match the pattern patt.
        ///https://reference.wolfram.com/language/ref/EdgeCount.html
        ///</summary>
        public static Engine EdgeCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeCount.html
        ///</summary>
        public static Engine EdgeCount(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeCount[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the edge list elist is an edge cover of the graph g and False otherwise.
        ///https://reference.wolfram.com/language/ref/EdgeCoverQ.html
        ///</summary>
        public static Engine EdgeCoverQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeCoverQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the edge cycle matrix of a graph g.
        ///https://reference.wolfram.com/language/ref/EdgeCycleMatrix.html
        ///</summary>
        public static Engine EdgeCycleMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeCycleMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeCycleMatrix.html
        ///</summary>
        public static Engine EdgeCycleMatrix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EdgeCycleMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a graph by deleting the edge e from the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeDelete.html
        ///</summary>
        public static Engine EdgeDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes a collection of edges from g.
        ///https://reference.wolfram.com/language/ref/EdgeDelete.html
        ///</summary>
        public static Engine EdgeDelete(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EdgeDelete[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeDelete.html
        ///</summary>
        public static Engine EdgeDelete(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeDelete[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds edges in image and returns the result as a binary image.
        ///https://reference.wolfram.com/language/ref/EdgeDetect.html
        ///</summary>
        public static Engine EdgeDetect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeDetect[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds edges at the scale of the specified pixel range r.
        ///https://reference.wolfram.com/language/ref/EdgeDetect.html
        ///</summary>
        public static Engine EdgeDetect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeDetect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a threshold t for selecting image edges.
        ///https://reference.wolfram.com/language/ref/EdgeDetect.html
        ///</summary>
        public static Engine EdgeDetect(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EdgeDetect[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a graphics directive that specifies that edges of polygons and other filled graphics objects are to be drawn using the graphics directive or list of directives g.
        ///https://reference.wolfram.com/language/ref/EdgeForm.html
        ///</summary>
        public static Engine EdgeForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the integer index for the edge e in the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeIndex.html
        ///</summary>
        public static Engine EdgeIndex(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeIndex[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeIndex.html
        ///</summary>
        public static Engine EdgeIndex(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeIndex[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of edges for the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeList.html
        ///</summary>
        public static Engine EdgeList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of edges that match the pattern patt.
        ///https://reference.wolfram.com/language/ref/EdgeList.html
        ///</summary>
        public static Engine EdgeList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeList.html
        ///</summary>
        public static Engine EdgeList(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeList[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if e is an edge in the graph g and False otherwise.
        ///https://reference.wolfram.com/language/ref/EdgeQ.html
        ///</summary>
        public static Engine EdgeQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EdgeQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of edge rules for the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeRules.html
        ///</summary>
        public static Engine EdgeRules(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeRules[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeRules.html
        ///</summary>
        public static Engine EdgeRules(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EdgeRules[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields a graph with edges ej tagged with unique tags.
        ///https://reference.wolfram.com/language/ref/EdgeTaggedGraph.html
        ///</summary>
        public static Engine EdgeTaggedGraph(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EdgeTaggedGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields a graph with vertices vi and edges ej tagged with tj.
        ///https://reference.wolfram.com/language/ref/EdgeTaggedGraph.html
        ///</summary>
        public static Engine EdgeTaggedGraph(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EdgeTaggedGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if the graph g has edges tagged and False otherwise.
        ///https://reference.wolfram.com/language/ref/EdgeTaggedGraphQ.html
        ///</summary>
        public static Engine EdgeTaggedGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeTaggedGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of tags for all edges in the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeTags.html
        ///</summary>
        public static Engine EdgeTags(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeTags[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of tags for edges between u and v.
        ///https://reference.wolfram.com/language/ref/EdgeTags.html
        ///</summary>
        public static Engine EdgeTags(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EdgeTags[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a edge-transitive graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/EdgeTransitiveGraphQ.html
        ///</summary>
        public static Engine EdgeTransitiveGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeTransitiveGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is an edge-weighted graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/EdgeWeightedGraphQ.html
        ///</summary>
        public static Engine EdgeWeightedGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EdgeWeightedGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the edit or Levenshtein distance between strings, vectors or biomolecular sequences u and v.
        ///https://reference.wolfram.com/language/ref/EditDistance.html
        ///</summary>
        public static Engine EditDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EditDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the effective interest rate corresponding to interest specification r, compounded at time intervals q.
        ///https://reference.wolfram.com/language/ref/EffectiveInterest.html
        ///</summary>
        public static Engine EffectiveInterest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EffectiveInterest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list {values,vectors} of the eigenvalues and eigenvectors of the square matrix m.
        ///https://reference.wolfram.com/language/ref/Eigensystem.html
        ///</summary>
        public static Engine Eigensystem(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Eigensystem[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generalized eigenvalues and eigenvectors of m with respect to a.
        ///https://reference.wolfram.com/language/ref/Eigensystem.html
        ///</summary>
        public static Engine Eigensystem(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Eigensystem[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the eigenvalues and eigenvectors for the first k eigenvalues of m.
        ///https://reference.wolfram.com/language/ref/Eigensystem.html
        ///</summary>
        public static Engine Eigensystem(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Eigensystem[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the first k generalized eigenvalues and eigenvectors.
        ///https://reference.wolfram.com/language/ref/Eigensystem.html
        ///</summary>
        public static Engine Eigensystem(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Eigensystem[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the eigenvalues of the square matrix m.
        ///https://reference.wolfram.com/language/ref/Eigenvalues.html
        ///</summary>
        public static Engine Eigenvalues(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Eigenvalues[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generalized eigenvalues of m with respect to a.
        ///https://reference.wolfram.com/language/ref/Eigenvalues.html
        ///</summary>
        public static Engine Eigenvalues(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Eigenvalues[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the first k eigenvalues of m.
        ///https://reference.wolfram.com/language/ref/Eigenvalues.html
        ///</summary>
        public static Engine Eigenvalues(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Eigenvalues[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the first k generalized eigenvalues.
        ///https://reference.wolfram.com/language/ref/Eigenvalues.html
        ///</summary>
        public static Engine Eigenvalues(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Eigenvalues[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of eigenvector centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/EigenvectorCentrality.html
        ///</summary>
        public static Engine EigenvectorCentrality(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EigenvectorCentrality[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of in-centralities for a directed graph g.
        ///https://reference.wolfram.com/language/ref/EigenvectorCentrality.html
        ///</summary>
        public static Engine EigenvectorCentrality(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EigenvectorCentrality[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/EigenvectorCentrality.html
        ///</summary>
        public static Engine EigenvectorCentrality(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EigenvectorCentrality[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the eigenvectors of the square matrix m.
        ///https://reference.wolfram.com/language/ref/Eigenvectors.html
        ///</summary>
        public static Engine Eigenvectors(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Eigenvectors[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generalized eigenvectors of m with respect to a.
        ///https://reference.wolfram.com/language/ref/Eigenvectors.html
        ///</summary>
        public static Engine Eigenvectors(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Eigenvectors[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the first k eigenvectors of m.
        ///https://reference.wolfram.com/language/ref/Eigenvectors.html
        ///</summary>
        public static Engine Eigenvectors(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Eigenvectors[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the first k generalized eigenvectors.
        ///https://reference.wolfram.com/language/ref/Eigenvectors.html
        ///</summary>
        public static Engine Eigenvectors(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Eigenvectors[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///or x∈dom asserts that x is an element of the domain dom.
        ///https://reference.wolfram.com/language/ref/Element.html
        ///</summary>
        public static Engine Element(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Element[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the chemical element "name".
        ///https://reference.wolfram.com/language/ref/ElementData.html
        ///</summary>
        public static Engine ElementData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ElementData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that applies a unary function f to every element of the input array.
        ///https://reference.wolfram.com/language/ref/ElementwiseLayer.html
        ///</summary>
        public static Engine ElementwiseLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ElementwiseLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///eliminates variables between a set of simultaneous equations.
        ///https://reference.wolfram.com/language/ref/Eliminate.html
        ///</summary>
        public static Engine Eliminate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Eliminate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an axis-aligned ellipsoid centered at the point p and with semiaxes lengths ri.
        ///https://reference.wolfram.com/language/ref/Ellipsoid.html
        ///</summary>
        public static Engine Ellipsoid(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Ellipsoid[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an ellipsoid centered at p and weight matrix Σ.
        ///https://reference.wolfram.com/language/ref/Ellipsoid.html
        ///</summary>
        public static Engine Ellipsoid(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Ellipsoid[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the complete elliptic integral .
        ///https://reference.wolfram.com/language/ref/EllipticE.html
        ///</summary>
        public static Engine EllipticE(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EllipticE[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the elliptic integral of the second kind .
        ///https://reference.wolfram.com/language/ref/EllipticE.html
        ///</summary>
        public static Engine EllipticE(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EllipticE[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the inverse for EllipticLog. It produces a list {x,y} such that u==EllipticLog[{x,y},{a,b}].
        ///https://reference.wolfram.com/language/ref/EllipticExp.html
        ///</summary>
        public static Engine EllipticExp(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EllipticExp[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the derivative of EllipticExp[u,{a,b}] with respect to u.
        ///https://reference.wolfram.com/language/ref/EllipticExpPrime.html
        ///</summary>
        public static Engine EllipticExpPrime(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EllipticExpPrime[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the elliptic integral of the first kind .
        ///https://reference.wolfram.com/language/ref/EllipticF.html
        ///</summary>
        public static Engine EllipticF(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EllipticF[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///designs a lowpass elliptic filter of order n.
        ///https://reference.wolfram.com/language/ref/EllipticFilterModel.html
        ///</summary>
        public static Engine EllipticFilterModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EllipticFilterModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the cutoff frequency ωc.
        ///https://reference.wolfram.com/language/ref/EllipticFilterModel.html
        ///</summary>
        public static Engine EllipticFilterModel(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EllipticFilterModel[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///expresses the model in terms of the variable var.
        ///https://reference.wolfram.com/language/ref/EllipticFilterModel.html
        ///</summary>
        public static Engine EllipticFilterModel(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EllipticFilterModel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the complete elliptic integral of the first kind .
        ///https://reference.wolfram.com/language/ref/EllipticK.html
        ///</summary>
        public static Engine EllipticK(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EllipticK[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generalized logarithm associated with the elliptic curve .
        ///https://reference.wolfram.com/language/ref/EllipticLog.html
        ///</summary>
        public static Engine EllipticLog(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EllipticLog[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the nome q corresponding to the parameter m in an elliptic function.
        ///https://reference.wolfram.com/language/ref/EllipticNomeQ.html
        ///</summary>
        public static Engine EllipticNomeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EllipticNomeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the complete elliptic integral of the third kind Π(nm).
        ///https://reference.wolfram.com/language/ref/EllipticPi.html
        ///</summary>
        public static Engine EllipticPi(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EllipticPi[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the incomplete elliptic integral Π(n;ϕm).
        ///https://reference.wolfram.com/language/ref/EllipticPi.html
        ///</summary>
        public static Engine EllipticPi(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EllipticPi[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the theta function .
        ///https://reference.wolfram.com/language/ref/EllipticTheta.html
        ///</summary>
        public static Engine EllipticTheta(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EllipticTheta[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the theta constant .
        ///https://reference.wolfram.com/language/ref/EllipticTheta.html
        ///</summary>
        public static Engine EllipticTheta(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EllipticTheta[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the derivative with respect to u of the theta function .
        ///https://reference.wolfram.com/language/ref/EllipticThetaPrime.html
        ///</summary>
        public static Engine EllipticThetaPrime(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EllipticThetaPrime[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the theta constant .
        ///https://reference.wolfram.com/language/ref/EllipticThetaPrime.html
        ///</summary>
        public static Engine EllipticThetaPrime(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EllipticThetaPrime[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates the code necessary to embed the object obj on a webpage.
        ///https://reference.wolfram.com/language/ref/EmbedCode.html
        ///</summary>
        public static Engine EmbedCode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmbedCode[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates code for an external environment or language of type "dest".
        ///https://reference.wolfram.com/language/ref/EmbedCode.html
        ///</summary>
        public static Engine EmbedCode(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EmbedCode[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///saves the generated code as files in the directory dir.
        ///https://reference.wolfram.com/language/ref/EmbedCode.html
        ///</summary>
        public static Engine EmbedCode(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EmbedCode[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an object that formats as a web frame containing the HTML content "string".
        ///https://reference.wolfram.com/language/ref/EmbeddedHTML.html
        ///</summary>
        public static Engine EmbeddedHTML(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmbeddedHTML[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that formats as a web frame containing content from the specified external service.
        ///https://reference.wolfram.com/language/ref/EmbeddedService.html
        ///</summary>
        public static Engine EmbeddedService(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmbeddedService[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a verbatim SQL query to be interpreted as an entity class with properties given by props.
        ///https://reference.wolfram.com/language/ref/EmbeddedSQLEntityClass.html
        ///</summary>
        public static Engine EmbeddedSQLEntityClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EmbeddedSQLEntityClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an SQL query string template with arguments provided by args.
        ///https://reference.wolfram.com/language/ref/EmbeddedSQLEntityClass.html
        ///</summary>
        public static Engine EmbeddedSQLEntityClass(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EmbeddedSQLEntityClass[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an SQL expression to be evaluated verbatim within an EntityFunction object.
        ///https://reference.wolfram.com/language/ref/EmbeddedSQLExpression.html
        ///</summary>
        public static Engine EmbeddedSQLExpression(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmbeddedSQLExpression[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an SQL expression string template with arguments provided by args.
        ///https://reference.wolfram.com/language/ref/EmbeddedSQLExpression.html
        ///</summary>
        public static Engine EmbeddedSQLExpression(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EmbeddedSQLExpression[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a trainable net layer that embeds integers between 1 and n into a continuous vector space of dimension size.
        ///https://reference.wolfram.com/language/ref/EmbeddingLayer.html
        ///</summary>
        public static Engine EmbeddingLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EmbeddingLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///leaves the n to be inferred from context.
        ///https://reference.wolfram.com/language/ref/EmbeddingLayer.html
        ///</summary>
        public static Engine EmbeddingLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmbeddingLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///emits the sound snd when evaluated.
        ///https://reference.wolfram.com/language/ref/EmitSound.html
        ///</summary>
        public static Engine EmitSound(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmitSound[" + arg0 + "]", name);
        }

        ///<summary>
        ///emits each of the sounds sndi in sequence.
        ///https://reference.wolfram.com/language/ref/EmitSound.html
        ///</summary>
        public static Engine EmitSound(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EmitSound[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents an empirical distribution based on the data values xi.
        ///https://reference.wolfram.com/language/ref/EmpiricalDistribution.html
        ///</summary>
        public static Engine EmpiricalDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EmpiricalDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a multivariate empirical distribution based on the data values {xi,yi,…}.
        ///https://reference.wolfram.com/language/ref/EmpiricalDistribution.html
        ///</summary>
        public static Engine EmpiricalDistribution(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EmpiricalDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if g is an empty graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/EmptyGraphQ.html
        ///</summary>
        public static Engine EmptyGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmptyGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the empty subset of .
        ///https://reference.wolfram.com/language/ref/EmptyRegion.html
        ///</summary>
        public static Engine EmptyRegion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmptyRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the empty space function  for point data pdata at radius r.
        ///https://reference.wolfram.com/language/ref/EmptySpaceF.html
        ///</summary>
        public static Engine EmptySpaceF(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EmptySpaceF[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates the function  that can be applied repeatedly to different radii r.
        ///https://reference.wolfram.com/language/ref/EmptySpaceF.html
        ///</summary>
        public static Engine EmptySpaceF(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EmptySpaceF[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to evaluate expr and return the result, but stops if it catches an error and returns a failure object.
        ///https://reference.wolfram.com/language/ref/Enclose.html
        ///</summary>
        public static Engine Enclose(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Enclose[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies f to any failure object generated.
        ///https://reference.wolfram.com/language/ref/Enclose.html
        ///</summary>
        public static Engine Enclose(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Enclose[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///only catches errors with explicitly specified tags matching form.
        ///https://reference.wolfram.com/language/ref/Enclose.html
        ///</summary>
        public static Engine Enclose(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Enclose[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///writes an encoded version of the file source to the file dest.
        ///https://reference.wolfram.com/language/ref/Encode.html
        ///</summary>
        public static Engine Encode(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Encode[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///decodes the file before reading its contents.
        ///https://reference.wolfram.com/language/ref/Encode.html
        ///</summary>
        public static Engine Encode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Encode[" + arg0 + "]", name);
        }

        ///<summary>
        ///produces an encoded file that must be read in using Get["dest","key"].
        ///https://reference.wolfram.com/language/ref/Encode.html
        ///</summary>
        public static Engine Encode(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Encode[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///encrypts expr using the specified password, to give an encrypted object.
        ///https://reference.wolfram.com/language/ref/Encrypt.html
        ///</summary>
        public static Engine Encrypt(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Encrypt[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///interactively requests a password with which to encrypt expr.
        ///https://reference.wolfram.com/language/ref/Encrypt.html
        ///</summary>
        public static Engine Encrypt(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Encrypt[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents encrypted data generated by Encrypt.
        ///https://reference.wolfram.com/language/ref/EncryptedObject.html
        ///</summary>
        public static Engine EncryptedObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EncryptedObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates an encrypted version of a file, using the specified password.
        ///https://reference.wolfram.com/language/ref/EncryptFile.html
        ///</summary>
        public static Engine EncryptFile(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EncryptFile[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates an encrypted version of source, putting the result in target.
        ///https://reference.wolfram.com/language/ref/EncryptFile.html
        ///</summary>
        public static Engine EncryptFile(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EncryptFile[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the present context, and reverts to the previous one.
        ///https://reference.wolfram.com/language/ref/End.html
        ///</summary>
        public static Engine End(this Engine en, string? name = null)
        {
            return en.Execute("End[]", name);
        }

        ///<summary>
        ///is a WSTP packet indicating the end of the Dialog subsession referenced by integer.
        ///https://reference.wolfram.com/language/ref/EndDialogPacket.html
        ///</summary>
        public static Engine EndDialogPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EndDialogPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///restores $Context and $ContextPath to their values before the preceding BeginPackage, and prepends the current context to the list $ContextPath.
        ///https://reference.wolfram.com/language/ref/EndPackage.html
        ///</summary>
        public static Engine EndPackage(this Engine en, string? name = null)
        {
            return en.Execute("EndPackage[]", name);
        }

        ///<summary>
        ///prints with all real numbers in expr given in engineering notation.
        ///https://reference.wolfram.com/language/ref/EngineeringForm.html
        ///</summary>
        public static Engine EngineeringForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EngineeringForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with numbers given to n‐digit precision.
        ///https://reference.wolfram.com/language/ref/EngineeringForm.html
        ///</summary>
        public static Engine EngineeringForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EngineeringForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that requests the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/EnterExpressionPacket.html
        ///</summary>
        public static Engine EnterExpressionPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EnterExpressionPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that requests the parsing and evaluation of string as an expression.
        ///https://reference.wolfram.com/language/ref/EnterTextPacket.html
        ///</summary>
        public static Engine EnterTextPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EnterTextPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an entity of the specified type, identified by name.
        ///https://reference.wolfram.com/language/ref/Entity.html
        ///</summary>
        public static Engine Entity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Entity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a class of entities of the specified type identified by name.
        ///https://reference.wolfram.com/language/ref/EntityClass.html
        ///</summary>
        public static Engine EntityClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an implicitly defined entity class containing entities of the specified type for which the properties propertyi conform to the value selector vspeci.
        ///https://reference.wolfram.com/language/ref/EntityClass.html
        ///</summary>
        public static Engine EntityClass(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EntityClass[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of entity classes for the specified type of entity.
        ///https://reference.wolfram.com/language/ref/EntityClassList.html
        ///</summary>
        public static Engine EntityClassList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EntityClassList[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents n copies of entity.
        ///https://reference.wolfram.com/language/ref/EntityCopies.html
        ///</summary>
        public static Engine EntityCopies(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityCopies[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a function with a single formal parameter x, to be used in EntityValue and related functions.
        ///https://reference.wolfram.com/language/ref/EntityFunction.html
        ///</summary>
        public static Engine EntityFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an EntityFunction with a list of formal parameters.
        ///https://reference.wolfram.com/language/ref/EntityFunction.html
        ///</summary>
        public static Engine EntityFunction(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a group of entities.
        ///https://reference.wolfram.com/language/ref/EntityGroup.html
        ///</summary>
        public static Engine EntityGroup(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EntityGroup[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents an entity whose qualifier qual has value val.
        ///https://reference.wolfram.com/language/ref/EntityInstance.html
        ///</summary>
        public static Engine EntityInstance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityInstance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an entity whose qualifiers quali have values vali.
        ///https://reference.wolfram.com/language/ref/EntityInstance.html
        ///</summary>
        public static Engine EntityInstance(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EntityInstance[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of entities in the specified entity class.
        ///https://reference.wolfram.com/language/ref/EntityList.html
        ///</summary>
        public static Engine EntityList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EntityList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of entities; simplify determines whether to reduce entities to the simplest possible type.
        ///https://reference.wolfram.com/language/ref/EntityList.html
        ///</summary>
        public static Engine EntityList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///fetches cacheable values associated with all entities of the specified type.
        ///https://reference.wolfram.com/language/ref/EntityPrefetch.html
        ///</summary>
        public static Engine EntityPrefetch(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EntityPrefetch[" + arg0 + "]", name);
        }

        ///<summary>
        ///lists properties associated with entity type type.
        ///https://reference.wolfram.com/language/ref/EntityProperties.html
        ///</summary>
        public static Engine EntityProperties(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EntityProperties[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a property identified by pname for use in EntityValue.
        ///https://reference.wolfram.com/language/ref/EntityProperty.html
        ///</summary>
        public static Engine EntityProperty(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityProperty[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a property modified by the qualifier rules qualivali.
        ///https://reference.wolfram.com/language/ref/EntityProperty.html
        ///</summary>
        public static Engine EntityProperty(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("EntityProperty[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents a class of properties identified by the name pcname.
        ///https://reference.wolfram.com/language/ref/EntityPropertyClass.html
        ///</summary>
        public static Engine EntityPropertyClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityPropertyClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///registers the entities in the entity store estore so that they can be accessed directly using Entity.
        ///https://reference.wolfram.com/language/ref/EntityRegister.html
        ///</summary>
        public static Engine EntityRegister(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EntityRegister[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an empty entity store for entities of type "type".
        ///https://reference.wolfram.com/language/ref/EntityStore.html
        ///</summary>
        public static Engine EntityStore(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EntityStore[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an entity store for entities of multiple types.
        ///https://reference.wolfram.com/language/ref/EntityStore.html
        ///</summary>
        public static Engine EntityStore(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EntityStore[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///constructs an entity store by mapping table names in the database specified by dbspec to types as specified by the tspeci.
        ///https://reference.wolfram.com/language/ref/EntityStore.html
        ///</summary>
        public static Engine EntityStore(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityStore[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of all registered entity stores that are accessed when Entity is used.
        ///https://reference.wolfram.com/language/ref/EntityStores.html
        ///</summary>
        public static Engine EntityStores(this Engine en, string? name = null)
        {
            return en.Execute("EntityStores[]", name);
        }

        ///<summary>
        ///gives the name of the entity type of entity.
        ///https://reference.wolfram.com/language/ref/EntityTypeName.html
        ///</summary>
        public static Engine EntityTypeName(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EntityTypeName[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the name of the entity type for entity1 through entityn.
        ///https://reference.wolfram.com/language/ref/EntityTypeName.html
        ///</summary>
        public static Engine EntityTypeName(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EntityTypeName[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///unregisters all entities in the first entity store that defines entities of the specified type.
        ///https://reference.wolfram.com/language/ref/EntityUnregister.html
        ///</summary>
        public static Engine EntityUnregister(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EntityUnregister[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the given entity.
        ///https://reference.wolfram.com/language/ref/EntityValue.html
        ///</summary>
        public static Engine EntityValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of values of the specified property for each of the entityi.
        ///https://reference.wolfram.com/language/ref/EntityValue.html
        ///</summary>
        public static Engine EntityValue(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EntityValue[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of values of the propertyi for the specified entity.
        ///https://reference.wolfram.com/language/ref/EntityValue.html
        ///</summary>
        public static Engine EntityValue(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EntityValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the base  information entropy of the values in list.
        ///https://reference.wolfram.com/language/ref/Entropy.html
        ///</summary>
        public static Engine Entropy(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Entropy[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the base k information entropy.
        ///https://reference.wolfram.com/language/ref/Entropy.html
        ///</summary>
        public static Engine Entropy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Entropy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the entropy value in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/EntropyFilter.html
        ///</summary>
        public static Engine EntropyFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EntropyFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses ri for filtering the dimension in data.
        ///https://reference.wolfram.com/language/ref/EntropyFilter.html
        ///</summary>
        public static Engine EntropyFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EntropyFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of an operating system environment variable.
        ///https://reference.wolfram.com/language/ref/Environment.html
        ///</summary>
        public static Engine Environment(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Environment[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/EqualTilde.html
        ///</summary>
        public static Engine EqualTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EqualTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x==y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/EqualTo.html
        ///</summary>
        public static Engine EqualTo(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EqualTo[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Equilibrium.html
        ///</summary>
        public static Engine Equilibrium(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Equilibrium[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///creates a finite impulse response (FIR) filter kernel of length n with an equiripple amplitude response, given the specified left and right band edge frequencies {ωLi,ωRi} and amplitudes ai.
        ///https://reference.wolfram.com/language/ref/EquirippleFilterKernel.html
        ///</summary>
        public static Engine EquirippleFilterKernel(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("EquirippleFilterKernel[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///uses relative weights wi for each frequency band.
        ///https://reference.wolfram.com/language/ref/EquirippleFilterKernel.html
        ///</summary>
        public static Engine EquirippleFilterKernel(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, List<object> arg3, object arg4, string? name = null)
        {
            return en.Execute("EquirippleFilterKernel[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///creates a filter of the specified "type".
        ///https://reference.wolfram.com/language/ref/EquirippleFilterKernel.html
        ///</summary>
        public static Engine EquirippleFilterKernel(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("EquirippleFilterKernel[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the logical equivalence e1⇔e2⇔…, giving True when all of the ei are the same.
        ///https://reference.wolfram.com/language/ref/Equivalent.html
        ///</summary>
        public static Engine Equivalent(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Equivalent[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the error function .
        ///https://reference.wolfram.com/language/ref/Erf.html
        ///</summary>
        public static Engine Erf(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Erf[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generalized error function .
        ///https://reference.wolfram.com/language/ref/Erf.html
        ///</summary>
        public static Engine Erf(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Erf[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the complementary error function .
        ///https://reference.wolfram.com/language/ref/Erfc.html
        ///</summary>
        public static Engine Erfc(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Erfc[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the imaginary error function .
        ///https://reference.wolfram.com/language/ref/Erfi.html
        ///</summary>
        public static Engine Erfi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Erfi[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes the Erlang B loss probability for an M/M/c/c queue.
        ///https://reference.wolfram.com/language/ref/ErlangB.html
        ///</summary>
        public static Engine ErlangB(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ErlangB[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes the Erlang C probability for nonzero waiting time in an M/M/c queue.
        ///https://reference.wolfram.com/language/ref/ErlangC.html
        ///</summary>
        public static Engine ErlangC(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ErlangC[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Erlang distribution with shape parameter k and rate λ.
        ///https://reference.wolfram.com/language/ref/ErlangDistribution.html
        ///</summary>
        public static Engine ErlangDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ErlangDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the morphological erosion of image with respect to the structuring element ker.
        ///https://reference.wolfram.com/language/ref/Erosion.html
        ///</summary>
        public static Engine Erosion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Erosion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents boxes that cannot be interpreted in input or output.
        ///https://reference.wolfram.com/language/ref/ErrorBox.html
        ///</summary>
        public static Engine ErrorBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ErrorBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the background of data.
        ///https://reference.wolfram.com/language/ref/EstimatedBackground.html
        ///</summary>
        public static Engine EstimatedBackground(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EstimatedBackground[" + arg0 + "]", name);
        }

        ///<summary>
        ///tries to preserve peaks up to scale σ.
        ///https://reference.wolfram.com/language/ref/EstimatedBackground.html
        ///</summary>
        public static Engine EstimatedBackground(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EstimatedBackground[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the parametric distribution dist from data.
        ///https://reference.wolfram.com/language/ref/EstimatedDistribution.html
        ///</summary>
        public static Engine EstimatedDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EstimatedDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the parameters p, q, … with starting values p0, q0, ….
        ///https://reference.wolfram.com/language/ref/EstimatedDistribution.html
        ///</summary>
        public static Engine EstimatedDistribution(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("EstimatedDistribution[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///estimates distribution dist with starting values taken from the instantiated distribution idist.
        ///https://reference.wolfram.com/language/ref/EstimatedDistribution.html
        ///</summary>
        public static Engine EstimatedDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EstimatedDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///estimates normal vectors for the points p1,p2,….
        ///https://reference.wolfram.com/language/ref/EstimatedPointNormals.html
        ///</summary>
        public static Engine EstimatedPointNormals(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EstimatedPointNormals[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///estimates normals vectors for the vertices of the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/EstimatedPointNormals.html
        ///</summary>
        public static Engine EstimatedPointNormals(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EstimatedPointNormals[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the parametric point process pproc from point data pdata.
        ///https://reference.wolfram.com/language/ref/EstimatedPointProcess.html
        ///</summary>
        public static Engine EstimatedPointProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EstimatedPointProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the parameters p, q, … with starting values p0, q0, ….
        ///https://reference.wolfram.com/language/ref/EstimatedPointProcess.html
        ///</summary>
        public static Engine EstimatedPointProcess(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("EstimatedPointProcess[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///estimates the parametric process proc from data.
        ///https://reference.wolfram.com/language/ref/EstimatedProcess.html
        ///</summary>
        public static Engine EstimatedProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EstimatedProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the parameters p, q, … with starting values p0, q0, ….
        ///https://reference.wolfram.com/language/ref/EstimatedProcess.html
        ///</summary>
        public static Engine EstimatedProcess(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("EstimatedProcess[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///estimates process proc with starting values taken from the instantiated process iproc.
        ///https://reference.wolfram.com/language/ref/EstimatedProcess.html
        ///</summary>
        public static Engine EstimatedProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EstimatedProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///estimates the best variogram function from values vali given at locations loci.
        ///https://reference.wolfram.com/language/ref/EstimatedVariogramModel.html
        ///</summary>
        public static Engine EstimatedVariogramModel(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EstimatedVariogramModel[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///estimates the best parameters of the variogram function specified by "model".
        ///https://reference.wolfram.com/language/ref/EstimatedVariogramModel.html
        ///</summary>
        public static Engine EstimatedVariogramModel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EstimatedVariogramModel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the non-numeric parameters in params.
        ///https://reference.wolfram.com/language/ref/EstimatedVariogramModel.html
        ///</summary>
        public static Engine EstimatedVariogramModel(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EstimatedVariogramModel[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the estimator gain matrix for the StateSpaceModel ssm, such that the poles of the estimator are pi.
        ///https://reference.wolfram.com/language/ref/EstimatorGains.html
        ///</summary>
        public static Engine EstimatorGains(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EstimatorGains[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///specifies the measured outputs outi to use.
        ///https://reference.wolfram.com/language/ref/EstimatorGains.html
        ///</summary>
        public static Engine EstimatorGains(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("EstimatorGains[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the output feedback controller with estimator and regulator gains l and κ for the system specification sspec.
        ///https://reference.wolfram.com/language/ref/EstimatorRegulator.html
        ///</summary>
        public static Engine EstimatorRegulator(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EstimatorRegulator[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the property "prop".
        ///https://reference.wolfram.com/language/ref/EstimatorRegulator.html
        ///</summary>
        public static Engine EstimatorRegulator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EstimatorRegulator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Euclidean distance between vectors u and v.
        ///https://reference.wolfram.com/language/ref/EuclideanDistance.html
        ///</summary>
        public static Engine EuclideanDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EuclideanDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives Euler angles {α,β,γ} corresponding to the rotation matrix r.
        ///https://reference.wolfram.com/language/ref/EulerAngles.html
        ///</summary>
        public static Engine EulerAngles(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EulerAngles[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives Euler angles {α,β,γ} with rotation order {a,b,c}.
        ///https://reference.wolfram.com/language/ref/EulerAngles.html
        ///</summary>
        public static Engine EulerAngles(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EulerAngles[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Euler characteristic of a poly.
        ///https://reference.wolfram.com/language/ref/EulerCharacteristic.html
        ///</summary>
        public static Engine EulerCharacteristic(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EulerCharacteristic[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Euler number .
        ///https://reference.wolfram.com/language/ref/EulerE.html
        ///</summary>
        public static Engine EulerE(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EulerE[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Euler polynomial .
        ///https://reference.wolfram.com/language/ref/EulerE.html
        ///</summary>
        public static Engine EulerE(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("EulerE[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is Eulerian, and False otherwise.
        ///https://reference.wolfram.com/language/ref/EulerianGraphQ.html
        ///</summary>
        public static Engine EulerianGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EulerianGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Euler 3D rotation matrix formed by rotating by α around the current  axis, then by β around the current  axis, and then by γ around the current  axis.
        ///https://reference.wolfram.com/language/ref/EulerMatrix.html
        ///</summary>
        public static Engine EulerMatrix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EulerMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Euler 3D rotation matrix corresponding, first rotating by α around the current a axis, then by β around the current b axis, and finally by γ around the current c axis.
        ///https://reference.wolfram.com/language/ref/EulerMatrix.html
        ///</summary>
        public static Engine EulerMatrix(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EulerMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Euler totient function .
        ///https://reference.wolfram.com/language/ref/EulerPhi.html
        ///</summary>
        public static Engine EulerPhi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EulerPhi[" + arg0 + "]", name);
        }

        ///<summary>
        ///causes expr to be evaluated even if it appears as the argument of a function whose attributes specify that it should be held unevaluated.
        ///https://reference.wolfram.com/language/ref/Evaluate.html
        ///</summary>
        public static Engine Evaluate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Evaluate[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet requesting evaluation of expr.
        ///https://reference.wolfram.com/language/ref/EvaluatePacket.html
        ///</summary>
        public static Engine EvaluatePacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EvaluatePacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a BoxObject corresponding to the box structure in which this function is being evaluated.
        ///https://reference.wolfram.com/language/ref/EvaluationBox.html
        ///</summary>
        public static Engine EvaluationBox(this Engine en, string? name = null)
        {
            return en.Execute("EvaluationBox[]", name);
        }

        ///<summary>
        ///returns a CellObject corresponding to the cell in which this function is being evaluated.
        ///https://reference.wolfram.com/language/ref/EvaluationCell.html
        ///</summary>
        public static Engine EvaluationCell(this Engine en, string? name = null)
        {
            return en.Execute("EvaluationCell[]", name);
        }

        ///<summary>
        ///gives an association containing the result of evaluating expr and metadata about the process of doing so.
        ///https://reference.wolfram.com/language/ref/EvaluationData.html
        ///</summary>
        public static Engine EvaluationData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EvaluationData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the notebook in which this function is being evaluated.
        ///https://reference.wolfram.com/language/ref/EvaluationNotebook.html
        ///</summary>
        public static Engine EvaluationNotebook(this Engine en, string? name = null)
        {
            return en.Execute("EvaluationNotebook[]", name);
        }

        ///<summary>
        ///represents an expression submitted for evaluation on any available parallel kernel.
        ///https://reference.wolfram.com/language/ref/EvaluationObject.html
        ///</summary>
        public static Engine EvaluationObject(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("EvaluationObject[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives True if expr is an even integer, and False otherwise.
        ///https://reference.wolfram.com/language/ref/EvenQ.html
        ///</summary>
        public static Engine EvenQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("EvenQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents event data with explicitly specified censoring ei.
        ///https://reference.wolfram.com/language/ref/EventData.html
        ///</summary>
        public static Engine EventData(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("EventData[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents event data ei with censoring indicators cii.
        ///https://reference.wolfram.com/language/ref/EventData.html
        ///</summary>
        public static Engine EventData(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EventData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents event data with censoring and truncation tri.
        ///https://reference.wolfram.com/language/ref/EventData.html
        ///</summary>
        public static Engine EventData(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("EventData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///displays as expr, evaluating actioni whenever "eventi" occurs in connection with expr.
        ///https://reference.wolfram.com/language/ref/EventHandler.html
        ///</summary>
        public static Engine EventHandler(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EventHandler[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a series of events given as time-value pairs {ti,vi}.
        ///https://reference.wolfram.com/language/ref/EventSeries.html
        ///</summary>
        public static Engine EventSeries(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("EventSeries[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a series of events with values vi at times specified by tspec.
        ///https://reference.wolfram.com/language/ref/EventSeries.html
        ///</summary>
        public static Engine EventSeries(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("EventSeries[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an exact Blackman window function of x.
        ///https://reference.wolfram.com/language/ref/ExactBlackmanWindow.html
        ///</summary>
        public static Engine ExactBlackmanWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExactBlackmanWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if expr is an exact real or complex number, and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/ExactNumberQ.html
        ///</summary>
        public static Engine ExactNumberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExactNumberQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of names of examples of the specified type.
        ///https://reference.wolfram.com/language/ref/ExampleData.html
        ///</summary>
        public static Engine ExampleData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExampleData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the default form of the named example of the specified type.
        ///https://reference.wolfram.com/language/ref/ExampleData.html
        ///</summary>
        public static Engine ExampleData(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ExampleData[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the specified element or property of an example.
        ///https://reference.wolfram.com/language/ref/ExampleData.html
        ///</summary>
        public static Engine ExampleData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ExampleData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a pattern object which represents any expression except one that matches c.
        ///https://reference.wolfram.com/language/ref/Except.html
        ///</summary>
        public static Engine Except(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Except[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents any expression that matches p but not c.
        ///https://reference.wolfram.com/language/ref/Except.html
        ///</summary>
        public static Engine Except(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Except[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the statement that there exists a value of x for which expr is True.
        ///https://reference.wolfram.com/language/ref/Exists.html
        ///</summary>
        public static Engine Exists(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Exists[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///states that there exists an x satisfying the condition cond for which expr is True.
        ///https://reference.wolfram.com/language/ref/Exists.html
        ///</summary>
        public static Engine Exists(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Exists[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///states that there exist values for all the  for which expr is True.
        ///https://reference.wolfram.com/language/ref/Exists.html
        ///</summary>
        public static Engine Exists(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Exists[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///terminates a Wolfram Language kernel session.
        ///https://reference.wolfram.com/language/ref/Exit.html
        ///</summary>
        public static Engine Exit(this Engine en, string? name = null)
        {
            return en.Execute("Exit[]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the exoplanet entity.
        ///https://reference.wolfram.com/language/ref/ExoplanetData.html
        ///</summary>
        public static Engine ExoplanetData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExoplanetData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified exoplanet entities.
        ///https://reference.wolfram.com/language/ref/ExoplanetData.html
        ///</summary>
        public static Engine ExoplanetData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ExoplanetData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/ExoplanetData.html
        ///</summary>
        public static Engine ExoplanetData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ExoplanetData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the exponential of z.
        ///https://reference.wolfram.com/language/ref/Exp.html
        ///</summary>
        public static Engine Exp(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Exp[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands out products and positive integer powers in expr.
        ///https://reference.wolfram.com/language/ref/Expand.html
        ///</summary>
        public static Engine Expand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Expand[" + arg0 + "]", name);
        }

        ///<summary>
        ///leaves unexpanded any parts of expr that are free of the pattern patt. »
        ///https://reference.wolfram.com/language/ref/Expand.html
        ///</summary>
        public static Engine Expand(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Expand[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///expands out all products and integer powers in any part of expr.
        ///https://reference.wolfram.com/language/ref/ExpandAll.html
        ///</summary>
        public static Engine ExpandAll(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpandAll[" + arg0 + "]", name);
        }

        ///<summary>
        ///avoids expanding parts of expr that do not contain terms matching the pattern patt.
        ///https://reference.wolfram.com/language/ref/ExpandAll.html
        ///</summary>
        public static Engine ExpandAll(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExpandAll[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///expands out products and powers that appear as denominators in expr.
        ///https://reference.wolfram.com/language/ref/ExpandDenominator.html
        ///</summary>
        public static Engine ExpandDenominator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpandDenominator[" + arg0 + "]", name);
        }

        ///<summary>
        ///textually expands name to have the form of an absolute file name for your operating system.
        ///https://reference.wolfram.com/language/ref/ExpandFileName.html
        ///</summary>
        public static Engine ExpandFileName(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpandFileName[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands out products and powers that appear in the numerator of expr.
        ///https://reference.wolfram.com/language/ref/ExpandNumerator.html
        ///</summary>
        public static Engine ExpandNumerator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpandNumerator[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the expectation of expr under the assumption that x follows the probability distribution dist.
        ///https://reference.wolfram.com/language/ref/Expectation.html
        ///</summary>
        public static Engine Expectation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Expectation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the expectation of expr under the assumption that x1, x2, … are independent and follow the distributions dist1, dist2, ….
        ///https://reference.wolfram.com/language/ref/Expectation.html
        ///</summary>
        public static Engine Expectation(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Expectation[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an exp-gamma distribution with shape parameter κ, scale parameter θ, and location parameter μ.
        ///https://reference.wolfram.com/language/ref/ExpGammaDistribution.html
        ///</summary>
        public static Engine ExpGammaDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ExpGammaDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the exponential integral function .
        ///https://reference.wolfram.com/language/ref/ExpIntegralE.html
        ///</summary>
        public static Engine ExpIntegralE(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExpIntegralE[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the exponential integral function .
        ///https://reference.wolfram.com/language/ref/ExpIntegralEi.html
        ///</summary>
        public static Engine ExpIntegralEi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpIntegralEi[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the maximum power with which form appears in the expanded form of expr.
        ///https://reference.wolfram.com/language/ref/Exponent.html
        ///</summary>
        public static Engine Exponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Exponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies h to the set of exponents with which form appears in expr.
        ///https://reference.wolfram.com/language/ref/Exponent.html
        ///</summary>
        public static Engine Exponent(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Exponent[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an exponential distribution with scale inversely proportional to parameter λ.
        ///https://reference.wolfram.com/language/ref/ExponentialDistribution.html
        ///</summary>
        public static Engine ExponentialDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExponentialDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the exponential generating function in x for the sequence whose n term is given by the expression expr.
        ///https://reference.wolfram.com/language/ref/ExponentialGeneratingFunction.html
        ///</summary>
        public static Engine ExponentialGeneratingFunction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ExponentialGeneratingFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional exponential generating function in x1, x2, … whose n1, n2, … term is given by expr.
        ///https://reference.wolfram.com/language/ref/ExponentialGeneratingFunction.html
        ///</summary>
        public static Engine ExponentialGeneratingFunction(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ExponentialGeneratingFunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the exponential moving average of list with smoothing constant α.
        ///https://reference.wolfram.com/language/ref/ExponentialMovingAverage.html
        ///</summary>
        public static Engine ExponentialMovingAverage(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExponentialMovingAverage[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an exponential power distribution with shape parameter κ, location parameter μ, and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/ExponentialPowerDistribution.html
        ///</summary>
        public static Engine ExponentialPowerDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ExponentialPowerDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an exponential power distribution with location parameter 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/ExponentialPowerDistribution.html
        ///</summary>
        public static Engine ExponentialPowerDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExponentialPowerDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///exports data to a file, converting it to the format corresponding to the file extension ext.
        ///https://reference.wolfram.com/language/ref/Export.html
        ///</summary>
        public static Engine Export(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Export[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///exports data in the specified format "fmt".
        ///https://reference.wolfram.com/language/ref/Export.html
        ///</summary>
        public static Engine Export(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Export[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses the specified options.
        ///https://reference.wolfram.com/language/ref/Export.html
        ///</summary>
        public static Engine Export(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Export[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///generates a ByteArray object corresponding to expr exported in the specified format.
        ///https://reference.wolfram.com/language/ref/ExportByteArray.html
        ///</summary>
        public static Engine ExportByteArray(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExportByteArray[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that expr should be exported in the specified format in functions like CloudDeploy and in external results from APIFunction and FormFunction.
        ///https://reference.wolfram.com/language/ref/ExportForm.html
        ///</summary>
        public static Engine ExportForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExportForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that when expr is exported, it should be tagged as having the specified MIME type.
        ///https://reference.wolfram.com/language/ref/ExportForm.html
        ///</summary>
        public static Engine ExportForm(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ExportForm[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a string corresponding to expr exported in the specified format.
        ///https://reference.wolfram.com/language/ref/ExportString.html
        ///</summary>
        public static Engine ExportString(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExportString[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives explicit rules for different elements of the data to be exported.
        ///https://reference.wolfram.com/language/ref/ExportString.html
        ///</summary>
        public static Engine ExportString(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ExportString[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives an expression cell that can appear in a Wolfram System notebook.
        ///https://reference.wolfram.com/language/ref/ExpressionCell.html
        ///</summary>
        public static Engine ExpressionCell(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpressionCell[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an expression cell with the specified style.
        ///https://reference.wolfram.com/language/ref/ExpressionCell.html
        ///</summary>
        public static Engine ExpressionCell(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExpressionCell[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an expression cell with multiple styles applied to it.
        ///https://reference.wolfram.com/language/ref/ExpressionCell.html
        ///</summary>
        public static Engine ExpressionCell(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ExpressionCell[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the tree graph with different levels at different depths.
        ///https://reference.wolfram.com/language/ref/ExpressionGraph.html
        ///</summary>
        public static Engine ExpressionGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpressionGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the tree graph only down to level n.
        ///https://reference.wolfram.com/language/ref/ExpressionGraph.html
        ///</summary>
        public static Engine ExpressionGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExpressionGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a tree graph in which subexpressions that match form are leaves.
        ///https://reference.wolfram.com/language/ref/ExpressionGraph.html
        ///</summary>
        public static Engine ExpressionGraph(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ExpressionGraph[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a Tree object from the structure of the expression expr.
        ///https://reference.wolfram.com/language/ref/ExpressionTree.html
        ///</summary>
        public static Engine ExpressionTree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpressionTree[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a Tree object from the expression expr with data and subtrees as specified by struct.
        ///https://reference.wolfram.com/language/ref/ExpressionTree.html
        ///</summary>
        public static Engine ExpressionTree(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExpressionTree[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts exponentials in expr to trigonometric functions.
        ///https://reference.wolfram.com/language/ref/ExpToTrig.html
        ///</summary>
        public static Engine ExpToTrig(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExpToTrig[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an entity class derived from class by adding a new computed property "name" whose value for each entity is obtained by applying the entity function f.
        ///https://reference.wolfram.com/language/ref/ExtendedEntityClass.html
        ///</summary>
        public static Engine ExtendedEntityClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExtendedEntityClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds the properties namei defined by the functions fi.
        ///https://reference.wolfram.com/language/ref/ExtendedEntityClass.html
        ///</summary>
        public static Engine ExtendedEntityClass(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ExtendedEntityClass[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the extended greatest common divisor of the integers ni.
        ///https://reference.wolfram.com/language/ref/ExtendedGCD.html
        ///</summary>
        public static Engine ExtendedGCD(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ExtendedGCD[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a bundle of resources to be externally deployed as named URLs, functions, etc.
        ///https://reference.wolfram.com/language/ref/ExternalBundle.html
        ///</summary>
        public static Engine ExternalBundle(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ExternalBundle[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates the command cmd in the external evaluator sys, returning an expression corresponding to the output.
        ///https://reference.wolfram.com/language/ref/ExternalEvaluate.html
        ///</summary>
        public static Engine ExternalEvaluate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalEvaluate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the options opts for the external evaluator.
        ///https://reference.wolfram.com/language/ref/ExternalEvaluate.html
        ///</summary>
        public static Engine ExternalEvaluate(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalEvaluate[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates the list of commands cmdi.
        ///https://reference.wolfram.com/language/ref/ExternalEvaluate.html
        ///</summary>
        public static Engine ExternalEvaluate(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ExternalEvaluate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of ExternalEvaluate that can be applied to a command or object.
        ///https://reference.wolfram.com/language/ref/ExternalEvaluate.html
        ///</summary>
        public static Engine ExternalEvaluate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalEvaluate[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an external function named "f" defined in the external evaluator sys.
        ///https://reference.wolfram.com/language/ref/ExternalFunction.html
        ///</summary>
        public static Engine ExternalFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a resource identified by id in the external identifier system "type".
        ///https://reference.wolfram.com/language/ref/ExternalIdentifier.html
        ///</summary>
        public static Engine ExternalIdentifier(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalIdentifier[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///includes the metadata given by the association meta to this instance of the external identifier object.
        ///https://reference.wolfram.com/language/ref/ExternalIdentifier.html
        ///</summary>
        public static Engine ExternalIdentifier(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ExternalIdentifier[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an external object inside an ExternalSessionObject.
        ///https://reference.wolfram.com/language/ref/ExternalObject.html
        ///</summary>
        public static Engine ExternalObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an external session started by StartExternalSession for use with ExternalEvaluate.
        ///https://reference.wolfram.com/language/ref/ExternalSessionObject.html
        ///</summary>
        public static Engine ExternalSessionObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalSessionObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of currently active external evaluator sessions.
        ///https://reference.wolfram.com/language/ref/ExternalSessions.html
        ///</summary>
        public static Engine ExternalSessions(this Engine en, string? name = null)
        {
            return en.Execute("ExternalSessions[]", name);
        }

        ///<summary>
        ///gives the list of sessions associated with the system sys.
        ///https://reference.wolfram.com/language/ref/ExternalSessions.html
        ///</summary>
        public static Engine ExternalSessions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalSessions[" + arg0 + "]", name);
        }

        ///<summary>
        ///downloads content from the specified location.
        ///https://reference.wolfram.com/language/ref/ExternalStorageDownload.html
        ///</summary>
        public static Engine ExternalStorageDownload(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalStorageDownload[" + arg0 + "]", name);
        }

        ///<summary>
        ///downloads content from the specified location to a local destination file or directory dest.
        ///https://reference.wolfram.com/language/ref/ExternalStorageDownload.html
        ///</summary>
        public static Engine ExternalStorageDownload(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalStorageDownload[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///downloads content from the specified locations to local destination dest.
        ///https://reference.wolfram.com/language/ref/ExternalStorageDownload.html
        ///</summary>
        public static Engine ExternalStorageDownload(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalStorageDownload[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///downloads content from the specified locations to local destinations.
        ///https://reference.wolfram.com/language/ref/ExternalStorageDownload.html
        ///</summary>
        public static Engine ExternalStorageDownload(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ExternalStorageDownload[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///reads in an expression stored at an external storage specified by the ExternalStorageObject.
        ///https://reference.wolfram.com/language/ref/ExternalStorageGet.html
        ///</summary>
        public static Engine ExternalStorageGet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalStorageGet[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a file stored in an external location.
        ///https://reference.wolfram.com/language/ref/ExternalStorageObject.html
        ///</summary>
        public static Engine ExternalStorageObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalStorageObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a file stored in an external location with additional elements given by assoc.
        ///https://reference.wolfram.com/language/ref/ExternalStorageObject.html
        ///</summary>
        public static Engine ExternalStorageObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalStorageObject[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///writes expr to an external storage specified by $ExternalStorageBase.
        ///https://reference.wolfram.com/language/ref/ExternalStoragePut.html
        ///</summary>
        public static Engine ExternalStoragePut(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalStoragePut[" + arg0 + "]", name);
        }

        ///<summary>
        ///writes expr to a specific path in an external storage specified by $ExternalStorageBase.
        ///https://reference.wolfram.com/language/ref/ExternalStoragePut.html
        ///</summary>
        public static Engine ExternalStoragePut(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalStoragePut[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uploads file to an external storage specified by $ExternalStorageBase.
        ///https://reference.wolfram.com/language/ref/ExternalStorageUpload.html
        ///</summary>
        public static Engine ExternalStorageUpload(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExternalStorageUpload[" + arg0 + "]", name);
        }

        ///<summary>
        ///uploads file to a specific destination dest for external storage services that support it.
        ///https://reference.wolfram.com/language/ref/ExternalStorageUpload.html
        ///</summary>
        public static Engine ExternalStorageUpload(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalStorageUpload[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uploads a list of files to a specific destination dest for external storage services that support it.
        ///https://reference.wolfram.com/language/ref/ExternalStorageUpload.html
        ///</summary>
        public static Engine ExternalStorageUpload(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalStorageUpload[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uploads a list of files to specific destinations for external storage services that support it.
        ///https://reference.wolfram.com/language/ref/ExternalStorageUpload.html
        ///</summary>
        public static Engine ExternalStorageUpload(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ExternalStorageUpload[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of "sym" in external evaluator sys.
        ///https://reference.wolfram.com/language/ref/ExternalValue.html
        ///</summary>
        public static Engine ExternalValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExternalValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///extracts the part of expr at the position specified by pos.
        ///https://reference.wolfram.com/language/ref/Extract.html
        ///</summary>
        public static Engine Extract(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Extract[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///extracts a list of parts of expr.
        ///https://reference.wolfram.com/language/ref/Extract.html
        ///</summary>
        public static Engine Extract(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Extract[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///extracts parts of expr, wrapping each of them with head h before evaluation.
        ///https://reference.wolfram.com/language/ref/Extract.html
        ///</summary>
        public static Engine Extract(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Extract[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of Extract that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Extract.html
        ///</summary>
        public static Engine Extract(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Extract[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands an archive file, saving its content into the current directory.
        ///https://reference.wolfram.com/language/ref/ExtractArchive.html
        ///</summary>
        public static Engine ExtractArchive(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExtractArchive[" + arg0 + "]", name);
        }

        ///<summary>
        ///saves the content of an archive file into directory dir.
        ///https://reference.wolfram.com/language/ref/ExtractArchive.html
        ///</summary>
        public static Engine ExtractArchive(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExtractArchive[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///extracts only files whose names match pattern.
        ///https://reference.wolfram.com/language/ref/ExtractArchive.html
        ///</summary>
        public static Engine ExtractArchive(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ExtractArchive[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a net layer that takes an array and a position specification as inputs and extracts the specified parts from the array.
        ///https://reference.wolfram.com/language/ref/ExtractLayer.html
        ///</summary>
        public static Engine ExtractLayer(this Engine en, string? name = null)
        {
            return en.Execute("ExtractLayer[]", name);
        }

        ///<summary>
        ///extracts the contents of the paclet archive file into the directory in which file resides.
        ///https://reference.wolfram.com/language/ref/ExtractPacletArchive.html
        ///</summary>
        public static Engine ExtractPacletArchive(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ExtractPacletArchive[" + arg0 + "]", name);
        }

        ///<summary>
        ///extracts the contents of the paclet archive file into destdir.
        ///https://reference.wolfram.com/language/ref/ExtractPacletArchive.html
        ///</summary>
        public static Engine ExtractPacletArchive(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExtractPacletArchive[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an extreme value distribution with location parameter α and scale parameter β.
        ///https://reference.wolfram.com/language/ref/ExtremeValueDistribution.html
        ///</summary>
        public static Engine ExtremeValueDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ExtremeValueDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an extreme value distribution with location parameter 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/ExtremeValueDistribution.html
        ///</summary>
        public static Engine ExtremeValueDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ExtremeValueDistribution[]", name);
        }


    }
}
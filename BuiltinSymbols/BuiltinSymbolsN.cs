namespace NetWolf
{
    public static class BuiltinSymbolN
    {
        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSquareSubset.html
        ///</summary>
        public static Engine NotSquareSubset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSquareSubset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSquareSubsetEqual.html
        ///</summary>
        public static Engine NotSquareSubsetEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSquareSubsetEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotRightTriangleEqual.html
        ///</summary>
        public static Engine NotRightTriangleEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotRightTriangleEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a disjunction of equations which represent numerical approximations to the roots of a polynomial equation. 
        ///https://reference.wolfram.com/language/ref/NRoots.html
        ///</summary>
        public static Engine NRoots(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NRoots[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a layer that has no input and produces as output a constant array.
        ///https://reference.wolfram.com/language/ref/NetArrayLayer.html
        ///</summary>
        public static Engine NetArrayLayer(this Engine en, string? name = null)
        {
            return en.Execute("NetArrayLayer[]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the nuclear explosion entity.
        ///https://reference.wolfram.com/language/ref/NuclearExplosionData.html
        ///</summary>
        public static Engine NuclearExplosionData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NuclearExplosionData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLessFullEqual.html
        ///</summary>
        public static Engine NotLessFullEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLessFullEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a numerical approximation to the sum .
        ///https://reference.wolfram.com/language/ref/NSum.html
        ///</summary>
        public static Engine NSum(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NSum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///loads an appropriate file if the specified context is not already in $Packages. 
        ///https://reference.wolfram.com/language/ref/Needs.html
        ///</summary>
        public static Engine Needs(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Needs[" + arg0 + "]", name);
        }

        ///<summary>
        ///loads an appropriate file if the specified context is not already in $Packages. 
        ///https://reference.wolfram.com/language/ref/Needs.html
        ///</summary>
        public static Engine Needs(this Engine en, string? name = null)
        {
            return en.Execute("Needs[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a decoder that takes a net representation and decodes it into an expression of a given form.
        ///https://reference.wolfram.com/language/ref/NetDecoder.html
        ///</summary>
        public static Engine NetDecoder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetDecoder[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a decoder that takes a net representation and decodes it into an expression of a given form.
        ///https://reference.wolfram.com/language/ref/NetDecoder.html
        ///</summary>
        public static Engine NetDecoder(this Engine en, string? name = null)
        {
            return en.Execute("NetDecoder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLeftTriangleEqual.html
        ///</summary>
        public static Engine NotLeftTriangleEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLeftTriangleEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSuperset.html
        ///</summary>
        public static Engine NotSuperset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSuperset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSucceedsEqual.html
        ///</summary>
        public static Engine NotSucceedsEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSucceedsEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///converts expr to a normal expression from a variety of special forms. 
        ///https://reference.wolfram.com/language/ref/Normal.html
        ///</summary>
        public static Engine Normal(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Normal[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts expr to a normal expression from a variety of special forms. 
        ///https://reference.wolfram.com/language/ref/Normal.html
        ///</summary>
        public static Engine Normal(this Engine en, string? name = null)
        {
            return en.Execute("Normal[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if x is a negative number. 
        ///https://reference.wolfram.com/language/ref/Negative.html
        ///</summary>
        public static Engine Negative(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Negative[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if x is a negative number. 
        ///https://reference.wolfram.com/language/ref/Negative.html
        ///</summary>
        public static Engine Negative(this Engine en, string? name = null)
        {
            return en.Execute("Negative[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a position xmax at which f is numerically maximized.
        ///https://reference.wolfram.com/language/ref/NArgMax.html
        ///</summary>
        public static Engine NArgMax(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NArgMax[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes the n from a NetChain or NetGraph.
        ///https://reference.wolfram.com/language/ref/NetDelete.html
        ///</summary>
        public static Engine NetDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotNestedLessLess.html
        ///</summary>
        public static Engine NotNestedLessLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotNestedLessLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the results of applying f to expr 0 through n times. 
        ///https://reference.wolfram.com/language/ref/NestList.html
        ///</summary>
        public static Engine NestList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NestList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the low‐level construct that represents a notebook manipulated by the Wolfram System front end. 
        ///https://reference.wolfram.com/language/ref/Notebook.html
        ///</summary>
        public static Engine Notebook(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Notebook[" + arg0 + "]", name);
        }

        ///<summary>
        ///is the low‐level construct that represents a notebook manipulated by the Wolfram System front end. 
        ///https://reference.wolfram.com/language/ref/Notebook.html
        ///</summary>
        public static Engine Notebook(this Engine en, string? name = null)
        {
            return en.Execute("Notebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form that yields Nearest[elems,x] when applied to a list elems.
        ///https://reference.wolfram.com/language/ref/NearestTo.html
        ///</summary>
        public static Engine NearestTo(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NearestTo[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields Nearest[elems,x] when applied to a list elems.
        ///https://reference.wolfram.com/language/ref/NearestTo.html
        ///</summary>
        public static Engine NearestTo(this Engine en, string? name = null)
        {
            return en.Execute("NearestTo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a negative binomial distribution with parameters n and p.
        ///https://reference.wolfram.com/language/ref/NegativeBinomialDistribution.html
        ///</summary>
        public static Engine NegativeBinomialDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NegativeBinomialDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a Nichols plot of the transfer function for the system lsys.
        ///https://reference.wolfram.com/language/ref/NicholsPlot.html
        ///</summary>
        public static Engine NicholsPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NicholsPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a Nichols plot of the transfer function for the system lsys.
        ///https://reference.wolfram.com/language/ref/NicholsPlot.html
        ///</summary>
        public static Engine NicholsPlot(this Engine en, string? name = null)
        {
            return en.Execute("NicholsPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a numerical approximation to the integral . 
        ///https://reference.wolfram.com/language/ref/NIntegrate.html
        ///</summary>
        public static Engine NIntegrate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NIntegrate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        /// gives True if m is an explicitly normal matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/NormalMatrixQ.html
        ///</summary>
        public static Engine NormalMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NormalMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        /// gives True if m is an explicitly normal matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/NormalMatrixQ.html
        ///</summary>
        public static Engine NormalMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("NormalMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the class number for the algebraic number field  generated by .
        ///https://reference.wolfram.com/language/ref/NumberFieldClassNumber.html
        ///</summary>
        public static Engine NumberFieldClassNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberFieldClassNumber[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the class number for the algebraic number field  generated by .
        ///https://reference.wolfram.com/language/ref/NumberFieldClassNumber.html
        ///</summary>
        public static Engine NumberFieldClassNumber(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldClassNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens an existing notebook with the specified name, returning the corresponding notebook object. 
        ///https://reference.wolfram.com/language/ref/NotebookOpen.html
        ///</summary>
        public static Engine NotebookOpen(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookOpen[" + arg0 + "]", name);
        }

        ///<summary>
        ///opens an existing notebook with the specified name, returning the corresponding notebook object. 
        ///https://reference.wolfram.com/language/ref/NotebookOpen.html
        ///</summary>
        public static Engine NotebookOpen(this Engine en, string? name = null)
        {
            return en.Execute("NotebookOpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the result of an n-body simulation.
        ///https://reference.wolfram.com/language/ref/NBodySimulationData.html
        ///</summary>
        public static Engine NBodySimulationData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NBodySimulationData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the result of an n-body simulation.
        ///https://reference.wolfram.com/language/ref/NBodySimulationData.html
        ///</summary>
        public static Engine NBodySimulationData(this Engine en, string? name = null)
        {
            return en.Execute("NBodySimulationData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of notebooks currently open in the front end.
        ///https://reference.wolfram.com/language/ref/Notebooks.html
        ///</summary>
        public static Engine Notebooks(this Engine en, string? name = null)
        {
            return en.Execute("Notebooks[]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotVerticalBar.html
        ///</summary>
        public static Engine NotVerticalBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotVerticalBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the graph neighborhood of a vertex v in the graph g.
        ///https://reference.wolfram.com/language/ref/NeighborhoodGraph.html
        ///</summary>
        public static Engine NeighborhoodGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NeighborhoodGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotCongruent.html
        ///</summary>
        public static Engine NotCongruent(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotCongruent[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///imports cells with the given cell style from the specified notebook.
        ///https://reference.wolfram.com/language/ref/NotebookImport.html
        ///</summary>
        public static Engine NotebookImport(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NotebookImport[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net that takes a pair of arrays, embeds them into a vector space using net, and outputs the distance under the embedding.
        ///https://reference.wolfram.com/language/ref/NetPairEmbeddingOperator.html
        ///</summary>
        public static Engine NetPairEmbeddingOperator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetPairEmbeddingOperator[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net that takes a pair of arrays, embeds them into a vector space using net, and outputs the distance under the embedding.
        ///https://reference.wolfram.com/language/ref/NetPairEmbeddingOperator.html
        ///</summary>
        public static Engine NetPairEmbeddingOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetPairEmbeddingOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotExists.html
        ///</summary>
        public static Engine NotExists(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NotExists[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///extracts the value of a parameter for the specified net layer.
        ///https://reference.wolfram.com/language/ref/NetExtract.html
        ///</summary>
        public static Engine NetExtract(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetExtract[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotGreaterFullEqual.html
        ///</summary>
        public static Engine NotGreaterFullEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotGreaterFullEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of fundamental units for the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldFundamentalUnits.html
        ///</summary>
        public static Engine NumberFieldFundamentalUnits(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberFieldFundamentalUnits[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of fundamental units for the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldFundamentalUnits.html
        ///</summary>
        public static Engine NumberFieldFundamentalUnits(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldFundamentalUnits[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Neville theta function . 
        ///https://reference.wolfram.com/language/ref/NevilleThetaC.html
        ///</summary>
        public static Engine NevilleThetaC(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NevilleThetaC[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a net in which the name old for a layer is replaced with new.
        ///https://reference.wolfram.com/language/ref/NetRename.html
        ///</summary>
        public static Engine NetRename(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetRename[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if test[ei] is False for all of the ei.
        ///https://reference.wolfram.com/language/ref/NoneTrue.html
        ///</summary>
        public static Engine NoneTrue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NoneTrue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts all ordinary arrays in net into NetSharedArray objects.
        ///https://reference.wolfram.com/language/ref/NetInsertSharedArrays.html
        ///</summary>
        public static Engine NetInsertSharedArrays(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetInsertSharedArrays[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts all ordinary arrays in net into NetSharedArray objects.
        ///https://reference.wolfram.com/language/ref/NetInsertSharedArrays.html
        ///</summary>
        public static Engine NetInsertSharedArrays(this Engine en, string? name = null)
        {
            return en.Execute("NetInsertSharedArrays[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLessGreater.html
        ///</summary>
        public static Engine NotLessGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLessGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list of elemi to which x is nearest. 
        ///https://reference.wolfram.com/language/ref/Nearest.html
        ///</summary>
        public static Engine Nearest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Nearest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///attempts to find numerical approximations to the solutions of the system expr of equations or inequalities for the variables vars. 
        ///https://reference.wolfram.com/language/ref/NSolve.html
        ///</summary>
        public static Engine NSolve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NSolve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///writes data into a notebook at the current selection, replacing the first selection placeholder in data by the current selection, and then setting the current selection to be just after the data written. 
        ///https://reference.wolfram.com/language/ref/NotebookApply.html
        ///</summary>
        public static Engine NotebookApply(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NotebookApply[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the nuclear reactor entity.
        ///https://reference.wolfram.com/language/ref/NuclearReactorData.html
        ///</summary>
        public static Engine NuclearReactorData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NuclearReactorData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes only those layers up to end in a NetChain or NetGraph.
        ///https://reference.wolfram.com/language/ref/NetTake.html
        ///</summary>
        public static Engine NetTake(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetTake[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the expression corresponding to the current selection in the specified notebook object. 
        ///https://reference.wolfram.com/language/ref/NotebookRead.html
        ///</summary>
        public static Engine NotebookRead(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookRead[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the expression corresponding to the current selection in the specified notebook object. 
        ///https://reference.wolfram.com/language/ref/NotebookRead.html
        ///</summary>
        public static Engine NotebookRead(this Engine en, string? name = null)
        {
            return en.Execute("NotebookRead[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an object that represents an open notebook in the front end. 
        ///https://reference.wolfram.com/language/ref/NotebookObject.html
        ///</summary>
        public static Engine NotebookObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that represents an open notebook in the front end. 
        ///https://reference.wolfram.com/language/ref/NotebookObject.html
        ///</summary>
        public static Engine NotebookObject(this Engine en, string? name = null)
        {
            return en.Execute("NotebookObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLessEqual.html
        ///</summary>
        public static Engine NotLessEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLessEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives 1 if e1<e2, -1 if e1>e2, 0 if e1 and e2 are identical or numerically the same and Order[e1,e2] if e1 and e2 are not numerically comparable.
        ///https://reference.wolfram.com/language/ref/NumericalOrder.html
        ///</summary>
        public static Engine NumericalOrder(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NumericalOrder[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a numeric cache object for a quantity with exact value x and approximate numerical value xn.
        ///https://reference.wolfram.com/language/ref/NCache.html
        ///</summary>
        public static Engine NCache(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NCache[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///inserts a layer into a NetChain before the layer at position i.
        ///https://reference.wolfram.com/language/ref/NetInsert.html
        ///</summary>
        public static Engine NetInsert(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NetInsert[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a net that applies net to a sequence and to its reverse, concatenating both results into one output sequence.
        ///https://reference.wolfram.com/language/ref/NetBidirectionalOperator.html
        ///</summary>
        public static Engine NetBidirectionalOperator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetBidirectionalOperator[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net that applies net to a sequence and to its reverse, concatenating both results into one output sequence.
        ///https://reference.wolfram.com/language/ref/NetBidirectionalOperator.html
        ///</summary>
        public static Engine NetBidirectionalOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetBidirectionalOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of vectors that forms a basis for the null space of the matrix m. 
        ///https://reference.wolfram.com/language/ref/NullSpace.html
        ///</summary>
        public static Engine NullSpace(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NullSpace[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of vectors that forms a basis for the null space of the matrix m. 
        ///https://reference.wolfram.com/language/ref/NullSpace.html
        ///</summary>
        public static Engine NullSpace(this Engine en, string? name = null)
        {
            return en.Execute("NullSpace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a net in which all layers matching patt are replaced with layer.
        ///https://reference.wolfram.com/language/ref/NetReplace.html
        ///</summary>
        public static Engine NetReplace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetReplace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the discriminant of the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldDiscriminant.html
        ///</summary>
        public static Engine NumberFieldDiscriminant(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberFieldDiscriminant[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the discriminant of the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldDiscriminant.html
        ///</summary>
        public static Engine NumberFieldDiscriminant(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldDiscriminant[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the regulator of the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldRegulator.html
        ///</summary>
        public static Engine NumberFieldRegulator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberFieldRegulator[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the regulator of the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldRegulator.html
        ///</summary>
        public static Engine NumberFieldRegulator(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldRegulator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is a valid NumericArray object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/NumericArrayQ.html
        ///</summary>
        public static Engine NumericArrayQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumericArrayQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a valid NumericArray object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/NumericArrayQ.html
        ///</summary>
        public static Engine NumericArrayQ(this Engine en, string? name = null)
        {
            return en.Execute("NumericArrayQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a net in which net is mapped over a sequence of inputs to give a sequence of outputs.
        ///https://reference.wolfram.com/language/ref/NetMapOperator.html
        ///</summary>
        public static Engine NetMapOperator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetMapOperator[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net in which net is mapped over a sequence of inputs to give a sequence of outputs.
        ///https://reference.wolfram.com/language/ref/NetMapOperator.html
        ///</summary>
        public static Engine NetMapOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetMapOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///collapses nested NetChain and NetGraph objects within net.
        ///https://reference.wolfram.com/language/ref/NetFlatten.html
        ///</summary>
        public static Engine NetFlatten(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetFlatten[" + arg0 + "]", name);
        }

        ///<summary>
        ///collapses nested NetChain and NetGraph objects within net.
        ///https://reference.wolfram.com/language/ref/NetFlatten.html
        ///</summary>
        public static Engine NetFlatten(this Engine en, string? name = null)
        {
            return en.Execute("NetFlatten[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///adds children to each leaf of tree, with f[expr] giving the list of data for the new children of a leaf with data expr.
        ///https://reference.wolfram.com/language/ref/NestTree.html
        ///</summary>
        public static Engine NestTree(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NestTree[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLess.html
        ///</summary>
        public static Engine NotLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///removes the first n layers from a NetChain.
        ///https://reference.wolfram.com/language/ref/NetDrop.html
        ///</summary>
        public static Engine NetDrop(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetDrop[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the next occurring date of the specified granularity type gran.
        ///https://reference.wolfram.com/language/ref/NextDate.html
        ///</summary>
        public static Engine NextDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NextDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the next occurring date of the specified granularity type gran.
        ///https://reference.wolfram.com/language/ref/NextDate.html
        ///</summary>
        public static Engine NextDate(this Engine en, string? name = null)
        {
            return en.Execute("NextDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a simulation of the motion of a system of n bodies with initial states statei, governed by the specified potential or force law, over a length of time t.
        ///https://reference.wolfram.com/language/ref/NBodySimulation.html
        ///</summary>
        public static Engine NBodySimulation(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NBodySimulation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///prints with approximate real numbers in expr given to n‐digit precision. 
        ///https://reference.wolfram.com/language/ref/NumberForm.html
        ///</summary>
        public static Engine NumberForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NumberForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs a nonlinear model with structure form that fits the yi for successive x values 1, 2, … using the parameters β1, ….
        ///https://reference.wolfram.com/language/ref/NonlinearModelFit.html
        ///</summary>
        public static Engine NonlinearModelFit(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("NonlinearModelFit[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the Neville theta function . 
        ///https://reference.wolfram.com/language/ref/NevilleThetaD.html
        ///</summary>
        public static Engine NevilleThetaD(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NevilleThetaD[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///maximizes f numerically with respect to x.
        ///https://reference.wolfram.com/language/ref/NMaximize.html
        ///</summary>
        public static Engine NMaximize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NMaximize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotPrecedes.html
        ///</summary>
        public static Engine NotPrecedes(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotPrecedes[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///sets the current selection in the specified notebook object to be the next occurrence of data. 
        ///https://reference.wolfram.com/language/ref/NotebookFind.html
        ///</summary>
        public static Engine NotebookFind(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NotebookFind[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr and returns information on network packets transmitted or received through all network interfaces on your computer during the time of the evaluation, together with the result of the evaluation. 
        ///https://reference.wolfram.com/language/ref/NetworkPacketTrace.html
        ///</summary>
        public static Engine NetworkPacketTrace(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetworkPacketTrace[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr and returns information on network packets transmitted or received through all network interfaces on your computer during the time of the evaluation, together with the result of the evaluation. 
        ///https://reference.wolfram.com/language/ref/NetworkPacketTrace.html
        ///</summary>
        public static Engine NetworkPacketTrace(this Engine en, string? name = null)
        {
            return en.Execute("NetworkPacketTrace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotRightTriangle.html
        ///</summary>
        public static Engine NotRightTriangle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotRightTriangle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotCupCap.html
        ///</summary>
        public static Engine NotCupCap(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotCupCap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///obtains a neural net model with the specified name from the Neural Net Repository. 
        ///https://reference.wolfram.com/language/ref/NetModel.html
        ///</summary>
        public static Engine NetModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///obtains a neural net model with the specified name from the Neural Net Repository. 
        ///https://reference.wolfram.com/language/ref/NetModel.html
        ///</summary>
        public static Engine NetModel(this Engine en, string? name = null)
        {
            return en.Execute("NetModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSupersetEqual.html
        ///</summary>
        public static Engine NotSupersetEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSupersetEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///connects a series of NetChain or NetGraph objects to form a single NetChain or NetGraph.
        ///https://reference.wolfram.com/language/ref/NetJoin.html
        ///</summary>
        public static Engine NetJoin(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NetJoin[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSquareSuperset.html
        ///</summary>
        public static Engine NotSquareSuperset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSquareSuperset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///evaluates all the evaluatable cells in notebook.
        ///https://reference.wolfram.com/language/ref/NotebookEvaluate.html
        ///</summary>
        public static Engine NotebookEvaluate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookEvaluate[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates all the evaluatable cells in notebook.
        ///https://reference.wolfram.com/language/ref/NotebookEvaluate.html
        ///</summary>
        public static Engine NotebookEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("NotebookEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces an array within a layer, returning a new layer.
        ///https://reference.wolfram.com/language/ref/NetReplacePart.html
        ///</summary>
        public static Engine NetReplacePart(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetReplacePart[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLessLess.html
        ///</summary>
        public static Engine NotLessLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLessLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotHumpDownHump.html
        ///</summary>
        public static Engine NotHumpDownHump(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotHumpDownHump[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents the half of the Earth currently in darkness.
        ///https://reference.wolfram.com/language/ref/NightHemisphere.html
        ///</summary>
        public static Engine NightHemisphere(this Engine en, string? name = null)
        {
            return en.Execute("NightHemisphere[]", name);
        }

        ///<summary>
        ///represents a function whose values give the elements closest to an element that is supplied.
        ///https://reference.wolfram.com/language/ref/NearestFunction.html
        ///</summary>
        public static Engine NearestFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NearestFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a function whose values give the elements closest to an element that is supplied.
        ///https://reference.wolfram.com/language/ref/NearestFunction.html
        ///</summary>
        public static Engine NearestFunction(this Engine en, string? name = null)
        {
            return en.Execute("NearestFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotGreaterGreater.html
        ///</summary>
        public static Engine NotGreaterGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotGreaterGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a normal (Gaussian) distribution with mean μ and standard deviation σ.
        ///https://reference.wolfram.com/language/ref/NormalDistribution.html
        ///</summary>
        public static Engine NormalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NormalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a position xmin at which f is numerically minimized.
        ///https://reference.wolfram.com/language/ref/NArgMin.html
        ///</summary>
        public static Engine NArgMin(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NArgMin[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the specified input or output port for a complete net.
        ///https://reference.wolfram.com/language/ref/NetPort.html
        ///</summary>
        public static Engine NetPort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetPort[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the specified input or output port for a complete net.
        ///https://reference.wolfram.com/language/ref/NetPort.html
        ///</summary>
        public static Engine NetPort(this Engine en, string? name = null)
        {
            return en.Execute("NetPort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSucceedsSlantEqual.html
        ///</summary>
        public static Engine NotSucceedsSlantEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSucceedsSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotGreater.html
        ///</summary>
        public static Engine NotGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives an integral basis for the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldIntegralBasis.html
        ///</summary>
        public static Engine NumberFieldIntegralBasis(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberFieldIntegralBasis[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an integral basis for the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldIntegralBasis.html
        ///</summary>
        public static Engine NumberFieldIntegralBasis(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldIntegralBasis[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of properties of the current evaluation notebook.
        ///https://reference.wolfram.com/language/ref/NotebookInformation.html
        ///</summary>
        public static Engine NotebookInformation(this Engine en, string? name = null)
        {
            return en.Execute("NotebookInformation[]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the nebula entity.
        ///https://reference.wolfram.com/language/ref/NebulaData.html
        ///</summary>
        public static Engine NebulaData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NebulaData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the gradient of the output of a net with respect to the value of the specified input port. 
        ///https://reference.wolfram.com/language/ref/NetPortGradient.html
        ///</summary>
        public static Engine NetPortGradient(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetPortGradient[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the gradient of the output of a net with respect to the value of the specified input port. 
        ///https://reference.wolfram.com/language/ref/NetPortGradient.html
        ///</summary>
        public static Engine NetPortGradient(this Engine en, string? name = null)
        {
            return en.Execute("NetPortGradient[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the file name of the current evaluation notebook. 
        ///https://reference.wolfram.com/language/ref/NotebookFileName.html
        ///</summary>
        public static Engine NotebookFileName(this Engine en, string? name = null)
        {
            return en.Execute("NotebookFileName[]", name);
        }

        ///<summary>
        ///gives an expression with f applied n times to expr. 
        ///https://reference.wolfram.com/language/ref/Nest.html
        ///</summary>
        public static Engine Nest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Nest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly negative definite, and False otherwise.
        ///https://reference.wolfram.com/language/ref/NegativeDefiniteMatrixQ.html
        ///</summary>
        public static Engine NegativeDefiniteMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NegativeDefiniteMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly negative definite, and False otherwise.
        ///https://reference.wolfram.com/language/ref/NegativeDefiniteMatrixQ.html
        ///</summary>
        public static Engine NegativeDefiniteMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("NegativeDefiniteMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to find numerical approximations to the values of vars determined by the solutions of the system expr.
        ///https://reference.wolfram.com/language/ref/NSolveValues.html
        ///</summary>
        public static Engine NSolveValues(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NSolveValues[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a noncentral beta distribution with shape parameters α, β and noncentrality parameter δ.
        ///https://reference.wolfram.com/language/ref/NoncentralBetaDistribution.html
        ///</summary>
        public static Engine NoncentralBetaDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NoncentralBetaDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a net in which net is folded over a sequence of inputs, maintaining a recurrent state.
        ///https://reference.wolfram.com/language/ref/NetFoldOperator.html
        ///</summary>
        public static Engine NetFoldOperator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetFoldOperator[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net in which net is folded over a sequence of inputs, maintaining a recurrent state.
        ///https://reference.wolfram.com/language/ref/NetFoldOperator.html
        ///</summary>
        public static Engine NetFoldOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetFoldOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an encoder that takes a given form of input and encodes it as an array for use in a net.
        ///https://reference.wolfram.com/language/ref/NetEncoder.html
        ///</summary>
        public static Engine NetEncoder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetEncoder[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an encoder that takes a given form of input and encodes it as an array for use in a net.
        ///https://reference.wolfram.com/language/ref/NetEncoder.html
        ///</summary>
        public static Engine NetEncoder(this Engine en, string? name = null)
        {
            return en.Execute("NetEncoder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly negative semidefinite, and False otherwise.
        ///https://reference.wolfram.com/language/ref/NegativeSemidefiniteMatrixQ.html
        ///</summary>
        public static Engine NegativeSemidefiniteMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NegativeSemidefiniteMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly negative semidefinite, and False otherwise.
        ///https://reference.wolfram.com/language/ref/NegativeSemidefiniteMatrixQ.html
        ///</summary>
        public static Engine NegativeSemidefiniteMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("NegativeSemidefiniteMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sends a notebook containing expr to your default printer.
        ///https://reference.wolfram.com/language/ref/NotebookPrint.html
        ///</summary>
        public static Engine NotebookPrint(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookPrint[" + arg0 + "]", name);
        }

        ///<summary>
        ///sends a notebook containing expr to your default printer.
        ///https://reference.wolfram.com/language/ref/NotebookPrint.html
        ///</summary>
        public static Engine NotebookPrint(this Engine en, string? name = null)
        {
            return en.Execute("NotebookPrint[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///saves the current version of the specified notebook. 
        ///https://reference.wolfram.com/language/ref/NotebookSave.html
        ///</summary>
        public static Engine NotebookSave(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookSave[" + arg0 + "]", name);
        }

        ///<summary>
        ///saves the current version of the specified notebook. 
        ///https://reference.wolfram.com/language/ref/NotebookSave.html
        ///</summary>
        public static Engine NotebookSave(this Engine en, string? name = null)
        {
            return en.Execute("NotebookSave[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the underlying type of values used for each element in the NumericArray object.
        ///https://reference.wolfram.com/language/ref/NumericArrayType.html
        ///</summary>
        public static Engine NumericArrayType(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumericArrayType[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the underlying type of values used for each element in the NumericArray object.
        ///https://reference.wolfram.com/language/ref/NumericArrayType.html
        ///</summary>
        public static Engine NumericArrayType(this Engine en, string? name = null)
        {
            return en.Execute("NumericArrayType[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sorts the elements of list into numerical order.
        ///https://reference.wolfram.com/language/ref/NumericalSort.html
        ///</summary>
        public static Engine NumericalSort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumericalSort[" + arg0 + "]", name);
        }

        ///<summary>
        ///sorts the elements of list into numerical order.
        ///https://reference.wolfram.com/language/ref/NumericalSort.html
        ///</summary>
        public static Engine NumericalSort(this Engine en, string? name = null)
        {
            return en.Execute("NumericalSort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a Nyquist plot of the transfer function for the system lsys.
        ///https://reference.wolfram.com/language/ref/NyquistPlot.html
        ///</summary>
        public static Engine NyquistPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NyquistPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a Nyquist plot of the transfer function for the system lsys.
        ///https://reference.wolfram.com/language/ref/NyquistPlot.html
        ///</summary>
        public static Engine NyquistPlot(this Engine en, string? name = null)
        {
            return en.Execute("NyquistPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotPrecedesEqual.html
        ///</summary>
        public static Engine NotPrecedesEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotPrecedesEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotTilde.html
        ///</summary>
        public static Engine NotTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///closes the notebook corresponding to the specified notebook object. 
        ///https://reference.wolfram.com/language/ref/NotebookClose.html
        ///</summary>
        public static Engine NotebookClose(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookClose[" + arg0 + "]", name);
        }

        ///<summary>
        ///closes the notebook corresponding to the specified notebook object. 
        ///https://reference.wolfram.com/language/ref/NotebookClose.html
        ///</summary>
        public static Engine NotebookClose(this Engine en, string? name = null)
        {
            return en.Execute("NotebookClose[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the roots of unity for the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldRootsOfUnity.html
        ///</summary>
        public static Engine NumberFieldRootsOfUnity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberFieldRootsOfUnity[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the roots of unity for the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldRootsOfUnity.html
        ///</summary>
        public static Engine NumberFieldRootsOfUnity(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldRootsOfUnity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotDoubleVerticalBar.html
        ///</summary>
        public static Engine NotDoubleVerticalBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotDoubleVerticalBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the n smallest magnitude eigenvalues and eigenfunctions for the linear differential operator ℒ over the region Ω.
        ///https://reference.wolfram.com/language/ref/NDEigensystem.html
        ///</summary>
        public static Engine NDEigensystem(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("NDEigensystem[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives True if x is a non‐positive number. 
        ///https://reference.wolfram.com/language/ref/NonPositive.html
        ///</summary>
        public static Engine NonPositive(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NonPositive[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if x is a non‐positive number. 
        ///https://reference.wolfram.com/language/ref/NonPositive.html
        ///</summary>
        public static Engine NonPositive(this Engine en, string? name = null)
        {
            return en.Execute("NonPositive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///specifies a neural net in which the output of layeri is connected to the input of layeri+1.
        ///https://reference.wolfram.com/language/ref/NetChain.html
        ///</summary>
        public static Engine NetChain(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetChain[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies a neural net in which the output of layeri is connected to the input of layeri+1.
        ///https://reference.wolfram.com/language/ref/NetChain.html
        ///</summary>
        public static Engine NetChain(this Engine en, string? name = null)
        {
            return en.Execute("NetChain[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the values vi on a number line.
        ///https://reference.wolfram.com/language/ref/NumberLinePlot.html
        ///</summary>
        public static Engine NumberLinePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberLinePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the values vi on a number line.
        ///https://reference.wolfram.com/language/ref/NumberLinePlot.html
        ///</summary>
        public static Engine NumberLinePlot(this Engine en, string? name = null)
        {
            return en.Execute("NumberLinePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the model , .
        ///https://reference.wolfram.com/language/ref/NonlinearStateSpaceModel.html
        ///</summary>
        public static Engine NonlinearStateSpaceModel(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NonlinearStateSpaceModel[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///starts with expr, then repeatedly applies f until applying test to the result no longer yields True. 
        ///https://reference.wolfram.com/language/ref/NestWhile.html
        ///</summary>
        public static Engine NestWhile(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NestWhile[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Neville theta function . 
        ///https://reference.wolfram.com/language/ref/NevilleThetaN.html
        ///</summary>
        public static Engine NevilleThetaN(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NevilleThetaN[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net in which mapnet is mapped over one or more inputs to give one or more outputs.
        ///https://reference.wolfram.com/language/ref/NetMapThreadOperator.html
        ///</summary>
        public static Engine NetMapThreadOperator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetMapThreadOperator[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net in which mapnet is mapped over one or more inputs to give one or more outputs.
        ///https://reference.wolfram.com/language/ref/NetMapThreadOperator.html
        ///</summary>
        public static Engine NetMapThreadOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetMapThreadOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Neumann boundary value val, specified on the part of the boundary of the region given to NDSolve and related functions where pred is True.
        ///https://reference.wolfram.com/language/ref/NeumannValue.html
        ///</summary>
        public static Engine NeumannValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NeumannValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as x⪢y⪢….
        ///https://reference.wolfram.com/language/ref/NestedGreaterGreater.html
        ///</summary>
        public static Engine NestedGreaterGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NestedGreaterGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the indices for the cells to which the point pt is nearest in the mesh region mr.
        ///https://reference.wolfram.com/language/ref/NearestMeshCells.html
        ///</summary>
        public static Engine NearestMeshCells(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NearestMeshCells[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSquareSupersetEqual.html
        ///</summary>
        public static Engine NotSquareSupersetEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSquareSupersetEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotGreaterLess.html
        ///</summary>
        public static Engine NotGreaterLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotGreaterLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotGreaterEqual.html
        ///</summary>
        public static Engine NotGreaterEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotGreaterEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSucceedsTilde.html
        ///</summary>
        public static Engine NotSucceedsTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSucceedsTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a trainable net layer that normalizes its input data across the second and subsequent dimensions and applies an independent scaling and bias to each component of the first dimension.
        ///https://reference.wolfram.com/language/ref/NormalizationLayer.html
        ///</summary>
        public static Engine NormalizationLayer(this Engine en, string? name = null)
        {
            return en.Execute("NormalizationLayer[]", name);
        }

        ///<summary>
        ///creates an object derived from net that represents a neural net with additional stored state information that is updated when the net is applied to data.
        ///https://reference.wolfram.com/language/ref/NetStateObject.html
        ///</summary>
        public static Engine NetStateObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetStateObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates an object derived from net that represents a neural net with additional stored state information that is updated when the net is applied to data.
        ///https://reference.wolfram.com/language/ref/NetStateObject.html
        ///</summary>
        public static Engine NetStateObject(this Engine en, string? name = null)
        {
            return en.Execute("NetStateObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the quantity c1 u1+…+cn un.
        ///https://reference.wolfram.com/language/ref/NumberCompose.html
        ///</summary>
        public static Engine NumberCompose(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NumberCompose[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prepends a layer or a net onto a NetChain, a layer or a NetGraph with one input port.
        ///https://reference.wolfram.com/language/ref/NetPrepend.html
        ///</summary>
        public static Engine NetPrepend(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetPrepend[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotRightTriangleBar.html
        ///</summary>
        public static Engine NotRightTriangleBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotRightTriangleBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///trains the specified neural net by giving the inputi as input and minimizing the discrepancy between the outputi and the actual output of the net, using an automatically chosen loss function.
        ///https://reference.wolfram.com/language/ref/NetTrain.html
        ///</summary>
        public static Engine NetTrain(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetTrain[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net in which net is applied n times to the input.
        ///https://reference.wolfram.com/language/ref/NetNestOperator.html
        ///</summary>
        public static Engine NetNestOperator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetNestOperator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a noncentral  distribution with ν degrees of freedom and noncentrality parameter λ.
        ///https://reference.wolfram.com/language/ref/NoncentralChiSquareDistribution.html
        ///</summary>
        public static Engine NoncentralChiSquareDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NoncentralChiSquareDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a number representing the Needleman–Wunsch similarity between strings, vectors or biomolecular sequences u and v.
        ///https://reference.wolfram.com/language/ref/NeedlemanWunschSimilarity.html
        ///</summary>
        public static Engine NeedlemanWunschSimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NeedlemanWunschSimilarity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the neighborhood entity.
        ///https://reference.wolfram.com/language/ref/NeighborhoodData.html
        ///</summary>
        public static Engine NeighborhoodData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NeighborhoodData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gets the raw expression corresponding to the notebook represented by the notebook object obj. 
        ///https://reference.wolfram.com/language/ref/NotebookGet.html
        ///</summary>
        public static Engine NotebookGet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookGet[" + arg0 + "]", name);
        }

        ///<summary>
        ///gets the raw expression corresponding to the notebook represented by the notebook object obj. 
        ///https://reference.wolfram.com/language/ref/NotebookGet.html
        ///</summary>
        public static Engine NotebookGet(this Engine en, string? name = null)
        {
            return en.Execute("NotebookGet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a notebook corresponding to expr and makes it the currently selected notebook in the front end. 
        ///https://reference.wolfram.com/language/ref/NotebookPut.html
        ///</summary>
        public static Engine NotebookPut(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookPut[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a notebook corresponding to expr and makes it the currently selected notebook in the front end. 
        ///https://reference.wolfram.com/language/ref/NotebookPut.html
        ///</summary>
        public static Engine NotebookPut(this Engine en, string? name = null)
        {
            return en.Execute("NotebookPut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject that represents a notebook template to be applied using functions like GenerateDocument and FileTemplateApply.
        ///https://reference.wolfram.com/language/ref/NotebookTemplate.html
        ///</summary>
        public static Engine NotebookTemplate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookTemplate[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject that represents a notebook template to be applied using functions like GenerateDocument and FileTemplateApply.
        ///https://reference.wolfram.com/language/ref/NotebookTemplate.html
        ///</summary>
        public static Engine NotebookTemplate(this Engine en, string? name = null)
        {
            return en.Execute("NotebookTemplate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///applies a nonlocal means filter to image by comparing a range r neighborhood to its nearby neighborhoods.
        ///https://reference.wolfram.com/language/ref/NonlocalMeansFilter.html
        ///</summary>
        public static Engine NonlocalMeansFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NonlocalMeansFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the maximum value of f with respect to x.
        ///https://reference.wolfram.com/language/ref/NMaxValue.html
        ///</summary>
        public static Engine NMaxValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NMaxValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotPrecedesSlantEqual.html
        ///</summary>
        public static Engine NotPrecedesSlantEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotPrecedesSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the current selection in the current evaluation notebook in the front end.
        ///https://reference.wolfram.com/language/ref/NotebookSelection.html
        ///</summary>
        public static Engine NotebookSelection(this Engine en, string? name = null)
        {
            return en.Execute("NotebookSelection[]", name);
        }

        ///<summary>
        ///nondimensionalizes eq, replacing original variables ovars with the variables fvars.
        ///https://reference.wolfram.com/language/ref/NondimensionalizationTransform.html
        ///</summary>
        public static Engine NondimensionalizationTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NondimensionalizationTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///creates a numeric array of the specified type.
        ///https://reference.wolfram.com/language/ref/NumericArray.html
        ///</summary>
        public static Engine NumericArray(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NumericArray[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///locates all cells with the specified tag in your current input notebook, selecting the cells and scrolling to the position of the first one. 
        ///https://reference.wolfram.com/language/ref/NotebookLocate.html
        ///</summary>
        public static Engine NotebookLocate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookLocate[" + arg0 + "]", name);
        }

        ///<summary>
        ///locates all cells with the specified tag in your current input notebook, selecting the cells and scrolling to the position of the first one. 
        ///https://reference.wolfram.com/language/ref/NotebookLocate.html
        ///</summary>
        public static Engine NotebookLocate(this Engine en, string? name = null)
        {
            return en.Execute("NotebookLocate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of representatives of classes of algebraic integers of norm  in the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldNormRepresentatives.html
        ///</summary>
        public static Engine NumberFieldNormRepresentatives(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NumberFieldNormRepresentatives[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list of the results of applying f repeatedly, starting with expr, and continuing until applying test to the result no longer yields True. 
        ///https://reference.wolfram.com/language/ref/NestWhileList.html
        ///</summary>
        public static Engine NestWhileList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NestWhileList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLessSlantEqual.html
        ///</summary>
        public static Engine NotLessSlantEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLessSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSubset.html
        ///</summary>
        public static Engine NotSubset(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSubset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a network to perform generative adversarial network (GAN) training with a generative net generator and a classification net discriminator.
        ///https://reference.wolfram.com/language/ref/NetGANOperator.html
        ///</summary>
        public static Engine NetGANOperator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetGANOperator[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a network to perform generative adversarial network (GAN) training with a generative net generator and a classification net discriminator.
        ///https://reference.wolfram.com/language/ref/NetGANOperator.html
        ///</summary>
        public static Engine NetGANOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetGANOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the logical NOR function. It evaluates its arguments in order, giving False immediately if any of them are True, and True if they are all False. 
        ///https://reference.wolfram.com/language/ref/Nor.html
        ///</summary>
        public static Engine Nor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Nor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a number, and False otherwise. 
        ///https://reference.wolfram.com/language/ref/NumberQ.html
        ///</summary>
        public static Engine NumberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a number, and False otherwise. 
        ///https://reference.wolfram.com/language/ref/NumberQ.html
        ///</summary>
        public static Engine NumberQ(this Engine en, string? name = null)
        {
            return en.Execute("NumberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Neville theta function . 
        ///https://reference.wolfram.com/language/ref/NevilleThetaS.html
        ///</summary>
        public static Engine NevilleThetaS(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NevilleThetaS[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the nearest neighbor function  at radius r in the point data pdata.
        ///https://reference.wolfram.com/language/ref/NearestNeighborG.html
        ///</summary>
        public static Engine NearestNeighborG(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NearestNeighborG[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the numerical value of expr. 
        ///https://reference.wolfram.com/language/ref/N.html
        ///</summary>
        public static Engine N(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("N[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the numerical value of expr. 
        ///https://reference.wolfram.com/language/ref/N.html
        ///</summary>
        public static Engine N(this Engine en, string? name = null)
        {
            return en.Execute("N[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the signature of the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldSignature.html
        ///</summary>
        public static Engine NumberFieldSignature(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberFieldSignature[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the signature of the field  generated by the algebraic number .
        ///https://reference.wolfram.com/language/ref/NumberFieldSignature.html
        ///</summary>
        public static Engine NumberFieldSignature(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldSignature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the normalized form of a vector v. 
        ///https://reference.wolfram.com/language/ref/Normalize.html
        ///</summary>
        public static Engine Normalize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Normalize[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the normalized form of a vector v. 
        ///https://reference.wolfram.com/language/ref/Normalize.html
        ///</summary>
        public static Engine Normalize(this Engine en, string? name = null)
        {
            return en.Execute("Normalize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///computes the requested measurement for the net evaluated on data.
        ///https://reference.wolfram.com/language/ref/NetMeasurements.html
        ///</summary>
        public static Engine NetMeasurements(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NetMeasurements[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///deletes the current selection in the notebook corresponding to the specified notebook object. 
        ///https://reference.wolfram.com/language/ref/NotebookDelete.html
        ///</summary>
        public static Engine NotebookDelete(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NotebookDelete[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes the current selection in the notebook corresponding to the specified notebook object. 
        ///https://reference.wolfram.com/language/ref/NotebookDelete.html
        ///</summary>
        public static Engine NotebookDelete(this Engine en, string? name = null)
        {
            return en.Execute("NotebookDelete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotTildeEqual.html
        ///</summary>
        public static Engine NotTildeEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotTildeEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an object generated by NetTrain that contains the trained net and other information about the training process.
        ///https://reference.wolfram.com/language/ref/NetTrainResultsObject.html
        ///</summary>
        public static Engine NetTrainResultsObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetTrainResultsObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an object generated by NetTrain that contains the trained net and other information about the training process.
        ///https://reference.wolfram.com/language/ref/NetTrainResultsObject.html
        ///</summary>
        public static Engine NetTrainResultsObject(this Engine en, string? name = null)
        {
            return en.Execute("NetTrainResultsObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotGreaterSlantEqual.html
        ///</summary>
        public static Engine NotGreaterSlantEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotGreaterSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the sequence of points p1,p2,p3,…,pn is negatively oriented.
        ///https://reference.wolfram.com/language/ref/NegativelyOrientedPoints.html
        ///</summary>
        public static Engine NegativelyOrientedPoints(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NegativelyOrientedPoints[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the sequence of points p1,p2,p3,…,pn is negatively oriented.
        ///https://reference.wolfram.com/language/ref/NegativelyOrientedPoints.html
        ///</summary>
        public static Engine NegativelyOrientedPoints(this Engine en, string? name = null)
        {
            return en.Execute("NegativelyOrientedPoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the n smallest magnitude eigenvalues for the linear differential operator ℒ over the region Ω.
        ///https://reference.wolfram.com/language/ref/NDEigenvalues.html
        ///</summary>
        public static Engine NDEigenvalues(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("NDEigenvalues[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives the smallest prime above .
        ///https://reference.wolfram.com/language/ref/NextPrime.html
        ///</summary>
        public static Engine NextPrime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NextPrime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the smallest prime above .
        ///https://reference.wolfram.com/language/ref/NextPrime.html
        ///</summary>
        public static Engine NextPrime(this Engine en, string? name = null)
        {
            return en.Execute("NextPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a noncentral F-ratio distribution with n numerator degrees of freedom, m denominator degrees of freedom, and numerator noncentrality parameter λ.
        ///https://reference.wolfram.com/language/ref/NoncentralFRatioDistribution.html
        ///</summary>
        public static Engine NoncentralFRatioDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NoncentralFRatioDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NestedLessLess.html
        ///</summary>
        public static Engine NestedLessLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NestedLessLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a list of coefficients {c1,…,cn} of a decomposition of the number x in the basis {u1,…,un}.
        ///https://reference.wolfram.com/language/ref/NumberDecompose.html
        ///</summary>
        public static Engine NumberDecompose(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NumberDecompose[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a numeric quantity, and False otherwise. 
        ///https://reference.wolfram.com/language/ref/NumericQ.html
        ///</summary>
        public static Engine NumericQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumericQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a numeric quantity, and False otherwise. 
        ///https://reference.wolfram.com/language/ref/NumericQ.html
        ///</summary>
        public static Engine NumericQ(this Engine en, string? name = null)
        {
            return en.Execute("NumericQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if x is a non‐negative number. 
        ///https://reference.wolfram.com/language/ref/NonNegative.html
        ///</summary>
        public static Engine NonNegative(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NonNegative[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if x is a non‐negative number. 
        ///https://reference.wolfram.com/language/ref/NonNegative.html
        ///</summary>
        public static Engine NonNegative(this Engine en, string? name = null)
        {
            return en.Execute("NonNegative[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///writes data into a notebook at the current selection, setting the current selection to be just after the data written. 
        ///https://reference.wolfram.com/language/ref/NotebookWrite.html
        ///</summary>
        public static Engine NotebookWrite(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NotebookWrite[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotHumpEqual.html
        ///</summary>
        public static Engine NotHumpEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotHumpEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotPrecedesTilde.html
        ///</summary>
        public static Engine NotPrecedesTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotPrecedesTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the numerical probability for an event that satisfies the predicate pred under the assumption that x follows the probability distribution dist. 
        ///https://reference.wolfram.com/language/ref/NProbability.html
        ///</summary>
        public static Engine NProbability(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NProbability[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///minimizes f numerically with respect to x.
        ///https://reference.wolfram.com/language/ref/NMinimize.html
        ///</summary>
        public static Engine NMinimize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NMinimize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives Nørlund polynomials  of degree n in a.
        ///https://reference.wolfram.com/language/ref/NorlundB.html
        ///</summary>
        public static Engine NorlundB(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NorlundB[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSubsetEqual.html
        ///</summary>
        public static Engine NotSubsetEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSubsetEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies a neural net defined by a graph in which the output of layer mi is given as input to layer ni.
        ///https://reference.wolfram.com/language/ref/NetGraph.html
        ///</summary>
        public static Engine NetGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the numerical expectation of expr under the assumption that x follows the probability distribution dist.
        ///https://reference.wolfram.com/language/ref/NExpectation.html
        ///</summary>
        public static Engine NExpectation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NExpectation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///appends a layer or a net onto a NetChain, a layer or a NetGraph with one output port.
        ///https://reference.wolfram.com/language/ref/NetAppend.html
        ///</summary>
        public static Engine NetAppend(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NetAppend[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Nakagami distribution with shape parameter μ and spread parameter ω.
        ///https://reference.wolfram.com/language/ref/NakagamiDistribution.html
        ///</summary>
        public static Engine NakagamiDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NakagamiDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLessTilde.html
        ///</summary>
        public static Engine NotLessTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLessTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotTildeFullEqual.html
        ///</summary>
        public static Engine NotTildeFullEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotTildeFullEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a graph with vertices elem1,elem2,… and edges connecting each elemi to its nearest neighbors.
        ///https://reference.wolfram.com/language/ref/NearestNeighborGraph.html
        ///</summary>
        public static Engine NearestNeighborGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NearestNeighborGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a graph with vertices elem1,elem2,… and edges connecting each elemi to its nearest neighbors.
        ///https://reference.wolfram.com/language/ref/NearestNeighborGraph.html
        ///</summary>
        public static Engine NearestNeighborGraph(this Engine en, string? name = null)
        {
            return en.Execute("NearestNeighborGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a negative multinomial distribution with parameter n and failure probability vector p.
        ///https://reference.wolfram.com/language/ref/NegativeMultinomialDistribution.html
        ///</summary>
        public static Engine NegativeMultinomialDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NegativeMultinomialDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the directory of the current evaluation notebook. 
        ///https://reference.wolfram.com/language/ref/NotebookDirectory.html
        ///</summary>
        public static Engine NotebookDirectory(this Engine en, string? name = null)
        {
            return en.Execute("NotebookDirectory[]", name);
        }

        ///<summary>
        ///produces the elementary net of the folded net fnet, exposing the recurrent states.
        ///https://reference.wolfram.com/language/ref/NetUnfold.html
        ///</summary>
        public static Engine NetUnfold(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetUnfold[" + arg0 + "]", name);
        }

        ///<summary>
        ///produces the elementary net of the folded net fnet, exposing the recurrent states.
        ///https://reference.wolfram.com/language/ref/NetUnfold.html
        ///</summary>
        public static Engine NetUnfold(this Engine en, string? name = null)
        {
            return en.Execute("NetUnfold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotGreaterTilde.html
        ///</summary>
        public static Engine NotGreaterTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotGreaterTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Neyman–Scott point process with density function μ, cluster mean λ and radial cluster point distribution rdist in . 
        ///https://reference.wolfram.com/language/ref/NeymanScottPointProcess.html
        ///</summary>
        public static Engine NeymanScottPointProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("NeymanScottPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a noncentral Student  distribution with ν degrees of freedom and noncentrality parameter δ.
        ///https://reference.wolfram.com/language/ref/NoncentralStudentTDistribution.html
        ///</summary>
        public static Engine NoncentralStudentTDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NoncentralStudentTDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the digit corresponding to 10n in the real-valued number x.
        ///https://reference.wolfram.com/language/ref/NumberDigit.html
        ///</summary>
        public static Engine NumberDigit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NumberDigit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///or x∉dom asserts that  is not an element of the domain dom.
        ///https://reference.wolfram.com/language/ref/NotElement.html
        ///</summary>
        public static Engine NotElement(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NotElement[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph obtained by starting with expr and applying f successively n times.
        ///https://reference.wolfram.com/language/ref/NestGraph.html
        ///</summary>
        public static Engine NestGraph(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NestGraph[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Nuttall window function of x.
        ///https://reference.wolfram.com/language/ref/NuttallWindow.html
        ///</summary>
        public static Engine NuttallWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NuttallWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Nuttall window function of x.
        ///https://reference.wolfram.com/language/ref/NuttallWindow.html
        ///</summary>
        public static Engine NuttallWindow(this Engine en, string? name = null)
        {
            return en.Execute("NuttallWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a numerical approximation to the product .
        ///https://reference.wolfram.com/language/ref/NProduct.html
        ///</summary>
        public static Engine NProduct(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NProduct[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the norm of a number, vector, or matrix. 
        ///https://reference.wolfram.com/language/ref/Norm.html
        ///</summary>
        public static Engine Norm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Norm[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the norm of a number, vector, or matrix. 
        ///https://reference.wolfram.com/language/ref/Norm.html
        ///</summary>
        public static Engine Norm(this Engine en, string? name = null)
        {
            return en.Execute("Norm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if there are any symbols whose names match the string pattern given, and yields False otherwise. 
        ///https://reference.wolfram.com/language/ref/NameQ.html
        ///</summary>
        public static Engine NameQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NameQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if there are any symbols whose names match the string pattern given, and yields False otherwise. 
        ///https://reference.wolfram.com/language/ref/NameQ.html
        ///</summary>
        public static Engine NameQ(this Engine en, string? name = null)
        {
            return en.Execute("NameQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotSucceeds.html
        ///</summary>
        public static Engine NotSucceeds(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotSucceeds[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotReverseElement.html
        ///</summary>
        public static Engine NotReverseElement(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotReverseElement[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an array in a net.
        ///https://reference.wolfram.com/language/ref/NetArray.html
        ///</summary>
        public static Engine NetArray(this Engine en, string? name = null)
        {
            return en.Execute("NetArray[]", name);
        }

        ///<summary>
        ///returns the CellObject corresponding to the cell directly below the currently evaluating cell.
        ///https://reference.wolfram.com/language/ref/NextCell.html
        ///</summary>
        public static Engine NextCell(this Engine en, string? name = null)
        {
            return en.Execute("NextCell[]", name);
        }

        ///<summary>
        ///gives a net in which all uninitialized learnable parameters in net have been given initial values.
        ///https://reference.wolfram.com/language/ref/NetInitialize.html
        ///</summary>
        public static Engine NetInitialize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetInitialize[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a net in which all uninitialized learnable parameters in net have been given initial values.
        ///https://reference.wolfram.com/language/ref/NetInitialize.html
        ///</summary>
        public static Engine NetInitialize(this Engine en, string? name = null)
        {
            return en.Execute("NetInitialize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the numerator of expr. 
        ///https://reference.wolfram.com/language/ref/Numerator.html
        ///</summary>
        public static Engine Numerator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Numerator[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the numerator of expr. 
        ///https://reference.wolfram.com/language/ref/Numerator.html
        ///</summary>
        public static Engine Numerator(this Engine en, string? name = null)
        {
            return en.Execute("Numerator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a numerical solution to the ordinary differential equations eqns for the function u with the independent variable x in the range xmin to xmax. 
        ///https://reference.wolfram.com/language/ref/NDSolve.html
        ///</summary>
        public static Engine NDSolve(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NDSolve[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotTildeTilde.html
        ///</summary>
        public static Engine NotTildeTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotTildeTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the normalized squared Euclidean distance between vectors u and v.
        ///https://reference.wolfram.com/language/ref/NormalizedSquaredEuclideanDistance.html
        ///</summary>
        public static Engine NormalizedSquaredEuclideanDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NormalizedSquaredEuclideanDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///creates a temporary interactive interface for capturing information on network packets transmitted or received through all network interfaces on your computer.
        ///https://reference.wolfram.com/language/ref/NetworkPacketCapture.html
        ///</summary>
        public static Engine NetworkPacketCapture(this Engine en, string? name = null)
        {
            return en.Execute("NetworkPacketCapture[]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLeftTriangle.html
        ///</summary>
        public static Engine NotLeftTriangle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLeftTriangle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the minimum value of f with respect to x.
        ///https://reference.wolfram.com/language/ref/NMinValue.html
        ///</summary>
        public static Engine NMinValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("NMinValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the decimal digits of x multiplied by their corresponding powers of 10. 
        ///https://reference.wolfram.com/language/ref/NumberExpand.html
        ///</summary>
        public static Engine NumberExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumberExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the decimal digits of x multiplied by their corresponding powers of 10. 
        ///https://reference.wolfram.com/language/ref/NumberExpand.html
        ///</summary>
        public static Engine NumberExpand(this Engine en, string? name = null)
        {
            return en.Execute("NumberExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the names of symbols that match the string. 
        ///https://reference.wolfram.com/language/ref/Names.html
        ///</summary>
        public static Engine Names(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Names[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the names of symbols that match the string. 
        ///https://reference.wolfram.com/language/ref/Names.html
        ///</summary>
        public static Engine Names(this Engine en, string? name = null)
        {
            return en.Execute("Names[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotEqualTilde.html
        ///</summary>
        public static Engine NotEqualTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotEqualTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotNestedGreaterGreater.html
        ///</summary>
        public static Engine NotNestedGreaterGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotNestedGreaterGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list {Numerator[expr],Denominator[expr]} of expr.
        ///https://reference.wolfram.com/language/ref/NumeratorDenominator.html
        ///</summary>
        public static Engine NumeratorDenominator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NumeratorDenominator[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list {Numerator[expr],Denominator[expr]} of expr.
        ///https://reference.wolfram.com/language/ref/NumeratorDenominator.html
        ///</summary>
        public static Engine NumeratorDenominator(this Engine en, string? name = null)
        {
            return en.Execute("NumeratorDenominator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/NotLeftTriangleBar.html
        ///</summary>
        public static Engine NotLeftTriangleBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NotLeftTriangleBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///records information on network packets transmitted or received through all network interfaces on your computer for t seconds.
        ///https://reference.wolfram.com/language/ref/NetworkPacketRecording.html
        ///</summary>
        public static Engine NetworkPacketRecording(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NetworkPacketRecording[" + arg0 + "]", name);
        }

        ///<summary>
        ///records information on network packets transmitted or received through all network interfaces on your computer for t seconds.
        ///https://reference.wolfram.com/language/ref/NetworkPacketRecording.html
        ///</summary>
        public static Engine NetworkPacketRecording(this Engine en, string? name = null)
        {
            return en.Execute("NetworkPacketRecording[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of expr with functions determined by a numerical solution to the ordinary differential equations eqns with the independent variable x in the range xmin to xmax. 
        ///https://reference.wolfram.com/language/ref/NDSolveValue.html
        ///</summary>
        public static Engine NDSolveValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("NDSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the logical NAND function. It evaluates its arguments in order, giving True immediately if any of them are False, and False if they are all True. 
        ///https://reference.wolfram.com/language/ref/Nand.html
        ///</summary>
        public static Engine Nand(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Nand[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a set of unordered categories cati. 
        ///https://reference.wolfram.com/language/ref/NominalScale.html
        ///</summary>
        public static Engine NominalScale(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("NominalScale[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a set of unordered categories cati. 
        ///https://reference.wolfram.com/language/ref/NominalScale.html
        ///</summary>
        public static Engine NominalScale(this Engine en, string? name = null)
        {
            return en.Execute("NominalScale[" + en.ValidNames.Last() + "]", name);
        }


    }
}
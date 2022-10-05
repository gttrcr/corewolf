namespace NetWolf
{
    public static class BuiltinSymbolU
    {
        ///<summary>
        ///gives 0 when x is zero, and 1 when x has any other numerical value.
        ///https://reference.wolfram.com/language/ref/Unitize.html
        ///</summary>
        public static Engine Unitize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Unitize[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives 0 when x is zero, and 1 when x has any other numerical value.
        ///https://reference.wolfram.com/language/ref/Unitize.html
        ///</summary>
        public static Engine Unitize(this Engine en, string? name = null)
        {
            return en.Execute("Unitize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a symbolic specification that represents up to n objects or positions. If n objects or positions are available, all are used. If fewer are available, only those available are used.
        ///https://reference.wolfram.com/language/ref/UpTo.html
        ///</summary>
        public static Engine UpTo(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UpTo[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a symbolic specification that represents up to n objects or positions. If n objects or positions are available, all are used. If fewer are available, only those available are used.
        ///https://reference.wolfram.com/language/ref/UpTo.html
        ///</summary>
        public static Engine UpTo(this Engine en, string? name = null)
        {
            return en.Execute("UpTo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the total number of seconds since the beginning of January 1, 1970, in the GMT time zone.
        ///https://reference.wolfram.com/language/ref/UnixTime.html
        ///</summary>
        public static Engine UnixTime(this Engine en, string? name = null)
        {
            return en.Execute("UnixTime[]", name);
        }

        ///<summary>
        ///gives a matrix in which all but the upper triangular elements of m are replaced with zeros. 
        ///https://reference.wolfram.com/language/ref/UpperTriangularize.html
        ///</summary>
        public static Engine UpperTriangularize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UpperTriangularize[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a matrix in which all but the upper triangular elements of m are replaced with zeros. 
        ///https://reference.wolfram.com/language/ref/UpperTriangularize.html
        ///</summary>
        public static Engine UpperTriangularize(this Engine en, string? name = null)
        {
            return en.Execute("UpperTriangularize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the unit triangle function on the interval  .
        ///https://reference.wolfram.com/language/ref/UnitTriangle.html
        ///</summary>
        public static Engine UnitTriangle(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitTriangle[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the unit triangle function on the interval  .
        ///https://reference.wolfram.com/language/ref/UnitTriangle.html
        ///</summary>
        public static Engine UnitTriangle(this Engine en, string? name = null)
        {
            return en.Execute("UnitTriangle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the low‐level box representation for  in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/UnderscriptBox.html
        ///</summary>
        public static Engine UnderscriptBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UnderscriptBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a number too small to represent explicitly on your computer system.
        ///https://reference.wolfram.com/language/ref/Underflow.html
        ///</summary>
        public static Engine Underflow(this Engine en, string? name = null)
        {
            return en.Execute("Underflow[]", name);
        }

        ///<summary>
        ///converts "string" into a URL-style, percent-encoded ASCII string. 
        ///https://reference.wolfram.com/language/ref/URLEncode.html
        ///</summary>
        public static Engine URLEncode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLEncode[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts "string" into a URL-style, percent-encoded ASCII string. 
        ///https://reference.wolfram.com/language/ref/URLEncode.html
        ///</summary>
        public static Engine URLEncode(this Engine en, string? name = null)
        {
            return en.Execute("URLEncode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///builds a URL with the specified path and query parameters and values parami and vali.
        ///https://reference.wolfram.com/language/ref/URLBuild.html
        ///</summary>
        public static Engine URLBuild(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("URLBuild[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the low‐level box representation for  in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/UnderoverscriptBox.html
        ///</summary>
        public static Engine UnderoverscriptBox(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UnderoverscriptBox[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays with a bar under expr.
        ///https://reference.wolfram.com/language/ref/UnderBar.html
        ///</summary>
        public static Engine UnderBar(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnderBar[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays with a bar under expr.
        ///https://reference.wolfram.com/language/ref/UnderBar.html
        ///</summary>
        public static Engine UnderBar(this Engine en, string? name = null)
        {
            return en.Execute("UnderBar[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a list of base dimensions associated with the specified unit.
        ///https://reference.wolfram.com/language/ref/UnitDimensions.html
        ///</summary>
        public static Engine UnitDimensions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitDimensions[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of base dimensions associated with the specified unit.
        ///https://reference.wolfram.com/language/ref/UnitDimensions.html
        ///</summary>
        public static Engine UnitDimensions(this Engine en, string? name = null)
        {
            return en.Execute("UnitDimensions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the unevaluated form of expr when it appears as the argument to a function. 
        ///https://reference.wolfram.com/language/ref/Unevaluated.html
        ///</summary>
        public static Engine Unevaluated(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Unevaluated[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the unevaluated form of expr when it appears as the argument to a function. 
        ///https://reference.wolfram.com/language/ref/Unevaluated.html
        ///</summary>
        public static Engine Unevaluated(this Engine en, string? name = null)
        {
            return en.Execute("Unevaluated[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as x⇅y⇅….
        ///https://reference.wolfram.com/language/ref/UpArrowDownArrow.html
        ///</summary>
        public static Engine UpArrowDownArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UpArrowDownArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///decodes a URL-style query string into a list of key-value rules. 
        ///https://reference.wolfram.com/language/ref/URLQueryDecode.html
        ///</summary>
        public static Engine URLQueryDecode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLQueryDecode[" + arg0 + "]", name);
        }

        ///<summary>
        ///decodes a URL-style query string into a list of key-value rules. 
        ///https://reference.wolfram.com/language/ref/URLQueryDecode.html
        ///</summary>
        public static Engine URLQueryDecode(this Engine en, string? name = null)
        {
            return en.Execute("URLQueryDecode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to simplify the units of the specified quantity.
        ///https://reference.wolfram.com/language/ref/UnitSimplify.html
        ///</summary>
        public static Engine UnitSimplify(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitSimplify[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to simplify the units of the specified quantity.
        ///https://reference.wolfram.com/language/ref/UnitSimplify.html
        ///</summary>
        public static Engine UnitSimplify(this Engine en, string? name = null)
        {
            return en.Execute("UnitSimplify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as x↗y↗….
        ///https://reference.wolfram.com/language/ref/UpperRightArrow.html
        ///</summary>
        public static Engine UpperRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UpperRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///creates a shortened URL that redirects to "url".
        ///https://reference.wolfram.com/language/ref/URLShorten.html
        ///</summary>
        public static Engine URLShorten(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLShorten[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a shortened URL that redirects to "url".
        ///https://reference.wolfram.com/language/ref/URLShorten.html
        ///</summary>
        public static Engine URLShorten(this Engine en, string? name = null)
        {
            return en.Execute("URLShorten[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///removes the attribute Protected for the symbols si. 
        ///https://reference.wolfram.com/language/ref/Unprotect.html
        ///</summary>
        public static Engine Unprotect(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Unprotect[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives an undirected graph from the directed graph g.
        ///https://reference.wolfram.com/language/ref/UndirectedGraph.html
        ///</summary>
        public static Engine UndirectedGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UndirectedGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an undirected graph from the directed graph g.
        ///https://reference.wolfram.com/language/ref/UndirectedGraph.html
        ///</summary>
        public static Engine UndirectedGraph(this Engine en, string? name = null)
        {
            return en.Execute("UndirectedGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns properties of the universe based on the default model at specification defined by the time after the Big Bang, the distance to the comoving object, or the redshift of such an object.
        ///https://reference.wolfram.com/language/ref/UniverseModelData.html
        ///</summary>
        public static Engine UniverseModelData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UniverseModelData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns properties of the universe based on the default model at specification defined by the time after the Big Bang, the distance to the comoving object, or the redshift of such an object.
        ///https://reference.wolfram.com/language/ref/UniverseModelData.html
        ///</summary>
        public static Engine UniverseModelData(this Engine en, string? name = null)
        {
            return en.Execute("UniverseModelData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an entity class containing all the distinct entities in all the classi.
        ///https://reference.wolfram.com/language/ref/UnionedEntityClass.html
        ///</summary>
        public static Engine UnionedEntityClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UnionedEntityClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x≠y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/UnequalTo.html
        ///</summary>
        public static Engine UnequalTo(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnequalTo[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x≠y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/UnequalTo.html
        ///</summary>
        public static Engine UnequalTo(this Engine en, string? name = null)
        {
            return en.Execute("UnequalTo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///executes the specified URL, importing whatever result is generated.
        ///https://reference.wolfram.com/language/ref/URLExecute.html
        ///</summary>
        public static Engine URLExecute(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLExecute[" + arg0 + "]", name);
        }

        ///<summary>
        ///executes the specified URL, importing whatever result is generated.
        ///https://reference.wolfram.com/language/ref/URLExecute.html
        ///</summary>
        public static Engine URLExecute(this Engine en, string? name = null)
        {
            return en.Execute("URLExecute[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the total number of seconds to request one byte from the specified URL.
        ///https://reference.wolfram.com/language/ref/URLResponseTime.html
        ///</summary>
        public static Engine URLResponseTime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLResponseTime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the total number of seconds to request one byte from the specified URL.
        ///https://reference.wolfram.com/language/ref/URLResponseTime.html
        ///</summary>
        public static Engine URLResponseTime(this Engine en, string? name = null)
        {
            return en.Execute("URLResponseTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the uniform polyhedron with the given name.
        ///https://reference.wolfram.com/language/ref/UniformPolyhedron.html
        ///</summary>
        public static Engine UniformPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UniformPolyhedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the uniform polyhedron with the given name.
        ///https://reference.wolfram.com/language/ref/UniformPolyhedron.html
        ///</summary>
        public static Engine UniformPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("UniformPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is upper triangular, and False otherwise.
        ///https://reference.wolfram.com/language/ref/UpperTriangularMatrixQ.html
        ///</summary>
        public static Engine UpperTriangularMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UpperTriangularMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m is upper triangular, and False otherwise.
        ///https://reference.wolfram.com/language/ref/UpperTriangularMatrixQ.html
        ///</summary>
        public static Engine UpperTriangularMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("UpperTriangularMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a tree of the same shape as tree in which the nodes and edges are displayed without labels.
        ///https://reference.wolfram.com/language/ref/UnlabeledTree.html
        ///</summary>
        public static Engine UnlabeledTree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnlabeledTree[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a tree of the same shape as tree in which the nodes and edges are displayed without labels.
        ///https://reference.wolfram.com/language/ref/UnlabeledTree.html
        ///</summary>
        public static Engine UnlabeledTree(this Engine en, string? name = null)
        {
            return en.Execute("UnlabeledTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all upvalues (values for g[…,f[…],…]) defined for the symbol f. 
        ///https://reference.wolfram.com/language/ref/UpValues.html
        ///</summary>
        public static Engine UpValues(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UpValues[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all upvalues (values for g[…,f[…],…]) defined for the symbol f. 
        ///https://reference.wolfram.com/language/ref/UpValues.html
        ///</summary>
        public static Engine UpValues(this Engine en, string? name = null)
        {
            return en.Execute("UpValues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a sorted list of all the distinct elements that appear in any of the listi. 
        ///https://reference.wolfram.com/language/ref/Union.html
        ///</summary>
        public static Engine Union(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Union[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the Boolean expression bexpr is positive unate in the variables x1, x2, … .
        ///https://reference.wolfram.com/language/ref/UnateQ.html
        ///</summary>
        public static Engine UnateQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UnateQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a new symbol, whose name is of the form $nnn. 
        ///https://reference.wolfram.com/language/ref/Unique.html
        ///</summary>
        public static Engine Unique(this Engine en, string? name = null)
        {
            return en.Execute("Unique[]", name);
        }

        ///<summary>
        ///downloads the content of the specified URL to a local temporary file.
        ///https://reference.wolfram.com/language/ref/URLDownload.html
        ///</summary>
        public static Engine URLDownload(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLDownload[" + arg0 + "]", name);
        }

        ///<summary>
        ///downloads the content of the specified URL to a local temporary file.
        ///https://reference.wolfram.com/language/ref/URLDownload.html
        ///</summary>
        public static Engine URLDownload(this Engine en, string? name = null)
        {
            return en.Execute("URLDownload[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///expands a shortened "url".
        ///https://reference.wolfram.com/language/ref/URLExpand.html
        ///</summary>
        public static Engine URLExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands a shortened "url".
        ///https://reference.wolfram.com/language/ref/URLExpand.html
        ///</summary>
        public static Engine URLExpand(this Engine en, string? name = null)
        {
            return en.Execute("URLExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether data came from an autoregressive time series process with unit root.
        ///https://reference.wolfram.com/language/ref/UnitRootTest.html
        ///</summary>
        public static Engine UnitRootTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitRootTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data came from an autoregressive time series process with unit root.
        ///https://reference.wolfram.com/language/ref/UnitRootTest.html
        ///</summary>
        public static Engine UnitRootTest(this Engine en, string? name = null)
        {
            return en.Execute("UnitRootTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as x↑y↑.
        ///https://reference.wolfram.com/language/ref/UpArrow.html
        ///</summary>
        public static Engine UpArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UpArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///decodes a URL-style percent-encoded string.
        ///https://reference.wolfram.com/language/ref/URLDecode.html
        ///</summary>
        public static Engine URLDecode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLDecode[" + arg0 + "]", name);
        }

        ///<summary>
        ///decodes a URL-style percent-encoded string.
        ///https://reference.wolfram.com/language/ref/URLDecode.html
        ///</summary>
        public static Engine URLDecode(this Engine en, string? name = null)
        {
            return en.Execute("URLDecode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts the upper triangular matrix umat to a structured array.
        ///https://reference.wolfram.com/language/ref/UpperTriangularMatrix.html
        ///</summary>
        public static Engine UpperTriangularMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UpperTriangularMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts the upper triangular matrix umat to a structured array.
        ///https://reference.wolfram.com/language/ref/UpperTriangularMatrix.html
        ///</summary>
        public static Engine UpperTriangularMatrix(this Engine en, string? name = null)
        {
            return en.Execute("UpperTriangularMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the undersea feature entity.
        ///https://reference.wolfram.com/language/ref/UnderseaFeatureData.html
        ///</summary>
        public static Engine UnderseaFeatureData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UnderseaFeatureData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tells the Wolfram Language that hidden changes have been made that could affect values associated with a symbol. 
        ///https://reference.wolfram.com/language/ref/Update.html
        ///</summary>
        public static Engine Update(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Update[" + arg0 + "]", name);
        }

        ///<summary>
        ///tells the Wolfram Language that hidden changes have been made that could affect values associated with a symbol. 
        ///https://reference.wolfram.com/language/ref/Update.html
        ///</summary>
        public static Engine Update(this Engine en, string? name = null)
        {
            return en.Execute("Update[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the unit box function, equal to 1 for  and 0 otherwise.
        ///https://reference.wolfram.com/language/ref/UnitBox.html
        ///</summary>
        public static Engine UnitBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the unit box function, equal to 1 for  and 0 otherwise.
        ///https://reference.wolfram.com/language/ref/UnitBox.html
        ///</summary>
        public static Engine UnitBox(this Engine en, string? name = null)
        {
            return en.Execute("UnitBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is an undirected graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/UndirectedGraphQ.html
        ///</summary>
        public static Engine UndirectedGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UndirectedGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is an undirected graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/UndirectedGraphQ.html
        ///</summary>
        public static Engine UndirectedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("UndirectedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the unit step function, equal to 0 for  and 1 for . 
        ///https://reference.wolfram.com/language/ref/UnitStep.html
        ///</summary>
        public static Engine UnitStep(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitStep[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the unit step function, equal to 0 for  and 1 for . 
        ///https://reference.wolfram.com/language/ref/UnitStep.html
        ///</summary>
        public static Engine UnitStep(this Engine en, string? name = null)
        {
            return en.Execute("UnitStep[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///updates the given search index object.
        ///https://reference.wolfram.com/language/ref/UpdateSearchIndex.html
        ///</summary>
        public static Engine UpdateSearchIndex(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UpdateSearchIndex[" + arg0 + "]", name);
        }

        ///<summary>
        ///updates the given search index object.
        ///https://reference.wolfram.com/language/ref/UpdateSearchIndex.html
        ///</summary>
        public static Engine UpdateSearchIndex(this Engine en, string? name = null)
        {
            return en.Execute("UpdateSearchIndex[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the two-dimensional unit vector in the k direction.
        ///https://reference.wolfram.com/language/ref/UnitVector.html
        ///</summary>
        public static Engine UnitVector(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitVector[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the two-dimensional unit vector in the k direction.
        ///https://reference.wolfram.com/language/ref/UnitVector.html
        ///</summary>
        public static Engine UnitVector(this Engine en, string? name = null)
        {
            return en.Execute("UnitVector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a URL-style query string from an association of keys and values. 
        ///https://reference.wolfram.com/language/ref/URLQueryEncode.html
        ///</summary>
        public static Engine URLQueryEncode(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("URLQueryEncode[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a continuous uniform statistical distribution giving values between min and max. 
        ///https://reference.wolfram.com/language/ref/UniformDistribution.html
        ///</summary>
        public static Engine UniformDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UniformDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a continuous uniform statistical distribution giving values between min and max. 
        ///https://reference.wolfram.com/language/ref/UniformDistribution.html
        ///</summary>
        public static Engine UniformDistribution(this Engine en, string? name = null)
        {
            return en.Execute("UniformDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits the specified URL to be executed asynchronously.
        ///https://reference.wolfram.com/language/ref/URLSubmit.html
        ///</summary>
        public static Engine URLSubmit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLSubmit[" + arg0 + "]", name);
        }

        ///<summary>
        ///submits the specified URL to be executed asynchronously.
        ///https://reference.wolfram.com/language/ref/URLSubmit.html
        ///</summary>
        public static Engine URLSubmit(this Engine en, string? name = null)
        {
            return en.Execute("URLSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the university entity.
        ///https://reference.wolfram.com/language/ref/UniversityData.html
        ///</summary>
        public static Engine UniversityData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UniversityData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if all the characters in the string are uppercase letters, and yields False otherwise. 
        ///https://reference.wolfram.com/language/ref/UpperCaseQ.html
        ///</summary>
        public static Engine UpperCaseQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UpperCaseQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if all the characters in the string are uppercase letters, and yields False otherwise. 
        ///https://reference.wolfram.com/language/ref/UpperCaseQ.html
        ///</summary>
        public static Engine UpperCaseQ(this Engine en, string? name = null)
        {
            return en.Execute("UpperCaseQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an upsampled version of the array by inserting  zeros between array elements.
        ///https://reference.wolfram.com/language/ref/Upsample.html
        ///</summary>
        public static Engine Upsample(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Upsample[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///stops the sharing of the variables or functions si among parallel kernels.
        ///https://reference.wolfram.com/language/ref/UnsetShared.html
        ///</summary>
        public static Engine UnsetShared(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UnsetShared[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/UpTee.html
        ///</summary>
        public static Engine UpTee(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UpTee[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///unregisters the external evaluator referenced by target for system sys so that it is not used by ExternalEvaluate and related functions.
        ///https://reference.wolfram.com/language/ref/UnregisterExternalEvaluator.html
        ///</summary>
        public static Engine UnregisterExternalEvaluator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UnregisterExternalEvaluator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr, making use of a front end if necessary.
        ///https://reference.wolfram.com/language/ref/UsingFrontEnd.html
        ///</summary>
        public static Engine UsingFrontEnd(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UsingFrontEnd[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr, making use of a front end if necessary.
        ///https://reference.wolfram.com/language/ref/UsingFrontEnd.html
        ///</summary>
        public static Engine UsingFrontEnd(this Engine en, string? name = null)
        {
            return en.Execute("UsingFrontEnd[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///takes ownership of memory wrapped in a "Managed" object, suitable for use in compiled code.
        ///https://reference.wolfram.com/language/ref/UnmanageObject.html
        ///</summary>
        public static Engine UnmanageObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnmanageObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///takes ownership of memory wrapped in a "Managed" object, suitable for use in compiled code.
        ///https://reference.wolfram.com/language/ref/UnmanageObject.html
        ///</summary>
        public static Engine UnmanageObject(this Engine en, string? name = null)
        {
            return en.Execute("UnmanageObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a symbolic representation of a URL.
        ///https://reference.wolfram.com/language/ref/URL.html
        ///</summary>
        public static Engine URL(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URL[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a symbolic representation of a URL.
        ///https://reference.wolfram.com/language/ref/URL.html
        ///</summary>
        public static Engine URL(this Engine en, string? name = null)
        {
            return en.Execute("URL[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the distribution of a sum of n random variables uniformly distributed from 0 to 1.
        ///https://reference.wolfram.com/language/ref/UniformSumDistribution.html
        ///</summary>
        public static Engine UniformSumDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UniformSumDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the distribution of a sum of n random variables uniformly distributed from 0 to 1.
        ///https://reference.wolfram.com/language/ref/UniformSumDistribution.html
        ///</summary>
        public static Engine UniformSumDistribution(this Engine en, string? name = null)
        {
            return en.Execute("UniformSumDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as x⊎y⊎….
        ///https://reference.wolfram.com/language/ref/UnionPlus.html
        ///</summary>
        public static Engine UnionPlus(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UnionPlus[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///recovers an expression from a compressed string representation generated by Compress.
        ///https://reference.wolfram.com/language/ref/Uncompress.html
        ///</summary>
        public static Engine Uncompress(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Uncompress[" + arg0 + "]", name);
        }

        ///<summary>
        ///recovers an expression from a compressed string representation generated by Compress.
        ///https://reference.wolfram.com/language/ref/Uncompress.html
        ///</summary>
        public static Engine Uncompress(this Engine en, string? name = null)
        {
            return en.Execute("Uncompress[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the elements for each listi that are not in any other list.
        ///https://reference.wolfram.com/language/ref/UniqueElements.html
        ///</summary>
        public static Engine UniqueElements(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UniqueElements[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the elements for each listi that are not in any other list.
        ///https://reference.wolfram.com/language/ref/UniqueElements.html
        ///</summary>
        public static Engine UniqueElements(this Engine en, string? name = null)
        {
            return en.Execute("UniqueElements[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///takes a well-formed URL and gives an association whose values correspond to the components of the URL.
        ///https://reference.wolfram.com/language/ref/URLParse.html
        ///</summary>
        public static Engine URLParse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLParse[" + arg0 + "]", name);
        }

        ///<summary>
        ///takes a well-formed URL and gives an association whose values correspond to the components of the URL.
        ///https://reference.wolfram.com/language/ref/URLParse.html
        ///</summary>
        public static Engine URLParse(this Engine en, string? name = null)
        {
            return en.Execute("URLParse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an object that formats as . 
        ///https://reference.wolfram.com/language/ref/Underoverscript.html
        ///</summary>
        public static Engine Underoverscript(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Underoverscript[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an object that formats as . 
        ///https://reference.wolfram.com/language/ref/Underscript.html
        ///</summary>
        public static Engine Underscript(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Underscript[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as x⤒y⤒….
        ///https://reference.wolfram.com/language/ref/UpArrowBar.html
        ///</summary>
        public static Engine UpArrowBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UpArrowBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a dispatcher for deployed URLs that specifies that URLs with relative paths matching the string patterns patti should give content represented by contenti.
        ///https://reference.wolfram.com/language/ref/URLDispatcher.html
        ///</summary>
        public static Engine URLDispatcher(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLDispatcher[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a dispatcher for deployed URLs that specifies that URLs with relative paths matching the string patterns patti should give content represented by contenti.
        ///https://reference.wolfram.com/language/ref/URLDispatcher.html
        ///</summary>
        public static Engine URLDispatcher(this Engine en, string? name = null)
        {
            return en.Execute("URLDispatcher[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to convert the specified quantity to the specified targetunit.
        ///https://reference.wolfram.com/language/ref/UnitConvert.html
        ///</summary>
        public static Engine UnitConvert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UnitConvert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a uniform graph distribution on n-vertex, m-edge graphs.
        ///https://reference.wolfram.com/language/ref/UniformGraphDistribution.html
        ///</summary>
        public static Engine UniformGraphDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UniformGraphDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///submits the specified URL to be downloaded asynchronously to the file given.
        ///https://reference.wolfram.com/language/ref/URLDownloadSubmit.html
        ///</summary>
        public static Engine URLDownloadSubmit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("URLDownloadSubmit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that transforms integers between 1 and n into n-dimensional unit vectors. 
        ///https://reference.wolfram.com/language/ref/UnitVectorLayer.html
        ///</summary>
        public static Engine UnitVectorLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitVectorLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that transforms integers between 1 and n into n-dimensional unit vectors. 
        ///https://reference.wolfram.com/language/ref/UnitVectorLayer.html
        ///</summary>
        public static Engine UnitVectorLayer(this Engine en, string? name = null)
        {
            return en.Execute("UnitVectorLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an undirected edge between u and v.
        ///https://reference.wolfram.com/language/ref/UndirectedEdge.html
        ///</summary>
        public static Engine UndirectedEdge(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("UndirectedEdge[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as x↕y↕….
        ///https://reference.wolfram.com/language/ref/UpDownArrow.html
        ///</summary>
        public static Engine UpDownArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UpDownArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///evaluates body and then test, repetitively, until test first gives True.
        ///https://reference.wolfram.com/language/ref/Until.html
        ///</summary>
        public static Engine Until(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Until[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sends a request to a URL and reads back the response, returning it as a response object.
        ///https://reference.wolfram.com/language/ref/URLRead.html
        ///</summary>
        public static Engine URLRead(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("URLRead[" + arg0 + "]", name);
        }

        ///<summary>
        ///sends a request to a URL and reads back the response, returning it as a response object.
        ///https://reference.wolfram.com/language/ref/URLRead.html
        ///</summary>
        public static Engine URLRead(this Engine en, string? name = null)
        {
            return en.Execute("URLRead[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as x↖y↖….
        ///https://reference.wolfram.com/language/ref/UpperLeftArrow.html
        ///</summary>
        public static Engine UpperLeftArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UpperLeftArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x↥y↥….
        ///https://reference.wolfram.com/language/ref/UpTeeArrow.html
        ///</summary>
        public static Engine UpTeeArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UpTeeArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///terminates an external program started by Install, and removes Wolfram Language definitions set up by it. 
        ///https://reference.wolfram.com/language/ref/Uninstall.html
        ///</summary>
        public static Engine Uninstall(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Uninstall[" + arg0 + "]", name);
        }

        ///<summary>
        ///terminates an external program started by Install, and removes Wolfram Language definitions set up by it. 
        ///https://reference.wolfram.com/language/ref/Uninstall.html
        ///</summary>
        public static Engine Uninstall(this Engine en, string? name = null)
        {
            return en.Execute("Uninstall[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is a unitary matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/UnitaryMatrixQ.html
        ///</summary>
        public static Engine UnitaryMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("UnitaryMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        /// gives True if m is a unitary matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/UnitaryMatrixQ.html
        ///</summary>
        public static Engine UnitaryMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("UnitaryMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as x⥮y⥮….
        ///https://reference.wolfram.com/language/ref/UpEquilibrium.html
        ///</summary>
        public static Engine UpEquilibrium(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("UpEquilibrium[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }


    }
}
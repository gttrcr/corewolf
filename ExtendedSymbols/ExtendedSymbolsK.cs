namespace CoreWolf
{
    public static class ExtendedSymbolsK
    {
        ///<summary>
        ///makes a Kagi chart of closing prices for the financial entity "name" over the date range daterange.
        ///https://reference.wolfram.com/language/ref/KagiChart.html
        ///</summary>
        public static Engine KagiChart(this Engine en, string? name = null)
        {
            return en.Execute("KagiChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Kaiser–Bessel window function of x.
        ///https://reference.wolfram.com/language/ref/KaiserBesselWindow.html
        ///</summary>
        public static Engine KaiserBesselWindow(this Engine en, string? name = null)
        {
            return en.Execute("KaiserBesselWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Kaiser window function of x.
        ///https://reference.wolfram.com/language/ref/KaiserWindow.html
        ///</summary>
        public static Engine KaiserWindow(this Engine en, string? name = null)
        {
            return en.Execute("KaiserWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Karhunen–Loeve transform {{b1,b2,…},m} of the numerical arrays {a1,a2,…}, where m.aibi.
        ///https://reference.wolfram.com/language/ref/KarhunenLoeveDecomposition.html
        ///</summary>
        public static Engine KarhunenLoeveDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("KarhunenLoeveDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a binary tree with n vertices.
        ///https://reference.wolfram.com/language/ref/KaryTree.html
        ///</summary>
        public static Engine KaryTree(this Engine en, string? name = null)
        {
            return en.Execute("KaryTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinBei.html
        ///</summary>
        public static Engine KelvinBei(this Engine en, string? name = null)
        {
            return en.Execute("KelvinBei[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinBer.html
        ///</summary>
        public static Engine KelvinBer(this Engine en, string? name = null)
        {
            return en.Execute("KelvinBer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinKei.html
        ///</summary>
        public static Engine KelvinKei(this Engine en, string? name = null)
        {
            return en.Execute("KelvinKei[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinKer.html
        ///</summary>
        public static Engine KelvinKer(this Engine en, string? name = null)
        {
            return en.Execute("KelvinKer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives Kendall's rank correlation coefficients  for the matrix m.
        ///https://reference.wolfram.com/language/ref/KendallTau.html
        ///</summary>
        public static Engine KendallTau(this Engine en, string? name = null)
        {
            return en.Execute("KendallTau[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///specifies a kernel that can be used for RemoteEvaluate or LaunchKernels.
        ///https://reference.wolfram.com/language/ref/KernelConfiguration.html
        ///</summary>
        public static Engine KernelConfiguration(this Engine en, string? name = null)
        {
            return en.Execute("KernelConfiguration[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a function to be evaluated in the Wolfram Engine kernel, even when it is called inside compiled code.
        ///https://reference.wolfram.com/language/ref/KernelFunction.html
        ///</summary>
        public static Engine KernelFunction(this Engine en, string? name = null)
        {
            return en.Execute("KernelFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a kernel mixture distribution based on the data values xi.
        ///https://reference.wolfram.com/language/ref/KernelMixtureDistribution.html
        ///</summary>
        public static Engine KernelMixtureDistribution(this Engine en, string? name = null)
        {
            return en.Execute("KernelMixtureDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a key used to access a value in an association.
        ///https://reference.wolfram.com/language/ref/Key.html
        ///</summary>
        public static Engine Key(this Engine en, string? name = null)
        {
            return en.Execute("Key[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates an association in which only elements whose keys appear in assocall but not in any of the associ are retained.
        ///https://reference.wolfram.com/language/ref/KeyComplement.html
        ///</summary>
        public static Engine KeyComplement(this Engine en, string? name = null)
        {
            return en.Execute("KeyComplement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyDrop that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyDrop.html
        ///</summary>
        public static Engine KeyDrop(this Engine en, string? name = null)
        {
            return en.Execute("KeyDrop[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyExistsQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyExistsQ.html
        ///</summary>
        public static Engine KeyExistsQ(this Engine en, string? name = null)
        {
            return en.Execute("KeyExistsQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyFreeQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyFreeQ.html
        ///</summary>
        public static Engine KeyFreeQ(this Engine en, string? name = null)
        {
            return en.Execute("KeyFreeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a list of associations in which only elements whose keys appear in all the associ are retained.
        ///https://reference.wolfram.com/language/ref/KeyIntersection.html
        ///</summary>
        public static Engine KeyIntersection(this Engine en, string? name = null)
        {
            return en.Execute("KeyIntersection[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyMap that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyMap.html
        ///</summary>
        public static Engine KeyMap(this Engine en, string? name = null)
        {
            return en.Execute("KeyMap[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyMemberQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyMemberQ.html
        ///</summary>
        public static Engine KeyMemberQ(this Engine en, string? name = null)
        {
            return en.Execute("KeyMemberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the keyi in a list of rules.
        ///https://reference.wolfram.com/language/ref/Keys.html
        ///</summary>
        public static Engine Keys(this Engine en, string? name = null)
        {
            return en.Execute("Keys[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeySelect that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeySelect.html
        ///</summary>
        public static Engine KeySelect(this Engine en, string? name = null)
        {
            return en.Execute("KeySelect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///orders the elements of an association by sorting its keys.
        ///https://reference.wolfram.com/language/ref/KeySort.html
        ///</summary>
        public static Engine KeySort(this Engine en, string? name = null)
        {
            return en.Execute("KeySort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeySortBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeySortBy.html
        ///</summary>
        public static Engine KeySortBy(this Engine en, string? name = null)
        {
            return en.Execute("KeySortBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyTake that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyTake.html
        ///</summary>
        public static Engine KeyTake(this Engine en, string? name = null)
        {
            return en.Execute("KeyTake[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a list of associations in which each association has the union of the keys of the associ, padding by inserting values of Missing[…] if necessary.
        ///https://reference.wolfram.com/language/ref/KeyUnion.html
        ///</summary>
        public static Engine KeyUnion(this Engine en, string? name = null)
        {
            return en.Execute("KeyUnion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyValueMap that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyValueMap.html
        ///</summary>
        public static Engine KeyValueMap(this Engine en, string? name = null)
        {
            return en.Execute("KeyValueMap[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pattern object that represents an association or list of rules that includes elements matching each of the patti.
        ///https://reference.wolfram.com/language/ref/KeyValuePattern.html
        ///</summary>
        public static Engine KeyValuePattern(this Engine en, string? name = null)
        {
            return en.Execute("KeyValuePattern[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///kills the external process represented by the ProcessObject proc.
        ///https://reference.wolfram.com/language/ref/KillProcess.html
        ///</summary>
        public static Engine KillProcess(this Engine en, string? name = null)
        {
            return en.Execute("KillProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the graph with Kirchhoff matrix kmat.
        ///https://reference.wolfram.com/language/ref/KirchhoffGraph.html
        ///</summary>
        public static Engine KirchhoffGraph(this Engine en, string? name = null)
        {
            return en.Execute("KirchhoffGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Kirchhoff matrix of the graph g.
        ///https://reference.wolfram.com/language/ref/KirchhoffMatrix.html
        ///</summary>
        public static Engine KirchhoffMatrix(this Engine en, string? name = null)
        {
            return en.Execute("KirchhoffMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Klein invariant modular elliptic function .
        ///https://reference.wolfram.com/language/ref/KleinInvariantJ.html
        ///</summary>
        public static Engine KleinInvariantJ(this Engine en, string? name = null)
        {
            return en.Execute("KleinInvariantJ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an image of the knot.
        ///https://reference.wolfram.com/language/ref/KnotData.html
        ///</summary>
        public static Engine KnotData(this Engine en, string? name = null)
        {
            return en.Execute("KnotData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if expr is a canonical unit, and False otherwise.
        ///https://reference.wolfram.com/language/ref/KnownUnitQ.html
        ///</summary>
        public static Engine KnownUnitQ(this Engine en, string? name = null)
        {
            return en.Execute("KnownUnitQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the line segments representing the n-step Koch curve.
        ///https://reference.wolfram.com/language/ref/KochCurve.html
        ///</summary>
        public static Engine KochCurve(this Engine en, string? name = null)
        {
            return en.Execute("KochCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Kolmogorov–Smirnov test.
        ///https://reference.wolfram.com/language/ref/KolmogorovSmirnovTest.html
        ///</summary>
        public static Engine KolmogorovSmirnovTest(this Engine en, string? name = null)
        {
            return en.Execute("KolmogorovSmirnovTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields the Kronecker decomposition of a descriptor state-space model ssm.
        ///https://reference.wolfram.com/language/ref/KroneckerModelDecomposition.html
        ///</summary>
        public static Engine KroneckerModelDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("KroneckerModelDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Kuiper test.
        ///https://reference.wolfram.com/language/ref/KuiperTest.html
        ///</summary>
        public static Engine KuiperTest(this Engine en, string? name = null)
        {
            return en.Execute("KuiperTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the coefficient of kurtosis for the elements in list.
        ///https://reference.wolfram.com/language/ref/Kurtosis.html
        ///</summary>
        public static Engine Kurtosis(this Engine en, string? name = null)
        {
            return en.Execute("Kurtosis[" + en.ValidNames.Last() + "]", name);
        }


    }
}
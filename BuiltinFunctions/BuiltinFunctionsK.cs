using System.Collections.Generic;

namespace CoreWolf
{
    public static class BuiltinFunctionK
    {
        ///<summary>
        ///makes a Kagi chart with prices pi at date datei.
        ///https://reference.wolfram.com/language/ref/KagiChart.html
        ///</summary>
        public static Engine KagiChart(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KagiChart[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a Kagi chart of closing prices for the financial entity "name" over the date range daterange.
        ///https://reference.wolfram.com/language/ref/KagiChart.html
        ///</summary>
        public static Engine KagiChart(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KagiChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a Kagi chart with reversal threshold rt.
        ///https://reference.wolfram.com/language/ref/KagiChart.html
        ///</summary>
        public static Engine KagiChart(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KagiChart[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Kaiser–Bessel window function of x.
        ///https://reference.wolfram.com/language/ref/KaiserBesselWindow.html
        ///</summary>
        public static Engine KaiserBesselWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KaiserBesselWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Kaiser window function of x.
        ///https://reference.wolfram.com/language/ref/KaiserWindow.html
        ///</summary>
        public static Engine KaiserWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KaiserWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the parameter α.
        ///https://reference.wolfram.com/language/ref/KaiserWindow.html
        ///</summary>
        public static Engine KaiserWindow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KaiserWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs the Kalman estimator for the StateSpaceModel ssm with process and measurement noise covariance matrices w and v.
        ///https://reference.wolfram.com/language/ref/KalmanEstimator.html
        ///</summary>
        public static Engine KalmanEstimator(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KalmanEstimator[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///specifies sensors as the noisy measurements of ssm.
        ///https://reference.wolfram.com/language/ref/KalmanEstimator.html
        ///</summary>
        public static Engine KalmanEstimator(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KalmanEstimator[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///filters data using the time series model given by tproc.
        ///https://reference.wolfram.com/language/ref/KalmanFilter.html
        ///</summary>
        public static Engine KalmanFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KalmanFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Karhunen–Loeve transform {{b1,b2,…},m} of the numerical arrays {a1,a2,…}, where m.aibi.
        ///https://reference.wolfram.com/language/ref/KarhunenLoeveDecomposition.html
        ///</summary>
        public static Engine KarhunenLoeveDecomposition(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KarhunenLoeveDecomposition[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses the inverse of the matrix m for transforming bi to ai.
        ///https://reference.wolfram.com/language/ref/KarhunenLoeveDecomposition.html
        ///</summary>
        public static Engine KarhunenLoeveDecomposition(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KarhunenLoeveDecomposition[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a binary tree with n vertices.
        ///https://reference.wolfram.com/language/ref/KaryTree.html
        ///</summary>
        public static Engine KaryTree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KaryTree[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a k-ary tree with n vertices.
        ///https://reference.wolfram.com/language/ref/KaryTree.html
        ///</summary>
        public static Engine KaryTree(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KaryTree[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of Katz centralities for the vertices in the graph g and weight α.
        ///https://reference.wolfram.com/language/ref/KatzCentrality.html
        ///</summary>
        public static Engine KatzCentrality(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KatzCentrality[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of Katz centralities using weight α and initial centralities β.
        ///https://reference.wolfram.com/language/ref/KatzCentrality.html
        ///</summary>
        public static Engine KatzCentrality(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KatzCentrality[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/KatzCentrality.html
        ///</summary>
        public static Engine KatzCentrality(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KatzCentrality[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the k-core components of the underlying simple graph of g.
        ///https://reference.wolfram.com/language/ref/KCoreComponents.html
        ///</summary>
        public static Engine KCoreComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KCoreComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the k-core components with vertex in-degrees at least k.
        ///https://reference.wolfram.com/language/ref/KCoreComponents.html
        ///</summary>
        public static Engine KCoreComponents(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KCoreComponents[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/KCoreComponents.html
        ///</summary>
        public static Engine KCoreComponents(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KCoreComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a K distribution with shape parameters ν and w.
        ///https://reference.wolfram.com/language/ref/KDistribution.html
        ///</summary>
        public static Engine KDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the k-edge-connected components of the graph g.
        ///https://reference.wolfram.com/language/ref/KEdgeConnectedComponents.html
        ///</summary>
        public static Engine KEdgeConnectedComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KEdgeConnectedComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the k-edge-connected components that include at least one of the vertices v1, v2, ….
        ///https://reference.wolfram.com/language/ref/KEdgeConnectedComponents.html
        ///</summary>
        public static Engine KEdgeConnectedComponents(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("KEdgeConnectedComponents[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/KEdgeConnectedComponents.html
        ///</summary>
        public static Engine KEdgeConnectedComponents(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KEdgeConnectedComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is k-edge-connected and False otherwise.
        ///https://reference.wolfram.com/language/ref/KEdgeConnectedGraphQ.html
        ///</summary>
        public static Engine KEdgeConnectedGraphQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KEdgeConnectedGraphQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinBei.html
        ///</summary>
        public static Engine KelvinBei(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KelvinBei[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinBei.html
        ///</summary>
        public static Engine KelvinBei(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KelvinBei[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinBer.html
        ///</summary>
        public static Engine KelvinBer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KelvinBer[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinBer.html
        ///</summary>
        public static Engine KelvinBer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KelvinBer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinKei.html
        ///</summary>
        public static Engine KelvinKei(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KelvinKei[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinKei.html
        ///</summary>
        public static Engine KelvinKei(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KelvinKei[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinKer.html
        ///</summary>
        public static Engine KelvinKer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KelvinKer[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Kelvin function .
        ///https://reference.wolfram.com/language/ref/KelvinKer.html
        ///</summary>
        public static Engine KelvinKer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KelvinKer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives Kendall's rank correlation coefficient  for the vectors v1 and v2.
        ///https://reference.wolfram.com/language/ref/KendallTau.html
        ///</summary>
        public static Engine KendallTau(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KendallTau[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives Kendall's rank correlation coefficients  for the matrix m.
        ///https://reference.wolfram.com/language/ref/KendallTau.html
        ///</summary>
        public static Engine KendallTau(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KendallTau[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the  Kendall rank correlation for the multivariate symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/KendallTau.html
        ///</summary>
        public static Engine KendallTau(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KendallTau[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the vectors v1 and v2 are independent.
        ///https://reference.wolfram.com/language/ref/KendallTauTest.html
        ///</summary>
        public static Engine KendallTauTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KendallTauTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies a kernel that can be used for RemoteEvaluate or LaunchKernels.
        ///https://reference.wolfram.com/language/ref/KernelConfiguration.html
        ///</summary>
        public static Engine KernelConfiguration(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KernelConfiguration[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a function to be evaluated in the Wolfram Engine kernel, even when it is called inside compiled code.
        ///https://reference.wolfram.com/language/ref/KernelFunction.html
        ///</summary>
        public static Engine KernelFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KernelFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a kernel mixture distribution based on the data values xi.
        ///https://reference.wolfram.com/language/ref/KernelMixtureDistribution.html
        ///</summary>
        public static Engine KernelMixtureDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KernelMixtureDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a multivariate kernel mixture distribution based on data values {xi,yi,…}.
        ///https://reference.wolfram.com/language/ref/KernelMixtureDistribution.html
        ///</summary>
        public static Engine KernelMixtureDistribution(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KernelMixtureDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a kernel mixture distribution with bandwidth bw.
        ///https://reference.wolfram.com/language/ref/KernelMixtureDistribution.html
        ///</summary>
        public static Engine KernelMixtureDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KernelMixtureDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a kernel mixture distribution with bandwidth bw and smoothing kernel ker.
        ///https://reference.wolfram.com/language/ref/KernelMixtureDistribution.html
        ///</summary>
        public static Engine KernelMixtureDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KernelMixtureDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a kernel available for parallel computing.
        ///https://reference.wolfram.com/language/ref/KernelObject.html
        ///</summary>
        public static Engine KernelObject(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KernelObject[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list of running kernels available for parallel computing.
        ///https://reference.wolfram.com/language/ref/Kernels.html
        ///</summary>
        public static Engine Kernels(this Engine en, string? name = null)
        {
            return en.Execute("Kernels[]", name);
        }

        ///<summary>
        ///represents a key used to access a value in an association.
        ///https://reference.wolfram.com/language/ref/Key.html
        ///</summary>
        public static Engine Key(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Key[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates an association in which only elements whose keys appear in assocall but not in any of the associ are retained.
        ///https://reference.wolfram.com/language/ref/KeyComplement.html
        ///</summary>
        public static Engine KeyComplement(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KeyComplement[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields an association from which elements with keys keyi have been dropped.
        ///https://reference.wolfram.com/language/ref/KeyDrop.html
        ///</summary>
        public static Engine KeyDrop(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KeyDrop[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of associations.
        ///https://reference.wolfram.com/language/ref/KeyDrop.html
        ///</summary>
        public static Engine KeyDrop(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KeyDrop[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyDrop that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyDrop.html
        ///</summary>
        public static Engine KeyDrop(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeyDrop[" + arg0 + "]", name);
        }

        ///<summary>
        ///changes the association a by dropping the element with the specified key.
        ///https://reference.wolfram.com/language/ref/KeyDropFrom.html
        ///</summary>
        public static Engine KeyDropFrom(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KeyDropFrom[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///drops the elements with keys keyi.
        ///https://reference.wolfram.com/language/ref/KeyDropFrom.html
        ///</summary>
        public static Engine KeyDropFrom(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KeyDropFrom[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns True if the specified key exists in the association assoc, and False otherwise.
        ///https://reference.wolfram.com/language/ref/KeyExistsQ.html
        ///</summary>
        public static Engine KeyExistsQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KeyExistsQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyExistsQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyExistsQ.html
        ///</summary>
        public static Engine KeyExistsQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeyExistsQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if no key in the association assoc matches form, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/KeyFreeQ.html
        ///</summary>
        public static Engine KeyFreeQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KeyFreeQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyFreeQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyFreeQ.html
        ///</summary>
        public static Engine KeyFreeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeyFreeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a list of associations in which only elements whose keys appear in all the associ are retained.
        ///https://reference.wolfram.com/language/ref/KeyIntersection.html
        ///</summary>
        public static Engine KeyIntersection(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KeyIntersection[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///maps f over the keys in an association, giving f[key1]val1,f[key2]val2,….
        ///https://reference.wolfram.com/language/ref/KeyMap.html
        ///</summary>
        public static Engine KeyMap(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("KeyMap[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyMap that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyMap.html
        ///</summary>
        public static Engine KeyMap(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeyMap[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if a key in the association assoc matches form, and False otherwise.
        ///https://reference.wolfram.com/language/ref/KeyMemberQ.html
        ///</summary>
        public static Engine KeyMemberQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KeyMemberQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyMemberQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyMemberQ.html
        ///</summary>
        public static Engine KeyMemberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeyMemberQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the keys keyi in an association.
        ///https://reference.wolfram.com/language/ref/Keys.html
        ///</summary>
        public static Engine Keys(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Keys[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the keyi in a list of rules.
        ///https://reference.wolfram.com/language/ref/Keys.html
        ///</summary>
        public static Engine Keys(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Keys[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of keys in expr, wrapping each of them with head h before evaluation.
        ///https://reference.wolfram.com/language/ref/Keys.html
        ///</summary>
        public static Engine Keys(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Keys[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///selects elements in the association assoc for which crit applied to their keys is True.
        ///https://reference.wolfram.com/language/ref/KeySelect.html
        ///</summary>
        public static Engine KeySelect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KeySelect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeySelect that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeySelect.html
        ///</summary>
        public static Engine KeySelect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeySelect[" + arg0 + "]", name);
        }

        ///<summary>
        ///orders the elements of an association by sorting its keys.
        ///https://reference.wolfram.com/language/ref/KeySort.html
        ///</summary>
        public static Engine KeySort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeySort[" + arg0 + "]", name);
        }

        ///<summary>
        ///orders the elements of an association using the ordering function p.
        ///https://reference.wolfram.com/language/ref/KeySort.html
        ///</summary>
        public static Engine KeySort(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KeySort[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sorts the elements of an association in the order defined by applying f to each of their keys.
        ///https://reference.wolfram.com/language/ref/KeySortBy.html
        ///</summary>
        public static Engine KeySortBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KeySortBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeySortBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeySortBy.html
        ///</summary>
        public static Engine KeySortBy(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeySortBy[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields an association containing only the elements with keys keyi.
        ///https://reference.wolfram.com/language/ref/KeyTake.html
        ///</summary>
        public static Engine KeyTake(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KeyTake[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of associations.
        ///https://reference.wolfram.com/language/ref/KeyTake.html
        ///</summary>
        public static Engine KeyTake(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KeyTake[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyTake that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyTake.html
        ///</summary>
        public static Engine KeyTake(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KeyTake[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a list of associations in which each association has the union of the keys of the associ, padding by inserting values of Missing[…] if necessary.
        ///https://reference.wolfram.com/language/ref/KeyUnion.html
        ///</summary>
        public static Engine KeyUnion(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KeyUnion[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses f[key] as the value associated with a missing key.
        ///https://reference.wolfram.com/language/ref/KeyUnion.html
        ///</summary>
        public static Engine KeyUnion(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KeyUnion[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list {f[key1,val1],f[key2,val2],…}.
        ///https://reference.wolfram.com/language/ref/KeyValueMap.html
        ///</summary>
        public static Engine KeyValueMap(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("KeyValueMap[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of KeyValueMap that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/KeyValueMap.html
        ///</summary>
        public static Engine KeyValueMap(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KeyValueMap[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a pattern object that represents an association or list of rules that includes elements matching each of the patti.
        ///https://reference.wolfram.com/language/ref/KeyValuePattern.html
        ///</summary>
        public static Engine KeyValuePattern(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KeyValuePattern[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///kills the external process represented by the ProcessObject proc.
        ///https://reference.wolfram.com/language/ref/KillProcess.html
        ///</summary>
        public static Engine KillProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KillProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the graph with Kirchhoff matrix kmat.
        ///https://reference.wolfram.com/language/ref/KirchhoffGraph.html
        ///</summary>
        public static Engine KirchhoffGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KirchhoffGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the graph with vertices vi and Kirchhoff matrix kmat.
        ///https://reference.wolfram.com/language/ref/KirchhoffGraph.html
        ///</summary>
        public static Engine KirchhoffGraph(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KirchhoffGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Kirchhoff matrix of the graph g.
        ///https://reference.wolfram.com/language/ref/KirchhoffMatrix.html
        ///</summary>
        public static Engine KirchhoffMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KirchhoffMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/KirchhoffMatrix.html
        ///</summary>
        public static Engine KirchhoffMatrix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("KirchhoffMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Klein invariant modular elliptic function .
        ///https://reference.wolfram.com/language/ref/KleinInvariantJ.html
        ///</summary>
        public static Engine KleinInvariantJ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KleinInvariantJ[" + arg0 + "]", name);
        }

        ///<summary>
        ///solves the knapsack problem of finding the maximum number of items associated with each of the costi, subject to the constraint that the total cost is not larger than maxtotalcost.
        ///https://reference.wolfram.com/language/ref/KnapsackSolve.html
        ///</summary>
        public static Engine KnapsackSolve(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("KnapsackSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a number of items that maximizes the total payoff, while satisfying the constraint on the total cost.
        ///https://reference.wolfram.com/language/ref/KnapsackSolve.html
        ///</summary>
        public static Engine KnapsackSolve(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("KnapsackSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a result that gives a total payoff not larger than maxtotalpayoff.
        ///https://reference.wolfram.com/language/ref/KnapsackSolve.html
        ///</summary>
        public static Engine KnapsackSolve(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KnapsackSolve[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///labels each type of item and gives the result as an association.
        ///https://reference.wolfram.com/language/ref/KnapsackSolve.html
        ///</summary>
        public static Engine KnapsackSolve(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KnapsackSolve[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a Knight's tour graph on an mn chessboard.
        ///https://reference.wolfram.com/language/ref/KnightTourGraph.html
        ///</summary>
        public static Engine KnightTourGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KnightTourGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified property for a knot.
        ///https://reference.wolfram.com/language/ref/KnotData.html
        ///</summary>
        public static Engine KnotData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KnotData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an image of the knot.
        ///https://reference.wolfram.com/language/ref/KnotData.html
        ///</summary>
        public static Engine KnotData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KnotData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if expr is a canonical unit, and False otherwise.
        ///https://reference.wolfram.com/language/ref/KnownUnitQ.html
        ///</summary>
        public static Engine KnownUnitQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KnownUnitQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the line segments representing the n-step Koch curve.
        ///https://reference.wolfram.com/language/ref/KochCurve.html
        ///</summary>
        public static Engine KochCurve(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KochCurve[" + arg0 + "]", name);
        }

        ///<summary>
        ///takes a series of steps of unit length at successive relative angles θi.
        ///https://reference.wolfram.com/language/ref/KochCurve.html
        ///</summary>
        public static Engine KochCurve(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("KochCurve[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///takes successive steps of lengths proportional to ri.
        ///https://reference.wolfram.com/language/ref/KochCurve.html
        ///</summary>
        public static Engine KochCurve(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("KochCurve[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Kolmogorov–Smirnov test.
        ///https://reference.wolfram.com/language/ref/KolmogorovSmirnovTest.html
        ///</summary>
        public static Engine KolmogorovSmirnovTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KolmogorovSmirnovTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is distributed according to dist using the Kolmogorov–Smirnov test.
        ///https://reference.wolfram.com/language/ref/KolmogorovSmirnovTest.html
        ///</summary>
        public static Engine KolmogorovSmirnovTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KolmogorovSmirnovTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/KolmogorovSmirnovTest.html
        ///</summary>
        public static Engine KolmogorovSmirnovTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KolmogorovSmirnovTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Kronecker delta , equal to 1 if all the  are equal, and 0 otherwise.
        ///https://reference.wolfram.com/language/ref/KroneckerDelta.html
        ///</summary>
        public static Engine KroneckerDelta(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KroneckerDelta[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields the Kronecker decomposition of a descriptor state-space model ssm.
        ///https://reference.wolfram.com/language/ref/KroneckerModelDecomposition.html
        ///</summary>
        public static Engine KroneckerModelDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KroneckerModelDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///constructs the Kronecker product of the arrays mi.
        ///https://reference.wolfram.com/language/ref/KroneckerProduct.html
        ///</summary>
        public static Engine KroneckerProduct(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KroneckerProduct[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Kronecker symbol .
        ///https://reference.wolfram.com/language/ref/KroneckerSymbol.html
        ///</summary>
        public static Engine KroneckerSymbol(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KroneckerSymbol[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Kuiper test.
        ///https://reference.wolfram.com/language/ref/KuiperTest.html
        ///</summary>
        public static Engine KuiperTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("KuiperTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is distributed according to dist using the Kuiper test.
        ///https://reference.wolfram.com/language/ref/KuiperTest.html
        ///</summary>
        public static Engine KuiperTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KuiperTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/KuiperTest.html
        ///</summary>
        public static Engine KuiperTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("KuiperTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Kumaraswamy distribution with shape parameters α and β.
        ///https://reference.wolfram.com/language/ref/KumaraswamyDistribution.html
        ///</summary>
        public static Engine KumaraswamyDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KumaraswamyDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the coefficient of kurtosis for the elements in list.
        ///https://reference.wolfram.com/language/ref/Kurtosis.html
        ///</summary>
        public static Engine Kurtosis(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Kurtosis[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes for each element p in data the variance of the values in the four (r+1)×(r+1) squares that have p as a corner, and replaces p with the mean of the values of the square with least variance.
        ///https://reference.wolfram.com/language/ref/KuwaharaFilter.html
        ///</summary>
        public static Engine KuwaharaFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KuwaharaFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the k-vertex-connected components of the graph g.
        ///https://reference.wolfram.com/language/ref/KVertexConnectedComponents.html
        ///</summary>
        public static Engine KVertexConnectedComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KVertexConnectedComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the k-vertex-connected components that include at least one of the vertices v1, v2, … .
        ///https://reference.wolfram.com/language/ref/KVertexConnectedComponents.html
        ///</summary>
        public static Engine KVertexConnectedComponents(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("KVertexConnectedComponents[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is k-vertex-connected and False otherwise.
        ///https://reference.wolfram.com/language/ref/KVertexConnectedGraphQ.html
        ///</summary>
        public static Engine KVertexConnectedGraphQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("KVertexConnectedGraphQ[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}
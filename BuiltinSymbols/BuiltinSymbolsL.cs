namespace CoreWolf
{
    public static class BuiltinSymbolL
    {
        ///<summary>
        ///represents a color in the Lab color space with lightness l and color components a and b.
        ///https://reference.wolfram.com/language/ref/LABColor.html
        ///</summary>
        public static Engine LABColor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LABColor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies opacity α.
        ///https://reference.wolfram.com/language/ref/LABColor.html
        ///</summary>
        public static Engine LABColor(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LABColor[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///returns a color from an HTML color name etc.
        ///https://reference.wolfram.com/language/ref/LABColor.html
        ///</summary>
        public static Engine LABColor(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LABColor[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a point in a compound expression to which control can be transferred using Goto.
        ///https://reference.wolfram.com/language/ref/Label.html
        ///</summary>
        public static Engine Label(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Label[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays expr labeled with lbl.
        ///https://reference.wolfram.com/language/ref/Labeled.html
        ///</summary>
        public static Engine Labeled(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Labeled[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///places lbl at a position specified by pos.
        ///https://reference.wolfram.com/language/ref/Labeled.html
        ///</summary>
        public static Engine Labeled(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Labeled[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///places the lbli at positions posi.
        ///https://reference.wolfram.com/language/ref/Labeled.html
        ///</summary>
        public static Engine Labeled(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Labeled[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///places the lbli at the bottom, left, top, and right, respectively.
        ///https://reference.wolfram.com/language/ref/Labeled.html
        ///</summary>
        public static Engine Labeled(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Labeled[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Laguerre polynomial .
        ///https://reference.wolfram.com/language/ref/LaguerreL.html
        ///</summary>
        public static Engine LaguerreL(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LaguerreL[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the generalized Laguerre polynomial .
        ///https://reference.wolfram.com/language/ref/LaguerreL.html
        ///</summary>
        public static Engine LaguerreL(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LaguerreL[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the lake entity.
        ///https://reference.wolfram.com/language/ref/LakeData.html
        ///</summary>
        public static Engine LakeData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LakeData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified lake entities.
        ///https://reference.wolfram.com/language/ref/LakeData.html
        ///</summary>
        public static Engine LakeData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LakeData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/LakeData.html
        ///</summary>
        public static Engine LakeData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LakeData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the lambda components of the graph g.
        ///https://reference.wolfram.com/language/ref/LambdaComponents.html
        ///</summary>
        public static Engine LambdaComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LambdaComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the lambda components that include at least one of the vertices {v1,v2,…}.
        ///https://reference.wolfram.com/language/ref/LambdaComponents.html
        ///</summary>
        public static Engine LambdaComponents(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LambdaComponents[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/LambdaComponents.html
        ///</summary>
        public static Engine LambdaComponents(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LambdaComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the  Lamé function  of order  with elliptic parameter .
        ///https://reference.wolfram.com/language/ref/LameC.html
        ///</summary>
        public static Engine LameC(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LameC[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the -derivative of the  Lamé function  of order  with elliptic parameter .
        ///https://reference.wolfram.com/language/ref/LameCPrime.html
        ///</summary>
        public static Engine LameCPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LameCPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the  Lamé eigenvalue  of order  with elliptic parameter  for the function LameC[ν,j,z,m].
        ///https://reference.wolfram.com/language/ref/LameEigenvalueA.html
        ///</summary>
        public static Engine LameEigenvalueA(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LameEigenvalueA[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the  Lamé eigenvalue  of order  with elliptic parameter  for the Lamé function LameS[ν,j,z,m].
        ///https://reference.wolfram.com/language/ref/LameEigenvalueB.html
        ///</summary>
        public static Engine LameEigenvalueB(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LameEigenvalueB[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the  Lamé function  of order  with elliptic parameter .
        ///https://reference.wolfram.com/language/ref/LameS.html
        ///</summary>
        public static Engine LameS(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LameS[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the -derivative of the  Lamé function  of order  with elliptic parameter .
        ///https://reference.wolfram.com/language/ref/LameSPrime.html
        ///</summary>
        public static Engine LameSPrime(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LameSPrime[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the lamina entity.
        ///https://reference.wolfram.com/language/ref/LaminaData.html
        ///</summary>
        public static Engine LaminaData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LaminaData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified lamina entities.
        ///https://reference.wolfram.com/language/ref/LaminaData.html
        ///</summary>
        public static Engine LaminaData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LaminaData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/LaminaData.html
        ///</summary>
        public static Engine LaminaData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LaminaData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Lanczos window function of x.
        ///https://reference.wolfram.com/language/ref/LanczosWindow.html
        ///</summary>
        public static Engine LanczosWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LanczosWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Landau distribution with location parameter μ and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/LandauDistribution.html
        ///</summary>
        public static Engine LandauDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LandauDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Landau distribution with location parameter 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/LandauDistribution.html
        ///</summary>
        public static Engine LandauDistribution(this Engine en, string? name = null)
        {
            return en.Execute("LandauDistribution[]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the language entity.
        ///https://reference.wolfram.com/language/ref/LanguageData.html
        ///</summary>
        public static Engine LanguageData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LanguageData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified language entities.
        ///https://reference.wolfram.com/language/ref/LanguageData.html
        ///</summary>
        public static Engine LanguageData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LanguageData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/LanguageData.html
        ///</summary>
        public static Engine LanguageData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LanguageData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///attempts to determine what human language text in string is in, predominantly.
        ///https://reference.wolfram.com/language/ref/LanguageIdentify.html
        ///</summary>
        public static Engine LanguageIdentify(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LanguageIdentify[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Laplace double-exponential distribution with mean μ and scale parameter β.
        ///https://reference.wolfram.com/language/ref/LaplaceDistribution.html
        ///</summary>
        public static Engine LaplaceDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LaplaceDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Laplace double-exponential distribution with mean 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/LaplaceDistribution.html
        ///</summary>
        public static Engine LaplaceDistribution(this Engine en, string? name = null)
        {
            return en.Execute("LaplaceDistribution[]", name);
        }

        ///<summary>
        ///gives the symbolic Laplace transform of f[t] in the variable t and returns a transform F[s] in the variable s.
        ///https://reference.wolfram.com/language/ref/LaplaceTransform.html
        ///</summary>
        public static Engine LaplaceTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LaplaceTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the numeric Laplace transform at the numerical value .
        ///https://reference.wolfram.com/language/ref/LaplaceTransform.html
        ///</summary>
        public static Engine LaplaceTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LaplaceTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Laplace transform of f[t1,…,tn].
        ///https://reference.wolfram.com/language/ref/LaplaceTransform.html
        ///</summary>
        public static Engine LaplaceTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LaplaceTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Laplacian .
        ///https://reference.wolfram.com/language/ref/Laplacian.html
        ///</summary>
        public static Engine Laplacian(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Laplacian[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Laplacian in the given coordinates chart.
        ///https://reference.wolfram.com/language/ref/Laplacian.html
        ///</summary>
        public static Engine Laplacian(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Laplacian[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///convolves data with a radius-r Laplacian kernel.
        ///https://reference.wolfram.com/language/ref/LaplacianFilter.html
        ///</summary>
        public static Engine LaplacianFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LaplacianFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses radius ri at level i in data.
        ///https://reference.wolfram.com/language/ref/LaplacianFilter.html
        ///</summary>
        public static Engine LaplacianFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LaplacianFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///convolves data with a Laplacian of Gaussian kernel of pixel radius r.
        ///https://reference.wolfram.com/language/ref/LaplacianGaussianFilter.html
        ///</summary>
        public static Engine LaplacianGaussianFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LaplacianGaussianFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///convolves data with a Laplacian of Gaussian kernel of radius r and standard deviation σ.
        ///https://reference.wolfram.com/language/ref/LaplacianGaussianFilter.html
        ///</summary>
        public static Engine LaplacianGaussianFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LaplacianGaussianFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a Laplacian term  with model variables vars.
        ///https://reference.wolfram.com/language/ref/LaplacianPDETerm.html
        ///</summary>
        public static Engine LaplacianPDETerm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LaplacianPDETerm[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the last element in expr.
        ///https://reference.wolfram.com/language/ref/Last.html
        ///</summary>
        public static Engine Last(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Last[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the last element if there are any elements, or def otherwise.
        ///https://reference.wolfram.com/language/ref/Last.html
        ///</summary>
        public static Engine Last(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Last[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the latitude in degrees of a geographic position specified by pos.
        ///https://reference.wolfram.com/language/ref/Latitude.html
        ///</summary>
        public static Engine Latitude(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Latitude[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the latitude referring to the specified geodetic datum.
        ///https://reference.wolfram.com/language/ref/Latitude.html
        ///</summary>
        public static Engine Latitude(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Latitude[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the latitude and longitude in degrees of a geographic position specified by pos.
        ///https://reference.wolfram.com/language/ref/LatitudeLongitude.html
        ///</summary>
        public static Engine LatitudeLongitude(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LatitudeLongitude[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the latitude and longitude referring to the specified geodetic datum.
        ///https://reference.wolfram.com/language/ref/LatitudeLongitude.html
        ///</summary>
        public static Engine LatitudeLongitude(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LatitudeLongitude[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified property for a lattice.
        ///https://reference.wolfram.com/language/ref/LatticeData.html
        ///</summary>
        public static Engine LatticeData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LatticeData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of named lattices of dimension n.
        ///https://reference.wolfram.com/language/ref/LatticeData.html
        ///</summary>
        public static Engine LatticeData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LatticeData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a reduced basis for the set of vectors vi.
        ///https://reference.wolfram.com/language/ref/LatticeReduce.html
        ///</summary>
        public static Engine LatticeReduce(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LatticeReduce[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///launches all currently configured parallel subkernels.
        ///https://reference.wolfram.com/language/ref/LaunchKernels.html
        ///</summary>
        public static Engine LaunchKernels(this Engine en, string? name = null)
        {
            return en.Execute("LaunchKernels[]", name);
        }

        ///<summary>
        ///launches n local subkernels on the current computer.
        ///https://reference.wolfram.com/language/ref/LaunchKernels.html
        ///</summary>
        public static Engine LaunchKernels(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LaunchKernels[" + arg0 + "]", name);
        }

        ///<summary>
        ///launches the kernels keri.
        ///https://reference.wolfram.com/language/ref/LaunchKernels.html
        ///</summary>
        public static Engine LaunchKernels(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LaunchKernels[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a layered plot of the graph g.
        ///https://reference.wolfram.com/language/ref/LayeredGraphPlot.html
        ///</summary>
        public static Engine LayeredGraphPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LayeredGraphPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a layered plot of the graph with edges ej.
        ///https://reference.wolfram.com/language/ref/LayeredGraphPlot.html
        ///</summary>
        public static Engine LayeredGraphPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LayeredGraphPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///places the dominant vertex v in the plot at position pos.
        ///https://reference.wolfram.com/language/ref/LayeredGraphPlot.html
        ///</summary>
        public static Engine LayeredGraphPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LayeredGraphPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a 3D layered plot of the graph g.
        ///https://reference.wolfram.com/language/ref/LayeredGraphPlot3D.html
        ///</summary>
        public static Engine LayeredGraphPlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LayeredGraphPlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a 3D layered plot of the graph with edges ei.
        ///https://reference.wolfram.com/language/ref/LayeredGraphPlot3D.html
        ///</summary>
        public static Engine LayeredGraphPlot3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LayeredGraphPlot3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///places the dominant vertex v in the plot at position pos.
        ///https://reference.wolfram.com/language/ref/LayeredGraphPlot3D.html
        ///</summary>
        public static Engine LayeredGraphPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LayeredGraphPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a color in the LCH color space with lightness l, chroma c and hue h.
        ///https://reference.wolfram.com/language/ref/LCHColor.html
        ///</summary>
        public static Engine LCHColor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LCHColor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies opacity a.
        ///https://reference.wolfram.com/language/ref/LCHColor.html
        ///</summary>
        public static Engine LCHColor(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LCHColor[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///returns a color from an HTML color name etc.
        ///https://reference.wolfram.com/language/ref/LCHColor.html
        ///</summary>
        public static Engine LCHColor(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LCHColor[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the least common multiple of the ni.
        ///https://reference.wolfram.com/language/ref/LCM.html
        ///</summary>
        public static Engine LCM(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LCM[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the total number of indivisible subexpressions in expr.
        ///https://reference.wolfram.com/language/ref/LeafCount.html
        ///</summary>
        public static Engine LeafCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LeafCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a repeated calendar element caused by a leap period.
        ///https://reference.wolfram.com/language/ref/LeapVariant.html
        ///</summary>
        public static Engine LeapVariant(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LeapVariant[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if the year corresponding to date is a leap year.
        ///https://reference.wolfram.com/language/ref/LeapYearQ.html
        ///</summary>
        public static Engine LeapYearQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LeapYearQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a LearnedDistribution[…] that attempts to represent an underlying distribution for the examples given.
        ///https://reference.wolfram.com/language/ref/LearnDistribution.html
        ///</summary>
        public static Engine LearnDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LearnDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a distribution generated by LearnDistribution.
        ///https://reference.wolfram.com/language/ref/LearnedDistribution.html
        ///</summary>
        public static Engine LearnedDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LearnedDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds an x that solves the linear least-squares problem for the matrix equation m.x==b.
        ///https://reference.wolfram.com/language/ref/LeastSquares.html
        ///</summary>
        public static Engine LeastSquares(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LeastSquares[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///creates a k-band finite impulse response (FIR) filter kernel of length n designed using a least squares method, given the specified frequencies ωi and amplitudes ai.
        ///https://reference.wolfram.com/language/ref/LeastSquaresFilterKernel.html
        ///</summary>
        public static Engine LeastSquaresFilterKernel(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("LeastSquaresFilterKernel[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses the full filter specification {"type",spec}.
        ///https://reference.wolfram.com/language/ref/LeastSquaresFilterKernel.html
        ///</summary>
        public static Engine LeastSquaresFilterKernel(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LeastSquaresFilterKernel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftArrow.html
        ///</summary>
        public static Engine LeftArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftArrowBar.html
        ///</summary>
        public static Engine LeftArrowBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftArrowBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftArrowRightArrow.html
        ///</summary>
        public static Engine LeftArrowRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftArrowRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftDownTeeVector.html
        ///</summary>
        public static Engine LeftDownTeeVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftDownTeeVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftDownVector.html
        ///</summary>
        public static Engine LeftDownVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftDownVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftDownVectorBar.html
        ///</summary>
        public static Engine LeftDownVectorBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftDownVectorBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftRightArrow.html
        ///</summary>
        public static Engine LeftRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftRightVector.html
        ///</summary>
        public static Engine LeftRightVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftRightVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftTee.html
        ///</summary>
        public static Engine LeftTee(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LeftTee[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftTeeArrow.html
        ///</summary>
        public static Engine LeftTeeArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftTeeArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftTeeVector.html
        ///</summary>
        public static Engine LeftTeeVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftTeeVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftTriangle.html
        ///</summary>
        public static Engine LeftTriangle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftTriangle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftTriangleBar.html
        ///</summary>
        public static Engine LeftTriangleBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftTriangleBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftTriangleEqual.html
        ///</summary>
        public static Engine LeftTriangleEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftTriangleEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftUpDownVector.html
        ///</summary>
        public static Engine LeftUpDownVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftUpDownVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftUpTeeVector.html
        ///</summary>
        public static Engine LeftUpTeeVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftUpTeeVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftUpVector.html
        ///</summary>
        public static Engine LeftUpVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftUpVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftUpVectorBar.html
        ///</summary>
        public static Engine LeftUpVectorBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftUpVectorBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftVector.html
        ///</summary>
        public static Engine LeftVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LeftVectorBar.html
        ///</summary>
        public static Engine LeftVectorBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LeftVectorBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays expr with legend leg.
        ///https://reference.wolfram.com/language/ref/Legended.html
        ///</summary>
        public static Engine Legended(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Legended[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Legendre polynomial .
        ///https://reference.wolfram.com/language/ref/LegendreP.html
        ///</summary>
        public static Engine LegendreP(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LegendreP[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the associated Legendre polynomial .
        ///https://reference.wolfram.com/language/ref/LegendreP.html
        ///</summary>
        public static Engine LegendreP(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LegendreP[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Legendre function of the second kind .
        ///https://reference.wolfram.com/language/ref/LegendreQ.html
        ///</summary>
        public static Engine LegendreQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LegendreQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the associated Legendre function of the second kind .
        ///https://reference.wolfram.com/language/ref/LegendreQ.html
        ///</summary>
        public static Engine LegendreQ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LegendreQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the number of elements in expr.
        ///https://reference.wolfram.com/language/ref/Length.html
        ///</summary>
        public static Engine Length(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Length[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of contiguous elements ei starting at the beginning of list for which crit[ei] is True.
        ///https://reference.wolfram.com/language/ref/LengthWhile.html
        ///</summary>
        public static Engine LengthWhile(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LengthWhile[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Lerch transcendent Φ(z,s,a).
        ///https://reference.wolfram.com/language/ref/LerchPhi.html
        ///</summary>
        public static Engine LerchPhi(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LerchPhi[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LessEqualGreater.html
        ///</summary>
        public static Engine LessEqualGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LessEqualGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x≤y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/LessEqualThan.html
        ///</summary>
        public static Engine LessEqualThan(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LessEqualThan[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LessFullEqual.html
        ///</summary>
        public static Engine LessFullEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LessFullEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LessGreater.html
        ///</summary>
        public static Engine LessGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LessGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LessLess.html
        ///</summary>
        public static Engine LessLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LessLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LessSlantEqual.html
        ///</summary>
        public static Engine LessSlantEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LessSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x<y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/LessThan.html
        ///</summary>
        public static Engine LessThan(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LessThan[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LessTilde.html
        ///</summary>
        public static Engine LessTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LessTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives an association whose keys are the distinct letters in string, and whose values give the number of times those letters appear in string.
        ///https://reference.wolfram.com/language/ref/LetterCounts.html
        ///</summary>
        public static Engine LetterCounts(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LetterCounts[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives counts of the distinct n-grams consisting of runs of n letters in string.
        ///https://reference.wolfram.com/language/ref/LetterCounts.html
        ///</summary>
        public static Engine LetterCounts(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LetterCounts[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///allows the characters ci to appear in n-grams, in addition to ordinary letters.
        ///https://reference.wolfram.com/language/ref/LetterCounts.html
        ///</summary>
        public static Engine LetterCounts(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LetterCounts[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the position of the character c in the English alphabet.
        ///https://reference.wolfram.com/language/ref/LetterNumber.html
        ///</summary>
        public static Engine LetterNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LetterNumber[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the position of c in the alphabet specified by alpha.
        ///https://reference.wolfram.com/language/ref/LetterNumber.html
        ///</summary>
        public static Engine LetterNumber(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LetterNumber[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if all the characters in the string are letters, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/LetterQ.html
        ///</summary>
        public static Engine LetterQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LetterQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of all subexpressions of expr on levels specified by levelspec.
        ///https://reference.wolfram.com/language/ref/Level.html
        ///</summary>
        public static Engine Level(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Level[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to the sequence of subexpressions.
        ///https://reference.wolfram.com/language/ref/Level.html
        ///</summary>
        public static Engine Level(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Level[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the variance of data is 1.
        ///https://reference.wolfram.com/language/ref/LeveneTest.html
        ///</summary>
        public static Engine LeveneTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LeveneTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the variances of data1, data2, … are equal.
        ///https://reference.wolfram.com/language/ref/LeveneTest.html
        ///</summary>
        public static Engine LeveneTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LeveneTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/LeveneTest.html
        ///</summary>
        public static Engine LeveneTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LeveneTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the d-dimensional Levi-Civita totally antisymmetric tensor.
        ///https://reference.wolfram.com/language/ref/LeviCivitaTensor.html
        ///</summary>
        public static Engine LeviCivitaTensor(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LeviCivitaTensor[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Lévy distribution with location parameter μ and dispersion parameter σ.
        ///https://reference.wolfram.com/language/ref/LevyDistribution.html
        ///</summary>
        public static Engine LevyDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LevyDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives Order[ai,bi] for the first non-coinciding pair ai,bi of elements, and 0 if the lists are identical.
        ///https://reference.wolfram.com/language/ref/LexicographicOrder.html
        ///</summary>
        public static Engine LexicographicOrder(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LexicographicOrder[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the ordering function p to compare ai with bi.
        ///https://reference.wolfram.com/language/ref/LexicographicOrder.html
        ///</summary>
        public static Engine LexicographicOrder(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("LexicographicOrder[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form that compares lists when applied to {a1,a2,…}, {b1,b2,…}.
        ///https://reference.wolfram.com/language/ref/LexicographicOrder.html
        ///</summary>
        public static Engine LexicographicOrder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LexicographicOrder[" + arg0 + "]", name);
        }

        ///<summary>
        ///sorts the list of expressions ei in lexicographic order.
        ///https://reference.wolfram.com/language/ref/LexicographicSort.html
        ///</summary>
        public static Engine LexicographicSort(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LexicographicSort[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///compares elements of the ei expressions using the ordering function p.
        ///https://reference.wolfram.com/language/ref/LexicographicSort.html
        ///</summary>
        public static Engine LexicographicSort(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LexicographicSort[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies the data type for a LibraryFunction argument or result to be datatype.
        ///https://reference.wolfram.com/language/ref/LibraryDataType.html
        ///</summary>
        public static Engine LibraryDataType(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LibraryDataType[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies an element type etype for data structures.
        ///https://reference.wolfram.com/language/ref/LibraryDataType.html
        ///</summary>
        public static Engine LibraryDataType(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LibraryDataType[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies an array depth d for array data types.
        ///https://reference.wolfram.com/language/ref/LibraryDataType.html
        ///</summary>
        public static Engine LibraryDataType(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LibraryDataType[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a function that has been loaded from a Wolfram Library.
        ///https://reference.wolfram.com/language/ref/LibraryFunction.html
        ///</summary>
        public static Engine LibraryFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LibraryFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a function declaration that exposes the library function extName with the type type from the library lib, for use in compiled code.
        ///https://reference.wolfram.com/language/ref/LibraryFunctionDeclaration.html
        ///</summary>
        public static Engine LibraryFunctionDeclaration(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LibraryFunctionDeclaration[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///assumes that the library will be loaded by the time the function is compiled.
        ///https://reference.wolfram.com/language/ref/LibraryFunctionDeclaration.html
        ///</summary>
        public static Engine LibraryFunctionDeclaration(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LibraryFunctionDeclaration[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an error returned from a LibraryFunction.
        ///https://reference.wolfram.com/language/ref/LibraryFunctionError.html
        ///</summary>
        public static Engine LibraryFunctionError(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LibraryFunctionError[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns information about a LibraryFunction.
        ///https://reference.wolfram.com/language/ref/LibraryFunctionInformation.html
        ///</summary>
        public static Engine LibraryFunctionInformation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LibraryFunctionInformation[" + arg0 + "]", name);
        }

        ///<summary>
        ///loads Wolfram Library lib and makes the library function fun available in the Wolfram Language.
        ///https://reference.wolfram.com/language/ref/LibraryFunctionLoad.html
        ///</summary>
        public static Engine LibraryFunctionLoad(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LibraryFunctionLoad[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///unloads a LibraryFunction so that it cannot be used.
        ///https://reference.wolfram.com/language/ref/LibraryFunctionUnload.html
        ///</summary>
        public static Engine LibraryFunctionUnload(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LibraryFunctionUnload[" + arg0 + "]", name);
        }

        ///<summary>
        ///loads the dynamic library lib into the Wolfram System runtime.
        ///https://reference.wolfram.com/language/ref/LibraryLoad.html
        ///</summary>
        public static Engine LibraryLoad(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LibraryLoad[" + arg0 + "]", name);
        }

        ///<summary>
        ///unloads all functions that have been loaded from a Wolfram Library, then it unloads the library.
        ///https://reference.wolfram.com/language/ref/LibraryUnload.html
        ///</summary>
        public static Engine LibraryUnload(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LibraryUnload[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an on-demand license entitlement.
        ///https://reference.wolfram.com/language/ref/LicenseEntitlementObject.html
        ///</summary>
        public static Engine LicenseEntitlementObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LicenseEntitlementObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of on-demand license entitlements owned by you.
        ///https://reference.wolfram.com/language/ref/LicenseEntitlements.html
        ///</summary>
        public static Engine LicenseEntitlements(this Engine en, string? name = null)
        {
            return en.Execute("LicenseEntitlements[]", name);
        }

        ///<summary>
        ///represents lifting-filter data used to compute forward and inverse lifting wavelet transforms.
        ///https://reference.wolfram.com/language/ref/LiftingFilterData.html
        ///</summary>
        public static Engine LiftingFilterData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LiftingFilterData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the lifting wavelet transform (LWT) of an array of data.
        ///https://reference.wolfram.com/language/ref/LiftingWaveletTransform.html
        ///</summary>
        public static Engine LiftingWaveletTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LiftingWaveletTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the lifting wavelet transform using the wavelet wave.
        ///https://reference.wolfram.com/language/ref/LiftingWaveletTransform.html
        ///</summary>
        public static Engine LiftingWaveletTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LiftingWaveletTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the lifting wavelet transform using r levels of refinement.
        ///https://reference.wolfram.com/language/ref/LiftingWaveletTransform.html
        ///</summary>
        public static Engine LiftingWaveletTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LiftingWaveletTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a lighter version of the specified color.
        ///https://reference.wolfram.com/language/ref/Lighter.html
        ///</summary>
        public static Engine Lighter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Lighter[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a version of the specified color lightened by a fraction f.
        ///https://reference.wolfram.com/language/ref/Lighter.html
        ///</summary>
        public static Engine Lighter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Lighter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the likelihood function for observations x1, x2, … from the distribution dist.
        ///https://reference.wolfram.com/language/ref/Likelihood.html
        ///</summary>
        public static Engine Likelihood(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Likelihood[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the likelihood function for the observations xi at time ti from the process proc.
        ///https://reference.wolfram.com/language/ref/Likelihood.html
        ///</summary>
        public static Engine Likelihood(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Likelihood[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the limit xx*f(x).
        ///https://reference.wolfram.com/language/ref/Limit.html
        ///</summary>
        public static Engine Limit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Limit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the nested limit ⋯ f (x1,…,xn).
        ///https://reference.wolfram.com/language/ref/Limit.html
        ///</summary>
        public static Engine Limit(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Limit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a Lindley distribution with shape parameter δ.
        ///https://reference.wolfram.com/language/ref/LindleyDistribution.html
        ///</summary>
        public static Engine LindleyDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LindleyDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the line segments joining a sequence for points pi.
        ///https://reference.wolfram.com/language/ref/Line.html
        ///</summary>
        public static Engine Line(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Line[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a collection of lines.
        ///https://reference.wolfram.com/language/ref/Line.html
        ///</summary>
        public static Engine Line(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Line[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds values of variables vars that minimize the linear fractional objective f subject to linear constraints cons.
        ///https://reference.wolfram.com/language/ref/LinearFractionalOptimization.html
        ///</summary>
        public static Engine LinearFractionalOptimization(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LinearFractionalOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a vector  that minimizes the linear fractional function  subject to the linear inequality constraints .
        ///https://reference.wolfram.com/language/ref/LinearFractionalOptimization.html
        ///</summary>
        public static Engine LinearFractionalOptimization(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LinearFractionalOptimization[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///includes the linear equality constraints .
        ///https://reference.wolfram.com/language/ref/LinearFractionalOptimization.html
        ///</summary>
        public static Engine LinearFractionalOptimization(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LinearFractionalOptimization[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///takes  to be in the domain domi, where domi is Integers or Reals.
        ///https://reference.wolfram.com/language/ref/LinearFractionalOptimization.html
        ///</summary>
        public static Engine LinearFractionalOptimization(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LinearFractionalOptimization[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///specifies what solution property "prop" should be returned.
        ///https://reference.wolfram.com/language/ref/LinearFractionalOptimization.html
        ///</summary>
        public static Engine LinearFractionalOptimization(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinearFractionalOptimization[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents a linear fractional transformation defined by the homogeneous matrix m.
        ///https://reference.wolfram.com/language/ref/LinearFractionalTransform.html
        ///</summary>
        public static Engine LinearFractionalTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinearFractionalTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a linear fractional transformation that maps  to .
        ///https://reference.wolfram.com/language/ref/LinearFractionalTransform.html
        ///</summary>
        public static Engine LinearFractionalTransform(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LinearFractionalTransform[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics directive specifying that faces of polygons and other filled graphics objects are to be drawn using a progressive transition between colors coli along a straight horizontal line.
        ///https://reference.wolfram.com/language/ref/LinearGradientFilling.html
        ///</summary>
        public static Engine LinearGradientFilling(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LinearGradientFilling[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///draws along the straight line with a direction dir.
        ///https://reference.wolfram.com/language/ref/LinearGradientFilling.html
        ///</summary>
        public static Engine LinearGradientFilling(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LinearGradientFilling[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the specified padding when drawing beyond the boundary positions pos1 and posn.
        ///https://reference.wolfram.com/language/ref/LinearGradientFilling.html
        ///</summary>
        public static Engine LinearGradientFilling(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LinearGradientFilling[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns an image with values linearly changing from left to right based on gradient color gcol.
        ///https://reference.wolfram.com/language/ref/LinearGradientImage.html
        ///</summary>
        public static Engine LinearGradientImage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinearGradientImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a linear gradient image of the specified size.
        ///https://reference.wolfram.com/language/ref/LinearGradientImage.html
        ///</summary>
        public static Engine LinearGradientImage(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinearGradientImage[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an image converted to the specified type.
        ///https://reference.wolfram.com/language/ref/LinearGradientImage.html
        ///</summary>
        public static Engine LinearGradientImage(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LinearGradientImage[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents data of an AffineStateSpaceModel linearized by functions such as FeedbackLinearize and StateTransformationLinearize using transformation of variables.
        ///https://reference.wolfram.com/language/ref/LinearizingTransformationData.html
        ///</summary>
        public static Engine LinearizingTransformationData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinearizingTransformationData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a trainable, fully connected net layer that computes  with output vector of size n.
        ///https://reference.wolfram.com/language/ref/LinearLayer.html
        ///</summary>
        public static Engine LinearLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinearLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a layer that outputs an array of dimensions n1×n2×….
        ///https://reference.wolfram.com/language/ref/LinearLayer.html
        ///</summary>
        public static Engine LinearLayer(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LinearLayer[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///leaves the dimensions of the output array to be inferred from context.
        ///https://reference.wolfram.com/language/ref/LinearLayer.html
        ///</summary>
        public static Engine LinearLayer(this Engine en, string? name = null)
        {
            return en.Execute("LinearLayer[]", name);
        }

        ///<summary>
        ///includes options for initial weights and other parameters.
        ///https://reference.wolfram.com/language/ref/LinearLayer.html
        ///</summary>
        public static Engine LinearLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinearLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs a linear model of the form  that fits the yi for successive x values 1, 2, ….
        ///https://reference.wolfram.com/language/ref/LinearModelFit.html
        ///</summary>
        public static Engine LinearModelFit(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("LinearModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///constructs a linear model of the form  where the fi depend on the variables xk.
        ///https://reference.wolfram.com/language/ref/LinearModelFit.html
        ///</summary>
        public static Engine LinearModelFit(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("LinearModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///constructs a linear model from the design matrix m and response vector v.
        ///https://reference.wolfram.com/language/ref/LinearModelFit.html
        ///</summary>
        public static Engine LinearModelFit(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LinearModelFit[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds values of variables vars that minimize the linear objective f subject to linear constraints cons.
        ///https://reference.wolfram.com/language/ref/LinearOptimization.html
        ///</summary>
        public static Engine LinearOptimization(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LinearOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a real vector x that minimizes the linear objective  subject to the linear inequality constraints .
        ///https://reference.wolfram.com/language/ref/LinearOptimization.html
        ///</summary>
        public static Engine LinearOptimization(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LinearOptimization[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///includes the linear equality constraints .
        ///https://reference.wolfram.com/language/ref/LinearOptimization.html
        ///</summary>
        public static Engine LinearOptimization(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LinearOptimization[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///takes xi to be in the domain domi, where domi is Integers or Reals.
        ///https://reference.wolfram.com/language/ref/LinearOptimization.html
        ///</summary>
        public static Engine LinearOptimization(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LinearOptimization[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///specifies what solution property "prop" should be returned.
        ///https://reference.wolfram.com/language/ref/LinearOptimization.html
        ///</summary>
        public static Engine LinearOptimization(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinearOptimization[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the sequence of length n obtained by iterating the linear recurrence with kernel ker starting with initial values init.
        ///https://reference.wolfram.com/language/ref/LinearRecurrence.html
        ///</summary>
        public static Engine LinearRecurrence(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LinearRecurrence[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the n term.
        ///https://reference.wolfram.com/language/ref/LinearRecurrence.html
        ///</summary>
        public static Engine LinearRecurrence(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LinearRecurrence[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///finds an x that solves the matrix equation m.x==b.
        ///https://reference.wolfram.com/language/ref/LinearSolve.html
        ///</summary>
        public static Engine LinearSolve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinearSolve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a LinearSolveFunction[…] that can be applied repeatedly to different b.
        ///https://reference.wolfram.com/language/ref/LinearSolve.html
        ///</summary>
        public static Engine LinearSolve(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinearSolve[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a function for providing solutions to a matrix equation.
        ///https://reference.wolfram.com/language/ref/LinearSolveFunction.html
        ///</summary>
        public static Engine LinearSolveFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinearSolveFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes a line break chart with prices pi at date datei.
        ///https://reference.wolfram.com/language/ref/LineBreakChart.html
        ///</summary>
        public static Engine LineBreakChart(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LineBreakChart[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a line break chart of closing prices for the financial entity "name" over the date range daterange.
        ///https://reference.wolfram.com/language/ref/LineBreakChart.html
        ///</summary>
        public static Engine LineBreakChart(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LineBreakChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a line break chart where n bars in a row cause a reversal.
        ///https://reference.wolfram.com/language/ref/LineBreakChart.html
        ///</summary>
        public static Engine LineBreakChart(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LineBreakChart[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the line graph of the graph g.
        ///https://reference.wolfram.com/language/ref/LineGraph.html
        ///</summary>
        public static Engine LineGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LineGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/LineGraph.html
        ///</summary>
        public static Engine LineGraph(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LineGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a line integral convolution plot of image convolved with the vector field {vx,vy} as a function of x and y.
        ///https://reference.wolfram.com/language/ref/LineIntegralConvolutionPlot.html
        ///</summary>
        public static Engine LineIntegralConvolutionPlot(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LineIntegralConvolutionPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates a legend that associates color coli with label lbli.
        ///https://reference.wolfram.com/language/ref/LineLegend.html
        ///</summary>
        public static Engine LineLegend(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LineLegend[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a legend with placeholder labels for the colors coli.
        ///https://reference.wolfram.com/language/ref/LineLegend.html
        ///</summary>
        public static Engine LineLegend(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LineLegend[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a legend with inherited colors within visualization functions.
        ///https://reference.wolfram.com/language/ref/LineLegend.html
        ///</summary>
        public static Engine LineLegend(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LineLegend[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///activates a WSTP connection, waiting for the program at the other end to respond.
        ///https://reference.wolfram.com/language/ref/LinkActivate.html
        ///</summary>
        public static Engine LinkActivate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkActivate[" + arg0 + "]", name);
        }

        ///<summary>
        ///closes an open WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkClose.html
        ///</summary>
        public static Engine LinkClose(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkClose[" + arg0 + "]", name);
        }

        ///<summary>
        ///connects to a WSTP link created by another program.
        ///https://reference.wolfram.com/language/ref/LinkConnect.html
        ///</summary>
        public static Engine LinkConnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkConnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a WSTP link with the specified name for another program to connect to.
        ///https://reference.wolfram.com/language/ref/LinkCreate.html
        ///</summary>
        public static Engine LinkCreate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkCreate[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a WSTP link and picks an unused name for the link.
        ///https://reference.wolfram.com/language/ref/LinkCreate.html
        ///</summary>
        public static Engine LinkCreate(this Engine en, string? name = null)
        {
            return en.Execute("LinkCreate[]", name);
        }

        ///<summary>
        ///sends an interrupt to the program at the other end of the specified WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkInterrupt.html
        ///</summary>
        public static Engine LinkInterrupt(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkInterrupt[" + arg0 + "]", name);
        }

        ///<summary>
        ///starts the external program prog and opens a WSTP connection to it.
        ///https://reference.wolfram.com/language/ref/LinkLaunch.html
        ///</summary>
        public static Engine LinkLaunch(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkLaunch[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that represents an active WSTP connection for functions such as LinkRead and LinkWrite.
        ///https://reference.wolfram.com/language/ref/LinkObject.html
        ///</summary>
        public static Engine LinkObject(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LinkObject[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the patterns for which definitions were set up when the external program associated with the specified WSTP connection was installed.
        ///https://reference.wolfram.com/language/ref/LinkPatterns.html
        ///</summary>
        public static Engine LinkPatterns(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkPatterns[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the link-rank centralities for edges in the graph g and weight α.
        ///https://reference.wolfram.com/language/ref/LinkRankCentrality.html
        ///</summary>
        public static Engine LinkRankCentrality(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinkRankCentrality[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the link-rank centralities, using weight α and initial vertex page-rank centralities β.
        ///https://reference.wolfram.com/language/ref/LinkRankCentrality.html
        ///</summary>
        public static Engine LinkRankCentrality(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LinkRankCentrality[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/LinkRankCentrality.html
        ///</summary>
        public static Engine LinkRankCentrality(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LinkRankCentrality[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reads one expression from the specified WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkRead.html
        ///</summary>
        public static Engine LinkRead(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkRead[" + arg0 + "]", name);
        }

        ///<summary>
        ///wraps h around the expression read before evaluating it.
        ///https://reference.wolfram.com/language/ref/LinkRead.html
        ///</summary>
        public static Engine LinkRead(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinkRead[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether there is an expression ready to read from the specified WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkReadyQ.html
        ///</summary>
        public static Engine LinkReadyQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LinkReadyQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///waits for up to t seconds to see if an expression becomes ready to read.
        ///https://reference.wolfram.com/language/ref/LinkReadyQ.html
        ///</summary>
        public static Engine LinkReadyQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinkReadyQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests all the linki in parallel, returning as soon as any of them are ready to read from.
        ///https://reference.wolfram.com/language/ref/LinkReadyQ.html
        ///</summary>
        public static Engine LinkReadyQ(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LinkReadyQ[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of all WSTP connections that are currently open.
        ///https://reference.wolfram.com/language/ref/Links.html
        ///</summary>
        public static Engine Links(this Engine en, string? name = null)
        {
            return en.Execute("Links[]", name);
        }

        ///<summary>
        ///lists only links whose names match the specified string pattern.
        ///https://reference.wolfram.com/language/ref/Links.html
        ///</summary>
        public static Engine Links(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Links[" + arg0 + "]", name);
        }

        ///<summary>
        ///writes expr to the specified WSTP connection.
        ///https://reference.wolfram.com/language/ref/LinkWrite.html
        ///</summary>
        public static Engine LinkWrite(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LinkWrite[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Liouville function .
        ///https://reference.wolfram.com/language/ref/LiouvilleLambda.html
        ///</summary>
        public static Engine LiouvilleLambda(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LiouvilleLambda[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates an animation whose frames are the successive expri.
        ///https://reference.wolfram.com/language/ref/ListAnimate.html
        ///</summary>
        public static Engine ListAnimate(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListAnimate[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///displays fps frames per second.
        ///https://reference.wolfram.com/language/ref/ListAnimate.html
        ///</summary>
        public static Engine ListAnimate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListAnimate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a contour plot from an array of values fij.
        ///https://reference.wolfram.com/language/ref/ListContourPlot.html
        ///</summary>
        public static Engine ListContourPlot(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListContourPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates a contour plot from a three-dimensional array of values.
        ///https://reference.wolfram.com/language/ref/ListContourPlot3D.html
        ///</summary>
        public static Engine ListContourPlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListContourPlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a contour plot from values defined at specified points in three‐dimensional space.
        ///https://reference.wolfram.com/language/ref/ListContourPlot3D.html
        ///</summary>
        public static Engine ListContourPlot3D(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListContourPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///forms the convolution of the kernel ker with list.
        ///https://reference.wolfram.com/language/ref/ListConvolve.html
        ///</summary>
        public static Engine ListConvolve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListConvolve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///forms the cyclic convolution in which the k element of ker is aligned with each element in list.
        ///https://reference.wolfram.com/language/ref/ListConvolve.html
        ///</summary>
        public static Engine ListConvolve(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ListConvolve[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///forms the cyclic convolution whose first element contains list[[1]]ker[[kL]] and whose last element contains list[[-1]]ker[[kR]].
        ///https://reference.wolfram.com/language/ref/ListConvolve.html
        ///</summary>
        public static Engine ListConvolve(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListConvolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///forms the convolution in which list is padded at each end with repetitions of the element p.
        ///https://reference.wolfram.com/language/ref/ListConvolve.html
        ///</summary>
        public static Engine ListConvolve(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ListConvolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///forms the convolution in which list is padded at each end with cyclic repetitions of the pi.
        ///https://reference.wolfram.com/language/ref/ListConvolve.html
        ///</summary>
        public static Engine ListConvolve(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("ListConvolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///forms a generalized convolution in which g is used in place of Times and h in place of Plus.
        ///https://reference.wolfram.com/language/ref/ListConvolve.html
        ///</summary>
        public static Engine ListConvolve(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("ListConvolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///forms a convolution using elements at level lev in ker and list.
        ///https://reference.wolfram.com/language/ref/ListConvolve.html
        ///</summary>
        public static Engine ListConvolve(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, string? name = null)
        {
            return en.Execute("ListConvolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + "]", name);
        }

        ///<summary>
        ///forms the correlation of the kernel ker with list.
        ///https://reference.wolfram.com/language/ref/ListCorrelate.html
        ///</summary>
        public static Engine ListCorrelate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListCorrelate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///forms the cyclic correlation in which the k element of ker is aligned with each element in list.
        ///https://reference.wolfram.com/language/ref/ListCorrelate.html
        ///</summary>
        public static Engine ListCorrelate(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ListCorrelate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///forms the cyclic correlation whose first element contains list[[1]]ker[[kL]] and whose last element contains list[[-1]]ker[[kR]].
        ///https://reference.wolfram.com/language/ref/ListCorrelate.html
        ///</summary>
        public static Engine ListCorrelate(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListCorrelate[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///forms the correlation in which list is padded at each end with repetitions of the element p.
        ///https://reference.wolfram.com/language/ref/ListCorrelate.html
        ///</summary>
        public static Engine ListCorrelate(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ListCorrelate[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///forms the correlation in which list is padded at each end with cyclic repetitions of the pi.
        ///https://reference.wolfram.com/language/ref/ListCorrelate.html
        ///</summary>
        public static Engine ListCorrelate(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("ListCorrelate[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///forms a generalized correlation in which g is used in place of Times and h in place of Plus.
        ///https://reference.wolfram.com/language/ref/ListCorrelate.html
        ///</summary>
        public static Engine ListCorrelate(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("ListCorrelate[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///forms a correlation using elements at level lev in ker and list.
        ///https://reference.wolfram.com/language/ref/ListCorrelate.html
        ///</summary>
        public static Engine ListCorrelate(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, string? name = null)
        {
            return en.Execute("ListCorrelate[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + "]", name);
        }

        ///<summary>
        ///plots a curve that corresponds to a smooth path through the specified points.
        ///https://reference.wolfram.com/language/ref/ListCurvePathPlot.html
        ///</summary>
        public static Engine ListCurvePathPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListCurvePathPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a deconvolution of list using kernel ker.
        ///https://reference.wolfram.com/language/ref/ListDeconvolve.html
        ///</summary>
        public static Engine ListDeconvolve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListDeconvolve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a smooth density plot from an array of values fij.
        ///https://reference.wolfram.com/language/ref/ListDensityPlot.html
        ///</summary>
        public static Engine ListDensityPlot(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListDensityPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates a smooth density plot from an array of values.
        ///https://reference.wolfram.com/language/ref/ListDensityPlot3D.html
        ///</summary>
        public static Engine ListDensityPlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListDensityPlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a density plot with values fi at the specified points {xi,yi,zi}.
        ///https://reference.wolfram.com/language/ref/ListDensityPlot3D.html
        ///</summary>
        public static Engine ListDensityPlot3D(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListDensityPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the discrete-time Fourier transform (DTFT) of a list as a function of the parameter ω.
        ///https://reference.wolfram.com/language/ref/ListFourierSequenceTransform.html
        ///</summary>
        public static Engine ListFourierSequenceTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListFourierSequenceTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///places the first element of list at integer time k on the infinite time axis.
        ///https://reference.wolfram.com/language/ref/ListFourierSequenceTransform.html
        ///</summary>
        public static Engine ListFourierSequenceTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ListFourierSequenceTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional discrete-time Fourier transform
        ///https://reference.wolfram.com/language/ref/ListFourierSequenceTransform.html
        ///</summary>
        public static Engine ListFourierSequenceTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListFourierSequenceTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///constructs an InterpolatingFunction object that represents an approximate function that interpolates the array of values given.
        ///https://reference.wolfram.com/language/ref/ListInterpolation.html
        ///</summary>
        public static Engine ListInterpolation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListInterpolation[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies the domain of the grid from which the values in array are assumed to come.
        ///https://reference.wolfram.com/language/ref/ListInterpolation.html
        ///</summary>
        public static Engine ListInterpolation(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListInterpolation[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates a line integral convolution plot of image convolved with the vector field defined by an array of vector field values.
        ///https://reference.wolfram.com/language/ref/ListLineIntegralConvolutionPlot.html
        ///</summary>
        public static Engine ListLineIntegralConvolutionPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListLineIntegralConvolutionPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a line integral convolution plot of white noise convolved with the vector field defined by array.
        ///https://reference.wolfram.com/language/ref/ListLineIntegralConvolutionPlot.html
        ///</summary>
        public static Engine ListLineIntegralConvolutionPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListLineIntegralConvolutionPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a line integral convolution plot of image convolved with the vector field defined by vectors {vxi,vyi} at specified points {xi,yi}.
        ///https://reference.wolfram.com/language/ref/ListLineIntegralConvolutionPlot.html
        ///</summary>
        public static Engine ListLineIntegralConvolutionPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListLineIntegralConvolutionPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots a line through the points {1,y1},{2,y2},….
        ///https://reference.wolfram.com/language/ref/ListLinePlot.html
        ///</summary>
        public static Engine ListLinePlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListLinePlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots a line through a list of points with specific x and y positions.
        ///https://reference.wolfram.com/language/ref/ListLinePlot.html
        ///</summary>
        public static Engine ListLinePlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListLinePlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots a curve through the 3D points {xi,yi,zi}.
        ///https://reference.wolfram.com/language/ref/ListLinePlot3D.html
        ///</summary>
        public static Engine ListLinePlot3D(this Engine en, List<object> arg0, List<object> arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("ListLinePlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///plots each row {zi1,zi2,…,zin} as a curve in the  direction, with successive curves stacked in the  direction.
        ///https://reference.wolfram.com/language/ref/ListLinePlot3D.html
        ///</summary>
        public static Engine ListLinePlot3D(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListLinePlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots curves through multiple sets of {x,y,z} points.
        ///https://reference.wolfram.com/language/ref/ListLinePlot3D.html
        ///</summary>
        public static Engine ListLinePlot3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListLinePlot3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a log-linear plot of the yi, assumed to correspond to x coordinates 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ListLogLinearPlot.html
        ///</summary>
        public static Engine ListLogLinearPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListLogLinearPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a log-linear plot of the specified list of x and y values.
        ///https://reference.wolfram.com/language/ref/ListLogLinearPlot.html
        ///</summary>
        public static Engine ListLogLinearPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListLogLinearPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a log-log plot of the yi, assumed to correspond to x coordinates 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ListLogLogPlot.html
        ///</summary>
        public static Engine ListLogLogPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListLogLogPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a log-log plot of the specified list of x and y values.
        ///https://reference.wolfram.com/language/ref/ListLogLogPlot.html
        ///</summary>
        public static Engine ListLogLogPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListLogLogPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a log plot of the yi, assumed to correspond to x coordinates 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ListLogPlot.html
        ///</summary>
        public static Engine ListLogPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListLogPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a log plot of the specified list of x and y values.
        ///https://reference.wolfram.com/language/ref/ListLogPlot.html
        ///</summary>
        public static Engine ListLogPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListLogPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a list pane with setting list that can contain possible values vali.
        ///https://reference.wolfram.com/language/ref/ListPicker.html
        ///</summary>
        public static Engine ListPicker(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListPicker[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///is a low-level box structure that represents a list pane control.
        ///https://reference.wolfram.com/language/ref/ListPickerBox.html
        ///</summary>
        public static Engine ListPickerBox(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListPickerBox[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///creates an object that plays as a sound whose amplitude is given by the sequence of levels ai.
        ///https://reference.wolfram.com/language/ref/ListPlay.html
        ///</summary>
        public static Engine ListPlay(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListPlay[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots points {1,y1},{2,y2},….
        ///https://reference.wolfram.com/language/ref/ListPlot.html
        ///</summary>
        public static Engine ListPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a 2D scatter plot of points with coordinates {xi,yi}.
        ///https://reference.wolfram.com/language/ref/ListPlot.html
        ///</summary>
        public static Engine ListPlot(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates a surface representing an array of height values fij.
        ///https://reference.wolfram.com/language/ref/ListPlot3D.html
        ///</summary>
        public static Engine ListPlot3D(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots the surfaces corresponding to each of the datai.
        ///https://reference.wolfram.com/language/ref/ListPlot3D.html
        ///</summary>
        public static Engine ListPlot3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListPlot3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a 3D scatter plot of points with coordinates {xi,yi,zi}.
        ///https://reference.wolfram.com/language/ref/ListPointPlot3D.html
        ///</summary>
        public static Engine ListPointPlot3D(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListPointPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a 3D scatter plot of points with a 2D array of height values.
        ///https://reference.wolfram.com/language/ref/ListPointPlot3D.html
        ///</summary>
        public static Engine ListPointPlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListPointPlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots several collections of points, by default in different colors.
        ///https://reference.wolfram.com/language/ref/ListPointPlot3D.html
        ///</summary>
        public static Engine ListPointPlot3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListPointPlot3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots points equally spaced in angle at radii ri.
        ///https://reference.wolfram.com/language/ref/ListPolarPlot.html
        ///</summary>
        public static Engine ListPolarPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListPolarPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots points at polar coordinates θi, ri.
        ///https://reference.wolfram.com/language/ref/ListPolarPlot.html
        ///</summary>
        public static Engine ListPolarPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListPolarPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if the head of expr is List, and False otherwise.
        ///https://reference.wolfram.com/language/ref/ListQ.html
        ///</summary>
        public static Engine ListQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a contour plot of the three-dimensional array of values sliced to the surface surf.
        ///https://reference.wolfram.com/language/ref/ListSliceContourPlot3D.html
        ///</summary>
        public static Engine ListSliceContourPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListSliceContourPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a slice contour plot for the values fi at points {xi,yi,zi}.
        ///https://reference.wolfram.com/language/ref/ListSliceContourPlot3D.html
        ///</summary>
        public static Engine ListSliceContourPlot3D(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ListSliceContourPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates slice contour plots over several slices surf1, surf2, ….
        ///https://reference.wolfram.com/language/ref/ListSliceContourPlot3D.html
        ///</summary>
        public static Engine ListSliceContourPlot3D(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListSliceContourPlot3D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a density plot of the three-dimensional array of values sliced to the surface surf.
        ///https://reference.wolfram.com/language/ref/ListSliceDensityPlot3D.html
        ///</summary>
        public static Engine ListSliceDensityPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListSliceDensityPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a slice density plot for the values fi at points {xi,yi,zi}.
        ///https://reference.wolfram.com/language/ref/ListSliceDensityPlot3D.html
        ///</summary>
        public static Engine ListSliceDensityPlot3D(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ListSliceDensityPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates slice density plots over several slices surf1, surf2, ….
        ///https://reference.wolfram.com/language/ref/ListSliceDensityPlot3D.html
        ///</summary>
        public static Engine ListSliceDensityPlot3D(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListSliceDensityPlot3D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a vector plot from a 3D array of vector field values over the slice surface surf.
        ///https://reference.wolfram.com/language/ref/ListSliceVectorPlot3D.html
        ///</summary>
        public static Engine ListSliceVectorPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListSliceVectorPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a slice vector plot over several surfaces surf1, surf2, ….
        ///https://reference.wolfram.com/language/ref/ListSliceVectorPlot3D.html
        ///</summary>
        public static Engine ListSliceVectorPlot3D(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListSliceVectorPlot3D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots the values y1, y2, … in steps at points 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ListStepPlot.html
        ///</summary>
        public static Engine ListStepPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListStepPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots the values y1, y2, … in steps at points x1, x2, ….
        ///https://reference.wolfram.com/language/ref/ListStepPlot.html
        ///</summary>
        public static Engine ListStepPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListStepPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots using steps specified by step.
        ///https://reference.wolfram.com/language/ref/ListStepPlot.html
        ///</summary>
        public static Engine ListStepPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListStepPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a stream density plot from a 2D array of vector and scalar field values {{vxij,vyij},sij}.
        ///https://reference.wolfram.com/language/ref/ListStreamDensityPlot.html
        ///</summary>
        public static Engine ListStreamDensityPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListStreamDensityPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a stream density plot from vector and scalar field values {{vxi,vyi},si} given at specified points {xi,yi}.
        ///https://reference.wolfram.com/language/ref/ListStreamDensityPlot.html
        ///</summary>
        public static Engine ListStreamDensityPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListStreamDensityPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots data for several vector and scalar fields.
        ///https://reference.wolfram.com/language/ref/ListStreamDensityPlot.html
        ///</summary>
        public static Engine ListStreamDensityPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListStreamDensityPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a stream plot from an array of vector field values.
        ///https://reference.wolfram.com/language/ref/ListStreamPlot.html
        ///</summary>
        public static Engine ListStreamPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListStreamPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a stream plot from vector field values {vxi,vyi} given at specified points {xi,yi}.
        ///https://reference.wolfram.com/language/ref/ListStreamPlot.html
        ///</summary>
        public static Engine ListStreamPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListStreamPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots data for several vector fields.
        ///https://reference.wolfram.com/language/ref/ListStreamPlot.html
        ///</summary>
        public static Engine ListStreamPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListStreamPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots streamlines for the vector field given as an array of vectors.
        ///https://reference.wolfram.com/language/ref/ListStreamPlot3D.html
        ///</summary>
        public static Engine ListStreamPlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListStreamPlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots a three-dimensional surface constructed to fit the specified points.
        ///https://reference.wolfram.com/language/ref/ListSurfacePlot3D.html
        ///</summary>
        public static Engine ListSurfacePlot3D(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListSurfacePlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a vector plot from a 2D array of vector and scalar field values {{vxij,vyij},sij}.
        ///https://reference.wolfram.com/language/ref/ListVectorDensityPlot.html
        ///</summary>
        public static Engine ListVectorDensityPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListVectorDensityPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a vector plot from vector and scalar field values {{vxi,vyi},si} given at specified points {xi,yi}.
        ///https://reference.wolfram.com/language/ref/ListVectorDensityPlot.html
        ///</summary>
        public static Engine ListVectorDensityPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListVectorDensityPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots data for several vector and scalar fields.
        ///https://reference.wolfram.com/language/ref/ListVectorDensityPlot.html
        ///</summary>
        public static Engine ListVectorDensityPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListVectorDensityPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a displacement plot from an array of vector displacements {vxij,vyij}.
        ///https://reference.wolfram.com/language/ref/ListVectorDisplacementPlot.html
        ///</summary>
        public static Engine ListVectorDisplacementPlot(this Engine en, List<object> arg0, object arg1, List<object> arg2, object arg3, List<object> arg4, object arg5, List<object> arg6, string? name = null)
        {
            return en.Execute("ListVectorDisplacementPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + "{" + string.Join(',', arg4) + "}" + ", " + arg5 + ", " + "{" + string.Join(',', arg6) + "}" + "]", name);
        }

        ///<summary>
        ///generates a displacement plot from displacements {vxi,vyi} at point {xi,yi}.
        ///https://reference.wolfram.com/language/ref/ListVectorDisplacementPlot.html
        ///</summary>
        public static Engine ListVectorDisplacementPlot(this Engine en, List<object> arg0, List<object> arg1, object arg2, List<object> arg3, List<object> arg4, string? name = null)
        {
            return en.Execute("ListVectorDisplacementPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
        }

        ///<summary>
        ///uses the scalar values si at point {xi,yi} to color the displaced region.
        ///https://reference.wolfram.com/language/ref/ListVectorDisplacementPlot.html
        ///</summary>
        public static Engine ListVectorDisplacementPlot(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListVectorDisplacementPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots the displacement over the region reg.
        ///https://reference.wolfram.com/language/ref/ListVectorDisplacementPlot.html
        ///</summary>
        public static Engine ListVectorDisplacementPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListVectorDisplacementPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a displacement plot from an array of vector displacements {vxij,vyij,vzij}.
        ///https://reference.wolfram.com/language/ref/ListVectorDisplacementPlot3D.html
        ///</summary>
        public static Engine ListVectorDisplacementPlot3D(this Engine en, List<object> arg0, object arg1, List<object> arg2, object arg3, List<object> arg4, object arg5, List<object> arg6, string? name = null)
        {
            return en.Execute("ListVectorDisplacementPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + "{" + string.Join(',', arg4) + "}" + ", " + arg5 + ", " + "{" + string.Join(',', arg6) + "}" + "]", name);
        }

        ///<summary>
        ///generates a displacement plot from displacements {vxi,vyi,vzi} at point {xi,yi,zi}.
        ///https://reference.wolfram.com/language/ref/ListVectorDisplacementPlot3D.html
        ///</summary>
        public static Engine ListVectorDisplacementPlot3D(this Engine en, List<object> arg0, List<object> arg1, object arg2, List<object> arg3, List<object> arg4, string? name = null)
        {
            return en.Execute("ListVectorDisplacementPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
        }

        ///<summary>
        ///plots the displacement over the region reg.
        ///https://reference.wolfram.com/language/ref/ListVectorDisplacementPlot3D.html
        ///</summary>
        public static Engine ListVectorDisplacementPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListVectorDisplacementPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a vector plot from an array of vector field values.
        ///https://reference.wolfram.com/language/ref/ListVectorPlot.html
        ///</summary>
        public static Engine ListVectorPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListVectorPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a vector plot from vector field values {vxi,vyi} given at specified points {xi,yi}.
        ///https://reference.wolfram.com/language/ref/ListVectorPlot.html
        ///</summary>
        public static Engine ListVectorPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ListVectorPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots data for several vector fields.
        ///https://reference.wolfram.com/language/ref/ListVectorPlot.html
        ///</summary>
        public static Engine ListVectorPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListVectorPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a 3D vector plot from a 3D array of vector field values.
        ///https://reference.wolfram.com/language/ref/ListVectorPlot3D.html
        ///</summary>
        public static Engine ListVectorPlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ListVectorPlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots data for several vector fields.
        ///https://reference.wolfram.com/language/ref/ListVectorPlot3D.html
        ///</summary>
        public static Engine ListVectorPlot3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ListVectorPlot3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Z transform of list as a function of z.
        ///https://reference.wolfram.com/language/ref/ListZTransform.html
        ///</summary>
        public static Engine ListZTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ListZTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///places the first element of list at integer time k on the infinite time axis.
        ///https://reference.wolfram.com/language/ref/ListZTransform.html
        ///</summary>
        public static Engine ListZTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ListZTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Z transform.
        ///https://reference.wolfram.com/language/ref/ListZTransform.html
        ///</summary>
        public static Engine ListZTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ListZTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents a literal value x for use as a type.
        ///https://reference.wolfram.com/language/ref/LiteralType.html
        ///</summary>
        public static Engine LiteralType(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LiteralType[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a binary image from image by replacing values above the mean of the range-r neighborhood with 1 and others with 0.
        ///https://reference.wolfram.com/language/ref/LocalAdaptiveBinarize.html
        ///</summary>
        public static Engine LocalAdaptiveBinarize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalAdaptiveBinarize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces values above  with 1 and others with 0, where  and  are the local mean and standard deviation.
        ///https://reference.wolfram.com/language/ref/LocalAdaptiveBinarize.html
        ///</summary>
        public static Engine LocalAdaptiveBinarize(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LocalAdaptiveBinarize[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///caches a cloud object in a local object.
        ///https://reference.wolfram.com/language/ref/LocalCache.html
        ///</summary>
        public static Engine LocalCache(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalCache[" + arg0 + "]", name);
        }

        ///<summary>
        ///caches the contents of obj in the specified local object.
        ///https://reference.wolfram.com/language/ref/LocalCache.html
        ///</summary>
        public static Engine LocalCache(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalCache[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of local clustering coefficients of all vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/LocalClusteringCoefficient.html
        ///</summary>
        public static Engine LocalClusteringCoefficient(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalClusteringCoefficient[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the local clustering coefficient of the vertex v in the graph g.
        ///https://reference.wolfram.com/language/ref/LocalClusteringCoefficient.html
        ///</summary>
        public static Engine LocalClusteringCoefficient(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalClusteringCoefficient[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/LocalClusteringCoefficient.html
        ///</summary>
        public static Engine LocalClusteringCoefficient(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalClusteringCoefficient[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the result of evaluating expr using your current default local Wolfram Language kernel.
        ///https://reference.wolfram.com/language/ref/LocalEvaluate.html
        ///</summary>
        public static Engine LocalEvaluate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalEvaluate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the result of evaluating expr using the kernel specified by ker.
        ///https://reference.wolfram.com/language/ref/LocalEvaluate.html
        ///</summary>
        public static Engine LocalEvaluate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalEvaluate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the results of evaluating expr using each of the kernels keri.
        ///https://reference.wolfram.com/language/ref/LocalEvaluate.html
        ///</summary>
        public static Engine LocalEvaluate(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalEvaluate[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///wraps the head h around the result produced before returning it.
        ///https://reference.wolfram.com/language/ref/LocalEvaluate.html
        ///</summary>
        public static Engine LocalEvaluate(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LocalEvaluate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a new anonymous local object.
        ///https://reference.wolfram.com/language/ref/LocalObject.html
        ///</summary>
        public static Engine LocalObject(this Engine en, string? name = null)
        {
            return en.Execute("LocalObject[]", name);
        }

        ///<summary>
        ///represents a local object with a given file path.
        ///https://reference.wolfram.com/language/ref/LocalObject.html
        ///</summary>
        public static Engine LocalObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a local object relative to the base lbase.
        ///https://reference.wolfram.com/language/ref/LocalObject.html
        ///</summary>
        public static Engine LocalObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalObject[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of local objects in your current local base directory.
        ///https://reference.wolfram.com/language/ref/LocalObjects.html
        ///</summary>
        public static Engine LocalObjects(this Engine en, string? name = null)
        {
            return en.Execute("LocalObjects[]", name);
        }

        ///<summary>
        ///gives a list of local objects in the local directory dir.
        ///https://reference.wolfram.com/language/ref/LocalObjects.html
        ///</summary>
        public static Engine LocalObjects(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalObjects[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that normalizes its input by averaging across neighboring input channels.
        ///https://reference.wolfram.com/language/ref/LocalResponseNormalizationLayer.html
        ///</summary>
        public static Engine LocalResponseNormalizationLayer(this Engine en, string? name = null)
        {
            return en.Execute("LocalResponseNormalizationLayer[]", name);
        }

        ///<summary>
        ///submits a task to evaluate expr in a separate kernel.
        ///https://reference.wolfram.com/language/ref/LocalSubmit.html
        ///</summary>
        public static Engine LocalSubmit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalSubmit[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a symbol whose value is persistently stored in the local file system.
        ///https://reference.wolfram.com/language/ref/LocalSymbol.html
        ///</summary>
        public static Engine LocalSymbol(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalSymbol[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a DateObject corresponding to the current local time at the current geo location.
        ///https://reference.wolfram.com/language/ref/LocalTime.html
        ///</summary>
        public static Engine LocalTime(this Engine en, string? name = null)
        {
            return en.Execute("LocalTime[]", name);
        }

        ///<summary>
        ///gives the current local time at the geo location specified by loc.
        ///https://reference.wolfram.com/language/ref/LocalTime.html
        ///</summary>
        public static Engine LocalTime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalTime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the local time corresponding to the date object time at the geo location loc.
        ///https://reference.wolfram.com/language/ref/LocalTime.html
        ///</summary>
        public static Engine LocalTime(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalTime[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses func to determine what to return for extended geographic regions.
        ///https://reference.wolfram.com/language/ref/LocalTime.html
        ///</summary>
        public static Engine LocalTime(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LocalTime[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the current time zone for the current geo location.
        ///https://reference.wolfram.com/language/ref/LocalTimeZone.html
        ///</summary>
        public static Engine LocalTimeZone(this Engine en, string? name = null)
        {
            return en.Execute("LocalTimeZone[]", name);
        }

        ///<summary>
        ///gives the current time zone for the geo location specified by loc.
        ///https://reference.wolfram.com/language/ref/LocalTimeZone.html
        ///</summary>
        public static Engine LocalTimeZone(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocalTimeZone[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the time zone for the geo location loc on the specified date.
        ///https://reference.wolfram.com/language/ref/LocalTimeZone.html
        ///</summary>
        public static Engine LocalTimeZone(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocalTimeZone[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified property of the time zone.
        ///https://reference.wolfram.com/language/ref/LocalTimeZone.html
        ///</summary>
        public static Engine LocalTimeZone(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LocalTimeZone[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the means or medians of the datai are equal.
        ///https://reference.wolfram.com/language/ref/LocationEquivalenceTest.html
        ///</summary>
        public static Engine LocationEquivalenceTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LocationEquivalenceTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/LocationEquivalenceTest.html
        ///</summary>
        public static Engine LocationEquivalenceTest(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LocationEquivalenceTest[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the mean or median of the data is zero.
        ///https://reference.wolfram.com/language/ref/LocationTest.html
        ///</summary>
        public static Engine LocationTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LocationTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the means or medians of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/LocationTest.html
        ///</summary>
        public static Engine LocationTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LocationTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///tests a location measure against μ0.
        ///https://reference.wolfram.com/language/ref/LocationTest.html
        ///</summary>
        public static Engine LocationTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocationTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/LocationTest.html
        ///</summary>
        public static Engine LocationTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LocationTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a locator object at position {x,y} in a graphic.
        ///https://reference.wolfram.com/language/ref/Locator.html
        ///</summary>
        public static Engine Locator(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Locator[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///takes the position to be the dynamically updated current value of pos, with this value being reset if the locator object is moved.
        ///https://reference.wolfram.com/language/ref/Locator.html
        ///</summary>
        public static Engine Locator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Locator[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays obj as the locator object.
        ///https://reference.wolfram.com/language/ref/Locator.html
        ///</summary>
        public static Engine Locator(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Locator[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a pane with a locator at position {x,y} and background back.
        ///https://reference.wolfram.com/language/ref/LocatorPane.html
        ///</summary>
        public static Engine LocatorPane(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LocatorPane[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes the locator position to be the dynamically updated current value of pt, with the value of pt being reset if the locator is moved.
        ///https://reference.wolfram.com/language/ref/LocatorPane.html
        ///</summary>
        public static Engine LocatorPane(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LocatorPane[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies the range of coordinates for the locator.
        ///https://reference.wolfram.com/language/ref/LocatorPane.html
        ///</summary>
        public static Engine LocatorPane(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("LocatorPane[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///uses jumps dx, dy.
        ///https://reference.wolfram.com/language/ref/LocatorPane.html
        ///</summary>
        public static Engine LocatorPane(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, List<object> arg4, string? name = null)
        {
            return en.Execute("LocatorPane[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
        }

        ///<summary>
        ///gives the natural logarithm of z (logarithm to base ).
        ///https://reference.wolfram.com/language/ref/Log.html
        ///</summary>
        public static Engine Log(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Log[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the logarithm to base b.
        ///https://reference.wolfram.com/language/ref/Log.html
        ///</summary>
        public static Engine Log(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Log[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the base-10 logarithm of x.
        ///https://reference.wolfram.com/language/ref/Log10.html
        ///</summary>
        public static Engine Log10(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Log10[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the base-2 logarithm of x.
        ///https://reference.wolfram.com/language/ref/Log2.html
        ///</summary>
        public static Engine Log2(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Log2[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the logarithm of the Barnes G-function .
        ///https://reference.wolfram.com/language/ref/LogBarnesG.html
        ///</summary>
        public static Engine LogBarnesG(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LogBarnesG[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the logarithm of the gamma function .
        ///https://reference.wolfram.com/language/ref/LogGamma.html
        ///</summary>
        public static Engine LogGamma(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LogGamma[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a log-gamma distribution with shape parameters α and β and location parameter μ.
        ///https://reference.wolfram.com/language/ref/LogGammaDistribution.html
        ///</summary>
        public static Engine LogGammaDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LogGammaDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///expands out logical combinations of equations, inequalities, and other functions.
        ///https://reference.wolfram.com/language/ref/LogicalExpand.html
        ///</summary>
        public static Engine LogicalExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LogicalExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///is the logarithmic integral function .
        ///https://reference.wolfram.com/language/ref/LogIntegral.html
        ///</summary>
        public static Engine LogIntegral(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LogIntegral[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a logistic distribution with mean μ and scale parameter β.
        ///https://reference.wolfram.com/language/ref/LogisticDistribution.html
        ///</summary>
        public static Engine LogisticDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LogisticDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a logistic distribution with mean 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/LogisticDistribution.html
        ///</summary>
        public static Engine LogisticDistribution(this Engine en, string? name = null)
        {
            return en.Execute("LogisticDistribution[]", name);
        }

        ///<summary>
        ///gives the logistic sigmoid function.
        ///https://reference.wolfram.com/language/ref/LogisticSigmoid.html
        ///</summary>
        public static Engine LogisticSigmoid(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LogisticSigmoid[" + arg0 + "]", name);
        }

        ///<summary>
        ///constructs a binomial logistic regression model of the form  that fits the yi for successive x values 1, 2, ….
        ///https://reference.wolfram.com/language/ref/LogitModelFit.html
        ///</summary>
        public static Engine LogitModelFit(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("LogitModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///constructs a binomial logistic regression model of the form  where the fi depend on the variables xk.
        ///https://reference.wolfram.com/language/ref/LogitModelFit.html
        ///</summary>
        public static Engine LogitModelFit(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("LogitModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///constructs a binomial logistic regression model from the design matrix m and response vector v.
        ///https://reference.wolfram.com/language/ref/LogitModelFit.html
        ///</summary>
        public static Engine LogitModelFit(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LogitModelFit[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the log‐likelihood function for observations x1, x2, … from the distribution dist.
        ///https://reference.wolfram.com/language/ref/LogLikelihood.html
        ///</summary>
        public static Engine LogLikelihood(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LogLikelihood[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the log-likelihood function for the observations xi at time ti from the process proc.
        ///https://reference.wolfram.com/language/ref/LogLikelihood.html
        ///</summary>
        public static Engine LogLikelihood(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("LogLikelihood[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates a log-linear plot of f as a function of x from xmin to xmax.
        ///https://reference.wolfram.com/language/ref/LogLinearPlot.html
        ///</summary>
        public static Engine LogLinearPlot(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LogLinearPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots several functions fi.
        ///https://reference.wolfram.com/language/ref/LogLinearPlot.html
        ///</summary>
        public static Engine LogLinearPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LogLinearPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots fi with features defined by the symbolic wrapper w.
        ///https://reference.wolfram.com/language/ref/LogLinearPlot.html
        ///</summary>
        public static Engine LogLinearPlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LogLinearPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes the variable x to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/LogLinearPlot.html
        ///</summary>
        public static Engine LogLinearPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LogLinearPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a log-logistic distribution with shape parameter γ and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/LogLogisticDistribution.html
        ///</summary>
        public static Engine LogLogisticDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LogLogisticDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a log-log plot of f as a function of x from xmin to xmax.
        ///https://reference.wolfram.com/language/ref/LogLogPlot.html
        ///</summary>
        public static Engine LogLogPlot(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LogLogPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots several functions fi.
        ///https://reference.wolfram.com/language/ref/LogLogPlot.html
        ///</summary>
        public static Engine LogLogPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LogLogPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots fi with features defined by the symbolic wrapper w.
        ///https://reference.wolfram.com/language/ref/LogLogPlot.html
        ///</summary>
        public static Engine LogLogPlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LogLogPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes the variable x to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/LogLogPlot.html
        ///</summary>
        public static Engine LogLogPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LogLogPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a log-multinormal distribution with parameters μ and Σ.
        ///https://reference.wolfram.com/language/ref/LogMultinormalDistribution.html
        ///</summary>
        public static Engine LogMultinormalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LogMultinormalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a lognormal distribution derived from a normal distribution with mean μ and standard deviation σ.
        ///https://reference.wolfram.com/language/ref/LogNormalDistribution.html
        ///</summary>
        public static Engine LogNormalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LogNormalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a log plot of f as a function of x from xmin to xmax.
        ///https://reference.wolfram.com/language/ref/LogPlot.html
        ///</summary>
        public static Engine LogPlot(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LogPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots several functions fi.
        ///https://reference.wolfram.com/language/ref/LogPlot.html
        ///</summary>
        public static Engine LogPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LogPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots fi with features defined by the symbolic wrapper w.
        ///https://reference.wolfram.com/language/ref/LogPlot.html
        ///</summary>
        public static Engine LogPlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LogPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes the variable x to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/LogPlot.html
        ///</summary>
        public static Engine LogPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LogPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests for equal hazard rates among the datai using a log-rank type test.
        ///https://reference.wolfram.com/language/ref/LogRankTest.html
        ///</summary>
        public static Engine LogRankTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("LogRankTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///performs a weighted log-rank test with weights wspec.
        ///https://reference.wolfram.com/language/ref/LogRankTest.html
        ///</summary>
        public static Engine LogRankTest(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LogRankTest[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/LogRankTest.html
        ///</summary>
        public static Engine LogRankTest(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LogRankTest[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a logarithmic series distribution with parameter θ.
        ///https://reference.wolfram.com/language/ref/LogSeriesDistribution.html
        ///</summary>
        public static Engine LogSeriesDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LogSeriesDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a pattern object that matches the longest sequence consistent with the pattern p.
        ///https://reference.wolfram.com/language/ref/Longest.html
        ///</summary>
        public static Engine Longest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Longest[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the longest sequence of contiguous or disjoint elements common to the strings, lists or biomolecular sequences s1 and s2.
        ///https://reference.wolfram.com/language/ref/LongestCommonSequence.html
        ///</summary>
        public static Engine LongestCommonSequence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LongestCommonSequence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the longest sequence of contiguous or disjoint elements common to the strings, lists or biomolecular sequences s1 and s2 and returns their positions.
        ///https://reference.wolfram.com/language/ref/LongestCommonSequencePositions.html
        ///</summary>
        public static Engine LongestCommonSequencePositions(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LongestCommonSequencePositions[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the longest contiguous subsequence of elements common to the strings, biomolecular sequences or lists s1 and s2.
        ///https://reference.wolfram.com/language/ref/LongestCommonSubsequence.html
        ///</summary>
        public static Engine LongestCommonSubsequence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LongestCommonSubsequence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the longest contiguous subsequence of elements common to the strings, biomolecular sequences or lists s1 and s2 and returns their positions {pos1,pos2} in s1 and s2.
        ///https://reference.wolfram.com/language/ref/LongestCommonSubsequencePositions.html
        ///</summary>
        public static Engine LongestCommonSubsequencePositions(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LongestCommonSubsequencePositions[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the longest ordered sequence of contiguous or disjoint elements in list.
        ///https://reference.wolfram.com/language/ref/LongestOrderedSequence.html
        ///</summary>
        public static Engine LongestOrderedSequence(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LongestOrderedSequence[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the longest ordered sequence using the ordering function p.
        ///https://reference.wolfram.com/language/ref/LongestOrderedSequence.html
        ///</summary>
        public static Engine LongestOrderedSequence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LongestOrderedSequence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the longitude in degrees of a geographic position specified by pos.
        ///https://reference.wolfram.com/language/ref/Longitude.html
        ///</summary>
        public static Engine Longitude(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Longitude[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the longitude referring to the specified geodetic datum.
        ///https://reference.wolfram.com/language/ref/Longitude.html
        ///</summary>
        public static Engine Longitude(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Longitude[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LongLeftArrow.html
        ///</summary>
        public static Engine LongLeftArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LongLeftArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LongLeftRightArrow.html
        ///</summary>
        public static Engine LongLeftRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LongLeftRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LongRightArrow.html
        ///</summary>
        public static Engine LongRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LongRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a trainable recurrent layer that takes a sequence of vectors and produces a sequence of vectors, each of size n.
        ///https://reference.wolfram.com/language/ref/LongShortTermMemoryLayer.html
        ///</summary>
        public static Engine LongShortTermMemoryLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LongShortTermMemoryLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///includes options for weights and other parameters.
        ///https://reference.wolfram.com/language/ref/LongShortTermMemoryLayer.html
        ///</summary>
        public static Engine LongShortTermMemoryLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LongShortTermMemoryLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///looks up the value associated with key in the association assoc; if the key is not present, Missing["KeyAbsent",key] is returned.
        ///https://reference.wolfram.com/language/ref/Lookup.html
        ///</summary>
        public static Engine Lookup(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Lookup[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the values associated with the keyi.
        ///https://reference.wolfram.com/language/ref/Lookup.html
        ///</summary>
        public static Engine Lookup(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Lookup[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list corresponding to the value of key in each associ.
        ///https://reference.wolfram.com/language/ref/Lookup.html
        ///</summary>
        public static Engine Lookup(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Lookup[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives default if the key is not present.
        ///https://reference.wolfram.com/language/ref/Lookup.html
        ///</summary>
        public static Engine Lookup(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Lookup[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///looks up the values associated with keys, wrapping each of then with head h before evaluation.
        ///https://reference.wolfram.com/language/ref/Lookup.html
        ///</summary>
        public static Engine Lookup(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Lookup[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of Lookup that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Lookup.html
        ///</summary>
        public static Engine Lookup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Lookup[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g has no self-loops, and False otherwise.
        ///https://reference.wolfram.com/language/ref/LoopFreeGraphQ.html
        ///</summary>
        public static Engine LoopFreeGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LoopFreeGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if all the characters in the string are lowercase letters, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/LowerCaseQ.html
        ///</summary>
        public static Engine LowerCaseQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LowerCaseQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LowerLeftArrow.html
        ///</summary>
        public static Engine LowerLeftArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LowerLeftArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/LowerRightArrow.html
        ///</summary>
        public static Engine LowerRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LowerRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a matrix in which all but the lower triangular elements of m are replaced with zeros.
        ///https://reference.wolfram.com/language/ref/LowerTriangularize.html
        ///</summary>
        public static Engine LowerTriangularize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LowerTriangularize[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces with zeros only the elements above the k subdiagonal of m.
        ///https://reference.wolfram.com/language/ref/LowerTriangularize.html
        ///</summary>
        public static Engine LowerTriangularize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LowerTriangularize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts the lower triangular matrix lmat to a structured array.
        ///https://reference.wolfram.com/language/ref/LowerTriangularMatrix.html
        ///</summary>
        public static Engine LowerTriangularMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LowerTriangularMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m is lower triangular, and False otherwise.
        ///https://reference.wolfram.com/language/ref/LowerTriangularMatrixQ.html
        ///</summary>
        public static Engine LowerTriangularMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LowerTriangularMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m is lower triangular starting down from the k diagonal, and False otherwise.
        ///https://reference.wolfram.com/language/ref/LowerTriangularMatrixQ.html
        ///</summary>
        public static Engine LowerTriangularMatrixQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LowerTriangularMatrixQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies a lowpass filter with a cutoff frequency ωc to an array of data.
        ///https://reference.wolfram.com/language/ref/LowpassFilter.html
        ///</summary>
        public static Engine LowpassFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LowpassFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a filter kernel of length n.
        ///https://reference.wolfram.com/language/ref/LowpassFilter.html
        ///</summary>
        public static Engine LowpassFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LowpassFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies a smoothing window wfun to the filter kernel.
        ///https://reference.wolfram.com/language/ref/LowpassFilter.html
        ///</summary>
        public static Engine LowpassFilter(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LowpassFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the optimal estimator gain matrix for the StateSpaceModel ssm, with process and measurement noise covariance matrices w and v.
        ///https://reference.wolfram.com/language/ref/LQEstimatorGains.html
        ///</summary>
        public static Engine LQEstimatorGains(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LQEstimatorGains[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///specifies sensors as the noisy measurements of ssm.
        ///https://reference.wolfram.com/language/ref/LQEstimatorGains.html
        ///</summary>
        public static Engine LQEstimatorGains(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LQEstimatorGains[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the optimal output feedback controller for the stochastic system specification sspec with noise covariance matrices cvs that minimize a cost function with weights wts.
        ///https://reference.wolfram.com/language/ref/LQGRegulator.html
        ///</summary>
        public static Engine LQGRegulator(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LQGRegulator[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the property "prop".
        ///https://reference.wolfram.com/language/ref/LQGRegulator.html
        ///</summary>
        public static Engine LQGRegulator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LQGRegulator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the state feedback gains for the system specification sspec that minimizes an output cost function with weights wts.
        ///https://reference.wolfram.com/language/ref/LQOutputRegulatorGains.html
        ///</summary>
        public static Engine LQOutputRegulatorGains(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LQOutputRegulatorGains[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the state feedback gains for the system specification sspec that minimizes a cost function with weights wts.
        ///https://reference.wolfram.com/language/ref/LQRegulatorGains.html
        ///</summary>
        public static Engine LQRegulatorGains(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LQRegulatorGains[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Lucas number .
        ///https://reference.wolfram.com/language/ref/LucasL.html
        ///</summary>
        public static Engine LucasL(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LucasL[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Lucas polynomial .
        ///https://reference.wolfram.com/language/ref/LucasL.html
        ///</summary>
        public static Engine LucasL(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LucasL[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Luccio–Sami components of the graph g.
        ///https://reference.wolfram.com/language/ref/LuccioSamiComponents.html
        ///</summary>
        public static Engine LuccioSamiComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LuccioSamiComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the components that include at least one of the vertices v1, v2, … .
        ///https://reference.wolfram.com/language/ref/LuccioSamiComponents.html
        ///</summary>
        public static Engine LuccioSamiComponents(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("LuccioSamiComponents[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/LuccioSamiComponents.html
        ///</summary>
        public static Engine LuccioSamiComponents(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LuccioSamiComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a representation of the LU decomposition of a square matrix m.
        ///https://reference.wolfram.com/language/ref/LUDecomposition.html
        ///</summary>
        public static Engine LUDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LUDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the time of the next lunar eclipse.
        ///https://reference.wolfram.com/language/ref/LunarEclipse.html
        ///</summary>
        public static Engine LunarEclipse(this Engine en, string? name = null)
        {
            return en.Execute("LunarEclipse[]", name);
        }

        ///<summary>
        ///gives the time for the next lunar eclipse after the specified date.
        ///https://reference.wolfram.com/language/ref/LunarEclipse.html
        ///</summary>
        public static Engine LunarEclipse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LunarEclipse[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the specified property value for the next lunar eclipse after the specified date.
        ///https://reference.wolfram.com/language/ref/LunarEclipse.html
        ///</summary>
        public static Engine LunarEclipse(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LunarEclipse[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a color in the LUV color space with lightness l and color components u and v.
        ///https://reference.wolfram.com/language/ref/LUVColor.html
        ///</summary>
        public static Engine LUVColor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LUVColor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies opacity a.
        ///https://reference.wolfram.com/language/ref/LUVColor.html
        ///</summary>
        public static Engine LUVColor(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("LUVColor[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///returns a color from an HTML color name etc.
        ///https://reference.wolfram.com/language/ref/LUVColor.html
        ///</summary>
        public static Engine LUVColor(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("LUVColor[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a solution  of the matrix Lyapunov equation .
        ///https://reference.wolfram.com/language/ref/LyapunovSolve.html
        ///</summary>
        public static Engine LyapunovSolve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("LyapunovSolve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///solves .
        ///https://reference.wolfram.com/language/ref/LyapunovSolve.html
        ///</summary>
        public static Engine LyapunovSolve(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("LyapunovSolve[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///solves .
        ///https://reference.wolfram.com/language/ref/LyapunovSolve.html
        ///</summary>
        public static Engine LyapunovSolve(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("LyapunovSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///solves .
        ///https://reference.wolfram.com/language/ref/LyapunovSolve.html
        ///</summary>
        public static Engine LyapunovSolve(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("LyapunovSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Lyons group .
        ///https://reference.wolfram.com/language/ref/LyonsGroupLy.html
        ///</summary>
        public static Engine LyonsGroupLy(this Engine en, string? name = null)
        {
            return en.Execute("LyonsGroupLy[]", name);
        }


    }
}
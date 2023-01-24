namespace NetWolf
{
    public static class BuiltinSymbolP
    {
        ///<summary>
        ///rescans all the installed paclets to rebuild the internal cache of paclet data.
        ///https://reference.wolfram.com/language/ref/PacletDataRebuild.html
        ///</summary>
        public static Engine PacletDataRebuild(this Engine en, string? name = null)
        {
            return en.Execute("PacletDataRebuild[]", name);
        }

        ///<summary>
        ///makes paclets in dir visible in the current session.
        ///https://reference.wolfram.com/language/ref/PacletDirectoryLoad.html
        ///</summary>
        public static Engine PacletDirectoryLoad(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletDirectoryLoad[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes paclets in all the diri visible in the current session.
        ///https://reference.wolfram.com/language/ref/PacletDirectoryLoad.html
        ///</summary>
        public static Engine PacletDirectoryLoad(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PacletDirectoryLoad[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes paclets in dir no longer visible in the current session.
        ///https://reference.wolfram.com/language/ref/PacletDirectoryUnload.html
        ///</summary>
        public static Engine PacletDirectoryUnload(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletDirectoryUnload[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes paclets in all the diri no longer visible in the current session.
        ///https://reference.wolfram.com/language/ref/PacletDirectoryUnload.html
        ///</summary>
        public static Engine PacletDirectoryUnload(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PacletDirectoryUnload[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///disables an installed paclet.
        ///https://reference.wolfram.com/language/ref/PacletDisable.html
        ///</summary>
        public static Engine PacletDisable(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletDisable[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of installed paclets that match "name".
        ///https://reference.wolfram.com/language/ref/PacletFind.html
        ///</summary>
        public static Engine PacletFind(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletFind[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of installed paclets that match "name" and criteria given by the propivali.
        ///https://reference.wolfram.com/language/ref/PacletFind.html
        ///</summary>
        public static Engine PacletFind(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PacletFind[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a list of paclets that match "name" available on known paclet sites.
        ///https://reference.wolfram.com/language/ref/PacletFindRemote.html
        ///</summary>
        public static Engine PacletFindRemote(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletFindRemote[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of paclets that match "name" and criteria given by the propivali available on known paclet sites.
        ///https://reference.wolfram.com/language/ref/PacletFindRemote.html
        ///</summary>
        public static Engine PacletFindRemote(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PacletFindRemote[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///installs or updates paclet.
        ///https://reference.wolfram.com/language/ref/PacletInstall.html
        ///</summary>
        public static Engine PacletInstall(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletInstall[" + arg0 + "]", name);
        }

        ///<summary>
        ///asynchronously installs or updates paclet.
        ///https://reference.wolfram.com/language/ref/PacletInstallSubmit.html
        ///</summary>
        public static Engine PacletInstallSubmit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletInstallSubmit[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if paclet1 has a higher version number than paclet2, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PacletNewerQ.html
        ///</summary>
        public static Engine PacletNewerQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PacletNewerQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a paclet on the local machine or on a remote paclet site.
        ///https://reference.wolfram.com/language/ref/PacletObject.html
        ///</summary>
        public static Engine PacletObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a site from which paclets can be automatically downloaded.
        ///https://reference.wolfram.com/language/ref/PacletSiteObject.html
        ///</summary>
        public static Engine PacletSiteObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletSiteObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///registers url as a known paclet site.
        ///https://reference.wolfram.com/language/ref/PacletSiteRegister.html
        ///</summary>
        public static Engine PacletSiteRegister(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletSiteRegister[" + arg0 + "]", name);
        }

        ///<summary>
        ///registers url as a known paclet site with name.
        ///https://reference.wolfram.com/language/ref/PacletSiteRegister.html
        ///</summary>
        public static Engine PacletSiteRegister(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PacletSiteRegister[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of all paclet sites known to your system.
        ///https://reference.wolfram.com/language/ref/PacletSites.html
        ///</summary>
        public static Engine PacletSites(this Engine en, string? name = null)
        {
            return en.Execute("PacletSites[]", name);
        }

        ///<summary>
        ///removes url from the list of registered paclet sites.
        ///https://reference.wolfram.com/language/ref/PacletSiteUnregister.html
        ///</summary>
        public static Engine PacletSiteUnregister(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletSiteUnregister[" + arg0 + "]", name);
        }

        ///<summary>
        ///acquires and caches current information about the available paclets on the given paclet site.
        ///https://reference.wolfram.com/language/ref/PacletSiteUpdate.html
        ///</summary>
        public static Engine PacletSiteUpdate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletSiteUpdate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the symbol named "sym" in the primary context of paclet.
        ///https://reference.wolfram.com/language/ref/PacletSymbol.html
        ///</summary>
        public static Engine PacletSymbol(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PacletSymbol[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///wraps the head h around the symbol before returning it.
        ///https://reference.wolfram.com/language/ref/PacletSymbol.html
        ///</summary>
        public static Engine PacletSymbol(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PacletSymbol[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uninstalls a paclet.
        ///https://reference.wolfram.com/language/ref/PacletUninstall.html
        ///</summary>
        public static Engine PacletUninstall(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PacletUninstall[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with all numbers in expr padded to leave room for a total of n digits.
        ///https://reference.wolfram.com/language/ref/PaddedForm.html
        ///</summary>
        public static Engine PaddedForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PaddedForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints with approximate real numbers having exactly f digits to the right of the decimal point.
        ///https://reference.wolfram.com/language/ref/PaddedForm.html
        ///</summary>
        public static Engine PaddedForm(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PaddedForm[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a net layer that pads an input array with mi elements at the beginning and ni elements at the end at level i of the array.
        ///https://reference.wolfram.com/language/ref/PaddingLayer.html
        ///</summary>
        public static Engine PaddingLayer(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PaddingLayer[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Padé approximant to expr about the point x=x0, with numerator order m and denominator order n.
        ///https://reference.wolfram.com/language/ref/PadeApproximant.html
        ///</summary>
        public static Engine PadeApproximant(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("PadeApproximant[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives the diagonal Padé approximant to expr about the point x=x0 of order n.
        ///https://reference.wolfram.com/language/ref/PadeApproximant.html
        ///</summary>
        public static Engine PadeApproximant(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PadeApproximant[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a list of length n by padding list with zeros on the left.
        ///https://reference.wolfram.com/language/ref/PadLeft.html
        ///</summary>
        public static Engine PadLeft(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PadLeft[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///pads by repeating the element x.
        ///https://reference.wolfram.com/language/ref/PadLeft.html
        ///</summary>
        public static Engine PadLeft(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PadLeft[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///pads by cyclically repeating the elements xi.
        ///https://reference.wolfram.com/language/ref/PadLeft.html
        ///</summary>
        public static Engine PadLeft(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("PadLeft[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///leaves a margin of m elements of padding on the right.
        ///https://reference.wolfram.com/language/ref/PadLeft.html
        ///</summary>
        public static Engine PadLeft(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PadLeft[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///makes a nested list with length ni at level i.
        ///https://reference.wolfram.com/language/ref/PadLeft.html
        ///</summary>
        public static Engine PadLeft(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PadLeft[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///pads a ragged array list with zeros to make it full.
        ///https://reference.wolfram.com/language/ref/PadLeft.html
        ///</summary>
        public static Engine PadLeft(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PadLeft[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a list of length n by padding list with zeros on the right.
        ///https://reference.wolfram.com/language/ref/PadRight.html
        ///</summary>
        public static Engine PadRight(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PadRight[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///pads by repeating the element x.
        ///https://reference.wolfram.com/language/ref/PadRight.html
        ///</summary>
        public static Engine PadRight(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PadRight[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///pads by cyclically repeating the elements xi.
        ///https://reference.wolfram.com/language/ref/PadRight.html
        ///</summary>
        public static Engine PadRight(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("PadRight[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///leaves a margin of m elements of padding on the left.
        ///https://reference.wolfram.com/language/ref/PadRight.html
        ///</summary>
        public static Engine PadRight(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PadRight[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///makes a nested list with length ni at level i.
        ///https://reference.wolfram.com/language/ref/PadRight.html
        ///</summary>
        public static Engine PadRight(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PadRight[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///pads a ragged array list with zeros to make it full.
        ///https://reference.wolfram.com/language/ref/PadRight.html
        ///</summary>
        public static Engine PadRight(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PadRight[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of page-rank centralities for the vertices in the graph g and weight α.
        ///https://reference.wolfram.com/language/ref/PageRankCentrality.html
        ///</summary>
        public static Engine PageRankCentrality(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PageRankCentrality[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of page-rank centralities, using weight α and initial centralities β.
        ///https://reference.wolfram.com/language/ref/PageRankCentrality.html
        ///</summary>
        public static Engine PageRankCentrality(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PageRankCentrality[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/PageRankCentrality.html
        ///</summary>
        public static Engine PageRankCentrality(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PageRankCentrality[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the pair correlation function  for point data pdata at radius r.
        ///https://reference.wolfram.com/language/ref/PairCorrelationG.html
        ///</summary>
        public static Engine PairCorrelationG(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PairCorrelationG[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates the function  that can be applied repeatedly to different radii r.
        ///https://reference.wolfram.com/language/ref/PairCorrelationG.html
        ///</summary>
        public static Engine PairCorrelationG(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PairCorrelationG[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a paired bar chart with bar lengths y1,  y2, … and z1, z2, …, respectively.
        ///https://reference.wolfram.com/language/ref/PairedBarChart.html
        ///</summary>
        public static Engine PairedBarChart(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PairedBarChart[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots a paired histogram of the values xi and yi.
        ///https://reference.wolfram.com/language/ref/PairedHistogram.html
        ///</summary>
        public static Engine PairedHistogram(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PairedHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots a paired histogram with bin width specification bspec.
        ///https://reference.wolfram.com/language/ref/PairedHistogram.html
        ///</summary>
        public static Engine PairedHistogram(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("PairedHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots a paired histogram with bin heights computed according to the specification hspec.
        ///https://reference.wolfram.com/language/ref/PairedHistogram.html
        ///</summary>
        public static Engine PairedHistogram(this Engine en, List<object> arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PairedHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///plots a paired smooth histogram of the values xi and yi.
        ///https://reference.wolfram.com/language/ref/PairedSmoothHistogram.html
        ///</summary>
        public static Engine PairedSmoothHistogram(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PairedSmoothHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots a paired smooth histogram with estimator specification espec.
        ///https://reference.wolfram.com/language/ref/PairedSmoothHistogram.html
        ///</summary>
        public static Engine PairedSmoothHistogram(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("PairedSmoothHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots a paired smooth histogram with distribution function dfun.
        ///https://reference.wolfram.com/language/ref/PairedSmoothHistogram.html
        ///</summary>
        public static Engine PairedSmoothHistogram(this Engine en, List<object> arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PairedSmoothHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///tests whether the mean of data is zero.
        ///https://reference.wolfram.com/language/ref/PairedTTest.html
        ///</summary>
        public static Engine PairedTTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PairedTTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the mean of data1– data2 is zero.
        ///https://reference.wolfram.com/language/ref/PairedTTest.html
        ///</summary>
        public static Engine PairedTTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PairedTTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///tests a location measure against μ0.
        ///https://reference.wolfram.com/language/ref/PairedTTest.html
        ///</summary>
        public static Engine PairedTTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PairedTTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/PairedTTest.html
        ///</summary>
        public static Engine PairedTTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PairedTTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the mean of the data is zero.
        ///https://reference.wolfram.com/language/ref/PairedZTest.html
        ///</summary>
        public static Engine PairedZTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PairedZTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the means of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/PairedZTest.html
        ///</summary>
        public static Engine PairedZTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PairedZTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///tests for zero or equal means assuming a population variance σ.
        ///https://reference.wolfram.com/language/ref/PairedZTest.html
        ///</summary>
        public static Engine PairedZTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PairedZTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests the mean against μ0.
        ///https://reference.wolfram.com/language/ref/PairedZTest.html
        ///</summary>
        public static Engine PairedZTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PairedZTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/PairedZTest.html
        ///</summary>
        public static Engine PairedZTest(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PairedZTest[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a palette notebook that can be manipulated by the Wolfram System front end.
        ///https://reference.wolfram.com/language/ref/PaletteNotebook.html
        ///</summary>
        public static Engine PaletteNotebook(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PaletteNotebook[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns True if the given list is identical to Reverse[list], and False otherwise.
        ///https://reference.wolfram.com/language/ref/PalindromeQ.html
        ///</summary>
        public static Engine PalindromeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PalindromeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as a pane containing expr.
        ///https://reference.wolfram.com/language/ref/Pane.html
        ///</summary>
        public static Engine Pane(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Pane[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes the pane be w printer's points wide, linewrapping the contents if necessary.
        ///https://reference.wolfram.com/language/ref/Pane.html
        ///</summary>
        public static Engine Pane(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Pane[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes the pane be w points wide and h points high, shrinking the contents if necessary.
        ///https://reference.wolfram.com/language/ref/Pane.html
        ///</summary>
        public static Engine Pane(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Pane[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///displays as a panel containing expr.
        ///https://reference.wolfram.com/language/ref/Panel.html
        ///</summary>
        public static Engine Panel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Panel[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the panel the specified title.
        ///https://reference.wolfram.com/language/ref/Panel.html
        ///</summary>
        public static Engine Panel(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Panel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///places title at a position specified by pos.
        ///https://reference.wolfram.com/language/ref/Panel.html
        ///</summary>
        public static Engine Panel(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Panel[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///places titlei at position posi.
        ///https://reference.wolfram.com/language/ref/Panel.html
        ///</summary>
        public static Engine Panel(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Panel[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///displays an empty panel.
        ///https://reference.wolfram.com/language/ref/Panel.html
        ///</summary>
        public static Engine Panel(this Engine en, string? name = null)
        {
            return en.Execute("Panel[]", name);
        }

        ///<summary>
        ///represents an object that displays as a pane containing the expri for which vali is equal to x.
        ///https://reference.wolfram.com/language/ref/PaneSelector.html
        ///</summary>
        public static Engine PaneSelector(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PaneSelector[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays default if x is none of the vali.
        ///https://reference.wolfram.com/language/ref/PaneSelector.html
        ///</summary>
        public static Engine PaneSelector(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PaneSelector[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the parabolic cylinder function .
        ///https://reference.wolfram.com/language/ref/ParabolicCylinderD.html
        ///</summary>
        public static Engine ParabolicCylinderD(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParabolicCylinderD[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates in parallel a list of length n, with elements f[i], evaluated.
        ///https://reference.wolfram.com/language/ref/ParallelArray.html
        ///</summary>
        public static Engine ParallelArray(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParallelArray[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates in parallel an  array of nested lists, with elements f[i1,i2,…].
        ///https://reference.wolfram.com/language/ref/ParallelArray.html
        ///</summary>
        public static Engine ParallelArray(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParallelArray[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates in parallel a list using the index origins ri (default 1).
        ///https://reference.wolfram.com/language/ref/ParallelArray.html
        ///</summary>
        public static Engine ParallelArray(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ParallelArray[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///uses head h, rather than List, for each level of the array.
        ///https://reference.wolfram.com/language/ref/ParallelArray.html
        ///</summary>
        public static Engine ParallelArray(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ParallelArray[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///generates a parallel axis plot for the points {yi1,…,yin} using equally spaced axes.
        ///https://reference.wolfram.com/language/ref/ParallelAxisPlot.html
        ///</summary>
        public static Engine ParallelAxisPlot(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ParallelAxisPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots several sets of points.
        ///https://reference.wolfram.com/language/ref/ParallelAxisPlot.html
        ///</summary>
        public static Engine ParallelAxisPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ParallelAxisPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates f[h[e1,e2,…]] in parallel by distributing parts of the computation to all parallel kernels and combining the partial results with comb.
        ///https://reference.wolfram.com/language/ref/ParallelCombine.html
        ///</summary>
        public static Engine ParallelCombine(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ParallelCombine[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is equivalent to ParallelCombine[f,h[e1,e2,…],h] if h has attribute Flat, and ParallelCombine[f,h[e1,e2,…],Join] otherwise.
        ///https://reference.wolfram.com/language/ref/ParallelCombine.html
        ///</summary>
        public static Engine ParallelCombine(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParallelCombine[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr in parallel imax times.
        ///https://reference.wolfram.com/language/ref/ParallelDo.html
        ///</summary>
        public static Engine ParallelDo(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParallelDo[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the successive values i1, i2, ….
        ///https://reference.wolfram.com/language/ref/ParallelDo.html
        ///</summary>
        public static Engine ParallelDo(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ParallelDo[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates expr looping in parallel over different values of j, etc. for each i.
        ///https://reference.wolfram.com/language/ref/ParallelDo.html
        ///</summary>
        public static Engine ParallelDo(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ParallelDo[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a parallelepiped with origin p and directions vi.
        ///https://reference.wolfram.com/language/ref/Parallelepiped.html
        ///</summary>
        public static Engine Parallelepiped(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Parallelepiped[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates the expression expr on all available parallel kernels and returns the list of results obtained.
        ///https://reference.wolfram.com/language/ref/ParallelEvaluate.html
        ///</summary>
        public static Engine ParallelEvaluate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParallelEvaluate[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr on the parallel kernel specified.
        ///https://reference.wolfram.com/language/ref/ParallelEvaluate.html
        ///</summary>
        public static Engine ParallelEvaluate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParallelEvaluate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr on the parallel kernels keri.
        ///https://reference.wolfram.com/language/ref/ParallelEvaluate.html
        ///</summary>
        public static Engine ParallelEvaluate(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParallelEvaluate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///wraps the head h around the results before returning them.
        ///https://reference.wolfram.com/language/ref/ParallelEvaluate.html
        ///</summary>
        public static Engine ParallelEvaluate(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ParallelEvaluate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///evaluates expr using automatic parallelization.
        ///https://reference.wolfram.com/language/ref/Parallelize.html
        ///</summary>
        public static Engine Parallelize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Parallelize[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies f in parallel to each element on the first level in expr.
        ///https://reference.wolfram.com/language/ref/ParallelMap.html
        ///</summary>
        public static Engine ParallelMap(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParallelMap[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f in parallel to parts of expr specified by levelspec.
        ///https://reference.wolfram.com/language/ref/ParallelMap.html
        ///</summary>
        public static Engine ParallelMap(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ParallelMap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///evaluates Needs["context`"] on all available parallel kernels.
        ///https://reference.wolfram.com/language/ref/ParallelNeeds.html
        ///</summary>
        public static Engine ParallelNeeds(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParallelNeeds[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a parallelogram with origin p and directions v1 and v2.
        ///https://reference.wolfram.com/language/ref/Parallelogram.html
        ///</summary>
        public static Engine Parallelogram(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Parallelogram[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates the product  in parallel.
        ///https://reference.wolfram.com/language/ref/ParallelProduct.html
        ///</summary>
        public static Engine ParallelProduct(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParallelProduct[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses successive values , , ….
        ///https://reference.wolfram.com/language/ref/ParallelProduct.html
        ///</summary>
        public static Engine ParallelProduct(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ParallelProduct[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates the multiple product  in parallel.
        ///https://reference.wolfram.com/language/ref/ParallelProduct.html
        ///</summary>
        public static Engine ParallelProduct(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ParallelProduct[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///submits expr for evaluation on the next available parallel kernel and returns an EvaluationObject expression representing the submitted evaluation.
        ///https://reference.wolfram.com/language/ref/ParallelSubmit.html
        ///</summary>
        public static Engine ParallelSubmit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParallelSubmit[" + arg0 + "]", name);
        }

        ///<summary>
        ///builds a closure for the variables given before submitting expr.
        ///https://reference.wolfram.com/language/ref/ParallelSubmit.html
        ///</summary>
        public static Engine ParallelSubmit(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ParallelSubmit[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates in parallel the sum .
        ///https://reference.wolfram.com/language/ref/ParallelSum.html
        ///</summary>
        public static Engine ParallelSum(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParallelSum[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses successive values , , ….
        ///https://reference.wolfram.com/language/ref/ParallelSum.html
        ///</summary>
        public static Engine ParallelSum(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ParallelSum[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates in parallel the multiple sum .
        ///https://reference.wolfram.com/language/ref/ParallelSum.html
        ///</summary>
        public static Engine ParallelSum(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ParallelSum[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///generates in parallel a list of imax copies of expr.
        ///https://reference.wolfram.com/language/ref/ParallelTable.html
        ///</summary>
        public static Engine ParallelTable(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParallelTable[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the successive values i1, i2, ….
        ///https://reference.wolfram.com/language/ref/ParallelTable.html
        ///</summary>
        public static Engine ParallelTable(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ParallelTable[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives a nested list. The list associated with i is outermost.
        ///https://reference.wolfram.com/language/ref/ParallelTable.html
        ///</summary>
        public static Engine ParallelTable(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ParallelTable[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///evaluates f[argi] in parallel, returning the first result received.
        ///https://reference.wolfram.com/language/ref/ParallelTry.html
        ///</summary>
        public static Engine ParallelTry(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParallelTry[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns a list of the first k results.
        ///https://reference.wolfram.com/language/ref/ParallelTry.html
        ///</summary>
        public static Engine ParallelTry(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ParallelTry[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a parameter mixture distribution where the parameter θ is distributed according to the weight distribution wdist.
        ///https://reference.wolfram.com/language/ref/ParameterMixtureDistribution.html
        ///</summary>
        public static Engine ParameterMixtureDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParameterMixtureDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a parameter mixture distribution where the parameter θ1 has weight distribution wdist1, θ2 has weight distribution wdist2, etc.
        ///https://reference.wolfram.com/language/ref/ParameterMixtureDistribution.html
        ///</summary>
        public static Engine ParameterMixtureDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParameterMixtureDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a ParametricFunction object that finds values of variables vars that minimize the convex objective function f subject to convex constraints cons with parameters pars.
        ///https://reference.wolfram.com/language/ref/ParametricConvexOptimization.html
        ///</summary>
        public static Engine ParametricConvexOptimization(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ParametricConvexOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///specifies what solution property "prop" should be returned by the ParametricFunction object.
        ///https://reference.wolfram.com/language/ref/ParametricConvexOptimization.html
        ///</summary>
        public static Engine ParametricConvexOptimization(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParametricConvexOptimization[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a function that computes a solution when evaluated with numerical values for the parameters pars.
        ///https://reference.wolfram.com/language/ref/ParametricFunction.html
        ///</summary>
        public static Engine ParametricFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParametricFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a numerical solution to the ordinary differential equations eqns for the function u with the independent variable x in the range xmin to xmax with parameters pars.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolve.html
        ///</summary>
        public static Engine ParametricNDSolve(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ParametricNDSolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///solves the partial differential equations eqns over a rectangular region.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolve.html
        ///</summary>
        public static Engine ParametricNDSolve(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, object arg4, string? name = null)
        {
            return en.Execute("ParametricNDSolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///solves the partial differential equations eqns over the region Ω.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolve.html
        ///</summary>
        public static Engine ParametricNDSolve(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ParametricNDSolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///solves the time-dependent partial differential equations eqns over the region Ω.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolve.html
        ///</summary>
        public static Engine ParametricNDSolve(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("ParametricNDSolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///solves for the functions ui.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolve.html
        ///</summary>
        public static Engine ParametricNDSolve(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ParametricNDSolve[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of expr with functions determined by a numerical solution to the ordinary differential equations eqns with the independent variable x in the range xmin to xmax with parameters pars.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolveValue.html
        ///</summary>
        public static Engine ParametricNDSolveValue(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ParametricNDSolveValue[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///solves the partial differential equations eqns over a rectangular region.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolveValue.html
        ///</summary>
        public static Engine ParametricNDSolveValue(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, object arg4, string? name = null)
        {
            return en.Execute("ParametricNDSolveValue[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///solves the partial differential equations eqns over the region Ω.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolveValue.html
        ///</summary>
        public static Engine ParametricNDSolveValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ParametricNDSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///solves the time-dependent partial differential equations eqns over the region Ω.
        ///https://reference.wolfram.com/language/ref/ParametricNDSolveValue.html
        ///</summary>
        public static Engine ParametricNDSolveValue(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("ParametricNDSolveValue[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///generates a parametric plot of a curve with x and y coordinates fx and fy as a function of u.
        ///https://reference.wolfram.com/language/ref/ParametricPlot.html
        ///</summary>
        public static Engine ParametricPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParametricPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots several parametric curves.
        ///https://reference.wolfram.com/language/ref/ParametricPlot.html
        ///</summary>
        public static Engine ParametricPlot(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ParametricPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots several parametric regions.
        ///https://reference.wolfram.com/language/ref/ParametricPlot.html
        ///</summary>
        public static Engine ParametricPlot(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("ParametricPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///plots the curve {fx,fy} with features defined by the symbolic wrapper w.
        ///https://reference.wolfram.com/language/ref/ParametricPlot.html
        ///</summary>
        public static Engine ParametricPlot(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ParametricPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///takes parameters {u,v} to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/ParametricPlot.html
        ///</summary>
        public static Engine ParametricPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParametricPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///produces a three-dimensional space curve parametrized by a variable u which runs from umin to umax.
        ///https://reference.wolfram.com/language/ref/ParametricPlot3D.html
        ///</summary>
        public static Engine ParametricPlot3D(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParametricPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///produces a three-dimensional surface parametrized by u and v.
        ///https://reference.wolfram.com/language/ref/ParametricPlot3D.html
        ///</summary>
        public static Engine ParametricPlot3D(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ParametricPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots several objects together.
        ///https://reference.wolfram.com/language/ref/ParametricPlot3D.html
        ///</summary>
        public static Engine ParametricPlot3D(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ParametricPlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///takes parameters {u,v} to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/ParametricPlot3D.html
        ///</summary>
        public static Engine ParametricPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParametricPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that computes a leaky ReLU activation with a slope that can be learned.
        ///https://reference.wolfram.com/language/ref/ParametricRampLayer.html
        ///</summary>
        public static Engine ParametricRampLayer(this Engine en, string? name = null)
        {
            return en.Execute("ParametricRampLayer[]", name);
        }

        ///<summary>
        ///specifies the levels on which each dimension has a specific slope.
        ///https://reference.wolfram.com/language/ref/ParametricRampLayer.html
        ///</summary>
        public static Engine ParametricRampLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParametricRampLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a region in  given by the points {f1,…,fn} for parameters ui∈.
        ///https://reference.wolfram.com/language/ref/ParametricRegion.html
        ///</summary>
        public static Engine ParametricRegion(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ParametricRegion[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constrains parameters to satisfy the condition cond.
        ///https://reference.wolfram.com/language/ref/ParametricRegion.html
        ///</summary>
        public static Engine ParametricRegion(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ParametricRegion[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the BoxObject that contains obj.
        ///https://reference.wolfram.com/language/ref/ParentBox.html
        ///</summary>
        public static Engine ParentBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParentBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the CellObject that contains obj.
        ///https://reference.wolfram.com/language/ref/ParentCell.html
        ///</summary>
        public static Engine ParentCell(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParentCell[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the parent of the current working directory.
        ///https://reference.wolfram.com/language/ref/ParentDirectory.html
        ///</summary>
        public static Engine ParentDirectory(this Engine en, string? name = null)
        {
            return en.Execute("ParentDirectory[]", name);
        }

        ///<summary>
        ///gives the parent of the directory dir.
        ///https://reference.wolfram.com/language/ref/ParentDirectory.html
        ///</summary>
        public static Engine ParentDirectory(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParentDirectory[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the directory n levels up from dir.
        ///https://reference.wolfram.com/language/ref/ParentDirectory.html
        ///</summary>
        public static Engine ParentDirectory(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParentDirectory[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the NotebookObject that contains obj.
        ///https://reference.wolfram.com/language/ref/ParentNotebook.html
        ///</summary>
        public static Engine ParentNotebook(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParentNotebook[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Pareto distribution with minimum value parameter k and shape parameter α.
        ///https://reference.wolfram.com/language/ref/ParetoDistribution.html
        ///</summary>
        public static Engine ParetoDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParetoDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Pareto type II distribution with location parameter μ.
        ///https://reference.wolfram.com/language/ref/ParetoDistribution.html
        ///</summary>
        public static Engine ParetoDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ParetoDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Pareto type IV distribution with shape parameter γ.
        ///https://reference.wolfram.com/language/ref/ParetoDistribution.html
        ///</summary>
        public static Engine ParetoDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ParetoDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a Pareto–Pickands distribution with location parameter μ, scale parameter σ and shape parameter ξ.
        ///https://reference.wolfram.com/language/ref/ParetoPickandsDistribution.html
        ///</summary>
        public static Engine ParetoPickandsDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ParetoPickandsDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the standard Pareto–Pickands distribution with zero location and unit scale parameters.
        ///https://reference.wolfram.com/language/ref/ParetoPickandsDistribution.html
        ///</summary>
        public static Engine ParetoPickandsDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParetoPickandsDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the park entity.
        ///https://reference.wolfram.com/language/ref/ParkData.html
        ///</summary>
        public static Engine ParkData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParkData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified park entities.
        ///https://reference.wolfram.com/language/ref/ParkData.html
        ///</summary>
        public static Engine ParkData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ParkData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/ParkData.html
        ///</summary>
        public static Engine ParkData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ParkData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the i part of expr.
        ///https://reference.wolfram.com/language/ref/Part.html
        ///</summary>
        public static Engine Part(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Part[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///counts from the end.
        ///https://reference.wolfram.com/language/ref/Part.html
        ///</summary>
        public static Engine Part(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Part[" + arg0 + "]", name);
        }

        ///<summary>
        ///is equivalent to expr[[i]][[j]]….
        ///https://reference.wolfram.com/language/ref/Part.html
        ///</summary>
        public static Engine Part(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Part[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///estimates the partial correlation function at lags hspec from data.
        ///https://reference.wolfram.com/language/ref/PartialCorrelationFunction.html
        ///</summary>
        public static Engine PartialCorrelationFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PartialCorrelationFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the particle accelerator entity.
        ///https://reference.wolfram.com/language/ref/ParticleAcceleratorData.html
        ///</summary>
        public static Engine ParticleAcceleratorData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParticleAcceleratorData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified particle accelerator entities.
        ///https://reference.wolfram.com/language/ref/ParticleAcceleratorData.html
        ///</summary>
        public static Engine ParticleAcceleratorData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ParticleAcceleratorData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/ParticleAcceleratorData.html
        ///</summary>
        public static Engine ParticleAcceleratorData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ParticleAcceleratorData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the specified property for a subatomic particle or family of particles with the specified name.
        ///https://reference.wolfram.com/language/ref/ParticleData.html
        ///</summary>
        public static Engine ParticleData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ParticleData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified property for a version of the particle with charge q.
        ///https://reference.wolfram.com/language/ref/ParticleData.html
        ///</summary>
        public static Engine ParticleData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ParticleData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///partitions list into nonoverlapping sublists of length n.
        ///https://reference.wolfram.com/language/ref/Partition.html
        ///</summary>
        public static Engine Partition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Partition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates sublists with offset d.
        ///https://reference.wolfram.com/language/ref/Partition.html
        ///</summary>
        public static Engine Partition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Partition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///partitions a nested list into blocks of size ××….
        ///https://reference.wolfram.com/language/ref/Partition.html
        ///</summary>
        public static Engine Partition(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Partition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses offset di at level i in list.
        ///https://reference.wolfram.com/language/ref/Partition.html
        ///</summary>
        public static Engine Partition(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Partition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///specifies that the first element of list should appear at position kL in the first sublist, and the last element of list should appear at or after position kR in the last sublist. If additional elements are needed, Partition fills them in by treating list as cyclic.
        ///https://reference.wolfram.com/language/ref/Partition.html
        ///</summary>
        public static Engine Partition(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("Partition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///pads if necessary by repeating the element x.
        ///https://reference.wolfram.com/language/ref/Partition.html
        ///</summary>
        public static Engine Partition(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, object arg4, string? name = null)
        {
            return en.Execute("Partition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///pads if necessary by cyclically repeating the elements xi.
        ///https://reference.wolfram.com/language/ref/Partition.html
        ///</summary>
        public static Engine Partition(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, List<object> arg4, string? name = null)
        {
            return en.Execute("Partition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
        }

        ///<summary>
        ///gives the number p(n) of unrestricted partitions of the integer n.
        ///https://reference.wolfram.com/language/ref/PartitionsP.html
        ///</summary>
        public static Engine PartitionsP(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PartitionsP[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number q(n) of partitions of the integer n into distinct parts.
        ///https://reference.wolfram.com/language/ref/PartitionsQ.html
        ///</summary>
        public static Engine PartitionsQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PartitionsQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that gives the i part of the input.
        ///https://reference.wolfram.com/language/ref/PartLayer.html
        ///</summary>
        public static Engine PartLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PartLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///takes part speci at level i in the input.
        ///https://reference.wolfram.com/language/ref/PartLayer.html
        ///</summary>
        public static Engine PartLayer(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PartLayer[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the possible parts of speech for the specified word.
        ///https://reference.wolfram.com/language/ref/PartOfSpeech.html
        ///</summary>
        public static Engine PartOfSpeech(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PartOfSpeech[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Parzen window function of x.
        ///https://reference.wolfram.com/language/ref/ParzenWindow.html
        ///</summary>
        public static Engine ParzenWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ParzenWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Pascal distribution with parameters n and p.
        ///https://reference.wolfram.com/language/ref/PascalDistribution.html
        ///</summary>
        public static Engine PascalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PascalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///pastes expr at the current insertion point in the input notebook.
        ///https://reference.wolfram.com/language/ref/Paste.html
        ///</summary>
        public static Engine Paste(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Paste[" + arg0 + "]", name);
        }

        ///<summary>
        ///pastes expr to the specified notebook.
        ///https://reference.wolfram.com/language/ref/Paste.html
        ///</summary>
        public static Engine Paste(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Paste[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///pastes the contents of the system clipboard in the input notebook.
        ///https://reference.wolfram.com/language/ref/Paste.html
        ///</summary>
        public static Engine Paste(this Engine en, string? name = null)
        {
            return en.Execute("Paste[]", name);
        }

        ///<summary>
        ///represents a button that pastes expr whenever it is pressed.
        ///https://reference.wolfram.com/language/ref/PasteButton.html
        ///</summary>
        public static Engine PasteButton(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PasteButton[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays with label on the button.
        ///https://reference.wolfram.com/language/ref/PasteButton.html
        ///</summary>
        public static Engine PasteButton(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PasteButton[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a path with vertices vi and edges between vi and vi+1 .
        ///https://reference.wolfram.com/language/ref/PathGraph.html
        ///</summary>
        public static Engine PathGraph(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PathGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields a path with vertices vi and edges ej.
        ///https://reference.wolfram.com/language/ref/PathGraph.html
        ///</summary>
        public static Engine PathGraph(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PathGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a path and False otherwise.
        ///https://reference.wolfram.com/language/ref/PathGraphQ.html
        ///</summary>
        public static Engine PathGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PathGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the pattern object obj, assigned the name sym.
        ///https://reference.wolfram.com/language/ref/Pattern.html
        ///</summary>
        public static Engine Pattern(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Pattern[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics directive specifying that obj should be used to fill faces of polygons and other filled graphics objects.
        ///https://reference.wolfram.com/language/ref/PatternFilling.html
        ///</summary>
        public static Engine PatternFilling(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PatternFilling[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies the size of the object obj.
        ///https://reference.wolfram.com/language/ref/PatternFilling.html
        ///</summary>
        public static Engine PatternFilling(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PatternFilling[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///moves the object obj by the offset {dx,dy}.
        ///https://reference.wolfram.com/language/ref/PatternFilling.html
        ///</summary>
        public static Engine PatternFilling(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("PatternFilling[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents a templated reaction between molecule patterns in reactants and products.
        ///https://reference.wolfram.com/language/ref/PatternReaction.html
        ///</summary>
        public static Engine PatternReaction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PatternReaction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a reaction with a specified mapping between atoms in reactants and products.
        ///https://reference.wolfram.com/language/ref/PatternReaction.html
        ///</summary>
        public static Engine PatternReaction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PatternReaction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a pattern object that represents a sequence of arguments matching p1, p2, ….
        ///https://reference.wolfram.com/language/ref/PatternSequence.html
        ///</summary>
        public static Engine PatternSequence(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PatternSequence[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the k Pauli spin matrix .
        ///https://reference.wolfram.com/language/ref/PauliMatrix.html
        ///</summary>
        public static Engine PauliMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PauliMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Paul wavelet of order 4.
        ///https://reference.wolfram.com/language/ref/PaulWavelet.html
        ///</summary>
        public static Engine PaulWavelet(this Engine en, string? name = null)
        {
            return en.Execute("PaulWavelet[]", name);
        }

        ///<summary>
        ///represents a Paul wavelet of order n.
        ///https://reference.wolfram.com/language/ref/PaulWavelet.html
        ///</summary>
        public static Engine PaulWavelet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PaulWavelet[" + arg0 + "]", name);
        }

        ///<summary>
        ///pauses for at least n seconds.
        ///https://reference.wolfram.com/language/ref/Pause.html
        ///</summary>
        public static Engine Pause(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Pause[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the probability density function for the distribution dist evaluated at x.
        ///https://reference.wolfram.com/language/ref/PDF.html
        ///</summary>
        public static Engine PDF(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PDF[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multivariate probability density function for a distribution dist evaluated at {x1,x2,…}.
        ///https://reference.wolfram.com/language/ref/PDF.html
        ///</summary>
        public static Engine PDF(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PDF[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the PDF as a pure function.
        ///https://reference.wolfram.com/language/ref/PDF.html
        ///</summary>
        public static Engine PDF(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PDF[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a binary list in which 1s correspond to peak positions in list.
        ///https://reference.wolfram.com/language/ref/PeakDetect.html
        ///</summary>
        public static Engine PeakDetect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PeakDetect[" + arg0 + "]", name);
        }

        ///<summary>
        ///detects peaks that survive Gaussian blurring up to scale σ.
        ///https://reference.wolfram.com/language/ref/PeakDetect.html
        ///</summary>
        public static Engine PeakDetect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PeakDetect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///detects peaks with minimum sharpness s.
        ///https://reference.wolfram.com/language/ref/PeakDetect.html
        ///</summary>
        public static Engine PeakDetect(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PeakDetect[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///detects only peaks with values greater than t.
        ///https://reference.wolfram.com/language/ref/PeakDetect.html
        ///</summary>
        public static Engine PeakDetect(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PeakDetect[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///uses different scales for thresholding sharpness and value.
        ///https://reference.wolfram.com/language/ref/PeakDetect.html
        ///</summary>
        public static Engine PeakDetect(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("PeakDetect[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives the line segments representing the n-step Peano curve.
        ///https://reference.wolfram.com/language/ref/PeanoCurve.html
        ///</summary>
        public static Engine PeanoCurve(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PeanoCurve[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Pearson  test.
        ///https://reference.wolfram.com/language/ref/PearsonChiSquareTest.html
        ///</summary>
        public static Engine PearsonChiSquareTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PearsonChiSquareTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is distributed according to dist using the Pearson  test.
        ///https://reference.wolfram.com/language/ref/PearsonChiSquareTest.html
        ///</summary>
        public static Engine PearsonChiSquareTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PearsonChiSquareTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/PearsonChiSquareTest.html
        ///</summary>
        public static Engine PearsonChiSquareTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PearsonChiSquareTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the vectors v1 and v2 are linearly independent.
        ///https://reference.wolfram.com/language/ref/PearsonCorrelationTest.html
        ///</summary>
        public static Engine PearsonCorrelationTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PearsonCorrelationTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a distribution of the Pearson family with parameters a1, a0, b2, b1, and b0.
        ///https://reference.wolfram.com/language/ref/PearsonDistribution.html
        ///</summary>
        public static Engine PearsonDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("PearsonDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents a Pearson distribution of given type.
        ///https://reference.wolfram.com/language/ref/PearsonDistribution.html
        ///</summary>
        public static Engine PearsonDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("PearsonDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///represents a Penttinen point process with constant intensity μ, interaction parameter γ and interaction radius rp in .
        ///https://reference.wolfram.com/language/ref/PenttinenPointProcess.html
        ///</summary>
        public static Engine PenttinenPointProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PenttinenPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///prints with numbers in expr given as percentages.
        ///https://reference.wolfram.com/language/ref/PercentForm.html
        ///</summary>
        public static Engine PercentForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PercentForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with approximate real numbers in expr given as percentages to n-digit precision.
        ///https://reference.wolfram.com/language/ref/PercentForm.html
        ///</summary>
        public static Engine PercentForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PercentForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the n perfect number.
        ///https://reference.wolfram.com/language/ref/PerfectNumber.html
        ///</summary>
        public static Engine PerfectNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PerfectNumber[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if n is a perfect number, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PerfectNumberQ.html
        ///</summary>
        public static Engine PerfectNumberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PerfectNumberQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the perimeter of the two-dimensional region reg.
        ///https://reference.wolfram.com/language/ref/Perimeter.html
        ///</summary>
        public static Engine Perimeter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Perimeter[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the perimeter of the parametrized region whose Cartesian coordinates xi are functions of s and t.
        ///https://reference.wolfram.com/language/ref/Perimeter.html
        ///</summary>
        public static Engine Perimeter(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Perimeter[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///interprets the xi as coordinates in the specified coordinate chart.
        ///https://reference.wolfram.com/language/ref/Perimeter.html
        ///</summary>
        public static Engine Perimeter(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("Perimeter[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a periodic boundary condition  for all xtarget on the boundary of the region given to NDSolve where pred is True.
        ///https://reference.wolfram.com/language/ref/PeriodicBoundaryCondition.html
        ///</summary>
        public static Engine PeriodicBoundaryCondition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PeriodicBoundaryCondition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots the squared magnitude of the discrete Fourier transform (power spectrum) of list.
        ///https://reference.wolfram.com/language/ref/Periodogram.html
        ///</summary>
        public static Engine Periodogram(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Periodogram[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the mean of power spectra of non-overlapping partitions of length n.
        ///https://reference.wolfram.com/language/ref/Periodogram.html
        ///</summary>
        public static Engine Periodogram(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Periodogram[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses partitions with offset d.
        ///https://reference.wolfram.com/language/ref/Periodogram.html
        ///</summary>
        public static Engine Periodogram(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Periodogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies a smoothing window wfun to each partition.
        ///https://reference.wolfram.com/language/ref/Periodogram.html
        ///</summary>
        public static Engine Periodogram(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Periodogram[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///pads partitions with zeros to length m prior to the computation of the transform.
        ///https://reference.wolfram.com/language/ref/Periodogram.html
        ///</summary>
        public static Engine Periodogram(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("Periodogram[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///plots power spectra of several lists.
        ///https://reference.wolfram.com/language/ref/Periodogram.html
        ///</summary>
        public static Engine Periodogram(this Engine en, List<object> arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("Periodogram[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///plots the power spectra of all audioi.
        ///https://reference.wolfram.com/language/ref/Periodogram.html
        ///</summary>
        public static Engine Periodogram(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Periodogram[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the squared magnitude of the discrete Fourier transform (power spectrum) of list.
        ///https://reference.wolfram.com/language/ref/PeriodogramArray.html
        ///</summary>
        public static Engine PeriodogramArray(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PeriodogramArray[" + arg0 + "]", name);
        }

        ///<summary>
        ///averages the power spectra of non-overlapping partitions of length n.
        ///https://reference.wolfram.com/language/ref/PeriodogramArray.html
        ///</summary>
        public static Engine PeriodogramArray(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PeriodogramArray[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses partitions with offset d.
        ///https://reference.wolfram.com/language/ref/PeriodogramArray.html
        ///</summary>
        public static Engine PeriodogramArray(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PeriodogramArray[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies a smoothing window wfun to each partition.
        ///https://reference.wolfram.com/language/ref/PeriodogramArray.html
        ///</summary>
        public static Engine PeriodogramArray(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PeriodogramArray[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///pads partitions with zeros to length m prior to the computation of the transform.
        ///https://reference.wolfram.com/language/ref/PeriodogramArray.html
        ///</summary>
        public static Engine PeriodogramArray(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("PeriodogramArray[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents a permissions group with the specified name, owned by the current user.
        ///https://reference.wolfram.com/language/ref/PermissionsGroup.html
        ///</summary>
        public static Engine PermissionsGroup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermissionsGroup[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a permissions group owned by the specified user.
        ///https://reference.wolfram.com/language/ref/PermissionsGroup.html
        ///</summary>
        public static Engine PermissionsGroup(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PermissionsGroup[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns True if user is a member of the permissions group group, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PermissionsGroupMemberQ.html
        ///</summary>
        public static Engine PermissionsGroupMemberQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PermissionsGroupMemberQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of permissions groups belonging to the current user.
        ///https://reference.wolfram.com/language/ref/PermissionsGroups.html
        ///</summary>
        public static Engine PermissionsGroups(this Engine en, string? name = null)
        {
            return en.Execute("PermissionsGroups[]", name);
        }

        ///<summary>
        ///represents a permissions key that can be used to authorize access to cloud resources.
        ///https://reference.wolfram.com/language/ref/PermissionsKey.html
        ///</summary>
        public static Engine PermissionsKey(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermissionsKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of all valid permissions keys created by the currently authenticated user.
        ///https://reference.wolfram.com/language/ref/PermissionsKeys.html
        ///</summary>
        public static Engine PermissionsKeys(this Engine en, string? name = null)
        {
            return en.Execute("PermissionsKeys[]", name);
        }

        ///<summary>
        ///gives a disjoint cycle representation of permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationCycles.html
        ///</summary>
        public static Engine PermutationCycles(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationCycles[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if expr is a permutation in disjoint cyclic form, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PermutationCyclesQ.html
        ///</summary>
        public static Engine PermutationCyclesQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationCyclesQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the group generated by multiplication of the permutations perm1,…,permn.
        ///https://reference.wolfram.com/language/ref/PermutationGroup.html
        ///</summary>
        public static Engine PermutationGroup(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PermutationGroup[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the number of integers moved by the permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationLength.html
        ///</summary>
        public static Engine PermutationLength(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationLength[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a permutation list representation of permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationList.html
        ///</summary>
        public static Engine PermutationList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationList[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a permutation list of length len.
        ///https://reference.wolfram.com/language/ref/PermutationList.html
        ///</summary>
        public static Engine PermutationList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PermutationList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns True if expr is a valid permutation list and False otherwise.
        ///https://reference.wolfram.com/language/ref/PermutationListQ.html
        ///</summary>
        public static Engine PermutationListQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationListQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the permutation matrix given by permutation vector permv as a structured array.
        ///https://reference.wolfram.com/language/ref/PermutationMatrix.html
        ///</summary>
        public static Engine PermutationMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the largest integer moved by the permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationMax.html
        ///</summary>
        public static Engine PermutationMax(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationMax[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the smallest integer moved by the permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationMin.html
        ///</summary>
        public static Engine PermutationMin(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationMin[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the order of permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationOrder.html
        ///</summary>
        public static Engine PermutationOrder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationOrder[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n permutation power of the permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationPower.html
        ///</summary>
        public static Engine PermutationPower(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PermutationPower[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the product of permutations a, b, c.
        ///https://reference.wolfram.com/language/ref/PermutationProduct.html
        ///</summary>
        public static Engine PermutationProduct(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PermutationProduct[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///replaces each part in expr by its image under the permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationReplace.html
        ///</summary>
        public static Engine PermutationReplace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PermutationReplace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list of all possible permutations of the elements in list.
        ///https://reference.wolfram.com/language/ref/Permutations.html
        ///</summary>
        public static Engine Permutations(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Permutations[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives all permutations containing at most n elements.
        ///https://reference.wolfram.com/language/ref/Permutations.html
        ///</summary>
        public static Engine Permutations(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Permutations[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives all permutations containing exactly n elements.
        ///https://reference.wolfram.com/language/ref/Permutations.html
        ///</summary>
        public static Engine Permutations(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Permutations[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the support of the permutation perm.
        ///https://reference.wolfram.com/language/ref/PermutationSupport.html
        ///</summary>
        public static Engine PermutationSupport(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PermutationSupport[" + arg0 + "]", name);
        }

        ///<summary>
        ///permutes the positions of the elements of expr according to the permutation perm.
        ///https://reference.wolfram.com/language/ref/Permute.html
        ///</summary>
        public static Engine Permute(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Permute[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies a Perona–Malik diffusion filter to image.
        ///https://reference.wolfram.com/language/ref/PeronaMalikFilter.html
        ///</summary>
        public static Engine PeronaMalikFilter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PeronaMalikFilter[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies the amount of diffusion time t to be applied.
        ///https://reference.wolfram.com/language/ref/PeronaMalikFilter.html
        ///</summary>
        public static Engine PeronaMalikFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PeronaMalikFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a conductance parameter k.
        ///https://reference.wolfram.com/language/ref/PeronaMalikFilter.html
        ///</summary>
        public static Engine PeronaMalikFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PeronaMalikFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies a Gaussian regularization of width σ to the image gradient in the conductance function.
        ///https://reference.wolfram.com/language/ref/PeronaMalikFilter.html
        ///</summary>
        public static Engine PeronaMalikFilter(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PeronaMalikFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the perpendicular bisector of the line segment connecting p1 and p2.
        ///https://reference.wolfram.com/language/ref/PerpendicularBisector.html
        ///</summary>
        public static Engine PerpendicularBisector(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PerpendicularBisector[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the perpendicular bisector of a line segment.
        ///https://reference.wolfram.com/language/ref/PerpendicularBisector.html
        ///</summary>
        public static Engine PerpendicularBisector(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PerpendicularBisector[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a persistence location of the given type.
        ///https://reference.wolfram.com/language/ref/PersistenceLocation.html
        ///</summary>
        public static Engine PersistenceLocation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PersistenceLocation[" + arg0 + "]", name);
        }

        ///<summary>
        ///includes the base address for a location type that allows multiple locations.
        ///https://reference.wolfram.com/language/ref/PersistenceLocation.html
        ///</summary>
        public static Engine PersistenceLocation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PersistenceLocation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a persistent object stored at persistence location loc.
        ///https://reference.wolfram.com/language/ref/PersistentObject.html
        ///</summary>
        public static Engine PersistentObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PersistentObject[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives all persistent objects in all locations in $PersistencePath.
        ///https://reference.wolfram.com/language/ref/PersistentObjects.html
        ///</summary>
        public static Engine PersistentObjects(this Engine en, string? name = null)
        {
            return en.Execute("PersistentObjects[]", name);
        }

        ///<summary>
        ///gives all persistent objects whose names match the string pattern patt.
        ///https://reference.wolfram.com/language/ref/PersistentObjects.html
        ///</summary>
        public static Engine PersistentObjects(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PersistentObjects[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives all matching persistent objects in persistence location loc.
        ///https://reference.wolfram.com/language/ref/PersistentObjects.html
        ///</summary>
        public static Engine PersistentObjects(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PersistentObjects[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives all matching persistent objects in all the loci.
        ///https://reference.wolfram.com/language/ref/PersistentObjects.html
        ///</summary>
        public static Engine PersistentObjects(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PersistentObjects[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents the persistent symbol associated with the key "name".
        ///https://reference.wolfram.com/language/ref/PersistentSymbol.html
        ///</summary>
        public static Engine PersistentSymbol(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PersistentSymbol[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the persistent symbol associated with name stored in persistence location loc.
        ///https://reference.wolfram.com/language/ref/PersistentSymbol.html
        ///</summary>
        public static Engine PersistentSymbol(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PersistentSymbol[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the persistent symbol associated with name at the first of the locations loci at which it occurs.
        ///https://reference.wolfram.com/language/ref/PersistentSymbol.html
        ///</summary>
        public static Engine PersistentSymbol(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PersistentSymbol[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the person entity.
        ///https://reference.wolfram.com/language/ref/PersonData.html
        ///</summary>
        public static Engine PersonData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PersonData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified person entities.
        ///https://reference.wolfram.com/language/ref/PersonData.html
        ///</summary>
        public static Engine PersonData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PersonData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/PersonData.html
        ///</summary>
        public static Engine PersonData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PersonData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a PERT distribution with range min to max and mode at c.
        ///https://reference.wolfram.com/language/ref/PERTDistribution.html
        ///</summary>
        public static Engine PERTDistribution(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PERTDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a modified PERT distribution with shape parameter λ.
        ///https://reference.wolfram.com/language/ref/PERTDistribution.html
        ///</summary>
        public static Engine PERTDistribution(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PERTDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the generalized Petersen graph .
        ///https://reference.wolfram.com/language/ref/PetersenGraph.html
        ///</summary>
        public static Engine PetersenGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PetersenGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the phase margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/PhaseMargins.html
        ///</summary>
        public static Engine PhaseMargins(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PhaseMargins[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a three‐dimensional graphics directive that specifies that faces of polygons and other filled graphics objects are to be drawn to reflect as a smooth surface using a normal‐vector interpolation shading.
        ///https://reference.wolfram.com/language/ref/PhongShading.html
        ///</summary>
        public static Engine PhongShading(this Engine en, string? name = null)
        {
            return en.Execute("PhongShading[]", name);
        }

        ///<summary>
        ///uses the attenuation factor d for the diffuse light.
        ///https://reference.wolfram.com/language/ref/PhongShading.html
        ///</summary>
        public static Engine PhongShading(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PhongShading[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the attenuation factor s for the specular light.
        ///https://reference.wolfram.com/language/ref/PhongShading.html
        ///</summary>
        public static Engine PhongShading(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PhongShading[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the attenuation factor a for the ambient light.
        ///https://reference.wolfram.com/language/ref/PhongShading.html
        ///</summary>
        public static Engine PhongShading(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PhongShading[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the physical system entity.
        ///https://reference.wolfram.com/language/ref/PhysicalSystemData.html
        ///</summary>
        public static Engine PhysicalSystemData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PhysicalSystemData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified physical system entities.
        ///https://reference.wolfram.com/language/ref/PhysicalSystemData.html
        ///</summary>
        public static Engine PhysicalSystemData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PhysicalSystemData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/PhysicalSystemData.html
        ///</summary>
        public static Engine PhysicalSystemData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PhysicalSystemData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///picks out those elements of list for which the corresponding element of sel is True.
        ///https://reference.wolfram.com/language/ref/Pick.html
        ///</summary>
        public static Engine Pick(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Pick[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///picks out those elements of list for which the corresponding element of sel matches patt.
        ///https://reference.wolfram.com/language/ref/Pick.html
        ///</summary>
        public static Engine Pick(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Pick[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a feedback PID controller for the system sys.
        ///https://reference.wolfram.com/language/ref/PIDTune.html
        ///</summary>
        public static Engine PIDTune(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PIDTune[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a controller of architecture "carch" ("P", "PI", "PID", etc).
        ///https://reference.wolfram.com/language/ref/PIDTune.html
        ///</summary>
        public static Engine PIDTune(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PIDTune[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a controller using the tuning rule "trule".
        ///https://reference.wolfram.com/language/ref/PIDTune.html
        ///</summary>
        public static Engine PIDTune(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PIDTune[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the value for the property "prop".
        ///https://reference.wolfram.com/language/ref/PIDTune.html
        ///</summary>
        public static Engine PIDTune(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PIDTune[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a piecewise function with values vali in the regions defined by the conditions condi.
        ///https://reference.wolfram.com/language/ref/Piecewise.html
        ///</summary>
        public static Engine Piecewise(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Piecewise[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses default value val if none of the condi apply. The default for val is 0.
        ///https://reference.wolfram.com/language/ref/Piecewise.html
        ///</summary>
        public static Engine Piecewise(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Piecewise[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///expands nested piecewise functions in expr to give a single piecewise function.
        ///https://reference.wolfram.com/language/ref/PiecewiseExpand.html
        ///</summary>
        public static Engine PiecewiseExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PiecewiseExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands piecewise functions using assumptions.
        ///https://reference.wolfram.com/language/ref/PiecewiseExpand.html
        ///</summary>
        public static Engine PiecewiseExpand(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PiecewiseExpand[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///does the expansion over the domain dom.
        ///https://reference.wolfram.com/language/ref/PiecewiseExpand.html
        ///</summary>
        public static Engine PiecewiseExpand(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PiecewiseExpand[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///makes a pie chart with sector angle proportional to y1, y2, ….
        ///https://reference.wolfram.com/language/ref/PieChart.html
        ///</summary>
        public static Engine PieChart(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PieChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a 3D pie chart with sector angle proportional to y1, y2, … .
        ///https://reference.wolfram.com/language/ref/PieChart3D.html
        ///</summary>
        public static Engine PieChart3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PieChart3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives Pillai's trace for the matrices m1 and m2.
        ///https://reference.wolfram.com/language/ref/PillaiTrace.html
        ///</summary>
        public static Engine PillaiTrace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PillaiTrace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the matrices m1 and m2 are independent.
        ///https://reference.wolfram.com/language/ref/PillaiTraceTest.html
        ///</summary>
        public static Engine PillaiTraceTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PillaiTraceTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the round-trip ping time for the specified network host.
        ///https://reference.wolfram.com/language/ref/PingTime.html
        ///</summary>
        public static Engine PingTime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PingTime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of times for n successive pings.
        ///https://reference.wolfram.com/language/ref/PingTime.html
        ///</summary>
        public static Engine PingTime(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PingTime[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///recognizes the main pitch in audio, returning it as a TimeSeries object.
        ///https://reference.wolfram.com/language/ref/PitchRecognize.html
        ///</summary>
        public static Engine PitchRecognize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PitchRecognize[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the main pitch processed according to the specified spec.
        ///https://reference.wolfram.com/language/ref/PitchRecognize.html
        ///</summary>
        public static Engine PitchRecognize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PitchRecognize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the pixel value of image at position pos.
        ///https://reference.wolfram.com/language/ref/PixelValue.html
        ///</summary>
        public static Engine PixelValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PixelValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the pixel value converted to the specified type.
        ///https://reference.wolfram.com/language/ref/PixelValue.html
        ///</summary>
        public static Engine PixelValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PixelValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a list of pixel positions in image that exactly match the value val.
        ///https://reference.wolfram.com/language/ref/PixelValuePositions.html
        ///</summary>
        public static Engine PixelValuePositions(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PixelValuePositions[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns all pixel positions that have values within a distance d from val.
        ///https://reference.wolfram.com/language/ref/PixelValuePositions.html
        ///</summary>
        public static Engine PixelValuePositions(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PixelValuePositions[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an expression expr placed at relative position pos in a chart or other display.
        ///https://reference.wolfram.com/language/ref/Placed.html
        ///</summary>
        public static Engine Placed(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Placed[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///places each of the ei at a relative position specified by pos.
        ///https://reference.wolfram.com/language/ref/Placed.html
        ///</summary>
        public static Engine Placed(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Placed[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies the function f to each of the ei before displaying it.
        ///https://reference.wolfram.com/language/ref/Placed.html
        ///</summary>
        public static Engine Placed(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Placed[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a placeholder labeled with name that indicates a place to type.
        ///https://reference.wolfram.com/language/ref/Placeholder.html
        ///</summary>
        public static Engine Placeholder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Placeholder[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the empty placeholder .
        ///https://reference.wolfram.com/language/ref/Placeholder.html
        ///</summary>
        public static Engine Placeholder(this Engine en, string? name = null)
        {
            return en.Execute("Placeholder[]", name);
        }

        ///<summary>
        ///represents a net layer whose operation is undefined.
        ///https://reference.wolfram.com/language/ref/PlaceholderLayer.html
        ///</summary>
        public static Engine PlaceholderLayer(this Engine en, string? name = null)
        {
            return en.Execute("PlaceholderLayer[]", name);
        }

        ///<summary>
        ///indicates a tag and information given by the association assoc.
        ///https://reference.wolfram.com/language/ref/PlaceholderLayer.html
        ///</summary>
        public static Engine PlaceholderLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PlaceholderLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the angle between the half‐lines from p through q1 and q2.
        ///https://reference.wolfram.com/language/ref/PlanarAngle.html
        ///</summary>
        public static Engine PlanarAngle(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PlanarAngle[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the angle at p formed by the triangle with vertex points p, q1 and q2.
        ///https://reference.wolfram.com/language/ref/PlanarAngle.html
        ///</summary>
        public static Engine PlanarAngle(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PlanarAngle[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the angle specified by "spec".
        ///https://reference.wolfram.com/language/ref/PlanarAngle.html
        ///</summary>
        public static Engine PlanarAngle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PlanarAngle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of faces of the planar graph g.
        ///https://reference.wolfram.com/language/ref/PlanarFaceList.html
        ///</summary>
        public static Engine PlanarFaceList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PlanarFaceList[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a planar graph with edges ej.
        ///https://reference.wolfram.com/language/ref/PlanarGraph.html
        ///</summary>
        public static Engine PlanarGraph(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PlanarGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields a planar graph with vertices vi and edges ej.
        ///https://reference.wolfram.com/language/ref/PlanarGraph.html
        ///</summary>
        public static Engine PlanarGraph(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PlanarGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if g is a planar graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/PlanarGraphQ.html
        ///</summary>
        public static Engine PlanarGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PlanarGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the spectral radiance for the specified temperature and wavelength λ.
        ///https://reference.wolfram.com/language/ref/PlanckRadiationLaw.html
        ///</summary>
        public static Engine PlanckRadiationLaw(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PlanckRadiationLaw[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the integrated result of the spectral radiance over the wavelength range λ1 to λ2.
        ///https://reference.wolfram.com/language/ref/PlanckRadiationLaw.html
        ///</summary>
        public static Engine PlanckRadiationLaw(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PlanckRadiationLaw[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the plane curve entity.
        ///https://reference.wolfram.com/language/ref/PlaneCurveData.html
        ///</summary>
        public static Engine PlaneCurveData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PlaneCurveData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified plane curve entities.
        ///https://reference.wolfram.com/language/ref/PlaneCurveData.html
        ///</summary>
        public static Engine PlaneCurveData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PlaneCurveData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/PlaneCurveData.html
        ///</summary>
        public static Engine PlaneCurveData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PlaneCurveData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the moon entity of a planet or minor planet.
        ///https://reference.wolfram.com/language/ref/PlanetaryMoonData.html
        ///</summary>
        public static Engine PlanetaryMoonData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PlanetaryMoonData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified moon entities.
        ///https://reference.wolfram.com/language/ref/PlanetaryMoonData.html
        ///</summary>
        public static Engine PlanetaryMoonData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PlanetaryMoonData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the property.
        ///https://reference.wolfram.com/language/ref/PlanetaryMoonData.html
        ///</summary>
        public static Engine PlanetaryMoonData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PlanetaryMoonData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the planet entity.
        ///https://reference.wolfram.com/language/ref/PlanetData.html
        ///</summary>
        public static Engine PlanetData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PlanetData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified planet entities.
        ///https://reference.wolfram.com/language/ref/PlanetData.html
        ///</summary>
        public static Engine PlanetData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PlanetData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the property.
        ///https://reference.wolfram.com/language/ref/PlanetData.html
        ///</summary>
        public static Engine PlanetData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PlanetData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the plant entity.
        ///https://reference.wolfram.com/language/ref/PlantData.html
        ///</summary>
        public static Engine PlantData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PlantData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified plant entities.
        ///https://reference.wolfram.com/language/ref/PlantData.html
        ///</summary>
        public static Engine PlantData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PlantData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the property.
        ///https://reference.wolfram.com/language/ref/PlantData.html
        ///</summary>
        public static Engine PlantData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PlantData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///creates an object that plays as a sound whose amplitude is given by f as a function of time t in seconds between tmin and tmax.
        ///https://reference.wolfram.com/language/ref/Play.html
        ///</summary>
        public static Engine Play(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Play[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a plot of f as a function of x from xmin to xmax.
        ///https://reference.wolfram.com/language/ref/Plot.html
        ///</summary>
        public static Engine Plot(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Plot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots several functions fi.
        ///https://reference.wolfram.com/language/ref/Plot.html
        ///</summary>
        public static Engine Plot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Plot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots fi with features defined by the symbolic wrapper w.
        ///https://reference.wolfram.com/language/ref/Plot.html
        ///</summary>
        public static Engine Plot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Plot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes the variable x to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/Plot.html
        ///</summary>
        public static Engine Plot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Plot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a three-dimensional plot of f as a function of x and y.
        ///https://reference.wolfram.com/language/ref/Plot3D.html
        ///</summary>
        public static Engine Plot3D(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Plot3D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots several functions.
        ///https://reference.wolfram.com/language/ref/Plot3D.html
        ///</summary>
        public static Engine Plot3D(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Plot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots fi with features defined by the symbolic wrapper w.
        ///https://reference.wolfram.com/language/ref/Plot3D.html
        ///</summary>
        public static Engine Plot3D(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Plot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes variables {x,y} to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/Plot3D.html
        ///</summary>
        public static Engine Plot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Plot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the plural form of the English word "noun".
        ///https://reference.wolfram.com/language/ref/Pluralize.html
        ///</summary>
        public static Engine Pluralize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Pluralize[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the inflected form of "noun" for n instances.
        ///https://reference.wolfram.com/language/ref/Pluralize.html
        ///</summary>
        public static Engine Pluralize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Pluralize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///inflects using the specified forms.
        ///https://reference.wolfram.com/language/ref/Pluralize.html
        ///</summary>
        public static Engine Pluralize(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Pluralize[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as ±x.
        ///https://reference.wolfram.com/language/ref/PlusMinus.html
        ///</summary>
        public static Engine PlusMinus(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PlusMinus[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as x±y±….
        ///https://reference.wolfram.com/language/ref/PlusMinus.html
        ///</summary>
        public static Engine PlusMinus(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PlusMinus[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Pochhammer symbol .
        ///https://reference.wolfram.com/language/ref/Pochhammer.html
        ///</summary>
        public static Engine Pochhammer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Pochhammer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a graphics and geometry primitive that represents a point at p.
        ///https://reference.wolfram.com/language/ref/Point.html
        ///</summary>
        public static Engine Point(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Point[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a collection of points.
        ///https://reference.wolfram.com/language/ref/Point.html
        ///</summary>
        public static Engine Point(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Point[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the distribution of point counts for the point process pproc in the region reg.
        ///https://reference.wolfram.com/language/ref/PointCountDistribution.html
        ///</summary>
        public static Engine PointCountDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PointCountDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the joint distribution of point counts in regions regi.
        ///https://reference.wolfram.com/language/ref/PointCountDistribution.html
        ///</summary>
        public static Engine PointCountDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PointCountDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///estimates the point density function  from point data pdata.
        ///https://reference.wolfram.com/language/ref/PointDensity.html
        ///</summary>
        public static Engine PointDensity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PointDensity[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the point density function  with the partition method pmethod.
        ///https://reference.wolfram.com/language/ref/PointDensity.html
        ///</summary>
        public static Engine PointDensity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PointDensity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a function whose values give the density at a given location.
        ///https://reference.wolfram.com/language/ref/PointDensityFunction.html
        ///</summary>
        public static Engine PointDensityFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PointDensityFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a point and figure chart with prices pi at date datei.
        ///https://reference.wolfram.com/language/ref/PointFigureChart.html
        ///</summary>
        public static Engine PointFigureChart(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PointFigureChart[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a point and figure chart of closing prices for the financial entity "name" over the date range daterange.
        ///https://reference.wolfram.com/language/ref/PointFigureChart.html
        ///</summary>
        public static Engine PointFigureChart(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PointFigureChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes a point and figure chart with point and figure height s and n reversals.
        ///https://reference.wolfram.com/language/ref/PointFigureChart.html
        ///</summary>
        public static Engine PointFigureChart(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PointFigureChart[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a legend that associates points of colors coli with labels lbli.
        ///https://reference.wolfram.com/language/ref/PointLegend.html
        ///</summary>
        public static Engine PointLegend(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PointLegend[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a legend with placeholder labels for the colors coli.
        ///https://reference.wolfram.com/language/ref/PointLegend.html
        ///</summary>
        public static Engine PointLegend(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PointLegend[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a legend with inherited colors within visualization functions.
        ///https://reference.wolfram.com/language/ref/PointLegend.html
        ///</summary>
        public static Engine PointLegend(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PointLegend[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive that specifies the point light of color col at position pt to use in coloring 3D surfaces.
        ///https://reference.wolfram.com/language/ref/PointLight.html
        ///</summary>
        public static Engine PointLight(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PointLight[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the point light with geometric attenuation att.
        ///https://reference.wolfram.com/language/ref/PointLight.html
        ///</summary>
        public static Engine PointLight(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PointLight[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an option to EstimatedPointProcess and FindPointProcessParameters that specifies what point process parameter estimator to use.
        ///https://reference.wolfram.com/language/ref/PointProcessEstimator.html
        ///</summary>
        public static Engine PointProcessEstimator(this Engine en, string? name = null)
        {
            return en.Execute("PointProcessEstimator[]", name);
        }

        ///<summary>
        ///tests whether the point collection pdata could be modeled by a Poisson point process.
        ///https://reference.wolfram.com/language/ref/PointProcessFitTest.html
        ///</summary>
        public static Engine PointProcessFitTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PointProcessFitTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the point collection could be modeled by the point process pproc.
        ///https://reference.wolfram.com/language/ref/PointProcessFitTest.html
        ///</summary>
        public static Engine PointProcessFitTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PointProcessFitTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/PointProcessFitTest.html
        ///</summary>
        public static Engine PointProcessFitTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PointProcessFitTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a logical expression for assumptions on parameters in the point process proc.
        ///https://reference.wolfram.com/language/ref/PointProcessParameterAssumptions.html
        ///</summary>
        public static Engine PointProcessParameterAssumptions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PointProcessParameterAssumptions[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if proc is a valid random point process, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/PointProcessParameterQ.html
        ///</summary>
        public static Engine PointProcessParameterQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PointProcessParameterQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that points which follow are to be shown if possible as circular regions with diameter d. The diameter d is given as a fraction of the total width of the plot.
        ///https://reference.wolfram.com/language/ref/PointSize.html
        ///</summary>
        public static Engine PointSize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PointSize[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a function whose values give the statistic of a points collection pdata at a supplied radius.
        ///https://reference.wolfram.com/language/ref/PointStatisticFunction.html
        ///</summary>
        public static Engine PointStatisticFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PointStatisticFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the points pti styled according to the values vali.
        ///https://reference.wolfram.com/language/ref/PointValuePlot.html
        ///</summary>
        public static Engine PointValuePlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PointValuePlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses a collection of points pti from pts with corresponding values vali from val.
        ///https://reference.wolfram.com/language/ref/PointValuePlot.html
        ///</summary>
        public static Engine PointValuePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PointValuePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the visual encoding enc to represent the values vali in the plot.
        ///https://reference.wolfram.com/language/ref/PointValuePlot.html
        ///</summary>
        public static Engine PointValuePlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PointValuePlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Poisson–Consul distribution with parameters μ and λ.
        ///https://reference.wolfram.com/language/ref/PoissonConsulDistribution.html
        ///</summary>
        public static Engine PoissonConsulDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PoissonConsulDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Poisson distribution with mean μ.
        ///https://reference.wolfram.com/language/ref/PoissonDistribution.html
        ///</summary>
        public static Engine PoissonDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PoissonDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a Poisson PDE term  with model variables vars and model parameters pars.
        ///https://reference.wolfram.com/language/ref/PoissonPDEComponent.html
        ///</summary>
        public static Engine PoissonPDEComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PoissonPDEComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a homogeneous Poisson point process with constant intensity μ in .
        ///https://reference.wolfram.com/language/ref/PoissonPointProcess.html
        ///</summary>
        public static Engine PoissonPointProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PoissonPointProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Poisson process with rate μ.
        ///https://reference.wolfram.com/language/ref/PoissonProcess.html
        ///</summary>
        public static Engine PoissonProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PoissonProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Poisson window function of x.
        ///https://reference.wolfram.com/language/ref/PoissonWindow.html
        ///</summary>
        public static Engine PoissonWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PoissonWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the parameter α.
        ///https://reference.wolfram.com/language/ref/PoissonWindow.html
        ///</summary>
        public static Engine PoissonWindow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PoissonWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a polar plot of a curve with radius r as a function of angle θ.
        ///https://reference.wolfram.com/language/ref/PolarPlot.html
        ///</summary>
        public static Engine PolarPlot(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PolarPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a polar plot of curves with radius functions r1, r2, ….
        ///https://reference.wolfram.com/language/ref/PolarPlot.html
        ///</summary>
        public static Engine PolarPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PolarPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a Pólya–Aeppli distribution with shape parameters θ and p.
        ///https://reference.wolfram.com/language/ref/PolyaAeppliDistribution.html
        ///</summary>
        public static Engine PolyaAeppliDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolyaAeppliDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the digamma function .
        ///https://reference.wolfram.com/language/ref/PolyGamma.html
        ///</summary>
        public static Engine PolyGamma(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PolyGamma[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n derivative of the digamma function .
        ///https://reference.wolfram.com/language/ref/PolyGamma.html
        ///</summary>
        public static Engine PolyGamma(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolyGamma[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a filled polygon with points pi.
        ///https://reference.wolfram.com/language/ref/Polygon.html
        ///</summary>
        public static Engine Polygon(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Polygon[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a polygon in which coordinates given as integers i in data are taken to be pi.
        ///https://reference.wolfram.com/language/ref/Polygon.html
        ///</summary>
        public static Engine Polygon(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Polygon[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the n triangular number .
        ///https://reference.wolfram.com/language/ref/PolygonalNumber.html
        ///</summary>
        public static Engine PolygonalNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PolygonalNumber[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n r-gonal number .
        ///https://reference.wolfram.com/language/ref/PolygonalNumber.html
        ///</summary>
        public static Engine PolygonalNumber(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolygonalNumber[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of angles at the vertex points of poly.
        ///https://reference.wolfram.com/language/ref/PolygonAngle.html
        ///</summary>
        public static Engine PolygonAngle(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PolygonAngle[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the angle at the vertex point p of a polygon poly.
        ///https://reference.wolfram.com/language/ref/PolygonAngle.html
        ///</summary>
        public static Engine PolygonAngle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolygonAngle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of coordinates in the polygon poly.
        ///https://reference.wolfram.com/language/ref/PolygonCoordinates.html
        ///</summary>
        public static Engine PolygonCoordinates(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PolygonCoordinates[" + arg0 + "]", name);
        }

        ///<summary>
        ///decomposes the polygon poly into a disjoint union of simpler polygons.
        ///https://reference.wolfram.com/language/ref/PolygonDecomposition.html
        ///</summary>
        public static Engine PolygonDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PolygonDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///decomposes into polygons of the specified "type".
        ///https://reference.wolfram.com/language/ref/PolygonDecomposition.html
        ///</summary>
        public static Engine PolygonDecomposition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolygonDecomposition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a filled polyhedron inside the closed surfaces with polygon faces fi.
        ///https://reference.wolfram.com/language/ref/Polyhedron.html
        ///</summary>
        public static Engine Polyhedron(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Polyhedron[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a polyhedron in which coordinates given as integers i in data are taken to be pi.
        ///https://reference.wolfram.com/language/ref/Polyhedron.html
        ///</summary>
        public static Engine Polyhedron(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Polyhedron[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the solid angle at the point p and spanned by edges with common point p.
        ///https://reference.wolfram.com/language/ref/PolyhedronAngle.html
        ///</summary>
        public static Engine PolyhedronAngle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolyhedronAngle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of coordinates in the polyhedron poly.
        ///https://reference.wolfram.com/language/ref/PolyhedronCoordinates.html
        ///</summary>
        public static Engine PolyhedronCoordinates(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PolyhedronCoordinates[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the polyhedron named poly.
        ///https://reference.wolfram.com/language/ref/PolyhedronData.html
        ///</summary>
        public static Engine PolyhedronData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolyhedronData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an image of the polyhedron named poly.
        ///https://reference.wolfram.com/language/ref/PolyhedronData.html
        ///</summary>
        public static Engine PolyhedronData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PolyhedronData[" + arg0 + "]", name);
        }

        ///<summary>
        ///decomposes the polyhedron poly into a union of simpler polyhedra.
        ///https://reference.wolfram.com/language/ref/PolyhedronDecomposition.html
        ///</summary>
        public static Engine PolyhedronDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PolyhedronDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the polylogarithm function .
        ///https://reference.wolfram.com/language/ref/PolyLog.html
        ///</summary>
        public static Engine PolyLog(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolyLog[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Nielsen generalized polylogarithm function .
        ///https://reference.wolfram.com/language/ref/PolyLog.html
        ///</summary>
        public static Engine PolyLog(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PolyLog[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives True if expr is structurally a polynomial expression in x, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PolynomialExpressionQ.html
        ///</summary>
        public static Engine PolynomialExpressionQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolynomialExpressionQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if expr is structurally a polynomial expression in x,y,…, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PolynomialExpressionQ.html
        ///</summary>
        public static Engine PolynomialExpressionQ(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PolynomialExpressionQ[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if expr is structurally a polynomial expression in x,y,… with coefficients satisfying test, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PolynomialExpressionQ.html
        ///</summary>
        public static Engine PolynomialExpressionQ(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("PolynomialExpressionQ[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the extended GCD of poly1 and poly2 treated as univariate polynomials in x.
        ///https://reference.wolfram.com/language/ref/PolynomialExtendedGCD.html
        ///</summary>
        public static Engine PolynomialExtendedGCD(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PolynomialExtendedGCD[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the extended GCD over the integers mod prime p.
        ///https://reference.wolfram.com/language/ref/PolynomialExtendedGCD.html
        ///</summary>
        public static Engine PolynomialExtendedGCD(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PolynomialExtendedGCD[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the greatest common divisor of the polynomials polyi.
        ///https://reference.wolfram.com/language/ref/PolynomialGCD.html
        ///</summary>
        public static Engine PolynomialGCD(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PolynomialGCD[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///evaluates the GCD modulo the prime p.
        ///https://reference.wolfram.com/language/ref/PolynomialGCD.html
        ///</summary>
        public static Engine PolynomialGCD(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PolynomialGCD[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the least common multiple of the polynomials polyi.
        ///https://reference.wolfram.com/language/ref/PolynomialLCM.html
        ///</summary>
        public static Engine PolynomialLCM(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PolynomialLCM[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///evaluates the LCM modulo the prime p.
        ///https://reference.wolfram.com/language/ref/PolynomialLCM.html
        ///</summary>
        public static Engine PolynomialLCM(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PolynomialLCM[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the polynomial poly reduced modulo m.
        ///https://reference.wolfram.com/language/ref/PolynomialMod.html
        ///</summary>
        public static Engine PolynomialMod(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolynomialMod[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reduces modulo all of the mi.
        ///https://reference.wolfram.com/language/ref/PolynomialMod.html
        ///</summary>
        public static Engine PolynomialMod(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PolynomialMod[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if expr is a polynomial in var, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/PolynomialQ.html
        ///</summary>
        public static Engine PolynomialQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolynomialQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether expr is a polynomial in the vari.
        ///https://reference.wolfram.com/language/ref/PolynomialQ.html
        ///</summary>
        public static Engine PolynomialQ(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PolynomialQ[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the quotient of p and q, treated as polynomials in x, with any remainder dropped.
        ///https://reference.wolfram.com/language/ref/PolynomialQuotient.html
        ///</summary>
        public static Engine PolynomialQuotient(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PolynomialQuotient[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the quotient and remainder of p and q, treated as polynomials in x.
        ///https://reference.wolfram.com/language/ref/PolynomialQuotientRemainder.html
        ///</summary>
        public static Engine PolynomialQuotientRemainder(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PolynomialQuotientRemainder[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a list representing a reduction of poly in terms of the polyi. The list has the form {{a1,a2,…},b}, where b is minimal and a1 poly1+a2 poly2+…+b is exactly poly.
        ///https://reference.wolfram.com/language/ref/PolynomialReduce.html
        ///</summary>
        public static Engine PolynomialReduce(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("PolynomialReduce[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the remainder from dividing p by q, treated as polynomials in x.
        ///https://reference.wolfram.com/language/ref/PolynomialRemainder.html
        ///</summary>
        public static Engine PolynomialRemainder(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PolynomialRemainder[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///attempts to find polynomials with real coefficients {f1,…,fn} such that f==f12+…+fn2.
        ///https://reference.wolfram.com/language/ref/PolynomialSumOfSquaresList.html
        ///</summary>
        public static Engine PolynomialSumOfSquaresList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PolynomialSumOfSquaresList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a pooling net layer using kernels of size sz.
        ///https://reference.wolfram.com/language/ref/PoolingLayer.html
        ///</summary>
        public static Engine PoolingLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PoolingLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a layer performing one-dimensional pooling with kernels of size w.
        ///https://reference.wolfram.com/language/ref/PoolingLayer.html
        ///</summary>
        public static Engine PoolingLayer(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PoolingLayer[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a layer that uses stride as the step size between kernel applications.
        ///https://reference.wolfram.com/language/ref/PoolingLayer.html
        ///</summary>
        public static Engine PoolingLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PoolingLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a popup menu with setting x and possible values vali.
        ///https://reference.wolfram.com/language/ref/PopupMenu.html
        ///</summary>
        public static Engine PopupMenu(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PopupMenu[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///displays the menu item as dlbl if x is none of the vali.
        ///https://reference.wolfram.com/language/ref/PopupMenu.html
        ///</summary>
        public static Engine PopupMenu(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("PopupMenu[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as base when it is not being clicked.
        ///https://reference.wolfram.com/language/ref/PopupMenu.html
        ///</summary>
        public static Engine PopupMenu(this Engine en, object arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("PopupMenu[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an object which displays as a popup menu whose items are the expri.
        ///https://reference.wolfram.com/language/ref/PopupView.html
        ///</summary>
        public static Engine PopupView(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PopupView[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes the i entry be the one currently chosen.
        ///https://reference.wolfram.com/language/ref/PopupView.html
        ///</summary>
        public static Engine PopupView(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PopupView[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as base if it is not being clicked.
        ///https://reference.wolfram.com/language/ref/PopupView.html
        ///</summary>
        public static Engine PopupView(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PopupView[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as expr, but pops up a window containing contents when clicked.
        ///https://reference.wolfram.com/language/ref/PopupWindow.html
        ///</summary>
        public static Engine PopupWindow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PopupWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the positions at which objects matching pattern appear in expr.
        ///https://reference.wolfram.com/language/ref/Position.html
        ///</summary>
        public static Engine Position(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Position[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds only objects that appear on levels specified by levelspec.
        ///https://reference.wolfram.com/language/ref/Position.html
        ///</summary>
        public static Engine Position(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Position[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the positions of the first n objects found.
        ///https://reference.wolfram.com/language/ref/Position.html
        ///</summary>
        public static Engine Position(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Position[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of Position that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Position.html
        ///</summary>
        public static Engine Position(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Position[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an association between unique elements in list and the positions at which they occur.
        ///https://reference.wolfram.com/language/ref/PositionIndex.html
        ///</summary>
        public static Engine PositionIndex(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PositionIndex[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if x is a positive number.
        ///https://reference.wolfram.com/language/ref/Positive.html
        ///</summary>
        public static Engine Positive(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Positive[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly positive definite, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PositiveDefiniteMatrixQ.html
        ///</summary>
        public static Engine PositiveDefiniteMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PositiveDefiniteMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the sequence of points p1,p2,p3,…,pd+1 is positively oriented.
        ///https://reference.wolfram.com/language/ref/PositivelyOrientedPoints.html
        ///</summary>
        public static Engine PositivelyOrientedPoints(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PositivelyOrientedPoints[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly positive semidefinite, and False otherwise.
        ///https://reference.wolfram.com/language/ref/PositiveSemidefiniteMatrixQ.html
        ///</summary>
        public static Engine PositiveSemidefiniteMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PositiveSemidefiniteMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if basic symbolic and numerical methods suggest that expr has value zero, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/PossibleZeroQ.html
        ///</summary>
        public static Engine PossibleZeroQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PossibleZeroQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with f[expr] given in default postfix form: expr//f.
        ///https://reference.wolfram.com/language/ref/Postfix.html
        ///</summary>
        public static Engine Postfix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Postfix[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as exprh.
        ///https://reference.wolfram.com/language/ref/Postfix.html
        ///</summary>
        public static Engine Postfix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Postfix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a power distribution with domain parameter k and shape parameter a.
        ///https://reference.wolfram.com/language/ref/PowerDistribution.html
        ///</summary>
        public static Engine PowerDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PowerDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///expands all powers of products and powers.
        ///https://reference.wolfram.com/language/ref/PowerExpand.html
        ///</summary>
        public static Engine PowerExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PowerExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands only with respect to the variables xi.
        ///https://reference.wolfram.com/language/ref/PowerExpand.html
        ///</summary>
        public static Engine PowerExpand(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PowerExpand[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives ab mod m.
        ///https://reference.wolfram.com/language/ref/PowerMod.html
        ///</summary>
        public static Engine PowerMod(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PowerMod[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of all  modulo m for which  mod m.
        ///https://reference.wolfram.com/language/ref/PowerModList.html
        ///</summary>
        public static Engine PowerModList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PowerModList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates the list {1,10,100,…,max}, where max is the largest power of 10 that does not exceed b.
        ///https://reference.wolfram.com/language/ref/PowerRange.html
        ///</summary>
        public static Engine PowerRange(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PowerRange[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates the list {a,10a,100a,…,max}, with successive elements increasing by factors of 10.
        ///https://reference.wolfram.com/language/ref/PowerRange.html
        ///</summary>
        public static Engine PowerRange(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PowerRange[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses factors of r instead of 10.
        ///https://reference.wolfram.com/language/ref/PowerRange.html
        ///</summary>
        public static Engine PowerRange(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PowerRange[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///estimates the power spectral density for data.
        ///https://reference.wolfram.com/language/ref/PowerSpectralDensity.html
        ///</summary>
        public static Engine PowerSpectralDensity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PowerSpectralDensity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the power spectral density for data with smoothing specification sspec.
        ///https://reference.wolfram.com/language/ref/PowerSpectralDensity.html
        ///</summary>
        public static Engine PowerSpectralDensity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PowerSpectralDensity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the distinct representations of the integer n as a sum of k non-negative p integer powers.
        ///https://reference.wolfram.com/language/ref/PowersRepresentations.html
        ///</summary>
        public static Engine PowersRepresentations(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PowersRepresentations[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a formal power symmetric polynomial with exponent r.
        ///https://reference.wolfram.com/language/ref/PowerSymmetricPolynomial.html
        ///</summary>
        public static Engine PowerSymmetricPolynomial(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PowerSymmetricPolynomial[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a multivariate formal power symmetric polynomial with exponents r1, r2, ….
        ///https://reference.wolfram.com/language/ref/PowerSymmetricPolynomial.html
        ///</summary>
        public static Engine PowerSymmetricPolynomial(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("PowerSymmetricPolynomial[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the power symmetric polynomial in data.
        ///https://reference.wolfram.com/language/ref/PowerSymmetricPolynomial.html
        ///</summary>
        public static Engine PowerSymmetricPolynomial(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PowerSymmetricPolynomial[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints with expr parenthesized as it would be if it contained an operator with precedence prec.
        ///https://reference.wolfram.com/language/ref/PrecedenceForm.html
        ///</summary>
        public static Engine PrecedenceForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PrecedenceForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Precedes.html
        ///</summary>
        public static Engine Precedes(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Precedes[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/PrecedesEqual.html
        ///</summary>
        public static Engine PrecedesEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PrecedesEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/PrecedesSlantEqual.html
        ///</summary>
        public static Engine PrecedesSlantEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PrecedesSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/PrecedesTilde.html
        ///</summary>
        public static Engine PrecedesTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PrecedesTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the effective number of digits of precision in the number x.
        ///https://reference.wolfram.com/language/ref/Precision.html
        ///</summary>
        public static Engine Precision(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Precision[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a PredictorFunction[…] based on the example input-output pairs given.
        ///https://reference.wolfram.com/language/ref/Predict.html
        ///</summary>
        public static Engine Predict(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Predict[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///attempts to predict the output associated with input from the training examples given.
        ///https://reference.wolfram.com/language/ref/Predict.html
        ///</summary>
        public static Engine Predict(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Predict[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a function generated by Predict that predicts numerical values from data.
        ///https://reference.wolfram.com/language/ref/PredictorFunction.html
        ///</summary>
        public static Engine PredictorFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PredictorFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives measurements associated with the property prop when predictor is evaluated on testset.
        ///https://reference.wolfram.com/language/ref/PredictorMeasurements.html
        ///</summary>
        public static Engine PredictorMeasurements(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PredictorMeasurements[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a measurement report that can be applied to any property.
        ///https://reference.wolfram.com/language/ref/PredictorMeasurements.html
        ///</summary>
        public static Engine PredictorMeasurements(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PredictorMeasurements[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives properties prop1, prop2, etc.
        ///https://reference.wolfram.com/language/ref/PredictorMeasurements.html
        ///</summary>
        public static Engine PredictorMeasurements(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("PredictorMeasurements[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an object generated by PredictorMeasurements that can be applied to properties.
        ///https://reference.wolfram.com/language/ref/PredictorMeasurementsObject.html
        ///</summary>
        public static Engine PredictorMeasurementsObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PredictorMeasurementsObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr, without any interruption from preemptive evaluations.
        ///https://reference.wolfram.com/language/ref/PreemptProtect.html
        ///</summary>
        public static Engine PreemptProtect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PreemptProtect[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with f[expr] given in default prefix form: f@expr.
        ///https://reference.wolfram.com/language/ref/Prefix.html
        ///</summary>
        public static Engine Prefix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Prefix[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as hexpr.
        ///https://reference.wolfram.com/language/ref/Prefix.html
        ///</summary>
        public static Engine Prefix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Prefix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives expr with elem prepended.
        ///https://reference.wolfram.com/language/ref/Prepend.html
        ///</summary>
        public static Engine Prepend(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Prepend[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of Prepend that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Prepend.html
        ///</summary>
        public static Engine Prepend(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Prepend[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that takes an input array and prepends another array to it.
        ///https://reference.wolfram.com/language/ref/PrependLayer.html
        ///</summary>
        public static Engine PrependLayer(this Engine en, string? name = null)
        {
            return en.Execute("PrependLayer[]", name);
        }

        ///<summary>
        ///prepends elem to the value of x, and resets x to the result.
        ///https://reference.wolfram.com/language/ref/PrependTo.html
        ///</summary>
        public static Engine PrependTo(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PrependTo[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the CellObject corresponding to the cell directly above the currently evaluating cell.
        ///https://reference.wolfram.com/language/ref/PreviousCell.html
        ///</summary>
        public static Engine PreviousCell(this Engine en, string? name = null)
        {
            return en.Execute("PreviousCell[]", name);
        }

        ///<summary>
        ///starts looking from the given cell.
        ///https://reference.wolfram.com/language/ref/PreviousCell.html
        ///</summary>
        public static Engine PreviousCell(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PreviousCell[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the previously occurring date of the specified granularity type gran.
        ///https://reference.wolfram.com/language/ref/PreviousDate.html
        ///</summary>
        public static Engine PreviousDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PreviousDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the previous date of the given granularity relative to the specified date.
        ///https://reference.wolfram.com/language/ref/PreviousDate.html
        ///</summary>
        public static Engine PreviousDate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PreviousDate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a de Solla Price graph distribution for n-vertex graphs where a new vertex with k edges is added at each step, using attractiveness parameter a.
        ///https://reference.wolfram.com/language/ref/PriceGraphDistribution.html
        ///</summary>
        public static Engine PriceGraphDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PriceGraphDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the nprime number .
        ///https://reference.wolfram.com/language/ref/Prime.html
        ///</summary>
        public static Engine Prime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Prime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of distinct primes  in n.
        ///https://reference.wolfram.com/language/ref/PrimeNu.html
        ///</summary>
        public static Engine PrimeNu(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrimeNu[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of prime factors counting multiplicities  in n.
        ///https://reference.wolfram.com/language/ref/PrimeOmega.html
        ///</summary>
        public static Engine PrimeOmega(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrimeOmega[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of primes  less than or equal to x.
        ///https://reference.wolfram.com/language/ref/PrimePi.html
        ///</summary>
        public static Engine PrimePi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrimePi[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if expr is a power of a prime number, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/PrimePowerQ.html
        ///</summary>
        public static Engine PrimePowerQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrimePowerQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if n is a prime number, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/PrimeQ.html
        ///</summary>
        public static Engine PrimeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrimeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives prime zeta function .
        ///https://reference.wolfram.com/language/ref/PrimeZetaP.html
        ///</summary>
        public static Engine PrimeZetaP(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrimeZetaP[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether poly is a primitive polynomial modulo a prime p.
        ///https://reference.wolfram.com/language/ref/PrimitivePolynomialQ.html
        ///</summary>
        public static Engine PrimitivePolynomialQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PrimitivePolynomialQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a primitive root of n.
        ///https://reference.wolfram.com/language/ref/PrimitiveRoot.html
        ///</summary>
        public static Engine PrimitiveRoot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrimitiveRoot[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the smallest primitive root of n greater than or equal to k.
        ///https://reference.wolfram.com/language/ref/PrimitiveRoot.html
        ///</summary>
        public static Engine PrimitiveRoot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PrimitiveRoot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of primitive roots of n.
        ///https://reference.wolfram.com/language/ref/PrimitiveRootList.html
        ///</summary>
        public static Engine PrimitiveRootList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrimitiveRootList[" + arg0 + "]", name);
        }

        ///<summary>
        ///transforms elements of matrix into unscaled principal components.
        ///https://reference.wolfram.com/language/ref/PrincipalComponents.html
        ///</summary>
        public static Engine PrincipalComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrincipalComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints expr as output.
        ///https://reference.wolfram.com/language/ref/Print.html
        ///</summary>
        public static Engine Print(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Print[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the string contains only printable ASCII characters, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/PrintableASCIIQ.html
        ///</summary>
        public static Engine PrintableASCIIQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrintableASCIIQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints out the 3D model using a 3D print previewer.
        ///https://reference.wolfram.com/language/ref/Printout3D.html
        ///</summary>
        public static Engine Printout3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Printout3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints out the 3D model using the specified 3D printing service.
        ///https://reference.wolfram.com/language/ref/Printout3D.html
        ///</summary>
        public static Engine Printout3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Printout3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints expr as a temporary cell in a notebook, removing it when the evaluation of the current input line is complete.
        ///https://reference.wolfram.com/language/ref/PrintTemporary.html
        ///</summary>
        public static Engine PrintTemporary(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrintTemporary[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a filled prism connecting the triangles {p1,p2,p3} and {p4,p5,p6}.
        ///https://reference.wolfram.com/language/ref/Prism.html
        ///</summary>
        public static Engine Prism(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Prism[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the private part of a key pair for a public-key cryptographic system.
        ///https://reference.wolfram.com/language/ref/PrivateKey.html
        ///</summary>
        public static Engine PrivateKey(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PrivateKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the probability for an event that satisfies the predicate pred under the assumption that x follows the probability distribution dist.
        ///https://reference.wolfram.com/language/ref/Probability.html
        ///</summary>
        public static Engine Probability(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Probability[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the probability that an event satisfies pred under the assumption that x1, x2, … are independent and follow the distributions dist1, dist2, ….
        ///https://reference.wolfram.com/language/ref/Probability.html
        ///</summary>
        public static Engine Probability(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Probability[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents the continuous distribution with PDF pdf in the variable x where the pdf is taken to be zero for  and .
        ///https://reference.wolfram.com/language/ref/ProbabilityDistribution.html
        ///</summary>
        public static Engine ProbabilityDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ProbabilityDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a multivariate distribution with PDF pdf in the variables x, y, …, etc.
        ///https://reference.wolfram.com/language/ref/ProbabilityDistribution.html
        ///</summary>
        public static Engine ProbabilityDistribution(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ProbabilityDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a probability distribution with CDF given by cdf.
        ///https://reference.wolfram.com/language/ref/ProbabilityDistribution.html
        ///</summary>
        public static Engine ProbabilityDistribution(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ProbabilityDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a plot of the CDF of list against the CDF of a normal distribution.
        ///https://reference.wolfram.com/language/ref/ProbabilityPlot.html
        ///</summary>
        public static Engine ProbabilityPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProbabilityPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot of the CDF of data against the CDF of rdata.
        ///https://reference.wolfram.com/language/ref/ProbabilityPlot.html
        ///</summary>
        public static Engine ProbabilityPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ProbabilityPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a plot of the CDF of datai against the CDF of a reference distribution ref.
        ///https://reference.wolfram.com/language/ref/ProbabilityPlot.html
        ///</summary>
        public static Engine ProbabilityPlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ProbabilityPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a normal probability plot of the samples xi.
        ///https://reference.wolfram.com/language/ref/ProbabilityScalePlot.html
        ///</summary>
        public static Engine ProbabilityScalePlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ProbabilityScalePlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a probability plot scaled for the distribution "dist".
        ///https://reference.wolfram.com/language/ref/ProbabilityScalePlot.html
        ///</summary>
        public static Engine ProbabilityScalePlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ProbabilityScalePlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs a binomial probit regression model of the form  that fits the yi for successive x values 1, 2, ….
        ///https://reference.wolfram.com/language/ref/ProbitModelFit.html
        ///</summary>
        public static Engine ProbitModelFit(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ProbitModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///constructs a binomial probit regression model of the form  where the fi depend on the variables xk.
        ///https://reference.wolfram.com/language/ref/ProbitModelFit.html
        ///</summary>
        public static Engine ProbitModelFit(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("ProbitModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///constructs a binomial probit regression model from the design matrix m and response vector v.
        ///https://reference.wolfram.com/language/ref/ProbitModelFit.html
        ///</summary>
        public static Engine ProbitModelFit(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ProbitModelFit[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the stream object for a given stream.
        ///https://reference.wolfram.com/language/ref/ProcessConnection.html
        ///</summary>
        public static Engine ProcessConnection(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ProcessConnection[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of currently running external processes started in this Wolfram Language session.
        ///https://reference.wolfram.com/language/ref/Processes.html
        ///</summary>
        public static Engine Processes(this Engine en, string? name = null)
        {
            return en.Execute("Processes[]", name);
        }

        ///<summary>
        ///gives information about an external process proc.
        ///https://reference.wolfram.com/language/ref/ProcessInformation.html
        ///</summary>
        public static Engine ProcessInformation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProcessInformation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives information about the property "prop".
        ///https://reference.wolfram.com/language/ref/ProcessInformation.html
        ///</summary>
        public static Engine ProcessInformation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ProcessInformation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an object that represents a runnable external process.
        ///https://reference.wolfram.com/language/ref/ProcessObject.html
        ///</summary>
        public static Engine ProcessObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProcessObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a logical expression for assumptions on parameters in the random process proc.
        ///https://reference.wolfram.com/language/ref/ProcessParameterAssumptions.html
        ///</summary>
        public static Engine ProcessParameterAssumptions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProcessParameterAssumptions[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if proc is a valid random process, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/ProcessParameterQ.html
        ///</summary>
        public static Engine ProcessParameterQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProcessParameterQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the current status of the external process represented by the ProcessObject proc.
        ///https://reference.wolfram.com/language/ref/ProcessStatus.html
        ///</summary>
        public static Engine ProcessStatus(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProcessStatus[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if the process has the status given and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/ProcessStatus.html
        ///</summary>
        public static Engine ProcessStatus(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ProcessStatus[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates the product .
        ///https://reference.wolfram.com/language/ref/Product.html
        ///</summary>
        public static Engine Product(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Product[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses successive values i1, i2, ….
        ///https://reference.wolfram.com/language/ref/Product.html
        ///</summary>
        public static Engine Product(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Product[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates the multiple product .
        ///https://reference.wolfram.com/language/ref/Product.html
        ///</summary>
        public static Engine Product(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("Product[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the indefinite product .
        ///https://reference.wolfram.com/language/ref/Product.html
        ///</summary>
        public static Engine Product(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Product[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the joint distribution with independent component distributions dist1, dist2, ….
        ///https://reference.wolfram.com/language/ref/ProductDistribution.html
        ///</summary>
        public static Engine ProductDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ProductDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the principal solution for w in .
        ///https://reference.wolfram.com/language/ref/ProductLog.html
        ///</summary>
        public static Engine ProductLog(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProductLog[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the k solution.
        ///https://reference.wolfram.com/language/ref/ProductLog.html
        ///</summary>
        public static Engine ProductLog(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ProductLog[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a progress indicator with setting x in the range 0 to 1.
        ///https://reference.wolfram.com/language/ref/ProgressIndicator.html
        ///</summary>
        public static Engine ProgressIndicator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProgressIndicator[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a progress indicator with range xmin to xmax.
        ///https://reference.wolfram.com/language/ref/ProgressIndicator.html
        ///</summary>
        public static Engine ProgressIndicator(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ProgressIndicator[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a progress indicator with indeterminate range.
        ///https://reference.wolfram.com/language/ref/ProgressIndicator.html
        ///</summary>
        public static Engine ProgressIndicator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ProgressIndicator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the projection of the vector u onto the vector v.
        ///https://reference.wolfram.com/language/ref/Projection.html
        ///</summary>
        public static Engine Projection(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Projection[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds projections with respect to the inner product function f.
        ///https://reference.wolfram.com/language/ref/Projection.html
        ///</summary>
        public static Engine Projection(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Projection[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a proof object generated by FindEquationalProof.
        ///https://reference.wolfram.com/language/ref/ProofObject.html
        ///</summary>
        public static Engine ProofObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProofObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Proportion.html
        ///</summary>
        public static Engine Proportion(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Proportion[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Proportional.html
        ///</summary>
        public static Engine Proportional(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Proportional[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///sets the attribute Protected for the symbols si.
        ///https://reference.wolfram.com/language/ref/Protect.html
        ///</summary>
        public static Engine Protect(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Protect[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///protects any symbols that are equal to or match any of the speci.
        ///https://reference.wolfram.com/language/ref/Protect.html
        ///</summary>
        public static Engine Protect(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Protect[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the reference amino acid sequence for the protein entity.
        ///https://reference.wolfram.com/language/ref/ProteinData.html
        ///</summary>
        public static Engine ProteinData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ProteinData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the protein entity.
        ///https://reference.wolfram.com/language/ref/ProteinData.html
        ///</summary>
        public static Engine ProteinData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ProteinData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/ProteinData.html
        ///</summary>
        public static Engine ProteinData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ProteinData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///removes the outermost branches of thin objects in image by setting their values to black.
        ///https://reference.wolfram.com/language/ref/Pruning.html
        ///</summary>
        public static Engine Pruning(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Pruning[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes branches that are at most n pixels long.
        ///https://reference.wolfram.com/language/ref/Pruning.html
        ///</summary>
        public static Engine Pruning(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Pruning[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///removes n pixels from each branch.
        ///https://reference.wolfram.com/language/ref/Pruning.html
        ///</summary>
        public static Engine Pruning(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Pruning[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///treats values above t as foreground.
        ///https://reference.wolfram.com/language/ref/Pruning.html
        ///</summary>
        public static Engine Pruning(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Pruning[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the pseudoinverse of a rectangular matrix.
        ///https://reference.wolfram.com/language/ref/PseudoInverse.html
        ///</summary>
        public static Engine PseudoInverse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PseudoInverse[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the psychrometric properties of moist air for the specified parameters.
        ///https://reference.wolfram.com/language/ref/PsychrometricPropertyData.html
        ///</summary>
        public static Engine PsychrometricPropertyData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PsychrometricPropertyData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the specified property for the given parameters.
        ///https://reference.wolfram.com/language/ref/PsychrometricPropertyData.html
        ///</summary>
        public static Engine PsychrometricPropertyData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PsychrometricPropertyData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the public part of a key pair for a public-key cryptographic system.
        ///https://reference.wolfram.com/language/ref/PublicKey.html
        ///</summary>
        public static Engine PublicKey(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("PublicKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the pulsar entity.
        ///https://reference.wolfram.com/language/ref/PulsarData.html
        ///</summary>
        public static Engine PulsarData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("PulsarData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified pulsar entities.
        ///https://reference.wolfram.com/language/ref/PulsarData.html
        ///</summary>
        public static Engine PulsarData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("PulsarData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/PulsarData.html
        ///</summary>
        public static Engine PulsarData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("PulsarData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a filled pyramid with base {p1,…,p4} and top p5.
        ///https://reference.wolfram.com/language/ref/Pyramid.html
        ///</summary>
        public static Engine Pyramid(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Pyramid[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }


    }
}
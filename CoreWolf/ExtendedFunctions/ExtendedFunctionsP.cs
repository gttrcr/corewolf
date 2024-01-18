namespace CoreWolf
{
    public static class ExtendedFunctionsP
    {
        ///<summary>
        /// makes paclets in dir visible in the current session.
        /// https://reference.wolfram.com/language/ref/PacletDirectoryLoad.html
        ///</summary>
        public static Engine PacletDirectoryLoad(this Engine en, string? name = null)
        {
            return en.Execute("PacletDirectoryLoad[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes paclets in dir no longer visible in the current session.
        /// https://reference.wolfram.com/language/ref/PacletDirectoryUnload.html
        ///</summary>
        public static Engine PacletDirectoryUnload(this Engine en, string? name = null)
        {
            return en.Execute("PacletDirectoryUnload[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// disables an installed paclet.
        /// https://reference.wolfram.com/language/ref/PacletDisable.html
        ///</summary>
        public static Engine PacletDisable(this Engine en, string? name = null)
        {
            return en.Execute("PacletDisable[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of installed paclets that match "name".
        /// https://reference.wolfram.com/language/ref/PacletFind.html
        ///</summary>
        public static Engine PacletFind(this Engine en, string? name = null)
        {
            return en.Execute("PacletFind[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of paclets that match "name" available on known paclet sites.
        /// https://reference.wolfram.com/language/ref/PacletFindRemote.html
        ///</summary>
        public static Engine PacletFindRemote(this Engine en, string? name = null)
        {
            return en.Execute("PacletFindRemote[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// installs or updates paclet.
        /// https://reference.wolfram.com/language/ref/PacletInstall.html
        ///</summary>
        public static Engine PacletInstall(this Engine en, string? name = null)
        {
            return en.Execute("PacletInstall[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// asynchronously installs or updates paclet.
        /// https://reference.wolfram.com/language/ref/PacletInstallSubmit.html
        ///</summary>
        public static Engine PacletInstallSubmit(this Engine en, string? name = null)
        {
            return en.Execute("PacletInstallSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a paclet on the local machine or on a remote paclet site.
        /// https://reference.wolfram.com/language/ref/PacletObject.html
        ///</summary>
        public static Engine PacletObject(this Engine en, string? name = null)
        {
            return en.Execute("PacletObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a site from which paclets can be automatically downloaded.
        /// https://reference.wolfram.com/language/ref/PacletSiteObject.html
        ///</summary>
        public static Engine PacletSiteObject(this Engine en, string? name = null)
        {
            return en.Execute("PacletSiteObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// registers url as a known paclet site.
        /// https://reference.wolfram.com/language/ref/PacletSiteRegister.html
        ///</summary>
        public static Engine PacletSiteRegister(this Engine en, string? name = null)
        {
            return en.Execute("PacletSiteRegister[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// removes url from the list of registered paclet sites.
        /// https://reference.wolfram.com/language/ref/PacletSiteUnregister.html
        ///</summary>
        public static Engine PacletSiteUnregister(this Engine en, string? name = null)
        {
            return en.Execute("PacletSiteUnregister[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// acquires and caches current information about the available paclets on the given paclet site.
        /// https://reference.wolfram.com/language/ref/PacletSiteUpdate.html
        ///</summary>
        public static Engine PacletSiteUpdate(this Engine en, string? name = null)
        {
            return en.Execute("PacletSiteUpdate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uninstalls a paclet.
        /// https://reference.wolfram.com/language/ref/PacletUninstall.html
        ///</summary>
        public static Engine PacletUninstall(this Engine en, string? name = null)
        {
            return en.Execute("PacletUninstall[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// pads a ragged array list with zeros to make it full.
        /// https://reference.wolfram.com/language/ref/PadLeft.html
        ///</summary>
        public static Engine PadLeft(this Engine en, string? name = null)
        {
            return en.Execute("PadLeft[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// pads a ragged array list with zeros to make it full.
        /// https://reference.wolfram.com/language/ref/PadRight.html
        ///</summary>
        public static Engine PadRight(this Engine en, string? name = null)
        {
            return en.Execute("PadRight[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates the function  that can be applied repeatedly to different radii r.
        /// https://reference.wolfram.com/language/ref/PairCorrelationG.html
        ///</summary>
        public static Engine PairCorrelationG(this Engine en, string? name = null)
        {
            return en.Execute("PairCorrelationG[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the mean of data is zero.
        /// https://reference.wolfram.com/language/ref/PairedTTest.html
        ///</summary>
        public static Engine PairedTTest(this Engine en, string? name = null)
        {
            return en.Execute("PairedTTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the mean of the data is zero.
        /// https://reference.wolfram.com/language/ref/PairedZTest.html
        ///</summary>
        public static Engine PairedZTest(this Engine en, string? name = null)
        {
            return en.Execute("PairedZTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a palette notebook that can be manipulated by the Wolfram System front end.
        /// https://reference.wolfram.com/language/ref/PaletteNotebook.html
        ///</summary>
        public static Engine PaletteNotebook(this Engine en, string? name = null)
        {
            return en.Execute("PaletteNotebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if the given list is identical to Reverse[list], and False otherwise.
        /// https://reference.wolfram.com/language/ref/PalindromeQ.html
        ///</summary>
        public static Engine PalindromeQ(this Engine en, string? name = null)
        {
            return en.Execute("PalindromeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays as a pane containing expr.
        /// https://reference.wolfram.com/language/ref/Pane.html
        ///</summary>
        public static Engine Pane(this Engine en, string? name = null)
        {
            return en.Execute("Pane[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays as a panel containing expr.
        /// https://reference.wolfram.com/language/ref/Panel.html
        ///</summary>
        public static Engine Panel(this Engine en, string? name = null)
        {
            return en.Execute("Panel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots several sets of points.
        /// https://reference.wolfram.com/language/ref/ParallelAxisPlot.html
        ///</summary>
        public static Engine ParallelAxisPlot(this Engine en, string? name = null)
        {
            return en.Execute("ParallelAxisPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates the expression expr on all available parallel kernels and returns the list of results obtained.
        /// https://reference.wolfram.com/language/ref/ParallelEvaluate.html
        ///</summary>
        public static Engine ParallelEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("ParallelEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates expr using automatic parallelization.
        /// https://reference.wolfram.com/language/ref/Parallelize.html
        ///</summary>
        public static Engine Parallelize(this Engine en, string? name = null)
        {
            return en.Execute("Parallelize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates Needs["context`"] on all available parallel kernels.
        /// https://reference.wolfram.com/language/ref/ParallelNeeds.html
        ///</summary>
        public static Engine ParallelNeeds(this Engine en, string? name = null)
        {
            return en.Execute("ParallelNeeds[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// submits expr for evaluation on the next available parallel kernel and returns an EvaluationObject expression representing the submitted evaluation.
        /// https://reference.wolfram.com/language/ref/ParallelSubmit.html
        ///</summary>
        public static Engine ParallelSubmit(this Engine en, string? name = null)
        {
            return en.Execute("ParallelSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// specifies the levels on which each dimension has a specific slope.
        /// https://reference.wolfram.com/language/ref/ParametricRampLayer.html
        ///</summary>
        public static Engine ParametricRampLayer(this Engine en, string? name = null)
        {
            return en.Execute("ParametricRampLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the BoxObject that contains obj.
        /// https://reference.wolfram.com/language/ref/ParentBox.html
        ///</summary>
        public static Engine ParentBox(this Engine en, string? name = null)
        {
            return en.Execute("ParentBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the CellObject that contains obj.
        /// https://reference.wolfram.com/language/ref/ParentCell.html
        ///</summary>
        public static Engine ParentCell(this Engine en, string? name = null)
        {
            return en.Execute("ParentCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the parent of the directory dir.
        /// https://reference.wolfram.com/language/ref/ParentDirectory.html
        ///</summary>
        public static Engine ParentDirectory(this Engine en, string? name = null)
        {
            return en.Execute("ParentDirectory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the NotebookObject that contains obj.
        /// https://reference.wolfram.com/language/ref/ParentNotebook.html
        ///</summary>
        public static Engine ParentNotebook(this Engine en, string? name = null)
        {
            return en.Execute("ParentNotebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the standard Pareto–Pickands distribution with zero location and unit scale parameters.
        /// https://reference.wolfram.com/language/ref/ParetoPickandsDistribution.html
        ///</summary>
        public static Engine ParetoPickandsDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ParetoPickandsDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// counts from the end.
        /// https://reference.wolfram.com/language/ref/Part.html
        ///</summary>
        public static Engine Part(this Engine en, string? name = null)
        {
            return en.Execute("Part[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number p(n) of unrestricted partitions of the integer n.
        /// https://reference.wolfram.com/language/ref/PartitionsP.html
        ///</summary>
        public static Engine PartitionsP(this Engine en, string? name = null)
        {
            return en.Execute("PartitionsP[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number q(n) of partitions of the integer n into distinct parts.
        /// https://reference.wolfram.com/language/ref/PartitionsQ.html
        ///</summary>
        public static Engine PartitionsQ(this Engine en, string? name = null)
        {
            return en.Execute("PartitionsQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net layer that gives the i part of the input.
        /// https://reference.wolfram.com/language/ref/PartLayer.html
        ///</summary>
        public static Engine PartLayer(this Engine en, string? name = null)
        {
            return en.Execute("PartLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the possible parts of speech for the specified word.
        /// https://reference.wolfram.com/language/ref/PartOfSpeech.html
        ///</summary>
        public static Engine PartOfSpeech(this Engine en, string? name = null)
        {
            return en.Execute("PartOfSpeech[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Parzen window function of x.
        /// https://reference.wolfram.com/language/ref/ParzenWindow.html
        ///</summary>
        public static Engine ParzenWindow(this Engine en, string? name = null)
        {
            return en.Execute("ParzenWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// pastes expr at the current insertion point in the input notebook.
        /// https://reference.wolfram.com/language/ref/Paste.html
        ///</summary>
        public static Engine Paste(this Engine en, string? name = null)
        {
            return en.Execute("Paste[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a button that pastes expr whenever it is pressed.
        /// https://reference.wolfram.com/language/ref/PasteButton.html
        ///</summary>
        public static Engine PasteButton(this Engine en, string? name = null)
        {
            return en.Execute("PasteButton[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a path with vertices vi and edges between vi and vi+1 .
        /// https://reference.wolfram.com/language/ref/PathGraph.html
        ///</summary>
        public static Engine PathGraph(this Engine en, string? name = null)
        {
            return en.Execute("PathGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is a path and False otherwise.
        /// https://reference.wolfram.com/language/ref/PathGraphQ.html
        ///</summary>
        public static Engine PathGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("PathGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a two-dimensional graphics directive specifying that obj should be used to fill faces of polygons and other filled graphics objects.
        /// https://reference.wolfram.com/language/ref/PatternFilling.html
        ///</summary>
        public static Engine PatternFilling(this Engine en, string? name = null)
        {
            return en.Execute("PatternFilling[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a templated reaction between molecule patterns in reactants and products.
        /// https://reference.wolfram.com/language/ref/PatternReaction.html
        ///</summary>
        public static Engine PatternReaction(this Engine en, string? name = null)
        {
            return en.Execute("PatternReaction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the k Pauli spin matrix .
        /// https://reference.wolfram.com/language/ref/PauliMatrix.html
        ///</summary>
        public static Engine PauliMatrix(this Engine en, string? name = null)
        {
            return en.Execute("PauliMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Paul wavelet of order n.
        /// https://reference.wolfram.com/language/ref/PaulWavelet.html
        ///</summary>
        public static Engine PaulWavelet(this Engine en, string? name = null)
        {
            return en.Execute("PaulWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// pauses for at least n seconds.
        /// https://reference.wolfram.com/language/ref/Pause.html
        ///</summary>
        public static Engine Pause(this Engine en, string? name = null)
        {
            return en.Execute("Pause[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the PDF as a pure function.
        /// https://reference.wolfram.com/language/ref/PDF.html
        ///</summary>
        public static Engine PDF(this Engine en, string? name = null)
        {
            return en.Execute("PDF[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a binary list in which 1s correspond to peak positions in list.
        /// https://reference.wolfram.com/language/ref/PeakDetect.html
        ///</summary>
        public static Engine PeakDetect(this Engine en, string? name = null)
        {
            return en.Execute("PeakDetect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the line segments representing the n-step Peano curve.
        /// https://reference.wolfram.com/language/ref/PeanoCurve.html
        ///</summary>
        public static Engine PeanoCurve(this Engine en, string? name = null)
        {
            return en.Execute("PeanoCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether data is normally distributed using the Pearson  test.
        /// https://reference.wolfram.com/language/ref/PearsonChiSquareTest.html
        ///</summary>
        public static Engine PearsonChiSquareTest(this Engine en, string? name = null)
        {
            return en.Execute("PearsonChiSquareTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints with numbers in expr given as percentages.
        /// https://reference.wolfram.com/language/ref/PercentForm.html
        ///</summary>
        public static Engine PercentForm(this Engine en, string? name = null)
        {
            return en.Execute("PercentForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n perfect number.
        /// https://reference.wolfram.com/language/ref/PerfectNumber.html
        ///</summary>
        public static Engine PerfectNumber(this Engine en, string? name = null)
        {
            return en.Execute("PerfectNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if n is a perfect number, and False otherwise.
        /// https://reference.wolfram.com/language/ref/PerfectNumberQ.html
        ///</summary>
        public static Engine PerfectNumberQ(this Engine en, string? name = null)
        {
            return en.Execute("PerfectNumberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the perimeter of the two-dimensional region reg.
        /// https://reference.wolfram.com/language/ref/Perimeter.html
        ///</summary>
        public static Engine Perimeter(this Engine en, string? name = null)
        {
            return en.Execute("Perimeter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the squared magnitude of the discrete Fourier transform (power spectrum) of list.
        /// https://reference.wolfram.com/language/ref/Periodogram.html
        ///</summary>
        public static Engine Periodogram(this Engine en, string? name = null)
        {
            return en.Execute("Periodogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the squared magnitude of the discrete Fourier transform (power spectrum) of list.
        /// https://reference.wolfram.com/language/ref/PeriodogramArray.html
        ///</summary>
        public static Engine PeriodogramArray(this Engine en, string? name = null)
        {
            return en.Execute("PeriodogramArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a permissions group with the specified name, owned by the current user.
        /// https://reference.wolfram.com/language/ref/PermissionsGroup.html
        ///</summary>
        public static Engine PermissionsGroup(this Engine en, string? name = null)
        {
            return en.Execute("PermissionsGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a permissions key that can be used to authorize access to cloud resources.
        /// https://reference.wolfram.com/language/ref/PermissionsKey.html
        ///</summary>
        public static Engine PermissionsKey(this Engine en, string? name = null)
        {
            return en.Execute("PermissionsKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a disjoint cycle representation of permutation perm.
        /// https://reference.wolfram.com/language/ref/PermutationCycles.html
        ///</summary>
        public static Engine PermutationCycles(this Engine en, string? name = null)
        {
            return en.Execute("PermutationCycles[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if expr is a permutation in disjoint cyclic form, and False otherwise.
        /// https://reference.wolfram.com/language/ref/PermutationCyclesQ.html
        ///</summary>
        public static Engine PermutationCyclesQ(this Engine en, string? name = null)
        {
            return en.Execute("PermutationCyclesQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the group generated by multiplication of the permutations perm1,…,permn.
        /// https://reference.wolfram.com/language/ref/PermutationGroup.html
        ///</summary>
        public static Engine PermutationGroup(this Engine en, string? name = null)
        {
            return en.Execute("PermutationGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the number of integers moved by the permutation perm.
        /// https://reference.wolfram.com/language/ref/PermutationLength.html
        ///</summary>
        public static Engine PermutationLength(this Engine en, string? name = null)
        {
            return en.Execute("PermutationLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a permutation list representation of permutation perm.
        /// https://reference.wolfram.com/language/ref/PermutationList.html
        ///</summary>
        public static Engine PermutationList(this Engine en, string? name = null)
        {
            return en.Execute("PermutationList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if expr is a valid permutation list and False otherwise.
        /// https://reference.wolfram.com/language/ref/PermutationListQ.html
        ///</summary>
        public static Engine PermutationListQ(this Engine en, string? name = null)
        {
            return en.Execute("PermutationListQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the permutation matrix given by permutation vector permv as a structured array.
        /// https://reference.wolfram.com/language/ref/PermutationMatrix.html
        ///</summary>
        public static Engine PermutationMatrix(this Engine en, string? name = null)
        {
            return en.Execute("PermutationMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the largest integer moved by the permutation perm.
        /// https://reference.wolfram.com/language/ref/PermutationMax.html
        ///</summary>
        public static Engine PermutationMax(this Engine en, string? name = null)
        {
            return en.Execute("PermutationMax[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the smallest integer moved by the permutation perm.
        /// https://reference.wolfram.com/language/ref/PermutationMin.html
        ///</summary>
        public static Engine PermutationMin(this Engine en, string? name = null)
        {
            return en.Execute("PermutationMin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the order of permutation perm.
        /// https://reference.wolfram.com/language/ref/PermutationOrder.html
        ///</summary>
        public static Engine PermutationOrder(this Engine en, string? name = null)
        {
            return en.Execute("PermutationOrder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a list of all possible permutations of the elements in list.
        /// https://reference.wolfram.com/language/ref/Permutations.html
        ///</summary>
        public static Engine Permutations(this Engine en, string? name = null)
        {
            return en.Execute("Permutations[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the support of the permutation perm.
        /// https://reference.wolfram.com/language/ref/PermutationSupport.html
        ///</summary>
        public static Engine PermutationSupport(this Engine en, string? name = null)
        {
            return en.Execute("PermutationSupport[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// applies a Perona–Malik diffusion filter to image.
        /// https://reference.wolfram.com/language/ref/PeronaMalikFilter.html
        ///</summary>
        public static Engine PeronaMalikFilter(this Engine en, string? name = null)
        {
            return en.Execute("PeronaMalikFilter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the perpendicular bisector of the line segment connecting p1 and p2.
        /// https://reference.wolfram.com/language/ref/PerpendicularBisector.html
        ///</summary>
        public static Engine PerpendicularBisector(this Engine en, string? name = null)
        {
            return en.Execute("PerpendicularBisector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a persistence location of the given type.
        /// https://reference.wolfram.com/language/ref/PersistenceLocation.html
        ///</summary>
        public static Engine PersistenceLocation(this Engine en, string? name = null)
        {
            return en.Execute("PersistenceLocation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives all persistent objects whose names match the string pattern patt.
        /// https://reference.wolfram.com/language/ref/PersistentObjects.html
        ///</summary>
        public static Engine PersistentObjects(this Engine en, string? name = null)
        {
            return en.Execute("PersistentObjects[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the persistent symbol associated with the key "name".
        /// https://reference.wolfram.com/language/ref/PersistentSymbol.html
        ///</summary>
        public static Engine PersistentSymbol(this Engine en, string? name = null)
        {
            return en.Execute("PersistentSymbol[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the phase margins of the linear time-invariant system lsys.
        /// https://reference.wolfram.com/language/ref/PhaseMargins.html
        ///</summary>
        public static Engine PhaseMargins(this Engine en, string? name = null)
        {
            return en.Execute("PhaseMargins[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uses the attenuation factor d for the diffuse light.
        /// https://reference.wolfram.com/language/ref/PhongShading.html
        ///</summary>
        public static Engine PhongShading(this Engine en, string? name = null)
        {
            return en.Execute("PhongShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a feedback PID controller for the system sys.
        /// https://reference.wolfram.com/language/ref/PIDTune.html
        ///</summary>
        public static Engine PIDTune(this Engine en, string? name = null)
        {
            return en.Execute("PIDTune[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// expands nested piecewise functions in expr to give a single piecewise function.
        /// https://reference.wolfram.com/language/ref/PiecewiseExpand.html
        ///</summary>
        public static Engine PiecewiseExpand(this Engine en, string? name = null)
        {
            return en.Execute("PiecewiseExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes a pie chart with sector angle proportional to y1, y2, ….
        /// https://reference.wolfram.com/language/ref/PieChart.html
        ///</summary>
        public static Engine PieChart(this Engine en, string? name = null)
        {
            return en.Execute("PieChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes a 3D pie chart with sector angle proportional to y1, y2, … .
        /// https://reference.wolfram.com/language/ref/PieChart3D.html
        ///</summary>
        public static Engine PieChart3D(this Engine en, string? name = null)
        {
            return en.Execute("PieChart3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the round-trip ping time for the specified network host.
        /// https://reference.wolfram.com/language/ref/PingTime.html
        ///</summary>
        public static Engine PingTime(this Engine en, string? name = null)
        {
            return en.Execute("PingTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// recognizes the main pitch in audio, returning it as a TimeSeries object.
        /// https://reference.wolfram.com/language/ref/PitchRecognize.html
        ///</summary>
        public static Engine PitchRecognize(this Engine en, string? name = null)
        {
            return en.Execute("PitchRecognize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a placeholder labeled with name that indicates a place to type.
        /// https://reference.wolfram.com/language/ref/Placeholder.html
        ///</summary>
        public static Engine Placeholder(this Engine en, string? name = null)
        {
            return en.Execute("Placeholder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the angle between the half‐lines from p through q1 and q2.
        /// https://reference.wolfram.com/language/ref/PlanarAngle.html
        ///</summary>
        public static Engine PlanarAngle(this Engine en, string? name = null)
        {
            return en.Execute("PlanarAngle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list of faces of the planar graph g.
        /// https://reference.wolfram.com/language/ref/PlanarFaceList.html
        ///</summary>
        public static Engine PlanarFaceList(this Engine en, string? name = null)
        {
            return en.Execute("PlanarFaceList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a planar graph with edges ej.
        /// https://reference.wolfram.com/language/ref/PlanarGraph.html
        ///</summary>
        public static Engine PlanarGraph(this Engine en, string? name = null)
        {
            return en.Execute("PlanarGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if g is a planar graph and False otherwise.
        /// https://reference.wolfram.com/language/ref/PlanarGraphQ.html
        ///</summary>
        public static Engine PlanarGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("PlanarGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the plural form of the English word "noun".
        /// https://reference.wolfram.com/language/ref/Pluralize.html
        ///</summary>
        public static Engine Pluralize(this Engine en, string? name = null)
        {
            return en.Execute("Pluralize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays as ±x.
        /// https://reference.wolfram.com/language/ref/PlusMinus.html
        ///</summary>
        public static Engine PlusMinus(this Engine en, string? name = null)
        {
            return en.Execute("PlusMinus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics and geometry primitive that represents a point at p.
        /// https://reference.wolfram.com/language/ref/Point.html
        ///</summary>
        public static Engine Point(this Engine en, string? name = null)
        {
            return en.Execute("Point[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// estimates the point density function  from point data pdata.
        /// https://reference.wolfram.com/language/ref/PointDensity.html
        ///</summary>
        public static Engine PointDensity(this Engine en, string? name = null)
        {
            return en.Execute("PointDensity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a function whose values give the density at a given location.
        /// https://reference.wolfram.com/language/ref/PointDensityFunction.html
        ///</summary>
        public static Engine PointDensityFunction(this Engine en, string? name = null)
        {
            return en.Execute("PointDensityFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes a point and figure chart of closing prices for the financial entity "name" over the date range daterange.
        /// https://reference.wolfram.com/language/ref/PointFigureChart.html
        ///</summary>
        public static Engine PointFigureChart(this Engine en, string? name = null)
        {
            return en.Execute("PointFigureChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a legend with inherited colors within visualization functions.
        /// https://reference.wolfram.com/language/ref/PointLegend.html
        ///</summary>
        public static Engine PointLegend(this Engine en, string? name = null)
        {
            return en.Execute("PointLegend[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the point collection pdata could be modeled by a Poisson point process.
        /// https://reference.wolfram.com/language/ref/PointProcessFitTest.html
        ///</summary>
        public static Engine PointProcessFitTest(this Engine en, string? name = null)
        {
            return en.Execute("PointProcessFitTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a logical expression for assumptions on parameters in the point process proc.
        /// https://reference.wolfram.com/language/ref/PointProcessParameterAssumptions.html
        ///</summary>
        public static Engine PointProcessParameterAssumptions(this Engine en, string? name = null)
        {
            return en.Execute("PointProcessParameterAssumptions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if proc is a valid random point process, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/PointProcessParameterQ.html
        ///</summary>
        public static Engine PointProcessParameterQ(this Engine en, string? name = null)
        {
            return en.Execute("PointProcessParameterQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive which specifies that points which follow are to be shown if possible as circular regions with diameter d. The diameter d is given as a fraction of the total width of the plot.
        /// https://reference.wolfram.com/language/ref/PointSize.html
        ///</summary>
        public static Engine PointSize(this Engine en, string? name = null)
        {
            return en.Execute("PointSize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a function whose values give the statistic of a points collection pdata at a supplied radius.
        /// https://reference.wolfram.com/language/ref/PointStatisticFunction.html
        ///</summary>
        public static Engine PointStatisticFunction(this Engine en, string? name = null)
        {
            return en.Execute("PointStatisticFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the points pti styled according to the values vali.
        /// https://reference.wolfram.com/language/ref/PointValuePlot.html
        ///</summary>
        public static Engine PointValuePlot(this Engine en, string? name = null)
        {
            return en.Execute("PointValuePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Poisson distribution with mean μ.
        /// https://reference.wolfram.com/language/ref/PoissonDistribution.html
        ///</summary>
        public static Engine PoissonDistribution(this Engine en, string? name = null)
        {
            return en.Execute("PoissonDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Poisson process with rate μ.
        /// https://reference.wolfram.com/language/ref/PoissonProcess.html
        ///</summary>
        public static Engine PoissonProcess(this Engine en, string? name = null)
        {
            return en.Execute("PoissonProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Poisson window function of x.
        /// https://reference.wolfram.com/language/ref/PoissonWindow.html
        ///</summary>
        public static Engine PoissonWindow(this Engine en, string? name = null)
        {
            return en.Execute("PoissonWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the digamma function .
        /// https://reference.wolfram.com/language/ref/PolyGamma.html
        ///</summary>
        public static Engine PolyGamma(this Engine en, string? name = null)
        {
            return en.Execute("PolyGamma[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a filled polygon with points pi.
        /// https://reference.wolfram.com/language/ref/Polygon.html
        ///</summary>
        public static Engine Polygon(this Engine en, string? name = null)
        {
            return en.Execute("Polygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n triangular number .
        /// https://reference.wolfram.com/language/ref/PolygonalNumber.html
        ///</summary>
        public static Engine PolygonalNumber(this Engine en, string? name = null)
        {
            return en.Execute("PolygonalNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of angles at the vertex points of poly.
        /// https://reference.wolfram.com/language/ref/PolygonAngle.html
        ///</summary>
        public static Engine PolygonAngle(this Engine en, string? name = null)
        {
            return en.Execute("PolygonAngle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of coordinates in the polygon poly.
        /// https://reference.wolfram.com/language/ref/PolygonCoordinates.html
        ///</summary>
        public static Engine PolygonCoordinates(this Engine en, string? name = null)
        {
            return en.Execute("PolygonCoordinates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// decomposes the polygon poly into a disjoint union of simpler polygons.
        /// https://reference.wolfram.com/language/ref/PolygonDecomposition.html
        ///</summary>
        public static Engine PolygonDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("PolygonDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a filled polyhedron inside the closed surfaces with polygon faces fi.
        /// https://reference.wolfram.com/language/ref/Polyhedron.html
        ///</summary>
        public static Engine Polyhedron(this Engine en, string? name = null)
        {
            return en.Execute("Polyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of coordinates in the polyhedron poly.
        /// https://reference.wolfram.com/language/ref/PolyhedronCoordinates.html
        ///</summary>
        public static Engine PolyhedronCoordinates(this Engine en, string? name = null)
        {
            return en.Execute("PolyhedronCoordinates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an image of the polyhedron named poly.
        /// https://reference.wolfram.com/language/ref/PolyhedronData.html
        ///</summary>
        public static Engine PolyhedronData(this Engine en, string? name = null)
        {
            return en.Execute("PolyhedronData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// decomposes the polyhedron poly into a union of simpler polyhedra.
        /// https://reference.wolfram.com/language/ref/PolyhedronDecomposition.html
        ///</summary>
        public static Engine PolyhedronDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("PolyhedronDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a pooling net layer using kernels of size sz.
        /// https://reference.wolfram.com/language/ref/PoolingLayer.html
        ///</summary>
        public static Engine PoolingLayer(this Engine en, string? name = null)
        {
            return en.Execute("PoolingLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an object which displays as a popup menu whose items are the expri.
        /// https://reference.wolfram.com/language/ref/PopupView.html
        ///</summary>
        public static Engine PopupView(this Engine en, string? name = null)
        {
            return en.Execute("PopupView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of Position that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/Position.html
        ///</summary>
        public static Engine Position(this Engine en, string? name = null)
        {
            return en.Execute("Position[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an association between unique elements in list and the positions at which they occur.
        /// https://reference.wolfram.com/language/ref/PositionIndex.html
        ///</summary>
        public static Engine PositionIndex(this Engine en, string? name = null)
        {
            return en.Execute("PositionIndex[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if x is a positive number.
        /// https://reference.wolfram.com/language/ref/Positive.html
        ///</summary>
        public static Engine Positive(this Engine en, string? name = null)
        {
            return en.Execute("Positive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is explicitly positive definite, and False otherwise.
        /// https://reference.wolfram.com/language/ref/PositiveDefiniteMatrixQ.html
        ///</summary>
        public static Engine PositiveDefiniteMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("PositiveDefiniteMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the sequence of points p1,p2,p3,…,pd+1 is positively oriented.
        /// https://reference.wolfram.com/language/ref/PositivelyOrientedPoints.html
        ///</summary>
        public static Engine PositivelyOrientedPoints(this Engine en, string? name = null)
        {
            return en.Execute("PositivelyOrientedPoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is explicitly positive semidefinite, and False otherwise.
        /// https://reference.wolfram.com/language/ref/PositiveSemidefiniteMatrixQ.html
        ///</summary>
        public static Engine PositiveSemidefiniteMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("PositiveSemidefiniteMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if basic symbolic and numerical methods suggest that expr has value zero, and gives False otherwise.
        /// https://reference.wolfram.com/language/ref/PossibleZeroQ.html
        ///</summary>
        public static Engine PossibleZeroQ(this Engine en, string? name = null)
        {
            return en.Execute("PossibleZeroQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints with f[expr] given in default postfix form: expr//f.
        /// https://reference.wolfram.com/language/ref/Postfix.html
        ///</summary>
        public static Engine Postfix(this Engine en, string? name = null)
        {
            return en.Execute("Postfix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// expands all powers of products and powers.
        /// https://reference.wolfram.com/language/ref/PowerExpand.html
        ///</summary>
        public static Engine PowerExpand(this Engine en, string? name = null)
        {
            return en.Execute("PowerExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates the list {1,10,100,…,max}, where max is the largest power of 10 that does not exceed b.
        /// https://reference.wolfram.com/language/ref/PowerRange.html
        ///</summary>
        public static Engine PowerRange(this Engine en, string? name = null)
        {
            return en.Execute("PowerRange[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a formal power symmetric polynomial with exponent r.
        /// https://reference.wolfram.com/language/ref/PowerSymmetricPolynomial.html
        ///</summary>
        public static Engine PowerSymmetricPolynomial(this Engine en, string? name = null)
        {
            return en.Execute("PowerSymmetricPolynomial[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the effective number of digits of precision in the number x.
        /// https://reference.wolfram.com/language/ref/Precision.html
        ///</summary>
        public static Engine Precision(this Engine en, string? name = null)
        {
            return en.Execute("Precision[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a PredictorFunction[…] based on the example input-output pairs given.
        /// https://reference.wolfram.com/language/ref/Predict.html
        ///</summary>
        public static Engine Predict(this Engine en, string? name = null)
        {
            return en.Execute("Predict[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a function generated by Predict that predicts numerical values from data.
        /// https://reference.wolfram.com/language/ref/PredictorFunction.html
        ///</summary>
        public static Engine PredictorFunction(this Engine en, string? name = null)
        {
            return en.Execute("PredictorFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an object generated by PredictorMeasurements that can be applied to properties.
        /// https://reference.wolfram.com/language/ref/PredictorMeasurementsObject.html
        ///</summary>
        public static Engine PredictorMeasurementsObject(this Engine en, string? name = null)
        {
            return en.Execute("PredictorMeasurementsObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates expr, without any interruption from preemptive evaluations.
        /// https://reference.wolfram.com/language/ref/PreemptProtect.html
        ///</summary>
        public static Engine PreemptProtect(this Engine en, string? name = null)
        {
            return en.Execute("PreemptProtect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints with f[expr] given in default prefix form: f@expr.
        /// https://reference.wolfram.com/language/ref/Prefix.html
        ///</summary>
        public static Engine Prefix(this Engine en, string? name = null)
        {
            return en.Execute("Prefix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of Prepend that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/Prepend.html
        ///</summary>
        public static Engine Prepend(this Engine en, string? name = null)
        {
            return en.Execute("Prepend[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// starts looking from the given cell.
        /// https://reference.wolfram.com/language/ref/PreviousCell.html
        ///</summary>
        public static Engine PreviousCell(this Engine en, string? name = null)
        {
            return en.Execute("PreviousCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the previously occurring date of the specified granularity type gran.
        /// https://reference.wolfram.com/language/ref/PreviousDate.html
        ///</summary>
        public static Engine PreviousDate(this Engine en, string? name = null)
        {
            return en.Execute("PreviousDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the nprime number .
        /// https://reference.wolfram.com/language/ref/Prime.html
        ///</summary>
        public static Engine Prime(this Engine en, string? name = null)
        {
            return en.Execute("Prime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of distinct primes  in n.
        /// https://reference.wolfram.com/language/ref/PrimeNu.html
        ///</summary>
        public static Engine PrimeNu(this Engine en, string? name = null)
        {
            return en.Execute("PrimeNu[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of prime factors counting multiplicities  in n.
        /// https://reference.wolfram.com/language/ref/PrimeOmega.html
        ///</summary>
        public static Engine PrimeOmega(this Engine en, string? name = null)
        {
            return en.Execute("PrimeOmega[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of primes  less than or equal to x.
        /// https://reference.wolfram.com/language/ref/PrimePi.html
        ///</summary>
        public static Engine PrimePi(this Engine en, string? name = null)
        {
            return en.Execute("PrimePi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if expr is a power of a prime number, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/PrimePowerQ.html
        ///</summary>
        public static Engine PrimePowerQ(this Engine en, string? name = null)
        {
            return en.Execute("PrimePowerQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if n is a prime number, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/PrimeQ.html
        ///</summary>
        public static Engine PrimeQ(this Engine en, string? name = null)
        {
            return en.Execute("PrimeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives prime zeta function .
        /// https://reference.wolfram.com/language/ref/PrimeZetaP.html
        ///</summary>
        public static Engine PrimeZetaP(this Engine en, string? name = null)
        {
            return en.Execute("PrimeZetaP[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a primitive root of n.
        /// https://reference.wolfram.com/language/ref/PrimitiveRoot.html
        ///</summary>
        public static Engine PrimitiveRoot(this Engine en, string? name = null)
        {
            return en.Execute("PrimitiveRoot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of primitive roots of n.
        /// https://reference.wolfram.com/language/ref/PrimitiveRootList.html
        ///</summary>
        public static Engine PrimitiveRootList(this Engine en, string? name = null)
        {
            return en.Execute("PrimitiveRootList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// transforms elements of matrix into unscaled principal components.
        /// https://reference.wolfram.com/language/ref/PrincipalComponents.html
        ///</summary>
        public static Engine PrincipalComponents(this Engine en, string? name = null)
        {
            return en.Execute("PrincipalComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints expr as output.
        /// https://reference.wolfram.com/language/ref/Print.html
        ///</summary>
        public static Engine Print(this Engine en, string? name = null)
        {
            return en.Execute("Print[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the string contains only printable ASCII characters, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/PrintableASCIIQ.html
        ///</summary>
        public static Engine PrintableASCIIQ(this Engine en, string? name = null)
        {
            return en.Execute("PrintableASCIIQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints out the 3D model using a 3D print previewer.
        /// https://reference.wolfram.com/language/ref/Printout3D.html
        ///</summary>
        public static Engine Printout3D(this Engine en, string? name = null)
        {
            return en.Execute("Printout3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints expr as a temporary cell in a notebook, removing it when the evaluation of the current input line is complete.
        /// https://reference.wolfram.com/language/ref/PrintTemporary.html
        ///</summary>
        public static Engine PrintTemporary(this Engine en, string? name = null)
        {
            return en.Execute("PrintTemporary[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a filled prism connecting the triangles {p1,p2,p3} and {p4,p5,p6}.
        /// https://reference.wolfram.com/language/ref/Prism.html
        ///</summary>
        public static Engine Prism(this Engine en, string? name = null)
        {
            return en.Execute("Prism[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the private part of a key pair for a public-key cryptographic system.
        /// https://reference.wolfram.com/language/ref/PrivateKey.html
        ///</summary>
        public static Engine PrivateKey(this Engine en, string? name = null)
        {
            return en.Execute("PrivateKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a plot of the CDF of list against the CDF of a normal distribution.
        /// https://reference.wolfram.com/language/ref/ProbabilityPlot.html
        ///</summary>
        public static Engine ProbabilityPlot(this Engine en, string? name = null)
        {
            return en.Execute("ProbabilityPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a normal probability plot of the samples xi.
        /// https://reference.wolfram.com/language/ref/ProbabilityScalePlot.html
        ///</summary>
        public static Engine ProbabilityScalePlot(this Engine en, string? name = null)
        {
            return en.Execute("ProbabilityScalePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// constructs a binomial probit regression model from the design matrix m and response vector v.
        /// https://reference.wolfram.com/language/ref/ProbitModelFit.html
        ///</summary>
        public static Engine ProbitModelFit(this Engine en, string? name = null)
        {
            return en.Execute("ProbitModelFit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives information about an external process proc.
        /// https://reference.wolfram.com/language/ref/ProcessInformation.html
        ///</summary>
        public static Engine ProcessInformation(this Engine en, string? name = null)
        {
            return en.Execute("ProcessInformation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an object that represents a runnable external process.
        /// https://reference.wolfram.com/language/ref/ProcessObject.html
        ///</summary>
        public static Engine ProcessObject(this Engine en, string? name = null)
        {
            return en.Execute("ProcessObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a logical expression for assumptions on parameters in the random process proc.
        /// https://reference.wolfram.com/language/ref/ProcessParameterAssumptions.html
        ///</summary>
        public static Engine ProcessParameterAssumptions(this Engine en, string? name = null)
        {
            return en.Execute("ProcessParameterAssumptions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if proc is a valid random process, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/ProcessParameterQ.html
        ///</summary>
        public static Engine ProcessParameterQ(this Engine en, string? name = null)
        {
            return en.Execute("ProcessParameterQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the current status of the external process represented by the ProcessObject proc.
        /// https://reference.wolfram.com/language/ref/ProcessStatus.html
        ///</summary>
        public static Engine ProcessStatus(this Engine en, string? name = null)
        {
            return en.Execute("ProcessStatus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the principal solution for w in .
        /// https://reference.wolfram.com/language/ref/ProductLog.html
        ///</summary>
        public static Engine ProductLog(this Engine en, string? name = null)
        {
            return en.Execute("ProductLog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a progress indicator with setting x in the range 0 to 1.
        /// https://reference.wolfram.com/language/ref/ProgressIndicator.html
        ///</summary>
        public static Engine ProgressIndicator(this Engine en, string? name = null)
        {
            return en.Execute("ProgressIndicator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a proof object generated by FindEquationalProof.
        /// https://reference.wolfram.com/language/ref/ProofObject.html
        ///</summary>
        public static Engine ProofObject(this Engine en, string? name = null)
        {
            return en.Execute("ProofObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// protects any symbols that are equal to or match any of the speci.
        /// https://reference.wolfram.com/language/ref/Protect.html
        ///</summary>
        public static Engine Protect(this Engine en, string? name = null)
        {
            return en.Execute("Protect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the reference amino acid sequence for the protein entity.
        /// https://reference.wolfram.com/language/ref/ProteinData.html
        ///</summary>
        public static Engine ProteinData(this Engine en, string? name = null)
        {
            return en.Execute("ProteinData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// removes the outermost branches of thin objects in image by setting their values to black.
        /// https://reference.wolfram.com/language/ref/Pruning.html
        ///</summary>
        public static Engine Pruning(this Engine en, string? name = null)
        {
            return en.Execute("Pruning[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds the pseudoinverse of a rectangular matrix.
        /// https://reference.wolfram.com/language/ref/PseudoInverse.html
        ///</summary>
        public static Engine PseudoInverse(this Engine en, string? name = null)
        {
            return en.Execute("PseudoInverse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the psychrometric properties of moist air for the specified parameters.
        /// https://reference.wolfram.com/language/ref/PsychrometricPropertyData.html
        ///</summary>
        public static Engine PsychrometricPropertyData(this Engine en, string? name = null)
        {
            return en.Execute("PsychrometricPropertyData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the public part of a key pair for a public-key cryptographic system.
        /// https://reference.wolfram.com/language/ref/PublicKey.html
        ///</summary>
        public static Engine PublicKey(this Engine en, string? name = null)
        {
            return en.Execute("PublicKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a filled pyramid with base {p1,…,p4} and top p5.
        /// https://reference.wolfram.com/language/ref/Pyramid.html
        ///</summary>
        public static Engine Pyramid(this Engine en, string? name = null)
        {
            return en.Execute("Pyramid[" + en.ValidNames.Last() + "]", name);
        }


    }
}
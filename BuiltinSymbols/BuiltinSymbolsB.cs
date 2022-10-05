namespace NetWolf
{
    public static class BuiltinSymbolB
    {
        ///<summary>
        ///converts the Boolean expression expr to disjunctive normal form.
        ///https://reference.wolfram.com/language/ref/BooleanConvert.html
        ///</summary>
        public static Engine BooleanConvert(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BooleanConvert[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts the Boolean expression expr to disjunctive normal form.
        ///https://reference.wolfram.com/language/ref/BooleanConvert.html
        ///</summary>
        public static Engine BooleanConvert(this Engine en, string? name = null)
        {
            return en.Execute("BooleanConvert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a binary representation of any expression expr as a ByteArray object.
        ///https://reference.wolfram.com/language/ref/BinarySerialize.html
        ///</summary>
        public static Engine BinarySerialize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinarySerialize[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a binary representation of any expression expr as a ByteArray object.
        ///https://reference.wolfram.com/language/ref/BinarySerialize.html
        ///</summary>
        public static Engine BinarySerialize(this Engine en, string? name = null)
        {
            return en.Execute("BinarySerialize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///counts the number of elements xi whose values lie in successive integer bins.
        ///https://reference.wolfram.com/language/ref/BinCounts.html
        ///</summary>
        public static Engine BinCounts(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinCounts[" + arg0 + "]", name);
        }

        ///<summary>
        ///counts the number of elements xi whose values lie in successive integer bins.
        ///https://reference.wolfram.com/language/ref/BinCounts.html
        ///</summary>
        public static Engine BinCounts(this Engine en, string? name = null)
        {
            return en.Execute("BinCounts[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads all remaining bytes from a file, and returns them as a list of integers from 0 to 255. 
        ///https://reference.wolfram.com/language/ref/BinaryReadList.html
        ///</summary>
        public static Engine BinaryReadList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinaryReadList[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads all remaining bytes from a file, and returns them as a list of integers from 0 to 255. 
        ///https://reference.wolfram.com/language/ref/BinaryReadList.html
        ///</summary>
        public static Engine BinaryReadList(this Engine en, string? name = null)
        {
            return en.Execute("BinaryReadList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Boolean combination bfunc of regions reg1, reg2, ….
        ///https://reference.wolfram.com/language/ref/BooleanRegion.html
        ///</summary>
        public static Engine BooleanRegion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BooleanRegion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies a bandpass filter with cutoff frequencies ω1 and ω2 to an array of data.
        ///https://reference.wolfram.com/language/ref/BandpassFilter.html
        ///</summary>
        public static Engine BandpassFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BandpassFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes a variogram using binned values. 
        ///https://reference.wolfram.com/language/ref/BinnedVariogramList.html
        ///</summary>
        public static Engine BinnedVariogramList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinnedVariogramList[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes a variogram using binned values. 
        ///https://reference.wolfram.com/language/ref/BinnedVariogramList.html
        ///</summary>
        public static Engine BinnedVariogramList(this Engine en, string? name = null)
        {
            return en.Execute("BinnedVariogramList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of bonds in the molecule mol.
        ///https://reference.wolfram.com/language/ref/BondList.html
        ///</summary>
        public static Engine BondList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BondList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of bonds in the molecule mol.
        ///https://reference.wolfram.com/language/ref/BondList.html
        ///</summary>
        public static Engine BondList(this Engine en, string? name = null)
        {
            return en.Execute("BondList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///biologically complements and reverses the sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceReverseComplement.html
        ///</summary>
        public static Engine BioSequenceReverseComplement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BioSequenceReverseComplement[" + arg0 + "]", name);
        }

        ///<summary>
        ///biologically complements and reverses the sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceReverseComplement.html
        ///</summary>
        public static Engine BioSequenceReverseComplement(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceReverseComplement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields 1 if expr is True and 0 if it is False. 
        ///https://reference.wolfram.com/language/ref/Boole.html
        ///</summary>
        public static Engine Boole(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Boole[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields 1 if expr is True and 0 if it is False. 
        ///https://reference.wolfram.com/language/ref/Boole.html
        ///</summary>
        public static Engine Boole(this Engine en, string? name = null)
        {
            return en.Execute("Boole[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple baby monster group .
        ///https://reference.wolfram.com/language/ref/BabyMonsterGroupB.html
        ///</summary>
        public static Engine BabyMonsterGroupB(this Engine en, string? name = null)
        {
            return en.Execute("BabyMonsterGroupB[]", name);
        }

        ///<summary>
        ///represents the biomolecular sequence of the given type corresponding to a string "seq".
        ///https://reference.wolfram.com/language/ref/BioSequence.html
        ///</summary>
        public static Engine BioSequence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BioSequence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a legend that identifies colors from the color function cf with an automatic range of values.
        ///https://reference.wolfram.com/language/ref/BarLegend.html
        ///</summary>
        public static Engine BarLegend(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BarLegend[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a legend that identifies colors from the color function cf with an automatic range of values.
        ///https://reference.wolfram.com/language/ref/BarLegend.html
        ///</summary>
        public static Engine BarLegend(this Engine en, string? name = null)
        {
            return en.Execute("BarLegend[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Boolean function of n variables that gives True if k consecutive variables are True.
        ///https://reference.wolfram.com/language/ref/BooleanConsecutiveFunction.html
        ///</summary>
        public static Engine BooleanConsecutiveFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BooleanConsecutiveFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Boolean function of n variables that gives True if at most kmax variables are True.
        ///https://reference.wolfram.com/language/ref/BooleanCountingFunction.html
        ///</summary>
        public static Engine BooleanCountingFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BooleanCountingFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of truth values for all possible combinations of variable values supplied to the Boolean function bf.
        ///https://reference.wolfram.com/language/ref/BooleanTable.html
        ///</summary>
        public static Engine BooleanTable(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BooleanTable[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of truth values for all possible combinations of variable values supplied to the Boolean function bf.
        ///https://reference.wolfram.com/language/ref/BooleanTable.html
        ///</summary>
        public static Engine BooleanTable(this Engine en, string? name = null)
        {
            return en.Execute("BooleanTable[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Borel–Tanner distribution with shape parameters α and n.
        ///https://reference.wolfram.com/language/ref/BorelTannerDistribution.html
        ///</summary>
        public static Engine BorelTannerDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BorelTannerDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the k Boolean function in n variables.
        ///https://reference.wolfram.com/language/ref/BooleanFunction.html
        ///</summary>
        public static Engine BooleanFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BooleanFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///discretizes a 2D or 3D graphic g into a BoundaryMeshRegion.
        ///https://reference.wolfram.com/language/ref/BoundaryDiscretizeGraphics.html
        ///</summary>
        public static Engine BoundaryDiscretizeGraphics(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoundaryDiscretizeGraphics[" + arg0 + "]", name);
        }

        ///<summary>
        ///discretizes a 2D or 3D graphic g into a BoundaryMeshRegion.
        ///https://reference.wolfram.com/language/ref/BoundaryDiscretizeGraphics.html
        ///</summary>
        public static Engine BoundaryDiscretizeGraphics(this Engine en, string? name = null)
        {
            return en.Execute("BoundaryDiscretizeGraphics[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the biological complement of the sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceComplement.html
        ///</summary>
        public static Engine BioSequenceComplement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BioSequenceComplement[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the biological complement of the sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceComplement.html
        ///</summary>
        public static Engine BioSequenceComplement(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceComplement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a bipartite graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/BipartiteGraphQ.html
        ///</summary>
        public static Engine BipartiteGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BipartiteGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a bipartite graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/BipartiteGraphQ.html
        ///</summary>
        public static Engine BipartiteGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("BipartiteGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Boolean graph defined by the Boolean function bfunc on the graphs g1, …, gn.
        ///https://reference.wolfram.com/language/ref/BooleanGraph.html
        ///</summary>
        public static Engine BooleanGraph(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("BooleanGraph[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///yields True if the region reg is a valid BoundaryMeshRegion object and False otherwise.
        ///https://reference.wolfram.com/language/ref/BoundaryMeshRegionQ.html
        ///</summary>
        public static Engine BoundaryMeshRegionQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoundaryMeshRegionQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the region reg is a valid BoundaryMeshRegion object and False otherwise.
        ///https://reference.wolfram.com/language/ref/BoundaryMeshRegionQ.html
        ///</summary>
        public static Engine BoundaryMeshRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("BoundaryMeshRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a mesh with boundary cells bcellj, where coordinates given as integer i are taken to be pi, where the cells together represent a closed curve, surface, etc.
        ///https://reference.wolfram.com/language/ref/BoundaryMeshRegion.html
        ///</summary>
        public static Engine BoundaryMeshRegion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BoundaryMeshRegion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the result of a Bayesian minimization process. 
        ///https://reference.wolfram.com/language/ref/BayesianMinimizationObject.html
        ///</summary>
        public static Engine BayesianMinimizationObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BayesianMinimizationObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the result of a Bayesian minimization process. 
        ///https://reference.wolfram.com/language/ref/BayesianMinimizationObject.html
        ///</summary>
        public static Engine BayesianMinimizationObject(this Engine en, string? name = null)
        {
            return en.Execute("BayesianMinimizationObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the result of a Bayesian maximization process.
        ///https://reference.wolfram.com/language/ref/BayesianMaximizationObject.html
        ///</summary>
        public static Engine BayesianMaximizationObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BayesianMaximizationObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the result of a Bayesian maximization process.
        ///https://reference.wolfram.com/language/ref/BayesianMaximizationObject.html
        ///</summary>
        public static Engine BayesianMaximizationObject(this Engine en, string? name = null)
        {
            return en.Execute("BayesianMaximizationObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a  matrix of s.
        ///https://reference.wolfram.com/language/ref/BoxMatrix.html
        ///</summary>
        public static Engine BoxMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoxMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a  matrix of s.
        ///https://reference.wolfram.com/language/ref/BoxMatrix.html
        ///</summary>
        public static Engine BoxMatrix(this Engine en, string? name = null)
        {
            return en.Execute("BoxMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the binary distance between vectors u and v, equal to 0 if they are identical and 1 otherwise.
        ///https://reference.wolfram.com/language/ref/BinaryDistance.html
        ///</summary>
        public static Engine BinaryDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BinaryDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies a bandstop filter with cutoff frequencies ω1 and ω2 to an array of data.
        ///https://reference.wolfram.com/language/ref/BandstopFilter.html
        ///</summary>
        public static Engine BandstopFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BandstopFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the bitwise NOT of the integer n. 
        ///https://reference.wolfram.com/language/ref/BitNot.html
        ///</summary>
        public static Engine BitNot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BitNot[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the bitwise NOT of the integer n. 
        ///https://reference.wolfram.com/language/ref/BitNot.html
        ///</summary>
        public static Engine BitNot(this Engine en, string? name = null)
        {
            return en.Execute("BitNot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Bartlett window function of x.
        ///https://reference.wolfram.com/language/ref/BartlettWindow.html
        ///</summary>
        public static Engine BartlettWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BartlettWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Bartlett window function of x.
        ///https://reference.wolfram.com/language/ref/BartlettWindow.html
        ///</summary>
        public static Engine BartlettWindow(this Engine en, string? name = null)
        {
            return en.Execute("BartlettWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a trainable recurrent layer that takes a sequence of vectors and produces a sequence of vectors each of size n.
        ///https://reference.wolfram.com/language/ref/BasicRecurrentLayer.html
        ///</summary>
        public static Engine BasicRecurrentLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BasicRecurrentLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a trainable recurrent layer that takes a sequence of vectors and produces a sequence of vectors each of size n.
        ///https://reference.wolfram.com/language/ref/BasicRecurrentLayer.html
        ///</summary>
        public static Engine BasicRecurrentLayer(this Engine en, string? name = null)
        {
            return en.Execute("BasicRecurrentLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the Boolean variables in the Boolean expression expr.
        ///https://reference.wolfram.com/language/ref/BooleanVariables.html
        ///</summary>
        public static Engine BooleanVariables(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BooleanVariables[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the Boolean variables in the Boolean expression expr.
        ///https://reference.wolfram.com/language/ref/BooleanVariables.html
        ///</summary>
        public static Engine BooleanVariables(this Engine en, string? name = null)
        {
            return en.Execute("BooleanVariables[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the sequence of positions on the diagonal band that starts with {i,j} in a sparse array.
        ///https://reference.wolfram.com/language/ref/Band.html
        ///</summary>
        public static Engine Band(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Band[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the sequence of positions on the diagonal band that starts with {i,j} in a sparse array.
        ///https://reference.wolfram.com/language/ref/Band.html
        ///</summary>
        public static Engine Band(this Engine en, string? name = null)
        {
            return en.Execute("Band[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Barabasi–Albert graph distribution for n-vertex graphs where a new vertex with k edges is added at each step.
        ///https://reference.wolfram.com/language/ref/BarabasiAlbertGraphDistribution.html
        ///</summary>
        public static Engine BarabasiAlbertGraphDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BarabasiAlbertGraphDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets to 0 the bit corresponding to the coefficient of  in the integer n. 
        ///https://reference.wolfram.com/language/ref/BitClear.html
        ///</summary>
        public static Engine BitClear(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BitClear[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets to 1 the bit corresponding to the coefficient of  in the integer n. 
        ///https://reference.wolfram.com/language/ref/BitSet.html
        ///</summary>
        public static Engine BitSet(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BitSet[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Because.html
        ///</summary>
        public static Engine Because(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Because[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the broadcast station entity.
        ///https://reference.wolfram.com/language/ref/BroadcastStationData.html
        ///</summary>
        public static Engine BroadcastStationData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BroadcastStationData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the unit ball centered at the point p.
        ///https://reference.wolfram.com/language/ref/Ball.html
        ///</summary>
        public static Engine Ball(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Ball[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the unit ball centered at the point p.
        ///https://reference.wolfram.com/language/ref/Ball.html
        ///</summary>
        public static Engine Ball(this Engine en, string? name = null)
        {
            return en.Execute("Ball[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a biorthogonal spline wavelet of order 4 and dual order 2.
        ///https://reference.wolfram.com/language/ref/BiorthogonalSplineWavelet.html
        ///</summary>
        public static Engine BiorthogonalSplineWavelet(this Engine en, string? name = null)
        {
            return en.Execute("BiorthogonalSplineWavelet[]", name);
        }

        ///<summary>
        ///represents a Blackman–Nuttall window function of x.
        ///https://reference.wolfram.com/language/ref/BlackmanNuttallWindow.html
        ///</summary>
        public static Engine BlackmanNuttallWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlackmanNuttallWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Blackman–Nuttall window function of x.
        ///https://reference.wolfram.com/language/ref/BlackmanNuttallWindow.html
        ///</summary>
        public static Engine BlackmanNuttallWindow(this Engine en, string? name = null)
        {
            return en.Execute("BlackmanNuttallWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a two-dimensional schematic diagram of the biomolecular sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequencePlot.html
        ///</summary>
        public static Engine BioSequencePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BioSequencePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a two-dimensional schematic diagram of the biomolecular sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequencePlot.html
        ///</summary>
        public static Engine BioSequencePlot(this Engine en, string? name = null)
        {
            return en.Execute("BioSequencePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Birnbaum–Saunders distribution with shape parameter α and scale parameter λ.
        ///https://reference.wolfram.com/language/ref/BirnbaumSaundersDistribution.html
        ///</summary>
        public static Engine BirnbaumSaundersDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BirnbaumSaundersDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the bitwise OR of the integers ni. 
        ///https://reference.wolfram.com/language/ref/BitOr.html
        ///</summary>
        public static Engine BitOr(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BitOr[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields True if image has the form of a binary Image or Image3D object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/BinaryImageQ.html
        ///</summary>
        public static Engine BinaryImageQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinaryImageQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if image has the form of a binary Image or Image3D object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/BinaryImageQ.html
        ///</summary>
        public static Engine BinaryImageQ(this Engine en, string? name = null)
        {
            return en.Execute("BinaryImageQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints with the numbers in expr given in base n. 
        ///https://reference.wolfram.com/language/ref/BaseForm.html
        ///</summary>
        public static Engine BaseForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BaseForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Birnbaum importances for all components in the ReliabilityDistribution rdist at time t.
        ///https://reference.wolfram.com/language/ref/BirnbaumImportance.html
        ///</summary>
        public static Engine BirnbaumImportance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BirnbaumImportance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///exits the nearest enclosing Do, For, or While. 
        ///https://reference.wolfram.com/language/ref/Break.html
        ///</summary>
        public static Engine Break(this Engine en, string? name = null)
        {
            return en.Execute("Break[]", name);
        }

        ///<summary>
        ///gives the bitwise AND of the integers ni. 
        ///https://reference.wolfram.com/language/ref/BitAnd.html
        ///</summary>
        public static Engine BitAnd(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BitAnd[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the Brownian bridge process from value a at time t1 to value b at time t2 with volatility σ.
        ///https://reference.wolfram.com/language/ref/BrownianBridgeProcess.html
        ///</summary>
        public static Engine BrownianBridgeProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BrownianBridgeProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///creates a lowpass biquadratic filter using the characteristic frequency ω and the quality factor q.
        ///https://reference.wolfram.com/language/ref/BiquadraticFilterModel.html
        ///</summary>
        public static Engine BiquadraticFilterModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BiquadraticFilterModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a lowpass biquadratic filter using the characteristic frequency ω and the quality factor q.
        ///https://reference.wolfram.com/language/ref/BiquadraticFilterModel.html
        ///</summary>
        public static Engine BiquadraticFilterModel(this Engine en, string? name = null)
        {
            return en.Execute("BiquadraticFilterModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Benktander distribution of type I with parameters a and b.
        ///https://reference.wolfram.com/language/ref/BenktanderGibratDistribution.html
        ///</summary>
        public static Engine BenktanderGibratDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BenktanderGibratDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives lists of the elements xi whose values lie in successive integer bins.
        ///https://reference.wolfram.com/language/ref/BinLists.html
        ///</summary>
        public static Engine BinLists(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinLists[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives lists of the elements xi whose values lie in successive integer bins.
        ///https://reference.wolfram.com/language/ref/BinLists.html
        ///</summary>
        public static Engine BinLists(this Engine en, string? name = null)
        {
            return en.Execute("BinLists[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Benford distribution with base parameter b.
        ///https://reference.wolfram.com/language/ref/BenfordDistribution.html
        ///</summary>
        public static Engine BenfordDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BenfordDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Benford distribution with base parameter b.
        ///https://reference.wolfram.com/language/ref/BenfordDistribution.html
        ///</summary>
        public static Engine BenfordDistribution(this Engine en, string? name = null)
        {
            return en.Execute("BenfordDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a bar chart with bar lengths y1,  y2, ….
        ///https://reference.wolfram.com/language/ref/BarChart.html
        ///</summary>
        public static Engine BarChart(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BarChart[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a bar chart with bar lengths y1,  y2, ….
        ///https://reference.wolfram.com/language/ref/BarChart.html
        ///</summary>
        public static Engine BarChart(this Engine en, string? name = null)
        {
            return en.Execute("BarChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level representation of the contents of a typesetting cell.
        ///https://reference.wolfram.com/language/ref/BoxData.html
        ///</summary>
        public static Engine BoxData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoxData[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level representation of the contents of a typesetting cell.
        ///https://reference.wolfram.com/language/ref/BoxData.html
        ///</summary>
        public static Engine BoxData(this Engine en, string? name = null)
        {
            return en.Execute("BoxData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Bernoulli distribution with probability parameter p.
        ///https://reference.wolfram.com/language/ref/BernoulliDistribution.html
        ///</summary>
        public static Engine BernoulliDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BernoulliDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Bernoulli distribution with probability parameter p.
        ///https://reference.wolfram.com/language/ref/BernoulliDistribution.html
        ///</summary>
        public static Engine BernoulliDistribution(this Engine en, string? name = null)
        {
            return en.Execute("BernoulliDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a graphics primitive that represents a nonuniform rational B-spline curve with control points pti.
        ///https://reference.wolfram.com/language/ref/BSplineCurve.html
        ///</summary>
        public static Engine BSplineCurve(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BSplineCurve[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a graphics primitive that represents a nonuniform rational B-spline curve with control points pti.
        ///https://reference.wolfram.com/language/ref/BSplineCurve.html
        ///</summary>
        public static Engine BSplineCurve(this Engine en, string? name = null)
        {
            return en.Execute("BSplineCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a color obtained by blending a fraction  of color col1 and  of color col2.
        ///https://reference.wolfram.com/language/ref/Blend.html
        ///</summary>
        public static Engine Blend(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Blend[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///writes a byte of data, specified as an integer from 0 to 255. 
        ///https://reference.wolfram.com/language/ref/BinaryWrite.html
        ///</summary>
        public static Engine BinaryWrite(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BinaryWrite[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an object that represents a box structure in an open notebook in the front end.
        ///https://reference.wolfram.com/language/ref/BoxObject.html
        ///</summary>
        public static Engine BoxObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoxObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that represents a box structure in an open notebook in the front end.
        ///https://reference.wolfram.com/language/ref/BoxObject.html
        ///</summary>
        public static Engine BoxObject(this Engine en, string? name = null)
        {
            return en.Execute("BoxObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///applies a bilateral filter of spatial spread σ and pixel value spread μ to data.
        ///https://reference.wolfram.com/language/ref/BilateralFilter.html
        ///</summary>
        public static Engine BilateralFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BilateralFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///expands the possibly degenerate sequence bioseq into all fully specified corresponding sequences.
        ///https://reference.wolfram.com/language/ref/BioSequenceInstances.html
        ///</summary>
        public static Engine BioSequenceInstances(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BioSequenceInstances[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands the possibly degenerate sequence bioseq into all fully specified corresponding sequences.
        ///https://reference.wolfram.com/language/ref/BioSequenceInstances.html
        ///</summary>
        public static Engine BioSequenceInstances(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceInstances[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes context` and System` the only active contexts. 
        ///https://reference.wolfram.com/language/ref/BeginPackage.html
        ///</summary>
        public static Engine BeginPackage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BeginPackage[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes context` and System` the only active contexts. 
        ///https://reference.wolfram.com/language/ref/BeginPackage.html
        ///</summary>
        public static Engine BeginPackage(this Engine en, string? name = null)
        {
            return en.Execute("BeginPackage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a graphics primitive that represents a nonuniform rational B-spline surface defined by an array of  control points.
        ///https://reference.wolfram.com/language/ref/BSplineSurface.html
        ///</summary>
        public static Engine BSplineSurface(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BSplineSurface[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a graphics primitive that represents a nonuniform rational B-spline surface defined by an array of  control points.
        ///https://reference.wolfram.com/language/ref/BSplineSurface.html
        ///</summary>
        public static Engine BSplineSurface(this Engine en, string? name = null)
        {
            return en.Execute("BSplineSurface[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives available information connected with the specified address on the default blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainAddressData.html
        ///</summary>
        public static Engine BlockchainAddressData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainAddressData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives available information connected with the specified address on the default blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainAddressData.html
        ///</summary>
        public static Engine BlockchainAddressData(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainAddressData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Bernoulli number . 
        ///https://reference.wolfram.com/language/ref/BernoulliB.html
        ///</summary>
        public static Engine BernoulliB(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BernoulliB[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Bernoulli number . 
        ///https://reference.wolfram.com/language/ref/BernoulliB.html
        ///</summary>
        public static Engine BernoulliB(this Engine en, string? name = null)
        {
            return en.Execute("BernoulliB[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Barnes G-function .
        ///https://reference.wolfram.com/language/ref/BarnesG.html
        ///</summary>
        public static Engine BarnesG(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BarnesG[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Barnes G-function .
        ///https://reference.wolfram.com/language/ref/BarnesG.html
        ///</summary>
        public static Engine BarnesG(this Engine en, string? name = null)
        {
            return en.Execute("BarnesG[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Battle–Lemarié wavelet of order 3.
        ///https://reference.wolfram.com/language/ref/BattleLemarieWavelet.html
        ///</summary>
        public static Engine BattleLemarieWavelet(this Engine en, string? name = null)
        {
            return en.Execute("BattleLemarieWavelet[]", name);
        }

        ///<summary>
        ///gives the binomial coefficient .
        ///https://reference.wolfram.com/language/ref/Binomial.html
        ///</summary>
        public static Engine Binomial(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Binomial[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a button that is labeled with label, and evaluates action whenever it is clicked. 
        ///https://reference.wolfram.com/language/ref/Button.html
        ///</summary>
        public static Engine Button(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Button[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the regularized incomplete beta function . 
        ///https://reference.wolfram.com/language/ref/BetaRegularized.html
        ///</summary>
        public static Engine BetaRegularized(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BetaRegularized[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Blackman window function of x.
        ///https://reference.wolfram.com/language/ref/BlackmanWindow.html
        ///</summary>
        public static Engine BlackmanWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlackmanWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Blackman window function of x.
        ///https://reference.wolfram.com/language/ref/BlackmanWindow.html
        ///</summary>
        public static Engine BlackmanWindow(this Engine en, string? name = null)
        {
            return en.Execute("BlackmanWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///specifies that expr is to be evaluated with local values for the symbols x, y, …. 
        ///https://reference.wolfram.com/language/ref/Block.html
        ///</summary>
        public static Engine Block(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Block[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Beckmann distribution with means μ1 and μ2 and standard deviations σ1 and σ2.
        ///https://reference.wolfram.com/language/ref/BeckmannDistribution.html
        ///</summary>
        public static Engine BeckmannDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("BeckmannDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives True if bond is a bond in the molecule m, and False otherwise.
        ///https://reference.wolfram.com/language/ref/BondQ.html
        ///</summary>
        public static Engine BondQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BondQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the minimal axis-aligned bounding box for the points pt1, pt2, ….
        ///https://reference.wolfram.com/language/ref/BoundingRegion.html
        ///</summary>
        public static Engine BoundingRegion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoundingRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the minimal axis-aligned bounding box for the points pt1, pt2, ….
        ///https://reference.wolfram.com/language/ref/BoundingRegion.html
        ///</summary>
        public static Engine BoundingRegion(this Engine en, string? name = null)
        {
            return en.Execute("BoundingRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if reg is a bounded region and False otherwise. 
        ///https://reference.wolfram.com/language/ref/BoundedRegionQ.html
        ///</summary>
        public static Engine BoundedRegionQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoundedRegionQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if reg is a bounded region and False otherwise. 
        ///https://reference.wolfram.com/language/ref/BoundedRegionQ.html
        ///</summary>
        public static Engine BoundedRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("BoundedRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gets the bit corresponding to the coefficient of  in the integer n. 
        ///https://reference.wolfram.com/language/ref/BitGet.html
        ///</summary>
        public static Engine BitGet(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BitGet[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the pixel width of uniform borders of image in the form {{left,right},{bottom,top}}.
        ///https://reference.wolfram.com/language/ref/BorderDimensions.html
        ///</summary>
        public static Engine BorderDimensions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BorderDimensions[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the pixel width of uniform borders of image in the form {{left,right},{bottom,top}}.
        ///https://reference.wolfram.com/language/ref/BorderDimensions.html
        ///</summary>
        public static Engine BorderDimensions(this Engine en, string? name = null)
        {
            return en.Execute("BorderDimensions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is equivalent to min≤x≤max.
        ///https://reference.wolfram.com/language/ref/Between.html
        ///</summary>
        public static Engine Between(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Between[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Bohman window function of x.
        ///https://reference.wolfram.com/language/ref/BohmanWindow.html
        ///</summary>
        public static Engine BohmanWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BohmanWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Bohman window function of x.
        ///https://reference.wolfram.com/language/ref/BohmanWindow.html
        ///</summary>
        public static Engine BohmanWindow(this Engine en, string? name = null)
        {
            return en.Execute("BohmanWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Backslash.html
        ///</summary>
        public static Engine Backslash(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Backslash[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///shifts the binary bits in the integer n to the left by k places, padding with zeros on the right.
        ///https://reference.wolfram.com/language/ref/BitShiftLeft.html
        ///</summary>
        public static Engine BitShiftLeft(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BitShiftLeft[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the zeroth uniform B-spline basis function of degree d at x.
        ///https://reference.wolfram.com/language/ref/BSplineBasis.html
        ///</summary>
        public static Engine BSplineBasis(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BSplineBasis[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Bernoulli graph distribution for n-vertex graphs with edge probability p.
        ///https://reference.wolfram.com/language/ref/BernoulliGraphDistribution.html
        ///</summary>
        public static Engine BernoulliGraphDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BernoulliGraphDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///decodes the Base64 data contained in a string and returns the result as a byte array.
        ///https://reference.wolfram.com/language/ref/BaseDecode.html
        ///</summary>
        public static Engine BaseDecode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BaseDecode[" + arg0 + "]", name);
        }

        ///<summary>
        ///decodes the Base64 data contained in a string and returns the result as a byte array.
        ///https://reference.wolfram.com/language/ref/BaseDecode.html
        ///</summary>
        public static Engine BaseDecode(this Engine en, string? name = null)
        {
            return en.Execute("BaseDecode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a B-spline function for a curve defined by the control points pti.
        ///https://reference.wolfram.com/language/ref/BSplineFunction.html
        ///</summary>
        public static Engine BSplineFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BSplineFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a B-spline function for a curve defined by the control points pti.
        ///https://reference.wolfram.com/language/ref/BSplineFunction.html
        ///</summary>
        public static Engine BSplineFunction(this Engine en, string? name = null)
        {
            return en.Execute("BSplineFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the distribution of a mean of n random variables uniformly distributed from 0 to 1.
        ///https://reference.wolfram.com/language/ref/BatesDistribution.html
        ///</summary>
        public static Engine BatesDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BatesDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the distribution of a mean of n random variables uniformly distributed from 0 to 1.
        ///https://reference.wolfram.com/language/ref/BatesDistribution.html
        ///</summary>
        public static Engine BatesDistribution(this Engine en, string? name = null)
        {
            return en.Execute("BatesDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///transcribes DNA into RNA or inverts the transcription of RNA back to DNA for the sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceTranscribe.html
        ///</summary>
        public static Engine BioSequenceTranscribe(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BioSequenceTranscribe[" + arg0 + "]", name);
        }

        ///<summary>
        ///transcribes DNA into RNA or inverts the transcription of RNA back to DNA for the sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceTranscribe.html
        ///</summary>
        public static Engine BioSequenceTranscribe(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceTranscribe[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the generalized back translations of a peptide sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceBackTranslateList.html
        ///</summary>
        public static Engine BioSequenceBackTranslateList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BioSequenceBackTranslateList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generalized back translations of a peptide sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceBackTranslateList.html
        ///</summary>
        public static Engine BioSequenceBackTranslateList(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceBackTranslateList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the modified Bessel function of the second kind . 
        ///https://reference.wolfram.com/language/ref/BesselK.html
        ///</summary>
        public static Engine BesselK(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BesselK[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the variance of data is 1. 
        ///https://reference.wolfram.com/language/ref/BrownForsytheTest.html
        ///</summary>
        public static Engine BrownForsytheTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BrownForsytheTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the variance of data is 1. 
        ///https://reference.wolfram.com/language/ref/BrownForsytheTest.html
        ///</summary>
        public static Engine BrownForsytheTest(this Engine en, string? name = null)
        {
            return en.Execute("BrownForsytheTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Euler beta function . 
        ///https://reference.wolfram.com/language/ref/Beta.html
        ///</summary>
        public static Engine Beta(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Beta[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Bartlett–Hann window function of x.
        ///https://reference.wolfram.com/language/ref/BartlettHannWindow.html
        ///</summary>
        public static Engine BartlettHannWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BartlettHannWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Bartlett–Hann window function of x.
        ///https://reference.wolfram.com/language/ref/BartlettHannWindow.html
        ///</summary>
        public static Engine BartlettHannWindow(this Engine en, string? name = null)
        {
            return en.Execute("BartlettHannWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the bridge entity.
        ///https://reference.wolfram.com/language/ref/BridgeData.html
        ///</summary>
        public static Engine BridgeData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BridgeData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the k maxterm in n variables.
        ///https://reference.wolfram.com/language/ref/BooleanMaxterms.html
        ///</summary>
        public static Engine BooleanMaxterms(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BooleanMaxterms[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a trainable net layer that normalizes its input data by learning the data mean and variance.
        ///https://reference.wolfram.com/language/ref/BatchNormalizationLayer.html
        ///</summary>
        public static Engine BatchNormalizationLayer(this Engine en, string? name = null)
        {
            return en.Execute("BatchNormalizationLayer[]", name);
        }

        ///<summary>
        ///estimates Besag's  function  for point data pdata at radius r.
        ///https://reference.wolfram.com/language/ref/BesagL.html
        ///</summary>
        public static Engine BesagL(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BesagL[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Bell number . 
        ///https://reference.wolfram.com/language/ref/BellB.html
        ///</summary>
        public static Engine BellB(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BellB[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Bell number . 
        ///https://reference.wolfram.com/language/ref/BellB.html
        ///</summary>
        public static Engine BellB(this Engine en, string? name = null)
        {
            return en.Execute("BellB[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the ByteArray object ba might be imported as format "fmt" and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/ByteArrayFormatQ.html
        ///</summary>
        public static Engine ByteArrayFormatQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ByteArrayFormatQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives information about the blockchain specified by $BlockchainBase.
        ///https://reference.wolfram.com/language/ref/BlockchainData.html
        ///</summary>
        public static Engine BlockchainData(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainData[]", name);
        }

        ///<summary>
        ///reads one byte of raw binary data from an input stream, and returns an integer from 0 to 255. 
        ///https://reference.wolfram.com/language/ref/BinaryRead.html
        ///</summary>
        public static Engine BinaryRead(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinaryRead[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads one byte of raw binary data from an input stream, and returns an integer from 0 to 255. 
        ///https://reference.wolfram.com/language/ref/BinaryRead.html
        ///</summary>
        public static Engine BinaryRead(this Engine en, string? name = null)
        {
            return en.Execute("BinaryRead[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if bioseq is a valid BioSequence expression, and False otherwise.
        ///https://reference.wolfram.com/language/ref/BioSequenceQ.html
        ///</summary>
        public static Engine BioSequenceQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BioSequenceQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if bioseq is a valid BioSequence expression, and False otherwise.
        ///https://reference.wolfram.com/language/ref/BioSequenceQ.html
        ///</summary>
        public static Engine BioSequenceQ(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Benini distribution with shape parameters α and β and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/BeniniDistribution.html
        ///</summary>
        public static Engine BeniniDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BeniniDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives an object representing the result of Bayesian maximization over the function f over the configurations confi.
        ///https://reference.wolfram.com/language/ref/BayesianMaximization.html
        ///</summary>
        public static Engine BayesianMaximization(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BayesianMaximization[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///submits the transaction specified in the BlockchainTransaction object obj to a blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainTransactionSubmit.html
        ///</summary>
        public static Engine BlockchainTransactionSubmit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainTransactionSubmit[" + arg0 + "]", name);
        }

        ///<summary>
        ///submits the transaction specified in the BlockchainTransaction object obj to a blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainTransactionSubmit.html
        ///</summary>
        public static Engine BlockchainTransactionSubmit(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainTransactionSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the block upper triangular matrix umat as a structured array.
        ///https://reference.wolfram.com/language/ref/BlockUpperTriangularMatrix.html
        ///</summary>
        public static Engine BlockUpperTriangularMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockUpperTriangularMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the block upper triangular matrix umat as a structured array.
        ///https://reference.wolfram.com/language/ref/BlockUpperTriangularMatrix.html
        ///</summary>
        public static Engine BlockUpperTriangularMatrix(this Engine en, string? name = null)
        {
            return en.Execute("BlockUpperTriangularMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives Blomqvist's medial correlation coefficient β for the vectors v1 and v2.
        ///https://reference.wolfram.com/language/ref/BlomqvistBeta.html
        ///</summary>
        public static Engine BlomqvistBeta(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BlomqvistBeta[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes a box‐and‐whisker chart for the values xi.
        ///https://reference.wolfram.com/language/ref/BoxWhiskerChart.html
        ///</summary>
        public static Engine BoxWhiskerChart(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoxWhiskerChart[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a box‐and‐whisker chart for the values xi.
        ///https://reference.wolfram.com/language/ref/BoxWhiskerChart.html
        ///</summary>
        public static Engine BoxWhiskerChart(this Engine en, string? name = null)
        {
            return en.Execute("BoxWhiskerChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a 3D bar chart with bar lengths y1, y2, … .
        ///https://reference.wolfram.com/language/ref/BarChart3D.html
        ///</summary>
        public static Engine BarChart3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BarChart3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a 3D bar chart with bar lengths y1, y2, … .
        ///https://reference.wolfram.com/language/ref/BarChart3D.html
        ///</summary>
        public static Engine BarChart3D(this Engine en, string? name = null)
        {
            return en.Execute("BarChart3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a blockchain transaction built from the components in the association assoc.
        ///https://reference.wolfram.com/language/ref/BlockchainTransaction.html
        ///</summary>
        public static Engine BlockchainTransaction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainTransaction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a blockchain transaction built from the components in the association assoc.
        ///https://reference.wolfram.com/language/ref/BlockchainTransaction.html
        ///</summary>
        public static Engine BlockchainTransaction(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainTransaction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the result of applying the modification "mod" to the sequence seq.
        ///https://reference.wolfram.com/language/ref/BioSequenceModify.html
        ///</summary>
        public static Engine BioSequenceModify(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BioSequenceModify[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Benktander distribution of type II with parameters a and b.
        ///https://reference.wolfram.com/language/ref/BenktanderWeibullDistribution.html
        ///</summary>
        public static Engine BenktanderWeibullDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BenktanderWeibullDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///discretizes the region reg into a BoundaryMeshRegion.
        ///https://reference.wolfram.com/language/ref/BoundaryDiscretizeRegion.html
        ///</summary>
        public static Engine BoundaryDiscretizeRegion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoundaryDiscretizeRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///discretizes the region reg into a BoundaryMeshRegion.
        ///https://reference.wolfram.com/language/ref/BoundaryDiscretizeRegion.html
        ///</summary>
        public static Engine BoundaryDiscretizeRegion(this Engine en, string? name = null)
        {
            return en.Execute("BoundaryDiscretizeRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Barlow–Proschan importances for all components in the ReliabilityDistribution rdist. 
        ///https://reference.wolfram.com/language/ref/BarlowProschanImportance.html
        ///</summary>
        public static Engine BarlowProschanImportance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BarlowProschanImportance[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Barlow–Proschan importances for all components in the ReliabilityDistribution rdist. 
        ///https://reference.wolfram.com/language/ref/BarlowProschanImportance.html
        ///</summary>
        public static Engine BarlowProschanImportance(this Engine en, string? name = null)
        {
            return en.Execute("BarlowProschanImportance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the bilateral Laplace transform of expr. 
        ///https://reference.wolfram.com/language/ref/BilateralLaplaceTransform.html
        ///</summary>
        public static Engine BilateralLaplaceTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BilateralLaplaceTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Blackman–Harris window function of x.
        ///https://reference.wolfram.com/language/ref/BlackmanHarrisWindow.html
        ///</summary>
        public static Engine BlackmanHarrisWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlackmanHarrisWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Blackman–Harris window function of x.
        ///https://reference.wolfram.com/language/ref/BlackmanHarrisWindow.html
        ///</summary>
        public static Engine BlackmanHarrisWindow(this Engine en, string? name = null)
        {
            return en.Execute("BlackmanHarrisWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of binary bits necessary to represent the integer n. 
        ///https://reference.wolfram.com/language/ref/BitLength.html
        ///</summary>
        public static Engine BitLength(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BitLength[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of binary bits necessary to represent the integer n. 
        ///https://reference.wolfram.com/language/ref/BitLength.html
        ///</summary>
        public static Engine BitLength(this Engine en, string? name = null)
        {
            return en.Execute("BitLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the morphological bottom-hat transform of image with respect to structuring element ker.
        ///https://reference.wolfram.com/language/ref/BottomHatTransform.html
        ///</summary>
        public static Engine BottomHatTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BottomHatTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates an audible beep when evaluated. 
        ///https://reference.wolfram.com/language/ref/Beep.html
        ///</summary>
        public static Engine Beep(this Engine en, string? name = null)
        {
            return en.Execute("Beep[]", name);
        }

        ///<summary>
        ///represents a bar of buttons with labels lbli that perform actions acti when pressed.
        ///https://reference.wolfram.com/language/ref/ButtonBar.html
        ///</summary>
        public static Engine ButtonBar(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ButtonBar[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a bar of buttons with labels lbli that perform actions acti when pressed.
        ///https://reference.wolfram.com/language/ref/ButtonBar.html
        ///</summary>
        public static Engine ButtonBar(this Engine en, string? name = null)
        {
            return en.Execute("ButtonBar[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///encodes the byte array ba as a Base64 string.
        ///https://reference.wolfram.com/language/ref/BaseEncode.html
        ///</summary>
        public static Engine BaseEncode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BaseEncode[" + arg0 + "]", name);
        }

        ///<summary>
        ///encodes the byte array ba as a Base64 string.
        ///https://reference.wolfram.com/language/ref/BaseEncode.html
        ///</summary>
        public static Engine BaseEncode(this Engine en, string? name = null)
        {
            return en.Execute("BaseEncode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a bubble chart with bubbles at positions {xi,yi} with sizes zi.
        ///https://reference.wolfram.com/language/ref/BubbleChart.html
        ///</summary>
        public static Engine BubbleChart(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BubbleChart[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the notebook, if any, that contains the button which initiated the current evaluation. 
        ///https://reference.wolfram.com/language/ref/ButtonNotebook.html
        ///</summary>
        public static Engine ButtonNotebook(this Engine en, string? name = null)
        {
            return en.Execute("ButtonNotebook[]", name);
        }

        ///<summary>
        ///shifts the binary bits in the integer n to the right by k places, dropping bits that are shifted past the unit's position on the right.  
        ///https://reference.wolfram.com/language/ref/BitShiftRight.html
        ///</summary>
        public static Engine BitShiftRight(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BitShiftRight[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a valid ByteArray object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/ByteArrayQ.html
        ///</summary>
        public static Engine ByteArrayQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ByteArrayQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a valid ByteArray object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/ByteArrayQ.html
        ///</summary>
        public static Engine ByteArrayQ(this Engine en, string? name = null)
        {
            return en.Execute("ByteArrayQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///designs a lowpass Bessel filter of order n and cutoff frequency 1.
        ///https://reference.wolfram.com/language/ref/BesselFilterModel.html
        ///</summary>
        public static Engine BesselFilterModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BesselFilterModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///designs a lowpass Bessel filter of order n and cutoff frequency 1.
        ///https://reference.wolfram.com/language/ref/BesselFilterModel.html
        ///</summary>
        public static Engine BesselFilterModel(this Engine en, string? name = null)
        {
            return en.Execute("BesselFilterModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///adjusts the brightness across image, correcting uneven illumination.
        ///https://reference.wolfram.com/language/ref/BrightnessEqualize.html
        ///</summary>
        public static Engine BrightnessEqualize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BrightnessEqualize[" + arg0 + "]", name);
        }

        ///<summary>
        ///adjusts the brightness across image, correcting uneven illumination.
        ///https://reference.wolfram.com/language/ref/BrightnessEqualize.html
        ///</summary>
        public static Engine BrightnessEqualize(this Engine en, string? name = null)
        {
            return en.Execute("BrightnessEqualize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the order-n butterfly graph. 
        ///https://reference.wolfram.com/language/ref/ButterflyGraph.html
        ///</summary>
        public static Engine ButterflyGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ButterflyGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the order-n butterfly graph. 
        ///https://reference.wolfram.com/language/ref/ButterflyGraph.html
        ///</summary>
        public static Engine ButterflyGraph(this Engine en, string? name = null)
        {
            return en.Execute("ButterflyGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a beta binomial mixture distribution with beta distribution parameters  and , and  binomial trials.
        ///https://reference.wolfram.com/language/ref/BetaBinomialDistribution.html
        ///</summary>
        public static Engine BetaBinomialDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BetaBinomialDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///translates a DNA or RNA sequence bioseq to a peptide sequence.
        ///https://reference.wolfram.com/language/ref/BioSequenceTranslate.html
        ///</summary>
        public static Engine BioSequenceTranslate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BioSequenceTranslate[" + arg0 + "]", name);
        }

        ///<summary>
        ///translates a DNA or RNA sequence bioseq to a peptide sequence.
        ///https://reference.wolfram.com/language/ref/BioSequenceTranslate.html
        ///</summary>
        public static Engine BioSequenceTranslate(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceTranslate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a binomial distribution with n trials and success probability p.
        ///https://reference.wolfram.com/language/ref/BinomialDistribution.html
        ///</summary>
        public static Engine BinomialDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BinomialDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///retrieves data from the Wolfram blockchain for the transaction with the specified ID.
        ///https://reference.wolfram.com/language/ref/BlockchainGet.html
        ///</summary>
        public static Engine BlockchainGet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainGet[" + arg0 + "]", name);
        }

        ///<summary>
        ///retrieves data from the Wolfram blockchain for the transaction with the specified ID.
        ///https://reference.wolfram.com/language/ref/BlockchainGet.html
        ///</summary>
        public static Engine BlockchainGet(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainGet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of betweenness centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/BetweennessCentrality.html
        ///</summary>
        public static Engine BetweennessCentrality(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BetweennessCentrality[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of betweenness centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/BetweennessCentrality.html
        ///</summary>
        public static Engine BetweennessCentrality(this Engine en, string? name = null)
        {
            return en.Execute("BetweennessCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a minimal-length disjunctive normal form representation of expr.
        ///https://reference.wolfram.com/language/ref/BooleanMinimize.html
        ///</summary>
        public static Engine BooleanMinimize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BooleanMinimize[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a minimal-length disjunctive normal form representation of expr.
        ///https://reference.wolfram.com/language/ref/BooleanMinimize.html
        ///</summary>
        public static Engine BooleanMinimize(this Engine en, string? name = null)
        {
            return en.Execute("BooleanMinimize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a BoundaryMeshRegion from a MeshRegion mreg. 
        ///https://reference.wolfram.com/language/ref/BoundaryMesh.html
        ///</summary>
        public static Engine BoundaryMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BoundaryMesh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a BoundaryMeshRegion from a MeshRegion mreg. 
        ///https://reference.wolfram.com/language/ref/BoundaryMesh.html
        ///</summary>
        public static Engine BoundaryMesh(this Engine en, string? name = null)
        {
            return en.Execute("BoundaryMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the partial Bell polynomial .
        ///https://reference.wolfram.com/language/ref/BellY.html
        ///</summary>
        public static Engine BellY(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BellY[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the bilateral Z transform of expr.
        ///https://reference.wolfram.com/language/ref/BilateralZTransform.html
        ///</summary>
        public static Engine BilateralZTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BilateralZTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Bernoulli process with event probability p.
        ///https://reference.wolfram.com/language/ref/BernoulliProcess.html
        ///</summary>
        public static Engine BernoulliProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BernoulliProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Bernoulli process with event probability p.
        ///https://reference.wolfram.com/language/ref/BernoulliProcess.html
        ///</summary>
        public static Engine BernoulliProcess(this Engine en, string? name = null)
        {
            return en.Execute("BernoulliProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Bessel function of the second kind . 
        ///https://reference.wolfram.com/language/ref/BesselY.html
        ///</summary>
        public static Engine BesselY(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BesselY[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a barcode image of "string" in the specified format.
        ///https://reference.wolfram.com/language/ref/BarcodeImage.html
        ///</summary>
        public static Engine BarcodeImage(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BarcodeImage[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a single chemical bond between atoms with indices idi and idj.
        ///https://reference.wolfram.com/language/ref/Bond.html
        ///</summary>
        public static Engine Bond(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Bond[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a single chemical bond between atoms with indices idi and idj.
        ///https://reference.wolfram.com/language/ref/Bond.html
        ///</summary>
        public static Engine Bond(this Engine en, string? name = null)
        {
            return en.Execute("Bond[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the vectors v1 and v2 are independent.
        ///https://reference.wolfram.com/language/ref/BlomqvistBetaTest.html
        ///</summary>
        public static Engine BlomqvistBetaTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BlomqvistBetaTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives information about the block with the specified hash on the blockchain specified by $BlockchainBase.
        ///https://reference.wolfram.com/language/ref/BlockchainBlockData.html
        ///</summary>
        public static Engine BlockchainBlockData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainBlockData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives information about the block with the specified hash on the blockchain specified by $BlockchainBase.
        ///https://reference.wolfram.com/language/ref/BlockchainBlockData.html
        ///</summary>
        public static Engine BlockchainBlockData(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainBlockData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives information about the blockchain transaction with ID txid on the blockchain specified by $BlockchainBase.
        ///https://reference.wolfram.com/language/ref/BlockchainTransactionData.html
        ///</summary>
        public static Engine BlockchainTransactionData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainTransactionData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives information about the blockchain transaction with ID txid on the blockchain specified by $BlockchainBase.
        ///https://reference.wolfram.com/language/ref/BlockchainTransactionData.html
        ///</summary>
        public static Engine BlockchainTransactionData(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainTransactionData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the block diagonal matrix with diagonal blocks di as a structured array.
        ///https://reference.wolfram.com/language/ref/BlockDiagonalMatrix.html
        ///</summary>
        public static Engine BlockDiagonalMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockDiagonalMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the block diagonal matrix with diagonal blocks di as a structured array.
        ///https://reference.wolfram.com/language/ref/BlockDiagonalMatrix.html
        ///</summary>
        public static Engine BlockDiagonalMatrix(this Engine en, string? name = null)
        {
            return en.Execute("BlockDiagonalMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a string by decoding the data in the byte array ba, assuming UTF-8 encoding.
        ///https://reference.wolfram.com/language/ref/ByteArrayToString.html
        ///</summary>
        public static Engine ByteArrayToString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ByteArrayToString[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a string by decoding the data in the byte array ba, assuming UTF-8 encoding.
        ///https://reference.wolfram.com/language/ref/ByteArrayToString.html
        ///</summary>
        public static Engine ByteArrayToString(this Engine en, string? name = null)
        {
            return en.Execute("ByteArrayToString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as x,y,….
        ///https://reference.wolfram.com/language/ref/BracketingBar.html
        ///</summary>
        public static Engine BracketingBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BracketingBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a button in a notebook expression.
        ///https://reference.wolfram.com/language/ref/ButtonBox.html
        ///</summary>
        public static Engine ButtonBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ButtonBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a button in a notebook expression.
        ///https://reference.wolfram.com/language/ref/ButtonBox.html
        ///</summary>
        public static Engine ButtonBox(this Engine en, string? name = null)
        {
            return en.Execute("ButtonBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a binomial point process with n points in the region reg.
        ///https://reference.wolfram.com/language/ref/BinomialPointProcess.html
        ///</summary>
        public static Engine BinomialPointProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BinomialPointProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes a 3D bubble chart with bubbles at positions {xi,yi,zi} with sizes ui.
        ///https://reference.wolfram.com/language/ref/BubbleChart3D.html
        ///</summary>
        public static Engine BubbleChart3D(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BubbleChart3D[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the beveled polyhedron of poly, by beveling each edge. 
        ///https://reference.wolfram.com/language/ref/BeveledPolyhedron.html
        ///</summary>
        public static Engine BeveledPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BeveledPolyhedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the beveled polyhedron of poly, by beveling each edge. 
        ///https://reference.wolfram.com/language/ref/BeveledPolyhedron.html
        ///</summary>
        public static Engine BeveledPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("BeveledPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a lowpass Butterworth filter of order n and cutoff frequency of 1.
        ///https://reference.wolfram.com/language/ref/ButterworthFilterModel.html
        ///</summary>
        public static Engine ButterworthFilterModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ButterworthFilterModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a lowpass Butterworth filter of order n and cutoff frequency of 1.
        ///https://reference.wolfram.com/language/ref/ButterworthFilterModel.html
        ///</summary>
        public static Engine ButterworthFilterModel(this Engine en, string? name = null)
        {
            return en.Execute("ButterworthFilterModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the buckyball graph.
        ///https://reference.wolfram.com/language/ref/BuckyballGraph.html
        ///</summary>
        public static Engine BuckyballGraph(this Engine en, string? name = null)
        {
            return en.Execute("BuckyballGraph[]", name);
        }

        ///<summary>
        ///creates a binary image from image by replacing all values above a globally determined threshold with 1 and others with 0.
        ///https://reference.wolfram.com/language/ref/Binarize.html
        ///</summary>
        public static Engine Binarize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Binarize[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a binary image from image by replacing all values above a globally determined threshold with 1 and others with 0.
        ///https://reference.wolfram.com/language/ref/Binarize.html
        ///</summary>
        public static Engine Binarize(this Engine en, string? name = null)
        {
            return en.Execute("Binarize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the k minterm in n variables.
        ///https://reference.wolfram.com/language/ref/BooleanMinterms.html
        ///</summary>
        public static Engine BooleanMinterms(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BooleanMinterms[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the k zero of the Bessel function of the second kind .
        ///https://reference.wolfram.com/language/ref/BesselYZero.html
        ///</summary>
        public static Engine BesselYZero(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BesselYZero[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the n Bernstein basis function of degree d at x.
        ///https://reference.wolfram.com/language/ref/BernsteinBasis.html
        ///</summary>
        public static Engine BernsteinBasis(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BernsteinBasis[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a continuous beta distribution with shape parameters α and β.
        ///https://reference.wolfram.com/language/ref/BetaDistribution.html
        ///</summary>
        public static Engine BetaDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BetaDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the number of bonds in the molecule mol.
        ///https://reference.wolfram.com/language/ref/BondCount.html
        ///</summary>
        public static Engine BondCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BondCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of bonds in the molecule mol.
        ///https://reference.wolfram.com/language/ref/BondCount.html
        ///</summary>
        public static Engine BondCount(this Engine en, string? name = null)
        {
            return en.Execute("BondCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the bitwise XOR of the integers ni. 
        ///https://reference.wolfram.com/language/ref/BitXor.html
        ///</summary>
        public static Engine BitXor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BitXor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the modified Bessel function of the first kind . 
        ///https://reference.wolfram.com/language/ref/BesselI.html
        ///</summary>
        public static Engine BesselI(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BesselI[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///recognizes a barcode in image and returns it as a string.
        ///https://reference.wolfram.com/language/ref/BarcodeRecognize.html
        ///</summary>
        public static Engine BarcodeRecognize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BarcodeRecognize[" + arg0 + "]", name);
        }

        ///<summary>
        ///recognizes a barcode in image and returns it as a string.
        ///https://reference.wolfram.com/language/ref/BarcodeRecognize.html
        ///</summary>
        public static Engine BarcodeRecognize(this Engine en, string? name = null)
        {
            return en.Execute("BarcodeRecognize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///digitally signs a blockchain transaction using the specified private key.
        ///https://reference.wolfram.com/language/ref/BlockchainTransactionSign.html
        ///</summary>
        public static Engine BlockchainTransactionSign(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BlockchainTransactionSign[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gets the result obtained from a Wolfram expression contract at blockchain address caddr.
        ///https://reference.wolfram.com/language/ref/BlockchainContractValue.html
        ///</summary>
        public static Engine BlockchainContractValue(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainContractValue[" + arg0 + "]", name);
        }

        ///<summary>
        ///gets the result obtained from a Wolfram expression contract at blockchain address caddr.
        ///https://reference.wolfram.com/language/ref/BlockchainContractValue.html
        ///</summary>
        public static Engine BlockchainContractValue(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainContractValue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the block lower triangular matrix lmat as a structured array.
        ///https://reference.wolfram.com/language/ref/BlockLowerTriangularMatrix.html
        ///</summary>
        public static Engine BlockLowerTriangularMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockLowerTriangularMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the block lower triangular matrix lmat as a structured array.
        ///https://reference.wolfram.com/language/ref/BlockLowerTriangularMatrix.html
        ///</summary>
        public static Engine BlockLowerTriangularMatrix(this Engine en, string? name = null)
        {
            return en.Execute("BlockLowerTriangularMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of bytes used internally by the Wolfram System to store expr. 
        ///https://reference.wolfram.com/language/ref/ByteCount.html
        ///</summary>
        public static Engine ByteCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ByteCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of bytes used internally by the Wolfram System to store expr. 
        ///https://reference.wolfram.com/language/ref/ByteCount.html
        ///</summary>
        public static Engine ByteCount(this Engine en, string? name = null)
        {
            return en.Execute("ByteCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Bray–Curtis distance between vectors u and v.
        ///https://reference.wolfram.com/language/ref/BrayCurtisDistance.html
        ///</summary>
        public static Engine BrayCurtisDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BrayCurtisDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///encodes a private or public key in the specified blockchain format.
        ///https://reference.wolfram.com/language/ref/BlockchainKeyEncode.html
        ///</summary>
        public static Engine BlockchainKeyEncode(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BlockchainKeyEncode[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a binomial process with event probability p.
        ///https://reference.wolfram.com/language/ref/BinomialProcess.html
        ///</summary>
        public static Engine BinomialProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinomialProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a binomial process with event probability p.
        ///https://reference.wolfram.com/language/ref/BinomialProcess.html
        ///</summary>
        public static Engine BinomialProcess(this Engine en, string? name = null)
        {
            return en.Execute("BinomialProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///recovers an expression from a binary representation generated by BinarySerialize.
        ///https://reference.wolfram.com/language/ref/BinaryDeserialize.html
        ///</summary>
        public static Engine BinaryDeserialize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BinaryDeserialize[" + arg0 + "]", name);
        }

        ///<summary>
        ///recovers an expression from a binary representation generated by BinarySerialize.
        ///https://reference.wolfram.com/language/ref/BinaryDeserialize.html
        ///</summary>
        public static Engine BinaryDeserialize(this Engine en, string? name = null)
        {
            return en.Execute("BinaryDeserialize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a graphics primitive that represents a Bézier curve with control points pti.
        ///https://reference.wolfram.com/language/ref/BezierCurve.html
        ///</summary>
        public static Engine BezierCurve(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BezierCurve[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a graphics primitive that represents a Bézier curve with control points pti.
        ///https://reference.wolfram.com/language/ref/BezierCurve.html
        ///</summary>
        public static Engine BezierCurve(this Engine en, string? name = null)
        {
            return en.Execute("BezierCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the building entity.
        ///https://reference.wolfram.com/language/ref/BuildingData.html
        ///</summary>
        public static Engine BuildingData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BuildingData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///resets the current context. 
        ///https://reference.wolfram.com/language/ref/Begin.html
        ///</summary>
        public static Engine Begin(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Begin[" + arg0 + "]", name);
        }

        ///<summary>
        ///resets the current context. 
        ///https://reference.wolfram.com/language/ref/Begin.html
        ///</summary>
        public static Engine Begin(this Engine en, string? name = null)
        {
            return en.Execute("Begin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a beta negative binomial mixture distribution with beta distribution parameters α and β and n successful trials.
        ///https://reference.wolfram.com/language/ref/BetaNegativeBinomialDistribution.html
        ///</summary>
        public static Engine BetaNegativeBinomialDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BetaNegativeBinomialDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns True if expr is either True or False.
        ///https://reference.wolfram.com/language/ref/BooleanQ.html
        ///</summary>
        public static Engine BooleanQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BooleanQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if expr is either True or False.
        ///https://reference.wolfram.com/language/ref/BooleanQ.html
        ///</summary>
        public static Engine BooleanQ(this Engine en, string? name = null)
        {
            return en.Execute("BooleanQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a blurred version of image.
        ///https://reference.wolfram.com/language/ref/Blur.html
        ///</summary>
        public static Engine Blur(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Blur[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a blurred version of image.
        ///https://reference.wolfram.com/language/ref/Blur.html
        ///</summary>
        public static Engine Blur(this Engine en, string? name = null)
        {
            return en.Execute("Blur[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the biweight location estimator of the elements in list.
        ///https://reference.wolfram.com/language/ref/BiweightLocation.html
        ///</summary>
        public static Engine BiweightLocation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BiweightLocation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the biweight location estimator of the elements in list.
        ///https://reference.wolfram.com/language/ref/BiweightLocation.html
        ///</summary>
        public static Engine BiweightLocation(this Engine en, string? name = null)
        {
            return en.Execute("BiweightLocation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Bessel function of the first kind . 
        ///https://reference.wolfram.com/language/ref/BesselJ.html
        ///</summary>
        public static Engine BesselJ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BesselJ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to non-overlapping sublists of length n in list. 
        ///https://reference.wolfram.com/language/ref/BlockMap.html
        ///</summary>
        public static Engine BlockMap(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BlockMap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether data follows a MultinormalDistribution using the Baringhaus–Henze test.
        ///https://reference.wolfram.com/language/ref/BaringhausHenzeTest.html
        ///</summary>
        public static Engine BaringhausHenzeTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BaringhausHenzeTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data follows a MultinormalDistribution using the Baringhaus–Henze test.
        ///https://reference.wolfram.com/language/ref/BaringhausHenzeTest.html
        ///</summary>
        public static Engine BaringhausHenzeTest(this Engine en, string? name = null)
        {
            return en.Execute("BaringhausHenzeTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///adds expr to the Wolfram blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainPut.html
        ///</summary>
        public static Engine BlockchainPut(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainPut[" + arg0 + "]", name);
        }

        ///<summary>
        ///adds expr to the Wolfram blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainPut.html
        ///</summary>
        public static Engine BlockchainPut(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainPut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///performs a breadth-first scan (bfs) of the graph g starting at the vertex s and evaluates fi whenever "eventi" occurs.
        ///https://reference.wolfram.com/language/ref/BreadthFirstScan.html
        ///</summary>
        public static Engine BreadthFirstScan(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BreadthFirstScan[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a bivariate normal distribution with mean {μ1,μ2} and covariance matrix {{σ12,ρ σ1 σ2},{ρ σ1 σ2,σ22}}.
        ///https://reference.wolfram.com/language/ref/BinormalDistribution.html
        ///</summary>
        public static Engine BinormalDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BinormalDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///constructs a ByteArray object containing the byte values bi.
        ///https://reference.wolfram.com/language/ref/ByteArray.html
        ///</summary>
        public static Engine ByteArray(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ByteArray[" + arg0 + "]", name);
        }

        ///<summary>
        ///constructs a ByteArray object containing the byte values bi.
        ///https://reference.wolfram.com/language/ref/ByteArray.html
        ///</summary>
        public static Engine ByteArray(this Engine en, string? name = null)
        {
            return en.Execute("ByteArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///draws a bullet gauge showing value and reference in a range of min to max.
        ///https://reference.wolfram.com/language/ref/BulletGauge.html
        ///</summary>
        public static Engine BulletGauge(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("BulletGauge[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a beta prime distribution with shape parameters p and q. 
        ///https://reference.wolfram.com/language/ref/BetaPrimeDistribution.html
        ///</summary>
        public static Engine BetaPrimeDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BetaPrimeDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that indicates the start of the Dialog subsession referenced by integer.
        ///https://reference.wolfram.com/language/ref/BeginDialogPacket.html
        ///</summary>
        public static Engine BeginDialogPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BeginDialogPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that indicates the start of the Dialog subsession referenced by integer.
        ///https://reference.wolfram.com/language/ref/BeginDialogPacket.html
        ///</summary>
        public static Engine BeginDialogPacket(this Engine en, string? name = null)
        {
            return en.Execute("BeginDialogPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Bézier function for a curve defined by the control points pti.
        ///https://reference.wolfram.com/language/ref/BezierFunction.html
        ///</summary>
        public static Engine BezierFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BezierFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Bézier function for a curve defined by the control points pti.
        ///https://reference.wolfram.com/language/ref/BezierFunction.html
        ///</summary>
        public static Engine BezierFunction(this Engine en, string? name = null)
        {
            return en.Execute("BezierFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr with all pseudorandom generators localized, so that uses of SeedRandom, RandomInteger, and related functions within the evaluation of expr do not affect subsequent pseudorandom sequences.
        ///https://reference.wolfram.com/language/ref/BlockRandom.html
        ///</summary>
        public static Engine BlockRandom(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockRandom[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr with all pseudorandom generators localized, so that uses of SeedRandom, RandomInteger, and related functions within the evaluation of expr do not affect subsequent pseudorandom sequences.
        ///https://reference.wolfram.com/language/ref/BlockRandom.html
        ///</summary>
        public static Engine BlockRandom(this Engine en, string? name = null)
        {
            return en.Execute("BlockRandom[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the k zero of the Bessel function .
        ///https://reference.wolfram.com/language/ref/BesselJZero.html
        ///</summary>
        public static Engine BesselJZero(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("BesselJZero[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the biweight midvariance of the elements in list.
        ///https://reference.wolfram.com/language/ref/BiweightMidvariance.html
        ///</summary>
        public static Engine BiweightMidvariance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BiweightMidvariance[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the biweight midvariance of the elements in list.
        ///https://reference.wolfram.com/language/ref/BiweightMidvariance.html
        ///</summary>
        public static Engine BiweightMidvariance(this Engine en, string? name = null)
        {
            return en.Execute("BiweightMidvariance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives information about the use of tokens with the specified name on a blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainTokenData.html
        ///</summary>
        public static Engine BlockchainTokenData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BlockchainTokenData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives information about the use of tokens with the specified name on a blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainTokenData.html
        ///</summary>
        public static Engine BlockchainTokenData(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainTokenData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a Bode plot of a linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/BodePlot.html
        ///</summary>
        public static Engine BodePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BodePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a Bode plot of a linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/BodePlot.html
        ///</summary>
        public static Engine BodePlot(this Engine en, string? name = null)
        {
            return en.Execute("BodePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if the date is a business day and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/BusinessDayQ.html
        ///</summary>
        public static Engine BusinessDayQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("BusinessDayQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if the date is a business day and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/BusinessDayQ.html
        ///</summary>
        public static Engine BusinessDayQ(this Engine en, string? name = null)
        {
            return en.Execute("BusinessDayQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to determine what ImportByteArray format could be used to import the ByteArray object ba.
        ///https://reference.wolfram.com/language/ref/ByteArrayFormat.html
        ///</summary>
        public static Engine ByteArrayFormat(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ByteArrayFormat[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to determine what ImportByteArray format could be used to import the ByteArray object ba.
        ///https://reference.wolfram.com/language/ref/ByteArrayFormat.html
        ///</summary>
        public static Engine ByteArrayFormat(this Engine en, string? name = null)
        {
            return en.Execute("ByteArrayFormat[" + en.ValidNames.Last() + "]", name);
        }


    }
}
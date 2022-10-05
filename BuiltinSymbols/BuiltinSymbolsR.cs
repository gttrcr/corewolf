namespace NetWolf
{
    public static class BuiltinSymbolR
    {
        ///<summary>
        ///gives the intersection of the regions reg1, reg2, ….
        ///https://reference.wolfram.com/language/ref/RegionIntersection.html
        ///</summary>
        public static Engine RegionIntersection(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RegionIntersection[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Ramanujan tau theta function .
        ///https://reference.wolfram.com/language/ref/RamanujanTauTheta.html
        ///</summary>
        public static Engine RamanujanTauTheta(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RamanujanTauTheta[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Ramanujan tau theta function .
        ///https://reference.wolfram.com/language/ref/RamanujanTauTheta.html
        ///</summary>
        public static Engine RamanujanTauTheta(this Engine en, string? name = null)
        {
            return en.Execute("RamanujanTauTheta[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents the displayed object  in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/RadicalBox.html
        ///</summary>
        public static Engine RadicalBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RadicalBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the reverse graph of the directed graph g.
        ///https://reference.wolfram.com/language/ref/ReverseGraph.html
        ///</summary>
        public static Engine ReverseGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReverseGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the reverse graph of the directed graph g.
        ///https://reference.wolfram.com/language/ref/ReverseGraph.html
        ///</summary>
        public static Engine ReverseGraph(this Engine en, string? name = null)
        {
            return en.Execute("ReverseGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the smallest element in the right coset of products of the elements of group by g.
        ///https://reference.wolfram.com/language/ref/RightCosetRepresentative.html
        ///</summary>
        public static Engine RightCosetRepresentative(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RightCosetRepresentative[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Rice distribution with shape parameters α and β.
        ///https://reference.wolfram.com/language/ref/RiceDistribution.html
        ///</summary>
        public static Engine RiceDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RiceDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the erosion of the region reg by a disk of radius r centered at the origin.
        ///https://reference.wolfram.com/language/ref/RegionErosion.html
        ///</summary>
        public static Engine RegionErosion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionErosion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Cartesian product of the regions reg1 and reg2.
        ///https://reference.wolfram.com/language/ref/RegionProduct.html
        ///</summary>
        public static Engine RegionProduct(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionProduct[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a representation of the internal state of a pseudorandom generator.
        ///https://reference.wolfram.com/language/ref/RandomGeneratorState.html
        ///</summary>
        public static Engine RandomGeneratorState(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomGeneratorState[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a representation of the internal state of a pseudorandom generator.
        ///https://reference.wolfram.com/language/ref/RandomGeneratorState.html
        ///</summary>
        public static Engine RandomGeneratorState(this Engine en, string? name = null)
        {
            return en.Execute("RandomGeneratorState[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the value expr from a function. 
        ///https://reference.wolfram.com/language/ref/Return.html
        ///</summary>
        public static Engine Return(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Return[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the value expr from a function. 
        ///https://reference.wolfram.com/language/ref/Return.html
        ///</summary>
        public static Engine Return(this Engine en, string? name = null)
        {
            return en.Execute("Return[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a response record to be given in a specified format when requested during the execution of a function specified by APIFunction, FormFunction, etc.
        ///https://reference.wolfram.com/language/ref/ResponseForm.html
        ///</summary>
        public static Engine ResponseForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ResponseForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates the list {1,2,…,imax}. 
        ///https://reference.wolfram.com/language/ref/Range.html
        ///</summary>
        public static Engine Range(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Range[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates the list {1,2,…,imax}. 
        ///https://reference.wolfram.com/language/ref/Range.html
        ///</summary>
        public static Engine Range(this Engine en, string? name = null)
        {
            return en.Execute("Range[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Riemann–Siegel function . 
        ///https://reference.wolfram.com/language/ref/RiemannSiegelZ.html
        ///</summary>
        public static Engine RiemannSiegelZ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RiemannSiegelZ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Riemann–Siegel function . 
        ///https://reference.wolfram.com/language/ref/RiemannSiegelZ.html
        ///</summary>
        public static Engine RiemannSiegelZ(this Engine en, string? name = null)
        {
            return en.Execute("RiemannSiegelZ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightArrow.html
        ///</summary>
        public static Engine RightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///sorts the elements of list using the reverse canonical order defined by applying f to each of them.
        ///https://reference.wolfram.com/language/ref/ReverseSortBy.html
        ///</summary>
        public static Engine ReverseSortBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ReverseSortBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom point uniformly distributed in the region reg.
        ///https://reference.wolfram.com/language/ref/RandomPoint.html
        ///</summary>
        public static Engine RandomPoint(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomPoint[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom point uniformly distributed in the region reg.
        ///https://reference.wolfram.com/language/ref/RandomPoint.html
        ///</summary>
        public static Engine RandomPoint(this Engine en, string? name = null)
        {
            return en.Execute("RandomPoint[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a pseudorandom spatial point configuration from the spatial point process pproc in the observation region reg. 
        ///https://reference.wolfram.com/language/ref/RandomPointConfiguration.html
        ///</summary>
        public static Engine RandomPointConfiguration(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RandomPointConfiguration[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a pseudorandom function from the process proc from tmin to tmax. 
        ///https://reference.wolfram.com/language/ref/RandomFunction.html
        ///</summary>
        public static Engine RandomFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RandomFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the regions reg1 and reg2 are similar.
        ///https://reference.wolfram.com/language/ref/RegionSimilar.html
        ///</summary>
        public static Engine RegionSimilar(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionSimilar[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of RemoteBatchJobObject expressions representing batch jobs submitted using env.
        ///https://reference.wolfram.com/language/ref/RemoteBatchJobs.html
        ///</summary>
        public static Engine RemoteBatchJobs(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoteBatchJobs[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of RemoteBatchJobObject expressions representing batch jobs submitted using env.
        ///https://reference.wolfram.com/language/ref/RemoteBatchJobs.html
        ///</summary>
        public static Engine RemoteBatchJobs(this Engine en, string? name = null)
        {
            return en.Execute("RemoteBatchJobs[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom real number in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/RandomReal.html
        ///</summary>
        public static Engine RandomReal(this Engine en, string? name = null)
        {
            return en.Execute("RandomReal[]", name);
        }

        ///<summary>
        ///gives the n smallest element in list.
        ///https://reference.wolfram.com/language/ref/RankedMin.html
        ///</summary>
        public static Engine RankedMin(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RankedMin[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Ramanujan tau Z-function .
        ///https://reference.wolfram.com/language/ref/RamanujanTauZ.html
        ///</summary>
        public static Engine RamanujanTauZ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RamanujanTauZ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Ramanujan tau Z-function .
        ///https://reference.wolfram.com/language/ref/RamanujanTauZ.html
        ///</summary>
        public static Engine RamanujanTauZ(this Engine en, string? name = null)
        {
            return en.Execute("RamanujanTauZ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightTeeArrow.html
        ///</summary>
        public static Engine RightTeeArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightTeeArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/ReverseEquilibrium.html
        ///</summary>
        public static Engine ReverseEquilibrium(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ReverseEquilibrium[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the result of evaluating expr using your current default remote Wolfram Language kernel.
        ///https://reference.wolfram.com/language/ref/RemoteEvaluate.html
        ///</summary>
        public static Engine RemoteEvaluate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoteEvaluate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the result of evaluating expr using your current default remote Wolfram Language kernel.
        ///https://reference.wolfram.com/language/ref/RemoteEvaluate.html
        ///</summary>
        public static Engine RemoteEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("RemoteEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///computes the probability for distribution dist to generate a sample that has a lower or equal PDF than example.
        ///https://reference.wolfram.com/language/ref/RarerProbability.html
        ///</summary>
        public static Engine RarerProbability(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RarerProbability[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics primitive which represents a rectangular array of gray cells. 
        ///https://reference.wolfram.com/language/ref/Raster.html
        ///</summary>
        public static Engine Raster(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Raster[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Ramanujan  function .
        ///https://reference.wolfram.com/language/ref/RamanujanTau.html
        ///</summary>
        public static Engine RamanujanTau(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RamanujanTau[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Ramanujan  function .
        ///https://reference.wolfram.com/language/ref/RamanujanTau.html
        ///</summary>
        public static Engine RamanujanTau(this Engine en, string? name = null)
        {
            return en.Execute("RamanujanTau[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a relief plot of an array of height values. 
        ///https://reference.wolfram.com/language/ref/ReliefPlot.html
        ///</summary>
        public static Engine ReliefPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReliefPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a relief plot of an array of height values. 
        ///https://reference.wolfram.com/language/ref/ReliefPlot.html
        ///</summary>
        public static Engine ReliefPlot(this Engine en, string? name = null)
        {
            return en.Execute("ReliefPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a remote batch job submitted by RemoteBatchSubmit or RemoteBatchMapSubmit.
        ///https://reference.wolfram.com/language/ref/RemoteBatchJobObject.html
        ///</summary>
        public static Engine RemoteBatchJobObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoteBatchJobObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a remote batch job submitted by RemoteBatchSubmit or RemoteBatchMapSubmit.
        ///https://reference.wolfram.com/language/ref/RemoteBatchJobObject.html
        ///</summary>
        public static Engine RemoteBatchJobObject(this Engine en, string? name = null)
        {
            return en.Execute("RemoteBatchJobObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the reliability distribution for a system with components xi having reliability distribution disti, where the whole system is working when the Boolean expression bexpr is True, and component xi is working when xi is True.
        ///https://reference.wolfram.com/language/ref/ReliabilityDistribution.html
        ///</summary>
        public static Engine ReliabilityDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ReliabilityDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/ReverseUpEquilibrium.html
        ///</summary>
        public static Engine ReverseUpEquilibrium(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ReverseUpEquilibrium[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightUpTeeVector.html
        ///</summary>
        public static Engine RightUpTeeVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightUpTeeVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom geo position uniformly distributed on the surface of the Earth.
        ///https://reference.wolfram.com/language/ref/RandomGeoPosition.html
        ///</summary>
        public static Engine RandomGeoPosition(this Engine en, string? name = null)
        {
            return en.Execute("RandomGeoPosition[]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightDownTeeVector.html
        ///</summary>
        public static Engine RightDownTeeVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightDownTeeVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///removes obj from the list of currently active channel listeners.
        ///https://reference.wolfram.com/language/ref/RemoveChannelListener.html
        ///</summary>
        public static Engine RemoveChannelListener(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoveChannelListener[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes obj from the list of currently active channel listeners.
        ///https://reference.wolfram.com/language/ref/RemoveChannelListener.html
        ///</summary>
        public static Engine RemoveChannelListener(this Engine en, string? name = null)
        {
            return en.Execute("RemoveChannelListener[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom prime number in the range imin to imax.
        ///https://reference.wolfram.com/language/ref/RandomPrime.html
        ///</summary>
        public static Engine RandomPrime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomPrime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom prime number in the range imin to imax.
        ///https://reference.wolfram.com/language/ref/RandomPrime.html
        ///</summary>
        public static Engine RandomPrime(this Engine en, string? name = null)
        {
            return en.Execute("RandomPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///removes a custom output stream method.
        ///https://reference.wolfram.com/language/ref/RemoveOutputStreamMethod.html
        ///</summary>
        public static Engine RemoveOutputStreamMethod(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoveOutputStreamMethod[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes a custom output stream method.
        ///https://reference.wolfram.com/language/ref/RemoveOutputStreamMethod.html
        ///</summary>
        public static Engine RemoveOutputStreamMethod(this Engine en, string? name = null)
        {
            return en.Execute("RemoveOutputStreamMethod[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a renewal process with interarrival times distributed according to rdist.
        ///https://reference.wolfram.com/language/ref/RenewalProcess.html
        ///</summary>
        public static Engine RenewalProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RenewalProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a renewal process with interarrival times distributed according to rdist.
        ///https://reference.wolfram.com/language/ref/RenewalProcess.html
        ///</summary>
        public static Engine RenewalProcess(this Engine en, string? name = null)
        {
            return en.Execute("RenewalProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightVectorBar.html
        ///</summary>
        public static Engine RightVectorBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightVectorBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom tree with n nodes.
        ///https://reference.wolfram.com/language/ref/RandomTree.html
        ///</summary>
        public static Engine RandomTree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomTree[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom tree with n nodes.
        ///https://reference.wolfram.com/language/ref/RandomTree.html
        ///</summary>
        public static Engine RandomTree(this Engine en, string? name = null)
        {
            return en.Execute("RandomTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///computes the polynomial moment  for the region reg.
        ///https://reference.wolfram.com/language/ref/RegionMoment.html
        ///</summary>
        public static Engine RegionMoment(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionMoment[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a reaction term  with reaction coefficient  and with model variables vars.
        ///https://reference.wolfram.com/language/ref/ReactionPDETerm.html
        ///</summary>
        public static Engine ReactionPDETerm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ReactionPDETerm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///submits an array batch job in which f is applied to each element on the first level of list, using the remote batch submission environment env.
        ///https://reference.wolfram.com/language/ref/RemoteBatchMapSubmit.html
        ///</summary>
        public static Engine RemoteBatchMapSubmit(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RemoteBatchMapSubmit[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///attempts to reduce expr to a single Root object. 
        ///https://reference.wolfram.com/language/ref/RootReduce.html
        ///</summary>
        public static Engine RootReduce(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RootReduce[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to reduce expr to a single Root object. 
        ///https://reference.wolfram.com/language/ref/RootReduce.html
        ///</summary>
        public static Engine RootReduce(this Engine en, string? name = null)
        {
            return en.Execute("RootReduce[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Riemann xi function .
        ///https://reference.wolfram.com/language/ref/RiemannXi.html
        ///</summary>
        public static Engine RiemannXi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RiemannXi[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Riemann xi function .
        ///https://reference.wolfram.com/language/ref/RiemannXi.html
        ///</summary>
        public static Engine RiemannXi(this Engine en, string? name = null)
        {
            return en.Execute("RiemannXi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a symbolic representation of a file on a remote machine.
        ///https://reference.wolfram.com/language/ref/RemoteFile.html
        ///</summary>
        public static Engine RemoteFile(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoteFile[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a symbolic representation of a file on a remote machine.
        ///https://reference.wolfram.com/language/ref/RemoteFile.html
        ///</summary>
        public static Engine RemoteFile(this Engine en, string? name = null)
        {
            return en.Execute("RemoteFile[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if tseries is a regular time series, and False otherwise.
        ///https://reference.wolfram.com/language/ref/RegularlySampledQ.html
        ///</summary>
        public static Engine RegularlySampledQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegularlySampledQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if tseries is a regular time series, and False otherwise.
        ///https://reference.wolfram.com/language/ref/RegularlySampledQ.html
        ///</summary>
        public static Engine RegularlySampledQ(this Engine en, string? name = null)
        {
            return en.Execute("RegularlySampledQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///resize the region reg to have the first side length l preserving side length ratios. 
        ///https://reference.wolfram.com/language/ref/RegionResize.html
        ///</summary>
        public static Engine RegionResize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionResize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///transforms expr by replacing the  element using rules.
        ///https://reference.wolfram.com/language/ref/ReplaceAt.html
        ///</summary>
        public static Engine ReplaceAt(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ReplaceAt[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a low-level representation of the contents of a cell in which Show Cell Expression has been toggled.
        ///https://reference.wolfram.com/language/ref/RawData.html
        ///</summary>
        public static Engine RawData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RawData[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level representation of the contents of a cell in which Show Cell Expression has been toggled.
        ///https://reference.wolfram.com/language/ref/RawData.html
        ///</summary>
        public static Engine RawData(this Engine en, string? name = null)
        {
            return en.Execute("RawData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the roll-pitch-yaw angles {α,β,γ} corresponding to the rotation matrix r.
        ///https://reference.wolfram.com/language/ref/RollPitchYawAngles.html
        ///</summary>
        public static Engine RollPitchYawAngles(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RollPitchYawAngles[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the roll-pitch-yaw angles {α,β,γ} corresponding to the rotation matrix r.
        ///https://reference.wolfram.com/language/ref/RollPitchYawAngles.html
        ///</summary>
        public static Engine RollPitchYawAngles(this Engine en, string? name = null)
        {
            return en.Execute("RollPitchYawAngles[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightTee.html
        ///</summary>
        public static Engine RightTee(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RightTee[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightTeeVector.html
        ///</summary>
        public static Engine RightTeeVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightTeeVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightUpVector.html
        ///</summary>
        public static Engine RightUpVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightUpVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an arbitrarily repeated type of element in an interpreter, API or form specification.
        ///https://reference.wolfram.com/language/ref/RepeatingElement.html
        ///</summary>
        public static Engine RepeatingElement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RepeatingElement[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an arbitrarily repeated type of element in an interpreter, API or form specification.
        ///https://reference.wolfram.com/language/ref/RepeatingElement.html
        ///</summary>
        public static Engine RepeatingElement(this Engine en, string? name = null)
        {
            return en.Execute("RepeatingElement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the measure of the region reg.
        ///https://reference.wolfram.com/language/ref/RegionMeasure.html
        ///</summary>
        public static Engine RegionMeasure(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegionMeasure[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the measure of the region reg.
        ///https://reference.wolfram.com/language/ref/RegionMeasure.html
        ///</summary>
        public static Engine RegionMeasure(this Engine en, string? name = null)
        {
            return en.Execute("RegionMeasure[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom entity with a type determined by the specification spec.
        ///https://reference.wolfram.com/language/ref/RandomEntity.html
        ///</summary>
        public static Engine RandomEntity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomEntity[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom entity with a type determined by the specification spec.
        ///https://reference.wolfram.com/language/ref/RandomEntity.html
        ///</summary>
        public static Engine RandomEntity(this Engine en, string? name = null)
        {
            return en.Execute("RandomEntity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents a rotation in 2D by θ radians about the origin.
        ///https://reference.wolfram.com/language/ref/RotationTransform.html
        ///</summary>
        public static Engine RotationTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RotationTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents a rotation in 2D by θ radians about the origin.
        ///https://reference.wolfram.com/language/ref/RotationTransform.html
        ///</summary>
        public static Engine RotationTransform(this Engine en, string? name = null)
        {
            return en.Execute("RotationTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts the number x to one of the "simplest" algebraic numbers that approximates it well.
        ///https://reference.wolfram.com/language/ref/RootApproximant.html
        ///</summary>
        public static Engine RootApproximant(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RootApproximant[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts the number x to one of the "simplest" algebraic numbers that approximates it well.
        ///https://reference.wolfram.com/language/ref/RootApproximant.html
        ///</summary>
        public static Engine RootApproximant(this Engine en, string? name = null)
        {
            return en.Execute("RootApproximant[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a Renko chart with prices pi at date datei.
        ///https://reference.wolfram.com/language/ref/RenkoChart.html
        ///</summary>
        public static Engine RenkoChart(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RenkoChart[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a plot of Re[f] and Im[f] as functions of x∈ from xmin to xmax.
        ///https://reference.wolfram.com/language/ref/ReImPlot.html
        ///</summary>
        public static Engine ReImPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ReImPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Riemann prime counting function .
        ///https://reference.wolfram.com/language/ref/RiemannR.html
        ///</summary>
        public static Engine RiemannR(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RiemannR[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Riemann prime counting function .
        ///https://reference.wolfram.com/language/ref/RiemannR.html
        ///</summary>
        public static Engine RiemannR(this Engine en, string? name = null)
        {
            return en.Execute("RiemannR[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts an approximate number x to a nearby rational with small denominator. 
        ///https://reference.wolfram.com/language/ref/Rationalize.html
        ///</summary>
        public static Engine Rationalize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Rationalize[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts an approximate number x to a nearby rational with small denominator. 
        ///https://reference.wolfram.com/language/ref/Rationalize.html
        ///</summary>
        public static Engine Rationalize(this Engine en, string? name = null)
        {
            return en.Execute("Rationalize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet containing string, the result of an EnterTextPacket evaluation.
        ///https://reference.wolfram.com/language/ref/ReturnTextPacket.html
        ///</summary>
        public static Engine ReturnTextPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReturnTextPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet containing string, the result of an EnterTextPacket evaluation.
        ///https://reference.wolfram.com/language/ref/ReturnTextPacket.html
        ///</summary>
        public static Engine ReturnTextPacket(this Engine en, string? name = null)
        {
            return en.Execute("ReturnTextPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an object that formats with the expri arranged in a row, potentially extending over several lines. 
        ///https://reference.wolfram.com/language/ref/Row.html
        ///</summary>
        public static Engine Row(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Row[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that formats with the expri arranged in a row, potentially extending over several lines. 
        ///https://reference.wolfram.com/language/ref/Row.html
        ///</summary>
        public static Engine Row(this Engine en, string? name = null)
        {
            return en.Execute("Row[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sorts the elements of list into reverse canonical order. 
        ///https://reference.wolfram.com/language/ref/ReverseSort.html
        ///</summary>
        public static Engine ReverseSort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReverseSort[" + arg0 + "]", name);
        }

        ///<summary>
        ///sorts the elements of list into reverse canonical order. 
        ///https://reference.wolfram.com/language/ref/ReverseSort.html
        ///</summary>
        public static Engine ReverseSort(this Engine en, string? name = null)
        {
            return en.Execute("ReverseSort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an image with an alpha channel where the background is transparent. 
        ///https://reference.wolfram.com/language/ref/RemoveBackground.html
        ///</summary>
        public static Engine RemoveBackground(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoveBackground[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns an image with an alpha channel where the background is transparent. 
        ///https://reference.wolfram.com/language/ref/RemoveBackground.html
        ///</summary>
        public static Engine RemoveBackground(this Engine en, string? name = null)
        {
            return en.Execute("RemoveBackground[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a disjunction of equations which represent the roots of a polynomial equation. 
        ///https://reference.wolfram.com/language/ref/Roots.html
        ///</summary>
        public static Engine Roots(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Roots[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///runs the specified system command on the remote host, returning information on the outcome.
        ///https://reference.wolfram.com/language/ref/RemoteRunProcess.html
        ///</summary>
        public static Engine RemoteRunProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RemoteRunProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the difference of the maximum and minimum in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/RangeFilter.html
        ///</summary>
        public static Engine RangeFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RangeFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a composition on the right of the functions f1, f2, f3, …. 
        ///https://reference.wolfram.com/language/ref/RightComposition.html
        ///</summary>
        public static Engine RightComposition(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("RightComposition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom graph with n vertices and m edges.
        ///https://reference.wolfram.com/language/ref/RandomGraph.html
        ///</summary>
        public static Engine RandomGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom graph with n vertices and m edges.
        ///https://reference.wolfram.com/language/ref/RandomGraph.html
        ///</summary>
        public static Engine RandomGraph(this Engine en, string? name = null)
        {
            return en.Execute("RandomGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the exact root of the general equation f[x]0 near x=c.
        ///https://reference.wolfram.com/language/ref/Root.html
        ///</summary>
        public static Engine Root(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Root[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the exact root of the general equation f[x]0 near x=c.
        ///https://reference.wolfram.com/language/ref/Root.html
        ///</summary>
        public static Engine Root(this Engine en, string? name = null)
        {
            return en.Execute("Root[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the graph with vertices vi and edges from vi to vj whenever f[vi,vj] is True.
        ///https://reference.wolfram.com/language/ref/RelationGraph.html
        ///</summary>
        public static Engine RelationGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RelationGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields an expression in which the i  part of expr is replaced by new. 
        ///https://reference.wolfram.com/language/ref/ReplacePart.html
        ///</summary>
        public static Engine ReplacePart(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ReplacePart[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives x rescaled to run from 0 to 1 over the range min to max. 
        ///https://reference.wolfram.com/language/ref/Rescale.html
        ///</summary>
        public static Engine Rescale(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Rescale[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///changes the pixel values at pixel position ppos in image to val.
        ///https://reference.wolfram.com/language/ref/ReplacePixelValue.html
        ///</summary>
        public static Engine ReplacePixelValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ReplacePixelValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics primitive that represents a cubical array of gray cells. 
        ///https://reference.wolfram.com/language/ref/Raster3D.html
        ///</summary>
        public static Engine Raster3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Raster3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives .
        ///https://reference.wolfram.com/language/ref/RealExponent.html
        ///</summary>
        public static Engine RealExponent(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RealExponent[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives .
        ///https://reference.wolfram.com/language/ref/RealExponent.html
        ///</summary>
        public static Engine RealExponent(this Engine en, string? name = null)
        {
            return en.Execute("RealExponent[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that contains the expression expr, the result of an EnterExpressionPacket evaluation.
        ///https://reference.wolfram.com/language/ref/ReturnExpressionPacket.html
        ///</summary>
        public static Engine ReturnExpressionPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReturnExpressionPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that contains the expression expr, the result of an EnterExpressionPacket evaluation.
        ///https://reference.wolfram.com/language/ref/ReturnExpressionPacket.html
        ///</summary>
        public static Engine ReturnExpressionPacket(this Engine en, string? name = null)
        {
            return en.Execute("ReturnExpressionPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a rectangle chart with bars of width xi and height yi. 
        ///https://reference.wolfram.com/language/ref/RectangleChart.html
        ///</summary>
        public static Engine RectangleChart(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RectangleChart[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of expr determined by a symbolic solution to the ordinary difference equation eqn with independent variable n. 
        ///https://reference.wolfram.com/language/ref/RSolveValue.html
        ///</summary>
        public static Engine RSolveValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///reads the complete contents of a file and returns it as a string.
        ///https://reference.wolfram.com/language/ref/ReadString.html
        ///</summary>
        public static Engine ReadString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReadString[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads the complete contents of a file and returns it as a string.
        ///https://reference.wolfram.com/language/ref/ReadString.html
        ///</summary>
        public static Engine ReadString(this Engine en, string? name = null)
        {
            return en.Execute("ReadString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an axis-aligned filled rectangle from {xmin,ymin} to {xmax,ymax}.
        ///https://reference.wolfram.com/language/ref/Rectangle.html
        ///</summary>
        public static Engine Rectangle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Rectangle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if reg is a valid region and False otherwise. 
        ///https://reference.wolfram.com/language/ref/RegionQ.html
        ///</summary>
        public static Engine RegionQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegionQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if reg is a valid region and False otherwise. 
        ///https://reference.wolfram.com/language/ref/RegionQ.html
        ///</summary>
        public static Engine RegionQ(this Engine en, string? name = null)
        {
            return en.Execute("RegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives x if x≥0 and 0 otherwise.
        ///https://reference.wolfram.com/language/ref/Ramp.html
        ///</summary>
        public static Engine Ramp(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Ramp[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives x if x≥0 and 0 otherwise.
        ///https://reference.wolfram.com/language/ref/Ramp.html
        ///</summary>
        public static Engine Ramp(this Engine en, string? name = null)
        {
            return en.Execute("Ramp[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a resource with the specified name.
        ///https://reference.wolfram.com/language/ref/ResourceObject.html
        ///</summary>
        public static Engine ResourceObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResourceObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a resource with the specified name.
        ///https://reference.wolfram.com/language/ref/ResourceObject.html
        ///</summary>
        public static Engine ResourceObject(this Engine en, string? name = null)
        {
            return en.Execute("ResourceObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the difference of the regions reg1 and reg2.
        ///https://reference.wolfram.com/language/ref/RegionDifference.html
        ///</summary>
        public static Engine RegionDifference(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionDifference[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightUpVectorBar.html
        ///</summary>
        public static Engine RightUpVectorBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightUpVectorBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the boundary of the region reg.
        ///https://reference.wolfram.com/language/ref/RegionBoundary.html
        ///</summary>
        public static Engine RegionBoundary(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegionBoundary[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the boundary of the region reg.
        ///https://reference.wolfram.com/language/ref/RegionBoundary.html
        ///</summary>
        public static Engine RegionBoundary(this Engine en, string? name = null)
        {
            return en.Execute("RegionBoundary[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the geometric dimension of the region reg. 
        ///https://reference.wolfram.com/language/ref/RegionDimension.html
        ///</summary>
        public static Engine RegionDimension(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegionDimension[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the geometric dimension of the region reg. 
        ///https://reference.wolfram.com/language/ref/RegionDimension.html
        ///</summary>
        public static Engine RegionDimension(this Engine en, string? name = null)
        {
            return en.Execute("RegionDimension[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives {e1,x,e2,x,…}. 
        ///https://reference.wolfram.com/language/ref/Riffle.html
        ///</summary>
        public static Engine Riffle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Riffle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///removes the users useri from the permissions group group.
        ///https://reference.wolfram.com/language/ref/RemoveUsers.html
        ///</summary>
        public static Engine RemoveUsers(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RemoveUsers[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///attempts to transform the entire expression expr by applying a rule or list of rules in all possible ways, and returns a list of the results obtained. 
        ///https://reference.wolfram.com/language/ref/ReplaceList.html
        ///</summary>
        public static Engine ReplaceList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ReplaceList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an object whose value in a Dynamic should be refreshed at times specified by the options opts. 
        ///https://reference.wolfram.com/language/ref/Refresh.html
        ///</summary>
        public static Engine Refresh(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Refresh[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom commonly used word.
        ///https://reference.wolfram.com/language/ref/RandomWord.html
        ///</summary>
        public static Engine RandomWord(this Engine en, string? name = null)
        {
            return en.Execute("RandomWord[]", name);
        }

        ///<summary>
        ///represents a remote batch job submission environment for provider with properties assoc.
        ///https://reference.wolfram.com/language/ref/RemoteBatchSubmissionEnvironment.html
        ///</summary>
        public static Engine RemoteBatchSubmissionEnvironment(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RemoteBatchSubmissionEnvironment[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes a measure for the presence of a ridge at every position of data.
        ///https://reference.wolfram.com/language/ref/RidgeFilter.html
        ///</summary>
        public static Engine RidgeFilter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RidgeFilter[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes a measure for the presence of a ridge at every position of data.
        ///https://reference.wolfram.com/language/ref/RidgeFilter.html
        ///</summary>
        public static Engine RidgeFilter(this Engine en, string? name = null)
        {
            return en.Execute("RidgeFilter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightArrowBar.html
        ///</summary>
        public static Engine RightArrowBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightArrowBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a rectangular array of elements of type spec in an interpreter, API or form specification.
        ///https://reference.wolfram.com/language/ref/RectangularRepeatingElement.html
        ///</summary>
        public static Engine RectangularRepeatingElement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RectangularRepeatingElement[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a rectangular array of elements of type spec in an interpreter, API or form specification.
        ///https://reference.wolfram.com/language/ref/RectangularRepeatingElement.html
        ///</summary>
        public static Engine RectangularRepeatingElement(this Engine en, string? name = null)
        {
            return en.Execute("RectangularRepeatingElement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits the specified resource object to be reviewed for publication.
        ///https://reference.wolfram.com/language/ref/ResourceSubmit.html
        ///</summary>
        public static Engine ResourceSubmit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResourceSubmit[" + arg0 + "]", name);
        }

        ///<summary>
        ///submits the specified resource object to be reviewed for publication.
        ///https://reference.wolfram.com/language/ref/ResourceSubmit.html
        ///</summary>
        public static Engine ResourceSubmit(this Engine en, string? name = null)
        {
            return en.Execute("ResourceSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the form of expr that would be obtained if symbols in it were replaced by explicit numerical expressions satisfying the assumptions assum. 
        ///https://reference.wolfram.com/language/ref/Refine.html
        ///</summary>
        public static Engine Refine(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Refine[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Ramanujan tau Dirichlet L-function .
        ///https://reference.wolfram.com/language/ref/RamanujanTauL.html
        ///</summary>
        public static Engine RamanujanTauL(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RamanujanTauL[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Ramanujan tau Dirichlet L-function .
        ///https://reference.wolfram.com/language/ref/RamanujanTauL.html
        ///</summary>
        public static Engine RamanujanTauL(this Engine en, string? name = null)
        {
            return en.Execute("RamanujanTauL[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Rogers–Tanimoto dissimilarity between Boolean vectors u and v.
        ///https://reference.wolfram.com/language/ref/RogersTanimotoDissimilarity.html
        ///</summary>
        public static Engine RogersTanimotoDissimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RogersTanimotoDissimilarity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///cycles the elements in expr n positions to the right. 
        ///https://reference.wolfram.com/language/ref/RotateRight.html
        ///</summary>
        public static Engine RotateRight(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RotateRight[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom simple polygon with n vertex points.
        ///https://reference.wolfram.com/language/ref/RandomPolygon.html
        ///</summary>
        public static Engine RandomPolygon(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomPolygon[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom simple polygon with n vertex points.
        ///https://reference.wolfram.com/language/ref/RandomPolygon.html
        ///</summary>
        public static Engine RandomPolygon(this Engine en, string? name = null)
        {
            return en.Execute("RandomPolygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the successive ratios of elements in list. 
        ///https://reference.wolfram.com/language/ref/Ratios.html
        ///</summary>
        public static Engine Ratios(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Ratios[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the successive ratios of elements in list. 
        ///https://reference.wolfram.com/language/ref/Ratios.html
        ///</summary>
        public static Engine Ratios(this Engine en, string? name = null)
        {
            return en.Execute("Ratios[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///executes an external command, giving the printed form of expr as input and taking the output, reading it as Wolfram Language input, and returning the result. 
        ///https://reference.wolfram.com/language/ref/RunThrough.html
        ///</summary>
        public static Engine RunThrough(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RunThrough[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that reinterprets the input to be an array of dimensions dims.
        ///https://reference.wolfram.com/language/ref/ReshapeLayer.html
        ///</summary>
        public static Engine ReshapeLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReshapeLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that reinterprets the input to be an array of dimensions dims.
        ///https://reference.wolfram.com/language/ref/ReshapeLayer.html
        ///</summary>
        public static Engine ReshapeLayer(this Engine en, string? name = null)
        {
            return en.Execute("ReshapeLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to resolve expr into a form that eliminates ForAll and Exists quantifiers. 
        ///https://reference.wolfram.com/language/ref/Resolve.html
        ///</summary>
        public static Engine Resolve(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Resolve[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to resolve expr into a form that eliminates ForAll and Exists quantifiers. 
        ///https://reference.wolfram.com/language/ref/Resolve.html
        ///</summary>
        public static Engine Resolve(this Engine en, string? name = null)
        {
            return en.Execute("Resolve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the symmetric difference of the regions reg1, reg2, ….
        ///https://reference.wolfram.com/language/ref/RegionSymmetricDifference.html
        ///</summary>
        public static Engine RegionSymmetricDifference(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RegionSymmetricDifference[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a point in the region reg that is nearest the point p. 
        ///https://reference.wolfram.com/language/ref/RegionNearest.html
        ///</summary>
        public static Engine RegionNearest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionNearest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the sum of form[x] for all x that satisfy the polynomial equation f[x]==0. 
        ///https://reference.wolfram.com/language/ref/RootSum.html
        ///</summary>
        public static Engine RootSum(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RootSum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///resets the current working directory to its previous value. 
        ///https://reference.wolfram.com/language/ref/ResetDirectory.html
        ///</summary>
        public static Engine ResetDirectory(this Engine en, string? name = null)
        {
            return en.Execute("ResetDirectory[]", name);
        }

        ///<summary>
        ///estimates Ripley's  function  at radius r for point data pdata.
        ///https://reference.wolfram.com/language/ref/RipleyK.html
        ///</summary>
        public static Engine RipleyK(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RipleyK[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a layer performing one-dimensional resizing of a two-dimensional array.
        ///https://reference.wolfram.com/language/ref/ResizeLayer.html
        ///</summary>
        public static Engine ResizeLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResizeLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a layer performing one-dimensional resizing of a two-dimensional array.
        ///https://reference.wolfram.com/language/ref/ResizeLayer.html
        ///</summary>
        public static Engine ResizeLayer(this Engine en, string? name = null)
        {
            return en.Execute("ResizeLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives expr with the first element removed. 
        ///https://reference.wolfram.com/language/ref/Rest.html
        ///</summary>
        public static Engine Rest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Rest[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives expr with the first element removed. 
        ///https://reference.wolfram.com/language/ref/Rest.html
        ///</summary>
        public static Engine Rest(this Engine en, string? name = null)
        {
            return en.Execute("Rest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom sample of n of the ei.
        ///https://reference.wolfram.com/language/ref/RandomSample.html
        ///</summary>
        public static Engine RandomSample(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RandomSample[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a dataset of resources that contain text matching form.
        ///https://reference.wolfram.com/language/ref/ResourceSearch.html
        ///</summary>
        public static Engine ResourceSearch(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResourceSearch[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a dataset of resources that contain text matching form.
        ///https://reference.wolfram.com/language/ref/ResourceSearch.html
        ///</summary>
        public static Engine ResourceSearch(this Engine en, string? name = null)
        {
            return en.Execute("ResourceSearch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a persistent cache of a resource object that can be referenced by name.
        ///https://reference.wolfram.com/language/ref/ResourceRegister.html
        ///</summary>
        public static Engine ResourceRegister(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResourceRegister[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a persistent cache of a resource object that can be referenced by name.
        ///https://reference.wolfram.com/language/ref/ResourceRegister.html
        ///</summary>
        public static Engine ResourceRegister(this Engine en, string? name = null)
        {
            return en.Execute("ResourceRegister[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of isolating intervals for the real roots of any of the polyi, together with a list of which polynomials actually have each successive root.
        ///https://reference.wolfram.com/language/ref/RootIntervals.html
        ///</summary>
        public static Engine RootIntervals(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RootIntervals[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of isolating intervals for the real roots of any of the polyi, together with a list of which polynomials actually have each successive root.
        ///https://reference.wolfram.com/language/ref/RootIntervals.html
        ///</summary>
        public static Engine RootIntervals(this Engine en, string? name = null)
        {
            return en.Execute("RootIntervals[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///changes the pixel values at position pos in image to val.
        ///https://reference.wolfram.com/language/ref/ReplaceImageValue.html
        ///</summary>
        public static Engine ReplaceImageValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ReplaceImageValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///solves a recurrence equation for a[n]. 
        ///https://reference.wolfram.com/language/ref/RSolve.html
        ///</summary>
        public static Engine RSolve(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RSolve[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightTriangle.html
        ///</summary>
        public static Engine RightTriangle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightTriangle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the 2D rotation matrix that rotates 2D vectors counterclockwise by θ radians.
        ///https://reference.wolfram.com/language/ref/RotationMatrix.html
        ///</summary>
        public static Engine RotationMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RotationMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the 2D rotation matrix that rotates 2D vectors counterclockwise by θ radians.
        ///https://reference.wolfram.com/language/ref/RotationMatrix.html
        ///</summary>
        public static Engine RotationMatrix(this Engine en, string? name = null)
        {
            return en.Execute("RotationMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a tree whose root contains data and that has children specified by the rulei.
        ///https://reference.wolfram.com/language/ref/RulesTree.html
        ///</summary>
        public static Engine RulesTree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RulesTree[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a tree whose root contains data and that has children specified by the rulei.
        ///https://reference.wolfram.com/language/ref/RulesTree.html
        ///</summary>
        public static Engine RulesTree(this Engine en, string? name = null)
        {
            return en.Execute("RulesTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a relief image of an array of height values. 
        ///https://reference.wolfram.com/language/ref/ReliefImage.html
        ///</summary>
        public static Engine ReliefImage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReliefImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a relief image of an array of height values. 
        ///https://reference.wolfram.com/language/ref/ReliefImage.html
        ///</summary>
        public static Engine ReliefImage(this Engine en, string? name = null)
        {
            return en.Execute("ReliefImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads one expression from an input stream and returns the expression. 
        ///https://reference.wolfram.com/language/ref/Read.html
        ///</summary>
        public static Engine Read(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Read[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads one expression from an input stream and returns the expression. 
        ///https://reference.wolfram.com/language/ref/Read.html
        ///</summary>
        public static Engine Read(this Engine en, string? name = null)
        {
            return en.Execute("Read[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///filters x using a linear recurrence equation with coefficients α and β.
        ///https://reference.wolfram.com/language/ref/RecurrenceFilter.html
        ///</summary>
        public static Engine RecurrenceFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RecurrenceFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom variate from the symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/RandomVariate.html
        ///</summary>
        public static Engine RandomVariate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomVariate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom variate from the symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/RandomVariate.html
        ///</summary>
        public static Engine RandomVariate(this Engine en, string? name = null)
        {
            return en.Execute("RandomVariate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the numeric point {x,y,…} is a member of the constant region reg and False otherwise.
        ///https://reference.wolfram.com/language/ref/RegionMember.html
        ///</summary>
        public static Engine RegionMember(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionMember[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the regular polygon with n vertices equally spaced around the unit circle.
        ///https://reference.wolfram.com/language/ref/RegularPolygon.html
        ///</summary>
        public static Engine RegularPolygon(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegularPolygon[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the regular polygon with n vertices equally spaced around the unit circle.
        ///https://reference.wolfram.com/language/ref/RegularPolygon.html
        ///</summary>
        public static Engine RegularPolygon(this Engine en, string? name = null)
        {
            return en.Execute("RegularPolygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Russell–Rao dissimilarity between Boolean vectors u and v.
        ///https://reference.wolfram.com/language/ref/RussellRaoDissimilarity.html
        ///</summary>
        public static Engine RussellRaoDissimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RussellRaoDissimilarity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightDownVector.html
        ///</summary>
        public static Engine RightDownVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightDownVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the integer closest to x. 
        ///https://reference.wolfram.com/language/ref/Round.html
        ///</summary>
        public static Engine Round(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Round[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the integer closest to x. 
        ///https://reference.wolfram.com/language/ref/Round.html
        ///</summary>
        public static Engine Round(this Engine en, string? name = null)
        {
            return en.Execute("Round[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Rudvalis group .
        ///https://reference.wolfram.com/language/ref/RudvalisGroupRu.html
        ///</summary>
        public static Engine RudvalisGroupRu(this Engine en, string? name = null)
        {
            return en.Execute("RudvalisGroupRu[]", name);
        }

        ///<summary>
        ///is a WSTP packet that contains the expression expr, the result of an EvaluatePacket evaluation.
        ///https://reference.wolfram.com/language/ref/ReturnPacket.html
        ///</summary>
        public static Engine ReturnPacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReturnPacket[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that contains the expression expr, the result of an EvaluatePacket evaluation.
        ///https://reference.wolfram.com/language/ref/ReturnPacket.html
        ///</summary>
        public static Engine ReturnPacket(this Engine en, string? name = null)
        {
            return en.Execute("ReturnPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a radio button whose setting x is set to val when the button is clicked. 
        ///https://reference.wolfram.com/language/ref/RadioButton.html
        ///</summary>
        public static Engine RadioButton(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RadioButton[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the centroid of the region reg.
        ///https://reference.wolfram.com/language/ref/RegionCentroid.html
        ///</summary>
        public static Engine RegionCentroid(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegionCentroid[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the centroid of the region reg.
        ///https://reference.wolfram.com/language/ref/RegionCentroid.html
        ///</summary>
        public static Engine RegionCentroid(this Engine en, string? name = null)
        {
            return en.Execute("RegionCentroid[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a rasterized version of the displayed form of expr.
        ///https://reference.wolfram.com/language/ref/Rasterize.html
        ///</summary>
        public static Engine Rasterize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Rasterize[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a rasterized version of the displayed form of expr.
        ///https://reference.wolfram.com/language/ref/Rasterize.html
        ///</summary>
        public static Engine Rasterize(this Engine en, string? name = null)
        {
            return en.Execute("Rasterize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///removes Hold, HoldForm, HoldPattern, and HoldComplete in expr. 
        ///https://reference.wolfram.com/language/ref/ReleaseHold.html
        ///</summary>
        public static Engine ReleaseHold(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReleaseHold[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes Hold, HoldForm, HoldPattern, and HoldComplete in expr. 
        ///https://reference.wolfram.com/language/ref/ReleaseHold.html
        ///</summary>
        public static Engine ReleaseHold(this Engine en, string? name = null)
        {
            return en.Execute("ReleaseHold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the bounds for the region reg.
        ///https://reference.wolfram.com/language/ref/RegionBounds.html
        ///</summary>
        public static Engine RegionBounds(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegionBounds[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the bounds for the region reg.
        ///https://reference.wolfram.com/language/ref/RegionBounds.html
        ///</summary>
        public static Engine RegionBounds(this Engine en, string? name = null)
        {
            return en.Execute("RegionBounds[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a plot representing the rule for the computational system sys.
        ///https://reference.wolfram.com/language/ref/RulePlot.html
        ///</summary>
        public static Engine RulePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RulePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot representing the rule for the computational system sys.
        ///https://reference.wolfram.com/language/ref/RulePlot.html
        ///</summary>
        public static Engine RulePlot(this Engine en, string? name = null)
        {
            return en.Execute("RulePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the matrix that represents reflection of points in a mirror normal to the vector v.
        ///https://reference.wolfram.com/language/ref/ReflectionMatrix.html
        ///</summary>
        public static Engine ReflectionMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReflectionMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the matrix that represents reflection of points in a mirror normal to the vector v.
        ///https://reference.wolfram.com/language/ref/ReflectionMatrix.html
        ///</summary>
        public static Engine ReflectionMatrix(this Engine en, string? name = null)
        {
            return en.Execute("ReflectionMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the n term in the Rudin–Shapiro sequence.
        ///https://reference.wolfram.com/language/ref/RudinShapiro.html
        ///</summary>
        public static Engine RudinShapiro(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RudinShapiro[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n term in the Rudin–Shapiro sequence.
        ///https://reference.wolfram.com/language/ref/RudinShapiro.html
        ///</summary>
        public static Engine RudinShapiro(this Engine en, string? name = null)
        {
            return en.Execute("RudinShapiro[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes all VideoStream objects.
        ///https://reference.wolfram.com/language/ref/RemoveVideoStream.html
        ///</summary>
        public static Engine RemoveVideoStream(this Engine en, string? name = null)
        {
            return en.Execute("RemoveVideoStream[]", name);
        }

        ///<summary>
        ///makes a 3D rectangle chart with bars of width xi, depth yi, and height zi.
        ///https://reference.wolfram.com/language/ref/RectangleChart3D.html
        ///</summary>
        public static Engine RectangleChart3D(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RectangleChart3D[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the n largest element in list.
        ///https://reference.wolfram.com/language/ref/RankedMax.html
        ///</summary>
        public static Engine RankedMax(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RankedMax[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reverses the order of the elements in expr. 
        ///https://reference.wolfram.com/language/ref/Reverse.html
        ///</summary>
        public static Engine Reverse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Reverse[" + arg0 + "]", name);
        }

        ///<summary>
        ///reverses the order of the elements in expr. 
        ///https://reference.wolfram.com/language/ref/Reverse.html
        ///</summary>
        public static Engine Reverse(this Engine en, string? name = null)
        {
            return en.Execute("Reverse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if the regions reg1 and reg2 are disjoint. 
        ///https://reference.wolfram.com/language/ref/RegionDisjoint.html
        ///</summary>
        public static Engine RegionDisjoint(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionDisjoint[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents a reflection in a mirror through the origin, normal to the vector v.
        ///https://reference.wolfram.com/language/ref/ReflectionTransform.html
        ///</summary>
        public static Engine ReflectionTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReflectionTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents a reflection in a mirror through the origin, normal to the vector v.
        ///https://reference.wolfram.com/language/ref/ReflectionTransform.html
        ///</summary>
        public static Engine ReflectionTransform(this Engine en, string? name = null)
        {
            return en.Execute("ReflectionTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a geometric region "model" that best fits the points p1,p2,….
        ///https://reference.wolfram.com/language/ref/RegionFit.html
        ///</summary>
        public static Engine RegionFit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionFit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the primary content of the specified resource.
        ///https://reference.wolfram.com/language/ref/ResourceData.html
        ///</summary>
        public static Engine ResourceData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResourceData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the primary content of the specified resource.
        ///https://reference.wolfram.com/language/ref/ResourceData.html
        ///</summary>
        public static Engine ResourceData(this Engine en, string? name = null)
        {
            return en.Execute("ResourceData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the dilation of the region reg by a disk of radius r centered at the origin.
        ///https://reference.wolfram.com/language/ref/RegionDilation.html
        ///</summary>
        public static Engine RegionDilation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionDilation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives -1, 0 or 1 depending on whether x is negative, zero or positive. 
        ///https://reference.wolfram.com/language/ref/RealSign.html
        ///</summary>
        public static Engine RealSign(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RealSign[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives -1, 0 or 1 depending on whether x is negative, zero or positive. 
        ///https://reference.wolfram.com/language/ref/RealSign.html
        ///</summary>
        public static Engine RealSign(this Engine en, string? name = null)
        {
            return en.Execute("RealSign[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightArrowLeftArrow.html
        ///</summary>
        public static Engine RightArrowLeftArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightArrowLeftArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies a rule or list of rules in an attempt to transform the entire expression expr. 
        ///https://reference.wolfram.com/language/ref/Replace.html
        ///</summary>
        public static Engine Replace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Replace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a radial axis plot where the yi are displayed on radial axes equally spaced around the origin.
        ///https://reference.wolfram.com/language/ref/RadialAxisPlot.html
        ///</summary>
        public static Engine RadialAxisPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RadialAxisPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a radial axis plot where the yi are displayed on radial axes equally spaced around the origin.
        ///https://reference.wolfram.com/language/ref/RadialAxisPlot.html
        ///</summary>
        public static Engine RadialAxisPlot(this Engine en, string? name = null)
        {
            return en.Execute("RadialAxisPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Riemann–Siegel function . 
        ///https://reference.wolfram.com/language/ref/RiemannSiegelTheta.html
        ///</summary>
        public static Engine RiemannSiegelTheta(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RiemannSiegelTheta[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Riemann–Siegel function . 
        ///https://reference.wolfram.com/language/ref/RiemannSiegelTheta.html
        ///</summary>
        public static Engine RiemannSiegelTheta(this Engine en, string? name = null)
        {
            return en.Execute("RiemannSiegelTheta[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a geometric region.
        ///https://reference.wolfram.com/language/ref/Region.html
        ///</summary>
        public static Engine Region(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Region[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a geometric region.
        ///https://reference.wolfram.com/language/ref/Region.html
        ///</summary>
        public static Engine Region(this Engine en, string? name = null)
        {
            return en.Execute("Region[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits expr for evaluation using the remote batch submission environment env.
        ///https://reference.wolfram.com/language/ref/RemoteBatchSubmit.html
        ///</summary>
        public static Engine RemoteBatchSubmit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RemoteBatchSubmit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the contents of src as a ByteArray object.
        ///https://reference.wolfram.com/language/ref/ReadByteArray.html
        ///</summary>
        public static Engine ReadByteArray(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReadByteArray[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the contents of src as a ByteArray object.
        ///https://reference.wolfram.com/language/ref/ReadByteArray.html
        ///</summary>
        public static Engine ReadByteArray(this Engine en, string? name = null)
        {
            return en.Execute("ReadByteArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Rayleigh distribution with scale parameter σ.
        ///https://reference.wolfram.com/language/ref/RayleighDistribution.html
        ///</summary>
        public static Engine RayleighDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RayleighDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the Rayleigh distribution with scale parameter σ.
        ///https://reference.wolfram.com/language/ref/RayleighDistribution.html
        ///</summary>
        public static Engine RayleighDistribution(this Engine en, string? name = null)
        {
            return en.Execute("RayleighDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightVector.html
        ///</summary>
        public static Engine RightVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a row of boxes or strings in a notebook expression. 
        ///https://reference.wolfram.com/language/ref/RowBox.html
        ///</summary>
        public static Engine RowBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RowBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a row of boxes or strings in a notebook expression. 
        ///https://reference.wolfram.com/language/ref/RowBox.html
        ///</summary>
        public static Engine RowBox(this Engine en, string? name = null)
        {
            return en.Execute("RowBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an image with pseudorandom pixel values in the range 0 to max.
        ///https://reference.wolfram.com/language/ref/RandomImage.html
        ///</summary>
        public static Engine RandomImage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an image with pseudorandom pixel values in the range 0 to max.
        ///https://reference.wolfram.com/language/ref/RandomImage.html
        ///</summary>
        public static Engine RandomImage(this Engine en, string? name = null)
        {
            return en.Execute("RandomImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the residue of expr at the point z=z0. 
        ///https://reference.wolfram.com/language/ref/Residue.html
        ///</summary>
        public static Engine Residue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Residue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that rescales the region with coordinate ranges xmin to xmax, etc. to the region with coordinate ranges xpmin to xpmax, etc.
        ///https://reference.wolfram.com/language/ref/RescalingTransform.html
        ///</summary>
        public static Engine RescalingTransform(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("RescalingTransform[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///removes the specified resource from the system on which it is run.
        ///https://reference.wolfram.com/language/ref/ResourceRemove.html
        ///</summary>
        public static Engine ResourceRemove(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResourceRemove[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes the specified resource from the system on which it is run.
        ///https://reference.wolfram.com/language/ref/ResourceRemove.html
        ///</summary>
        public static Engine ResourceRemove(this Engine en, string? name = null)
        {
            return en.Execute("ResourceRemove[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///aborts a remote batch job.
        ///https://reference.wolfram.com/language/ref/RemoteBatchJobAbort.html
        ///</summary>
        public static Engine RemoteBatchJobAbort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoteBatchJobAbort[" + arg0 + "]", name);
        }

        ///<summary>
        ///aborts a remote batch job.
        ///https://reference.wolfram.com/language/ref/RemoteBatchJobAbort.html
        ///</summary>
        public static Engine RemoteBatchJobAbort(this Engine en, string? name = null)
        {
            return en.Execute("RemoteBatchJobAbort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///runs command as an external operating system command, returning the exit code obtained.
        ///https://reference.wolfram.com/language/ref/Run.html
        ///</summary>
        public static Engine Run(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Run[" + arg0 + "]", name);
        }

        ///<summary>
        ///runs command as an external operating system command, returning the exit code obtained.
        ///https://reference.wolfram.com/language/ref/Run.html
        ///</summary>
        public static Engine Run(this Engine en, string? name = null)
        {
            return en.Execute("Run[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom polyhedron with the specified specification spec.
        ///https://reference.wolfram.com/language/ref/RandomPolyhedron.html
        ///</summary>
        public static Engine RandomPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomPolyhedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom polyhedron with the specified specification spec.
        ///https://reference.wolfram.com/language/ref/RandomPolyhedron.html
        ///</summary>
        public static Engine RandomPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("RandomPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightTriangleBar.html
        ///</summary>
        public static Engine RightTriangleBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightTriangleBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a root locus plot of a linear time-invariant system lsys as the parameter k ranges from kmin to kmax.
        ///https://reference.wolfram.com/language/ref/RootLocusPlot.html
        ///</summary>
        public static Engine RootLocusPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RootLocusPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the minimum distance from the point p to the region reg.
        ///https://reference.wolfram.com/language/ref/RegionDistance.html
        ///</summary>
        public static Engine RegionDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a random walk on a line with the probability of a positive unit step p and the probability of a negative unit step 1-p.
        ///https://reference.wolfram.com/language/ref/RandomWalkProcess.html
        ///</summary>
        public static Engine RandomWalkProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomWalkProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a random walk on a line with the probability of a positive unit step p and the probability of a negative unit step 1-p.
        ///https://reference.wolfram.com/language/ref/RandomWalkProcess.html
        ///</summary>
        public static Engine RandomWalkProcess(this Engine en, string? name = null)
        {
            return en.Execute("RandomWalkProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///repairs defects in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/RepairMesh.html
        ///</summary>
        public static Engine RepairMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RepairMesh[" + arg0 + "]", name);
        }

        ///<summary>
        ///repairs defects in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/RepairMesh.html
        ///</summary>
        public static Engine RepairMesh(this Engine en, string? name = null)
        {
            return en.Execute("RepairMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the union of the regions reg1, reg2, ….
        ///https://reference.wolfram.com/language/ref/RegionUnion.html
        ///</summary>
        public static Engine RegionUnion(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RegionUnion[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a list of values of expr for successive n based on solving the recurrence equations eqns.
        ///https://reference.wolfram.com/language/ref/RecurrenceTable.html
        ///</summary>
        public static Engine RecurrenceTable(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RecurrenceTable[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightDownVectorBar.html
        ///</summary>
        public static Engine RightDownVectorBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightDownVectorBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a net layer that has no input and produces a random array from the univariate distribution dist.
        ///https://reference.wolfram.com/language/ref/RandomArrayLayer.html
        ///</summary>
        public static Engine RandomArrayLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomArrayLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that has no input and produces a random array from the univariate distribution dist.
        ///https://reference.wolfram.com/language/ref/RandomArrayLayer.html
        ///</summary>
        public static Engine RandomArrayLayer(this Engine en, string? name = null)
        {
            return en.Execute("RandomArrayLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the regions reg1 and reg2 are congruent.
        ///https://reference.wolfram.com/language/ref/RegionCongruent.html
        ///</summary>
        public static Engine RegionCongruent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionCongruent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list {Re[z],Im[z]} of the number z.
        ///https://reference.wolfram.com/language/ref/ReIm.html
        ///</summary>
        public static Engine ReIm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReIm[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list {Re[z],Im[z]} of the number z.
        ///https://reference.wolfram.com/language/ref/ReIm.html
        ///</summary>
        public static Engine ReIm(this Engine en, string? name = null)
        {
            return en.Execute("ReIm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an estimated observation based on the point data pdata. 
        ///https://reference.wolfram.com/language/ref/RipleyRassonRegion.html
        ///</summary>
        public static Engine RipleyRassonRegion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RipleyRassonRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an estimated observation based on the point data pdata. 
        ///https://reference.wolfram.com/language/ref/RipleyRassonRegion.html
        ///</summary>
        public static Engine RipleyRassonRegion(this Engine en, string? name = null)
        {
            return en.Execute("RipleyRassonRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a plot of the surface of revolution with height fz at radius t.
        ///https://reference.wolfram.com/language/ref/RevolutionPlot3D.html
        ///</summary>
        public static Engine RevolutionPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RevolutionPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the function associated with the specified resource.
        ///https://reference.wolfram.com/language/ref/ResourceFunction.html
        ///</summary>
        public static Engine ResourceFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResourceFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the function associated with the specified resource.
        ///https://reference.wolfram.com/language/ref/ResourceFunction.html
        ///</summary>
        public static Engine ResourceFunction(this Engine en, string? name = null)
        {
            return en.Execute("ResourceFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a net layer that takes an input of dimensions {d1,d2,…} and replicates it n times to produce an output of dimensions {n,d1,d2,…}.
        ///https://reference.wolfram.com/language/ref/ReplicateLayer.html
        ///</summary>
        public static Engine ReplicateLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReplicateLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that takes an input of dimensions {d1,d2,…} and replicates it n times to produce an output of dimensions {n,d1,d2,…}.
        ///https://reference.wolfram.com/language/ref/ReplicateLayer.html
        ///</summary>
        public static Engine ReplicateLayer(this Engine en, string? name = null)
        {
            return en.Execute("ReplicateLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics directive specifying that faces of polygons and other filled graphics objects are to be drawn using concentric circles of colors coli.
        ///https://reference.wolfram.com/language/ref/RadialGradientFilling.html
        ///</summary>
        public static Engine RadialGradientFilling(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RadialGradientFilling[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics directive specifying that faces of polygons and other filled graphics objects are to be drawn using concentric circles of colors coli.
        ///https://reference.wolfram.com/language/ref/RadialGradientFilling.html
        ///</summary>
        public static Engine RadialGradientFilling(this Engine en, string? name = null)
        {
            return en.Execute("RadialGradientFilling[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a binary version of image that includes the foreground pixels of marker and also connected regions whose pixel values are within a distance d.
        ///https://reference.wolfram.com/language/ref/RegionBinarize.html
        ///</summary>
        public static Engine RegionBinarize(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RegionBinarize[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the absolute value of the real number x. 
        ///https://reference.wolfram.com/language/ref/RealAbs.html
        ///</summary>
        public static Engine RealAbs(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RealAbs[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the absolute value of the real number x. 
        ///https://reference.wolfram.com/language/ref/RealAbs.html
        ///</summary>
        public static Engine RealAbs(this Engine en, string? name = null)
        {
            return en.Execute("RealAbs[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the real part of the complex number z. 
        ///https://reference.wolfram.com/language/ref/Re.html
        ///</summary>
        public static Engine Re(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Re[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the real part of the complex number z. 
        ///https://reference.wolfram.com/language/ref/Re.html
        ///</summary>
        public static Engine Re(this Engine en, string? name = null)
        {
            return en.Execute("Re[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///runs the specified external command, returning information on the outcome.
        ///https://reference.wolfram.com/language/ref/RunProcess.html
        ///</summary>
        public static Engine RunProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RunProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///runs the specified external command, returning information on the outcome.
        ///https://reference.wolfram.com/language/ref/RunProcess.html
        ///</summary>
        public static Engine RunProcess(this Engine en, string? name = null)
        {
            return en.Execute("RunProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a random instance of an expression such as a geometric scene or biomolecular sequence.
        ///https://reference.wolfram.com/language/ref/RandomInstance.html
        ///</summary>
        public static Engine RandomInstance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomInstance[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a random instance of an expression such as a geometric scene or biomolecular sequence.
        ///https://reference.wolfram.com/language/ref/RandomInstance.html
        ///</summary>
        public static Engine RandomInstance(this Engine en, string? name = null)
        {
            return en.Execute("RandomInstance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///connects to the specified remote host.
        ///https://reference.wolfram.com/language/ref/RemoteConnect.html
        ///</summary>
        public static Engine RemoteConnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoteConnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///connects to the specified remote host.
        ///https://reference.wolfram.com/language/ref/RemoteConnect.html
        ///</summary>
        public static Engine RemoteConnect(this Engine en, string? name = null)
        {
            return en.Execute("RemoteConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level construct which is formatted as boxes without further interpretation. 
        ///https://reference.wolfram.com/language/ref/RawBoxes.html
        ///</summary>
        public static Engine RawBoxes(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RawBoxes[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level construct which is formatted as boxes without further interpretation. 
        ///https://reference.wolfram.com/language/ref/RawBoxes.html
        ///</summary>
        public static Engine RawBoxes(this Engine en, string? name = null)
        {
            return en.Execute("RawBoxes[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the root node of tree as a Tree object.
        ///https://reference.wolfram.com/language/ref/RootTree.html
        ///</summary>
        public static Engine RootTree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RootTree[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the root node of tree as a Tree object.
        ///https://reference.wolfram.com/language/ref/RootTree.html
        ///</summary>
        public static Engine RootTree(this Engine en, string? name = null)
        {
            return en.Execute("RootTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a radio button bar with setting x and with labeled radio buttons for values vali.
        ///https://reference.wolfram.com/language/ref/RadioButtonBar.html
        ///</summary>
        public static Engine RadioButtonBar(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RadioButtonBar[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///renames the directory dir1 to dir2. 
        ///https://reference.wolfram.com/language/ref/RenameDirectory.html
        ///</summary>
        public static Engine RenameDirectory(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RenameDirectory[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a form of f that takes arguments in reverse order so that ReverseApplied[f][x1,…,xn] is equivalent to f[xn,…,x1].
        ///https://reference.wolfram.com/language/ref/ReverseApplied.html
        ///</summary>
        public static Engine ReverseApplied(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReverseApplied[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a form of f that takes arguments in reverse order so that ReverseApplied[f][x1,…,xn] is equivalent to f[xn,…,x1].
        ///https://reference.wolfram.com/language/ref/ReverseApplied.html
        ///</summary>
        public static Engine ReverseApplied(this Engine en, string? name = null)
        {
            return en.Execute("ReverseApplied[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///removes symbols completely, so that their names are no longer recognized by the Wolfram Language. 
        ///https://reference.wolfram.com/language/ref/Remove.html
        ///</summary>
        public static Engine Remove(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Remove[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///removes all subscribers from the specified channel.
        ///https://reference.wolfram.com/language/ref/RemoveChannelSubscribers.html
        ///</summary>
        public static Engine RemoveChannelSubscribers(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoveChannelSubscribers[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes all subscribers from the specified channel.
        ///https://reference.wolfram.com/language/ref/RemoveChannelSubscribers.html
        ///</summary>
        public static Engine RemoveChannelSubscribers(this Engine en, string? name = null)
        {
            return en.Execute("RemoveChannelSubscribers[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the sum of residues of the meromorphic function f with the variable z.
        ///https://reference.wolfram.com/language/ref/ResidueSum.html
        ///</summary>
        public static Engine ResidueSum(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ResidueSum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightTriangleEqual.html
        ///</summary>
        public static Engine RightTriangleEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightTriangleEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///runs the specified operating system command on the remote host, returning the exit code obtained.
        ///https://reference.wolfram.com/language/ref/RemoteRun.html
        ///</summary>
        public static Engine RemoteRun(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RemoteRun[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts the region representation reg to the specified form.
        ///https://reference.wolfram.com/language/ref/RegionConvert.html
        ///</summary>
        public static Engine RegionConvert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionConvert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of expr together with all expressions to which Sow has been applied during its evaluation. Expressions sown using Sow[e] or Sow[e,tagi] with different tags are given in different lists. 
        ///https://reference.wolfram.com/language/ref/Reap.html
        ///</summary>
        public static Engine Reap(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Reap[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of expr together with all expressions to which Sow has been applied during its evaluation. Expressions sown using Sow[e] or Sow[e,tagi] with different tags are given in different lists. 
        ///https://reference.wolfram.com/language/ref/Reap.html
        ///</summary>
        public static Engine Reap(this Engine en, string? name = null)
        {
            return en.Execute("Reap[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if reg2 is contained within reg1.
        ///https://reference.wolfram.com/language/ref/RegionWithin.html
        ///</summary>
        public static Engine RegionWithin(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionWithin[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the root mean square of values in list.
        ///https://reference.wolfram.com/language/ref/RootMeanSquare.html
        ///</summary>
        public static Engine RootMeanSquare(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RootMeanSquare[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the root mean square of values in list.
        ///https://reference.wolfram.com/language/ref/RootMeanSquare.html
        ///</summary>
        public static Engine RootMeanSquare(this Engine en, string? name = null)
        {
            return en.Execute("RootMeanSquare[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom choice of one of the ei. 
        ///https://reference.wolfram.com/language/ref/RandomChoice.html
        ///</summary>
        public static Engine RandomChoice(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomChoice[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom choice of one of the ei. 
        ///https://reference.wolfram.com/language/ref/RandomChoice.html
        ///</summary>
        public static Engine RandomChoice(this Engine en, string? name = null)
        {
            return en.Execute("RandomChoice[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the risk achievement importances for all components in the ReliabilityDistribution rdist at time t.
        ///https://reference.wolfram.com/language/ref/RiskAchievementImportance.html
        ///</summary>
        public static Engine RiskAchievementImportance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RiskAchievementImportance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the 3D rotation matrix formed by rotating by α around the initial  axis, then by β around the initial  axis, and then by γ around the initial  axis. 
        ///https://reference.wolfram.com/language/ref/RollPitchYawMatrix.html
        ///</summary>
        public static Engine RollPitchYawMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RollPitchYawMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the 3D rotation matrix formed by rotating by α around the initial  axis, then by β around the initial  axis, and then by γ around the initial  axis. 
        ///https://reference.wolfram.com/language/ref/RollPitchYawMatrix.html
        ///</summary>
        public static Engine RollPitchYawMatrix(this Engine en, string? name = null)
        {
            return en.Execute("RollPitchYawMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a form for Interpreter and related functions restricted according to the conditions cond.
        ///https://reference.wolfram.com/language/ref/Restricted.html
        ///</summary>
        public static Engine Restricted(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Restricted[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents schema information about a relational database.
        ///https://reference.wolfram.com/language/ref/RelationalDatabase.html
        ///</summary>
        public static Engine RelationalDatabase(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RelationalDatabase[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents schema information about a relational database.
        ///https://reference.wolfram.com/language/ref/RelationalDatabase.html
        ///</summary>
        public static Engine RelationalDatabase(this Engine en, string? name = null)
        {
            return en.Execute("RelationalDatabase[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an image with values radially changing from center to corners based on gradient color gcol.
        ///https://reference.wolfram.com/language/ref/RadialGradientImage.html
        ///</summary>
        public static Engine RadialGradientImage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RadialGradientImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns an image with values radially changing from center to corners based on gradient color gcol.
        ///https://reference.wolfram.com/language/ref/RadialGradientImage.html
        ///</summary>
        public static Engine RadialGradientImage(this Engine en, string? name = null)
        {
            return en.Execute("RadialGradientImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an object that represents a remote connection.
        ///https://reference.wolfram.com/language/ref/RemoteConnectionObject.html
        ///</summary>
        public static Engine RemoteConnectionObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoteConnectionObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that represents a remote connection.
        ///https://reference.wolfram.com/language/ref/RemoteConnectionObject.html
        ///</summary>
        public static Engine RemoteConnectionObject(this Engine en, string? name = null)
        {
            return en.Execute("RemoteConnectionObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a version of the reaction rxn in which the stoichiometric coefficients for elements in the reactants and products are balanced.
        ///https://reference.wolfram.com/language/ref/ReactionBalance.html
        ///</summary>
        public static Engine ReactionBalance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReactionBalance[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a version of the reaction rxn in which the stoichiometric coefficients for elements in the reactants and products are balanced.
        ///https://reference.wolfram.com/language/ref/ReactionBalance.html
        ///</summary>
        public static Engine ReactionBalance(this Engine en, string? name = null)
        {
            return en.Execute("ReactionBalance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads a line of text from a file and returns it as a string.
        ///https://reference.wolfram.com/language/ref/ReadLine.html
        ///</summary>
        public static Engine ReadLine(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReadLine[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads a line of text from a file and returns it as a string.
        ///https://reference.wolfram.com/language/ref/ReadLine.html
        ///</summary>
        public static Engine ReadLine(this Engine en, string? name = null)
        {
            return en.Execute("ReadLine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a color in the RGB color space with red, blue and green components. 
        ///https://reference.wolfram.com/language/ref/RGBColor.html
        ///</summary>
        public static Engine RGBColor(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RGBColor[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///makes a plot showing the region in which pred is True. 
        ///https://reference.wolfram.com/language/ref/RegionPlot.html
        ///</summary>
        public static Engine RegionPlot(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RegionPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives an image representing the discrete Radon transform of image.
        ///https://reference.wolfram.com/language/ref/Radon.html
        ///</summary>
        public static Engine Radon(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Radon[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an image representing the discrete Radon transform of image.
        ///https://reference.wolfram.com/language/ref/Radon.html
        ///</summary>
        public static Engine Radon(this Engine en, string? name = null)
        {
            return en.Execute("Radon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents 2D graphics primitives or any other objects g rotated counterclockwise by θ radians about the center of their bounding box. 
        ///https://reference.wolfram.com/language/ref/Rotate.html
        ///</summary>
        public static Engine Rotate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Rotate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///renames file1 to file2. 
        ///https://reference.wolfram.com/language/ref/RenameFile.html
        ///</summary>
        public static Engine RenameFile(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RenameFile[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the dimension of the space in which the region reg is embedded. 
        ///https://reference.wolfram.com/language/ref/RegionEmbeddingDimension.html
        ///</summary>
        public static Engine RegionEmbeddingDimension(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegionEmbeddingDimension[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the dimension of the space in which the region reg is embedded. 
        ///https://reference.wolfram.com/language/ref/RegionEmbeddingDimension.html
        ///</summary>
        public static Engine RegionEmbeddingDimension(this Engine en, string? name = null)
        {
            return en.Execute("RegionEmbeddingDimension[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/RightUpDownVector.html
        ///</summary>
        public static Engine RightUpDownVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RightUpDownVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///replaces characters in string that have diacritics by their base ASCII characters, when possible.
        ///https://reference.wolfram.com/language/ref/RemoveDiacritics.html
        ///</summary>
        public static Engine RemoveDiacritics(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoveDiacritics[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces characters in string that have diacritics by their base ASCII characters, when possible.
        ///https://reference.wolfram.com/language/ref/RemoveDiacritics.html
        ///</summary>
        public static Engine RemoveDiacritics(this Engine en, string? name = null)
        {
            return en.Execute("RemoveDiacritics[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///removes opacity from color.
        ///https://reference.wolfram.com/language/ref/RemoveAlphaChannel.html
        ///</summary>
        public static Engine RemoveAlphaChannel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoveAlphaChannel[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes opacity from color.
        ///https://reference.wolfram.com/language/ref/RemoveAlphaChannel.html
        ///</summary>
        public static Engine RemoveAlphaChannel(this Engine en, string? name = null)
        {
            return en.Execute("RemoveAlphaChannel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom integer in the range {imin,imax}. 
        ///https://reference.wolfram.com/language/ref/RandomInteger.html
        ///</summary>
        public static Engine RandomInteger(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomInteger[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom integer in the range {imin,imax}. 
        ///https://reference.wolfram.com/language/ref/RandomInteger.html
        ///</summary>
        public static Engine RandomInteger(this Engine en, string? name = null)
        {
            return en.Execute("RandomInteger[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if a is a root of unity, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/RootOfUnityQ.html
        ///</summary>
        public static Engine RootOfUnityQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RootOfUnityQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if a is a root of unity, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/RootOfUnityQ.html
        ///</summary>
        public static Engine RootOfUnityQ(this Engine en, string? name = null)
        {
            return en.Execute("RootOfUnityQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a reverse biorthogonal spline wavelet of order 4 and dual order 2.
        ///https://reference.wolfram.com/language/ref/ReverseBiorthogonalSplineWavelet.html
        ///</summary>
        public static Engine ReverseBiorthogonalSplineWavelet(this Engine en, string? name = null)
        {
            return en.Execute("ReverseBiorthogonalSplineWavelet[]", name);
        }

        ///<summary>
        ///returns a rasterized grayscale 2D or 3D image of reg.
        ///https://reference.wolfram.com/language/ref/RegionImage.html
        ///</summary>
        public static Engine RegionImage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegionImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a rasterized grayscale 2D or 3D image of reg.
        ///https://reference.wolfram.com/language/ref/RegionImage.html
        ///</summary>
        public static Engine RegionImage(this Engine en, string? name = null)
        {
            return en.Execute("RegionImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reduces the statement expr by solving equations or inequalities for vars and eliminating quantifiers. 
        ///https://reference.wolfram.com/language/ref/Reduce.html
        ///</summary>
        public static Engine Reduce(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Reduce[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///updates to the latest version of the specified resource object.
        ///https://reference.wolfram.com/language/ref/ResourceUpdate.html
        ///</summary>
        public static Engine ResourceUpdate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ResourceUpdate[" + arg0 + "]", name);
        }

        ///<summary>
        ///updates to the latest version of the specified resource object.
        ///https://reference.wolfram.com/language/ref/ResourceUpdate.html
        ///</summary>
        public static Engine ResourceUpdate(this Engine en, string? name = null)
        {
            return en.Execute("ResourceUpdate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is structurally a rational expression in x, and False otherwise.
        ///https://reference.wolfram.com/language/ref/RationalExpressionQ.html
        ///</summary>
        public static Engine RationalExpressionQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RationalExpressionQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a string corresponding to the Roman numeral form of the integer n.
        ///https://reference.wolfram.com/language/ref/RomanNumeral.html
        ///</summary>
        public static Engine RomanNumeral(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RomanNumeral[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a string corresponding to the Roman numeral form of the integer n.
        ///https://reference.wolfram.com/language/ref/RomanNumeral.html
        ///</summary>
        public static Engine RomanNumeral(this Engine en, string? name = null)
        {
            return en.Execute("RomanNumeral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///registers the target for use as an external evaluator with the language or system sys.
        ///https://reference.wolfram.com/language/ref/RegisterExternalEvaluator.html
        ///</summary>
        public static Engine RegisterExternalEvaluator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegisterExternalEvaluator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the risk reduction importances for all components in the ReliabilityDistribution rdist at time t.
        ///https://reference.wolfram.com/language/ref/RiskReductionImportance.html
        ///</summary>
        public static Engine RiskReductionImportance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RiskReductionImportance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom color directive in the RGBColor space.
        ///https://reference.wolfram.com/language/ref/RandomColor.html
        ///</summary>
        public static Engine RandomColor(this Engine en, string? name = null)
        {
            return en.Execute("RandomColor[]", name);
        }

        ///<summary>
        ///gives a list of the digits in the approximate real number x, together with the number of digits that are to the left of the decimal point. 
        ///https://reference.wolfram.com/language/ref/RealDigits.html
        ///</summary>
        public static Engine RealDigits(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RealDigits[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the digits in the approximate real number x, together with the number of digits that are to the left of the decimal point. 
        ///https://reference.wolfram.com/language/ref/RealDigits.html
        ///</summary>
        public static Engine RealDigits(this Engine en, string? name = null)
        {
            return en.Execute("RealDigits[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///computes the resultant of the polynomials poly1 and poly2 with respect to the variable var. 
        ///https://reference.wolfram.com/language/ref/Resultant.html
        ///</summary>
        public static Engine Resultant(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Resultant[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of radiality centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/RadialityCentrality.html
        ///</summary>
        public static Engine RadialityCentrality(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RadialityCentrality[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of radiality centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/RadialityCentrality.html
        ///</summary>
        public static Engine RadialityCentrality(this Engine en, string? name = null)
        {
            return en.Execute("RadialityCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads all the remaining expressions in a file and returns a list of them. 
        ///https://reference.wolfram.com/language/ref/ReadList.html
        ///</summary>
        public static Engine ReadList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReadList[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads all the remaining expressions in a file and returns a list of them. 
        ///https://reference.wolfram.com/language/ref/ReadList.html
        ///</summary>
        public static Engine ReadList(this Engine en, string? name = null)
        {
            return en.Execute("ReadList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if the given chemical reaction is balanced, and False otherwise.
        ///https://reference.wolfram.com/language/ref/ReactionBalancedQ.html
        ///</summary>
        public static Engine ReactionBalancedQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReactionBalancedQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if the given chemical reaction is balanced, and False otherwise.
        ///https://reference.wolfram.com/language/ref/ReactionBalancedQ.html
        ///</summary>
        public static Engine ReactionBalancedQ(this Engine en, string? name = null)
        {
            return en.Execute("ReactionBalancedQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Radon transform of expr.
        ///https://reference.wolfram.com/language/ref/RadonTransform.html
        ///</summary>
        public static Engine RadonTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("RadonTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///makes a plot showing the three-dimensional region in which pred is True. 
        ///https://reference.wolfram.com/language/ref/RegionPlot3D.html
        ///</summary>
        public static Engine RegionPlot3D(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("RegionPlot3D[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the row‐reduced form of the matrix m. 
        ///https://reference.wolfram.com/language/ref/RowReduce.html
        ///</summary>
        public static Engine RowReduce(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RowReduce[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the row‐reduced form of the matrix m. 
        ///https://reference.wolfram.com/language/ref/RowReduce.html
        ///</summary>
        public static Engine RowReduce(this Engine en, string? name = null)
        {
            return en.Execute("RowReduce[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the matrix  that is the stabilizing solution of the continuous algebraic Riccati equation .
        ///https://reference.wolfram.com/language/ref/RiccatiSolve.html
        ///</summary>
        public static Engine RiccatiSolve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RiccatiSolve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///removes a custom input stream method.
        ///https://reference.wolfram.com/language/ref/RemoveInputStreamMethod.html
        ///</summary>
        public static Engine RemoveInputStreamMethod(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RemoveInputStreamMethod[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes a custom input stream method.
        ///https://reference.wolfram.com/language/ref/RemoveInputStreamMethod.html
        ///</summary>
        public static Engine RemoveInputStreamMethod(this Engine en, string? name = null)
        {
            return en.Execute("RemoveInputStreamMethod[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/ReverseElement.html
        ///</summary>
        public static Engine ReverseElement(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ReverseElement[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///deletes all AudioStream objects.
        ///https://reference.wolfram.com/language/ref/RemoveAudioStream.html
        ///</summary>
        public static Engine RemoveAudioStream(this Engine en, string? name = null)
        {
            return en.Execute("RemoveAudioStream[]", name);
        }

        ///<summary>
        ///returns True if the regions reg1 and reg2 are equal.
        ///https://reference.wolfram.com/language/ref/RegionEqual.html
        ///</summary>
        public static Engine RegionEqual(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RegionEqual[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom complex number with real and imaginary parts in the range 0 to 1.
        ///https://reference.wolfram.com/language/ref/RandomComplex.html
        ///</summary>
        public static Engine RandomComplex(this Engine en, string? name = null)
        {
            return en.Execute("RandomComplex[]", name);
        }

        ///<summary>
        ///gives a pseudorandom permutation in the permutation group gr.
        ///https://reference.wolfram.com/language/ref/RandomPermutation.html
        ///</summary>
        public static Engine RandomPermutation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RandomPermutation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom permutation in the permutation group gr.
        ///https://reference.wolfram.com/language/ref/RandomPermutation.html
        ///</summary>
        public static Engine RandomPermutation(this Engine en, string? name = null)
        {
            return en.Execute("RandomPermutation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the specified property "prop" for the resampling rs.
        ///https://reference.wolfram.com/language/ref/ResamplingAlgorithmData.html
        ///</summary>
        public static Engine ResamplingAlgorithmData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ResamplingAlgorithmData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the generalized regular expression specified by the string "regex". 
        ///https://reference.wolfram.com/language/ref/RegularExpression.html
        ///</summary>
        public static Engine RegularExpression(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RegularExpression[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the generalized regular expression specified by the string "regex". 
        ///https://reference.wolfram.com/language/ref/RegularExpression.html
        ///</summary>
        public static Engine RegularExpression(this Engine en, string? name = null)
        {
            return en.Execute("RegularExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds values of vars that give the minimum value of f for vars that satisfy the constraints vcons for all possible values of the parameters pars that satisfy the parametric constraints pcons.
        ///https://reference.wolfram.com/language/ref/RobustConvexOptimization.html
        ///</summary>
        public static Engine RobustConvexOptimization(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("RobustConvexOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///evaluates expr repeatedly and returns a list of the average time in seconds used, together with the result obtained.
        ///https://reference.wolfram.com/language/ref/RepeatedTiming.html
        ///</summary>
        public static Engine RepeatedTiming(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("RepeatedTiming[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr repeatedly and returns a list of the average time in seconds used, together with the result obtained.
        ///https://reference.wolfram.com/language/ref/RepeatedTiming.html
        ///</summary>
        public static Engine RepeatedTiming(this Engine en, string? name = null)
        {
            return en.Execute("RepeatedTiming[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///cycles the elements in expr n positions to the left. 
        ///https://reference.wolfram.com/language/ref/RotateLeft.html
        ///</summary>
        public static Engine RotateLeft(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("RotateLeft[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reconstructs a mesh from a set of points pt1,pt2,….
        ///https://reference.wolfram.com/language/ref/ReconstructionMesh.html
        ///</summary>
        public static Engine ReconstructionMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ReconstructionMesh[" + arg0 + "]", name);
        }

        ///<summary>
        ///reconstructs a mesh from a set of points pt1,pt2,….
        ///https://reference.wolfram.com/language/ref/ReconstructionMesh.html
        ///</summary>
        public static Engine ReconstructionMesh(this Engine en, string? name = null)
        {
            return en.Execute("ReconstructionMesh[" + en.ValidNames.Last() + "]", name);
        }


    }
}
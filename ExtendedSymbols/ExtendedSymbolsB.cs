namespace NetWolf
{
    public static class ExtendedSymbolsB
    {
        ///<summary>
        ///represents the unit ball centered at the point p.
        ///https://reference.wolfram.com/language/ref/Ball.html
        ///</summary>
        public static Engine Ball(this Engine en, string? name = null)
        {
            return en.Execute("Ball[" + en.ValidNames.Last() + "]", name);
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
        ///makes a bar chart with bar lengths y1,  y2, ….
        ///https://reference.wolfram.com/language/ref/BarChart.html
        ///</summary>
        public static Engine BarChart(this Engine en, string? name = null)
        {
            return en.Execute("BarChart[" + en.ValidNames.Last() + "]", name);
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
        ///recognizes a barcode in image and returns it as a string.
        ///https://reference.wolfram.com/language/ref/BarcodeRecognize.html
        ///</summary>
        public static Engine BarcodeRecognize(this Engine en, string? name = null)
        {
            return en.Execute("BarcodeRecognize[" + en.ValidNames.Last() + "]", name);
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
        ///generates a legend that identifies colors from the color function cf with an automatic range of values.
        ///https://reference.wolfram.com/language/ref/BarLegend.html
        ///</summary>
        public static Engine BarLegend(this Engine en, string? name = null)
        {
            return en.Execute("BarLegend[" + en.ValidNames.Last() + "]", name);
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
        ///gives the Barnes G-function .
        ///https://reference.wolfram.com/language/ref/BarnesG.html
        ///</summary>
        public static Engine BarnesG(this Engine en, string? name = null)
        {
            return en.Execute("BarnesG[" + en.ValidNames.Last() + "]", name);
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
        ///represents a Bartlett window function of x.
        ///https://reference.wolfram.com/language/ref/BartlettWindow.html
        ///</summary>
        public static Engine BartlettWindow(this Engine en, string? name = null)
        {
            return en.Execute("BartlettWindow[" + en.ValidNames.Last() + "]", name);
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
        ///encodes the byte array ba as a Base64 string.
        ///https://reference.wolfram.com/language/ref/BaseEncode.html
        ///</summary>
        public static Engine BaseEncode(this Engine en, string? name = null)
        {
            return en.Execute("BaseEncode[" + en.ValidNames.Last() + "]", name);
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
        ///represents the distribution of a mean of n random variables uniformly distributed from 0 to 1.
        ///https://reference.wolfram.com/language/ref/BatesDistribution.html
        ///</summary>
        public static Engine BatesDistribution(this Engine en, string? name = null)
        {
            return en.Execute("BatesDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Battle–Lemarié wavelet of order n evaluated on equally spaced interval {-10,10}.
        ///https://reference.wolfram.com/language/ref/BattleLemarieWavelet.html
        ///</summary>
        public static Engine BattleLemarieWavelet(this Engine en, string? name = null)
        {
            return en.Execute("BattleLemarieWavelet[" + en.ValidNames.Last() + "]", name);
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
        ///represents the result of a Bayesian minimization process.
        ///https://reference.wolfram.com/language/ref/BayesianMinimizationObject.html
        ///</summary>
        public static Engine BayesianMinimizationObject(this Engine en, string? name = null)
        {
            return en.Execute("BayesianMinimizationObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///beeps and populates the Why the Beep dialog with message.
        ///https://reference.wolfram.com/language/ref/Beep.html
        ///</summary>
        public static Engine Beep(this Engine en, string? name = null)
        {
            return en.Execute("Beep[" + en.ValidNames.Last() + "]", name);
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
        ///is a WSTP packet that indicates the start of the Dialog subsession referenced by integer.
        ///https://reference.wolfram.com/language/ref/BeginDialogPacket.html
        ///</summary>
        public static Engine BeginDialogPacket(this Engine en, string? name = null)
        {
            return en.Execute("BeginDialogPacket[" + en.ValidNames.Last() + "]", name);
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
        ///gives the Bell number .
        ///https://reference.wolfram.com/language/ref/BellB.html
        ///</summary>
        public static Engine BellB(this Engine en, string? name = null)
        {
            return en.Execute("BellB[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the generalized Bell polynomial of a matrix m.
        ///https://reference.wolfram.com/language/ref/BellY.html
        ///</summary>
        public static Engine BellY(this Engine en, string? name = null)
        {
            return en.Execute("BellY[" + en.ValidNames.Last() + "]", name);
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
        ///gives the Bernoulli number .
        ///https://reference.wolfram.com/language/ref/BernoulliB.html
        ///</summary>
        public static Engine BernoulliB(this Engine en, string? name = null)
        {
            return en.Execute("BernoulliB[" + en.ValidNames.Last() + "]", name);
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
        ///represents a Bernoulli process with event probability p.
        ///https://reference.wolfram.com/language/ref/BernoulliProcess.html
        ///</summary>
        public static Engine BernoulliProcess(this Engine en, string? name = null)
        {
            return en.Execute("BernoulliProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates the function  that can be applied repeatedly to different radii r.
        ///https://reference.wolfram.com/language/ref/BesagL.html
        ///</summary>
        public static Engine BesagL(this Engine en, string? name = null)
        {
            return en.Execute("BesagL[" + en.ValidNames.Last() + "]", name);
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
        ///is an operator form that yields Between[x,range] when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/Between.html
        ///</summary>
        public static Engine Between(this Engine en, string? name = null)
        {
            return en.Execute("Between[" + en.ValidNames.Last() + "]", name);
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
        ///gives the beveled polyhedron of poly, by beveling each edge.
        ///https://reference.wolfram.com/language/ref/BeveledPolyhedron.html
        ///</summary>
        public static Engine BeveledPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("BeveledPolyhedron[" + en.ValidNames.Last() + "]", name);
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
        ///represents a Bézier function for a curve defined by the control points pti.
        ///https://reference.wolfram.com/language/ref/BezierFunction.html
        ///</summary>
        public static Engine BezierFunction(this Engine en, string? name = null)
        {
            return en.Execute("BezierFunction[" + en.ValidNames.Last() + "]", name);
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
        ///recovers an expression from a binary representation generated by BinarySerialize.
        ///https://reference.wolfram.com/language/ref/BinaryDeserialize.html
        ///</summary>
        public static Engine BinaryDeserialize(this Engine en, string? name = null)
        {
            return en.Execute("BinaryDeserialize[" + en.ValidNames.Last() + "]", name);
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
        ///reads one byte of raw binary data from an input stream, and returns an integer from 0 to 255.
        ///https://reference.wolfram.com/language/ref/BinaryRead.html
        ///</summary>
        public static Engine BinaryRead(this Engine en, string? name = null)
        {
            return en.Execute("BinaryRead[" + en.ValidNames.Last() + "]", name);
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
        public static Engine BinCounts(this Engine en, string? name = null)
        {
            return en.Execute("BinCounts[" + en.ValidNames.Last() + "]", name);
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
        ///computes a variogram using binned values.
        ///https://reference.wolfram.com/language/ref/BinnedVariogramList.html
        ///</summary>
        public static Engine BinnedVariogramList(this Engine en, string? name = null)
        {
            return en.Execute("BinnedVariogramList[" + en.ValidNames.Last() + "]", name);
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
        ///represents a bivariate normal distribution with zero mean and covariance matrix {{1,ρ },{ρ,1}}.
        ///https://reference.wolfram.com/language/ref/BinormalDistribution.html
        ///</summary>
        public static Engine BinormalDistribution(this Engine en, string? name = null)
        {
            return en.Execute("BinormalDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///infers the type (DNA, protein, etc.) from the sequence.
        ///https://reference.wolfram.com/language/ref/BioSequence.html
        ///</summary>
        public static Engine BioSequence(this Engine en, string? name = null)
        {
            return en.Execute("BioSequence[" + en.ValidNames.Last() + "]", name);
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
        ///gives the biological complement of the sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceComplement.html
        ///</summary>
        public static Engine BioSequenceComplement(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceComplement[" + en.ValidNames.Last() + "]", name);
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
        ///represents an operator form of BioSequenceModify that can be applied to a biomolecular sequence.
        ///https://reference.wolfram.com/language/ref/BioSequenceModify.html
        ///</summary>
        public static Engine BioSequenceModify(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceModify[" + en.ValidNames.Last() + "]", name);
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
        ///returns True if bioseq is a valid BioSequence expression, and False otherwise.
        ///https://reference.wolfram.com/language/ref/BioSequenceQ.html
        ///</summary>
        public static Engine BioSequenceQ(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceQ[" + en.ValidNames.Last() + "]", name);
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
        ///transcribes DNA into RNA or inverts the transcription of RNA back to DNA for the sequence bioseq.
        ///https://reference.wolfram.com/language/ref/BioSequenceTranscribe.html
        ///</summary>
        public static Engine BioSequenceTranscribe(this Engine en, string? name = null)
        {
            return en.Execute("BioSequenceTranscribe[" + en.ValidNames.Last() + "]", name);
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
        ///yields True if the graph g is a bipartite graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/BipartiteGraphQ.html
        ///</summary>
        public static Engine BipartiteGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("BipartiteGraphQ[" + en.ValidNames.Last() + "]", name);
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
        ///gives the number of binary bits necessary to represent the integer n.
        ///https://reference.wolfram.com/language/ref/BitLength.html
        ///</summary>
        public static Engine BitLength(this Engine en, string? name = null)
        {
            return en.Execute("BitLength[" + en.ValidNames.Last() + "]", name);
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
        ///shifts one bit to the left.
        ///https://reference.wolfram.com/language/ref/BitShiftLeft.html
        ///</summary>
        public static Engine BitShiftLeft(this Engine en, string? name = null)
        {
            return en.Execute("BitShiftLeft[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///shifts one bit to the right.
        ///https://reference.wolfram.com/language/ref/BitShiftRight.html
        ///</summary>
        public static Engine BitShiftRight(this Engine en, string? name = null)
        {
            return en.Execute("BitShiftRight[" + en.ValidNames.Last() + "]", name);
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
        ///gives the value of the biweight midvariance of the elements in list.
        ///https://reference.wolfram.com/language/ref/BiweightMidvariance.html
        ///</summary>
        public static Engine BiweightMidvariance(this Engine en, string? name = null)
        {
            return en.Execute("BiweightMidvariance[" + en.ValidNames.Last() + "]", name);
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
        ///represents a Blackman–Nuttall window function of x.
        ///https://reference.wolfram.com/language/ref/BlackmanNuttallWindow.html
        ///</summary>
        public static Engine BlackmanNuttallWindow(this Engine en, string? name = null)
        {
            return en.Execute("BlackmanNuttallWindow[" + en.ValidNames.Last() + "]", name);
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
        ///is a pattern object that can stand for any Wolfram Language expression.
        ///https://reference.wolfram.com/language/ref/Blank.html
        ///</summary>
        public static Engine Blank(this Engine en, string? name = null)
        {
            return en.Execute("Blank[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pattern object that can stand for any sequence of zero or more Wolfram Language expressions.
        ///https://reference.wolfram.com/language/ref/BlankNullSequence.html
        ///</summary>
        public static Engine BlankNullSequence(this Engine en, string? name = null)
        {
            return en.Execute("BlankNullSequence[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pattern object that can stand for any sequence of one or more Wolfram Language expressions.
        ///https://reference.wolfram.com/language/ref/BlankSequence.html
        ///</summary>
        public static Engine BlankSequence(this Engine en, string? name = null)
        {
            return en.Execute("BlankSequence[" + en.ValidNames.Last() + "]", name);
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
        ///gives information about the block with the specified hash on the blockchain specified by $BlockchainBase.
        ///https://reference.wolfram.com/language/ref/BlockchainBlockData.html
        ///</summary>
        public static Engine BlockchainBlockData(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainBlockData[" + en.ValidNames.Last() + "]", name);
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
        ///gives the value of the specified property of the blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainData.html
        ///</summary>
        public static Engine BlockchainData(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainData[" + en.ValidNames.Last() + "]", name);
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
        ///adds expr to the Wolfram blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainPut.html
        ///</summary>
        public static Engine BlockchainPut(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainPut[" + en.ValidNames.Last() + "]", name);
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
        ///represents a blockchain transaction built from the components in the association assoc.
        ///https://reference.wolfram.com/language/ref/BlockchainTransaction.html
        ///</summary>
        public static Engine BlockchainTransaction(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainTransaction[" + en.ValidNames.Last() + "]", name);
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
        ///submits the transaction specified in the BlockchainTransaction object obj to a blockchain.
        ///https://reference.wolfram.com/language/ref/BlockchainTransactionSubmit.html
        ///</summary>
        public static Engine BlockchainTransactionSubmit(this Engine en, string? name = null)
        {
            return en.Execute("BlockchainTransactionSubmit[" + en.ValidNames.Last() + "]", name);
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
        ///represents the block lower triangular matrix lmat as a structured array.
        ///https://reference.wolfram.com/language/ref/BlockLowerTriangularMatrix.html
        ///</summary>
        public static Engine BlockLowerTriangularMatrix(this Engine en, string? name = null)
        {
            return en.Execute("BlockLowerTriangularMatrix[" + en.ValidNames.Last() + "]", name);
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
        ///represents the block upper triangular matrix umat as a structured array.
        ///https://reference.wolfram.com/language/ref/BlockUpperTriangularMatrix.html
        ///</summary>
        public static Engine BlockUpperTriangularMatrix(this Engine en, string? name = null)
        {
            return en.Execute("BlockUpperTriangularMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives Blomqvist's medial correlation coefficient β for the matrix m.
        ///https://reference.wolfram.com/language/ref/BlomqvistBeta.html
        ///</summary>
        public static Engine BlomqvistBeta(this Engine en, string? name = null)
        {
            return en.Execute("BlomqvistBeta[" + en.ValidNames.Last() + "]", name);
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
        ///generates a Bode plot of a linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/BodePlot.html
        ///</summary>
        public static Engine BodePlot(this Engine en, string? name = null)
        {
            return en.Execute("BodePlot[" + en.ValidNames.Last() + "]", name);
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
        ///represents a single chemical bond between atoms with indices idi and idj.
        ///https://reference.wolfram.com/language/ref/Bond.html
        ///</summary>
        public static Engine Bond(this Engine en, string? name = null)
        {
            return en.Execute("Bond[" + en.ValidNames.Last() + "]", name);
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
        ///gives the list of bonds in the molecule mol.
        ///https://reference.wolfram.com/language/ref/BondList.html
        ///</summary>
        public static Engine BondList(this Engine en, string? name = null)
        {
            return en.Execute("BondList[" + en.ValidNames.Last() + "]", name);
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
        ///converts the Boolean expression expr to disjunctive normal form.
        ///https://reference.wolfram.com/language/ref/BooleanConvert.html
        ///</summary>
        public static Engine BooleanConvert(this Engine en, string? name = null)
        {
            return en.Execute("BooleanConvert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Boolean function corresponding to the specified vector of truth values.
        ///https://reference.wolfram.com/language/ref/BooleanFunction.html
        ///</summary>
        public static Engine BooleanFunction(this Engine en, string? name = null)
        {
            return en.Execute("BooleanFunction[" + en.ValidNames.Last() + "]", name);
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
        ///returns True if expr is either True or False.
        ///https://reference.wolfram.com/language/ref/BooleanQ.html
        ///</summary>
        public static Engine BooleanQ(this Engine en, string? name = null)
        {
            return en.Execute("BooleanQ[" + en.ValidNames.Last() + "]", name);
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
        ///gives a list of the Boolean variables in the Boolean expression expr.
        ///https://reference.wolfram.com/language/ref/BooleanVariables.html
        ///</summary>
        public static Engine BooleanVariables(this Engine en, string? name = null)
        {
            return en.Execute("BooleanVariables[" + en.ValidNames.Last() + "]", name);
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
        ///discretizes a 2D or 3D graphic g into a BoundaryMeshRegion.
        ///https://reference.wolfram.com/language/ref/BoundaryDiscretizeGraphics.html
        ///</summary>
        public static Engine BoundaryDiscretizeGraphics(this Engine en, string? name = null)
        {
            return en.Execute("BoundaryDiscretizeGraphics[" + en.ValidNames.Last() + "]", name);
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
        ///gives a BoundaryMeshRegion from a MeshRegion mreg.
        ///https://reference.wolfram.com/language/ref/BoundaryMesh.html
        ///</summary>
        public static Engine BoundaryMesh(this Engine en, string? name = null)
        {
            return en.Execute("BoundaryMesh[" + en.ValidNames.Last() + "]", name);
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
        ///gives True if reg is a bounded region and False otherwise.
        ///https://reference.wolfram.com/language/ref/BoundedRegionQ.html
        ///</summary>
        public static Engine BoundedRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("BoundedRegionQ[" + en.ValidNames.Last() + "]", name);
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
        ///is a low-level representation of the contents of a typesetting cell.
        ///https://reference.wolfram.com/language/ref/BoxData.html
        ///</summary>
        public static Engine BoxData(this Engine en, string? name = null)
        {
            return en.Execute("BoxData[" + en.ValidNames.Last() + "]", name);
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
        ///is an object that represents a box structure in an open notebook in the front end.
        ///https://reference.wolfram.com/language/ref/BoxObject.html
        ///</summary>
        public static Engine BoxObject(this Engine en, string? name = null)
        {
            return en.Execute("BoxObject[" + en.ValidNames.Last() + "]", name);
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
        ///adjusts the brightness across image, correcting uneven illumination.
        ///https://reference.wolfram.com/language/ref/BrightnessEqualize.html
        ///</summary>
        public static Engine BrightnessEqualize(this Engine en, string? name = null)
        {
            return en.Execute("BrightnessEqualize[" + en.ValidNames.Last() + "]", name);
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
        ///is a graphics primitive that represents a nonuniform rational B-spline curve with control points pti.
        ///https://reference.wolfram.com/language/ref/BSplineCurve.html
        ///</summary>
        public static Engine BSplineCurve(this Engine en, string? name = null)
        {
            return en.Execute("BSplineCurve[" + en.ValidNames.Last() + "]", name);
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
        ///is a graphics primitive that represents a nonuniform rational B-spline surface defined by an array of  control points.
        ///https://reference.wolfram.com/language/ref/BSplineSurface.html
        ///</summary>
        public static Engine BSplineSurface(this Engine en, string? name = null)
        {
            return en.Execute("BSplineSurface[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a bubble chart from multiple datasets datai.
        ///https://reference.wolfram.com/language/ref/BubbleChart.html
        ///</summary>
        public static Engine BubbleChart(this Engine en, string? name = null)
        {
            return en.Execute("BubbleChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a 3D bubble chart from multiple datasets datai.
        ///https://reference.wolfram.com/language/ref/BubbleChart3D.html
        ///</summary>
        public static Engine BubbleChart3D(this Engine en, string? name = null)
        {
            return en.Execute("BubbleChart3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the order‐n buckyball graph.
        ///https://reference.wolfram.com/language/ref/BuckyballGraph.html
        ///</summary>
        public static Engine BuckyballGraph(this Engine en, string? name = null)
        {
            return en.Execute("BuckyballGraph[" + en.ValidNames.Last() + "]", name);
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
        ///gives the order-n butterfly graph.
        ///https://reference.wolfram.com/language/ref/ButterflyGraph.html
        ///</summary>
        public static Engine ButterflyGraph(this Engine en, string? name = null)
        {
            return en.Execute("ButterflyGraph[" + en.ValidNames.Last() + "]", name);
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
        ///represents a bar of buttons with labels lbli that perform actions acti when pressed.
        ///https://reference.wolfram.com/language/ref/ButtonBar.html
        ///</summary>
        public static Engine ButtonBar(this Engine en, string? name = null)
        {
            return en.Execute("ButtonBar[" + en.ValidNames.Last() + "]", name);
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
        ///constructs a ByteArray object containing the byte values bi.
        ///https://reference.wolfram.com/language/ref/ByteArray.html
        ///</summary>
        public static Engine ByteArray(this Engine en, string? name = null)
        {
            return en.Execute("ByteArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to determine what ImportByteArray format could be used to import the ByteArray object ba.
        ///https://reference.wolfram.com/language/ref/ByteArrayFormat.html
        ///</summary>
        public static Engine ByteArrayFormat(this Engine en, string? name = null)
        {
            return en.Execute("ByteArrayFormat[" + en.ValidNames.Last() + "]", name);
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
        ///returns a string by decoding the data in the byte array ba, assuming UTF-8 encoding.
        ///https://reference.wolfram.com/language/ref/ByteArrayToString.html
        ///</summary>
        public static Engine ByteArrayToString(this Engine en, string? name = null)
        {
            return en.Execute("ByteArrayToString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of bytes used internally by the Wolfram System to store expr.
        ///https://reference.wolfram.com/language/ref/ByteCount.html
        ///</summary>
        public static Engine ByteCount(this Engine en, string? name = null)
        {
            return en.Execute("ByteCount[" + en.ValidNames.Last() + "]", name);
        }


    }
}
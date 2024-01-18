namespace CoreWolf
{
    public static class ExtendedFunctionsN
    {
        ///<summary>
        /// gives the numerical value of expr.
        /// https://reference.wolfram.com/language/ref/N.html
        ///</summary>
        public static Engine N(this Engine en, string? name = null)
        {
            return en.Execute("N[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if there are any symbols whose names match the string pattern given, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/NameQ.html
        ///</summary>
        public static Engine NameQ(this Engine en, string? name = null)
        {
            return en.Execute("NameQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the names of symbols that match the string.
        /// https://reference.wolfram.com/language/ref/Names.html
        ///</summary>
        public static Engine Names(this Engine en, string? name = null)
        {
            return en.Execute("Names[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the result of an n-body simulation.
        /// https://reference.wolfram.com/language/ref/NBodySimulationData.html
        ///</summary>
        public static Engine NBodySimulationData(this Engine en, string? name = null)
        {
            return en.Execute("NBodySimulationData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a NearestFunction[…] that can be applied repeatedly to different x.
        /// https://reference.wolfram.com/language/ref/Nearest.html
        ///</summary>
        public static Engine Nearest(this Engine en, string? name = null)
        {
            return en.Execute("Nearest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a function whose values give the elements closest to an element that is supplied.
        /// https://reference.wolfram.com/language/ref/NearestFunction.html
        ///</summary>
        public static Engine NearestFunction(this Engine en, string? name = null)
        {
            return en.Execute("NearestFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates the function  that can be applied repeatedly to different radii r.
        /// https://reference.wolfram.com/language/ref/NearestNeighborG.html
        ///</summary>
        public static Engine NearestNeighborG(this Engine en, string? name = null)
        {
            return en.Execute("NearestNeighborG[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a graph with vertices elem1,elem2,… and edges connecting each elemi to its nearest neighbors.
        /// https://reference.wolfram.com/language/ref/NearestNeighborGraph.html
        ///</summary>
        public static Engine NearestNeighborGraph(this Engine en, string? name = null)
        {
            return en.Execute("NearestNeighborGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an operator form that yields Nearest[elems,x] when applied to a list elems.
        /// https://reference.wolfram.com/language/ref/NearestTo.html
        ///</summary>
        public static Engine NearestTo(this Engine en, string? name = null)
        {
            return en.Execute("NearestTo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// loads an appropriate file if the specified context is not already in $Packages.
        /// https://reference.wolfram.com/language/ref/Needs.html
        ///</summary>
        public static Engine Needs(this Engine en, string? name = null)
        {
            return en.Execute("Needs[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if x is a negative number.
        /// https://reference.wolfram.com/language/ref/Negative.html
        ///</summary>
        public static Engine Negative(this Engine en, string? name = null)
        {
            return en.Execute("Negative[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is explicitly negative definite, and False otherwise.
        /// https://reference.wolfram.com/language/ref/NegativeDefiniteMatrixQ.html
        ///</summary>
        public static Engine NegativeDefiniteMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("NegativeDefiniteMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the sequence of points p1,p2,p3,…,pn is negatively oriented.
        /// https://reference.wolfram.com/language/ref/NegativelyOrientedPoints.html
        ///</summary>
        public static Engine NegativelyOrientedPoints(this Engine en, string? name = null)
        {
            return en.Execute("NegativelyOrientedPoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is explicitly negative semidefinite, and False otherwise.
        /// https://reference.wolfram.com/language/ref/NegativeSemidefiniteMatrixQ.html
        ///</summary>
        public static Engine NegativeSemidefiniteMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("NegativeSemidefiniteMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uses "name" as an identifier to share the array in more than one layer.
        /// https://reference.wolfram.com/language/ref/NetArray.html
        ///</summary>
        public static Engine NetArray(this Engine en, string? name = null)
        {
            return en.Execute("NetArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// includes options for the initial value of the array or output size.
        /// https://reference.wolfram.com/language/ref/NetArrayLayer.html
        ///</summary>
        public static Engine NetArrayLayer(this Engine en, string? name = null)
        {
            return en.Execute("NetArrayLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net that applies net to a sequence and to its reverse, concatenating both results into one output sequence.
        /// https://reference.wolfram.com/language/ref/NetBidirectionalOperator.html
        ///</summary>
        public static Engine NetBidirectionalOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetBidirectionalOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// specifies a neural net in which the output of layeri is connected to the input of layeri+1.
        /// https://reference.wolfram.com/language/ref/NetChain.html
        ///</summary>
        public static Engine NetChain(this Engine en, string? name = null)
        {
            return en.Execute("NetChain[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a decoder that takes a net representation and decodes it into an expression of a given form.
        /// https://reference.wolfram.com/language/ref/NetDecoder.html
        ///</summary>
        public static Engine NetDecoder(this Engine en, string? name = null)
        {
            return en.Execute("NetDecoder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an encoder that takes a given form of input and encodes it as an array for use in a net.
        /// https://reference.wolfram.com/language/ref/NetEncoder.html
        ///</summary>
        public static Engine NetEncoder(this Engine en, string? name = null)
        {
            return en.Execute("NetEncoder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// collapses nested NetChain and NetGraph objects within net.
        /// https://reference.wolfram.com/language/ref/NetFlatten.html
        ///</summary>
        public static Engine NetFlatten(this Engine en, string? name = null)
        {
            return en.Execute("NetFlatten[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net in which net is folded over a sequence of inputs, maintaining a recurrent state.
        /// https://reference.wolfram.com/language/ref/NetFoldOperator.html
        ///</summary>
        public static Engine NetFoldOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetFoldOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a network to perform generative adversarial network (GAN) training with a generative net generator and a classification net discriminator.
        /// https://reference.wolfram.com/language/ref/NetGANOperator.html
        ///</summary>
        public static Engine NetGANOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetGANOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts a layer or a NetChain into an equivalent minimal NetGraph.
        /// https://reference.wolfram.com/language/ref/NetGraph.html
        ///</summary>
        public static Engine NetGraph(this Engine en, string? name = null)
        {
            return en.Execute("NetGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a net in which all uninitialized learnable parameters in net have been given initial values.
        /// https://reference.wolfram.com/language/ref/NetInitialize.html
        ///</summary>
        public static Engine NetInitialize(this Engine en, string? name = null)
        {
            return en.Execute("NetInitialize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts all ordinary arrays in net into NetSharedArray objects.
        /// https://reference.wolfram.com/language/ref/NetInsertSharedArrays.html
        ///</summary>
        public static Engine NetInsertSharedArrays(this Engine en, string? name = null)
        {
            return en.Execute("NetInsertSharedArrays[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net in which net is mapped over a sequence of inputs to give a sequence of outputs.
        /// https://reference.wolfram.com/language/ref/NetMapOperator.html
        ///</summary>
        public static Engine NetMapOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetMapOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net in which mapnet is mapped over one or more inputs to give one or more outputs.
        /// https://reference.wolfram.com/language/ref/NetMapThreadOperator.html
        ///</summary>
        public static Engine NetMapThreadOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetMapThreadOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// obtains a neural net model with the specified name from the Neural Net Repository.
        /// https://reference.wolfram.com/language/ref/NetModel.html
        ///</summary>
        public static Engine NetModel(this Engine en, string? name = null)
        {
            return en.Execute("NetModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net that takes a pair of arrays, embeds them into a vector space using net, and outputs the distance under the embedding.
        /// https://reference.wolfram.com/language/ref/NetPairEmbeddingOperator.html
        ///</summary>
        public static Engine NetPairEmbeddingOperator(this Engine en, string? name = null)
        {
            return en.Execute("NetPairEmbeddingOperator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the specified input or output port for a complete net.
        /// https://reference.wolfram.com/language/ref/NetPort.html
        ///</summary>
        public static Engine NetPort(this Engine en, string? name = null)
        {
            return en.Execute("NetPort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the gradient of the output of a net with respect to the value of the specified input port.
        /// https://reference.wolfram.com/language/ref/NetPortGradient.html
        ///</summary>
        public static Engine NetPortGradient(this Engine en, string? name = null)
        {
            return en.Execute("NetPortGradient[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates an object derived from net that represents a neural net with additional stored state information that is updated when the net is applied to data.
        /// https://reference.wolfram.com/language/ref/NetStateObject.html
        ///</summary>
        public static Engine NetStateObject(this Engine en, string? name = null)
        {
            return en.Execute("NetStateObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an object generated by NetTrain that contains the trained net and other information about the training process.
        /// https://reference.wolfram.com/language/ref/NetTrainResultsObject.html
        ///</summary>
        public static Engine NetTrainResultsObject(this Engine en, string? name = null)
        {
            return en.Execute("NetTrainResultsObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// produces the elementary net of the folded net fnet, exposing the recurrent states.
        /// https://reference.wolfram.com/language/ref/NetUnfold.html
        ///</summary>
        public static Engine NetUnfold(this Engine en, string? name = null)
        {
            return en.Execute("NetUnfold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// captures only packets associated with the specified network service.
        /// https://reference.wolfram.com/language/ref/NetworkPacketCapture.html
        ///</summary>
        public static Engine NetworkPacketCapture(this Engine en, string? name = null)
        {
            return en.Execute("NetworkPacketCapture[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// records information on network packets transmitted or received through all network interfaces on your computer for t seconds.
        /// https://reference.wolfram.com/language/ref/NetworkPacketRecording.html
        ///</summary>
        public static Engine NetworkPacketRecording(this Engine en, string? name = null)
        {
            return en.Execute("NetworkPacketRecording[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates expr and returns information on network packets transmitted or received through all network interfaces on your computer during the time of the evaluation, together with the result of the evaluation.
        /// https://reference.wolfram.com/language/ref/NetworkPacketTrace.html
        ///</summary>
        public static Engine NetworkPacketTrace(this Engine en, string? name = null)
        {
            return en.Execute("NetworkPacketTrace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// starts looking from the given cell.
        /// https://reference.wolfram.com/language/ref/NextCell.html
        ///</summary>
        public static Engine NextCell(this Engine en, string? name = null)
        {
            return en.Execute("NextCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the next occurring date of the specified granularity type gran.
        /// https://reference.wolfram.com/language/ref/NextDate.html
        ///</summary>
        public static Engine NextDate(this Engine en, string? name = null)
        {
            return en.Execute("NextDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the smallest prime above .
        /// https://reference.wolfram.com/language/ref/NextPrime.html
        ///</summary>
        public static Engine NextPrime(this Engine en, string? name = null)
        {
            return en.Execute("NextPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a Nichols plot of the transfer function for the system lsys.
        /// https://reference.wolfram.com/language/ref/NicholsPlot.html
        ///</summary>
        public static Engine NicholsPlot(this Engine en, string? name = null)
        {
            return en.Execute("NicholsPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the night half of the Earth for the specified date.
        /// https://reference.wolfram.com/language/ref/NightHemisphere.html
        ///</summary>
        public static Engine NightHemisphere(this Engine en, string? name = null)
        {
            return en.Execute("NightHemisphere[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a set of unordered categories cati.
        /// https://reference.wolfram.com/language/ref/NominalScale.html
        ///</summary>
        public static Engine NominalScale(this Engine en, string? name = null)
        {
            return en.Execute("NominalScale[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of NoneTrue that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/NoneTrue.html
        ///</summary>
        public static Engine NoneTrue(this Engine en, string? name = null)
        {
            return en.Execute("NoneTrue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a state-space representation corresponding to the systems model sys.
        /// https://reference.wolfram.com/language/ref/NonlinearStateSpaceModel.html
        ///</summary>
        public static Engine NonlinearStateSpaceModel(this Engine en, string? name = null)
        {
            return en.Execute("NonlinearStateSpaceModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if x is a non‐negative number.
        /// https://reference.wolfram.com/language/ref/NonNegative.html
        ///</summary>
        public static Engine NonNegative(this Engine en, string? name = null)
        {
            return en.Execute("NonNegative[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if x is a non‐positive number.
        /// https://reference.wolfram.com/language/ref/NonPositive.html
        ///</summary>
        public static Engine NonPositive(this Engine en, string? name = null)
        {
            return en.Execute("NonPositive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the norm of a number, vector, or matrix.
        /// https://reference.wolfram.com/language/ref/Norm.html
        ///</summary>
        public static Engine Norm(this Engine en, string? name = null)
        {
            return en.Execute("Norm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts expr to a normal expression from a variety of special forms.
        /// https://reference.wolfram.com/language/ref/Normal.html
        ///</summary>
        public static Engine Normal(this Engine en, string? name = null)
        {
            return en.Execute("Normal[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// normalizes its input data across the specified aggregation levels and applies a learned scaling and bias on the remaining levels.
        /// https://reference.wolfram.com/language/ref/NormalizationLayer.html
        ///</summary>
        public static Engine NormalizationLayer(this Engine en, string? name = null)
        {
            return en.Execute("NormalizationLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the normalized form of a vector v.
        /// https://reference.wolfram.com/language/ref/Normalize.html
        ///</summary>
        public static Engine Normalize(this Engine en, string? name = null)
        {
            return en.Execute("Normalize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is an explicitly normal matrix, and False otherwise.
        /// https://reference.wolfram.com/language/ref/NormalMatrixQ.html
        ///</summary>
        public static Engine NormalMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("NormalMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is the low‐level construct that represents a notebook manipulated by the Wolfram System front end.
        /// https://reference.wolfram.com/language/ref/Notebook.html
        ///</summary>
        public static Engine Notebook(this Engine en, string? name = null)
        {
            return en.Execute("Notebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// closes the notebook corresponding to the specified notebook object.
        /// https://reference.wolfram.com/language/ref/NotebookClose.html
        ///</summary>
        public static Engine NotebookClose(this Engine en, string? name = null)
        {
            return en.Execute("NotebookClose[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// deletes the current selection in the notebook corresponding to the specified notebook object.
        /// https://reference.wolfram.com/language/ref/NotebookDelete.html
        ///</summary>
        public static Engine NotebookDelete(this Engine en, string? name = null)
        {
            return en.Execute("NotebookDelete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the directory for the notebook specified by nb.
        /// https://reference.wolfram.com/language/ref/NotebookDirectory.html
        ///</summary>
        public static Engine NotebookDirectory(this Engine en, string? name = null)
        {
            return en.Execute("NotebookDirectory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates all the evaluatable cells in notebook.
        /// https://reference.wolfram.com/language/ref/NotebookEvaluate.html
        ///</summary>
        public static Engine NotebookEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("NotebookEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the file name for the notebook specified by nb.
        /// https://reference.wolfram.com/language/ref/NotebookFileName.html
        ///</summary>
        public static Engine NotebookFileName(this Engine en, string? name = null)
        {
            return en.Execute("NotebookFileName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gets the raw expression corresponding to the notebook represented by the notebook object obj.
        /// https://reference.wolfram.com/language/ref/NotebookGet.html
        ///</summary>
        public static Engine NotebookGet(this Engine en, string? name = null)
        {
            return en.Execute("NotebookGet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of properties for the specified notebook.
        /// https://reference.wolfram.com/language/ref/NotebookInformation.html
        ///</summary>
        public static Engine NotebookInformation(this Engine en, string? name = null)
        {
            return en.Execute("NotebookInformation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// locates all cells with the specified tag in your current input notebook, selecting the cells and scrolling to the position of the first one.
        /// https://reference.wolfram.com/language/ref/NotebookLocate.html
        ///</summary>
        public static Engine NotebookLocate(this Engine en, string? name = null)
        {
            return en.Execute("NotebookLocate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an object that represents an open notebook in the front end.
        /// https://reference.wolfram.com/language/ref/NotebookObject.html
        ///</summary>
        public static Engine NotebookObject(this Engine en, string? name = null)
        {
            return en.Execute("NotebookObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// opens an existing notebook with the specified name, returning the corresponding notebook object.
        /// https://reference.wolfram.com/language/ref/NotebookOpen.html
        ///</summary>
        public static Engine NotebookOpen(this Engine en, string? name = null)
        {
            return en.Execute("NotebookOpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// sends a notebook containing expr to your default printer.
        /// https://reference.wolfram.com/language/ref/NotebookPrint.html
        ///</summary>
        public static Engine NotebookPrint(this Engine en, string? name = null)
        {
            return en.Execute("NotebookPrint[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a notebook corresponding to expr and makes it the currently selected notebook in the front end.
        /// https://reference.wolfram.com/language/ref/NotebookPut.html
        ///</summary>
        public static Engine NotebookPut(this Engine en, string? name = null)
        {
            return en.Execute("NotebookPut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the expression corresponding to the current selection in the specified notebook object.
        /// https://reference.wolfram.com/language/ref/NotebookRead.html
        ///</summary>
        public static Engine NotebookRead(this Engine en, string? name = null)
        {
            return en.Execute("NotebookRead[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// saves the current version of the specified notebook.
        /// https://reference.wolfram.com/language/ref/NotebookSave.html
        ///</summary>
        public static Engine NotebookSave(this Engine en, string? name = null)
        {
            return en.Execute("NotebookSave[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the current selection associated with the open notebook nb.
        /// https://reference.wolfram.com/language/ref/NotebookSelection.html
        ///</summary>
        public static Engine NotebookSelection(this Engine en, string? name = null)
        {
            return en.Execute("NotebookSelection[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a TemplateObject that represents a notebook template to be applied using functions like GenerateDocument and FileTemplateApply.
        /// https://reference.wolfram.com/language/ref/NotebookTemplate.html
        ///</summary>
        public static Engine NotebookTemplate(this Engine en, string? name = null)
        {
            return en.Execute("NotebookTemplate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of vectors that forms a basis for the null space of the matrix m.
        /// https://reference.wolfram.com/language/ref/NullSpace.html
        ///</summary>
        public static Engine NullSpace(this Engine en, string? name = null)
        {
            return en.Execute("NullSpace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the decimal digits of x multiplied by their corresponding powers of 10.
        /// https://reference.wolfram.com/language/ref/NumberExpand.html
        ///</summary>
        public static Engine NumberExpand(this Engine en, string? name = null)
        {
            return en.Execute("NumberExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the class number for the algebraic number field  generated by .
        /// https://reference.wolfram.com/language/ref/NumberFieldClassNumber.html
        ///</summary>
        public static Engine NumberFieldClassNumber(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldClassNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the discriminant of the field  generated by the algebraic number .
        /// https://reference.wolfram.com/language/ref/NumberFieldDiscriminant.html
        ///</summary>
        public static Engine NumberFieldDiscriminant(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldDiscriminant[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of fundamental units for the field  generated by the algebraic number .
        /// https://reference.wolfram.com/language/ref/NumberFieldFundamentalUnits.html
        ///</summary>
        public static Engine NumberFieldFundamentalUnits(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldFundamentalUnits[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an integral basis for the field  generated by the algebraic number .
        /// https://reference.wolfram.com/language/ref/NumberFieldIntegralBasis.html
        ///</summary>
        public static Engine NumberFieldIntegralBasis(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldIntegralBasis[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the regulator of the field  generated by the algebraic number .
        /// https://reference.wolfram.com/language/ref/NumberFieldRegulator.html
        ///</summary>
        public static Engine NumberFieldRegulator(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldRegulator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the roots of unity for the field  generated by the algebraic number .
        /// https://reference.wolfram.com/language/ref/NumberFieldRootsOfUnity.html
        ///</summary>
        public static Engine NumberFieldRootsOfUnity(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldRootsOfUnity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the signature of the field  generated by the algebraic number .
        /// https://reference.wolfram.com/language/ref/NumberFieldSignature.html
        ///</summary>
        public static Engine NumberFieldSignature(this Engine en, string? name = null)
        {
            return en.Execute("NumberFieldSignature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints using the default options of NumberForm.
        /// https://reference.wolfram.com/language/ref/NumberForm.html
        ///</summary>
        public static Engine NumberForm(this Engine en, string? name = null)
        {
            return en.Execute("NumberForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the values vi on a number line.
        /// https://reference.wolfram.com/language/ref/NumberLinePlot.html
        ///</summary>
        public static Engine NumberLinePlot(this Engine en, string? name = null)
        {
            return en.Execute("NumberLinePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is a number, and False otherwise.
        /// https://reference.wolfram.com/language/ref/NumberQ.html
        ///</summary>
        public static Engine NumberQ(this Engine en, string? name = null)
        {
            return en.Execute("NumberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the numerator of expr.
        /// https://reference.wolfram.com/language/ref/Numerator.html
        ///</summary>
        public static Engine Numerator(this Engine en, string? name = null)
        {
            return en.Execute("Numerator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list {Numerator[expr],Denominator[expr]} of expr.
        /// https://reference.wolfram.com/language/ref/NumeratorDenominator.html
        ///</summary>
        public static Engine NumeratorDenominator(this Engine en, string? name = null)
        {
            return en.Execute("NumeratorDenominator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// sorts the elements of list into numerical order.
        /// https://reference.wolfram.com/language/ref/NumericalSort.html
        ///</summary>
        public static Engine NumericalSort(this Engine en, string? name = null)
        {
            return en.Execute("NumericalSort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is a valid NumericArray object, and False otherwise.
        /// https://reference.wolfram.com/language/ref/NumericArrayQ.html
        ///</summary>
        public static Engine NumericArrayQ(this Engine en, string? name = null)
        {
            return en.Execute("NumericArrayQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the underlying type of values used for each element in the NumericArray object.
        /// https://reference.wolfram.com/language/ref/NumericArrayType.html
        ///</summary>
        public static Engine NumericArrayType(this Engine en, string? name = null)
        {
            return en.Execute("NumericArrayType[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is a numeric quantity, and False otherwise.
        /// https://reference.wolfram.com/language/ref/NumericQ.html
        ///</summary>
        public static Engine NumericQ(this Engine en, string? name = null)
        {
            return en.Execute("NumericQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Nuttall window function of x.
        /// https://reference.wolfram.com/language/ref/NuttallWindow.html
        ///</summary>
        public static Engine NuttallWindow(this Engine en, string? name = null)
        {
            return en.Execute("NuttallWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a Nyquist plot of the transfer function for the system lsys.
        /// https://reference.wolfram.com/language/ref/NyquistPlot.html
        ///</summary>
        public static Engine NyquistPlot(this Engine en, string? name = null)
        {
            return en.Execute("NyquistPlot[" + en.ValidNames.Last() + "]", name);
        }


    }
}
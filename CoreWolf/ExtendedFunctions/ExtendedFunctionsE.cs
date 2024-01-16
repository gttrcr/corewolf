namespace CoreWolf
{
    public static class ExtendedFunctionsE
    {
        ///<summary>
        ///gives all earthquake properties for the location corresponding to loc.
        ///https://reference.wolfram.com/language/ref/EarthquakeData.html
        ///</summary>
        public static Engine EarthquakeData(this Engine en, string? name = null)
        {
            return en.Execute("EarthquakeData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of eccentricity centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/EccentricityCentrality.html
        ///</summary>
        public static Engine EccentricityCentrality(this Engine en, string? name = null)
        {
            return en.Execute("EccentricityCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints expr and returns expr.
        ///https://reference.wolfram.com/language/ref/Echo.html
        ///</summary>
        public static Engine Echo(this Engine en, string? name = null)
        {
            return en.Execute("Echo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints expr before evaluation, then prints the result after evaluation and returns that result.
        ///https://reference.wolfram.com/language/ref/EchoEvaluation.html
        ///</summary>
        public static Engine EchoEvaluation(this Engine en, string? name = null)
        {
            return en.Execute("EchoEvaluation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints f[expr] and returns expr.
        ///https://reference.wolfram.com/language/ref/EchoFunction.html
        ///</summary>
        public static Engine EchoFunction(this Engine en, string? name = null)
        {
            return en.Execute("EchoFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr, prints the time in seconds used and returns the result of the evaluation.
        ///https://reference.wolfram.com/language/ref/EchoTiming.html
        ///</summary>
        public static Engine EchoTiming(this Engine en, string? name = null)
        {
            return en.Execute("EchoTiming[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of betweenness centralities for the edges in the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeBetweennessCentrality.html
        ///</summary>
        public static Engine EdgeBetweennessCentrality(this Engine en, string? name = null)
        {
            return en.Execute("EdgeBetweennessCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the chromatic number for the edges of the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeChromaticNumber.html
        ///</summary>
        public static Engine EdgeChromaticNumber(this Engine en, string? name = null)
        {
            return en.Execute("EdgeChromaticNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the edge connectivity of the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeConnectivity.html
        ///</summary>
        public static Engine EdgeConnectivity(this Engine en, string? name = null)
        {
            return en.Execute("EdgeConnectivity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a count of the number of edges in the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeCount.html
        ///</summary>
        public static Engine EdgeCount(this Engine en, string? name = null)
        {
            return en.Execute("EdgeCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the edge cycle matrix of a graph g.
        ///https://reference.wolfram.com/language/ref/EdgeCycleMatrix.html
        ///</summary>
        public static Engine EdgeCycleMatrix(this Engine en, string? name = null)
        {
            return en.Execute("EdgeCycleMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds edges in image and returns the result as a binary image.
        ///https://reference.wolfram.com/language/ref/EdgeDetect.html
        ///</summary>
        public static Engine EdgeDetect(this Engine en, string? name = null)
        {
            return en.Execute("EdgeDetect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a graphics directive that specifies that edges of polygons and other filled graphics objects are to be drawn using the graphics directive or list of directives g.
        ///https://reference.wolfram.com/language/ref/EdgeForm.html
        ///</summary>
        public static Engine EdgeForm(this Engine en, string? name = null)
        {
            return en.Execute("EdgeForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of edges for the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeList.html
        ///</summary>
        public static Engine EdgeList(this Engine en, string? name = null)
        {
            return en.Execute("EdgeList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of edge rules for the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeRules.html
        ///</summary>
        public static Engine EdgeRules(this Engine en, string? name = null)
        {
            return en.Execute("EdgeRules[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a graph with edges ej tagged with unique tags.
        ///https://reference.wolfram.com/language/ref/EdgeTaggedGraph.html
        ///</summary>
        public static Engine EdgeTaggedGraph(this Engine en, string? name = null)
        {
            return en.Execute("EdgeTaggedGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g has edges tagged and False otherwise.
        ///https://reference.wolfram.com/language/ref/EdgeTaggedGraphQ.html
        ///</summary>
        public static Engine EdgeTaggedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("EdgeTaggedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of tags for all edges in the graph g.
        ///https://reference.wolfram.com/language/ref/EdgeTags.html
        ///</summary>
        public static Engine EdgeTags(this Engine en, string? name = null)
        {
            return en.Execute("EdgeTags[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a edge-transitive graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/EdgeTransitiveGraphQ.html
        ///</summary>
        public static Engine EdgeTransitiveGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("EdgeTransitiveGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is an edge-weighted graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/EdgeWeightedGraphQ.html
        ///</summary>
        public static Engine EdgeWeightedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("EdgeWeightedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list {values,vectors} of the eigenvalues and eigenvectors of the square matrix m.
        ///https://reference.wolfram.com/language/ref/Eigensystem.html
        ///</summary>
        public static Engine Eigensystem(this Engine en, string? name = null)
        {
            return en.Execute("Eigensystem[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the eigenvalues of the square matrix m.
        ///https://reference.wolfram.com/language/ref/Eigenvalues.html
        ///</summary>
        public static Engine Eigenvalues(this Engine en, string? name = null)
        {
            return en.Execute("Eigenvalues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of eigenvector centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/EigenvectorCentrality.html
        ///</summary>
        public static Engine EigenvectorCentrality(this Engine en, string? name = null)
        {
            return en.Execute("EigenvectorCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the eigenvectors of the square matrix m.
        ///https://reference.wolfram.com/language/ref/Eigenvectors.html
        ///</summary>
        public static Engine Eigenvectors(this Engine en, string? name = null)
        {
            return en.Execute("Eigenvectors[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a net layer that applies a unary function f to every element of the input array.
        ///https://reference.wolfram.com/language/ref/ElementwiseLayer.html
        ///</summary>
        public static Engine ElementwiseLayer(this Engine en, string? name = null)
        {
            return en.Execute("ElementwiseLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the complete elliptic integral .
        ///https://reference.wolfram.com/language/ref/EllipticE.html
        ///</summary>
        public static Engine EllipticE(this Engine en, string? name = null)
        {
            return en.Execute("EllipticE[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///designs a lowpass elliptic filter of order n.
        ///https://reference.wolfram.com/language/ref/EllipticFilterModel.html
        ///</summary>
        public static Engine EllipticFilterModel(this Engine en, string? name = null)
        {
            return en.Execute("EllipticFilterModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the complete elliptic integral of the first kind .
        ///https://reference.wolfram.com/language/ref/EllipticK.html
        ///</summary>
        public static Engine EllipticK(this Engine en, string? name = null)
        {
            return en.Execute("EllipticK[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the nome q corresponding to the parameter m in an elliptic function.
        ///https://reference.wolfram.com/language/ref/EllipticNomeQ.html
        ///</summary>
        public static Engine EllipticNomeQ(this Engine en, string? name = null)
        {
            return en.Execute("EllipticNomeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates the code necessary to embed the object obj on a webpage.
        ///https://reference.wolfram.com/language/ref/EmbedCode.html
        ///</summary>
        public static Engine EmbedCode(this Engine en, string? name = null)
        {
            return en.Execute("EmbedCode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an object that formats as a web frame containing the HTML content "string".
        ///https://reference.wolfram.com/language/ref/EmbeddedHTML.html
        ///</summary>
        public static Engine EmbeddedHTML(this Engine en, string? name = null)
        {
            return en.Execute("EmbeddedHTML[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an object that formats as a web frame containing content from the specified external service.
        ///https://reference.wolfram.com/language/ref/EmbeddedService.html
        ///</summary>
        public static Engine EmbeddedService(this Engine en, string? name = null)
        {
            return en.Execute("EmbeddedService[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an SQL expression to be evaluated verbatim within an EntityFunction object.
        ///https://reference.wolfram.com/language/ref/EmbeddedSQLExpression.html
        ///</summary>
        public static Engine EmbeddedSQLExpression(this Engine en, string? name = null)
        {
            return en.Execute("EmbeddedSQLExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///leaves the n to be inferred from context.
        ///https://reference.wolfram.com/language/ref/EmbeddingLayer.html
        ///</summary>
        public static Engine EmbeddingLayer(this Engine en, string? name = null)
        {
            return en.Execute("EmbeddingLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///emits the sound snd when evaluated.
        ///https://reference.wolfram.com/language/ref/EmitSound.html
        ///</summary>
        public static Engine EmitSound(this Engine en, string? name = null)
        {
            return en.Execute("EmitSound[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an empirical distribution based on the data values xi.
        ///https://reference.wolfram.com/language/ref/EmpiricalDistribution.html
        ///</summary>
        public static Engine EmpiricalDistribution(this Engine en, string? name = null)
        {
            return en.Execute("EmpiricalDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if g is an empty graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/EmptyGraphQ.html
        ///</summary>
        public static Engine EmptyGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("EmptyGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the empty subset of .
        ///https://reference.wolfram.com/language/ref/EmptyRegion.html
        ///</summary>
        public static Engine EmptyRegion(this Engine en, string? name = null)
        {
            return en.Execute("EmptyRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates the function  that can be applied repeatedly to different radii r.
        ///https://reference.wolfram.com/language/ref/EmptySpaceF.html
        ///</summary>
        public static Engine EmptySpaceF(this Engine en, string? name = null)
        {
            return en.Execute("EmptySpaceF[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to evaluate expr and return the result, but stops if it catches an error and returns a failure object.
        ///https://reference.wolfram.com/language/ref/Enclose.html
        ///</summary>
        public static Engine Enclose(this Engine en, string? name = null)
        {
            return en.Execute("Enclose[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///decodes the file before reading its contents.
        ///https://reference.wolfram.com/language/ref/Encode.html
        ///</summary>
        public static Engine Encode(this Engine en, string? name = null)
        {
            return en.Execute("Encode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///interactively requests a password with which to encrypt expr.
        ///https://reference.wolfram.com/language/ref/Encrypt.html
        ///</summary>
        public static Engine Encrypt(this Engine en, string? name = null)
        {
            return en.Execute("Encrypt[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents encrypted data generated by Encrypt.
        ///https://reference.wolfram.com/language/ref/EncryptedObject.html
        ///</summary>
        public static Engine EncryptedObject(this Engine en, string? name = null)
        {
            return en.Execute("EncryptedObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet indicating the end of the Dialog subsession referenced by integer.
        ///https://reference.wolfram.com/language/ref/EndDialogPacket.html
        ///</summary>
        public static Engine EndDialogPacket(this Engine en, string? name = null)
        {
            return en.Execute("EndDialogPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints with all real numbers in expr given in engineering notation.
        ///https://reference.wolfram.com/language/ref/EngineeringForm.html
        ///</summary>
        public static Engine EngineeringForm(this Engine en, string? name = null)
        {
            return en.Execute("EngineeringForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that requests the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/EnterExpressionPacket.html
        ///</summary>
        public static Engine EnterExpressionPacket(this Engine en, string? name = null)
        {
            return en.Execute("EnterExpressionPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that requests the parsing and evaluation of string as an expression.
        ///https://reference.wolfram.com/language/ref/EnterTextPacket.html
        ///</summary>
        public static Engine EnterTextPacket(this Engine en, string? name = null)
        {
            return en.Execute("EnterTextPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of entity classes for the specified type of entity.
        ///https://reference.wolfram.com/language/ref/EntityClassList.html
        ///</summary>
        public static Engine EntityClassList(this Engine en, string? name = null)
        {
            return en.Execute("EntityClassList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a group of entities.
        ///https://reference.wolfram.com/language/ref/EntityGroup.html
        ///</summary>
        public static Engine EntityGroup(this Engine en, string? name = null)
        {
            return en.Execute("EntityGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of entities in the specified entity class.
        ///https://reference.wolfram.com/language/ref/EntityList.html
        ///</summary>
        public static Engine EntityList(this Engine en, string? name = null)
        {
            return en.Execute("EntityList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///fetches cacheable values associated with all entities of the specified type.
        ///https://reference.wolfram.com/language/ref/EntityPrefetch.html
        ///</summary>
        public static Engine EntityPrefetch(this Engine en, string? name = null)
        {
            return en.Execute("EntityPrefetch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///lists properties associated with entity type type.
        ///https://reference.wolfram.com/language/ref/EntityProperties.html
        ///</summary>
        public static Engine EntityProperties(this Engine en, string? name = null)
        {
            return en.Execute("EntityProperties[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///registers the entities in the entity store estore so that they can be accessed directly using Entity.
        ///https://reference.wolfram.com/language/ref/EntityRegister.html
        ///</summary>
        public static Engine EntityRegister(this Engine en, string? name = null)
        {
            return en.Execute("EntityRegister[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an empty entity store for entities of type "type".
        ///https://reference.wolfram.com/language/ref/EntityStore.html
        ///</summary>
        public static Engine EntityStore(this Engine en, string? name = null)
        {
            return en.Execute("EntityStore[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the name of the entity type of entity.
        ///https://reference.wolfram.com/language/ref/EntityTypeName.html
        ///</summary>
        public static Engine EntityTypeName(this Engine en, string? name = null)
        {
            return en.Execute("EntityTypeName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///unregisters all entities in the first entity store that defines entities of the specified type.
        ///https://reference.wolfram.com/language/ref/EntityUnregister.html
        ///</summary>
        public static Engine EntityUnregister(this Engine en, string? name = null)
        {
            return en.Execute("EntityUnregister[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the base  information entropy of the values in list.
        ///https://reference.wolfram.com/language/ref/Entropy.html
        ///</summary>
        public static Engine Entropy(this Engine en, string? name = null)
        {
            return en.Execute("Entropy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of an operating system environment variable.
        ///https://reference.wolfram.com/language/ref/Environment.html
        ///</summary>
        public static Engine Environment(this Engine en, string? name = null)
        {
            return en.Execute("Environment[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x==y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/EqualTo.html
        ///</summary>
        public static Engine EqualTo(this Engine en, string? name = null)
        {
            return en.Execute("EqualTo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the error function .
        ///https://reference.wolfram.com/language/ref/Erf.html
        ///</summary>
        public static Engine Erf(this Engine en, string? name = null)
        {
            return en.Execute("Erf[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the complementary error function .
        ///https://reference.wolfram.com/language/ref/Erfc.html
        ///</summary>
        public static Engine Erfc(this Engine en, string? name = null)
        {
            return en.Execute("Erfc[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the imaginary error function .
        ///https://reference.wolfram.com/language/ref/Erfi.html
        ///</summary>
        public static Engine Erfi(this Engine en, string? name = null)
        {
            return en.Execute("Erfi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents boxes that cannot be interpreted in input or output.
        ///https://reference.wolfram.com/language/ref/ErrorBox.html
        ///</summary>
        public static Engine ErrorBox(this Engine en, string? name = null)
        {
            return en.Execute("ErrorBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates the background of data.
        ///https://reference.wolfram.com/language/ref/EstimatedBackground.html
        ///</summary>
        public static Engine EstimatedBackground(this Engine en, string? name = null)
        {
            return en.Execute("EstimatedBackground[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates normal vectors for the points p1,p2,….
        ///https://reference.wolfram.com/language/ref/EstimatedPointNormals.html
        ///</summary>
        public static Engine EstimatedPointNormals(this Engine en, string? name = null)
        {
            return en.Execute("EstimatedPointNormals[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates the best variogram function from values vali given at locations loci.
        ///https://reference.wolfram.com/language/ref/EstimatedVariogramModel.html
        ///</summary>
        public static Engine EstimatedVariogramModel(this Engine en, string? name = null)
        {
            return en.Execute("EstimatedVariogramModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives Euler angles {α,β,γ} corresponding to the rotation matrix r.
        ///https://reference.wolfram.com/language/ref/EulerAngles.html
        ///</summary>
        public static Engine EulerAngles(this Engine en, string? name = null)
        {
            return en.Execute("EulerAngles[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Euler characteristic of a poly.
        ///https://reference.wolfram.com/language/ref/EulerCharacteristic.html
        ///</summary>
        public static Engine EulerCharacteristic(this Engine en, string? name = null)
        {
            return en.Execute("EulerCharacteristic[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Euler number .
        ///https://reference.wolfram.com/language/ref/EulerE.html
        ///</summary>
        public static Engine EulerE(this Engine en, string? name = null)
        {
            return en.Execute("EulerE[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is Eulerian, and False otherwise.
        ///https://reference.wolfram.com/language/ref/EulerianGraphQ.html
        ///</summary>
        public static Engine EulerianGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("EulerianGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Euler 3D rotation matrix formed by rotating by α around the current  axis, then by β around the current  axis, and then by γ around the current  axis.
        ///https://reference.wolfram.com/language/ref/EulerMatrix.html
        ///</summary>
        public static Engine EulerMatrix(this Engine en, string? name = null)
        {
            return en.Execute("EulerMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Euler totient function .
        ///https://reference.wolfram.com/language/ref/EulerPhi.html
        ///</summary>
        public static Engine EulerPhi(this Engine en, string? name = null)
        {
            return en.Execute("EulerPhi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///causes expr to be evaluated even if it appears as the argument of a function whose attributes specify that it should be held unevaluated.
        ///https://reference.wolfram.com/language/ref/Evaluate.html
        ///</summary>
        public static Engine Evaluate(this Engine en, string? name = null)
        {
            return en.Execute("Evaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet requesting evaluation of expr.
        ///https://reference.wolfram.com/language/ref/EvaluatePacket.html
        ///</summary>
        public static Engine EvaluatePacket(this Engine en, string? name = null)
        {
            return en.Execute("EvaluatePacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an association containing the result of evaluating expr and metadata about the process of doing so.
        ///https://reference.wolfram.com/language/ref/EvaluationData.html
        ///</summary>
        public static Engine EvaluationData(this Engine en, string? name = null)
        {
            return en.Execute("EvaluationData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is an even integer, and False otherwise.
        ///https://reference.wolfram.com/language/ref/EvenQ.html
        ///</summary>
        public static Engine EvenQ(this Engine en, string? name = null)
        {
            return en.Execute("EvenQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents event data with explicitly specified censoring ei.
        ///https://reference.wolfram.com/language/ref/EventData.html
        ///</summary>
        public static Engine EventData(this Engine en, string? name = null)
        {
            return en.Execute("EventData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an exact Blackman window function of x.
        ///https://reference.wolfram.com/language/ref/ExactBlackmanWindow.html
        ///</summary>
        public static Engine ExactBlackmanWindow(this Engine en, string? name = null)
        {
            return en.Execute("ExactBlackmanWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if expr is an exact real or complex number, and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/ExactNumberQ.html
        ///</summary>
        public static Engine ExactNumberQ(this Engine en, string? name = null)
        {
            return en.Execute("ExactNumberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of names of examples of the specified type.
        ///https://reference.wolfram.com/language/ref/ExampleData.html
        ///</summary>
        public static Engine ExampleData(this Engine en, string? name = null)
        {
            return en.Execute("ExampleData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pattern object which represents any expression except one that matches c.
        ///https://reference.wolfram.com/language/ref/Except.html
        ///</summary>
        public static Engine Except(this Engine en, string? name = null)
        {
            return en.Execute("Except[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the exponential of z.
        ///https://reference.wolfram.com/language/ref/Exp.html
        ///</summary>
        public static Engine Exp(this Engine en, string? name = null)
        {
            return en.Execute("Exp[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///expands out products and positive integer powers in expr.
        ///https://reference.wolfram.com/language/ref/Expand.html
        ///</summary>
        public static Engine Expand(this Engine en, string? name = null)
        {
            return en.Execute("Expand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///expands out all products and integer powers in any part of expr.
        ///https://reference.wolfram.com/language/ref/ExpandAll.html
        ///</summary>
        public static Engine ExpandAll(this Engine en, string? name = null)
        {
            return en.Execute("ExpandAll[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///expands out products and powers that appear as denominators in expr.
        ///https://reference.wolfram.com/language/ref/ExpandDenominator.html
        ///</summary>
        public static Engine ExpandDenominator(this Engine en, string? name = null)
        {
            return en.Execute("ExpandDenominator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///textually expands name to have the form of an absolute file name for your operating system.
        ///https://reference.wolfram.com/language/ref/ExpandFileName.html
        ///</summary>
        public static Engine ExpandFileName(this Engine en, string? name = null)
        {
            return en.Execute("ExpandFileName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///expands out products and powers that appear in the numerator of expr.
        ///https://reference.wolfram.com/language/ref/ExpandNumerator.html
        ///</summary>
        public static Engine ExpandNumerator(this Engine en, string? name = null)
        {
            return en.Execute("ExpandNumerator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the exponential integral function .
        ///https://reference.wolfram.com/language/ref/ExpIntegralEi.html
        ///</summary>
        public static Engine ExpIntegralEi(this Engine en, string? name = null)
        {
            return en.Execute("ExpIntegralEi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an exponential distribution with scale inversely proportional to parameter λ.
        ///https://reference.wolfram.com/language/ref/ExponentialDistribution.html
        ///</summary>
        public static Engine ExponentialDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ExponentialDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an exponential power distribution with location parameter 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/ExponentialPowerDistribution.html
        ///</summary>
        public static Engine ExponentialPowerDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ExponentialPowerDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an expression cell that can appear in a Wolfram System notebook.
        ///https://reference.wolfram.com/language/ref/ExpressionCell.html
        ///</summary>
        public static Engine ExpressionCell(this Engine en, string? name = null)
        {
            return en.Execute("ExpressionCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the tree graph with different levels at different depths.
        ///https://reference.wolfram.com/language/ref/ExpressionGraph.html
        ///</summary>
        public static Engine ExpressionGraph(this Engine en, string? name = null)
        {
            return en.Execute("ExpressionGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a Tree object from the structure of the expression expr.
        ///https://reference.wolfram.com/language/ref/ExpressionTree.html
        ///</summary>
        public static Engine ExpressionTree(this Engine en, string? name = null)
        {
            return en.Execute("ExpressionTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts exponentials in expr to trigonometric functions.
        ///https://reference.wolfram.com/language/ref/ExpToTrig.html
        ///</summary>
        public static Engine ExpToTrig(this Engine en, string? name = null)
        {
            return en.Execute("ExpToTrig[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a bundle of resources to be externally deployed as named URLs, functions, etc.
        ///https://reference.wolfram.com/language/ref/ExternalBundle.html
        ///</summary>
        public static Engine ExternalBundle(this Engine en, string? name = null)
        {
            return en.Execute("ExternalBundle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of ExternalEvaluate that can be applied to a command or object.
        ///https://reference.wolfram.com/language/ref/ExternalEvaluate.html
        ///</summary>
        public static Engine ExternalEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("ExternalEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an external object inside an ExternalSessionObject.
        ///https://reference.wolfram.com/language/ref/ExternalObject.html
        ///</summary>
        public static Engine ExternalObject(this Engine en, string? name = null)
        {
            return en.Execute("ExternalObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an external session started by StartExternalSession for use with ExternalEvaluate.
        ///https://reference.wolfram.com/language/ref/ExternalSessionObject.html
        ///</summary>
        public static Engine ExternalSessionObject(this Engine en, string? name = null)
        {
            return en.Execute("ExternalSessionObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of sessions associated with the system sys.
        ///https://reference.wolfram.com/language/ref/ExternalSessions.html
        ///</summary>
        public static Engine ExternalSessions(this Engine en, string? name = null)
        {
            return en.Execute("ExternalSessions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///downloads content from the specified location.
        ///https://reference.wolfram.com/language/ref/ExternalStorageDownload.html
        ///</summary>
        public static Engine ExternalStorageDownload(this Engine en, string? name = null)
        {
            return en.Execute("ExternalStorageDownload[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads in an expression stored at an external storage specified by the ExternalStorageObject.
        ///https://reference.wolfram.com/language/ref/ExternalStorageGet.html
        ///</summary>
        public static Engine ExternalStorageGet(this Engine en, string? name = null)
        {
            return en.Execute("ExternalStorageGet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a file stored in an external location.
        ///https://reference.wolfram.com/language/ref/ExternalStorageObject.html
        ///</summary>
        public static Engine ExternalStorageObject(this Engine en, string? name = null)
        {
            return en.Execute("ExternalStorageObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///writes expr to an external storage specified by $ExternalStorageBase.
        ///https://reference.wolfram.com/language/ref/ExternalStoragePut.html
        ///</summary>
        public static Engine ExternalStoragePut(this Engine en, string? name = null)
        {
            return en.Execute("ExternalStoragePut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///uploads file to an external storage specified by $ExternalStorageBase.
        ///https://reference.wolfram.com/language/ref/ExternalStorageUpload.html
        ///</summary>
        public static Engine ExternalStorageUpload(this Engine en, string? name = null)
        {
            return en.Execute("ExternalStorageUpload[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of Extract that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Extract.html
        ///</summary>
        public static Engine Extract(this Engine en, string? name = null)
        {
            return en.Execute("Extract[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///expands an archive file, saving its content into the current directory.
        ///https://reference.wolfram.com/language/ref/ExtractArchive.html
        ///</summary>
        public static Engine ExtractArchive(this Engine en, string? name = null)
        {
            return en.Execute("ExtractArchive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///extracts the contents of the paclet archive file into the directory in which file resides.
        ///https://reference.wolfram.com/language/ref/ExtractPacletArchive.html
        ///</summary>
        public static Engine ExtractPacletArchive(this Engine en, string? name = null)
        {
            return en.Execute("ExtractPacletArchive[" + en.ValidNames.Last() + "]", name);
        }


    }
}
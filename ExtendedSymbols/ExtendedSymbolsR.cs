namespace NetWolf
{
    public static class ExtendedSymbolsR
    {
        ///<summary>
        ///generates a radial axis plot where the yi are displayed on radial axes equally spaced around the origin.
        ///https://reference.wolfram.com/language/ref/RadialAxisPlot.html
        ///</summary>
        public static Engine RadialAxisPlot(this Engine en, string? name = null)
        {
            return en.Execute("RadialAxisPlot[" + en.ValidNames.Last() + "]", name);
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
        ///returns an image with values radially changing from center to corners based on gradient color gcol.
        ///https://reference.wolfram.com/language/ref/RadialGradientImage.html
        ///</summary>
        public static Engine RadialGradientImage(this Engine en, string? name = null)
        {
            return en.Execute("RadialGradientImage[" + en.ValidNames.Last() + "]", name);
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
        ///gives an image representing the discrete Radon transform of image.
        ///https://reference.wolfram.com/language/ref/Radon.html
        ///</summary>
        public static Engine Radon(this Engine en, string? name = null)
        {
            return en.Execute("Radon[" + en.ValidNames.Last() + "]", name);
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
        ///gives the Ramanujan tau Dirichlet L-function .
        ///https://reference.wolfram.com/language/ref/RamanujanTauL.html
        ///</summary>
        public static Engine RamanujanTauL(this Engine en, string? name = null)
        {
            return en.Execute("RamanujanTauL[" + en.ValidNames.Last() + "]", name);
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
        ///gives the Ramanujan tau Z-function .
        ///https://reference.wolfram.com/language/ref/RamanujanTauZ.html
        ///</summary>
        public static Engine RamanujanTauZ(this Engine en, string? name = null)
        {
            return en.Execute("RamanujanTauZ[" + en.ValidNames.Last() + "]", name);
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
        ///represents a net layer that has no input and produces a random array from the univariate distribution dist.
        ///https://reference.wolfram.com/language/ref/RandomArrayLayer.html
        ///</summary>
        public static Engine RandomArrayLayer(this Engine en, string? name = null)
        {
            return en.Execute("RandomArrayLayer[" + en.ValidNames.Last() + "]", name);
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
        ///gives n pseudorandom colors.
        ///https://reference.wolfram.com/language/ref/RandomColor.html
        ///</summary>
        public static Engine RandomColor(this Engine en, string? name = null)
        {
            return en.Execute("RandomColor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom complex number in the rectangle with corners given by the complex numbers zmin and zmax.
        ///https://reference.wolfram.com/language/ref/RandomComplex.html
        ///</summary>
        public static Engine RandomComplex(this Engine en, string? name = null)
        {
            return en.Execute("RandomComplex[" + en.ValidNames.Last() + "]", name);
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
        ///gives a representation of the internal state of a pseudorandom generator.
        ///https://reference.wolfram.com/language/ref/RandomGeneratorState.html
        ///</summary>
        public static Engine RandomGeneratorState(this Engine en, string? name = null)
        {
            return en.Execute("RandomGeneratorState[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom geo position uniformly distributed in the geo region g.
        ///https://reference.wolfram.com/language/ref/RandomGeoPosition.html
        ///</summary>
        public static Engine RandomGeoPosition(this Engine en, string? name = null)
        {
            return en.Execute("RandomGeoPosition[" + en.ValidNames.Last() + "]", name);
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
        ///gives an image with pseudorandom pixel values in the range 0 to max.
        ///https://reference.wolfram.com/language/ref/RandomImage.html
        ///</summary>
        public static Engine RandomImage(this Engine en, string? name = null)
        {
            return en.Execute("RandomImage[" + en.ValidNames.Last() + "]", name);
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
        ///gives a pseudorandom integer in the range {imin,imax}.
        ///https://reference.wolfram.com/language/ref/RandomInteger.html
        ///</summary>
        public static Engine RandomInteger(this Engine en, string? name = null)
        {
            return en.Execute("RandomInteger[" + en.ValidNames.Last() + "]", name);
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
        ///gives a pseudorandom point uniformly distributed in the region reg.
        ///https://reference.wolfram.com/language/ref/RandomPoint.html
        ///</summary>
        public static Engine RandomPoint(this Engine en, string? name = null)
        {
            return en.Execute("RandomPoint[" + en.ValidNames.Last() + "]", name);
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
        ///gives a pseudorandom polyhedron with the specified specification spec.
        ///https://reference.wolfram.com/language/ref/RandomPolyhedron.html
        ///</summary>
        public static Engine RandomPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("RandomPolyhedron[" + en.ValidNames.Last() + "]", name);
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
        ///gives a pseudorandom real number in the range xmin to xmax.
        ///https://reference.wolfram.com/language/ref/RandomReal.html
        ///</summary>
        public static Engine RandomReal(this Engine en, string? name = null)
        {
            return en.Execute("RandomReal[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a pseudorandom permutation of the ei.
        ///https://reference.wolfram.com/language/ref/RandomSample.html
        ///</summary>
        public static Engine RandomSample(this Engine en, string? name = null)
        {
            return en.Execute("RandomSample[" + en.ValidNames.Last() + "]", name);
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
        ///gives a pseudorandom variate from the symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/RandomVariate.html
        ///</summary>
        public static Engine RandomVariate(this Engine en, string? name = null)
        {
            return en.Execute("RandomVariate[" + en.ValidNames.Last() + "]", name);
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
        ///gives a list of n pseudorandom words.
        ///https://reference.wolfram.com/language/ref/RandomWord.html
        ///</summary>
        public static Engine RandomWord(this Engine en, string? name = null)
        {
            return en.Execute("RandomWord[" + en.ValidNames.Last() + "]", name);
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
        ///is a two-dimensional graphics primitive which represents a rectangular array of gray cells.
        ///https://reference.wolfram.com/language/ref/Raster.html
        ///</summary>
        public static Engine Raster(this Engine en, string? name = null)
        {
            return en.Execute("Raster[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics primitive that represents a cubical array of gray cells.
        ///https://reference.wolfram.com/language/ref/Raster3D.html
        ///</summary>
        public static Engine Raster3D(this Engine en, string? name = null)
        {
            return en.Execute("Raster3D[" + en.ValidNames.Last() + "]", name);
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
        ///converts an approximate number x to a nearby rational with small denominator.
        ///https://reference.wolfram.com/language/ref/Rationalize.html
        ///</summary>
        public static Engine Rationalize(this Engine en, string? name = null)
        {
            return en.Execute("Rationalize[" + en.ValidNames.Last() + "]", name);
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
        ///is a low-level construct which is formatted as boxes without further interpretation.
        ///https://reference.wolfram.com/language/ref/RawBoxes.html
        ///</summary>
        public static Engine RawBoxes(this Engine en, string? name = null)
        {
            return en.Execute("RawBoxes[" + en.ValidNames.Last() + "]", name);
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
        ///represents the Rayleigh distribution with scale parameter σ.
        ///https://reference.wolfram.com/language/ref/RayleighDistribution.html
        ///</summary>
        public static Engine RayleighDistribution(this Engine en, string? name = null)
        {
            return en.Execute("RayleighDistribution[" + en.ValidNames.Last() + "]", name);
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
        ///returns a version of the reaction rxn in which the stoichiometric coefficients for elements in the reactants and products are balanced.
        ///https://reference.wolfram.com/language/ref/ReactionBalance.html
        ///</summary>
        public static Engine ReactionBalance(this Engine en, string? name = null)
        {
            return en.Execute("ReactionBalance[" + en.ValidNames.Last() + "]", name);
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
        ///reads one expression from an input stream and returns the expression.
        ///https://reference.wolfram.com/language/ref/Read.html
        ///</summary>
        public static Engine Read(this Engine en, string? name = null)
        {
            return en.Execute("Read[" + en.ValidNames.Last() + "]", name);
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
        ///reads a line of text from a file and returns it as a string.
        ///https://reference.wolfram.com/language/ref/ReadLine.html
        ///</summary>
        public static Engine ReadLine(this Engine en, string? name = null)
        {
            return en.Execute("ReadLine[" + en.ValidNames.Last() + "]", name);
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
        ///reads the complete contents of a file and returns it as a string.
        ///https://reference.wolfram.com/language/ref/ReadString.html
        ///</summary>
        public static Engine ReadString(this Engine en, string? name = null)
        {
            return en.Execute("ReadString[" + en.ValidNames.Last() + "]", name);
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
        ///gives a list of the digits in the approximate real number x, together with the number of digits that are to the left of the decimal point.
        ///https://reference.wolfram.com/language/ref/RealDigits.html
        ///</summary>
        public static Engine RealDigits(this Engine en, string? name = null)
        {
            return en.Execute("RealDigits[" + en.ValidNames.Last() + "]", name);
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
        ///gives -1, 0 or 1 depending on whether x is negative, zero or positive.
        ///https://reference.wolfram.com/language/ref/RealSign.html
        ///</summary>
        public static Engine RealSign(this Engine en, string? name = null)
        {
            return en.Execute("RealSign[" + en.ValidNames.Last() + "]", name);
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
        ///reconstructs a mesh from a set of points pt1,pt2,….
        ///https://reference.wolfram.com/language/ref/ReconstructionMesh.html
        ///</summary>
        public static Engine ReconstructionMesh(this Engine en, string? name = null)
        {
            return en.Execute("ReconstructionMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///corresponds to a unit square with its bottom-left corner at {xmin,ymin}.
        ///https://reference.wolfram.com/language/ref/Rectangle.html
        ///</summary>
        public static Engine Rectangle(this Engine en, string? name = null)
        {
            return en.Execute("Rectangle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a rectangle chart from multiple datasets datai.
        ///https://reference.wolfram.com/language/ref/RectangleChart.html
        ///</summary>
        public static Engine RectangleChart(this Engine en, string? name = null)
        {
            return en.Execute("RectangleChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a 3D rectangle chart from multiple datasets datai.
        ///https://reference.wolfram.com/language/ref/RectangleChart3D.html
        ///</summary>
        public static Engine RectangleChart3D(this Engine en, string? name = null)
        {
            return en.Execute("RectangleChart3D[" + en.ValidNames.Last() + "]", name);
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
        ///uses default assumptions specified by any enclosing Assuming constructs.
        ///https://reference.wolfram.com/language/ref/Refine.html
        ///</summary>
        public static Engine Refine(this Engine en, string? name = null)
        {
            return en.Execute("Refine[" + en.ValidNames.Last() + "]", name);
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
        ///gives a TransformationFunction that represents a reflection in a mirror through the origin, normal to the vector v.
        ///https://reference.wolfram.com/language/ref/ReflectionTransform.html
        ///</summary>
        public static Engine ReflectionTransform(this Engine en, string? name = null)
        {
            return en.Execute("ReflectionTransform[" + en.ValidNames.Last() + "]", name);
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
        ///represents the boundary of the region reg.
        ///https://reference.wolfram.com/language/ref/RegionBoundary.html
        ///</summary>
        public static Engine RegionBoundary(this Engine en, string? name = null)
        {
            return en.Execute("RegionBoundary[" + en.ValidNames.Last() + "]", name);
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
        ///gives the centroid of the region reg.
        ///https://reference.wolfram.com/language/ref/RegionCentroid.html
        ///</summary>
        public static Engine RegionCentroid(this Engine en, string? name = null)
        {
            return en.Execute("RegionCentroid[" + en.ValidNames.Last() + "]", name);
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
        ///gives a RegionDistanceFunction[…] that can be applied repeatedly to different points.
        ///https://reference.wolfram.com/language/ref/RegionDistance.html
        ///</summary>
        public static Engine RegionDistance(this Engine en, string? name = null)
        {
            return en.Execute("RegionDistance[" + en.ValidNames.Last() + "]", name);
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
        ///returns a rasterized grayscale 2D or 3D image of reg.
        ///https://reference.wolfram.com/language/ref/RegionImage.html
        ///</summary>
        public static Engine RegionImage(this Engine en, string? name = null)
        {
            return en.Execute("RegionImage[" + en.ValidNames.Last() + "]", name);
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
        ///returns a RegionMemberFunction[…] that can be applied repeatedly to different points.
        ///https://reference.wolfram.com/language/ref/RegionMember.html
        ///</summary>
        public static Engine RegionMember(this Engine en, string? name = null)
        {
            return en.Execute("RegionMember[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a RegionNearestFunction[…] that can be repeatedly applied to points.
        ///https://reference.wolfram.com/language/ref/RegionNearest.html
        ///</summary>
        public static Engine RegionNearest(this Engine en, string? name = null)
        {
            return en.Execute("RegionNearest[" + en.ValidNames.Last() + "]", name);
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
        ///represents the generalized regular expression specified by the string "regex".
        ///https://reference.wolfram.com/language/ref/RegularExpression.html
        ///</summary>
        public static Engine RegularExpression(this Engine en, string? name = null)
        {
            return en.Execute("RegularExpression[" + en.ValidNames.Last() + "]", name);
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
        ///gives the regular polygon with n vertices equally spaced around the unit circle.
        ///https://reference.wolfram.com/language/ref/RegularPolygon.html
        ///</summary>
        public static Engine RegularPolygon(this Engine en, string? name = null)
        {
            return en.Execute("RegularPolygon[" + en.ValidNames.Last() + "]", name);
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
        ///represents schema information about a relational database.
        ///https://reference.wolfram.com/language/ref/RelationalDatabase.html
        ///</summary>
        public static Engine RelationalDatabase(this Engine en, string? name = null)
        {
            return en.Execute("RelationalDatabase[" + en.ValidNames.Last() + "]", name);
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
        ///generates a relief image of an array of height values.
        ///https://reference.wolfram.com/language/ref/ReliefImage.html
        ///</summary>
        public static Engine ReliefImage(this Engine en, string? name = null)
        {
            return en.Execute("ReliefImage[" + en.ValidNames.Last() + "]", name);
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
        ///aborts a remote batch job.
        ///https://reference.wolfram.com/language/ref/RemoteBatchJobAbort.html
        ///</summary>
        public static Engine RemoteBatchJobAbort(this Engine en, string? name = null)
        {
            return en.Execute("RemoteBatchJobAbort[" + en.ValidNames.Last() + "]", name);
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
        ///gives a list of RemoteBatchJobObject expressions representing batch jobs submitted using env.
        ///https://reference.wolfram.com/language/ref/RemoteBatchJobs.html
        ///</summary>
        public static Engine RemoteBatchJobs(this Engine en, string? name = null)
        {
            return en.Execute("RemoteBatchJobs[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a submission environment for provider with default optional properties.
        ///https://reference.wolfram.com/language/ref/RemoteBatchSubmissionEnvironment.html
        ///</summary>
        public static Engine RemoteBatchSubmissionEnvironment(this Engine en, string? name = null)
        {
            return en.Execute("RemoteBatchSubmissionEnvironment[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits expr for evaluation using $DefaultRemoteBatchSubmissionEnvironment.
        ///https://reference.wolfram.com/language/ref/RemoteBatchSubmit.html
        ///</summary>
        public static Engine RemoteBatchSubmit(this Engine en, string? name = null)
        {
            return en.Execute("RemoteBatchSubmit[" + en.ValidNames.Last() + "]", name);
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
        ///is an object that represents a remote connection.
        ///https://reference.wolfram.com/language/ref/RemoteConnectionObject.html
        ///</summary>
        public static Engine RemoteConnectionObject(this Engine en, string? name = null)
        {
            return en.Execute("RemoteConnectionObject[" + en.ValidNames.Last() + "]", name);
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
        ///is a symbolic representation of a file on a remote machine.
        ///https://reference.wolfram.com/language/ref/RemoteFile.html
        ///</summary>
        public static Engine RemoteFile(this Engine en, string? name = null)
        {
            return en.Execute("RemoteFile[" + en.ValidNames.Last() + "]", name);
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
        ///deletes the AudioStream object stream.
        ///https://reference.wolfram.com/language/ref/RemoveAudioStream.html
        ///</summary>
        public static Engine RemoveAudioStream(this Engine en, string? name = null)
        {
            return en.Execute("RemoveAudioStream[" + en.ValidNames.Last() + "]", name);
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
        ///removes obj from the list of currently active channel listeners.
        ///https://reference.wolfram.com/language/ref/RemoveChannelListener.html
        ///</summary>
        public static Engine RemoveChannelListener(this Engine en, string? name = null)
        {
            return en.Execute("RemoveChannelListener[" + en.ValidNames.Last() + "]", name);
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
        ///replaces characters in string that have diacritics by their base ASCII characters, when possible.
        ///https://reference.wolfram.com/language/ref/RemoveDiacritics.html
        ///</summary>
        public static Engine RemoveDiacritics(this Engine en, string? name = null)
        {
            return en.Execute("RemoveDiacritics[" + en.ValidNames.Last() + "]", name);
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
        ///removes a custom output stream method.
        ///https://reference.wolfram.com/language/ref/RemoveOutputStreamMethod.html
        ///</summary>
        public static Engine RemoveOutputStreamMethod(this Engine en, string? name = null)
        {
            return en.Execute("RemoveOutputStreamMethod[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes the VideoStream object stream.
        ///https://reference.wolfram.com/language/ref/RemoveVideoStream.html
        ///</summary>
        public static Engine RemoveVideoStream(this Engine en, string? name = null)
        {
            return en.Execute("RemoveVideoStream[" + en.ValidNames.Last() + "]", name);
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
        ///makes a Renko chart of closing prices for the financial entity "name" over the date range daterange.
        ///https://reference.wolfram.com/language/ref/RenkoChart.html
        ///</summary>
        public static Engine RenkoChart(this Engine en, string? name = null)
        {
            return en.Execute("RenkoChart[" + en.ValidNames.Last() + "]", name);
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
        ///is a pattern object that represents a sequence of one or more expressions, each matching p.
        ///https://reference.wolfram.com/language/ref/Repeated.html
        ///</summary>
        public static Engine Repeated(this Engine en, string? name = null)
        {
            return en.Execute("Repeated[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pattern object that represents a sequence of zero or more expressions, each matching p.
        ///https://reference.wolfram.com/language/ref/RepeatedNull.html
        ///</summary>
        public static Engine RepeatedNull(this Engine en, string? name = null)
        {
            return en.Execute("RepeatedNull[" + en.ValidNames.Last() + "]", name);
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
        ///represents an arbitrarily repeated type of element in an interpreter, API or form specification.
        ///https://reference.wolfram.com/language/ref/RepeatingElement.html
        ///</summary>
        public static Engine RepeatingElement(this Engine en, string? name = null)
        {
            return en.Execute("RepeatingElement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of Replace that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Replace.html
        ///</summary>
        public static Engine Replace(this Engine en, string? name = null)
        {
            return en.Execute("Replace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of ReplaceAll that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/ReplaceAll.html
        ///</summary>
        public static Engine ReplaceAll(this Engine en, string? name = null)
        {
            return en.Execute("ReplaceAll[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form of ReplaceList that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/ReplaceList.html
        ///</summary>
        public static Engine ReplaceList(this Engine en, string? name = null)
        {
            return en.Execute("ReplaceList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of ReplacePart that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/ReplacePart.html
        ///</summary>
        public static Engine ReplacePart(this Engine en, string? name = null)
        {
            return en.Execute("ReplacePart[" + en.ValidNames.Last() + "]", name);
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
        ///rescales each element of list to run from 0 to 1 over the range Min[list] to Max[list].
        ///https://reference.wolfram.com/language/ref/Rescale.html
        ///</summary>
        public static Engine Rescale(this Engine en, string? name = null)
        {
            return en.Execute("Rescale[" + en.ValidNames.Last() + "]", name);
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
        ///represents a layer performing one-dimensional resizing of a two-dimensional array.
        ///https://reference.wolfram.com/language/ref/ResizeLayer.html
        ///</summary>
        public static Engine ResizeLayer(this Engine en, string? name = null)
        {
            return en.Execute("ResizeLayer[" + en.ValidNames.Last() + "]", name);
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
        ///gives the primary content of the specified resource.
        ///https://reference.wolfram.com/language/ref/ResourceData.html
        ///</summary>
        public static Engine ResourceData(this Engine en, string? name = null)
        {
            return en.Execute("ResourceData[" + en.ValidNames.Last() + "]", name);
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
        ///represents a resource with the specified name.
        ///https://reference.wolfram.com/language/ref/ResourceObject.html
        ///</summary>
        public static Engine ResourceObject(this Engine en, string? name = null)
        {
            return en.Execute("ResourceObject[" + en.ValidNames.Last() + "]", name);
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
        ///removes the specified resource from the system on which it is run.
        ///https://reference.wolfram.com/language/ref/ResourceRemove.html
        ///</summary>
        public static Engine ResourceRemove(this Engine en, string? name = null)
        {
            return en.Execute("ResourceRemove[" + en.ValidNames.Last() + "]", name);
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
        ///submits the specified resource object to be reviewed for publication.
        ///https://reference.wolfram.com/language/ref/ResourceSubmit.html
        ///</summary>
        public static Engine ResourceSubmit(this Engine en, string? name = null)
        {
            return en.Execute("ResourceSubmit[" + en.ValidNames.Last() + "]", name);
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
        ///gives expr with the first element removed.
        ///https://reference.wolfram.com/language/ref/Rest.html
        ///</summary>
        public static Engine Rest(this Engine en, string? name = null)
        {
            return en.Execute("Rest[" + en.ValidNames.Last() + "]", name);
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
        ///is a WSTP packet that contains the expression expr, the result of an EnterExpressionPacket evaluation.
        ///https://reference.wolfram.com/language/ref/ReturnExpressionPacket.html
        ///</summary>
        public static Engine ReturnExpressionPacket(this Engine en, string? name = null)
        {
            return en.Execute("ReturnExpressionPacket[" + en.ValidNames.Last() + "]", name);
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
        ///is a WSTP packet containing string, the result of an EnterTextPacket evaluation.
        ///https://reference.wolfram.com/language/ref/ReturnTextPacket.html
        ///</summary>
        public static Engine ReturnTextPacket(this Engine en, string? name = null)
        {
            return en.Execute("ReturnTextPacket[" + en.ValidNames.Last() + "]", name);
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
        ///represents a form of f that takes arguments in reverse order so that ReverseApplied[f][x1,…,xn] is equivalent to f[xn,…,x1].
        ///https://reference.wolfram.com/language/ref/ReverseApplied.html
        ///</summary>
        public static Engine ReverseApplied(this Engine en, string? name = null)
        {
            return en.Execute("ReverseApplied[" + en.ValidNames.Last() + "]", name);
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
        ///sorts the elements of list into reverse canonical order.
        ///https://reference.wolfram.com/language/ref/ReverseSort.html
        ///</summary>
        public static Engine ReverseSort(this Engine en, string? name = null)
        {
            return en.Execute("ReverseSort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of ReverseSortBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/ReverseSortBy.html
        ///</summary>
        public static Engine ReverseSortBy(this Engine en, string? name = null)
        {
            return en.Execute("ReverseSortBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a color from an HTML color name, etc.
        ///https://reference.wolfram.com/language/ref/RGBColor.html
        ///</summary>
        public static Engine RGBColor(this Engine en, string? name = null)
        {
            return en.Execute("RGBColor[" + en.ValidNames.Last() + "]", name);
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
        ///gives the Riemann prime counting function .
        ///https://reference.wolfram.com/language/ref/RiemannR.html
        ///</summary>
        public static Engine RiemannR(this Engine en, string? name = null)
        {
            return en.Execute("RiemannR[" + en.ValidNames.Last() + "]", name);
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
        ///gives the Riemann–Siegel function .
        ///https://reference.wolfram.com/language/ref/RiemannSiegelZ.html
        ///</summary>
        public static Engine RiemannSiegelZ(this Engine en, string? name = null)
        {
            return en.Execute("RiemannSiegelZ[" + en.ValidNames.Last() + "]", name);
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
        ///generates the function  that can be applied repeatedly at different radii r.
        ///https://reference.wolfram.com/language/ref/RipleyK.html
        ///</summary>
        public static Engine RipleyK(this Engine en, string? name = null)
        {
            return en.Execute("RipleyK[" + en.ValidNames.Last() + "]", name);
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
        ///gives the roll-pitch-yaw angles {α,β,γ} corresponding to the rotation matrix r.
        ///https://reference.wolfram.com/language/ref/RollPitchYawAngles.html
        ///</summary>
        public static Engine RollPitchYawAngles(this Engine en, string? name = null)
        {
            return en.Execute("RollPitchYawAngles[" + en.ValidNames.Last() + "]", name);
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
        ///gives a string corresponding to the Roman numeral form of the integer n.
        ///https://reference.wolfram.com/language/ref/RomanNumeral.html
        ///</summary>
        public static Engine RomanNumeral(this Engine en, string? name = null)
        {
            return en.Execute("RomanNumeral[" + en.ValidNames.Last() + "]", name);
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
        ///converts the number x to one of the "simplest" algebraic numbers that approximates it well.
        ///https://reference.wolfram.com/language/ref/RootApproximant.html
        ///</summary>
        public static Engine RootApproximant(this Engine en, string? name = null)
        {
            return en.Execute("RootApproximant[" + en.ValidNames.Last() + "]", name);
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
        ///gives the root mean square of values in list.
        ///https://reference.wolfram.com/language/ref/RootMeanSquare.html
        ///</summary>
        public static Engine RootMeanSquare(this Engine en, string? name = null)
        {
            return en.Execute("RootMeanSquare[" + en.ValidNames.Last() + "]", name);
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
        ///attempts to reduce expr to a single Root object.
        ///https://reference.wolfram.com/language/ref/RootReduce.html
        ///</summary>
        public static Engine RootReduce(this Engine en, string? name = null)
        {
            return en.Execute("RootReduce[" + en.ValidNames.Last() + "]", name);
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
        ///cycles one position to the left.
        ///https://reference.wolfram.com/language/ref/RotateLeft.html
        ///</summary>
        public static Engine RotateLeft(this Engine en, string? name = null)
        {
            return en.Execute("RotateLeft[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///cycles one position to the right.
        ///https://reference.wolfram.com/language/ref/RotateRight.html
        ///</summary>
        public static Engine RotateRight(this Engine en, string? name = null)
        {
            return en.Execute("RotateRight[" + en.ValidNames.Last() + "]", name);
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
        ///gives a TransformationFunction that represents a rotation in 2D by θ radians about the origin.
        ///https://reference.wolfram.com/language/ref/RotationTransform.html
        ///</summary>
        public static Engine RotationTransform(this Engine en, string? name = null)
        {
            return en.Execute("RotationTransform[" + en.ValidNames.Last() + "]", name);
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
        ///is an object that formats with the expri arranged in a row, potentially extending over several lines.
        ///https://reference.wolfram.com/language/ref/Row.html
        ///</summary>
        public static Engine Row(this Engine en, string? name = null)
        {
            return en.Execute("Row[" + en.ValidNames.Last() + "]", name);
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
        ///gives the row‐reduced form of the matrix m.
        ///https://reference.wolfram.com/language/ref/RowReduce.html
        ///</summary>
        public static Engine RowReduce(this Engine en, string? name = null)
        {
            return en.Execute("RowReduce[" + en.ValidNames.Last() + "]", name);
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
        ///generates a plot representing the rule for the computational system sys.
        ///https://reference.wolfram.com/language/ref/RulePlot.html
        ///</summary>
        public static Engine RulePlot(this Engine en, string? name = null)
        {
            return en.Execute("RulePlot[" + en.ValidNames.Last() + "]", name);
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
        ///runs command as an external operating system command, returning the exit code obtained.
        ///https://reference.wolfram.com/language/ref/Run.html
        ///</summary>
        public static Engine Run(this Engine en, string? name = null)
        {
            return en.Execute("Run[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///runs the specified external command, returning information on the outcome.
        ///https://reference.wolfram.com/language/ref/RunProcess.html
        ///</summary>
        public static Engine RunProcess(this Engine en, string? name = null)
        {
            return en.Execute("RunProcess[" + en.ValidNames.Last() + "]", name);
        }


    }
}
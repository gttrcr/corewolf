using System.Collections.Generic;

namespace CoreWolf
{
    public static class ExtendedFunctionsA
    {
        ///<summary>
        /// evaluates expr, saving any aborts until the evaluation is complete.
        /// https://reference.wolfram.com/language/ref/AbortProtect.html
        ///</summary>
        public static Engine AbortProtect(this Engine en, string? name = null)
        {
            return en.Execute("AbortProtect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the absolute value of the real or complex number z.
        /// https://reference.wolfram.com/language/ref/Abs.html
        ///</summary>
        public static Engine Abs(this Engine en, string? name = null)
        {
            return en.Execute("Abs[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list {Abs[z],Arg[z]} of the number z.
        /// https://reference.wolfram.com/language/ref/AbsArg.html
        ///</summary>
        public static Engine AbsArg(this Engine en, string? name = null)
        {
            return en.Execute("AbsArg[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the absolute correlation matrix for the matrix m.
        /// https://reference.wolfram.com/language/ref/AbsoluteCorrelation.html
        ///</summary>
        public static Engine AbsoluteCorrelation(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteCorrelation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the absolute current value of item at a location in the Wolfram System and interface.
        /// https://reference.wolfram.com/language/ref/AbsoluteCurrentValue.html
        ///</summary>
        public static Engine AbsoluteCurrentValue(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteCurrentValue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive which specifies that lines which follow are to be drawn dashed, with successive segments having absolute lengths d1, d2, … (repeated cyclically).
        /// https://reference.wolfram.com/language/ref/AbsoluteDashing.html
        ///</summary>
        public static Engine AbsoluteDashing(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteDashing[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the full absolute version of the name for a file in your filesystem.
        /// https://reference.wolfram.com/language/ref/AbsoluteFileName.html
        ///</summary>
        public static Engine AbsoluteFileName(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteFileName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the absolute settings of options specified in an expression such as a graphics object.
        /// https://reference.wolfram.com/language/ref/AbsoluteOptions.html
        ///</summary>
        public static Engine AbsoluteOptions(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteOptions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive which specifies that points which follow are to be shown if possible as circular regions with absolute diameter d.
        /// https://reference.wolfram.com/language/ref/AbsolutePointSize.html
        ///</summary>
        public static Engine AbsolutePointSize(this Engine en, string? name = null)
        {
            return en.Execute("AbsolutePointSize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive which specifies that lines which follow are to be drawn with absolute thickness d.
        /// https://reference.wolfram.com/language/ref/AbsoluteThickness.html
        ///</summary>
        public static Engine AbsoluteThickness(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteThickness[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the absolute time specification corresponding to the given date specification.
        /// https://reference.wolfram.com/language/ref/AbsoluteTime.html
        ///</summary>
        public static Engine AbsoluteTime(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates expr, returning a list of the absolute number of seconds in real time that have elapsed, together with the result obtained.
        /// https://reference.wolfram.com/language/ref/AbsoluteTiming.html
        ///</summary>
        public static Engine AbsoluteTiming(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteTiming[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints with all numbers in expr given in standard accounting notation.
        /// https://reference.wolfram.com/language/ref/AccountingForm.html
        ///</summary>
        public static Engine AccountingForm(this Engine en, string? name = null)
        {
            return en.Execute("AccountingForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the successive accumulated totals of elements in list.
        /// https://reference.wolfram.com/language/ref/Accumulate.html
        ///</summary>
        public static Engine Accumulate(this Engine en, string? name = null)
        {
            return en.Execute("Accumulate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the effective number of digits to the right of the decimal point in the number x.
        /// https://reference.wolfram.com/language/ref/Accuracy.html
        ///</summary>
        public static Engine Accuracy(this Engine en, string? name = null)
        {
            return en.Execute("Accuracy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// replaces all instances of Inactive[f] in expr with f.
        /// https://reference.wolfram.com/language/ref/Activate.html
        ///</summary>
        public static Engine Activate(this Engine en, string? name = null)
        {
            return en.Execute("Activate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the result of an ActiveClassification process.
        /// https://reference.wolfram.com/language/ref/ActiveClassificationObject.html
        ///</summary>
        public static Engine ActiveClassificationObject(this Engine en, string? name = null)
        {
            return en.Execute("ActiveClassificationObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the result of an ActivePrediction process.
        /// https://reference.wolfram.com/language/ref/ActivePredictionObject.html
        ///</summary>
        public static Engine ActivePredictionObject(this Engine en, string? name = null)
        {
            return en.Execute("ActivePredictionObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is an acyclic graph and False otherwise.
        /// https://reference.wolfram.com/language/ref/AcyclicGraphQ.html
        ///</summary>
        public static Engine AcyclicGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("AcyclicGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the graph with adjacency matrix amat.
        /// https://reference.wolfram.com/language/ref/AdjacencyGraph.html
        ///</summary>
        public static Engine AdjacencyGraph(this Engine en, string? name = null)
        {
            return en.Execute("AdjacencyGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the vertex–vertex adjacency matrix of the graph g.
        /// https://reference.wolfram.com/language/ref/AdjacencyMatrix.html
        ///</summary>
        public static Engine AdjacencyMatrix(this Engine en, string? name = null)
        {
            return en.Execute("AdjacencyMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the adjugate of a square matrix m.
        /// https://reference.wolfram.com/language/ref/Adjugate.html
        ///</summary>
        public static Engine Adjugate(this Engine en, string? name = null)
        {
            return en.Execute("Adjugate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the affine space passing through the points pi.
        /// https://reference.wolfram.com/language/ref/AffineSpace.html
        ///</summary>
        public static Engine AffineSpace(this Engine en, string? name = null)
        {
            return en.Execute("AffineSpace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an affine state-space model corresponding to the system model sys.
        /// https://reference.wolfram.com/language/ref/AffineStateSpaceModel.html
        ///</summary>
        public static Engine AffineStateSpaceModel(this Engine en, string? name = null)
        {
            return en.Execute("AffineStateSpaceModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a TransformationFunction that represents an affine transform that maps r to m.r.
        /// https://reference.wolfram.com/language/ref/AffineTransform.html
        ///</summary>
        public static Engine AffineTransform(this Engine en, string? name = null)
        {
            return en.Execute("AffineTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a layer that aggregates an array of arbitrary rank into a vector, using the function f.
        /// https://reference.wolfram.com/language/ref/AggregationLayer.html
        ///</summary>
        public static Engine AggregationLayer(this Engine en, string? name = null)
        {
            return en.Execute("AggregationLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the air pressure value for the specified time near the current location.
        /// https://reference.wolfram.com/language/ref/AirPressureData.html
        ///</summary>
        public static Engine AirPressureData(this Engine en, string? name = null)
        {
            return en.Execute("AirPressureData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the air temperature value for the specified time near the current location.
        /// https://reference.wolfram.com/language/ref/AirTemperatureData.html
        ///</summary>
        public static Engine AirTemperatureData(this Engine en, string? name = null)
        {
            return en.Execute("AirTemperatureData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Airy function .
        /// https://reference.wolfram.com/language/ref/AiryAi.html
        ///</summary>
        public static Engine AiryAi(this Engine en, string? name = null)
        {
            return en.Execute("AiryAi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the derivative of the Airy function .
        /// https://reference.wolfram.com/language/ref/AiryAiPrime.html
        ///</summary>
        public static Engine AiryAiPrime(this Engine en, string? name = null)
        {
            return en.Execute("AiryAiPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the k zero of the Airy function .
        /// https://reference.wolfram.com/language/ref/AiryAiZero.html
        ///</summary>
        public static Engine AiryAiZero(this Engine en, string? name = null)
        {
            return en.Execute("AiryAiZero[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Airy function .
        /// https://reference.wolfram.com/language/ref/AiryBi.html
        ///</summary>
        public static Engine AiryBi(this Engine en, string? name = null)
        {
            return en.Execute("AiryBi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the derivative of the Airy function .
        /// https://reference.wolfram.com/language/ref/AiryBiPrime.html
        ///</summary>
        public static Engine AiryBiPrime(this Engine en, string? name = null)
        {
            return en.Execute("AiryBiPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the k zero of the Airy function .
        /// https://reference.wolfram.com/language/ref/AiryBiZero.html
        ///</summary>
        public static Engine AiryBiZero(this Engine en, string? name = null)
        {
            return en.Execute("AiryBiZero[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if a is an algebraic integer, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/AlgebraicIntegerQ.html
        ///</summary>
        public static Engine AlgebraicIntegerQ(this Engine en, string? name = null)
        {
            return en.Execute("AlgebraicIntegerQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the smallest positive integer n such that n a is an algebraic integer.
        /// https://reference.wolfram.com/language/ref/AlgebraicNumberDenominator.html
        ///</summary>
        public static Engine AlgebraicNumberDenominator(this Engine en, string? name = null)
        {
            return en.Execute("AlgebraicNumberDenominator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the norm of the algebraic number a.
        /// https://reference.wolfram.com/language/ref/AlgebraicNumberNorm.html
        ///</summary>
        public static Engine AlgebraicNumberNorm(this Engine en, string? name = null)
        {
            return en.Execute("AlgebraicNumberNorm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the trace of the algebraic number a.
        /// https://reference.wolfram.com/language/ref/AlgebraicNumberTrace.html
        ///</summary>
        public static Engine AlgebraicNumberTrace(this Engine en, string? name = null)
        {
            return en.Execute("AlgebraicNumberTrace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if a is an algebraic unit, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/AlgebraicUnitQ.html
        ///</summary>
        public static Engine AlgebraicUnitQ(this Engine en, string? name = null)
        {
            return en.Execute("AlgebraicUnitQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of AllTrue that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/AllTrue.html
        ///</summary>
        public static Engine AllTrue(this Engine en, string? name = null)
        {
            return en.Execute("AllTrue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the alphabet for the language or class type.
        /// https://reference.wolfram.com/language/ref/Alphabet.html
        ///</summary>
        public static Engine Alphabet(this Engine en, string? name = null)
        {
            return en.Execute("Alphabet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form that compares strings when applied to "string1", "string2".
        /// https://reference.wolfram.com/language/ref/AlphabeticOrder.html
        ///</summary>
        public static Engine AlphabeticOrder(this Engine en, string? name = null)
        {
            return en.Execute("AlphabeticOrder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// sorts the elements of list into alphabetical order.
        /// https://reference.wolfram.com/language/ref/AlphabeticSort.html
        ///</summary>
        public static Engine AlphabeticSort(this Engine en, string? name = null)
        {
            return en.Execute("AlphabeticSort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the opacity of color.
        /// https://reference.wolfram.com/language/ref/AlphaChannel.html
        ///</summary>
        public static Engine AlphaChannel(this Engine en, string? name = null)
        {
            return en.Execute("AlphaChannel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the alternating factorial .
        /// https://reference.wolfram.com/language/ref/AlternatingFactorial.html
        ///</summary>
        public static Engine AlternatingFactorial(this Engine en, string? name = null)
        {
            return en.Execute("AlternatingFactorial[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the alternating group of degree n.
        /// https://reference.wolfram.com/language/ref/AlternatingGroup.html
        ///</summary>
        public static Engine AlternatingGroup(this Engine en, string? name = null)
        {
            return en.Execute("AlternatingGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a three-dimensional graphics directive that specifies the uniform ambient light of color col to use in coloring 3D surfaces.
        /// https://reference.wolfram.com/language/ref/AmbientLight.html
        ///</summary>
        public static Engine AmbientLight(this Engine en, string? name = null)
        {
            return en.Execute("AmbientLight[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents possible results derived from an ambiguous semantic interpretation.
        /// https://reference.wolfram.com/language/ref/AmbiguityList.html
        ///</summary>
        public static Engine AmbiguityList(this Engine en, string? name = null)
        {
            return en.Execute("AmbiguityList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive used in AnatomyPlot3D that specifies how anatomy entity‐based graphics objects are to be drawn using the graphics directive or association of directives g.
        /// https://reference.wolfram.com/language/ref/AnatomyStyling.html
        ///</summary>
        public static Engine AnatomyStyling(this Engine en, string? name = null)
        {
            return en.Execute("AnatomyStyling[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether data is normally distributed using the Anderson–Darling test.
        /// https://reference.wolfram.com/language/ref/AndersonDarlingTest.html
        ///</summary>
        public static Engine AndersonDarlingTest(this Engine en, string? name = null)
        {
            return en.Execute("AndersonDarlingTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the bisector of the interior angle at p formed by the triangle with vertex points p, q1 and q2.
        /// https://reference.wolfram.com/language/ref/AngleBisector.html
        ///</summary>
        public static Engine AngleBisector(this Engine en, string? name = null)
        {
            return en.Execute("AngleBisector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list of 2D coordinates corresponding to a path that starts at {0,0}, then takes a series of steps of unit length at successive relative angles θi.
        /// https://reference.wolfram.com/language/ref/AnglePath.html
        ///</summary>
        public static Engine AnglePath(this Engine en, string? name = null)
        {
            return en.Execute("AnglePath[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// takes the successive rotations to be specified by the 3D rotation matrices mati.
        /// https://reference.wolfram.com/language/ref/AnglePath3D.html
        ///</summary>
        public static Engine AnglePath3D(this Engine en, string? name = null)
        {
            return en.Execute("AnglePath3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list representing the 2D unit vector at angle θ relative to the  axis.
        /// https://reference.wolfram.com/language/ref/AngleVector.html
        ///</summary>
        public static Engine AngleVector(this Engine en, string? name = null)
        {
            return en.Execute("AngleVector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// draws a gauge showing value in the range 0 to 1.
        /// https://reference.wolfram.com/language/ref/AngularGauge.html
        ///</summary>
        public static Engine AngularGauge(this Engine en, string? name = null)
        {
            return en.Execute("AngularGauge[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates an animation whose frames are the successive imagei.
        /// https://reference.wolfram.com/language/ref/AnimatedImage.html
        ///</summary>
        public static Engine AnimatedImage(this Engine en, string? name = null)
        {
            return en.Execute("AnimatedImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an object that displays with the value of u being continually increased from 0 to 1 with time.
        /// https://reference.wolfram.com/language/ref/Animator.html
        ///</summary>
        public static Engine Animator(this Engine en, string? name = null)
        {
            return en.Execute("Animator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// deletes all annotations of the object obj.
        /// https://reference.wolfram.com/language/ref/AnnotationDelete.html
        ///</summary>
        public static Engine AnnotationDelete(this Engine en, string? name = null)
        {
            return en.Execute("AnnotationDelete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// lists all annotation keys available for the object obj.
        /// https://reference.wolfram.com/language/ref/AnnotationKeys.html
        ///</summary>
        public static Engine AnnotationKeys(this Engine en, string? name = null)
        {
            return en.Execute("AnnotationKeys[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates an AnomalyDetectorFunction[…] based on the examples given.
        /// https://reference.wolfram.com/language/ref/AnomalyDetection.html
        ///</summary>
        public static Engine AnomalyDetection(this Engine en, string? name = null)
        {
            return en.Execute("AnomalyDetection[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a function generated by AnomalyDetection for detecting whether data is anomalous or not.
        /// https://reference.wolfram.com/language/ref/AnomalyDetectorFunction.html
        ///</summary>
        public static Engine AnomalyDetectorFunction(this Engine en, string? name = null)
        {
            return en.Execute("AnomalyDetectorFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the symmetry of an antihermitian matrix.
        /// https://reference.wolfram.com/language/ref/Antihermitian.html
        ///</summary>
        public static Engine Antihermitian(this Engine en, string? name = null)
        {
            return en.Execute("Antihermitian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is explicitly antihermitian, and False otherwise.
        /// https://reference.wolfram.com/language/ref/AntihermitianMatrixQ.html
        ///</summary>
        public static Engine AntihermitianMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("AntihermitianMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the symmetry of a tensor that is antisymmetric in the slots si.
        /// https://reference.wolfram.com/language/ref/Antisymmetric.html
        ///</summary>
        public static Engine Antisymmetric(this Engine en, string? name = null)
        {
            return en.Execute("Antisymmetric[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is explicitly antisymmetric, and False otherwise.
        /// https://reference.wolfram.com/language/ref/AntisymmetricMatrixQ.html
        ///</summary>
        public static Engine AntisymmetricMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("AntisymmetricMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the antonyms associated with the specified word.
        /// https://reference.wolfram.com/language/ref/Antonyms.html
        ///</summary>
        public static Engine Antonyms(this Engine en, string? name = null)
        {
            return en.Execute("Antonyms[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an element in an interpreter or form that accepts any subset of the choices ci.
        /// https://reference.wolfram.com/language/ref/AnySubset.html
        ///</summary>
        public static Engine AnySubset(this Engine en, string? name = null)
        {
            return en.Execute("AnySubset[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of AnyTrue that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/AnyTrue.html
        ///</summary>
        public static Engine AnyTrue(this Engine en, string? name = null)
        {
            return en.Execute("AnyTrue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// rewrites a rational expression as a sum of terms with minimal denominators.
        /// https://reference.wolfram.com/language/ref/Apart.html
        ///</summary>
        public static Engine Apart(this Engine en, string? name = null)
        {
            return en.Execute("Apart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// rewrites a rational expression as a sum of terms whose denominators are powers of square-free polynomials.
        /// https://reference.wolfram.com/language/ref/ApartSquareFree.html
        ///</summary>
        public static Engine ApartSquareFree(this Engine en, string? name = null)
        {
            return en.Execute("ApartSquareFree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of Append that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/Append.html
        ///</summary>
        public static Engine Append(this Engine en, string? name = null)
        {
            return en.Execute("Append[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of Apply that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/Apply.html
        ///</summary>
        public static Engine Apply(this Engine en, string? name = null)
        {
            return en.Execute("Apply[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of ApplyReaction that can be applied to a list of molecules.
        /// https://reference.wolfram.com/language/ref/ApplyReaction.html
        ///</summary>
        public static Engine ApplyReaction(this Engine en, string? name = null)
        {
            return en.Execute("ApplyReaction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the arc cosine  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcCos.html
        ///</summary>
        public static Engine ArcCos(this Engine en, string? name = null)
        {
            return en.Execute("ArcCos[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse hyperbolic cosine  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcCosh.html
        ///</summary>
        public static Engine ArcCosh(this Engine en, string? name = null)
        {
            return en.Execute("ArcCosh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the arc cotangent  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcCot.html
        ///</summary>
        public static Engine ArcCot(this Engine en, string? name = null)
        {
            return en.Execute("ArcCot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse hyperbolic cotangent  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcCoth.html
        ///</summary>
        public static Engine ArcCoth(this Engine en, string? name = null)
        {
            return en.Execute("ArcCoth[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the arc cosecant  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcCsc.html
        ///</summary>
        public static Engine ArcCsc(this Engine en, string? name = null)
        {
            return en.Execute("ArcCsc[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse hyperbolic cosecant  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcCsch.html
        ///</summary>
        public static Engine ArcCsch(this Engine en, string? name = null)
        {
            return en.Execute("ArcCsch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the length of the one-dimensional region reg.
        /// https://reference.wolfram.com/language/ref/ArcLength.html
        ///</summary>
        public static Engine ArcLength(this Engine en, string? name = null)
        {
            return en.Execute("ArcLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the arc secant  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcSec.html
        ///</summary>
        public static Engine ArcSec(this Engine en, string? name = null)
        {
            return en.Execute("ArcSec[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse hyperbolic secant  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcSech.html
        ///</summary>
        public static Engine ArcSech(this Engine en, string? name = null)
        {
            return en.Execute("ArcSech[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the arc sine  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcSin.html
        ///</summary>
        public static Engine ArcSin(this Engine en, string? name = null)
        {
            return en.Execute("ArcSin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the arc sine distribution supported between xmin and xmax.
        /// https://reference.wolfram.com/language/ref/ArcSinDistribution.html
        ///</summary>
        public static Engine ArcSinDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ArcSinDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse hyperbolic sine  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcSinh.html
        ///</summary>
        public static Engine ArcSinh(this Engine en, string? name = null)
        {
            return en.Execute("ArcSinh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the arc tangent  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcTan.html
        ///</summary>
        public static Engine ArcTan(this Engine en, string? name = null)
        {
            return en.Execute("ArcTan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse hyperbolic tangent  of the complex number .
        /// https://reference.wolfram.com/language/ref/ArcTanh.html
        ///</summary>
        public static Engine ArcTanh(this Engine en, string? name = null)
        {
            return en.Execute("ArcTanh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the area of the two-dimensional region reg.
        /// https://reference.wolfram.com/language/ref/Area.html
        ///</summary>
        public static Engine Area(this Engine en, string? name = null)
        {
            return en.Execute("Area[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the argument of the complex number z.
        /// https://reference.wolfram.com/language/ref/Arg.html
        ///</summary>
        public static Engine Arg(this Engine en, string? name = null)
        {
            return en.Execute("Arg[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an approximate number or quantity around the mean of the distribution dist, with an uncertainty corresponding to the standard deviation of the distribution.
        /// https://reference.wolfram.com/language/ref/Around.html
        ///</summary>
        public static Engine Around(this Engine en, string? name = null)
        {
            return en.Execute("Around[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an array in which all identical elements of array are replaced by an integer index representing the component in which the element lies.
        /// https://reference.wolfram.com/language/ref/ArrayComponents.html
        ///</summary>
        public static Engine ArrayComponents(this Engine en, string? name = null)
        {
            return en.Execute("ArrayComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the depth to which expr is a full array, with all the parts at a particular level having the same length.
        /// https://reference.wolfram.com/language/ref/ArrayDepth.html
        ///</summary>
        public static Engine ArrayDepth(this Engine en, string? name = null)
        {
            return en.Execute("ArrayDepth[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a mesh region from an array of rank d in which each cell has a geometric dimension d and represents a nonzero value of the array.
        /// https://reference.wolfram.com/language/ref/ArrayMesh.html
        ///</summary>
        public static Engine ArrayMesh(this Engine en, string? name = null)
        {
            return en.Execute("ArrayMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a plot in which the values in an array are shown in a discrete array of squares.
        /// https://reference.wolfram.com/language/ref/ArrayPlot.html
        ///</summary>
        public static Engine ArrayPlot(this Engine en, string? name = null)
        {
            return en.Execute("ArrayPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a plot in which the values in an array are shown in a discrete array of cubes.
        /// https://reference.wolfram.com/language/ref/ArrayPlot3D.html
        ///</summary>
        public static Engine ArrayPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ArrayPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is a full array or a SparseArray object, and gives False otherwise.
        /// https://reference.wolfram.com/language/ref/ArrayQ.html
        ///</summary>
        public static Engine ArrayQ(this Engine en, string? name = null)
        {
            return en.Execute("ArrayQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the rules {pos1val1,pos2val2,…} specifying elements in a sparse array.
        /// https://reference.wolfram.com/language/ref/ArrayRules.html
        ///</summary>
        public static Engine ArrayRules(this Engine en, string? name = null)
        {
            return en.Execute("ArrayRules[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the domain of arrays of rank r and dimensions di.
        /// https://reference.wolfram.com/language/ref/Arrays.html
        ///</summary>
        public static Engine Arrays(this Engine en, string? name = null)
        {
            return en.Execute("Arrays[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics primitive that represents an arrow from pt1 to pt2.
        /// https://reference.wolfram.com/language/ref/Arrow.html
        ///</summary>
        public static Engine Arrow(this Engine en, string? name = null)
        {
            return en.Execute("Arrow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive specifying that arrows that follow should have arrowheads with sizes, positions, and forms specified by spec.
        /// https://reference.wolfram.com/language/ref/Arrowheads.html
        ///</summary>
        public static Engine Arrowheads(this Engine en, string? name = null)
        {
            return en.Execute("Arrowheads[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a construct for use inside AskFunction that gives the value associated with key, or interactively asks for it if it is not already known.
        /// https://reference.wolfram.com/language/ref/Ask.html
        ///</summary>
        public static Engine Ask(this Engine en, string? name = null)
        {
            return en.Execute("Ask[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a construct for use inside AskFunction that asks for a new value, appends it to the current value associated with "key", and returns the resulting list.
        /// https://reference.wolfram.com/language/ref/AskAppend.html
        ///</summary>
        public static Engine AskAppend(this Engine en, string? name = null)
        {
            return en.Execute("AskAppend[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a construct for use inside AskFunction that asks for confirmation of the current value associated with "key" and allows this to be either confirmed or changed.
        /// https://reference.wolfram.com/language/ref/AskConfirm.html
        ///</summary>
        public static Engine AskConfirm(this Engine en, string? name = null)
        {
            return en.Execute("AskConfirm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a construct for use inside AskFunction that displays the result of evaluating expr in the context of the AskFunction.
        /// https://reference.wolfram.com/language/ref/AskDisplay.html
        ///</summary>
        public static Engine AskDisplay(this Engine en, string? name = null)
        {
            return en.Execute("AskDisplay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a construct for use inside AskFunction that gives True if a value is currently associated with key, and False otherwise.
        /// https://reference.wolfram.com/language/ref/AskedQ.html
        ///</summary>
        public static Engine AskedQ(this Engine en, string? name = null)
        {
            return en.Execute("AskedQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a construct for use inside AskFunction that gives the value associated with key, or Missing[…] if none has been provided.
        /// https://reference.wolfram.com/language/ref/AskedValue.html
        ///</summary>
        public static Engine AskedValue(this Engine en, string? name = null)
        {
            return en.Execute("AskedValue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates body, interactively asking for values specified by Ask[…] and related constructs.
        /// https://reference.wolfram.com/language/ref/AskFunction.html
        ///</summary>
        public static Engine AskFunction(this Engine en, string? name = null)
        {
            return en.Execute("AskFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a construct for use inside AskFunction that displays the result of applying fun to the association of the values of all keys encountered so far in the evaluation of the AskFunction.
        /// https://reference.wolfram.com/language/ref/AskTemplateDisplay.html
        ///</summary>
        public static Engine AskTemplateDisplay(this Engine en, string? name = null)
        {
            return en.Execute("AskTemplateDisplay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the assertion that test is True. If assertions have been enabled, test is evaluated when the assertion is encountered. If test is not True, then an assertion failure is generated.
        /// https://reference.wolfram.com/language/ref/Assert.html
        ///</summary>
        public static Engine Assert(this Engine en, string? name = null)
        {
            return en.Execute("Assert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a tool for assessing whether answers are correct according to the key.
        /// https://reference.wolfram.com/language/ref/AssessmentFunction.html
        ///</summary>
        public static Engine AssessmentFunction(this Engine en, string? name = null)
        {
            return en.Execute("AssessmentFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the results of an assessment.
        /// https://reference.wolfram.com/language/ref/AssessmentResultObject.html
        ///</summary>
        public static Engine AssessmentResultObject(this Engine en, string? name = null)
        {
            return en.Execute("AssessmentResultObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of AssociationMap that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/AssociationMap.html
        ///</summary>
        public static Engine AssociationMap(this Engine en, string? name = null)
        {
            return en.Execute("AssociationMap[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is a valid Association object, and False otherwise.
        /// https://reference.wolfram.com/language/ref/AssociationQ.html
        ///</summary>
        public static Engine AssociationQ(this Engine en, string? name = null)
        {
            return en.Execute("AssociationQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the association key1val1,key2val2,….
        /// https://reference.wolfram.com/language/ref/AssociationThread.html
        ///</summary>
        public static Engine AssociationThread(this Engine en, string? name = null)
        {
            return en.Execute("AssociationThread[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an atom with atomic symbol "sym".
        /// https://reference.wolfram.com/language/ref/Atom.html
        ///</summary>
        public static Engine Atom(this Engine en, string? name = null)
        {
            return en.Execute("Atom[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of atoms in the molecule represented by mol.
        /// https://reference.wolfram.com/language/ref/AtomCount.html
        ///</summary>
        public static Engine AtomCount(this Engine en, string? name = null)
        {
            return en.Execute("AtomCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list of atoms in the molecule represented by mol.
        /// https://reference.wolfram.com/language/ref/AtomList.html
        ///</summary>
        public static Engine AtomList(this Engine en, string? name = null)
        {
            return en.Execute("AtomList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if expr is an expression which cannot be divided into subexpressions, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/AtomQ.html
        ///</summary>
        public static Engine AtomQ(this Engine en, string? name = null)
        {
            return en.Execute("AtomQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes expr a cell attached to the current cell being evaluated.
        /// https://reference.wolfram.com/language/ref/AttachCell.html
        ///</summary>
        public static Engine AttachCell(this Engine en, string? name = null)
        {
            return en.Execute("AttachCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// specifies a particular net to give scores for portions of the input.
        /// https://reference.wolfram.com/language/ref/AttentionLayer.html
        ///</summary>
        public static Engine AttentionLayer(this Engine en, string? name = null)
        {
            return en.Execute("AttentionLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list of attributes for a symbol.
        /// https://reference.wolfram.com/language/ref/Attributes.html
        ///</summary>
        public static Engine Attributes(this Engine en, string? name = null)
        {
            return en.Execute("Attributes[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents audio stored in the given file.
        /// https://reference.wolfram.com/language/ref/Audio.html
        ///</summary>
        public static Engine Audio(this Engine en, string? name = null)
        {
            return en.Execute("Audio[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives all annotations associated to audio.
        /// https://reference.wolfram.com/language/ref/AudioAnnotationLookup.html
        ///</summary>
        public static Engine AudioAnnotationLookup(this Engine en, string? name = null)
        {
            return en.Execute("AudioAnnotationLookup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// captures an audio signal into file.
        /// https://reference.wolfram.com/language/ref/AudioCapture.html
        ///</summary>
        public static Engine AudioCapture(this Engine en, string? name = null)
        {
            return en.Execute("AudioCapture[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a multichannel audio object by combining the sequence of channels in audioi.
        /// https://reference.wolfram.com/language/ref/AudioChannelCombine.html
        ///</summary>
        public static Engine AudioChannelCombine(this Engine en, string? name = null)
        {
            return en.Execute("AudioChannelCombine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// mixes channels of audio by averaging and returns a center-panned stereo audio object.
        /// https://reference.wolfram.com/language/ref/AudioChannelMix.html
        ///</summary>
        public static Engine AudioChannelMix(this Engine en, string? name = null)
        {
            return en.Execute("AudioChannelMix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the number of channels in the Audio object audio.
        /// https://reference.wolfram.com/language/ref/AudioChannels.html
        ///</summary>
        public static Engine AudioChannels(this Engine en, string? name = null)
        {
            return en.Execute("AudioChannels[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of Audio objects, each of which represents one channel of audio.
        /// https://reference.wolfram.com/language/ref/AudioChannelSeparate.html
        ///</summary>
        public static Engine AudioChannelSeparate(this Engine en, string? name = null)
        {
            return en.Execute("AudioChannelSeparate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an array of audio samples.
        /// https://reference.wolfram.com/language/ref/AudioData.html
        ///</summary>
        public static Engine AudioData(this Engine en, string? name = null)
        {
            return en.Execute("AudioData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns audio in which the beginning and end of audio are faded.
        /// https://reference.wolfram.com/language/ref/AudioFade.html
        ///</summary>
        public static Engine AudioFade(this Engine en, string? name = null)
        {
            return en.Execute("AudioFade[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates one second of audio of a given model.
        /// https://reference.wolfram.com/language/ref/AudioGenerator.html
        ///</summary>
        public static Engine AudioGenerator(this Engine en, string? name = null)
        {
            return en.Execute("AudioGenerator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields the result of attempting to identify what audio is a recording of.
        /// https://reference.wolfram.com/language/ref/AudioIdentify.html
        ///</summary>
        public static Engine AudioIdentify(this Engine en, string? name = null)
        {
            return en.Execute("AudioIdentify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns audible intervals of audio.
        /// https://reference.wolfram.com/language/ref/AudioIntervals.html
        ///</summary>
        public static Engine AudioIntervals(this Engine en, string? name = null)
        {
            return en.Execute("AudioIntervals[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the number of samples in the Audio object audio.
        /// https://reference.wolfram.com/language/ref/AudioLength.html
        ///</summary>
        public static Engine AudioLength(this Engine en, string? name = null)
        {
            return en.Execute("AudioLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// computes the loudness of audio according to the EBU momentary definition.
        /// https://reference.wolfram.com/language/ref/AudioLoudness.html
        ///</summary>
        public static Engine AudioLoudness(this Engine en, string? name = null)
        {
            return en.Execute("AudioLoudness[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// normalizes audio so that the maximum absolute value of its samples is 1.
        /// https://reference.wolfram.com/language/ref/AudioNormalize.html
        ///</summary>
        public static Engine AudioNormalize(this Engine en, string? name = null)
        {
            return en.Execute("AudioNormalize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns an audio object by overlaying all audioi.
        /// https://reference.wolfram.com/language/ref/AudioOverlay.html
        ///</summary>
        public static Engine AudioOverlay(this Engine en, string? name = null)
        {
            return en.Execute("AudioOverlay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a center-panned stereo audio object from a mono audio.
        /// https://reference.wolfram.com/language/ref/AudioPan.html
        ///</summary>
        public static Engine AudioPan(this Engine en, string? name = null)
        {
            return en.Execute("AudioPan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// pauses the playback of the AudioStream object astream.
        /// https://reference.wolfram.com/language/ref/AudioPause.html
        ///</summary>
        public static Engine AudioPause(this Engine en, string? name = null)
        {
            return en.Execute("AudioPause[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a new AudioStream object from audio and starts the playback.
        /// https://reference.wolfram.com/language/ref/AudioPlay.html
        ///</summary>
        public static Engine AudioPlay(this Engine en, string? name = null)
        {
            return en.Execute("AudioPlay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the waveform of audio.
        /// https://reference.wolfram.com/language/ref/AudioPlot.html
        ///</summary>
        public static Engine AudioPlot(this Engine en, string? name = null)
        {
            return en.Execute("AudioPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if audio has the form of a valid Audio object, and False otherwise.
        /// https://reference.wolfram.com/language/ref/AudioQ.html
        ///</summary>
        public static Engine AudioQ(this Engine en, string? name = null)
        {
            return en.Execute("AudioQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// records from the input audio device inputdev.
        /// https://reference.wolfram.com/language/ref/AudioRecord.html
        ///</summary>
        public static Engine AudioRecord(this Engine en, string? name = null)
        {
            return en.Execute("AudioRecord[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// adds reverberation to audio.
        /// https://reference.wolfram.com/language/ref/AudioReverb.html
        ///</summary>
        public static Engine AudioReverb(this Engine en, string? name = null)
        {
            return en.Execute("AudioReverb[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// reverses audio so that the signal is played backward.
        /// https://reference.wolfram.com/language/ref/AudioReverse.html
        ///</summary>
        public static Engine AudioReverse(this Engine en, string? name = null)
        {
            return en.Execute("AudioReverse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the sample rate of the Audio object audio.
        /// https://reference.wolfram.com/language/ref/AudioSampleRate.html
        ///</summary>
        public static Engine AudioSampleRate(this Engine en, string? name = null)
        {
            return en.Execute("AudioSampleRate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// stops the playback of the AudioStream object astream.
        /// https://reference.wolfram.com/language/ref/AudioStop.html
        ///</summary>
        public static Engine AudioStop(this Engine en, string? name = null)
        {
            return en.Execute("AudioStop[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a new AudioStream object from source.
        /// https://reference.wolfram.com/language/ref/AudioStream.html
        ///</summary>
        public static Engine AudioStream(this Engine en, string? name = null)
        {
            return en.Execute("AudioStream[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns all existing streams that originated from audio.
        /// https://reference.wolfram.com/language/ref/AudioStreams.html
        ///</summary>
        public static Engine AudioStreams(this Engine en, string? name = null)
        {
            return en.Execute("AudioStreams[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// trims silence from the beginning and end of audio.
        /// https://reference.wolfram.com/language/ref/AudioTrim.html
        ///</summary>
        public static Engine AudioTrim(this Engine en, string? name = null)
        {
            return en.Execute("AudioTrim[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the data type used to represent samples in the Audio object audio.
        /// https://reference.wolfram.com/language/ref/AudioType.html
        ///</summary>
        public static Engine AudioType(this Engine en, string? name = null)
        {
            return en.Execute("AudioType[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the augmented polyhedron poly by replacing each face by a pyramid.
        /// https://reference.wolfram.com/language/ref/AugmentedPolyhedron.html
        ///</summary>
        public static Engine AugmentedPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("AugmentedPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a formal augmented symmetric polynomial with exponents r1, r2, ….
        /// https://reference.wolfram.com/language/ref/AugmentedSymmetricPolynomial.html
        ///</summary>
        public static Engine AugmentedSymmetricPolynomial(this Engine en, string? name = null)
        {
            return en.Execute("AugmentedSymmetricPolynomial[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// initiates an authentication dialog of the specified standard type.
        /// https://reference.wolfram.com/language/ref/AuthenticationDialog.html
        ///</summary>
        public static Engine AuthenticationDialog(this Engine en, string? name = null)
        {
            return en.Execute("AuthenticationDialog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an AutocompletionFunction[…] that can be applied to a string.
        /// https://reference.wolfram.com/language/ref/Autocomplete.html
        ///</summary>
        public static Engine Autocomplete(this Engine en, string? name = null)
        {
            return en.Execute("Autocomplete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a function to be applied to a string to generate possible completions.
        /// https://reference.wolfram.com/language/ref/AutocompletionFunction.html
        ///</summary>
        public static Engine AutocompletionFunction(this Engine en, string? name = null)
        {
            return en.Execute("AutocompletionFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the data is autocorrelated.
        /// https://reference.wolfram.com/language/ref/AutocorrelationTest.html
        ///</summary>
        public static Engine AutocorrelationTest(this Engine en, string? name = null)
        {
            return en.Execute("AutocorrelationTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an expression to be reevaluated every hour and made available in the cloud.
        /// https://reference.wolfram.com/language/ref/AutoRefreshed.html
        ///</summary>
        public static Engine AutoRefreshed(this Engine en, string? name = null)
        {
            return en.Execute("AutoRefreshed[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an element of a form that automatically submits the whole form if it is entered.
        /// https://reference.wolfram.com/language/ref/AutoSubmitting.html
        ///</summary>
        public static Engine AutoSubmitting(this Engine en, string? name = null)
        {
            return en.Execute("AutoSubmitting[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an axiomatic representation of the specified axiomatic theory.
        /// https://reference.wolfram.com/language/ref/AxiomaticTheory.html
        ///</summary>
        public static Engine AxiomaticTheory(this Engine en, string? name = null)
        {
            return en.Execute("AxiomaticTheory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a Graphics primitive that represents an axis with a quantitative scale along the path path.
        /// https://reference.wolfram.com/language/ref/AxisObject.html
        ///</summary>
        public static Engine AxisObject(this Engine en, string? name = null)
        {
            return en.Execute("AxisObject[" + en.ValidNames.Last() + "]", name);
        }


    }
}
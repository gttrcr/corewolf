namespace CoreWolf
{
    public static class ExtendedFunctionsC
    {
        ///<summary>
        /// is the default form for the i  parameter or constant generated in representing the results of various symbolic computations.
        /// https://reference.wolfram.com/language/ref/C.html
        ///</summary>
        public static Engine C(this Engine en, string? name = null)
        {
            return en.Execute("C[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts to the default calendar type.
        /// https://reference.wolfram.com/language/ref/CalendarConvert.html
        ///</summary>
        public static Engine CalendarConvert(this Engine en, string? name = null)
        {
            return en.Execute("CalendarConvert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the default parameters associated with the date calendar cal.
        /// https://reference.wolfram.com/language/ref/CalendarData.html
        ///</summary>
        public static Engine CalendarData(this Engine en, string? name = null)
        {
            return en.Execute("CalendarData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// cancels out common factors in the numerator and denominator of expr.
        /// https://reference.wolfram.com/language/ref/Cancel.html
        ///</summary>
        public static Engine Cancel(this Engine en, string? name = null)
        {
            return en.Execute("Cancel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a button labeled Cancel that evaluates action when clicked.
        /// https://reference.wolfram.com/language/ref/CancelButton.html
        ///</summary>
        public static Engine CancelButton(this Engine en, string? name = null)
        {
            return en.Execute("CancelButton[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes a candlestick chart for the financial entity "name" over the date range daterange.
        /// https://reference.wolfram.com/language/ref/CandlestickChart.html
        ///</summary>
        public static Engine CandlestickChart(this Engine en, string? name = null)
        {
            return en.Execute("CandlestickChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a canonical form of the graph g.
        /// https://reference.wolfram.com/language/ref/CanonicalGraph.html
        ///</summary>
        public static Engine CanonicalGraph(this Engine en, string? name = null)
        {
            return en.Execute("CanonicalGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a canonical representation of the polygon poly with shared coordinates and with inner and outer boundaries.
        /// https://reference.wolfram.com/language/ref/CanonicalizePolygon.html
        ///</summary>
        public static Engine CanonicalizePolygon(this Engine en, string? name = null)
        {
            return en.Execute("CanonicalizePolygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a canonical representation of the polyhedron poly with shared coordinates and with inner and outer boundaries.
        /// https://reference.wolfram.com/language/ref/CanonicalizePolyhedron.html
        ///</summary>
        public static Engine CanonicalizePolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("CanonicalizePolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a canonical representation of the region reg.
        /// https://reference.wolfram.com/language/ref/CanonicalizeRegion.html
        ///</summary>
        public static Engine CanonicalizeRegion(this Engine en, string? name = null)
        {
            return en.Execute("CanonicalizeRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the canonical name for the entity specified by entity.
        /// https://reference.wolfram.com/language/ref/CanonicalName.html
        ///</summary>
        public static Engine CanonicalName(this Engine en, string? name = null)
        {
            return en.Execute("CanonicalName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a mesh region representing the n-step Cantor set.
        /// https://reference.wolfram.com/language/ref/CantorMesh.html
        ///</summary>
        public static Engine CantorMesh(this Engine en, string? name = null)
        {
            return en.Execute("CantorMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Cantor staircase function .
        /// https://reference.wolfram.com/language/ref/CantorStaircase.html
        ///</summary>
        public static Engine CantorStaircase(this Engine en, string? name = null)
        {
            return en.Execute("CantorStaircase[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a canvas that initially contains the specified 2D graphic.
        /// https://reference.wolfram.com/language/ref/Canvas.html
        ///</summary>
        public static Engine Canvas(this Engine en, string? name = null)
        {
            return en.Execute("Canvas[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics primitive that specifies what type of caps should be used at the ends of lines, tubes, and related primitives.
        /// https://reference.wolfram.com/language/ref/CapForm.html
        ///</summary>
        public static Engine CapForm(this Engine en, string? name = null)
        {
            return en.Execute("CapForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays as x.
        /// https://reference.wolfram.com/language/ref/CapitalDifferentialD.html
        ///</summary>
        public static Engine CapitalDifferentialD(this Engine en, string? name = null)
        {
            return en.Execute("CapitalDifferentialD[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a string in which the first character has been made uppercase.
        /// https://reference.wolfram.com/language/ref/Capitalize.html
        ///</summary>
        public static Engine Capitalize(this Engine en, string? name = null)
        {
            return en.Execute("Capitalize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Carmichael function .
        /// https://reference.wolfram.com/language/ref/CarmichaelLambda.html
        ///</summary>
        public static Engine CarmichaelLambda(this Engine en, string? name = null)
        {
            return en.Execute("CarmichaelLambda[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of Cases that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/Cases.html
        ///</summary>
        public static Engine Cases(this Engine en, string? name = null)
        {
            return en.Execute("Cases[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a string pattern that requires matching typographical case, even with the overall option setting IgnoreCase->True.
        /// https://reference.wolfram.com/language/ref/CaseSensitive.html
        ///</summary>
        public static Engine CaseSensitive(this Engine en, string? name = null)
        {
            return en.Execute("CaseSensitive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a series of cash flows occurring at unit time intervals.
        /// https://reference.wolfram.com/language/ref/Cashflow.html
        ///</summary>
        public static Engine Cashflow(this Engine en, string? name = null)
        {
            return en.Execute("Cashflow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n Catalan number .
        /// https://reference.wolfram.com/language/ref/CatalanNumber.html
        ///</summary>
        public static Engine CatalanNumber(this Engine en, string? name = null)
        {
            return en.Execute("CatalanNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the argument of the first Throw generated in the evaluation of expr.
        /// https://reference.wolfram.com/language/ref/Catch.html
        ///</summary>
        public static Engine Catch(this Engine en, string? name = null)
        {
            return en.Execute("Catch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a uniform categorical distribution over classes c1, c2, etc.
        /// https://reference.wolfram.com/language/ref/CategoricalDistribution.html
        ///</summary>
        public static Engine CategoricalDistribution(this Engine en, string? name = null)
        {
            return en.Execute("CategoricalDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a single list with all elements from the listi in order.
        /// https://reference.wolfram.com/language/ref/Catenate.html
        ///</summary>
        public static Engine Catenate(this Engine en, string? name = null)
        {
            return en.Execute("Catenate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net layer that takes a list of input arrays and catenates them at level n.
        /// https://reference.wolfram.com/language/ref/CatenateLayer.html
        ///</summary>
        public static Engine CatenateLayer(this Engine en, string? name = null)
        {
            return en.Execute("CatenateLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Cauchy window function of x.
        /// https://reference.wolfram.com/language/ref/CauchyWindow.html
        ///</summary>
        public static Engine CauchyWindow(this Engine en, string? name = null)
        {
            return en.Execute("CauchyWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a Cayley graph representation of group.
        /// https://reference.wolfram.com/language/ref/CayleyGraph.html
        ///</summary>
        public static Engine CayleyGraph(this Engine en, string? name = null)
        {
            return en.Execute("CayleyGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the CDF as a pure function.
        /// https://reference.wolfram.com/language/ref/CDF.html
        ///</summary>
        public static Engine CDF(this Engine en, string? name = null)
        {
            return en.Execute("CDF[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Cohen–Daubechies–Feauveau wavelet of type "type".
        /// https://reference.wolfram.com/language/ref/CDFWavelet.html
        ///</summary>
        public static Engine CDFWavelet(this Engine en, string? name = null)
        {
            return en.Execute("CDFWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the smallest integer greater than or equal to x.
        /// https://reference.wolfram.com/language/ref/Ceiling.html
        ///</summary>
        public static Engine Ceiling(this Engine en, string? name = null)
        {
            return en.Execute("Ceiling[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is the low-level representation of a cell inside a Wolfram System notebook.
        /// https://reference.wolfram.com/language/ref/Cell.html
        ///</summary>
        public static Engine Cell(this Engine en, string? name = null)
        {
            return en.Execute("Cell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an open group of cells that can appear in a Wolfram System notebook.
        /// https://reference.wolfram.com/language/ref/CellGroup.html
        ///</summary>
        public static Engine CellGroup(this Engine en, string? name = null)
        {
            return en.Execute("CellGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a low-level construct that represents an open group of cells in a notebook.
        /// https://reference.wolfram.com/language/ref/CellGroupData.html
        ///</summary>
        public static Engine CellGroupData(this Engine en, string? name = null)
        {
            return en.Execute("CellGroupData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an object that represents a cell in an open notebook in the front end.
        /// https://reference.wolfram.com/language/ref/CellObject.html
        ///</summary>
        public static Engine CellObject(this Engine en, string? name = null)
        {
            return en.Execute("CellObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// inserts expr as a complete cell in the current notebook just below the cell being evaluated.
        /// https://reference.wolfram.com/language/ref/CellPrint.html
        ///</summary>
        public static Engine CellPrint(this Engine en, string? name = null)
        {
            return en.Execute("CellPrint[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the list of CellObject expressions in obj.
        /// https://reference.wolfram.com/language/ref/Cells.html
        ///</summary>
        public static Engine Cells(this Engine en, string? name = null)
        {
            return en.Execute("Cells[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an operator form of CellularAutomaton that represents one step of evolution.
        /// https://reference.wolfram.com/language/ref/CellularAutomaton.html
        ///</summary>
        public static Engine CellularAutomaton(this Engine en, string? name = null)
        {
            return en.Execute("CellularAutomaton[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates an array with a single 1 at the center and zeros elsewhere.
        /// https://reference.wolfram.com/language/ref/CenterArray.html
        ///</summary>
        public static Engine CenterArray(this Engine en, string? name = null)
        {
            return en.Execute("CenterArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// for an approximate number c gives a centered interval that contains all values within the error bounds of c.
        /// https://reference.wolfram.com/language/ref/CenteredInterval.html
        ///</summary>
        public static Engine CenteredInterval(this Engine en, string? name = null)
        {
            return en.Execute("CenteredInterval[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the central feature of the elements .
        /// https://reference.wolfram.com/language/ref/CentralFeature.html
        ///</summary>
        public static Engine CentralFeature(this Engine en, string? name = null)
        {
            return en.Execute("CentralFeature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the r formal central moment.
        /// https://reference.wolfram.com/language/ref/CentralMoment.html
        ///</summary>
        public static Engine CentralMoment(this Engine en, string? name = null)
        {
            return en.Execute("CentralMoment[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the array of power cepstra computed on each partition of data.
        /// https://reference.wolfram.com/language/ref/Cepstrogram.html
        ///</summary>
        public static Engine Cepstrogram(this Engine en, string? name = null)
        {
            return en.Execute("Cepstrogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// computes an array of cepstra on data.
        /// https://reference.wolfram.com/language/ref/CepstrogramArray.html
        ///</summary>
        public static Engine CepstrogramArray(this Engine en, string? name = null)
        {
            return en.Execute("CepstrogramArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// computes the power cepstrum of data.
        /// https://reference.wolfram.com/language/ref/CepstrumArray.html
        ///</summary>
        public static Engine CepstrumArray(this Engine en, string? name = null)
        {
            return en.Execute("CepstrumArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints as a C language version of expr.
        /// https://reference.wolfram.com/language/ref/CForm.html
        ///</summary>
        public static Engine CForm(this Engine en, string? name = null)
        {
            return en.Execute("CForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the base-b Champernowne number .
        /// https://reference.wolfram.com/language/ref/ChampernowneNumber.html
        ///</summary>
        public static Engine ChampernowneNumber(this Engine en, string? name = null)
        {
            return en.Execute("ChampernowneNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// starts listening on the specified channel.
        /// https://reference.wolfram.com/language/ref/ChannelListen.html
        ///</summary>
        public static Engine ChannelListen(this Engine en, string? name = null)
        {
            return en.Execute("ChannelListen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a channel listener created by ChannelListen.
        /// https://reference.wolfram.com/language/ref/ChannelListener.html
        ///</summary>
        public static Engine ChannelListener(this Engine en, string? name = null)
        {
            return en.Execute("ChannelListener[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a channel specified by a given URL.
        /// https://reference.wolfram.com/language/ref/ChannelObject.html
        ///</summary>
        public static Engine ChannelObject(this Engine en, string? name = null)
        {
            return en.Execute("ChannelObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a channel receiver function that applies fun to any channel message it receives.
        /// https://reference.wolfram.com/language/ref/ChannelReceiverFunction.html
        ///</summary>
        public static Engine ChannelReceiverFunction(this Engine en, string? name = null)
        {
            return en.Execute("ChannelReceiverFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of users currently subscribed to the specified channel.
        /// https://reference.wolfram.com/language/ref/ChannelSubscribers.html
        ///</summary>
        public static Engine ChannelSubscribers(this Engine en, string? name = null)
        {
            return en.Execute("ChannelSubscribers[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds a two-level segmentation of image by computing optimal contours around regions of consistent intensity in image.
        /// https://reference.wolfram.com/language/ref/ChanVeseBinarize.html
        ///</summary>
        public static Engine ChanVeseBinarize(this Engine en, string? name = null)
        {
            return en.Execute("ChanVeseBinarize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an association whose keys are the distinct characters in string, and whose values give the number of times those characters appear in string.
        /// https://reference.wolfram.com/language/ref/CharacterCounts.html
        ///</summary>
        public static Engine CharacterCounts(this Engine en, string? name = null)
        {
            return en.Execute("CharacterCounts[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the name of the character c.
        /// https://reference.wolfram.com/language/ref/CharacterName.html
        ///</summary>
        public static Engine CharacterName(this Engine en, string? name = null)
        {
            return en.Execute("CharacterName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the characters in a string.
        /// https://reference.wolfram.com/language/ref/Characters.html
        ///</summary>
        public static Engine Characters(this Engine en, string? name = null)
        {
            return en.Execute("Characters[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a lowpass Chebyshev type 1 filter of order n.
        /// https://reference.wolfram.com/language/ref/Chebyshev1FilterModel.html
        ///</summary>
        public static Engine Chebyshev1FilterModel(this Engine en, string? name = null)
        {
            return en.Execute("Chebyshev1FilterModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a lowpass Chebyshev type 2 filter of order n.
        /// https://reference.wolfram.com/language/ref/Chebyshev2FilterModel.html
        ///</summary>
        public static Engine Chebyshev2FilterModel(this Engine en, string? name = null)
        {
            return en.Execute("Chebyshev2FilterModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a checkbox with setting x, displayed as  when x is True and  when x is False.
        /// https://reference.wolfram.com/language/ref/Checkbox.html
        ///</summary>
        public static Engine Checkbox(this Engine en, string? name = null)
        {
            return en.Execute("Checkbox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts to SI base units.
        /// https://reference.wolfram.com/language/ref/ChemicalConvert.html
        ///</summary>
        public static Engine ChemicalConvert(this Engine en, string? name = null)
        {
            return en.Execute("ChemicalConvert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a structure diagram for the chemical with the specified name.
        /// https://reference.wolfram.com/language/ref/ChemicalData.html
        ///</summary>
        public static Engine ChemicalData(this Engine en, string? name = null)
        {
            return en.Execute("ChemicalData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the chemical formula corresponding to the given input.
        /// https://reference.wolfram.com/language/ref/ChemicalFormula.html
        ///</summary>
        public static Engine ChemicalFormula(this Engine en, string? name = null)
        {
            return en.Execute("ChemicalFormula[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a chemical reaction between the given reactants and products.
        /// https://reference.wolfram.com/language/ref/ChemicalReaction.html
        ///</summary>
        public static Engine ChemicalReaction(this Engine en, string? name = null)
        {
            return en.Execute("ChemicalReaction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a  distribution with ν degrees of freedom.
        /// https://reference.wolfram.com/language/ref/ChiDistribution.html
        ///</summary>
        public static Engine ChiDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ChiDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a  distribution with ν degrees of freedom.
        /// https://reference.wolfram.com/language/ref/ChiSquareDistribution.html
        ///</summary>
        public static Engine ChiSquareDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ChiSquareDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents OK and Cancel buttons that evaluate the corresponding acti when clicked.
        /// https://reference.wolfram.com/language/ref/ChoiceButtons.html
        ///</summary>
        public static Engine ChoiceButtons(this Engine en, string? name = null)
        {
            return en.Execute("ChoiceButtons[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// puts up a standard choice dialog that displays expr together with OK and Cancel buttons, and returns True if OK is clicked and False if Cancel is clicked.
        /// https://reference.wolfram.com/language/ref/ChoiceDialog.html
        ///</summary>
        public static Engine ChoiceDialog(this Engine en, string? name = null)
        {
            return en.Execute("ChoiceDialog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the Cholesky decomposition of a matrix m.
        /// https://reference.wolfram.com/language/ref/CholeskyDecomposition.html
        ///</summary>
        public static Engine CholeskyDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("CholeskyDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// replaces approximate real numbers in expr that are close to zero by the exact integer 0.
        /// https://reference.wolfram.com/language/ref/Chop.html
        ///</summary>
        public static Engine Chop(this Engine en, string? name = null)
        {
            return en.Execute("Chop[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots a 2D slice of the color space colspace.
        /// https://reference.wolfram.com/language/ref/ChromaticityPlot.html
        ///</summary>
        public static Engine ChromaticityPlot(this Engine en, string? name = null)
        {
            return en.Execute("ChromaticityPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a 3D gamut of the color space colspace.
        /// https://reference.wolfram.com/language/ref/ChromaticityPlot3D.html
        ///</summary>
        public static Engine ChromaticityPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("ChromaticityPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a circle of radius 1.
        /// https://reference.wolfram.com/language/ref/Circle.html
        ///</summary>
        public static Engine Circle(this Engine en, string? name = null)
        {
            return en.Execute("Circle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the positions of n points equally spaced around the unit circle.
        /// https://reference.wolfram.com/language/ref/CirclePoints.html
        ///</summary>
        public static Engine CirclePoints(this Engine en, string? name = null)
        {
            return en.Execute("CirclePoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a circle passing through the points pi.
        /// https://reference.wolfram.com/language/ref/CircleThrough.html
        ///</summary>
        public static Engine CircleThrough(this Engine en, string? name = null)
        {
            return en.Execute("CircleThrough[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays as .
        /// https://reference.wolfram.com/language/ref/CircleTimes.html
        ///</summary>
        public static Engine CircleTimes(this Engine en, string? name = null)
        {
            return en.Execute("CircleTimes[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a circular arc passing through the points pi.
        /// https://reference.wolfram.com/language/ref/CircularArcThrough.html
        ///</summary>
        public static Engine CircularArcThrough(this Engine en, string? name = null)
        {
            return en.Execute("CircularArcThrough[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a circular orthogonal matrix distribution with matrix dimensions {n,n}.
        /// https://reference.wolfram.com/language/ref/CircularOrthogonalMatrixDistribution.html
        ///</summary>
        public static Engine CircularOrthogonalMatrixDistribution(this Engine en, string? name = null)
        {
            return en.Execute("CircularOrthogonalMatrixDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a circular quaternion matrix distribution with matrix dimensions {2 n,2 n} over the field of complex numbers.
        /// https://reference.wolfram.com/language/ref/CircularQuaternionMatrixDistribution.html
        ///</summary>
        public static Engine CircularQuaternionMatrixDistribution(this Engine en, string? name = null)
        {
            return en.Execute("CircularQuaternionMatrixDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a circular real matrix distribution with matrix dimensions {n,n}.
        /// https://reference.wolfram.com/language/ref/CircularRealMatrixDistribution.html
        ///</summary>
        public static Engine CircularRealMatrixDistribution(this Engine en, string? name = null)
        {
            return en.Execute("CircularRealMatrixDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a circular symplectic matrix distribution with matrix dimensions {2 n,2 n} over the field of complex numbers.
        /// https://reference.wolfram.com/language/ref/CircularSymplecticMatrixDistribution.html
        ///</summary>
        public static Engine CircularSymplecticMatrixDistribution(this Engine en, string? name = null)
        {
            return en.Execute("CircularSymplecticMatrixDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a circular unitary matrix distribution with matrix dimensions {n,n}.
        /// https://reference.wolfram.com/language/ref/CircularUnitaryMatrixDistribution.html
        ///</summary>
        public static Engine CircularUnitaryMatrixDistribution(this Engine en, string? name = null)
        {
            return en.Execute("CircularUnitaryMatrixDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the sphere that circumscribes the points pi in .
        /// https://reference.wolfram.com/language/ref/Circumsphere.html
        ///</summary>
        public static Engine Circumsphere(this Engine en, string? name = null)
        {
            return en.Execute("Circumsphere[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the full specifications of cities whose names are consistent with name.
        /// https://reference.wolfram.com/language/ref/CityData.html
        ///</summary>
        public static Engine CityData(this Engine en, string? name = null)
        {
            return en.Execute("CityData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a function generated by Classify that classifies data into classes.
        /// https://reference.wolfram.com/language/ref/ClassifierFunction.html
        ///</summary>
        public static Engine ClassifierFunction(this Engine en, string? name = null)
        {
            return en.Execute("ClassifierFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an object generated by ClassifierMeasurements that can be applied to properties.
        /// https://reference.wolfram.com/language/ref/ClassifierMeasurementsObject.html
        ///</summary>
        public static Engine ClassifierMeasurementsObject(this Engine en, string? name = null)
        {
            return en.Execute("ClassifierMeasurementsObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a ClassifierFunction[…] based on the examples and classes given.
        /// https://reference.wolfram.com/language/ref/Classify.html
        ///</summary>
        public static Engine Classify(this Engine en, string? name = null)
        {
            return en.Execute("Classify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// clears all persistent and session cookies associated with the specified domain.
        /// https://reference.wolfram.com/language/ref/ClearCookies.html
        ///</summary>
        public static Engine ClearCookies(this Engine en, string? name = null)
        {
            return en.Execute("ClearCookies[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// clears permissions for the cloud object corresponding to the current document.
        /// https://reference.wolfram.com/language/ref/ClearPermissions.html
        ///</summary>
        public static Engine ClearPermissions(this Engine en, string? name = null)
        {
            return en.Execute("ClearPermissions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// clears only caches of the specified type.
        /// https://reference.wolfram.com/language/ref/ClearSystemCache.html
        ///</summary>
        public static Engine ClearSystemCache(this Engine en, string? name = null)
        {
            return en.Execute("ClearSystemCache[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a button that copies expr whenever it is clicked.
        /// https://reference.wolfram.com/language/ref/ClickToCopy.html
        ///</summary>
        public static Engine ClickToCopy(this Engine en, string? name = null)
        {
            return en.Execute("ClickToCopy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives x clipped to be between  and .
        /// https://reference.wolfram.com/language/ref/Clip.html
        ///</summary>
        public static Engine Clip(this Engine en, string? name = null)
        {
            return en.Execute("Clip[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// cycles from 0 to t every t seconds.
        /// https://reference.wolfram.com/language/ref/Clock.html
        ///</summary>
        public static Engine Clock(this Engine en, string? name = null)
        {
            return en.Execute("Clock[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// draws an analog clock face showing the time corresponding to an AbsoluteTime, DateObject, or TimeObject specification.
        /// https://reference.wolfram.com/language/ref/ClockGauge.html
        ///</summary>
        public static Engine ClockGauge(this Engine en, string? name = null)
        {
            return en.Execute("ClockGauge[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// closes a stream or socket.
        /// https://reference.wolfram.com/language/ref/Close.html
        ///</summary>
        public static Engine Close(this Engine en, string? name = null)
        {
            return en.Execute("Close[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// terminates the kernel k.
        /// https://reference.wolfram.com/language/ref/CloseKernels.html
        ///</summary>
        public static Engine CloseKernels(this Engine en, string? name = null)
        {
            return en.Execute("CloseKernels[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of closeness centralities for the vertices in the graph g.
        /// https://reference.wolfram.com/language/ref/ClosenessCentrality.html
        ///</summary>
        public static Engine ClosenessCentrality(this Engine en, string? name = null)
        {
            return en.Execute("ClosenessCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the property prop associated with the cloud account being used.
        /// https://reference.wolfram.com/language/ref/CloudAccountData.html
        ///</summary>
        public static Engine CloudAccountData(this Engine en, string? name = null)
        {
            return en.Execute("CloudAccountData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// shows a dialog to input the password.
        /// https://reference.wolfram.com/language/ref/CloudConnect.html
        ///</summary>
        public static Engine CloudConnect(this Engine en, string? name = null)
        {
            return en.Execute("CloudConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// deploys expr to a new anonymous cloud object.
        /// https://reference.wolfram.com/language/ref/CloudDeploy.html
        ///</summary>
        public static Engine CloudDeploy(this Engine en, string? name = null)
        {
            return en.Execute("CloudDeploy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates expr in the cloud and returns the result.
        /// https://reference.wolfram.com/language/ref/CloudEvaluate.html
        ///</summary>
        public static Engine CloudEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("CloudEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an expression whose value is persistently stored in the cloud.
        /// https://reference.wolfram.com/language/ref/CloudExpression.html
        ///</summary>
        public static Engine CloudExpression(this Engine en, string? name = null)
        {
            return en.Execute("CloudExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of anonymous cloud expressions owned by you.
        /// https://reference.wolfram.com/language/ref/CloudExpressions.html
        ///</summary>
        public static Engine CloudExpressions(this Engine en, string? name = null)
        {
            return en.Execute("CloudExpressions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a pure function that evaluates fun[args] in the cloud.
        /// https://reference.wolfram.com/language/ref/CloudFunction.html
        ///</summary>
        public static Engine CloudFunction(this Engine en, string? name = null)
        {
            return en.Execute("CloudFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// reads in a cloud object at a given URI, evaluating each expression in it and returning the last one.
        /// https://reference.wolfram.com/language/ref/CloudGet.html
        ///</summary>
        public static Engine CloudGet(this Engine en, string? name = null)
        {
            return en.Execute("CloudGet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// imports from a cloud object at a given URI.
        /// https://reference.wolfram.com/language/ref/CloudImport.html
        ///</summary>
        public static Engine CloudImport(this Engine en, string? name = null)
        {
            return en.Execute("CloudImport[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives summary logging data for all your cloud objects of a particular category.
        /// https://reference.wolfram.com/language/ref/CloudLoggingData.html
        ///</summary>
        public static Engine CloudLoggingData(this Engine en, string? name = null)
        {
            return en.Execute("CloudLoggingData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a cloud object of a given user with a given path.
        /// https://reference.wolfram.com/language/ref/CloudObject.html
        ///</summary>
        public static Engine CloudObject(this Engine en, string? name = null)
        {
            return en.Execute("CloudObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of cloud objects in the cloud directory dir.
        /// https://reference.wolfram.com/language/ref/CloudObjects.html
        ///</summary>
        public static Engine CloudObjects(this Engine en, string? name = null)
        {
            return en.Execute("CloudObjects[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes a public copy of the cloud object obj.
        /// https://reference.wolfram.com/language/ref/CloudPublish.html
        ///</summary>
        public static Engine CloudPublish(this Engine en, string? name = null)
        {
            return en.Execute("CloudPublish[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// writes expr to a new anonymous cloud object.
        /// https://reference.wolfram.com/language/ref/CloudPut.html
        ///</summary>
        public static Engine CloudPut(this Engine en, string? name = null)
        {
            return en.Execute("CloudPut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// saves definitions associated with the specified symbol to a new anonymous cloud object.
        /// https://reference.wolfram.com/language/ref/CloudSave.html
        ///</summary>
        public static Engine CloudSave(this Engine en, string? name = null)
        {
            return en.Execute("CloudSave[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// shares the current cloud document with the specified user.
        /// https://reference.wolfram.com/language/ref/CloudShare.html
        ///</summary>
        public static Engine CloudShare(this Engine en, string? name = null)
        {
            return en.Execute("CloudShare[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// submits expr for immediate asynchronous cloud evaluation.
        /// https://reference.wolfram.com/language/ref/CloudSubmit.html
        ///</summary>
        public static Engine CloudSubmit(this Engine en, string? name = null)
        {
            return en.Execute("CloudSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a symbol whose value is persistently stored in the cloud.
        /// https://reference.wolfram.com/language/ref/CloudSymbol.html
        ///</summary>
        public static Engine CloudSymbol(this Engine en, string? name = null)
        {
            return en.Execute("CloudSymbol[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// cancels sharing of the cloud object obj with everyone.
        /// https://reference.wolfram.com/language/ref/CloudUnshare.html
        ///</summary>
        public static Engine CloudUnshare(this Engine en, string? name = null)
        {
            return en.Execute("CloudUnshare[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a ClassifierFunction[…] by partitioning data into clusters of similar elements.
        /// https://reference.wolfram.com/language/ref/ClusterClassify.html
        ///</summary>
        public static Engine ClusterClassify(this Engine en, string? name = null)
        {
            return en.Execute("ClusterClassify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an array in which each element at the lowest level of array is replaced by an integer index representing the cluster in which the element lies.
        /// https://reference.wolfram.com/language/ref/ClusteringComponents.html
        ///</summary>
        public static Engine ClusteringComponents(this Engine en, string? name = null)
        {
            return en.Execute("ClusteringComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// constructs a weighted tree from the hierarchical clustering of the elements e1, e2, ….
        /// https://reference.wolfram.com/language/ref/ClusteringTree.html
        ///</summary>
        public static Engine ClusteringTree(this Engine en, string? name = null)
        {
            return en.Execute("ClusteringTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a color from an HTML color name etc.
        /// https://reference.wolfram.com/language/ref/CMYKColor.html
        ///</summary>
        public static Engine CMYKColor(this Engine en, string? name = null)
        {
            return en.Execute("CMYKColor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Coiflet wavelet of order n.
        /// https://reference.wolfram.com/language/ref/CoifletWavelet.html
        ///</summary>
        public static Engine CoifletWavelet(this Engine en, string? name = null)
        {
            return en.Execute("CoifletWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the points p1,p2,p3,…,pn are collinear.
        /// https://reference.wolfram.com/language/ref/CollinearPoints.html
        ///</summary>
        public static Engine CollinearPoints(this Engine en, string? name = null)
        {
            return en.Execute("CollinearPoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// adjusts the colors in image to achieve a balance that simulates the effect of neutral lighting.
        /// https://reference.wolfram.com/language/ref/ColorBalance.html
        ///</summary>
        public static Engine ColorBalance(this Engine en, string? name = null)
        {
            return en.Execute("ColorBalance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a multichannel image by combining the sequence of channels in the imagei.
        /// https://reference.wolfram.com/language/ref/ColorCombine.html
        ///</summary>
        public static Engine ColorCombine(this Engine en, string? name = null)
        {
            return en.Execute("ColorCombine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a function that generates colors in the named color scheme when applied to parameter values.
        /// https://reference.wolfram.com/language/ref/ColorData.html
        ///</summary>
        public static Engine ColorData(this Engine en, string? name = null)
        {
            return en.Execute("ColorData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates an image from an integer matrix m, using colors for positive integers and black for non-positive integers.
        /// https://reference.wolfram.com/language/ref/Colorize.html
        ///</summary>
        public static Engine Colorize(this Engine en, string? name = null)
        {
            return en.Execute("Colorize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the negative of a color.
        /// https://reference.wolfram.com/language/ref/ColorNegate.html
        ///</summary>
        public static Engine ColorNegate(this Engine en, string? name = null)
        {
            return en.Execute("ColorNegate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if color is a valid color directive and False otherwise.
        /// https://reference.wolfram.com/language/ref/ColorQ.html
        ///</summary>
        public static Engine ColorQ(this Engine en, string? name = null)
        {
            return en.Execute("ColorQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an approximation to image by quantizing to distinct colors.
        /// https://reference.wolfram.com/language/ref/ColorQuantize.html
        ///</summary>
        public static Engine ColorQuantize(this Engine en, string? name = null)
        {
            return en.Execute("ColorQuantize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of single-channel images corresponding to each of the color channels in image.
        /// https://reference.wolfram.com/language/ref/ColorSeparate.html
        ///</summary>
        public static Engine ColorSeparate(this Engine en, string? name = null)
        {
            return en.Execute("ColorSeparate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a color setter which displays as a swatch of the specified color and when clicked brings up a system color picker dialog.
        /// https://reference.wolfram.com/language/ref/ColorSetter.html
        ///</summary>
        public static Engine ColorSetter(this Engine en, string? name = null)
        {
            return en.Execute("ColorSetter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a color slider currently set to the color corresponding to color.
        /// https://reference.wolfram.com/language/ref/ColorSlider.html
        ///</summary>
        public static Engine ColorSlider(this Engine en, string? name = null)
        {
            return en.Execute("ColorSlider[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a region around color.
        /// https://reference.wolfram.com/language/ref/ColorsNear.html
        ///</summary>
        public static Engine ColorsNear(this Engine en, string? name = null)
        {
            return en.Execute("ColorsNear[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// applies a tone mapping to color values in image so as to make variations of luminance visible even in small intervals of the dynamic range.
        /// https://reference.wolfram.com/language/ref/ColorToneMapping.html
        ///</summary>
        public static Engine ColorToneMapping(this Engine en, string? name = null)
        {
            return en.Execute("ColorToneMapping[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an object that formats with the expri arranged in a column, with expr1 above expr2, etc.
        /// https://reference.wolfram.com/language/ref/Column.html
        ///</summary>
        public static Engine Column(this Engine en, string? name = null)
        {
            return en.Execute("Column[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the elements that are the most common in list.
        /// https://reference.wolfram.com/language/ref/Commonest.html
        ///</summary>
        public static Engine Commonest(this Engine en, string? name = null)
        {
            return en.Execute("Commonest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the common name for the entity specified by entity.
        /// https://reference.wolfram.com/language/ref/CommonName.html
        ///</summary>
        public static Engine CommonName(this Engine en, string? name = null)
        {
            return en.Execute("CommonName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts quantity1 through quantityn to common units across compatible dimensions.
        /// https://reference.wolfram.com/language/ref/CommonUnits.html
        ///</summary>
        public static Engine CommonUnits(this Engine en, string? name = null)
        {
            return en.Execute("CommonUnits[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a plot showing the community structure of the graph g.
        /// https://reference.wolfram.com/language/ref/CommunityGraphPlot.html
        ///</summary>
        public static Engine CommunityGraphPlot(this Engine en, string? name = null)
        {
            return en.Execute("CommunityGraphPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a function created by FunctionCompile that contains compiled code that is run when the CompiledCodeFunction is applied to suitable arguments.
        /// https://reference.wolfram.com/language/ref/CompiledCodeFunction.html
        ///</summary>
        public static Engine CompiledCodeFunction(this Engine en, string? name = null)
        {
            return en.Execute("CompiledCodeFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents compiled code for evaluating a compiled function.
        /// https://reference.wolfram.com/language/ref/CompiledFunction.html
        ///</summary>
        public static Engine CompiledFunction(this Engine en, string? name = null)
        {
            return en.Execute("CompiledFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net layer whose computation is defined by the compilable function func.
        /// https://reference.wolfram.com/language/ref/CompiledLayer.html
        ///</summary>
        public static Engine CompiledLayer(this Engine en, string? name = null)
        {
            return en.Execute("CompiledLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a function that, if defined in a compiler environment, is automatically called by the Wolfram Compiler.
        /// https://reference.wolfram.com/language/ref/CompilerCallback.html
        ///</summary>
        public static Engine CompilerCallback(this Engine en, string? name = null)
        {
            return en.Execute("CompilerCallback[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// appends declarations to $CompilerEnvironment.
        /// https://reference.wolfram.com/language/ref/CompilerEnvironmentAppendTo.html
        ///</summary>
        public static Engine CompilerEnvironmentAppendTo(this Engine en, string? name = null)
        {
            return en.Execute("CompilerEnvironmentAppendTo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the complete graph with n vertices .
        /// https://reference.wolfram.com/language/ref/CompleteGraph.html
        ///</summary>
        public static Engine CompleteGraph(this Engine en, string? name = null)
        {
            return en.Execute("CompleteGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is a complete graph, and False otherwise.
        /// https://reference.wolfram.com/language/ref/CompleteGraphQ.html
        ///</summary>
        public static Engine CompleteGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("CompleteGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the complete binary tree with n levels.
        /// https://reference.wolfram.com/language/ref/CompleteKaryTree.html
        ///</summary>
        public static Engine CompleteKaryTree(this Engine en, string? name = null)
        {
            return en.Execute("CompleteKaryTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a plot in which complex values zij in an array array are shown in a discrete array of squares with Arg[zij] indicated by color and Abs[zij] by shading.
        /// https://reference.wolfram.com/language/ref/ComplexArrayPlot.html
        ///</summary>
        public static Engine ComplexArrayPlot(this Engine en, string? name = null)
        {
            return en.Execute("ComplexArrayPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// expands expr assuming that all variables are real.
        /// https://reference.wolfram.com/language/ref/ComplexExpand.html
        ///</summary>
        public static Engine ComplexExpand(this Engine en, string? name = null)
        {
            return en.Execute("ComplexExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots complex numbers z1, z2, … as points in the complex plane.
        /// https://reference.wolfram.com/language/ref/ComplexListPlot.html
        ///</summary>
        public static Engine ComplexListPlot(this Engine en, string? name = null)
        {
            return en.Execute("ComplexListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if n is a composite number, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/CompositeQ.html
        ///</summary>
        public static Engine CompositeQ(this Engine en, string? name = null)
        {
            return en.Execute("CompositeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a form or interpreter specification for a list of fields or inputs that gives a list of results.
        /// https://reference.wolfram.com/language/ref/CompoundElement.html
        ///</summary>
        public static Engine CompoundElement(this Engine en, string? name = null)
        {
            return en.Execute("CompoundElement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a compressed representation of expr as a string.
        /// https://reference.wolfram.com/language/ref/Compress.html
        ///</summary>
        public static Engine Compress(this Engine en, string? name = null)
        {
            return en.Execute("Compress[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the concave hull mesh from the points p1,p2,….
        /// https://reference.wolfram.com/language/ref/ConcaveHullMesh.html
        ///</summary>
        public static Engine ConcaveHullMesh(this Engine en, string? name = null)
        {
            return en.Execute("ConcaveHullMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// confirms that expr is not considered a failure, otherwise throwing an error to the nearest surrounding Enclose.
        /// https://reference.wolfram.com/language/ref/Confirm.html
        ///</summary>
        public static Engine Confirm(this Engine en, string? name = null)
        {
            return en.Execute("Confirm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// confirms that test is True, otherwise throwing an error to the nearest surrounding Enclose.
        /// https://reference.wolfram.com/language/ref/ConfirmAssert.html
        ///</summary>
        public static Engine ConfirmAssert(this Engine en, string? name = null)
        {
            return en.Execute("ConfirmAssert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// confirms that no messages are generated during the evaluation of expr, otherwise quieting them and throwing an error to the nearest surrounding Enclose.
        /// https://reference.wolfram.com/language/ref/ConfirmQuiet.html
        ///</summary>
        public static Engine ConfirmQuiet(this Engine en, string? name = null)
        {
            return en.Execute("ConfirmQuiet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a list of audio objects where all audioi are made to have conforming properties, including duration, data type, and number of channels.
        /// https://reference.wolfram.com/language/ref/ConformAudio.html
        ///</summary>
        public static Engine ConformAudio(this Engine en, string? name = null)
        {
            return en.Execute("ConformAudio[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a list of images where all imagei are made to have conforming properties, including dimensions, data type, color space, and interleaving.
        /// https://reference.wolfram.com/language/ref/ConformImages.html
        ///</summary>
        public static Engine ConformImages(this Engine en, string? name = null)
        {
            return en.Execute("ConformImages[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a two-dimensional graphics directive specifying that faces of polygons and other filled graphics objects are to be drawn using a progressive transition between colors coli along a circle.
        /// https://reference.wolfram.com/language/ref/ConicGradientFilling.html
        ///</summary>
        public static Engine ConicGradientFilling(this Engine en, string? name = null)
        {
            return en.Execute("ConicGradientFilling[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the m-dimensional affine hull region passing through points pi.
        /// https://reference.wolfram.com/language/ref/ConicHullRegion.html
        ///</summary>
        public static Engine ConicHullRegion(this Engine en, string? name = null)
        {
            return en.Execute("ConicHullRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// or z gives the complex conjugate of the complex number z.
        /// https://reference.wolfram.com/language/ref/Conjugate.html
        ///</summary>
        public static Engine Conjugate(this Engine en, string? name = null)
        {
            return en.Execute("Conjugate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// or  gives the conjugate transpose of .
        /// https://reference.wolfram.com/language/ref/ConjugateTranspose.html
        ///</summary>
        public static Engine ConjugateTranspose(this Engine en, string? name = null)
        {
            return en.Execute("ConjugateTranspose[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the connected components of the graph g.
        /// https://reference.wolfram.com/language/ref/ConnectedComponents.html
        ///</summary>
        public static Engine ConnectedComponents(this Engine en, string? name = null)
        {
            return en.Execute("ConnectedComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the connected components of the graph g.
        /// https://reference.wolfram.com/language/ref/ConnectedGraphComponents.html
        ///</summary>
        public static Engine ConnectedGraphComponents(this Engine en, string? name = null)
        {
            return en.Execute("ConnectedGraphComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is connected, and False otherwise.
        /// https://reference.wolfram.com/language/ref/ConnectedGraphQ.html
        ///</summary>
        public static Engine ConnectedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("ConnectedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list {c1,c2,…} of disjoint path connected meshed regions.
        /// https://reference.wolfram.com/language/ref/ConnectedMeshComponents.html
        ///</summary>
        public static Engine ConnectedMeshComponents(this Engine en, string? name = null)
        {
            return en.Execute("ConnectedMeshComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the connected components of the molecule mol.
        /// https://reference.wolfram.com/language/ref/ConnectedMoleculeComponents.html
        ///</summary>
        public static Engine ConnectedMoleculeComponents(this Engine en, string? name = null)
        {
            return en.Execute("ConnectedMoleculeComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if the atoms in mol form are connected by bonds, and False otherwise.
        /// https://reference.wolfram.com/language/ref/ConnectedMoleculeQ.html
        ///</summary>
        public static Engine ConnectedMoleculeQ(this Engine en, string? name = null)
        {
            return en.Execute("ConnectedMoleculeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Connes window function of x.
        /// https://reference.wolfram.com/language/ref/ConnesWindow.html
        ///</summary>
        public static Engine ConnesWindow(this Engine en, string? name = null)
        {
            return en.Execute("ConnesWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the variances of data1, data2, … are equal.
        /// https://reference.wolfram.com/language/ref/ConoverTest.html
        ///</summary>
        public static Engine ConoverTest(this Engine en, string? name = null)
        {
            return en.Execute("ConoverTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if the reg is a constant region and False otherwise.
        /// https://reference.wolfram.com/language/ref/ConstantRegionQ.html
        ///</summary>
        public static Engine ConstantRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("ConstantRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an operator form that yields True when the object to which it is applied contains all of the elements of e2.
        /// https://reference.wolfram.com/language/ref/ContainsAll.html
        ///</summary>
        public static Engine ContainsAll(this Engine en, string? name = null)
        {
            return en.Execute("ContainsAll[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an operator form that yields True when the object to which it is applied contains any of the elements in e2.
        /// https://reference.wolfram.com/language/ref/ContainsAny.html
        ///</summary>
        public static Engine ContainsAny(this Engine en, string? name = null)
        {
            return en.Execute("ContainsAny[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an operator form that yields True when the object to which it is applied contains exactly the same elements as e2.
        /// https://reference.wolfram.com/language/ref/ContainsExactly.html
        ///</summary>
        public static Engine ContainsExactly(this Engine en, string? name = null)
        {
            return en.Execute("ContainsExactly[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an operator form that yields True when the object to which it is applied contains none of the elements of e2.
        /// https://reference.wolfram.com/language/ref/ContainsNone.html
        ///</summary>
        public static Engine ContainsNone(this Engine en, string? name = null)
        {
            return en.Execute("ContainsNone[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an operator form that yields True when the object to which it is applied contains only elements that appear in e2.
        /// https://reference.wolfram.com/language/ref/ContainsOnly.html
        ///</summary>
        public static Engine ContainsOnly(this Engine en, string? name = null)
        {
            return en.Execute("ContainsOnly[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a function generated by TrainImageContentDetector or TrainTextContentDetector that localizes and classifies contents in a piece of text or an image.
        /// https://reference.wolfram.com/language/ref/ContentDetectorFunction.html
        ///</summary>
        public static Engine ContentDetectorFunction(this Engine en, string? name = null)
        {
            return en.Execute("ContentDetectorFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a content object whose content is string.
        /// https://reference.wolfram.com/language/ref/ContentObject.html
        ///</summary>
        public static Engine ContentObject(this Engine en, string? name = null)
        {
            return en.Execute("ContentObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the context in which a symbol appears.
        /// https://reference.wolfram.com/language/ref/Context.html
        ///</summary>
        public static Engine Context(this Engine en, string? name = null)
        {
            return en.Execute("Context[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the contexts that match the string.
        /// https://reference.wolfram.com/language/ref/Contexts.html
        ///</summary>
        public static Engine Contexts(this Engine en, string? name = null)
        {
            return en.Execute("Contexts[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the string specifying the file name that is by convention associated with a particular context.
        /// https://reference.wolfram.com/language/ref/ContextToFileName.html
        ///</summary>
        public static Engine ContextToFileName(this Engine en, string? name = null)
        {
            return en.Execute("ContextToFileName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a list of all terms that can be obtained given the precision of x.
        /// https://reference.wolfram.com/language/ref/ContinuedFraction.html
        ///</summary>
        public static Engine ContinuedFraction(this Engine en, string? name = null)
        {
            return en.Execute("ContinuedFraction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a task in which expr is continuously reevaluated.
        /// https://reference.wolfram.com/language/ref/ContinuousTask.html
        ///</summary>
        public static Engine ContinuousTask(this Engine en, string? name = null)
        {
            return en.Execute("ContinuousTask[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if lsys is a continuous-time systems model, and False otherwise.
        /// https://reference.wolfram.com/language/ref/ContinuousTimeModelQ.html
        ///</summary>
        public static Engine ContinuousTimeModelQ(this Engine en, string? name = null)
        {
            return en.Execute("ContinuousTimeModelQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the continuous wavelet transform of a list of values xi.
        /// https://reference.wolfram.com/language/ref/ContinuousWaveletTransform.html
        ///</summary>
        public static Engine ContinuousWaveletTransform(this Engine en, string? name = null)
        {
            return en.Execute("ContinuousWaveletTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a binary image in which white pixels correspond to the zeros and zero crossings in image.
        /// https://reference.wolfram.com/language/ref/ContourDetect.html
        ///</summary>
        public static Engine ContourDetect(this Engine en, string? name = null)
        {
            return en.Execute("ContourDetect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the contraharmonic mean of the values in list.
        /// https://reference.wolfram.com/language/ref/ContraharmonicMean.html
        ///</summary>
        public static Engine ContraharmonicMean(this Engine en, string? name = null)
        {
            return en.Execute("ContraharmonicMean[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// specifies a distance above which the loss is zero for True targets.
        /// https://reference.wolfram.com/language/ref/ContrastiveLossLayer.html
        ///</summary>
        public static Engine ContrastiveLossLayer(this Engine en, string? name = null)
        {
            return en.Execute("ContrastiveLossLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an interactive control for the variable u in the domain dom, with the type of control chosen to be appropriate for the domain specified.
        /// https://reference.wolfram.com/language/ref/Control.html
        ///</summary>
        public static Engine Control(this Engine en, string? name = null)
        {
            return en.Execute("Control[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the controllability Gramian of the state-space model ssm.
        /// https://reference.wolfram.com/language/ref/ControllabilityGramian.html
        ///</summary>
        public static Engine ControllabilityGramian(this Engine en, string? name = null)
        {
            return en.Execute("ControllabilityGramian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the controllability matrix of the state-space model ssm.
        /// https://reference.wolfram.com/language/ref/ControllabilityMatrix.html
        ///</summary>
        public static Engine ControllabilityMatrix(this Engine en, string? name = null)
        {
            return en.Execute("ControllabilityMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields the controllable subsystem of the state-space model sys.
        /// https://reference.wolfram.com/language/ref/ControllableDecomposition.html
        ///</summary>
        public static Engine ControllableDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("ControllableDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the state-space model sys is controllable, and False otherwise.
        /// https://reference.wolfram.com/language/ref/ControllableModelQ.html
        ///</summary>
        public static Engine ControllableModelQ(this Engine en, string? name = null)
        {
            return en.Execute("ControllableModelQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the state of the control c for the first connected controller device on which it is supported.
        /// https://reference.wolfram.com/language/ref/ControllerState.html
        ///</summary>
        public static Engine ControllerState(this Engine en, string? name = null)
        {
            return en.Execute("ControllerState[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the convergents corresponding to the continued fraction terms list.
        /// https://reference.wolfram.com/language/ref/Convergents.html
        ///</summary>
        public static Engine Convergents(this Engine en, string? name = null)
        {
            return en.Execute("Convergents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a BoundaryMeshRegion representing the convex hull from the points p1, p2, ….
        /// https://reference.wolfram.com/language/ref/ConvexHullMesh.html
        ///</summary>
        public static Engine ConvexHullMesh(this Engine en, string? name = null)
        {
            return en.Execute("ConvexHullMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the convex hull from the points p1, p2, ….
        /// https://reference.wolfram.com/language/ref/ConvexHullRegion.html
        ///</summary>
        public static Engine ConvexHullRegion(this Engine en, string? name = null)
        {
            return en.Execute("ConvexHullRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if the polygon poly is convex, and False otherwise.
        /// https://reference.wolfram.com/language/ref/ConvexPolygonQ.html
        ///</summary>
        public static Engine ConvexPolygonQ(this Engine en, string? name = null)
        {
            return en.Execute("ConvexPolygonQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if the polyhedron poly is convex, and False otherwise.
        /// https://reference.wolfram.com/language/ref/ConvexPolyhedronQ.html
        ///</summary>
        public static Engine ConvexPolyhedronQ(this Engine en, string? name = null)
        {
            return en.Execute("ConvexPolyhedronQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if reg is a convex region and False otherwise.
        /// https://reference.wolfram.com/language/ref/ConvexRegionQ.html
        ///</summary>
        public static Engine ConvexRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("ConvexRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the corners {{xmin,ymin,…},{xmax,ymax,…}} of the bounding box of the region defined by coords.
        /// https://reference.wolfram.com/language/ref/CoordinateBoundingBox.html
        ///</summary>
        public static Engine CoordinateBoundingBox(this Engine en, string? name = null)
        {
            return en.Execute("CoordinateBoundingBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list {{xmin,xmax},{ymin,ymax},…} of the bounds in each dimension of the region defined by coords.
        /// https://reference.wolfram.com/language/ref/CoordinateBounds.html
        ///</summary>
        public static Engine CoordinateBounds(this Engine en, string? name = null)
        {
            return en.Execute("CoordinateBounds[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the points p1,p2,p3,p4,…,pn are coplanar.
        /// https://reference.wolfram.com/language/ref/CoplanarPoints.html
        ///</summary>
        public static Engine CoplanarPoints(this Engine en, string? name = null)
        {
            return en.Execute("CoplanarPoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a copy of a databin.
        /// https://reference.wolfram.com/language/ref/CopyDatabin.html
        ///</summary>
        public static Engine CopyDatabin(this Engine en, string? name = null)
        {
            return en.Execute("CopyDatabin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// replaces the contents of the clipboard with expr.
        /// https://reference.wolfram.com/language/ref/CopyToClipboard.html
        ///</summary>
        public static Engine CopyToClipboard(this Engine en, string? name = null)
        {
            return en.Execute("CopyToClipboard[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields the core-nilpotent decomposition of a square matrix m.
        /// https://reference.wolfram.com/language/ref/CoreNilpotentDecomposition.html
        ///</summary>
        public static Engine CoreNilpotentDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("CoreNilpotentDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// computes a measure for the presence of a corner for each pixel in image and returns the result as an intensity image.
        /// https://reference.wolfram.com/language/ref/CornerFilter.html
        ///</summary>
        public static Engine CornerFilter(this Engine en, string? name = null)
        {
            return en.Execute("CornerFilter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the sample correlation matrix for observations in matrix m.
        /// https://reference.wolfram.com/language/ref/Correlation.html
        ///</summary>
        public static Engine Correlation(this Engine en, string? name = null)
        {
            return en.Execute("Correlation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the cosine of z.
        /// https://reference.wolfram.com/language/ref/Cos.html
        ///</summary>
        public static Engine Cos(this Engine en, string? name = null)
        {
            return en.Execute("Cos[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the hyperbolic cosine of z.
        /// https://reference.wolfram.com/language/ref/Cosh.html
        ///</summary>
        public static Engine Cosh(this Engine en, string? name = null)
        {
            return en.Execute("Cosh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the hyperbolic cosine integral .
        /// https://reference.wolfram.com/language/ref/CoshIntegral.html
        ///</summary>
        public static Engine CoshIntegral(this Engine en, string? name = null)
        {
            return en.Execute("CoshIntegral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a cosine window function of x.
        /// https://reference.wolfram.com/language/ref/CosineWindow.html
        ///</summary>
        public static Engine CosineWindow(this Engine en, string? name = null)
        {
            return en.Execute("CosineWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the cosine integral function .
        /// https://reference.wolfram.com/language/ref/CosIntegral.html
        ///</summary>
        public static Engine CosIntegral(this Engine en, string? name = null)
        {
            return en.Execute("CosIntegral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the cotangent of z.
        /// https://reference.wolfram.com/language/ref/Cot.html
        ///</summary>
        public static Engine Cot(this Engine en, string? name = null)
        {
            return en.Execute("Cot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the hyperbolic cotangent of z.
        /// https://reference.wolfram.com/language/ref/Coth.html
        ///</summary>
        public static Engine Coth(this Engine en, string? name = null)
        {
            return en.Execute("Coth[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of Count that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/Count.html
        ///</summary>
        public static Engine Count(this Engine en, string? name = null)
        {
            return en.Execute("Count[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of distinct elements that appear in list.
        /// https://reference.wolfram.com/language/ref/CountDistinct.html
        ///</summary>
        public static Engine CountDistinct(this Engine en, string? name = null)
        {
            return en.Execute("CountDistinct[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of CountDistinctBy that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/CountDistinctBy.html
        ///</summary>
        public static Engine CountDistinctBy(this Engine en, string? name = null)
        {
            return en.Execute("CountDistinctBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an association whose keys are the distinct elements of list, and whose values give the number of times those elements appear in list.
        /// https://reference.wolfram.com/language/ref/Counts.html
        ///</summary>
        public static Engine Counts(this Engine en, string? name = null)
        {
            return en.Execute("Counts[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of CountsBy that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/CountsBy.html
        ///</summary>
        public static Engine CountsBy(this Engine en, string? name = null)
        {
            return en.Execute("CountsBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the sample covariance matrix for observations in matrix m.
        /// https://reference.wolfram.com/language/ref/Covariance.html
        ///</summary>
        public static Engine Covariance(this Engine en, string? name = null)
        {
            return en.Execute("Covariance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the symbolic proportional hazards model obtained from CoxModelFit.
        /// https://reference.wolfram.com/language/ref/CoxModel.html
        ///</summary>
        public static Engine CoxModel(this Engine en, string? name = null)
        {
            return en.Execute("CoxModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// constructs a model of the baseline hazard  for events times ei.
        /// https://reference.wolfram.com/language/ref/CoxModelFit.html
        ///</summary>
        public static Engine CoxModelFit(this Engine en, string? name = null)
        {
            return en.Execute("CoxModelFit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether data is normally distributed using the Cramér–von Mises test.
        /// https://reference.wolfram.com/language/ref/CramerVonMisesTest.html
        ///</summary>
        public static Engine CramerVonMisesTest(this Engine en, string? name = null)
        {
            return en.Execute("CramerVonMisesTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a compressed archive in the current directory from source.
        /// https://reference.wolfram.com/language/ref/CreateArchive.html
        ///</summary>
        public static Engine CreateArchive(this Engine en, string? name = null)
        {
            return en.Execute("CreateArchive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a channel with the specified path relative to the home area of the currently authenticated user.
        /// https://reference.wolfram.com/language/ref/CreateChannel.html
        ///</summary>
        public static Engine CreateChannel(this Engine en, string? name = null)
        {
            return en.Execute("CreateChannel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a new anonymous cloud expression that stores the specified initial value.
        /// https://reference.wolfram.com/language/ref/CreateCloudExpression.html
        ///</summary>
        public static Engine CreateCloudExpression(this Engine en, string? name = null)
        {
            return en.Execute("CreateCloudExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a databin with the specified options.
        /// https://reference.wolfram.com/language/ref/CreateDatabin.html
        ///</summary>
        public static Engine CreateDatabin(this Engine en, string? name = null)
        {
            return en.Execute("CreateDatabin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a SystemModel generating a signal of values vi.
        /// https://reference.wolfram.com/language/ref/CreateDataSystemModel.html
        ///</summary>
        public static Engine CreateDataSystemModel(this Engine en, string? name = null)
        {
            return en.Execute("CreateDataSystemModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a dialog notebook containing expr and opens it in the front end.
        /// https://reference.wolfram.com/language/ref/CreateDialog.html
        ///</summary>
        public static Engine CreateDialog(this Engine en, string? name = null)
        {
            return en.Execute("CreateDialog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a directory with name dir.
        /// https://reference.wolfram.com/language/ref/CreateDirectory.html
        ///</summary>
        public static Engine CreateDirectory(this Engine en, string? name = null)
        {
            return en.Execute("CreateDirectory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates and opens a document notebook containing the expression expr.
        /// https://reference.wolfram.com/language/ref/CreateDocument.html
        ///</summary>
        public static Engine CreateDocument(this Engine en, string? name = null)
        {
            return en.Execute("CreateDocument[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a file with name file.
        /// https://reference.wolfram.com/language/ref/CreateFile.html
        ///</summary>
        public static Engine CreateFile(this Engine en, string? name = null)
        {
            return en.Execute("CreateFile[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates an on-demand license entitlement using settings.
        /// https://reference.wolfram.com/language/ref/CreateLicenseEntitlement.html
        ///</summary>
        public static Engine CreateLicenseEntitlement(this Engine en, string? name = null)
        {
            return en.Execute("CreateLicenseEntitlement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates an empty notebook of the specified type and opens it in the front end.
        /// https://reference.wolfram.com/language/ref/CreateNotebook.html
        ///</summary>
        public static Engine CreateNotebook(this Engine en, string? name = null)
        {
            return en.Execute("CreateNotebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a paclet archive file from source.
        /// https://reference.wolfram.com/language/ref/CreatePacletArchive.html
        ///</summary>
        public static Engine CreatePacletArchive(this Engine en, string? name = null)
        {
            return en.Execute("CreatePacletArchive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a palette notebook containing expr, and opens it in the front end.
        /// https://reference.wolfram.com/language/ref/CreatePalette.html
        ///</summary>
        public static Engine CreatePalette(this Engine en, string? name = null)
        {
            return en.Execute("CreatePalette[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a permissions group with the specified name.
        /// https://reference.wolfram.com/language/ref/CreatePermissionsGroup.html
        ///</summary>
        public static Engine CreatePermissionsGroup(this Engine en, string? name = null)
        {
            return en.Execute("CreatePermissionsGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a search index from all files in the directory dir and its subdirectories.
        /// https://reference.wolfram.com/language/ref/CreateSearchIndex.html
        ///</summary>
        public static Engine CreateSearchIndex(this Engine en, string? name = null)
        {
            return en.Execute("CreateSearchIndex[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a Modelica SystemModel from the systems model sys.
        /// https://reference.wolfram.com/language/ref/CreateSystemModel.html
        ///</summary>
        public static Engine CreateSystemModel(this Engine en, string? name = null)
        {
            return en.Execute("CreateSystemModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// appends a UUID string to the specified base string.
        /// https://reference.wolfram.com/language/ref/CreateUUID.html
        ///</summary>
        public static Engine CreateUUID(this Engine en, string? name = null)
        {
            return en.Execute("CreateUUID[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a window displaying the notebook expression expr, and opens it in the front end.
        /// https://reference.wolfram.com/language/ref/CreateWindow.html
        ///</summary>
        public static Engine CreateWindow(this Engine en, string? name = null)
        {
            return en.Execute("CreateWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net layer that computes the cross-entropy loss by comparing input class probability vectors with indices representing the target class.
        /// https://reference.wolfram.com/language/ref/CrossEntropyLossLayer.html
        ///</summary>
        public static Engine CrossEntropyLossLayer(this Engine en, string? name = null)
        {
            return en.Execute("CrossEntropyLossLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a binary image in which white pixels correspond to the zero crossings in image.
        /// https://reference.wolfram.com/language/ref/CrossingDetect.html
        ///</summary>
        public static Engine CrossingDetect(this Engine en, string? name = null)
        {
            return en.Execute("CrossingDetect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a Polygon representing all points for which a ray from the point in any direction in the plane crosses the line segments {p1,p2},…,{pn-1,pn},{pn,p1} an odd number of times.
        /// https://reference.wolfram.com/language/ref/CrossingPolygon.html
        ///</summary>
        public static Engine CrossingPolygon(this Engine en, string? name = null)
        {
            return en.Execute("CrossingPolygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a matrix whose elements are 1 in a centered cross-shaped region that extends r positions along each index direction, and are 0 otherwise.
        /// https://reference.wolfram.com/language/ref/CrossMatrix.html
        ///</summary>
        public static Engine CrossMatrix(this Engine en, string? name = null)
        {
            return en.Execute("CrossMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the cosecant of z.
        /// https://reference.wolfram.com/language/ref/Csc.html
        ///</summary>
        public static Engine Csc(this Engine en, string? name = null)
        {
            return en.Execute("Csc[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the hyperbolic cosecant of z.
        /// https://reference.wolfram.com/language/ref/Csch.html
        ///</summary>
        public static Engine Csch(this Engine en, string? name = null)
        {
            return en.Execute("Csch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the region reg is a valid CSGRegion object and False otherwise.
        /// https://reference.wolfram.com/language/ref/CSGRegionQ.html
        ///</summary>
        public static Engine CSGRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("CSGRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the tree expression representing the CSG region reg.
        /// https://reference.wolfram.com/language/ref/CSGRegionTree.html
        ///</summary>
        public static Engine CSGRegionTree(this Engine en, string? name = null)
        {
            return en.Execute("CSGRegionTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a cube with edge length l.
        /// https://reference.wolfram.com/language/ref/Cube.html
        ///</summary>
        public static Engine Cube(this Engine en, string? name = null)
        {
            return en.Execute("Cube[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the real-valued cube root of x.
        /// https://reference.wolfram.com/language/ref/CubeRoot.html
        ///</summary>
        public static Engine CubeRoot(this Engine en, string? name = null)
        {
            return en.Execute("CubeRoot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a unit hypercube with its lower corner at pmin.
        /// https://reference.wolfram.com/language/ref/Cuboid.html
        ///</summary>
        public static Engine Cuboid(this Engine en, string? name = null)
        {
            return en.Execute("Cuboid[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the r formal cumulant.
        /// https://reference.wolfram.com/language/ref/Cumulant.html
        ///</summary>
        public static Engine Cumulant(this Engine en, string? name = null)
        {
            return en.Execute("Cumulant[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// estimates the feature impacts using synthetic data.
        /// https://reference.wolfram.com/language/ref/CumulativeFeatureImpactPlot.html
        ///</summary>
        public static Engine CumulativeFeatureImpactPlot(this Engine en, string? name = null)
        {
            return en.Execute("CumulativeFeatureImpactPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the current date of the specified granularity type gran.
        /// https://reference.wolfram.com/language/ref/CurrentDate.html
        ///</summary>
        public static Engine CurrentDate(this Engine en, string? name = null)
        {
            return en.Execute("CurrentDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns n sequential image frames as a list.
        /// https://reference.wolfram.com/language/ref/CurrentImage.html
        ///</summary>
        public static Engine CurrentImage(this Engine en, string? name = null)
        {
            return en.Execute("CurrentImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns an image captured from the portion of the notebook nb that appears on your screen.
        /// https://reference.wolfram.com/language/ref/CurrentNotebookImage.html
        ///</summary>
        public static Engine CurrentNotebookImage(this Engine en, string? name = null)
        {
            return en.Execute("CurrentNotebookImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns an image captured from display screen n.
        /// https://reference.wolfram.com/language/ref/CurrentScreenImage.html
        ///</summary>
        public static Engine CurrentScreenImage(this Engine en, string? name = null)
        {
            return en.Execute("CurrentScreenImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the current value of item at a location in the Wolfram System and interface.
        /// https://reference.wolfram.com/language/ref/CurrentValue.html
        ///</summary>
        public static Engine CurrentValue(this Engine en, string? name = null)
        {
            return en.Execute("CurrentValue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of CurryApplied that can be applied to a function to represent an operator form with n arguments.
        /// https://reference.wolfram.com/language/ref/CurryApplied.html
        ///</summary>
        public static Engine CurryApplied(this Engine en, string? name = null)
        {
            return en.Execute("CurryApplied[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// applies a mean curvature flow filter to image.
        /// https://reference.wolfram.com/language/ref/CurvatureFlowFilter.html
        ///</summary>
        public static Engine CurvatureFlowFilter(this Engine en, string? name = null)
        {
            return en.Execute("CurvatureFlowFilter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the cycle graph with n vertices .
        /// https://reference.wolfram.com/language/ref/CycleGraph.html
        ///</summary>
        public static Engine CycleGraph(this Engine en, string? name = null)
        {
            return en.Execute("CycleGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a permutation with disjoint cycles cyci.
        /// https://reference.wolfram.com/language/ref/Cycles.html
        ///</summary>
        public static Engine Cycles(this Engine en, string? name = null)
        {
            return en.Execute("Cycles[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the cyclic group of degree n.
        /// https://reference.wolfram.com/language/ref/CyclicGroup.html
        ///</summary>
        public static Engine CyclicGroup(this Engine en, string? name = null)
        {
            return en.Execute("CyclicGroup[" + en.ValidNames.Last() + "]", name);
        }


    }
}
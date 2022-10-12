namespace NetWolf
{
    public static class BuiltinSymbolC
    {
		///<summary>
		///is the default form for the i  parameter or constant generated in representing the results of various symbolic computations.
		///https://reference.wolfram.com/language/ref/C.html
		///</summary>
		public static Engine C(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("C[" + arg0 + "]", name);
		}

		///<summary>
		///converts the date object date to the specified calendar type calendar.
		///https://reference.wolfram.com/language/ref/CalendarConvert.html
		///</summary>
		public static Engine CalendarConvert(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CalendarConvert[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///converts to the default calendar type.
		///https://reference.wolfram.com/language/ref/CalendarConvert.html
		///</summary>
		public static Engine CalendarConvert(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CalendarConvert[" + arg0 + "]", name);
		}

		///<summary>
		///converts date1 through daten to the specified calendar.
		///https://reference.wolfram.com/language/ref/CalendarConvert.html
		///</summary>
		public static Engine CalendarConvert(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CalendarConvert[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the default parameters associated with the date calendar cal.
		///https://reference.wolfram.com/language/ref/CalendarData.html
		///</summary>
		public static Engine CalendarData(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CalendarData[" + arg0 + "]", name);
		}

		///<summary>
		///gives the value of the specified parameter param for calendar cal.
		///https://reference.wolfram.com/language/ref/CalendarData.html
		///</summary>
		public static Engine CalendarData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CalendarData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///displays expr in a plot as a callout pointing to data.
		///https://reference.wolfram.com/language/ref/Callout.html
		///</summary>
		public static Engine Callout(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Callout[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///displays a callout with expr at a position specified by pos.
		///https://reference.wolfram.com/language/ref/Callout.html
		///</summary>
		public static Engine Callout(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Callout[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///displays a callout anchored at a position specified by apos.
		///https://reference.wolfram.com/language/ref/Callout.html
		///</summary>
		public static Engine Callout(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Callout[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///is a WSTP packet encapsulating a request to invoke the external function numbered integer with the arguments contained in list.
		///https://reference.wolfram.com/language/ref/CallPacket.html
		///</summary>
		public static Engine CallPacket(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CallPacket[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the Canberra distance between vectors u and v.
		///https://reference.wolfram.com/language/ref/CanberraDistance.html
		///</summary>
		public static Engine CanberraDistance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CanberraDistance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///cancels out common factors in the numerator and denominator of expr.
		///https://reference.wolfram.com/language/ref/Cancel.html
		///</summary>
		public static Engine Cancel(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cancel[" + arg0 + "]", name);
		}

		///<summary>
		///represents a Cancel button in a dialog that closes the dialog window when clicked.
		///https://reference.wolfram.com/language/ref/CancelButton.html
		///</summary>
		public static Engine CancelButton(this Engine en, string? name = null)
		{
				return en.Execute("CancelButton[]", name);
		}

		///<summary>
		///represents a button labeled Cancel that evaluates action when clicked.
		///https://reference.wolfram.com/language/ref/CancelButton.html
		///</summary>
		public static Engine CancelButton(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CancelButton[" + arg0 + "]", name);
		}

		///<summary>
		///uses label as the label for the button.
		///https://reference.wolfram.com/language/ref/CancelButton.html
		///</summary>
		public static Engine CancelButton(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CancelButton[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///makes a chart with candles representing open, high, low, and close prices for each date.
		///https://reference.wolfram.com/language/ref/CandlestickChart.html
		///</summary>
		public static Engine CandlestickChart(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CandlestickChart[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///makes a candlestick chart for the financial entity "name" over the date range daterange.
		///https://reference.wolfram.com/language/ref/CandlestickChart.html
		///</summary>
		public static Engine CandlestickChart(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CandlestickChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives a canonical form of the graph g.
		///https://reference.wolfram.com/language/ref/CanonicalGraph.html
		///</summary>
		public static Engine CanonicalGraph(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CanonicalGraph[" + arg0 + "]", name);
		}

		///<summary>
		///uses rules vw to specify the graph.
		///https://reference.wolfram.com/language/ref/CanonicalGraph.html
		///</summary>
		public static Engine CanonicalGraph(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CanonicalGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives a canonical representation of the polygon poly with shared coordinates and with inner and outer boundaries.
		///https://reference.wolfram.com/language/ref/CanonicalizePolygon.html
		///</summary>
		public static Engine CanonicalizePolygon(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CanonicalizePolygon[" + arg0 + "]", name);
		}

		///<summary>
		///gives a canonical representation of poly with the specified filter.
		///https://reference.wolfram.com/language/ref/CanonicalizePolygon.html
		///</summary>
		public static Engine CanonicalizePolygon(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CanonicalizePolygon[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a canonical representation of the polyhedron poly with shared coordinates and with inner and outer boundaries.
		///https://reference.wolfram.com/language/ref/CanonicalizePolyhedron.html
		///</summary>
		public static Engine CanonicalizePolyhedron(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CanonicalizePolyhedron[" + arg0 + "]", name);
		}

		///<summary>
		///gives a canonical representation of the region reg.
		///https://reference.wolfram.com/language/ref/CanonicalizeRegion.html
		///</summary>
		public static Engine CanonicalizeRegion(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CanonicalizeRegion[" + arg0 + "]", name);
		}

		///<summary>
		///gives the canonical name for the entity specified by entity.
		///https://reference.wolfram.com/language/ref/CanonicalName.html
		///</summary>
		public static Engine CanonicalName(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CanonicalName[" + arg0 + "]", name);
		}

		///<summary>
		///gives the canonical name for entity1 through entityn.
		///https://reference.wolfram.com/language/ref/CanonicalName.html
		///</summary>
		public static Engine CanonicalName(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CanonicalName[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the canonical time warping (CTW) correspondence between sequences s1 and s2.
		///https://reference.wolfram.com/language/ref/CanonicalWarpingCorrespondence.html
		///</summary>
		public static Engine CanonicalWarpingCorrespondence(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CanonicalWarpingCorrespondence[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses warp as initial warping correspondence.
		///https://reference.wolfram.com/language/ref/CanonicalWarpingCorrespondence.html
		///</summary>
		public static Engine CanonicalWarpingCorrespondence(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CanonicalWarpingCorrespondence[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///uses a window win for local search.
		///https://reference.wolfram.com/language/ref/CanonicalWarpingCorrespondence.html
		///</summary>
		public static Engine CanonicalWarpingCorrespondence(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CanonicalWarpingCorrespondence[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the canonical time warping (CTW) distance between sequences s1 and s2.
		///https://reference.wolfram.com/language/ref/CanonicalWarpingDistance.html
		///</summary>
		public static Engine CanonicalWarpingDistance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CanonicalWarpingDistance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses init as the initial correspondence between the two sequences.
		///https://reference.wolfram.com/language/ref/CanonicalWarpingDistance.html
		///</summary>
		public static Engine CanonicalWarpingDistance(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CanonicalWarpingDistance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///uses a window win for local search.
		///https://reference.wolfram.com/language/ref/CanonicalWarpingDistance.html
		///</summary>
		public static Engine CanonicalWarpingDistance(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CanonicalWarpingDistance[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives a mesh region representing the n-step Cantor set.
		///https://reference.wolfram.com/language/ref/CantorMesh.html
		///</summary>
		public static Engine CantorMesh(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CantorMesh[" + arg0 + "]", name);
		}

		///<summary>
		///gives the n-step Cantor set in dimension d.
		///https://reference.wolfram.com/language/ref/CantorMesh.html
		///</summary>
		public static Engine CantorMesh(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CantorMesh[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the Cantor staircase function .
		///https://reference.wolfram.com/language/ref/CantorStaircase.html
		///</summary>
		public static Engine CantorStaircase(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CantorStaircase[" + arg0 + "]", name);
		}

		///<summary>
		///represents an empty canvas in the current notebook in which you can do free-form drawing.
		///https://reference.wolfram.com/language/ref/Canvas.html
		///</summary>
		public static Engine Canvas(this Engine en, string? name = null)
		{
				return en.Execute("Canvas[]", name);
		}

		///<summary>
		///represents a canvas that initially contains the specified 2D graphic.
		///https://reference.wolfram.com/language/ref/Canvas.html
		///</summary>
		public static Engine Canvas(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Canvas[" + arg0 + "]", name);
		}

		///<summary>
		///displays as x⌢y⌢….
		///https://reference.wolfram.com/language/ref/Cap.html
		///</summary>
		public static Engine Cap(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Cap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///is a graphics primitive that specifies what type of caps should be used at the ends of lines, tubes, and related primitives.
		///https://reference.wolfram.com/language/ref/CapForm.html
		///</summary>
		public static Engine CapForm(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CapForm[" + arg0 + "]", name);
		}

		///<summary>
		///displays as x.
		///https://reference.wolfram.com/language/ref/CapitalDifferentialD.html
		///</summary>
		public static Engine CapitalDifferentialD(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CapitalDifferentialD[" + arg0 + "]", name);
		}

		///<summary>
		///yields a string in which the first character has been made uppercase.
		///https://reference.wolfram.com/language/ref/Capitalize.html
		///</summary>
		public static Engine Capitalize(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Capitalize[" + arg0 + "]", name);
		}

		///<summary>
		///gives a string capitalized using the specified capitalization scheme.
		///https://reference.wolfram.com/language/ref/Capitalize.html
		///</summary>
		public static Engine Capitalize(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Capitalize[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the filled capsule between points {xi,yi,zi} and radius r.
		///https://reference.wolfram.com/language/ref/CapsuleShape.html
		///</summary>
		public static Engine CapsuleShape(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("CapsuleShape[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the Caputo fractional differintegral  of the function .
		///https://reference.wolfram.com/language/ref/CaputoD.html
		///</summary>
		public static Engine CaputoD(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CaputoD[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///Carleman linearizes the nonlinear state-space model sys according to spec.
		///https://reference.wolfram.com/language/ref/CarlemanLinearize.html
		///</summary>
		public static Engine CarlemanLinearize(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CarlemanLinearize[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the Carlson's elliptic integral .
		///https://reference.wolfram.com/language/ref/CarlsonRC.html
		///</summary>
		public static Engine CarlsonRC(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CarlsonRC[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the Carlson's elliptic integral .
		///https://reference.wolfram.com/language/ref/CarlsonRD.html
		///</summary>
		public static Engine CarlsonRD(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CarlsonRD[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the Carlson's elliptic integral .
		///https://reference.wolfram.com/language/ref/CarlsonRE.html
		///</summary>
		public static Engine CarlsonRE(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CarlsonRE[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the Carlson's elliptic integral .
		///https://reference.wolfram.com/language/ref/CarlsonRF.html
		///</summary>
		public static Engine CarlsonRF(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CarlsonRF[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the Carlson's elliptic integral .
		///https://reference.wolfram.com/language/ref/CarlsonRG.html
		///</summary>
		public static Engine CarlsonRG(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CarlsonRG[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives Carlson's elliptic integral .
		///https://reference.wolfram.com/language/ref/CarlsonRJ.html
		///</summary>
		public static Engine CarlsonRJ(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CarlsonRJ[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the Carlson's elliptic integral .
		///https://reference.wolfram.com/language/ref/CarlsonRK.html
		///</summary>
		public static Engine CarlsonRK(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CarlsonRK[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives Carlson's elliptic integral .
		///https://reference.wolfram.com/language/ref/CarlsonRM.html
		///</summary>
		public static Engine CarlsonRM(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CarlsonRM[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the Carmichael function .
		///https://reference.wolfram.com/language/ref/CarmichaelLambda.html
		///</summary>
		public static Engine CarmichaelLambda(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CarmichaelLambda[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of the ei that match the pattern.
		///https://reference.wolfram.com/language/ref/Cases.html
		///</summary>
		public static Engine Cases(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Cases[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of all parts of expr on levels specified by levelspec that match the pattern.
		///https://reference.wolfram.com/language/ref/Cases.html
		///</summary>
		public static Engine Cases(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Cases[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the first n parts in expr that match the pattern.
		///https://reference.wolfram.com/language/ref/Cases.html
		///</summary>
		public static Engine Cases(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Cases[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents an operator form of Cases that can be applied to an expression.
		///https://reference.wolfram.com/language/ref/Cases.html
		///</summary>
		public static Engine Cases(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cases[" + arg0 + "]", name);
		}

		///<summary>
		///represents a string pattern that requires matching typographical case, even with the overall option setting IgnoreCase->True.
		///https://reference.wolfram.com/language/ref/CaseSensitive.html
		///</summary>
		public static Engine CaseSensitive(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CaseSensitive[" + arg0 + "]", name);
		}

		///<summary>
		///represents a series of cash flows occurring at unit time intervals.
		///https://reference.wolfram.com/language/ref/Cashflow.html
		///</summary>
		public static Engine Cashflow(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Cashflow[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents cash flows occurring at time intervals q.
		///https://reference.wolfram.com/language/ref/Cashflow.html
		///</summary>
		public static Engine Cashflow(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Cashflow[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents cash flows occurring at the specified times.
		///https://reference.wolfram.com/language/ref/Cashflow.html
		///</summary>
		public static Engine Cashflow(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Cashflow[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the Casoratian determinant for the sequences y1, y2, … depending on n.
		///https://reference.wolfram.com/language/ref/Casoratian.html
		///</summary>
		public static Engine Casoratian(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Casoratian[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the Casoratian determinant for the basis of the solutions of the linear difference equation eqn involving y[n+m].
		///https://reference.wolfram.com/language/ref/Casoratian.html
		///</summary>
		public static Engine Casoratian(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Casoratian[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the Casoratian determinant for the system of linear difference equations eqns.
		///https://reference.wolfram.com/language/ref/Casoratian.html
		///</summary>
		public static Engine Casoratian(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("Casoratian[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///converts val to the type type, for use in compiled code.
		///https://reference.wolfram.com/language/ref/Cast.html
		///</summary>
		public static Engine Cast(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Cast[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///reinterprets the bits representing val as having the type type.
		///https://reference.wolfram.com/language/ref/Cast.html
		///</summary>
		public static Engine Cast(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Cast[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the n Catalan number .
		///https://reference.wolfram.com/language/ref/CatalanNumber.html
		///</summary>
		public static Engine CatalanNumber(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CatalanNumber[" + arg0 + "]", name);
		}

		///<summary>
		///returns the argument of the first Throw generated in the evaluation of expr.
		///https://reference.wolfram.com/language/ref/Catch.html
		///</summary>
		public static Engine Catch(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Catch[" + arg0 + "]", name);
		}

		///<summary>
		///returns value from the first Throw[value,tag] for which form matches tag.
		///https://reference.wolfram.com/language/ref/Catch.html
		///</summary>
		public static Engine Catch(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Catch[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns f[value,tag].
		///https://reference.wolfram.com/language/ref/Catch.html
		///</summary>
		public static Engine Catch(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Catch[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a uniform categorical distribution over classes c1, c2, etc.
		///https://reference.wolfram.com/language/ref/CategoricalDistribution.html
		///</summary>
		public static Engine CategoricalDistribution(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CategoricalDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents a categorical distribution over classes ci with weights wi.
		///https://reference.wolfram.com/language/ref/CategoricalDistribution.html
		///</summary>
		public static Engine CategoricalDistribution(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CategoricalDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///uses the array weights to define probabilities over each element of the domain.
		///https://reference.wolfram.com/language/ref/CategoricalDistribution.html
		///</summary>
		public static Engine CategoricalDistribution(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CategoricalDistribution[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields a single list with all elements from the listi in order.
		///https://reference.wolfram.com/language/ref/Catenate.html
		///</summary>
		public static Engine Catenate(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Catenate[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents a net layer that takes a list of input arrays and catenates them.
		///https://reference.wolfram.com/language/ref/CatenateLayer.html
		///</summary>
		public static Engine CatenateLayer(this Engine en, string? name = null)
		{
				return en.Execute("CatenateLayer[]", name);
		}

		///<summary>
		///represents a net layer that takes a list of input arrays and catenates them at level n.
		///https://reference.wolfram.com/language/ref/CatenateLayer.html
		///</summary>
		public static Engine CatenateLayer(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CatenateLayer[" + arg0 + "]", name);
		}

		///<summary>
		///represents a Cauchy distribution with location parameter a and scale parameter b.
		///https://reference.wolfram.com/language/ref/CauchyDistribution.html
		///</summary>
		public static Engine CauchyDistribution(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CauchyDistribution[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a Cauchy distribution with location parameter 0 and scale parameter 1.
		///https://reference.wolfram.com/language/ref/CauchyDistribution.html
		///</summary>
		public static Engine CauchyDistribution(this Engine en, string? name = null)
		{
				return en.Execute("CauchyDistribution[]", name);
		}

		///<summary>
		///represents a Cauchy cluster point process with density μ, cluster mean λ and scale parameter b in .
		///https://reference.wolfram.com/language/ref/CauchyPointProcess.html
		///</summary>
		public static Engine CauchyPointProcess(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CauchyPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents a Cauchy window function of x.
		///https://reference.wolfram.com/language/ref/CauchyWindow.html
		///</summary>
		public static Engine CauchyWindow(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CauchyWindow[" + arg0 + "]", name);
		}

		///<summary>
		///uses the parameter α.
		///https://reference.wolfram.com/language/ref/CauchyWindow.html
		///</summary>
		public static Engine CauchyWindow(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CauchyWindow[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns a Cayley graph representation of group.
		///https://reference.wolfram.com/language/ref/CayleyGraph.html
		///</summary>
		public static Engine CayleyGraph(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CayleyGraph[" + arg0 + "]", name);
		}

		///<summary>
		///gives the cumulative distribution function for the distribution dist evaluated at x.
		///https://reference.wolfram.com/language/ref/CDF.html
		///</summary>
		public static Engine CDF(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CDF[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the multivariate cumulative distribution function for the distribution dist evaluated at {x1,x2,…}.
		///https://reference.wolfram.com/language/ref/CDF.html
		///</summary>
		public static Engine CDF(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CDF[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the CDF as a pure function.
		///https://reference.wolfram.com/language/ref/CDF.html
		///</summary>
		public static Engine CDF(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CDF[" + arg0 + "]", name);
		}

		///<summary>
		///deploys expr in a form that can be played by Wolfram Player.
		///https://reference.wolfram.com/language/ref/CDFDeploy.html
		///</summary>
		public static Engine CDFDeploy(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CDFDeploy[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a Cohen–Daubechies–Feauveau wavelet of type "9/7".
		///https://reference.wolfram.com/language/ref/CDFWavelet.html
		///</summary>
		public static Engine CDFWavelet(this Engine en, string? name = null)
		{
				return en.Execute("CDFWavelet[]", name);
		}

		///<summary>
		///represents a Cohen–Daubechies–Feauveau wavelet of type "type".
		///https://reference.wolfram.com/language/ref/CDFWavelet.html
		///</summary>
		public static Engine CDFWavelet(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CDFWavelet[" + arg0 + "]", name);
		}

		///<summary>
		///gives the smallest integer greater than or equal to x.
		///https://reference.wolfram.com/language/ref/Ceiling.html
		///</summary>
		public static Engine Ceiling(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Ceiling[" + arg0 + "]", name);
		}

		///<summary>
		///gives the smallest multiple of a greater than or equal to x.
		///https://reference.wolfram.com/language/ref/Ceiling.html
		///</summary>
		public static Engine Ceiling(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Ceiling[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is the low-level representation of a cell inside a Wolfram System notebook.
		///https://reference.wolfram.com/language/ref/Cell.html
		///</summary>
		public static Engine Cell(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cell[" + arg0 + "]", name);
		}

		///<summary>
		///represents a cell in the specified style.
		///https://reference.wolfram.com/language/ref/Cell.html
		///</summary>
		public static Engine Cell(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Cell[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a cell with multiple styles applied to it.
		///https://reference.wolfram.com/language/ref/Cell.html
		///</summary>
		public static Engine Cell(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Cell[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives an open group of cells that can appear in a Wolfram System notebook.
		///https://reference.wolfram.com/language/ref/CellGroup.html
		///</summary>
		public static Engine CellGroup(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CellGroup[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives a cell group in which only the first cell is open.
		///https://reference.wolfram.com/language/ref/CellGroup.html
		///</summary>
		public static Engine CellGroup(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CellGroup[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a cell group in which cells i1, i2, …  are open.
		///https://reference.wolfram.com/language/ref/CellGroup.html
		///</summary>
		public static Engine CellGroup(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CellGroup[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///is a low-level construct that represents an open group of cells in a notebook.
		///https://reference.wolfram.com/language/ref/CellGroupData.html
		///</summary>
		public static Engine CellGroupData(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CellGroupData[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents a cell group that is open or closed according to the value of status.
		///https://reference.wolfram.com/language/ref/CellGroupData.html
		///</summary>
		public static Engine CellGroupData(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CellGroupData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a cell group with cells at positions i1, i2, … open.
		///https://reference.wolfram.com/language/ref/CellGroupData.html
		///</summary>
		public static Engine CellGroupData(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CellGroupData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///is an object that represents a cell in an open notebook in the front end.
		///https://reference.wolfram.com/language/ref/CellObject.html
		///</summary>
		public static Engine CellObject(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CellObject[" + arg0 + "]", name);
		}

		///<summary>
		///inserts expr as a complete cell in the current notebook just below the cell being evaluated.
		///https://reference.wolfram.com/language/ref/CellPrint.html
		///</summary>
		public static Engine CellPrint(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CellPrint[" + arg0 + "]", name);
		}

		///<summary>
		///inserts a sequence of cells.
		///https://reference.wolfram.com/language/ref/CellPrint.html
		///</summary>
		public static Engine CellPrint(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CellPrint[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///returns a list of CellObject expressions corresponding to cells in the current notebook.
		///https://reference.wolfram.com/language/ref/Cells.html
		///</summary>
		public static Engine Cells(this Engine en, string? name = null)
		{
				return en.Execute("Cells[]", name);
		}

		///<summary>
		///returns the list of CellObject expressions in obj.
		///https://reference.wolfram.com/language/ref/Cells.html
		///</summary>
		public static Engine Cells(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cells[" + arg0 + "]", name);
		}

		///<summary>
		///generates a list representing the evolution of the cellular automaton with the specified rule from initial condition init for t steps.
		///https://reference.wolfram.com/language/ref/CellularAutomaton.html
		///</summary>
		public static Engine CellularAutomaton(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CellularAutomaton[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the result of evolving init for one step.
		///https://reference.wolfram.com/language/ref/CellularAutomaton.html
		///</summary>
		public static Engine CellularAutomaton(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CellularAutomaton[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives only those parts of the evolution specified by tspec, xspec, etc.
		///https://reference.wolfram.com/language/ref/CellularAutomaton.html
		///</summary>
		public static Engine CellularAutomaton(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CellularAutomaton[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///is an operator form of CellularAutomaton that represents one step of evolution.
		///https://reference.wolfram.com/language/ref/CellularAutomaton.html
		///</summary>
		public static Engine CellularAutomaton(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CellularAutomaton[" + arg0 + "]", name);
		}

		///<summary>
		///represents the distribution of values that come from dist and are censored to be between xmin and xmax.
		///https://reference.wolfram.com/language/ref/CensoredDistribution.html
		///</summary>
		public static Engine CensoredDistribution(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CensoredDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the distribution of values that come from the multivariate distribution dist and are censored to be between xmin and xmax, ymin and ymax, etc.
		///https://reference.wolfram.com/language/ref/CensoredDistribution.html
		///</summary>
		public static Engine CensoredDistribution(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("CensoredDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a censored event time t with censoring c.
		///https://reference.wolfram.com/language/ref/Censoring.html
		///</summary>
		public static Engine Censoring(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Censoring[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a vector of censored event times ti with censoring c.
		///https://reference.wolfram.com/language/ref/Censoring.html
		///</summary>
		public static Engine Censoring(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Censoring[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a vector of event times ti with corresponding censoring ci.
		///https://reference.wolfram.com/language/ref/Censoring.html
		///</summary>
		public static Engine Censoring(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Censoring[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///creates a list of length n with the elements of a at the center and zeros elsewhere.
		///https://reference.wolfram.com/language/ref/CenterArray.html
		///</summary>
		public static Engine CenterArray(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CenterArray[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates an n1×n2×… array with the array a at the center and zeros elsewhere.
		///https://reference.wolfram.com/language/ref/CenterArray.html
		///</summary>
		public static Engine CenterArray(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CenterArray[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///uses pad instead of zero for the background.
		///https://reference.wolfram.com/language/ref/CenterArray.html
		///</summary>
		public static Engine CenterArray(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CenterArray[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///creates an array with a single 1 at the center and zeros elsewhere.
		///https://reference.wolfram.com/language/ref/CenterArray.html
		///</summary>
		public static Engine CenterArray(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CenterArray[" + arg0 + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/CenterDot.html
		///</summary>
		public static Engine CenterDot(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CenterDot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///for real numbers x and dx gives a centered interval that contains the real interval .
		///https://reference.wolfram.com/language/ref/CenteredInterval.html
		///</summary>
		public static Engine CenteredInterval(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CenteredInterval[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///for an approximate number c gives a centered interval that contains all values within the error bounds of c.
		///https://reference.wolfram.com/language/ref/CenteredInterval.html
		///</summary>
		public static Engine CenteredInterval(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CenteredInterval[" + arg0 + "]", name);
		}

		///<summary>
		///gives the central feature of the elements .
		///https://reference.wolfram.com/language/ref/CentralFeature.html
		///</summary>
		public static Engine CentralFeature(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CentralFeature[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the central feature for several different forms of data.
		///https://reference.wolfram.com/language/ref/CentralFeature.html
		///</summary>
		public static Engine CentralFeature(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CentralFeature[" + arg0 + "]", name);
		}

		///<summary>
		///gives the r central moment of the elements in list with respect to their mean.
		///https://reference.wolfram.com/language/ref/CentralMoment.html
		///</summary>
		public static Engine CentralMoment(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CentralMoment[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the r formal central moment.
		///https://reference.wolfram.com/language/ref/CentralMoment.html
		///</summary>
		public static Engine CentralMoment(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CentralMoment[" + arg0 + "]", name);
		}

		///<summary>
		///gives the central moment-generating function for the distribution dist as a function of the variable t.
		///https://reference.wolfram.com/language/ref/CentralMomentGeneratingFunction.html
		///</summary>
		public static Engine CentralMomentGeneratingFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CentralMomentGeneratingFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the central moment-generating function for the multivariate distribution dist as a function of the variables t1, t2, ….
		///https://reference.wolfram.com/language/ref/CentralMomentGeneratingFunction.html
		///</summary>
		public static Engine CentralMomentGeneratingFunction(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CentralMomentGeneratingFunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///plots the array of power cepstra computed on each partition of data.
		///https://reference.wolfram.com/language/ref/Cepstrogram.html
		///</summary>
		public static Engine Cepstrogram(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cepstrogram[" + arg0 + "]", name);
		}

		///<summary>
		///uses partitions of length n.
		///https://reference.wolfram.com/language/ref/Cepstrogram.html
		///</summary>
		public static Engine Cepstrogram(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Cepstrogram[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses partitions with offset d.
		///https://reference.wolfram.com/language/ref/Cepstrogram.html
		///</summary>
		public static Engine Cepstrogram(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Cepstrogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///applies a smoothing window wfun to each partition.
		///https://reference.wolfram.com/language/ref/Cepstrogram.html
		///</summary>
		public static Engine Cepstrogram(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Cepstrogram[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///pads partitions with zeros to length m prior to the computation of the transform.
		///https://reference.wolfram.com/language/ref/Cepstrogram.html
		///</summary>
		public static Engine Cepstrogram(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
		{
				return en.Execute("Cepstrogram[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
		}

		///<summary>
		///computes an array of cepstra on data.
		///https://reference.wolfram.com/language/ref/CepstrogramArray.html
		///</summary>
		public static Engine CepstrogramArray(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CepstrogramArray[" + arg0 + "]", name);
		}

		///<summary>
		///uses partitions of length n.
		///https://reference.wolfram.com/language/ref/CepstrogramArray.html
		///</summary>
		public static Engine CepstrogramArray(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CepstrogramArray[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses partitions with offset d.
		///https://reference.wolfram.com/language/ref/CepstrogramArray.html
		///</summary>
		public static Engine CepstrogramArray(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CepstrogramArray[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///applies a smoothing window wfun to each partition.
		///https://reference.wolfram.com/language/ref/CepstrogramArray.html
		///</summary>
		public static Engine CepstrogramArray(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CepstrogramArray[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///pads partitions with zeros to length m prior to the computation of the transform.
		///https://reference.wolfram.com/language/ref/CepstrogramArray.html
		///</summary>
		public static Engine CepstrogramArray(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
		{
				return en.Execute("CepstrogramArray[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
		}

		///<summary>
		///computes the power cepstrum of data.
		///https://reference.wolfram.com/language/ref/CepstrumArray.html
		///</summary>
		public static Engine CepstrumArray(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CepstrumArray[" + arg0 + "]", name);
		}

		///<summary>
		///computes the specified type of cepstrum of data.
		///https://reference.wolfram.com/language/ref/CepstrumArray.html
		///</summary>
		public static Engine CepstrumArray(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CepstrumArray[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///prints as a C language version of expr.
		///https://reference.wolfram.com/language/ref/CForm.html
		///</summary>
		public static Engine CForm(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CForm[" + arg0 + "]", name);
		}

		///<summary>
		///gives the base-b Champernowne number .
		///https://reference.wolfram.com/language/ref/ChampernowneNumber.html
		///</summary>
		public static Engine ChampernowneNumber(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChampernowneNumber[" + arg0 + "]", name);
		}

		///<summary>
		///gives the base-10 Champernowne number.
		///https://reference.wolfram.com/language/ref/ChampernowneNumber.html
		///</summary>
		public static Engine ChampernowneNumber(this Engine en, string? name = null)
		{
				return en.Execute("ChampernowneNumber[]", name);
		}

		///<summary>
		///starts listening on the specified channel.
		///https://reference.wolfram.com/language/ref/ChannelListen.html
		///</summary>
		public static Engine ChannelListen(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChannelListen[" + arg0 + "]", name);
		}

		///<summary>
		///applies func to the association corresponding to each message received on the channel.
		///https://reference.wolfram.com/language/ref/ChannelListen.html
		///</summary>
		public static Engine ChannelListen(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChannelListen[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a channel listener created by ChannelListen.
		///https://reference.wolfram.com/language/ref/ChannelListener.html
		///</summary>
		public static Engine ChannelListener(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChannelListener[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of currently active channel listeners.
		///https://reference.wolfram.com/language/ref/ChannelListeners.html
		///</summary>
		public static Engine ChannelListeners(this Engine en, string? name = null)
		{
				return en.Execute("ChannelListeners[]", name);
		}

		///<summary>
		///gives a new anonymous channel specification.
		///https://reference.wolfram.com/language/ref/ChannelObject.html
		///</summary>
		public static Engine ChannelObject(this Engine en, string? name = null)
		{
				return en.Execute("ChannelObject[]", name);
		}

		///<summary>
		///represents a channel specified by a given URL.
		///https://reference.wolfram.com/language/ref/ChannelObject.html
		///</summary>
		public static Engine ChannelObject(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChannelObject[" + arg0 + "]", name);
		}

		///<summary>
		///represents a channel receiver function that applies fun to any channel message it receives.
		///https://reference.wolfram.com/language/ref/ChannelReceiverFunction.html
		///</summary>
		public static Engine ChannelReceiverFunction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChannelReceiverFunction[" + arg0 + "]", name);
		}

		///<summary>
		///sends the specified message msg to the specified channel.
		///https://reference.wolfram.com/language/ref/ChannelSend.html
		///</summary>
		public static Engine ChannelSend(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChannelSend[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of users currently subscribed to the specified channel.
		///https://reference.wolfram.com/language/ref/ChannelSubscribers.html
		///</summary>
		public static Engine ChannelSubscribers(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChannelSubscribers[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of subscribed users for each of the channels channeli.
		///https://reference.wolfram.com/language/ref/ChannelSubscribers.html
		///</summary>
		public static Engine ChannelSubscribers(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ChannelSubscribers[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///finds a two-level segmentation of image by computing optimal contours around regions of consistent intensity in image.
		///https://reference.wolfram.com/language/ref/ChanVeseBinarize.html
		///</summary>
		public static Engine ChanVeseBinarize(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChanVeseBinarize[" + arg0 + "]", name);
		}

		///<summary>
		///uses marker to create an initial contour.
		///https://reference.wolfram.com/language/ref/ChanVeseBinarize.html
		///</summary>
		public static Engine ChanVeseBinarize(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChanVeseBinarize[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///specify the Chan–Vese weights μ, ν, λ1, and λ2.
		///https://reference.wolfram.com/language/ref/ChanVeseBinarize.html
		///</summary>
		public static Engine ChanVeseBinarize(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ChanVeseBinarize[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives an association whose keys are the distinct characters in string, and whose values give the number of times those characters appear in string.
		///https://reference.wolfram.com/language/ref/CharacterCounts.html
		///</summary>
		public static Engine CharacterCounts(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CharacterCounts[" + arg0 + "]", name);
		}

		///<summary>
		///gives counts of the distinct n-grams consisting of runs of n characters in string.
		///https://reference.wolfram.com/language/ref/CharacterCounts.html
		///</summary>
		public static Engine CharacterCounts(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CharacterCounts[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the characteristic function for the distribution dist as a function of the variable t.
		///https://reference.wolfram.com/language/ref/CharacteristicFunction.html
		///</summary>
		public static Engine CharacteristicFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CharacteristicFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the characteristic function for the multivariate distribution dist as a function of the variables t1, t2, ….
		///https://reference.wolfram.com/language/ref/CharacteristicFunction.html
		///</summary>
		public static Engine CharacteristicFunction(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CharacteristicFunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the characteristic polynomial for the matrix m.
		///https://reference.wolfram.com/language/ref/CharacteristicPolynomial.html
		///</summary>
		public static Engine CharacteristicPolynomial(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CharacteristicPolynomial[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the generalized characteristic polynomial with respect to a.
		///https://reference.wolfram.com/language/ref/CharacteristicPolynomial.html
		///</summary>
		public static Engine CharacteristicPolynomial(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CharacteristicPolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the name of the character c.
		///https://reference.wolfram.com/language/ref/CharacterName.html
		///</summary>
		public static Engine CharacterName(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CharacterName[" + arg0 + "]", name);
		}

		///<summary>
		///gives a name of the specified type.
		///https://reference.wolfram.com/language/ref/CharacterName.html
		///</summary>
		public static Engine CharacterName(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CharacterName[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///converts the characters in text to the specified normalization form.
		///https://reference.wolfram.com/language/ref/CharacterNormalize.html
		///</summary>
		public static Engine CharacterNormalize(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CharacterNormalize[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields a list of the characters in the range from "c1" to "c2".
		///https://reference.wolfram.com/language/ref/CharacterRange.html
		///</summary>
		public static Engine CharacterRange(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CharacterRange[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of the characters in a string.
		///https://reference.wolfram.com/language/ref/Characters.html
		///</summary>
		public static Engine Characters(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Characters[" + arg0 + "]", name);
		}

		///<summary>
		///creates a lowpass Chebyshev type 1 filter of order n.
		///https://reference.wolfram.com/language/ref/Chebyshev1FilterModel.html
		///</summary>
		public static Engine Chebyshev1FilterModel(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Chebyshev1FilterModel[" + arg0 + "]", name);
		}

		///<summary>
		///uses the cutoff frequency ωc.
		///https://reference.wolfram.com/language/ref/Chebyshev1FilterModel.html
		///</summary>
		public static Engine Chebyshev1FilterModel(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Chebyshev1FilterModel[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///expresses the model in terms of the variable var.
		///https://reference.wolfram.com/language/ref/Chebyshev1FilterModel.html
		///</summary>
		public static Engine Chebyshev1FilterModel(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Chebyshev1FilterModel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a lowpass Chebyshev type 2 filter of order n.
		///https://reference.wolfram.com/language/ref/Chebyshev2FilterModel.html
		///</summary>
		public static Engine Chebyshev2FilterModel(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Chebyshev2FilterModel[" + arg0 + "]", name);
		}

		///<summary>
		///uses the cutoff frequency ωc.
		///https://reference.wolfram.com/language/ref/Chebyshev2FilterModel.html
		///</summary>
		public static Engine Chebyshev2FilterModel(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Chebyshev2FilterModel[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///expresses the model in terms of the variable var.
		///https://reference.wolfram.com/language/ref/Chebyshev2FilterModel.html
		///</summary>
		public static Engine Chebyshev2FilterModel(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Chebyshev2FilterModel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the Chebyshev polynomial of the first kind .
		///https://reference.wolfram.com/language/ref/ChebyshevT.html
		///</summary>
		public static Engine ChebyshevT(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChebyshevT[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the Chebyshev polynomial of the second kind .
		///https://reference.wolfram.com/language/ref/ChebyshevU.html
		///</summary>
		public static Engine ChebyshevU(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChebyshevU[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///evaluates expr, and returns the result, unless messages were generated, in which case it evaluates and returns failexpr.
		///https://reference.wolfram.com/language/ref/Check.html
		///</summary>
		public static Engine Check(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Check[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///checks only for the specified messages.
		///https://reference.wolfram.com/language/ref/Check.html
		///</summary>
		public static Engine Check(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("Check[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///checks only for messages in the named message group.
		///https://reference.wolfram.com/language/ref/Check.html
		///</summary>
		public static Engine Check(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Check[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///evaluates expr, returning failexpr if an abort occurs.
		///https://reference.wolfram.com/language/ref/CheckAbort.html
		///</summary>
		public static Engine CheckAbort(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CheckAbort[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives True if args consists of exactly n positional arguments followed by valid options for f, and False otherwise.
		///https://reference.wolfram.com/language/ref/CheckArguments.html
		///</summary>
		public static Engine CheckArguments(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CheckArguments[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///requires the number of positional arguments to be between min and max.
		///https://reference.wolfram.com/language/ref/CheckArguments.html
		///</summary>
		public static Engine CheckArguments(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CheckArguments[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///modifies the behavior based on the information in the association assoc.
		///https://reference.wolfram.com/language/ref/CheckArguments.html
		///</summary>
		public static Engine CheckArguments(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CheckArguments[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a checkbox with setting x, displayed as  when x is True and  when x is False.
		///https://reference.wolfram.com/language/ref/Checkbox.html
		///</summary>
		public static Engine Checkbox(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Checkbox[" + arg0 + "]", name);
		}

		///<summary>
		///represents a checkbox that toggles between values val1 and val2 and displays as  and , respectively.
		///https://reference.wolfram.com/language/ref/Checkbox.html
		///</summary>
		public static Engine Checkbox(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Checkbox[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents a checkbox bar with setting x and with checkboxes for values vali to include in the list x.
		///https://reference.wolfram.com/language/ref/CheckboxBar.html
		///</summary>
		public static Engine CheckboxBar(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CheckboxBar[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///converts the quantity in the specified instance cheminst to targetunit.
		///https://reference.wolfram.com/language/ref/ChemicalConvert.html
		///</summary>
		public static Engine ChemicalConvert(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChemicalConvert[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///converts to SI base units.
		///https://reference.wolfram.com/language/ref/ChemicalConvert.html
		///</summary>
		public static Engine ChemicalConvert(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChemicalConvert[" + arg0 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the chemical "name".
		///https://reference.wolfram.com/language/ref/ChemicalData.html
		///</summary>
		public static Engine ChemicalData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChemicalData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a structure diagram for the chemical with the specified name.
		///https://reference.wolfram.com/language/ref/ChemicalData.html
		///</summary>
		public static Engine ChemicalData(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChemicalData[" + arg0 + "]", name);
		}

		///<summary>
		///represents a chemical species with ni atoms of the element elemi.
		///https://reference.wolfram.com/language/ref/ChemicalFormula.html
		///</summary>
		public static Engine ChemicalFormula(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ChemicalFormula[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns the chemical formula corresponding to the given input.
		///https://reference.wolfram.com/language/ref/ChemicalFormula.html
		///</summary>
		public static Engine ChemicalFormula(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChemicalFormula[" + arg0 + "]", name);
		}

		///<summary>
		///represents a chemical whose qualifiers quali have values of vali.
		///https://reference.wolfram.com/language/ref/ChemicalInstance.html
		///</summary>
		public static Engine ChemicalInstance(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ChemicalInstance[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents a chemical quantified by quantity.
		///https://reference.wolfram.com/language/ref/ChemicalInstance.html
		///</summary>
		public static Engine ChemicalInstance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChemicalInstance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a chemical reaction between the given reactants and products.
		///https://reference.wolfram.com/language/ref/ChemicalReaction.html
		///</summary>
		public static Engine ChemicalReaction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChemicalReaction[" + arg0 + "]", name);
		}

		///<summary>
		///gives the chessboard, Chebyshev, or sup norm distance between vectors u and v.
		///https://reference.wolfram.com/language/ref/ChessboardDistance.html
		///</summary>
		public static Engine ChessboardDistance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChessboardDistance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a  distribution with ν degrees of freedom.
		///https://reference.wolfram.com/language/ref/ChiDistribution.html
		///</summary>
		public static Engine ChiDistribution(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChiDistribution[" + arg0 + "]", name);
		}

		///<summary>
		///gives the smallest  with  that satisfies all the integer congruences .
		///https://reference.wolfram.com/language/ref/ChineseRemainder.html
		///</summary>
		public static Engine ChineseRemainder(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ChineseRemainder[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the smallest  with  that satisfies all the integer congruences .
		///https://reference.wolfram.com/language/ref/ChineseRemainder.html
		///</summary>
		public static Engine ChineseRemainder(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("ChineseRemainder[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a  distribution with ν degrees of freedom.
		///https://reference.wolfram.com/language/ref/ChiSquareDistribution.html
		///</summary>
		public static Engine ChiSquareDistribution(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChiSquareDistribution[" + arg0 + "]", name);
		}

		///<summary>
		///represents a pair of OK and Cancel buttons that close a dialog.
		///https://reference.wolfram.com/language/ref/ChoiceButtons.html
		///</summary>
		public static Engine ChoiceButtons(this Engine en, string? name = null)
		{
				return en.Execute("ChoiceButtons[]", name);
		}

		///<summary>
		///represents OK and Cancel buttons that evaluate the corresponding acti when clicked.
		///https://reference.wolfram.com/language/ref/ChoiceButtons.html
		///</summary>
		public static Engine ChoiceButtons(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ChoiceButtons[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///uses the lbli to label the buttons.
		///https://reference.wolfram.com/language/ref/ChoiceButtons.html
		///</summary>
		public static Engine ChoiceButtons(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ChoiceButtons[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///puts up a standard choice dialog that displays expr together with OK and Cancel buttons, and returns True if OK is clicked and False if Cancel is clicked.
		///https://reference.wolfram.com/language/ref/ChoiceDialog.html
		///</summary>
		public static Engine ChoiceDialog(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChoiceDialog[" + arg0 + "]", name);
		}

		///<summary>
		///includes buttons with labels lbli, and returns the corresponding vali for the button clicked.
		///https://reference.wolfram.com/language/ref/ChoiceDialog.html
		///</summary>
		public static Engine ChoiceDialog(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ChoiceDialog[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the Cholesky decomposition of a matrix m.
		///https://reference.wolfram.com/language/ref/CholeskyDecomposition.html
		///</summary>
		public static Engine CholeskyDecomposition(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CholeskyDecomposition[" + arg0 + "]", name);
		}

		///<summary>
		///replaces approximate real numbers in expr that are close to zero by the exact integer 0.
		///https://reference.wolfram.com/language/ref/Chop.html
		///</summary>
		public static Engine Chop(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Chop[" + arg0 + "]", name);
		}

		///<summary>
		///plots a 2D slice of the color space colspace.
		///https://reference.wolfram.com/language/ref/ChromaticityPlot.html
		///</summary>
		public static Engine ChromaticityPlot(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChromaticityPlot[" + arg0 + "]", name);
		}

		///<summary>
		///plots multiple colors and color spaces.
		///https://reference.wolfram.com/language/ref/ChromaticityPlot.html
		///</summary>
		public static Engine ChromaticityPlot(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ChromaticityPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///uses the reference color space refcolspace.
		///https://reference.wolfram.com/language/ref/ChromaticityPlot.html
		///</summary>
		public static Engine ChromaticityPlot(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChromaticityPlot[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns a 3D gamut of the color space colspace.
		///https://reference.wolfram.com/language/ref/ChromaticityPlot3D.html
		///</summary>
		public static Engine ChromaticityPlot3D(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ChromaticityPlot3D[" + arg0 + "]", name);
		}

		///<summary>
		///plots multiple colors, color spaces and images.
		///https://reference.wolfram.com/language/ref/ChromaticityPlot3D.html
		///</summary>
		public static Engine ChromaticityPlot3D(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ChromaticityPlot3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///uses the reference color space refcolspace.
		///https://reference.wolfram.com/language/ref/ChromaticityPlot3D.html
		///</summary>
		public static Engine ChromaticityPlot3D(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChromaticityPlot3D[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the chromatic polynomial of the graph g.
		///https://reference.wolfram.com/language/ref/ChromaticPolynomial.html
		///</summary>
		public static Engine ChromaticPolynomial(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ChromaticPolynomial[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses rules vw to specify the graph g.
		///https://reference.wolfram.com/language/ref/ChromaticPolynomial.html
		///</summary>
		public static Engine ChromaticPolynomial(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ChromaticPolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a circle of radius r centered at {x,y}.
		///https://reference.wolfram.com/language/ref/Circle.html
		///</summary>
		public static Engine Circle(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Circle[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a circle of radius 1.
		///https://reference.wolfram.com/language/ref/Circle.html
		///</summary>
		public static Engine Circle(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Circle[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives an axis-aligned ellipse with semiaxes lengths rx and ry.
		///https://reference.wolfram.com/language/ref/Circle.html
		///</summary>
		public static Engine Circle(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Circle[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives a circular or ellipse arc from angle θ1 to θ2.
		///https://reference.wolfram.com/language/ref/Circle.html
		///</summary>
		public static Engine Circle(this Engine en, List<string> arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("Circle[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/CircleDot.html
		///</summary>
		public static Engine CircleDot(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CircleDot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/CircleMinus.html
		///</summary>
		public static Engine CircleMinus(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CircleMinus[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/CirclePlus.html
		///</summary>
		public static Engine CirclePlus(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CirclePlus[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the positions of n points equally spaced around the unit circle.
		///https://reference.wolfram.com/language/ref/CirclePoints.html
		///</summary>
		public static Engine CirclePoints(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CirclePoints[" + arg0 + "]", name);
		}

		///<summary>
		///gives the positions of n points equally spaced around a circle of radius r.
		///https://reference.wolfram.com/language/ref/CirclePoints.html
		///</summary>
		public static Engine CirclePoints(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CirclePoints[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///starts at angle θ1 with respect to the  axis.
		///https://reference.wolfram.com/language/ref/CirclePoints.html
		///</summary>
		public static Engine CirclePoints(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CirclePoints[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///centers the circle at {x,y}.
		///https://reference.wolfram.com/language/ref/CirclePoints.html
		///</summary>
		public static Engine CirclePoints(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CirclePoints[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a circle passing through the points pi.
		///https://reference.wolfram.com/language/ref/CircleThrough.html
		///</summary>
		public static Engine CircleThrough(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CircleThrough[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents a circle with center q.
		///https://reference.wolfram.com/language/ref/CircleThrough.html
		///</summary>
		public static Engine CircleThrough(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CircleThrough[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a circle with radius r.
		///https://reference.wolfram.com/language/ref/CircleThrough.html
		///</summary>
		public static Engine CircleThrough(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CircleThrough[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/CircleTimes.html
		///</summary>
		public static Engine CircleTimes(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CircleTimes[" + arg0 + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/CircleTimes.html
		///</summary>
		public static Engine CircleTimes(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CircleTimes[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the circulant graph  with n vertices and jump j.
		///https://reference.wolfram.com/language/ref/CirculantGraph.html
		///</summary>
		public static Engine CirculantGraph(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CirculantGraph[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the circulant graph  with n vertices and jumps j1, j2, ….
		///https://reference.wolfram.com/language/ref/CirculantGraph.html
		///</summary>
		public static Engine CirculantGraph(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CirculantGraph[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents a circular arc passing through the points pi.
		///https://reference.wolfram.com/language/ref/CircularArcThrough.html
		///</summary>
		public static Engine CircularArcThrough(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CircularArcThrough[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents a circular arc with center q.
		///https://reference.wolfram.com/language/ref/CircularArcThrough.html
		///</summary>
		public static Engine CircularArcThrough(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CircularArcThrough[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a circular arc with radius r.
		///https://reference.wolfram.com/language/ref/CircularArcThrough.html
		///</summary>
		public static Engine CircularArcThrough(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CircularArcThrough[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a circular orthogonal matrix distribution with matrix dimensions {n,n}.
		///https://reference.wolfram.com/language/ref/CircularOrthogonalMatrixDistribution.html
		///</summary>
		public static Engine CircularOrthogonalMatrixDistribution(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CircularOrthogonalMatrixDistribution[" + arg0 + "]", name);
		}

		///<summary>
		///represents a circular quaternion matrix distribution with matrix dimensions {2 n,2 n} over the field of complex numbers.
		///https://reference.wolfram.com/language/ref/CircularQuaternionMatrixDistribution.html
		///</summary>
		public static Engine CircularQuaternionMatrixDistribution(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CircularQuaternionMatrixDistribution[" + arg0 + "]", name);
		}

		///<summary>
		///represents a circular real matrix distribution with matrix dimensions {n,n}.
		///https://reference.wolfram.com/language/ref/CircularRealMatrixDistribution.html
		///</summary>
		public static Engine CircularRealMatrixDistribution(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CircularRealMatrixDistribution[" + arg0 + "]", name);
		}

		///<summary>
		///represents a circular symplectic matrix distribution with matrix dimensions {2 n,2 n} over the field of complex numbers.
		///https://reference.wolfram.com/language/ref/CircularSymplecticMatrixDistribution.html
		///</summary>
		public static Engine CircularSymplecticMatrixDistribution(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CircularSymplecticMatrixDistribution[" + arg0 + "]", name);
		}

		///<summary>
		///represents a circular unitary matrix distribution with matrix dimensions {n,n}.
		///https://reference.wolfram.com/language/ref/CircularUnitaryMatrixDistribution.html
		///</summary>
		public static Engine CircularUnitaryMatrixDistribution(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CircularUnitaryMatrixDistribution[" + arg0 + "]", name);
		}

		///<summary>
		///gives the sphere that circumscribes the points pi in .
		///https://reference.wolfram.com/language/ref/Circumsphere.html
		///</summary>
		public static Engine Circumsphere(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Circumsphere[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the circumsphere of a polyhedron or polygon poly.
		///https://reference.wolfram.com/language/ref/Circumsphere.html
		///</summary>
		public static Engine Circumsphere(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Circumsphere[" + arg0 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the city with the specified name.
		///https://reference.wolfram.com/language/ref/CityData.html
		///</summary>
		public static Engine CityData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CityData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of the full specifications of cities whose names are consistent with name.
		///https://reference.wolfram.com/language/ref/CityData.html
		///</summary>
		public static Engine CityData(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CityData[" + arg0 + "]", name);
		}

		///<summary>
		///represents a function generated by Classify that classifies data into classes.
		///https://reference.wolfram.com/language/ref/ClassifierFunction.html
		///</summary>
		public static Engine ClassifierFunction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClassifierFunction[" + arg0 + "]", name);
		}

		///<summary>
		///gives measurements associated with property prop when classifier is evaluated on testset.
		///https://reference.wolfram.com/language/ref/ClassifierMeasurements.html
		///</summary>
		public static Engine ClassifierMeasurements(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ClassifierMeasurements[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///yields a measurement report that can be applied to any property.
		///https://reference.wolfram.com/language/ref/ClassifierMeasurements.html
		///</summary>
		public static Engine ClassifierMeasurements(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ClassifierMeasurements[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives properties prop1, prop2, etc.
		///https://reference.wolfram.com/language/ref/ClassifierMeasurements.html
		///</summary>
		public static Engine ClassifierMeasurements(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ClassifierMeasurements[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents an object generated by ClassifierMeasurements that can be applied to properties.
		///https://reference.wolfram.com/language/ref/ClassifierMeasurementsObject.html
		///</summary>
		public static Engine ClassifierMeasurementsObject(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClassifierMeasurementsObject[" + arg0 + "]", name);
		}

		///<summary>
		///generates a ClassifierFunction[…] based on the examples and classes given.
		///https://reference.wolfram.com/language/ref/Classify.html
		///</summary>
		public static Engine Classify(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Classify[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///generates a ClassifierFunction[…] based on an association of classes with their examples.
		///https://reference.wolfram.com/language/ref/Classify.html
		///</summary>
		public static Engine Classify(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Classify[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///attempts to classify data using a classifier function deduced from the training set given.
		///https://reference.wolfram.com/language/ref/Classify.html
		///</summary>
		public static Engine Classify(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Classify[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///clears values and definitions for the symboli.
		///https://reference.wolfram.com/language/ref/Clear.html
		///</summary>
		public static Engine Clear(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Clear[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///clears all values, definitions, attributes, messages, and defaults associated with symbols.
		///https://reference.wolfram.com/language/ref/ClearAll.html
		///</summary>
		public static Engine ClearAll(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ClearAll[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///removes attr from the list of attributes of the symbol symbol.
		///https://reference.wolfram.com/language/ref/ClearAttributes.html
		///</summary>
		public static Engine ClearAttributes(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ClearAttributes[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///removes several attributes at a time.
		///https://reference.wolfram.com/language/ref/ClearAttributes.html
		///</summary>
		public static Engine ClearAttributes(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ClearAttributes[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///removes attributes from several symbols at a time.
		///https://reference.wolfram.com/language/ref/ClearAttributes.html
		///</summary>
		public static Engine ClearAttributes(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ClearAttributes[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///clears all persistent and session cookies associated with the specified domain.
		///https://reference.wolfram.com/language/ref/ClearCookies.html
		///</summary>
		public static Engine ClearCookies(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClearCookies[" + arg0 + "]", name);
		}

		///<summary>
		///clears permissions for the specified class of users for the cloud object obj.
		///https://reference.wolfram.com/language/ref/ClearPermissions.html
		///</summary>
		public static Engine ClearPermissions(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ClearPermissions[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///clears permissions for the cloud object corresponding to the current document.
		///https://reference.wolfram.com/language/ref/ClearPermissions.html
		///</summary>
		public static Engine ClearPermissions(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClearPermissions[" + arg0 + "]", name);
		}

		///<summary>
		///clears internal system caches of stored results.
		///https://reference.wolfram.com/language/ref/ClearSystemCache.html
		///</summary>
		public static Engine ClearSystemCache(this Engine en, string? name = null)
		{
				return en.Execute("ClearSystemCache[]", name);
		}

		///<summary>
		///clears only caches of the specified type.
		///https://reference.wolfram.com/language/ref/ClearSystemCache.html
		///</summary>
		public static Engine ClearSystemCache(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClearSystemCache[" + arg0 + "]", name);
		}

		///<summary>
		///gives the Clebsch–Gordan coefficient for the decomposition of  in terms of .
		///https://reference.wolfram.com/language/ref/ClebschGordan.html
		///</summary>
		public static Engine ClebschGordan(this Engine en, List<string> arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ClebschGordan[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///represents a clickable pane that displays as image and applies func to the  coordinates of each click within the pane.
		///https://reference.wolfram.com/language/ref/ClickPane.html
		///</summary>
		public static Engine ClickPane(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ClickPane[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///specifies the range of coordinates to use.
		///https://reference.wolfram.com/language/ref/ClickPane.html
		///</summary>
		public static Engine ClickPane(this Engine en, string arg0, List<string> arg1, List<string> arg2, string arg3, string? name = null)
		{
				return en.Execute("ClickPane[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents a button that copies expr whenever it is clicked.
		///https://reference.wolfram.com/language/ref/ClickToCopy.html
		///</summary>
		public static Engine ClickToCopy(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClickToCopy[" + arg0 + "]", name);
		}

		///<summary>
		///displays with label on the button.
		///https://reference.wolfram.com/language/ref/ClickToCopy.html
		///</summary>
		public static Engine ClickToCopy(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ClickToCopy[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives x clipped to be between  and .
		///https://reference.wolfram.com/language/ref/Clip.html
		///</summary>
		public static Engine Clip(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Clip[" + arg0 + "]", name);
		}

		///<summary>
		///gives x for min≤x≤max, min for x<min and max for x>max.
		///https://reference.wolfram.com/language/ref/Clip.html
		///</summary>
		public static Engine Clip(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Clip[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives vmin for x<min and vmax for x>max.
		///https://reference.wolfram.com/language/ref/Clip.html
		///</summary>
		public static Engine Clip(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("Clip[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///represents a clock variable whose value cycles continuously from 0 to 1 once per second when it appears inside a dynamically updated object such as a Dynamic.
		///https://reference.wolfram.com/language/ref/Clock.html
		///</summary>
		public static Engine Clock(this Engine en, string? name = null)
		{
				return en.Execute("Clock[]", name);
		}

		///<summary>
		///cycles from 0 to t every t seconds.
		///https://reference.wolfram.com/language/ref/Clock.html
		///</summary>
		public static Engine Clock(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Clock[" + arg0 + "]", name);
		}

		///<summary>
		///cycles from 0 to vmax every t seconds.
		///https://reference.wolfram.com/language/ref/Clock.html
		///</summary>
		public static Engine Clock(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Clock[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///cycles through the range vmin to vmax every t seconds.
		///https://reference.wolfram.com/language/ref/Clock.html
		///</summary>
		public static Engine Clock(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Clock[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///cycles through the range vmin to vmax over the course of vmax-vmin seconds.
		///https://reference.wolfram.com/language/ref/Clock.html
		///</summary>
		public static Engine Clock(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Clock[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///goes through the cycle only n times, then always yields only the maximum value.
		///https://reference.wolfram.com/language/ref/Clock.html
		///</summary>
		public static Engine Clock(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Clock[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///draws an analog clock face showing the local time with hours, minutes, and seconds.
		///https://reference.wolfram.com/language/ref/ClockGauge.html
		///</summary>
		public static Engine ClockGauge(this Engine en, string? name = null)
		{
				return en.Execute("ClockGauge[]", name);
		}

		///<summary>
		///draws an analog clock face showing the time corresponding to an AbsoluteTime, DateObject, or TimeObject specification.
		///https://reference.wolfram.com/language/ref/ClockGauge.html
		///</summary>
		public static Engine ClockGauge(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClockGauge[" + arg0 + "]", name);
		}

		///<summary>
		///draws an analog clock face showing hour h, minute m, and seconds s.
		///https://reference.wolfram.com/language/ref/ClockGauge.html
		///</summary>
		public static Engine ClockGauge(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ClockGauge[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///closes a stream or socket.
		///https://reference.wolfram.com/language/ref/Close.html
		///</summary>
		public static Engine Close(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Close[" + arg0 + "]", name);
		}

		///<summary>
		///terminates all parallel kernels from the list Kernels[].
		///https://reference.wolfram.com/language/ref/CloseKernels.html
		///</summary>
		public static Engine CloseKernels(this Engine en, string? name = null)
		{
				return en.Execute("CloseKernels[]", name);
		}

		///<summary>
		///terminates the kernel k.
		///https://reference.wolfram.com/language/ref/CloseKernels.html
		///</summary>
		public static Engine CloseKernels(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloseKernels[" + arg0 + "]", name);
		}

		///<summary>
		///terminates the kernels k1, k2, ….
		///https://reference.wolfram.com/language/ref/CloseKernels.html
		///</summary>
		public static Engine CloseKernels(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CloseKernels[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives a list of closeness centralities for the vertices in the graph g.
		///https://reference.wolfram.com/language/ref/ClosenessCentrality.html
		///</summary>
		public static Engine ClosenessCentrality(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClosenessCentrality[" + arg0 + "]", name);
		}

		///<summary>
		///uses rules vw to specify the graph g.
		///https://reference.wolfram.com/language/ref/ClosenessCentrality.html
		///</summary>
		public static Engine ClosenessCentrality(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ClosenessCentrality[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the morphological closing of image with respect to the structuring element ker.
		///https://reference.wolfram.com/language/ref/Closing.html
		///</summary>
		public static Engine Closing(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Closing[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives data associated with the cloud account currently being used.
		///https://reference.wolfram.com/language/ref/CloudAccountData.html
		///</summary>
		public static Engine CloudAccountData(this Engine en, string? name = null)
		{
				return en.Execute("CloudAccountData[]", name);
		}

		///<summary>
		///gives the property prop associated with the cloud account being used.
		///https://reference.wolfram.com/language/ref/CloudAccountData.html
		///</summary>
		public static Engine CloudAccountData(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudAccountData[" + arg0 + "]", name);
		}

		///<summary>
		///authenticates to the Wolfram Cloud using the specified cloud user ID and password.
		///https://reference.wolfram.com/language/ref/CloudConnect.html
		///</summary>
		public static Engine CloudConnect(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudConnect[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///shows a dialog to input the password.
		///https://reference.wolfram.com/language/ref/CloudConnect.html
		///</summary>
		public static Engine CloudConnect(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudConnect[" + arg0 + "]", name);
		}

		///<summary>
		///shows a dialog to input both the cloud user ID and the password.
		///https://reference.wolfram.com/language/ref/CloudConnect.html
		///</summary>
		public static Engine CloudConnect(this Engine en, string? name = null)
		{
				return en.Execute("CloudConnect[]", name);
		}

		///<summary>
		///deploys expr to a new anonymous cloud object.
		///https://reference.wolfram.com/language/ref/CloudDeploy.html
		///</summary>
		public static Engine CloudDeploy(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudDeploy[" + arg0 + "]", name);
		}

		///<summary>
		///deploys expr to a cloud object at the specified location relative to the user's current cloud directory.
		///https://reference.wolfram.com/language/ref/CloudDeploy.html
		///</summary>
		public static Engine CloudDeploy(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudDeploy[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a CloudObject representing the current working directory used for cloud objects.
		///https://reference.wolfram.com/language/ref/CloudDirectory.html
		///</summary>
		public static Engine CloudDirectory(this Engine en, string? name = null)
		{
				return en.Execute("CloudDirectory[]", name);
		}

		///<summary>
		///disconnects a non-cloud instance of the Wolfram Language from the Wolfram Cloud.
		///https://reference.wolfram.com/language/ref/CloudDisconnect.html
		///</summary>
		public static Engine CloudDisconnect(this Engine en, string? name = null)
		{
				return en.Execute("CloudDisconnect[]", name);
		}

		///<summary>
		///evaluates expr in the cloud and returns the result.
		///https://reference.wolfram.com/language/ref/CloudEvaluate.html
		///</summary>
		public static Engine CloudEvaluate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudEvaluate[" + arg0 + "]", name);
		}

		///<summary>
		///wraps the head h around the result before returning it.
		///https://reference.wolfram.com/language/ref/CloudEvaluate.html
		///</summary>
		public static Engine CloudEvaluate(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudEvaluate[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///exports expr to a new anonymous cloud object in the specified format.
		///https://reference.wolfram.com/language/ref/CloudExport.html
		///</summary>
		public static Engine CloudExport(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudExport[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///exports to a cloud object at a given URI.
		///https://reference.wolfram.com/language/ref/CloudExport.html
		///</summary>
		public static Engine CloudExport(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CloudExport[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents an expression whose value is persistently stored in the cloud.
		///https://reference.wolfram.com/language/ref/CloudExpression.html
		///</summary>
		public static Engine CloudExpression(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudExpression[" + arg0 + "]", name);
		}

		///<summary>
		///represents a cloud expression with a given URI.
		///https://reference.wolfram.com/language/ref/CloudExpression.html
		///</summary>
		public static Engine CloudExpression(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudExpression[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the part of a cloud expression specified by the parti.
		///https://reference.wolfram.com/language/ref/CloudExpression.html
		///</summary>
		public static Engine CloudExpression(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CloudExpression[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives a list of named cloud expressions owned by you.
		///https://reference.wolfram.com/language/ref/CloudExpressions.html
		///</summary>
		public static Engine CloudExpressions(this Engine en, string? name = null)
		{
				return en.Execute("CloudExpressions[]", name);
		}

		///<summary>
		///gives a list of anonymous cloud expressions owned by you.
		///https://reference.wolfram.com/language/ref/CloudExpressions.html
		///</summary>
		public static Engine CloudExpressions(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudExpressions[" + arg0 + "]", name);
		}

		///<summary>
		///represents a pure function that evaluates fun[args] in the cloud.
		///https://reference.wolfram.com/language/ref/CloudFunction.html
		///</summary>
		public static Engine CloudFunction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudFunction[" + arg0 + "]", name);
		}

		///<summary>
		///wraps the head h around the result of the function before returning it.
		///https://reference.wolfram.com/language/ref/CloudFunction.html
		///</summary>
		public static Engine CloudFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///reads in a cloud object at a given URI, evaluating each expression in it and returning the last one.
		///https://reference.wolfram.com/language/ref/CloudGet.html
		///</summary>
		public static Engine CloudGet(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudGet[" + arg0 + "]", name);
		}

		///<summary>
		///imports from a cloud object at a given URI.
		///https://reference.wolfram.com/language/ref/CloudImport.html
		///</summary>
		public static Engine CloudImport(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudImport[" + arg0 + "]", name);
		}

		///<summary>
		///imports the specified elements of a cloud object.
		///https://reference.wolfram.com/language/ref/CloudImport.html
		///</summary>
		public static Engine CloudImport(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudImport[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives summary logging data for all your cloud objects.
		///https://reference.wolfram.com/language/ref/CloudLoggingData.html
		///</summary>
		public static Engine CloudLoggingData(this Engine en, string? name = null)
		{
				return en.Execute("CloudLoggingData[]", name);
		}

		///<summary>
		///gives summary logging data for all your cloud objects of a particular category.
		///https://reference.wolfram.com/language/ref/CloudLoggingData.html
		///</summary>
		public static Engine CloudLoggingData(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudLoggingData[" + arg0 + "]", name);
		}

		///<summary>
		///gives aggregated summary logging data for all the objects obji.
		///https://reference.wolfram.com/language/ref/CloudLoggingData.html
		///</summary>
		public static Engine CloudLoggingData(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CloudLoggingData[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives summary logging data for the specified period.
		///https://reference.wolfram.com/language/ref/CloudLoggingData.html
		///</summary>
		public static Engine CloudLoggingData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudLoggingData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives logging data elements specified by elems.
		///https://reference.wolfram.com/language/ref/CloudLoggingData.html
		///</summary>
		public static Engine CloudLoggingData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CloudLoggingData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a new anonymous cloud object.
		///https://reference.wolfram.com/language/ref/CloudObject.html
		///</summary>
		public static Engine CloudObject(this Engine en, string? name = null)
		{
				return en.Execute("CloudObject[]", name);
		}

		///<summary>
		///represents a cloud object with a given URI.
		///https://reference.wolfram.com/language/ref/CloudObject.html
		///</summary>
		public static Engine CloudObject(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudObject[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a cloud object of a given user with a given path.
		///https://reference.wolfram.com/language/ref/CloudObject.html
		///</summary>
		public static Engine CloudObject(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudObject[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of cloud objects in your current cloud directory.
		///https://reference.wolfram.com/language/ref/CloudObjects.html
		///</summary>
		public static Engine CloudObjects(this Engine en, string? name = null)
		{
				return en.Execute("CloudObjects[]", name);
		}

		///<summary>
		///gives a list of cloud objects in the cloud directory dir.
		///https://reference.wolfram.com/language/ref/CloudObjects.html
		///</summary>
		public static Engine CloudObjects(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudObjects[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of cloud objects of the specified type in the cloud directory dir.
		///https://reference.wolfram.com/language/ref/CloudObjects.html
		///</summary>
		public static Engine CloudObjects(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudObjects[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///makes a public copy in the cloud of the current document.
		///https://reference.wolfram.com/language/ref/CloudPublish.html
		///</summary>
		public static Engine CloudPublish(this Engine en, string? name = null)
		{
				return en.Execute("CloudPublish[]", name);
		}

		///<summary>
		///makes a public copy of the cloud object obj.
		///https://reference.wolfram.com/language/ref/CloudPublish.html
		///</summary>
		public static Engine CloudPublish(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudPublish[" + arg0 + "]", name);
		}

		///<summary>
		///publishes to the specified location relative to the user's current cloud directory.
		///https://reference.wolfram.com/language/ref/CloudPublish.html
		///</summary>
		public static Engine CloudPublish(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudPublish[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///writes expr to a new anonymous cloud object.
		///https://reference.wolfram.com/language/ref/CloudPut.html
		///</summary>
		public static Engine CloudPut(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudPut[" + arg0 + "]", name);
		}

		///<summary>
		///writes expr to a cloud object at a given URI.
		///https://reference.wolfram.com/language/ref/CloudPut.html
		///</summary>
		public static Engine CloudPut(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudPut[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///saves definitions associated with the specified symbol to a new anonymous cloud object.
		///https://reference.wolfram.com/language/ref/CloudSave.html
		///</summary>
		public static Engine CloudSave(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudSave[" + arg0 + "]", name);
		}

		///<summary>
		///saves definitions associated with several objects.
		///https://reference.wolfram.com/language/ref/CloudSave.html
		///</summary>
		public static Engine CloudSave(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CloudSave[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///appends definitions associated with symspec to the cloud object at the given URI.
		///https://reference.wolfram.com/language/ref/CloudSave.html
		///</summary>
		public static Engine CloudSave(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudSave[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///shares the current cloud document with the specified user.
		///https://reference.wolfram.com/language/ref/CloudShare.html
		///</summary>
		public static Engine CloudShare(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudShare[" + arg0 + "]", name);
		}

		///<summary>
		///shares the current document with all the users useri.
		///https://reference.wolfram.com/language/ref/CloudShare.html
		///</summary>
		public static Engine CloudShare(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CloudShare[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///shares the cloud object obj with the specified users.
		///https://reference.wolfram.com/language/ref/CloudShare.html
		///</summary>
		public static Engine CloudShare(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudShare[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///submits expr for immediate asynchronous cloud evaluation.
		///https://reference.wolfram.com/language/ref/CloudSubmit.html
		///</summary>
		public static Engine CloudSubmit(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudSubmit[" + arg0 + "]", name);
		}

		///<summary>
		///represents a symbol whose value is persistently stored in the cloud.
		///https://reference.wolfram.com/language/ref/CloudSymbol.html
		///</summary>
		public static Engine CloudSymbol(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudSymbol[" + arg0 + "]", name);
		}

		///<summary>
		///cancels sharing of the cloud object obj with everyone.
		///https://reference.wolfram.com/language/ref/CloudUnshare.html
		///</summary>
		public static Engine CloudUnshare(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CloudUnshare[" + arg0 + "]", name);
		}

		///<summary>
		///cancels sharing with the specified list of users.
		///https://reference.wolfram.com/language/ref/CloudUnshare.html
		///</summary>
		public static Engine CloudUnshare(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CloudUnshare[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///generates a ClassifierFunction[…] by partitioning data into clusters of similar elements.
		///https://reference.wolfram.com/language/ref/ClusterClassify.html
		///</summary>
		public static Engine ClusterClassify(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClusterClassify[" + arg0 + "]", name);
		}

		///<summary>
		///generates a ClassifierFunction[…] with n clusters.
		///https://reference.wolfram.com/language/ref/ClusterClassify.html
		///</summary>
		public static Engine ClusterClassify(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ClusterClassify[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an array in which each element at the lowest level of array is replaced by an integer index representing the cluster in which the element lies.
		///https://reference.wolfram.com/language/ref/ClusteringComponents.html
		///</summary>
		public static Engine ClusteringComponents(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ClusteringComponents[" + arg0 + "]", name);
		}

		///<summary>
		///finds n clusters.
		///https://reference.wolfram.com/language/ref/ClusteringComponents.html
		///</summary>
		public static Engine ClusteringComponents(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ClusteringComponents[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///finds clusters at the specified level in array.
		///https://reference.wolfram.com/language/ref/ClusteringComponents.html
		///</summary>
		public static Engine ClusteringComponents(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ClusteringComponents[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///constructs a weighted tree from the hierarchical clustering of the elements e1, e2, ….
		///https://reference.wolfram.com/language/ref/ClusteringTree.html
		///</summary>
		public static Engine ClusteringTree(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ClusteringTree[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents ei using labels labeli in the constructed graph.
		///https://reference.wolfram.com/language/ref/ClusteringTree.html
		///</summary>
		public static Engine ClusteringTree(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ClusteringTree[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a color in the CMYK color space with cyan, magenta, yellow and black components.
		///https://reference.wolfram.com/language/ref/CMYKColor.html
		///</summary>
		public static Engine CMYKColor(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CMYKColor[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///specifies opacity a.
		///https://reference.wolfram.com/language/ref/CMYKColor.html
		///</summary>
		public static Engine CMYKColor(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
		{
				return en.Execute("CMYKColor[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
		}

		///<summary>
		///returns a color from an HTML color name etc.
		///https://reference.wolfram.com/language/ref/CMYKColor.html
		///</summary>
		public static Engine CMYKColor(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CMYKColor[" + arg0 + "]", name);
		}

		///<summary>
		///gives the coefficient of form in the polynomial expr.
		///https://reference.wolfram.com/language/ref/Coefficient.html
		///</summary>
		public static Engine Coefficient(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Coefficient[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the coefficient of form^n in expr.
		///https://reference.wolfram.com/language/ref/Coefficient.html
		///</summary>
		public static Engine Coefficient(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Coefficient[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the arrays of coefficients of the variables vars in the polynomials polys.
		///https://reference.wolfram.com/language/ref/CoefficientArrays.html
		///</summary>
		public static Engine CoefficientArrays(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CoefficientArrays[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of coefficients of powers of var in poly, starting with power 0.
		///https://reference.wolfram.com/language/ref/CoefficientList.html
		///</summary>
		public static Engine CoefficientList(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CoefficientList[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an array of coefficients of the vari.
		///https://reference.wolfram.com/language/ref/CoefficientList.html
		///</summary>
		public static Engine CoefficientList(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CoefficientList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives an array of dimensions {dim1,dim2,…}, truncating or padding with zeros as needed.
		///https://reference.wolfram.com/language/ref/CoefficientList.html
		///</summary>
		public static Engine CoefficientList(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CoefficientList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the list {{e11,e12,…}c1,{e21,…}c2,…} of exponent vectors and coefficients for the monomials in poly with respect to the xi.
		///https://reference.wolfram.com/language/ref/CoefficientRules.html
		///</summary>
		public static Engine CoefficientRules(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CoefficientRules[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the result with the monomial ordering specified by order.
		///https://reference.wolfram.com/language/ref/CoefficientRules.html
		///</summary>
		public static Engine CoefficientRules(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("CoefficientRules[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a Coiflet wavelet of order 2.
		///https://reference.wolfram.com/language/ref/CoifletWavelet.html
		///</summary>
		public static Engine CoifletWavelet(this Engine en, string? name = null)
		{
				return en.Execute("CoifletWavelet[]", name);
		}

		///<summary>
		///represents a Coiflet wavelet of order n.
		///https://reference.wolfram.com/language/ref/CoifletWavelet.html
		///</summary>
		public static Engine CoifletWavelet(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CoifletWavelet[" + arg0 + "]", name);
		}

		///<summary>
		///collects together terms involving the same powers of objects matching x.
		///https://reference.wolfram.com/language/ref/Collect.html
		///</summary>
		public static Engine Collect(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Collect[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///successively collects together terms that involve the same powers of objects matching x1, then x2, ….
		///https://reference.wolfram.com/language/ref/Collect.html
		///</summary>
		public static Engine Collect(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Collect[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///applies h to the expression that forms the coefficient of each term obtained.
		///https://reference.wolfram.com/language/ref/Collect.html
		///</summary>
		public static Engine Collect(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Collect[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///tests whether the points p1,p2,p3,…,pn are collinear.
		///https://reference.wolfram.com/language/ref/CollinearPoints.html
		///</summary>
		public static Engine CollinearPoints(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CollinearPoints[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/Colon.html
		///</summary>
		public static Engine Colon(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Colon[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///adjusts the colors in image to achieve a balance that simulates the effect of neutral lighting.
		///https://reference.wolfram.com/language/ref/ColorBalance.html
		///</summary>
		public static Engine ColorBalance(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorBalance[" + arg0 + "]", name);
		}

		///<summary>
		///adjusts colors in image so that the reference color specified by ref is mapped to white.
		///https://reference.wolfram.com/language/ref/ColorBalance.html
		///</summary>
		public static Engine ColorBalance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorBalance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a multichannel image by combining the sequence of channels in the imagei.
		///https://reference.wolfram.com/language/ref/ColorCombine.html
		///</summary>
		public static Engine ColorCombine(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ColorCombine[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///combines images that represent the color components specified by colorspace.
		///https://reference.wolfram.com/language/ref/ColorCombine.html
		///</summary>
		public static Engine ColorCombine(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorCombine[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///converts the color space of a color to the specified color space colspace.
		///https://reference.wolfram.com/language/ref/ColorConvert.html
		///</summary>
		public static Engine ColorConvert(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorConvert[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///converts the color space of a list of colors and images.
		///https://reference.wolfram.com/language/ref/ColorConvert.html
		///</summary>
		public static Engine ColorConvert(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorConvert[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a function that generates colors in the named color scheme when applied to parameter values.
		///https://reference.wolfram.com/language/ref/ColorData.html
		///</summary>
		public static Engine ColorData(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorData[" + arg0 + "]", name);
		}

		///<summary>
		///gives the specified property of a color scheme.
		///https://reference.wolfram.com/language/ref/ColorData.html
		///</summary>
		public static Engine ColorData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of named collections of color schemes.
		///https://reference.wolfram.com/language/ref/ColorData.html
		///</summary>
		public static Engine ColorData(this Engine en, string? name = null)
		{
				return en.Execute("ColorData[]", name);
		}

		///<summary>
		///returns a mask image representing regions in image with colors within the specified color region.
		///https://reference.wolfram.com/language/ref/ColorDetect.html
		///</summary>
		public static Engine ColorDetect(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorDetect[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the approximate perceptual distance between color directives c1 and c2.
		///https://reference.wolfram.com/language/ref/ColorDistance.html
		///</summary>
		public static Engine ColorDistance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorDistance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///generates an image from an integer matrix m, using colors for positive integers and black for non-positive integers.
		///https://reference.wolfram.com/language/ref/Colorize.html
		///</summary>
		public static Engine Colorize(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Colorize[" + arg0 + "]", name);
		}

		///<summary>
		///gives the negative of a color.
		///https://reference.wolfram.com/language/ref/ColorNegate.html
		///</summary>
		public static Engine ColorNegate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorNegate[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of negative images or colors.
		///https://reference.wolfram.com/language/ref/ColorNegate.html
		///</summary>
		public static Engine ColorNegate(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ColorNegate[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents an ICC color profile that can convert between the independent color space "ics" and the device-dependent color space "device".
		///https://reference.wolfram.com/language/ref/ColorProfileData.html
		///</summary>
		public static Engine ColorProfileData(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ColorProfileData[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///yields True if color is a valid color directive and False otherwise.
		///https://reference.wolfram.com/language/ref/ColorQ.html
		///</summary>
		public static Engine ColorQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives an approximation to image by quantizing to distinct colors.
		///https://reference.wolfram.com/language/ref/ColorQuantize.html
		///</summary>
		public static Engine ColorQuantize(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorQuantize[" + arg0 + "]", name);
		}

		///<summary>
		///uses at most n distinct colors.
		///https://reference.wolfram.com/language/ref/ColorQuantize.html
		///</summary>
		public static Engine ColorQuantize(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorQuantize[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an image using only the n specified colors coli.
		///https://reference.wolfram.com/language/ref/ColorQuantize.html
		///</summary>
		public static Engine ColorQuantize(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ColorQuantize[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///finds regions in image whose pixel values are similar to color and replaces them with transparent pixels.
		///https://reference.wolfram.com/language/ref/ColorReplace.html
		///</summary>
		public static Engine ColorReplace(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorReplace[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///replaces all pixels whose values are within a distance d from color.
		///https://reference.wolfram.com/language/ref/ColorReplace.html
		///</summary>
		public static Engine ColorReplace(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ColorReplace[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///does multiple color replacements.
		///https://reference.wolfram.com/language/ref/ColorReplace.html
		///</summary>
		public static Engine ColorReplace(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ColorReplace[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives a list of single-channel images corresponding to each of the color channels in image.
		///https://reference.wolfram.com/language/ref/ColorSeparate.html
		///</summary>
		public static Engine ColorSeparate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorSeparate[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of images corresponding to the components of colorspace.
		///https://reference.wolfram.com/language/ref/ColorSeparate.html
		///</summary>
		public static Engine ColorSeparate(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorSeparate[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a color setter which displays as a swatch of the specified color and when clicked brings up a system color picker dialog.
		///https://reference.wolfram.com/language/ref/ColorSetter.html
		///</summary>
		public static Engine ColorSetter(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorSetter[" + arg0 + "]", name);
		}

		///<summary>
		///gives a color setter with initial color gray.
		///https://reference.wolfram.com/language/ref/ColorSetter.html
		///</summary>
		public static Engine ColorSetter(this Engine en, string? name = null)
		{
				return en.Execute("ColorSetter[]", name);
		}

		///<summary>
		///represents a color slider currently set to the color corresponding to color.
		///https://reference.wolfram.com/language/ref/ColorSlider.html
		///</summary>
		public static Engine ColorSlider(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorSlider[" + arg0 + "]", name);
		}

		///<summary>
		///represents a color slider with an initial gray color.
		///https://reference.wolfram.com/language/ref/ColorSlider.html
		///</summary>
		public static Engine ColorSlider(this Engine en, string? name = null)
		{
				return en.Execute("ColorSlider[]", name);
		}

		///<summary>
		///represents a region around color.
		///https://reference.wolfram.com/language/ref/ColorsNear.html
		///</summary>
		public static Engine ColorsNear(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorsNear[" + arg0 + "]", name);
		}

		///<summary>
		///represents a region with maximum distance d around color.
		///https://reference.wolfram.com/language/ref/ColorsNear.html
		///</summary>
		public static Engine ColorsNear(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorsNear[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses the specified color distance function dfun.
		///https://reference.wolfram.com/language/ref/ColorsNear.html
		///</summary>
		public static Engine ColorsNear(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ColorsNear[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///applies a tone mapping to color values in image so as to make variations of luminance visible even in small intervals of the dynamic range.
		///https://reference.wolfram.com/language/ref/ColorToneMapping.html
		///</summary>
		public static Engine ColorToneMapping(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ColorToneMapping[" + arg0 + "]", name);
		}

		///<summary>
		///maps colors by compressing the overall range of luminance values by a factor c.
		///https://reference.wolfram.com/language/ref/ColorToneMapping.html
		///</summary>
		public static Engine ColorToneMapping(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ColorToneMapping[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///takes the specified range of colors and compresses their overall luminance values by a factor c.
		///https://reference.wolfram.com/language/ref/ColorToneMapping.html
		///</summary>
		public static Engine ColorToneMapping(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ColorToneMapping[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///uses different compression factors ci for different ranges rangei.
		///https://reference.wolfram.com/language/ref/ColorToneMapping.html
		///</summary>
		public static Engine ColorToneMapping(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ColorToneMapping[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///uses the color compensation factor s to correct for saturation distortion introduced during tone mapping.
		///https://reference.wolfram.com/language/ref/ColorToneMapping.html
		///</summary>
		public static Engine ColorToneMapping(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ColorToneMapping[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///is an object that formats with the expri arranged in a column, with expr1 above expr2, etc.
		///https://reference.wolfram.com/language/ref/Column.html
		///</summary>
		public static Engine Column(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Column[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///aligns each element horizontally in the specified way.
		///https://reference.wolfram.com/language/ref/Column.html
		///</summary>
		public static Engine Column(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Column[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///leaves the specified number of x-heights of spacing between successive elements.
		///https://reference.wolfram.com/language/ref/Column.html
		///</summary>
		public static Engine Column(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Column[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a class of entities obtained by combining the properties of those pairs of entities from class1 and class2 for which the value of the property prop is the same for the two entities in the pair.
		///https://reference.wolfram.com/language/ref/CombinedEntityClass.html
		///</summary>
		public static Engine CombinedEntityClass(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CombinedEntityClass[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///combines pairs of entities for which all the property specifications pspeck agree.
		///https://reference.wolfram.com/language/ref/CombinedEntityClass.html
		///</summary>
		public static Engine CombinedEntityClass(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CombinedEntityClass[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///uses "jspec" to determine when to allow entities with missing properties to be included.
		///https://reference.wolfram.com/language/ref/CombinedEntityClass.html
		///</summary>
		public static Engine CombinedEntityClass(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CombinedEntityClass[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the comet entity.
		///https://reference.wolfram.com/language/ref/CometData.html
		///</summary>
		public static Engine CometData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CometData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of property values for the specified comet entities.
		///https://reference.wolfram.com/language/ref/CometData.html
		///</summary>
		public static Engine CometData(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CometData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the specified annotation associated with the given property.
		///https://reference.wolfram.com/language/ref/CometData.html
		///</summary>
		public static Engine CometData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CometData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives a list of the elements that are the most common in list.
		///https://reference.wolfram.com/language/ref/Commonest.html
		///</summary>
		public static Engine Commonest(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Commonest[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of the n most common elements in list.
		///https://reference.wolfram.com/language/ref/Commonest.html
		///</summary>
		public static Engine Commonest(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Commonest[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///filters data by replacing every value with the most common value in its range-r neighborhood.
		///https://reference.wolfram.com/language/ref/CommonestFilter.html
		///</summary>
		public static Engine CommonestFilter(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CommonestFilter[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses ri for filtering the dimension in data.
		///https://reference.wolfram.com/language/ref/CommonestFilter.html
		///</summary>
		public static Engine CommonestFilter(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CommonestFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the common name for the entity specified by entity.
		///https://reference.wolfram.com/language/ref/CommonName.html
		///</summary>
		public static Engine CommonName(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CommonName[" + arg0 + "]", name);
		}

		///<summary>
		///gives the common name for entity1 through entityn.
		///https://reference.wolfram.com/language/ref/CommonName.html
		///</summary>
		public static Engine CommonName(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CommonName[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///converts quantity1 through quantityn to common units across compatible dimensions.
		///https://reference.wolfram.com/language/ref/CommonUnits.html
		///</summary>
		public static Engine CommonUnits(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CommonUnits[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///generates a plot showing the community structure of the graph g.
		///https://reference.wolfram.com/language/ref/CommunityGraphPlot.html
		///</summary>
		public static Engine CommunityGraphPlot(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CommunityGraphPlot[" + arg0 + "]", name);
		}

		///<summary>
		///generates a plot for the graph g with communities {vi1,vi2,…}, ….
		///https://reference.wolfram.com/language/ref/CommunityGraphPlot.html
		///</summary>
		public static Engine CommunityGraphPlot(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CommunityGraphPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///generates a plot with highlighting features defined by the symbol wrappers wj.
		///https://reference.wolfram.com/language/ref/CommunityGraphPlot.html
		///</summary>
		public static Engine CommunityGraphPlot(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CommunityGraphPlot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///generates a plot for a graph in which vertex vik is connected to vertex vjk.
		///https://reference.wolfram.com/language/ref/CommunityGraphPlot.html
		///</summary>
		public static Engine CommunityGraphPlot(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CommunityGraphPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///generates a plot for a graph represented by the adjacency matrix m.
		///https://reference.wolfram.com/language/ref/CommunityGraphPlot.html
		///</summary>
		public static Engine CommunityGraphPlot(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CommunityGraphPlot[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the company entity.
		///https://reference.wolfram.com/language/ref/CompanyData.html
		///</summary>
		public static Engine CompanyData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompanyData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of property values for the specified company entities.
		///https://reference.wolfram.com/language/ref/CompanyData.html
		///</summary>
		public static Engine CompanyData(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CompanyData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the specified annotation associated with the given property.
		///https://reference.wolfram.com/language/ref/CompanyData.html
		///</summary>
		public static Engine CompanyData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CompanyData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns True if quantity1 and quantity2 have compatible units, and False otherwise.
		///https://reference.wolfram.com/language/ref/CompatibleUnitQ.html
		///</summary>
		public static Engine CompatibleUnitQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompatibleUnitQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a compiled function that evaluates expr assuming numerical values of the xi.
		///https://reference.wolfram.com/language/ref/Compile.html
		///</summary>
		public static Engine Compile(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Compile[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///assumes that subexpressions in expr that match pi are of types that match pti.
		///https://reference.wolfram.com/language/ref/Compile.html
		///</summary>
		public static Engine Compile(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("Compile[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///is a function created by FunctionCompile that contains compiled code that is run when the CompiledCodeFunction is applied to suitable arguments.
		///https://reference.wolfram.com/language/ref/CompiledCodeFunction.html
		///</summary>
		public static Engine CompiledCodeFunction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CompiledCodeFunction[" + arg0 + "]", name);
		}

		///<summary>
		///represents a type for expressions of the form h[x1,x2,…,xn], suitable for use in compiled code.
		///https://reference.wolfram.com/language/ref/CompiledExpressionDeclaration.html
		///</summary>
		public static Engine CompiledExpressionDeclaration(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompiledExpressionDeclaration[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a type for expressions of the form h[x1,x2,…,xn], with xi having the type ti.
		///https://reference.wolfram.com/language/ref/CompiledExpressionDeclaration.html
		///</summary>
		public static Engine CompiledExpressionDeclaration(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CompiledExpressionDeclaration[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///asserts the condition cond on the type parameters.
		///https://reference.wolfram.com/language/ref/CompiledExpressionDeclaration.html
		///</summary>
		public static Engine CompiledExpressionDeclaration(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CompiledExpressionDeclaration[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///represents compiled code for evaluating a compiled function.
		///https://reference.wolfram.com/language/ref/CompiledFunction.html
		///</summary>
		public static Engine CompiledFunction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CompiledFunction[" + arg0 + "]", name);
		}

		///<summary>
		///represents a net layer whose computation is defined by the compilable function func.
		///https://reference.wolfram.com/language/ref/CompiledLayer.html
		///</summary>
		public static Engine CompiledLayer(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CompiledLayer[" + arg0 + "]", name);
		}

		///<summary>
		///specifies a gradient propagating function allowing the layer to be used in NetTrain.
		///https://reference.wolfram.com/language/ref/CompiledLayer.html
		///</summary>
		public static Engine CompiledLayer(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompiledLayer[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is a function that, if defined in a compiler environment, is automatically called by the Wolfram Compiler.
		///https://reference.wolfram.com/language/ref/CompilerCallback.html
		///</summary>
		public static Engine CompilerCallback(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CompilerCallback[" + arg0 + "]", name);
		}

		///<summary>
		///appends declarations to $CompilerEnvironment.
		///https://reference.wolfram.com/language/ref/CompilerEnvironmentAppendTo.html
		///</summary>
		public static Engine CompilerEnvironmentAppendTo(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CompilerEnvironmentAppendTo[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///appends declarations to CompilerEnvironmentObject env.
		///https://reference.wolfram.com/language/ref/CompilerEnvironmentAppendTo.html
		///</summary>
		public static Engine CompilerEnvironmentAppendTo(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CompilerEnvironmentAppendTo[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the elements in eall that are not in any of the ei.
		///https://reference.wolfram.com/language/ref/Complement.html
		///</summary>
		public static Engine Complement(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Complement[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents an entity class containing all the entities in classall that are not in any of the classi.
		///https://reference.wolfram.com/language/ref/ComplementedEntityClass.html
		///</summary>
		public static Engine ComplementedEntityClass(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ComplementedEntityClass[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the complete graph with n vertices .
		///https://reference.wolfram.com/language/ref/CompleteGraph.html
		///</summary>
		public static Engine CompleteGraph(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CompleteGraph[" + arg0 + "]", name);
		}

		///<summary>
		///gives the complete k-partite graph with n1+n2+⋯+nk vertices .
		///https://reference.wolfram.com/language/ref/CompleteGraph.html
		///</summary>
		public static Engine CompleteGraph(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CompleteGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///yields True if the graph g is a complete graph, and False otherwise.
		///https://reference.wolfram.com/language/ref/CompleteGraphQ.html
		///</summary>
		public static Engine CompleteGraphQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CompleteGraphQ[" + arg0 + "]", name);
		}

		///<summary>
		///yields True if the subgraph induced by vlist is a complete graph, and False otherwise.
		///https://reference.wolfram.com/language/ref/CompleteGraphQ.html
		///</summary>
		public static Engine CompleteGraphQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompleteGraphQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a complete integral u for the first-order partial differential equation pde, with independent variables {x1,…,xn}.
		///https://reference.wolfram.com/language/ref/CompleteIntegral.html
		///</summary>
		public static Engine CompleteIntegral(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CompleteIntegral[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the complete binary tree with n levels.
		///https://reference.wolfram.com/language/ref/CompleteKaryTree.html
		///</summary>
		public static Engine CompleteKaryTree(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CompleteKaryTree[" + arg0 + "]", name);
		}

		///<summary>
		///gives the complete k-ary tree with n levels.
		///https://reference.wolfram.com/language/ref/CompleteKaryTree.html
		///</summary>
		public static Engine CompleteKaryTree(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompleteKaryTree[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///generates a plot in which complex values zij in an array array are shown in a discrete array of squares with Arg[zij] indicated by color and Abs[zij] by shading.
		///https://reference.wolfram.com/language/ref/ComplexArrayPlot.html
		///</summary>
		public static Engine ComplexArrayPlot(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ComplexArrayPlot[" + arg0 + "]", name);
		}

		///<summary>
		///generates a filled contour plot of f as a function of z.
		///https://reference.wolfram.com/language/ref/ComplexContourPlot.html
		///</summary>
		public static Engine ComplexContourPlot(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexContourPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///generates contour lines for f1, f2, ….
		///https://reference.wolfram.com/language/ref/ComplexContourPlot.html
		///</summary>
		public static Engine ComplexContourPlot(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexContourPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///expands expr assuming that all variables are real.
		///https://reference.wolfram.com/language/ref/ComplexExpand.html
		///</summary>
		public static Engine ComplexExpand(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ComplexExpand[" + arg0 + "]", name);
		}

		///<summary>
		///expands expr assuming that variables matching any of the xi are complex.
		///https://reference.wolfram.com/language/ref/ComplexExpand.html
		///</summary>
		public static Engine ComplexExpand(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexExpand[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///plots complex numbers z1, z2, … as points in the complex plane.
		///https://reference.wolfram.com/language/ref/ComplexListPlot.html
		///</summary>
		public static Engine ComplexListPlot(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ComplexListPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///generates a plot of Arg[f] over the complex rectangle with corners zmin and zmax.
		///https://reference.wolfram.com/language/ref/ComplexPlot.html
		///</summary>
		public static Engine ComplexPlot(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///generates a 3D plot of Abs[f] colored by Arg[f] over the complex rectangle with corners zmin and zmax.
		///https://reference.wolfram.com/language/ref/ComplexPlot3D.html
		///</summary>
		public static Engine ComplexPlot3D(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexPlot3D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///makes a plot showing the region in the complex plane for which pred is True.
		///https://reference.wolfram.com/language/ref/ComplexRegionPlot.html
		///</summary>
		public static Engine ComplexRegionPlot(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexRegionPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///plots regions given by the multiple predicates predi.
		///https://reference.wolfram.com/language/ref/ComplexRegionPlot.html
		///</summary>
		public static Engine ComplexRegionPlot(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexRegionPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///generates a streamline plot of the vector field {Re[f],Im[f]} over the complex rectangle with corners zmin and zmax.
		///https://reference.wolfram.com/language/ref/ComplexStreamPlot.html
		///</summary>
		public static Engine ComplexStreamPlot(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexStreamPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///generates a vector plot of the vector field {Re[f],Im[f]} over the complex rectangle with corners zmin and zmax.
		///https://reference.wolfram.com/language/ref/ComplexVectorPlot.html
		///</summary>
		public static Engine ComplexVectorPlot(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexVectorPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///plots several vector fields.
		///https://reference.wolfram.com/language/ref/ComplexVectorPlot.html
		///</summary>
		public static Engine ComplexVectorPlot(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ComplexVectorPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///computes the property "prop" for components of image indicated by the label matrix lmat.
		///https://reference.wolfram.com/language/ref/ComponentMeasurements.html
		///</summary>
		public static Engine ComponentMeasurements(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ComponentMeasurements[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///computes the property "prop" for connected components of image.
		///https://reference.wolfram.com/language/ref/ComponentMeasurements.html
		///</summary>
		public static Engine ComponentMeasurements(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ComponentMeasurements[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///only returns measurements for components that satisfy the criterion crit.
		///https://reference.wolfram.com/language/ref/ComponentMeasurements.html
		///</summary>
		public static Engine ComponentMeasurements(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ComponentMeasurements[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///formats the result according to the output specification format.
		///https://reference.wolfram.com/language/ref/ComponentMeasurements.html
		///</summary>
		public static Engine ComponentMeasurements(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ComponentMeasurements[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///generates a list of the form {x,f1[x],f2[f1[x]],…}.
		///https://reference.wolfram.com/language/ref/ComposeList.html
		///</summary>
		public static Engine ComposeList(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ComposeList[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///composes several power series.
		///https://reference.wolfram.com/language/ref/ComposeSeries.html
		///</summary>
		public static Engine ComposeSeries(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ComposeSeries[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///yields True if n is a composite number, and yields False otherwise.
		///https://reference.wolfram.com/language/ref/CompositeQ.html
		///</summary>
		public static Engine CompositeQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CompositeQ[" + arg0 + "]", name);
		}

		///<summary>
		///represents a composition of the functions f1, f2, f3, ….
		///https://reference.wolfram.com/language/ref/Composition.html
		///</summary>
		public static Engine Composition(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Composition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents a form or interpreter specification for a list of fields or inputs that gives a list of results.
		///https://reference.wolfram.com/language/ref/CompoundElement.html
		///</summary>
		public static Engine CompoundElement(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CompoundElement[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents a form or interpreter specification that gives an association of results.
		///https://reference.wolfram.com/language/ref/CompoundElement.html
		///</summary>
		public static Engine CompoundElement(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CompoundElement[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a compound Poisson distribution with rate parameter λ and jump size distribution dist.
		///https://reference.wolfram.com/language/ref/CompoundPoissonDistribution.html
		///</summary>
		public static Engine CompoundPoissonDistribution(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompoundPoissonDistribution[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a compound Poisson process with rate parameter λ and jump size distribution jdist.
		///https://reference.wolfram.com/language/ref/CompoundPoissonProcess.html
		///</summary>
		public static Engine CompoundPoissonProcess(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompoundPoissonProcess[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a compound renewal process with renewal-time distribution rdist and jump size distribution jdist.
		///https://reference.wolfram.com/language/ref/CompoundRenewalProcess.html
		///</summary>
		public static Engine CompoundRenewalProcess(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CompoundRenewalProcess[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a compressed representation of expr as a string.
		///https://reference.wolfram.com/language/ref/Compress.html
		///</summary>
		public static Engine Compress(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Compress[" + arg0 + "]", name);
		}

		///<summary>
		///gives the concave hull mesh from the points p1,p2,….
		///https://reference.wolfram.com/language/ref/ConcaveHullMesh.html
		///</summary>
		public static Engine ConcaveHullMesh(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ConcaveHullMesh[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the concave hull mesh of the specified parameter α.
		///https://reference.wolfram.com/language/ref/ConcaveHullMesh.html
		///</summary>
		public static Engine ConcaveHullMesh(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ConcaveHullMesh[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the concave hull mesh of cells of dimension d.
		///https://reference.wolfram.com/language/ref/ConcaveHullMesh.html
		///</summary>
		public static Engine ConcaveHullMesh(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConcaveHullMesh[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///is a symbolic construct that represents the expression expr when the condition cond is True.
		///https://reference.wolfram.com/language/ref/ConditionalExpression.html
		///</summary>
		public static Engine ConditionalExpression(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConditionalExpression[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///or exprcond represents expr conditioned by the predicate cond.
		///https://reference.wolfram.com/language/ref/Conditioned.html
		///</summary>
		public static Engine Conditioned(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Conditioned[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a cone with a base of radius r centered at (x1,y1,z1) and a tip at (x2,y2,z2).
		///https://reference.wolfram.com/language/ref/Cone.html
		///</summary>
		public static Engine Cone(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("Cone[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a cone with a base of radius 1.
		///https://reference.wolfram.com/language/ref/Cone.html
		///</summary>
		public static Engine Cone(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Cone[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///confirms that expr is not considered a failure, otherwise throwing an error to the nearest surrounding Enclose.
		///https://reference.wolfram.com/language/ref/Confirm.html
		///</summary>
		public static Engine Confirm(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Confirm[" + arg0 + "]", name);
		}

		///<summary>
		///evaluates info and includes its value in the thrown error if expr is not confirmed.
		///https://reference.wolfram.com/language/ref/Confirm.html
		///</summary>
		public static Engine Confirm(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Confirm[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses the specified tag for any thrown errors.
		///https://reference.wolfram.com/language/ref/Confirm.html
		///</summary>
		public static Engine Confirm(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Confirm[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///confirms that test is True, otherwise throwing an error to the nearest surrounding Enclose.
		///https://reference.wolfram.com/language/ref/ConfirmAssert.html
		///</summary>
		public static Engine ConfirmAssert(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConfirmAssert[" + arg0 + "]", name);
		}

		///<summary>
		///evaluates info and includes its value in the thrown error if test is not True.
		///https://reference.wolfram.com/language/ref/ConfirmAssert.html
		///</summary>
		public static Engine ConfirmAssert(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConfirmAssert[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses the specified tag for any thrown errors.
		///https://reference.wolfram.com/language/ref/ConfirmAssert.html
		///</summary>
		public static Engine ConfirmAssert(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConfirmAssert[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///confirms that f[expr] returns True, otherwise throwing an error to the nearest surrounding Enclose.
		///https://reference.wolfram.com/language/ref/ConfirmBy.html
		///</summary>
		public static Engine ConfirmBy(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConfirmBy[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///evaluates info and includes its value in the thrown error if expr is not confirmed.
		///https://reference.wolfram.com/language/ref/ConfirmBy.html
		///</summary>
		public static Engine ConfirmBy(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConfirmBy[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///uses the specified tag for any thrown errors.
		///https://reference.wolfram.com/language/ref/ConfirmBy.html
		///</summary>
		public static Engine ConfirmBy(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ConfirmBy[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///confirms that expr matches the pattern form, otherwise throwing an error to the nearest surrounding Enclose.
		///https://reference.wolfram.com/language/ref/ConfirmMatch.html
		///</summary>
		public static Engine ConfirmMatch(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConfirmMatch[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///evaluates info and includes its value in the thrown error if expr is not confirmed.
		///https://reference.wolfram.com/language/ref/ConfirmMatch.html
		///</summary>
		public static Engine ConfirmMatch(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConfirmMatch[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///uses the specified tag for any thrown errors.
		///https://reference.wolfram.com/language/ref/ConfirmMatch.html
		///</summary>
		public static Engine ConfirmMatch(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ConfirmMatch[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///confirms that no messages are generated during the evaluation of expr, otherwise quieting them and throwing an error to the nearest surrounding Enclose.
		///https://reference.wolfram.com/language/ref/ConfirmQuiet.html
		///</summary>
		public static Engine ConfirmQuiet(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConfirmQuiet[" + arg0 + "]", name);
		}

		///<summary>
		///tests only for the specified message.
		///https://reference.wolfram.com/language/ref/ConfirmQuiet.html
		///</summary>
		public static Engine ConfirmQuiet(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConfirmQuiet[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///tests only for the specified list of messages.
		///https://reference.wolfram.com/language/ref/ConfirmQuiet.html
		///</summary>
		public static Engine ConfirmQuiet(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConfirmQuiet[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///evaluates info and includes its value in the thrown error if expr is not confirmed.
		///https://reference.wolfram.com/language/ref/ConfirmQuiet.html
		///</summary>
		public static Engine ConfirmQuiet(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConfirmQuiet[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///uses the specified tag for any thrown errors.
		///https://reference.wolfram.com/language/ref/ConfirmQuiet.html
		///</summary>
		public static Engine ConfirmQuiet(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ConfirmQuiet[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///returns a list of audio objects where all audioi are made to have conforming properties, including duration, data type, and number of channels.
		///https://reference.wolfram.com/language/ref/ConformAudio.html
		///</summary>
		public static Engine ConformAudio(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ConformAudio[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///returns all audio objects of the specified spec.
		///https://reference.wolfram.com/language/ref/ConformAudio.html
		///</summary>
		public static Engine ConformAudio(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ConformAudio[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns a list of images where all imagei are made to have conforming properties, including dimensions, data type, color space, and interleaving.
		///https://reference.wolfram.com/language/ref/ConformImages.html
		///</summary>
		public static Engine ConformImages(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ConformImages[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///returns all images of the specified spec.
		///https://reference.wolfram.com/language/ref/ConformImages.html
		///</summary>
		public static Engine ConformImages(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ConformImages[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///resizes images using the specified fitting method.
		///https://reference.wolfram.com/language/ref/ConformImages.html
		///</summary>
		public static Engine ConformImages(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConformImages[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/Congruent.html
		///</summary>
		public static Engine Congruent(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Congruent[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///is a two-dimensional graphics directive specifying that faces of polygons and other filled graphics objects are to be drawn using a progressive transition between colors coli along a circle.
		///https://reference.wolfram.com/language/ref/ConicGradientFilling.html
		///</summary>
		public static Engine ConicGradientFilling(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ConicGradientFilling[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///rotates from the center point {x,y}.
		///https://reference.wolfram.com/language/ref/ConicGradientFilling.html
		///</summary>
		public static Engine ConicGradientFilling(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConicGradientFilling[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents the m-dimensional affine hull region passing through points pi.
		///https://reference.wolfram.com/language/ref/ConicHullRegion.html
		///</summary>
		public static Engine ConicHullRegion(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ConicHullRegion[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents the m-dimensional affine hull region passing through the point p and parallel to vi.
		///https://reference.wolfram.com/language/ref/ConicHullRegion.html
		///</summary>
		public static Engine ConicHullRegion(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConicHullRegion[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents the m-dimensional affine hull plus the conic hull generated by the vectors wj.
		///https://reference.wolfram.com/language/ref/ConicHullRegion.html
		///</summary>
		public static Engine ConicHullRegion(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConicHullRegion[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents the m-dimensional affine hull plus the conic hull generated by the vectors wj.
		///https://reference.wolfram.com/language/ref/ConicHullRegion.html
		///</summary>
		public static Engine ConicHullRegion(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ConicHullRegion[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///finds values of variables vars that minimize the linear objective f subject to conic constraints cons.
		///https://reference.wolfram.com/language/ref/ConicOptimization.html
		///</summary>
		public static Engine ConicOptimization(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConicOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///specifies what solution property "prop" should be returned.
		///https://reference.wolfram.com/language/ref/ConicOptimization.html
		///</summary>
		public static Engine ConicOptimization(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConicOptimization[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///or z gives the complex conjugate of the complex number z.
		///https://reference.wolfram.com/language/ref/Conjugate.html
		///</summary>
		public static Engine Conjugate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Conjugate[" + arg0 + "]", name);
		}

		///<summary>
		///or  gives the conjugate transpose of .
		///https://reference.wolfram.com/language/ref/ConjugateTranspose.html
		///</summary>
		public static Engine ConjugateTranspose(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConjugateTranspose[" + arg0 + "]", name);
		}

		///<summary>
		///gives the conjunction of expr over all choices of the Boolean variables ai.
		///https://reference.wolfram.com/language/ref/Conjunction.html
		///</summary>
		public static Engine Conjunction(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Conjunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the connected components of the graph g.
		///https://reference.wolfram.com/language/ref/ConnectedComponents.html
		///</summary>
		public static Engine ConnectedComponents(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConnectedComponents[" + arg0 + "]", name);
		}

		///<summary>
		///gives the connected components that include at least one of the vertices v1, v2, … .
		///https://reference.wolfram.com/language/ref/ConnectedComponents.html
		///</summary>
		public static Engine ConnectedComponents(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConnectedComponents[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the connected components that include a vertex that matches the pattern patt.
		///https://reference.wolfram.com/language/ref/ConnectedComponents.html
		///</summary>
		public static Engine ConnectedComponents(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConnectedComponents[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses rules vw to specify the graph g.
		///https://reference.wolfram.com/language/ref/ConnectedComponents.html
		///</summary>
		public static Engine ConnectedComponents(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ConnectedComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the connected components of the graph g.
		///https://reference.wolfram.com/language/ref/ConnectedGraphComponents.html
		///</summary>
		public static Engine ConnectedGraphComponents(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConnectedGraphComponents[" + arg0 + "]", name);
		}

		///<summary>
		///gives the connected components that include at least one of the vertices v1, v2, … .
		///https://reference.wolfram.com/language/ref/ConnectedGraphComponents.html
		///</summary>
		public static Engine ConnectedGraphComponents(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConnectedGraphComponents[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the connected components that include a vertex that matches the pattern patt.
		///https://reference.wolfram.com/language/ref/ConnectedGraphComponents.html
		///</summary>
		public static Engine ConnectedGraphComponents(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConnectedGraphComponents[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses rules vw to specify the graph g.
		///https://reference.wolfram.com/language/ref/ConnectedGraphComponents.html
		///</summary>
		public static Engine ConnectedGraphComponents(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ConnectedGraphComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields True if the graph g is connected, and False otherwise.
		///https://reference.wolfram.com/language/ref/ConnectedGraphQ.html
		///</summary>
		public static Engine ConnectedGraphQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConnectedGraphQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list {c1,c2,…} of disjoint path connected meshed regions.
		///https://reference.wolfram.com/language/ref/ConnectedMeshComponents.html
		///</summary>
		public static Engine ConnectedMeshComponents(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConnectedMeshComponents[" + arg0 + "]", name);
		}

		///<summary>
		///gives the connected components of the molecule mol.
		///https://reference.wolfram.com/language/ref/ConnectedMoleculeComponents.html
		///</summary>
		public static Engine ConnectedMoleculeComponents(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConnectedMoleculeComponents[" + arg0 + "]", name);
		}

		///<summary>
		///returns True if the atoms in mol form are connected by bonds, and False otherwise.
		///https://reference.wolfram.com/language/ref/ConnectedMoleculeQ.html
		///</summary>
		public static Engine ConnectedMoleculeQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConnectedMoleculeQ[" + arg0 + "]", name);
		}

		///<summary>
		///connects a CompiledFunction cf with the library callback manager with name mname.
		///https://reference.wolfram.com/language/ref/ConnectLibraryCallbackFunction.html
		///</summary>
		public static Engine ConnectLibraryCallbackFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConnectLibraryCallbackFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a system model by connecting connector "a" of component "c1" with connector "b" of component "c2" etc.
		///https://reference.wolfram.com/language/ref/ConnectSystemModelComponents.html
		///</summary>
		public static Engine ConnectSystemModelComponents(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConnectSystemModelComponents[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///connects the system model model with a controller according to the controller data controller.
		///https://reference.wolfram.com/language/ref/ConnectSystemModelController.html
		///</summary>
		public static Engine ConnectSystemModelController(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConnectSystemModelController[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a Connes window function of x.
		///https://reference.wolfram.com/language/ref/ConnesWindow.html
		///</summary>
		public static Engine ConnesWindow(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConnesWindow[" + arg0 + "]", name);
		}

		///<summary>
		///uses the parameter α.
		///https://reference.wolfram.com/language/ref/ConnesWindow.html
		///</summary>
		public static Engine ConnesWindow(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConnesWindow[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///tests whether the variances of data1, data2, … are equal.
		///https://reference.wolfram.com/language/ref/ConoverTest.html
		///</summary>
		public static Engine ConoverTest(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ConoverTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///tests a dispersion measure against .
		///https://reference.wolfram.com/language/ref/ConoverTest.html
		///</summary>
		public static Engine ConoverTest(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConoverTest[" + arg0 + "]", name);
		}

		///<summary>
		///returns the value of "property".
		///https://reference.wolfram.com/language/ref/ConoverTest.html
		///</summary>
		public static Engine ConoverTest(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConoverTest[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a conservative convection term  with conservative convection coefficient  and model variables vars.
		///https://reference.wolfram.com/language/ref/ConservativeConvectionPDETerm.html
		///</summary>
		public static Engine ConservativeConvectionPDETerm(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConservativeConvectionPDETerm[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses model parameters pars.
		///https://reference.wolfram.com/language/ref/ConservativeConvectionPDETerm.html
		///</summary>
		public static Engine ConservativeConvectionPDETerm(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConservativeConvectionPDETerm[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///generates a list of n copies of the element c.
		///https://reference.wolfram.com/language/ref/ConstantArray.html
		///</summary>
		public static Engine ConstantArray(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConstantArray[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///generates an  array of nested lists containing copies of the element c.
		///https://reference.wolfram.com/language/ref/ConstantArray.html
		///</summary>
		public static Engine ConstantArray(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConstantArray[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives an image of the specified size with constant pixel values of val.
		///https://reference.wolfram.com/language/ref/ConstantImage.html
		///</summary>
		public static Engine ConstantImage(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConstantImage[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an image converted to the specified type.
		///https://reference.wolfram.com/language/ref/ConstantImage.html
		///</summary>
		public static Engine ConstantImage(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConstantImage[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives True if the reg is a constant region and False otherwise.
		///https://reference.wolfram.com/language/ref/ConstantRegionQ.html
		///</summary>
		public static Engine ConstantRegionQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConstantRegionQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the constellation entity.
		///https://reference.wolfram.com/language/ref/ConstellationData.html
		///</summary>
		public static Engine ConstellationData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConstellationData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of property values for the specified constellation entities.
		///https://reference.wolfram.com/language/ref/ConstellationData.html
		///</summary>
		public static Engine ConstellationData(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ConstellationData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the specified annotation associated with the given property.
		///https://reference.wolfram.com/language/ref/ConstellationData.html
		///</summary>
		public static Engine ConstellationData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConstellationData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives f[x].
		///https://reference.wolfram.com/language/ref/Construct.html
		///</summary>
		public static Engine Construct(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Construct[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives f[x1,…,xn].
		///https://reference.wolfram.com/language/ref/Construct.html
		///</summary>
		public static Engine Construct(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Construct[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents an object of type outer containing objects of type inner.
		///https://reference.wolfram.com/language/ref/Containing.html
		///</summary>
		public static Engine Containing(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Containing[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields True if e1 contains all of the elements of e2.
		///https://reference.wolfram.com/language/ref/ContainsAll.html
		///</summary>
		public static Engine ContainsAll(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContainsAll[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is an operator form that yields True when the object to which it is applied contains all of the elements of e2.
		///https://reference.wolfram.com/language/ref/ContainsAll.html
		///</summary>
		public static Engine ContainsAll(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContainsAll[" + arg0 + "]", name);
		}

		///<summary>
		///yields True if e1 contains any of the elements of e2.
		///https://reference.wolfram.com/language/ref/ContainsAny.html
		///</summary>
		public static Engine ContainsAny(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContainsAny[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is an operator form that yields True when the object to which it is applied contains any of the elements in e2.
		///https://reference.wolfram.com/language/ref/ContainsAny.html
		///</summary>
		public static Engine ContainsAny(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContainsAny[" + arg0 + "]", name);
		}

		///<summary>
		///yields True if e1 contains exactly the same elements as e2.
		///https://reference.wolfram.com/language/ref/ContainsExactly.html
		///</summary>
		public static Engine ContainsExactly(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContainsExactly[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is an operator form that yields True when the object to which it is applied contains exactly the same elements as e2.
		///https://reference.wolfram.com/language/ref/ContainsExactly.html
		///</summary>
		public static Engine ContainsExactly(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContainsExactly[" + arg0 + "]", name);
		}

		///<summary>
		///yields True if e1 contains none of the elements in e2.
		///https://reference.wolfram.com/language/ref/ContainsNone.html
		///</summary>
		public static Engine ContainsNone(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContainsNone[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is an operator form that yields True when the object to which it is applied contains none of the elements of e2.
		///https://reference.wolfram.com/language/ref/ContainsNone.html
		///</summary>
		public static Engine ContainsNone(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContainsNone[" + arg0 + "]", name);
		}

		///<summary>
		///yields True if e1 contains only elements that appear in e2.
		///https://reference.wolfram.com/language/ref/ContainsOnly.html
		///</summary>
		public static Engine ContainsOnly(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContainsOnly[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is an operator form that yields True when the object to which it is applied contains only elements that appear in e2.
		///https://reference.wolfram.com/language/ref/ContainsOnly.html
		///</summary>
		public static Engine ContainsOnly(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContainsOnly[" + arg0 + "]", name);
		}

		///<summary>
		///represents a function generated by TrainImageContentDetector or TrainTextContentDetector that localizes and classifies contents in a piece of text or an image.
		///https://reference.wolfram.com/language/ref/ContentDetectorFunction.html
		///</summary>
		public static Engine ContentDetectorFunction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContentDetectorFunction[" + arg0 + "]", name);
		}

		///<summary>
		///gives a content object whose content is string.
		///https://reference.wolfram.com/language/ref/ContentObject.html
		///</summary>
		public static Engine ContentObject(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContentObject[" + arg0 + "]", name);
		}

		///<summary>
		///gives a content object with a sequence of fields with names namei and values vali.
		///https://reference.wolfram.com/language/ref/ContentObject.html
		///</summary>
		public static Engine ContentObject(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ContentObject[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the current context.
		///https://reference.wolfram.com/language/ref/Context.html
		///</summary>
		public static Engine Context(this Engine en, string? name = null)
		{
				return en.Execute("Context[]", name);
		}

		///<summary>
		///gives the context in which a symbol appears.
		///https://reference.wolfram.com/language/ref/Context.html
		///</summary>
		public static Engine Context(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Context[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of all contexts.
		///https://reference.wolfram.com/language/ref/Contexts.html
		///</summary>
		public static Engine Contexts(this Engine en, string? name = null)
		{
				return en.Execute("Contexts[]", name);
		}

		///<summary>
		///gives a list of the contexts that match the string.
		///https://reference.wolfram.com/language/ref/Contexts.html
		///</summary>
		public static Engine Contexts(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Contexts[" + arg0 + "]", name);
		}

		///<summary>
		///gives the string specifying the file name that is by convention associated with a particular context.
		///https://reference.wolfram.com/language/ref/ContextToFileName.html
		///</summary>
		public static Engine ContextToFileName(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContextToFileName[" + arg0 + "]", name);
		}

		///<summary>
		///exits to the nearest enclosing Do, For, or While in a procedural program.
		///https://reference.wolfram.com/language/ref/Continue.html
		///</summary>
		public static Engine Continue(this Engine en, string? name = null)
		{
				return en.Execute("Continue[]", name);
		}

		///<summary>
		///generates a list of the first n terms in the continued fraction representation of x.
		///https://reference.wolfram.com/language/ref/ContinuedFraction.html
		///</summary>
		public static Engine ContinuedFraction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContinuedFraction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///generates a list of all terms that can be obtained given the precision of x.
		///https://reference.wolfram.com/language/ref/ContinuedFraction.html
		///</summary>
		public static Engine ContinuedFraction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContinuedFraction[" + arg0 + "]", name);
		}

		///<summary>
		///represents the continued fraction .
		///https://reference.wolfram.com/language/ref/ContinuedFractionK.html
		///</summary>
		public static Engine ContinuedFractionK(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ContinuedFractionK[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///represents the continued fraction .
		///https://reference.wolfram.com/language/ref/ContinuedFractionK.html
		///</summary>
		public static Engine ContinuedFractionK(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ContinuedFractionK[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents a continuous-time finite-state Markov process with transition rate matrix q and initial state i0.
		///https://reference.wolfram.com/language/ref/ContinuousMarkovProcess.html
		///</summary>
		public static Engine ContinuousMarkovProcess(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContinuousMarkovProcess[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a Markov process with transition matrix m and transition rates μ.
		///https://reference.wolfram.com/language/ref/ContinuousMarkovProcess.html
		///</summary>
		public static Engine ContinuousMarkovProcess(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ContinuousMarkovProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a task in which expr is continuously reevaluated.
		///https://reference.wolfram.com/language/ref/ContinuousTask.html
		///</summary>
		public static Engine ContinuousTask(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContinuousTask[" + arg0 + "]", name);
		}

		///<summary>
		///represents a task in which expr is continuously reevaluated until the time specified by end.
		///https://reference.wolfram.com/language/ref/ContinuousTask.html
		///</summary>
		public static Engine ContinuousTask(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContinuousTask[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives True if lsys is a continuous-time systems model, and False otherwise.
		///https://reference.wolfram.com/language/ref/ContinuousTimeModelQ.html
		///</summary>
		public static Engine ContinuousTimeModelQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContinuousTimeModelQ[" + arg0 + "]", name);
		}

		///<summary>
		///yields a continuous wavelet data object with wavelet coefficients coefi corresponding to octave and voice {octi,voci} and wavelet wave.
		///https://reference.wolfram.com/language/ref/ContinuousWaveletData.html
		///</summary>
		public static Engine ContinuousWaveletData(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ContinuousWaveletData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the continuous wavelet transform of a list of values xi.
		///https://reference.wolfram.com/language/ref/ContinuousWaveletTransform.html
		///</summary>
		public static Engine ContinuousWaveletTransform(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ContinuousWaveletTransform[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the continuous wavelet transform using the wavelet wave.
		///https://reference.wolfram.com/language/ref/ContinuousWaveletTransform.html
		///</summary>
		public static Engine ContinuousWaveletTransform(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContinuousWaveletTransform[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the continuous wavelet transform using noct octaves with nvoc voices per octave.
		///https://reference.wolfram.com/language/ref/ContinuousWaveletTransform.html
		///</summary>
		public static Engine ContinuousWaveletTransform(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ContinuousWaveletTransform[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives a binary image in which white pixels correspond to the zeros and zero crossings in image.
		///https://reference.wolfram.com/language/ref/ContourDetect.html
		///</summary>
		public static Engine ContourDetect(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContourDetect[" + arg0 + "]", name);
		}

		///<summary>
		///treats values in image that are smaller in absolute value than delta as zero.
		///https://reference.wolfram.com/language/ref/ContourDetect.html
		///</summary>
		public static Engine ContourDetect(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContourDetect[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///generates a contour plot of f as a function of x and y.
		///https://reference.wolfram.com/language/ref/ContourPlot.html
		///</summary>
		public static Engine ContourPlot(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ContourPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///plots several contour lines.
		///https://reference.wolfram.com/language/ref/ContourPlot.html
		///</summary>
		public static Engine ContourPlot(this Engine en, List<string> arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ContourPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///takes the variables {x,y} to be in the geometric region reg.
		///https://reference.wolfram.com/language/ref/ContourPlot.html
		///</summary>
		public static Engine ContourPlot(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContourPlot[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///produces a three-dimensional contour plot of f as a function of x, y, and z.
		///https://reference.wolfram.com/language/ref/ContourPlot3D.html
		///</summary>
		public static Engine ContourPlot3D(this Engine en, string arg0, List<string> arg1, List<string> arg2, List<string> arg3, string? name = null)
		{
				return en.Execute("ContourPlot3D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
		}

		///<summary>
		///takes the variables {x,y,z} to be in the geometric region reg.
		///https://reference.wolfram.com/language/ref/ContourPlot3D.html
		///</summary>
		public static Engine ContourPlot3D(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContourPlot3D[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the contraharmonic mean of the values in list.
		///https://reference.wolfram.com/language/ref/ContraharmonicMean.html
		///</summary>
		public static Engine ContraharmonicMean(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContraharmonicMean[" + arg0 + "]", name);
		}

		///<summary>
		///gives the order p Lehmer contraharmonic mean.
		///https://reference.wolfram.com/language/ref/ContraharmonicMean.html
		///</summary>
		public static Engine ContraharmonicMean(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ContraharmonicMean[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a loss layer that computes a loss based on a distance metric and a target that specifies whether the distance should be minimized or maximized.
		///https://reference.wolfram.com/language/ref/ContrastiveLossLayer.html
		///</summary>
		public static Engine ContrastiveLossLayer(this Engine en, string? name = null)
		{
				return en.Execute("ContrastiveLossLayer[]", name);
		}

		///<summary>
		///specifies a distance above which the loss is zero for True targets.
		///https://reference.wolfram.com/language/ref/ContrastiveLossLayer.html
		///</summary>
		public static Engine ContrastiveLossLayer(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ContrastiveLossLayer[" + arg0 + "]", name);
		}

		///<summary>
		///represents an interactive control for the variable u in the domain dom, with the type of control chosen to be appropriate for the domain specified.
		///https://reference.wolfram.com/language/ref/Control.html
		///</summary>
		public static Engine Control(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Control[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///evaluates to act if a control that affects act is actively being used, and to norm otherwise.
		///https://reference.wolfram.com/language/ref/ControlActive.html
		///</summary>
		public static Engine ControlActive(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ControlActive[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the controllability Gramian of the state-space model ssm.
		///https://reference.wolfram.com/language/ref/ControllabilityGramian.html
		///</summary>
		public static Engine ControllabilityGramian(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ControllabilityGramian[" + arg0 + "]", name);
		}

		///<summary>
		///gives the controllability matrix of the state-space model ssm.
		///https://reference.wolfram.com/language/ref/ControllabilityMatrix.html
		///</summary>
		public static Engine ControllabilityMatrix(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ControllabilityMatrix[" + arg0 + "]", name);
		}

		///<summary>
		///yields the controllable subsystem of the state-space model sys.
		///https://reference.wolfram.com/language/ref/ControllableDecomposition.html
		///</summary>
		public static Engine ControllableDecomposition(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ControllableDecomposition[" + arg0 + "]", name);
		}

		///<summary>
		///specifies the new state variables zi.
		///https://reference.wolfram.com/language/ref/ControllableDecomposition.html
		///</summary>
		public static Engine ControllableDecomposition(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ControllableDecomposition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///yields True if the state-space model sys is controllable, and False otherwise.
		///https://reference.wolfram.com/language/ref/ControllableModelQ.html
		///</summary>
		public static Engine ControllableModelQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ControllableModelQ[" + arg0 + "]", name);
		}

		///<summary>
		///yields True if the subsystem sub is controllable.
		///https://reference.wolfram.com/language/ref/ControllableModelQ.html
		///</summary>
		public static Engine ControllableModelQ(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ControllableModelQ[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives dynamically updated information on currently connected controller devices.
		///https://reference.wolfram.com/language/ref/ControllerInformation.html
		///</summary>
		public static Engine ControllerInformation(this Engine en, string? name = null)
		{
				return en.Execute("ControllerInformation[]", name);
		}

		///<summary>
		///generates a version of expr set up to allow interactive manipulation of the value of u using an external controller device.
		///https://reference.wolfram.com/language/ref/ControllerManipulate.html
		///</summary>
		public static Engine ControllerManipulate(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ControllerManipulate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///allows u to take on discrete values u1, u2, ….
		///https://reference.wolfram.com/language/ref/ControllerManipulate.html
		///</summary>
		public static Engine ControllerManipulate(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ControllerManipulate[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///allows each of the u, v, … to be manipulated by the external controller device.
		///https://reference.wolfram.com/language/ref/ControllerManipulate.html
		///</summary>
		public static Engine ControllerManipulate(this Engine en, string arg0, List<string> arg1, List<string> arg2, string arg3, string? name = null)
		{
				return en.Execute("ControllerManipulate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
		}

		///<summary>
		///links the parameters to the specified controllers on the external controller device.
		///https://reference.wolfram.com/language/ref/ControllerManipulate.html
		///</summary>
		public static Engine ControllerManipulate(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ControllerManipulate[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the state of the control c for the first connected controller device on which it is supported.
		///https://reference.wolfram.com/language/ref/ControllerState.html
		///</summary>
		public static Engine ControllerState(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ControllerState[" + arg0 + "]", name);
		}

		///<summary>
		///gives the states of several controls.
		///https://reference.wolfram.com/language/ref/ControllerState.html
		///</summary>
		public static Engine ControllerState(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ControllerState[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the state of control c for controller devices with the specified identifier.
		///https://reference.wolfram.com/language/ref/ControllerState.html
		///</summary>
		public static Engine ControllerState(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ControllerState[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the states of several controls for several controller devices.
		///https://reference.wolfram.com/language/ref/ControllerState.html
		///</summary>
		public static Engine ControllerState(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ControllerState[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents a convection term  with convection coefficient  and model variables vars.
		///https://reference.wolfram.com/language/ref/ConvectionPDETerm.html
		///</summary>
		public static Engine ConvectionPDETerm(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConvectionPDETerm[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses model parameters pars.
		///https://reference.wolfram.com/language/ref/ConvectionPDETerm.html
		///</summary>
		public static Engine ConvectionPDETerm(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConvectionPDETerm[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives a list of the convergents corresponding to the continued fraction terms list.
		///https://reference.wolfram.com/language/ref/Convergents.html
		///</summary>
		public static Engine Convergents(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Convergents[" + arg0 + "]", name);
		}

		///<summary>
		///gives the first n convergents for a number x.
		///https://reference.wolfram.com/language/ref/Convergents.html
		///</summary>
		public static Engine Convergents(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Convergents[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a BoundaryMeshRegion representing the convex hull from the points p1, p2, ….
		///https://reference.wolfram.com/language/ref/ConvexHullMesh.html
		///</summary>
		public static Engine ConvexHullMesh(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ConvexHullMesh[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the convex hull of the mesh region mreg.
		///https://reference.wolfram.com/language/ref/ConvexHullMesh.html
		///</summary>
		public static Engine ConvexHullMesh(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConvexHullMesh[" + arg0 + "]", name);
		}

		///<summary>
		///gives the convex hull from the points p1, p2, ….
		///https://reference.wolfram.com/language/ref/ConvexHullRegion.html
		///</summary>
		public static Engine ConvexHullRegion(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ConvexHullRegion[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the convex hull of the region reg.
		///https://reference.wolfram.com/language/ref/ConvexHullRegion.html
		///</summary>
		public static Engine ConvexHullRegion(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConvexHullRegion[" + arg0 + "]", name);
		}

		///<summary>
		///finds values of variables vars that minimize the convex objective function f subject to convex constraints cons.
		///https://reference.wolfram.com/language/ref/ConvexOptimization.html
		///</summary>
		public static Engine ConvexOptimization(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConvexOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///specifies what solution property "prop" should be returned.
		///https://reference.wolfram.com/language/ref/ConvexOptimization.html
		///</summary>
		public static Engine ConvexOptimization(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConvexOptimization[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives True if the polygon poly is convex, and False otherwise.
		///https://reference.wolfram.com/language/ref/ConvexPolygonQ.html
		///</summary>
		public static Engine ConvexPolygonQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConvexPolygonQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives True if the polyhedron poly is convex, and False otherwise.
		///https://reference.wolfram.com/language/ref/ConvexPolyhedronQ.html
		///</summary>
		public static Engine ConvexPolyhedronQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConvexPolyhedronQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives True if reg is a convex region and False otherwise.
		///https://reference.wolfram.com/language/ref/ConvexRegionQ.html
		///</summary>
		public static Engine ConvexRegionQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ConvexRegionQ[" + arg0 + "]", name);
		}

		///<summary>
		///represents a trainable convolutional net layer having n output channels and using kernels of size s to compute the convolution.
		///https://reference.wolfram.com/language/ref/ConvolutionLayer.html
		///</summary>
		public static Engine ConvolutionLayer(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ConvolutionLayer[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a layer performing one-dimensional convolutions with kernels of size s.
		///https://reference.wolfram.com/language/ref/ConvolutionLayer.html
		///</summary>
		public static Engine ConvolutionLayer(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ConvolutionLayer[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///includes options for padding and other parameters.
		///https://reference.wolfram.com/language/ref/ConvolutionLayer.html
		///</summary>
		public static Engine ConvolutionLayer(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ConvolutionLayer[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the convolution with respect to x of the expressions f and g.
		///https://reference.wolfram.com/language/ref/Convolve.html
		///</summary>
		public static Engine Convolve(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Convolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the multidimensional convolution.
		///https://reference.wolfram.com/language/ref/Convolve.html
		///</summary>
		public static Engine Convolve(this Engine en, string arg0, string arg1, List<string> arg2, List<string> arg3, string? name = null)
		{
				return en.Execute("Convolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
		}

		///<summary>
		///represents the sporadic simple Conway group Co1.
		///https://reference.wolfram.com/language/ref/ConwayGroupCo1.html
		///</summary>
		public static Engine ConwayGroupCo1(this Engine en, string? name = null)
		{
				return en.Execute("ConwayGroupCo1[]", name);
		}

		///<summary>
		///represents the sporadic simple Conway group Co2.
		///https://reference.wolfram.com/language/ref/ConwayGroupCo2.html
		///</summary>
		public static Engine ConwayGroupCo2(this Engine en, string? name = null)
		{
				return en.Execute("ConwayGroupCo2[]", name);
		}

		///<summary>
		///represents the sporadic simple Conway group Co3.
		///https://reference.wolfram.com/language/ref/ConwayGroupCo3.html
		///</summary>
		public static Engine ConwayGroupCo3(this Engine en, string? name = null)
		{
				return en.Execute("ConwayGroupCo3[]", name);
		}

		///<summary>
		///gives the corners {{xmin,ymin,…},{xmax,ymax,…}} of the bounding box of the region defined by coords.
		///https://reference.wolfram.com/language/ref/CoordinateBoundingBox.html
		///</summary>
		public static Engine CoordinateBoundingBox(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CoordinateBoundingBox[" + arg0 + "]", name);
		}

		///<summary>
		///pads the region by δ in each direction.
		///https://reference.wolfram.com/language/ref/CoordinateBoundingBox.html
		///</summary>
		public static Engine CoordinateBoundingBox(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CoordinateBoundingBox[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///pads by p1, p2, … in successive dimensions.
		///https://reference.wolfram.com/language/ref/CoordinateBoundingBox.html
		///</summary>
		public static Engine CoordinateBoundingBox(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CoordinateBoundingBox[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives {{xmin-p1min,ymin-p2min,…},{xmax+p1max,ymax+p2max,…},…}
		///https://reference.wolfram.com/language/ref/CoordinateBoundingBox.html
		///</summary>
		public static Engine CoordinateBoundingBox(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CoordinateBoundingBox[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///generates an array of {x,y,…} coordinates with integer steps in each dimension.
		///https://reference.wolfram.com/language/ref/CoordinateBoundingBoxArray.html
		///</summary>
		public static Engine CoordinateBoundingBoxArray(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CoordinateBoundingBoxArray[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///uses step d in each dimension.
		///https://reference.wolfram.com/language/ref/CoordinateBoundingBoxArray.html
		///</summary>
		public static Engine CoordinateBoundingBoxArray(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CoordinateBoundingBoxArray[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///specifies offsets to use for each coordinate point.
		///https://reference.wolfram.com/language/ref/CoordinateBoundingBoxArray.html
		///</summary>
		public static Engine CoordinateBoundingBoxArray(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CoordinateBoundingBoxArray[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///expands the array by k elements in every direction.
		///https://reference.wolfram.com/language/ref/CoordinateBoundingBoxArray.html
		///</summary>
		public static Engine CoordinateBoundingBoxArray(this Engine en, List<string> arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CoordinateBoundingBoxArray[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives a list {{xmin,xmax},{ymin,ymax},…} of the bounds in each dimension of the region defined by coords.
		///https://reference.wolfram.com/language/ref/CoordinateBounds.html
		///</summary>
		public static Engine CoordinateBounds(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CoordinateBounds[" + arg0 + "]", name);
		}

		///<summary>
		///pads the ranges of coordinates by ±δ in each dimension.
		///https://reference.wolfram.com/language/ref/CoordinateBounds.html
		///</summary>
		public static Engine CoordinateBounds(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CoordinateBounds[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///pads by p1, p2, … in successive dimensions.
		///https://reference.wolfram.com/language/ref/CoordinateBounds.html
		///</summary>
		public static Engine CoordinateBounds(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CoordinateBounds[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives {{xmin-p1min,xmax+p1max},{ymin-p2min,ymax+p2max},…}
		///https://reference.wolfram.com/language/ref/CoordinateBounds.html
		///</summary>
		public static Engine CoordinateBounds(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CoordinateBounds[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///generates an array of {x,y,…} coordinates with integer steps in each dimension.
		///https://reference.wolfram.com/language/ref/CoordinateBoundsArray.html
		///</summary>
		public static Engine CoordinateBoundsArray(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CoordinateBoundsArray[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///uses step d in each dimension.
		///https://reference.wolfram.com/language/ref/CoordinateBoundsArray.html
		///</summary>
		public static Engine CoordinateBoundsArray(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CoordinateBoundsArray[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///specifies offsets to use for each coordinate point.
		///https://reference.wolfram.com/language/ref/CoordinateBoundsArray.html
		///</summary>
		public static Engine CoordinateBoundsArray(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CoordinateBoundsArray[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///expands the array by k elements in every direction.
		///https://reference.wolfram.com/language/ref/CoordinateBoundsArray.html
		///</summary>
		public static Engine CoordinateBoundsArray(this Engine en, List<string> arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CoordinateBoundsArray[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for chart.
		///https://reference.wolfram.com/language/ref/CoordinateChartData.html
		///</summary>
		public static Engine CoordinateChartData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CoordinateChartData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for chart evaluated at the point {x1,x2,…,xn}.
		///https://reference.wolfram.com/language/ref/CoordinateChartData.html
		///</summary>
		public static Engine CoordinateChartData(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CoordinateChartData[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///performs the coordinate transformation t on the point pt.
		///https://reference.wolfram.com/language/ref/CoordinateTransform.html
		///</summary>
		public static Engine CoordinateTransform(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CoordinateTransform[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///transforms several points.
		///https://reference.wolfram.com/language/ref/CoordinateTransform.html
		///</summary>
		public static Engine CoordinateTransform(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CoordinateTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the coordinate transformation t.
		///https://reference.wolfram.com/language/ref/CoordinateTransformData.html
		///</summary>
		public static Engine CoordinateTransformData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CoordinateTransformData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the value of the property evaluated at the point {x1,x2,…,xn}.
		///https://reference.wolfram.com/language/ref/CoordinateTransformData.html
		///</summary>
		public static Engine CoordinateTransformData(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("CoordinateTransformData[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///tests whether the points p1,p2,p3,p4,…,pn are coplanar.
		///https://reference.wolfram.com/language/ref/CoplanarPoints.html
		///</summary>
		public static Engine CoplanarPoints(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CoplanarPoints[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///yields True if n1 and n2 are relatively prime, and yields False otherwise.
		///https://reference.wolfram.com/language/ref/CoprimeQ.html
		///</summary>
		public static Engine CoprimeQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CoprimeQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields True if all pairs of the ni are relatively prime, and yields False otherwise.
		///https://reference.wolfram.com/language/ref/CoprimeQ.html
		///</summary>
		public static Engine CoprimeQ(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CoprimeQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///displays as .
		///https://reference.wolfram.com/language/ref/Coproduct.html
		///</summary>
		public static Engine Coproduct(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Coproduct[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a copula distribution with kernel distribution ker and marginal distributions dist1, dist2, … .
		///https://reference.wolfram.com/language/ref/CopulaDistribution.html
		///</summary>
		public static Engine CopulaDistribution(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CopulaDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///creates a copy of a databin.
		///https://reference.wolfram.com/language/ref/CopyDatabin.html
		///</summary>
		public static Engine CopyDatabin(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CopyDatabin[" + arg0 + "]", name);
		}

		///<summary>
		///creates a copy with the specified options.
		///https://reference.wolfram.com/language/ref/CopyDatabin.html
		///</summary>
		public static Engine CopyDatabin(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CopyDatabin[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///copies the directory dir1 to dir2.
		///https://reference.wolfram.com/language/ref/CopyDirectory.html
		///</summary>
		public static Engine CopyDirectory(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CopyDirectory[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///copies from the local, remote or cloud file file1 to the local, remote or cloud file file2.
		///https://reference.wolfram.com/language/ref/CopyFile.html
		///</summary>
		public static Engine CopyFile(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CopyFile[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///replaces the contents of the clipboard with expr.
		///https://reference.wolfram.com/language/ref/CopyToClipboard.html
		///</summary>
		public static Engine CopyToClipboard(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CopyToClipboard[" + arg0 + "]", name);
		}

		///<summary>
		///yields the core-nilpotent decomposition of a square matrix m.
		///https://reference.wolfram.com/language/ref/CoreNilpotentDecomposition.html
		///</summary>
		public static Engine CoreNilpotentDecomposition(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CoreNilpotentDecomposition[" + arg0 + "]", name);
		}

		///<summary>
		///computes a measure for the presence of a corner for each pixel in image and returns the result as an intensity image.
		///https://reference.wolfram.com/language/ref/CornerFilter.html
		///</summary>
		public static Engine CornerFilter(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CornerFilter[" + arg0 + "]", name);
		}

		///<summary>
		///detects corners at a pixel range r.
		///https://reference.wolfram.com/language/ref/CornerFilter.html
		///</summary>
		public static Engine CornerFilter(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CornerFilter[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the correlation between the vectors v1 and v2.
		///https://reference.wolfram.com/language/ref/Correlation.html
		///</summary>
		public static Engine Correlation(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Correlation[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the sample correlation matrix for observations in matrix m.
		///https://reference.wolfram.com/language/ref/Correlation.html
		///</summary>
		public static Engine Correlation(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Correlation[" + arg0 + "]", name);
		}

		///<summary>
		///gives the (i,j) correlation for the multivariate symbolic distribution dist.
		///https://reference.wolfram.com/language/ref/Correlation.html
		///</summary>
		public static Engine Correlation(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Correlation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the correlation coefficient distance between vectors u and v.
		///https://reference.wolfram.com/language/ref/CorrelationDistance.html
		///</summary>
		public static Engine CorrelationDistance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CorrelationDistance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///estimates the correlation function at lags hspec from data.
		///https://reference.wolfram.com/language/ref/CorrelationFunction.html
		///</summary>
		public static Engine CorrelationFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CorrelationFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the correlation function at times s and t for the random process proc.
		///https://reference.wolfram.com/language/ref/CorrelationFunction.html
		///</summary>
		public static Engine CorrelationFunction(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CorrelationFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///tests whether the correlation coefficient for a bivariate population is zero.
		///https://reference.wolfram.com/language/ref/CorrelationTest.html
		///</summary>
		public static Engine CorrelationTest(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CorrelationTest[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///tests whether the correlation coefficient is ρ0.
		///https://reference.wolfram.com/language/ref/CorrelationTest.html
		///</summary>
		public static Engine CorrelationTest(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("CorrelationTest[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///tests whether the correlation coefficients for two populations are equal.
		///https://reference.wolfram.com/language/ref/CorrelationTest.html
		///</summary>
		public static Engine CorrelationTest(this Engine en, List<string> arg0, List<string> arg1, List<string> arg2, List<string> arg3, string? name = null)
		{
				return en.Execute("CorrelationTest[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
		}

		///<summary>
		///returns the value of "property".
		///https://reference.wolfram.com/language/ref/CorrelationTest.html
		///</summary>
		public static Engine CorrelationTest(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CorrelationTest[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the cosine of z.
		///https://reference.wolfram.com/language/ref/Cos.html
		///</summary>
		public static Engine Cos(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cos[" + arg0 + "]", name);
		}

		///<summary>
		///gives the hyperbolic cosine of z.
		///https://reference.wolfram.com/language/ref/Cosh.html
		///</summary>
		public static Engine Cosh(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cosh[" + arg0 + "]", name);
		}

		///<summary>
		///gives the hyperbolic cosine integral .
		///https://reference.wolfram.com/language/ref/CoshIntegral.html
		///</summary>
		public static Engine CoshIntegral(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CoshIntegral[" + arg0 + "]", name);
		}

		///<summary>
		///gives the angular cosine distance between vectors u and v.
		///https://reference.wolfram.com/language/ref/CosineDistance.html
		///</summary>
		public static Engine CosineDistance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CosineDistance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a cosine window function of x.
		///https://reference.wolfram.com/language/ref/CosineWindow.html
		///</summary>
		public static Engine CosineWindow(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CosineWindow[" + arg0 + "]", name);
		}

		///<summary>
		///uses the exponent α.
		///https://reference.wolfram.com/language/ref/CosineWindow.html
		///</summary>
		public static Engine CosineWindow(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CosineWindow[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the cosine integral function .
		///https://reference.wolfram.com/language/ref/CosIntegral.html
		///</summary>
		public static Engine CosIntegral(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CosIntegral[" + arg0 + "]", name);
		}

		///<summary>
		///gives the cotangent of z.
		///https://reference.wolfram.com/language/ref/Cot.html
		///</summary>
		public static Engine Cot(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cot[" + arg0 + "]", name);
		}

		///<summary>
		///gives the hyperbolic cotangent of z.
		///https://reference.wolfram.com/language/ref/Coth.html
		///</summary>
		public static Engine Coth(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Coth[" + arg0 + "]", name);
		}

		///<summary>
		///gives the regular Coulomb wavefunction .
		///https://reference.wolfram.com/language/ref/CoulombF.html
		///</summary>
		public static Engine CoulombF(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CoulombF[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the irregular Coulomb wavefunction .
		///https://reference.wolfram.com/language/ref/CoulombG.html
		///</summary>
		public static Engine CoulombG(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CoulombG[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the outgoing irregular Coulomb wavefunction .
		///https://reference.wolfram.com/language/ref/CoulombH1.html
		///</summary>
		public static Engine CoulombH1(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CoulombH1[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the incoming irregular Coulomb wavefunction .
		///https://reference.wolfram.com/language/ref/CoulombH2.html
		///</summary>
		public static Engine CoulombH2(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CoulombH2[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the number of elements in list that match pattern.
		///https://reference.wolfram.com/language/ref/Count.html
		///</summary>
		public static Engine Count(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Count[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the total number of subexpressions matching pattern that appear at the levels in expr specified by levelspec.
		///https://reference.wolfram.com/language/ref/Count.html
		///</summary>
		public static Engine Count(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Count[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents an operator form of Count that can be applied to an expression.
		///https://reference.wolfram.com/language/ref/Count.html
		///</summary>
		public static Engine Count(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Count[" + arg0 + "]", name);
		}

		///<summary>
		///gives the number of distinct elements that appear in list.
		///https://reference.wolfram.com/language/ref/CountDistinct.html
		///</summary>
		public static Engine CountDistinct(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CountDistinct[" + arg0 + "]", name);
		}

		///<summary>
		///gives the number of distinct values of f[ei] that occur.
		///https://reference.wolfram.com/language/ref/CountDistinctBy.html
		///</summary>
		public static Engine CountDistinctBy(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CountDistinctBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an operator form of CountDistinctBy that can be applied to an expression.
		///https://reference.wolfram.com/language/ref/CountDistinctBy.html
		///</summary>
		public static Engine CountDistinctBy(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CountDistinctBy[" + arg0 + "]", name);
		}

		///<summary>
		///gives the number of real roots of the univariate function f in x.
		///https://reference.wolfram.com/language/ref/CountRoots.html
		///</summary>
		public static Engine CountRoots(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CountRoots[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the number of roots between a and b.
		///https://reference.wolfram.com/language/ref/CountRoots.html
		///</summary>
		public static Engine CountRoots(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CountRoots[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the country, country-like entity, or group of countries specified by "tag".
		///https://reference.wolfram.com/language/ref/CountryData.html
		///</summary>
		public static Engine CountryData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CountryData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives time series for certain economic and other properties.
		///https://reference.wolfram.com/language/ref/CountryData.html
		///</summary>
		public static Engine CountryData(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CountryData[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives an association whose keys are the distinct elements of list, and whose values give the number of times those elements appear in list.
		///https://reference.wolfram.com/language/ref/Counts.html
		///</summary>
		public static Engine Counts(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Counts[" + arg0 + "]", name);
		}

		///<summary>
		///gives an association whose keys are the distinct values of the f[ei], and whose values give the number of times these f[ei] values appear.
		///https://reference.wolfram.com/language/ref/CountsBy.html
		///</summary>
		public static Engine CountsBy(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CountsBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an operator form of CountsBy that can be applied to an expression.
		///https://reference.wolfram.com/language/ref/CountsBy.html
		///</summary>
		public static Engine CountsBy(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CountsBy[" + arg0 + "]", name);
		}

		///<summary>
		///gives the covariance between the vectors v1 and v2.
		///https://reference.wolfram.com/language/ref/Covariance.html
		///</summary>
		public static Engine Covariance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Covariance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the sample covariance matrix for observations in matrix m.
		///https://reference.wolfram.com/language/ref/Covariance.html
		///</summary>
		public static Engine Covariance(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Covariance[" + arg0 + "]", name);
		}

		///<summary>
		///gives the (i,j) covariance for the multivariate symbolic distribution dist.
		///https://reference.wolfram.com/language/ref/Covariance.html
		///</summary>
		public static Engine Covariance(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Covariance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///estimates the covariance function at lags hspec from data.
		///https://reference.wolfram.com/language/ref/CovarianceFunction.html
		///</summary>
		public static Engine CovarianceFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CovarianceFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the covariance function at times s and t for the random process proc.
		///https://reference.wolfram.com/language/ref/CovarianceFunction.html
		///</summary>
		public static Engine CovarianceFunction(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CovarianceFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represent an m-phase Coxian distribution with phase probabilities αi and rates λi.
		///https://reference.wolfram.com/language/ref/CoxianDistribution.html
		///</summary>
		public static Engine CoxianDistribution(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CoxianDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents a Cox–Ingersoll–Ross process with long‐term mean μ, volatility σ, speed of adjustment θ, and initial condition x0.
		///https://reference.wolfram.com/language/ref/CoxIngersollRossProcess.html
		///</summary>
		public static Engine CoxIngersollRossProcess(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CoxIngersollRossProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents the symbolic proportional hazards model obtained from CoxModelFit.
		///https://reference.wolfram.com/language/ref/CoxModel.html
		///</summary>
		public static Engine CoxModel(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CoxModel[" + arg0 + "]", name);
		}

		///<summary>
		///constructs a model of the baseline hazard  for events times ei.
		///https://reference.wolfram.com/language/ref/CoxModelFit.html
		///</summary>
		public static Engine CoxModelFit(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CoxModelFit[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///constructs a Cox model of the form , where the fi depend on the xk.
		///https://reference.wolfram.com/language/ref/CoxModelFit.html
		///</summary>
		public static Engine CoxModelFit(this Engine en, List<string> arg0, string arg1, List<string> arg2, List<string> arg3, List<string> arg4, List<string> arg5, string? name = null)
		{
				return en.Execute("CoxModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + "{" + string.Join(',', arg4) + "}" + ", " + "{" + string.Join(',', arg5) + "}" + "]", name);
		}

		///<summary>
		///tests whether data is normally distributed using the Cramér–von Mises test.
		///https://reference.wolfram.com/language/ref/CramerVonMisesTest.html
		///</summary>
		public static Engine CramerVonMisesTest(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CramerVonMisesTest[" + arg0 + "]", name);
		}

		///<summary>
		///tests whether data is distributed according to dist using the Cramér–von Mises test.
		///https://reference.wolfram.com/language/ref/CramerVonMisesTest.html
		///</summary>
		public static Engine CramerVonMisesTest(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CramerVonMisesTest[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns the value of "property".
		///https://reference.wolfram.com/language/ref/CramerVonMisesTest.html
		///</summary>
		public static Engine CramerVonMisesTest(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CramerVonMisesTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///creates a compressed archive in the current directory from source.
		///https://reference.wolfram.com/language/ref/CreateArchive.html
		///</summary>
		public static Engine CreateArchive(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateArchive[" + arg0 + "]", name);
		}

		///<summary>
		///creates a compressed archive in the directory or file specified by path.
		///https://reference.wolfram.com/language/ref/CreateArchive.html
		///</summary>
		public static Engine CreateArchive(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateArchive[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a new channel for channel communication, with a generated name.
		///https://reference.wolfram.com/language/ref/CreateChannel.html
		///</summary>
		public static Engine CreateChannel(this Engine en, string? name = null)
		{
				return en.Execute("CreateChannel[]", name);
		}

		///<summary>
		///creates a channel with the specified path relative to the home area of the currently authenticated user.
		///https://reference.wolfram.com/language/ref/CreateChannel.html
		///</summary>
		public static Engine CreateChannel(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateChannel[" + arg0 + "]", name);
		}

		///<summary>
		///creates a new anonymous cloud expression that stores the specified initial value.
		///https://reference.wolfram.com/language/ref/CreateCloudExpression.html
		///</summary>
		public static Engine CreateCloudExpression(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateCloudExpression[" + arg0 + "]", name);
		}

		///<summary>
		///creates a new cloud expression with the specified name.
		///https://reference.wolfram.com/language/ref/CreateCloudExpression.html
		///</summary>
		public static Engine CreateCloudExpression(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateCloudExpression[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a compiler environment that can be used in FunctionCompile and related functions.
		///https://reference.wolfram.com/language/ref/CreateCompilerEnvironment.html
		///</summary>
		public static Engine CreateCompilerEnvironment(this Engine en, string? name = null)
		{
				return en.Execute("CreateCompilerEnvironment[]", name);
		}

		///<summary>
		///creates a databin in the Wolfram Data Drop and returns the corresponding Databin object.
		///https://reference.wolfram.com/language/ref/CreateDatabin.html
		///</summary>
		public static Engine CreateDatabin(this Engine en, string? name = null)
		{
				return en.Execute("CreateDatabin[]", name);
		}

		///<summary>
		///creates a databin with the specified options.
		///https://reference.wolfram.com/language/ref/CreateDatabin.html
		///</summary>
		public static Engine CreateDatabin(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateDatabin[" + arg0 + "]", name);
		}

		///<summary>
		///creates a data structure with the specified type.
		///https://reference.wolfram.com/language/ref/CreateDataStructure.html
		///</summary>
		public static Engine CreateDataStructure(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CreateDataStructure[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///creates a SystemModel generating a signal of values vi.
		///https://reference.wolfram.com/language/ref/CreateDataSystemModel.html
		///</summary>
		public static Engine CreateDataSystemModel(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CreateDataSystemModel[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///creates a model for the TimeSeries or InterpolatingFunction obj.
		///https://reference.wolfram.com/language/ref/CreateDataSystemModel.html
		///</summary>
		public static Engine CreateDataSystemModel(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateDataSystemModel[" + arg0 + "]", name);
		}

		///<summary>
		///creates a model with samples from the function fun between tmin and tmax.
		///https://reference.wolfram.com/language/ref/CreateDataSystemModel.html
		///</summary>
		public static Engine CreateDataSystemModel(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CreateDataSystemModel[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///creates a model with data specification "dspec".
		///https://reference.wolfram.com/language/ref/CreateDataSystemModel.html
		///</summary>
		public static Engine CreateDataSystemModel(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateDataSystemModel[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a dialog notebook containing expr and opens it in the front end.
		///https://reference.wolfram.com/language/ref/CreateDialog.html
		///</summary>
		public static Engine CreateDialog(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateDialog[" + arg0 + "]", name);
		}

		///<summary>
		///replaces the notebook represented by the notebook object obj with the one obtained from expr.
		///https://reference.wolfram.com/language/ref/CreateDialog.html
		///</summary>
		public static Engine CreateDialog(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateDialog[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a directory with name dir.
		///https://reference.wolfram.com/language/ref/CreateDirectory.html
		///</summary>
		public static Engine CreateDirectory(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateDirectory[" + arg0 + "]", name);
		}

		///<summary>
		///creates a directory in the default area for temporary directories on your computer system.
		///https://reference.wolfram.com/language/ref/CreateDirectory.html
		///</summary>
		public static Engine CreateDirectory(this Engine en, string? name = null)
		{
				return en.Execute("CreateDirectory[]", name);
		}

		///<summary>
		///creates an empty document notebook and opens it in the front end.
		///https://reference.wolfram.com/language/ref/CreateDocument.html
		///</summary>
		public static Engine CreateDocument(this Engine en, string? name = null)
		{
				return en.Execute("CreateDocument[]", name);
		}

		///<summary>
		///creates and opens a document notebook containing the expression expr.
		///https://reference.wolfram.com/language/ref/CreateDocument.html
		///</summary>
		public static Engine CreateDocument(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateDocument[" + arg0 + "]", name);
		}

		///<summary>
		///creates and opens a document notebook consisting of a sequence of cells containing the expri.
		///https://reference.wolfram.com/language/ref/CreateDocument.html
		///</summary>
		public static Engine CreateDocument(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CreateDocument[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///replaces the notebook represented by the notebook object obj with the one obtained from expr.
		///https://reference.wolfram.com/language/ref/CreateDocument.html
		///</summary>
		public static Engine CreateDocument(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateDocument[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a file with name file.
		///https://reference.wolfram.com/language/ref/CreateFile.html
		///</summary>
		public static Engine CreateFile(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateFile[" + arg0 + "]", name);
		}

		///<summary>
		///creates a file in the default area for temporary files on your computer system.
		///https://reference.wolfram.com/language/ref/CreateFile.html
		///</summary>
		public static Engine CreateFile(this Engine en, string? name = null)
		{
				return en.Execute("CreateFile[]", name);
		}

		///<summary>
		///creates an on-demand license entitlement using settings.
		///https://reference.wolfram.com/language/ref/CreateLicenseEntitlement.html
		///</summary>
		public static Engine CreateLicenseEntitlement(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateLicenseEntitlement[" + arg0 + "]", name);
		}

		///<summary>
		///creates an on-demand license entitlement using the default settings.
		///https://reference.wolfram.com/language/ref/CreateLicenseEntitlement.html
		///</summary>
		public static Engine CreateLicenseEntitlement(this Engine en, string? name = null)
		{
				return en.Execute("CreateLicenseEntitlement[]", name);
		}

		///<summary>
		///creates a managed library expression by applying f to a positive integer ID associated with a registered manager with name mname.
		///https://reference.wolfram.com/language/ref/CreateManagedLibraryExpression.html
		///</summary>
		public static Engine CreateManagedLibraryExpression(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateManagedLibraryExpression[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a generic empty notebook and opens it in the front end.
		///https://reference.wolfram.com/language/ref/CreateNotebook.html
		///</summary>
		public static Engine CreateNotebook(this Engine en, string? name = null)
		{
				return en.Execute("CreateNotebook[]", name);
		}

		///<summary>
		///creates an empty notebook of the specified type and opens it in the front end.
		///https://reference.wolfram.com/language/ref/CreateNotebook.html
		///</summary>
		public static Engine CreateNotebook(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateNotebook[" + arg0 + "]", name);
		}

		///<summary>
		///replaces the notebook represented by the notebook object obj by a version converted to be of the specified type.
		///https://reference.wolfram.com/language/ref/CreateNotebook.html
		///</summary>
		public static Engine CreateNotebook(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateNotebook[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a paclet archive file from source.
		///https://reference.wolfram.com/language/ref/CreatePacletArchive.html
		///</summary>
		public static Engine CreatePacletArchive(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreatePacletArchive[" + arg0 + "]", name);
		}

		///<summary>
		///creates a paclet archive file from source and places it in destdir.
		///https://reference.wolfram.com/language/ref/CreatePacletArchive.html
		///</summary>
		public static Engine CreatePacletArchive(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreatePacletArchive[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a palette notebook containing expr, and opens it in the front end.
		///https://reference.wolfram.com/language/ref/CreatePalette.html
		///</summary>
		public static Engine CreatePalette(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreatePalette[" + arg0 + "]", name);
		}

		///<summary>
		///creates and opens a palette notebook consisting of a sequence of cells containing the expri.
		///https://reference.wolfram.com/language/ref/CreatePalette.html
		///</summary>
		public static Engine CreatePalette(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CreatePalette[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///replaces the notebook represented by the notebook object obj with the one obtained from expr.
		///https://reference.wolfram.com/language/ref/CreatePalette.html
		///</summary>
		public static Engine CreatePalette(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreatePalette[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a permissions group with the specified name.
		///https://reference.wolfram.com/language/ref/CreatePermissionsGroup.html
		///</summary>
		public static Engine CreatePermissionsGroup(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreatePermissionsGroup[" + arg0 + "]", name);
		}

		///<summary>
		///creates a permissions group consisting of the specified initial users.
		///https://reference.wolfram.com/language/ref/CreatePermissionsGroup.html
		///</summary>
		public static Engine CreatePermissionsGroup(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CreatePermissionsGroup[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///creates a search index from all files in the directory dir and its subdirectories.
		///https://reference.wolfram.com/language/ref/CreateSearchIndex.html
		///</summary>
		public static Engine CreateSearchIndex(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateSearchIndex[" + arg0 + "]", name);
		}

		///<summary>
		///creates a search index from all sources sourcei.
		///https://reference.wolfram.com/language/ref/CreateSearchIndex.html
		///</summary>
		public static Engine CreateSearchIndex(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CreateSearchIndex[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the search index the specified name.
		///https://reference.wolfram.com/language/ref/CreateSearchIndex.html
		///</summary>
		public static Engine CreateSearchIndex(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateSearchIndex[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates an empty search index, which can be added to with AddToSearchIndex.
		///https://reference.wolfram.com/language/ref/CreateSearchIndex.html
		///</summary>
		public static Engine CreateSearchIndex(this Engine en, string? name = null)
		{
				return en.Execute("CreateSearchIndex[]", name);
		}

		///<summary>
		///creates a Modelica SystemModel from the systems model sys.
		///https://reference.wolfram.com/language/ref/CreateSystemModel.html
		///</summary>
		public static Engine CreateSystemModel(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateSystemModel[" + arg0 + "]", name);
		}

		///<summary>
		///creates a model for the system equations eqns with independent variable t.
		///https://reference.wolfram.com/language/ref/CreateSystemModel.html
		///</summary>
		public static Engine CreateSystemModel(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateSystemModel[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates an instance of a type in compiled code.
		///https://reference.wolfram.com/language/ref/CreateTypeInstance.html
		///</summary>
		public static Engine CreateTypeInstance(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("CreateTypeInstance[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///creates a random, universally unique UUID string.
		///https://reference.wolfram.com/language/ref/CreateUUID.html
		///</summary>
		public static Engine CreateUUID(this Engine en, string? name = null)
		{
				return en.Execute("CreateUUID[]", name);
		}

		///<summary>
		///appends a UUID string to the specified base string.
		///https://reference.wolfram.com/language/ref/CreateUUID.html
		///</summary>
		public static Engine CreateUUID(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateUUID[" + arg0 + "]", name);
		}

		///<summary>
		///creates an empty window in the front end.
		///https://reference.wolfram.com/language/ref/CreateWindow.html
		///</summary>
		public static Engine CreateWindow(this Engine en, string? name = null)
		{
				return en.Execute("CreateWindow[]", name);
		}

		///<summary>
		///creates a window displaying the notebook expression expr, and opens it in the front end.
		///https://reference.wolfram.com/language/ref/CreateWindow.html
		///</summary>
		public static Engine CreateWindow(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CreateWindow[" + arg0 + "]", name);
		}

		///<summary>
		///replaces the notebook represented by the notebook object obj with the one obtained from expr.
		///https://reference.wolfram.com/language/ref/CreateWindow.html
		///</summary>
		public static Engine CreateWindow(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CreateWindow[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the criticality failure importances for all components in the ReliabilityDistribution rdist at time t.
		///https://reference.wolfram.com/language/ref/CriticalityFailureImportance.html
		///</summary>
		public static Engine CriticalityFailureImportance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CriticalityFailureImportance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the criticality success importances for all components in the ReliabilityDistribution rdist at time t.
		///https://reference.wolfram.com/language/ref/CriticalitySuccessImportance.html
		///</summary>
		public static Engine CriticalitySuccessImportance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CriticalitySuccessImportance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///locks the variable var with respect to parallel computation, evaluates expr, then releases var.
		///https://reference.wolfram.com/language/ref/CriticalSection.html
		///</summary>
		public static Engine CriticalSection(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CriticalSection[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///locks all variables vari simultaneously.
		///https://reference.wolfram.com/language/ref/CriticalSection.html
		///</summary>
		public static Engine CriticalSection(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CriticalSection[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the vector cross product of a and b.
		///https://reference.wolfram.com/language/ref/Cross.html
		///</summary>
		public static Engine Cross(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Cross[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a net layer that computes the cross-entropy loss by comparing input class probability vectors with indices representing the target class.
		///https://reference.wolfram.com/language/ref/CrossEntropyLossLayer.html
		///</summary>
		public static Engine CrossEntropyLossLayer(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CrossEntropyLossLayer[" + arg0 + "]", name);
		}

		///<summary>
		///gives a count of the number of times a ray starting from the point p crosses the closed curve contour.
		///https://reference.wolfram.com/language/ref/CrossingCount.html
		///</summary>
		public static Engine CrossingCount(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CrossingCount[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a binary image in which white pixels correspond to the zero crossings in image.
		///https://reference.wolfram.com/language/ref/CrossingDetect.html
		///</summary>
		public static Engine CrossingDetect(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CrossingDetect[" + arg0 + "]", name);
		}

		///<summary>
		///treats values in image that are smaller in absolute value than delta as zero.
		///https://reference.wolfram.com/language/ref/CrossingDetect.html
		///</summary>
		public static Engine CrossingDetect(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CrossingDetect[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a Polygon representing all points for which a ray from the point in any direction in the plane crosses the line segments {p1,p2},…,{pn-1,pn},{pn,p1} an odd number of times.
		///https://reference.wolfram.com/language/ref/CrossingPolygon.html
		///</summary>
		public static Engine CrossingPolygon(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CrossingPolygon[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives a Polygon from the line segments {p11,p12},…,{p21,p22},….
		///https://reference.wolfram.com/language/ref/CrossingPolygon.html
		///</summary>
		public static Engine CrossingPolygon(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CrossingPolygon[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives a matrix whose elements are 1 in a centered cross-shaped region that extends r positions along each index direction, and are 0 otherwise.
		///https://reference.wolfram.com/language/ref/CrossMatrix.html
		///</summary>
		public static Engine CrossMatrix(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CrossMatrix[" + arg0 + "]", name);
		}

		///<summary>
		///gives a w×w matrix containing a cross-shaped region of 1s.
		///https://reference.wolfram.com/language/ref/CrossMatrix.html
		///</summary>
		public static Engine CrossMatrix(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CrossMatrix[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields an array whose elements are 1 in a centered cross-shaped region that extends ri positions in the i index direction.
		///https://reference.wolfram.com/language/ref/CrossMatrix.html
		///</summary>
		public static Engine CrossMatrix(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("CrossMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the cosecant of z.
		///https://reference.wolfram.com/language/ref/Csc.html
		///</summary>
		public static Engine Csc(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Csc[" + arg0 + "]", name);
		}

		///<summary>
		///gives the hyperbolic cosecant of z.
		///https://reference.wolfram.com/language/ref/Csch.html
		///</summary>
		public static Engine Csch(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Csch[" + arg0 + "]", name);
		}

		///<summary>
		///represents the solid region corresponding to the Boolean combination "op" of regions reg1,reg2,….
		///https://reference.wolfram.com/language/ref/CSGRegion.html
		///</summary>
		public static Engine CSGRegion(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CSGRegion[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///yields True if the region reg is a valid CSGRegion object and False otherwise.
		///https://reference.wolfram.com/language/ref/CSGRegionQ.html
		///</summary>
		public static Engine CSGRegionQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CSGRegionQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives the tree expression representing the CSG region reg.
		///https://reference.wolfram.com/language/ref/CSGRegionTree.html
		///</summary>
		public static Engine CSGRegionTree(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CSGRegionTree[" + arg0 + "]", name);
		}

		///<summary>
		///represents a net layer that computes the connectionist temporal classification loss by comparing a sequence of class probability vectors with a sequence of indices representing the target classes.
		///https://reference.wolfram.com/language/ref/CTCLossLayer.html
		///</summary>
		public static Engine CTCLossLayer(this Engine en, string? name = null)
		{
				return en.Execute("CTCLossLayer[]", name);
		}

		///<summary>
		///represents a regular cube centered at the origin with unit edge length.
		///https://reference.wolfram.com/language/ref/Cube.html
		///</summary>
		public static Engine Cube(this Engine en, string? name = null)
		{
				return en.Execute("Cube[]", name);
		}

		///<summary>
		///represents a cube with edge length l.
		///https://reference.wolfram.com/language/ref/Cube.html
		///</summary>
		public static Engine Cube(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cube[" + arg0 + "]", name);
		}

		///<summary>
		///represents a cube rotated by an angle θ with respect to the z axis and angle ϕ with respect to the y axis.
		///https://reference.wolfram.com/language/ref/Cube.html
		///</summary>
		public static Engine Cube(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Cube[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the real-valued cube root of x.
		///https://reference.wolfram.com/language/ref/CubeRoot.html
		///</summary>
		public static Engine CubeRoot(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CubeRoot[" + arg0 + "]", name);
		}

		///<summary>
		///represents a unit hypercube with its lower corner at pmin.
		///https://reference.wolfram.com/language/ref/Cuboid.html
		///</summary>
		public static Engine Cuboid(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cuboid[" + arg0 + "]", name);
		}

		///<summary>
		///represents an axis-aligned filled cuboid with lower corner pmin and upper corner pmax.
		///https://reference.wolfram.com/language/ref/Cuboid.html
		///</summary>
		public static Engine Cuboid(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Cuboid[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the r cumulant of the distribution dist.
		///https://reference.wolfram.com/language/ref/Cumulant.html
		///</summary>
		public static Engine Cumulant(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Cumulant[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the r formal cumulant.
		///https://reference.wolfram.com/language/ref/Cumulant.html
		///</summary>
		public static Engine Cumulant(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Cumulant[" + arg0 + "]", name);
		}

		///<summary>
		///gives the cumulant-generating function for the distribution dist as a function of the variable t.
		///https://reference.wolfram.com/language/ref/CumulantGeneratingFunction.html
		///</summary>
		public static Engine CumulantGeneratingFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CumulantGeneratingFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the cumulant-generating function for the multivariate distribution dist as a function of the variables t1, t2, … .
		///https://reference.wolfram.com/language/ref/CumulantGeneratingFunction.html
		///</summary>
		public static Engine CumulantGeneratingFunction(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CumulantGeneratingFunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///plots the cumulative impact of the value of each feature in data on the result of model.
		///https://reference.wolfram.com/language/ref/CumulativeFeatureImpactPlot.html
		///</summary>
		public static Engine CumulativeFeatureImpactPlot(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CumulativeFeatureImpactPlot[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///estimates the feature impacts using synthetic data.
		///https://reference.wolfram.com/language/ref/CumulativeFeatureImpactPlot.html
		///</summary>
		public static Engine CumulativeFeatureImpactPlot(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CumulativeFeatureImpactPlot[" + arg0 + "]", name);
		}

		///<summary>
		///displays as x⌣y⌣….
		///https://reference.wolfram.com/language/ref/Cup.html
		///</summary>
		public static Engine Cup(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Cup[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///displays as x≍y≍….
		///https://reference.wolfram.com/language/ref/CupCap.html
		///</summary>
		public static Engine CupCap(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CupCap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the curl .
		///https://reference.wolfram.com/language/ref/Curl.html
		///</summary>
		public static Engine Curl(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Curl[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the curl of the ××…× array f with respect to the -dimensional vector {x1,…,xn}.
		///https://reference.wolfram.com/language/ref/Curl.html
		///</summary>
		public static Engine Curl(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Curl[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the curl in the coordinates chart.
		///https://reference.wolfram.com/language/ref/Curl.html
		///</summary>
		public static Engine Curl(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Curl[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///attempts to convert the specified currency quantity to the specified target currency.
		///https://reference.wolfram.com/language/ref/CurrencyConvert.html
		///</summary>
		public static Engine CurrencyConvert(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CurrencyConvert[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///converts to the target currency for the historical date specification.
		///https://reference.wolfram.com/language/ref/CurrencyConvert.html
		///</summary>
		public static Engine CurrencyConvert(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CurrencyConvert[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the current date of the specified granularity type gran.
		///https://reference.wolfram.com/language/ref/CurrentDate.html
		///</summary>
		public static Engine CurrentDate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CurrentDate[" + arg0 + "]", name);
		}

		///<summary>
		///gives the date of the given granularity that includes the specified date.
		///https://reference.wolfram.com/language/ref/CurrentDate.html
		///</summary>
		public static Engine CurrentDate(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CurrentDate[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the instant corresponding to the current date.
		///https://reference.wolfram.com/language/ref/CurrentDate.html
		///</summary>
		public static Engine CurrentDate(this Engine en, string? name = null)
		{
				return en.Execute("CurrentDate[]", name);
		}

		///<summary>
		///returns the current image captured from a connected camera.
		///https://reference.wolfram.com/language/ref/CurrentImage.html
		///</summary>
		public static Engine CurrentImage(this Engine en, string? name = null)
		{
				return en.Execute("CurrentImage[]", name);
		}

		///<summary>
		///returns n sequential image frames as a list.
		///https://reference.wolfram.com/language/ref/CurrentImage.html
		///</summary>
		public static Engine CurrentImage(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CurrentImage[" + arg0 + "]", name);
		}

		///<summary>
		///returns an image captured from the portion of the notebook nb that appears on your screen.
		///https://reference.wolfram.com/language/ref/CurrentNotebookImage.html
		///</summary>
		public static Engine CurrentNotebookImage(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CurrentNotebookImage[" + arg0 + "]", name);
		}

		///<summary>
		///returns an image captured from the notebook in which the function is evaluated.
		///https://reference.wolfram.com/language/ref/CurrentNotebookImage.html
		///</summary>
		public static Engine CurrentNotebookImage(this Engine en, string? name = null)
		{
				return en.Execute("CurrentNotebookImage[]", name);
		}

		///<summary>
		///returns an image captured from all current display screens on your computer.
		///https://reference.wolfram.com/language/ref/CurrentScreenImage.html
		///</summary>
		public static Engine CurrentScreenImage(this Engine en, string? name = null)
		{
				return en.Execute("CurrentScreenImage[]", name);
		}

		///<summary>
		///returns an image captured from display screen n.
		///https://reference.wolfram.com/language/ref/CurrentScreenImage.html
		///</summary>
		public static Engine CurrentScreenImage(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CurrentScreenImage[" + arg0 + "]", name);
		}

		///<summary>
		///returns the specified rectangle from the image of all current display screens.
		///https://reference.wolfram.com/language/ref/CurrentScreenImage.html
		///</summary>
		public static Engine CurrentScreenImage(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CurrentScreenImage[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the current value of item at a location in the Wolfram System and interface.
		///https://reference.wolfram.com/language/ref/CurrentValue.html
		///</summary>
		public static Engine CurrentValue(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CurrentValue[" + arg0 + "]", name);
		}

		///<summary>
		///gives the current value for the feature of item specified by spec.
		///https://reference.wolfram.com/language/ref/CurrentValue.html
		///</summary>
		public static Engine CurrentValue(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("CurrentValue[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the current value of item associated with the object obj.
		///https://reference.wolfram.com/language/ref/CurrentValue.html
		///</summary>
		public static Engine CurrentValue(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CurrentValue[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an operator form of the function f of n arguments so that CurryApplied[f,n][x1]…[xn] is equivalent to f[x1,…,xn].
		///https://reference.wolfram.com/language/ref/CurryApplied.html
		///</summary>
		public static Engine CurryApplied(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CurryApplied[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an operator form of CurryApplied that can be applied to a function to represent an operator form with n arguments.
		///https://reference.wolfram.com/language/ref/CurryApplied.html
		///</summary>
		public static Engine CurryApplied(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CurryApplied[" + arg0 + "]", name);
		}

		///<summary>
		///represents an operator form of the function f of n arguments so that CurryApplied[f,{i1,…,in}][x1]…[xn] is equivalent to f[xi1,…,xin].
		///https://reference.wolfram.com/language/ref/CurryApplied.html
		///</summary>
		public static Engine CurryApplied(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CurryApplied[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///applies a mean curvature flow filter to image.
		///https://reference.wolfram.com/language/ref/CurvatureFlowFilter.html
		///</summary>
		public static Engine CurvatureFlowFilter(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CurvatureFlowFilter[" + arg0 + "]", name);
		}

		///<summary>
		///specifies the amount of curvature flow time t to be applied.
		///https://reference.wolfram.com/language/ref/CurvatureFlowFilter.html
		///</summary>
		public static Engine CurvatureFlowFilter(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("CurvatureFlowFilter[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///applies the curvature flow with a modified conductance term parametrized by k.
		///https://reference.wolfram.com/language/ref/CurvatureFlowFilter.html
		///</summary>
		public static Engine CurvatureFlowFilter(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CurvatureFlowFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the cycle graph with n vertices .
		///https://reference.wolfram.com/language/ref/CycleGraph.html
		///</summary>
		public static Engine CycleGraph(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CycleGraph[" + arg0 + "]", name);
		}

		///<summary>
		///constructs the cycle index monomial of the permutation perm in the variables xi.
		///https://reference.wolfram.com/language/ref/CycleIndexPolynomial.html
		///</summary>
		public static Engine CycleIndexPolynomial(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CycleIndexPolynomial[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents a permutation with disjoint cycles cyci.
		///https://reference.wolfram.com/language/ref/Cycles.html
		///</summary>
		public static Engine Cycles(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Cycles[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents the cyclic group of degree n.
		///https://reference.wolfram.com/language/ref/CyclicGroup.html
		///</summary>
		public static Engine CyclicGroup(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("CyclicGroup[" + arg0 + "]", name);
		}

		///<summary>
		///gives the n cyclotomic polynomial in x.
		///https://reference.wolfram.com/language/ref/Cyclotomic.html
		///</summary>
		public static Engine Cyclotomic(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Cyclotomic[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a cylinder of radius r around the line from (x1,y1,z1) to (x2,y2,z2).
		///https://reference.wolfram.com/language/ref/Cylinder.html
		///</summary>
		public static Engine Cylinder(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("Cylinder[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a cylinder of radius 1.
		///https://reference.wolfram.com/language/ref/Cylinder.html
		///</summary>
		public static Engine Cylinder(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Cylinder[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///finds a decomposition of the region represented by the statement expr into cylindrical parts whose directions correspond to the successive xi.
		///https://reference.wolfram.com/language/ref/CylindricalDecomposition.html
		///</summary>
		public static Engine CylindricalDecomposition(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("CylindricalDecomposition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///finds a decomposition of the result of applying the topological operation op to the region represented by the statement expr.
		///https://reference.wolfram.com/language/ref/CylindricalDecomposition.html
		///</summary>
		public static Engine CylindricalDecomposition(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("CylindricalDecomposition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents a cylindrical algebraic formula in x1,x2,….
		///https://reference.wolfram.com/language/ref/CylindricalDecompositionFunction.html
		///</summary>
		public static Engine CylindricalDecompositionFunction(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("CylindricalDecompositionFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}


    }
}
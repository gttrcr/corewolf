namespace CoreWolf
{
    public static class ExtendedSymbolsO
    {
        ///<summary>
        ///gives the observability Gramian of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/ObservabilityGramian.html
        ///</summary>
        public static Engine ObservabilityGramian(this Engine en, string? name = null)
        {
            return en.Execute("ObservabilityGramian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the observability matrix of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/ObservabilityMatrix.html
        ///</summary>
        public static Engine ObservabilityMatrix(this Engine en, string? name = null)
        {
            return en.Execute("ObservabilityMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields the observable subsystem of the system sys.
        ///https://reference.wolfram.com/language/ref/ObservableDecomposition.html
        ///</summary>
        public static Engine ObservableDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("ObservableDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the system sys is observable, and False otherwise.
        ///https://reference.wolfram.com/language/ref/ObservableModelQ.html
        ///</summary>
        public static Engine ObservableModelQ(this Engine en, string? name = null)
        {
            return en.Execute("ObservableModelQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an octahedron with edge length l.
        ///https://reference.wolfram.com/language/ref/Octahedron.html
        ///</summary>
        public static Engine Octahedron(this Engine en, string? name = null)
        {
            return en.Execute("Octahedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is an odd integer, and False otherwise.
        ///https://reference.wolfram.com/language/ref/OddQ.html
        ///</summary>
        public static Engine OddQ(this Engine en, string? name = null)
        {
            return en.Execute("OddQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///switches off a message, so that it is no longer printed.
        ///https://reference.wolfram.com/language/ref/Off.html
        ///</summary>
        public static Engine Off(this Engine en, string? name = null)
        {
            return en.Execute("Off[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///switches on a message, so that it can be printed.
        ///https://reference.wolfram.com/language/ref/On.html
        ///</summary>
        public static Engine On(this Engine en, string? name = null)
        {
            return en.Execute("On[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr once in each Wolfram Language session, always returning the result from the first evaluation.
        ///https://reference.wolfram.com/language/ref/Once.html
        ///</summary>
        public static Engine Once(this Engine en, string? name = null)
        {
            return en.Execute("Once[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a graphics directive that specifies that graphical objects that follow are to be displayed, if possible, with opacity a.
        ///https://reference.wolfram.com/language/ref/Opacity.html
        ///</summary>
        public static Engine Opacity(this Engine en, string? name = null)
        {
            return en.Execute("Opacity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens a file to append output to it, and returns an OutputStream object.
        ///https://reference.wolfram.com/language/ref/OpenAppend.html
        ///</summary>
        public static Engine OpenAppend(this Engine en, string? name = null)
        {
            return en.Execute("OpenAppend[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an opener with setting x, displayed as  when x is True and  when x is False.
        ///https://reference.wolfram.com/language/ref/Opener.html
        ///</summary>
        public static Engine Opener(this Engine en, string? name = null)
        {
            return en.Execute("Opener[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an object which displays as an opener, together with expr1 if the opener is closed, and both expr1 and expr2 if it is open.
        ///https://reference.wolfram.com/language/ref/OpenerView.html
        ///</summary>
        public static Engine OpenerView(this Engine en, string? name = null)
        {
            return en.Execute("OpenerView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens a file to read data from, and returns an InputStream object.
        ///https://reference.wolfram.com/language/ref/OpenRead.html
        ///</summary>
        public static Engine OpenRead(this Engine en, string? name = null)
        {
            return en.Execute("OpenRead[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens a file to write output to it, and returns an OutputStream object.
        ///https://reference.wolfram.com/language/ref/OpenWrite.html
        ///</summary>
        public static Engine OpenWrite(this Engine en, string? name = null)
        {
            return en.Execute("OpenWrite[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of the function f of two arguments so that OperatorApplied[f][y][x] is equivalent to f[x,y].
        ///https://reference.wolfram.com/language/ref/OperatorApplied.html
        ///</summary>
        public static Engine OperatorApplied(this Engine en, string? name = null)
        {
            return en.Execute("OperatorApplied[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a grammar rules pattern object that represents 0 or 1 instances of patt.
        ///https://reference.wolfram.com/language/ref/OptionalElement.html
        ///</summary>
        public static Engine OptionalElement(this Engine en, string? name = null)
        {
            return en.Execute("OptionalElement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of default options assigned to a symbol.
        ///https://reference.wolfram.com/language/ref/Options.html
        ///</summary>
        public static Engine Options(this Engine en, string? name = null)
        {
            return en.Execute("Options[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///takes default option values from Options[f].
        ///https://reference.wolfram.com/language/ref/OptionsPattern.html
        ///</summary>
        public static Engine OptionsPattern(this Engine en, string? name = null)
        {
            return en.Execute("OptionsPattern[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of name in options matched by OptionsPattern.
        ///https://reference.wolfram.com/language/ref/OptionValue.html
        ///</summary>
        public static Engine OptionValue(this Engine en, string? name = null)
        {
            return en.Execute("OptionValue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the ei are in canonical order, and False otherwise.
        ///https://reference.wolfram.com/language/ref/OrderedQ.html
        ///</summary>
        public static Engine OrderedQ(this Engine en, string? name = null)
        {
            return en.Execute("OrderedQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the positions in list at which each successive element of Sort[list] appears.
        ///https://reference.wolfram.com/language/ref/Ordering.html
        ///</summary>
        public static Engine Ordering(this Engine en, string? name = null)
        {
            return en.Execute("Ordering[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the first n elements in the ordering of its input.
        ///https://reference.wolfram.com/language/ref/OrderingLayer.html
        ///</summary>
        public static Engine OrderingLayer(this Engine en, string? name = null)
        {
            return en.Execute("OrderingLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a set of ordered categories cati with order cat1<cat2<…<catn.
        ///https://reference.wolfram.com/language/ref/OrdinalScale.html
        ///</summary>
        public static Engine OrdinalScale(this Engine en, string? name = null)
        {
            return en.Execute("OrdinalScale[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an orthonormal basis found by orthogonalizing the vectors vi.
        ///https://reference.wolfram.com/language/ref/Orthogonalize.html
        ///</summary>
        public static Engine Orthogonalize(this Engine en, string? name = null)
        {
            return en.Execute("Orthogonalize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is an explicitly orthogonal matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/OrthogonalMatrixQ.html
        ///</summary>
        public static Engine OrthogonalMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("OrthogonalMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a global object that is assigned to be the value produced on the n output line.
        ///https://reference.wolfram.com/language/ref/Out.html
        ///</summary>
        public static Engine Out(this Engine en, string? name = null)
        {
            return en.Execute("Out[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the outer polygon of the polygon poly.
        ///https://reference.wolfram.com/language/ref/OuterPolygon.html
        ///</summary>
        public static Engine OuterPolygon(this Engine en, string? name = null)
        {
            return en.Execute("OuterPolygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the outer polyhedron of the polyhedron poly.
        ///https://reference.wolfram.com/language/ref/OuterPolyhedron.html
        ///</summary>
        public static Engine OuterPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("OuterPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the output controllability matrix of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/OutputControllabilityMatrix.html
        ///</summary>
        public static Engine OutputControllabilityMatrix(this Engine en, string? name = null)
        {
            return en.Execute("OutputControllabilityMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the state-space model ssm is output controllable, and False otherwise.
        ///https://reference.wolfram.com/language/ref/OutputControllableModelQ.html
        ///</summary>
        public static Engine OutputControllableModelQ(this Engine en, string? name = null)
        {
            return en.Execute("OutputControllableModelQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as a two-dimensional representation of expr using only keyboard characters.
        ///https://reference.wolfram.com/language/ref/OutputForm.html
        ///</summary>
        public static Engine OutputForm(this Engine en, string? name = null)
        {
            return en.Execute("OutputForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that contains in string the name assigned to the next output.
        ///https://reference.wolfram.com/language/ref/OutputNamePacket.html
        ///</summary>
        public static Engine OutputNamePacket(this Engine en, string? name = null)
        {
            return en.Execute("OutputNamePacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays with a bar over expr.
        ///https://reference.wolfram.com/language/ref/OverBar.html
        ///</summary>
        public static Engine OverBar(this Engine en, string? name = null)
        {
            return en.Execute("OverBar[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays with a dot over expr.
        ///https://reference.wolfram.com/language/ref/OverDot.html
        ///</summary>
        public static Engine OverDot(this Engine en, string? name = null)
        {
            return en.Execute("OverDot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays with a hat over expr.
        ///https://reference.wolfram.com/language/ref/OverHat.html
        ///</summary>
        public static Engine OverHat(this Engine en, string? name = null)
        {
            return en.Execute("OverHat[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as an overlay of all the expri.
        ///https://reference.wolfram.com/language/ref/Overlay.html
        ///</summary>
        public static Engine Overlay(this Engine en, string? name = null)
        {
            return en.Execute("Overlay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays with a tilde over expr.
        ///https://reference.wolfram.com/language/ref/OverTilde.html
        ///</summary>
        public static Engine OverTilde(this Engine en, string? name = null)
        {
            return en.Execute("OverTilde[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays with a right vector over expr.
        ///https://reference.wolfram.com/language/ref/OverVector.html
        ///</summary>
        public static Engine OverVector(this Engine en, string? name = null)
        {
            return en.Execute("OverVector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all ownvalues defined for the symbol x.
        ///https://reference.wolfram.com/language/ref/OwnValues.html
        ///</summary>
        public static Engine OwnValues(this Engine en, string? name = null)
        {
            return en.Execute("OwnValues[" + en.ValidNames.Last() + "]", name);
        }


    }
}
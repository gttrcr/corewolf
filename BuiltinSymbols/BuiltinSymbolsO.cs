namespace NetWolf
{
    public static class BuiltinSymbolO
    {
        ///<summary>
        ///displays with a bar over expr.
        ///https://reference.wolfram.com/language/ref/OverBar.html
        ///</summary>
        public static Engine OverBar(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OverBar[" + arg0 + "]", name);
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
        ///switches on a message, so that it can be printed. 
        ///https://reference.wolfram.com/language/ref/On.html
        ///</summary>
        public static Engine On(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("On[" + arg0 + "]", name);
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
        ///gives 1 if expr1 is before expr2 in canonical order, and -1 if expr1 is after expr2 in canonical order. It gives 0 if expr1 is identical to expr2. 
        ///https://reference.wolfram.com/language/ref/Order.html
        ///</summary>
        public static Engine Order(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Order[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields the observable subsystem of the system sys.
        ///https://reference.wolfram.com/language/ref/ObservableDecomposition.html
        ///</summary>
        public static Engine ObservableDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ObservableDecomposition[" + arg0 + "]", name);
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
        ///represents an opener with setting x, displayed as  when x is True and  when x is False. 
        ///https://reference.wolfram.com/language/ref/Opener.html
        ///</summary>
        public static Engine Opener(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Opener[" + arg0 + "]", name);
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
        ///opens a file to read data from, and returns an InputStream object.
        ///https://reference.wolfram.com/language/ref/OpenRead.html
        ///</summary>
        public static Engine OpenRead(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OpenRead[" + arg0 + "]", name);
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
        ///displays with a right vector over expr.
        ///https://reference.wolfram.com/language/ref/OverVector.html
        ///</summary>
        public static Engine OverVector(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OverVector[" + arg0 + "]", name);
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
        ///gives the outer polyhedron of the polyhedron poly.
        ///https://reference.wolfram.com/language/ref/OuterPolyhedron.html
        ///</summary>
        public static Engine OuterPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OuterPolyhedron[" + arg0 + "]", name);
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
        ///gives the position of a graphical object obtained by starting at the specified position and then moving by absolute offset {dx,dy}. 
        ///https://reference.wolfram.com/language/ref/Offset.html
        ///</summary>
        public static Engine Offset(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Offset[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of the function f of n arguments so that OperatorApplied[f,n][x1]…[xn] is equivalent to f[x1,…,xn].
        ///https://reference.wolfram.com/language/ref/OperatorApplied.html
        ///</summary>
        public static Engine OperatorApplied(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("OperatorApplied[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an orthonormal basis found by orthogonalizing the vectors vi.
        ///https://reference.wolfram.com/language/ref/Orthogonalize.html
        ///</summary>
        public static Engine Orthogonalize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Orthogonalize[" + arg0 + "]", name);
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
        ///is a grammar rules pattern object that represents 0 or 1 instances of patt.
        ///https://reference.wolfram.com/language/ref/OptionalElement.html
        ///</summary>
        public static Engine OptionalElement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OptionalElement[" + arg0 + "]", name);
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
        ///represents a stationary Ornstein–Uhlenbeck process with long-term mean μ, volatility , and mean reversion speed θ. 
        ///https://reference.wolfram.com/language/ref/OrnsteinUhlenbeckProcess.html
        ///</summary>
        public static Engine OrnsteinUhlenbeckProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("OrnsteinUhlenbeckProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all ownvalues defined for the symbol x.
        ///https://reference.wolfram.com/language/ref/OwnValues.html
        ///</summary>
        public static Engine OwnValues(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OwnValues[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all ownvalues defined for the symbol x.
        ///https://reference.wolfram.com/language/ref/OwnValues.html
        ///</summary>
        public static Engine OwnValues(this Engine en, string? name = null)
        {
            return en.Execute("OwnValues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the output controllability matrix of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/OutputControllabilityMatrix.html
        ///</summary>
        public static Engine OutputControllabilityMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OutputControllabilityMatrix[" + arg0 + "]", name);
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
        ///displays with a dot over expr.
        ///https://reference.wolfram.com/language/ref/OverDot.html
        ///</summary>
        public static Engine OverDot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OverDot[" + arg0 + "]", name);
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
        ///gives the morphological opening of image with respect to the structuring element ker.
        ///https://reference.wolfram.com/language/ref/Opening.html
        ///</summary>
        public static Engine Opening(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Opening[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays with a tilde over expr.
        ///https://reference.wolfram.com/language/ref/OverTilde.html
        ///</summary>
        public static Engine OverTilde(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OverTilde[" + arg0 + "]", name);
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
        ///is a WSTP packet that contains in string the name assigned to the next output.
        ///https://reference.wolfram.com/language/ref/OutputNamePacket.html
        ///</summary>
        public static Engine OutputNamePacket(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OutputNamePacket[" + arg0 + "]", name);
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
        ///gives p[f][x,y]. 
        ///https://reference.wolfram.com/language/ref/Operate.html
        ///</summary>
        public static Engine Operate(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Operate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the observability Gramian of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/ObservabilityGramian.html
        ///</summary>
        public static Engine ObservabilityGramian(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ObservabilityGramian[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the observability Gramian of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/ObservabilityGramian.html
        ///</summary>
        public static Engine ObservabilityGramian(this Engine en, string? name = null)
        {
            return en.Execute("ObservabilityGramian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives Owen's T function .
        ///https://reference.wolfram.com/language/ref/OwenT.html
        ///</summary>
        public static Engine OwenT(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("OwenT[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the k-order statistics distribution for n observations from the distribution dist.
        ///https://reference.wolfram.com/language/ref/OrderDistribution.html
        ///</summary>
        public static Engine OrderDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("OrderDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the positions in list at which each successive element of SortBy[list,f] appears.
        ///https://reference.wolfram.com/language/ref/OrderingBy.html
        ///</summary>
        public static Engine OrderingBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("OrderingBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents flow data such as generated by FindMaximumFlow, FindMinimumCostFlow, etc.
        ///https://reference.wolfram.com/language/ref/OptimumFlowData.html
        ///</summary>
        public static Engine OptimumFlowData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OptimumFlowData[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents flow data such as generated by FindMaximumFlow, FindMinimumCostFlow, etc.
        ///https://reference.wolfram.com/language/ref/OptimumFlowData.html
        ///</summary>
        public static Engine OptimumFlowData(this Engine en, string? name = null)
        {
            return en.Execute("OptimumFlowData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens a file to write output to it, and returns an OutputStream object. 
        ///https://reference.wolfram.com/language/ref/OpenWrite.html
        ///</summary>
        public static Engine OpenWrite(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OpenWrite[" + arg0 + "]", name);
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
        ///represents a number too large to represent explicitly on your computer system.
        ///https://reference.wolfram.com/language/ref/Overflow.html
        ///</summary>
        public static Engine Overflow(this Engine en, string? name = null)
        {
            return en.Execute("Overflow[]", name);
        }

        ///<summary>
        ///represents an object which displays as an opener, together with expr1 if the opener is closed, and both expr1 and expr2 if it is open.
        ///https://reference.wolfram.com/language/ref/OpenerView.html
        ///</summary>
        public static Engine OpenerView(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OpenerView[" + arg0 + "]", name);
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
        ///gives the generalized outer product of the listi, forming all possible combinations of the lowest‐level elements in each of them, and feeding them as arguments to f. 
        ///https://reference.wolfram.com/language/ref/Outer.html
        ///</summary>
        public static Engine Outer(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Outer[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives True if the system sys is observable, and False otherwise.
        ///https://reference.wolfram.com/language/ref/ObservableModelQ.html
        ///</summary>
        public static Engine ObservableModelQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ObservableModelQ[" + arg0 + "]", name);
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
        ///displays as an overlay of all the expri.
        ///https://reference.wolfram.com/language/ref/Overlay.html
        ///</summary>
        public static Engine Overlay(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Overlay[" + arg0 + "]", name);
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
        ///gives the outer polygon of the polygon poly.
        ///https://reference.wolfram.com/language/ref/OuterPolygon.html
        ///</summary>
        public static Engine OuterPolygon(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OuterPolygon[" + arg0 + "]", name);
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
        ///represents the sporadic simple O'Nan group .
        ///https://reference.wolfram.com/language/ref/ONanGroupON.html
        ///</summary>
        public static Engine ONanGroupON(this Engine en, string? name = null)
        {
            return en.Execute("ONanGroupON[]", name);
        }

        ///<summary>
        ///gives True if the state-space model ssm is output controllable, and False otherwise.
        ///https://reference.wolfram.com/language/ref/OutputControllableModelQ.html
        ///</summary>
        public static Engine OutputControllableModelQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OutputControllableModelQ[" + arg0 + "]", name);
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
        ///gives True if m is an explicitly orthogonal matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/OrthogonalMatrixQ.html
        ///</summary>
        public static Engine OrthogonalMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OrthogonalMatrixQ[" + arg0 + "]", name);
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
        ///gives the list of default options assigned to a symbol. 
        ///https://reference.wolfram.com/language/ref/Options.html
        ///</summary>
        public static Engine Options(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Options[" + arg0 + "]", name);
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
        ///gives True if the ei are in canonical order, and False otherwise.
        ///https://reference.wolfram.com/language/ref/OrderedQ.html
        ///</summary>
        public static Engine OrderedQ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("OrderedQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the observability matrix of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/ObservabilityMatrix.html
        ///</summary>
        public static Engine ObservabilityMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ObservabilityMatrix[" + arg0 + "]", name);
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
        ///displays with a hat over expr.
        ///https://reference.wolfram.com/language/ref/OverHat.html
        ///</summary>
        public static Engine OverHat(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OverHat[" + arg0 + "]", name);
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
        ///is a graphics directive that specifies that graphical objects that follow are to be displayed, if possible, with opacity a. 
        ///https://reference.wolfram.com/language/ref/Opacity.html
        ///</summary>
        public static Engine Opacity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Opacity[" + arg0 + "]", name);
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
        ///evaluates expr once in each Wolfram Language session, always returning the result from the first evaluation.
        ///https://reference.wolfram.com/language/ref/Once.html
        ///</summary>
        public static Engine Once(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Once[" + arg0 + "]", name);
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
        ///gives the value of the specified property for the ocean entity.
        ///https://reference.wolfram.com/language/ref/OceanData.html
        ///</summary>
        public static Engine OceanData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("OceanData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a net layer that effectively applies Ordering to its input. 
        ///https://reference.wolfram.com/language/ref/OrderingLayer.html
        ///</summary>
        public static Engine OrderingLayer(this Engine en, string? name = null)
        {
            return en.Execute("OrderingLayer[]", name);
        }

        ///<summary>
        ///prints as a two-dimensional representation of expr using only keyboard characters. 
        ///https://reference.wolfram.com/language/ref/OutputForm.html
        ///</summary>
        public static Engine OutputForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OutputForm[" + arg0 + "]", name);
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
        ///gives the positions in list at which each successive element of Sort[list] appears. 
        ///https://reference.wolfram.com/language/ref/Ordering.html
        ///</summary>
        public static Engine Ordering(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Ordering[" + arg0 + "]", name);
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
        ///is a pattern object that represents a collection of options given as rules, where the values of the options can be accessed using OptionValue.
        ///https://reference.wolfram.com/language/ref/OptionsPattern.html
        ///</summary>
        public static Engine OptionsPattern(this Engine en, string? name = null)
        {
            return en.Execute("OptionsPattern[]", name);
        }

        ///<summary>
        ///gives the result of overlaying o onto a background video or image background. 
        ///https://reference.wolfram.com/language/ref/OverlayVideo.html
        ///</summary>
        public static Engine OverlayVideo(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("OverlayVideo[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the numeric output response of systems model sys to the input u[t] for tmin≤t≤tmax.
        ///https://reference.wolfram.com/language/ref/OutputResponse.html
        ///</summary>
        public static Engine OutputResponse(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("OutputResponse[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a regular octahedron centered at the origin with unit edge length.
        ///https://reference.wolfram.com/language/ref/Octahedron.html
        ///</summary>
        public static Engine Octahedron(this Engine en, string? name = null)
        {
            return en.Execute("Octahedron[]", name);
        }

        ///<summary>
        ///is an object that formats as . 
        ///https://reference.wolfram.com/language/ref/Overscript.html
        ///</summary>
        public static Engine Overscript(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Overscript[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of name in options matched by OptionsPattern. 
        ///https://reference.wolfram.com/language/ref/OptionValue.html
        ///</summary>
        public static Engine OptionValue(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OptionValue[" + arg0 + "]", name);
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
        ///gives True if expr is an odd integer, and False otherwise. 
        ///https://reference.wolfram.com/language/ref/OddQ.html
        ///</summary>
        public static Engine OddQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OddQ[" + arg0 + "]", name);
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
        ///is a pattern object that represents a sequence of arguments matching p1,p2,… in any order.
        ///https://reference.wolfram.com/language/ref/OrderlessPatternSequence.html
        ///</summary>
        public static Engine OrderlessPatternSequence(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("OrderlessPatternSequence[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the low‐level box representation for  in notebook expressions. 
        ///https://reference.wolfram.com/language/ref/OverscriptBox.html
        ///</summary>
        public static Engine OverscriptBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("OverscriptBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an object that represents an output stream for functions such as Write. 
        ///https://reference.wolfram.com/language/ref/OutputStream.html
        ///</summary>
        public static Engine OutputStream(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("OutputStream[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///opens a file to append output to it, and returns an OutputStream object. 
        ///https://reference.wolfram.com/language/ref/OpenAppend.html
        ///</summary>
        public static Engine OpenAppend(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OpenAppend[" + arg0 + "]", name);
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
        ///switches off a message, so that it is no longer printed. 
        ///https://reference.wolfram.com/language/ref/Off.html
        ///</summary>
        public static Engine Off(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Off[" + arg0 + "]", name);
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
        ///represents a set of ordered categories cati with order cat1<cat2<…<catn.
        ///https://reference.wolfram.com/language/ref/OrdinalScale.html
        ///</summary>
        public static Engine OrdinalScale(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("OrdinalScale[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a set of ordered categories cati with order cat1<cat2<…<catn.
        ///https://reference.wolfram.com/language/ref/OrdinalScale.html
        ///</summary>
        public static Engine OrdinalScale(this Engine en, string? name = null)
        {
            return en.Execute("OrdinalScale[" + en.ValidNames.Last() + "]", name);
        }


    }
}
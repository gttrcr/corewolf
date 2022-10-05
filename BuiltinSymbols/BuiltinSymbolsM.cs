namespace NetWolf
{
    public static class BuiltinSymbolM
    {
        ///<summary>
        ///gives Minkowski's question mark function .
        ///https://reference.wolfram.com/language/ref/MinkowskiQuestionMark.html
        ///</summary>
        public static Engine MinkowskiQuestionMark(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinkowskiQuestionMark[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives Minkowski's question mark function .
        ///https://reference.wolfram.com/language/ref/MinkowskiQuestionMark.html
        ///</summary>
        public static Engine MinkowskiQuestionMark(this Engine en, string? name = null)
        {
            return en.Execute("MinkowskiQuestionMark[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an item of mail associated with an active mail server connection.
        ///https://reference.wolfram.com/language/ref/MailItem.html
        ///</summary>
        public static Engine MailItem(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MailItem[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an item of mail associated with an active mail server connection.
        ///https://reference.wolfram.com/language/ref/MailItem.html
        ///</summary>
        public static Engine MailItem(this Engine en, string? name = null)
        {
            return en.Execute("MailItem[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the minor planet entity.
        ///https://reference.wolfram.com/language/ref/MinorPlanetData.html
        ///</summary>
        public static Engine MinorPlanetData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinorPlanetData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a generalized maximum extreme value distribution with location parameter μ, scale parameter σ, and shape parameter ξ.
        ///https://reference.wolfram.com/language/ref/MaxStableDistribution.html
        ///</summary>
        public static Engine MaxStableDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MaxStableDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///searches the specified mail folder for messages with properties matching elements in assoc.
        ///https://reference.wolfram.com/language/ref/MailSearch.html
        ///</summary>
        public static Engine MailSearch(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MailSearch[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple McLaughlin group .
        ///https://reference.wolfram.com/language/ref/McLaughlinGroupMcL.html
        ///</summary>
        public static Engine McLaughlinGroupMcL(this Engine en, string? name = null)
        {
            return en.Execute("McLaughlinGroupMcL[]", name);
        }

        ///<summary>
        ///gives the maximum number of bytes used to store all data for the current Wolfram System session.
        ///https://reference.wolfram.com/language/ref/MaxMemoryUsed.html
        ///</summary>
        public static Engine MaxMemoryUsed(this Engine en, string? name = null)
        {
            return en.Execute("MaxMemoryUsed[]", name);
        }

        ///<summary>
        ///gives the maximum value of f with respect to x.
        ///https://reference.wolfram.com/language/ref/MaxValue.html
        ///</summary>
        public static Engine MaxValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MaxValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if expr has head Missing.
        ///https://reference.wolfram.com/language/ref/MissingQ.html
        ///</summary>
        public static Engine MissingQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MissingQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr has head Missing.
        ///https://reference.wolfram.com/language/ref/MissingQ.html
        ///</summary>
        public static Engine MissingQ(this Engine en, string? name = null)
        {
            return en.Execute("MissingQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Mittag–Leffler function .
        ///https://reference.wolfram.com/language/ref/MittagLefflerE.html
        ///</summary>
        public static Engine MittagLefflerE(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MittagLefflerE[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the low‐level function used in Wolfram System sessions to convert expressions into boxes. 
        ///https://reference.wolfram.com/language/ref/MakeBoxes.html
        ///</summary>
        public static Engine MakeBoxes(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MakeBoxes[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the mean distance between all pairs of vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/MeanGraphDistance.html
        ///</summary>
        public static Engine MeanGraphDistance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeanGraphDistance[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the mean distance between all pairs of vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/MeanGraphDistance.html
        ///</summary>
        public static Engine MeanGraphDistance(this Engine en, string? name = null)
        {
            return en.Execute("MeanGraphDistance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Manhattan or "city block" distance between vectors u and v.
        ///https://reference.wolfram.com/language/ref/ManhattanDistance.html
        ///</summary>
        public static Engine ManhattanDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ManhattanDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Böttcher coordinate of z with respect to the Mandelbrot set.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetBoettcher.html
        ///</summary>
        public static Engine MandelbrotSetBoettcher(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MandelbrotSetBoettcher[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Böttcher coordinate of z with respect to the Mandelbrot set.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetBoettcher.html
        ///</summary>
        public static Engine MandelbrotSetBoettcher(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetBoettcher[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a symbolic representation of a connection to an incoming mail server.
        ///https://reference.wolfram.com/language/ref/MailServerConnection.html
        ///</summary>
        public static Engine MailServerConnection(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MailServerConnection[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a symbolic representation of a connection to an incoming mail server.
        ///https://reference.wolfram.com/language/ref/MailServerConnection.html
        ///</summary>
        public static Engine MailServerConnection(this Engine en, string? name = null)
        {
            return en.Execute("MailServerConnection[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a generalized minimum extreme value distribution with location parameter μ, scale parameter σ, and shape parameter ξ.
        ///https://reference.wolfram.com/language/ref/MinStableDistribution.html
        ///</summary>
        public static Engine MinStableDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MinStableDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the min limit xx*f(x). 
        ///https://reference.wolfram.com/language/ref/MinLimit.html
        ///</summary>
        public static Engine MinLimit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinLimit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces each element in list by the mean of the values of all elements that differ by less than d.
        ///https://reference.wolfram.com/language/ref/MeanShift.html
        ///</summary>
        public static Engine MeanShift(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeanShift[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a mail receiver function that applies fun to any mail message it receives.
        ///https://reference.wolfram.com/language/ref/MailReceiverFunction.html
        ///</summary>
        public static Engine MailReceiverFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MailReceiverFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a mail receiver function that applies fun to any mail message it receives.
        ///https://reference.wolfram.com/language/ref/MailReceiverFunction.html
        ///</summary>
        public static Engine MailReceiverFunction(this Engine en, string? name = null)
        {
            return en.Execute("MailReceiverFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates the distance from c to the nearest point in the Mandelbrot set.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetDistance.html
        ///</summary>
        public static Engine MandelbrotSetDistance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MandelbrotSetDistance[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the distance from c to the nearest point in the Mandelbrot set.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetDistance.html
        ///</summary>
        public static Engine MandelbrotSetDistance(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetDistance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays a window with interactive tools for drawing a Molecule, and returns the result.
        ///https://reference.wolfram.com/language/ref/MoleculeDraw.html
        ///</summary>
        public static Engine MoleculeDraw(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeDraw[]", name);
        }

        ///<summary>
        ///gives the statistical mean of the elements in list. 
        ///https://reference.wolfram.com/language/ref/Mean.html
        ///</summary>
        public static Engine Mean(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Mean[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the statistical mean of the elements in list. 
        ///https://reference.wolfram.com/language/ref/Mean.html
        ///</summary>
        public static Engine Mean(this Engine en, string? name = null)
        {
            return en.Execute("Mean[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents data that is missing.
        ///https://reference.wolfram.com/language/ref/Missing.html
        ///</summary>
        public static Engine Missing(this Engine en, string? name = null)
        {
            return en.Execute("Missing[]", name);
        }

        ///<summary>
        ///gives a list of k-mean degree connectivity for the graph g for successive k=0,1,2… .
        ///https://reference.wolfram.com/language/ref/MeanDegreeConnectivity.html
        ///</summary>
        public static Engine MeanDegreeConnectivity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeanDegreeConnectivity[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of k-mean degree connectivity for the graph g for successive k=0,1,2… .
        ///https://reference.wolfram.com/language/ref/MeanDegreeConnectivity.html
        ///</summary>
        public static Engine MeanDegreeConnectivity(this Engine en, string? name = null)
        {
            return en.Execute("MeanDegreeConnectivity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a mixed-magnitude expression consisting of values val1 through valn.
        ///https://reference.wolfram.com/language/ref/MixedMagnitude.html
        ///</summary>
        public static Engine MixedMagnitude(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MixedMagnitude[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a mixed-magnitude expression consisting of values val1 through valn.
        ///https://reference.wolfram.com/language/ref/MixedMagnitude.html
        ///</summary>
        public static Engine MixedMagnitude(this Engine en, string? name = null)
        {
            return en.Execute("MixedMagnitude[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a mixture distribution whose CDF is given as a sum of the CDFs of the component distributions disti, each with weight wi.
        ///https://reference.wolfram.com/language/ref/MixtureDistribution.html
        ///</summary>
        public static Engine MixtureDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MixtureDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a mixed-unit expression consisting of units unit1 through unitn.
        ///https://reference.wolfram.com/language/ref/MixedUnit.html
        ///</summary>
        public static Engine MixedUnit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MixedUnit[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a mixed-unit expression consisting of units unit1 through unitn.
        ///https://reference.wolfram.com/language/ref/MixedUnit.html
        ///</summary>
        public static Engine MixedUnit(this Engine en, string? name = null)
        {
            return en.Execute("MixedUnit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the medical test entity.
        ///https://reference.wolfram.com/language/ref/MedicalTestData.html
        ///</summary>
        public static Engine MedicalTestData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MedicalTestData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the modular inverse of k modulo n.
        ///https://reference.wolfram.com/language/ref/ModularInverse.html
        ///</summary>
        public static Engine ModularInverse(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ModularInverse[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a molecule with atoms atomi and bonds bondi.
        ///https://reference.wolfram.com/language/ref/Molecule.html
        ///</summary>
        public static Engine Molecule(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Molecule[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns True if expr is a managed library expression and False otherwise.
        ///https://reference.wolfram.com/language/ref/ManagedLibraryExpressionQ.html
        ///</summary>
        public static Engine ManagedLibraryExpressionQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if expr is a managed library expression and False otherwise.
        ///https://reference.wolfram.com/language/ref/ManagedLibraryExpressionQ.html
        ///</summary>
        public static Engine ManagedLibraryExpressionQ(this Engine en, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr, stopping if more than b bytes of memory are requested. 
        ///https://reference.wolfram.com/language/ref/MemoryConstrained.html
        ///</summary>
        public static Engine MemoryConstrained(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MemoryConstrained[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to the element at position n in expr. If n is negative, the position is counted from the end. 
        ///https://reference.wolfram.com/language/ref/MapAt.html
        ///</summary>
        public static Engine MapAt(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MapAt[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the minors of a matrix m. 
        ///https://reference.wolfram.com/language/ref/Minors.html
        ///</summary>
        public static Engine Minors(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Minors[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the minors of a matrix m. 
        ///https://reference.wolfram.com/language/ref/Minors.html
        ///</summary>
        public static Engine Minors(this Engine en, string? name = null)
        {
            return en.Execute("Minors[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Maxwell distribution with scale parameter σ.
        ///https://reference.wolfram.com/language/ref/MaxwellDistribution.html
        ///</summary>
        public static Engine MaxwellDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MaxwellDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Maxwell distribution with scale parameter σ.
        ///https://reference.wolfram.com/language/ref/MaxwellDistribution.html
        ///</summary>
        public static Engine MaxwellDistribution(this Engine en, string? name = null)
        {
            return en.Execute("MaxwellDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a manipulator with setting x in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/Manipulator.html
        ///</summary>
        public static Engine Manipulator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Manipulator[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a manipulator with setting x in the range 0 to 1. 
        ///https://reference.wolfram.com/language/ref/Manipulator.html
        ///</summary>
        public static Engine Manipulator(this Engine en, string? name = null)
        {
            return en.Execute("Manipulator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///filters image by replacing every value by the median in its range-r neighborhood. 
        ///https://reference.wolfram.com/language/ref/MedianFilter.html
        ///</summary>
        public static Engine MedianFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MedianFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///connects to your default incoming mail server.
        ///https://reference.wolfram.com/language/ref/MailServerConnect.html
        ///</summary>
        public static Engine MailServerConnect(this Engine en, string? name = null)
        {
            return en.Execute("MailServerConnect[]", name);
        }

        ///<summary>
        ///gives the remainder on division of m by n. 
        ///https://reference.wolfram.com/language/ref/Mod.html
        ///</summary>
        public static Engine Mod(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Mod[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet indicating a menu request with title string.
        ///https://reference.wolfram.com/language/ref/MenuPacket.html
        ///</summary>
        public static Engine MenuPacket(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MenuPacket[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots the portion of the Mandelbrot set inside the rectangle with corners zmin and zmax.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetPlot.html
        ///</summary>
        public static Engine MandelbrotSetPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MandelbrotSetPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the portion of the Mandelbrot set inside the rectangle with corners zmin and zmax.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetPlot.html
        ///</summary>
        public static Engine MandelbrotSetPlot(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives Marcum's Q function .
        ///https://reference.wolfram.com/language/ref/MarcumQ.html
        ///</summary>
        public static Engine MarcumQ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MarcumQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/MinusPlus.html
        ///</summary>
        public static Engine MinusPlus(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinusPlus[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/MinusPlus.html
        ///</summary>
        public static Engine MinusPlus(this Engine en, string? name = null)
        {
            return en.Execute("MinusPlus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a graph constructed from the molecule mol.
        ///https://reference.wolfram.com/language/ref/MoleculeGraph.html
        ///</summary>
        public static Engine MoleculeGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a graph constructed from the molecule mol.
        ///https://reference.wolfram.com/language/ref/MoleculeGraph.html
        ///</summary>
        public static Engine MoleculeGraph(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Marchenko–Pastur distribution with asymptotic ratio  and scale parameter .
        ///https://reference.wolfram.com/language/ref/MarchenkoPasturDistribution.html
        ///</summary>
        public static Engine MarchenkoPasturDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MarchenkoPasturDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to the elements of expr, giving the part specification of each element as a second argument to f. 
        ///https://reference.wolfram.com/language/ref/MapIndexed.html
        ///</summary>
        public static Engine MapIndexed(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MapIndexed[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the modular lambda elliptic function . 
        ///https://reference.wolfram.com/language/ref/ModularLambda.html
        ///</summary>
        public static Engine ModularLambda(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ModularLambda[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the modular lambda elliptic function . 
        ///https://reference.wolfram.com/language/ref/ModularLambda.html
        ///</summary>
        public static Engine ModularLambda(this Engine en, string? name = null)
        {
            return en.Execute("ModularLambda[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the mean absolute deviation from the mean of the elements in list.
        ///https://reference.wolfram.com/language/ref/MeanDeviation.html
        ///</summary>
        public static Engine MeanDeviation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeanDeviation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the mean absolute deviation from the mean of the elements in list.
        ///https://reference.wolfram.com/language/ref/MeanDeviation.html
        ///</summary>
        public static Engine MeanDeviation(this Engine en, string? name = null)
        {
            return en.Execute("MeanDeviation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a mesh region representing the n-step Menger sponge. 
        ///https://reference.wolfram.com/language/ref/MengerMesh.html
        ///</summary>
        public static Engine MengerMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MengerMesh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a mesh region representing the n-step Menger sponge. 
        ///https://reference.wolfram.com/language/ref/MengerMesh.html
        ///</summary>
        public static Engine MengerMesh(this Engine en, string? name = null)
        {
            return en.Execute("MengerMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to return the systematic chemical name for the given molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeName.html
        ///</summary>
        public static Engine MoleculeName(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeName[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to return the systematic chemical name for the given molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeName.html
        ///</summary>
        public static Engine MoleculeName(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether data follows a MultinormalDistribution using the Mardia skewness test.
        ///https://reference.wolfram.com/language/ref/MardiaSkewnessTest.html
        ///</summary>
        public static Engine MardiaSkewnessTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MardiaSkewnessTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data follows a MultinormalDistribution using the Mardia skewness test.
        ///https://reference.wolfram.com/language/ref/MardiaSkewnessTest.html
        ///</summary>
        public static Engine MardiaSkewnessTest(this Engine en, string? name = null)
        {
            return en.Execute("MardiaSkewnessTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a version of expr with controls added to allow interactive manipulation of the value of u. 
        ///https://reference.wolfram.com/language/ref/Manipulate.html
        ///</summary>
        public static Engine Manipulate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Manipulate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that occurrences of the symbols x, y, … in expr should be treated as local. 
        ///https://reference.wolfram.com/language/ref/Module.html
        ///</summary>
        public static Engine Module(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Module[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Meixner distribution with location parameter m, scale parameter a, skew parameter b, and shape parameter d.
        ///https://reference.wolfram.com/language/ref/MeixnerDistribution.html
        ///</summary>
        public static Engine MeixnerDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MeixnerDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///creates a two-dimensional structure diagram of the molecule mol.
        ///https://reference.wolfram.com/language/ref/MoleculePlot.html
        ///</summary>
        public static Engine MoleculePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a two-dimensional structure diagram of the molecule mol.
        ///https://reference.wolfram.com/language/ref/MoleculePlot.html
        ///</summary>
        public static Engine MoleculePlot(this Engine en, string? name = null)
        {
            return en.Execute("MoleculePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a loss layer that computes the mean squared loss between its "Input" port and "Target" port.
        ///https://reference.wolfram.com/language/ref/MeanSquaredLossLayer.html
        ///</summary>
        public static Engine MeanSquaredLossLayer(this Engine en, string? name = null)
        {
            return en.Execute("MeanSquaredLossLayer[]", name);
        }

        ///<summary>
        ///executes the mail command cmd on the target mail server connection, folder, file or item(s).
        ///https://reference.wolfram.com/language/ref/MailExecute.html
        ///</summary>
        public static Engine MailExecute(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MailExecute[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the mean clustering coefficient of the graph g.
        ///https://reference.wolfram.com/language/ref/MeanClusteringCoefficient.html
        ///</summary>
        public static Engine MeanClusteringCoefficient(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeanClusteringCoefficient[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the mean clustering coefficient of the graph g.
        ///https://reference.wolfram.com/language/ref/MeanClusteringCoefficient.html
        ///</summary>
        public static Engine MeanClusteringCoefficient(this Engine en, string? name = null)
        {
            return en.Execute("MeanClusteringCoefficient[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if expr is a machine‐precision real or complex number, and returns False otherwise. 
        ///https://reference.wolfram.com/language/ref/MachineNumberQ.html
        ///</summary>
        public static Engine MachineNumberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MachineNumberQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if expr is a machine‐precision real or complex number, and returns False otherwise. 
        ///https://reference.wolfram.com/language/ref/MachineNumberQ.html
        ///</summary>
        public static Engine MachineNumberQ(this Engine en, string? name = null)
        {
            return en.Execute("MachineNumberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a mass concentration boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/MassConcentrationCondition.html
        ///</summary>
        public static Engine MassConcentrationCondition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MassConcentrationCondition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns True if mol is a valid Molecule expression, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MoleculeQ.html
        ///</summary>
        public static Engine MoleculeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if mol is a valid Molecule expression, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MoleculeQ.html
        ///</summary>
        public static Engine MoleculeQ(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the mean of the pixels in a range-r neighborhood and whose value is within a distance d.
        ///https://reference.wolfram.com/language/ref/MeanShiftFilter.html
        ///</summary>
        public static Engine MeanShiftFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MeanShiftFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list {IntegerPart[expr],FractionalPart[expr]}.
        ///https://reference.wolfram.com/language/ref/MixedFractionParts.html
        ///</summary>
        public static Engine MixedFractionParts(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MixedFractionParts[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list {IntegerPart[expr],FractionalPart[expr]}.
        ///https://reference.wolfram.com/language/ref/MixedFractionParts.html
        ///</summary>
        public static Engine MixedFractionParts(this Engine en, string? name = null)
        {
            return en.Execute("MixedFractionParts[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the low‐level function used in Wolfram System sessions to construct expressions from boxes. 
        ///https://reference.wolfram.com/language/ref/MakeExpression.html
        ///</summary>
        public static Engine MakeExpression(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MakeExpression[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a molecule pattern with atoms atomi and bonds bondi for use in substructure searching.
        ///https://reference.wolfram.com/language/ref/MoleculePattern.html
        ///</summary>
        public static Engine MoleculePattern(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculePattern[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of mean neighbor degrees of vertices for the graph g.
        ///https://reference.wolfram.com/language/ref/MeanNeighborDegree.html
        ///</summary>
        public static Engine MeanNeighborDegree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeanNeighborDegree[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of mean neighbor degrees of vertices for the graph g.
        ///https://reference.wolfram.com/language/ref/MeanNeighborDegree.html
        ///</summary>
        public static Engine MeanNeighborDegree(this Engine en, string? name = null)
        {
            return en.Execute("MeanNeighborDegree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the manned space mission entity.
        ///https://reference.wolfram.com/language/ref/MannedSpaceMissionData.html
        ///</summary>
        public static Engine MannedSpaceMissionData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MannedSpaceMissionData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the estimated number of bytes readily available for storing additional data in the current Wolfram Language kernel session.
        ///https://reference.wolfram.com/language/ref/MemoryAvailable.html
        ///</summary>
        public static Engine MemoryAvailable(this Engine en, string? name = null)
        {
            return en.Execute("MemoryAvailable[]", name);
        }

        ///<summary>
        ///represents a mass outflow boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/MassOutflowValue.html
        ///</summary>
        public static Engine MassOutflowValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MassOutflowValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list {Min[list],Max[list]}.
        ///https://reference.wolfram.com/language/ref/MinMax.html
        ///</summary>
        public static Engine MinMax(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinMax[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list {Min[list],Max[list]}.
        ///https://reference.wolfram.com/language/ref/MinMax.html
        ///</summary>
        public static Engine MinMax(this Engine en, string? name = null)
        {
            return en.Execute("MinMax[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if the pattern form matches expr, and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/MatchQ.html
        ///</summary>
        public static Engine MatchQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatchQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Matérn cluster point process with density μ, cluster mean λ and radius rm in .
        ///https://reference.wolfram.com/language/ref/MaternPointProcess.html
        ///</summary>
        public static Engine MaternPointProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MaternPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///or f//@expr applies f to every subexpression in expr. 
        ///https://reference.wolfram.com/language/ref/MapAll.html
        ///</summary>
        public static Engine MapAll(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MapAll[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the number of iterations of the function , beginning with , that are needed to determine whether c is in the Mandelbrot set.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetIterationCount.html
        ///</summary>
        public static Engine MandelbrotSetIterationCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MandelbrotSetIterationCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the number of iterations of the function , beginning with , that are needed to determine whether c is in the Mandelbrot set.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetIterationCount.html
        ///</summary>
        public static Engine MandelbrotSetIterationCount(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetIterationCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Mellin convolution with respect to x of the expressions f and g.
        ///https://reference.wolfram.com/language/ref/MellinConvolve.html
        ///</summary>
        public static Engine MellinConvolve(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MellinConvolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///tests whether data follows a MultinormalDistribution using the Mardia combined test.
        ///https://reference.wolfram.com/language/ref/MardiaCombinedTest.html
        ///</summary>
        public static Engine MardiaCombinedTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MardiaCombinedTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data follows a MultinormalDistribution using the Mardia combined test.
        ///https://reference.wolfram.com/language/ref/MardiaCombinedTest.html
        ///</summary>
        public static Engine MardiaCombinedTest(this Engine en, string? name = null)
        {
            return en.Execute("MardiaCombinedTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a molecule or list of molecules derived from the molecule mol by applying the modification "mod".
        ///https://reference.wolfram.com/language/ref/MoleculeModify.html
        ///</summary>
        public static Engine MoleculeModify(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeModify[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the r sample moment of the elements in list.
        ///https://reference.wolfram.com/language/ref/Moment.html
        ///</summary>
        public static Engine Moment(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Moment[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to each element on the first level in expr. 
        ///https://reference.wolfram.com/language/ref/Map.html
        ///</summary>
        public static Engine Map(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Map[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a summary of properties for the finite state Markov process mproc.
        ///https://reference.wolfram.com/language/ref/MarkovProcessProperties.html
        ///</summary>
        public static Engine MarkovProcessProperties(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MarkovProcessProperties[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a summary of properties for the finite state Markov process mproc.
        ///https://reference.wolfram.com/language/ref/MarkovProcessProperties.html
        ///</summary>
        public static Engine MarkovProcessProperties(this Engine en, string? name = null)
        {
            return en.Execute("MarkovProcessProperties[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts the moment expression mexpr to the specified form.  
        ///https://reference.wolfram.com/language/ref/MomentConvert.html
        ///</summary>
        public static Engine MomentConvert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MomentConvert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a mass transport PDE term with variables vars and parameters pars.
        ///https://reference.wolfram.com/language/ref/MassTransportPDEComponent.html
        ///</summary>
        public static Engine MassTransportPDEComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MassTransportPDEComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the moment-generating function for the distribution dist as a function of the variable t. 
        ///https://reference.wolfram.com/language/ref/MomentGeneratingFunction.html
        ///</summary>
        public static Engine MomentGeneratingFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MomentGeneratingFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///recognizes a molecule in image and returns it as a Molecule object.
        ///https://reference.wolfram.com/language/ref/MoleculeRecognize.html
        ///</summary>
        public static Engine MoleculeRecognize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeRecognize[" + arg0 + "]", name);
        }

        ///<summary>
        ///recognizes a molecule in image and returns it as a Molecule object.
        ///https://reference.wolfram.com/language/ref/MoleculeRecognize.html
        ///</summary>
        public static Engine MoleculeRecognize(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeRecognize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the list of bases of a numerical system in which different digits have different bases.
        ///https://reference.wolfram.com/language/ref/MixedRadix.html
        ///</summary>
        public static Engine MixedRadix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MixedRadix[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the list of bases of a numerical system in which different digits have different bases.
        ///https://reference.wolfram.com/language/ref/MixedRadix.html
        ///</summary>
        public static Engine MixedRadix(this Engine en, string? name = null)
        {
            return en.Execute("MixedRadix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the characteristic value  for odd Mathieu functions with characteristic exponent r and parameter q. 
        ///https://reference.wolfram.com/language/ref/MathieuCharacteristicB.html
        ///</summary>
        public static Engine MathieuCharacteristicB(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MathieuCharacteristicB[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns True if patt is not a substructure of molecule, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MoleculeFreeQ.html
        ///</summary>
        public static Engine MoleculeFreeQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeFreeQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///creates a three-dimensional model of the molecule mol.
        ///https://reference.wolfram.com/language/ref/MoleculePlot3D.html
        ///</summary>
        public static Engine MoleculePlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculePlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a three-dimensional model of the molecule mol.
        ///https://reference.wolfram.com/language/ref/MoleculePlot3D.html
        ///</summary>
        public static Engine MoleculePlot3D(this Engine en, string? name = null)
        {
            return en.Execute("MoleculePlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a loss layer that computes the mean absolute loss between the "Input" port and "Target" port.
        ///https://reference.wolfram.com/language/ref/MeanAbsoluteLossLayer.html
        ///</summary>
        public static Engine MeanAbsoluteLossLayer(this Engine en, string? name = null)
        {
            return en.Execute("MeanAbsoluteLossLayer[]", name);
        }

        ///<summary>
        ///gives the matching dissimilarity between Boolean vectors u and v.
        ///https://reference.wolfram.com/language/ref/MatchingDissimilarity.html
        ///</summary>
        public static Engine MatchingDissimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatchingDissimilarity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of coordinates in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/MeshCoordinates.html
        ///</summary>
        public static Engine MeshCoordinates(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeshCoordinates[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of coordinates in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/MeshCoordinates.html
        ///</summary>
        public static Engine MeshCoordinates(this Engine en, string? name = null)
        {
            return en.Execute("MeshCoordinates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the graphics primitives for cells of dimension d in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/MeshPrimitives.html
        ///</summary>
        public static Engine MeshPrimitives(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshPrimitives[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Mathieu group .
        ///https://reference.wolfram.com/language/ref/MathieuGroupM22.html
        ///</summary>
        public static Engine MathieuGroupM22(this Engine en, string? name = null)
        {
            return en.Execute("MathieuGroupM22[]", name);
        }

        ///<summary>
        ///represents a Morlet wavelet. 
        ///https://reference.wolfram.com/language/ref/MorletWavelet.html
        ///</summary>
        public static Engine MorletWavelet(this Engine en, string? name = null)
        {
            return en.Execute("MorletWavelet[]", name);
        }

        ///<summary>
        ///returns a version of mol that is aligned with reference molecule ref.
        ///https://reference.wolfram.com/language/ref/MoleculeAlign.html
        ///</summary>
        public static Engine MoleculeAlign(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeAlign[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the position of the Moon for the current date and location.
        ///https://reference.wolfram.com/language/ref/MoonPosition.html
        ///</summary>
        public static Engine MoonPosition(this Engine en, string? name = null)
        {
            return en.Execute("MoonPosition[]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive specifying that surfaces that follow are to be drawn with the material "material" appearance.
        ///https://reference.wolfram.com/language/ref/MaterialShading.html
        ///</summary>
        public static Engine MaterialShading(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MaterialShading[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive specifying that surfaces that follow are to be drawn with the material "material" appearance.
        ///https://reference.wolfram.com/language/ref/MaterialShading.html
        ///</summary>
        public static Engine MaterialShading(this Engine en, string? name = null)
        {
            return en.Execute("MaterialShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an object to be displayed with magnification r. 
        ///https://reference.wolfram.com/language/ref/Magnify.html
        ///</summary>
        public static Engine Magnify(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Magnify[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the median of the elements in list. 
        ///https://reference.wolfram.com/language/ref/Median.html
        ///</summary>
        public static Engine Median(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Median[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the median of the elements in list. 
        ///https://reference.wolfram.com/language/ref/Median.html
        ///</summary>
        public static Engine Median(this Engine en, string? name = null)
        {
            return en.Execute("Median[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///applies the function f to the 3×3 neighborhood of each pixel in a binary image image.
        ///https://reference.wolfram.com/language/ref/MorphologicalTransform.html
        ///</summary>
        public static Engine MorphologicalTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MorphologicalTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the cells of dimension d in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/MeshCells.html
        ///</summary>
        public static Engine MeshCells(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshCells[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives data corresponding to property for the mathematical function specified by entity.
        ///https://reference.wolfram.com/language/ref/MathematicalFunctionData.html
        ///</summary>
        public static Engine MathematicalFunctionData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MathematicalFunctionData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Mathieu group .
        ///https://reference.wolfram.com/language/ref/MathieuGroupM24.html
        ///</summary>
        public static Engine MathieuGroupM24(this Engine en, string? name = null)
        {
            return en.Execute("MathieuGroupM24[]", name);
        }

        ///<summary>
        ///gives the von Mangoldt function .
        ///https://reference.wolfram.com/language/ref/MangoldtLambda.html
        ///</summary>
        public static Engine MangoldtLambda(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MangoldtLambda[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the von Mangoldt function .
        ///https://reference.wolfram.com/language/ref/MangoldtLambda.html
        ///</summary>
        public static Engine MangoldtLambda(this Engine en, string? name = null)
        {
            return en.Execute("MangoldtLambda[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple monster group .
        ///https://reference.wolfram.com/language/ref/MonsterGroupM.html
        ///</summary>
        public static Engine MonsterGroupM(this Engine en, string? name = null)
        {
            return en.Execute("MonsterGroupM[]", name);
        }

        ///<summary>
        ///represents a mass symmetry boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/MassSymmetryValue.html
        ///</summary>
        public static Engine MassSymmetryValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MassSymmetryValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Mathieu group .
        ///https://reference.wolfram.com/language/ref/MathieuGroupM11.html
        ///</summary>
        public static Engine MathieuGroupM11(this Engine en, string? name = null)
        {
            return en.Execute("MathieuGroupM11[]", name);
        }

        ///<summary>
        ///gives the matrix logarithm of a matrix m.
        ///https://reference.wolfram.com/language/ref/MatrixLog.html
        ///</summary>
        public static Engine MatrixLog(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MatrixLog[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the matrix logarithm of a matrix m.
        ///https://reference.wolfram.com/language/ref/MatrixLog.html
        ///</summary>
        public static Engine MatrixLog(this Engine en, string? name = null)
        {
            return en.Execute("MatrixLog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the Meijer G function . 
        ///https://reference.wolfram.com/language/ref/MeijerG.html
        ///</summary>
        public static Engine MeijerG(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("MeijerG[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents a univariate marginal distribution of the k coordinate from the multivariate distribution dist.
        ///https://reference.wolfram.com/language/ref/MarginalDistribution.html
        ///</summary>
        public static Engine MarginalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MarginalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a version of a binary image image in which white pixels represent the morphological branch points.
        ///https://reference.wolfram.com/language/ref/MorphologicalBranchPoints.html
        ///</summary>
        public static Engine MorphologicalBranchPoints(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MorphologicalBranchPoints[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a version of a binary image image in which white pixels represent the morphological branch points.
        ///https://reference.wolfram.com/language/ref/MorphologicalBranchPoints.html
        ///</summary>
        public static Engine MorphologicalBranchPoints(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalBranchPoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a mass flux boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/MassFluxValue.html
        ///</summary>
        public static Engine MassFluxValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MassFluxValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the mean value in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/MeanFilter.html
        ///</summary>
        public static Engine MeanFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeanFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns True if the Molecule matches the given pattern.
        ///https://reference.wolfram.com/language/ref/MoleculeMatchQ.html
        ///</summary>
        public static Engine MoleculeMatchQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeMatchQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the current mouse position in the notebook front end. 
        ///https://reference.wolfram.com/language/ref/MousePosition.html
        ///</summary>
        public static Engine MousePosition(this Engine en, string? name = null)
        {
            return en.Execute("MousePosition[]", name);
        }

        ///<summary>
        ///represents a moving-average process of order q with normal white noise variance v.
        ///https://reference.wolfram.com/language/ref/MAProcess.html
        ///</summary>
        public static Engine MAProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MAProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the n  matrix power of the matrix m. 
        ///https://reference.wolfram.com/language/ref/MatrixPower.html
        ///</summary>
        public static Engine MatrixPower(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixPower[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a list of lists or a two-dimensional SparseArray object that can represent a matrix, and gives False otherwise. 
        ///https://reference.wolfram.com/language/ref/MatrixQ.html
        ///</summary>
        public static Engine MatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a list of lists or a two-dimensional SparseArray object that can represent a matrix, and gives False otherwise. 
        ///https://reference.wolfram.com/language/ref/MatrixQ.html
        ///</summary>
        public static Engine MatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("MatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the positive integer ID associated with expr if it is a managed library expression and $Failed otherwise.
        ///https://reference.wolfram.com/language/ref/ManagedLibraryExpressionID.html
        ///</summary>
        public static Engine ManagedLibraryExpressionID(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionID[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the positive integer ID associated with expr if it is a managed library expression and $Failed otherwise.
        ///https://reference.wolfram.com/language/ref/ManagedLibraryExpressionID.html
        ///</summary>
        public static Engine ManagedLibraryExpressionID(this Engine en, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionID[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates the mean point density  from point data pdata in the observation region reg. 
        ///https://reference.wolfram.com/language/ref/MeanPointDensity.html
        ///</summary>
        public static Engine MeanPointDensity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeanPointDensity[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the mean point density  from point data pdata in the observation region reg. 
        ///https://reference.wolfram.com/language/ref/MeanPointDensity.html
        ///</summary>
        public static Engine MeanPointDensity(this Engine en, string? name = null)
        {
            return en.Execute("MeanPointDensity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives moon phase fraction of illumination for the current date.
        ///https://reference.wolfram.com/language/ref/MoonPhase.html
        ///</summary>
        public static Engine MoonPhase(this Engine en, string? name = null)
        {
            return en.Execute("MoonPhase[]", name);
        }

        ///<summary>
        ///yields True if the graph g is a mixed graph and False otherwise. 
        ///https://reference.wolfram.com/language/ref/MixedGraphQ.html
        ///</summary>
        public static Engine MixedGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MixedGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a mixed graph and False otherwise. 
        ///https://reference.wolfram.com/language/ref/MixedGraphQ.html
        ///</summary>
        public static Engine MixedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("MixedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the n Mersenne prime exponent.
        ///https://reference.wolfram.com/language/ref/MersennePrimeExponent.html
        ///</summary>
        public static Engine MersennePrimeExponent(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MersennePrimeExponent[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n Mersenne prime exponent.
        ///https://reference.wolfram.com/language/ref/MersennePrimeExponent.html
        ///</summary>
        public static Engine MersennePrimeExponent(this Engine en, string? name = null)
        {
            return en.Execute("MersennePrimeExponent[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a global object assigned to be a list of the names of messages generated during the processing of the n input line. 
        ///https://reference.wolfram.com/language/ref/MessageList.html
        ///</summary>
        public static Engine MessageList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MessageList[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a global object assigned to be a list of the names of messages generated during the processing of the n input line. 
        ///https://reference.wolfram.com/language/ref/MessageList.html
        ///</summary>
        public static Engine MessageList(this Engine en, string? name = null)
        {
            return en.Execute("MessageList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a mail folder associated with an active mail server connection.
        ///https://reference.wolfram.com/language/ref/MailFolder.html
        ///</summary>
        public static Engine MailFolder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MailFolder[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a mail folder associated with an active mail server connection.
        ///https://reference.wolfram.com/language/ref/MailFolder.html
        ///</summary>
        public static Engine MailFolder(this Engine en, string? name = null)
        {
            return en.Execute("MailFolder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Mexican hat wavelet of width 1.
        ///https://reference.wolfram.com/language/ref/MexicanHatWavelet.html
        ///</summary>
        public static Engine MexicanHatWavelet(this Engine en, string? name = null)
        {
            return en.Execute("MexicanHatWavelet[]", name);
        }

        ///<summary>
        ///prints as a MathML form of expr. 
        ///https://reference.wolfram.com/language/ref/MathMLForm.html
        ///</summary>
        public static Engine MathMLForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MathMLForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as a MathML form of expr. 
        ///https://reference.wolfram.com/language/ref/MathMLForm.html
        ///</summary>
        public static Engine MathMLForm(this Engine en, string? name = null)
        {
            return en.Execute("MathMLForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list {c0,c1,…} of counts cd of cells of dimension d in the mesh region mreg. 
        ///https://reference.wolfram.com/language/ref/MeshCellCount.html
        ///</summary>
        public static Engine MeshCellCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeshCellCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list {c0,c1,…} of counts cd of cells of dimension d in the mesh region mreg. 
        ///https://reference.wolfram.com/language/ref/MeshCellCount.html
        ///</summary>
        public static Engine MeshCellCount(this Engine en, string? name = null)
        {
            return en.Execute("MeshCellCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the cell indices for cells of dimension d in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/MeshCellIndex.html
        ///</summary>
        public static Engine MeshCellIndex(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshCellIndex[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the derivative with respect to z of the even Mathieu function with characteristic value a and parameter q. 
        ///https://reference.wolfram.com/language/ref/MathieuCPrime.html
        ///</summary>
        public static Engine MathieuCPrime(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MathieuCPrime[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the morphological Euler number of regions in a binary image.
        ///https://reference.wolfram.com/language/ref/MorphologicalEulerNumber.html
        ///</summary>
        public static Engine MorphologicalEulerNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MorphologicalEulerNumber[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes the morphological Euler number of regions in a binary image.
        ///https://reference.wolfram.com/language/ref/MorphologicalEulerNumber.html
        ///</summary>
        public static Engine MorphologicalEulerNumber(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalEulerNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the medians of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/MannWhitneyTest.html
        ///</summary>
        public static Engine MannWhitneyTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MannWhitneyTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the medians of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/MannWhitneyTest.html
        ///</summary>
        public static Engine MannWhitneyTest(this Engine en, string? name = null)
        {
            return en.Execute("MannWhitneyTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the mountain entity.
        ///https://reference.wolfram.com/language/ref/MountainData.html
        ///</summary>
        public static Engine MountainData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MountainData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies f to size w windows in the specified data.
        ///https://reference.wolfram.com/language/ref/MovingMap.html
        ///</summary>
        public static Engine MovingMap(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MovingMap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an object that formats with the elements of list arranged in a grid with the indicated number of columns.
        ///https://reference.wolfram.com/language/ref/Multicolumn.html
        ///</summary>
        public static Engine Multicolumn(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Multicolumn[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the moving median of list, computed using spans of r elements.
        ///https://reference.wolfram.com/language/ref/MovingMedian.html
        ///</summary>
        public static Engine MovingMedian(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MovingMedian[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a plot that gives a visual representation of the values of elements in a matrix.
        ///https://reference.wolfram.com/language/ref/MatrixPlot.html
        ///</summary>
        public static Engine MatrixPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MatrixPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot that gives a visual representation of the values of elements in a matrix.
        ///https://reference.wolfram.com/language/ref/MatrixPlot.html
        ///</summary>
        public static Engine MatrixPlot(this Engine en, string? name = null)
        {
            return en.Execute("MatrixPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Mellin transform of expr.
        ///https://reference.wolfram.com/language/ref/MellinTransform.html
        ///</summary>
        public static Engine MellinTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MellinTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an object in which selecting the menu item with label lbli displays expri. 
        ///https://reference.wolfram.com/language/ref/MenuView.html
        ///</summary>
        public static Engine MenuView(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MenuView[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an object in which selecting the menu item with label lbli displays expri. 
        ///https://reference.wolfram.com/language/ref/MenuView.html
        ///</summary>
        public static Engine MenuView(this Engine en, string? name = null)
        {
            return en.Execute("MenuView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an array in which each pixel of image is replaced by an integer index representing the connected foreground image component in which the pixel lies.
        ///https://reference.wolfram.com/language/ref/MorphologicalComponents.html
        ///</summary>
        public static Engine MorphologicalComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MorphologicalComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an array in which each pixel of image is replaced by an integer index representing the connected foreground image component in which the pixel lies.
        ///https://reference.wolfram.com/language/ref/MorphologicalComponents.html
        ///</summary>
        public static Engine MorphologicalComponents(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a graph of points connected by lines.
        ///https://reference.wolfram.com/language/ref/MeshConnectivityGraph.html
        ///</summary>
        public static Engine MeshConnectivityGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshConnectivityGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if the majority of the ei are True, and False if the majority are False.
        ///https://reference.wolfram.com/language/ref/Majority.html
        ///</summary>
        public static Engine Majority(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Majority[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the minimum value of f with respect to x.
        ///https://reference.wolfram.com/language/ref/MinValue.html
        ///</summary>
        public static Engine MinValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether data follows a MultinormalDistribution using the Mardia kurtosis test.
        ///https://reference.wolfram.com/language/ref/MardiaKurtosisTest.html
        ///</summary>
        public static Engine MardiaKurtosisTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MardiaKurtosisTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data follows a MultinormalDistribution using the Mardia kurtosis test.
        ///https://reference.wolfram.com/language/ref/MardiaKurtosisTest.html
        ///</summary>
        public static Engine MardiaKurtosisTest(this Engine en, string? name = null)
        {
            return en.Execute("MardiaKurtosisTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents zero mean matrix  distribution with row covariance matrix Σrow, column covariance matrix Σcol, and degrees of freedom parameter ν.
        ///https://reference.wolfram.com/language/ref/MatrixTDistribution.html
        ///</summary>
        public static Engine MatrixTDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MatrixTDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives all the messages assigned to a particular symbol. 
        ///https://reference.wolfram.com/language/ref/Messages.html
        ///</summary>
        public static Engine Messages(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Messages[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives all the messages assigned to a particular symbol. 
        ///https://reference.wolfram.com/language/ref/Messages.html
        ///</summary>
        public static Engine Messages(this Engine en, string? name = null)
        {
            return en.Execute("Messages[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the meteor shower entity.
        ///https://reference.wolfram.com/language/ref/MeteorShowerData.html
        ///</summary>
        public static Engine MeteorShowerData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeteorShowerData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a single Quantity expression representing the addition of compatible units with magnitude values.
        ///https://reference.wolfram.com/language/ref/MixedRadixQuantity.html
        ///</summary>
        public static Engine MixedRadixQuantity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MixedRadixQuantity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multiplicative order of k modulo n, defined as the smallest integer  such that . 
        ///https://reference.wolfram.com/language/ref/MultiplicativeOrder.html
        ///</summary>
        public static Engine MultiplicativeOrder(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MultiplicativeOrder[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the characteristic exponent r for Mathieu functions with characteristic value a and parameter q. 
        ///https://reference.wolfram.com/language/ref/MathieuCharacteristicExponent.html
        ///</summary>
        public static Engine MathieuCharacteristicExponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MathieuCharacteristicExponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a count of the number of times patt appears as a substructure in mol.
        ///https://reference.wolfram.com/language/ref/MoleculeSubstructureCount.html
        ///</summary>
        public static Engine MoleculeSubstructureCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeSubstructureCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the max limit xx*f(x). 
        ///https://reference.wolfram.com/language/ref/MaxLimit.html
        ///</summary>
        public static Engine MaxLimit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MaxLimit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an Around object describing the mean of the xi and its uncertainty.
        ///https://reference.wolfram.com/language/ref/MeanAround.html
        ///</summary>
        public static Engine MeanAround(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeanAround[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an Around object describing the mean of the xi and its uncertainty.
        ///https://reference.wolfram.com/language/ref/MeanAround.html
        ///</summary>
        public static Engine MeanAround(this Engine en, string? name = null)
        {
            return en.Execute("MeanAround[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints with the elements of list arranged in a regular array. 
        ///https://reference.wolfram.com/language/ref/MatrixForm.html
        ///</summary>
        public static Engine MatrixForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MatrixForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with the elements of list arranged in a regular array. 
        ///https://reference.wolfram.com/language/ref/MatrixForm.html
        ///</summary>
        public static Engine MatrixForm(this Engine en, string? name = null)
        {
            return en.Execute("MatrixForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a mass transfer boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/MassTransferValue.html
        ///</summary>
        public static Engine MassTransferValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MassTransferValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a temporary monitor cell in which the continually updated current value of mon is displayed during the course of evaluation of expr. 
        ///https://reference.wolfram.com/language/ref/Monitor.html
        ///</summary>
        public static Engine Monitor(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Monitor[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the median absolute deviation from the median of the elements in list.
        ///https://reference.wolfram.com/language/ref/MedianDeviation.html
        ///</summary>
        public static Engine MedianDeviation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MedianDeviation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the median absolute deviation from the median of the elements in list.
        ///https://reference.wolfram.com/language/ref/MedianDeviation.html
        ///</summary>
        public static Engine MedianDeviation(this Engine en, string? name = null)
        {
            return en.Execute("MedianDeviation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Mathieu group .
        ///https://reference.wolfram.com/language/ref/MathieuGroupM23.html
        ///</summary>
        public static Engine MathieuGroupM23(this Engine en, string? name = null)
        {
            return en.Execute("MathieuGroupM23[]", name);
        }

        ///<summary>
        ///is a WSTP packet containing a Wolfram Language message identifier of the form symbol::string.
        ///https://reference.wolfram.com/language/ref/MessagePacket.html
        ///</summary>
        public static Engine MessagePacket(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MessagePacket[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the midpoint of the line segment connecting the points p1 and p2.
        ///https://reference.wolfram.com/language/ref/Midpoint.html
        ///</summary>
        public static Engine Midpoint(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Midpoint[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the midpoint of the line segment connecting the points p1 and p2.
        ///https://reference.wolfram.com/language/ref/Midpoint.html
        ///</summary>
        public static Engine Midpoint(this Engine en, string? name = null)
        {
            return en.Execute("Midpoint[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if patt is a substructure of molecule, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MoleculeContainsQ.html
        ///</summary>
        public static Engine MoleculeContainsQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeContainsQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a graph object that represents the connectivity of the morphological branch points and endpoints of the objects in image after applying morphological thinning.
        ///https://reference.wolfram.com/language/ref/MorphologicalGraph.html
        ///</summary>
        public static Engine MorphologicalGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MorphologicalGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a graph object that represents the connectivity of the morphological branch points and endpoints of the objects in image after applying morphological thinning.
        ///https://reference.wolfram.com/language/ref/MorphologicalGraph.html
        ///</summary>
        public static Engine MorphologicalGraph(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a property identified by pname for use in MoleculeValue.
        ///https://reference.wolfram.com/language/ref/MoleculeProperty.html
        ///</summary>
        public static Engine MoleculeProperty(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeProperty[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a property identified by pname for use in MoleculeValue.
        ///https://reference.wolfram.com/language/ref/MoleculeProperty.html
        ///</summary>
        public static Engine MoleculeProperty(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeProperty[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of bytes currently being used to store all data in the current Wolfram Language kernel session. 
        ///https://reference.wolfram.com/language/ref/MemoryInUse.html
        ///</summary>
        public static Engine MemoryInUse(this Engine en, string? name = null)
        {
            return en.Execute("MemoryInUse[]", name);
        }

        ///<summary>
        ///represents an object that displays as over when the mouse pointer is over it, and as expr otherwise. 
        ///https://reference.wolfram.com/language/ref/Mouseover.html
        ///</summary>
        public static Engine Mouseover(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Mouseover[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///creates a binary image from image by replacing all values above the upper threshold t2 with 1, also including pixels with intensities above the lower threshold t1 that are connected to the foreground.
        ///https://reference.wolfram.com/language/ref/MorphologicalBinarize.html
        ///</summary>
        public static Engine MorphologicalBinarize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MorphologicalBinarize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the region reg is a valid MeshRegion object and False otherwise.
        ///https://reference.wolfram.com/language/ref/MeshRegionQ.html
        ///</summary>
        public static Engine MeshRegionQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeshRegionQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the region reg is a valid MeshRegion object and False otherwise.
        ///https://reference.wolfram.com/language/ref/MeshRegionQ.html
        ///</summary>
        public static Engine MeshRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("MeshRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if z is in the Mandelbrot set, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetMemberQ.html
        ///</summary>
        public static Engine MandelbrotSetMemberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MandelbrotSetMemberQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if z is in the Mandelbrot set, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetMemberQ.html
        ///</summary>
        public static Engine MandelbrotSetMemberQ(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetMemberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the odd Mathieu function with characteristic value a and parameter q. 
        ///https://reference.wolfram.com/language/ref/MathieuS.html
        ///</summary>
        public static Engine MathieuS(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MathieuS[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives {f[a1,b1,…],f[a2,b2,…],…}. 
        ///https://reference.wolfram.com/language/ref/MapThread.html
        ///</summary>
        public static Engine MapThread(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MapThread[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///evaluates formal moments in the moment expression mexpr on the distribution dist.
        ///https://reference.wolfram.com/language/ref/MomentEvaluate.html
        ///</summary>
        public static Engine MomentEvaluate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MomentEvaluate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the movie entity.
        ///https://reference.wolfram.com/language/ref/MovieData.html
        ///</summary>
        public static Engine MovieData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MovieData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a mass impermeable boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/MassImpermeableBoundaryValue.html
        ///</summary>
        public static Engine MassImpermeableBoundaryValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MassImpermeableBoundaryValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the model predictive controller for the system specification sspec that minimizes the cost function cost and satisfies the constraints cons.
        ///https://reference.wolfram.com/language/ref/ModelPredictiveController.html
        ///</summary>
        public static Engine ModelPredictiveController(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ModelPredictiveController[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the even Mathieu function with characteristic value a and parameter q. 
        ///https://reference.wolfram.com/language/ref/MathieuC.html
        ///</summary>
        public static Engine MathieuC(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MathieuC[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///prints the message symbol::tag unless it has been switched off. 
        ///https://reference.wolfram.com/language/ref/Message.html
        ///</summary>
        public static Engine Message(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Message[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints the message symbol::tag unless it has been switched off. 
        ///https://reference.wolfram.com/language/ref/Message.html
        ///</summary>
        public static Engine Message(this Engine en, string? name = null)
        {
            return en.Execute("Message[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Mathieu group .
        ///https://reference.wolfram.com/language/ref/MathieuGroupM12.html
        ///</summary>
        public static Engine MathieuGroupM12(this Engine en, string? name = null)
        {
            return en.Execute("MathieuGroupM12[]", name);
        }

        ///<summary>
        ///returns True if n is a Mersenne prime exponent, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MersennePrimeExponentQ.html
        ///</summary>
        public static Engine MersennePrimeExponentQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MersennePrimeExponentQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if n is a Mersenne prime exponent, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MersennePrimeExponentQ.html
        ///</summary>
        public static Engine MersennePrimeExponentQ(this Engine en, string? name = null)
        {
            return en.Execute("MersennePrimeExponentQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the moving average of list, computed by averaging runs of r elements.
        ///https://reference.wolfram.com/language/ref/MovingAverage.html
        ///</summary>
        public static Engine MovingAverage(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MovingAverage[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the rank of the matrix m. 
        ///https://reference.wolfram.com/language/ref/MatrixRank.html
        ///</summary>
        public static Engine MatrixRank(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MatrixRank[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the rank of the matrix m. 
        ///https://reference.wolfram.com/language/ref/MatrixRank.html
        ///</summary>
        public static Engine MatrixRank(this Engine en, string? name = null)
        {
            return en.Execute("MatrixRank[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///computes the moment of inertia for the region reg rotating around an axis through the point pt in direction v.
        ///https://reference.wolfram.com/language/ref/MomentOfInertia.html
        ///</summary>
        public static Engine MomentOfInertia(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MomentOfInertia[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a molecule pattern representing the largest common substructure for the input molecules.
        ///https://reference.wolfram.com/language/ref/MoleculeMaximumCommonSubstructure.html
        ///</summary>
        public static Engine MoleculeMaximumCommonSubstructure(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeMaximumCommonSubstructure[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a molecule pattern representing the largest common substructure for the input molecules.
        ///https://reference.wolfram.com/language/ref/MoleculeMaximumCommonSubstructure.html
        ///</summary>
        public static Engine MoleculeMaximumCommonSubstructure(this Engine en, string? name = null)
        {
            return en.Execute("MoleculeMaximumCommonSubstructure[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents zero mean matrix normal distribution with row covariance matrix Σrow and column covariance matrix Σcol.
        ///https://reference.wolfram.com/language/ref/MatrixNormalDistribution.html
        ///</summary>
        public static Engine MatrixNormalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixNormalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns True if an element of list matches form, and False otherwise. 
        ///https://reference.wolfram.com/language/ref/MemberQ.html
        ///</summary>
        public static Engine MemberQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MemberQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives any mouse annotation associated with the expression at the current mouse position. 
        ///https://reference.wolfram.com/language/ref/MouseAnnotation.html
        ///</summary>
        public static Engine MouseAnnotation(this Engine en, string? name = null)
        {
            return en.Execute("MouseAnnotation[]", name);
        }

        ///<summary>
        ///represents the distribution of the matrix property expr where the matrix-valued random variable x follows the matrix distribution mdist.
        ///https://reference.wolfram.com/language/ref/MatrixPropertyDistribution.html
        ///</summary>
        public static Engine MatrixPropertyDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixPropertyDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///merges the associations associ, using the function f to combine values with the same key. 
        ///https://reference.wolfram.com/language/ref/Merge.html
        ///</summary>
        public static Engine Merge(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Merge[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///attempts to reduce expr to a single MeijerG object as a function of x.
        ///https://reference.wolfram.com/language/ref/MeijerGReduce.html
        ///</summary>
        public static Engine MeijerGReduce(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeijerGReduce[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the given molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeValue.html
        ///</summary>
        public static Engine MoleculeValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the values of all properties for the specified demographic.
        ///https://reference.wolfram.com/language/ref/MortalityData.html
        ///</summary>
        public static Engine MortalityData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MortalityData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the values of all properties for the specified demographic.
        ///https://reference.wolfram.com/language/ref/MortalityData.html
        ///</summary>
        public static Engine MortalityData(this Engine en, string? name = null)
        {
            return en.Execute("MortalityData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields the numerically largest of the xi. 
        ///https://reference.wolfram.com/language/ref/Max.html
        ///</summary>
        public static Engine Max(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Max[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Möbius function . 
        ///https://reference.wolfram.com/language/ref/MoebiusMu.html
        ///</summary>
        public static Engine MoebiusMu(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoebiusMu[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Möbius function . 
        ///https://reference.wolfram.com/language/ref/MoebiusMu.html
        ///</summary>
        public static Engine MoebiusMu(this Engine en, string? name = null)
        {
            return en.Execute("MoebiusMu[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///minimizes f exactly with respect to x.
        ///https://reference.wolfram.com/language/ref/Minimize.html
        ///</summary>
        public static Engine Minimize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Minimize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list containing the mantissa and exponent of a number x. 
        ///https://reference.wolfram.com/language/ref/MantissaExponent.html
        ///</summary>
        public static Engine MantissaExponent(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MantissaExponent[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list containing the mantissa and exponent of a number x. 
        ///https://reference.wolfram.com/language/ref/MantissaExponent.html
        ///</summary>
        public static Engine MantissaExponent(this Engine en, string? name = null)
        {
            return en.Execute("MantissaExponent[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the matrix generated by the scalar function f at the matrix argument m.
        ///https://reference.wolfram.com/language/ref/MatrixFunction.html
        ///</summary>
        public static Engine MatrixFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the mineral entity.
        ///https://reference.wolfram.com/language/ref/MineralData.html
        ///</summary>
        public static Engine MineralData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MineralData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of all monomials in the polynomial poly.
        ///https://reference.wolfram.com/language/ref/MonomialList.html
        ///</summary>
        public static Engine MonomialList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MonomialList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of all monomials in the polynomial poly.
        ///https://reference.wolfram.com/language/ref/MonomialList.html
        ///</summary>
        public static Engine MonomialList(this Engine en, string? name = null)
        {
            return en.Execute("MonomialList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///picks out the morphological perimeter of regions of foreground in image.
        ///https://reference.wolfram.com/language/ref/MorphologicalPerimeter.html
        ///</summary>
        public static Engine MorphologicalPerimeter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MorphologicalPerimeter[" + arg0 + "]", name);
        }

        ///<summary>
        ///picks out the morphological perimeter of regions of foreground in image.
        ///https://reference.wolfram.com/language/ref/MorphologicalPerimeter.html
        ///</summary>
        public static Engine MorphologicalPerimeter(this Engine en, string? name = null)
        {
            return en.Execute("MorphologicalPerimeter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns lists of file formats corresponding to all registered MIME types.
        ///https://reference.wolfram.com/language/ref/MIMETypeToFormatList.html
        ///</summary>
        public static Engine MIMETypeToFormatList(this Engine en, string? name = null)
        {
            return en.Execute("MIMETypeToFormatList[]", name);
        }

        ///<summary>
        ///gives the characteristic value  for even Mathieu functions with characteristic exponent r and parameter q. 
        ///https://reference.wolfram.com/language/ref/MathieuCharacteristicA.html
        ///</summary>
        public static Engine MathieuCharacteristicA(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MathieuCharacteristicA[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the domain of matrices of dimensions d1×d2.
        ///https://reference.wolfram.com/language/ref/Matrices.html
        ///</summary>
        public static Engine Matrices(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Matrices[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the domain of matrices of dimensions d1×d2.
        ///https://reference.wolfram.com/language/ref/Matrices.html
        ///</summary>
        public static Engine Matrices(this Engine en, string? name = null)
        {
            return en.Execute("Matrices[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a multigraph and False otherwise.
        ///https://reference.wolfram.com/language/ref/MultigraphQ.html
        ///</summary>
        public static Engine MultigraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MultigraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a multigraph and False otherwise.
        ///https://reference.wolfram.com/language/ref/MultigraphQ.html
        ///</summary>
        public static Engine MultigraphQ(this Engine en, string? name = null)
        {
            return en.Execute("MultigraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the derivative with respect to z of the odd Mathieu function with characteristic value a and parameter q. 
        ///https://reference.wolfram.com/language/ref/MathieuSPrime.html
        ///</summary>
        public static Engine MathieuSPrime(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MathieuSPrime[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///multiplies each side of the equation or inequality rel by x.
        ///https://reference.wolfram.com/language/ref/MultiplySides.html
        ///</summary>
        public static Engine MultiplySides(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MultiplySides[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Meyer wavelet of order 3.
        ///https://reference.wolfram.com/language/ref/MeyerWavelet.html
        ///</summary>
        public static Engine MeyerWavelet(this Engine en, string? name = null)
        {
            return en.Execute("MeyerWavelet[]", name);
        }

        ///<summary>
        ///represents a Moyal distribution with location parameter μ and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/MoyalDistribution.html
        ///</summary>
        public static Engine MoyalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoyalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///puts up a standard message dialog that displays expr together with an OK button.
        ///https://reference.wolfram.com/language/ref/MessageDialog.html
        ///</summary>
        public static Engine MessageDialog(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MessageDialog[" + arg0 + "]", name);
        }

        ///<summary>
        ///puts up a standard message dialog that displays expr together with an OK button.
        ///https://reference.wolfram.com/language/ref/MessageDialog.html
        ///</summary>
        public static Engine MessageDialog(this Engine en, string? name = null)
        {
            return en.Execute("MessageDialog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives expr with the last element removed. 
        ///https://reference.wolfram.com/language/ref/Most.html
        ///</summary>
        public static Engine Most(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Most[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives expr with the last element removed. 
        ///https://reference.wolfram.com/language/ref/Most.html
        ///</summary>
        public static Engine Most(this Engine en, string? name = null)
        {
            return en.Execute("Most[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///changes the mouse cursor to appear as graphic when the mouse pointer is in the area where expr is displayed.
        ///https://reference.wolfram.com/language/ref/MouseAppearance.html
        ///</summary>
        public static Engine MouseAppearance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MouseAppearance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a mesh with cells mcellj, where coordinates given as integer i are taken to be pi.
        ///https://reference.wolfram.com/language/ref/MeshRegion.html
        ///</summary>
        public static Engine MeshRegion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshRegion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the latest date of the datei.
        ///https://reference.wolfram.com/language/ref/MaxDate.html
        ///</summary>
        public static Engine MaxDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MaxDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the latest date of the datei.
        ///https://reference.wolfram.com/language/ref/MaxDate.html
        ///</summary>
        public static Engine MaxDate(this Engine en, string? name = null)
        {
            return en.Execute("MaxDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the minimum time increment in the time series tseries.
        ///https://reference.wolfram.com/language/ref/MinimumTimeIncrement.html
        ///</summary>
        public static Engine MinimumTimeIncrement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinimumTimeIncrement[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the minimum time increment in the time series tseries.
        ///https://reference.wolfram.com/language/ref/MinimumTimeIncrement.html
        ///</summary>
        public static Engine MinimumTimeIncrement(this Engine en, string? name = null)
        {
            return en.Execute("MinimumTimeIncrement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the minimum value in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/MinFilter.html
        ///</summary>
        public static Engine MinFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the matrix exponential of m. 
        ///https://reference.wolfram.com/language/ref/MatrixExp.html
        ///</summary>
        public static Engine MatrixExp(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MatrixExp[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the matrix exponential of m. 
        ///https://reference.wolfram.com/language/ref/MatrixExp.html
        ///</summary>
        public static Engine MatrixExp(this Engine en, string? name = null)
        {
            return en.Execute("MatrixExp[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields the numerically smallest of the xi. 
        ///https://reference.wolfram.com/language/ref/Min.html
        ///</summary>
        public static Engine Min(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Min[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multinomial coefficient . 
        ///https://reference.wolfram.com/language/ref/Multinomial.html
        ///</summary>
        public static Engine Multinomial(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Multinomial[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a binary image in which white pixels correspond to constant extended maxima in image.
        ///https://reference.wolfram.com/language/ref/MaxDetect.html
        ///</summary>
        public static Engine MaxDetect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MaxDetect[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a binary image in which white pixels correspond to constant extended maxima in image.
        ///https://reference.wolfram.com/language/ref/MaxDetect.html
        ///</summary>
        public static Engine MaxDetect(this Engine en, string? name = null)
        {
            return en.Execute("MaxDetect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a multinomial distribution with n trials and probabilities pi.
        ///https://reference.wolfram.com/language/ref/MultinomialDistribution.html
        ///</summary>
        public static Engine MultinomialDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MultinomialDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of the ei for which the value of f[ei] is minimal.
        ///https://reference.wolfram.com/language/ref/MinimalBy.html
        ///</summary>
        public static Engine MinimalBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinimalBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the earliest date of the datei.
        ///https://reference.wolfram.com/language/ref/MinDate.html
        ///</summary>
        public static Engine MinDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the earliest date of the datei.
        ///https://reference.wolfram.com/language/ref/MinDate.html
        ///</summary>
        public static Engine MinDate(this Engine en, string? name = null)
        {
            return en.Execute("MinDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a multivariate hypergeometric distribution with n draws without replacement from a collection containing mi objects of type i. 
        ///https://reference.wolfram.com/language/ref/MultivariateHypergeometricDistribution.html
        ///</summary>
        public static Engine MultivariateHypergeometricDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MultivariateHypergeometricDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a multivariate normal (Gaussian) distribution with mean vector μ and covariance matrix Σ.
        ///https://reference.wolfram.com/language/ref/MultinormalDistribution.html
        ///</summary>
        public static Engine MultinormalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MultinormalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the maximum value in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/MaxFilter.html
        ///</summary>
        public static Engine MaxFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MaxFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the minimal polynomial in x for which the algebraic number s is a root. 
        ///https://reference.wolfram.com/language/ref/MinimalPolynomial.html
        ///</summary>
        public static Engine MinimalPolynomial(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinimalPolynomial[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a binary image in which white pixels correspond to constant extended minima in image.
        ///https://reference.wolfram.com/language/ref/MinDetect.html
        ///</summary>
        public static Engine MinDetect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinDetect[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a binary image in which white pixels correspond to constant extended minima in image.
        ///https://reference.wolfram.com/language/ref/MinDetect.html
        ///</summary>
        public static Engine MinDetect(this Engine en, string? name = null)
        {
            return en.Execute("MinDetect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a multivariate Poisson distribution with mean vector {μ0+μ1,μ0+μ2,…}.
        ///https://reference.wolfram.com/language/ref/MultivariatePoissonDistribution.html
        ///</summary>
        public static Engine MultivariatePoissonDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MultivariatePoissonDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of the ei for which the value of f[ei] is maximal.
        ///https://reference.wolfram.com/language/ref/MaximalBy.html
        ///</summary>
        public static Engine MaximalBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MaximalBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the minimal state-space model of the state-space model sys.
        ///https://reference.wolfram.com/language/ref/MinimalStateSpaceModel.html
        ///</summary>
        public static Engine MinimalStateSpaceModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinimalStateSpaceModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the minimal state-space model of the state-space model sys.
        ///https://reference.wolfram.com/language/ref/MinimalStateSpaceModel.html
        ///</summary>
        public static Engine MinimalStateSpaceModel(this Engine en, string? name = null)
        {
            return en.Execute("MinimalStateSpaceModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the multivariate Student  distribution with scale matrix Σ and degrees of freedom parameter ν.
        ///https://reference.wolfram.com/language/ref/MultivariateTDistribution.html
        ///</summary>
        public static Engine MultivariateTDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MultivariateTDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///maximizes f exactly with respect to x.
        ///https://reference.wolfram.com/language/ref/Maximize.html
        ///</summary>
        public static Engine Maximize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Maximize[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}
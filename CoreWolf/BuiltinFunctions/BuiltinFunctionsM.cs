using System.Collections.Generic;

namespace CoreWolf
{
    public static class BuiltinFunctionM
    {
        ///<summary>
        ///returns True if expr is a machine‐precision real or complex number, and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/MachineNumberQ.html
        ///</summary>
        public static Engine MachineNumberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MachineNumberQ[" + arg0 + "]", name);
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
        ///displays with expr magnified by a fixed factor.
        ///https://reference.wolfram.com/language/ref/Magnify.html
        ///</summary>
        public static Engine Magnify(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Magnify[" + arg0 + "]", name);
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
        ///represents a mail folder associated with an active mail server connection.
        ///https://reference.wolfram.com/language/ref/MailFolder.html
        ///</summary>
        public static Engine MailFolder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MailFolder[" + arg0 + "]", name);
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
        ///represents a mail receiver function that applies fun to any mail message it receives.
        ///https://reference.wolfram.com/language/ref/MailReceiverFunction.html
        ///</summary>
        public static Engine MailReceiverFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MailReceiverFunction[" + arg0 + "]", name);
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
        ///searches the current default mail inbox.
        ///https://reference.wolfram.com/language/ref/MailSearch.html
        ///</summary>
        public static Engine MailSearch(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MailSearch[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of unread messages in the current default mail inbox.
        ///https://reference.wolfram.com/language/ref/MailSearch.html
        ///</summary>
        public static Engine MailSearch(this Engine en, string? name = null)
        {
            return en.Execute("MailSearch[]", name);
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
        ///connects to the specified incoming mail server "server".
        ///https://reference.wolfram.com/language/ref/MailServerConnect.html
        ///</summary>
        public static Engine MailServerConnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MailServerConnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///connects using the specified user ID userid.
        ///https://reference.wolfram.com/language/ref/MailServerConnect.html
        ///</summary>
        public static Engine MailServerConnect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MailServerConnect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///connects using userid and password.
        ///https://reference.wolfram.com/language/ref/MailServerConnect.html
        ///</summary>
        public static Engine MailServerConnect(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MailServerConnect[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives True if the majority of the ei are True, and False if the majority are False.
        ///https://reference.wolfram.com/language/ref/Majority.html
        ///</summary>
        public static Engine Majority(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Majority[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///is the function to convert expr to StandardForm boxes.
        ///https://reference.wolfram.com/language/ref/MakeBoxes.html
        ///</summary>
        public static Engine MakeBoxes(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MakeBoxes[" + arg0 + "]", name);
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
        ///returns the positive integer ID associated with expr if it is a managed library expression and $Failed otherwise.
        ///https://reference.wolfram.com/language/ref/ManagedLibraryExpressionID.html
        ///</summary>
        public static Engine ManagedLibraryExpressionID(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionID[" + arg0 + "]", name);
        }

        ///<summary>
        ///only returns the ID if expr is associated with the registered manager having name mname.
        ///https://reference.wolfram.com/language/ref/ManagedLibraryExpressionID.html
        ///</summary>
        public static Engine ManagedLibraryExpressionID(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionID[" + arg0 + ", " + arg1 + "]", name);
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
        ///only returns True if expr is associated with the registered manager having name mname.
        ///https://reference.wolfram.com/language/ref/ManagedLibraryExpressionQ.html
        ///</summary>
        public static Engine ManagedLibraryExpressionQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ManagedLibraryExpressionQ[" + arg0 + ", " + arg1 + "]", name);
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
        ///estimates the distance from c to the nearest point in the Mandelbrot set.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetDistance.html
        ///</summary>
        public static Engine MandelbrotSetDistance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MandelbrotSetDistance[" + arg0 + "]", name);
        }

        ///<summary>
        ///estimates the distance from c to the nearest point in the complement of the Mandelbrot set.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetDistance.html
        ///</summary>
        public static Engine MandelbrotSetDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MandelbrotSetDistance[" + arg0 + ", " + arg1 + "]", name);
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
        ///returns True if z is in the Mandelbrot set, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetMemberQ.html
        ///</summary>
        public static Engine MandelbrotSetMemberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MandelbrotSetMemberQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the portion of the Mandelbrot set inside the rectangle with corners zmin and zmax.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetPlot.html
        ///</summary>
        public static Engine MandelbrotSetPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MandelbrotSetPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots the Mandelbrot set over a default rectangle.
        ///https://reference.wolfram.com/language/ref/MandelbrotSetPlot.html
        ///</summary>
        public static Engine MandelbrotSetPlot(this Engine en, string? name = null)
        {
            return en.Execute("MandelbrotSetPlot[]", name);
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
        ///gives the Manhattan or "city block" distance between vectors u and v.
        ///https://reference.wolfram.com/language/ref/ManhattanDistance.html
        ///</summary>
        public static Engine ManhattanDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ManhattanDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a version of expr with controls added to allow interactive manipulation of the value of u.
        ///https://reference.wolfram.com/language/ref/Manipulate.html
        ///</summary>
        public static Engine Manipulate(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Manipulate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///allows u to take on discrete values u1,u2,….
        ///https://reference.wolfram.com/language/ref/Manipulate.html
        ///</summary>
        public static Engine Manipulate(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Manipulate[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///provides controls to manipulate each of the u,v,….
        ///https://reference.wolfram.com/language/ref/Manipulate.html
        ///</summary>
        public static Engine Manipulate(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("Manipulate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///links the controls to the specified controllers on an external device.
        ///https://reference.wolfram.com/language/ref/Manipulate.html
        ///</summary>
        public static Engine Manipulate(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Manipulate[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///represents a manipulator with range xmin to xmax.
        ///https://reference.wolfram.com/language/ref/Manipulator.html
        ///</summary>
        public static Engine Manipulator(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Manipulator[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///gives a list of property values for the specified manned space mission entities.
        ///https://reference.wolfram.com/language/ref/MannedSpaceMissionData.html
        ///</summary>
        public static Engine MannedSpaceMissionData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MannedSpaceMissionData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/MannedSpaceMissionData.html
        ///</summary>
        public static Engine MannedSpaceMissionData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MannedSpaceMissionData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the medians of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/MannWhitneyTest.html
        ///</summary>
        public static Engine MannWhitneyTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MannWhitneyTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///tests the median difference against μ0.
        ///https://reference.wolfram.com/language/ref/MannWhitneyTest.html
        ///</summary>
        public static Engine MannWhitneyTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MannWhitneyTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/MannWhitneyTest.html
        ///</summary>
        public static Engine MannWhitneyTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MannWhitneyTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the base‐b mantissa and exponent of x.
        ///https://reference.wolfram.com/language/ref/MantissaExponent.html
        ///</summary>
        public static Engine MantissaExponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MantissaExponent[" + arg0 + ", " + arg1 + "]", name);
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
        ///replaces heads at level 1 of expr by f.
        ///https://reference.wolfram.com/language/ref/MapApply.html
        ///</summary>
        public static Engine MapApply(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MapApply[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of MapApply that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/MapApply.html
        ///</summary>
        public static Engine MapApply(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MapApply[" + arg0 + "]", name);
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
        ///applies f to the part of expr at position {i,j,…}.
        ///https://reference.wolfram.com/language/ref/MapAt.html
        ///</summary>
        public static Engine MapAt(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("MapAt[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///applies f to parts of expr at several positions.
        ///https://reference.wolfram.com/language/ref/MapAt.html
        ///</summary>
        public static Engine MapAt(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("MapAt[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of MapAt that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/MapAt.html
        ///</summary>
        public static Engine MapAt(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MapAt[" + arg0 + ", " + arg1 + "]", name);
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
        ///applies f to all parts of expr on levels specified by levelspec.
        ///https://reference.wolfram.com/language/ref/MapIndexed.html
        ///</summary>
        public static Engine MapIndexed(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MapIndexed[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of MapIndexed that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/MapIndexed.html
        ///</summary>
        public static Engine MapIndexed(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MapIndexed[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a moving-average process of order q with normal white noise variance v.
        ///https://reference.wolfram.com/language/ref/MAProcess.html
        ///</summary>
        public static Engine MAProcess(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an MA process with initial data init.
        ///https://reference.wolfram.com/language/ref/MAProcess.html
        ///</summary>
        public static Engine MAProcess(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an MA process with a constant c.
        ///https://reference.wolfram.com/language/ref/MAProcess.html
        ///</summary>
        public static Engine MAProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MAProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives {f[a1,b1,…],f[a2,b2,…],…}.
        ///https://reference.wolfram.com/language/ref/MapThread.html
        ///</summary>
        public static Engine MapThread(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("MapThread[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///applies f to the parts of the expri at level n.
        ///https://reference.wolfram.com/language/ref/MapThread.html
        ///</summary>
        public static Engine MapThread(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("MapThread[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of MapThread that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/MapThread.html
        ///</summary>
        public static Engine MapThread(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MapThread[" + arg0 + "]", name);
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
        ///represents a Marchenko–Pastur distribution with unit scale parameter.
        ///https://reference.wolfram.com/language/ref/MarchenkoPasturDistribution.html
        ///</summary>
        public static Engine MarchenkoPasturDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MarchenkoPasturDistribution[" + arg0 + "]", name);
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
        ///gives Marcum's Q function .
        ///https://reference.wolfram.com/language/ref/MarcumQ.html
        ///</summary>
        public static Engine MarcumQ(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MarcumQ[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/MardiaCombinedTest.html
        ///</summary>
        public static Engine MardiaCombinedTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MardiaCombinedTest[" + arg0 + ", " + arg1 + "]", name);
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
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/MardiaKurtosisTest.html
        ///</summary>
        public static Engine MardiaKurtosisTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MardiaKurtosisTest[" + arg0 + ", " + arg1 + "]", name);
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
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/MardiaSkewnessTest.html
        ///</summary>
        public static Engine MardiaSkewnessTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MardiaSkewnessTest[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents a multivariate marginal distribution of the {k1,k2,…} coordinates.
        ///https://reference.wolfram.com/language/ref/MarginalDistribution.html
        ///</summary>
        public static Engine MarginalDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MarginalDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///gives the specified "property" for the process mproc.
        ///https://reference.wolfram.com/language/ref/MarkovProcessProperties.html
        ///</summary>
        public static Engine MarkovProcessProperties(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MarkovProcessProperties[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents a thermal surface boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/MassConcentrationCondition.html
        ///</summary>
        public static Engine MassConcentrationCondition(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MassConcentrationCondition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///represents a mass flux boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/MassFluxValue.html
        ///</summary>
        public static Engine MassFluxValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MassFluxValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///represents a mass impermeable boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/MassImpermeableBoundaryValue.html
        ///</summary>
        public static Engine MassImpermeableBoundaryValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MassImpermeableBoundaryValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///represents a mass outflow boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/MassOutflowValue.html
        ///</summary>
        public static Engine MassOutflowValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MassOutflowValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///represents a mass symmetry boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/MassSymmetryValue.html
        ///</summary>
        public static Engine MassSymmetryValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MassSymmetryValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///represents a mass transfer boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/MassTransferValue.html
        ///</summary>
        public static Engine MassTransferValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MassTransferValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///gives the matching dissimilarity between Boolean vectors u and v.
        ///https://reference.wolfram.com/language/ref/MatchingDissimilarity.html
        ///</summary>
        public static Engine MatchingDissimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatchingDissimilarity[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents an operator form of MatchQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/MatchQ.html
        ///</summary>
        public static Engine MatchQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MatchQ[" + arg0 + "]", name);
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
        ///uses the specified color col as the base color.
        ///https://reference.wolfram.com/language/ref/MaterialShading.html
        ///</summary>
        public static Engine MaterialShading(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MaterialShading[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses the specified parameters parms.
        ///https://reference.wolfram.com/language/ref/MaterialShading.html
        ///</summary>
        public static Engine MaterialShading(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MaterialShading[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives data corresponding to property for the mathematical function specified by entity.
        ///https://reference.wolfram.com/language/ref/MathematicalFunctionData.html
        ///</summary>
        public static Engine MathematicalFunctionData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MathematicalFunctionData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives data for the given entity-property pair in the format specified by annotation.
        ///https://reference.wolfram.com/language/ref/MathematicalFunctionData.html
        ///</summary>
        public static Engine MathematicalFunctionData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MathematicalFunctionData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives data for the given entity-property pair with property qualifiers qual1, qual2, … set to the given values.
        ///https://reference.wolfram.com/language/ref/MathematicalFunctionData.html
        ///</summary>
        public static Engine MathematicalFunctionData(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("MathematicalFunctionData[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives data corresponding to the given entity, property and annotation format, with property qualifiers qual1, qual2, … set to the given values.
        ///https://reference.wolfram.com/language/ref/MathematicalFunctionData.html
        ///</summary>
        public static Engine MathematicalFunctionData(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("MathematicalFunctionData[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
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
        ///gives the characteristic value  for even Mathieu functions with characteristic exponent r and parameter q.
        ///https://reference.wolfram.com/language/ref/MathieuCharacteristicA.html
        ///</summary>
        public static Engine MathieuCharacteristicA(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MathieuCharacteristicA[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the characteristic exponent r for Mathieu functions with characteristic value a and parameter q.
        ///https://reference.wolfram.com/language/ref/MathieuCharacteristicExponent.html
        ///</summary>
        public static Engine MathieuCharacteristicExponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MathieuCharacteristicExponent[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents the sporadic simple Mathieu group .
        ///https://reference.wolfram.com/language/ref/MathieuGroupM11.html
        ///</summary>
        public static Engine MathieuGroupM11(this Engine en, string? name = null)
        {
            return en.Execute("MathieuGroupM11[]", name);
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
        ///represents the sporadic simple Mathieu group .
        ///https://reference.wolfram.com/language/ref/MathieuGroupM22.html
        ///</summary>
        public static Engine MathieuGroupM22(this Engine en, string? name = null)
        {
            return en.Execute("MathieuGroupM22[]", name);
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
        ///represents the sporadic simple Mathieu group .
        ///https://reference.wolfram.com/language/ref/MathieuGroupM24.html
        ///</summary>
        public static Engine MathieuGroupM24(this Engine en, string? name = null)
        {
            return en.Execute("MathieuGroupM24[]", name);
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
        ///gives the derivative with respect to z of the odd Mathieu function with characteristic value a and parameter q.
        ///https://reference.wolfram.com/language/ref/MathieuSPrime.html
        ///</summary>
        public static Engine MathieuSPrime(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MathieuSPrime[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///represents the domain of matrices of dimensions d1×d2.
        ///https://reference.wolfram.com/language/ref/Matrices.html
        ///</summary>
        public static Engine Matrices(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Matrices[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the domain of matrices of dimensions d1×d2, with components in the domain dom.
        ///https://reference.wolfram.com/language/ref/Matrices.html
        ///</summary>
        public static Engine Matrices(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Matrices[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the subdomain of matrices d1×d2 with symmetry sym.
        ///https://reference.wolfram.com/language/ref/Matrices.html
        ///</summary>
        public static Engine Matrices(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Matrices[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the matrix exponential of m applied to the vector v.
        ///https://reference.wolfram.com/language/ref/MatrixExp.html
        ///</summary>
        public static Engine MatrixExp(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixExp[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the matrix generated by the scalar function f at the matrix argument m.
        ///https://reference.wolfram.com/language/ref/MatrixFunction.html
        ///</summary>
        public static Engine MatrixFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixFunction[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents zero mean matrix normal distribution with row covariance matrix Σrow and column covariance matrix Σcol.
        ///https://reference.wolfram.com/language/ref/MatrixNormalDistribution.html
        ///</summary>
        public static Engine MatrixNormalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixNormalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents matrix normal distribution with mean matrix μ.
        ///https://reference.wolfram.com/language/ref/MatrixNormalDistribution.html
        ///</summary>
        public static Engine MatrixNormalDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MatrixNormalDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the n  matrix power of the matrix m.
        ///https://reference.wolfram.com/language/ref/MatrixPower.html
        ///</summary>
        public static Engine MatrixPower(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixPower[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the n matrix power of the matrix m applied to the vector v.
        ///https://reference.wolfram.com/language/ref/MatrixPower.html
        ///</summary>
        public static Engine MatrixPower(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MatrixPower[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///represents the distribution where x1, x2, … are independent and follow the matrix distributions mdist1, mdist2, ….
        ///https://reference.wolfram.com/language/ref/MatrixPropertyDistribution.html
        ///</summary>
        public static Engine MatrixPropertyDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MatrixPropertyDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///gives True only if test yields True when applied to each of the matrix elements in expr.
        ///https://reference.wolfram.com/language/ref/MatrixQ.html
        ///</summary>
        public static Engine MatrixQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MatrixQ[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents zero mean matrix  distribution with row covariance matrix Σrow, column covariance matrix Σcol, and degrees of freedom parameter ν.
        ///https://reference.wolfram.com/language/ref/MatrixTDistribution.html
        ///</summary>
        public static Engine MatrixTDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MatrixTDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents matrix  distribution with mean matrix μ.
        ///https://reference.wolfram.com/language/ref/MatrixTDistribution.html
        ///</summary>
        public static Engine MatrixTDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MatrixTDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///yields the largest element of any of the lists.
        ///https://reference.wolfram.com/language/ref/Max.html
        ///</summary>
        public static Engine Max(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Max[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the latest date of the datei.
        ///https://reference.wolfram.com/language/ref/MaxDate.html
        ///</summary>
        public static Engine MaxDate(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MaxDate[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the endpoint of the date interval interval.
        ///https://reference.wolfram.com/language/ref/MaxDate.html
        ///</summary>
        public static Engine MaxDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MaxDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the endpoint of interval as specified by granularity gran.
        ///https://reference.wolfram.com/language/ref/MaxDate.html
        ///</summary>
        public static Engine MaxDate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MaxDate[" + arg0 + ", " + arg1 + "]", name);
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
        ///finds extended maxima where the range of values is not greater than h.
        ///https://reference.wolfram.com/language/ref/MaxDetect.html
        ///</summary>
        public static Engine MaxDetect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MaxDetect[" + arg0 + ", " + arg1 + "]", name);
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
        ///uses ri for filtering the dimension in data.
        ///https://reference.wolfram.com/language/ref/MaxFilter.html
        ///</summary>
        public static Engine MaxFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MaxFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns a list of the ei for which the value of f[ei] is maximal.
        ///https://reference.wolfram.com/language/ref/MaximalBy.html
        ///</summary>
        public static Engine MaximalBy(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MaximalBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of the ei corresponding to the n largest f[ei].
        ///https://reference.wolfram.com/language/ref/MaximalBy.html
        ///</summary>
        public static Engine MaximalBy(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MaximalBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of MaximalBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/MaximalBy.html
        ///</summary>
        public static Engine MaximalBy(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MaximalBy[" + arg0 + "]", name);
        }

        ///<summary>
        ///maximizes f exactly with respect to x.
        ///https://reference.wolfram.com/language/ref/Maximize.html
        ///</summary>
        public static Engine Maximize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Maximize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///maximizes f exactly with respect to x, y, ….
        ///https://reference.wolfram.com/language/ref/Maximize.html
        ///</summary>
        public static Engine Maximize(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Maximize[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///maximizes f exactly subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/Maximize.html
        ///</summary>
        public static Engine Maximize(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Maximize[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constrains variables to the domain dom, typically Reals or Integers.
        ///https://reference.wolfram.com/language/ref/Maximize.html
        ///</summary>
        public static Engine Maximize(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Maximize[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the nested max limit ⋯ f (x1,…,xn).
        ///https://reference.wolfram.com/language/ref/MaxLimit.html
        ///</summary>
        public static Engine MaxLimit(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MaxLimit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///gives the maximum number of bytes used during the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/MaxMemoryUsed.html
        ///</summary>
        public static Engine MaxMemoryUsed(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MaxMemoryUsed[" + arg0 + "]", name);
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
        ///gives the maximum value of f with respect to x.
        ///https://reference.wolfram.com/language/ref/MaxValue.html
        ///</summary>
        public static Engine MaxValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MaxValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the maximum value of f with respect to x, y, ….
        ///https://reference.wolfram.com/language/ref/MaxValue.html
        ///</summary>
        public static Engine MaxValue(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MaxValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the maximum value of f subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/MaxValue.html
        ///</summary>
        public static Engine MaxValue(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MaxValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constrains variables to the domain dom, typically Reals or Integers.
        ///https://reference.wolfram.com/language/ref/MaxValue.html
        ///</summary>
        public static Engine MaxValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MaxValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///represents the sporadic simple McLaughlin group .
        ///https://reference.wolfram.com/language/ref/McLaughlinGroupMcL.html
        ///</summary>
        public static Engine McLaughlinGroupMcL(this Engine en, string? name = null)
        {
            return en.Execute("McLaughlinGroupMcL[]", name);
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
        ///represents a loss layer that computes the mean absolute loss between the "Input" port and "Target" port.
        ///https://reference.wolfram.com/language/ref/MeanAbsoluteLossLayer.html
        ///</summary>
        public static Engine MeanAbsoluteLossLayer(this Engine en, string? name = null)
        {
            return en.Execute("MeanAbsoluteLossLayer[]", name);
        }

        ///<summary>
        ///gives an Around object describing the mean of the xi and its uncertainty.
        ///https://reference.wolfram.com/language/ref/MeanAround.html
        ///</summary>
        public static Engine MeanAround(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MeanAround[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a VectorAround object describing the means of the vectors xi and their covariance.
        ///https://reference.wolfram.com/language/ref/MeanAround.html
        ///</summary>
        public static Engine MeanAround(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MeanAround[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/MeanClusteringCoefficient.html
        ///</summary>
        public static Engine MeanClusteringCoefficient(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MeanClusteringCoefficient[" + "{" + string.Join(',', arg0) + "}" + "]", name);
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
        ///gives a list of k-mean in-degree connectivity for the graph g.
        ///https://reference.wolfram.com/language/ref/MeanDegreeConnectivity.html
        ///</summary>
        public static Engine MeanDegreeConnectivity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeanDegreeConnectivity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/MeanDegreeConnectivity.html
        ///</summary>
        public static Engine MeanDegreeConnectivity(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MeanDegreeConnectivity[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
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
        ///filters data by replacing every value by the mean value in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/MeanFilter.html
        ///</summary>
        public static Engine MeanFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeanFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses ri for filtering the dimension in data.
        ///https://reference.wolfram.com/language/ref/MeanFilter.html
        ///</summary>
        public static Engine MeanFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MeanFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/MeanGraphDistance.html
        ///</summary>
        public static Engine MeanGraphDistance(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MeanGraphDistance[" + "{" + string.Join(',', arg0) + "}" + "]", name);
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
        ///gives a list of mean neighbor in-degrees.
        ///https://reference.wolfram.com/language/ref/MeanNeighborDegree.html
        ///</summary>
        public static Engine MeanNeighborDegree(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeanNeighborDegree[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/MeanNeighborDegree.html
        ///</summary>
        public static Engine MeanNeighborDegree(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MeanNeighborDegree[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
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
        ///replaces each element in list by the mean of the values of all elements that differ by less than d.
        ///https://reference.wolfram.com/language/ref/MeanShift.html
        ///</summary>
        public static Engine MeanShift(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeanShift[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the list where only the specified parts pi are replaced with mean-shifted values.
        ///https://reference.wolfram.com/language/ref/MeanShift.html
        ///</summary>
        public static Engine MeanShift(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("MeanShift[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
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
        ///uses ri for filtering the dimension in data.
        ///https://reference.wolfram.com/language/ref/MeanShiftFilter.html
        ///</summary>
        public static Engine MeanShiftFilter(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("MeanShiftFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
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
        ///gives the median of the elements in list.
        ///https://reference.wolfram.com/language/ref/Median.html
        ///</summary>
        public static Engine Median(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Median[" + arg0 + "]", name);
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
        ///filters image by replacing every value by the median in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/MedianFilter.html
        ///</summary>
        public static Engine MedianFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MedianFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses ri for filtering the dimension in data.
        ///https://reference.wolfram.com/language/ref/MedianFilter.html
        ///</summary>
        public static Engine MedianFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MedianFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///gives a list of property values for the specified medical test entities.
        ///https://reference.wolfram.com/language/ref/MedicalTestData.html
        ///</summary>
        public static Engine MedicalTestData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MedicalTestData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/MedicalTestData.html
        ///</summary>
        public static Engine MedicalTestData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MedicalTestData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is the Meijer G function .
        ///https://reference.wolfram.com/language/ref/MeijerG.html
        ///</summary>
        public static Engine MeijerG(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, List<object> arg3, object arg4, string? name = null)
        {
            return en.Execute("MeijerG[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + arg4 + "]", name);
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
        ///represents a Meixner distribution with location parameter m, scale parameter a, skew parameter b, and shape parameter d.
        ///https://reference.wolfram.com/language/ref/MeixnerDistribution.html
        ///</summary>
        public static Engine MeixnerDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MeixnerDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///gives the multidimensional Mellin convolution.
        ///https://reference.wolfram.com/language/ref/MellinConvolve.html
        ///</summary>
        public static Engine MellinConvolve(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("MellinConvolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
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
        ///gives the multidimensional Mellin transform of expr.
        ///https://reference.wolfram.com/language/ref/MellinTransform.html
        ///</summary>
        public static Engine MellinTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("MellinTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
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
        ///tests all parts of list specified by levelspec.
        ///https://reference.wolfram.com/language/ref/MemberQ.html
        ///</summary>
        public static Engine MemberQ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MemberQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of MemberQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/MemberQ.html
        ///</summary>
        public static Engine MemberQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MemberQ[" + arg0 + "]", name);
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
        ///evaluates expr, stopping if more than b bytes of memory are requested.
        ///https://reference.wolfram.com/language/ref/MemoryConstrained.html
        ///</summary>
        public static Engine MemoryConstrained(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MemoryConstrained[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns failexpr if the memory constraint is not met.
        ///https://reference.wolfram.com/language/ref/MemoryConstrained.html
        ///</summary>
        public static Engine MemoryConstrained(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MemoryConstrained[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the number of bytes used in the Wolfram System front end.
        ///https://reference.wolfram.com/language/ref/MemoryInUse.html
        ///</summary>
        public static Engine MemoryInUse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MemoryInUse[" + arg0 + "]", name);
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
        ///gives the n-step Menger sponge in dimension d.
        ///https://reference.wolfram.com/language/ref/MengerMesh.html
        ///</summary>
        public static Engine MengerMesh(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MengerMesh[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents an object in which selecting the menu item with label lbli displays expri.
        ///https://reference.wolfram.com/language/ref/MenuView.html
        ///</summary>
        public static Engine MenuView(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MenuView[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes the i item be the one currently selected.
        ///https://reference.wolfram.com/language/ref/MenuView.html
        ///</summary>
        public static Engine MenuView(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MenuView[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///associates values vi with successive menu items, and makes the item with value v be the one currently selected.
        ///https://reference.wolfram.com/language/ref/MenuView.html
        ///</summary>
        public static Engine MenuView(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("MenuView[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///merges the associations associ, using the function f to combine values with the same key.
        ///https://reference.wolfram.com/language/ref/Merge.html
        ///</summary>
        public static Engine Merge(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Merge[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of Merge that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Merge.html
        ///</summary>
        public static Engine Merge(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Merge[" + arg0 + "]", name);
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
        ///returns True if n is a Mersenne prime exponent, and False otherwise.
        ///https://reference.wolfram.com/language/ref/MersennePrimeExponentQ.html
        ///</summary>
        public static Engine MersennePrimeExponentQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MersennePrimeExponentQ[" + arg0 + "]", name);
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
        ///gives the total count of cells of dimension d.
        ///https://reference.wolfram.com/language/ref/MeshCellCount.html
        ///</summary>
        public static Engine MeshCellCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshCellCount[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the cells of dimension d in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/MeshCells.html
        ///</summary>
        public static Engine MeshCells(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshCells[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives a graph from cells of dimension d to cells of dimension e that share a cell of dimension r.
        ///https://reference.wolfram.com/language/ref/MeshConnectivityGraph.html
        ///</summary>
        public static Engine MeshConnectivityGraph(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("MeshConnectivityGraph[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
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
        ///gives the graphics primitives for cells of dimension d in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/MeshPrimitives.html
        ///</summary>
        public static Engine MeshPrimitives(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshPrimitives[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a mesh with cells mcellj, where coordinates given as integer i are taken to be pi.
        ///https://reference.wolfram.com/language/ref/MeshRegion.html
        ///</summary>
        public static Engine MeshRegion(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MeshRegion[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a mesh with cell properties defined by the symbolic wrapper wi.
        ///https://reference.wolfram.com/language/ref/MeshRegion.html
        ///</summary>
        public static Engine MeshRegion(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MeshRegion[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields a mesh from a mesh region mreg with options opts.
        ///https://reference.wolfram.com/language/ref/MeshRegion.html
        ///</summary>
        public static Engine MeshRegion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeshRegion[" + arg0 + ", " + arg1 + "]", name);
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
        ///prints the message symbol::tag unless it has been switched off.
        ///https://reference.wolfram.com/language/ref/Message.html
        ///</summary>
        public static Engine Message(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Message[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints a message, inserting the values of the ei as needed.
        ///https://reference.wolfram.com/language/ref/Message.html
        ///</summary>
        public static Engine Message(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Message[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///includes buttons with labels lbli that evaluate the corresponding acti if clicked.
        ///https://reference.wolfram.com/language/ref/MessageDialog.html
        ///</summary>
        public static Engine MessageDialog(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MessageDialog[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///is a WSTP packet containing a Wolfram Language message identifier of the form symbol::string.
        ///https://reference.wolfram.com/language/ref/MessagePacket.html
        ///</summary>
        public static Engine MessagePacket(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MessagePacket[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the value of the specified property for the meteor shower entity.
        ///https://reference.wolfram.com/language/ref/MeteorShowerData.html
        ///</summary>
        public static Engine MeteorShowerData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeteorShowerData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified meteor shower entities.
        ///https://reference.wolfram.com/language/ref/MeteorShowerData.html
        ///</summary>
        public static Engine MeteorShowerData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MeteorShowerData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/MeteorShowerData.html
        ///</summary>
        public static Engine MeteorShowerData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MeteorShowerData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///represents the Mexican hat wavelet of width σ.
        ///https://reference.wolfram.com/language/ref/MexicanHatWavelet.html
        ///</summary>
        public static Engine MexicanHatWavelet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MexicanHatWavelet[" + arg0 + "]", name);
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
        ///represents the Meyer wavelet of order n evaluated on the equally spaced interval {-10,10}.
        ///https://reference.wolfram.com/language/ref/MeyerWavelet.html
        ///</summary>
        public static Engine MeyerWavelet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MeyerWavelet[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the Meyer wavelet of order n evaluated on the equally spaced interval {-lim,lim}.
        ///https://reference.wolfram.com/language/ref/MeyerWavelet.html
        ///</summary>
        public static Engine MeyerWavelet(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MeyerWavelet[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the midpoint of the line segment connecting the points p1 and p2.
        ///https://reference.wolfram.com/language/ref/Midpoint.html
        ///</summary>
        public static Engine Midpoint(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Midpoint[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the midpoint of a line.
        ///https://reference.wolfram.com/language/ref/Midpoint.html
        ///</summary>
        public static Engine Midpoint(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Midpoint[" + arg0 + "]", name);
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
        ///returns a list of file formats that matches the MIME type mime.
        ///https://reference.wolfram.com/language/ref/MIMETypeToFormatList.html
        ///</summary>
        public static Engine MIMETypeToFormatList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MIMETypeToFormatList[" + arg0 + "]", name);
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
        ///yields the smallest element of any of the lists.
        ///https://reference.wolfram.com/language/ref/Min.html
        ///</summary>
        public static Engine Min(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Min[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the earliest date of the datei.
        ///https://reference.wolfram.com/language/ref/MinDate.html
        ///</summary>
        public static Engine MinDate(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MinDate[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the beginning of the date interval interval.
        ///https://reference.wolfram.com/language/ref/MinDate.html
        ///</summary>
        public static Engine MinDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the beginning of interval as specified by granularity gran.
        ///https://reference.wolfram.com/language/ref/MinDate.html
        ///</summary>
        public static Engine MinDate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinDate[" + arg0 + ", " + arg1 + "]", name);
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
        ///finds extended minima where the range of values is not greater than h.
        ///https://reference.wolfram.com/language/ref/MinDetect.html
        ///</summary>
        public static Engine MinDetect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinDetect[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives a list of property values for the specified mineral entities.
        ///https://reference.wolfram.com/language/ref/MineralData.html
        ///</summary>
        public static Engine MineralData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MineralData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/MineralData.html
        ///</summary>
        public static Engine MineralData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MineralData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///uses ri for filtering the dimension in data.
        ///https://reference.wolfram.com/language/ref/MinFilter.html
        ///</summary>
        public static Engine MinFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MinFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns a list of the ei for which the value of f[ei] is minimal.
        ///https://reference.wolfram.com/language/ref/MinimalBy.html
        ///</summary>
        public static Engine MinimalBy(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MinimalBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of the ei corresponding to the n smallest f[ei].
        ///https://reference.wolfram.com/language/ref/MinimalBy.html
        ///</summary>
        public static Engine MinimalBy(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MinimalBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of MinimalBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/MinimalBy.html
        ///</summary>
        public static Engine MinimalBy(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinimalBy[" + arg0 + "]", name);
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
        ///gives the minimal state-space model of the state-space model sys.
        ///https://reference.wolfram.com/language/ref/MinimalStateSpaceModel.html
        ///</summary>
        public static Engine MinimalStateSpaceModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinimalStateSpaceModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies the new coordinates zi.
        ///https://reference.wolfram.com/language/ref/MinimalStateSpaceModel.html
        ///</summary>
        public static Engine MinimalStateSpaceModel(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MinimalStateSpaceModel[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///minimizes f exactly with respect to x, y, ….
        ///https://reference.wolfram.com/language/ref/Minimize.html
        ///</summary>
        public static Engine Minimize(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Minimize[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///minimizes f exactly subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/Minimize.html
        ///</summary>
        public static Engine Minimize(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Minimize[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constrains variables to the domain dom, typically Reals or Integers.
        ///https://reference.wolfram.com/language/ref/Minimize.html
        ///</summary>
        public static Engine Minimize(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Minimize[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives Minkowski's question mark function .
        ///https://reference.wolfram.com/language/ref/MinkowskiQuestionMark.html
        ///</summary>
        public static Engine MinkowskiQuestionMark(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MinkowskiQuestionMark[" + arg0 + "]", name);
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
        ///gives the nested min limit ⋯ f (x1,…,xn).
        ///https://reference.wolfram.com/language/ref/MinLimit.html
        ///</summary>
        public static Engine MinLimit(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MinLimit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///gives {Min[list]-δ, Max[list]+δ}.
        ///https://reference.wolfram.com/language/ref/MinMax.html
        ///</summary>
        public static Engine MinMax(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MinMax[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives {Min[list]-δmin,Max[list]+δmax}.
        ///https://reference.wolfram.com/language/ref/MinMax.html
        ///</summary>
        public static Engine MinMax(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MinMax[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///gives a list of property values for the specified minor planet entities.
        ///https://reference.wolfram.com/language/ref/MinorPlanetData.html
        ///</summary>
        public static Engine MinorPlanetData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MinorPlanetData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/MinorPlanetData.html
        ///</summary>
        public static Engine MinorPlanetData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MinorPlanetData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the k  minors.
        ///https://reference.wolfram.com/language/ref/Minors.html
        ///</summary>
        public static Engine Minors(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Minors[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies the function f rather than Det to each of the submatrices picked out.
        ///https://reference.wolfram.com/language/ref/Minors.html
        ///</summary>
        public static Engine Minors(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Minors[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        public static Engine MinusPlus(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MinusPlus[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the exact minimum value of f with respect to x, y, ….
        ///https://reference.wolfram.com/language/ref/MinValue.html
        ///</summary>
        public static Engine MinValue(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MinValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the minimum value of f subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/MinValue.html
        ///</summary>
        public static Engine MinValue(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MinValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constrains variables to the domain dom, typically Reals or Integers.
        ///https://reference.wolfram.com/language/ref/MinValue.html
        ///</summary>
        public static Engine MinValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MinValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///specifies a reason for the data's being missing.
        ///https://reference.wolfram.com/language/ref/Missing.html
        ///</summary>
        public static Engine Missing(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Missing[" + arg0 + "]", name);
        }

        ///<summary>
        ///associates the expression expr with the missing data.
        ///https://reference.wolfram.com/language/ref/Missing.html
        ///</summary>
        public static Engine Missing(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Missing[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the Mittag–Leffler function .
        ///https://reference.wolfram.com/language/ref/MittagLefflerE.html
        ///</summary>
        public static Engine MittagLefflerE(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MittagLefflerE[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the generalized Mittag–Leffler function .
        ///https://reference.wolfram.com/language/ref/MittagLefflerE.html
        ///</summary>
        public static Engine MittagLefflerE(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MittagLefflerE[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///yields True if the graph g is a mixed graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/MixedGraphQ.html
        ///</summary>
        public static Engine MixedGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MixedGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a mixed-magnitude expression consisting of values val1 through valn.
        ///https://reference.wolfram.com/language/ref/MixedMagnitude.html
        ///</summary>
        public static Engine MixedMagnitude(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MixedMagnitude[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the list of bases of a numerical system in which different digits have different bases.
        ///https://reference.wolfram.com/language/ref/MixedRadix.html
        ///</summary>
        public static Engine MixedRadix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MixedRadix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields a single Quantity expression representing the addition of compatible units with magnitude values.
        ///https://reference.wolfram.com/language/ref/MixedRadixQuantity.html
        ///</summary>
        public static Engine MixedRadixQuantity(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MixedRadixQuantity[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a mixed-unit expression consisting of units unit1 through unitn.
        ///https://reference.wolfram.com/language/ref/MixedUnit.html
        ///</summary>
        public static Engine MixedUnit(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MixedUnit[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a mixture distribution whose CDF is given as a sum of the CDFs of the component distributions disti, each with weight wi.
        ///https://reference.wolfram.com/language/ref/MixtureDistribution.html
        ///</summary>
        public static Engine MixtureDistribution(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MixtureDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///uses an offset d.
        ///https://reference.wolfram.com/language/ref/Mod.html
        ///</summary>
        public static Engine Mod(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Mod[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///returns the value of the property "prop".
        ///https://reference.wolfram.com/language/ref/ModelPredictiveController.html
        ///</summary>
        public static Engine ModelPredictiveController(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ModelPredictiveController[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the modular lambda elliptic function .
        ///https://reference.wolfram.com/language/ref/ModularLambda.html
        ///</summary>
        public static Engine ModularLambda(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ModularLambda[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies that occurrences of the symbols x, y, … in expr should be treated as local.
        ///https://reference.wolfram.com/language/ref/Module.html
        ///</summary>
        public static Engine Module(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Module[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
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
        ///represents a molecule with atoms atomi and bonds bondi.
        ///https://reference.wolfram.com/language/ref/Molecule.html
        ///</summary>
        public static Engine Molecule(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Molecule[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the molecule corresponding to the input name.
        ///https://reference.wolfram.com/language/ref/Molecule.html
        ///</summary>
        public static Engine Molecule(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Molecule[" + arg0 + "]", name);
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
        ///aligns atoms in mol with index mi to the atoms in ref with index ri.
        ///https://reference.wolfram.com/language/ref/MoleculeAlign.html
        ///</summary>
        public static Engine MoleculeAlign(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("MoleculeAlign[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///uses the molecule pattern patt to find an atom mapping between ref and mol.
        ///https://reference.wolfram.com/language/ref/MoleculeAlign.html
        ///</summary>
        public static Engine MoleculeAlign(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MoleculeAlign[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///aligns each of the moli with ref.
        ///https://reference.wolfram.com/language/ref/MoleculeAlign.html
        ///</summary>
        public static Engine MoleculeAlign(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("MoleculeAlign[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///aligns the molecules and returns the property prop of the alignment.
        ///https://reference.wolfram.com/language/ref/MoleculeAlign.html
        ///</summary>
        public static Engine MoleculeAlign(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MoleculeAlign[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///represents an operator form of MoleculeContainsQ that can be applied to a molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeContainsQ.html
        ///</summary>
        public static Engine MoleculeContainsQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeContainsQ[" + arg0 + "]", name);
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
        ///displays a window that initially contains the Molecule mol.
        ///https://reference.wolfram.com/language/ref/MoleculeDraw.html
        ///</summary>
        public static Engine MoleculeDraw(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeDraw[" + arg0 + "]", name);
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
        ///represents an operator form of MoleculeFreeQ that can be applied to a molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeFreeQ.html
        ///</summary>
        public static Engine MoleculeFreeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeFreeQ[" + arg0 + "]", name);
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
        ///returns True if the Molecule matches the given pattern.
        ///https://reference.wolfram.com/language/ref/MoleculeMatchQ.html
        ///</summary>
        public static Engine MoleculeMatchQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeMatchQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of MoleculeMatchQ that can be applied to a molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeMatchQ.html
        ///</summary>
        public static Engine MoleculeMatchQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeMatchQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a molecule pattern representing the largest common substructure for the input molecules.
        ///https://reference.wolfram.com/language/ref/MoleculeMaximumCommonSubstructure.html
        ///</summary>
        public static Engine MoleculeMaximumCommonSubstructure(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MoleculeMaximumCommonSubstructure[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses params to determine equivalence between atoms and bonds.
        ///https://reference.wolfram.com/language/ref/MoleculeMaximumCommonSubstructure.html
        ///</summary>
        public static Engine MoleculeMaximumCommonSubstructure(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeMaximumCommonSubstructure[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
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
        ///gives a molecule or list of molecules derived from the molecule mol by applying the modification "mod" with additional specifications specs.
        ///https://reference.wolfram.com/language/ref/MoleculeModify.html
        ///</summary>
        public static Engine MoleculeModify(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MoleculeModify[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of MoleculeModify that can be applied to a molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeModify.html
        ///</summary>
        public static Engine MoleculeModify(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeModify[" + arg0 + "]", name);
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
        ///uses the given source to find the molecule name.
        ///https://reference.wolfram.com/language/ref/MoleculeName.html
        ///</summary>
        public static Engine MoleculeName(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeName[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a molecule pattern with atoms atomi and bonds bondi for use in substructure searching.
        ///https://reference.wolfram.com/language/ref/MoleculePattern.html
        ///</summary>
        public static Engine MoleculePattern(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculePattern[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a molecule pattern from the input SMARTS pattern.
        ///https://reference.wolfram.com/language/ref/MoleculePattern.html
        ///</summary>
        public static Engine MoleculePattern(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculePattern[" + arg0 + "]", name);
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
        ///creates a diagram of mol where all atoms and bonds matching the pattern patt are highlighted.
        ///https://reference.wolfram.com/language/ref/MoleculePlot.html
        ///</summary>
        public static Engine MoleculePlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculePlot[" + arg0 + ", " + arg1 + "]", name);
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
        ///creates a model of mol where all atoms and bonds matching the pattern patt are highlighted.
        ///https://reference.wolfram.com/language/ref/MoleculePlot3D.html
        ///</summary>
        public static Engine MoleculePlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculePlot3D[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents a property that applies to item within a molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeProperty.html
        ///</summary>
        public static Engine MoleculeProperty(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("MoleculeProperty[" + "{" + string.Join(',', arg0) + "}" + "]", name);
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
        ///recognizes a molecule in image and returns it as a Molecule object.
        ///https://reference.wolfram.com/language/ref/MoleculeRecognize.html
        ///</summary>
        public static Engine MoleculeRecognize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeRecognize[" + arg0 + "]", name);
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
        ///represents an operator form of MoleculeSubstructureCount that can be applied to a molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeSubstructureCount.html
        ///</summary>
        public static Engine MoleculeSubstructureCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoleculeSubstructureCount[" + arg0 + "]", name);
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
        ///gives the list of values for the specified property for each of the moleculei.
        ///https://reference.wolfram.com/language/ref/MoleculeValue.html
        ///</summary>
        public static Engine MoleculeValue(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MoleculeValue[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of values of the propertyi for the specified molecule.
        ///https://reference.wolfram.com/language/ref/MoleculeValue.html
        ///</summary>
        public static Engine MoleculeValue(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MoleculeValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the list of values of the propertyi for each of the moleculei.
        ///https://reference.wolfram.com/language/ref/MoleculeValue.html
        ///</summary>
        public static Engine MoleculeValue(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MoleculeValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///gives the {r1,r2,…} multivariate moment.
        ///https://reference.wolfram.com/language/ref/Moment.html
        ///</summary>
        public static Engine Moment(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Moment[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents the r formal moment.
        ///https://reference.wolfram.com/language/ref/Moment.html
        ///</summary>
        public static Engine Moment(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Moment[" + arg0 + "]", name);
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
        ///evaluates formal moments in the moment expression mexpr on the distribution dist.
        ///https://reference.wolfram.com/language/ref/MomentEvaluate.html
        ///</summary>
        public static Engine MomentEvaluate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MomentEvaluate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates formal moments on the distribution dist and formal sample moments on the data list.
        ///https://reference.wolfram.com/language/ref/MomentEvaluate.html
        ///</summary>
        public static Engine MomentEvaluate(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MomentEvaluate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the moment-generating function for the multivariate distribution dist as a function of the variables t1, t2, … .
        ///https://reference.wolfram.com/language/ref/MomentGeneratingFunction.html
        ///</summary>
        public static Engine MomentGeneratingFunction(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MomentGeneratingFunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///computes the moment of inertia matrix for the region reg relative to the center of mass.
        ///https://reference.wolfram.com/language/ref/MomentOfInertia.html
        ///</summary>
        public static Engine MomentOfInertia(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MomentOfInertia[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes the moment of inertia matrix relative to the point pt.
        ///https://reference.wolfram.com/language/ref/MomentOfInertia.html
        ///</summary>
        public static Engine MomentOfInertia(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MomentOfInertia[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the list of all monomials in the polynomial poly.
        ///https://reference.wolfram.com/language/ref/MonomialList.html
        ///</summary>
        public static Engine MonomialList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MonomialList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of monomials with respect to the variables xi in poly.
        ///https://reference.wolfram.com/language/ref/MonomialList.html
        ///</summary>
        public static Engine MonomialList(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MonomialList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///puts the monomials in the specified order.
        ///https://reference.wolfram.com/language/ref/MonomialList.html
        ///</summary>
        public static Engine MonomialList(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("MonomialList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
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
        ///gives moon phase fraction of illumination for the current date.
        ///https://reference.wolfram.com/language/ref/MoonPhase.html
        ///</summary>
        public static Engine MoonPhase(this Engine en, string? name = null)
        {
            return en.Execute("MoonPhase[]", name);
        }

        ///<summary>
        ///gives moon phase fraction of illumination for the specified date.
        ///https://reference.wolfram.com/language/ref/MoonPhase.html
        ///</summary>
        public static Engine MoonPhase(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoonPhase[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the property of the moon phase for the specified date.
        ///https://reference.wolfram.com/language/ref/MoonPhase.html
        ///</summary>
        public static Engine MoonPhase(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoonPhase[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the position of the Moon for the specified date.
        ///https://reference.wolfram.com/language/ref/MoonPosition.html
        ///</summary>
        public static Engine MoonPosition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MoonPosition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the position of the Moon for the specified date and location.
        ///https://reference.wolfram.com/language/ref/MoonPosition.html
        ///</summary>
        public static Engine MoonPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoonPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the positions of the Moon for all specified locations on the specified dates.
        ///https://reference.wolfram.com/language/ref/MoonPosition.html
        ///</summary>
        public static Engine MoonPosition(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MoonPosition[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses func to determine what to return for extended locations.
        ///https://reference.wolfram.com/language/ref/MoonPosition.html
        ///</summary>
        public static Engine MoonPosition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MoonPosition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///creates a binary image from image by replacing all values above the upper threshold t2 with 1, also including pixels with intensities above the lower threshold t1 that are connected to the foreground.
        ///https://reference.wolfram.com/language/ref/MorphologicalBinarize.html
        ///</summary>
        public static Engine MorphologicalBinarize(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MorphologicalBinarize[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses t as the upper threshold, automatically choosing a suitable value for the lower threshold.
        ///https://reference.wolfram.com/language/ref/MorphologicalBinarize.html
        ///</summary>
        public static Engine MorphologicalBinarize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MorphologicalBinarize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///chooses the lower and the upper threshold automatically.
        ///https://reference.wolfram.com/language/ref/MorphologicalBinarize.html
        ///</summary>
        public static Engine MorphologicalBinarize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MorphologicalBinarize[" + arg0 + "]", name);
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
        ///gives an array in which each pixel of image is replaced by an integer index representing the connected foreground image component in which the pixel lies.
        ///https://reference.wolfram.com/language/ref/MorphologicalComponents.html
        ///</summary>
        public static Engine MorphologicalComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MorphologicalComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///treats values above t as foreground.
        ///https://reference.wolfram.com/language/ref/MorphologicalComponents.html
        ///</summary>
        public static Engine MorphologicalComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MorphologicalComponents[" + arg0 + ", " + arg1 + "]", name);
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
        ///treats values above t as foreground.
        ///https://reference.wolfram.com/language/ref/MorphologicalEulerNumber.html
        ///</summary>
        public static Engine MorphologicalEulerNumber(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MorphologicalEulerNumber[" + arg0 + ", " + arg1 + "]", name);
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
        ///picks out the morphological perimeter of regions of foreground in image.
        ///https://reference.wolfram.com/language/ref/MorphologicalPerimeter.html
        ///</summary>
        public static Engine MorphologicalPerimeter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MorphologicalPerimeter[" + arg0 + "]", name);
        }

        ///<summary>
        ///treats values above t as foreground.
        ///https://reference.wolfram.com/language/ref/MorphologicalPerimeter.html
        ///</summary>
        public static Engine MorphologicalPerimeter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MorphologicalPerimeter[" + arg0 + ", " + arg1 + "]", name);
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
        ///applies n iterations of transformation on image.
        ///https://reference.wolfram.com/language/ref/MorphologicalTransform.html
        ///</summary>
        public static Engine MorphologicalTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MorphologicalTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the value of the specified property for the specified demographic.
        ///https://reference.wolfram.com/language/ref/MortalityData.html
        ///</summary>
        public static Engine MortalityData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MortalityData[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the value of the specified property for the mountain entity.
        ///https://reference.wolfram.com/language/ref/MountainData.html
        ///</summary>
        public static Engine MountainData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MountainData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified mountain entities.
        ///https://reference.wolfram.com/language/ref/MountainData.html
        ///</summary>
        public static Engine MountainData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MountainData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/MountainData.html
        ///</summary>
        public static Engine MountainData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MountainData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///changes the mouse cursor to appear as graphic when the mouse pointer is in the area where expr is displayed.
        ///https://reference.wolfram.com/language/ref/MouseAppearance.html
        ///</summary>
        public static Engine MouseAppearance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MouseAppearance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the coordinates {x,y} in the graphic as the hotspot for the mouse cursor.
        ///https://reference.wolfram.com/language/ref/MouseAppearance.html
        ///</summary>
        public static Engine MouseAppearance(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("MouseAppearance[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///uses the scaled coordinates {x,y} as the hotspot for the mouse cursor.
        ///https://reference.wolfram.com/language/ref/MouseAppearance.html
        ///</summary>
        public static Engine MouseAppearance(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MouseAppearance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the current mouse position in the notebook front end.
        ///https://reference.wolfram.com/language/ref/MousePosition.html
        ///</summary>
        public static Engine MousePosition(this Engine en, string? name = null)
        {
            return en.Execute("MousePosition[]", name);
        }

        ///<summary>
        ///gives the mouse position with respect to the specified coordinate system.
        ///https://reference.wolfram.com/language/ref/MousePosition.html
        ///</summary>
        public static Engine MousePosition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MousePosition[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns def if the mouse is not over an object that defines the specified coordinate system.
        ///https://reference.wolfram.com/language/ref/MousePosition.html
        ///</summary>
        public static Engine MousePosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MousePosition[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives a list of property values for the specified movie entities.
        ///https://reference.wolfram.com/language/ref/MovieData.html
        ///</summary>
        public static Engine MovieData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("MovieData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/MovieData.html
        ///</summary>
        public static Engine MovieData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MovieData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the moving average of list, computed with weights wi.
        ///https://reference.wolfram.com/language/ref/MovingAverage.html
        ///</summary>
        public static Engine MovingAverage(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MovingAverage[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///pads data using padding.
        ///https://reference.wolfram.com/language/ref/MovingMap.html
        ///</summary>
        public static Engine MovingMap(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("MovingMap[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
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
        ///represents a Moyal distribution with location parameter μ and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/MoyalDistribution.html
        ///</summary>
        public static Engine MoyalDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("MoyalDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Moyal distribution with location parameter 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/MoyalDistribution.html
        ///</summary>
        public static Engine MoyalDistribution(this Engine en, string? name = null)
        {
            return en.Execute("MoyalDistribution[]", name);
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
        ///formats as a grid with the indicated number of rows.
        ///https://reference.wolfram.com/language/ref/Multicolumn.html
        ///</summary>
        public static Engine Multicolumn(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Multicolumn[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///formats with the elements of list in a roughly square arrangement.
        ///https://reference.wolfram.com/language/ref/Multicolumn.html
        ///</summary>
        public static Engine Multicolumn(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Multicolumn[" + arg0 + "]", name);
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
        ///gives the multinomial coefficient .
        ///https://reference.wolfram.com/language/ref/Multinomial.html
        ///</summary>
        public static Engine Multinomial(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Multinomial[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a multinomial distribution with n trials and probabilities pi.
        ///https://reference.wolfram.com/language/ref/MultinomialDistribution.html
        ///</summary>
        public static Engine MultinomialDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MultinomialDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///represents a multivariate normal distribution with zero mean and covariance matrix Σ.
        ///https://reference.wolfram.com/language/ref/MultinormalDistribution.html
        ///</summary>
        public static Engine MultinormalDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("MultinormalDistribution[" + arg0 + "]", name);
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
        ///gives the generalized multiplicative order of k modulo n, defined as the smallest integer  such that  for some .
        ///https://reference.wolfram.com/language/ref/MultiplicativeOrder.html
        ///</summary>
        public static Engine MultiplicativeOrder(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("MultiplicativeOrder[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
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
        ///represents a multivariate hypergeometric distribution with n draws without replacement from a collection containing mi objects of type i.
        ///https://reference.wolfram.com/language/ref/MultivariateHypergeometricDistribution.html
        ///</summary>
        public static Engine MultivariateHypergeometricDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MultivariateHypergeometricDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a multivariate Poisson distribution with mean vector {μ0+μ1,μ0+μ2,…}.
        ///https://reference.wolfram.com/language/ref/MultivariatePoissonDistribution.html
        ///</summary>
        public static Engine MultivariatePoissonDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("MultivariatePoissonDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
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
        ///represents the multivariate Student  distribution with location μ, scale matrix Σ, and ν degrees of freedom.
        ///https://reference.wolfram.com/language/ref/MultivariateTDistribution.html
        ///</summary>
        public static Engine MultivariateTDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("MultivariateTDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }


    }
}
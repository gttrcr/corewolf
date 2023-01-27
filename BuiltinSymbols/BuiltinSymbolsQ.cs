namespace CoreWolf
{
    public static class BuiltinSymbolQ
    {
        ///<summary>
        ///gives the -binomial coefficient .
        ///https://reference.wolfram.com/language/ref/QBinomial.html
        ///</summary>
        public static Engine QBinomial(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("QBinomial[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the -factorial .
        ///https://reference.wolfram.com/language/ref/QFactorial.html
        ///</summary>
        public static Engine QFactorial(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QFactorial[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the -gamma function .
        ///https://reference.wolfram.com/language/ref/QGamma.html
        ///</summary>
        public static Engine QGamma(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QGamma[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the basic hypergeometric series .
        ///https://reference.wolfram.com/language/ref/QHypergeometricPFQ.html
        ///</summary>
        public static Engine QHypergeometricPFQ(this Engine en, List<object> arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("QHypergeometricPFQ[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the  statistic of the elements in list.
        ///https://reference.wolfram.com/language/ref/QnDispersion.html
        ///</summary>
        public static Engine QnDispersion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QnDispersion[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the  statistic with a scaling factor c.
        ///https://reference.wolfram.com/language/ref/QnDispersion.html
        ///</summary>
        public static Engine QnDispersion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QnDispersion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the -Pochhammer symbol .
        ///https://reference.wolfram.com/language/ref/QPochhammer.html
        ///</summary>
        public static Engine QPochhammer(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("QPochhammer[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the -Pochhammer symbol .
        ///https://reference.wolfram.com/language/ref/QPochhammer.html
        ///</summary>
        public static Engine QPochhammer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QPochhammer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the -Pochhammer symbol .
        ///https://reference.wolfram.com/language/ref/QPochhammer.html
        ///</summary>
        public static Engine QPochhammer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QPochhammer[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the -digamma function .
        ///https://reference.wolfram.com/language/ref/QPolyGamma.html
        ///</summary>
        public static Engine QPolyGamma(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QPolyGamma[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the  derivative of the -digamma function .
        ///https://reference.wolfram.com/language/ref/QPolyGamma.html
        ///</summary>
        public static Engine QPolyGamma(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("QPolyGamma[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields the QR decomposition for a numerical matrix m. The result is a list {q,r}, where q is a unitary matrix and r is an upper‐triangular matrix.
        ///https://reference.wolfram.com/language/ref/QRDecomposition.html
        ///</summary>
        public static Engine QRDecomposition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QRDecomposition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if x is a quadratic irrational and False otherwise.
        ///https://reference.wolfram.com/language/ref/QuadraticIrrationalQ.html
        ///</summary>
        public static Engine QuadraticIrrationalQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuadraticIrrationalQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds values of variables vars that minimize the quadratic objective f subject to linear constraints cons.
        ///https://reference.wolfram.com/language/ref/QuadraticOptimization.html
        ///</summary>
        public static Engine QuadraticOptimization(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("QuadraticOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a vector  that minimizes the quadratic objective  subject to the linear inequality constraints .
        ///https://reference.wolfram.com/language/ref/QuadraticOptimization.html
        ///</summary>
        public static Engine QuadraticOptimization(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("QuadraticOptimization[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///includes the linear equality constraints .
        ///https://reference.wolfram.com/language/ref/QuadraticOptimization.html
        ///</summary>
        public static Engine QuadraticOptimization(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("QuadraticOptimization[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///takes  to be in the domain domi, where domi is Integers or Reals.
        ///https://reference.wolfram.com/language/ref/QuadraticOptimization.html
        ///</summary>
        public static Engine QuadraticOptimization(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("QuadraticOptimization[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///specifies what solution property "prop" should be returned.
        ///https://reference.wolfram.com/language/ref/QuadraticOptimization.html
        ///</summary>
        public static Engine QuadraticOptimization(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuadraticOptimization[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the q  quantile of list.
        ///https://reference.wolfram.com/language/ref/Quantile.html
        ///</summary>
        public static Engine Quantile(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Quantile[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of quantiles q1, q2, ….
        ///https://reference.wolfram.com/language/ref/Quantile.html
        ///</summary>
        public static Engine Quantile(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Quantile[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the quantile definition specified by parameters a, b, c, d.
        ///https://reference.wolfram.com/language/ref/Quantile.html
        ///</summary>
        public static Engine Quantile(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("Quantile[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///generates a plot of quantiles of list against the quantiles of a normal distribution.
        ///https://reference.wolfram.com/language/ref/QuantilePlot.html
        ///</summary>
        public static Engine QuantilePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantilePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot of the quantiles of data against the quantiles of rdata.
        ///https://reference.wolfram.com/language/ref/QuantilePlot.html
        ///</summary>
        public static Engine QuantilePlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuantilePlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a plot of quantiles of datai against the quantiles of a reference distribution ref.
        ///https://reference.wolfram.com/language/ref/QuantilePlot.html
        ///</summary>
        public static Engine QuantilePlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("QuantilePlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a quantity with size magnitude and unit specified by unit.
        ///https://reference.wolfram.com/language/ref/Quantity.html
        ///</summary>
        public static Engine Quantity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Quantity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///assumes the magnitude of the specified unit to be 1.
        ///https://reference.wolfram.com/language/ref/Quantity.html
        ///</summary>
        public static Engine Quantity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Quantity[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an array of quantities with magnitudes mags and common unit.
        ///https://reference.wolfram.com/language/ref/QuantityArray.html
        ///</summary>
        public static Engine QuantityArray(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuantityArray[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an array of lists of quantities with units {unit1,unit2,…}.
        ///https://reference.wolfram.com/language/ref/QuantityArray.html
        ///</summary>
        public static Engine QuantityArray(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("QuantityArray[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///converts an array of Quantity objects into a single QuantityArray object.
        ///https://reference.wolfram.com/language/ref/QuantityArray.html
        ///</summary>
        public static Engine QuantityArray(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityArray[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a distribution dist of quantities with unit specified by unit.
        ///https://reference.wolfram.com/language/ref/QuantityDistribution.html
        ///</summary>
        public static Engine QuantityDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuantityDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a multivariate distribution with units {unit1,unit2,…}.
        ///https://reference.wolfram.com/language/ref/QuantityDistribution.html
        ///</summary>
        public static Engine QuantityDistribution(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("QuantityDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///prints expr with all Quantity expressions using the specified unit display form form.
        ///https://reference.wolfram.com/language/ref/QuantityForm.html
        ///</summary>
        public static Engine QuantityForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuantityForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints expr using the appropriate combination of the specified unit display forms forms.
        ///https://reference.wolfram.com/language/ref/QuantityForm.html
        ///</summary>
        public static Engine QuantityForm(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("QuantityForm[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the amount of the specified quantity.
        ///https://reference.wolfram.com/language/ref/QuantityMagnitude.html
        ///</summary>
        public static Engine QuantityMagnitude(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityMagnitude[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value corresponding to quantity when converted to unit.
        ///https://reference.wolfram.com/language/ref/QuantityMagnitude.html
        ///</summary>
        public static Engine QuantityMagnitude(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuantityMagnitude[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a Quantity with valid arguments, and False otherwise.
        ///https://reference.wolfram.com/language/ref/QuantityQ.html
        ///</summary>
        public static Engine QuantityQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the unit associated with the specified quantity.
        ///https://reference.wolfram.com/language/ref/QuantityUnit.html
        ///</summary>
        public static Engine QuantityUnit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityUnit[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a variable with the label var and the corresponding physical quantity "pq".
        ///https://reference.wolfram.com/language/ref/QuantityVariable.html
        ///</summary>
        public static Engine QuantityVariable(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuantityVariable[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the unlabeled physical quantity "pq".
        ///https://reference.wolfram.com/language/ref/QuantityVariable.html
        ///</summary>
        public static Engine QuantityVariable(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityVariable[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the canonical unit associated with the specified quantityvariable.
        ///https://reference.wolfram.com/language/ref/QuantityVariableCanonicalUnit.html
        ///</summary>
        public static Engine QuantityVariableCanonicalUnit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityVariableCanonicalUnit[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of base dimensions associated with the specified quantityvariable.
        ///https://reference.wolfram.com/language/ref/QuantityVariableDimensions.html
        ///</summary>
        public static Engine QuantityVariableDimensions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityVariableDimensions[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the identifier associated with the specified quantityvariable.
        ///https://reference.wolfram.com/language/ref/QuantityVariableIdentifier.html
        ///</summary>
        public static Engine QuantityVariableIdentifier(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityVariableIdentifier[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the physical quantity associated with the quantity variable var.
        ///https://reference.wolfram.com/language/ref/QuantityVariablePhysicalQuantity.html
        ///</summary>
        public static Engine QuantityVariablePhysicalQuantity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuantityVariablePhysicalQuantity[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the physical quantity using the format type.
        ///https://reference.wolfram.com/language/ref/QuantityVariablePhysicalQuantity.html
        ///</summary>
        public static Engine QuantityVariablePhysicalQuantity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuantityVariablePhysicalQuantity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the quartile deviation or semi-interquartile range of the elements in list.
        ///https://reference.wolfram.com/language/ref/QuartileDeviation.html
        ///</summary>
        public static Engine QuartileDeviation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuartileDeviation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the 1/4, 1/2 and 3/4 quantiles of the elements in list.
        ///https://reference.wolfram.com/language/ref/Quartiles.html
        ///</summary>
        public static Engine Quartiles(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Quartiles[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the coefficient of quartile skewness for the elements in list.
        ///https://reference.wolfram.com/language/ref/QuartileSkewness.html
        ///</summary>
        public static Engine QuartileSkewness(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuartileSkewness[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a query that can be applied to a Dataset object, in which the successive operatori are applied at successively deeper levels.
        ///https://reference.wolfram.com/language/ref/Query.html
        ///</summary>
        public static Engine Query(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Query[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a QuestionObject generated by applying genfunc to "name1":>val1,"name1":>val2,….
        ///https://reference.wolfram.com/language/ref/QuestionGenerator.html
        ///</summary>
        public static Engine QuestionGenerator(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("QuestionGenerator[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a cloud-deployed question generator.
        ///https://reference.wolfram.com/language/ref/QuestionGenerator.html
        ///</summary>
        public static Engine QuestionGenerator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuestionGenerator[" + arg0 + "]", name);
        }

        ///<summary>
        ///defines an interface for a QuestionObject using the given type and properties pi with settings si.
        ///https://reference.wolfram.com/language/ref/QuestionInterface.html
        ///</summary>
        public static Engine QuestionInterface(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("QuestionInterface[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents the question q and the corresponding assessment assess.
        ///https://reference.wolfram.com/language/ref/QuestionObject.html
        ///</summary>
        public static Engine QuestionObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuestionObject[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///derives a question from the assessment.
        ///https://reference.wolfram.com/language/ref/QuestionObject.html
        ///</summary>
        public static Engine QuestionObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuestionObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a list of questions from which one of the question objects qoi can be randomly selected.
        ///https://reference.wolfram.com/language/ref/QuestionSelector.html
        ///</summary>
        public static Engine QuestionSelector(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("QuestionSelector[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a cloud-deployed question selector.
        ///https://reference.wolfram.com/language/ref/QuestionSelector.html
        ///</summary>
        public static Engine QuestionSelector(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuestionSelector[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an open (Jackson) queueing network process with arrival vector γ, routing probability matrix r, service vector μ, and service channel vector c.
        ///https://reference.wolfram.com/language/ref/QueueingNetworkProcess.html
        ///</summary>
        public static Engine QueueingNetworkProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("QueueingNetworkProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a closed (Gordon–Newell) queueing network process with k jobs in the system.
        ///https://reference.wolfram.com/language/ref/QueueingNetworkProcess.html
        ///</summary>
        public static Engine QueueingNetworkProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("QueueingNetworkProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents an M/M/1 queue with arrival rate λ and service rate μ.
        ///https://reference.wolfram.com/language/ref/QueueingProcess.html
        ///</summary>
        public static Engine QueueingProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QueueingProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a queueing process with c service channels.
        ///https://reference.wolfram.com/language/ref/QueueingProcess.html
        ///</summary>
        public static Engine QueueingProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("QueueingProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a queueing process with system capacity k.
        ///https://reference.wolfram.com/language/ref/QueueingProcess.html
        ///</summary>
        public static Engine QueueingProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("QueueingProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a queueing process with initial state x0.
        ///https://reference.wolfram.com/language/ref/QueueingProcess.html
        ///</summary>
        public static Engine QueueingProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("QueueingProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///gives a summary of properties for the queueing process qproc.
        ///https://reference.wolfram.com/language/ref/QueueProperties.html
        ///</summary>
        public static Engine QueueProperties(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QueueProperties[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a summary of properties for the i node in the queueing network process qproc.
        ///https://reference.wolfram.com/language/ref/QueueProperties.html
        ///</summary>
        public static Engine QueueProperties(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("QueueProperties[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the specified "property".
        ///https://reference.wolfram.com/language/ref/QueueProperties.html
        ///</summary>
        public static Engine QueueProperties(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QueueProperties[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr "quietly", without actually outputting any messages generated.
        ///https://reference.wolfram.com/language/ref/Quiet.html
        ///</summary>
        public static Engine Quiet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Quiet[" + arg0 + "]", name);
        }

        ///<summary>
        ///quietens only the specified messages during the evaluation of expr.
        ///https://reference.wolfram.com/language/ref/Quiet.html
        ///</summary>
        public static Engine Quiet(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Quiet[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///quietens only the named group of messages.
        ///https://reference.wolfram.com/language/ref/Quiet.html
        ///</summary>
        public static Engine Quiet(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Quiet[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr without letting Echo and related functions inside expr print any result.
        ///https://reference.wolfram.com/language/ref/QuietEcho.html
        ///</summary>
        public static Engine QuietEcho(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("QuietEcho[" + arg0 + "]", name);
        }

        ///<summary>
        ///terminates a Wolfram Language kernel session.
        ///https://reference.wolfram.com/language/ref/Quit.html
        ///</summary>
        public static Engine Quit(this Engine en, string? name = null)
        {
            return en.Execute("Quit[]", name);
        }

        ///<summary>
        ///gives the integer quotient of m and n.
        ///https://reference.wolfram.com/language/ref/Quotient.html
        ///</summary>
        public static Engine Quotient(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Quotient[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses an offset d.
        ///https://reference.wolfram.com/language/ref/Quotient.html
        ///</summary>
        public static Engine Quotient(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Quotient[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the quotient and remainder from division of m by n.
        ///https://reference.wolfram.com/language/ref/QuotientRemainder.html
        ///</summary>
        public static Engine QuotientRemainder(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("QuotientRemainder[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}
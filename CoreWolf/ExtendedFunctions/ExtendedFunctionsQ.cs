namespace CoreWolf
{
    public static class ExtendedFunctionsQ
    {
        ///<summary>
        /// gives the  statistic of the elements in list.
        /// https://reference.wolfram.com/language/ref/QnDispersion.html
        ///</summary>
        public static Engine QnDispersion(this Engine en, string? name = null)
        {
            return en.Execute("QnDispersion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the -Pochhammer symbol .
        /// https://reference.wolfram.com/language/ref/QPochhammer.html
        ///</summary>
        public static Engine QPochhammer(this Engine en, string? name = null)
        {
            return en.Execute("QPochhammer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields the QR decomposition for a numerical matrix m. The result is a list {q,r}, where q is a unitary matrix and r is an upper‐triangular matrix.
        /// https://reference.wolfram.com/language/ref/QRDecomposition.html
        ///</summary>
        public static Engine QRDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("QRDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if x is a quadratic irrational and False otherwise.
        /// https://reference.wolfram.com/language/ref/QuadraticIrrationalQ.html
        ///</summary>
        public static Engine QuadraticIrrationalQ(this Engine en, string? name = null)
        {
            return en.Execute("QuadraticIrrationalQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a plot of quantiles of list against the quantiles of a normal distribution.
        /// https://reference.wolfram.com/language/ref/QuantilePlot.html
        ///</summary>
        public static Engine QuantilePlot(this Engine en, string? name = null)
        {
            return en.Execute("QuantilePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// assumes the magnitude of the specified unit to be 1.
        /// https://reference.wolfram.com/language/ref/Quantity.html
        ///</summary>
        public static Engine Quantity(this Engine en, string? name = null)
        {
            return en.Execute("Quantity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts an array of Quantity objects into a single QuantityArray object.
        /// https://reference.wolfram.com/language/ref/QuantityArray.html
        ///</summary>
        public static Engine QuantityArray(this Engine en, string? name = null)
        {
            return en.Execute("QuantityArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the amount of the specified quantity.
        /// https://reference.wolfram.com/language/ref/QuantityMagnitude.html
        ///</summary>
        public static Engine QuantityMagnitude(this Engine en, string? name = null)
        {
            return en.Execute("QuantityMagnitude[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is a Quantity with valid arguments, and False otherwise.
        /// https://reference.wolfram.com/language/ref/QuantityQ.html
        ///</summary>
        public static Engine QuantityQ(this Engine en, string? name = null)
        {
            return en.Execute("QuantityQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the unit associated with the specified quantity.
        /// https://reference.wolfram.com/language/ref/QuantityUnit.html
        ///</summary>
        public static Engine QuantityUnit(this Engine en, string? name = null)
        {
            return en.Execute("QuantityUnit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the unlabeled physical quantity "pq".
        /// https://reference.wolfram.com/language/ref/QuantityVariable.html
        ///</summary>
        public static Engine QuantityVariable(this Engine en, string? name = null)
        {
            return en.Execute("QuantityVariable[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the canonical unit associated with the specified quantityvariable.
        /// https://reference.wolfram.com/language/ref/QuantityVariableCanonicalUnit.html
        ///</summary>
        public static Engine QuantityVariableCanonicalUnit(this Engine en, string? name = null)
        {
            return en.Execute("QuantityVariableCanonicalUnit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a list of base dimensions associated with the specified quantityvariable.
        /// https://reference.wolfram.com/language/ref/QuantityVariableDimensions.html
        ///</summary>
        public static Engine QuantityVariableDimensions(this Engine en, string? name = null)
        {
            return en.Execute("QuantityVariableDimensions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the identifier associated with the specified quantityvariable.
        /// https://reference.wolfram.com/language/ref/QuantityVariableIdentifier.html
        ///</summary>
        public static Engine QuantityVariableIdentifier(this Engine en, string? name = null)
        {
            return en.Execute("QuantityVariableIdentifier[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the physical quantity associated with the quantity variable var.
        /// https://reference.wolfram.com/language/ref/QuantityVariablePhysicalQuantity.html
        ///</summary>
        public static Engine QuantityVariablePhysicalQuantity(this Engine en, string? name = null)
        {
            return en.Execute("QuantityVariablePhysicalQuantity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the quartile deviation or semi-interquartile range of the elements in list.
        /// https://reference.wolfram.com/language/ref/QuartileDeviation.html
        ///</summary>
        public static Engine QuartileDeviation(this Engine en, string? name = null)
        {
            return en.Execute("QuartileDeviation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the 1/4, 1/2 and 3/4 quantiles of the elements in list.
        /// https://reference.wolfram.com/language/ref/Quartiles.html
        ///</summary>
        public static Engine Quartiles(this Engine en, string? name = null)
        {
            return en.Execute("Quartiles[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the coefficient of quartile skewness for the elements in list.
        /// https://reference.wolfram.com/language/ref/QuartileSkewness.html
        ///</summary>
        public static Engine QuartileSkewness(this Engine en, string? name = null)
        {
            return en.Execute("QuartileSkewness[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a cloud-deployed question generator.
        /// https://reference.wolfram.com/language/ref/QuestionGenerator.html
        ///</summary>
        public static Engine QuestionGenerator(this Engine en, string? name = null)
        {
            return en.Execute("QuestionGenerator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// derives a question from the assessment.
        /// https://reference.wolfram.com/language/ref/QuestionObject.html
        ///</summary>
        public static Engine QuestionObject(this Engine en, string? name = null)
        {
            return en.Execute("QuestionObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a list of questions from which one of the question objects qoi can be randomly selected.
        /// https://reference.wolfram.com/language/ref/QuestionSelector.html
        ///</summary>
        public static Engine QuestionSelector(this Engine en, string? name = null)
        {
            return en.Execute("QuestionSelector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a summary of properties for the queueing process qproc.
        /// https://reference.wolfram.com/language/ref/QueueProperties.html
        ///</summary>
        public static Engine QueueProperties(this Engine en, string? name = null)
        {
            return en.Execute("QueueProperties[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates expr "quietly", without actually outputting any messages generated.
        /// https://reference.wolfram.com/language/ref/Quiet.html
        ///</summary>
        public static Engine Quiet(this Engine en, string? name = null)
        {
            return en.Execute("Quiet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates expr without letting Echo and related functions inside expr print any result.
        /// https://reference.wolfram.com/language/ref/QuietEcho.html
        ///</summary>
        public static Engine QuietEcho(this Engine en, string? name = null)
        {
            return en.Execute("QuietEcho[" + en.ValidNames.Last() + "]", name);
        }


    }
}
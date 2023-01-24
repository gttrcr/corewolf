namespace NetWolf
{
    public static class BuiltinSymbolF
    {
        ///<summary>
        ///attempts to find faces in image and align them.
        ///https://reference.wolfram.com/language/ref/FaceAlign.html
        ///</summary>
        public static Engine FaceAlign(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FaceAlign[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives aligned faces according to the face reference fref.
        ///https://reference.wolfram.com/language/ref/FaceAlign.html
        ///</summary>
        public static Engine FaceAlign(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FaceAlign[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives aligned faces of the specified size.
        ///https://reference.wolfram.com/language/ref/FaceAlign.html
        ///</summary>
        public static Engine FaceAlign(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FaceAlign[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of aligned faces for all imagei.
        ///https://reference.wolfram.com/language/ref/FaceAlign.html
        ///</summary>
        public static Engine FaceAlign(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FaceAlign[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that faces of polygons and other filled graphics objects are to be drawn using the graphics directive or list of directives g.
        ///https://reference.wolfram.com/language/ref/FaceForm.html
        ///</summary>
        public static Engine FaceForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FaceForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies that the front faces of three-dimensional polygons should be drawn with directives g, and the backs with directives gback.
        ///https://reference.wolfram.com/language/ref/FaceForm.html
        ///</summary>
        public static Engine FaceForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FaceForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a ClassifierFunction[…] based on the face examples and names given.
        ///https://reference.wolfram.com/language/ref/FaceRecognize.html
        ///</summary>
        public static Engine FaceRecognize(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FaceRecognize[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses an association of names with their examples.
        ///https://reference.wolfram.com/language/ref/FaceRecognize.html
        ///</summary>
        public static Engine FaceRecognize(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FaceRecognize[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///attempts to find faces present in an image and classify them with the given training set.
        ///https://reference.wolfram.com/language/ref/FaceRecognize.html
        ///</summary>
        public static Engine FaceRecognize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FaceRecognize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a minimal summary of facial features for all detected faces in image.
        ///https://reference.wolfram.com/language/ref/FacialFeatures.html
        ///</summary>
        public static Engine FacialFeatures(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FacialFeatures[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the specified facial features.
        ///https://reference.wolfram.com/language/ref/FacialFeatures.html
        ///</summary>
        public static Engine FacialFeatures(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FacialFeatures[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///factors a polynomial over the integers.
        ///https://reference.wolfram.com/language/ref/Factor.html
        ///</summary>
        public static Engine Factor(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Factor[" + arg0 + "]", name);
        }

        ///<summary>
        ///factors a polynomial modulo a prime p.
        ///https://reference.wolfram.com/language/ref/Factor.html
        ///</summary>
        public static Engine Factor(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Factor[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the r moment of the elements in the list.
        ///https://reference.wolfram.com/language/ref/FactorialMoment.html
        ///</summary>
        public static Engine FactorialMoment(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FactorialMoment[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the r factorial moment.
        ///https://reference.wolfram.com/language/ref/FactorialMoment.html
        ///</summary>
        public static Engine FactorialMoment(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FactorialMoment[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the factorial moment-generating function for the distribution dist as a function of the variable t.
        ///https://reference.wolfram.com/language/ref/FactorialMomentGeneratingFunction.html
        ///</summary>
        public static Engine FactorialMomentGeneratingFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FactorialMomentGeneratingFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the factorial moment-generating function for the multivariate distribution dist as a function of the variables t1, t2, ….
        ///https://reference.wolfram.com/language/ref/FactorialMomentGeneratingFunction.html
        ///</summary>
        public static Engine FactorialMomentGeneratingFunction(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FactorialMomentGeneratingFunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the factorial power .
        ///https://reference.wolfram.com/language/ref/FactorialPower.html
        ///</summary>
        public static Engine FactorialPower(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FactorialPower[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the step-h factorial power .
        ///https://reference.wolfram.com/language/ref/FactorialPower.html
        ///</summary>
        public static Engine FactorialPower(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FactorialPower[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the prime factors of the integer n, together with their exponents.
        ///https://reference.wolfram.com/language/ref/FactorInteger.html
        ///</summary>
        public static Engine FactorInteger(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FactorInteger[" + arg0 + "]", name);
        }

        ///<summary>
        ///does partial factorization, pulling out at most k distinct factors.
        ///https://reference.wolfram.com/language/ref/FactorInteger.html
        ///</summary>
        public static Engine FactorInteger(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FactorInteger[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the factors of a polynomial, together with their exponents.
        ///https://reference.wolfram.com/language/ref/FactorList.html
        ///</summary>
        public static Engine FactorList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FactorList[" + arg0 + "]", name);
        }

        ///<summary>
        ///pulls out any multiple factors in a polynomial.
        ///https://reference.wolfram.com/language/ref/FactorSquareFree.html
        ///</summary>
        public static Engine FactorSquareFree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FactorSquareFree[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of square‐free factors of a polynomial, together with their exponents.
        ///https://reference.wolfram.com/language/ref/FactorSquareFreeList.html
        ///</summary>
        public static Engine FactorSquareFreeList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FactorSquareFreeList[" + arg0 + "]", name);
        }

        ///<summary>
        ///pulls out any overall numerical factor in poly.
        ///https://reference.wolfram.com/language/ref/FactorTerms.html
        ///</summary>
        public static Engine FactorTerms(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FactorTerms[" + arg0 + "]", name);
        }

        ///<summary>
        ///pulls out any overall factor in poly that does not depend on x.
        ///https://reference.wolfram.com/language/ref/FactorTerms.html
        ///</summary>
        public static Engine FactorTerms(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FactorTerms[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///pulls out any overall factor in poly that does not depend on any of the xi.
        ///https://reference.wolfram.com/language/ref/FactorTerms.html
        ///</summary>
        public static Engine FactorTerms(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FactorTerms[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list in which the first element is the overall numerical factor in poly, and the second element is the polynomial with the overall factor removed.
        ///https://reference.wolfram.com/language/ref/FactorTermsList.html
        ///</summary>
        public static Engine FactorTermsList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FactorTermsList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of factors of poly. The first element in the list is the overall numerical factor. The second element is a factor that does not depend on any of the xi. Subsequent elements are factors which depend on progressively more of the xi.
        ///https://reference.wolfram.com/language/ref/FactorTermsList.html
        ///</summary>
        public static Engine FactorTermsList(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FactorTermsList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a failure of a type indicated by tag, with details given by the association assoc.
        ///https://reference.wolfram.com/language/ref/Failure.html
        ///</summary>
        public static Engine Failure(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Failure[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the failure distribution for a system with events xi having reliability distribution disti where the top event occurs when the Boolean expression bexpr is True and event xi has occurred when xi is True.
        ///https://reference.wolfram.com/language/ref/FailureDistribution.html
        ///</summary>
        public static Engine FailureDistribution(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FailureDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if expr has head Failure or is equal to $Failed or $Aborted.
        ///https://reference.wolfram.com/language/ref/FailureQ.html
        ///</summary>
        public static Engine FailureQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FailureQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates the Farey sequence of order n.
        ///https://reference.wolfram.com/language/ref/FareySequence.html
        ///</summary>
        public static Engine FareySequence(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FareySequence[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the k element of the Farey sequence of order n.
        ///https://reference.wolfram.com/language/ref/FareySequence.html
        ///</summary>
        public static Engine FareySequence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FareySequence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an autoregressive fractionally integrated moving-average process  such that its d difference is an ARMAProcess[{a1,…,ap},{b1,…,bq,v].
        ///https://reference.wolfram.com/language/ref/FARIMAProcess.html
        ///</summary>
        public static Engine FARIMAProcess(this Engine en, List<object> arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("FARIMAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a vector autoregressive fractionally integrated moving-average process (y1(t),… ,yn(t)) such that its (d1,…,dn) difference is a vector ARMAProcess.
        ///https://reference.wolfram.com/language/ref/FARIMAProcess.html
        ///</summary>
        public static Engine FARIMAProcess(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("FARIMAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the distance between example1 and example2 in the feature space defined by extractor.
        ///https://reference.wolfram.com/language/ref/FeatureDistance.html
        ///</summary>
        public static Engine FeatureDistance(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FeatureDistance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of FeatureDistance that can be applied to a pair of examples.
        ///https://reference.wolfram.com/language/ref/FeatureDistance.html
        ///</summary>
        public static Engine FeatureDistance(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FeatureDistance[" + arg0 + "]", name);
        }

        ///<summary>
        ///extracts features for each of the examplei using a feature extractor trained on all the examplei.
        ///https://reference.wolfram.com/language/ref/FeatureExtract.html
        ///</summary>
        public static Engine FeatureExtract(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FeatureExtract[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///extracts features using the specified feature extractor method.
        ///https://reference.wolfram.com/language/ref/FeatureExtract.html
        ///</summary>
        public static Engine FeatureExtract(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FeatureExtract[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///extracts features by applying the extractori in sequence.
        ///https://reference.wolfram.com/language/ref/FeatureExtract.html
        ///</summary>
        public static Engine FeatureExtract(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FeatureExtract[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a FeatureExtractorFunction[…] trained from the examples given.
        ///https://reference.wolfram.com/language/ref/FeatureExtraction.html
        ///</summary>
        public static Engine FeatureExtraction(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FeatureExtraction[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses the specified feature extractor method.
        ///https://reference.wolfram.com/language/ref/FeatureExtraction.html
        ///</summary>
        public static Engine FeatureExtraction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FeatureExtraction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies the extractori in sequence to generate a feature extractor.
        ///https://reference.wolfram.com/language/ref/FeatureExtraction.html
        ///</summary>
        public static Engine FeatureExtraction(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FeatureExtraction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the feature extraction properties specified by props.
        ///https://reference.wolfram.com/language/ref/FeatureExtraction.html
        ///</summary>
        public static Engine FeatureExtraction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FeatureExtraction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a feature extractor function generated by FeatureExtraction.
        ///https://reference.wolfram.com/language/ref/FeatureExtractorFunction.html
        ///</summary>
        public static Engine FeatureExtractorFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FeatureExtractorFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the impact of the value of each feature in data on the result of model.
        ///https://reference.wolfram.com/language/ref/FeatureImpactPlot.html
        ///</summary>
        public static Engine FeatureImpactPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FeatureImpactPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the feature impacts using synthetic data.
        ///https://reference.wolfram.com/language/ref/FeatureImpactPlot.html
        ///</summary>
        public static Engine FeatureImpactPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FeatureImpactPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of elemi to which x is nearest in a computed feature space.
        ///https://reference.wolfram.com/language/ref/FeatureNearest.html
        ///</summary>
        public static Engine FeatureNearest(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FeatureNearest[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the property prop for the elemi to which x is nearest.
        ///https://reference.wolfram.com/language/ref/FeatureNearest.html
        ///</summary>
        public static Engine FeatureNearest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FeatureNearest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///effectively gives {FeatureNearest[data,x1],FeatureNearest[data,x2],…}.
        ///https://reference.wolfram.com/language/ref/FeatureNearest.html
        ///</summary>
        public static Engine FeatureNearest(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FeatureNearest[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n nearest elemi to x.
        ///https://reference.wolfram.com/language/ref/FeatureNearest.html
        ///</summary>
        public static Engine FeatureNearest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FeatureNearest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a NearestFunction[…] that can be applied repeatedly to different x.
        ///https://reference.wolfram.com/language/ref/FeatureNearest.html
        ///</summary>
        public static Engine FeatureNearest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FeatureNearest[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots features extracted from the examplei as a scatter plot.
        ///https://reference.wolfram.com/language/ref/FeatureSpacePlot.html
        ///</summary>
        public static Engine FeatureSpacePlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FeatureSpacePlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots features extracted from the examplei as a scatter 3D plot.
        ///https://reference.wolfram.com/language/ref/FeatureSpacePlot3D.html
        ///</summary>
        public static Engine FeatureSpacePlot3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FeatureSpacePlot3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots the dependency of the result of model on the value of a particular feature in data.
        ///https://reference.wolfram.com/language/ref/FeatureValueDependencyPlot.html
        ///</summary>
        public static Engine FeatureValueDependencyPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FeatureValueDependencyPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the feature value dependency using synthetic data.
        ///https://reference.wolfram.com/language/ref/FeatureValueDependencyPlot.html
        ///</summary>
        public static Engine FeatureValueDependencyPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FeatureValueDependencyPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the impact of the value of a given feature in data on the result of model.
        ///https://reference.wolfram.com/language/ref/FeatureValueImpactPlot.html
        ///</summary>
        public static Engine FeatureValueImpactPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FeatureValueImpactPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the feature value impact using synthetic data.
        ///https://reference.wolfram.com/language/ref/FeatureValueImpactPlot.html
        ///</summary>
        public static Engine FeatureValueImpactPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FeatureValueImpactPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///input-output linearizes the AffineStateSpaceModel asys by state transformation and feedback.
        ///https://reference.wolfram.com/language/ref/FeedbackLinearize.html
        ///</summary>
        public static Engine FeedbackLinearize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FeedbackLinearize[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies the new states z and the new control inputs v.
        ///https://reference.wolfram.com/language/ref/FeedbackLinearize.html
        ///</summary>
        public static Engine FeedbackLinearize(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FeedbackLinearize[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///computes the property "prop".
        ///https://reference.wolfram.com/language/ref/FeedbackLinearize.html
        ///</summary>
        public static Engine FeedbackLinearize(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FeedbackLinearize[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the values for all properties of fetal development for the specified age of the fetus.
        ///https://reference.wolfram.com/language/ref/FetalGrowthData.html
        ///</summary>
        public static Engine FetalGrowthData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FetalGrowthData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the value for a property of fetal development for the specified age.
        ///https://reference.wolfram.com/language/ref/FetalGrowthData.html
        ///</summary>
        public static Engine FetalGrowthData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FetalGrowthData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value for a property at the specified age and percentile.
        ///https://reference.wolfram.com/language/ref/FetalGrowthData.html
        ///</summary>
        public static Engine FetalGrowthData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FetalGrowthData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Fibonacci number .
        ///https://reference.wolfram.com/language/ref/Fibonacci.html
        ///</summary>
        public static Engine Fibonacci(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Fibonacci[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Fibonacci polynomial .
        ///https://reference.wolfram.com/language/ref/Fibonacci.html
        ///</summary>
        public static Engine Fibonacci(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Fibonacci[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the fibonorial .
        ///https://reference.wolfram.com/language/ref/Fibonorial.html
        ///</summary>
        public static Engine Fibonorial(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Fibonorial[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a symbolic representation of a location in the local file system.
        ///https://reference.wolfram.com/language/ref/File.html
        ///</summary>
        public static Engine File(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("File[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the base name for a file without its extension.
        ///https://reference.wolfram.com/language/ref/FileBaseName.html
        ///</summary>
        public static Engine FileBaseName(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileBaseName[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of bytes in a file.
        ///https://reference.wolfram.com/language/ref/FileByteCount.html
        ///</summary>
        public static Engine FileByteCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileByteCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts the contents of source to the format defined by the extension ext and writes the result to the file dest.ext.
        ///https://reference.wolfram.com/language/ref/FileConvert.html
        ///</summary>
        public static Engine FileConvert(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileConvert[" + arg0 + "]", name);
        }

        ///<summary>
        ///writes the result to the filename defined by source, but with an extension defined by the specified format.
        ///https://reference.wolfram.com/language/ref/FileConvert.html
        ///</summary>
        public static Engine FileConvert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileConvert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the date and time at which a file was last modified.
        ///https://reference.wolfram.com/language/ref/FileDate.html
        ///</summary>
        public static Engine FileDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives information on the specified type of date associated with a file.
        ///https://reference.wolfram.com/language/ref/FileDate.html
        ///</summary>
        public static Engine FileDate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileDate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if the file with the specified name exists, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/FileExistsQ.html
        ///</summary>
        public static Engine FileExistsQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileExistsQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the file extension for a file name.
        ///https://reference.wolfram.com/language/ref/FileExtension.html
        ///</summary>
        public static Engine FileExtension(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileExtension[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to determine what Import format could be used to import the file corresponding to source.
        ///https://reference.wolfram.com/language/ref/FileFormat.html
        ///</summary>
        public static Engine FileFormat(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileFormat[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the first "fmti" that can be used to import source.
        ///https://reference.wolfram.com/language/ref/FileFormat.html
        ///</summary>
        public static Engine FileFormat(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FileFormat[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns an association of properties for the specified format "fmt".
        ///https://reference.wolfram.com/language/ref/FileFormatProperties.html
        ///</summary>
        public static Engine FileFormatProperties(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileFormatProperties[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the property "prop" for the format "fmt".
        ///https://reference.wolfram.com/language/ref/FileFormatProperties.html
        ///</summary>
        public static Engine FileFormatProperties(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileFormatProperties[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns multiple properties.
        ///https://reference.wolfram.com/language/ref/FileFormatProperties.html
        ///</summary>
        public static Engine FileFormatProperties(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FileFormatProperties[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if the file corresponding to source might be imported as format "fmt" and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/FileFormatQ.html
        ///</summary>
        public static Engine FileFormatQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileFormatQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if source might be imported as one of "fmti".
        ///https://reference.wolfram.com/language/ref/FileFormatQ.html
        ///</summary>
        public static Engine FileFormatQ(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FileFormatQ[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives an integer hash code for the contents of the specified file.
        ///https://reference.wolfram.com/language/ref/FileHash.html
        ///</summary>
        public static Engine FileHash(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileHash[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an integer hash of the specified type.
        ///https://reference.wolfram.com/language/ref/FileHash.html
        ///</summary>
        public static Engine FileHash(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileHash[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a hash code in the specified format.
        ///https://reference.wolfram.com/language/ref/FileHash.html
        ///</summary>
        public static Engine FileHash(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FileHash[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the hash code for the specified range of bytes.
        ///https://reference.wolfram.com/language/ref/FileHash.html
        ///</summary>
        public static Engine FileHash(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FileHash[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the number of path elements in the file name "file".
        ///https://reference.wolfram.com/language/ref/FileNameDepth.html
        ///</summary>
        public static Engine FileNameDepth(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileNameDepth[" + arg0 + "]", name);
        }

        ///<summary>
        ///drops the first n path elements in the file name "name".
        ///https://reference.wolfram.com/language/ref/FileNameDrop.html
        ///</summary>
        public static Engine FileNameDrop(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileNameDrop[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///drops elements m through n in the file name "name".
        ///https://reference.wolfram.com/language/ref/FileNameDrop.html
        ///</summary>
        public static Engine FileNameDrop(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FileNameDrop[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///drops the last path element in the file name "name".
        ///https://reference.wolfram.com/language/ref/FileNameDrop.html
        ///</summary>
        public static Engine FileNameDrop(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileNameDrop[" + arg0 + "]", name);
        }

        ///<summary>
        ///joins the namei together into a file name suitable for your current operating system.
        ///https://reference.wolfram.com/language/ref/FileNameJoin.html
        ///</summary>
        public static Engine FileNameJoin(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FileNameJoin[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///lists all files in the current working directory.
        ///https://reference.wolfram.com/language/ref/FileNames.html
        ///</summary>
        public static Engine FileNames(this Engine en, string? name = null)
        {
            return en.Execute("FileNames[]", name);
        }

        ///<summary>
        ///lists all files in the current working directory whose names match the string pattern form.
        ///https://reference.wolfram.com/language/ref/FileNames.html
        ///</summary>
        public static Engine FileNames(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileNames[" + arg0 + "]", name);
        }

        ///<summary>
        ///lists all files whose names match any of the formi.
        ///https://reference.wolfram.com/language/ref/FileNames.html
        ///</summary>
        public static Engine FileNames(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FileNames[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///lists all files in the directory dir.
        ///https://reference.wolfram.com/language/ref/FileNames.html
        ///</summary>
        public static Engine FileNames(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileNames[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///lists files with names matching forms in any of the directories diri.
        ///https://reference.wolfram.com/language/ref/FileNames.html
        ///</summary>
        public static Engine FileNames(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FileNames[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///includes files that are in subdirectories up to n levels down.
        ///https://reference.wolfram.com/language/ref/FileNames.html
        ///</summary>
        public static Engine FileNames(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FileNames[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a file name setter which displays as a Browse button and when clicked brings up a system file opening dialog, starting from the location corresponding to name.
        ///https://reference.wolfram.com/language/ref/FileNameSetter.html
        ///</summary>
        public static Engine FileNameSetter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileNameSetter[" + arg0 + "]", name);
        }

        ///<summary>
        ///brings up a file saving dialog.
        ///https://reference.wolfram.com/language/ref/FileNameSetter.html
        ///</summary>
        public static Engine FileNameSetter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileNameSetter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///looks for files of types typei with names matching the file patterns pattij.
        ///https://reference.wolfram.com/language/ref/FileNameSetter.html
        ///</summary>
        public static Engine FileNameSetter(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("FileNameSetter[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///splits a file name into a list of parts.
        ///https://reference.wolfram.com/language/ref/FileNameSplit.html
        ///</summary>
        public static Engine FileNameSplit(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileNameSplit[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the last path element in the file name "name".
        ///https://reference.wolfram.com/language/ref/FileNameTake.html
        ///</summary>
        public static Engine FileNameTake(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileNameTake[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the first n path elements in the file name "name".
        ///https://reference.wolfram.com/language/ref/FileNameTake.html
        ///</summary>
        public static Engine FileNameTake(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileNameTake[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives elements m through n in the file name "name".
        ///https://reference.wolfram.com/language/ref/FileNameTake.html
        ///</summary>
        public static Engine FileNameTake(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FileNameTake[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns lists of file formats corresponding to all registered file name patterns.
        ///https://reference.wolfram.com/language/ref/FileNameToFormatList.html
        ///</summary>
        public static Engine FileNameToFormatList(this Engine en, string? name = null)
        {
            return en.Execute("FileNameToFormatList[]", name);
        }

        ///<summary>
        ///returns a list of file formats that matches the file name "file".
        ///https://reference.wolfram.com/language/ref/FileNameToFormatList.html
        ///</summary>
        public static Engine FileNameToFormatList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileNameToFormatList[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints out the raw textual contents of file.
        ///https://reference.wolfram.com/language/ref/FilePrint.html
        ///</summary>
        public static Engine FilePrint(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FilePrint[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints out the first n raw textual lines of file.
        ///https://reference.wolfram.com/language/ref/FilePrint.html
        ///</summary>
        public static Engine FilePrint(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FilePrint[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the size of a file as a quantity.
        ///https://reference.wolfram.com/language/ref/FileSize.html
        ///</summary>
        public static Engine FileSize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileSize[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an association whose keys are the names of files in root, and whose values are the results of applying f to the full names of these files.
        ///https://reference.wolfram.com/language/ref/FileSystemMap.html
        ///</summary>
        public static Engine FileSystemMap(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileSystemMap[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a nested association in which subdirectories down to level n are represented by an association.
        ///https://reference.wolfram.com/language/ref/FileSystemMap.html
        ///</summary>
        public static Engine FileSystemMap(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FileSystemMap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a nested association including files in subdirectories from level m down through n.
        ///https://reference.wolfram.com/language/ref/FileSystemMap.html
        ///</summary>
        public static Engine FileSystemMap(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FileSystemMap[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///combines levels to give a nested output association with r levels.
        ///https://reference.wolfram.com/language/ref/FileSystemMap.html
        ///</summary>
        public static Engine FileSystemMap(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FileSystemMap[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///evaluates f on all files contained in root.
        ///https://reference.wolfram.com/language/ref/FileSystemScan.html
        ///</summary>
        public static Engine FileSystemScan(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileSystemScan[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///restricts the operation to directories at level n.
        ///https://reference.wolfram.com/language/ref/FileSystemScan.html
        ///</summary>
        public static Engine FileSystemScan(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FileSystemScan[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject expression that represents a file template to be applied using functions like TemplateApply.
        ///https://reference.wolfram.com/language/ref/FileTemplate.html
        ///</summary>
        public static Engine FileTemplate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileTemplate[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject with arguments, suitable for cloud deployment or other evaluation.
        ///https://reference.wolfram.com/language/ref/FileTemplate.html
        ///</summary>
        public static Engine FileTemplate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileTemplate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies a template, evaluating all template elements it contains, and then writes the result to a temporary file, whose name is returned.
        ///https://reference.wolfram.com/language/ref/FileTemplateApply.html
        ///</summary>
        public static Engine FileTemplateApply(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileTemplateApply[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies a template, using args to fill its slots, and then writes the result to a temporary file.
        ///https://reference.wolfram.com/language/ref/FileTemplateApply.html
        ///</summary>
        public static Engine FileTemplateApply(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FileTemplateApply[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies a template, using args to fill its slots, and then writes the result to the file represented by output.
        ///https://reference.wolfram.com/language/ref/FileTemplateApply.html
        ///</summary>
        public static Engine FileTemplateApply(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FileTemplateApply[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the type of a file, typically File, Directory, or None.
        ///https://reference.wolfram.com/language/ref/FileType.html
        ///</summary>
        public static Engine FileType(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FileType[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a filled curve consisting of segment1 followed by segment2 etc.
        ///https://reference.wolfram.com/language/ref/FilledCurve.html
        ///</summary>
        public static Engine FilledCurve(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FilledCurve[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a filled torus centered at {x,y,z} with inner radius rinner and outer radius router.
        ///https://reference.wolfram.com/language/ref/FilledTorus.html
        ///</summary>
        public static Engine FilledTorus(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FilledTorus[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a version of image with all extended minima filled.
        ///https://reference.wolfram.com/language/ref/FillingTransform.html
        ///</summary>
        public static Engine FillingTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FillingTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///fills extended minima in regions where at least one corresponding element of marker is nonzero.
        ///https://reference.wolfram.com/language/ref/FillingTransform.html
        ///</summary>
        public static Engine FillingTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FillingTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a class of entities where only entities for which the EntityFunction object f yields True are kept.
        ///https://reference.wolfram.com/language/ref/FilteredEntityClass.html
        ///</summary>
        public static Engine FilteredEntityClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FilteredEntityClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///filters the list rules by picking out only those rules whose left-hand sides match patt.
        ///https://reference.wolfram.com/language/ref/FilterRules.html
        ///</summary>
        public static Engine FilterRules(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FilterRules[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///picks out rules whose left-hand sides match any of the patti.
        ///https://reference.wolfram.com/language/ref/FilterRules.html
        ///</summary>
        public static Engine FilterRules(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FilterRules[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of a financial bond instrument.
        ///https://reference.wolfram.com/language/ref/FinancialBond.html
        ///</summary>
        public static Engine FinancialBond(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FinancialBond[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes the specified property prop.
        ///https://reference.wolfram.com/language/ref/FinancialBond.html
        ///</summary>
        public static Engine FinancialBond(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FinancialBond[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the last known price or value for the financial entity specified by "name".
        ///https://reference.wolfram.com/language/ref/FinancialData.html
        ///</summary>
        public static Engine FinancialData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FinancialData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of dates and daily closing values for "name" from start until the current date.
        ///https://reference.wolfram.com/language/ref/FinancialData.html
        ///</summary>
        public static Engine FinancialData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FinancialData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of dates and daily closing values for dates from start to end.
        ///https://reference.wolfram.com/language/ref/FinancialData.html
        ///</summary>
        public static Engine FinancialData(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FinancialData[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of dates and values of a property for a sequence of dates or periods.
        ///https://reference.wolfram.com/language/ref/FinancialData.html
        ///</summary>
        public static Engine FinancialData(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FinancialData[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the specified financial instrument.
        ///https://reference.wolfram.com/language/ref/FinancialDerivative.html
        ///</summary>
        public static Engine FinancialDerivative(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FinancialDerivative[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the specified property prop.
        ///https://reference.wolfram.com/language/ref/FinancialDerivative.html
        ///</summary>
        public static Engine FinancialDerivative(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FinancialDerivative[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a financial indicator "ind" with parameters par1, par2, etc.
        ///https://reference.wolfram.com/language/ref/FinancialIndicator.html
        ///</summary>
        public static Engine FinancialIndicator(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FinancialIndicator[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds the first line in an input stream that contains the specified string.
        ///https://reference.wolfram.com/language/ref/Find.html
        ///</summary>
        public static Engine Find(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Find[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the first line that contains any of the specified strings.
        ///https://reference.wolfram.com/language/ref/Find.html
        ///</summary>
        public static Engine Find(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Find[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of the examplei that are considered anomalous with respect to the other examples.
        ///https://reference.wolfram.com/language/ref/FindAnomalies.html
        ///</summary>
        public static Engine FindAnomalies(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindAnomalies[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the specified property related to the anomaly computation.
        ///https://reference.wolfram.com/language/ref/FindAnomalies.html
        ///</summary>
        public static Engine FindAnomalies(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindAnomalies[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the properties propi.
        ///https://reference.wolfram.com/language/ref/FindAnomalies.html
        ///</summary>
        public static Engine FindAnomalies(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindAnomalies[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives properties related to the anomaly computation.
        ///https://reference.wolfram.com/language/ref/FindAnomalies.html
        ///</summary>
        public static Engine FindAnomalies(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindAnomalies[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the position xmax of a local maximum of f.
        ///https://reference.wolfram.com/language/ref/FindArgMax.html
        ///</summary>
        public static Engine FindArgMax(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindArgMax[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the position xmax of a local maximum of f, found by a search starting from the point x=x0.
        ///https://reference.wolfram.com/language/ref/FindArgMax.html
        ///</summary>
        public static Engine FindArgMax(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindArgMax[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the position {xmax,ymax,…} of a local maximum of a function of several variables.
        ///https://reference.wolfram.com/language/ref/FindArgMax.html
        ///</summary>
        public static Engine FindArgMax(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindArgMax[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the position of a local maximum subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/FindArgMax.html
        ///</summary>
        public static Engine FindArgMax(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindArgMax[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///starts from a point within the region defined by the constraints.
        ///https://reference.wolfram.com/language/ref/FindArgMax.html
        ///</summary>
        public static Engine FindArgMax(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindArgMax[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the position xmin of a local minimum of f.
        ///https://reference.wolfram.com/language/ref/FindArgMin.html
        ///</summary>
        public static Engine FindArgMin(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindArgMin[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the position xmin of a local minimum of f, found by a search starting from the point x=x0.
        ///https://reference.wolfram.com/language/ref/FindArgMin.html
        ///</summary>
        public static Engine FindArgMin(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindArgMin[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the position {xmin,ymin,…} of a local minimum of a function of several variables.
        ///https://reference.wolfram.com/language/ref/FindArgMin.html
        ///</summary>
        public static Engine FindArgMin(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindArgMin[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the position of a local minimum subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/FindArgMin.html
        ///</summary>
        public static Engine FindArgMin(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindArgMin[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///starts from a point within the region defined by the constraints.
        ///https://reference.wolfram.com/language/ref/FindArgMin.html
        ///</summary>
        public static Engine FindArgMin(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindArgMin[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of channels in your home area on the channel broker server.
        ///https://reference.wolfram.com/language/ref/FindChannels.html
        ///</summary>
        public static Engine FindChannels(this Engine en, string? name = null)
        {
            return en.Execute("FindChannels[]", name);
        }

        ///<summary>
        ///gives a list of your unnamed channels.
        ///https://reference.wolfram.com/language/ref/FindChannels.html
        ///</summary>
        public static Engine FindChannels(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindChannels[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a largest clique in the graph g.
        ///https://reference.wolfram.com/language/ref/FindClique.html
        ///</summary>
        public static Engine FindClique(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindClique[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a clique containing at most n vertices.
        ///https://reference.wolfram.com/language/ref/FindClique.html
        ///</summary>
        public static Engine FindClique(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindClique[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a clique containing exactly n vertices.
        ///https://reference.wolfram.com/language/ref/FindClique.html
        ///</summary>
        public static Engine FindClique(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindClique[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds at most s cliques.
        ///https://reference.wolfram.com/language/ref/FindClique.html
        ///</summary>
        public static Engine FindClique(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindClique[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds cliques that include the vertex v only.
        ///https://reference.wolfram.com/language/ref/FindClique.html
        ///</summary>
        public static Engine FindClique(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindClique[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///partitions the ei into clusters of similar elements.
        ///https://reference.wolfram.com/language/ref/FindClusters.html
        ///</summary>
        public static Engine FindClusters(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindClusters[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///partitions data into n clusters.
        ///https://reference.wolfram.com/language/ref/FindClusters.html
        ///</summary>
        public static Engine FindClusters(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindClusters[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of all currently set cookies.
        ///https://reference.wolfram.com/language/ref/FindCookies.html
        ///</summary>
        public static Engine FindCookies(this Engine en, string? name = null)
        {
            return en.Execute("FindCookies[]", name);
        }

        ///<summary>
        ///gives a list of cookies associated with the specified domain.
        ///https://reference.wolfram.com/language/ref/FindCookies.html
        ///</summary>
        public static Engine FindCookies(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindCookies[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an ordering of the {xi,yi} that corresponds to one or more smooth curves.
        ///https://reference.wolfram.com/language/ref/FindCurvePath.html
        ///</summary>
        public static Engine FindCurvePath(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindCurvePath[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds a cycle in the graph g.
        ///https://reference.wolfram.com/language/ref/FindCycle.html
        ///</summary>
        public static Engine FindCycle(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindCycle[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a cycle of length at most k in the graph g.
        ///https://reference.wolfram.com/language/ref/FindCycle.html
        ///</summary>
        public static Engine FindCycle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindCycle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a cycle of length exactly k.
        ///https://reference.wolfram.com/language/ref/FindCycle.html
        ///</summary>
        public static Engine FindCycle(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindCycle[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds at most s cycles.
        ///https://reference.wolfram.com/language/ref/FindCycle.html
        ///</summary>
        public static Engine FindCycle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindCycle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds cycles that include the vertex v.
        ///https://reference.wolfram.com/language/ref/FindCycle.html
        ///</summary>
        public static Engine FindCycle(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindCycle[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///searches for available devices on your computer system.
        ///https://reference.wolfram.com/language/ref/FindDevices.html
        ///</summary>
        public static Engine FindDevices(this Engine en, string? name = null)
        {
            return en.Execute("FindDevices[]", name);
        }

        ///<summary>
        ///gives a list of devices in classes whose names match the string pattern form.
        ///https://reference.wolfram.com/language/ref/FindDevices.html
        ///</summary>
        public static Engine FindDevices(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindDevices[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of devices in classes whose names match any of the formi.
        ///https://reference.wolfram.com/language/ref/FindDevices.html
        ///</summary>
        public static Engine FindDevices(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindDevices[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns at most n devices.
        ///https://reference.wolfram.com/language/ref/FindDevices.html
        ///</summary>
        public static Engine FindDevices(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindDevices[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a simple functional form to fit the distribution of data.
        ///https://reference.wolfram.com/language/ref/FindDistribution.html
        ///</summary>
        public static Engine FindDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds up to n best distributions.
        ///https://reference.wolfram.com/language/ref/FindDistribution.html
        ///</summary>
        public static Engine FindDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns up to n best distributions associated with property prop.
        ///https://reference.wolfram.com/language/ref/FindDistribution.html
        ///</summary>
        public static Engine FindDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns up to n best distributions associated with properties prop1, prop2, etc.
        ///https://reference.wolfram.com/language/ref/FindDistribution.html
        ///</summary>
        public static Engine FindDistribution(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindDistribution[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///finds the parameter estimates for the distribution dist from data.
        ///https://reference.wolfram.com/language/ref/FindDistributionParameters.html
        ///</summary>
        public static Engine FindDistributionParameters(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindDistributionParameters[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the parameters p, q, … with starting values p0, q0, ….
        ///https://reference.wolfram.com/language/ref/FindDistributionParameters.html
        ///</summary>
        public static Engine FindDistributionParameters(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("FindDistributionParameters[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///finds a list of about n "nice" numbers that divide the interval around xmin to xmax into equally spaced parts.
        ///https://reference.wolfram.com/language/ref/FindDivisions.html
        ///</summary>
        public static Engine FindDivisions(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindDivisions[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds successive subdivisions into about n1, n2, … parts.
        ///https://reference.wolfram.com/language/ref/FindDivisions.html
        ///</summary>
        public static Engine FindDivisions(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindDivisions[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses spacings that are forced to be multiples of dx1, dx2, ….
        ///https://reference.wolfram.com/language/ref/FindDivisions.html
        ///</summary>
        public static Engine FindDivisions(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("FindDivisions[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///finds a coloring with minimal size for the edges in the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeColoring.html
        ///</summary>
        public static Engine FindEdgeColoring(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindEdgeColoring[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a coloring {c1,c2,…,ck} for the edges in the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeColoring.html
        ///</summary>
        public static Engine FindEdgeColoring(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindEdgeColoring[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds an edge cover of the graph g with a minimum number of edges.
        ///https://reference.wolfram.com/language/ref/FindEdgeCover.html
        ///</summary>
        public static Engine FindEdgeCover(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindEdgeCover[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeCover.html
        ///</summary>
        public static Engine FindEdgeCover(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindEdgeCover[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds a smallest edge cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeCut.html
        ///</summary>
        public static Engine FindEdgeCut(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindEdgeCut[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a smallest s-t edge cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeCut.html
        ///</summary>
        public static Engine FindEdgeCut(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindEdgeCut[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeCut.html
        ///</summary>
        public static Engine FindEdgeCut(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindEdgeCut[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds at most k edge-independent paths from vertex s to vertex t in the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeIndependentPaths.html
        ///</summary>
        public static Engine FindEdgeIndependentPaths(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindEdgeIndependentPaths[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeIndependentPaths.html
        ///</summary>
        public static Engine FindEdgeIndependentPaths(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindEdgeIndependentPaths[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tries to find an equational proof of the symbolic theorem thm using the axioms axms.
        ///https://reference.wolfram.com/language/ref/FindEquationalProof.html
        ///</summary>
        public static Engine FindEquationalProof(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindEquationalProof[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds an Eulerian cycle in the graph g.
        ///https://reference.wolfram.com/language/ref/FindEulerianCycle.html
        ///</summary>
        public static Engine FindEulerianCycle(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindEulerianCycle[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds at most k Eulerian cycles.
        ///https://reference.wolfram.com/language/ref/FindEulerianCycle.html
        ///</summary>
        public static Engine FindEulerianCycle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindEulerianCycle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindEulerianCycle.html
        ///</summary>
        public static Engine FindEulerianCycle(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindEulerianCycle[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds installed external evaluators that can be used with ExternalEvaluate, returning a dataset of the results found.
        ///https://reference.wolfram.com/language/ref/FindExternalEvaluators.html
        ///</summary>
        public static Engine FindExternalEvaluators(this Engine en, string? name = null)
        {
            return en.Execute("FindExternalEvaluators[]", name);
        }

        ///<summary>
        ///finds only external evaluators for language or system sys.
        ///https://reference.wolfram.com/language/ref/FindExternalEvaluators.html
        ///</summary>
        public static Engine FindExternalEvaluators(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindExternalEvaluators[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to find human faces in image and returns a list of bounding boxes.
        ///https://reference.wolfram.com/language/ref/FindFaces.html
        ///</summary>
        public static Engine FindFaces(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindFaces[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the specified property prop for each detected face.
        ///https://reference.wolfram.com/language/ref/FindFaces.html
        ///</summary>
        public static Engine FindFaces(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindFaces[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds faces that satisfy the criterion crit.
        ///https://reference.wolfram.com/language/ref/FindFaces.html
        ///</summary>
        public static Engine FindFaces(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindFaces[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the file with the specified name that would be loaded by Get[name] and related functions.
        ///https://reference.wolfram.com/language/ref/FindFile.html
        ///</summary>
        public static Engine FindFile(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindFile[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds numerical values of the parameters pars that make expr give a best fit to data as a function of vars.
        ///https://reference.wolfram.com/language/ref/FindFit.html
        ///</summary>
        public static Engine FindFit(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindFit[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds a best fit subject to the parameter constraints cons.
        ///https://reference.wolfram.com/language/ref/FindFit.html
        ///</summary>
        public static Engine FindFit(this Engine en, object arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindFit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds a pure function that approximates data.
        ///https://reference.wolfram.com/language/ref/FindFormula.html
        ///</summary>
        public static Engine FindFormula(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindFormula[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a symbolic function of the variable x that approximates data.
        ///https://reference.wolfram.com/language/ref/FindFormula.html
        ///</summary>
        public static Engine FindFormula(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindFormula[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds up to n functions that approximate data.
        ///https://reference.wolfram.com/language/ref/FindFormula.html
        ///</summary>
        public static Engine FindFormula(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindFormula[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns up to n best functions associated with property prop.
        ///https://reference.wolfram.com/language/ref/FindFormula.html
        ///</summary>
        public static Engine FindFormula(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindFormula[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///returns up to n best functions associated with properties prop1, prop2, etc.
        ///https://reference.wolfram.com/language/ref/FindFormula.html
        ///</summary>
        public static Engine FindFormula(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("FindFormula[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///finds fundamental cycles of the graph g.
        ///https://reference.wolfram.com/language/ref/FindFundamentalCycles.html
        ///</summary>
        public static Engine FindFundamentalCycles(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindFundamentalCycles[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to find a simple generating function in x whose n series coefficient is an.
        ///https://reference.wolfram.com/language/ref/FindGeneratingFunction.html
        ///</summary>
        public static Engine FindGeneratingFunction(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindGeneratingFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///attempts to find a simple generating function whose ni series coefficient is ai.
        ///https://reference.wolfram.com/language/ref/FindGeneratingFunction.html
        ///</summary>
        public static Engine FindGeneratingFunction(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FindGeneratingFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///attempts to find the current geo location of your computer.
        ///https://reference.wolfram.com/language/ref/FindGeoLocation.html
        ///</summary>
        public static Engine FindGeoLocation(this Engine en, string? name = null)
        {
            return en.Execute("FindGeoLocation[]", name);
        }

        ///<summary>
        ///gives an estimate of the geo location associated with the IP address given.
        ///https://reference.wolfram.com/language/ref/FindGeoLocation.html
        ///</summary>
        public static Engine FindGeoLocation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindGeoLocation[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds conjectures that appear to hold for the GeometricScene object scene and adds these conjectures to the scene object.
        ///https://reference.wolfram.com/language/ref/FindGeometricConjectures.html
        ///</summary>
        public static Engine FindGeometricConjectures(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindGeometricConjectures[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds conjectures that appear to hold for all instances scenei of a geometric scene and returns a combined scene with the conjectures added.
        ///https://reference.wolfram.com/language/ref/FindGeometricConjectures.html
        ///</summary>
        public static Engine FindGeometricConjectures(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindGeometricConjectures[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///adds only conjectures that match the pattern patt.
        ///https://reference.wolfram.com/language/ref/FindGeometricConjectures.html
        ///</summary>
        public static Engine FindGeometricConjectures(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindGeometricConjectures[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds only up to n conjectures.
        ///https://reference.wolfram.com/language/ref/FindGeometricConjectures.html
        ///</summary>
        public static Engine FindGeometricConjectures(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindGeometricConjectures[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a geometric transformation that aligns positions specified by pts2 with pts1, returning the alignment error together with the transformation function.
        ///https://reference.wolfram.com/language/ref/FindGeometricTransform.html
        ///</summary>
        public static Engine FindGeometricTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindGeometricTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds geometric transformations that align each of the ptsi with ref.
        ///https://reference.wolfram.com/language/ref/FindGeometricTransform.html
        ///</summary>
        public static Engine FindGeometricTransform(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindGeometricTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds geometric transformations that align each of the ptsi with pts1.
        ///https://reference.wolfram.com/language/ref/FindGeometricTransform.html
        ///</summary>
        public static Engine FindGeometricTransform(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindGeometricTransform[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds communities in the graph g.
        ///https://reference.wolfram.com/language/ref/FindGraphCommunities.html
        ///</summary>
        public static Engine FindGraphCommunities(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindGraphCommunities[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindGraphCommunities.html
        ///</summary>
        public static Engine FindGraphCommunities(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindGraphCommunities[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds an isomorphism that maps the graph g1 to g2 by renaming vertices.
        ///https://reference.wolfram.com/language/ref/FindGraphIsomorphism.html
        ///</summary>
        public static Engine FindGraphIsomorphism(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindGraphIsomorphism[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds at most n isomorphisms.
        ///https://reference.wolfram.com/language/ref/FindGraphIsomorphism.html
        ///</summary>
        public static Engine FindGraphIsomorphism(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindGraphIsomorphism[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindGraphIsomorphism.html
        ///</summary>
        public static Engine FindGraphIsomorphism(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindGraphIsomorphism[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a partition of vertices of the graph g.
        ///https://reference.wolfram.com/language/ref/FindGraphPartition.html
        ///</summary>
        public static Engine FindGraphPartition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindGraphPartition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a partition of vertices into k approximately equal-size parts.
        ///https://reference.wolfram.com/language/ref/FindGraphPartition.html
        ///</summary>
        public static Engine FindGraphPartition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindGraphPartition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a partition of vertices into parts with sizes n1, …, nk.
        ///https://reference.wolfram.com/language/ref/FindGraphPartition.html
        ///</summary>
        public static Engine FindGraphPartition(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindGraphPartition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindGraphPartition.html
        ///</summary>
        public static Engine FindGraphPartition(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindGraphPartition[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a Hamiltonian cycle in the graph g.
        ///https://reference.wolfram.com/language/ref/FindHamiltonianCycle.html
        ///</summary>
        public static Engine FindHamiltonianCycle(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindHamiltonianCycle[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds at most k Hamiltonian cycles.
        ///https://reference.wolfram.com/language/ref/FindHamiltonianCycle.html
        ///</summary>
        public static Engine FindHamiltonianCycle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindHamiltonianCycle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindHamiltonianCycle.html
        ///</summary>
        public static Engine FindHamiltonianCycle(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindHamiltonianCycle[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a Hamiltonian path in the graph g with the smallest total length.
        ///https://reference.wolfram.com/language/ref/FindHamiltonianPath.html
        ///</summary>
        public static Engine FindHamiltonianPath(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindHamiltonianPath[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a Hamiltonian path with the smallest total length from s to t.
        ///https://reference.wolfram.com/language/ref/FindHamiltonianPath.html
        ///</summary>
        public static Engine FindHamiltonianPath(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindHamiltonianPath[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the most likely hidden states of the HiddenMarkovProcess hmm corresponding to the emissions data.
        ///https://reference.wolfram.com/language/ref/FindHiddenMarkovStates.html
        ///</summary>
        public static Engine FindHiddenMarkovStates(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindHiddenMarkovStates[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the given criterion crit to find the hidden states.
        ///https://reference.wolfram.com/language/ref/FindHiddenMarkovStates.html
        ///</summary>
        public static Engine FindHiddenMarkovStates(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindHiddenMarkovStates[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///detects text in image and returns a single bounding box.
        ///https://reference.wolfram.com/language/ref/FindImageText.html
        ///</summary>
        public static Engine FindImageText(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindImageText[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of bounding boxes at the specified structural level.
        ///https://reference.wolfram.com/language/ref/FindImageText.html
        ///</summary>
        public static Engine FindImageText(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindImageText[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns prop for text at the given level.
        ///https://reference.wolfram.com/language/ref/FindImageText.html
        ///</summary>
        public static Engine FindImageText(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindImageText[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds an independent edge set of the graph g with a maximum number of edges.
        ///https://reference.wolfram.com/language/ref/FindIndependentEdgeSet.html
        ///</summary>
        public static Engine FindIndependentEdgeSet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindIndependentEdgeSet[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindIndependentEdgeSet.html
        ///</summary>
        public static Engine FindIndependentEdgeSet(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindIndependentEdgeSet[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds an independent vertex set of the graph g with a maximum number of vertices.
        ///https://reference.wolfram.com/language/ref/FindIndependentVertexSet.html
        ///</summary>
        public static Engine FindIndependentVertexSet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindIndependentVertexSet[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds an independent vertex set with at most n vertices.
        ///https://reference.wolfram.com/language/ref/FindIndependentVertexSet.html
        ///</summary>
        public static Engine FindIndependentVertexSet(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindIndependentVertexSet[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds an independent vertex set with exactly n vertices.
        ///https://reference.wolfram.com/language/ref/FindIndependentVertexSet.html
        ///</summary>
        public static Engine FindIndependentVertexSet(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindIndependentVertexSet[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds at most s independent vertex sets.
        ///https://reference.wolfram.com/language/ref/FindIndependentVertexSet.html
        ///</summary>
        public static Engine FindIndependentVertexSet(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindIndependentVertexSet[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds independent sets that include the vertex v only.
        ///https://reference.wolfram.com/language/ref/FindIndependentVertexSet.html
        ///</summary>
        public static Engine FindIndependentVertexSet(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindIndependentVertexSet[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds an instance of vars that makes the statement expr be True.
        ///https://reference.wolfram.com/language/ref/FindInstance.html
        ///</summary>
        public static Engine FindInstance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindInstance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds an instance over the domain dom. Common choices of dom are Complexes, Reals, Integers, and Booleans.
        ///https://reference.wolfram.com/language/ref/FindInstance.html
        ///</summary>
        public static Engine FindInstance(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindInstance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds n instances.
        ///https://reference.wolfram.com/language/ref/FindInstance.html
        ///</summary>
        public static Engine FindInstance(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindInstance[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds a list of integers  such that .
        ///https://reference.wolfram.com/language/ref/FindIntegerNullVector.html
        ///</summary>
        public static Engine FindIntegerNullVector(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindIntegerNullVector[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds a list of integers  with  such that .
        ///https://reference.wolfram.com/language/ref/FindIntegerNullVector.html
        ///</summary>
        public static Engine FindIntegerNullVector(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindIntegerNullVector[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of molecules with the same chemical formula as chem.
        ///https://reference.wolfram.com/language/ref/FindIsomers.html
        ///</summary>
        public static Engine FindIsomers(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindIsomers[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds isomers of chem and returns them in the given form.
        ///https://reference.wolfram.com/language/ref/FindIsomers.html
        ///</summary>
        public static Engine FindIsomers(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindIsomers[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a subgraph of g1 that is isomorphic to g2.
        ///https://reference.wolfram.com/language/ref/FindIsomorphicSubgraph.html
        ///</summary>
        public static Engine FindIsomorphicSubgraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindIsomorphicSubgraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds at most n subgraphs.
        ///https://reference.wolfram.com/language/ref/FindIsomorphicSubgraph.html
        ///</summary>
        public static Engine FindIsomorphicSubgraph(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindIsomorphicSubgraph[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a largest k-clan in the graph g.
        ///https://reference.wolfram.com/language/ref/FindKClan.html
        ///</summary>
        public static Engine FindKClan(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindKClan[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a k-clan containing at most n vertices.
        ///https://reference.wolfram.com/language/ref/FindKClan.html
        ///</summary>
        public static Engine FindKClan(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindKClan[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a k-clan containing exactly n vertices.
        ///https://reference.wolfram.com/language/ref/FindKClan.html
        ///</summary>
        public static Engine FindKClan(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindKClan[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///finds at most s k-clans.
        ///https://reference.wolfram.com/language/ref/FindKClan.html
        ///</summary>
        public static Engine FindKClan(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindKClan[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds k-clans that include the vertex v only.
        ///https://reference.wolfram.com/language/ref/FindKClan.html
        ///</summary>
        public static Engine FindKClan(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindKClan[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindKClan.html
        ///</summary>
        public static Engine FindKClan(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindKClan[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a largest k-clique in the graph g.
        ///https://reference.wolfram.com/language/ref/FindKClique.html
        ///</summary>
        public static Engine FindKClique(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindKClique[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a k-clique containing at most n vertices.
        ///https://reference.wolfram.com/language/ref/FindKClique.html
        ///</summary>
        public static Engine FindKClique(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindKClique[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a k-clique containing exactly n vertices.
        ///https://reference.wolfram.com/language/ref/FindKClique.html
        ///</summary>
        public static Engine FindKClique(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindKClique[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///finds at most s k-cliques.
        ///https://reference.wolfram.com/language/ref/FindKClique.html
        ///</summary>
        public static Engine FindKClique(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindKClique[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds k-cliques that include the vertex v only.
        ///https://reference.wolfram.com/language/ref/FindKClique.html
        ///</summary>
        public static Engine FindKClique(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindKClique[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindKClique.html
        ///</summary>
        public static Engine FindKClique(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindKClique[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a largest k-club in the graph g.
        ///https://reference.wolfram.com/language/ref/FindKClub.html
        ///</summary>
        public static Engine FindKClub(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindKClub[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a largest k-plex in the graph g.
        ///https://reference.wolfram.com/language/ref/FindKPlex.html
        ///</summary>
        public static Engine FindKPlex(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindKPlex[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a k-plex containing at most n vertices.
        ///https://reference.wolfram.com/language/ref/FindKPlex.html
        ///</summary>
        public static Engine FindKPlex(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindKPlex[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a k-plex containing exactly n vertices.
        ///https://reference.wolfram.com/language/ref/FindKPlex.html
        ///</summary>
        public static Engine FindKPlex(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindKPlex[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///finds at most s k-plexes.
        ///https://reference.wolfram.com/language/ref/FindKPlex.html
        ///</summary>
        public static Engine FindKPlex(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindKPlex[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds k-plexes that include the vertex v only.
        ///https://reference.wolfram.com/language/ref/FindKPlex.html
        ///</summary>
        public static Engine FindKPlex(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindKPlex[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindKPlex.html
        ///</summary>
        public static Engine FindKPlex(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindKPlex[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a dynamic library that can be loaded by LibraryFunctionLoad.
        ///https://reference.wolfram.com/language/ref/FindLibrary.html
        ///</summary>
        public static Engine FindLibrary(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindLibrary[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds if possible the minimal linear recurrence that generates list.
        ///https://reference.wolfram.com/language/ref/FindLinearRecurrence.html
        ///</summary>
        public static Engine FindLinearRecurrence(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindLinearRecurrence[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds if possible the linear recurrence of maximum order d that generates list.
        ///https://reference.wolfram.com/language/ref/FindLinearRecurrence.html
        ///</summary>
        public static Engine FindLinearRecurrence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindLinearRecurrence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of lines in the file that contain the specified string.
        ///https://reference.wolfram.com/language/ref/FindList.html
        ///</summary>
        public static Engine FindList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of all lines that contain any of the specified strings.
        ///https://reference.wolfram.com/language/ref/FindList.html
        ///</summary>
        public static Engine FindList(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of lines containing the specified strings in any of the filei.
        ///https://reference.wolfram.com/language/ref/FindList.html
        ///</summary>
        public static Engine FindList(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindList[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///includes only the first n lines found.
        ///https://reference.wolfram.com/language/ref/FindList.html
        ///</summary>
        public static Engine FindList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a color similar to the color that is present in image.
        ///https://reference.wolfram.com/language/ref/FindMatchingColor.html
        ///</summary>
        public static Engine FindMatchingColor(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMatchingColor[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of colors matching each colori.
        ///https://reference.wolfram.com/language/ref/FindMatchingColor.html
        ///</summary>
        public static Engine FindMatchingColor(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMatchingColor[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns lists of matching colors for all imagei.
        ///https://reference.wolfram.com/language/ref/FindMatchingColor.html
        ///</summary>
        public static Engine FindMatchingColor(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMatchingColor[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///searches for a local maximum in f, starting from an automatically selected point.
        ///https://reference.wolfram.com/language/ref/FindMaximum.html
        ///</summary>
        public static Engine FindMaximum(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMaximum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///searches for a local maximum in f, starting from the point x=x0.
        ///https://reference.wolfram.com/language/ref/FindMaximum.html
        ///</summary>
        public static Engine FindMaximum(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMaximum[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///searches for a local maximum in a function of several variables.
        ///https://reference.wolfram.com/language/ref/FindMaximum.html
        ///</summary>
        public static Engine FindMaximum(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMaximum[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///searches for a local maximum subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/FindMaximum.html
        ///</summary>
        public static Engine FindMaximum(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMaximum[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///starts from a point within the region defined by the constraints.
        ///https://reference.wolfram.com/language/ref/FindMaximum.html
        ///</summary>
        public static Engine FindMaximum(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMaximum[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the maximum cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindMaximumCut.html
        ///</summary>
        public static Engine FindMaximumCut(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindMaximumCut[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the maximum flow between source vertex s and target vertex t in a graph g.
        ///https://reference.wolfram.com/language/ref/FindMaximumFlow.html
        ///</summary>
        public static Engine FindMaximumFlow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindMaximumFlow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the maximum flow between multi-sources s1, … and multi-targets t1, ….
        ///https://reference.wolfram.com/language/ref/FindMaximumFlow.html
        ///</summary>
        public static Engine FindMaximumFlow(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMaximumFlow[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/FindMaximumFlow.html
        ///</summary>
        public static Engine FindMaximumFlow(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindMaximumFlow[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindMaximumFlow.html
        ///</summary>
        public static Engine FindMaximumFlow(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMaximumFlow[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value at a local maximum of f.
        ///https://reference.wolfram.com/language/ref/FindMaxValue.html
        ///</summary>
        public static Engine FindMaxValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMaxValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value at a local maximum of f, found by a search starting from the point x=x0.
        ///https://reference.wolfram.com/language/ref/FindMaxValue.html
        ///</summary>
        public static Engine FindMaxValue(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMaxValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value at a local maximum of a function of several variables.
        ///https://reference.wolfram.com/language/ref/FindMaxValue.html
        ///</summary>
        public static Engine FindMaxValue(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMaxValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value at a local maximum subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/FindMaxValue.html
        ///</summary>
        public static Engine FindMaxValue(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMaxValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///starts from a point within the region defined by the constraints.
        ///https://reference.wolfram.com/language/ref/FindMaxValue.html
        ///</summary>
        public static Engine FindMaxValue(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMaxValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds defects in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/FindMeshDefects.html
        ///</summary>
        public static Engine FindMeshDefects(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindMeshDefects[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds only the specified type of defects def1, ….
        ///https://reference.wolfram.com/language/ref/FindMeshDefects.html
        ///</summary>
        public static Engine FindMeshDefects(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMeshDefects[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///formats the results according to format specification.
        ///https://reference.wolfram.com/language/ref/FindMeshDefects.html
        ///</summary>
        public static Engine FindMeshDefects(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindMeshDefects[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///searches for a local minimum in f, starting from an automatically selected point.
        ///https://reference.wolfram.com/language/ref/FindMinimum.html
        ///</summary>
        public static Engine FindMinimum(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMinimum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///searches for a local minimum in f, starting from the point x=x0.
        ///https://reference.wolfram.com/language/ref/FindMinimum.html
        ///</summary>
        public static Engine FindMinimum(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMinimum[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///searches for a local minimum in a function of several variables.
        ///https://reference.wolfram.com/language/ref/FindMinimum.html
        ///</summary>
        public static Engine FindMinimum(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMinimum[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///searches for a local minimum subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/FindMinimum.html
        ///</summary>
        public static Engine FindMinimum(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMinimum[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///starts from a point within the region defined by the constraints.
        ///https://reference.wolfram.com/language/ref/FindMinimum.html
        ///</summary>
        public static Engine FindMinimum(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMinimum[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds the minimum cost flow in the graph g with sd1, sd2, … vertex supplies or demands.
        ///https://reference.wolfram.com/language/ref/FindMinimumCostFlow.html
        ///</summary>
        public static Engine FindMinimumCostFlow(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMinimumCostFlow[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds the minimum cost maximum flow between source vertex s and target vertex t in a graph g.
        ///https://reference.wolfram.com/language/ref/FindMinimumCostFlow.html
        ///</summary>
        public static Engine FindMinimumCostFlow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindMinimumCostFlow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the minimum cost flow between source s and target t, with the required flow d.
        ///https://reference.wolfram.com/language/ref/FindMinimumCostFlow.html
        ///</summary>
        public static Engine FindMinimumCostFlow(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindMinimumCostFlow[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds the minimum cost flow in a graph with cost matrix m.
        ///https://reference.wolfram.com/language/ref/FindMinimumCostFlow.html
        ///</summary>
        public static Engine FindMinimumCostFlow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMinimumCostFlow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindMinimumCostFlow.html
        ///</summary>
        public static Engine FindMinimumCostFlow(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMinimumCostFlow[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the minimum cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindMinimumCut.html
        ///</summary>
        public static Engine FindMinimumCut(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindMinimumCut[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindMinimumCut.html
        ///</summary>
        public static Engine FindMinimumCut(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindMinimumCut[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value at a local minimum of f.
        ///https://reference.wolfram.com/language/ref/FindMinValue.html
        ///</summary>
        public static Engine FindMinValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMinValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value at a local minimum of f, found by a search starting from the point x=x0.
        ///https://reference.wolfram.com/language/ref/FindMinValue.html
        ///</summary>
        public static Engine FindMinValue(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMinValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value at a local minimum of a function of several variables.
        ///https://reference.wolfram.com/language/ref/FindMinValue.html
        ///</summary>
        public static Engine FindMinValue(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMinValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value at a local minimum subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/FindMinValue.html
        ///</summary>
        public static Engine FindMinValue(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindMinValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///starts from a point within the region defined by the constraints.
        ///https://reference.wolfram.com/language/ref/FindMinValue.html
        ///</summary>
        public static Engine FindMinValue(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindMinValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds a mapping between the atom indices in mol and an occurrence of patt in mol.
        ///https://reference.wolfram.com/language/ref/FindMoleculeSubstructure.html
        ///</summary>
        public static Engine FindMoleculeSubstructure(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindMoleculeSubstructure[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds all occurrences of patt in mol and returns all mappings.
        ///https://reference.wolfram.com/language/ref/FindMoleculeSubstructure.html
        ///</summary>
        public static Engine FindMoleculeSubstructure(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindMoleculeSubstructure[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a path between vertex s and vertex t in the graph g.
        ///https://reference.wolfram.com/language/ref/FindPath.html
        ///</summary>
        public static Engine FindPath(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindPath[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds a path of length at most k between vertex s and vertex t in the graph g.
        ///https://reference.wolfram.com/language/ref/FindPath.html
        ///</summary>
        public static Engine FindPath(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindPath[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds a path of length exactly k.
        ///https://reference.wolfram.com/language/ref/FindPath.html
        ///</summary>
        public static Engine FindPath(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("FindPath[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///finds at most n paths.
        ///https://reference.wolfram.com/language/ref/FindPath.html
        ///</summary>
        public static Engine FindPath(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("FindPath[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindPath.html
        ///</summary>
        public static Engine FindPath(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindPath[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives positions and values of the detected peaks in list.
        ///https://reference.wolfram.com/language/ref/FindPeaks.html
        ///</summary>
        public static Engine FindPeaks(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindPeaks[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds peaks that survive Gaussian blurring up to scale σ.
        ///https://reference.wolfram.com/language/ref/FindPeaks.html
        ///</summary>
        public static Engine FindPeaks(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindPeaks[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds peaks with minimum sharpness s.
        ///https://reference.wolfram.com/language/ref/FindPeaks.html
        ///</summary>
        public static Engine FindPeaks(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindPeaks[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds only peaks with values greater than t.
        ///https://reference.wolfram.com/language/ref/FindPeaks.html
        ///</summary>
        public static Engine FindPeaks(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindPeaks[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///uses different scales for thresholding sharpness and value.
        ///https://reference.wolfram.com/language/ref/FindPeaks.html
        ///</summary>
        public static Engine FindPeaks(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("FindPeaks[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives a permutation that produces expr by permuting Sort[expr].
        ///https://reference.wolfram.com/language/ref/FindPermutation.html
        ///</summary>
        public static Engine FindPermutation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindPermutation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a permutation that converts expr1 to expr2 for two expressions that differ only in the order of their arguments.
        ///https://reference.wolfram.com/language/ref/FindPermutation.html
        ///</summary>
        public static Engine FindPermutation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindPermutation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a coloring with minimal size for the faces of the planar graph g.
        ///https://reference.wolfram.com/language/ref/FindPlanarColoring.html
        ///</summary>
        public static Engine FindPlanarColoring(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindPlanarColoring[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a coloring {c1,c2,…,ck} for the faces in the graph g.
        ///https://reference.wolfram.com/language/ref/FindPlanarColoring.html
        ///</summary>
        public static Engine FindPlanarColoring(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindPlanarColoring[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///estimates the parameters of the point process pproc from point data pdata.
        ///https://reference.wolfram.com/language/ref/FindPointProcessParameters.html
        ///</summary>
        public static Engine FindPointProcessParameters(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindPointProcessParameters[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///estimates the parameters p, q, … with starting values p0, q0, ….
        ///https://reference.wolfram.com/language/ref/FindPointProcessParameters.html
        ///</summary>
        public static Engine FindPointProcessParameters(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("FindPointProcessParameters[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///finds a Chinese postman tour in the graph g of minimal length.
        ///https://reference.wolfram.com/language/ref/FindPostmanTour.html
        ///</summary>
        public static Engine FindPostmanTour(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindPostmanTour[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds at most k Chinese postman tours.
        ///https://reference.wolfram.com/language/ref/FindPostmanTour.html
        ///</summary>
        public static Engine FindPostmanTour(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindPostmanTour[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindPostmanTour.html
        ///</summary>
        public static Engine FindPostmanTour(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindPostmanTour[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the parameter estimates for the process proc from data.
        ///https://reference.wolfram.com/language/ref/FindProcessParameters.html
        ///</summary>
        public static Engine FindProcessParameters(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindProcessParameters[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the parameters p, q, … with starting values p0, q0, … .
        ///https://reference.wolfram.com/language/ref/FindProcessParameters.html
        ///</summary>
        public static Engine FindProcessParameters(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("FindProcessParameters[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives the transformation function that maps the region reg1 to the region reg2.
        ///https://reference.wolfram.com/language/ref/FindRegionTransform.html
        ///</summary>
        public static Engine FindRegionTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindRegionTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the minimal sublist or subarray that repeats to give list.
        ///https://reference.wolfram.com/language/ref/FindRepeat.html
        ///</summary>
        public static Engine FindRepeat(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindRepeat[" + arg0 + "]", name);
        }

        ///<summary>
        ///requires that the sublist be repeated at least n times in list.
        ///https://reference.wolfram.com/language/ref/FindRepeat.html
        ///</summary>
        public static Engine FindRepeat(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindRepeat[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///requires ni to repeat at level i in list.
        ///https://reference.wolfram.com/language/ref/FindRepeat.html
        ///</summary>
        public static Engine FindRepeat(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindRepeat[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///searches for a numerical root of f, starting from the point x=x0.
        ///https://reference.wolfram.com/language/ref/FindRoot.html
        ///</summary>
        public static Engine FindRoot(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindRoot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///searches for a simultaneous numerical root of all the fi.
        ///https://reference.wolfram.com/language/ref/FindRoot.html
        ///</summary>
        public static Engine FindRoot(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FindRoot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///attempts to find a simple function that yields the sequence an when given successive integer arguments.
        ///https://reference.wolfram.com/language/ref/FindSequenceFunction.html
        ///</summary>
        public static Engine FindSequenceFunction(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindSequenceFunction[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///attempts to find a simple function that yields ai when given argument ni.
        ///https://reference.wolfram.com/language/ref/FindSequenceFunction.html
        ///</summary>
        public static Engine FindSequenceFunction(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindSequenceFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a function that yields ai when given argument ni.
        ///https://reference.wolfram.com/language/ref/FindSequenceFunction.html
        ///</summary>
        public static Engine FindSequenceFunction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindSequenceFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the function applied to n.
        ///https://reference.wolfram.com/language/ref/FindSequenceFunction.html
        ///</summary>
        public static Engine FindSequenceFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindSequenceFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the shortest path from source vertex s to target vertex t in the graph g.
        ///https://reference.wolfram.com/language/ref/FindShortestPath.html
        ///</summary>
        public static Engine FindShortestPath(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindShortestPath[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindShortestPath.html
        ///</summary>
        public static Engine FindShortestPath(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindShortestPath[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///attempts to find an ordering of the vi that minimizes the total distance on a tour that visits all the vi once.
        ///https://reference.wolfram.com/language/ref/FindShortestTour.html
        ///</summary>
        public static Engine FindShortestTour(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindShortestTour[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///attempts to find an ordering of the vertices in graph that minimizes the total length when visiting each vertex once.
        ///https://reference.wolfram.com/language/ref/FindShortestTour.html
        ///</summary>
        public static Engine FindShortestTour(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindShortestTour[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds an ordering of the vi that minimizes the total distance on a path from vj to vk.
        ///https://reference.wolfram.com/language/ref/FindShortestTour.html
        ///</summary>
        public static Engine FindShortestTour(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindShortestTour[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds an ordering of the vertices that minimizes the total length on a path from s to t.
        ///https://reference.wolfram.com/language/ref/FindShortestTour.html
        ///</summary>
        public static Engine FindShortestTour(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindShortestTour[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindShortestTour.html
        ///</summary>
        public static Engine FindShortestTour(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindShortestTour[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a spanning tree that minimizes the total distance between the vi.
        ///https://reference.wolfram.com/language/ref/FindSpanningTree.html
        ///</summary>
        public static Engine FindSpanningTree(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindSpanningTree[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds a spanning tree of the graph g that minimizes the total distances between vertices.
        ///https://reference.wolfram.com/language/ref/FindSpanningTree.html
        ///</summary>
        public static Engine FindSpanningTree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindSpanningTree[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a spanning tree of the connected component of g that includes the vertex v.
        ///https://reference.wolfram.com/language/ref/FindSpanningTree.html
        ///</summary>
        public static Engine FindSpanningTree(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindSpanningTree[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a subgraph isomorphism that maps the graph g1 to a subgraph of g2 by renaming vertices.
        ///https://reference.wolfram.com/language/ref/FindSubgraphIsomorphism.html
        ///</summary>
        public static Engine FindSubgraphIsomorphism(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindSubgraphIsomorphism[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds at most n subgraph isomorphisms.
        ///https://reference.wolfram.com/language/ref/FindSubgraphIsomorphism.html
        ///</summary>
        public static Engine FindSubgraphIsomorphism(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindSubgraphIsomorphism[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///searches for an equilibrium to the model model.
        ///https://reference.wolfram.com/language/ref/FindSystemModelEquilibrium.html
        ///</summary>
        public static Engine FindSystemModelEquilibrium(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindSystemModelEquilibrium[" + arg0 + "]", name);
        }

        ///<summary>
        ///searches for an equilibrium, starting from the points xi=xi0, ui=ui0 and yi=yi0.
        ///https://reference.wolfram.com/language/ref/FindSystemModelEquilibrium.html
        ///</summary>
        public static Engine FindSystemModelEquilibrium(this Engine en, object arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("FindSystemModelEquilibrium[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///searches for an equilibrium, with variable xi constrained to have the value vi etc.
        ///https://reference.wolfram.com/language/ref/FindSystemModelEquilibrium.html
        ///</summary>
        public static Engine FindSystemModelEquilibrium(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FindSystemModelEquilibrium[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the substring of text that best appears to answer question.
        ///https://reference.wolfram.com/language/ref/FindTextualAnswer.html
        ///</summary>
        public static Engine FindTextualAnswer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindTextualAnswer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of up to n answers that appear most probable.
        ///https://reference.wolfram.com/language/ref/FindTextualAnswer.html
        ///</summary>
        public static Engine FindTextualAnswer(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindTextualAnswer[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the specified property for each answer.
        ///https://reference.wolfram.com/language/ref/FindTextualAnswer.html
        ///</summary>
        public static Engine FindTextualAnswer(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindTextualAnswer[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds a global threshold value that partitions the intensity values in image into two intervals.
        ///https://reference.wolfram.com/language/ref/FindThreshold.html
        ///</summary>
        public static Engine FindThreshold(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindThreshold[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a pair of lists {transient,repeat} where the elements of repeat occur successively at least n times after the elements of the transient part of list.
        ///https://reference.wolfram.com/language/ref/FindTransientRepeat.html
        ///</summary>
        public static Engine FindTransientRepeat(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FindTransientRepeat[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a coloring with minimal size for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexColoring.html
        ///</summary>
        public static Engine FindVertexColoring(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindVertexColoring[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a coloring {c1,c2,…,ck} for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexColoring.html
        ///</summary>
        public static Engine FindVertexColoring(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FindVertexColoring[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds a vertex cover of the graph g with a minimum number of vertices.
        ///https://reference.wolfram.com/language/ref/FindVertexCover.html
        ///</summary>
        public static Engine FindVertexCover(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindVertexCover[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexCover.html
        ///</summary>
        public static Engine FindVertexCover(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FindVertexCover[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///finds a smallest vertex cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexCut.html
        ///</summary>
        public static Engine FindVertexCut(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FindVertexCut[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds a smallest s-t vertex cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexCut.html
        ///</summary>
        public static Engine FindVertexCut(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FindVertexCut[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexCut.html
        ///</summary>
        public static Engine FindVertexCut(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindVertexCut[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds at most k vertex-independent paths from vertex s to vertex t in the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexIndependentPaths.html
        ///</summary>
        public static Engine FindVertexIndependentPaths(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FindVertexIndependentPaths[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexIndependentPaths.html
        ///</summary>
        public static Engine FindVertexIndependentPaths(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FindVertexIndependentPaths[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finishes updating and displaying all currently visible Dynamic objects.
        ///https://reference.wolfram.com/language/ref/FinishDynamic.html
        ///</summary>
        public static Engine FinishDynamic(this Engine en, string? name = null)
        {
            return en.Execute("FinishDynamic[]", name);
        }

        ///<summary>
        ///gives the number of finite Abelian groups of order n.
        ///https://reference.wolfram.com/language/ref/FiniteAbelianGroupCount.html
        ///</summary>
        public static Engine FiniteAbelianGroupCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FiniteAbelianGroupCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of finite groups of order n.
        ///https://reference.wolfram.com/language/ref/FiniteGroupCount.html
        ///</summary>
        public static Engine FiniteGroupCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FiniteGroupCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the finite group specified by name.
        ///https://reference.wolfram.com/language/ref/FiniteGroupData.html
        ///</summary>
        public static Engine FiniteGroupData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FiniteGroupData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of finite groups in the specified class.
        ///https://reference.wolfram.com/language/ref/FiniteGroupData.html
        ///</summary>
        public static Engine FiniteGroupData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FiniteGroupData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the first element in expr.
        ///https://reference.wolfram.com/language/ref/First.html
        ///</summary>
        public static Engine First(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("First[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the first element if it exists, or def otherwise.
        ///https://reference.wolfram.com/language/ref/First.html
        ///</summary>
        public static Engine First(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("First[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the first ei to match pattern, or Missing["NotFound"] if none matching pattern is found.
        ///https://reference.wolfram.com/language/ref/FirstCase.html
        ///</summary>
        public static Engine FirstCase(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FirstCase[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives default if no element matching pattern is found.
        ///https://reference.wolfram.com/language/ref/FirstCase.html
        ///</summary>
        public static Engine FirstCase(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FirstCase[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds only objects that appear on levels specified by levelspec.
        ///https://reference.wolfram.com/language/ref/FirstCase.html
        ///</summary>
        public static Engine FirstCase(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FirstCase[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of FirstCase that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/FirstCase.html
        ///</summary>
        public static Engine FirstCase(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FirstCase[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the distribution of times for the Markov process mproc to pass from the initial state to final states f for the first time.
        ///https://reference.wolfram.com/language/ref/FirstPassageTimeDistribution.html
        ///</summary>
        public static Engine FirstPassageTimeDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FirstPassageTimeDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the position of the first element in expr that matches pattern, or Missing["NotFound"] if no such element is found.
        ///https://reference.wolfram.com/language/ref/FirstPosition.html
        ///</summary>
        public static Engine FirstPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FirstPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives default if no element matching pattern is found.
        ///https://reference.wolfram.com/language/ref/FirstPosition.html
        ///</summary>
        public static Engine FirstPosition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FirstPosition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds only objects that appear on levels specified by levelspec.
        ///https://reference.wolfram.com/language/ref/FirstPosition.html
        ///</summary>
        public static Engine FirstPosition(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FirstPosition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of FirstPosition that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/FirstPosition.html
        ///</summary>
        public static Engine FirstPosition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FirstPosition[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the sporadic simple Fischer group .
        ///https://reference.wolfram.com/language/ref/FischerGroupFi22.html
        ///</summary>
        public static Engine FischerGroupFi22(this Engine en, string? name = null)
        {
            return en.Execute("FischerGroupFi22[]", name);
        }

        ///<summary>
        ///represents the sporadic simple Fischer group .
        ///https://reference.wolfram.com/language/ref/FischerGroupFi23.html
        ///</summary>
        public static Engine FischerGroupFi23(this Engine en, string? name = null)
        {
            return en.Execute("FischerGroupFi23[]", name);
        }

        ///<summary>
        ///represents the sporadic simple Fischer group .
        ///https://reference.wolfram.com/language/ref/FischerGroupFi24Prime.html
        ///</summary>
        public static Engine FischerGroupFi24Prime(this Engine en, string? name = null)
        {
            return en.Execute("FischerGroupFi24Prime[]", name);
        }

        ///<summary>
        ///represents a Fisher noncentral hypergeometric distribution.
        ///https://reference.wolfram.com/language/ref/FisherHypergeometricDistribution.html
        ///</summary>
        public static Engine FisherHypergeometricDistribution(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FisherHypergeometricDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///tests whether the variance of data is 1.
        ///https://reference.wolfram.com/language/ref/FisherRatioTest.html
        ///</summary>
        public static Engine FisherRatioTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FisherRatioTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the variances of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/FisherRatioTest.html
        ///</summary>
        public static Engine FisherRatioTest(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FisherRatioTest[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/FisherRatioTest.html
        ///</summary>
        public static Engine FisherRatioTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FisherRatioTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Fisher  distribution with n numerator and m denominator degrees of freedom.
        ///https://reference.wolfram.com/language/ref/FisherZDistribution.html
        ///</summary>
        public static Engine FisherZDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FisherZDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds a fit a1 f1+…+an fn to a list of data for functions f1,…,fn of variables {x,y,…}.
        ///https://reference.wolfram.com/language/ref/Fit.html
        ///</summary>
        public static Engine Fit(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Fit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///finds a fit vector a that minimizes  for a design matrix m.
        ///https://reference.wolfram.com/language/ref/Fit.html
        ///</summary>
        public static Engine Fit(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Fit[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///specifies what fit property prop should be returned.
        ///https://reference.wolfram.com/language/ref/Fit.html
        ///</summary>
        public static Engine Fit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Fit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the symbolic fitted model obtained from functions like LinearModelFit.
        ///https://reference.wolfram.com/language/ref/FittedModel.html
        ///</summary>
        public static Engine FittedModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FittedModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a grammar rules pattern object that represents a sequence of elements matching p1, p2, …, in the fixed order given.
        ///https://reference.wolfram.com/language/ref/FixedOrder.html
        ///</summary>
        public static Engine FixedOrder(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FixedOrder[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///starts with expr, then applies f repeatedly until the result no longer changes.
        ///https://reference.wolfram.com/language/ref/FixedPoint.html
        ///</summary>
        public static Engine FixedPoint(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FixedPoint[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list giving the results of applying f repeatedly, starting with expr, until the results no longer change.
        ///https://reference.wolfram.com/language/ref/FixedPointList.html
        ///</summary>
        public static Engine FixedPointList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FixedPointList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive that specifies that faces of polygons and other filled graphics objects are to be drawn to reflect as a flat surface.
        ///https://reference.wolfram.com/language/ref/FlatShading.html
        ///</summary>
        public static Engine FlatShading(this Engine en, string? name = null)
        {
            return en.Execute("FlatShading[]", name);
        }

        ///<summary>
        ///uses the attenuation factor d for the diffuse light.
        ///https://reference.wolfram.com/language/ref/FlatShading.html
        ///</summary>
        public static Engine FlatShading(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FlatShading[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the attenuation factor a for the ambient light.
        ///https://reference.wolfram.com/language/ref/FlatShading.html
        ///</summary>
        public static Engine FlatShading(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FlatShading[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///flattens out nested lists.
        ///https://reference.wolfram.com/language/ref/Flatten.html
        ///</summary>
        public static Engine Flatten(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Flatten[" + arg0 + "]", name);
        }

        ///<summary>
        ///flattens to level n.
        ///https://reference.wolfram.com/language/ref/Flatten.html
        ///</summary>
        public static Engine Flatten(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Flatten[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///flattens subexpressions with head h.
        ///https://reference.wolfram.com/language/ref/Flatten.html
        ///</summary>
        public static Engine Flatten(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Flatten[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///flattens list by combining all levels sij to make each level i in the result.
        ///https://reference.wolfram.com/language/ref/Flatten.html
        ///</summary>
        public static Engine Flatten(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Flatten[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///flattens out a sublist that appears as the n th element of list. If n is negative, the position is counted from the end.
        ///https://reference.wolfram.com/language/ref/FlattenAt.html
        ///</summary>
        public static Engine FlattenAt(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FlattenAt[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///flattens out the part of expr at position {i,j,…}.
        ///https://reference.wolfram.com/language/ref/FlattenAt.html
        ///</summary>
        public static Engine FlattenAt(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FlattenAt[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///flattens out parts of expr at several positions.
        ///https://reference.wolfram.com/language/ref/FlattenAt.html
        ///</summary>
        public static Engine FlattenAt(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FlattenAt[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of FlattenAt that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/FlattenAt.html
        ///</summary>
        public static Engine FlattenAt(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FlattenAt[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that flattens any input array into a vector.
        ///https://reference.wolfram.com/language/ref/FlattenLayer.html
        ///</summary>
        public static Engine FlattenLayer(this Engine en, string? name = null)
        {
            return en.Execute("FlattenLayer[]", name);
        }

        ///<summary>
        ///represents a net layer that flattens its input to level n.
        ///https://reference.wolfram.com/language/ref/FlattenLayer.html
        ///</summary>
        public static Engine FlattenLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FlattenLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that flattens its input by combining all levels sij to make each level i in the result.
        ///https://reference.wolfram.com/language/ref/FlattenLayer.html
        ///</summary>
        public static Engine FlattenLayer(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FlattenLayer[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an exact flat top window function of x.
        ///https://reference.wolfram.com/language/ref/FlatTopWindow.html
        ///</summary>
        public static Engine FlatTopWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FlatTopWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a subset of properties for a flight or selection of flights with specifications spec.
        ///https://reference.wolfram.com/language/ref/FlightData.html
        ///</summary>
        public static Engine FlightData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FlightData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of the property prop for specifications spec.
        ///https://reference.wolfram.com/language/ref/FlightData.html
        ///</summary>
        public static Engine FlightData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FlightData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the value of the property prop for a specific time or time range datespec.
        ///https://reference.wolfram.com/language/ref/FlightData.html
        ///</summary>
        public static Engine FlightData(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FlightData[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an object which flips between displaying expr1 and expr2 each time it is clicked.
        ///https://reference.wolfram.com/language/ref/FlipView.html
        ///</summary>
        public static Engine FlipView(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FlipView[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///makes expri be the object currently displayed.
        ///https://reference.wolfram.com/language/ref/FlipView.html
        ///</summary>
        public static Engine FlipView(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FlipView[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the greatest integer less than or equal to x.
        ///https://reference.wolfram.com/language/ref/Floor.html
        ///</summary>
        public static Engine Floor(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Floor[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the greatest multiple of a less than or equal to x.
        ///https://reference.wolfram.com/language/ref/Floor.html
        ///</summary>
        public static Engine Floor(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Floor[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the flow polynomial of the graph g.
        ///https://reference.wolfram.com/language/ref/FlowPolynomial.html
        ///</summary>
        public static Engine FlowPolynomial(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FlowPolynomial[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/FlowPolynomial.html
        ///</summary>
        public static Engine FlowPolynomial(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FlowPolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the last element of FoldList[f,x,list].
        ///https://reference.wolfram.com/language/ref/Fold.html
        ///</summary>
        public static Engine Fold(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Fold[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is equivalent to Fold[f,First[list],Rest[list]].
        ///https://reference.wolfram.com/language/ref/Fold.html
        ///</summary>
        public static Engine Fold(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Fold[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of Fold that can be applied to expressions.
        ///https://reference.wolfram.com/language/ref/Fold.html
        ///</summary>
        public static Engine Fold(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Fold[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives {x,f[x,a],f[f[x,a],b],…}.
        ///https://reference.wolfram.com/language/ref/FoldList.html
        ///</summary>
        public static Engine FoldList(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FoldList[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives {a,f[a,b],f[f[a,b],c],…}.
        ///https://reference.wolfram.com/language/ref/FoldList.html
        ///</summary>
        public static Engine FoldList(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FoldList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of FoldList that can be applied to expressions.
        ///https://reference.wolfram.com/language/ref/FoldList.html
        ///</summary>
        public static Engine FoldList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FoldList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the last element of FoldPairList[f,y0,list].
        ///https://reference.wolfram.com/language/ref/FoldPair.html
        ///</summary>
        public static Engine FoldPair(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FoldPair[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the last element of FoldPairList[f,y0,list,g].
        ///https://reference.wolfram.com/language/ref/FoldPair.html
        ///</summary>
        public static Engine FoldPair(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FoldPair[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///is equivalent to FoldPair[f,a0,{a1,a2,…}].
        ///https://reference.wolfram.com/language/ref/FoldPair.html
        ///</summary>
        public static Engine FoldPair(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FoldPair[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the list of successive xi obtained by applying f to pairs of the form {yi-1,ai}, where at each step f returns {xi,yi}.
        ///https://reference.wolfram.com/language/ref/FoldPairList.html
        ///</summary>
        public static Engine FoldPairList(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FoldPairList[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the list of successive values of g[{xi,yi}].
        ///https://reference.wolfram.com/language/ref/FoldPairList.html
        ///</summary>
        public static Engine FoldPairList(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FoldPairList[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///is equivalent to FoldPairList[f,a0,{a1,a2,…}].
        ///https://reference.wolfram.com/language/ref/FoldPairList.html
        ///</summary>
        public static Engine FoldPairList(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FoldPairList[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the first expression f[… f[f[x,a1],a2]…,ak] to which applying test does not yield True.
        ///https://reference.wolfram.com/language/ref/FoldWhile.html
        ///</summary>
        public static Engine FoldWhile(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("FoldWhile[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///is equivalent to FoldWhile[f,First[list],Rest[list],test].
        ///https://reference.wolfram.com/language/ref/FoldWhile.html
        ///</summary>
        public static Engine FoldWhile(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FoldWhile[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///supplies the most recent m results as arguments for test at each step.
        ///https://reference.wolfram.com/language/ref/FoldWhile.html
        ///</summary>
        public static Engine FoldWhile(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("FoldWhile[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///returns the result after applying f an extra n times after test fails.
        ///https://reference.wolfram.com/language/ref/FoldWhile.html
        ///</summary>
        public static Engine FoldWhile(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("FoldWhile[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///represents an operator form of FoldWhile that can be applied to expressions.
        ///https://reference.wolfram.com/language/ref/FoldWhile.html
        ///</summary>
        public static Engine FoldWhile(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FoldWhile[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns {x,f[x,a1],f[f[x,a1],a2],…}, repeatedly applying f with subsequent values ai until applying test to the result does not yield True.
        ///https://reference.wolfram.com/language/ref/FoldWhileList.html
        ///</summary>
        public static Engine FoldWhileList(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("FoldWhileList[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///is equivalent to FoldWhileList[f,First[list],Rest[list],test].
        ///https://reference.wolfram.com/language/ref/FoldWhileList.html
        ///</summary>
        public static Engine FoldWhileList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FoldWhileList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///supplies the most recent m results as arguments for test at each step.
        ///https://reference.wolfram.com/language/ref/FoldWhileList.html
        ///</summary>
        public static Engine FoldWhileList(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("FoldWhileList[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///returns n additional results by applying f an extra n times after test fails.
        ///https://reference.wolfram.com/language/ref/FoldWhileList.html
        ///</summary>
        public static Engine FoldWhileList(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("FoldWhileList[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///represents an operator form of FoldWhileList that can be applied to expressions.
        ///https://reference.wolfram.com/language/ref/FoldWhileList.html
        ///</summary>
        public static Engine FoldWhileList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FoldWhileList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///executes start, then repeatedly evaluates body and incr until test fails to give True.
        ///https://reference.wolfram.com/language/ref/For.html
        ///</summary>
        public static Engine For(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("For[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents the statement that expr is True for all values of .
        ///https://reference.wolfram.com/language/ref/ForAll.html
        ///</summary>
        public static Engine ForAll(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ForAll[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///states that expr is True for all x satisfying the condition cond.
        ///https://reference.wolfram.com/language/ref/ForAll.html
        ///</summary>
        public static Engine ForAll(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ForAll[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///states that expr is True for all values of all the xi.
        ///https://reference.wolfram.com/language/ref/ForAll.html
        ///</summary>
        public static Engine ForAll(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ForAll[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a type parameterized by x.
        ///https://reference.wolfram.com/language/ref/ForAllType.html
        ///</summary>
        public static Engine ForAllType(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ForAllType[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a type satisfying cond.
        ///https://reference.wolfram.com/language/ref/ForAllType.html
        ///</summary>
        public static Engine ForAllType(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ForAllType[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a type with multiple parameters.
        ///https://reference.wolfram.com/language/ref/ForAllType.html
        ///</summary>
        public static Engine ForAllType(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ForAllType[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///prints as the formatted form of expr. Assigning values to Format[expr] defines print forms for expressions.
        ///https://reference.wolfram.com/language/ref/Format.html
        ///</summary>
        public static Engine Format(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Format[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a format for the specified form of output.
        ///https://reference.wolfram.com/language/ref/Format.html
        ///</summary>
        public static Engine Format(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Format[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct which displays as boxes but specifies that rules associated with form should be used to interpret boxes on input.
        ///https://reference.wolfram.com/language/ref/FormBox.html
        ///</summary>
        public static Engine FormBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FormBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an editable form in a notebook, with structure specified by struct and current values specified by assoc.
        ///https://reference.wolfram.com/language/ref/FormControl.html
        ///</summary>
        public static Engine FormControl(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FormControl[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an active form that, when submitted, applies func to the values obtained from the form specified by formspec.
        ///https://reference.wolfram.com/language/ref/FormFunction.html
        ///</summary>
        public static Engine FormFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FormFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an active form with fields named namei interpreted as types typei.
        ///https://reference.wolfram.com/language/ref/FormFunction.html
        ///</summary>
        public static Engine FormFunction(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FormFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that in the cloud, the result from applying func should be returned in format fmt.
        ///https://reference.wolfram.com/language/ref/FormFunction.html
        ///</summary>
        public static Engine FormFunction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FormFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a multipage form, in which the successive formspeci can be functions that are applied to the values obtained so far.
        ///https://reference.wolfram.com/language/ref/FormFunction.html
        ///</summary>
        public static Engine FormFunction(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FormFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a form with fields having names namei that take data of type typei.
        ///https://reference.wolfram.com/language/ref/FormObject.html
        ///</summary>
        public static Engine FormObject(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FormObject[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents an active page that takes input from a form and generates results on the same page by applying func to the values obtained from the form whose structure is defined by formspec.
        ///https://reference.wolfram.com/language/ref/FormPage.html
        ///</summary>
        public static Engine FormPage(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FormPage[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an active form page with fields named namei interpreted as types typei.
        ///https://reference.wolfram.com/language/ref/FormPage.html
        ///</summary>
        public static Engine FormPage(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FormPage[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///lays out the page according to the layout specification form.
        ///https://reference.wolfram.com/language/ref/FormPage.html
        ///</summary>
        public static Engine FormPage(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FormPage[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the equations for the formula name.
        ///https://reference.wolfram.com/language/ref/FormulaData.html
        ///</summary>
        public static Engine FormulaData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FormulaData[" + arg0 + "]", name);
        }

        ///<summary>
        ///solves or simplifies equations using the specified values quantityi for the variables vari.
        ///https://reference.wolfram.com/language/ref/FormulaData.html
        ///</summary>
        public static Engine FormulaData(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FormulaData[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the formula name.
        ///https://reference.wolfram.com/language/ref/FormulaData.html
        ///</summary>
        public static Engine FormulaData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FormulaData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the full names of formulas whose names are consistent with "query".
        ///https://reference.wolfram.com/language/ref/FormulaLookup.html
        ///</summary>
        public static Engine FormulaLookup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FormulaLookup[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns at most n results.
        ///https://reference.wolfram.com/language/ref/FormulaLookup.html
        ///</summary>
        public static Engine FormulaLookup(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FormulaLookup[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints as a Fortran language version of expr.
        ///https://reference.wolfram.com/language/ref/FortranForm.html
        ///</summary>
        public static Engine FortranForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FortranForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the discrete Fourier transform of a list of complex numbers.
        ///https://reference.wolfram.com/language/ref/Fourier.html
        ///</summary>
        public static Engine Fourier(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Fourier[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the specified positions of the discrete Fourier transform.
        ///https://reference.wolfram.com/language/ref/Fourier.html
        ///</summary>
        public static Engine Fourier(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Fourier[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n coefficient in the Fourier series expansion of expr.
        ///https://reference.wolfram.com/language/ref/FourierCoefficient.html
        ///</summary>
        public static Engine FourierCoefficient(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierCoefficient[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a multidimensional Fourier coefficient.
        ///https://reference.wolfram.com/language/ref/FourierCoefficient.html
        ///</summary>
        public static Engine FourierCoefficient(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierCoefficient[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n coefficient in the Fourier cosine series expansion of expr.
        ///https://reference.wolfram.com/language/ref/FourierCosCoefficient.html
        ///</summary>
        public static Engine FourierCosCoefficient(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierCosCoefficient[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a multidimensional Fourier cosine coefficient.
        ///https://reference.wolfram.com/language/ref/FourierCosCoefficient.html
        ///</summary>
        public static Engine FourierCosCoefficient(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierCosCoefficient[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n-order Fourier cosine series expansion of expr in t.
        ///https://reference.wolfram.com/language/ref/FourierCosSeries.html
        ///</summary>
        public static Engine FourierCosSeries(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierCosSeries[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Fourier cosine series of expr.
        ///https://reference.wolfram.com/language/ref/FourierCosSeries.html
        ///</summary>
        public static Engine FourierCosSeries(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierCosSeries[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the symbolic Fourier cosine transform of expr.
        ///https://reference.wolfram.com/language/ref/FourierCosTransform.html
        ///</summary>
        public static Engine FourierCosTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierCosTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Fourier cosine transform of expr.
        ///https://reference.wolfram.com/language/ref/FourierCosTransform.html
        ///</summary>
        public static Engine FourierCosTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierCosTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///finds the Fourier discrete cosine transform of a list of real numbers.
        ///https://reference.wolfram.com/language/ref/FourierDCT.html
        ///</summary>
        public static Engine FourierDCT(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FourierDCT[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the Fourier discrete cosine transform of type m.
        ///https://reference.wolfram.com/language/ref/FourierDCT.html
        ///</summary>
        public static Engine FourierDCT(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FourierDCT[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reduces noise in image by locally thresholding the discrete cosine transforms of overlapping subimages, using the hard threshold t.
        ///https://reference.wolfram.com/language/ref/FourierDCTFilter.html
        ///</summary>
        public static Engine FourierDCTFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FourierDCTFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns an n×n discrete cosine transform matrix of type 2.
        ///https://reference.wolfram.com/language/ref/FourierDCTMatrix.html
        ///</summary>
        public static Engine FourierDCTMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FourierDCTMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns an n×n discrete cosine transform matrix of type m.
        ///https://reference.wolfram.com/language/ref/FourierDCTMatrix.html
        ///</summary>
        public static Engine FourierDCTMatrix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FourierDCTMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the Fourier discrete sine transform of a list of real numbers.
        ///https://reference.wolfram.com/language/ref/FourierDST.html
        ///</summary>
        public static Engine FourierDST(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FourierDST[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the Fourier discrete sine transform of type .
        ///https://reference.wolfram.com/language/ref/FourierDST.html
        ///</summary>
        public static Engine FourierDST(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FourierDST[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns an n×n discrete sine transform matrix of type 2.
        ///https://reference.wolfram.com/language/ref/FourierDSTMatrix.html
        ///</summary>
        public static Engine FourierDSTMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FourierDSTMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns an n×n discrete sine transform matrix of type m.
        ///https://reference.wolfram.com/language/ref/FourierDSTMatrix.html
        ///</summary>
        public static Engine FourierDSTMatrix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FourierDSTMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns an n×n Fourier matrix.
        ///https://reference.wolfram.com/language/ref/FourierMatrix.html
        ///</summary>
        public static Engine FourierMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FourierMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Fourier sequence transform of expr.
        ///https://reference.wolfram.com/language/ref/FourierSequenceTransform.html
        ///</summary>
        public static Engine FourierSequenceTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierSequenceTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Fourier sequence transform.
        ///https://reference.wolfram.com/language/ref/FourierSequenceTransform.html
        ///</summary>
        public static Engine FourierSequenceTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierSequenceTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n-order Fourier series expansion of expr in t.
        ///https://reference.wolfram.com/language/ref/FourierSeries.html
        ///</summary>
        public static Engine FourierSeries(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierSeries[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Fourier series.
        ///https://reference.wolfram.com/language/ref/FourierSeries.html
        ///</summary>
        public static Engine FourierSeries(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierSeries[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n coefficient in the Fourier sine series expansion of expr.
        ///https://reference.wolfram.com/language/ref/FourierSinCoefficient.html
        ///</summary>
        public static Engine FourierSinCoefficient(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierSinCoefficient[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a multidimensional Fourier sine coefficient.
        ///https://reference.wolfram.com/language/ref/FourierSinCoefficient.html
        ///</summary>
        public static Engine FourierSinCoefficient(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierSinCoefficient[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n-order Fourier sine series expansion of expr in t.
        ///https://reference.wolfram.com/language/ref/FourierSinSeries.html
        ///</summary>
        public static Engine FourierSinSeries(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierSinSeries[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Fourier sine series of expr.
        ///https://reference.wolfram.com/language/ref/FourierSinSeries.html
        ///</summary>
        public static Engine FourierSinSeries(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierSinSeries[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the symbolic Fourier sine transform of expr.
        ///https://reference.wolfram.com/language/ref/FourierSinTransform.html
        ///</summary>
        public static Engine FourierSinTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierSinTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Fourier sine transform of expr.
        ///https://reference.wolfram.com/language/ref/FourierSinTransform.html
        ///</summary>
        public static Engine FourierSinTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierSinTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the symbolic Fourier transform of expr.
        ///https://reference.wolfram.com/language/ref/FourierTransform.html
        ///</summary>
        public static Engine FourierTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Fourier transform of expr.
        ///https://reference.wolfram.com/language/ref/FourierTransform.html
        ///</summary>
        public static Engine FourierTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the n-order Fourier trigonometric series expansion of expr in t.
        ///https://reference.wolfram.com/language/ref/FourierTrigSeries.html
        ///</summary>
        public static Engine FourierTrigSeries(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FourierTrigSeries[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional Fourier trigonometric series of expr.
        ///https://reference.wolfram.com/language/ref/FourierTrigSeries.html
        ///</summary>
        public static Engine FourierTrigSeries(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("FourierTrigSeries[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///is the Fox H function .
        ///https://reference.wolfram.com/language/ref/FoxH.html
        ///</summary>
        public static Engine FoxH(this Engine en, List<object> arg0, object arg1, List<object> arg2, List<object> arg3, object arg4, List<object> arg5, List<object> arg6, object arg7, List<object> arg8, List<object> arg9, object arg10, List<object> arg11, object arg12, string? name = null)
        {
            return en.Execute("FoxH[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + arg4 + ", " + "{" + string.Join(',', arg5) + "}" + ", " + "{" + string.Join(',', arg6) + "}" + ", " + arg7 + ", " + "{" + string.Join(',', arg8) + "}" + ", " + "{" + string.Join(',', arg9) + "}" + ", " + arg10 + ", " + "{" + string.Join(',', arg11) + "}" + ", " + arg12 + "]", name);
        }

        ///<summary>
        ///attempts to reduce expr to a single FoxH object as a function of x.
        ///https://reference.wolfram.com/language/ref/FoxHReduce.html
        ///</summary>
        public static Engine FoxHReduce(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FoxHReduce[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents fractional Brownian motion process with drift μ, volatility σ, and Hurst index h.
        ///https://reference.wolfram.com/language/ref/FractionalBrownianMotionProcess.html
        ///</summary>
        public static Engine FractionalBrownianMotionProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FractionalBrownianMotionProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents fractional Brownian motion process with drift 0, volatility 1, and Hurst index h.
        ///https://reference.wolfram.com/language/ref/FractionalBrownianMotionProcess.html
        ///</summary>
        public static Engine FractionalBrownianMotionProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FractionalBrownianMotionProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Riemann–Liouville fractional derivative  of order α of the function f.
        ///https://reference.wolfram.com/language/ref/FractionalD.html
        ///</summary>
        public static Engine FractionalD(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FractionalD[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a fractional Gaussian noise process with drift μ, volatility σ, and Hurst index h.
        ///https://reference.wolfram.com/language/ref/FractionalGaussianNoiseProcess.html
        ///</summary>
        public static Engine FractionalGaussianNoiseProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FractionalGaussianNoiseProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a fractional Gaussian noise process with drift 0, volatility 1, and Hurst index h.
        ///https://reference.wolfram.com/language/ref/FractionalGaussianNoiseProcess.html
        ///</summary>
        public static Engine FractionalGaussianNoiseProcess(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FractionalGaussianNoiseProcess[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the fractional part of x.
        ///https://reference.wolfram.com/language/ref/FractionalPart.html
        ///</summary>
        public static Engine FractionalPart(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FractionalPart[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level formatting construct that represents  in notebook expressions.
        ///https://reference.wolfram.com/language/ref/FractionBox.html
        ///</summary>
        public static Engine FractionBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FractionBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents box with a frame drawn around it.
        ///https://reference.wolfram.com/language/ref/FrameBox.html
        ///</summary>
        public static Engine FrameBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FrameBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays a framed version of expr.
        ///https://reference.wolfram.com/language/ref/Framed.html
        ///</summary>
        public static Engine Framed(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Framed[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a video containing frames image1, image2, etc.
        ///https://reference.wolfram.com/language/ref/FrameListVideo.html
        ///</summary>
        public static Engine FrameListVideo(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FrameListVideo[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a video from existing image files.
        ///https://reference.wolfram.com/language/ref/FrameListVideo.html
        ///</summary>
        public static Engine FrameListVideo(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FrameListVideo[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an F-ratio distribution with n numerator and m denominator degrees of freedom.
        ///https://reference.wolfram.com/language/ref/FRatioDistribution.html
        ///</summary>
        public static Engine FRatioDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FRatioDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Fréchet distribution with shape parameter α and scale parameter β.
        ///https://reference.wolfram.com/language/ref/FrechetDistribution.html
        ///</summary>
        public static Engine FrechetDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FrechetDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Fréchet distribution with shape parameter α, scale parameter β, and location parameter μ.
        ///https://reference.wolfram.com/language/ref/FrechetDistribution.html
        ///</summary>
        public static Engine FrechetDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FrechetDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields True if no subexpression in expr matches form, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/FreeQ.html
        ///</summary>
        public static Engine FreeQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FreeQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests only those parts of expr on levels specified by levelspec.
        ///https://reference.wolfram.com/language/ref/FreeQ.html
        ///</summary>
        public static Engine FreeQ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FreeQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of FreeQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/FreeQ.html
        ///</summary>
        public static Engine FreeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FreeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generalized curvatures and Frenet–Serret basis for the parametric curve xi[t].
        ///https://reference.wolfram.com/language/ref/FrenetSerretSystem.html
        ///</summary>
        public static Engine FrenetSerretSystem(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FrenetSerretSystem[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///interprets the xi as coordinates in the specified coordinate chart.
        ///https://reference.wolfram.com/language/ref/FrenetSerretSystem.html
        ///</summary>
        public static Engine FrenetSerretSystem(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FrenetSerretSystem[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///creates a finite impulse response (FIR) filter kernel using a frequency sampling method from amplitude values ai.
        ///https://reference.wolfram.com/language/ref/FrequencySamplingFilterKernel.html
        ///</summary>
        public static Engine FrequencySamplingFilterKernel(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FrequencySamplingFilterKernel[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///creates an FIR filter kernel of type m.
        ///https://reference.wolfram.com/language/ref/FrequencySamplingFilterKernel.html
        ///</summary>
        public static Engine FrequencySamplingFilterKernel(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FrequencySamplingFilterKernel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Fresnel integral .
        ///https://reference.wolfram.com/language/ref/FresnelC.html
        ///</summary>
        public static Engine FresnelC(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FresnelC[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Fresnel auxiliary function .
        ///https://reference.wolfram.com/language/ref/FresnelF.html
        ///</summary>
        public static Engine FresnelF(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FresnelF[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Fresnel auxiliary function .
        ///https://reference.wolfram.com/language/ref/FresnelG.html
        ///</summary>
        public static Engine FresnelG(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FresnelG[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Fresnel integral .
        ///https://reference.wolfram.com/language/ref/FresnelS.html
        ///</summary>
        public static Engine FresnelS(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FresnelS[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Frobenius number of a1,…,an.
        ///https://reference.wolfram.com/language/ref/FrobeniusNumber.html
        ///</summary>
        public static Engine FrobeniusNumber(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FrobeniusNumber[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of all solutions of the Frobenius equation .
        ///https://reference.wolfram.com/language/ref/FrobeniusSolve.html
        ///</summary>
        public static Engine FrobeniusSolve(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FrobeniusSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives at most m solutions.
        ///https://reference.wolfram.com/language/ref/FrobeniusSolve.html
        ///</summary>
        public static Engine FrobeniusSolve(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FrobeniusSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to an absolute time specification as given by AbsoluteTime.
        ///https://reference.wolfram.com/language/ref/FromAbsoluteTime.html
        ///</summary>
        public static Engine FromAbsoluteTime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromAbsoluteTime[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a string consisting of the character with integer code n.
        ///https://reference.wolfram.com/language/ref/FromCharacterCode.html
        ///</summary>
        public static Engine FromCharacterCode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromCharacterCode[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a string consisting of the sequence of characters with codes ni.
        ///https://reference.wolfram.com/language/ref/FromCharacterCode.html
        ///</summary>
        public static Engine FromCharacterCode(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FromCharacterCode[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of strings.
        ///https://reference.wolfram.com/language/ref/FromCharacterCode.html
        ///</summary>
        public static Engine FromCharacterCode(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FromCharacterCode[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the specified character encoding.
        ///https://reference.wolfram.com/language/ref/FromCharacterCode.html
        ///</summary>
        public static Engine FromCharacterCode(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FromCharacterCode[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs a polynomial from a list of rules for exponent vectors and coefficients.
        ///https://reference.wolfram.com/language/ref/FromCoefficientRules.html
        ///</summary>
        public static Engine FromCoefficientRules(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FromCoefficientRules[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///reconstructs a number from the list of its continued fraction terms.
        ///https://reference.wolfram.com/language/ref/FromContinuedFraction.html
        ///</summary>
        public static Engine FromContinuedFraction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromContinuedFraction[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to the date represented by "string".
        ///https://reference.wolfram.com/language/ref/FromDateString.html
        ///</summary>
        public static Engine FromDateString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromDateString[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the date object obtained by extracting elements "ei" from "string".
        ///https://reference.wolfram.com/language/ref/FromDateString.html
        ///</summary>
        public static Engine FromDateString(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FromDateString[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the date object obtained using the date format fmt.
        ///https://reference.wolfram.com/language/ref/FromDateString.html
        ///</summary>
        public static Engine FromDateString(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FromDateString[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs an integer from the list of its decimal digits.
        ///https://reference.wolfram.com/language/ref/FromDigits.html
        ///</summary>
        public static Engine FromDigits(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromDigits[" + arg0 + "]", name);
        }

        ///<summary>
        ///takes the digits to be given in base b.
        ///https://reference.wolfram.com/language/ref/FromDigits.html
        ///</summary>
        public static Engine FromDigits(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FromDigits[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///converts from degrees, minutes, and seconds to decimal degrees.
        ///https://reference.wolfram.com/language/ref/FromDMS.html
        ///</summary>
        public static Engine FromDMS(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FromDMS[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///converts from a DMS string to decimal degrees.
        ///https://reference.wolfram.com/language/ref/FromDMS.html
        ///</summary>
        public static Engine FromDMS(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromDMS[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a Wolfram Language object corresponding to an entity.
        ///https://reference.wolfram.com/language/ref/FromEntity.html
        ///</summary>
        public static Engine FromEntity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromEntity[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to the Julian date jd.
        ///https://reference.wolfram.com/language/ref/FromJulianDate.html
        ///</summary>
        public static Engine FromJulianDate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromJulianDate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to the specified Julian date variant.
        ///https://reference.wolfram.com/language/ref/FromJulianDate.html
        ///</summary>
        public static Engine FromJulianDate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FromJulianDate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the lowercase letter at position n in the English alphabet.
        ///https://reference.wolfram.com/language/ref/FromLetterNumber.html
        ///</summary>
        public static Engine FromLetterNumber(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromLetterNumber[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the letter at position n in the alphabet specified by alpha.
        ///https://reference.wolfram.com/language/ref/FromLetterNumber.html
        ///</summary>
        public static Engine FromLetterNumber(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FromLetterNumber[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the {x,y} Cartesian coordinates corresponding to the polar coordinates {r,θ}.
        ///https://reference.wolfram.com/language/ref/FromPolarCoordinates.html
        ///</summary>
        public static Engine FromPolarCoordinates(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FromPolarCoordinates[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the value referred to by the pointer p for use in compiled code.
        ///https://reference.wolfram.com/language/ref/FromRawPointer.html
        ///</summary>
        public static Engine FromRawPointer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromRawPointer[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the value of a C array at an offset.
        ///https://reference.wolfram.com/language/ref/FromRawPointer.html
        ///</summary>
        public static Engine FromRawPointer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FromRawPointer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the integer corresponding to the Roman numeral "string".
        ///https://reference.wolfram.com/language/ref/FromRomanNumeral.html
        ///</summary>
        public static Engine FromRomanNumeral(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromRomanNumeral[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the {x,y,z} Cartesian coordinates corresponding to the spherical coordinates {r,θ,ϕ}.
        ///https://reference.wolfram.com/language/ref/FromSphericalCoordinates.html
        ///</summary>
        public static Engine FromSphericalCoordinates(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FromSphericalCoordinates[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to a UnixTime specification.
        ///https://reference.wolfram.com/language/ref/FromUnixTime.html
        ///</summary>
        public static Engine FromUnixTime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FromUnixTime[" + arg0 + "]", name);
        }

        ///<summary>
        ///sends expr to be executed by the Wolfram System front end.
        ///https://reference.wolfram.com/language/ref/FrontEndExecute.html
        ///</summary>
        public static Engine FrontEndExecute(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FrontEndExecute[" + arg0 + "]", name);
        }

        ///<summary>
        ///is an object that represents a front end command token, typically corresponding to a front end menu item, to be executed by FrontEndExecute.
        ///https://reference.wolfram.com/language/ref/FrontEndToken.html
        ///</summary>
        public static Engine FrontEndToken(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FrontEndToken[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a command that targets the specified notebook.
        ///https://reference.wolfram.com/language/ref/FrontEndToken.html
        ///</summary>
        public static Engine FrontEndToken(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FrontEndToken[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a command with a parameter.
        ///https://reference.wolfram.com/language/ref/FrontEndToken.html
        ///</summary>
        public static Engine FrontEndToken(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FrontEndToken[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///executes the specified front end command token, typically corresponding to a front end menu item.
        ///https://reference.wolfram.com/language/ref/FrontEndTokenExecute.html
        ///</summary>
        public static Engine FrontEndTokenExecute(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FrontEndTokenExecute[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as the definitions given for symbol, and all symbols on which these depend.
        ///https://reference.wolfram.com/language/ref/FullDefinition.html
        ///</summary>
        public static Engine FullDefinition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FullDefinition[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints as the full form of expr, with no special syntax.
        ///https://reference.wolfram.com/language/ref/FullForm.html
        ///</summary>
        public static Engine FullForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FullForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///takes a graphics object, and generates a new one in which objects specified by graphics options are given as explicit lists of graphics primitives.
        ///https://reference.wolfram.com/language/ref/FullGraphics.html
        ///</summary>
        public static Engine FullGraphics(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FullGraphics[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the full state information output regulator for sys using specification rspec.
        ///https://reference.wolfram.com/language/ref/FullInformationOutputRegulator.html
        ///</summary>
        public static Engine FullInformationOutputRegulator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FullInformationOutputRegulator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies the regulated outputs outi and the controlled inputs inj.
        ///https://reference.wolfram.com/language/ref/FullInformationOutputRegulator.html
        ///</summary>
        public static Engine FullInformationOutputRegulator(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("FullInformationOutputRegulator[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents the full region .
        ///https://reference.wolfram.com/language/ref/FullRegion.html
        ///</summary>
        public static Engine FullRegion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FullRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///tries a wide range of transformations on expr involving elementary and special functions and returns the simplest form it finds.
        ///https://reference.wolfram.com/language/ref/FullSimplify.html
        ///</summary>
        public static Engine FullSimplify(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FullSimplify[" + arg0 + "]", name);
        }

        ///<summary>
        ///does simplification using assumptions.
        ///https://reference.wolfram.com/language/ref/FullSimplify.html
        ///</summary>
        public static Engine FullSimplify(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FullSimplify[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a pure (or "anonymous") function. The formal parameters are # (or #1), #2, etc.
        ///https://reference.wolfram.com/language/ref/Function.html
        ///</summary>
        public static Engine Function(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Function[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a pure function with a single formal parameter x.
        ///https://reference.wolfram.com/language/ref/Function.html
        ///</summary>
        public static Engine Function(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Function[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a pure function that is treated as having attributes attrs for purposes of evaluation.
        ///https://reference.wolfram.com/language/ref/Function.html
        ///</summary>
        public static Engine Function(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Function[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  is an analytic function for x∈Reals.
        ///https://reference.wolfram.com/language/ref/FunctionAnalytic.html
        ///</summary>
        public static Engine FunctionAnalytic(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionAnalytic[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether  is an analytic function for x∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionAnalytic.html
        ///</summary>
        public static Engine FunctionAnalytic(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionAnalytic[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  are analytic functions for x1,x2,…∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionAnalytic.html
        ///</summary>
        public static Engine FunctionAnalytic(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionAnalytic[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  are analytic functions for xvars in an open set containing the solutions of the constraints cons over the domain dom.
        ///https://reference.wolfram.com/language/ref/FunctionAnalytic.html
        ///</summary>
        public static Engine FunctionAnalytic(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionAnalytic[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  has exactly one solution x∈Reals for each y∈Reals.
        ///https://reference.wolfram.com/language/ref/FunctionBijective.html
        ///</summary>
        public static Engine FunctionBijective(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionBijective[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether  has exactly one solution x∈dom for each y∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionBijective.html
        ///</summary>
        public static Engine FunctionBijective(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionBijective[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  has exactly one solution x1,x2,…∈dom for each y1,y2,…∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionBijective.html
        ///</summary>
        public static Engine FunctionBijective(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionBijective[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  has exactly one solution with xvars∈dom restricted by the constraints xcons for each yvars∈dom restricted by the constraints ycons.
        ///https://reference.wolfram.com/language/ref/FunctionBijective.html
        ///</summary>
        public static Engine FunctionBijective(this Engine en, List<object> arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FunctionBijective[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///generates a compiled code function from a pure function.
        ///https://reference.wolfram.com/language/ref/FunctionCompile.html
        ///</summary>
        public static Engine FunctionCompile(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FunctionCompile[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a list of compiled code functions from a list of pure functions.
        ///https://reference.wolfram.com/language/ref/FunctionCompile.html
        ///</summary>
        public static Engine FunctionCompile(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("FunctionCompile[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates an association of compiled code functions from an association of Wolfram Language functions.
        ///https://reference.wolfram.com/language/ref/FunctionCompile.html
        ///</summary>
        public static Engine FunctionCompile(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionCompile[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses the local auxiliary definitions defs.
        ///https://reference.wolfram.com/language/ref/FunctionCompile.html
        ///</summary>
        public static Engine FunctionCompile(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionCompile[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///exports a compiled version of functions fspec in the format specified by the file extension ext.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExport.html
        ///</summary>
        public static Engine FunctionCompileExport(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionCompileExport[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///exports a compiled version of fspec using local auxiliary definitions defs.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExport.html
        ///</summary>
        public static Engine FunctionCompileExport(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionCompileExport[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///exports a compiled version using local auxiliary definitions.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExport.html
        ///</summary>
        public static Engine FunctionCompileExport(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FunctionCompileExport[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a byte array of binary LLVM code obtained by compiling the function specification fspec.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExportByteArray.html
        ///</summary>
        public static Engine FunctionCompileExportByteArray(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FunctionCompileExportByteArray[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the auxiliary definitions defs for compilation.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExportByteArray.html
        ///</summary>
        public static Engine FunctionCompileExportByteArray(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionCompileExportByteArray[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///exports a compiled version of function specification fspec as a shared library suitable for external use.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExportLibrary.html
        ///</summary>
        public static Engine FunctionCompileExportLibrary(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionCompileExportLibrary[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the auxiliary definitions defs for compilation.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExportLibrary.html
        ///</summary>
        public static Engine FunctionCompileExportLibrary(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionCompileExportLibrary[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a string of textual LLVM code obtained by compiling the function specification fspec.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExportString.html
        ///</summary>
        public static Engine FunctionCompileExportString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FunctionCompileExportString[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the auxiliary definitions defs for compilation.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExportString.html
        ///</summary>
        public static Engine FunctionCompileExportString(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionCompileExportString[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether  is a real-valued continuous function for x∈Reals.
        ///https://reference.wolfram.com/language/ref/FunctionContinuous.html
        ///</summary>
        public static Engine FunctionContinuous(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionContinuous[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether  is a continuous function for x∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionContinuous.html
        ///</summary>
        public static Engine FunctionContinuous(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionContinuous[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  are continuous functions for x1,x2,…∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionContinuous.html
        ///</summary>
        public static Engine FunctionContinuous(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionContinuous[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  are continuous functions for xvars∈dom restricted by the constraints cons.
        ///https://reference.wolfram.com/language/ref/FunctionContinuous.html
        ///</summary>
        public static Engine FunctionContinuous(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionContinuous[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the convexity of the function f with variables x1,x2,… over the reals.
        ///https://reference.wolfram.com/language/ref/FunctionConvexity.html
        ///</summary>
        public static Engine FunctionConvexity(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FunctionConvexity[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds the convexity when variables are restricted by the constraints cons representing a convex region.
        ///https://reference.wolfram.com/language/ref/FunctionConvexity.html
        ///</summary>
        public static Engine FunctionConvexity(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FunctionConvexity[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///declares name to be a typed function suitable for use in a compiler environment.
        ///https://reference.wolfram.com/language/ref/FunctionDeclaration.html
        ///</summary>
        public static Engine FunctionDeclaration(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionDeclaration[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the discontinuities of  for x∈Reals.
        ///https://reference.wolfram.com/language/ref/FunctionDiscontinuities.html
        ///</summary>
        public static Engine FunctionDiscontinuities(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionDiscontinuities[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the discontinuities of  for x∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionDiscontinuities.html
        ///</summary>
        public static Engine FunctionDiscontinuities(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionDiscontinuities[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the discontinuities of  for x1,x2,…∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionDiscontinuities.html
        ///</summary>
        public static Engine FunctionDiscontinuities(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionDiscontinuities[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the largest domain of definition of the real function f of the variable x.
        ///https://reference.wolfram.com/language/ref/FunctionDomain.html
        ///</summary>
        public static Engine FunctionDomain(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionDomain[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///considers f to be a function with arguments and values in the domain dom.
        ///https://reference.wolfram.com/language/ref/FunctionDomain.html
        ///</summary>
        public static Engine FunctionDomain(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionDomain[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the domain of funs with the values of vars restricted by constraints cons.
        ///https://reference.wolfram.com/language/ref/FunctionDomain.html
        ///</summary>
        public static Engine FunctionDomain(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionDomain[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tries to expand out special and certain other functions in expr, when possible reducing compound arguments to simpler ones.
        ///https://reference.wolfram.com/language/ref/FunctionExpand.html
        ///</summary>
        public static Engine FunctionExpand(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FunctionExpand[" + arg0 + "]", name);
        }

        ///<summary>
        ///expands using assumptions.
        ///https://reference.wolfram.com/language/ref/FunctionExpand.html
        ///</summary>
        public static Engine FunctionExpand(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionExpand[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether  has at most one solution x∈Reals for each y.
        ///https://reference.wolfram.com/language/ref/FunctionInjective.html
        ///</summary>
        public static Engine FunctionInjective(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionInjective[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether  has at most one solution x∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionInjective.html
        ///</summary>
        public static Engine FunctionInjective(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionInjective[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  has at most one solution x1,x2,…∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionInjective.html
        ///</summary>
        public static Engine FunctionInjective(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionInjective[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  has at most one solution with xvars∈dom restricted by the constraints xcons for each yvars∈dom restricted by the constraints ycons.
        ///https://reference.wolfram.com/language/ref/FunctionInjective.html
        ///</summary>
        public static Engine FunctionInjective(this Engine en, List<object> arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FunctionInjective[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///evaluates expr with x running from xmin to xmax and constructs an InterpolatingFunction object which represents an approximate function corresponding to the result.
        ///https://reference.wolfram.com/language/ref/FunctionInterpolation.html
        ///</summary>
        public static Engine FunctionInterpolation(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FunctionInterpolation[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constructs an InterpolatingFunction object with several arguments.
        ///https://reference.wolfram.com/language/ref/FunctionInterpolation.html
        ///</summary>
        public static Engine FunctionInterpolation(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("FunctionInterpolation[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a net layer that applies function f to its input.
        ///https://reference.wolfram.com/language/ref/FunctionLayer.html
        ///</summary>
        public static Engine FunctionLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("FunctionLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///test whether  is a meromorphic function of x.
        ///https://reference.wolfram.com/language/ref/FunctionMeromorphic.html
        ///</summary>
        public static Engine FunctionMeromorphic(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionMeromorphic[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///test whether  is a meromorphic function of x1,x2,….
        ///https://reference.wolfram.com/language/ref/FunctionMeromorphic.html
        ///</summary>
        public static Engine FunctionMeromorphic(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FunctionMeromorphic[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///test whether  are meromorphic functions for x1,x2,….
        ///https://reference.wolfram.com/language/ref/FunctionMeromorphic.html
        ///</summary>
        public static Engine FunctionMeromorphic(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FunctionMeromorphic[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///test whether  are meromorphic functions for xvars in an open set containing the solutions of the constraints cons.
        ///https://reference.wolfram.com/language/ref/FunctionMeromorphic.html
        ///</summary>
        public static Engine FunctionMeromorphic(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionMeromorphic[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the monotonicity of the function f with the variable x over the reals.
        ///https://reference.wolfram.com/language/ref/FunctionMonotonicity.html
        ///</summary>
        public static Engine FunctionMonotonicity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionMonotonicity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the monotonicity of f when x is restricted to the domain dom.
        ///https://reference.wolfram.com/language/ref/FunctionMonotonicity.html
        ///</summary>
        public static Engine FunctionMonotonicity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionMonotonicity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the monotonicity of f when x is restricted by the constraints cons.
        ///https://reference.wolfram.com/language/ref/FunctionMonotonicity.html
        ///</summary>
        public static Engine FunctionMonotonicity(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionMonotonicity[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a period p of the function f over the reals such that .
        ///https://reference.wolfram.com/language/ref/FunctionPeriod.html
        ///</summary>
        public static Engine FunctionPeriod(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionPeriod[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a period with x restricted to the domain dom.
        ///https://reference.wolfram.com/language/ref/FunctionPeriod.html
        ///</summary>
        public static Engine FunctionPeriod(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionPeriod[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives periods {p1,p2,…} for {x1,x2,…} such that .
        ///https://reference.wolfram.com/language/ref/FunctionPeriod.html
        ///</summary>
        public static Engine FunctionPeriod(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionPeriod[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the poles of the meromorphic function f with the variable x.
        ///https://reference.wolfram.com/language/ref/FunctionPoles.html
        ///</summary>
        public static Engine FunctionPoles(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionPoles[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the poles of f when x is restricted by the constraints cons.
        ///https://reference.wolfram.com/language/ref/FunctionPoles.html
        ///</summary>
        public static Engine FunctionPoles(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionPoles[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the range of the real function f of the variable x returning the result in terms of y.
        ///https://reference.wolfram.com/language/ref/FunctionRange.html
        ///</summary>
        public static Engine FunctionRange(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionRange[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///considers f to be a function with arguments and values in the domain dom.
        ///https://reference.wolfram.com/language/ref/FunctionRange.html
        ///</summary>
        public static Engine FunctionRange(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FunctionRange[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds the range of the mapping funs with the values of xvars restricted by constraints cons.
        ///https://reference.wolfram.com/language/ref/FunctionRange.html
        ///</summary>
        public static Engine FunctionRange(this Engine en, List<object> arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FunctionRange[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///finds the real sign of the function f with variables x1,x2,… over the reals.
        ///https://reference.wolfram.com/language/ref/FunctionSign.html
        ///</summary>
        public static Engine FunctionSign(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("FunctionSign[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds the real sign with variables restricted to the domain dom.
        ///https://reference.wolfram.com/language/ref/FunctionSign.html
        ///</summary>
        public static Engine FunctionSign(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionSign[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the sign when variables are restricted by the constraints cons.
        ///https://reference.wolfram.com/language/ref/FunctionSign.html
        ///</summary>
        public static Engine FunctionSign(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionSign[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the singularities of  for x∈Reals.
        ///https://reference.wolfram.com/language/ref/FunctionSingularities.html
        ///</summary>
        public static Engine FunctionSingularities(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionSingularities[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the singularities of  for x∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionSingularities.html
        ///</summary>
        public static Engine FunctionSingularities(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionSingularities[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the singularities of  for x1,x2,…∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionSingularities.html
        ///</summary>
        public static Engine FunctionSingularities(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionSingularities[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  has at least one solution  for each y∈Reals.
        ///https://reference.wolfram.com/language/ref/FunctionSurjective.html
        ///</summary>
        public static Engine FunctionSurjective(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FunctionSurjective[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether  has at least one solution x∈dom for each y∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionSurjective.html
        ///</summary>
        public static Engine FunctionSurjective(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionSurjective[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  has at least one solution x1,x2,…∈dom for each y1,y2,…∈dom.
        ///https://reference.wolfram.com/language/ref/FunctionSurjective.html
        ///</summary>
        public static Engine FunctionSurjective(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("FunctionSurjective[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether  has at least one solution with xvars∈dom restricted by the constraints xcons for each yvars∈dom restricted by the constraints ycons.
        ///https://reference.wolfram.com/language/ref/FunctionSurjective.html
        ///</summary>
        public static Engine FunctionSurjective(this Engine en, List<object> arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("FunctionSurjective[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the Fussell–Vesely importances for all components in the ReliabilityDistribution rdist at time t.
        ///https://reference.wolfram.com/language/ref/FussellVeselyImportance.html
        ///</summary>
        public static Engine FussellVeselyImportance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("FussellVeselyImportance[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}
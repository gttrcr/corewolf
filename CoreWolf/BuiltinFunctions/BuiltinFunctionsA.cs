using System.Collections.Generic;

namespace CoreWolf
{
    public static class BuiltinFunctionA
    {
        ///<summary>
        ///returns a filled triangle with angles α and β and side length a, where a is adjacent to one angle only.
        ///https://reference.wolfram.com/language/ref/AASTriangle.html
        ///</summary>
        public static Engine AASTriangle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AASTriangle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates an interrupt to abort a computation.
        ///https://reference.wolfram.com/language/ref/Abort.html
        ///</summary>
        public static Engine Abort(this Engine en, string? name = null)
        {
            return en.Execute("Abort[]", name);
        }

        ///<summary>
        ///aborts evaluations running in all parallel subkernels.
        ///https://reference.wolfram.com/language/ref/AbortKernels.html
        ///</summary>
        public static Engine AbortKernels(this Engine en, string? name = null)
        {
            return en.Execute("AbortKernels[]", name);
        }

        ///<summary>
        ///evaluates expr, saving any aborts until the evaluation is complete.
        ///https://reference.wolfram.com/language/ref/AbortProtect.html
        ///</summary>
        public static Engine AbortProtect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbortProtect[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the absolute value of the real or complex number z.
        ///https://reference.wolfram.com/language/ref/Abs.html
        ///</summary>
        public static Engine Abs(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Abs[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list {Abs[z],Arg[z]} of the number z.
        ///https://reference.wolfram.com/language/ref/AbsArg.html
        ///</summary>
        public static Engine AbsArg(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsArg[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot of Abs[f] colored by Arg[f] as a function of x∈ from xmin to xmax.
        ///https://reference.wolfram.com/language/ref/AbsArgPlot.html
        ///</summary>
        public static Engine AbsArgPlot(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AbsArgPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots several functions.
        ///https://reference.wolfram.com/language/ref/AbsArgPlot.html
        ///</summary>
        public static Engine AbsArgPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AbsArgPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots fi with features defined by the symbolic wrapper w.
        ///https://reference.wolfram.com/language/ref/AbsArgPlot.html
        ///</summary>
        public static Engine AbsArgPlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AbsArgPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes the variable x to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/AbsArgPlot.html
        ///</summary>
        public static Engine AbsArgPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AbsArgPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the absolute correlation between the vectors v1 and v2.
        ///https://reference.wolfram.com/language/ref/AbsoluteCorrelation.html
        ///</summary>
        public static Engine AbsoluteCorrelation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AbsoluteCorrelation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the absolute correlation matrix for the matrix m.
        ///https://reference.wolfram.com/language/ref/AbsoluteCorrelation.html
        ///</summary>
        public static Engine AbsoluteCorrelation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsoluteCorrelation[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the (i,j) absolute correlation for the multivariate symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/AbsoluteCorrelation.html
        ///</summary>
        public static Engine AbsoluteCorrelation(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AbsoluteCorrelation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///estimates the absolute correlation function at lags hspec from data.
        ///https://reference.wolfram.com/language/ref/AbsoluteCorrelationFunction.html
        ///</summary>
        public static Engine AbsoluteCorrelationFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AbsoluteCorrelationFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the absolute correlation function at times s and t for the random process proc.
        ///https://reference.wolfram.com/language/ref/AbsoluteCorrelationFunction.html
        ///</summary>
        public static Engine AbsoluteCorrelationFunction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AbsoluteCorrelationFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the absolute current value of item at a location in the Wolfram System and interface.
        ///https://reference.wolfram.com/language/ref/AbsoluteCurrentValue.html
        ///</summary>
        public static Engine AbsoluteCurrentValue(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsoluteCurrentValue[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the absolute current value for the feature of item specified by spec.
        ///https://reference.wolfram.com/language/ref/AbsoluteCurrentValue.html
        ///</summary>
        public static Engine AbsoluteCurrentValue(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AbsoluteCurrentValue[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the absolute current value of item associated with the object obj.
        ///https://reference.wolfram.com/language/ref/AbsoluteCurrentValue.html
        ///</summary>
        public static Engine AbsoluteCurrentValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AbsoluteCurrentValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that lines which follow are to be drawn dashed, with successive segments having absolute lengths d1, d2, … (repeated cyclically).
        ///https://reference.wolfram.com/language/ref/AbsoluteDashing.html
        ///</summary>
        public static Engine AbsoluteDashing(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AbsoluteDashing[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is equivalent to AbsoluteDashing[{d,d}].
        ///https://reference.wolfram.com/language/ref/AbsoluteDashing.html
        ///</summary>
        public static Engine AbsoluteDashing(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsoluteDashing[" + arg0 + "]", name);
        }

        ///<summary>
        ///offsets the dashes by offset.
        ///https://reference.wolfram.com/language/ref/AbsoluteDashing.html
        ///</summary>
        public static Engine AbsoluteDashing(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AbsoluteDashing[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets the CapForm for individual dashes to capform.
        ///https://reference.wolfram.com/language/ref/AbsoluteDashing.html
        ///</summary>
        public static Engine AbsoluteDashing(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AbsoluteDashing[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the full absolute version of the name for a file in your filesystem.
        ///https://reference.wolfram.com/language/ref/AbsoluteFileName.html
        ///</summary>
        public static Engine AbsoluteFileName(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsoluteFileName[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the absolute settings of options specified in an expression such as a graphics object.
        ///https://reference.wolfram.com/language/ref/AbsoluteOptions.html
        ///</summary>
        public static Engine AbsoluteOptions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsoluteOptions[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the absolute setting for the option name.
        ///https://reference.wolfram.com/language/ref/AbsoluteOptions.html
        ///</summary>
        public static Engine AbsoluteOptions(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AbsoluteOptions[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the absolute settings for the options namei.
        ///https://reference.wolfram.com/language/ref/AbsoluteOptions.html
        ///</summary>
        public static Engine AbsoluteOptions(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AbsoluteOptions[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that points which follow are to be shown if possible as circular regions with absolute diameter d.
        ///https://reference.wolfram.com/language/ref/AbsolutePointSize.html
        ///</summary>
        public static Engine AbsolutePointSize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsolutePointSize[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that lines which follow are to be drawn with absolute thickness d.
        ///https://reference.wolfram.com/language/ref/AbsoluteThickness.html
        ///</summary>
        public static Engine AbsoluteThickness(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsoluteThickness[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the total number of seconds since the beginning of January 1, 1900, in your time zone.
        ///https://reference.wolfram.com/language/ref/AbsoluteTime.html
        ///</summary>
        public static Engine AbsoluteTime(this Engine en, string? name = null)
        {
            return en.Execute("AbsoluteTime[]", name);
        }

        ///<summary>
        ///gives the absolute time specification corresponding to the given date specification.
        ///https://reference.wolfram.com/language/ref/AbsoluteTime.html
        ///</summary>
        public static Engine AbsoluteTime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsoluteTime[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates expr, returning a list of the absolute number of seconds in real time that have elapsed, together with the result obtained.
        ///https://reference.wolfram.com/language/ref/AbsoluteTiming.html
        ///</summary>
        public static Engine AbsoluteTiming(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AbsoluteTiming[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with all numbers in expr given in standard accounting notation.
        ///https://reference.wolfram.com/language/ref/AccountingForm.html
        ///</summary>
        public static Engine AccountingForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AccountingForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with numbers given to n‐digit precision.
        ///https://reference.wolfram.com/language/ref/AccountingForm.html
        ///</summary>
        public static Engine AccountingForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AccountingForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the successive accumulated totals of elements in list.
        ///https://reference.wolfram.com/language/ref/Accumulate.html
        ///</summary>
        public static Engine Accumulate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Accumulate[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the effective number of digits to the right of the decimal point in the number x.
        ///https://reference.wolfram.com/language/ref/Accuracy.html
        ///</summary>
        public static Engine Accuracy(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Accuracy[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain absorbing boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/AcousticAbsorbingValue.html
        ///</summary>
        public static Engine AcousticAbsorbingValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AcousticAbsorbingValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/AcousticAbsorbingValue.html
        ///</summary>
        public static Engine AcousticAbsorbingValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AcousticAbsorbingValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain impedance boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/AcousticImpedanceValue.html
        ///</summary>
        public static Engine AcousticImpedanceValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AcousticImpedanceValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/AcousticImpedanceValue.html
        ///</summary>
        public static Engine AcousticImpedanceValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AcousticImpedanceValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain normal velocity boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/AcousticNormalVelocityValue.html
        ///</summary>
        public static Engine AcousticNormalVelocityValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AcousticNormalVelocityValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/AcousticNormalVelocityValue.html
        ///</summary>
        public static Engine AcousticNormalVelocityValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AcousticNormalVelocityValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///yields an acoustic PDE term component with variables vars and parameters pars.
        ///https://reference.wolfram.com/language/ref/AcousticPDEComponent.html
        ///</summary>
        public static Engine AcousticPDEComponent(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AcousticPDEComponent[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain pressure boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/AcousticPressureCondition.html
        ///</summary>
        public static Engine AcousticPressureCondition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AcousticPressureCondition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/AcousticPressureCondition.html
        ///</summary>
        public static Engine AcousticPressureCondition(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AcousticPressureCondition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency radiation boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/AcousticRadiationValue.html
        ///</summary>
        public static Engine AcousticRadiationValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AcousticRadiationValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/AcousticRadiationValue.html
        ///</summary>
        public static Engine AcousticRadiationValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AcousticRadiationValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain sound hard boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/AcousticSoundHardValue.html
        ///</summary>
        public static Engine AcousticSoundHardValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AcousticSoundHardValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/AcousticSoundHardValue.html
        ///</summary>
        public static Engine AcousticSoundHardValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AcousticSoundHardValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain sound soft boundary condition for PDEs with predicate pred indicating where it applies, with model variables vars and global parameters pars.
        ///https://reference.wolfram.com/language/ref/AcousticSoundSoftCondition.html
        ///</summary>
        public static Engine AcousticSoundSoftCondition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AcousticSoundSoftCondition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a time or frequency domain boundary condition with local parameters specified in pars[lkey].
        ///https://reference.wolfram.com/language/ref/AcousticSoundSoftCondition.html
        ///</summary>
        public static Engine AcousticSoundSoftCondition(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AcousticSoundSoftCondition[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an action menu with label name and with items labeled lbli that evaluates the expression acti if the corresponding item is chosen.
        ///https://reference.wolfram.com/language/ref/ActionMenu.html
        ///</summary>
        public static Engine ActionMenu(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ActionMenu[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///replaces all instances of Inactive[f] in expr with f.
        ///https://reference.wolfram.com/language/ref/Activate.html
        ///</summary>
        public static Engine Activate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Activate[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces only instances of Inactive[f] for which f matches the pattern patt.
        ///https://reference.wolfram.com/language/ref/Activate.html
        ///</summary>
        public static Engine Activate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Activate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an object representing the result of active classification obtained by using the function f to determine classes for the example configurations confi.
        ///https://reference.wolfram.com/language/ref/ActiveClassification.html
        ///</summary>
        public static Engine ActiveClassification(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ActiveClassification[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates configurations within the region specified by reg.
        ///https://reference.wolfram.com/language/ref/ActiveClassification.html
        ///</summary>
        public static Engine ActiveClassification(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ActiveClassification[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the result of an ActiveClassification process.
        ///https://reference.wolfram.com/language/ref/ActiveClassificationObject.html
        ///</summary>
        public static Engine ActiveClassificationObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ActiveClassificationObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an object representing the result of active prediction obtained by using the function f to determine values for the example configurations confi.
        ///https://reference.wolfram.com/language/ref/ActivePrediction.html
        ///</summary>
        public static Engine ActivePrediction(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ActivePrediction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates configurations within the region specified by reg.
        ///https://reference.wolfram.com/language/ref/ActivePrediction.html
        ///</summary>
        public static Engine ActivePrediction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ActivePrediction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the result of an ActivePrediction process.
        ///https://reference.wolfram.com/language/ref/ActivePredictionObject.html
        ///</summary>
        public static Engine ActivePredictionObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ActivePredictionObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is an acyclic graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/AcyclicGraphQ.html
        ///</summary>
        public static Engine AcyclicGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AcyclicGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///adds x to each side of the equation or inequality rel.
        ///https://reference.wolfram.com/language/ref/AddSides.html
        ///</summary>
        public static Engine AddSides(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AddSides[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds the specified content to the existing search index object obj.
        ///https://reference.wolfram.com/language/ref/AddToSearchIndex.html
        ///</summary>
        public static Engine AddToSearchIndex(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AddToSearchIndex[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds all the contenti to obj.
        ///https://reference.wolfram.com/language/ref/AddToSearchIndex.html
        ///</summary>
        public static Engine AddToSearchIndex(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AddToSearchIndex[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///adds the users useri to the permissions group group.
        ///https://reference.wolfram.com/language/ref/AddUsers.html
        ///</summary>
        public static Engine AddUsers(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AddUsers[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the graph with adjacency matrix amat.
        ///https://reference.wolfram.com/language/ref/AdjacencyGraph.html
        ///</summary>
        public static Engine AdjacencyGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AdjacencyGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the graph with vertices vi and adjacency matrix amat.
        ///https://reference.wolfram.com/language/ref/AdjacencyGraph.html
        ///</summary>
        public static Engine AdjacencyGraph(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AdjacencyGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of vertices adjacent to vertex v.
        ///https://reference.wolfram.com/language/ref/AdjacencyList.html
        ///</summary>
        public static Engine AdjacencyList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AdjacencyList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of vertices that are at distance at most d.
        ///https://reference.wolfram.com/language/ref/AdjacencyList.html
        ///</summary>
        public static Engine AdjacencyList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AdjacencyList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/AdjacencyList.html
        ///</summary>
        public static Engine AdjacencyList(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AdjacencyList[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the vertex–vertex adjacency matrix of the graph g.
        ///https://reference.wolfram.com/language/ref/AdjacencyMatrix.html
        ///</summary>
        public static Engine AdjacencyMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AdjacencyMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/AdjacencyMatrix.html
        ///</summary>
        public static Engine AdjacencyMatrix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AdjacencyMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives cells of dimension d adjacent to the cell specified by cellspec in the mesh mr.
        ///https://reference.wolfram.com/language/ref/AdjacentMeshCells.html
        ///</summary>
        public static Engine AdjacentMeshCells(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AdjacentMeshCells[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the adjugate of a square matrix m.
        ///https://reference.wolfram.com/language/ref/Adjugate.html
        ///</summary>
        public static Engine Adjugate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Adjugate[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct which displays with the placement of box adjusted using the options given.
        ///https://reference.wolfram.com/language/ref/AdjustmentBox.html
        ///</summary>
        public static Engine AdjustmentBox(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AdjustmentBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adjusts forecast using new observations newdata according to the time series model tproc.
        ///https://reference.wolfram.com/language/ref/AdjustTimeSeriesForecast.html
        ///</summary>
        public static Engine AdjustTimeSeriesForecast(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AdjustTimeSeriesForecast[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the administrative division entity.
        ///https://reference.wolfram.com/language/ref/AdministrativeDivisionData.html
        ///</summary>
        public static Engine AdministrativeDivisionData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AdministrativeDivisionData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified administrative division names.
        ///https://reference.wolfram.com/language/ref/AdministrativeDivisionData.html
        ///</summary>
        public static Engine AdministrativeDivisionData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AdministrativeDivisionData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/AdministrativeDivisionData.html
        ///</summary>
        public static Engine AdministrativeDivisionData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AdministrativeDivisionData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents AffineSpace[{p1,…,pk+1}] extended in the direction w.
        ///https://reference.wolfram.com/language/ref/AffineHalfSpace.html
        ///</summary>
        public static Engine AffineHalfSpace(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AffineHalfSpace[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents AffineSpace[p,{v1,…,vk}] extended in the direction w.
        ///https://reference.wolfram.com/language/ref/AffineHalfSpace.html
        ///</summary>
        public static Engine AffineHalfSpace(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("AffineHalfSpace[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the affine space passing through the points pi.
        ///https://reference.wolfram.com/language/ref/AffineSpace.html
        ///</summary>
        public static Engine AffineSpace(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AffineSpace[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the affine space passing through p in the directions vi.
        ///https://reference.wolfram.com/language/ref/AffineSpace.html
        ///</summary>
        public static Engine AffineSpace(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AffineSpace[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents the affine state-space model , .
        ///https://reference.wolfram.com/language/ref/AffineStateSpaceModel.html
        ///</summary>
        public static Engine AffineStateSpaceModel(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AffineStateSpaceModel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an affine state-space model corresponding to the system model sys.
        ///https://reference.wolfram.com/language/ref/AffineStateSpaceModel.html
        ///</summary>
        public static Engine AffineStateSpaceModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AffineStateSpaceModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the affine state-space model obtained by Taylor input linearization about the dependent variable xi at xi0 and input uj at uj0 of the differential equations eqns with outputs gi and independent variable t.
        ///https://reference.wolfram.com/language/ref/AffineStateSpaceModel.html
        ///</summary>
        public static Engine AffineStateSpaceModel(this Engine en, object arg0, List<object> arg1, List<object> arg2, List<object> arg3, object arg4, string? name = null)
        {
            return en.Execute("AffineStateSpaceModel[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents an affine transform that maps r to m.r.
        ///https://reference.wolfram.com/language/ref/AffineTransform.html
        ///</summary>
        public static Engine AffineTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AffineTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an affine transform that maps r to m.r+v.
        ///https://reference.wolfram.com/language/ref/AffineTransform.html
        ///</summary>
        public static Engine AffineTransform(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AffineTransform[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents an entity class containing a single entity with the property prop whose value is the result of applying the function f to the whole specified entity class.
        ///https://reference.wolfram.com/language/ref/AggregatedEntityClass.html
        ///</summary>
        public static Engine AggregatedEntityClass(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AggregatedEntityClass[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs multiple properties propi obtained by applying fi to class.
        ///https://reference.wolfram.com/language/ref/AggregatedEntityClass.html
        ///</summary>
        public static Engine AggregatedEntityClass(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AggregatedEntityClass[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///forms groups of elements of class according to their values of the property gprop, then generates an entity class with an entity for each of these groups.
        ///https://reference.wolfram.com/language/ref/AggregatedEntityClass.html
        ///</summary>
        public static Engine AggregatedEntityClass(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AggregatedEntityClass[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///forms groups for which the set of values defined by the gspeci is distinct.
        ///https://reference.wolfram.com/language/ref/AggregatedEntityClass.html
        ///</summary>
        public static Engine AggregatedEntityClass(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AggregatedEntityClass[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents a layer that aggregates an array of arbitrary rank into a vector, using the function f.
        ///https://reference.wolfram.com/language/ref/AggregationLayer.html
        ///</summary>
        public static Engine AggregationLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AggregationLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///aggregates an array at level n.
        ///https://reference.wolfram.com/language/ref/AggregationLayer.html
        ///</summary>
        public static Engine AggregationLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AggregationLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///aggregates an array at levels n1,n2,….
        ///https://reference.wolfram.com/language/ref/AggregationLayer.html
        ///</summary>
        public static Engine AggregationLayer(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AggregationLayer[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the aircraft entity.
        ///https://reference.wolfram.com/language/ref/AircraftData.html
        ///</summary>
        public static Engine AircraftData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AircraftData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified aircraft entities.
        ///https://reference.wolfram.com/language/ref/AircraftData.html
        ///</summary>
        public static Engine AircraftData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AircraftData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/AircraftData.html
        ///</summary>
        public static Engine AircraftData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AircraftData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the airport entity.
        ///https://reference.wolfram.com/language/ref/AirportData.html
        ///</summary>
        public static Engine AirportData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AirportData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified airport entities.
        ///https://reference.wolfram.com/language/ref/AirportData.html
        ///</summary>
        public static Engine AirportData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AirportData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/AirportData.html
        ///</summary>
        public static Engine AirportData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AirportData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the most recent measurement for air pressure near the current location.
        ///https://reference.wolfram.com/language/ref/AirPressureData.html
        ///</summary>
        public static Engine AirPressureData(this Engine en, string? name = null)
        {
            return en.Execute("AirPressureData[]", name);
        }

        ///<summary>
        ///gives the air pressure value for the specified time near the current location.
        ///https://reference.wolfram.com/language/ref/AirPressureData.html
        ///</summary>
        public static Engine AirPressureData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AirPressureData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value or values for the specified date and location.
        ///https://reference.wolfram.com/language/ref/AirPressureData.html
        ///</summary>
        public static Engine AirPressureData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AirPressureData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives values for all specified locations on the specified dates.
        ///https://reference.wolfram.com/language/ref/AirPressureData.html
        ///</summary>
        public static Engine AirPressureData(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AirPressureData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the sound attenuation coefficient in moist air for the specified parameters spec for frequency.
        ///https://reference.wolfram.com/language/ref/AirSoundAttenuation.html
        ///</summary>
        public static Engine AirSoundAttenuation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AirSoundAttenuation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the sound attenuation factor for the specified parameters at distance.
        ///https://reference.wolfram.com/language/ref/AirSoundAttenuation.html
        ///</summary>
        public static Engine AirSoundAttenuation(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AirSoundAttenuation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the sound level at distance given the source sound level sl.
        ///https://reference.wolfram.com/language/ref/AirSoundAttenuation.html
        ///</summary>
        public static Engine AirSoundAttenuation(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AirSoundAttenuation[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the most recent measurement for air temperature near the current location.
        ///https://reference.wolfram.com/language/ref/AirTemperatureData.html
        ///</summary>
        public static Engine AirTemperatureData(this Engine en, string? name = null)
        {
            return en.Execute("AirTemperatureData[]", name);
        }

        ///<summary>
        ///gives the air temperature value for the specified time near the current location.
        ///https://reference.wolfram.com/language/ref/AirTemperatureData.html
        ///</summary>
        public static Engine AirTemperatureData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AirTemperatureData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value or values for the specified date and location.
        ///https://reference.wolfram.com/language/ref/AirTemperatureData.html
        ///</summary>
        public static Engine AirTemperatureData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AirTemperatureData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives values for all specified locations on the specified dates.
        ///https://reference.wolfram.com/language/ref/AirTemperatureData.html
        ///</summary>
        public static Engine AirTemperatureData(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AirTemperatureData[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Airy function .
        ///https://reference.wolfram.com/language/ref/AiryAi.html
        ///</summary>
        public static Engine AiryAi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AiryAi[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Airy function .
        ///https://reference.wolfram.com/language/ref/AiryAiPrime.html
        ///</summary>
        public static Engine AiryAiPrime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AiryAiPrime[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the k zero of the Airy function .
        ///https://reference.wolfram.com/language/ref/AiryAiZero.html
        ///</summary>
        public static Engine AiryAiZero(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AiryAiZero[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the k zero less than x0.
        ///https://reference.wolfram.com/language/ref/AiryAiZero.html
        ///</summary>
        public static Engine AiryAiZero(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AiryAiZero[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Airy function .
        ///https://reference.wolfram.com/language/ref/AiryBi.html
        ///</summary>
        public static Engine AiryBi(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AiryBi[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Airy function .
        ///https://reference.wolfram.com/language/ref/AiryBiPrime.html
        ///</summary>
        public static Engine AiryBiPrime(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AiryBiPrime[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the k zero of the Airy function .
        ///https://reference.wolfram.com/language/ref/AiryBiZero.html
        ///</summary>
        public static Engine AiryBiZero(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AiryBiZero[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the k zero less than x0.
        ///https://reference.wolfram.com/language/ref/AiryBiZero.html
        ///</summary>
        public static Engine AiryBiZero(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AiryBiZero[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if a is an algebraic integer, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/AlgebraicIntegerQ.html
        ///</summary>
        public static Engine AlgebraicIntegerQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlgebraicIntegerQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the algebraic number in the field  given by .
        ///https://reference.wolfram.com/language/ref/AlgebraicNumber.html
        ///</summary>
        public static Engine AlgebraicNumber(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AlgebraicNumber[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the smallest positive integer n such that n a is an algebraic integer.
        ///https://reference.wolfram.com/language/ref/AlgebraicNumberDenominator.html
        ///</summary>
        public static Engine AlgebraicNumberDenominator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlgebraicNumberDenominator[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the norm of the algebraic number a.
        ///https://reference.wolfram.com/language/ref/AlgebraicNumberNorm.html
        ///</summary>
        public static Engine AlgebraicNumberNorm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlgebraicNumberNorm[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the polynomial in x corresponding to the AlgebraicNumber object a.
        ///https://reference.wolfram.com/language/ref/AlgebraicNumberPolynomial.html
        ///</summary>
        public static Engine AlgebraicNumberPolynomial(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AlgebraicNumberPolynomial[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the trace of the algebraic number a.
        ///https://reference.wolfram.com/language/ref/AlgebraicNumberTrace.html
        ///</summary>
        public static Engine AlgebraicNumberTrace(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlgebraicNumberTrace[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if a is an algebraic unit, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/AlgebraicUnitQ.html
        ///</summary>
        public static Engine AlgebraicUnitQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlgebraicUnitQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if test[ei] is True for all of the ei.
        ///https://reference.wolfram.com/language/ref/AllTrue.html
        ///</summary>
        public static Engine AllTrue(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AllTrue[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests parts of expr at level level.
        ///https://reference.wolfram.com/language/ref/AllTrue.html
        ///</summary>
        public static Engine AllTrue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AllTrue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of AllTrue that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/AllTrue.html
        ///</summary>
        public static Engine AllTrue(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AllTrue[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the lowercase letters a through z in the English alphabet.
        ///https://reference.wolfram.com/language/ref/Alphabet.html
        ///</summary>
        public static Engine Alphabet(this Engine en, string? name = null)
        {
            return en.Execute("Alphabet[]", name);
        }

        ///<summary>
        ///gives the alphabet for the language or class type.
        ///https://reference.wolfram.com/language/ref/Alphabet.html
        ///</summary>
        public static Engine Alphabet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Alphabet[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the alphabet defined by prop for the language or class type .
        ///https://reference.wolfram.com/language/ref/Alphabet.html
        ///</summary>
        public static Engine Alphabet(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Alphabet[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives 1 if "string1" appears before "string2" in alphabetical order, -1 if it is after, and 0 if it is identical.
        ///https://reference.wolfram.com/language/ref/AlphabeticOrder.html
        ///</summary>
        public static Engine AlphabeticOrder(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AlphabeticOrder[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses an ordering suitable for the language lang.
        ///https://reference.wolfram.com/language/ref/AlphabeticOrder.html
        ///</summary>
        public static Engine AlphabeticOrder(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AlphabeticOrder[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form that compares strings when applied to "string1", "string2".
        ///https://reference.wolfram.com/language/ref/AlphabeticOrder.html
        ///</summary>
        public static Engine AlphabeticOrder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlphabeticOrder[" + arg0 + "]", name);
        }

        ///<summary>
        ///sorts the elements of list into alphabetical order.
        ///https://reference.wolfram.com/language/ref/AlphabeticSort.html
        ///</summary>
        public static Engine AlphabeticSort(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlphabeticSort[" + arg0 + "]", name);
        }

        ///<summary>
        ///sorts using an ordering suitable for the language lang.
        ///https://reference.wolfram.com/language/ref/AlphabeticSort.html
        ///</summary>
        public static Engine AlphabeticSort(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AlphabeticSort[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the opacity of color.
        ///https://reference.wolfram.com/language/ref/AlphaChannel.html
        ///</summary>
        public static Engine AlphaChannel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlphaChannel[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the alternating factorial .
        ///https://reference.wolfram.com/language/ref/AlternatingFactorial.html
        ///</summary>
        public static Engine AlternatingFactorial(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlternatingFactorial[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the alternating group of degree n.
        ///https://reference.wolfram.com/language/ref/AlternatingGroup.html
        ///</summary>
        public static Engine AlternatingGroup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AlternatingGroup[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive that specifies the uniform ambient light of color col to use in coloring 3D surfaces.
        ///https://reference.wolfram.com/language/ref/AmbientLight.html
        ///</summary>
        public static Engine AmbientLight(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AmbientLight[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents possible results derived from an ambiguous semantic interpretation.
        ///https://reference.wolfram.com/language/ref/AmbiguityList.html
        ///</summary>
        public static Engine AmbiguityList(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AmbiguityList[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents possible results from semantic interpretation of an input string.
        ///https://reference.wolfram.com/language/ref/AmbiguityList.html
        ///</summary>
        public static Engine AmbiguityList(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AmbiguityList[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///includes a sequence of associations giving details of the interpretations used to obtain the expri.
        ///https://reference.wolfram.com/language/ref/AmbiguityList.html
        ///</summary>
        public static Engine AmbiguityList(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AmbiguityList[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the anatomical structure entity.
        ///https://reference.wolfram.com/language/ref/AnatomyData.html
        ///</summary>
        public static Engine AnatomyData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AnatomyData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified anatomical structure entities.
        ///https://reference.wolfram.com/language/ref/AnatomyData.html
        ///</summary>
        public static Engine AnatomyData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AnatomyData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/AnatomyData.html
        ///</summary>
        public static Engine AnatomyData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AnatomyData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a three-dimensional graphical image that works with anatomical entities as well as standard 3D graphics primitives and directives.
        ///https://reference.wolfram.com/language/ref/AnatomyPlot3D.html
        ///</summary>
        public static Engine AnatomyPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AnatomyPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a graphics directive used in AnatomyPlot3D that specifies how anatomy entity‐based graphics objects are to be drawn using the graphics directive or association of directives g.
        ///https://reference.wolfram.com/language/ref/AnatomyStyling.html
        ///</summary>
        public static Engine AnatomyStyling(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AnatomyStyling[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Anderson–Darling test.
        ///https://reference.wolfram.com/language/ref/AndersonDarlingTest.html
        ///</summary>
        public static Engine AndersonDarlingTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AndersonDarlingTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is distributed according to dist using the Anderson–Darling test.
        ///https://reference.wolfram.com/language/ref/AndersonDarlingTest.html
        ///</summary>
        public static Engine AndersonDarlingTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AndersonDarlingTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/AndersonDarlingTest.html
        ///</summary>
        public static Engine AndersonDarlingTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AndersonDarlingTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Anger function .
        ///https://reference.wolfram.com/language/ref/AngerJ.html
        ///</summary>
        public static Engine AngerJ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AngerJ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the associated Anger function .
        ///https://reference.wolfram.com/language/ref/AngerJ.html
        ///</summary>
        public static Engine AngerJ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AngerJ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the bisector of the interior angle at p formed by the triangle with vertex points p, q1 and q2.
        ///https://reference.wolfram.com/language/ref/AngleBisector.html
        ///</summary>
        public static Engine AngleBisector(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AngleBisector[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the angle bisector of the specified type.
        ///https://reference.wolfram.com/language/ref/AngleBisector.html
        ///</summary>
        public static Engine AngleBisector(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AngleBisector[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/AngleBracket.html
        ///</summary>
        public static Engine AngleBracket(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AngleBracket[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list of 2D coordinates corresponding to a path that starts at {0,0}, then takes a series of steps of unit length at successive relative angles θi.
        ///https://reference.wolfram.com/language/ref/AnglePath.html
        ///</summary>
        public static Engine AnglePath(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AnglePath[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///takes successive steps of lengths ri.
        ///https://reference.wolfram.com/language/ref/AnglePath.html
        ///</summary>
        public static Engine AnglePath(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AnglePath[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///starts at angle θ0 with respect to the  axis.
        ///https://reference.wolfram.com/language/ref/AnglePath.html
        ///</summary>
        public static Engine AnglePath(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AnglePath[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///starts at the point {x,y} with initial angle 0 with respect to the  axis.
        ///https://reference.wolfram.com/language/ref/AnglePath.html
        ///</summary>
        public static Engine AnglePath(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AnglePath[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns at each step the data of the form specified by form.
        ///https://reference.wolfram.com/language/ref/AnglePath.html
        ///</summary>
        public static Engine AnglePath(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AnglePath[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list of 3D coordinates of a path of an object that starts at {0,0,0}, then takes a series of steps of unit length, each in the direction of the  axis obtained after successive rotation of the object by the Euler angles αi, βi, γi.
        ///https://reference.wolfram.com/language/ref/AnglePath3D.html
        ///</summary>
        public static Engine AnglePath3D(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AnglePath3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///takes the successive rotations to be specified by the 3D rotation matrices mati.
        ///https://reference.wolfram.com/language/ref/AnglePath3D.html
        ///</summary>
        public static Engine AnglePath3D(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AnglePath3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///starts at the point {x0,y0,z0}.
        ///https://reference.wolfram.com/language/ref/AnglePath3D.html
        ///</summary>
        public static Engine AnglePath3D(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AnglePath3D[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns at each step the data of the form specified by form.
        ///https://reference.wolfram.com/language/ref/AnglePath3D.html
        ///</summary>
        public static Engine AnglePath3D(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AnglePath3D[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the list representing the 2D unit vector at angle θ relative to the  axis.
        ///https://reference.wolfram.com/language/ref/AngleVector.html
        ///</summary>
        public static Engine AngleVector(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AngleVector[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list representing the 2D vector of length r at angle θ.
        ///https://reference.wolfram.com/language/ref/AngleVector.html
        ///</summary>
        public static Engine AngleVector(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AngleVector[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the result of starting from the point {x,y}, then going a unit distance at angle θ.
        ///https://reference.wolfram.com/language/ref/AngleVector.html
        ///</summary>
        public static Engine AngleVector(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AngleVector[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the result of starting from the point {x,y}, then going distance r at angle θ.
        ///https://reference.wolfram.com/language/ref/AngleVector.html
        ///</summary>
        public static Engine AngleVector(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AngleVector[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///draws a gauge showing value in the range 0 to 1.
        ///https://reference.wolfram.com/language/ref/AngularGauge.html
        ///</summary>
        public static Engine AngularGauge(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AngularGauge[" + arg0 + "]", name);
        }

        ///<summary>
        ///draws a gauge showing value in a range of min to max.
        ///https://reference.wolfram.com/language/ref/AngularGauge.html
        ///</summary>
        public static Engine AngularGauge(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AngularGauge[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///allows value to be set interactively using the gauge.
        ///https://reference.wolfram.com/language/ref/AngularGauge.html
        ///</summary>
        public static Engine AngularGauge(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AngularGauge[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///draws a gauge showing multiple values.
        ///https://reference.wolfram.com/language/ref/AngularGauge.html
        ///</summary>
        public static Engine AngularGauge(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AngularGauge[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates an animation of expr in which u varies continuously from umin to umax.
        ///https://reference.wolfram.com/language/ref/Animate.html
        ///</summary>
        public static Engine Animate(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Animate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes u take on discrete values u1, u2, ….
        ///https://reference.wolfram.com/language/ref/Animate.html
        ///</summary>
        public static Engine Animate(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Animate[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///varies all the variables u, v, ….
        ///https://reference.wolfram.com/language/ref/Animate.html
        ///</summary>
        public static Engine Animate(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("Animate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///generates an animation whose frames are the successive imagei.
        ///https://reference.wolfram.com/language/ref/AnimatedImage.html
        ///</summary>
        public static Engine AnimatedImage(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AnimatedImage[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents an animated image from file.
        ///https://reference.wolfram.com/language/ref/AnimatedImage.html
        ///</summary>
        public static Engine AnimatedImage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AnimatedImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a video of fexpr in which u varies from umin to umax.
        ///https://reference.wolfram.com/language/ref/AnimationVideo.html
        ///</summary>
        public static Engine AnimationVideo(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AnimationVideo[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes u take on values u1, u2, ….
        ///https://reference.wolfram.com/language/ref/AnimationVideo.html
        ///</summary>
        public static Engine AnimationVideo(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AnimationVideo[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents an object that displays with the value of u being continually increased from 0 to 1 with time.
        ///https://reference.wolfram.com/language/ref/Animator.html
        ///</summary>
        public static Engine Animator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Animator[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes u vary from umin to umax.
        ///https://reference.wolfram.com/language/ref/Animator.html
        ///</summary>
        public static Engine Animator(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Animator[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes the value of u increase at a rate of ups units per second.
        ///https://reference.wolfram.com/language/ref/Animator.html
        ///</summary>
        public static Engine Animator(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Animator[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///sets the annotation keyvalue for the object obj.
        ///https://reference.wolfram.com/language/ref/Annotate.html
        ///</summary>
        public static Engine Annotate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Annotate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets the annotation for the items in obj specified by itemspec.
        ///https://reference.wolfram.com/language/ref/Annotate.html
        ///</summary>
        public static Engine Annotate(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Annotate[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an expression expr, with annotation data.
        ///https://reference.wolfram.com/language/ref/Annotation.html
        ///</summary>
        public static Engine Annotation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Annotation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies the type of annotation being given.
        ///https://reference.wolfram.com/language/ref/Annotation.html
        ///</summary>
        public static Engine Annotation(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Annotation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///deletes all annotations of the object obj.
        ///https://reference.wolfram.com/language/ref/AnnotationDelete.html
        ///</summary>
        public static Engine AnnotationDelete(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AnnotationDelete[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes all annotations of the items of obj specified by itemspec.
        ///https://reference.wolfram.com/language/ref/AnnotationDelete.html
        ///</summary>
        public static Engine AnnotationDelete(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AnnotationDelete[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///deletes the annotation key specified by spec.
        ///https://reference.wolfram.com/language/ref/AnnotationDelete.html
        ///</summary>
        public static Engine AnnotationDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AnnotationDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///lists all annotation keys available for the object obj.
        ///https://reference.wolfram.com/language/ref/AnnotationKeys.html
        ///</summary>
        public static Engine AnnotationKeys(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AnnotationKeys[" + arg0 + "]", name);
        }

        ///<summary>
        ///lists all annotation keys available for the items specified by itemspec in obj.
        ///https://reference.wolfram.com/language/ref/AnnotationKeys.html
        ///</summary>
        public static Engine AnnotationKeys(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AnnotationKeys[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the annotation value associated with key for the object obj.
        ///https://reference.wolfram.com/language/ref/AnnotationValue.html
        ///</summary>
        public static Engine AnnotationValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AnnotationValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the annotation value associated with key for items specified by itemspec in obj.
        ///https://reference.wolfram.com/language/ref/AnnotationValue.html
        ///</summary>
        public static Engine AnnotationValue(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AnnotationValue[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an annuity of fixed payments p made over t periods.
        ///https://reference.wolfram.com/language/ref/Annuity.html
        ///</summary>
        public static Engine Annuity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Annuity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a series of payments occurring at time intervals q.
        ///https://reference.wolfram.com/language/ref/Annuity.html
        ///</summary>
        public static Engine Annuity(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Annuity[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an annuity with the specified initial and final payments.
        ///https://reference.wolfram.com/language/ref/Annuity.html
        ///</summary>
        public static Engine Annuity(this Engine en, object arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Annuity[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an annuity due of fixed payments p made over t periods.
        ///https://reference.wolfram.com/language/ref/AnnuityDue.html
        ///</summary>
        public static Engine AnnuityDue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AnnuityDue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a series of payments occurring at time intervals q.
        ///https://reference.wolfram.com/language/ref/AnnuityDue.html
        ///</summary>
        public static Engine AnnuityDue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AnnuityDue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an annuity due with the specified initial and final payments.
        ///https://reference.wolfram.com/language/ref/AnnuityDue.html
        ///</summary>
        public static Engine AnnuityDue(this Engine en, object arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AnnuityDue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an annulus centered at {x,y} with inner radius rinner and outer radius router.
        ///https://reference.wolfram.com/language/ref/Annulus.html
        ///</summary>
        public static Engine Annulus(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Annulus[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an annulus from angle θ1 to θ2.
        ///https://reference.wolfram.com/language/ref/Annulus.html
        ///</summary>
        public static Engine Annulus(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Annulus[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates an AnomalyDetectorFunction[…] based on the examples given.
        ///https://reference.wolfram.com/language/ref/AnomalyDetection.html
        ///</summary>
        public static Engine AnomalyDetection(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AnomalyDetection[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates an anomaly detector based on the given distribution.
        ///https://reference.wolfram.com/language/ref/AnomalyDetection.html
        ///</summary>
        public static Engine AnomalyDetection(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AnomalyDetection[" + arg0 + "]", name);
        }

        ///<summary>
        ///can be used to indicate which examples should be considered anomalous.
        ///https://reference.wolfram.com/language/ref/AnomalyDetection.html
        ///</summary>
        public static Engine AnomalyDetection(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AnomalyDetection[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a function generated by AnomalyDetection for detecting whether data is anomalous or not.
        ///https://reference.wolfram.com/language/ref/AnomalyDetectorFunction.html
        ///</summary>
        public static Engine AnomalyDetectorFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AnomalyDetectorFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the symmetry of an antihermitian matrix.
        ///https://reference.wolfram.com/language/ref/Antihermitian.html
        ///</summary>
        public static Engine Antihermitian(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Antihermitian[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly antihermitian, and False otherwise.
        ///https://reference.wolfram.com/language/ref/AntihermitianMatrixQ.html
        ///</summary>
        public static Engine AntihermitianMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AntihermitianMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the symmetry of a tensor that is antisymmetric in the slots si.
        ///https://reference.wolfram.com/language/ref/Antisymmetric.html
        ///</summary>
        public static Engine Antisymmetric(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Antisymmetric[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly antisymmetric, and False otherwise.
        ///https://reference.wolfram.com/language/ref/AntisymmetricMatrixQ.html
        ///</summary>
        public static Engine AntisymmetricMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AntisymmetricMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the antonyms associated with the specified word.
        ///https://reference.wolfram.com/language/ref/Antonyms.html
        ///</summary>
        public static Engine Antonyms(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Antonyms[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a grammar rules pattern object that represents a sequence of elements matching p1, p2, … in any order.
        ///https://reference.wolfram.com/language/ref/AnyOrder.html
        ///</summary>
        public static Engine AnyOrder(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AnyOrder[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an element in an interpreter or form that accepts any subset of the choices ci.
        ///https://reference.wolfram.com/language/ref/AnySubset.html
        ///</summary>
        public static Engine AnySubset(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AnySubset[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///accepts any subset of the entities in the specified entity class.
        ///https://reference.wolfram.com/language/ref/AnySubset.html
        ///</summary>
        public static Engine AnySubset(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AnySubset[" + arg0 + "]", name);
        }

        ///<summary>
        ///allows at most max choices to be selected.
        ///https://reference.wolfram.com/language/ref/AnySubset.html
        ///</summary>
        public static Engine AnySubset(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AnySubset[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///allows at least min and at most max choices to be selected.
        ///https://reference.wolfram.com/language/ref/AnySubset.html
        ///</summary>
        public static Engine AnySubset(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AnySubset[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if test[ei] is True for any of the ei.
        ///https://reference.wolfram.com/language/ref/AnyTrue.html
        ///</summary>
        public static Engine AnyTrue(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AnyTrue[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests parts of expr at level level.
        ///https://reference.wolfram.com/language/ref/AnyTrue.html
        ///</summary>
        public static Engine AnyTrue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AnyTrue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of AnyTrue that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/AnyTrue.html
        ///</summary>
        public static Engine AnyTrue(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AnyTrue[" + arg0 + "]", name);
        }

        ///<summary>
        ///rewrites a rational expression as a sum of terms with minimal denominators.
        ///https://reference.wolfram.com/language/ref/Apart.html
        ///</summary>
        public static Engine Apart(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Apart[" + arg0 + "]", name);
        }

        ///<summary>
        ///treats all variables other than var as constants.
        ///https://reference.wolfram.com/language/ref/Apart.html
        ///</summary>
        public static Engine Apart(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Apart[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///rewrites a rational expression as a sum of terms whose denominators are powers of square-free polynomials.
        ///https://reference.wolfram.com/language/ref/ApartSquareFree.html
        ///</summary>
        public static Engine ApartSquareFree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ApartSquareFree[" + arg0 + "]", name);
        }

        ///<summary>
        ///treats all variables other than var as constants.
        ///https://reference.wolfram.com/language/ref/ApartSquareFree.html
        ///</summary>
        public static Engine ApartSquareFree(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ApartSquareFree[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an API with parameters namei that evaluates the function fun whenever it is called. The function fun is applied to "name1"val1,"name2"val2,…, where the vali are the settings for the parameters, interpreted as being of types typei.
        ///https://reference.wolfram.com/language/ref/APIFunction.html
        ///</summary>
        public static Engine APIFunction(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("APIFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that the result from applying fun should be returned in format fmt.
        ///https://reference.wolfram.com/language/ref/APIFunction.html
        ///</summary>
        public static Engine APIFunction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("APIFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies that the result should be returned as a response of the form rform.
        ///https://reference.wolfram.com/language/ref/APIFunction.html
        ///</summary>
        public static Engine APIFunction(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("APIFunction[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///is the Appell hypergeometric function of two variables .
        ///https://reference.wolfram.com/language/ref/AppellF1.html
        ///</summary>
        public static Engine AppellF1(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, string? name = null)
        {
            return en.Execute("AppellF1[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
        }

        ///<summary>
        ///gives expr with elem appended.
        ///https://reference.wolfram.com/language/ref/Append.html
        ///</summary>
        public static Engine Append(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Append[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of Append that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Append.html
        ///</summary>
        public static Engine Append(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Append[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a net layer that takes an input array and appends another array to it.
        ///https://reference.wolfram.com/language/ref/AppendLayer.html
        ///</summary>
        public static Engine AppendLayer(this Engine en, string? name = null)
        {
            return en.Execute("AppendLayer[]", name);
        }

        ///<summary>
        ///appends elem to the value of x, and resets x to the result.
        ///https://reference.wolfram.com/language/ref/AppendTo.html
        ///</summary>
        public static Engine AppendTo(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AppendTo[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the formal application of f to g.
        ///https://reference.wolfram.com/language/ref/Application.html
        ///</summary>
        public static Engine Application(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Application[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces the head of expr by f.
        ///https://reference.wolfram.com/language/ref/Apply.html
        ///</summary>
        public static Engine Apply(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Apply[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces heads in parts of expr specified by levelspec.
        ///https://reference.wolfram.com/language/ref/Apply.html
        ///</summary>
        public static Engine Apply(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Apply[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of Apply that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Apply.html
        ///</summary>
        public static Engine Apply(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Apply[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies the pattern reaction rxn to the list of molecules mols, returning a single list of products.
        ///https://reference.wolfram.com/language/ref/ApplyReaction.html
        ///</summary>
        public static Engine ApplyReaction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ApplyReaction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns up to n lists of products.
        ///https://reference.wolfram.com/language/ref/ApplyReaction.html
        ///</summary>
        public static Engine ApplyReaction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ApplyReaction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a single set of products, using mapi to map the atoms in the i molecule to the i reactant.
        ///https://reference.wolfram.com/language/ref/ApplyReaction.html
        ///</summary>
        public static Engine ApplyReaction(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ApplyReaction[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of ApplyReaction that can be applied to a list of molecules.
        ///https://reference.wolfram.com/language/ref/ApplyReaction.html
        ///</summary>
        public static Engine ApplyReaction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ApplyReaction[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies f to each side of the equation or inequality rel.
        ///https://reference.wolfram.com/language/ref/ApplySides.html
        ///</summary>
        public static Engine ApplySides(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ApplySides[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the arc cosine  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcCos.html
        ///</summary>
        public static Engine ArcCos(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcCos[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the inverse hyperbolic cosine  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcCosh.html
        ///</summary>
        public static Engine ArcCosh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcCosh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the arc cotangent  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcCot.html
        ///</summary>
        public static Engine ArcCot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcCot[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the inverse hyperbolic cotangent  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcCoth.html
        ///</summary>
        public static Engine ArcCoth(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcCoth[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the arc cosecant  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcCsc.html
        ///</summary>
        public static Engine ArcCsc(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcCsc[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the inverse hyperbolic cosecant  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcCsch.html
        ///</summary>
        public static Engine ArcCsch(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcCsch[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the curvature of the parametrized curve whose Cartesian coordinates xi are functions of t.
        ///https://reference.wolfram.com/language/ref/ArcCurvature.html
        ///</summary>
        public static Engine ArcCurvature(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ArcCurvature[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///interprets the xi as coordinates in the specified coordinate chart.
        ///https://reference.wolfram.com/language/ref/ArcCurvature.html
        ///</summary>
        public static Engine ArcCurvature(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArcCurvature[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an autoregressive conditionally heteroscedastic process of order q, driven by a standard white noise.
        ///https://reference.wolfram.com/language/ref/ARCHProcess.html
        ///</summary>
        public static Engine ARCHProcess(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ARCHProcess[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an ARCH process with initial data init.
        ///https://reference.wolfram.com/language/ref/ARCHProcess.html
        ///</summary>
        public static Engine ARCHProcess(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ARCHProcess[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the length of the one-dimensional region reg.
        ///https://reference.wolfram.com/language/ref/ArcLength.html
        ///</summary>
        public static Engine ArcLength(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcLength[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the length of the parametrized curve whose Cartesian coordinates xi are functions of t.
        ///https://reference.wolfram.com/language/ref/ArcLength.html
        ///</summary>
        public static Engine ArcLength(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ArcLength[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///interprets the xi as coordinates in the specified coordinate chart.
        ///https://reference.wolfram.com/language/ref/ArcLength.html
        ///</summary>
        public static Engine ArcLength(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ArcLength[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the arc secant  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcSec.html
        ///</summary>
        public static Engine ArcSec(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcSec[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the inverse hyperbolic secant  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcSech.html
        ///</summary>
        public static Engine ArcSech(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcSech[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the arc sine  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcSin.html
        ///</summary>
        public static Engine ArcSin(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcSin[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the arc sine distribution supported between xmin and xmax.
        ///https://reference.wolfram.com/language/ref/ArcSinDistribution.html
        ///</summary>
        public static Engine ArcSinDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("ArcSinDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the arc sine distribution supported between zero and one.
        ///https://reference.wolfram.com/language/ref/ArcSinDistribution.html
        ///</summary>
        public static Engine ArcSinDistribution(this Engine en, string? name = null)
        {
            return en.Execute("ArcSinDistribution[]", name);
        }

        ///<summary>
        ///gives the inverse hyperbolic sine  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcSinh.html
        ///</summary>
        public static Engine ArcSinh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcSinh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the arc tangent  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcTan.html
        ///</summary>
        public static Engine ArcTan(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcTan[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the arc tangent of , taking into account which quadrant the point  is in.
        ///https://reference.wolfram.com/language/ref/ArcTan.html
        ///</summary>
        public static Engine ArcTan(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArcTan[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the inverse hyperbolic tangent  of the complex number .
        ///https://reference.wolfram.com/language/ref/ArcTanh.html
        ///</summary>
        public static Engine ArcTanh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArcTanh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the area of the two-dimensional region reg.
        ///https://reference.wolfram.com/language/ref/Area.html
        ///</summary>
        public static Engine Area(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Area[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the area of the parametrized surface whose Cartesian coordinates xi are functions of s and t.
        ///https://reference.wolfram.com/language/ref/Area.html
        ///</summary>
        public static Engine Area(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Area[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///interprets the xi as coordinates in the specified coordinate chart.
        ///https://reference.wolfram.com/language/ref/Area.html
        ///</summary>
        public static Engine Area(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("Area[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the argument of the complex number z.
        ///https://reference.wolfram.com/language/ref/Arg.html
        ///</summary>
        public static Engine Arg(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Arg[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a position xmax at which f is maximized.
        ///https://reference.wolfram.com/language/ref/ArgMax.html
        ///</summary>
        public static Engine ArgMax(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArgMax[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a position {xmax,ymax,…} at which f is maximized.
        ///https://reference.wolfram.com/language/ref/ArgMax.html
        ///</summary>
        public static Engine ArgMax(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ArgMax[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a position at which f is maximized subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/ArgMax.html
        ///</summary>
        public static Engine ArgMax(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ArgMax[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constrains variables to the domain dom, typically Reals or Integers.
        ///https://reference.wolfram.com/language/ref/ArgMax.html
        ///</summary>
        public static Engine ArgMax(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArgMax[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a position xmin at which f is minimized.
        ///https://reference.wolfram.com/language/ref/ArgMin.html
        ///</summary>
        public static Engine ArgMin(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArgMin[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a position {xmin,ymin,…} at which f is minimized.
        ///https://reference.wolfram.com/language/ref/ArgMin.html
        ///</summary>
        public static Engine ArgMin(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ArgMin[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a position at which f is minimized subject to the constraints cons.
        ///https://reference.wolfram.com/language/ref/ArgMin.html
        ///</summary>
        public static Engine ArgMin(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ArgMin[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constrains variables to the domain dom, typically Reals or Integers.
        ///https://reference.wolfram.com/language/ref/ArgMin.html
        ///</summary>
        public static Engine ArgMin(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArgMin[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tries to separate args into a list of n positional arguments followed by a list of valid options for f.
        ///https://reference.wolfram.com/language/ref/ArgumentsOptions.html
        ///</summary>
        public static Engine ArgumentsOptions(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArgumentsOptions[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///requires the number of positional arguments to be between min and max.
        ///https://reference.wolfram.com/language/ref/ArgumentsOptions.html
        ///</summary>
        public static Engine ArgumentsOptions(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ArgumentsOptions[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///modifies the behavior based on the information in the association assoc.
        ///https://reference.wolfram.com/language/ref/ArgumentsOptions.html
        ///</summary>
        public static Engine ArgumentsOptions(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArgumentsOptions[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an autoregressive integrated moving-average process  such that its  difference is a weakly stationary ARMAProcess[{a1,…,ap},{b1,…,bq},v].
        ///https://reference.wolfram.com/language/ref/ARIMAProcess.html
        ///</summary>
        public static Engine ARIMAProcess(this Engine en, List<object> arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ARIMAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a vector ARIMA process (y1(t),… ,yn(t)) such that its (d1,…,dn) difference is a vector weakly stationary ARMAProcess.
        ///https://reference.wolfram.com/language/ref/ARIMAProcess.html
        ///</summary>
        public static Engine ARIMAProcess(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ARIMAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an ARIMA process with initial data init.
        ///https://reference.wolfram.com/language/ref/ARIMAProcess.html
        ///</summary>
        public static Engine ARIMAProcess(this Engine en, List<object> arg0, object arg1, List<object> arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("ARIMAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents an ARIMA process with a constant c.
        ///https://reference.wolfram.com/language/ref/ARIMAProcess.html
        ///</summary>
        public static Engine ARIMAProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ARIMAProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the arithmetic‐geometric mean of a and b.
        ///https://reference.wolfram.com/language/ref/ArithmeticGeometricMean.html
        ///</summary>
        public static Engine ArithmeticGeometricMean(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArithmeticGeometricMean[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a weakly stationary autoregressive moving-average process with AR coefficients ai, MA coefficients bj, and normal white noise variance v.
        ///https://reference.wolfram.com/language/ref/ARMAProcess.html
        ///</summary>
        public static Engine ARMAProcess(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ARMAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an ARMA process with initial data init.
        ///https://reference.wolfram.com/language/ref/ARMAProcess.html
        ///</summary>
        public static Engine ARMAProcess(this Engine en, List<object> arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("ARMAProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an ARMA process with a constant c.
        ///https://reference.wolfram.com/language/ref/ARMAProcess.html
        ///</summary>
        public static Engine ARMAProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ARMAProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an approximate number or quantity with a value around x and an uncertainty δ.
        ///https://reference.wolfram.com/language/ref/Around.html
        ///</summary>
        public static Engine Around(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Around[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a number or quantity with a value around x and asymmetric uncertainties δ-, δ+.
        ///https://reference.wolfram.com/language/ref/Around.html
        ///</summary>
        public static Engine Around(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Around[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives an approximate number or quantity around the mean of the distribution dist, with an uncertainty corresponding to the standard deviation of the distribution.
        ///https://reference.wolfram.com/language/ref/Around.html
        ///</summary>
        public static Engine Around(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Around[" + arg0 + "]", name);
        }

        ///<summary>
        ///propagates uncertainty in expr by replacing all occurrences of si by Around[xi,δi].
        ///https://reference.wolfram.com/language/ref/AroundReplace.html
        ///</summary>
        public static Engine AroundReplace(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AroundReplace[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///propagates uncertainty in expr using a series expansion to order n.
        ///https://reference.wolfram.com/language/ref/AroundReplace.html
        ///</summary>
        public static Engine AroundReplace(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AroundReplace[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a weakly stationary autoregressive process of order p with normal white noise variance v.
        ///https://reference.wolfram.com/language/ref/ARProcess.html
        ///</summary>
        public static Engine ARProcess(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("ARProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an AR process with initial data init.
        ///https://reference.wolfram.com/language/ref/ARProcess.html
        ///</summary>
        public static Engine ARProcess(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ARProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an AR process with a constant c.
        ///https://reference.wolfram.com/language/ref/ARProcess.html
        ///</summary>
        public static Engine ARProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ARProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list of length n, with elements f[i].
        ///https://reference.wolfram.com/language/ref/Array.html
        ///</summary>
        public static Engine Array(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Array[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a list using the index origin r.
        ///https://reference.wolfram.com/language/ref/Array.html
        ///</summary>
        public static Engine Array(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Array[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a list using n values from a to b.
        ///https://reference.wolfram.com/language/ref/Array.html
        ///</summary>
        public static Engine Array(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Array[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates an n1×n2×… array of nested lists, with elements f[i1,i2,…].
        ///https://reference.wolfram.com/language/ref/Array.html
        ///</summary>
        public static Engine Array(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Array[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a list using the index origins ri (default 1).
        ///https://reference.wolfram.com/language/ref/Array.html
        ///</summary>
        public static Engine Array(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Array[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates a list using ni values from ai to bi.
        ///https://reference.wolfram.com/language/ref/Array.html
        ///</summary>
        public static Engine Array(this Engine en, object arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("Array[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///uses head h, rather than List, for each level of the array.
        ///https://reference.wolfram.com/language/ref/Array.html
        ///</summary>
        public static Engine Array(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Array[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives an array in which all identical elements of array are replaced by an integer index representing the component in which the element lies.
        ///https://reference.wolfram.com/language/ref/ArrayComponents.html
        ///</summary>
        public static Engine ArrayComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArrayComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the identical elements at the specified level in array
        ///https://reference.wolfram.com/language/ref/ArrayComponents.html
        ///</summary>
        public static Engine ArrayComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArrayComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a rule or a list of rules for specifying the labels.
        ///https://reference.wolfram.com/language/ref/ArrayComponents.html
        ///</summary>
        public static Engine ArrayComponents(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArrayComponents[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the depth to which expr is a full array, with all the parts at a particular level having the same length.
        ///https://reference.wolfram.com/language/ref/ArrayDepth.html
        ///</summary>
        public static Engine ArrayDepth(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArrayDepth[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies f to all range-r blocks in the specified array.
        ///https://reference.wolfram.com/language/ref/ArrayFilter.html
        ///</summary>
        public static Engine ArrayFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArrayFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies f to blocks with ranges r1, r2, … in successive dimensions.
        ///https://reference.wolfram.com/language/ref/ArrayFilter.html
        ///</summary>
        public static Engine ArrayFilter(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ArrayFilter[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///creates a single flattened matrix from a matrix of matrices mi j.
        ///https://reference.wolfram.com/language/ref/ArrayFlatten.html
        ///</summary>
        public static Engine ArrayFlatten(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ArrayFlatten[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///flattens out r pairs of levels in the array a.
        ///https://reference.wolfram.com/language/ref/ArrayFlatten.html
        ///</summary>
        public static Engine ArrayFlatten(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArrayFlatten[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a mesh region from an array of rank d in which each cell has a geometric dimension d and represents a nonzero value of the array.
        ///https://reference.wolfram.com/language/ref/ArrayMesh.html
        ///</summary>
        public static Engine ArrayMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArrayMesh[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an array with m zeros of padding on every side.
        ///https://reference.wolfram.com/language/ref/ArrayPad.html
        ///</summary>
        public static Engine ArrayPad(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArrayPad[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the specified padding.
        ///https://reference.wolfram.com/language/ref/ArrayPad.html
        ///</summary>
        public static Engine ArrayPad(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArrayPad[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///pads with m elements at the beginning and n elements at the end.
        ///https://reference.wolfram.com/language/ref/ArrayPad.html
        ///</summary>
        public static Engine ArrayPad(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("ArrayPad[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///pads with mi, ni elements at level i in array.
        ///https://reference.wolfram.com/language/ref/ArrayPad.html
        ///</summary>
        public static Engine ArrayPad(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("ArrayPad[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///generates a plot in which the values in an array are shown in a discrete array of squares.
        ///https://reference.wolfram.com/language/ref/ArrayPlot.html
        ///</summary>
        public static Engine ArrayPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArrayPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot in which the values in an array are shown in a discrete array of cubes.
        ///https://reference.wolfram.com/language/ref/ArrayPlot3D.html
        ///</summary>
        public static Engine ArrayPlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArrayPlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a full array or a SparseArray object, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/ArrayQ.html
        ///</summary>
        public static Engine ArrayQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArrayQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///requires expr to be a full array with a depth that matches the pattern patt.
        ///https://reference.wolfram.com/language/ref/ArrayQ.html
        ///</summary>
        public static Engine ArrayQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArrayQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///requires also that test yield True when applied to each of the array elements in expr.
        ///https://reference.wolfram.com/language/ref/ArrayQ.html
        ///</summary>
        public static Engine ArrayQ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArrayQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///reduces dimension n of array by applying f.
        ///https://reference.wolfram.com/language/ref/ArrayReduce.html
        ///</summary>
        public static Engine ArrayReduce(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArrayReduce[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///reduces dimensions n1, n2, etc.
        ///https://reference.wolfram.com/language/ref/ArrayReduce.html
        ///</summary>
        public static Engine ArrayReduce(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("ArrayReduce[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///applies f to arrays formed by combining all dimensions nij to make each dimension i.
        ///https://reference.wolfram.com/language/ref/ArrayReduce.html
        ///</summary>
        public static Engine ArrayReduce(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("ArrayReduce[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///resamples array to have dimensions {n1,n2,…}.
        ///https://reference.wolfram.com/language/ref/ArrayResample.html
        ///</summary>
        public static Engine ArrayResample(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("ArrayResample[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///resamples array according to the dimension specification dspec.
        ///https://reference.wolfram.com/language/ref/ArrayResample.html
        ///</summary>
        public static Engine ArrayResample(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArrayResample[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies resampling scheme, either point or bin based.
        ///https://reference.wolfram.com/language/ref/ArrayResample.html
        ///</summary>
        public static Engine ArrayResample(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArrayResample[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///resamples only the data in the specified subrange {{xmin,xmax},…}.
        ///https://reference.wolfram.com/language/ref/ArrayResample.html
        ///</summary>
        public static Engine ArrayResample(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("ArrayResample[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///arranges the elements of list into a rectangular array with dimensions dims.
        ///https://reference.wolfram.com/language/ref/ArrayReshape.html
        ///</summary>
        public static Engine ArrayReshape(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("ArrayReshape[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the specified padding if list does not contain enough elements.
        ///https://reference.wolfram.com/language/ref/ArrayReshape.html
        ///</summary>
        public static Engine ArrayReshape(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ArrayReshape[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the rules {pos1val1,pos2val2,…} specifying elements in a sparse array.
        ///https://reference.wolfram.com/language/ref/ArrayRules.html
        ///</summary>
        public static Engine ArrayRules(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("ArrayRules[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the domain of arrays of rank r and dimensions di.
        ///https://reference.wolfram.com/language/ref/Arrays.html
        ///</summary>
        public static Engine Arrays(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Arrays[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the domain of arrays of dimensions di, with components in the domain dom.
        ///https://reference.wolfram.com/language/ref/Arrays.html
        ///</summary>
        public static Engine Arrays(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Arrays[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the subdomain of arrays with dimensions di and symmetry sym.
        ///https://reference.wolfram.com/language/ref/Arrays.html
        ///</summary>
        public static Engine Arrays(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Arrays[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a graphics primitive that represents an arrow from pt1 to pt2.
        ///https://reference.wolfram.com/language/ref/Arrow.html
        ///</summary>
        public static Engine Arrow(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Arrow[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents an arrow with its ends set back from pt1 and pt2 by a distance s.
        ///https://reference.wolfram.com/language/ref/Arrow.html
        ///</summary>
        public static Engine Arrow(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Arrow[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets back by s1 from pt1 and s2 from pt2.
        ///https://reference.wolfram.com/language/ref/Arrow.html
        ///</summary>
        public static Engine Arrow(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Arrow[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents an arrow following the specified curve.
        ///https://reference.wolfram.com/language/ref/Arrow.html
        ///</summary>
        public static Engine Arrow(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Arrow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a graphics directive specifying that arrows that follow should have arrowheads with sizes, positions, and forms specified by spec.
        ///https://reference.wolfram.com/language/ref/Arrowheads.html
        ///</summary>
        public static Engine Arrowheads(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Arrowheads[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a filled triangle with angles α and β and side length c, and c is adjacent to both angles.
        ///https://reference.wolfram.com/language/ref/ASATriangle.html
        ///</summary>
        public static Engine ASATriangle(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("ASATriangle[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a construct for use inside AskFunction that gives the value associated with key, or interactively asks for it if it is not already known.
        ///https://reference.wolfram.com/language/ref/Ask.html
        ///</summary>
        public static Engine Ask(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Ask[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the values associated with all the keyi, interactively asking for any that are needed.
        ///https://reference.wolfram.com/language/ref/Ask.html
        ///</summary>
        public static Engine Ask(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Ask[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is a construct for use inside AskFunction that asks for a new value, appends it to the current value associated with "key", and returns the resulting list.
        ///https://reference.wolfram.com/language/ref/AskAppend.html
        ///</summary>
        public static Engine AskAppend(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AskAppend[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a construct for use inside AskFunction that asks for confirmation of the current value associated with "key" and allows this to be either confirmed or changed.
        ///https://reference.wolfram.com/language/ref/AskConfirm.html
        ///</summary>
        public static Engine AskConfirm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AskConfirm[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies the function fun to determine how to ask for confirmation.
        ///https://reference.wolfram.com/language/ref/AskConfirm.html
        ///</summary>
        public static Engine AskConfirm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AskConfirm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a construct for use inside AskFunction that displays the result of evaluating expr in the context of the AskFunction.
        ///https://reference.wolfram.com/language/ref/AskDisplay.html
        ///</summary>
        public static Engine AskDisplay(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AskDisplay[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a construct for use inside AskFunction that gives True if a value is currently associated with key, and False otherwise.
        ///https://reference.wolfram.com/language/ref/AskedQ.html
        ///</summary>
        public static Engine AskedQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AskedQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a construct for use inside AskFunction that gives the value associated with key, or Missing[…] if none has been provided.
        ///https://reference.wolfram.com/language/ref/AskedValue.html
        ///</summary>
        public static Engine AskedValue(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AskedValue[" + arg0 + "]", name);
        }

        ///<summary>
        ///evaluates body, interactively asking for values specified by Ask[…] and related constructs.
        ///https://reference.wolfram.com/language/ref/AskFunction.html
        ///</summary>
        public static Engine AskFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AskFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies how values associated with the keyi should be asked for.
        ///https://reference.wolfram.com/language/ref/AskFunction.html
        ///</summary>
        public static Engine AskFunction(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AskFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a construct for use inside AskFunction that returns an association of all values in the current state of the AskFunction.
        ///https://reference.wolfram.com/language/ref/AskState.html
        ///</summary>
        public static Engine AskState(this Engine en, string? name = null)
        {
            return en.Execute("AskState[]", name);
        }

        ///<summary>
        ///is a construct for use inside AskFunction that displays the result of applying fun to the association of the values of all keys encountered so far in the evaluation of the AskFunction.
        ///https://reference.wolfram.com/language/ref/AskTemplateDisplay.html
        ///</summary>
        public static Engine AskTemplateDisplay(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AskTemplateDisplay[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the assertion that test is True. If assertions have been enabled, test is evaluated when the assertion is encountered. If test is not True, then an assertion failure is generated.
        ///https://reference.wolfram.com/language/ref/Assert.html
        ///</summary>
        public static Engine Assert(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Assert[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies a tag that will be used to identify the assertion if it fails.
        ///https://reference.wolfram.com/language/ref/Assert.html
        ///</summary>
        public static Engine Assert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Assert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a tool for assessing whether answers are correct according to the key.
        ///https://reference.wolfram.com/language/ref/AssessmentFunction.html
        ///</summary>
        public static Engine AssessmentFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AssessmentFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the specified answer comparison method.
        ///https://reference.wolfram.com/language/ref/AssessmentFunction.html
        ///</summary>
        public static Engine AssessmentFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AssessmentFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///assesses the specified question within the CloudObject obj.
        ///https://reference.wolfram.com/language/ref/AssessmentFunction.html
        ///</summary>
        public static Engine AssessmentFunction(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AssessmentFunction[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the results of an assessment.
        ///https://reference.wolfram.com/language/ref/AssessmentResultObject.html
        ///</summary>
        public static Engine AssessmentResultObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AssessmentResultObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a collection of many assessments.
        ///https://reference.wolfram.com/language/ref/AssessmentResultObject.html
        ///</summary>
        public static Engine AssessmentResultObject(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AssessmentResultObject[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///changes the association a by adding the key-value pair keyval.
        ///https://reference.wolfram.com/language/ref/AssociateTo.html
        ///</summary>
        public static Engine AssociateTo(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AssociateTo[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds all key-value pairs keyivali.
        ///https://reference.wolfram.com/language/ref/AssociateTo.html
        ///</summary>
        public static Engine AssociateTo(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AssociateTo[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///creates the association key1f[key1],key2f[key2],….
        ///https://reference.wolfram.com/language/ref/AssociationMap.html
        ///</summary>
        public static Engine AssociationMap(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AssociationMap[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///creates the association f[key1val1],f[key2val2],….
        ///https://reference.wolfram.com/language/ref/AssociationMap.html
        ///</summary>
        public static Engine AssociationMap(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AssociationMap[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of AssociationMap that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/AssociationMap.html
        ///</summary>
        public static Engine AssociationMap(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AssociationMap[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a valid Association object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/AssociationQ.html
        ///</summary>
        public static Engine AssociationQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AssociationQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the association key1val1,key2val2,….
        ///https://reference.wolfram.com/language/ref/AssociationThread.html
        ///</summary>
        public static Engine AssociationThread(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AssociationThread[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///also gives the association key1val1,key2val2,….
        ///https://reference.wolfram.com/language/ref/AssociationThread.html
        ///</summary>
        public static Engine AssociationThread(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AssociationThread[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates expr with assum appended to $Assumptions, so that assum is included in the default assumptions used by functions such as Refine, Simplify, and Integrate.
        ///https://reference.wolfram.com/language/ref/Assuming.html
        ///</summary>
        public static Engine Assuming(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Assuming[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an asymptotic approximation for expr near x0.
        ///https://reference.wolfram.com/language/ref/Asymptotic.html
        ///</summary>
        public static Engine Asymptotic(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Asymptotic[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an asymptotic approximation for expr near x0 to order n.
        ///https://reference.wolfram.com/language/ref/Asymptotic.html
        ///</summary>
        public static Engine Asymptotic(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Asymptotic[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation to the differential equation eqn for f[x] centered at x0.
        ///https://reference.wolfram.com/language/ref/AsymptoticDSolveValue.html
        ///</summary>
        public static Engine AsymptoticDSolveValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticDSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation to a system of differential equations.
        ///https://reference.wolfram.com/language/ref/AsymptoticDSolveValue.html
        ///</summary>
        public static Engine AsymptoticDSolveValue(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticDSolveValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation of f[x,ϵ] for the parameter ϵ centered at ϵ0.
        ///https://reference.wolfram.com/language/ref/AsymptoticDSolveValue.html
        ///</summary>
        public static Engine AsymptoticDSolveValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AsymptoticDSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///computes the asymptotic approximation to order n.
        ///https://reference.wolfram.com/language/ref/AsymptoticDSolveValue.html
        ///</summary>
        public static Engine AsymptoticDSolveValue(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("AsymptoticDSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as xx*.
        ///https://reference.wolfram.com/language/ref/AsymptoticEqual.html
        ///</summary>
        public static Engine AsymptoticEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as {x1,…,xn}{,…,}.
        ///https://reference.wolfram.com/language/ref/AsymptoticEqual.html
        ///</summary>
        public static Engine AsymptoticEqual(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticEqual[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives conditions for  as xx*.
        ///https://reference.wolfram.com/language/ref/AsymptoticEquivalent.html
        ///</summary>
        public static Engine AsymptoticEquivalent(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticEquivalent[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives conditions for  as {x1,…,xn}{,…,}.
        ///https://reference.wolfram.com/language/ref/AsymptoticEquivalent.html
        ///</summary>
        public static Engine AsymptoticEquivalent(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticEquivalent[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation for the expectation of expr centered at a0, under the assumption that x follows the probability distribution dist.
        ///https://reference.wolfram.com/language/ref/AsymptoticExpectation.html
        ///</summary>
        public static Engine AsymptoticExpectation(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticExpectation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the asymptotic expectation to order n.
        ///https://reference.wolfram.com/language/ref/AsymptoticExpectation.html
        ///</summary>
        public static Engine AsymptoticExpectation(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticExpectation[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as xx*.
        ///https://reference.wolfram.com/language/ref/AsymptoticGreater.html
        ///</summary>
        public static Engine AsymptoticGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as .
        ///https://reference.wolfram.com/language/ref/AsymptoticGreater.html
        ///</summary>
        public static Engine AsymptoticGreater(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticGreater[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as xx*.
        ///https://reference.wolfram.com/language/ref/AsymptoticGreaterEqual.html
        ///</summary>
        public static Engine AsymptoticGreaterEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticGreaterEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as {x1,…,xn}{,…,}.
        ///https://reference.wolfram.com/language/ref/AsymptoticGreaterEqual.html
        ///</summary>
        public static Engine AsymptoticGreaterEqual(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticGreaterEqual[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation of the indefinite integral  for x centered at x0.
        ///https://reference.wolfram.com/language/ref/AsymptoticIntegrate.html
        ///</summary>
        public static Engine AsymptoticIntegrate(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticIntegrate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation of the definite integral  for α centered at α0.
        ///https://reference.wolfram.com/language/ref/AsymptoticIntegrate.html
        ///</summary>
        public static Engine AsymptoticIntegrate(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticIntegrate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the asymptotic approximation to order n.
        ///https://reference.wolfram.com/language/ref/AsymptoticIntegrate.html
        ///</summary>
        public static Engine AsymptoticIntegrate(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticIntegrate[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as xx*.
        ///https://reference.wolfram.com/language/ref/AsymptoticLess.html
        ///</summary>
        public static Engine AsymptoticLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as {x1,…,xn}{,…,}.
        ///https://reference.wolfram.com/language/ref/AsymptoticLess.html
        ///</summary>
        public static Engine AsymptoticLess(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticLess[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as xx*.
        ///https://reference.wolfram.com/language/ref/AsymptoticLessEqual.html
        ///</summary>
        public static Engine AsymptoticLessEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticLessEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives conditions for  or  as {x1,…,xn}{,…,}.
        ///https://reference.wolfram.com/language/ref/AsymptoticLessEqual.html
        ///</summary>
        public static Engine AsymptoticLessEqual(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticLessEqual[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the state feedback control law that causes the outputs of the affine system sys to track the reference signals fi with decay rates pj.
        ///https://reference.wolfram.com/language/ref/AsymptoticOutputTracker.html
        ///</summary>
        public static Engine AsymptoticOutputTracker(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticOutputTracker[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///specifies outputs outi and control inputs inj to use.
        ///https://reference.wolfram.com/language/ref/AsymptoticOutputTracker.html
        ///</summary>
        public static Engine AsymptoticOutputTracker(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("AsymptoticOutputTracker[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation for the probability of pred centered at a0, under the assumption that x follows the probability distribution dist.
        ///https://reference.wolfram.com/language/ref/AsymptoticProbability.html
        ///</summary>
        public static Engine AsymptoticProbability(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticProbability[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the asymptotic probability to order n.
        ///https://reference.wolfram.com/language/ref/AsymptoticProbability.html
        ///</summary>
        public static Engine AsymptoticProbability(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticProbability[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation of the indefinite product  for x near x0.
        ///https://reference.wolfram.com/language/ref/AsymptoticProduct.html
        ///</summary>
        public static Engine AsymptoticProduct(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticProduct[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation of the definite product  for α near α0.
        ///https://reference.wolfram.com/language/ref/AsymptoticProduct.html
        ///</summary>
        public static Engine AsymptoticProduct(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticProduct[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the asymptotic approximation to order n.
        ///https://reference.wolfram.com/language/ref/AsymptoticProduct.html
        ///</summary>
        public static Engine AsymptoticProduct(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticProduct[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation to the difference equation eqn for f[x] near .
        ///https://reference.wolfram.com/language/ref/AsymptoticRSolveValue.html
        ///</summary>
        public static Engine AsymptoticRSolveValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticRSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation to a system of difference equations.
        ///https://reference.wolfram.com/language/ref/AsymptoticRSolveValue.html
        ///</summary>
        public static Engine AsymptoticRSolveValue(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticRSolveValue[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation of f[x,ϵ] for the parameter ϵ centered at ϵ0.
        ///https://reference.wolfram.com/language/ref/AsymptoticRSolveValue.html
        ///</summary>
        public static Engine AsymptoticRSolveValue(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AsymptoticRSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///computes the asymptotic approximation to order n.
        ///https://reference.wolfram.com/language/ref/AsymptoticRSolveValue.html
        ///</summary>
        public static Engine AsymptoticRSolveValue(this Engine en, object arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("AsymptoticRSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///computes asymptotic approximations of solutions y[x] of the equation eqn passing through {a,b}.
        ///https://reference.wolfram.com/language/ref/AsymptoticSolve.html
        ///</summary>
        public static Engine AsymptoticSolve(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticSolve[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes asymptotic approximations of solutions y[x] of the equation eqn for x near a.
        ///https://reference.wolfram.com/language/ref/AsymptoticSolve.html
        ///</summary>
        public static Engine AsymptoticSolve(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticSolve[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes asymptotic approximations of solutions {y1[x1,x2,…],y2[x1,x2,…],…} of the system of equations eqns.
        ///https://reference.wolfram.com/language/ref/AsymptoticSolve.html
        ///</summary>
        public static Engine AsymptoticSolve(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticSolve[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///computes the asymptotic approximation to order n.
        ///https://reference.wolfram.com/language/ref/AsymptoticSolve.html
        ///</summary>
        public static Engine AsymptoticSolve(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("AsymptoticSolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///computes only solutions that are real valued for real argument values.
        ///https://reference.wolfram.com/language/ref/AsymptoticSolve.html
        ///</summary>
        public static Engine AsymptoticSolve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AsymptoticSolve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation of the indefinite sum  for x centered at x0.
        ///https://reference.wolfram.com/language/ref/AsymptoticSum.html
        ///</summary>
        public static Engine AsymptoticSum(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticSum[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes an asymptotic approximation of the definite sum  for α centered at α0.
        ///https://reference.wolfram.com/language/ref/AsymptoticSum.html
        ///</summary>
        public static Engine AsymptoticSum(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("AsymptoticSum[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the asymptotic approximation to order n.
        ///https://reference.wolfram.com/language/ref/AsymptoticSum.html
        ///</summary>
        public static Engine AsymptoticSum(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AsymptoticSum[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents an atom with atomic symbol "sym".
        ///https://reference.wolfram.com/language/ref/Atom.html
        ///</summary>
        public static Engine Atom(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Atom[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an atom with atomic symbol "sym" and specified properties.
        ///https://reference.wolfram.com/language/ref/Atom.html
        ///</summary>
        public static Engine Atom(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Atom[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the number of atoms in the molecule represented by mol.
        ///https://reference.wolfram.com/language/ref/AtomCount.html
        ///</summary>
        public static Engine AtomCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AtomCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of atoms in the molecule mol matching the atom pattern patt.
        ///https://reference.wolfram.com/language/ref/AtomCount.html
        ///</summary>
        public static Engine AtomCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AtomCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of atoms in the molecule represented by mol.
        ///https://reference.wolfram.com/language/ref/AtomList.html
        ///</summary>
        public static Engine AtomList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AtomList[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of atoms in the molecule mol matching the atom pattern patt.
        ///https://reference.wolfram.com/language/ref/AtomList.html
        ///</summary>
        public static Engine AtomList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AtomList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value for the specified property of the atoms matching patt.
        ///https://reference.wolfram.com/language/ref/AtomList.html
        ///</summary>
        public static Engine AtomList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AtomList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields True if expr is an expression which cannot be divided into subexpressions, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/AtomQ.html
        ///</summary>
        public static Engine AtomQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AtomQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes expr a cell attached to the current cell being evaluated.
        ///https://reference.wolfram.com/language/ref/AttachCell.html
        ///</summary>
        public static Engine AttachCell(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AttachCell[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes expr a cell attached to the notebook, cell or box object obj.
        ///https://reference.wolfram.com/language/ref/AttachCell.html
        ///</summary>
        public static Engine AttachCell(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AttachCell[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that the attached cell should be at position pos relative to obj.
        ///https://reference.wolfram.com/language/ref/AttachCell.html
        ///</summary>
        public static Engine AttachCell(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AttachCell[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies that the attached cell should be at a distance dist from pos.
        ///https://reference.wolfram.com/language/ref/AttachCell.html
        ///</summary>
        public static Engine AttachCell(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AttachCell[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///aligns the attached cell so that position opos in expr lies at distance dist from location pos.
        ///https://reference.wolfram.com/language/ref/AttachCell.html
        ///</summary>
        public static Engine AttachCell(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("AttachCell[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents a trainable net layer that learns to pay attention to certain portions of its input.
        ///https://reference.wolfram.com/language/ref/AttentionLayer.html
        ///</summary>
        public static Engine AttentionLayer(this Engine en, string? name = null)
        {
            return en.Execute("AttentionLayer[]", name);
        }

        ///<summary>
        ///specifies a particular net to give scores for portions of the input.
        ///https://reference.wolfram.com/language/ref/AttentionLayer.html
        ///</summary>
        public static Engine AttentionLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AttentionLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///includes options for weight normalization, masking and other parameters.
        ///https://reference.wolfram.com/language/ref/AttentionLayer.html
        ///</summary>
        public static Engine AttentionLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AttentionLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of attributes for a symbol.
        ///https://reference.wolfram.com/language/ref/Attributes.html
        ///</summary>
        public static Engine Attributes(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Attributes[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the attributes for each of the si.
        ///https://reference.wolfram.com/language/ref/Attributes.html
        ///</summary>
        public static Engine Attributes(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Attributes[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents audio stored in the given file.
        ///https://reference.wolfram.com/language/ref/Audio.html
        ///</summary>
        public static Engine Audio(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Audio[" + arg0 + "]", name);
        }

        ///<summary>
        ///multiplies all samples of audio by a factor s.
        ///https://reference.wolfram.com/language/ref/AudioAmplify.html
        ///</summary>
        public static Engine AudioAmplify(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioAmplify[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes the property prop and adds it as an annotation to audio.
        ///https://reference.wolfram.com/language/ref/AudioAnnotate.html
        ///</summary>
        public static Engine AudioAnnotate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioAnnotate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives all annotations associated to audio.
        ///https://reference.wolfram.com/language/ref/AudioAnnotationLookup.html
        ///</summary>
        public static Engine AudioAnnotationLookup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioAnnotationLookup[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the annotations specified by tags.
        ///https://reference.wolfram.com/language/ref/AudioAnnotationLookup.html
        ///</summary>
        public static Engine AudioAnnotationLookup(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioAnnotationLookup[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///formats each annotation element according to format.
        ///https://reference.wolfram.com/language/ref/AudioAnnotationLookup.html
        ///</summary>
        public static Engine AudioAnnotationLookup(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioAnnotationLookup[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies f to non-overlapping partitions of length dur in audio.
        ///https://reference.wolfram.com/language/ref/AudioBlockMap.html
        ///</summary>
        public static Engine AudioBlockMap(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioBlockMap[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies f to partitions with offset offset in audio.
        ///https://reference.wolfram.com/language/ref/AudioBlockMap.html
        ///</summary>
        public static Engine AudioBlockMap(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AudioBlockMap[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///creates a temporary interactive interface for capturing an audio signal.
        ///https://reference.wolfram.com/language/ref/AudioCapture.html
        ///</summary>
        public static Engine AudioCapture(this Engine en, string? name = null)
        {
            return en.Execute("AudioCapture[]", name);
        }

        ///<summary>
        ///captures an audio signal into file.
        ///https://reference.wolfram.com/language/ref/AudioCapture.html
        ///</summary>
        public static Engine AudioCapture(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioCapture[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a multichannel audio object by combining the sequence of channels in audioi.
        ///https://reference.wolfram.com/language/ref/AudioChannelCombine.html
        ///</summary>
        public static Engine AudioChannelCombine(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AudioChannelCombine[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///mixes channels of audio by averaging and returns a center-panned stereo audio object.
        ///https://reference.wolfram.com/language/ref/AudioChannelMix.html
        ///</summary>
        public static Engine AudioChannelMix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioChannelMix[" + arg0 + "]", name);
        }

        ///<summary>
        ///mixes audio channels into the specified desttype.
        ///https://reference.wolfram.com/language/ref/AudioChannelMix.html
        ///</summary>
        public static Engine AudioChannelMix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioChannelMix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the number of channels in the Audio object audio.
        ///https://reference.wolfram.com/language/ref/AudioChannels.html
        ///</summary>
        public static Engine AudioChannels(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioChannels[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of Audio objects, each of which represents one channel of audio.
        ///https://reference.wolfram.com/language/ref/AudioChannelSeparate.html
        ///</summary>
        public static Engine AudioChannelSeparate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioChannelSeparate[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the specified channel from audio.
        ///https://reference.wolfram.com/language/ref/AudioChannelSeparate.html
        ///</summary>
        public static Engine AudioChannelSeparate(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioChannelSeparate[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an array of audio samples.
        ///https://reference.wolfram.com/language/ref/AudioData.html
        ///</summary>
        public static Engine AudioData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an array of audio samples converted to the specified "type".
        ///https://reference.wolfram.com/language/ref/AudioData.html
        ///</summary>
        public static Engine AudioData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///creates audio by adding repeated decaying echos to audio spaced by the specified delay.
        ///https://reference.wolfram.com/language/ref/AudioDelay.html
        ///</summary>
        public static Engine AudioDelay(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioDelay[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the specified feedback as the amount of signal to preserve during each repetition.
        ///https://reference.wolfram.com/language/ref/AudioDelay.html
        ///</summary>
        public static Engine AudioDelay(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioDelay[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses mix to control the ratio between original and delayed audio.
        ///https://reference.wolfram.com/language/ref/AudioDelay.html
        ///</summary>
        public static Engine AudioDelay(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AudioDelay[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///deletes the first t seconds of audio.
        ///https://reference.wolfram.com/language/ref/AudioDelete.html
        ///</summary>
        public static Engine AudioDelete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioDelete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes from time t1 to time t2, returning the remaining audio as a single Audio object.
        ///https://reference.wolfram.com/language/ref/AudioDelete.html
        ///</summary>
        public static Engine AudioDelete(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioDelete[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns a distance measure between audio1 and audio2.
        ///https://reference.wolfram.com/language/ref/AudioDistance.html
        ///</summary>
        public static Engine AudioDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns audio in which the beginning and end of audio are faded.
        ///https://reference.wolfram.com/language/ref/AudioFade.html
        ///</summary>
        public static Engine AudioFade(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioFade[" + arg0 + "]", name);
        }

        ///<summary>
        ///fades the first and last t seconds of audio.
        ///https://reference.wolfram.com/language/ref/AudioFade.html
        ///</summary>
        public static Engine AudioFade(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioFade[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///fades t1 seconds at the beginning and t2 seconds at the end.
        ///https://reference.wolfram.com/language/ref/AudioFade.html
        ///</summary>
        public static Engine AudioFade(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioFade[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives audio by shifting the spectrum of audio by freq.
        ///https://reference.wolfram.com/language/ref/AudioFrequencyShift.html
        ///</summary>
        public static Engine AudioFrequencyShift(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioFrequencyShift[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses mix to control the ratio between the original and shifted audio.
        ///https://reference.wolfram.com/language/ref/AudioFrequencyShift.html
        ///</summary>
        public static Engine AudioFrequencyShift(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioFrequencyShift[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates one second of audio of a given model.
        ///https://reference.wolfram.com/language/ref/AudioGenerator.html
        ///</summary>
        public static Engine AudioGenerator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioGenerator[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates t seconds of audio.
        ///https://reference.wolfram.com/language/ref/AudioGenerator.html
        ///</summary>
        public static Engine AudioGenerator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioGenerator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates audio samples of the specified "type".
        ///https://reference.wolfram.com/language/ref/AudioGenerator.html
        ///</summary>
        public static Engine AudioGenerator(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioGenerator[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields the result of attempting to identify what audio is a recording of.
        ///https://reference.wolfram.com/language/ref/AudioIdentify.html
        ///</summary>
        public static Engine AudioIdentify(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioIdentify[" + arg0 + "]", name);
        }

        ///<summary>
        ///restricts the identification to the specified category.
        ///https://reference.wolfram.com/language/ref/AudioIdentify.html
        ///</summary>
        public static Engine AudioIdentify(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioIdentify[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of up to n possible identifications.
        ///https://reference.wolfram.com/language/ref/AudioIdentify.html
        ///</summary>
        public static Engine AudioIdentify(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioIdentify[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the specified property for each identification.
        ///https://reference.wolfram.com/language/ref/AudioIdentify.html
        ///</summary>
        public static Engine AudioIdentify(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("AudioIdentify[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///inserts the audio signal new at time t.
        ///https://reference.wolfram.com/language/ref/AudioInsert.html
        ///</summary>
        public static Engine AudioInsert(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioInsert[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///inserts multiple audio signals at different positions.
        ///https://reference.wolfram.com/language/ref/AudioInsert.html
        ///</summary>
        public static Engine AudioInsert(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioInsert[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if audio sounds to be an instance of the object obj, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/AudioInstanceQ.html
        ///</summary>
        public static Engine AudioInstanceQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioInstanceQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///assumes that audio is the sound of something in the category cat.
        ///https://reference.wolfram.com/language/ref/AudioInstanceQ.html
        ///</summary>
        public static Engine AudioInstanceQ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioInstanceQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns audible intervals of audio.
        ///https://reference.wolfram.com/language/ref/AudioIntervals.html
        ///</summary>
        public static Engine AudioIntervals(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioIntervals[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns intervals of audio for which the criterion crit is satisfied.
        ///https://reference.wolfram.com/language/ref/AudioIntervals.html
        ///</summary>
        public static Engine AudioIntervals(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioIntervals[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns only intervals larger than the given duration mindur.
        ///https://reference.wolfram.com/language/ref/AudioIntervals.html
        ///</summary>
        public static Engine AudioIntervals(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioIntervals[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the number of samples in the Audio object audio.
        ///https://reference.wolfram.com/language/ref/AudioLength.html
        ///</summary>
        public static Engine AudioLength(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioLength[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes the property "prop" locally for partitions of audio.
        ///https://reference.wolfram.com/language/ref/AudioLocalMeasurements.html
        ///</summary>
        public static Engine AudioLocalMeasurements(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioLocalMeasurements[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes several properties "propi".
        ///https://reference.wolfram.com/language/ref/AudioLocalMeasurements.html
        ///</summary>
        public static Engine AudioLocalMeasurements(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioLocalMeasurements[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the measurements in the specified output format.
        ///https://reference.wolfram.com/language/ref/AudioLocalMeasurements.html
        ///</summary>
        public static Engine AudioLocalMeasurements(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioLocalMeasurements[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///computes the loudness of audio according to the EBU momentary definition.
        ///https://reference.wolfram.com/language/ref/AudioLoudness.html
        ///</summary>
        public static Engine AudioLoudness(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioLoudness[" + arg0 + "]", name);
        }

        ///<summary>
        ///computes the loudness according to the definition def.
        ///https://reference.wolfram.com/language/ref/AudioLoudness.html
        ///</summary>
        public static Engine AudioLoudness(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioLoudness[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes the property "prop" for the entire audio.
        ///https://reference.wolfram.com/language/ref/AudioMeasurements.html
        ///</summary>
        public static Engine AudioMeasurements(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioMeasurements[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes several properties "propi".
        ///https://reference.wolfram.com/language/ref/AudioMeasurements.html
        ///</summary>
        public static Engine AudioMeasurements(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioMeasurements[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the values in the specified output format.
        ///https://reference.wolfram.com/language/ref/AudioMeasurements.html
        ///</summary>
        public static Engine AudioMeasurements(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioMeasurements[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns measurements for all audioi.
        ///https://reference.wolfram.com/language/ref/AudioMeasurements.html
        ///</summary>
        public static Engine AudioMeasurements(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioMeasurements[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///normalizes audio so that the maximum absolute value of its samples is 1.
        ///https://reference.wolfram.com/language/ref/AudioNormalize.html
        ///</summary>
        public static Engine AudioNormalize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioNormalize[" + arg0 + "]", name);
        }

        ///<summary>
        ///normalizes the audio signal based on the specified model.
        ///https://reference.wolfram.com/language/ref/AudioNormalize.html
        ///</summary>
        public static Engine AudioNormalize(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioNormalize[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns an audio object by overlaying all audioi.
        ///https://reference.wolfram.com/language/ref/AudioOverlay.html
        ///</summary>
        public static Engine AudioOverlay(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AudioOverlay[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///adds t seconds of silence to the end of audio.
        ///https://reference.wolfram.com/language/ref/AudioPad.html
        ///</summary>
        public static Engine AudioPad(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioPad[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds t1 seconds of silence to the beginning and t2 seconds to the end of audio.
        ///https://reference.wolfram.com/language/ref/AudioPad.html
        ///</summary>
        public static Engine AudioPad(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioPad[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///pads using the value or method specified by padding.
        ///https://reference.wolfram.com/language/ref/AudioPad.html
        ///</summary>
        public static Engine AudioPad(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioPad[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a center-panned stereo audio object from a mono audio.
        ///https://reference.wolfram.com/language/ref/AudioPan.html
        ///</summary>
        public static Engine AudioPan(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioPan[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a stereo audio object after panning left and right channels using the specified pan.
        ///https://reference.wolfram.com/language/ref/AudioPan.html
        ///</summary>
        public static Engine AudioPan(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioPan[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///partitions an audio object into non-overlapping segments of duration dur.
        ///https://reference.wolfram.com/language/ref/AudioPartition.html
        ///</summary>
        public static Engine AudioPartition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioPartition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates segments with specified offset.
        ///https://reference.wolfram.com/language/ref/AudioPartition.html
        ///</summary>
        public static Engine AudioPartition(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioPartition[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///pauses the playback of all AudioStream objects.
        ///https://reference.wolfram.com/language/ref/AudioPause.html
        ///</summary>
        public static Engine AudioPause(this Engine en, string? name = null)
        {
            return en.Execute("AudioPause[]", name);
        }

        ///<summary>
        ///pauses the playback of the AudioStream object astream.
        ///https://reference.wolfram.com/language/ref/AudioPause.html
        ///</summary>
        public static Engine AudioPause(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioPause[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies pitch shifting to audio by the ratio r, shifting every frequency  to .
        ///https://reference.wolfram.com/language/ref/AudioPitchShift.html
        ///</summary>
        public static Engine AudioPitchShift(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioPitchShift[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a new AudioStream object from audio and starts the playback.
        ///https://reference.wolfram.com/language/ref/AudioPlay.html
        ///</summary>
        public static Engine AudioPlay(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioPlay[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the waveform of audio.
        ///https://reference.wolfram.com/language/ref/AudioPlot.html
        ///</summary>
        public static Engine AudioPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots waveforms of all audioi.
        ///https://reference.wolfram.com/language/ref/AudioPlot.html
        ///</summary>
        public static Engine AudioPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AudioPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if audio has the form of a valid Audio object, and False otherwise.
        ///https://reference.wolfram.com/language/ref/AudioQ.html
        ///</summary>
        public static Engine AudioQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a new AudioStream object and starts to record from the default input audio device.
        ///https://reference.wolfram.com/language/ref/AudioRecord.html
        ///</summary>
        public static Engine AudioRecord(this Engine en, string? name = null)
        {
            return en.Execute("AudioRecord[]", name);
        }

        ///<summary>
        ///records from the input audio device inputdev.
        ///https://reference.wolfram.com/language/ref/AudioRecord.html
        ///</summary>
        public static Engine AudioRecord(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioRecord[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces the audio signal between t1 and t2 with the new signal new.
        ///https://reference.wolfram.com/language/ref/AudioReplace.html
        ///</summary>
        public static Engine AudioReplace(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioReplace[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces multiple intervals.
        ///https://reference.wolfram.com/language/ref/AudioReplace.html
        ///</summary>
        public static Engine AudioReplace(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioReplace[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the specified fitting method.
        ///https://reference.wolfram.com/language/ref/AudioReplace.html
        ///</summary>
        public static Engine AudioReplace(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioReplace[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///resamples audio to have the sample rate of sr.
        ///https://reference.wolfram.com/language/ref/AudioResample.html
        ///</summary>
        public static Engine AudioResample(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioResample[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///adds reverberation to audio.
        ///https://reference.wolfram.com/language/ref/AudioReverb.html
        ///</summary>
        public static Engine AudioReverb(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioReverb[" + arg0 + "]", name);
        }

        ///<summary>
        ///adds reverberation following the room model.
        ///https://reference.wolfram.com/language/ref/AudioReverb.html
        ///</summary>
        public static Engine AudioReverb(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioReverb[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///controls the mix ratio between original and reverberated audio.
        ///https://reference.wolfram.com/language/ref/AudioReverb.html
        ///</summary>
        public static Engine AudioReverb(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AudioReverb[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///reverses audio so that the signal is played backward.
        ///https://reference.wolfram.com/language/ref/AudioReverse.html
        ///</summary>
        public static Engine AudioReverse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioReverse[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the sample rate of the Audio object audio.
        ///https://reference.wolfram.com/language/ref/AudioSampleRate.html
        ///</summary>
        public static Engine AudioSampleRate(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioSampleRate[" + arg0 + "]", name);
        }

        ///<summary>
        ///transforms audio by applying the function f to its short-time Fourier transform.
        ///https://reference.wolfram.com/language/ref/AudioSpectralMap.html
        ///</summary>
        public static Engine AudioSpectralMap(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioSpectralMap[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies the function f to the list of short-time Fourier transforms of all audioi.
        ///https://reference.wolfram.com/language/ref/AudioSpectralMap.html
        ///</summary>
        public static Engine AudioSpectralMap(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioSpectralMap[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns a modified version of audio by applying a time-frequency transformation f to its short-time Fourier transform.
        ///https://reference.wolfram.com/language/ref/AudioSpectralTransformation.html
        ///</summary>
        public static Engine AudioSpectralTransformation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioSpectralTransformation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///splits audio at time t.
        ///https://reference.wolfram.com/language/ref/AudioSplit.html
        ///</summary>
        public static Engine AudioSplit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioSplit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///splits audio at times ti.
        ///https://reference.wolfram.com/language/ref/AudioSplit.html
        ///</summary>
        public static Engine AudioSplit(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioSplit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///stops the playback of all AudioStream objects.
        ///https://reference.wolfram.com/language/ref/AudioStop.html
        ///</summary>
        public static Engine AudioStop(this Engine en, string? name = null)
        {
            return en.Execute("AudioStop[]", name);
        }

        ///<summary>
        ///stops the playback of the AudioStream object astream.
        ///https://reference.wolfram.com/language/ref/AudioStop.html
        ///</summary>
        public static Engine AudioStop(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioStop[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a new AudioStream object from source.
        ///https://reference.wolfram.com/language/ref/AudioStream.html
        ///</summary>
        public static Engine AudioStream(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioStream[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns all existing streams.
        ///https://reference.wolfram.com/language/ref/AudioStreams.html
        ///</summary>
        public static Engine AudioStreams(this Engine en, string? name = null)
        {
            return en.Execute("AudioStreams[]", name);
        }

        ///<summary>
        ///returns all existing streams that originated from audio.
        ///https://reference.wolfram.com/language/ref/AudioStreams.html
        ///</summary>
        public static Engine AudioStreams(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioStreams[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns "prop" for all streams that originated from audio.
        ///https://reference.wolfram.com/language/ref/AudioStreams.html
        ///</summary>
        public static Engine AudioStreams(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioStreams[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies time stretching to audio by the specified factor r.
        ///https://reference.wolfram.com/language/ref/AudioTimeStretch.html
        ///</summary>
        public static Engine AudioTimeStretch(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioTimeStretch[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies the function f to the first audio track of the Video object video.
        ///https://reference.wolfram.com/language/ref/AudioTrackApply.html
        ///</summary>
        public static Engine AudioTrackApply(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioTrackApply[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///trims silence from the beginning and end of audio.
        ///https://reference.wolfram.com/language/ref/AudioTrim.html
        ///</summary>
        public static Engine AudioTrim(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioTrim[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the first t seconds of audio.
        ///https://reference.wolfram.com/language/ref/AudioTrim.html
        ///</summary>
        public static Engine AudioTrim(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AudioTrim[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns audio starting at time t1 and ending at time t2 of audio.
        ///https://reference.wolfram.com/language/ref/AudioTrim.html
        ///</summary>
        public static Engine AudioTrim(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AudioTrim[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the data type used to represent samples in the Audio object audio.
        ///https://reference.wolfram.com/language/ref/AudioType.html
        ///</summary>
        public static Engine AudioType(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AudioType[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the augmented polyhedron poly by replacing each face by a pyramid.
        ///https://reference.wolfram.com/language/ref/AugmentedPolyhedron.html
        ///</summary>
        public static Engine AugmentedPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AugmentedPolyhedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the augmented polyhedron with a pyramid of height h.
        ///https://reference.wolfram.com/language/ref/AugmentedPolyhedron.html
        ///</summary>
        public static Engine AugmentedPolyhedron(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AugmentedPolyhedron[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a formal augmented symmetric polynomial with exponents r1, r2, ….
        ///https://reference.wolfram.com/language/ref/AugmentedSymmetricPolynomial.html
        ///</summary>
        public static Engine AugmentedSymmetricPolynomial(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AugmentedSymmetricPolynomial[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a multivariate formal augmented symmetric polynomial with exponent vectors {r11, …, r1n}, {r21, …, r2n}, ….
        ///https://reference.wolfram.com/language/ref/AugmentedSymmetricPolynomial.html
        ///</summary>
        public static Engine AugmentedSymmetricPolynomial(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("AugmentedSymmetricPolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the augmented symmetric polynomial in data.
        ///https://reference.wolfram.com/language/ref/AugmentedSymmetricPolynomial.html
        ///</summary>
        public static Engine AugmentedSymmetricPolynomial(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AugmentedSymmetricPolynomial[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///initiates a standard dialog for entering username/password authentication information.
        ///https://reference.wolfram.com/language/ref/AuthenticationDialog.html
        ///</summary>
        public static Engine AuthenticationDialog(this Engine en, string? name = null)
        {
            return en.Execute("AuthenticationDialog[]", name);
        }

        ///<summary>
        ///initiates an authentication dialog of the specified standard type.
        ///https://reference.wolfram.com/language/ref/AuthenticationDialog.html
        ///</summary>
        public static Engine AuthenticationDialog(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AuthenticationDialog[" + arg0 + "]", name);
        }

        ///<summary>
        ///initiates an authentication dialog that requests values for the specified keys.
        ///https://reference.wolfram.com/language/ref/AuthenticationDialog.html
        ///</summary>
        public static Engine AuthenticationDialog(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AuthenticationDialog[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///applies the function func to the dialog's return value.
        ///https://reference.wolfram.com/language/ref/AuthenticationDialog.html
        ///</summary>
        public static Engine AuthenticationDialog(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AuthenticationDialog[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the stringi that can complete string.
        ///https://reference.wolfram.com/language/ref/Autocomplete.html
        ///</summary>
        public static Engine Autocomplete(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Autocomplete[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///puts the completions in order of decreasing weights wi.
        ///https://reference.wolfram.com/language/ref/Autocomplete.html
        ///</summary>
        public static Engine Autocomplete(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Autocomplete[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the first at most n completions.
        ///https://reference.wolfram.com/language/ref/Autocomplete.html
        ///</summary>
        public static Engine Autocomplete(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Autocomplete[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives an AutocompletionFunction[…] that can be applied to a string.
        ///https://reference.wolfram.com/language/ref/Autocomplete.html
        ///</summary>
        public static Engine Autocomplete(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Autocomplete[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a function to be applied to a string to generate possible completions.
        ///https://reference.wolfram.com/language/ref/AutocompletionFunction.html
        ///</summary>
        public static Engine AutocompletionFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AutocompletionFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the data is autocorrelated.
        ///https://reference.wolfram.com/language/ref/AutocorrelationTest.html
        ///</summary>
        public static Engine AutocorrelationTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AutocorrelationTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether the data is autocorrelated up to lag k.
        ///https://reference.wolfram.com/language/ref/AutocorrelationTest.html
        ///</summary>
        public static Engine AutocorrelationTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AutocorrelationTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property" for a given model.
        ///https://reference.wolfram.com/language/ref/AutocorrelationTest.html
        ///</summary>
        public static Engine AutocorrelationTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AutocorrelationTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an expression to be reevaluated every hour and made available in the cloud.
        ///https://reference.wolfram.com/language/ref/AutoRefreshed.html
        ///</summary>
        public static Engine AutoRefreshed(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AutoRefreshed[" + arg0 + "]", name);
        }

        ///<summary>
        ///reevaluates at time interval dt.
        ///https://reference.wolfram.com/language/ref/AutoRefreshed.html
        ///</summary>
        public static Engine AutoRefreshed(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AutoRefreshed[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that the result from evaluating expr should be given in format fmt.
        ///https://reference.wolfram.com/language/ref/AutoRefreshed.html
        ///</summary>
        public static Engine AutoRefreshed(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("AutoRefreshed[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies that the result should be given as a response of the form rform.
        ///https://reference.wolfram.com/language/ref/AutoRefreshed.html
        ///</summary>
        public static Engine AutoRefreshed(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("AutoRefreshed[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents an element of a form that automatically submits the whole form if it is entered.
        ///https://reference.wolfram.com/language/ref/AutoSubmitting.html
        ///</summary>
        public static Engine AutoSubmitting(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AutoSubmitting[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an axiomatic representation of the specified axiomatic theory.
        ///https://reference.wolfram.com/language/ref/AxiomaticTheory.html
        ///</summary>
        public static Engine AxiomaticTheory(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AxiomaticTheory[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses si to represent the operator opi in the theory.
        ///https://reference.wolfram.com/language/ref/AxiomaticTheory.html
        ///</summary>
        public static Engine AxiomaticTheory(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("AxiomaticTheory[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the specified property of an axiomatic theory.
        ///https://reference.wolfram.com/language/ref/AxiomaticTheory.html
        ///</summary>
        public static Engine AxiomaticTheory(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AxiomaticTheory[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a Graphics primitive that represents an axis with a quantitative scale along the path path.
        ///https://reference.wolfram.com/language/ref/AxisObject.html
        ///</summary>
        public static Engine AxisObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("AxisObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the scale specified by scale.
        ///https://reference.wolfram.com/language/ref/AxisObject.html
        ///</summary>
        public static Engine AxisObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("AxisObject[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}
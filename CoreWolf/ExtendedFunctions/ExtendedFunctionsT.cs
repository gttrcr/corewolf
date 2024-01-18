namespace CoreWolf
{
    public static class ExtendedFunctionsT
    {
        ///<summary>
        /// prints with the elements of list arranged in an array of rectangular cells.
        /// https://reference.wolfram.com/language/ref/TableForm.html
        ///</summary>
        public static Engine TableForm(this Engine en, string? name = null)
        {
            return en.Execute("TableForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// takes the contents of the table view to be the dynamically updated current value of x, with the value of x being reset as the table view is interactively edited.
        /// https://reference.wolfram.com/language/ref/TableView.html
        ///</summary>
        public static Engine TableView(this Engine en, string? name = null)
        {
            return en.Execute("TableView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an object in which clicking the tab with label lbli displays expri.
        /// https://reference.wolfram.com/language/ref/TabView.html
        ///</summary>
        public static Engine TabView(this Engine en, string? name = null)
        {
            return en.Execute("TabView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TakeLargest that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/TakeLargest.html
        ///</summary>
        public static Engine TakeLargest(this Engine en, string? name = null)
        {
            return en.Execute("TakeLargest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TakeSmallest that can be applied to an expression.
        /// https://reference.wolfram.com/language/ref/TakeSmallest.html
        ///</summary>
        public static Engine TakeSmallest(this Engine en, string? name = null)
        {
            return en.Execute("TakeSmallest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tallies the elements in list, listing all distinct elements together with their multiplicities.
        /// https://reference.wolfram.com/language/ref/Tally.html
        ///</summary>
        public static Engine Tally(this Engine en, string? name = null)
        {
            return en.Execute("Tally[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the tangent of .
        /// https://reference.wolfram.com/language/ref/Tan.html
        ///</summary>
        public static Engine Tan(this Engine en, string? name = null)
        {
            return en.Execute("Tan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the hyperbolic tangent of .
        /// https://reference.wolfram.com/language/ref/Tanh.html
        ///</summary>
        public static Engine Tanh(this Engine en, string? name = null)
        {
            return en.Execute("Tanh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates an interrupt to abort the current execution of a task.
        /// https://reference.wolfram.com/language/ref/TaskAbort.html
        ///</summary>
        public static Engine TaskAbort(this Engine en, string? name = null)
        {
            return en.Execute("TaskAbort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// immediately executes an instance of the specified task, independently of any schedule given.
        /// https://reference.wolfram.com/language/ref/TaskExecute.html
        ///</summary>
        public static Engine TaskExecute(this Engine en, string? name = null)
        {
            return en.Execute("TaskExecute[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an object that represents a background task.
        /// https://reference.wolfram.com/language/ref/TaskObject.html
        ///</summary>
        public static Engine TaskObject(this Engine en, string? name = null)
        {
            return en.Execute("TaskObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// terminates and removes the specified task.
        /// https://reference.wolfram.com/language/ref/TaskRemove.html
        ///</summary>
        public static Engine TaskRemove(this Engine en, string? name = null)
        {
            return en.Execute("TaskRemove[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// resumes execution of the specified task.
        /// https://reference.wolfram.com/language/ref/TaskResume.html
        ///</summary>
        public static Engine TaskResume(this Engine en, string? name = null)
        {
            return en.Execute("TaskResume[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of TaskObject expressions representing currently submitted tasks of given type.
        /// https://reference.wolfram.com/language/ref/Tasks.html
        ///</summary>
        public static Engine Tasks(this Engine en, string? name = null)
        {
            return en.Execute("Tasks[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// suspends the execution of the specified task.
        /// https://reference.wolfram.com/language/ref/TaskSuspend.html
        ///</summary>
        public static Engine TaskSuspend(this Engine en, string? name = null)
        {
            return en.Execute("TaskSuspend[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// waits for the specified task to be completely finished.
        /// https://reference.wolfram.com/language/ref/TaskWait.html
        ///</summary>
        public static Engine TaskWait(this Engine en, string? name = null)
        {
            return en.Execute("TaskWait[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if all combinations of values of variables make the Boolean function bf yield True.
        /// https://reference.wolfram.com/language/ref/TautologyQ.html
        ///</summary>
        public static Engine TautologyQ(this Engine en, string? name = null)
        {
            return en.Execute("TautologyQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a telegraph process with rate μ.
        /// https://reference.wolfram.com/language/ref/TelegraphProcess.html
        ///</summary>
        public static Engine TelegraphProcess(this Engine en, string? name = null)
        {
            return en.Execute("TelegraphProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// applies a template, evaluating all template elements it contains.
        /// https://reference.wolfram.com/language/ref/TemplateApply.html
        ///</summary>
        public static Engine TemplateApply(this Engine en, string? name = null)
        {
            return en.Execute("TemplateApply[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an expression held until a template is applied, and then evaluated.
        /// https://reference.wolfram.com/language/ref/TemplateExpression.html
        ///</summary>
        public static Engine TemplateExpression(this Engine en, string? name = null)
        {
            return en.Execute("TemplateExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a template object to be applied using functions like TemplateApply.
        /// https://reference.wolfram.com/language/ref/TemplateObject.html
        ///</summary>
        public static Engine TemplateObject(this Engine en, string? name = null)
        {
            return en.Execute("TemplateObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a template slot to be filled from the n argument when the template is applied.
        /// https://reference.wolfram.com/language/ref/TemplateSlot.html
        ///</summary>
        public static Engine TemplateSlot(this Engine en, string? name = null)
        {
            return en.Execute("TemplateSlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the list of dimensions of tensor.
        /// https://reference.wolfram.com/language/ref/TensorDimensions.html
        ///</summary>
        public static Engine TensorDimensions(this Engine en, string? name = null)
        {
            return en.Execute("TensorDimensions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// expands out tensor-related products in the symbolic tensor expression texpr.
        /// https://reference.wolfram.com/language/ref/TensorExpand.html
        ///</summary>
        public static Engine TensorExpand(this Engine en, string? name = null)
        {
            return en.Execute("TensorExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the rank of tensor.
        /// https://reference.wolfram.com/language/ref/TensorRank.html
        ///</summary>
        public static Engine TensorRank(this Engine en, string? name = null)
        {
            return en.Execute("TensorRank[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// attempts to return a canonical form for the symbolic tensor expression texpr.
        /// https://reference.wolfram.com/language/ref/TensorReduce.html
        ///</summary>
        public static Engine TensorReduce(this Engine en, string? name = null)
        {
            return en.Execute("TensorReduce[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the symmetry of tensor under permutations of its slots.
        /// https://reference.wolfram.com/language/ref/TensorSymmetry.html
        ///</summary>
        public static Engine TensorSymmetry(this Engine en, string? name = null)
        {
            return en.Execute("TensorSymmetry[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots a ternary plot with several datasets datai.
        /// https://reference.wolfram.com/language/ref/TernaryListPlot.html
        ///</summary>
        public static Engine TernaryListPlot(this Engine en, string? name = null)
        {
            return en.Execute("TernaryListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// runs tests from a file, returning an analysis of the completed test run.
        /// https://reference.wolfram.com/language/ref/TestReport.html
        ///</summary>
        public static Engine TestReport(this Engine en, string? name = null)
        {
            return en.Execute("TestReport[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an object that represents the results of a VerificationTest.
        /// https://reference.wolfram.com/language/ref/TestResultObject.html
        ///</summary>
        public static Engine TestResultObject(this Engine en, string? name = null)
        {
            return en.Execute("TestResultObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a tetrahedron with edge length l.
        /// https://reference.wolfram.com/language/ref/Tetrahedron.html
        ///</summary>
        public static Engine Tetrahedron(this Engine en, string? name = null)
        {
            return en.Execute("Tetrahedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints as a  version of expr.
        /// https://reference.wolfram.com/language/ref/TeXForm.html
        ///</summary>
        public static Engine TeXForm(this Engine en, string? name = null)
        {
            return en.Execute("TeXForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays with expr in plain text format.
        /// https://reference.wolfram.com/language/ref/Text.html
        ///</summary>
        public static Engine Text(this Engine en, string? name = null)
        {
            return en.Execute("Text[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a text cell that can appear in a Wolfram System notebook.
        /// https://reference.wolfram.com/language/ref/TextCell.html
        ///</summary>
        public static Engine TextCell(this Engine en, string? name = null)
        {
            return en.Execute("TextCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a dataset of information about entities, dates, quantities and other content-related elements found in text.
        /// https://reference.wolfram.com/language/ref/TextContents.html
        ///</summary>
        public static Engine TextContents(this Engine en, string? name = null)
        {
            return en.Execute("TextContents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a low-level representation of the contents of a textual cell.
        /// https://reference.wolfram.com/language/ref/TextData.html
        ///</summary>
        public static Engine TextData(this Engine en, string? name = null)
        {
            return en.Execute("TextData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents text where no properties are specified.
        /// https://reference.wolfram.com/language/ref/TextElement.html
        ///</summary>
        public static Engine TextElement(this Engine en, string? name = null)
        {
            return en.Execute("TextElement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a WSTP packet containing string, the text output from the Wolfram System as produced by functions such as Print.
        /// https://reference.wolfram.com/language/ref/TextPacket.html
        ///</summary>
        public static Engine TextPacket(this Engine en, string? name = null)
        {
            return en.Execute("TextPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// recognizes text in image and returns it as a string.
        /// https://reference.wolfram.com/language/ref/TextRecognize.html
        ///</summary>
        public static Engine TextRecognize(this Engine en, string? name = null)
        {
            return en.Execute("TextRecognize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the runs of characters identified as sentences in string.
        /// https://reference.wolfram.com/language/ref/TextSentences.html
        ///</summary>
        public static Engine TextSentences(this Engine en, string? name = null)
        {
            return en.Execute("TextSentences[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a human-readable string representation of expr.
        /// https://reference.wolfram.com/language/ref/TextString.html
        ///</summary>
        public static Engine TextString(this Engine en, string? name = null)
        {
            return en.Execute("TextString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a nested collection of TextElement objects representing the grammatical structure of natural language text.
        /// https://reference.wolfram.com/language/ref/TextStructure.html
        ///</summary>
        public static Engine TextStructure(this Engine en, string? name = null)
        {
            return en.Execute("TextStructure[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// translates text into the current default language.
        /// https://reference.wolfram.com/language/ref/TextTranslation.html
        ///</summary>
        public static Engine TextTranslation(this Engine en, string? name = null)
        {
            return en.Execute("TextTranslation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive that specifies that obj should be used as a texture on faces of polygons and other filled graphics objects.
        /// https://reference.wolfram.com/language/ref/Texture.html
        ///</summary>
        public static Engine Texture(this Engine en, string? name = null)
        {
            return en.Execute("Texture[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the runs of characters identified as words in string.
        /// https://reference.wolfram.com/language/ref/TextWords.html
        ///</summary>
        public static Engine TextWords(this Engine en, string? name = null)
        {
            return en.Execute("TextWords[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// draws a thermometer showing value in a range of 0 to 1.
        /// https://reference.wolfram.com/language/ref/ThermometerGauge.html
        ///</summary>
        public static Engine ThermometerGauge(this Engine en, string? name = null)
        {
            return en.Execute("ThermometerGauge[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a graphics directive which specifies that lines which follow are to be drawn with thickness r. The thickness r is given as a fraction of the horizontal plot range.
        /// https://reference.wolfram.com/language/ref/Thickness.html
        ///</summary>
        public static Engine Thickness(this Engine en, string? name = null)
        {
            return en.Execute("Thickness[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds the skeletons of foreground regions in image by applying morphological thinning until convergence.
        /// https://reference.wolfram.com/language/ref/Thinning.html
        ///</summary>
        public static Engine Thinning(this Engine en, string? name = null)
        {
            return en.Execute("Thinning[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// "threads" f over any lists that appear in args.
        /// https://reference.wolfram.com/language/ref/Thread.html
        ///</summary>
        public static Engine Thread(this Engine en, string? name = null)
        {
            return en.Execute("Thread[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an object whose elements will automatically be threaded into the lowest level of an array when used in a listable operation such as Plus.
        /// https://reference.wolfram.com/language/ref/Threaded.html
        ///</summary>
        public static Engine Threaded(this Engine en, string? name = null)
        {
            return en.Execute("Threaded[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net layer that takes several input arrays and applies a function f to corresponding array elements.
        /// https://reference.wolfram.com/language/ref/ThreadingLayer.html
        ///</summary>
        public static Engine ThreadingLayer(this Engine en, string? name = null)
        {
            return en.Execute("ThreadingLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// thresholds data by replacing values close to zero by zero.
        /// https://reference.wolfram.com/language/ref/Threshold.html
        ///</summary>
        public static Engine Threshold(this Engine en, string? name = null)
        {
            return en.Execute("Threshold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives p[f1[x],f2[x]].
        /// https://reference.wolfram.com/language/ref/Through.html
        ///</summary>
        public static Engine Through(this Engine en, string? name = null)
        {
            return en.Execute("Through[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// stops evaluation and returns value as the value of the nearest enclosing Catch.
        /// https://reference.wolfram.com/language/ref/Throw.html
        ///</summary>
        public static Engine Throw(this Engine en, string? name = null)
        {
            return en.Execute("Throw[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n term in the Thue–Morse sequence.
        /// https://reference.wolfram.com/language/ref/ThueMorse.html
        ///</summary>
        public static Engine ThueMorse(this Engine en, string? name = null)
        {
            return en.Execute("ThueMorse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a thumbnail version of an image.
        /// https://reference.wolfram.com/language/ref/Thumbnail.html
        ///</summary>
        public static Engine Thumbnail(this Engine en, string? name = null)
        {
            return en.Execute("Thumbnail[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the tidal properties for a location or a set of tidal parameters.
        /// https://reference.wolfram.com/language/ref/TideData.html
        ///</summary>
        public static Engine TideData(this Engine en, string? name = null)
        {
            return en.Execute("TideData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes a timeline plot with dates date1, date2, ….
        /// https://reference.wolfram.com/language/ref/TimelinePlot.html
        ///</summary>
        public static Engine TimelinePlot(this Engine en, string? name = null)
        {
            return en.Execute("TimelinePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a time object of standard normalized form.
        /// https://reference.wolfram.com/language/ref/TimeObject.html
        ///</summary>
        public static Engine TimeObject(this Engine en, string? name = null)
        {
            return en.Execute("TimeObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is a TimeObject with valid arguments, and False otherwise.
        /// https://reference.wolfram.com/language/ref/TimeObjectQ.html
        ///</summary>
        public static Engine TimeObjectQ(this Engine en, string? name = null)
        {
            return en.Execute("TimeObjectQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives conditions for the time series process tproc to be invertible.
        /// https://reference.wolfram.com/language/ref/TimeSeriesInvertibility.html
        ///</summary>
        public static Engine TimeSeriesInvertibility(this Engine en, string? name = null)
        {
            return en.Execute("TimeSeriesInvertibility[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the symbolic time series model obtained from TimeSeriesModelFit.
        /// https://reference.wolfram.com/language/ref/TimeSeriesModel.html
        ///</summary>
        public static Engine TimeSeriesModel(this Engine en, string? name = null)
        {
            return en.Execute("TimeSeriesModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// constructs a time series model for data from an automatically selected model family.
        /// https://reference.wolfram.com/language/ref/TimeSeriesModelFit.html
        ///</summary>
        public static Engine TimeSeriesModelFit(this Engine en, string? name = null)
        {
            return en.Execute("TimeSeriesModelFit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uniformly resamples tseries according to its minimum time increment.
        /// https://reference.wolfram.com/language/ref/TimeSeriesResample.html
        ///</summary>
        public static Engine TimeSeriesResample(this Engine en, string? name = null)
        {
            return en.Execute("TimeSeriesResample[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts to the default time system.
        /// https://reference.wolfram.com/language/ref/TimeSystemConvert.html
        ///</summary>
        public static Engine TimeSystemConvert(this Engine en, string? name = null)
        {
            return en.Execute("TimeSystemConvert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts to the current $TimeZone value.
        /// https://reference.wolfram.com/language/ref/TimeZoneConvert.html
        ///</summary>
        public static Engine TimeZoneConvert(this Engine en, string? name = null)
        {
            return en.Execute("TimeZoneConvert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the numeric offset between the time zone tz and GMT on the current date.
        /// https://reference.wolfram.com/language/ref/TimeZoneOffset.html
        ///</summary>
        public static Engine TimeZoneOffset(this Engine en, string? name = null)
        {
            return en.Execute("TimeZoneOffset[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates expr, and returns a list of the time in seconds used, together with the result obtained.
        /// https://reference.wolfram.com/language/ref/Timing.html
        ///</summary>
        public static Engine Timing(this Engine en, string? name = null)
        {
            return en.Execute("Timing[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates boxes corresponding to the printed form of expr in StandardForm.
        /// https://reference.wolfram.com/language/ref/ToBoxes.html
        ///</summary>
        public static Engine ToBoxes(this Engine en, string? name = null)
        {
            return en.Execute("ToBoxes[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the integer codes corresponding to the characters in a string.
        /// https://reference.wolfram.com/language/ref/ToCharacterCode.html
        ///</summary>
        public static Engine ToCharacterCode(this Engine en, string? name = null)
        {
            return en.Execute("ToCharacterCode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the continuous-time approximation of the discrete-time systems models lsys.
        /// https://reference.wolfram.com/language/ref/ToContinuousTimeModel.html
        ///</summary>
        public static Engine ToContinuousTimeModel(this Engine en, string? name = null)
        {
            return en.Execute("ToContinuousTimeModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns an entity object corresponding to the given expression.
        /// https://reference.wolfram.com/language/ref/ToEntity.html
        ///</summary>
        public static Engine ToEntity(this Engine en, string? name = null)
        {
            return en.Execute("ToEntity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the n×n Toeplitz matrix with first row and first column being successive integers.
        /// https://reference.wolfram.com/language/ref/ToeplitzMatrix.html
        ///</summary>
        public static Engine ToeplitzMatrix(this Engine en, string? name = null)
        {
            return en.Execute("ToeplitzMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the expression obtained by interpreting strings or boxes as Wolfram Language input.
        /// https://reference.wolfram.com/language/ref/ToExpression.html
        ///</summary>
        public static Engine ToExpression(this Engine en, string? name = null)
        {
            return en.Execute("ToExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// puts terms in a sum over a common denominator, and cancels factors in the result.
        /// https://reference.wolfram.com/language/ref/Together.html
        ///</summary>
        public static Engine Together(this Engine en, string? name = null)
        {
            return en.Execute("Together[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a toggler button with setting x, that toggles between True and False.
        /// https://reference.wolfram.com/language/ref/Toggler.html
        ///</summary>
        public static Engine Toggler(this Engine en, string? name = null)
        {
            return en.Execute("Toggler[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns an invertible version of a time series process tproc.
        /// https://reference.wolfram.com/language/ref/ToInvertibleTimeSeries.html
        ///</summary>
        public static Engine ToInvertibleTimeSeries(this Engine en, string? name = null)
        {
            return en.Execute("ToInvertibleTimeSeries[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a string in which all letters have been converted to lowercase.
        /// https://reference.wolfram.com/language/ref/ToLowerCase.html
        ///</summary>
        public static Engine ToLowerCase(this Engine en, string? name = null)
        {
            return en.Execute("ToLowerCase[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// expresses the ai in a common extension field generated by a single algebraic number.
        /// https://reference.wolfram.com/language/ref/ToNumberField.html
        ///</summary>
        public static Engine ToNumberField(this Engine en, string? name = null)
        {
            return en.Execute("ToNumberField[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uses the color col as base color.
        /// https://reference.wolfram.com/language/ref/ToonShading.html
        ///</summary>
        public static Engine ToonShading(this Engine en, string? name = null)
        {
            return en.Execute("ToonShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the {r,θ} polar coordinates corresponding to the Cartesian coordinates {x,y}.
        /// https://reference.wolfram.com/language/ref/ToPolarCoordinates.html
        ///</summary>
        public static Engine ToPolarCoordinates(this Engine en, string? name = null)
        {
            return en.Execute("ToPolarCoordinates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of vertices of g in topologically sorted order for a directed acyclic graph g.
        /// https://reference.wolfram.com/language/ref/TopologicalSort.html
        ///</summary>
        public static Engine TopologicalSort(this Engine en, string? name = null)
        {
            return en.Execute("TopologicalSort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// attempts to express all Root objects in expr in terms of radicals.
        /// https://reference.wolfram.com/language/ref/ToRadicals.html
        ///</summary>
        public static Engine ToRadicals(this Engine en, string? name = null)
        {
            return en.Execute("ToRadicals[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a new object pointing to the initial value val.
        /// https://reference.wolfram.com/language/ref/ToRawPointer.html
        ///</summary>
        public static Engine ToRawPointer(this Engine en, string? name = null)
        {
            return en.Execute("ToRawPointer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// takes logical combinations of equations, in the form generated by Roots and Reduce, and converts them to lists of rules, of the form produced by Solve.
        /// https://reference.wolfram.com/language/ref/ToRules.html
        ///</summary>
        public static Engine ToRules(this Engine en, string? name = null)
        {
            return en.Execute("ToRules[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the k-dimensional torus graph with n1×n2×…×nk vertices.
        /// https://reference.wolfram.com/language/ref/TorusGraph.html
        ///</summary>
        public static Engine TorusGraph(this Engine en, string? name = null)
        {
            return en.Execute("TorusGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the {r,θ,ϕ} spherical coordinates corresponding to the Cartesian coordinates {x,y,z}.
        /// https://reference.wolfram.com/language/ref/ToSphericalCoordinates.html
        ///</summary>
        public static Engine ToSphericalCoordinates(this Engine en, string? name = null)
        {
            return en.Execute("ToSphericalCoordinates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a string corresponding to the printed form of expr in OutputForm.
        /// https://reference.wolfram.com/language/ref/ToString.html
        ///</summary>
        public static Engine ToString(this Engine en, string? name = null)
        {
            return en.Execute("ToString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the total of the elements in list.
        /// https://reference.wolfram.com/language/ref/Total.html
        ///</summary>
        public static Engine Total(this Engine en, string? name = null)
        {
            return en.Execute("Total[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// iteratively reduces noise while preserving rapid transitions in data.
        /// https://reference.wolfram.com/language/ref/TotalVariationFilter.html
        ///</summary>
        public static Engine TotalVariationFilter(this Engine en, string? name = null)
        {
            return en.Execute("TotalVariationFilter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the touch positions with respect to the specified coordinate system.
        /// https://reference.wolfram.com/language/ref/TouchPosition.html
        ///</summary>
        public static Engine TouchPosition(this Engine en, string? name = null)
        {
            return en.Execute("TouchPosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a string in which all letters have been converted to uppercase.
        /// https://reference.wolfram.com/language/ref/ToUpperCase.html
        ///</summary>
        public static Engine ToUpperCase(this Engine en, string? name = null)
        {
            return en.Execute("ToUpperCase[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds the trace of the matrix or tensor list.
        /// https://reference.wolfram.com/language/ref/Tr.html
        ///</summary>
        public static Engine Tr(this Engine en, string? name = null)
        {
            return en.Execute("Tr[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a list of all expressions used in the evaluation of expr.
        /// https://reference.wolfram.com/language/ref/Trace.html
        ///</summary>
        public static Engine Trace(this Engine en, string? name = null)
        {
            return en.Execute("Trace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// initiates a dialog for every expression used in the evaluation of expr.
        /// https://reference.wolfram.com/language/ref/TraceDialog.html
        ///</summary>
        public static Engine TraceDialog(this Engine en, string? name = null)
        {
            return en.Execute("TraceDialog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints all expressions used in the evaluation of expr.
        /// https://reference.wolfram.com/language/ref/TracePrint.html
        ///</summary>
        public static Engine TracePrint(this Engine en, string? name = null)
        {
            return en.Execute("TracePrint[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Tracy–Widom distribution with Dyson index β.
        /// https://reference.wolfram.com/language/ref/TracyWidomDistribution.html
        ///</summary>
        public static Engine TracyWidomDistribution(this Engine en, string? name = null)
        {
            return en.Execute("TracyWidomDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes a financial chart for the financial entity "name" over the daterange.
        /// https://reference.wolfram.com/language/ref/TradingChart.html
        ///</summary>
        public static Engine TradingChart(this Engine en, string? name = null)
        {
            return en.Execute("TradingChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints as an approximation to the traditional mathematical notation for expr.
        /// https://reference.wolfram.com/language/ref/TraditionalForm.html
        ///</summary>
        public static Engine TraditionalForm(this Engine en, string? name = null)
        {
            return en.Execute("TraditionalForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// trains a ContentDetectorFunction[…] based on the examples given.
        /// https://reference.wolfram.com/language/ref/TrainImageContentDetector.html
        ///</summary>
        public static Engine TrainImageContentDetector(this Engine en, string? name = null)
        {
            return en.Execute("TrainImageContentDetector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// trains a ContentDetectorFunction[…] based on the examples given.
        /// https://reference.wolfram.com/language/ref/TrainTextContentDetector.html
        ///</summary>
        public static Engine TrainTextContentDetector(this Engine en, string? name = null)
        {
            return en.Execute("TrainTextContentDetector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// cancels common poles and zeros in the TransferFunctionModel tfm.
        /// https://reference.wolfram.com/language/ref/TransferFunctionCancel.html
        ///</summary>
        public static Engine TransferFunctionCancel(this Engine en, string? name = null)
        {
            return en.Execute("TransferFunctionCancel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// expands polynomial terms in the numerators and denominators of the TransferFunctionModel tfm.
        /// https://reference.wolfram.com/language/ref/TransferFunctionExpand.html
        ///</summary>
        public static Engine TransferFunctionExpand(this Engine en, string? name = null)
        {
            return en.Execute("TransferFunctionExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// factors the polynomial terms in the numerators and denominators of the TransferFunctionModel tfm.
        /// https://reference.wolfram.com/language/ref/TransferFunctionFactor.html
        ///</summary>
        public static Engine TransferFunctionFactor(this Engine en, string? name = null)
        {
            return en.Execute("TransferFunctionFactor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the transfer-function model of the systems model sys.
        /// https://reference.wolfram.com/language/ref/TransferFunctionModel.html
        ///</summary>
        public static Engine TransferFunctionModel(this Engine en, string? name = null)
        {
            return en.Execute("TransferFunctionModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a matrix of roots of the denominators in the TransferFunctionModel tfm.
        /// https://reference.wolfram.com/language/ref/TransferFunctionPoles.html
        ///</summary>
        public static Engine TransferFunctionPoles(this Engine en, string? name = null)
        {
            return en.Execute("TransferFunctionPoles[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a matrix of roots of the numerators in the TransferFunctionModel tfm.
        /// https://reference.wolfram.com/language/ref/TransferFunctionZeros.html
        ///</summary>
        public static Engine TransferFunctionZeros(this Engine en, string? name = null)
        {
            return en.Execute("TransferFunctionZeros[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a transformation function that applies geometric and other transformations.
        /// https://reference.wolfram.com/language/ref/TransformationFunction.html
        ///</summary>
        public static Engine TransformationFunction(this Engine en, string? name = null)
        {
            return en.Execute("TransformationFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the homogeneous matrix associated with a TransformationFunction object.
        /// https://reference.wolfram.com/language/ref/TransformationMatrix.html
        ///</summary>
        public static Engine TransformationMatrix(this Engine en, string? name = null)
        {
            return en.Execute("TransformationMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the transitive closure of the graph g.
        /// https://reference.wolfram.com/language/ref/TransitiveClosureGraph.html
        ///</summary>
        public static Engine TransitiveClosureGraph(this Engine en, string? name = null)
        {
            return en.Execute("TransitiveClosureGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a transitive reduction of the graph g.
        /// https://reference.wolfram.com/language/ref/TransitiveReductionGraph.html
        ///</summary>
        public static Engine TransitiveReductionGraph(this Engine en, string? name = null)
        {
            return en.Execute("TransitiveReductionGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a TransformationFunction that represents translation of points by a vector v.
        /// https://reference.wolfram.com/language/ref/TranslationTransform.html
        ///</summary>
        public static Engine TranslationTransform(this Engine en, string? name = null)
        {
            return en.Execute("TranslationTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// attempts to transliterate string into plain ASCII.
        /// https://reference.wolfram.com/language/ref/Transliterate.html
        ///</summary>
        public static Engine Transliterate(this Engine en, string? name = null)
        {
            return en.Execute("Transliterate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// transposes the first two levels in list.
        /// https://reference.wolfram.com/language/ref/Transpose.html
        ///</summary>
        public static Engine Transpose(this Engine en, string? name = null)
        {
            return en.Execute("Transpose[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net layer that transposes levels m and n of its input.
        /// https://reference.wolfram.com/language/ref/TransposeLayer.html
        ///</summary>
        public static Engine TransposeLayer(this Engine en, string? name = null)
        {
            return en.Execute("TransposeLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates directions for travel from loc1 to loc2, ….
        /// https://reference.wolfram.com/language/ref/TravelDirections.html
        ///</summary>
        public static Engine TravelDirections(this Engine en, string? name = null)
        {
            return en.Execute("TravelDirections[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents travel directions generated by TravelDirections.
        /// https://reference.wolfram.com/language/ref/TravelDirectionsData.html
        ///</summary>
        public static Engine TravelDirectionsData(this Engine en, string? name = null)
        {
            return en.Execute("TravelDirectionsData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the estimated distance for travel from loc1 to loc2, ….
        /// https://reference.wolfram.com/language/ref/TravelDistance.html
        ///</summary>
        public static Engine TravelDistance(this Engine en, string? name = null)
        {
            return en.Execute("TravelDistance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the list {TravelDistance[loc1,loc2],…,TravelDistance[locn-1,locn]}.
        /// https://reference.wolfram.com/language/ref/TravelDistanceList.html
        ///</summary>
        public static Engine TravelDistanceList(this Engine en, string? name = null)
        {
            return en.Execute("TravelDistanceList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the estimated time to travel from loc1 to loc2, ….
        /// https://reference.wolfram.com/language/ref/TravelTime.html
        ///</summary>
        public static Engine TravelTime(this Engine en, string? name = null)
        {
            return en.Execute("TravelTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a tree with a list of child subtrees subtreei.
        /// https://reference.wolfram.com/language/ref/Tree.html
        ///</summary>
        public static Engine Tree(this Engine en, string? name = null)
        {
            return en.Execute("Tree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeCases that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeCases.html
        ///</summary>
        public static Engine TreeCases(this Engine en, string? name = null)
        {
            return en.Execute("TreeCases[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// extracts the children of the root of the Tree object tree.
        /// https://reference.wolfram.com/language/ref/TreeChildren.html
        ///</summary>
        public static Engine TreeChildren(this Engine en, string? name = null)
        {
            return en.Execute("TreeChildren[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeCount that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeCount.html
        ///</summary>
        public static Engine TreeCount(this Engine en, string? name = null)
        {
            return en.Execute("TreeCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// extracts the data in the root of the Tree object tree.
        /// https://reference.wolfram.com/language/ref/TreeData.html
        ///</summary>
        public static Engine TreeData(this Engine en, string? name = null)
        {
            return en.Execute("TreeData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeDelete that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeDelete.html
        ///</summary>
        public static Engine TreeDelete(this Engine en, string? name = null)
        {
            return en.Execute("TreeDelete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the maximum level of tree.
        /// https://reference.wolfram.com/language/ref/TreeDepth.html
        ///</summary>
        public static Engine TreeDepth(this Engine en, string? name = null)
        {
            return en.Execute("TreeDepth[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an expression from the structure of the Tree object tree.
        /// https://reference.wolfram.com/language/ref/TreeExpression.html
        ///</summary>
        public static Engine TreeExpression(this Engine en, string? name = null)
        {
            return en.Execute("TreeExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeExtract that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeExtract.html
        ///</summary>
        public static Engine TreeExtract(this Engine en, string? name = null)
        {
            return en.Execute("TreeExtract[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeFold that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeFold.html
        ///</summary>
        public static Engine TreeFold(this Engine en, string? name = null)
        {
            return en.Execute("TreeFold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays expr as a tree with different levels at different depths.
        /// https://reference.wolfram.com/language/ref/TreeForm.html
        ///</summary>
        public static Engine TreeForm(this Engine en, string? name = null)
        {
            return en.Execute("TreeForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields a tree with edges ej.
        /// https://reference.wolfram.com/language/ref/TreeGraph.html
        ///</summary>
        public static Engine TreeGraph(this Engine en, string? name = null)
        {
            return en.Execute("TreeGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if the graph g is a tree and False otherwise.
        /// https://reference.wolfram.com/language/ref/TreeGraphQ.html
        ///</summary>
        public static Engine TreeGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("TreeGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of leaves of tree.
        /// https://reference.wolfram.com/language/ref/TreeLeafCount.html
        ///</summary>
        public static Engine TreeLeafCount(this Engine en, string? name = null)
        {
            return en.Execute("TreeLeafCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if tree is a Tree object with no children, and gives False otherwise.
        /// https://reference.wolfram.com/language/ref/TreeLeafQ.html
        ///</summary>
        public static Engine TreeLeafQ(this Engine en, string? name = null)
        {
            return en.Execute("TreeLeafQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the list of leaves of the tree tree.
        /// https://reference.wolfram.com/language/ref/TreeLeaves.html
        ///</summary>
        public static Engine TreeLeaves(this Engine en, string? name = null)
        {
            return en.Execute("TreeLeaves[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeLevel that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeLevel.html
        ///</summary>
        public static Engine TreeLevel(this Engine en, string? name = null)
        {
            return en.Execute("TreeLevel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeMap that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeMap.html
        ///</summary>
        public static Engine TreeMap(this Engine en, string? name = null)
        {
            return en.Execute("TreeMap[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an outline of the data in tree as a nested OpenerView.
        /// https://reference.wolfram.com/language/ref/TreeOutline.html
        ///</summary>
        public static Engine TreeOutline(this Engine en, string? name = null)
        {
            return en.Execute("TreeOutline[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreePosition that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreePosition.html
        ///</summary>
        public static Engine TreePosition(this Engine en, string? name = null)
        {
            return en.Execute("TreePosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if tree is a valid Tree object and False otherwise.
        /// https://reference.wolfram.com/language/ref/TreeQ.html
        ///</summary>
        public static Engine TreeQ(this Engine en, string? name = null)
        {
            return en.Execute("TreeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeReplacePart that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeReplacePart.html
        ///</summary>
        public static Engine TreeReplacePart(this Engine en, string? name = null)
        {
            return en.Execute("TreeReplacePart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the rules associated with the Tree object tree.
        /// https://reference.wolfram.com/language/ref/TreeRules.html
        ///</summary>
        public static Engine TreeRules(this Engine en, string? name = null)
        {
            return en.Execute("TreeRules[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeScan that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeScan.html
        ///</summary>
        public static Engine TreeScan(this Engine en, string? name = null)
        {
            return en.Execute("TreeScan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of TreeSelect that can be applied to a tree.
        /// https://reference.wolfram.com/language/ref/TreeSelect.html
        ///</summary>
        public static Engine TreeSelect(this Engine en, string? name = null)
        {
            return en.Execute("TreeSelect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of subtrees of tree.
        /// https://reference.wolfram.com/language/ref/TreeSize.html
        ///</summary>
        public static Engine TreeSize(this Engine en, string? name = null)
        {
            return en.Execute("TreeSize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a filled triangle with corner points p1, p2, and p3.
        /// https://reference.wolfram.com/language/ref/Triangle.html
        ///</summary>
        public static Engine Triangle(this Engine en, string? name = null)
        {
            return en.Execute("Triangle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the centroid of the triangle.
        /// https://reference.wolfram.com/language/ref/TriangleCenter.html
        ///</summary>
        public static Engine TriangleCenter(this Engine en, string? name = null)
        {
            return en.Execute("TriangleCenter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a triangle wave that varies between  and  with unit period.
        /// https://reference.wolfram.com/language/ref/TriangleWave.html
        ///</summary>
        public static Engine TriangleWave(this Engine en, string? name = null)
        {
            return en.Execute("TriangleWave[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a symmetric triangular statistical distribution giving values between min and max.
        /// https://reference.wolfram.com/language/ref/TriangularDistribution.html
        ///</summary>
        public static Engine TriangularDistribution(this Engine en, string? name = null)
        {
            return en.Execute("TriangularDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a triangulation of the mesh region mr.
        /// https://reference.wolfram.com/language/ref/TriangulateMesh.html
        ///</summary>
        public static Engine TriangulateMesh(this Engine en, string? name = null)
        {
            return en.Execute("TriangulateMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// expands out trigonometric functions in expr.
        /// https://reference.wolfram.com/language/ref/TrigExpand.html
        ///</summary>
        public static Engine TrigExpand(this Engine en, string? name = null)
        {
            return en.Execute("TrigExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// factors trigonometric functions in expr.
        /// https://reference.wolfram.com/language/ref/TrigFactor.html
        ///</summary>
        public static Engine TrigFactor(this Engine en, string? name = null)
        {
            return en.Execute("TrigFactor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// factors trigonometric functions in expr, yielding a list of lists containing trigonometric monomials and exponents.
        /// https://reference.wolfram.com/language/ref/TrigFactorList.html
        ///</summary>
        public static Engine TrigFactorList(this Engine en, string? name = null)
        {
            return en.Execute("TrigFactorList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a trigger that can be pressed to make the dynamically updated value of u be continually increased with time from 0 to 1.
        /// https://reference.wolfram.com/language/ref/Trigger.html
        ///</summary>
        public static Engine Trigger(this Engine en, string? name = null)
        {
            return en.Execute("Trigger[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// rewrites products and powers of trigonometric functions in expr in terms of trigonometric functions with combined arguments.
        /// https://reference.wolfram.com/language/ref/TrigReduce.html
        ///</summary>
        public static Engine TrigReduce(this Engine en, string? name = null)
        {
            return en.Execute("TrigReduce[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts trigonometric functions in expr to exponentials.
        /// https://reference.wolfram.com/language/ref/TrigToExp.html
        ///</summary>
        public static Engine TrigToExp(this Engine en, string? name = null)
        {
            return en.Execute("TrigToExp[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the 5% trimmed mean TrimmedMean[list,0.05].
        /// https://reference.wolfram.com/language/ref/TrimmedMean.html
        ///</summary>
        public static Engine TrimmedMean(this Engine en, string? name = null)
        {
            return en.Execute("TrimmedMean[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the 5% trimmed variance TrimmedVariance[list,0.05].
        /// https://reference.wolfram.com/language/ref/TrimmedVariance.html
        ///</summary>
        public static Engine TrimmedVariance(this Engine en, string? name = null)
        {
            return en.Execute("TrimmedVariance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if expr is True, and yields False otherwise.
        /// https://reference.wolfram.com/language/ref/TrueQ.html
        ///</summary>
        public static Engine TrueQ(this Engine en, string? name = null)
        {
            return en.Execute("TrueQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the truncated polyhedron of poly by truncating all vertices.
        /// https://reference.wolfram.com/language/ref/TruncatedPolyhedron.html
        ///</summary>
        public static Engine TruncatedPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("TruncatedPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Tsallis -Gaussian distribution with mean 0 and scale parameter 1.
        /// https://reference.wolfram.com/language/ref/TsallisQGaussianDistribution.html
        ///</summary>
        public static Engine TsallisQGaussianDistribution(this Engine en, string? name = null)
        {
            return en.Execute("TsallisQGaussianDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether the mean of data is zero.
        /// https://reference.wolfram.com/language/ref/TTest.html
        ///</summary>
        public static Engine TTest(this Engine en, string? name = null)
        {
            return en.Execute("TTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents Tukey's lambda distribution with shape parameter λ.
        /// https://reference.wolfram.com/language/ref/TukeyLambdaDistribution.html
        ///</summary>
        public static Engine TukeyLambdaDistribution(this Engine en, string? name = null)
        {
            return en.Execute("TukeyLambdaDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a Tukey window function of x.
        /// https://reference.wolfram.com/language/ref/TukeyWindow.html
        ///</summary>
        public static Engine TukeyWindow(this Engine en, string? name = null)
        {
            return en.Execute("TukeyWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// generates a list of all possible tuples whose i element is from listi.
        /// https://reference.wolfram.com/language/ref/Tuples.html
        ///</summary>
        public static Engine Tuples(this Engine en, string? name = null)
        {
            return en.Execute("Tuples[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an operator form of TuringMachine that corresponds to one step of evolution.
        /// https://reference.wolfram.com/language/ref/TuringMachine.html
        ///</summary>
        public static Engine TuringMachine(this Engine en, string? name = null)
        {
            return en.Execute("TuringMachine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a type created by evaluating expr.
        /// https://reference.wolfram.com/language/ref/TypeEvaluate.html
        ///</summary>
        public static Engine TypeEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("TypeEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the type of expr without evaluating it.
        /// https://reference.wolfram.com/language/ref/TypeOf.html
        ///</summary>
        public static Engine TypeOf(this Engine en, string? name = null)
        {
            return en.Execute("TypeOf[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a type.
        /// https://reference.wolfram.com/language/ref/TypeSpecifier.html
        ///</summary>
        public static Engine TypeSpecifier(this Engine en, string? name = null)
        {
            return en.Execute("TypeSpecifier[" + en.ValidNames.Last() + "]", name);
        }


    }
}
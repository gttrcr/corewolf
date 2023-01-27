namespace CoreWolf
{
    public static class ExtendedSymbolsD
    {
        ///<summary>
        ///represents a darker version of the specified color.
        ///https://reference.wolfram.com/language/ref/Darker.html
        ///</summary>
        public static Engine Darker(this Engine en, string? name = null)
        {
            return en.Execute("Darker[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics directive specifying that lines that follow are to be drawn dashed, with successive segments of lengths r1, r2, … (repeated cyclically). The ri are given as a fraction of the total width of the graph.
        ///https://reference.wolfram.com/language/ref/Dashing.html
        ///</summary>
        public static Engine Dashing(this Engine en, string? name = null)
        {
            return en.Execute("Dashing[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///activates a connection to the database db.
        ///https://reference.wolfram.com/language/ref/DatabaseConnect.html
        ///</summary>
        public static Engine DatabaseConnect(this Engine en, string? name = null)
        {
            return en.Execute("DatabaseConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deactivates a connection to the database db.
        ///https://reference.wolfram.com/language/ref/DatabaseDisconnect.html
        ///</summary>
        public static Engine DatabaseDisconnect(this Engine en, string? name = null)
        {
            return en.Execute("DatabaseDisconnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a reference to a local file-based SQL database.
        ///https://reference.wolfram.com/language/ref/DatabaseReference.html
        ///</summary>
        public static Engine DatabaseReference(this Engine en, string? name = null)
        {
            return en.Execute("DatabaseReference[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a databin in the Wolfram Data Drop.
        ///https://reference.wolfram.com/language/ref/Databin.html
        ///</summary>
        public static Engine Databin(this Engine en, string? name = null)
        {
            return en.Execute("Databin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a structured dataset based on a hierarchy of lists and associations.
        ///https://reference.wolfram.com/language/ref/Dataset.html
        ///</summary>
        public static Engine Dataset(this Engine en, string? name = null)
        {
            return en.Execute("Dataset[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if ds is a valid data structure and False otherwise.
        ///https://reference.wolfram.com/language/ref/DataStructureQ.html
        ///</summary>
        public static Engine DataStructureQ(this Engine en, string? name = null)
        {
            return en.Execute("DataStructureQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the earliest and latest of the datei.
        ///https://reference.wolfram.com/language/ref/DateBounds.html
        ///</summary>
        public static Engine DateBounds(this Engine en, string? name = null)
        {
            return en.Execute("DateBounds[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots a histogram of the dates datei.
        ///https://reference.wolfram.com/language/ref/DateHistogram.html
        ///</summary>
        public static Engine DateHistogram(this Engine en, string? name = null)
        {
            return en.Execute("DateHistogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the continuous interval of time between start and end.
        ///https://reference.wolfram.com/language/ref/DateInterval.html
        ///</summary>
        public static Engine DateInterval(this Engine en, string? name = null)
        {
            return en.Execute("DateInterval[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a date list corresponding to the given date specification.
        ///https://reference.wolfram.com/language/ref/DateList.html
        ///</summary>
        public static Engine DateList(this Engine en, string? name = null)
        {
            return en.Execute("DateList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the time series tseries.
        ///https://reference.wolfram.com/language/ref/DateListLogPlot.html
        ///</summary>
        public static Engine DateListLogPlot(this Engine en, string? name = null)
        {
            return en.Execute("DateListLogPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the time series tseries.
        ///https://reference.wolfram.com/language/ref/DateListPlot.html
        ///</summary>
        public static Engine DateListPlot(this Engine en, string? name = null)
        {
            return en.Execute("DateListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the time series tseries.
        ///https://reference.wolfram.com/language/ref/DateListStepPlot.html
        ///</summary>
        public static Engine DateListStepPlot(this Engine en, string? name = null)
        {
            return en.Execute("DateListStepPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to the given date specification.
        ///https://reference.wolfram.com/language/ref/DateObject.html
        ///</summary>
        public static Engine DateObject(this Engine en, string? name = null)
        {
            return en.Execute("DateObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is a DateObject with valid arguments, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DateObjectQ.html
        ///</summary>
        public static Engine DateObjectQ(this Engine en, string? name = null)
        {
            return en.Execute("DateObjectQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the characters of a date with elements of type "ei" in StringExpression.
        ///https://reference.wolfram.com/language/ref/DatePattern.html
        ///</summary>
        public static Engine DatePattern(this Engine en, string? name = null)
        {
            return en.Execute("DatePattern[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the date n days after the current date.
        ///https://reference.wolfram.com/language/ref/DatePlus.html
        ///</summary>
        public static Engine DatePlus(this Engine en, string? name = null)
        {
            return en.Execute("DatePlus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of DateSelect that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/DateSelect.html
        ///</summary>
        public static Engine DateSelect(this Engine en, string? name = null)
        {
            return en.Execute("DateSelect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a string corresponding to the given date specification.
        ///https://reference.wolfram.com/language/ref/DateString.html
        ///</summary>
        public static Engine DateString(this Engine en, string? name = null)
        {
            return en.Execute("DateString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the specified element of the current date and time.
        ///https://reference.wolfram.com/language/ref/DateValue.html
        ///</summary>
        public static Engine DateValue(this Engine en, string? name = null)
        {
            return en.Execute("DateValue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Daubechies wavelet of order n.
        ///https://reference.wolfram.com/language/ref/DaubechiesWavelet.html
        ///</summary>
        public static Engine DaubechiesWavelet(this Engine en, string? name = null)
        {
            return en.Execute("DaubechiesWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Dawson integral .
        ///https://reference.wolfram.com/language/ref/DawsonF.html
        ///</summary>
        public static Engine DawsonF(this Engine en, string? name = null)
        {
            return en.Execute("DawsonF[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the daylight half of the Earth for the specified date.
        ///https://reference.wolfram.com/language/ref/DayHemisphere.html
        ///</summary>
        public static Engine DayHemisphere(this Engine en, string? name = null)
        {
            return en.Execute("DayHemisphere[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if it is daylight from the user's location on the specified datespec.
        ///https://reference.wolfram.com/language/ref/DaylightQ.html
        ///</summary>
        public static Engine DaylightQ(this Engine en, string? name = null)
        {
            return en.Execute("DaylightQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the day of the week for the given date.
        ///https://reference.wolfram.com/language/ref/DayName.html
        ///</summary>
        public static Engine DayName(this Engine en, string? name = null)
        {
            return en.Execute("DayName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the separation line between day and night for the specified date.
        ///https://reference.wolfram.com/language/ref/DayNightTerminator.html
        ///</summary>
        public static Engine DayNightTerminator(this Engine en, string? name = null)
        {
            return en.Execute("DayNightTerminator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a string in which the first character has been made lowercase.
        ///https://reference.wolfram.com/language/ref/Decapitalize.html
        ///</summary>
        public static Engine Decapitalize(this Engine en, string? name = null)
        {
            return en.Execute("Decapitalize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints with approximate real numbers in expr always given in decimal form, without scientific notation.
        ///https://reference.wolfram.com/language/ref/DecimalForm.html
        ///</summary>
        public static Engine DecimalForm(this Engine en, string? name = null)
        {
            return en.Execute("DecimalForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///interactively requests a password with which to try to decrypt obj.
        ///https://reference.wolfram.com/language/ref/Decrypt.html
        ///</summary>
        public static Engine Decrypt(this Engine en, string? name = null)
        {
            return en.Execute("Decrypt[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Dedekind eta modular elliptic function .
        ///https://reference.wolfram.com/language/ref/DedekindEta.html
        ///</summary>
        public static Engine DedekindEta(this Engine en, string? name = null)
        {
            return en.Execute("DedekindEta[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the default value for arguments of the function f obtained with a _. pattern object.
        ///https://reference.wolfram.com/language/ref/Default.html
        ///</summary>
        public static Engine Default(this Engine en, string? name = null)
        {
            return en.Execute("Default[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a button that is labeled OK, and whose action is to evaluate action.
        ///https://reference.wolfram.com/language/ref/DefaultButton.html
        ///</summary>
        public static Engine DefaultButton(this Engine en, string? name = null)
        {
            return en.Execute("DefaultButton[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all default argument values (values for Default[f,…]) defined for the symbol f.
        ///https://reference.wolfram.com/language/ref/DefaultValues.html
        ///</summary>
        public static Engine DefaultValues(this Engine en, string? name = null)
        {
            return en.Execute("DefaultValues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields an object that displays as the unevaluated form of expr, but that is evaluated if it is explicitly given as Wolfram Language input.
        ///https://reference.wolfram.com/language/ref/Defer.html
        ///</summary>
        public static Engine Defer(this Engine en, string? name = null)
        {
            return en.Execute("Defer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///defines a resource function that can be applied to arguments to give the same result as f[…].
        ///https://reference.wolfram.com/language/ref/DefineResourceFunction.html
        ///</summary>
        public static Engine DefineResourceFunction(this Engine en, string? name = null)
        {
            return en.Execute("DefineResourceFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as the definitions given for a symbol.
        ///https://reference.wolfram.com/language/ref/Definition.html
        ///</summary>
        public static Engine Definition(this Engine en, string? name = null)
        {
            return en.Execute("Definition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of vertex degrees for the vertices in the underlying simple graph of g.
        ///https://reference.wolfram.com/language/ref/DegreeCentrality.html
        ///</summary>
        public static Engine DegreeCentrality(this Engine en, string? name = null)
        {
            return en.Execute("DegreeCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a degree graph distribution with vertex degree dlist.
        ///https://reference.wolfram.com/language/ref/DegreeGraphDistribution.html
        ///</summary>
        public static Engine DegreeGraphDistribution(this Engine en, string? name = null)
        {
            return en.Execute("DegreeGraphDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Del.html
        ///</summary>
        public static Engine Del(this Engine en, string? name = null)
        {
            return en.Execute("Del[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a MeshRegion representing the Delaunay mesh from the points p1, p2, ….
        ///https://reference.wolfram.com/language/ref/DelaunayMesh.html
        ///</summary>
        public static Engine DelaunayMesh(this Engine en, string? name = null)
        {
            return en.Execute("DelaunayMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an expression whose evaluation is delayed until its value is externally requested.
        ///https://reference.wolfram.com/language/ref/Delayed.html
        ///</summary>
        public static Engine Delayed(this Engine en, string? name = null)
        {
            return en.Execute("Delayed[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of Delete that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Delete.html
        ///</summary>
        public static Engine Delete(this Engine en, string? name = null)
        {
            return en.Execute("Delete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes all duplicates in runs of identical elements in list.
        ///https://reference.wolfram.com/language/ref/DeleteAdjacentDuplicates.html
        ///</summary>
        public static Engine DeleteAdjacentDuplicates(this Engine en, string? name = null)
        {
            return en.Execute("DeleteAdjacentDuplicates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list in which examplei that are considered anomalous have been dropped.
        ///https://reference.wolfram.com/language/ref/DeleteAnomalies.html
        ///</summary>
        public static Engine DeleteAnomalies(this Engine en, string? name = null)
        {
            return en.Execute("DeleteAnomalies[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces connected components adjacent to the border in a binary image image with background pixels.
        ///https://reference.wolfram.com/language/ref/DeleteBorderComponents.html
        ///</summary>
        public static Engine DeleteBorderComponents(this Engine en, string? name = null)
        {
            return en.Execute("DeleteBorderComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of DeleteCases that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/DeleteCases.html
        ///</summary>
        public static Engine DeleteCases(this Engine en, string? name = null)
        {
            return en.Execute("DeleteCases[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes the specified channel from the channel broker server.
        ///https://reference.wolfram.com/language/ref/DeleteChannel.html
        ///</summary>
        public static Engine DeleteChannel(this Engine en, string? name = null)
        {
            return en.Execute("DeleteChannel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes the cloud expression identified by "name".
        ///https://reference.wolfram.com/language/ref/DeleteCloudExpression.html
        ///</summary>
        public static Engine DeleteCloudExpression(this Engine en, string? name = null)
        {
            return en.Execute("DeleteCloudExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes the specified directory.
        ///https://reference.wolfram.com/language/ref/DeleteDirectory.html
        ///</summary>
        public static Engine DeleteDirectory(this Engine en, string? name = null)
        {
            return en.Execute("DeleteDirectory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes all duplicates from list.
        ///https://reference.wolfram.com/language/ref/DeleteDuplicates.html
        ///</summary>
        public static Engine DeleteDuplicates(this Engine en, string? name = null)
        {
            return en.Execute("DeleteDuplicates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of DeleteDuplicatesBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/DeleteDuplicatesBy.html
        ///</summary>
        public static Engine DeleteDuplicatesBy(this Engine en, string? name = null)
        {
            return en.Execute("DeleteDuplicatesBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes a file.
        ///https://reference.wolfram.com/language/ref/DeleteFile.html
        ///</summary>
        public static Engine DeleteFile(this Engine en, string? name = null)
        {
            return en.Execute("DeleteFile[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///drops elements with head Missing from a list.
        ///https://reference.wolfram.com/language/ref/DeleteMissing.html
        ///</summary>
        public static Engine DeleteMissing(this Engine en, string? name = null)
        {
            return en.Execute("DeleteMissing[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes the object obj.
        ///https://reference.wolfram.com/language/ref/DeleteObject.html
        ///</summary>
        public static Engine DeleteObject(this Engine en, string? name = null)
        {
            return en.Execute("DeleteObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes a permissions key, rendering it invalid.
        ///https://reference.wolfram.com/language/ref/DeletePermissionsKey.html
        ///</summary>
        public static Engine DeletePermissionsKey(this Engine en, string? name = null)
        {
            return en.Execute("DeletePermissionsKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes the search index represented by the search index object obj.
        ///https://reference.wolfram.com/language/ref/DeleteSearchIndex.html
        ///</summary>
        public static Engine DeleteSearchIndex(this Engine en, string? name = null)
        {
            return en.Execute("DeleteSearchIndex[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces small connected components in a binary image image with background pixels.
        ///https://reference.wolfram.com/language/ref/DeleteSmallComponents.html
        ///</summary>
        public static Engine DeleteSmallComponents(this Engine en, string? name = null)
        {
            return en.Execute("DeleteSmallComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///deletes stopwords from a list of words.
        ///https://reference.wolfram.com/language/ref/DeleteStopwords.html
        ///</summary>
        public static Engine DeleteStopwords(this Engine en, string? name = null)
        {
            return en.Execute("DeleteStopwords[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a delimited sequence of elements of the specified form in Interpreter and related functions.
        ///https://reference.wolfram.com/language/ref/DelimitedSequence.html
        ///</summary>
        public static Engine DelimitedSequence(this Engine en, string? name = null)
        {
            return en.Execute("DelimitedSequence[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///constructs a dendrogram from the hierarchical clustering of the elements e1, e2, ….
        ///https://reference.wolfram.com/language/ref/Dendrogram.html
        ///</summary>
        public static Engine Dendrogram(this Engine en, string? name = null)
        {
            return en.Execute("Dendrogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the denominator of expr.
        ///https://reference.wolfram.com/language/ref/Denominator.html
        ///</summary>
        public static Engine Denominator(this Engine en, string? name = null)
        {
            return en.Execute("Denominator[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a deployed version of expr in which elements such as Slider, InputField, Locator and Button are active, but general editing and selection is disabled.
        ///https://reference.wolfram.com/language/ref/Deploy.html
        ///</summary>
        public static Engine Deploy(this Engine en, string? name = null)
        {
            return en.Execute("Deploy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the maximum number of indices needed to specify any part of expr, plus 1.
        ///https://reference.wolfram.com/language/ref/Depth.html
        ///</summary>
        public static Engine Depth(this Engine en, string? name = null)
        {
            return en.Execute("Depth[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a derived key generated by GenerateDerivedKey.
        ///https://reference.wolfram.com/language/ref/DerivedKey.html
        ///</summary>
        public static Engine DerivedKey(this Engine en, string? name = null)
        {
            return en.Execute("DerivedKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the determinant of the square matrix m.
        ///https://reference.wolfram.com/language/ref/Det.html
        ///</summary>
        public static Engine Det(this Engine en, string? name = null)
        {
            return en.Execute("Det[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///closes the connection to a device and frees related resources.
        ///https://reference.wolfram.com/language/ref/DeviceClose.html
        ///</summary>
        public static Engine DeviceClose(this Engine en, string? name = null)
        {
            return en.Execute("DeviceClose[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a device that can be accessed in a Wolfram Language session.
        ///https://reference.wolfram.com/language/ref/DeviceObject.html
        ///</summary>
        public static Engine DeviceObject(this Engine en, string? name = null)
        {
            return en.Execute("DeviceObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens a connection to the first available device in the class specified by "devclass".
        ///https://reference.wolfram.com/language/ref/DeviceOpen.html
        ///</summary>
        public static Engine DeviceOpen(this Engine en, string? name = null)
        {
            return en.Execute("DeviceOpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads a single default item from the open device corresponding to the specified DeviceObject.
        ///https://reference.wolfram.com/language/ref/DeviceRead.html
        ///</summary>
        public static Engine DeviceRead(this Engine en, string? name = null)
        {
            return en.Execute("DeviceRead[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads the complete contents of the buffer on a device.
        ///https://reference.wolfram.com/language/ref/DeviceReadBuffer.html
        ///</summary>
        public static Engine DeviceReadBuffer(this Engine en, string? name = null)
        {
            return en.Execute("DeviceReadBuffer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the most recently collected default item from a device.
        ///https://reference.wolfram.com/language/ref/DeviceReadLatest.html
        ///</summary>
        public static Engine DeviceReadLatest(this Engine en, string? name = null)
        {
            return en.Execute("DeviceReadLatest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of devices in classes whose names match the string pattern form.
        ///https://reference.wolfram.com/language/ref/Devices.html
        ///</summary>
        public static Engine Devices(this Engine en, string? name = null)
        {
            return en.Execute("Devices[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of all open streams associated with a device.
        ///https://reference.wolfram.com/language/ref/DeviceStreams.html
        ///</summary>
        public static Engine DeviceStreams(this Engine en, string? name = null)
        {
            return en.Execute("DeviceStreams[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a derivative of Gaussian wavelet of derivative order n.
        ///https://reference.wolfram.com/language/ref/DGaussianWavelet.html
        ///</summary>
        public static Engine DGaussianWavelet(this Engine en, string? name = null)
        {
            return en.Execute("DGaussianWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of elements on the leading diagonal of the matrix m.
        ///https://reference.wolfram.com/language/ref/Diagonal.html
        ///</summary>
        public static Engine Diagonal(this Engine en, string? name = null)
        {
            return en.Execute("Diagonal[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is diagonalizable, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DiagonalizableMatrixQ.html
        ///</summary>
        public static Engine DiagonalizableMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("DiagonalizableMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a matrix with the elements of list on the leading diagonal, and zero elsewhere.
        ///https://reference.wolfram.com/language/ref/DiagonalMatrix.html
        ///</summary>
        public static Engine DiagonalMatrix(this Engine en, string? name = null)
        {
            return en.Execute("DiagonalMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is diagonal, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DiagonalMatrixQ.html
        ///</summary>
        public static Engine DiagonalMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("DiagonalMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///initiates a dialog with expr as the current value of %.
        ///https://reference.wolfram.com/language/ref/Dialog.html
        ///</summary>
        public static Engine Dialog(this Engine en, string? name = null)
        {
            return en.Execute("Dialog[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///interactively puts up expr as a dialog notebook, waits until a DialogReturn[e] is evaluated from within it, and then returns the result e.
        ///https://reference.wolfram.com/language/ref/DialogInput.html
        ///</summary>
        public static Engine DialogInput(this Engine en, string? name = null)
        {
            return en.Execute("DialogInput[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a dialog notebook that can be manipulated by the Wolfram System front end.
        ///https://reference.wolfram.com/language/ref/DialogNotebook.html
        ///</summary>
        public static Engine DialogNotebook(this Engine en, string? name = null)
        {
            return en.Execute("DialogNotebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///closes a dialog window, returning the expression expr from the dialog.
        ///https://reference.wolfram.com/language/ref/DialogReturn.html
        ///</summary>
        public static Engine DialogReturn(this Engine en, string? name = null)
        {
            return en.Execute("DialogReturn[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a matrix whose elements are 1 in a diamond-shaped region that extends r index positions to each side, and are 0 otherwise.
        ///https://reference.wolfram.com/language/ref/DiamondMatrix.html
        ///</summary>
        public static Engine DiamondMatrix(this Engine en, string? name = null)
        {
            return en.Execute("DiamondMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds all words in an English dictionary that match the string pattern patt.
        ///https://reference.wolfram.com/language/ref/DictionaryLookup.html
        ///</summary>
        public static Engine DictionaryLookup(this Engine en, string? name = null)
        {
            return en.Execute("DictionaryLookup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether "word" is a recognized dictionary word.
        ///https://reference.wolfram.com/language/ref/DictionaryWordQ.html
        ///</summary>
        public static Engine DictionaryWordQ(this Engine en, string? name = null)
        {
            return en.Execute("DictionaryWordQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the holonomic sequence , specified by the linear difference equation lde[h,k].
        ///https://reference.wolfram.com/language/ref/DifferenceRoot.html
        ///</summary>
        public static Engine DifferenceRoot(this Engine en, string? name = null)
        {
            return en.Execute("DifferenceRoot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the successive differences of elements in list.
        ///https://reference.wolfram.com/language/ref/Differences.html
        ///</summary>
        public static Engine Differences(this Engine en, string? name = null)
        {
            return en.Execute("Differences[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as x.
        ///https://reference.wolfram.com/language/ref/DifferentialD.html
        ///</summary>
        public static Engine DifferentialD(this Engine en, string? name = null)
        {
            return en.Execute("DifferentialD[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the holonomic function , specified by the linear differential equation lde[h,x].
        ///https://reference.wolfram.com/language/ref/DifferentialRoot.html
        ///</summary>
        public static Engine DifferentialRoot(this Engine en, string? name = null)
        {
            return en.Execute("DifferentialRoot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a diffusion term  with model variables vars.
        ///https://reference.wolfram.com/language/ref/DiffusionPDETerm.html
        ///</summary>
        public static Engine DiffusionPDETerm(this Engine en, string? name = null)
        {
            return en.Execute("DiffusionPDETerm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a digital signature object.
        ///https://reference.wolfram.com/language/ref/DigitalSignature.html
        ///</summary>
        public static Engine DigitalSignature(this Engine en, string? name = null)
        {
            return en.Execute("DigitalSignature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the numbers of , , …, ,  digits in the base-10 representation of n.
        ///https://reference.wolfram.com/language/ref/DigitCount.html
        ///</summary>
        public static Engine DigitCount(this Engine en, string? name = null)
        {
            return en.Execute("DigitCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if all the characters in the string are digits in the range 0 through 9, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/DigitQ.html
        ///</summary>
        public static Engine DigitQ(this Engine en, string? name = null)
        {
            return en.Execute("DigitQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the dihedral group of order 2n.
        ///https://reference.wolfram.com/language/ref/DihedralGroup.html
        ///</summary>
        public static Engine DihedralGroup(this Engine en, string? name = null)
        {
            return en.Execute("DihedralGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the possible combinations of the list of physical quantities pqi that are dimensionless.
        ///https://reference.wolfram.com/language/ref/DimensionalCombinations.html
        ///</summary>
        public static Engine DimensionalCombinations(this Engine en, string? name = null)
        {
            return en.Execute("DimensionalCombinations[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list {r0,r1,…} of regions such that rd has dimension d for a mesh region mr.
        ///https://reference.wolfram.com/language/ref/DimensionalMeshComponents.html
        ///</summary>
        public static Engine DimensionalMeshComponents(this Engine en, string? name = null)
        {
            return en.Execute("DimensionalMeshComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///projects the examples examplei to a lower-dimensional approximating manifold.
        ///https://reference.wolfram.com/language/ref/DimensionReduce.html
        ///</summary>
        public static Engine DimensionReduce(this Engine en, string? name = null)
        {
            return en.Execute("DimensionReduce[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a function generated by DimensionReduction that projects data onto a lower-dimensional approximating manifold.
        ///https://reference.wolfram.com/language/ref/DimensionReducerFunction.html
        ///</summary>
        public static Engine DimensionReducerFunction(this Engine en, string? name = null)
        {
            return en.Execute("DimensionReducerFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a DimensionReducerFunction[…] that projects from the space defined by the examplei to a lower-dimensional approximating manifold.
        ///https://reference.wolfram.com/language/ref/DimensionReduction.html
        ///</summary>
        public static Engine DimensionReduction(this Engine en, string? name = null)
        {
            return en.Execute("DimensionReduction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the dimensions of expr.
        ///https://reference.wolfram.com/language/ref/Dimensions.html
        ///</summary>
        public static Engine Dimensions(this Engine en, string? name = null)
        {
            return en.Execute("Dimensions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Dirac comb function  giving a delta function at every integer point.
        ///https://reference.wolfram.com/language/ref/DiracComb.html
        ///</summary>
        public static Engine DiracComb(this Engine en, string? name = null)
        {
            return en.Execute("DiracComb[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Dirac delta function .
        ///https://reference.wolfram.com/language/ref/DiracDelta.html
        ///</summary>
        public static Engine DiracDelta(this Engine en, string? name = null)
        {
            return en.Execute("DiracDelta[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a directed graph from the undirected graph g.
        ///https://reference.wolfram.com/language/ref/DirectedGraph.html
        ///</summary>
        public static Engine DirectedGraph(this Engine en, string? name = null)
        {
            return en.Execute("DirectedGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a directed graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/DirectedGraphQ.html
        ///</summary>
        public static Engine DirectedGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("DirectedGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an infinite numerical quantity that is a positive real multiple of the complex number z.
        ///https://reference.wolfram.com/language/ref/DirectedInfinity.html
        ///</summary>
        public static Engine DirectedInfinity(this Engine en, string? name = null)
        {
            return en.Execute("DirectedInfinity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///extracts the directory name from the specification for a file.
        ///https://reference.wolfram.com/language/ref/DirectoryName.html
        ///</summary>
        public static Engine DirectoryName(this Engine en, string? name = null)
        {
            return en.Execute("DirectoryName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the directory with the specified name exists, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/DirectoryQ.html
        ///</summary>
        public static Engine DirectoryQ(this Engine en, string? name = null)
        {
            return en.Execute("DirectoryQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet beta function .
        ///https://reference.wolfram.com/language/ref/DirichletBeta.html
        ///</summary>
        public static Engine DirichletBeta(this Engine en, string? name = null)
        {
            return en.Execute("DirichletBeta[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Dirichlet distribution of dimension k with shape parameters αi.
        ///https://reference.wolfram.com/language/ref/DirichletDistribution.html
        ///</summary>
        public static Engine DirichletDistribution(this Engine en, string? name = null)
        {
            return en.Execute("DirichletDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet eta function .
        ///https://reference.wolfram.com/language/ref/DirichletEta.html
        ///</summary>
        public static Engine DirichletEta(this Engine en, string? name = null)
        {
            return en.Execute("DirichletEta[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet lambda function .
        ///https://reference.wolfram.com/language/ref/DirichletLambda.html
        ///</summary>
        public static Engine DirichletLambda(this Engine en, string? name = null)
        {
            return en.Execute("DirichletLambda[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Dirichlet window function of x.
        ///https://reference.wolfram.com/language/ref/DirichletWindow.html
        ///</summary>
        public static Engine DirichletWindow(this Engine en, string? name = null)
        {
            return en.Execute("DirichletWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a form that disables the formatting of expr when it appears inside held expressions, but gives expr as soon as evaluation occurs.
        ///https://reference.wolfram.com/language/ref/DisableFormatting.html
        ///</summary>
        public static Engine DisableFormatting(this Engine en, string? name = null)
        {
            return en.Execute("DisableFormatting[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the chirp Z transform of list.
        ///https://reference.wolfram.com/language/ref/DiscreteChirpZTransform.html
        ///</summary>
        public static Engine DiscreteChirpZTransform(this Engine en, string? name = null)
        {
            return en.Execute("DiscreteChirpZTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the discrete Hadamard transform of list.
        ///https://reference.wolfram.com/language/ref/DiscreteHadamardTransform.html
        ///</summary>
        public static Engine DiscreteHadamardTransform(this Engine en, string? name = null)
        {
            return en.Execute("DiscreteHadamardTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if lsys is a discrete-time systems model, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DiscreteTimeModelQ.html
        ///</summary>
        public static Engine DiscreteTimeModelQ(this Engine en, string? name = null)
        {
            return en.Execute("DiscreteTimeModelQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a discrete uniform distribution over the integers from imin to imax.
        ///https://reference.wolfram.com/language/ref/DiscreteUniformDistribution.html
        ///</summary>
        public static Engine DiscreteUniformDistribution(this Engine en, string? name = null)
        {
            return en.Execute("DiscreteUniformDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the discrete wavelet packet transform (DWPT) of an array of data.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletPacketTransform.html
        ///</summary>
        public static Engine DiscreteWaveletPacketTransform(this Engine en, string? name = null)
        {
            return en.Execute("DiscreteWaveletPacketTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the discrete wavelet transform (DWT) of an array of data.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletTransform.html
        ///</summary>
        public static Engine DiscreteWaveletTransform(this Engine en, string? name = null)
        {
            return en.Execute("DiscreteWaveletTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///discretizes a 2D or 3D graphic g into a MeshRegion.
        ///https://reference.wolfram.com/language/ref/DiscretizeGraphics.html
        ///</summary>
        public static Engine DiscretizeGraphics(this Engine en, string? name = null)
        {
            return en.Execute("DiscretizeGraphics[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///discretizes a region reg into a MeshRegion.
        ///https://reference.wolfram.com/language/ref/DiscretizeRegion.html
        ///</summary>
        public static Engine DiscretizeRegion(this Engine en, string? name = null)
        {
            return en.Execute("DiscretizeRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a disk of radius 1.
        ///https://reference.wolfram.com/language/ref/Disk.html
        ///</summary>
        public static Engine Disk(this Engine en, string? name = null)
        {
            return en.Execute("Disk[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a matrix whose elements are 1 in a disk-shaped region of radius r, and are otherwise 0.
        ///https://reference.wolfram.com/language/ref/DiskMatrix.html
        ///</summary>
        public static Engine DiskMatrix(this Engine en, string? name = null)
        {
            return en.Execute("DiskMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates an optimized dispatch table representation of a list of rules. The object produced by Dispatch can be used to give the rules in expr/.rules.
        ///https://reference.wolfram.com/language/ref/Dispatch.html
        ///</summary>
        public static Engine Dispatch(this Engine en, string? name = null)
        {
            return en.Execute("Dispatch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints with low-level boxes inside expr shown in explicit two-dimensional or other form.
        ///https://reference.wolfram.com/language/ref/DisplayForm.html
        ///</summary>
        public static Engine DisplayForm(this Engine en, string? name = null)
        {
            return en.Execute("DisplayForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the matrix of distances between each pair of elements ui, uj.
        ///https://reference.wolfram.com/language/ref/DistanceMatrix.html
        ///</summary>
        public static Engine DistanceMatrix(this Engine en, string? name = null)
        {
            return en.Execute("DistanceMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the distance transform of image, in which the value of each pixel is replaced by its distance to the nearest background pixel.
        ///https://reference.wolfram.com/language/ref/DistanceTransform.html
        ///</summary>
        public static Engine DistanceTransform(this Engine en, string? name = null)
        {
            return en.Execute("DistanceTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///distributes f over Plus appearing in any of the xi.
        ///https://reference.wolfram.com/language/ref/Distribute.html
        ///</summary>
        public static Engine Distribute(this Engine en, string? name = null)
        {
            return en.Execute("Distribute[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///distributes definitions for all symbols in the specified context.
        ///https://reference.wolfram.com/language/ref/DistributeDefinitions.html
        ///</summary>
        public static Engine DistributeDefinitions(this Engine en, string? name = null)
        {
            return en.Execute("DistributeDefinitions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a distribution chart with a distribution symbol for each datai.
        ///https://reference.wolfram.com/language/ref/DistributionChart.html
        ///</summary>
        public static Engine DistributionChart(this Engine en, string? name = null)
        {
            return en.Execute("DistributionChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed.
        ///https://reference.wolfram.com/language/ref/DistributionFitTest.html
        ///</summary>
        public static Engine DistributionFitTest(this Engine en, string? name = null)
        {
            return en.Execute("DistributionFitTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a logical expression for assumptions on parameters in the symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/DistributionParameterAssumptions.html
        ///</summary>
        public static Engine DistributionParameterAssumptions(this Engine en, string? name = null)
        {
            return en.Execute("DistributionParameterAssumptions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if dist is a valid distribution, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/DistributionParameterQ.html
        ///</summary>
        public static Engine DistributionParameterQ(this Engine en, string? name = null)
        {
            return en.Execute("DistributionParameterQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///divides each side of rel by the right-hand side, producing a 1 right-hand side.
        ///https://reference.wolfram.com/language/ref/DivideSides.html
        ///</summary>
        public static Engine DivideSides(this Engine en, string? name = null)
        {
            return en.Execute("DivideSides[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the integers that divide n.
        ///https://reference.wolfram.com/language/ref/Divisors.html
        ///</summary>
        public static Engine Divisors(this Engine en, string? name = null)
        {
            return en.Execute("Divisors[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts an angle θ given in decimal degrees to a DMS list {degree,minute,second}.
        ///https://reference.wolfram.com/language/ref/DMSList.html
        ///</summary>
        public static Engine DMSList(this Engine en, string? name = null)
        {
            return en.Execute("DMSList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts an angle θ given in decimal degrees to a degrees-minutes-seconds string.
        ///https://reference.wolfram.com/language/ref/DMSString.html
        ///</summary>
        public static Engine DMSString(this Engine en, string? name = null)
        {
            return en.Execute("DMSString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the properties of the DocumentGenerator cloudobj.
        ///https://reference.wolfram.com/language/ref/DocumentGeneratorInformation.html
        ///</summary>
        public static Engine DocumentGeneratorInformation(this Engine en, string? name = null)
        {
            return en.Execute("DocumentGeneratorInformation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a complete document notebook in the Wolfram System front end.
        ///https://reference.wolfram.com/language/ref/DocumentNotebook.html
        ///</summary>
        public static Engine DocumentNotebook(this Engine en, string? name = null)
        {
            return en.Execute("DocumentNotebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a dodecahedron with edge length l.
        ///https://reference.wolfram.com/language/ref/Dodecahedron.html
        ///</summary>
        public static Engine Dodecahedron(this Engine en, string? name = null)
        {
            return en.Execute("Dodecahedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns dominant colors in image.
        ///https://reference.wolfram.com/language/ref/DominantColors.html
        ///</summary>
        public static Engine DominantColors(this Engine en, string? name = null)
        {
            return en.Execute("DominantColors[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///uses given transpose specifications for the respective inputs.
        ///https://reference.wolfram.com/language/ref/DotLayer.html
        ///</summary>
        public static Engine DotLayer(this Engine en, string? name = null)
        {
            return en.Execute("DotLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all downvalues (values for f[…]) defined for the symbol f.
        ///https://reference.wolfram.com/language/ref/DownValues.html
        ///</summary>
        public static Engine DownValues(this Engine en, string? name = null)
        {
            return en.Execute("DownValues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the Drazin generalized inverse  of a square matrix m.
        ///https://reference.wolfram.com/language/ref/DrazinInverse.html
        ///</summary>
        public static Engine DrazinInverse(this Engine en, string? name = null)
        {
            return en.Execute("DrazinInverse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets its input elements to zero with probability p during training.
        ///https://reference.wolfram.com/language/ref/DropoutLayer.html
        ///</summary>
        public static Engine DropoutLayer(this Engine en, string? name = null)
        {
            return en.Execute("DropoutLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///uses an absolute offset {dx,dy}.
        ///https://reference.wolfram.com/language/ref/DropShadowing.html
        ///</summary>
        public static Engine DropShadowing(this Engine en, string? name = null)
        {
            return en.Execute("DropShadowing[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the total differential df.
        ///https://reference.wolfram.com/language/ref/Dt.html
        ///</summary>
        public static Engine Dt(this Engine en, string? name = null)
        {
            return en.Execute("Dt[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the dual of the planar graph g.
        ///https://reference.wolfram.com/language/ref/DualPlanarGraph.html
        ///</summary>
        public static Engine DualPlanarGraph(this Engine en, string? name = null)
        {
            return en.Execute("DualPlanarGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the dual polyhedron of the polyhedron poly.
        ///https://reference.wolfram.com/language/ref/DualPolyhedron.html
        ///</summary>
        public static Engine DualPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("DualPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the dual of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/DualSystemsModel.html
        ///</summary>
        public static Engine DualSystemsModel(this Engine en, string? name = null)
        {
            return en.Execute("DualSystemsModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if list has no duplicates, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DuplicateFreeQ.html
        ///</summary>
        public static Engine DuplicateFreeQ(this Engine en, string? name = null)
        {
            return en.Execute("DuplicateFreeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the duration of expr.
        ///https://reference.wolfram.com/language/ref/Duration.html
        ///</summary>
        public static Engine Duration(this Engine en, string? name = null)
        {
            return en.Execute("Duration[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an object that displays as the dynamically updated current value of expr. If the displayed form of Dynamic[expr] is interactively changed or edited, an assignment expr=val is done to give expr the new value val that corresponds to the displayed form.
        ///https://reference.wolfram.com/language/ref/Dynamic.html
        ///</summary>
        public static Engine Dynamic(this Engine en, string? name = null)
        {
            return en.Execute("Dynamic[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays a dynamic version of image, supporting panning, zooming, etc.
        ///https://reference.wolfram.com/language/ref/DynamicImage.html
        ///</summary>
        public static Engine DynamicImage(this Engine en, string? name = null)
        {
            return en.Execute("DynamicImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an object which displays as e, but is interpreted as the dynamically updated current value of Setting[e] if supplied as Wolfram Language input.
        ///https://reference.wolfram.com/language/ref/DynamicSetting.html
        ///</summary>
        public static Engine DynamicSetting(this Engine en, string? name = null)
        {
            return en.Execute("DynamicSetting[" + en.ValidNames.Last() + "]", name);
        }


    }
}
namespace NetWolf
{
    public static class BuiltinSymbolD
    {
        ///<summary>
        ///gives the partial derivative .
        ///https://reference.wolfram.com/language/ref/D.html
        ///</summary>
        public static Engine D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multiple derivative .
        ///https://reference.wolfram.com/language/ref/D.html
        ///</summary>
        public static Engine D(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the partial derivative .
        ///https://reference.wolfram.com/language/ref/D.html
        ///</summary>
        public static Engine D(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("D[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the multiple partial derivative .
        ///https://reference.wolfram.com/language/ref/D.html
        ///</summary>
        public static Engine D(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a Dagum distribution with shape parameters p and a and scale parameter b.
        ///https://reference.wolfram.com/language/ref/DagumDistribution.html
        ///</summary>
        public static Engine DagumDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DagumDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the dam entity.
        ///https://reference.wolfram.com/language/ref/DamData.html
        ///</summary>
        public static Engine DamData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DamData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified dam entities.
        ///https://reference.wolfram.com/language/ref/DamData.html
        ///</summary>
        public static Engine DamData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DamData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/DamData.html
        ///</summary>
        public static Engine DamData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DamData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Damerau–Levenshtein distance between strings, vectors or biomolecular sequences u and v.
        ///https://reference.wolfram.com/language/ref/DamerauLevenshteinDistance.html
        ///</summary>
        public static Engine DamerauLevenshteinDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DamerauLevenshteinDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a darker version of the specified color.
        ///https://reference.wolfram.com/language/ref/Darker.html
        ///</summary>
        public static Engine Darker(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Darker[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a version of the specified color darkened by a fraction f.
        ///https://reference.wolfram.com/language/ref/Darker.html
        ///</summary>
        public static Engine Darker(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Darker[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional graphics directive specifying that lines that follow are to be drawn dashed, with successive segments of lengths r1, r2, … (repeated cyclically). The ri are given as a fraction of the total width of the graph.
        ///https://reference.wolfram.com/language/ref/Dashing.html
        ///</summary>
        public static Engine Dashing(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Dashing[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is equivalent to Dashing[{r,r}].
        ///https://reference.wolfram.com/language/ref/Dashing.html
        ///</summary>
        public static Engine Dashing(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Dashing[" + arg0 + "]", name);
        }

        ///<summary>
        ///offsets the dashes by offset.
        ///https://reference.wolfram.com/language/ref/Dashing.html
        ///</summary>
        public static Engine Dashing(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Dashing[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///sets the CapForm for individual dashes to capform.
        ///https://reference.wolfram.com/language/ref/Dashing.html
        ///</summary>
        public static Engine Dashing(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Dashing[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///activates a connection to the database db.
        ///https://reference.wolfram.com/language/ref/DatabaseConnect.html
        ///</summary>
        public static Engine DatabaseConnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DatabaseConnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///deactivates a connection to the database db.
        ///https://reference.wolfram.com/language/ref/DatabaseDisconnect.html
        ///</summary>
        public static Engine DatabaseDisconnect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DatabaseDisconnect[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a reference to a local file-based SQL database.
        ///https://reference.wolfram.com/language/ref/DatabaseReference.html
        ///</summary>
        public static Engine DatabaseReference(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DatabaseReference[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a databin in the Wolfram Data Drop.
        ///https://reference.wolfram.com/language/ref/Databin.html
        ///</summary>
        public static Engine Databin(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Databin[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the first n entries in a databin.
        ///https://reference.wolfram.com/language/ref/Databin.html
        ///</summary>
        public static Engine Databin(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Databin[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents entries m through n in a databin, with negative numbers counting from the end.
        ///https://reference.wolfram.com/language/ref/Databin.html
        ///</summary>
        public static Engine Databin(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Databin[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents only elements with keys keyi within each entry in a databin.
        ///https://reference.wolfram.com/language/ref/Databin.html
        ///</summary>
        public static Engine Databin(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Databin[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///adds the specified data to a databin.
        ///https://reference.wolfram.com/language/ref/DatabinAdd.html
        ///</summary>
        public static Engine DatabinAdd(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DatabinAdd[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of databins associated with the currently connected user.
        ///https://reference.wolfram.com/language/ref/Databins.html
        ///</summary>
        public static Engine Databins(this Engine en, string? name = null)
        {
            return en.Execute("Databins[]", name);
        }

        ///<summary>
        ///submits the specified data to be added to the databin bin asynchronously.
        ///https://reference.wolfram.com/language/ref/DatabinSubmit.html
        ///</summary>
        public static Engine DatabinSubmit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DatabinSubmit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///bulk uploads all the entries entryi to a databin.
        ///https://reference.wolfram.com/language/ref/DatabinUpload.html
        ///</summary>
        public static Engine DatabinUpload(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DatabinUpload[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///bulk uploads all entries in an event series to a databin.
        ///https://reference.wolfram.com/language/ref/DatabinUpload.html
        ///</summary>
        public static Engine DatabinUpload(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DatabinUpload[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a probability distribution of type ddist, estimated from a set of data.
        ///https://reference.wolfram.com/language/ref/DataDistribution.html
        ///</summary>
        public static Engine DataDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DataDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a structured dataset based on a hierarchy of lists and associations.
        ///https://reference.wolfram.com/language/ref/Dataset.html
        ///</summary>
        public static Engine Dataset(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Dataset[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a data structure.
        ///https://reference.wolfram.com/language/ref/DataStructure.html
        ///</summary>
        public static Engine DataStructure(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DataStructure[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if ds is a valid data structure and False otherwise.
        ///https://reference.wolfram.com/language/ref/DataStructureQ.html
        ///</summary>
        public static Engine DataStructureQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DataStructureQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if ds is a valid data structure of the specified type and False otherwise.
        ///https://reference.wolfram.com/language/ref/DataStructureQ.html
        ///</summary>
        public static Engine DataStructureQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DataStructureQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the earliest and latest of the datei.
        ///https://reference.wolfram.com/language/ref/DateBounds.html
        ///</summary>
        public static Engine DateBounds(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DateBounds[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the first and last dates in the time series tseries.
        ///https://reference.wolfram.com/language/ref/DateBounds.html
        ///</summary>
        public static Engine DateBounds(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateBounds[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the endpoints of interval in the specified granularity gran.
        ///https://reference.wolfram.com/language/ref/DateBounds.html
        ///</summary>
        public static Engine DateBounds(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateBounds[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the object obj associated with a particular year.
        ///https://reference.wolfram.com/language/ref/Dated.html
        ///</summary>
        public static Engine Dated(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Dated[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the number of days from date1 to date2.
        ///https://reference.wolfram.com/language/ref/DateDifference.html
        ///</summary>
        public static Engine DateDifference(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateDifference[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the difference between date1 and date2 in the specified unit.
        ///https://reference.wolfram.com/language/ref/DateDifference.html
        ///</summary>
        public static Engine DateDifference(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DateDifference[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the difference as a list with elements corresponding to the successive "uniti".
        ///https://reference.wolfram.com/language/ref/DateDifference.html
        ///</summary>
        public static Engine DateDifference(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DateDifference[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents the specified unit at a specific date.
        ///https://reference.wolfram.com/language/ref/DatedUnit.html
        ///</summary>
        public static Engine DatedUnit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DatedUnit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots a histogram of the dates datei.
        ///https://reference.wolfram.com/language/ref/DateHistogram.html
        ///</summary>
        public static Engine DateHistogram(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DateHistogram[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots a histogram with bin width specification bspec.
        ///https://reference.wolfram.com/language/ref/DateHistogram.html
        ///</summary>
        public static Engine DateHistogram(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DateHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots a histogram with bin heights computed according to the specification hspec.
        ///https://reference.wolfram.com/language/ref/DateHistogram.html
        ///</summary>
        public static Engine DateHistogram(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DateHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the continuous interval of time between start and end.
        ///https://reference.wolfram.com/language/ref/DateInterval.html
        ///</summary>
        public static Engine DateInterval(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DateInterval[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents an interval of dates with calendar granularity gran.
        ///https://reference.wolfram.com/language/ref/DateInterval.html
        ///</summary>
        public static Engine DateInterval(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DateInterval[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the union of intervals start1 to end1, start2 to end2, ….
        ///https://reference.wolfram.com/language/ref/DateInterval.html
        ///</summary>
        public static Engine DateInterval(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DateInterval[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the date interval from the initial to final instants of the granular date object gdate.
        ///https://reference.wolfram.com/language/ref/DateInterval.html
        ///</summary>
        public static Engine DateInterval(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateInterval[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the current local date and time in the form {year,month,day,hour,minute,second}.
        ///https://reference.wolfram.com/language/ref/DateList.html
        ///</summary>
        public static Engine DateList(this Engine en, string? name = null)
        {
            return en.Execute("DateList[]", name);
        }

        ///<summary>
        ///gives a date list corresponding to the given date specification.
        ///https://reference.wolfram.com/language/ref/DateList.html
        ///</summary>
        public static Engine DateList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateList[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a log plot with values vi at a sequence of dates.
        ///https://reference.wolfram.com/language/ref/DateListLogPlot.html
        ///</summary>
        public static Engine DateListLogPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DateListLogPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///makes a log plot with dates at equal intervals specified by datespec.
        ///https://reference.wolfram.com/language/ref/DateListLogPlot.html
        ///</summary>
        public static Engine DateListLogPlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DateListLogPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots the time series tseries.
        ///https://reference.wolfram.com/language/ref/DateListLogPlot.html
        ///</summary>
        public static Engine DateListLogPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateListLogPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots data from all the datai.
        ///https://reference.wolfram.com/language/ref/DateListLogPlot.html
        ///</summary>
        public static Engine DateListLogPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DateListLogPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots points with values vi at a sequence of dates.
        ///https://reference.wolfram.com/language/ref/DateListPlot.html
        ///</summary>
        public static Engine DateListPlot(this Engine en, List<object> arg0, List<object> arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("DateListPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///plots points with dates at equal intervals specified by datespec.
        ///https://reference.wolfram.com/language/ref/DateListPlot.html
        ///</summary>
        public static Engine DateListPlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DateListPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots the time series tseries.
        ///https://reference.wolfram.com/language/ref/DateListPlot.html
        ///</summary>
        public static Engine DateListPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateListPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots data from all the datai.
        ///https://reference.wolfram.com/language/ref/DateListPlot.html
        ///</summary>
        public static Engine DateListPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DateListPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots the values vi in steps at a sequence of dates.
        ///https://reference.wolfram.com/language/ref/DateListStepPlot.html
        ///</summary>
        public static Engine DateListStepPlot(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DateListStepPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots the values vi in steps with dates at equal intervals specified by datespec.
        ///https://reference.wolfram.com/language/ref/DateListStepPlot.html
        ///</summary>
        public static Engine DateListStepPlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DateListStepPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots the time series tseries.
        ///https://reference.wolfram.com/language/ref/DateListStepPlot.html
        ///</summary>
        public static Engine DateListStepPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateListStepPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots data from all the datai.
        ///https://reference.wolfram.com/language/ref/DateListStepPlot.html
        ///</summary>
        public static Engine DateListStepPlot(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DateListStepPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///plots using steps specified by step.
        ///https://reference.wolfram.com/language/ref/DateListStepPlot.html
        ///</summary>
        public static Engine DateListStepPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateListStepPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the current local date.
        ///https://reference.wolfram.com/language/ref/DateObject.html
        ///</summary>
        public static Engine DateObject(this Engine en, string? name = null)
        {
            return en.Execute("DateObject[]", name);
        }

        ///<summary>
        ///gives a date object corresponding to the given date specification.
        ///https://reference.wolfram.com/language/ref/DateObject.html
        ///</summary>
        public static Engine DateObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the date object of calendar granularity gran that includes the reference date rdate.
        ///https://reference.wolfram.com/language/ref/DateObject.html
        ///</summary>
        public static Engine DateObject(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateObject[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if expr is a DateObject with valid arguments, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DateObjectQ.html
        ///</summary>
        public static Engine DateObjectQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateObjectQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if the calendar dates date1 and date2 overlap, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DateOverlapsQ.html
        ///</summary>
        public static Engine DateOverlapsQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateOverlapsQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the characters of a date with elements of type "ei" in StringExpression.
        ///https://reference.wolfram.com/language/ref/DatePattern.html
        ///</summary>
        public static Engine DatePattern(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DatePattern[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///allows separators that match the string expression sep.
        ///https://reference.wolfram.com/language/ref/DatePattern.html
        ///</summary>
        public static Engine DatePattern(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DatePattern[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the date n days after date.
        ///https://reference.wolfram.com/language/ref/DatePlus.html
        ///</summary>
        public static Engine DatePlus(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DatePlus[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the date n calendar steps after date.
        ///https://reference.wolfram.com/language/ref/DatePlus.html
        ///</summary>
        public static Engine DatePlus(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DatePlus[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a date offset by ni steps of each specified size.
        ///https://reference.wolfram.com/language/ref/DatePlus.html
        ///</summary>
        public static Engine DatePlus(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DatePlus[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the date n days after the current date.
        ///https://reference.wolfram.com/language/ref/DatePlus.html
        ///</summary>
        public static Engine DatePlus(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DatePlus[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives all dates in the range from date1 to date2.
        ///https://reference.wolfram.com/language/ref/DateRange.html
        ///</summary>
        public static Engine DateRange(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateRange[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the dates in the range from date1 to date2 that are increment apart.
        ///https://reference.wolfram.com/language/ref/DateRange.html
        ///</summary>
        public static Engine DateRange(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DateRange[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the canonical mapping of continuous dates and times to a quantitative scale.
        ///https://reference.wolfram.com/language/ref/DateScale.html
        ///</summary>
        public static Engine DateScale(this Engine en, string? name = null)
        {
            return en.Execute("DateScale[]", name);
        }

        ///<summary>
        ///picks out all dates datei of a list for which crit[datei] is True.
        ///https://reference.wolfram.com/language/ref/DateSelect.html
        ///</summary>
        public static Engine DateSelect(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateSelect[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of DateSelect that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/DateSelect.html
        ///</summary>
        public static Engine DateSelect(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateSelect[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a string representing the complete current local date and time.
        ///https://reference.wolfram.com/language/ref/DateString.html
        ///</summary>
        public static Engine DateString(this Engine en, string? name = null)
        {
            return en.Execute("DateString[]", name);
        }

        ///<summary>
        ///gives a string corresponding to the given date specification.
        ///https://reference.wolfram.com/language/ref/DateString.html
        ///</summary>
        public static Engine DateString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateString[" + arg0 + "]", name);
        }

        ///<summary>
        ///concatenates the specified elements in the order given.
        ///https://reference.wolfram.com/language/ref/DateString.html
        ///</summary>
        public static Engine DateString(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DateString[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives elements specified by the date format fmt for the date or time specification date.
        ///https://reference.wolfram.com/language/ref/DateString.html
        ///</summary>
        public static Engine DateString(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateString[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified element of the current date and time.
        ///https://reference.wolfram.com/language/ref/DateValue.html
        ///</summary>
        public static Engine DateValue(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DateValue[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the specified elements of the current date and time.
        ///https://reference.wolfram.com/language/ref/DateValue.html
        ///</summary>
        public static Engine DateValue(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DateValue[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the specified element of the specified date.
        ///https://reference.wolfram.com/language/ref/DateValue.html
        ///</summary>
        public static Engine DateValue(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateValue[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the result in the specified form.
        ///https://reference.wolfram.com/language/ref/DateValue.html
        ///</summary>
        public static Engine DateValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DateValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns True if the calendar date date2 is entirely contained within date1, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DateWithinQ.html
        ///</summary>
        public static Engine DateWithinQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DateWithinQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Daubechies wavelet of order 2.
        ///https://reference.wolfram.com/language/ref/DaubechiesWavelet.html
        ///</summary>
        public static Engine DaubechiesWavelet(this Engine en, string? name = null)
        {
            return en.Execute("DaubechiesWavelet[]", name);
        }

        ///<summary>
        ///represents a Daubechies wavelet of order n.
        ///https://reference.wolfram.com/language/ref/DaubechiesWavelet.html
        ///</summary>
        public static Engine DaubechiesWavelet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DaubechiesWavelet[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Davis distribution with scale parameter b, shape parameter n, and location parameter μ.
        ///https://reference.wolfram.com/language/ref/DavisDistribution.html
        ///</summary>
        public static Engine DavisDistribution(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DavisDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Dawson integral .
        ///https://reference.wolfram.com/language/ref/DawsonF.html
        ///</summary>
        public static Engine DawsonF(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DawsonF[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of days from date1 to date2.
        ///https://reference.wolfram.com/language/ref/DayCount.html
        ///</summary>
        public static Engine DayCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DayCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the number of days of the specified daytype from date1 to date2.
        ///https://reference.wolfram.com/language/ref/DayCount.html
        ///</summary>
        public static Engine DayCount(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DayCount[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents the half of the Earth that is currently in daylight.
        ///https://reference.wolfram.com/language/ref/DayHemisphere.html
        ///</summary>
        public static Engine DayHemisphere(this Engine en, string? name = null)
        {
            return en.Execute("DayHemisphere[]", name);
        }

        ///<summary>
        ///represents the daylight half of the Earth for the specified date.
        ///https://reference.wolfram.com/language/ref/DayHemisphere.html
        ///</summary>
        public static Engine DayHemisphere(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DayHemisphere[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if it is currently daylight from the user's location.
        ///https://reference.wolfram.com/language/ref/DaylightQ.html
        ///</summary>
        public static Engine DaylightQ(this Engine en, string? name = null)
        {
            return en.Execute("DaylightQ[]", name);
        }

        ///<summary>
        ///gives True if it is daylight from the user's location on the specified datespec.
        ///https://reference.wolfram.com/language/ref/DaylightQ.html
        ///</summary>
        public static Engine DaylightQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DaylightQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if it is daylight from the specified locationspec on the specified datespec.
        ///https://reference.wolfram.com/language/ref/DaylightQ.html
        ///</summary>
        public static Engine DaylightQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DaylightQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if it is daylight from the specified locations and dates.
        ///https://reference.wolfram.com/language/ref/DaylightQ.html
        ///</summary>
        public static Engine DaylightQ(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DaylightQ[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if it is daylight from the specified locationspec on the specified datespec taking inclusionspec into account.
        ///https://reference.wolfram.com/language/ref/DaylightQ.html
        ///</summary>
        public static Engine DaylightQ(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DaylightQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns True if the date matches the daytype specification and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/DayMatchQ.html
        ///</summary>
        public static Engine DayMatchQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DayMatchQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the current day of the week.
        ///https://reference.wolfram.com/language/ref/DayName.html
        ///</summary>
        public static Engine DayName(this Engine en, string? name = null)
        {
            return en.Execute("DayName[]", name);
        }

        ///<summary>
        ///gives the day of the week for the given date.
        ///https://reference.wolfram.com/language/ref/DayName.html
        ///</summary>
        public static Engine DayName(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DayName[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a one-dimensional GeoGraphics primitive that represents the separation line between the halves of the Earth currently in daytime and nighttime.
        ///https://reference.wolfram.com/language/ref/DayNightTerminator.html
        ///</summary>
        public static Engine DayNightTerminator(this Engine en, string? name = null)
        {
            return en.Execute("DayNightTerminator[]", name);
        }

        ///<summary>
        ///represents the separation line between day and night for the specified date.
        ///https://reference.wolfram.com/language/ref/DayNightTerminator.html
        ///</summary>
        public static Engine DayNightTerminator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DayNightTerminator[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the date n days away from date.
        ///https://reference.wolfram.com/language/ref/DayPlus.html
        ///</summary>
        public static Engine DayPlus(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DayPlus[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the date that is n days of daytype away from date.
        ///https://reference.wolfram.com/language/ref/DayPlus.html
        ///</summary>
        public static Engine DayPlus(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DayPlus[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the dates in the range from date1 to date2.
        ///https://reference.wolfram.com/language/ref/DayRange.html
        ///</summary>
        public static Engine DayRange(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DayRange[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the dates in the range from date1 to date2 that are of the specified daytype.
        ///https://reference.wolfram.com/language/ref/DayRange.html
        ///</summary>
        public static Engine DayRange(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DayRange[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///rounds date to the nearest day of daytype, using the next-day rounding convention.
        ///https://reference.wolfram.com/language/ref/DayRound.html
        ///</summary>
        public static Engine DayRound(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DayRound[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///rounds date to the nearest day of daytype, using rounding.
        ///https://reference.wolfram.com/language/ref/DayRound.html
        ///</summary>
        public static Engine DayRound(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DayRound[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the n-dimensional De Bruijn graph with m symbols.
        ///https://reference.wolfram.com/language/ref/DeBruijnGraph.html
        ///</summary>
        public static Engine DeBruijnGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeBruijnGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the De Bruijn graph with connectivity given by type.
        ///https://reference.wolfram.com/language/ref/DeBruijnGraph.html
        ///</summary>
        public static Engine DeBruijnGraph(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeBruijnGraph[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a de Bruijn sequence on the elements in list taken n at a time.
        ///https://reference.wolfram.com/language/ref/DeBruijnSequence.html
        ///</summary>
        public static Engine DeBruijnSequence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeBruijnSequence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a string in which the first character has been made lowercase.
        ///https://reference.wolfram.com/language/ref/Decapitalize.html
        ///</summary>
        public static Engine Decapitalize(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Decapitalize[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with approximate real numbers in expr always given in decimal form, without scientific notation.
        ///https://reference.wolfram.com/language/ref/DecimalForm.html
        ///</summary>
        public static Engine DecimalForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DecimalForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///prints with approximate real numbers given in decimal form to n-digit precision.
        ///https://reference.wolfram.com/language/ref/DecimalForm.html
        ///</summary>
        public static Engine DecimalForm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DecimalForm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints with approximate real numbers having n digits, with f digits to the right of the decimal point.
        ///https://reference.wolfram.com/language/ref/DecimalForm.html
        ///</summary>
        public static Engine DecimalForm(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DecimalForm[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///declares that Needs["context`"] should automatically be executed if a symbol with any of the specified names is ever used.
        ///https://reference.wolfram.com/language/ref/DeclarePackage.html
        ///</summary>
        public static Engine DeclarePackage(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DeclarePackage[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///decomposes a polynomial, if possible, into a composition of simpler polynomials.
        ///https://reference.wolfram.com/language/ref/Decompose.html
        ///</summary>
        public static Engine Decompose(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Decompose[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a trainable deconvolutional net layer having n output channels and using kernels of size sz to compute the deconvolution.
        ///https://reference.wolfram.com/language/ref/DeconvolutionLayer.html
        ///</summary>
        public static Engine DeconvolutionLayer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeconvolutionLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a layer performing one-dimensional deconvolutions with kernels of size s.
        ///https://reference.wolfram.com/language/ref/DeconvolutionLayer.html
        ///</summary>
        public static Engine DeconvolutionLayer(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DeconvolutionLayer[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///includes options for initial kernels and other parameters.
        ///https://reference.wolfram.com/language/ref/DeconvolutionLayer.html
        ///</summary>
        public static Engine DeconvolutionLayer(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeconvolutionLayer[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///attempts to decrypt the encrypted object enc using the specified password.
        ///https://reference.wolfram.com/language/ref/Decrypt.html
        ///</summary>
        public static Engine Decrypt(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Decrypt[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///interactively requests a password with which to try to decrypt obj.
        ///https://reference.wolfram.com/language/ref/Decrypt.html
        ///</summary>
        public static Engine Decrypt(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Decrypt[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a decrypted version of a file, using the specified password.
        ///https://reference.wolfram.com/language/ref/DecryptFile.html
        ///</summary>
        public static Engine DecryptFile(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DecryptFile[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a decrypted version of source, putting the result in target.
        ///https://reference.wolfram.com/language/ref/DecryptFile.html
        ///</summary>
        public static Engine DecryptFile(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DecryptFile[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Dedekind eta modular elliptic function .
        ///https://reference.wolfram.com/language/ref/DedekindEta.html
        ///</summary>
        public static Engine DedekindEta(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DedekindEta[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the deep space probe entity.
        ///https://reference.wolfram.com/language/ref/DeepSpaceProbeData.html
        ///</summary>
        public static Engine DeepSpaceProbeData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeepSpaceProbeData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified deep space probe entities.
        ///https://reference.wolfram.com/language/ref/DeepSpaceProbeData.html
        ///</summary>
        public static Engine DeepSpaceProbeData(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DeepSpaceProbeData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/DeepSpaceProbeData.html
        ///</summary>
        public static Engine DeepSpaceProbeData(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeepSpaceProbeData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the default value for arguments of the function f obtained with a _. pattern object.
        ///https://reference.wolfram.com/language/ref/Default.html
        ///</summary>
        public static Engine Default(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Default[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the default value to use when _. appears as the i argument of f.
        ///https://reference.wolfram.com/language/ref/Default.html
        ///</summary>
        public static Engine Default(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Default[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the default value for the i argument out of a total of n arguments.
        ///https://reference.wolfram.com/language/ref/Default.html
        ///</summary>
        public static Engine Default(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Default[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an OK button that closes a dialog, and is the default when  is pressed in the dialog.
        ///https://reference.wolfram.com/language/ref/DefaultButton.html
        ///</summary>
        public static Engine DefaultButton(this Engine en, string? name = null)
        {
            return en.Execute("DefaultButton[]", name);
        }

        ///<summary>
        ///represents a button that is labeled OK, and whose action is to evaluate action.
        ///https://reference.wolfram.com/language/ref/DefaultButton.html
        ///</summary>
        public static Engine DefaultButton(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DefaultButton[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses label as the label for the button.
        ///https://reference.wolfram.com/language/ref/DefaultButton.html
        ///</summary>
        public static Engine DefaultButton(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DefaultButton[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all default argument values (values for Default[f,…]) defined for the symbol f.
        ///https://reference.wolfram.com/language/ref/DefaultValues.html
        ///</summary>
        public static Engine DefaultValues(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DefaultValues[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields an object that displays as the unevaluated form of expr, but that is evaluated if it is explicitly given as Wolfram Language input.
        ///https://reference.wolfram.com/language/ref/Defer.html
        ///</summary>
        public static Engine Defer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Defer[" + arg0 + "]", name);
        }

        ///<summary>
        ///defines a custom input stream method with the specified name, allowing the Wolfram Language to call the stream functions fnamei for opening and reading from an input stream.
        ///https://reference.wolfram.com/language/ref/DefineInputStreamMethod.html
        ///</summary>
        public static Engine DefineInputStreamMethod(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DefineInputStreamMethod[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///defines a custom output stream method with the specified name, allowing the Wolfram Language to call the stream functions for opening and writing to an output stream.
        ///https://reference.wolfram.com/language/ref/DefineOutputStreamMethod.html
        ///</summary>
        public static Engine DefineOutputStreamMethod(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DefineOutputStreamMethod[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///defines a resource function that can be applied to arguments to give the same result as f[…].
        ///https://reference.wolfram.com/language/ref/DefineResourceFunction.html
        ///</summary>
        public static Engine DefineResourceFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DefineResourceFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses name as the name of the resource function.
        ///https://reference.wolfram.com/language/ref/DefineResourceFunction.html
        ///</summary>
        public static Engine DefineResourceFunction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DefineResourceFunction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///prints as the definitions given for a symbol.
        ///https://reference.wolfram.com/language/ref/Definition.html
        ///</summary>
        public static Engine Definition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Definition[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of vertex degrees for the vertices in the underlying simple graph of g.
        ///https://reference.wolfram.com/language/ref/DegreeCentrality.html
        ///</summary>
        public static Engine DegreeCentrality(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DegreeCentrality[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of vertex in-degrees.
        ///https://reference.wolfram.com/language/ref/DegreeCentrality.html
        ///</summary>
        public static Engine DegreeCentrality(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DegreeCentrality[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/DegreeCentrality.html
        ///</summary>
        public static Engine DegreeCentrality(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DegreeCentrality[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a degree graph distribution with vertex degree dlist.
        ///https://reference.wolfram.com/language/ref/DegreeGraphDistribution.html
        ///</summary>
        public static Engine DegreeGraphDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DegreeGraphDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n smallest magnitude eigenvalues and eigenfunctions for the linear differential operator ℒ over the region Ω.
        ///https://reference.wolfram.com/language/ref/DEigensystem.html
        ///</summary>
        public static Engine DEigensystem(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DEigensystem[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the eigenvalues and eigenfunctions for solutions u of the time-dependent differential equations eqns.
        ///https://reference.wolfram.com/language/ref/DEigensystem.html
        ///</summary>
        public static Engine DEigensystem(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("DEigensystem[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///gives the n smallest magnitude eigenvalues for the linear differential operator ℒ over the region Ω.
        ///https://reference.wolfram.com/language/ref/DEigenvalues.html
        ///</summary>
        public static Engine DEigenvalues(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DEigenvalues[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the eigenvalues for solutions u of the time-dependent differential equations eqns.
        ///https://reference.wolfram.com/language/ref/DEigenvalues.html
        ///</summary>
        public static Engine DEigenvalues(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("DEigenvalues[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Del.html
        ///</summary>
        public static Engine Del(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Del[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a MeshRegion representing the Delaunay mesh from the points p1, p2, ….
        ///https://reference.wolfram.com/language/ref/DelaunayMesh.html
        ///</summary>
        public static Engine DelaunayMesh(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DelaunayMesh[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents an expression whose evaluation is delayed until its value is externally requested.
        ///https://reference.wolfram.com/language/ref/Delayed.html
        ///</summary>
        public static Engine Delayed(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Delayed[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies that the result from evaluating expr should be given in format fmt.
        ///https://reference.wolfram.com/language/ref/Delayed.html
        ///</summary>
        public static Engine Delayed(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Delayed[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///specifies that the result should be given as a response of the form rform.
        ///https://reference.wolfram.com/language/ref/Delayed.html
        ///</summary>
        public static Engine Delayed(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Delayed[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///deletes the element at position n in expr. If n is negative, the position is counted from the end.
        ///https://reference.wolfram.com/language/ref/Delete.html
        ///</summary>
        public static Engine Delete(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Delete[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes the part at position {i,j,…}.
        ///https://reference.wolfram.com/language/ref/Delete.html
        ///</summary>
        public static Engine Delete(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Delete[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///deletes parts at several positions.
        ///https://reference.wolfram.com/language/ref/Delete.html
        ///</summary>
        public static Engine Delete(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Delete[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents an operator form of Delete that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Delete.html
        ///</summary>
        public static Engine Delete(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Delete[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes all duplicates in runs of identical elements in list.
        ///https://reference.wolfram.com/language/ref/DeleteAdjacentDuplicates.html
        ///</summary>
        public static Engine DeleteAdjacentDuplicates(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteAdjacentDuplicates[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies test to pairs of consecutive elements to determine whether they should be considered duplicates.
        ///https://reference.wolfram.com/language/ref/DeleteAdjacentDuplicates.html
        ///</summary>
        public static Engine DeleteAdjacentDuplicates(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeleteAdjacentDuplicates[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list in which examplei that are considered anomalous have been dropped.
        ///https://reference.wolfram.com/language/ref/DeleteAnomalies.html
        ///</summary>
        public static Engine DeleteAnomalies(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DeleteAnomalies[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///drops anomalies in data using the given AnomalyDetectorFunction[…] or LearnedDistribution[…].
        ///https://reference.wolfram.com/language/ref/DeleteAnomalies.html
        ///</summary>
        public static Engine DeleteAnomalies(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeleteAnomalies[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///replaces connected components adjacent to the border in a binary image image with background pixels.
        ///https://reference.wolfram.com/language/ref/DeleteBorderComponents.html
        ///</summary>
        public static Engine DeleteBorderComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteBorderComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes all elements of expr that match pattern.
        ///https://reference.wolfram.com/language/ref/DeleteCases.html
        ///</summary>
        public static Engine DeleteCases(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeleteCases[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///removes all parts of expr on levels specified by levelspec that match pattern.
        ///https://reference.wolfram.com/language/ref/DeleteCases.html
        ///</summary>
        public static Engine DeleteCases(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeleteCases[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///removes the first n parts of expr that match pattern.
        ///https://reference.wolfram.com/language/ref/DeleteCases.html
        ///</summary>
        public static Engine DeleteCases(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DeleteCases[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents an operator form of DeleteCases that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/DeleteCases.html
        ///</summary>
        public static Engine DeleteCases(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteCases[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes the specified channel from the channel broker server.
        ///https://reference.wolfram.com/language/ref/DeleteChannel.html
        ///</summary>
        public static Engine DeleteChannel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteChannel[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes all the channeli.
        ///https://reference.wolfram.com/language/ref/DeleteChannel.html
        ///</summary>
        public static Engine DeleteChannel(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DeleteChannel[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///deletes the cloud expression identified by "name".
        ///https://reference.wolfram.com/language/ref/DeleteCloudExpression.html
        ///</summary>
        public static Engine DeleteCloudExpression(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteCloudExpression[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes the specified directory.
        ///https://reference.wolfram.com/language/ref/DeleteDirectory.html
        ///</summary>
        public static Engine DeleteDirectory(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteDirectory[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes all duplicates from list.
        ///https://reference.wolfram.com/language/ref/DeleteDuplicates.html
        ///</summary>
        public static Engine DeleteDuplicates(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteDuplicates[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies test to pairs of elements to determine whether they should be considered duplicates.
        ///https://reference.wolfram.com/language/ref/DeleteDuplicates.html
        ///</summary>
        public static Engine DeleteDuplicates(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeleteDuplicates[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes those ei that yield duplicates in the list {f[e1],f[e2],…}.
        ///https://reference.wolfram.com/language/ref/DeleteDuplicatesBy.html
        ///</summary>
        public static Engine DeleteDuplicatesBy(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DeleteDuplicatesBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of DeleteDuplicatesBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/DeleteDuplicatesBy.html
        ///</summary>
        public static Engine DeleteDuplicatesBy(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteDuplicatesBy[" + arg0 + "]", name);
        }

        ///<summary>
        ///removes all instances of elements ei from list.
        ///https://reference.wolfram.com/language/ref/DeleteElements.html
        ///</summary>
        public static Engine DeleteElements(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DeleteElements[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///removes up to n instances of each ei from list.
        ///https://reference.wolfram.com/language/ref/DeleteElements.html
        ///</summary>
        public static Engine DeleteElements(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeleteElements[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes a file.
        ///https://reference.wolfram.com/language/ref/DeleteFile.html
        ///</summary>
        public static Engine DeleteFile(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteFile[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes a list of files.
        ///https://reference.wolfram.com/language/ref/DeleteFile.html
        ///</summary>
        public static Engine DeleteFile(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DeleteFile[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///drops elements with head Missing from a list.
        ///https://reference.wolfram.com/language/ref/DeleteMissing.html
        ///</summary>
        public static Engine DeleteMissing(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteMissing[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies DeleteMissing to any lists or associations that occur within the first n levels of expr.
        ///https://reference.wolfram.com/language/ref/DeleteMissing.html
        ///</summary>
        public static Engine DeleteMissing(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeleteMissing[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///considers an element at level n to be missing if Missing occurs within the first d levels of the element.
        ///https://reference.wolfram.com/language/ref/DeleteMissing.html
        ///</summary>
        public static Engine DeleteMissing(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeleteMissing[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///deletes the object obj.
        ///https://reference.wolfram.com/language/ref/DeleteObject.html
        ///</summary>
        public static Engine DeleteObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes all the obji.
        ///https://reference.wolfram.com/language/ref/DeleteObject.html
        ///</summary>
        public static Engine DeleteObject(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DeleteObject[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///deletes a permissions key, rendering it invalid.
        ///https://reference.wolfram.com/language/ref/DeletePermissionsKey.html
        ///</summary>
        public static Engine DeletePermissionsKey(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeletePermissionsKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes several permissions keys.
        ///https://reference.wolfram.com/language/ref/DeletePermissionsKey.html
        ///</summary>
        public static Engine DeletePermissionsKey(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DeletePermissionsKey[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///deletes the search index represented by the search index object obj.
        ///https://reference.wolfram.com/language/ref/DeleteSearchIndex.html
        ///</summary>
        public static Engine DeleteSearchIndex(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteSearchIndex[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces small connected components in a binary image image with background pixels.
        ///https://reference.wolfram.com/language/ref/DeleteSmallComponents.html
        ///</summary>
        public static Engine DeleteSmallComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteSmallComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///replaces components consisting of n or fewer elements.
        ///https://reference.wolfram.com/language/ref/DeleteSmallComponents.html
        ///</summary>
        public static Engine DeleteSmallComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeleteSmallComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///deletes stopwords from a list of words.
        ///https://reference.wolfram.com/language/ref/DeleteStopwords.html
        ///</summary>
        public static Engine DeleteStopwords(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeleteStopwords[" + arg0 + "]", name);
        }

        ///<summary>
        ///deletes stopwords from a list of strings.
        ///https://reference.wolfram.com/language/ref/DeleteStopwords.html
        ///</summary>
        public static Engine DeleteStopwords(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DeleteStopwords[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a delimited sequence of elements of the specified form in Interpreter and related functions.
        ///https://reference.wolfram.com/language/ref/DelimitedSequence.html
        ///</summary>
        public static Engine DelimitedSequence(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DelimitedSequence[" + arg0 + "]", name);
        }

        ///<summary>
        ///assumes a separator that matches sep.
        ///https://reference.wolfram.com/language/ref/DelimitedSequence.html
        ///</summary>
        public static Engine DelimitedSequence(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DelimitedSequence[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///assumes left and right delimiters matching left and right, respectively.
        ///https://reference.wolfram.com/language/ref/DelimitedSequence.html
        ///</summary>
        public static Engine DelimitedSequence(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DelimitedSequence[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///constructs a dendrogram from the hierarchical clustering of the elements e1, e2, ….
        ///https://reference.wolfram.com/language/ref/Dendrogram.html
        ///</summary>
        public static Engine Dendrogram(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Dendrogram[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents ei using labels labeli in the constructed dendrogram.
        ///https://reference.wolfram.com/language/ref/Dendrogram.html
        ///</summary>
        public static Engine Dendrogram(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Dendrogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///constructs an oriented dendrogram according to orientation.
        ///https://reference.wolfram.com/language/ref/Dendrogram.html
        ///</summary>
        public static Engine Dendrogram(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Dendrogram[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs the dendrogram corresponding to weighted tree tree.
        ///https://reference.wolfram.com/language/ref/Dendrogram.html
        ///</summary>
        public static Engine Dendrogram(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Dendrogram[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the denominator of expr.
        ///https://reference.wolfram.com/language/ref/Denominator.html
        ///</summary>
        public static Engine Denominator(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Denominator[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots a density histogram of the values {xi,yi}.
        ///https://reference.wolfram.com/language/ref/DensityHistogram.html
        ///</summary>
        public static Engine DensityHistogram(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DensityHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots a density histogram with bins specified by bspec.
        ///https://reference.wolfram.com/language/ref/DensityHistogram.html
        ///</summary>
        public static Engine DensityHistogram(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("DensityHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///plots a density histogram with bin densities computed according to the specification hspec.
        ///https://reference.wolfram.com/language/ref/DensityHistogram.html
        ///</summary>
        public static Engine DensityHistogram(this Engine en, List<object> arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DensityHistogram[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///makes a density plot of f as a function of x and y.
        ///https://reference.wolfram.com/language/ref/DensityPlot.html
        ///</summary>
        public static Engine DensityPlot(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DensityPlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///takes the variables {x,y} to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/DensityPlot.html
        ///</summary>
        public static Engine DensityPlot(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DensityPlot[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes a density plot of f as a function of x, y, and z.
        ///https://reference.wolfram.com/language/ref/DensityPlot3D.html
        ///</summary>
        public static Engine DensityPlot3D(this Engine en, object arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("DensityPlot3D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///takes the variables to be in the geometric region reg.
        ///https://reference.wolfram.com/language/ref/DensityPlot3D.html
        ///</summary>
        public static Engine DensityPlot3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DensityPlot3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a deployed version of expr in which elements such as Slider, InputField, Locator and Button are active, but general editing and selection is disabled.
        ///https://reference.wolfram.com/language/ref/Deploy.html
        ///</summary>
        public static Engine Deploy(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Deploy[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the maximum number of indices needed to specify any part of expr, plus 1.
        ///https://reference.wolfram.com/language/ref/Depth.html
        ///</summary>
        public static Engine Depth(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Depth[" + arg0 + "]", name);
        }

        ///<summary>
        ///performs a depth-first scan of the graph g starting at the vertex s and evaluates fi whenever "eventi" occurs.
        ///https://reference.wolfram.com/language/ref/DepthFirstScan.html
        ///</summary>
        public static Engine DepthFirstScan(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DepthFirstScan[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///performs a depth-first scan of the whole graph g.
        ///https://reference.wolfram.com/language/ref/DepthFirstScan.html
        ///</summary>
        public static Engine DepthFirstScan(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DepthFirstScan[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/DepthFirstScan.html
        ///</summary>
        public static Engine DepthFirstScan(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DepthFirstScan[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes the ni derivative of data at level i.
        ///https://reference.wolfram.com/language/ref/DerivativeFilter.html
        ///</summary>
        public static Engine DerivativeFilter(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DerivativeFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///computes the derivative at a Gaussian scale of standard deviation σ.
        ///https://reference.wolfram.com/language/ref/DerivativeFilter.html
        ///</summary>
        public static Engine DerivativeFilter(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("DerivativeFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a load derivative term  with load derivative coefficient  and model variables vars.
        ///https://reference.wolfram.com/language/ref/DerivativePDETerm.html
        ///</summary>
        public static Engine DerivativePDETerm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DerivativePDETerm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses model parameters pars.
        ///https://reference.wolfram.com/language/ref/DerivativePDETerm.html
        ///</summary>
        public static Engine DerivativePDETerm(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DerivativePDETerm[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a derived key generated by GenerateDerivedKey.
        ///https://reference.wolfram.com/language/ref/DerivedKey.html
        ///</summary>
        public static Engine DerivedKey(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DerivedKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///constructs the design matrix for the linear model β0+β1 f1+β2 f2+….
        ///https://reference.wolfram.com/language/ref/DesignMatrix.html
        ///</summary>
        public static Engine DesignMatrix(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("DesignMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives the determinant of the square matrix m.
        ///https://reference.wolfram.com/language/ref/Det.html
        ///</summary>
        public static Engine Det(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Det[" + arg0 + "]", name);
        }

        ///<summary>
        ///closes the connection to a device and frees related resources.
        ///https://reference.wolfram.com/language/ref/DeviceClose.html
        ///</summary>
        public static Engine DeviceClose(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeviceClose[" + arg0 + "]", name);
        }

        ///<summary>
        ///configures the specified device according to config.
        ///https://reference.wolfram.com/language/ref/DeviceConfigure.html
        ///</summary>
        public static Engine DeviceConfigure(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceConfigure[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///executes the specified command on a device.
        ///https://reference.wolfram.com/language/ref/DeviceExecute.html
        ///</summary>
        public static Engine DeviceExecute(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceExecute[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///executes the command with the parameters params.
        ///https://reference.wolfram.com/language/ref/DeviceExecute.html
        ///</summary>
        public static Engine DeviceExecute(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeviceExecute[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///initiates asynchronous execution of the specified command on a device, calling the handler function fun when an event occurs.
        ///https://reference.wolfram.com/language/ref/DeviceExecuteAsynchronous.html
        ///</summary>
        public static Engine DeviceExecuteAsynchronous(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeviceExecuteAsynchronous[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///executes the command with the parameters params.
        ///https://reference.wolfram.com/language/ref/DeviceExecuteAsynchronous.html
        ///</summary>
        public static Engine DeviceExecuteAsynchronous(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DeviceExecuteAsynchronous[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a device that can be accessed in a Wolfram Language session.
        ///https://reference.wolfram.com/language/ref/DeviceObject.html
        ///</summary>
        public static Engine DeviceObject(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeviceObject[" + arg0 + "]", name);
        }

        ///<summary>
        ///opens a connection to the first available device in the class specified by "devclass".
        ///https://reference.wolfram.com/language/ref/DeviceOpen.html
        ///</summary>
        public static Engine DeviceOpen(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeviceOpen[" + arg0 + "]", name);
        }

        ///<summary>
        ///opens a connection to the particular device defined by spec.
        ///https://reference.wolfram.com/language/ref/DeviceOpen.html
        ///</summary>
        public static Engine DeviceOpen(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceOpen[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reads a single default item from the open device corresponding to the specified DeviceObject.
        ///https://reference.wolfram.com/language/ref/DeviceRead.html
        ///</summary>
        public static Engine DeviceRead(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeviceRead[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads the parameter param from the specified device.
        ///https://reference.wolfram.com/language/ref/DeviceRead.html
        ///</summary>
        public static Engine DeviceRead(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceRead[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reads the list of parameters parami from the specified device.
        ///https://reference.wolfram.com/language/ref/DeviceRead.html
        ///</summary>
        public static Engine DeviceRead(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DeviceRead[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///reads the complete contents of the buffer on a device.
        ///https://reference.wolfram.com/language/ref/DeviceReadBuffer.html
        ///</summary>
        public static Engine DeviceReadBuffer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeviceReadBuffer[" + arg0 + "]", name);
        }

        ///<summary>
        ///reads n elements from the buffer.
        ///https://reference.wolfram.com/language/ref/DeviceReadBuffer.html
        ///</summary>
        public static Engine DeviceReadBuffer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceReadBuffer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reads elements associated with the parameter param.
        ///https://reference.wolfram.com/language/ref/DeviceReadBuffer.html
        ///</summary>
        public static Engine DeviceReadBuffer(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeviceReadBuffer[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///reads elements associated with the parami.
        ///https://reference.wolfram.com/language/ref/DeviceReadBuffer.html
        ///</summary>
        public static Engine DeviceReadBuffer(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DeviceReadBuffer[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///returns the most recently collected default item from a device.
        ///https://reference.wolfram.com/language/ref/DeviceReadLatest.html
        ///</summary>
        public static Engine DeviceReadLatest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeviceReadLatest[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a list of the n most recently collected items.
        ///https://reference.wolfram.com/language/ref/DeviceReadLatest.html
        ///</summary>
        public static Engine DeviceReadLatest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceReadLatest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the n most recently collected values of param.
        ///https://reference.wolfram.com/language/ref/DeviceReadLatest.html
        ///</summary>
        public static Engine DeviceReadLatest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeviceReadLatest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a list of the most recently collected values of the parami.
        ///https://reference.wolfram.com/language/ref/DeviceReadLatest.html
        ///</summary>
        public static Engine DeviceReadLatest(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DeviceReadLatest[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///reads from the specified device n times, returning a list of the results.
        ///https://reference.wolfram.com/language/ref/DeviceReadList.html
        ///</summary>
        public static Engine DeviceReadList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceReadList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///reads the parameter param.
        ///https://reference.wolfram.com/language/ref/DeviceReadList.html
        ///</summary>
        public static Engine DeviceReadList(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DeviceReadList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///reads the list of parameters parami.
        ///https://reference.wolfram.com/language/ref/DeviceReadList.html
        ///</summary>
        public static Engine DeviceReadList(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DeviceReadList[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///repeatedly reads default items from the specified device at interval dt for a total time t, returning a time series of the resulting values.
        ///https://reference.wolfram.com/language/ref/DeviceReadTimeSeries.html
        ///</summary>
        public static Engine DeviceReadTimeSeries(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DeviceReadTimeSeries[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///repeatedly reads the parameter param and returns a time series of its values.
        ///https://reference.wolfram.com/language/ref/DeviceReadTimeSeries.html
        ///</summary>
        public static Engine DeviceReadTimeSeries(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("DeviceReadTimeSeries[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///repeatedly reads the parami and returns a time series of their values.
        ///https://reference.wolfram.com/language/ref/DeviceReadTimeSeries.html
        ///</summary>
        public static Engine DeviceReadTimeSeries(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DeviceReadTimeSeries[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of registered devices on a particular system.
        ///https://reference.wolfram.com/language/ref/Devices.html
        ///</summary>
        public static Engine Devices(this Engine en, string? name = null)
        {
            return en.Execute("Devices[]", name);
        }

        ///<summary>
        ///gives a list of devices in classes whose names match the string pattern form.
        ///https://reference.wolfram.com/language/ref/Devices.html
        ///</summary>
        public static Engine Devices(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Devices[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of devices in classes whose names match any of the formi.
        ///https://reference.wolfram.com/language/ref/Devices.html
        ///</summary>
        public static Engine Devices(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Devices[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of all open streams associated with a device.
        ///https://reference.wolfram.com/language/ref/DeviceStreams.html
        ///</summary>
        public static Engine DeviceStreams(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DeviceStreams[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of streams whose names match the string pattern patt.
        ///https://reference.wolfram.com/language/ref/DeviceStreams.html
        ///</summary>
        public static Engine DeviceStreams(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceStreams[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of streams whose names match any of the patti.
        ///https://reference.wolfram.com/language/ref/DeviceStreams.html
        ///</summary>
        public static Engine DeviceStreams(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DeviceStreams[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///writes the value val to the specified device.
        ///https://reference.wolfram.com/language/ref/DeviceWrite.html
        ///</summary>
        public static Engine DeviceWrite(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceWrite[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///writes the sequence of values vali to the specified device.
        ///https://reference.wolfram.com/language/ref/DeviceWrite.html
        ///</summary>
        public static Engine DeviceWrite(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DeviceWrite[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///fills the buffer on a device with the values vals.
        ///https://reference.wolfram.com/language/ref/DeviceWriteBuffer.html
        ///</summary>
        public static Engine DeviceWriteBuffer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DeviceWriteBuffer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///fills the buffers associated with the parami with the corresponding values valsi .
        ///https://reference.wolfram.com/language/ref/DeviceWriteBuffer.html
        ///</summary>
        public static Engine DeviceWriteBuffer(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DeviceWriteBuffer[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a derivative of Gaussian wavelet of derivative order 2.
        ///https://reference.wolfram.com/language/ref/DGaussianWavelet.html
        ///</summary>
        public static Engine DGaussianWavelet(this Engine en, string? name = null)
        {
            return en.Execute("DGaussianWavelet[]", name);
        }

        ///<summary>
        ///represents a derivative of Gaussian wavelet of derivative order n.
        ///https://reference.wolfram.com/language/ref/DGaussianWavelet.html
        ///</summary>
        public static Engine DGaussianWavelet(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DGaussianWavelet[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the list of elements on the leading diagonal of the matrix m.
        ///https://reference.wolfram.com/language/ref/Diagonal.html
        ///</summary>
        public static Engine Diagonal(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Diagonal[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the elements on the k diagonal of m.
        ///https://reference.wolfram.com/language/ref/Diagonal.html
        ///</summary>
        public static Engine Diagonal(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Diagonal[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives True if m is diagonalizable, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DiagonalizableMatrixQ.html
        ///</summary>
        public static Engine DiagonalizableMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiagonalizableMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a matrix with the elements of list on the leading diagonal, and zero elsewhere.
        ///https://reference.wolfram.com/language/ref/DiagonalMatrix.html
        ///</summary>
        public static Engine DiagonalMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiagonalMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a matrix with the elements of list on the k diagonal.
        ///https://reference.wolfram.com/language/ref/DiagonalMatrix.html
        ///</summary>
        public static Engine DiagonalMatrix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiagonalMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///pads with zeros to create an n×n matrix.
        ///https://reference.wolfram.com/language/ref/DiagonalMatrix.html
        ///</summary>
        public static Engine DiagonalMatrix(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiagonalMatrix[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives True if m is diagonal, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DiagonalMatrixQ.html
        ///</summary>
        public static Engine DiagonalMatrixQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiagonalMatrixQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if m has nonzero elements only on the k diagonal, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DiagonalMatrixQ.html
        ///</summary>
        public static Engine DiagonalMatrixQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiagonalMatrixQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///initiates a dialog.
        ///https://reference.wolfram.com/language/ref/Dialog.html
        ///</summary>
        public static Engine Dialog(this Engine en, string? name = null)
        {
            return en.Execute("Dialog[]", name);
        }

        ///<summary>
        ///initiates a dialog with expr as the current value of %.
        ///https://reference.wolfram.com/language/ref/Dialog.html
        ///</summary>
        public static Engine Dialog(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Dialog[" + arg0 + "]", name);
        }

        ///<summary>
        ///interactively puts up expr as a dialog notebook, waits until a DialogReturn[e] is evaluated from within it, and then returns the result e.
        ///https://reference.wolfram.com/language/ref/DialogInput.html
        ///</summary>
        public static Engine DialogInput(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DialogInput[" + arg0 + "]", name);
        }

        ///<summary>
        ///sets up local variables x, y, … in expr.
        ///https://reference.wolfram.com/language/ref/DialogInput.html
        ///</summary>
        public static Engine DialogInput(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DialogInput[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a dialog notebook that can be manipulated by the Wolfram System front end.
        ///https://reference.wolfram.com/language/ref/DialogNotebook.html
        ///</summary>
        public static Engine DialogNotebook(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DialogNotebook[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///closes a dialog window, returning the expression expr from the dialog.
        ///https://reference.wolfram.com/language/ref/DialogReturn.html
        ///</summary>
        public static Engine DialogReturn(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DialogReturn[" + arg0 + "]", name);
        }

        ///<summary>
        ///closes a dialog window, returning Null.
        ///https://reference.wolfram.com/language/ref/DialogReturn.html
        ///</summary>
        public static Engine DialogReturn(this Engine en, string? name = null)
        {
            return en.Execute("DialogReturn[]", name);
        }

        ///<summary>
        ///displays as x⋄y⋄….
        ///https://reference.wolfram.com/language/ref/Diamond.html
        ///</summary>
        public static Engine Diamond(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Diamond[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a matrix whose elements are 1 in a diamond-shaped region that extends r index positions to each side, and are 0 otherwise.
        ///https://reference.wolfram.com/language/ref/DiamondMatrix.html
        ///</summary>
        public static Engine DiamondMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiamondMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a w×w matrix containing a diamond-shaped region of 1s.
        ///https://reference.wolfram.com/language/ref/DiamondMatrix.html
        ///</summary>
        public static Engine DiamondMatrix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiamondMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields an array whose elements are 1 in a diamond-shaped region that extends ri index positions in the i direction.
        ///https://reference.wolfram.com/language/ref/DiamondMatrix.html
        ///</summary>
        public static Engine DiamondMatrix(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DiamondMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Dice dissimilarity between Boolean vectors x and y.
        ///https://reference.wolfram.com/language/ref/DiceDissimilarity.html
        ///</summary>
        public static Engine DiceDissimilarity(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiceDissimilarity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds all words in an English dictionary that match the string pattern patt.
        ///https://reference.wolfram.com/language/ref/DictionaryLookup.html
        ///</summary>
        public static Engine DictionaryLookup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DictionaryLookup[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives only the first n words found.
        ///https://reference.wolfram.com/language/ref/DictionaryLookup.html
        ///</summary>
        public static Engine DictionaryLookup(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DictionaryLookup[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds words in the language specified by lang.
        ///https://reference.wolfram.com/language/ref/DictionaryLookup.html
        ///</summary>
        public static Engine DictionaryLookup(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DictionaryLookup[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///tests whether "word" is a recognized dictionary word.
        ///https://reference.wolfram.com/language/ref/DictionaryWordQ.html
        ///</summary>
        public static Engine DictionaryWordQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DictionaryWordQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the discrete difference .
        ///https://reference.wolfram.com/language/ref/DifferenceDelta.html
        ///</summary>
        public static Engine DifferenceDelta(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DifferenceDelta[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multiple difference .
        ///https://reference.wolfram.com/language/ref/DifferenceDelta.html
        ///</summary>
        public static Engine DifferenceDelta(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DifferenceDelta[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///computes the partial difference with respect to i, j, ….
        ///https://reference.wolfram.com/language/ref/DifferenceDelta.html
        ///</summary>
        public static Engine DifferenceDelta(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DifferenceDelta[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the difference quotient .
        ///https://reference.wolfram.com/language/ref/DifferenceQuotient.html
        ///</summary>
        public static Engine DifferenceQuotient(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DifferenceQuotient[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///computes the partial difference quotient with respect to x1,x2,….
        ///https://reference.wolfram.com/language/ref/DifferenceQuotient.html
        ///</summary>
        public static Engine DifferenceQuotient(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("DifferenceQuotient[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the holonomic sequence , specified by the linear difference equation lde[h,k].
        ///https://reference.wolfram.com/language/ref/DifferenceRoot.html
        ///</summary>
        public static Engine DifferenceRoot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DifferenceRoot[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to reduce expr to a single DifferenceRoot object as a function of n.
        ///https://reference.wolfram.com/language/ref/DifferenceRootReduce.html
        ///</summary>
        public static Engine DifferenceRootReduce(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DifferenceRootReduce[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the successive differences of elements in list.
        ///https://reference.wolfram.com/language/ref/Differences.html
        ///</summary>
        public static Engine Differences(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Differences[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the n differences of list.
        ///https://reference.wolfram.com/language/ref/Differences.html
        ///</summary>
        public static Engine Differences(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Differences[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the differences of elements step s apart.
        ///https://reference.wolfram.com/language/ref/Differences.html
        ///</summary>
        public static Engine Differences(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Differences[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the successive nk differences at level k in a nested list.
        ///https://reference.wolfram.com/language/ref/Differences.html
        ///</summary>
        public static Engine Differences(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Differences[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///displays as x.
        ///https://reference.wolfram.com/language/ref/DifferentialD.html
        ///</summary>
        public static Engine DifferentialD(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DifferentialD[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the holonomic function , specified by the linear differential equation lde[h,x].
        ///https://reference.wolfram.com/language/ref/DifferentialRoot.html
        ///</summary>
        public static Engine DifferentialRoot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DifferentialRoot[" + arg0 + "]", name);
        }

        ///<summary>
        ///attempts to reduce expr to a single DifferentialRoot object as a function of x.
        ///https://reference.wolfram.com/language/ref/DifferentialRootReduce.html
        ///</summary>
        public static Engine DifferentialRootReduce(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DifferentialRootReduce[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes the initial conditions to be specified at x=x0.
        ///https://reference.wolfram.com/language/ref/DifferentialRootReduce.html
        ///</summary>
        public static Engine DifferentialRootReduce(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DifferentialRootReduce[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///applies a differentiator filter with a cutoff frequency ωc to an array of data.
        ///https://reference.wolfram.com/language/ref/DifferentiatorFilter.html
        ///</summary>
        public static Engine DifferentiatorFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DifferentiatorFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a filter kernel of length n.
        ///https://reference.wolfram.com/language/ref/DifferentiatorFilter.html
        ///</summary>
        public static Engine DifferentiatorFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DifferentiatorFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///applies a smoothing window wfun to the filter kernel.
        ///https://reference.wolfram.com/language/ref/DifferentiatorFilter.html
        ///</summary>
        public static Engine DifferentiatorFilter(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DifferentiatorFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a diffusion term  with model variables vars.
        ///https://reference.wolfram.com/language/ref/DiffusionPDETerm.html
        ///</summary>
        public static Engine DiffusionPDETerm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiffusionPDETerm[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a diffusion term  with diffusion coefficient .
        ///https://reference.wolfram.com/language/ref/DiffusionPDETerm.html
        ///</summary>
        public static Engine DiffusionPDETerm(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiffusionPDETerm[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses model parameters pars.
        ///https://reference.wolfram.com/language/ref/DiffusionPDETerm.html
        ///</summary>
        public static Engine DiffusionPDETerm(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiffusionPDETerm[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Diggle–Gates point process with constant intensity μ and interaction radius ρ in .
        ///https://reference.wolfram.com/language/ref/DiggleGatesPointProcess.html
        ///</summary>
        public static Engine DiggleGatesPointProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiggleGatesPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Diggle–Gratton point process with constant intensity μ, interaction parameter κ, hard-core interaction radius δ and interaction radius ρ in .
        ///https://reference.wolfram.com/language/ref/DiggleGrattonPointProcess.html
        ///</summary>
        public static Engine DiggleGrattonPointProcess(this Engine en, object arg0, object arg1, object arg2, object arg3, object arg4, string? name = null)
        {
            return en.Execute("DiggleGrattonPointProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
        }

        ///<summary>
        ///represents a digital signature object.
        ///https://reference.wolfram.com/language/ref/DigitalSignature.html
        ///</summary>
        public static Engine DigitalSignature(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DigitalSignature[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the number of d digits in the base-b representation of n.
        ///https://reference.wolfram.com/language/ref/DigitCount.html
        ///</summary>
        public static Engine DigitCount(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DigitCount[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the numbers of , , …, ,  digits in the base-b representation of n.
        ///https://reference.wolfram.com/language/ref/DigitCount.html
        ///</summary>
        public static Engine DigitCount(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DigitCount[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the numbers of , , …, ,  digits in the base-10 representation of n.
        ///https://reference.wolfram.com/language/ref/DigitCount.html
        ///</summary>
        public static Engine DigitCount(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DigitCount[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if all the characters in the string are digits in the range 0 through 9, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/DigitQ.html
        ///</summary>
        public static Engine DigitQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DigitQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the angle between two half-planes bounded by the line through p1 and p2 and extended in the direction v and w.
        ///https://reference.wolfram.com/language/ref/DihedralAngle.html
        ///</summary>
        public static Engine DihedralAngle(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DihedralAngle[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents the dihedral group of order 2n.
        ///https://reference.wolfram.com/language/ref/DihedralGroup.html
        ///</summary>
        public static Engine DihedralGroup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DihedralGroup[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the morphological dilation of image with respect to the structuring element ker.
        ///https://reference.wolfram.com/language/ref/Dilation.html
        ///</summary>
        public static Engine Dilation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Dilation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the possible combinations of the list of physical quantities pqi that are dimensionless.
        ///https://reference.wolfram.com/language/ref/DimensionalCombinations.html
        ///</summary>
        public static Engine DimensionalCombinations(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DimensionalCombinations[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the possible combinations of the list of physical quantities pqi that match the dimensions of physical quantity dim.
        ///https://reference.wolfram.com/language/ref/DimensionalCombinations.html
        ///</summary>
        public static Engine DimensionalCombinations(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DimensionalCombinations[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list {r0,r1,…} of regions such that rd has dimension d for a mesh region mr.
        ///https://reference.wolfram.com/language/ref/DimensionalMeshComponents.html
        ///</summary>
        public static Engine DimensionalMeshComponents(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DimensionalMeshComponents[" + arg0 + "]", name);
        }

        ///<summary>
        ///projects the examples examplei to a lower-dimensional approximating manifold.
        ///https://reference.wolfram.com/language/ref/DimensionReduce.html
        ///</summary>
        public static Engine DimensionReduce(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DimensionReduce[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///projects onto an approximating manifold in n-dimensional space.
        ///https://reference.wolfram.com/language/ref/DimensionReduce.html
        ///</summary>
        public static Engine DimensionReduce(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DimensionReduce[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a function generated by DimensionReduction that projects data onto a lower-dimensional approximating manifold.
        ///https://reference.wolfram.com/language/ref/DimensionReducerFunction.html
        ///</summary>
        public static Engine DimensionReducerFunction(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DimensionReducerFunction[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a DimensionReducerFunction[…] that projects from the space defined by the examplei to a lower-dimensional approximating manifold.
        ///https://reference.wolfram.com/language/ref/DimensionReduction.html
        ///</summary>
        public static Engine DimensionReduction(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DimensionReduction[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a DimensionReducerFunction[…] for an n-dimensional approximating manifold.
        ///https://reference.wolfram.com/language/ref/DimensionReduction.html
        ///</summary>
        public static Engine DimensionReduction(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DimensionReduction[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates the specified properties of the dimensionality reduction.
        ///https://reference.wolfram.com/language/ref/DimensionReduction.html
        ///</summary>
        public static Engine DimensionReduction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DimensionReduction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the dimensions of expr.
        ///https://reference.wolfram.com/language/ref/Dimensions.html
        ///</summary>
        public static Engine Dimensions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Dimensions[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of the dimensions of expr down to level n.
        ///https://reference.wolfram.com/language/ref/Dimensions.html
        ///</summary>
        public static Engine Dimensions(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Dimensions[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the Dirac comb function  giving a delta function at every integer point.
        ///https://reference.wolfram.com/language/ref/DiracComb.html
        ///</summary>
        public static Engine DiracComb(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiracComb[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the multidimensional Dirac comb function .
        ///https://reference.wolfram.com/language/ref/DiracComb.html
        ///</summary>
        public static Engine DiracComb(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiracComb[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the Dirac delta function .
        ///https://reference.wolfram.com/language/ref/DiracDelta.html
        ///</summary>
        public static Engine DiracDelta(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiracDelta[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents the multidimensional Dirac delta function .
        ///https://reference.wolfram.com/language/ref/DiracDelta.html
        ///</summary>
        public static Engine DiracDelta(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiracDelta[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a directed graph from the undirected graph g.
        ///https://reference.wolfram.com/language/ref/DirectedGraph.html
        ///</summary>
        public static Engine DirectedGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirectedGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a directed graph using the conversion conv.
        ///https://reference.wolfram.com/language/ref/DirectedGraph.html
        ///</summary>
        public static Engine DirectedGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DirectedGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/DirectedGraph.html
        ///</summary>
        public static Engine DirectedGraph(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DirectedGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a directed graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/DirectedGraphQ.html
        ///</summary>
        public static Engine DirectedGraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirectedGraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an infinite numerical quantity whose direction in the complex plane is unknown.
        ///https://reference.wolfram.com/language/ref/DirectedInfinity.html
        ///</summary>
        public static Engine DirectedInfinity(this Engine en, string? name = null)
        {
            return en.Execute("DirectedInfinity[]", name);
        }

        ///<summary>
        ///represents an infinite numerical quantity that is a positive real multiple of the complex number z.
        ///https://reference.wolfram.com/language/ref/DirectedInfinity.html
        ///</summary>
        public static Engine DirectedInfinity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirectedInfinity[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a three–dimensional graphics directive that specifies the directional light of color col from the point pt to the center of the bounding box to use in coloring 3D surfaces.
        ///https://reference.wolfram.com/language/ref/DirectionalLight.html
        ///</summary>
        public static Engine DirectionalLight(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DirectionalLight[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a directional light along the vector from pt1 to pt2.
        ///https://reference.wolfram.com/language/ref/DirectionalLight.html
        ///</summary>
        public static Engine DirectionalLight(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DirectionalLight[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a single graphics directive composed of the directives g1, g2, ….
        ///https://reference.wolfram.com/language/ref/Directive.html
        ///</summary>
        public static Engine Directive(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Directive[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the current working directory.
        ///https://reference.wolfram.com/language/ref/Directory.html
        ///</summary>
        public static Engine Directory(this Engine en, string? name = null)
        {
            return en.Execute("Directory[]", name);
        }

        ///<summary>
        ///extracts the directory name from the specification for a file.
        ///https://reference.wolfram.com/language/ref/DirectoryName.html
        ///</summary>
        public static Engine DirectoryName(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirectoryName[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives True if the directory with the specified name exists, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/DirectoryQ.html
        ///</summary>
        public static Engine DirectoryQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirectoryQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the directory stack that represents the sequence of current directories used.
        ///https://reference.wolfram.com/language/ref/DirectoryStack.html
        ///</summary>
        public static Engine DirectoryStack(this Engine en, string? name = null)
        {
            return en.Execute("DirectoryStack[]", name);
        }

        ///<summary>
        ///gives the Dirichlet beta function .
        ///https://reference.wolfram.com/language/ref/DirichletBeta.html
        ///</summary>
        public static Engine DirichletBeta(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirichletBeta[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet character  with modulus k and index j.
        ///https://reference.wolfram.com/language/ref/DirichletCharacter.html
        ///</summary>
        public static Engine DirichletCharacter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DirichletCharacter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Dirichlet boundary condition given by equation beqn, satisfied on the part of the boundary of the region given to NDSolve and related functions where pred is True.
        ///https://reference.wolfram.com/language/ref/DirichletCondition.html
        ///</summary>
        public static Engine DirichletCondition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DirichletCondition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet convolution of the expressions f and g.
        ///https://reference.wolfram.com/language/ref/DirichletConvolve.html
        ///</summary>
        public static Engine DirichletConvolve(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DirichletConvolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a Dirichlet distribution of dimension k with shape parameters αi.
        ///https://reference.wolfram.com/language/ref/DirichletDistribution.html
        ///</summary>
        public static Engine DirichletDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DirichletDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet eta function .
        ///https://reference.wolfram.com/language/ref/DirichletEta.html
        ///</summary>
        public static Engine DirichletEta(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirichletEta[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet L-function  for the Dirichlet character  with modulus k and index j.
        ///https://reference.wolfram.com/language/ref/DirichletL.html
        ///</summary>
        public static Engine DirichletL(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DirichletL[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet lambda function .
        ///https://reference.wolfram.com/language/ref/DirichletLambda.html
        ///</summary>
        public static Engine DirichletLambda(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirichletLambda[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Dirichlet transform of expr with respect to n.
        ///https://reference.wolfram.com/language/ref/DirichletTransform.html
        ///</summary>
        public static Engine DirichletTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DirichletTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Dirichlet window function of x.
        ///https://reference.wolfram.com/language/ref/DirichletWindow.html
        ///</summary>
        public static Engine DirichletWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DirichletWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a form that disables the formatting of expr when it appears inside held expressions, but gives expr as soon as evaluation occurs.
        ///https://reference.wolfram.com/language/ref/DisableFormatting.html
        ///</summary>
        public static Engine DisableFormatting(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DisableFormatting[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an asymptotic approximation for expr as n tends to infinity over the integers.
        ///https://reference.wolfram.com/language/ref/DiscreteAsymptotic.html
        ///</summary>
        public static Engine DiscreteAsymptotic(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteAsymptotic[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives an asymptotic series approximation for expr to order m.
        ///https://reference.wolfram.com/language/ref/DiscreteAsymptotic.html
        ///</summary>
        public static Engine DiscreteAsymptotic(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscreteAsymptotic[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the chirp Z transform of list.
        ///https://reference.wolfram.com/language/ref/DiscreteChirpZTransform.html
        ///</summary>
        public static Engine DiscreteChirpZTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiscreteChirpZTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns a length n chirp Z transform.
        ///https://reference.wolfram.com/language/ref/DiscreteChirpZTransform.html
        ///</summary>
        public static Engine DiscreteChirpZTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteChirpZTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a spiral path on the complex  plane defined by w.
        ///https://reference.wolfram.com/language/ref/DiscreteChirpZTransform.html
        ///</summary>
        public static Engine DiscreteChirpZTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteChirpZTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses a as the complex starting point.
        ///https://reference.wolfram.com/language/ref/DiscreteChirpZTransform.html
        ///</summary>
        public static Engine DiscreteChirpZTransform(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DiscreteChirpZTransform[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional chirp Z transform.
        ///https://reference.wolfram.com/language/ref/DiscreteChirpZTransform.html
        ///</summary>
        public static Engine DiscreteChirpZTransform(this Engine en, object arg0, List<object> arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("DiscreteChirpZTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives the convolution with respect to n of the expressions f and g.
        ///https://reference.wolfram.com/language/ref/DiscreteConvolve.html
        ///</summary>
        public static Engine DiscreteConvolve(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DiscreteConvolve[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional convolution.
        ///https://reference.wolfram.com/language/ref/DiscreteConvolve.html
        ///</summary>
        public static Engine DiscreteConvolve(this Engine en, object arg0, object arg1, List<object> arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("DiscreteConvolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives the discrete delta function , equal to 1 if all the ni are zero, and 0 otherwise.
        ///https://reference.wolfram.com/language/ref/DiscreteDelta.html
        ///</summary>
        public static Engine DiscreteDelta(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteDelta[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the discrete Hadamard transform of list.
        ///https://reference.wolfram.com/language/ref/DiscreteHadamardTransform.html
        ///</summary>
        public static Engine DiscreteHadamardTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiscreteHadamardTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields the discrete indicator function, equal to 1 if x=x1 and, otherwise, to 0 if x=ui for some i.
        ///https://reference.wolfram.com/language/ref/DiscreteIndicator.html
        ///</summary>
        public static Engine DiscreteIndicator(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DiscreteIndicator[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents a discrete-time model with input u and output  at sampling instant i.
        ///https://reference.wolfram.com/language/ref/DiscreteInputOutputModel.html
        ///</summary>
        public static Engine DiscreteInputOutputModel(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteInputOutputModel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///can be used to specify outputs  that also depend on the output variables y.
        ///https://reference.wolfram.com/language/ref/DiscreteInputOutputModel.html
        ///</summary>
        public static Engine DiscreteInputOutputModel(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteInputOutputModel[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies input and output values for each signal for instants k<=0.
        ///https://reference.wolfram.com/language/ref/DiscreteInputOutputModel.html
        ///</summary>
        public static Engine DiscreteInputOutputModel(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, List<object> arg4, string? name = null)
        {
            return en.Execute("DiscreteInputOutputModel[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
        }

        ///<summary>
        ///gives the limit k∞f(k) for the sequence f as k tends to infinity over the integers.
        ///https://reference.wolfram.com/language/ref/DiscreteLimit.html
        ///</summary>
        public static Engine DiscreteLimit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteLimit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the nested limit ⋯ f(k1,…,kn) over the integers.
        ///https://reference.wolfram.com/language/ref/DiscreteLimit.html
        ///</summary>
        public static Engine DiscreteLimit(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscreteLimit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the optimal discrete-time estimator gain matrix with sampling period τ for the continuous-time StateSpaceModel ssm, with process and measurement noise covariance matrices w and v.
        ///https://reference.wolfram.com/language/ref/DiscreteLQEstimatorGains.html
        ///</summary>
        public static Engine DiscreteLQEstimatorGains(this Engine en, object arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteLQEstimatorGains[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///specifies sensors as the noisy measurements of ssm.
        ///https://reference.wolfram.com/language/ref/DiscreteLQEstimatorGains.html
        ///</summary>
        public static Engine DiscreteLQEstimatorGains(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteLQEstimatorGains[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the discrete-time state feedback gains with sampling period τ for the continuous-time system specification sspec that minimizes a cost function with weights wts.
        ///https://reference.wolfram.com/language/ref/DiscreteLQRegulatorGains.html
        ///</summary>
        public static Engine DiscreteLQRegulatorGains(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteLQRegulatorGains[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the value of the property "prop".
        ///https://reference.wolfram.com/language/ref/DiscreteLQRegulatorGains.html
        ///</summary>
        public static Engine DiscreteLQRegulatorGains(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteLQRegulatorGains[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///finds the numeric solution  of the discrete matrix equation .
        ///https://reference.wolfram.com/language/ref/DiscreteLyapunovSolve.html
        ///</summary>
        public static Engine DiscreteLyapunovSolve(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteLyapunovSolve[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///solves .
        ///https://reference.wolfram.com/language/ref/DiscreteLyapunovSolve.html
        ///</summary>
        public static Engine DiscreteLyapunovSolve(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteLyapunovSolve[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///solves .
        ///https://reference.wolfram.com/language/ref/DiscreteLyapunovSolve.html
        ///</summary>
        public static Engine DiscreteLyapunovSolve(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteLyapunovSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///solves .
        ///https://reference.wolfram.com/language/ref/DiscreteLyapunovSolve.html
        ///</summary>
        public static Engine DiscreteLyapunovSolve(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteLyapunovSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a discrete-time, finite-state Markov process with transition matrix m and initial state i0.
        ///https://reference.wolfram.com/language/ref/DiscreteMarkovProcess.html
        ///</summary>
        public static Engine DiscreteMarkovProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteMarkovProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the max limit k∞f(k) of the sequence f as k tends to ∞ over the integers.
        ///https://reference.wolfram.com/language/ref/DiscreteMaxLimit.html
        ///</summary>
        public static Engine DiscreteMaxLimit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteMaxLimit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the nested max limit ⋯ f(k1,…,kn) over the integers.
        ///https://reference.wolfram.com/language/ref/DiscreteMaxLimit.html
        ///</summary>
        public static Engine DiscreteMaxLimit(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscreteMaxLimit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the min limit k∞f(k) of the sequence f as k tends to ∞ over the integers.
        ///https://reference.wolfram.com/language/ref/DiscreteMinLimit.html
        ///</summary>
        public static Engine DiscreteMinLimit(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteMinLimit[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the nested min limit ⋯ f(k1,…,kn) over the integers.
        ///https://reference.wolfram.com/language/ref/DiscreteMinLimit.html
        ///</summary>
        public static Engine DiscreteMinLimit(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscreteMinLimit[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///generates a plot of the values of expr when n runs from 1 to nmax.
        ///https://reference.wolfram.com/language/ref/DiscretePlot.html
        ///</summary>
        public static Engine DiscretePlot(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscretePlot[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the successive values n1, n2, ….
        ///https://reference.wolfram.com/language/ref/DiscretePlot.html
        ///</summary>
        public static Engine DiscretePlot(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DiscretePlot[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///plots the values of all the expri.
        ///https://reference.wolfram.com/language/ref/DiscretePlot.html
        ///</summary>
        public static Engine DiscretePlot(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscretePlot[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a plot of the values of expr when i runs from imin to imax and j runs from jmin to jmax.
        ///https://reference.wolfram.com/language/ref/DiscretePlot3D.html
        ///</summary>
        public static Engine DiscretePlot3D(this Engine en, object arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DiscretePlot3D[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///uses successive i values i1, i2, … and j values j1,  j2, ….
        ///https://reference.wolfram.com/language/ref/DiscretePlot3D.html
        ///</summary>
        public static Engine DiscretePlot3D(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, List<object> arg4, string? name = null)
        {
            return en.Execute("DiscretePlot3D[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
        }

        ///<summary>
        ///plots the values of all the expri.
        ///https://reference.wolfram.com/language/ref/DiscretePlot3D.html
        ///</summary>
        public static Engine DiscretePlot3D(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscretePlot3D[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the discrete ratio .
        ///https://reference.wolfram.com/language/ref/DiscreteRatio.html
        ///</summary>
        public static Engine DiscreteRatio(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteRatio[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multiple discrete ratio.
        ///https://reference.wolfram.com/language/ref/DiscreteRatio.html
        ///</summary>
        public static Engine DiscreteRatio(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscreteRatio[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///computes the partial difference ratio with respect to i, j, ….
        ///https://reference.wolfram.com/language/ref/DiscreteRatio.html
        ///</summary>
        public static Engine DiscreteRatio(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DiscreteRatio[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the matrix  that is the stabilizing solution of the discrete algebraic Riccati equation .
        ///https://reference.wolfram.com/language/ref/DiscreteRiccatiSolve.html
        ///</summary>
        public static Engine DiscreteRiccatiSolve(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscreteRiccatiSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the discrete shift .
        ///https://reference.wolfram.com/language/ref/DiscreteShift.html
        ///</summary>
        public static Engine DiscreteShift(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteShift[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multiple shift .
        ///https://reference.wolfram.com/language/ref/DiscreteShift.html
        ///</summary>
        public static Engine DiscreteShift(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscreteShift[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///computes partial shifts with respect to i, j, ….
        ///https://reference.wolfram.com/language/ref/DiscreteShift.html
        ///</summary>
        public static Engine DiscreteShift(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DiscreteShift[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives True if lsys is a discrete-time systems model, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DiscreteTimeModelQ.html
        ///</summary>
        public static Engine DiscreteTimeModelQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiscreteTimeModelQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a discrete uniform distribution over the integers from imin to imax.
        ///https://reference.wolfram.com/language/ref/DiscreteUniformDistribution.html
        ///</summary>
        public static Engine DiscreteUniformDistribution(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DiscreteUniformDistribution[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a multivariate discrete uniform distribution over integers within the box {{imin,imax},{jmin,jmax},…}.
        ///https://reference.wolfram.com/language/ref/DiscreteUniformDistribution.html
        ///</summary>
        public static Engine DiscreteUniformDistribution(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscreteUniformDistribution[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields a discrete wavelet data object with wavelet coefficients coefi corresponding to wavelet index windi, wavelet wave, and wavelet transform wtrans.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletData.html
        ///</summary>
        public static Engine DiscreteWaveletData(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteWaveletData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields a discrete wavelet data object assuming data dimensions {d1,…}.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletData.html
        ///</summary>
        public static Engine DiscreteWaveletData(this Engine en, List<object> arg0, object arg1, object arg2, List<object> arg3, string? name = null)
        {
            return en.Execute("DiscreteWaveletData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives the discrete wavelet packet transform (DWPT) of an array of data.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletPacketTransform.html
        ///</summary>
        public static Engine DiscreteWaveletPacketTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiscreteWaveletPacketTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the discrete wavelet packet transform using the wavelet wave.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletPacketTransform.html
        ///</summary>
        public static Engine DiscreteWaveletPacketTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteWaveletPacketTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the discrete wavelet packet transform using r levels of refinement.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletPacketTransform.html
        ///</summary>
        public static Engine DiscreteWaveletPacketTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteWaveletPacketTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the discrete wavelet transform (DWT) of an array of data.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletTransform.html
        ///</summary>
        public static Engine DiscreteWaveletTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiscreteWaveletTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the discrete wavelet transform using the wavelet wave.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletTransform.html
        ///</summary>
        public static Engine DiscreteWaveletTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscreteWaveletTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the discrete wavelet transform using r levels of refinement.
        ///https://reference.wolfram.com/language/ref/DiscreteWaveletTransform.html
        ///</summary>
        public static Engine DiscreteWaveletTransform(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DiscreteWaveletTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///discretizes a 2D or 3D graphic g into a MeshRegion.
        ///https://reference.wolfram.com/language/ref/DiscretizeGraphics.html
        ///</summary>
        public static Engine DiscretizeGraphics(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiscretizeGraphics[" + arg0 + "]", name);
        }

        ///<summary>
        ///discretizes only the elements in g that match the pattern patt.
        ///https://reference.wolfram.com/language/ref/DiscretizeGraphics.html
        ///</summary>
        public static Engine DiscretizeGraphics(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiscretizeGraphics[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///discretizes a region reg into a MeshRegion.
        ///https://reference.wolfram.com/language/ref/DiscretizeRegion.html
        ///</summary>
        public static Engine DiscretizeRegion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiscretizeRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///restricts to the bounds .
        ///https://reference.wolfram.com/language/ref/DiscretizeRegion.html
        ///</summary>
        public static Engine DiscretizeRegion(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DiscretizeRegion[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///computes the discriminant of the polynomial poly with respect to the variable var.
        ///https://reference.wolfram.com/language/ref/Discriminant.html
        ///</summary>
        public static Engine Discriminant(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Discriminant[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///computes the discriminant modulo .
        ///https://reference.wolfram.com/language/ref/Discriminant.html
        ///</summary>
        public static Engine Discriminant(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Discriminant[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///yields True if list1 and list2 do not share any common elements, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DisjointQ.html
        ///</summary>
        public static Engine DisjointQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DisjointQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the disjunction of expr over all choices of the Boolean variables ai.
        ///https://reference.wolfram.com/language/ref/Disjunction.html
        ///</summary>
        public static Engine Disjunction(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Disjunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a disk of radius r centered at {x,y}.
        ///https://reference.wolfram.com/language/ref/Disk.html
        ///</summary>
        public static Engine Disk(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Disk[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a disk of radius 1.
        ///https://reference.wolfram.com/language/ref/Disk.html
        ///</summary>
        public static Engine Disk(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Disk[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives an axis-aligned elliptical disk with semiaxes lengths rx and ry.
        ///https://reference.wolfram.com/language/ref/Disk.html
        ///</summary>
        public static Engine Disk(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Disk[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a sector of a disk from angle θ1 to θ2.
        ///https://reference.wolfram.com/language/ref/Disk.html
        ///</summary>
        public static Engine Disk(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Disk[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives a matrix whose elements are 1 in a disk-shaped region of radius r, and are otherwise 0.
        ///https://reference.wolfram.com/language/ref/DiskMatrix.html
        ///</summary>
        public static Engine DiskMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DiskMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a w×w matrix containing a disk of 1s with radius r.
        ///https://reference.wolfram.com/language/ref/DiskMatrix.html
        ///</summary>
        public static Engine DiskMatrix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DiskMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields an array whose elements are 1 in an ellipsoidal region with semiaxis ri in the i index direction.
        ///https://reference.wolfram.com/language/ref/DiskMatrix.html
        ///</summary>
        public static Engine DiskMatrix(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DiskMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the disk segment from angle θ1 to θ2 in a disk centered at {x,y} of radius r.
        ///https://reference.wolfram.com/language/ref/DiskSegment.html
        ///</summary>
        public static Engine DiskSegment(this Engine en, List<object> arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DiskSegment[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents the ellipse segment from angle θ1 to θ2 in an axis-aligned ellipse with semiaxes lengths rx and ry.
        ///https://reference.wolfram.com/language/ref/DiskSegment.html
        ///</summary>
        public static Engine DiskSegment(this Engine en, List<object> arg0, List<object> arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DiskSegment[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///generates an optimized dispatch table representation of a list of rules. The object produced by Dispatch can be used to give the rules in expr/.rules.
        ///https://reference.wolfram.com/language/ref/Dispatch.html
        ///</summary>
        public static Engine Dispatch(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("Dispatch[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that indicates the end of a series of expressions relating to a postscript graphic.
        ///https://reference.wolfram.com/language/ref/DisplayEndPacket.html
        ///</summary>
        public static Engine DisplayEndPacket(this Engine en, string? name = null)
        {
            return en.Execute("DisplayEndPacket[]", name);
        }

        ///<summary>
        ///prints with low-level boxes inside expr shown in explicit two-dimensional or other form.
        ///https://reference.wolfram.com/language/ref/DisplayForm.html
        ///</summary>
        public static Engine DisplayForm(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DisplayForm[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a WSTP packet that indicates the beginning of a series of expressions related to a PostScript graphic.
        ///https://reference.wolfram.com/language/ref/DisplayPacket.html
        ///</summary>
        public static Engine DisplayPacket(this Engine en, string? name = null)
        {
            return en.Execute("DisplayPacket[]", name);
        }

        ///<summary>
        ///gives the matrix of distances between each pair of elements ui, uj.
        ///https://reference.wolfram.com/language/ref/DistanceMatrix.html
        ///</summary>
        public static Engine DistanceMatrix(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DistanceMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the matrix of distances between each pair of elements ui, vj.
        ///https://reference.wolfram.com/language/ref/DistanceMatrix.html
        ///</summary>
        public static Engine DistanceMatrix(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DistanceMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the distance transform of image, in which the value of each pixel is replaced by its distance to the nearest background pixel.
        ///https://reference.wolfram.com/language/ref/DistanceTransform.html
        ///</summary>
        public static Engine DistanceTransform(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DistanceTransform[" + arg0 + "]", name);
        }

        ///<summary>
        ///treats values above t as foreground.
        ///https://reference.wolfram.com/language/ref/DistanceTransform.html
        ///</summary>
        public static Engine DistanceTransform(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DistanceTransform[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///distributes f over Plus appearing in any of the xi.
        ///https://reference.wolfram.com/language/ref/Distribute.html
        ///</summary>
        public static Engine Distribute(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Distribute[" + arg0 + "]", name);
        }

        ///<summary>
        ///distributes over g.
        ///https://reference.wolfram.com/language/ref/Distribute.html
        ///</summary>
        public static Engine Distribute(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Distribute[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///performs the distribution only if the head of expr is f.
        ///https://reference.wolfram.com/language/ref/Distribute.html
        ///</summary>
        public static Engine Distribute(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Distribute[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///or xdist asserts that the random variable x is distributed according to the probability distribution dist.
        ///https://reference.wolfram.com/language/ref/Distributed.html
        ///</summary>
        public static Engine Distributed(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Distributed[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///or {x1,x2,…}dist asserts that the random vector {x1,x2,…} is distributed according to the multivariate probability distribution dist.
        ///https://reference.wolfram.com/language/ref/Distributed.html
        ///</summary>
        public static Engine Distributed(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Distributed[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///distributes all definitions for the symbols si to all parallel kernels.
        ///https://reference.wolfram.com/language/ref/DistributeDefinitions.html
        ///</summary>
        public static Engine DistributeDefinitions(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DistributeDefinitions[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///distributes definitions for all symbols in the specified context.
        ///https://reference.wolfram.com/language/ref/DistributeDefinitions.html
        ///</summary>
        public static Engine DistributeDefinitions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DistributeDefinitions[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a distribution chart with a distribution symbol for each datai.
        ///https://reference.wolfram.com/language/ref/DistributionChart.html
        ///</summary>
        public static Engine DistributionChart(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DistributionChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed.
        ///https://reference.wolfram.com/language/ref/DistributionFitTest.html
        ///</summary>
        public static Engine DistributionFitTest(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DistributionFitTest[" + arg0 + "]", name);
        }

        ///<summary>
        ///tests whether data is distributed according to dist.
        ///https://reference.wolfram.com/language/ref/DistributionFitTest.html
        ///</summary>
        public static Engine DistributionFitTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DistributionFitTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the value of "property".
        ///https://reference.wolfram.com/language/ref/DistributionFitTest.html
        ///</summary>
        public static Engine DistributionFitTest(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DistributionFitTest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a logical expression for assumptions on parameters in the symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/DistributionParameterAssumptions.html
        ///</summary>
        public static Engine DistributionParameterAssumptions(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DistributionParameterAssumptions[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if dist is a valid distribution, and yields False otherwise.
        ///https://reference.wolfram.com/language/ref/DistributionParameterQ.html
        ///</summary>
        public static Engine DistributionParameterQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DistributionParameterQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the divergence .
        ///https://reference.wolfram.com/language/ref/Div.html
        ///</summary>
        public static Engine Div(this Engine en, List<object> arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Div[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the divergence in the coordinates chart.
        ///https://reference.wolfram.com/language/ref/Div.html
        ///</summary>
        public static Engine Div(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("Div[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is equivalent to .
        ///https://reference.wolfram.com/language/ref/Divide.html
        ///</summary>
        public static Engine Divide(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Divide[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///divides each side of the equation or inequality rel by x.
        ///https://reference.wolfram.com/language/ref/DivideSides.html
        ///</summary>
        public static Engine DivideSides(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DivideSides[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///divides each side of rel by the right-hand side, producing a 1 right-hand side.
        ///https://reference.wolfram.com/language/ref/DivideSides.html
        ///</summary>
        public static Engine DivideSides(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DivideSides[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields True if n is divisible by m, and yields False if it is not.
        ///https://reference.wolfram.com/language/ref/Divisible.html
        ///</summary>
        public static Engine Divisible(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Divisible[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the integers that divide n.
        ///https://reference.wolfram.com/language/ref/Divisors.html
        ///</summary>
        public static Engine Divisors(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Divisors[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the divisor function .
        ///https://reference.wolfram.com/language/ref/DivisorSigma.html
        ///</summary>
        public static Engine DivisorSigma(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DivisorSigma[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the sum of form[i] for all i that divide n.
        ///https://reference.wolfram.com/language/ref/DivisorSum.html
        ///</summary>
        public static Engine DivisorSum(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DivisorSum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///includes only those divisors for which cond[i] gives True.
        ///https://reference.wolfram.com/language/ref/DivisorSum.html
        ///</summary>
        public static Engine DivisorSum(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DivisorSum[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///converts an angle θ given in decimal degrees to a DMS list {degree,minute,second}.
        ///https://reference.wolfram.com/language/ref/DMSList.html
        ///</summary>
        public static Engine DMSList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DMSList[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts an angle θ given in decimal degrees to a degrees-minutes-seconds string.
        ///https://reference.wolfram.com/language/ref/DMSString.html
        ///</summary>
        public static Engine DMSString(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DMSString[" + arg0 + "]", name);
        }

        ///<summary>
        ///converts latitude and longitude given in decimal degrees to a DMS latitude-longitude string.
        ///https://reference.wolfram.com/language/ref/DMSString.html
        ///</summary>
        public static Engine DMSString(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DMSString[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates expr n times.
        ///https://reference.wolfram.com/language/ref/Do.html
        ///</summary>
        public static Engine Do(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Do[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///evaluates expr with the variable i successively taking on the values 1 through imax (in steps of 1).
        ///https://reference.wolfram.com/language/ref/Do.html
        ///</summary>
        public static Engine Do(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Do[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses the successive values i1, i2, ….
        ///https://reference.wolfram.com/language/ref/Do.html
        ///</summary>
        public static Engine Do(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("Do[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///evaluates expr looping over different values of j etc. for each i.
        ///https://reference.wolfram.com/language/ref/Do.html
        ///</summary>
        public static Engine Do(this Engine en, object arg0, List<object> arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("Do[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a document generator with template template to be evaluated on the schedule defined by timespec.
        ///https://reference.wolfram.com/language/ref/DocumentGenerator.html
        ///</summary>
        public static Engine DocumentGenerator(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DocumentGenerator[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///takes parameters for filling the template from driver.
        ///https://reference.wolfram.com/language/ref/DocumentGenerator.html
        ///</summary>
        public static Engine DocumentGenerator(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DocumentGenerator[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the properties of the DocumentGenerator cloudobj.
        ///https://reference.wolfram.com/language/ref/DocumentGeneratorInformation.html
        ///</summary>
        public static Engine DocumentGeneratorInformation(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DocumentGeneratorInformation[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the value of the property property.
        ///https://reference.wolfram.com/language/ref/DocumentGeneratorInformation.html
        ///</summary>
        public static Engine DocumentGeneratorInformation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DocumentGeneratorInformation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of CloudObject expressions that represent currently deployed document generators.
        ///https://reference.wolfram.com/language/ref/DocumentGenerators.html
        ///</summary>
        public static Engine DocumentGenerators(this Engine en, string? name = null)
        {
            return en.Execute("DocumentGenerators[]", name);
        }

        ///<summary>
        ///represents a complete document notebook in the Wolfram System front end.
        ///https://reference.wolfram.com/language/ref/DocumentNotebook.html
        ///</summary>
        public static Engine DocumentNotebook(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DocumentNotebook[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a regular dodecahedron centered at the origin with unit edge length.
        ///https://reference.wolfram.com/language/ref/Dodecahedron.html
        ///</summary>
        public static Engine Dodecahedron(this Engine en, string? name = null)
        {
            return en.Execute("Dodecahedron[]", name);
        }

        ///<summary>
        ///represents a dodecahedron with edge length l.
        ///https://reference.wolfram.com/language/ref/Dodecahedron.html
        ///</summary>
        public static Engine Dodecahedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Dodecahedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a dodecahedron rotated by an angle θ with respect to the z axis and angle ϕ with respect to the y axis.
        ///https://reference.wolfram.com/language/ref/Dodecahedron.html
        ///</summary>
        public static Engine Dodecahedron(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("Dodecahedron[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns dominant colors in image.
        ///https://reference.wolfram.com/language/ref/DominantColors.html
        ///</summary>
        public static Engine DominantColors(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DominantColors[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns at most n dominant colors in image.
        ///https://reference.wolfram.com/language/ref/DominantColors.html
        ///</summary>
        public static Engine DominantColors(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DominantColors[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the specified property prop for the regions that belong to the same dominant color.
        ///https://reference.wolfram.com/language/ref/DominantColors.html
        ///</summary>
        public static Engine DominantColors(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DominantColors[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the output in the specified format.
        ///https://reference.wolfram.com/language/ref/DominantColors.html
        ///</summary>
        public static Engine DominantColors(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DominantColors[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///returns dominant colors in each imagei.
        ///https://reference.wolfram.com/language/ref/DominantColors.html
        ///</summary>
        public static Engine DominantColors(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DominantColors[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the dominator tree of the directed graph g from the root vertex v.
        ///https://reference.wolfram.com/language/ref/DominatorTreeGraph.html
        ///</summary>
        public static Engine DominatorTreeGraph(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DominatorTreeGraph[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the list of immediate dominators of the directed graph g from the root vertex v.
        ///https://reference.wolfram.com/language/ref/DominatorVertexList.html
        ///</summary>
        public static Engine DominatorVertexList(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DominatorVertexList[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives products of vectors, matrices, and tensors.
        ///https://reference.wolfram.com/language/ref/Dot.html
        ///</summary>
        public static Engine Dot(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Dot[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x≐y≐….
        ///https://reference.wolfram.com/language/ref/DotEqual.html
        ///</summary>
        public static Engine DotEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DotEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a net layer that takes the dot product of two or more arrays.
        ///https://reference.wolfram.com/language/ref/DotLayer.html
        ///</summary>
        public static Engine DotLayer(this Engine en, string? name = null)
        {
            return en.Execute("DotLayer[]", name);
        }

        ///<summary>
        ///uses given transpose specifications for the respective inputs.
        ///https://reference.wolfram.com/language/ref/DotLayer.html
        ///</summary>
        public static Engine DotLayer(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DotLayer[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///displays as x,y,….
        ///https://reference.wolfram.com/language/ref/DoubleBracketingBar.html
        ///</summary>
        public static Engine DoubleBracketingBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleBracketingBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⇓y….
        ///https://reference.wolfram.com/language/ref/DoubleDownArrow.html
        ///</summary>
        public static Engine DoubleDownArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleDownArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⇐y⇐….
        ///https://reference.wolfram.com/language/ref/DoubleLeftArrow.html
        ///</summary>
        public static Engine DoubleLeftArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleLeftArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⇔y⇔….
        ///https://reference.wolfram.com/language/ref/DoubleLeftRightArrow.html
        ///</summary>
        public static Engine DoubleLeftRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleLeftRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/DoubleLeftTee.html
        ///</summary>
        public static Engine DoubleLeftTee(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DoubleLeftTee[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as x⟸y⟸….
        ///https://reference.wolfram.com/language/ref/DoubleLongLeftArrow.html
        ///</summary>
        public static Engine DoubleLongLeftArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleLongLeftArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⟺y⟺….
        ///https://reference.wolfram.com/language/ref/DoubleLongLeftRightArrow.html
        ///</summary>
        public static Engine DoubleLongLeftRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleLongLeftRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⟹y⟹….
        ///https://reference.wolfram.com/language/ref/DoubleLongRightArrow.html
        ///</summary>
        public static Engine DoubleLongRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleLongRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⇒y⇒….
        ///https://reference.wolfram.com/language/ref/DoubleRightArrow.html
        ///</summary>
        public static Engine DoubleRightArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleRightArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/DoubleRightTee.html
        ///</summary>
        public static Engine DoubleRightTee(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DoubleRightTee[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as x⇑y⇑….
        ///https://reference.wolfram.com/language/ref/DoubleUpArrow.html
        ///</summary>
        public static Engine DoubleUpArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleUpArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⇕y⇕….
        ///https://reference.wolfram.com/language/ref/DoubleUpDownArrow.html
        ///</summary>
        public static Engine DoubleUpDownArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleUpDownArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x∥y∥….
        ///https://reference.wolfram.com/language/ref/DoubleVerticalBar.html
        ///</summary>
        public static Engine DoubleVerticalBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DoubleVerticalBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x↓y↓….
        ///https://reference.wolfram.com/language/ref/DownArrow.html
        ///</summary>
        public static Engine DownArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⤓y⤓….
        ///https://reference.wolfram.com/language/ref/DownArrowBar.html
        ///</summary>
        public static Engine DownArrowBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownArrowBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⇵y⇵….
        ///https://reference.wolfram.com/language/ref/DownArrowUpArrow.html
        ///</summary>
        public static Engine DownArrowUpArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownArrowUpArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⥐y⥐….
        ///https://reference.wolfram.com/language/ref/DownLeftRightVector.html
        ///</summary>
        public static Engine DownLeftRightVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownLeftRightVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⥞y⥞….
        ///https://reference.wolfram.com/language/ref/DownLeftTeeVector.html
        ///</summary>
        public static Engine DownLeftTeeVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownLeftTeeVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x↽y↽….
        ///https://reference.wolfram.com/language/ref/DownLeftVector.html
        ///</summary>
        public static Engine DownLeftVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownLeftVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⥖y⥖….
        ///https://reference.wolfram.com/language/ref/DownLeftVectorBar.html
        ///</summary>
        public static Engine DownLeftVectorBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownLeftVectorBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⥟y⥟….
        ///https://reference.wolfram.com/language/ref/DownRightTeeVector.html
        ///</summary>
        public static Engine DownRightTeeVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownRightTeeVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⇁y⇁….
        ///https://reference.wolfram.com/language/ref/DownRightVector.html
        ///</summary>
        public static Engine DownRightVector(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownRightVector[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as x⥗y⥗….
        ///https://reference.wolfram.com/language/ref/DownRightVectorBar.html
        ///</summary>
        public static Engine DownRightVectorBar(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownRightVectorBar[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a downsampled version of the array by sampling every n element.
        ///https://reference.wolfram.com/language/ref/Downsample.html
        ///</summary>
        public static Engine Downsample(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Downsample[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///starts sampling from the element at position offset.
        ///https://reference.wolfram.com/language/ref/Downsample.html
        ///</summary>
        public static Engine Downsample(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Downsample[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/DownTee.html
        ///</summary>
        public static Engine DownTee(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DownTee[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as x↧y↧….
        ///https://reference.wolfram.com/language/ref/DownTeeArrow.html
        ///</summary>
        public static Engine DownTeeArrow(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DownTeeArrow[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all downvalues (values for f[…]) defined for the symbol f.
        ///https://reference.wolfram.com/language/ref/DownValues.html
        ///</summary>
        public static Engine DownValues(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DownValues[" + arg0 + "]", name);
        }

        ///<summary>
        ///finds the Drazin generalized inverse  of a square matrix m.
        ///https://reference.wolfram.com/language/ref/DrazinInverse.html
        ///</summary>
        public static Engine DrazinInverse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DrazinInverse[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives list with its first n elements dropped.
        ///https://reference.wolfram.com/language/ref/Drop.html
        ///</summary>
        public static Engine Drop(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Drop[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives list with its n element dropped.
        ///https://reference.wolfram.com/language/ref/Drop.html
        ///</summary>
        public static Engine Drop(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Drop[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a nested list in which elements specified by seqi have been dropped at level i in list.
        ///https://reference.wolfram.com/language/ref/Drop.html
        ///</summary>
        public static Engine Drop(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Drop[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a net layer that sets its input elements to zero with probability 0.5 during training.
        ///https://reference.wolfram.com/language/ref/DropoutLayer.html
        ///</summary>
        public static Engine DropoutLayer(this Engine en, string? name = null)
        {
            return en.Execute("DropoutLayer[]", name);
        }

        ///<summary>
        ///sets its input elements to zero with probability p during training.
        ///https://reference.wolfram.com/language/ref/DropoutLayer.html
        ///</summary>
        public static Engine DropoutLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DropoutLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a two‐dimensional directive specifying that graphics objects are to be drawn with an additional blurred offset image.
        ///https://reference.wolfram.com/language/ref/DropShadowing.html
        ///</summary>
        public static Engine DropShadowing(this Engine en, string? name = null)
        {
            return en.Execute("DropShadowing[]", name);
        }

        ///<summary>
        ///uses an absolute offset {dx,dy}.
        ///https://reference.wolfram.com/language/ref/DropShadowing.html
        ///</summary>
        public static Engine DropShadowing(this Engine en, List<object> arg0, string? name = null)
        {
            return en.Execute("DropShadowing[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///applies a blur effect with radius r.
        ///https://reference.wolfram.com/language/ref/DropShadowing.html
        ///</summary>
        public static Engine DropShadowing(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DropShadowing[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the specified color col for the blurred offset image.
        ///https://reference.wolfram.com/language/ref/DropShadowing.html
        ///</summary>
        public static Engine DropShadowing(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DropShadowing[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///solves a differential equation for the function u, with independent variable x.
        ///https://reference.wolfram.com/language/ref/DSolve.html
        ///</summary>
        public static Engine DSolve(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DSolve[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///solves a differential equation for x between xmin and xmax.
        ///https://reference.wolfram.com/language/ref/DSolve.html
        ///</summary>
        public static Engine DSolve(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DSolve[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///solves a list of differential equations.
        ///https://reference.wolfram.com/language/ref/DSolve.html
        ///</summary>
        public static Engine DSolve(this Engine en, List<object> arg0, List<object> arg1, object arg2, string? name = null)
        {
            return en.Execute("DSolve[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///changes the solution function in dsolve to  using the transformation trans.
        ///https://reference.wolfram.com/language/ref/DSolveChangeVariables.html
        ///</summary>
        public static Engine DSolveChangeVariables(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DSolveChangeVariables[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///changes the solution functions in the system to .
        ///https://reference.wolfram.com/language/ref/DSolveChangeVariables.html
        ///</summary>
        public static Engine DSolveChangeVariables(this Engine en, object arg0, List<object> arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("DSolveChangeVariables[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///changes the solution function in the partial differential equation to .
        ///https://reference.wolfram.com/language/ref/DSolveChangeVariables.html
        ///</summary>
        public static Engine DSolveChangeVariables(this Engine en, object arg0, object arg1, List<object> arg2, object arg3, string? name = null)
        {
            return en.Execute("DSolveChangeVariables[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the value of expr determined by a symbolic solution to the ordinary differential equation eqn with independent variable x.
        ///https://reference.wolfram.com/language/ref/DSolveValue.html
        ///</summary>
        public static Engine DSolveValue(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DSolveValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses a symbolic solution for x between xmin and xmax.
        ///https://reference.wolfram.com/language/ref/DSolveValue.html
        ///</summary>
        public static Engine DSolveValue(this Engine en, object arg0, object arg1, List<object> arg2, string? name = null)
        {
            return en.Execute("DSolveValue[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///uses a symbolic solution for a list of differential equations.
        ///https://reference.wolfram.com/language/ref/DSolveValue.html
        ///</summary>
        public static Engine DSolveValue(this Engine en, List<object> arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("DSolveValue[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the total derivative df/dx.
        ///https://reference.wolfram.com/language/ref/Dt.html
        ///</summary>
        public static Engine Dt(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Dt[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the total differential df.
        ///https://reference.wolfram.com/language/ref/Dt.html
        ///</summary>
        public static Engine Dt(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Dt[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the multiple derivative dnf/dxn.
        ///https://reference.wolfram.com/language/ref/Dt.html
        ///</summary>
        public static Engine Dt(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Dt[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives d/dx1 d/dx2 … f.
        ///https://reference.wolfram.com/language/ref/Dt.html
        ///</summary>
        public static Engine Dt(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("Dt[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the dual of the planar graph g.
        ///https://reference.wolfram.com/language/ref/DualPlanarGraph.html
        ///</summary>
        public static Engine DualPlanarGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DualPlanarGraph[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the dual polyhedron of the polyhedron poly.
        ///https://reference.wolfram.com/language/ref/DualPolyhedron.html
        ///</summary>
        public static Engine DualPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DualPolyhedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the dual of the state-space model ssm.
        ///https://reference.wolfram.com/language/ref/DualSystemsModel.html
        ///</summary>
        public static Engine DualSystemsModel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DualSystemsModel[" + arg0 + "]", name);
        }

        ///<summary>
        ///writes definitions associated with a symbol to a file in internal Wolfram System format.
        ///https://reference.wolfram.com/language/ref/DumpSave.html
        ///</summary>
        public static Engine DumpSave(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DumpSave[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///writes out definitions for several symbols or contexts.
        ///https://reference.wolfram.com/language/ref/DumpSave.html
        ///</summary>
        public static Engine DumpSave(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("DumpSave[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives True if list has no duplicates, and False otherwise.
        ///https://reference.wolfram.com/language/ref/DuplicateFreeQ.html
        ///</summary>
        public static Engine DuplicateFreeQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DuplicateFreeQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies test to pairs of elements to determine whether they should be considered duplicates.
        ///https://reference.wolfram.com/language/ref/DuplicateFreeQ.html
        ///</summary>
        public static Engine DuplicateFreeQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DuplicateFreeQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the duration of expr.
        ///https://reference.wolfram.com/language/ref/Duration.html
        ///</summary>
        public static Engine Duration(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Duration[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an object that displays as the dynamically updated current value of expr. If the displayed form of Dynamic[expr] is interactively changed or edited, an assignment expr=val is done to give expr the new value val that corresponds to the displayed form.
        ///https://reference.wolfram.com/language/ref/Dynamic.html
        ///</summary>
        public static Engine Dynamic(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Dynamic[" + arg0 + "]", name);
        }

        ///<summary>
        ///does not allow interactive changing or editing.
        ///https://reference.wolfram.com/language/ref/Dynamic.html
        ///</summary>
        public static Engine Dynamic(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Dynamic[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///also evaluates fend[val,expr] when interactive changing or editing is complete.
        ///https://reference.wolfram.com/language/ref/Dynamic.html
        ///</summary>
        public static Engine Dynamic(this Engine en, object arg0, List<object> arg1, string? name = null)
        {
            return en.Execute("Dynamic[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a dynamic, interactive, two-dimensional geographical image.
        ///https://reference.wolfram.com/language/ref/DynamicGeoGraphics.html
        ///</summary>
        public static Engine DynamicGeoGraphics(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DynamicGeoGraphics[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays a dynamic version of image, supporting panning, zooming, etc.
        ///https://reference.wolfram.com/language/ref/DynamicImage.html
        ///</summary>
        public static Engine DynamicImage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DynamicImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents an object which maintains the same local instance of the symbols x, y, … in the course of all evaluations of Dynamic objects in expr. Symbols specified in a DynamicModule will by default have their values maintained even across Wolfram System sessions.
        ///https://reference.wolfram.com/language/ref/DynamicModule.html
        ///</summary>
        public static Engine DynamicModule(this Engine en, List<object> arg0, object arg1, string? name = null)
        {
            return en.Execute("DynamicModule[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an object which displays as e, but is interpreted as the dynamically updated current value of Setting[e] if supplied as Wolfram Language input.
        ///https://reference.wolfram.com/language/ref/DynamicSetting.html
        ///</summary>
        public static Engine DynamicSetting(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("DynamicSetting[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as e, but is interpreted as f[e] if supplied as input.
        ///https://reference.wolfram.com/language/ref/DynamicSetting.html
        ///</summary>
        public static Engine DynamicSetting(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DynamicSetting[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an object that displays as e, but dynamically updates the expression expr whenever that object is visible on screen.
        ///https://reference.wolfram.com/language/ref/DynamicWrapper.html
        ///</summary>
        public static Engine DynamicWrapper(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("DynamicWrapper[" + arg0 + ", " + arg1 + "]", name);
        }


    }
}
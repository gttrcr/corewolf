namespace NetWolf
{
    public static class ExtendedSymbolsF
    {
        ///<summary>
        ///attempts to find faces in image and align them.
        ///https://reference.wolfram.com/language/ref/FaceAlign.html
        ///</summary>
        public static Engine FaceAlign(this Engine en, string? name = null)
        {
            return en.Execute("FaceAlign[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that faces of polygons and other filled graphics objects are to be drawn using the graphics directive or list of directives g.
        ///https://reference.wolfram.com/language/ref/FaceForm.html
        ///</summary>
        public static Engine FaceForm(this Engine en, string? name = null)
        {
            return en.Execute("FaceForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a ClassifierFunction[…] based on the face examples and names given.
        ///https://reference.wolfram.com/language/ref/FaceRecognize.html
        ///</summary>
        public static Engine FaceRecognize(this Engine en, string? name = null)
        {
            return en.Execute("FaceRecognize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a minimal summary of facial features for all detected faces in image.
        ///https://reference.wolfram.com/language/ref/FacialFeatures.html
        ///</summary>
        public static Engine FacialFeatures(this Engine en, string? name = null)
        {
            return en.Execute("FacialFeatures[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///factors a polynomial over the integers.
        ///https://reference.wolfram.com/language/ref/Factor.html
        ///</summary>
        public static Engine Factor(this Engine en, string? name = null)
        {
            return en.Execute("Factor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the r factorial moment.
        ///https://reference.wolfram.com/language/ref/FactorialMoment.html
        ///</summary>
        public static Engine FactorialMoment(this Engine en, string? name = null)
        {
            return en.Execute("FactorialMoment[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the prime factors of the integer n, together with their exponents.
        ///https://reference.wolfram.com/language/ref/FactorInteger.html
        ///</summary>
        public static Engine FactorInteger(this Engine en, string? name = null)
        {
            return en.Execute("FactorInteger[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the factors of a polynomial, together with their exponents.
        ///https://reference.wolfram.com/language/ref/FactorList.html
        ///</summary>
        public static Engine FactorList(this Engine en, string? name = null)
        {
            return en.Execute("FactorList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///pulls out any multiple factors in a polynomial.
        ///https://reference.wolfram.com/language/ref/FactorSquareFree.html
        ///</summary>
        public static Engine FactorSquareFree(this Engine en, string? name = null)
        {
            return en.Execute("FactorSquareFree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of square‐free factors of a polynomial, together with their exponents.
        ///https://reference.wolfram.com/language/ref/FactorSquareFreeList.html
        ///</summary>
        public static Engine FactorSquareFreeList(this Engine en, string? name = null)
        {
            return en.Execute("FactorSquareFreeList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///pulls out any overall numerical factor in poly.
        ///https://reference.wolfram.com/language/ref/FactorTerms.html
        ///</summary>
        public static Engine FactorTerms(this Engine en, string? name = null)
        {
            return en.Execute("FactorTerms[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list in which the first element is the overall numerical factor in poly, and the second element is the polynomial with the overall factor removed.
        ///https://reference.wolfram.com/language/ref/FactorTermsList.html
        ///</summary>
        public static Engine FactorTermsList(this Engine en, string? name = null)
        {
            return en.Execute("FactorTermsList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr has head Failure or is equal to $Failed or $Aborted.
        ///https://reference.wolfram.com/language/ref/FailureQ.html
        ///</summary>
        public static Engine FailureQ(this Engine en, string? name = null)
        {
            return en.Execute("FailureQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates the Farey sequence of order n.
        ///https://reference.wolfram.com/language/ref/FareySequence.html
        ///</summary>
        public static Engine FareySequence(this Engine en, string? name = null)
        {
            return en.Execute("FareySequence[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of FeatureDistance that can be applied to a pair of examples.
        ///https://reference.wolfram.com/language/ref/FeatureDistance.html
        ///</summary>
        public static Engine FeatureDistance(this Engine en, string? name = null)
        {
            return en.Execute("FeatureDistance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///extracts features for each of the examplei using a feature extractor trained on all the examplei.
        ///https://reference.wolfram.com/language/ref/FeatureExtract.html
        ///</summary>
        public static Engine FeatureExtract(this Engine en, string? name = null)
        {
            return en.Execute("FeatureExtract[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a FeatureExtractorFunction[…] trained from the examples given.
        ///https://reference.wolfram.com/language/ref/FeatureExtraction.html
        ///</summary>
        public static Engine FeatureExtraction(this Engine en, string? name = null)
        {
            return en.Execute("FeatureExtraction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a feature extractor function generated by FeatureExtraction.
        ///https://reference.wolfram.com/language/ref/FeatureExtractorFunction.html
        ///</summary>
        public static Engine FeatureExtractorFunction(this Engine en, string? name = null)
        {
            return en.Execute("FeatureExtractorFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates the feature impacts using synthetic data.
        ///https://reference.wolfram.com/language/ref/FeatureImpactPlot.html
        ///</summary>
        public static Engine FeatureImpactPlot(this Engine en, string? name = null)
        {
            return en.Execute("FeatureImpactPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a NearestFunction[…] that can be applied repeatedly to different x.
        ///https://reference.wolfram.com/language/ref/FeatureNearest.html
        ///</summary>
        public static Engine FeatureNearest(this Engine en, string? name = null)
        {
            return en.Execute("FeatureNearest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots features extracted from the examplei as a scatter plot.
        ///https://reference.wolfram.com/language/ref/FeatureSpacePlot.html
        ///</summary>
        public static Engine FeatureSpacePlot(this Engine en, string? name = null)
        {
            return en.Execute("FeatureSpacePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots features extracted from the examplei as a scatter 3D plot.
        ///https://reference.wolfram.com/language/ref/FeatureSpacePlot3D.html
        ///</summary>
        public static Engine FeatureSpacePlot3D(this Engine en, string? name = null)
        {
            return en.Execute("FeatureSpacePlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates the feature value dependency using synthetic data.
        ///https://reference.wolfram.com/language/ref/FeatureValueDependencyPlot.html
        ///</summary>
        public static Engine FeatureValueDependencyPlot(this Engine en, string? name = null)
        {
            return en.Execute("FeatureValueDependencyPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates the feature value impact using synthetic data.
        ///https://reference.wolfram.com/language/ref/FeatureValueImpactPlot.html
        ///</summary>
        public static Engine FeatureValueImpactPlot(this Engine en, string? name = null)
        {
            return en.Execute("FeatureValueImpactPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///input-output linearizes the AffineStateSpaceModel asys by state transformation and feedback.
        ///https://reference.wolfram.com/language/ref/FeedbackLinearize.html
        ///</summary>
        public static Engine FeedbackLinearize(this Engine en, string? name = null)
        {
            return en.Execute("FeedbackLinearize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the values for all properties of fetal development for the specified age of the fetus.
        ///https://reference.wolfram.com/language/ref/FetalGrowthData.html
        ///</summary>
        public static Engine FetalGrowthData(this Engine en, string? name = null)
        {
            return en.Execute("FetalGrowthData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Fibonacci number .
        ///https://reference.wolfram.com/language/ref/Fibonacci.html
        ///</summary>
        public static Engine Fibonacci(this Engine en, string? name = null)
        {
            return en.Execute("Fibonacci[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the fibonorial .
        ///https://reference.wolfram.com/language/ref/Fibonorial.html
        ///</summary>
        public static Engine Fibonorial(this Engine en, string? name = null)
        {
            return en.Execute("Fibonorial[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a symbolic representation of a location in the local file system.
        ///https://reference.wolfram.com/language/ref/File.html
        ///</summary>
        public static Engine File(this Engine en, string? name = null)
        {
            return en.Execute("File[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the base name for a file without its extension.
        ///https://reference.wolfram.com/language/ref/FileBaseName.html
        ///</summary>
        public static Engine FileBaseName(this Engine en, string? name = null)
        {
            return en.Execute("FileBaseName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of bytes in a file.
        ///https://reference.wolfram.com/language/ref/FileByteCount.html
        ///</summary>
        public static Engine FileByteCount(this Engine en, string? name = null)
        {
            return en.Execute("FileByteCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts the contents of source to the format defined by the extension ext and writes the result to the file dest.ext.
        ///https://reference.wolfram.com/language/ref/FileConvert.html
        ///</summary>
        public static Engine FileConvert(this Engine en, string? name = null)
        {
            return en.Execute("FileConvert[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the date and time at which a file was last modified.
        ///https://reference.wolfram.com/language/ref/FileDate.html
        ///</summary>
        public static Engine FileDate(this Engine en, string? name = null)
        {
            return en.Execute("FileDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the file with the specified name exists, and gives False otherwise.
        ///https://reference.wolfram.com/language/ref/FileExistsQ.html
        ///</summary>
        public static Engine FileExistsQ(this Engine en, string? name = null)
        {
            return en.Execute("FileExistsQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the file extension for a file name.
        ///https://reference.wolfram.com/language/ref/FileExtension.html
        ///</summary>
        public static Engine FileExtension(this Engine en, string? name = null)
        {
            return en.Execute("FileExtension[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to determine what Import format could be used to import the file corresponding to source.
        ///https://reference.wolfram.com/language/ref/FileFormat.html
        ///</summary>
        public static Engine FileFormat(this Engine en, string? name = null)
        {
            return en.Execute("FileFormat[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an association of properties for the specified format "fmt".
        ///https://reference.wolfram.com/language/ref/FileFormatProperties.html
        ///</summary>
        public static Engine FileFormatProperties(this Engine en, string? name = null)
        {
            return en.Execute("FileFormatProperties[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an integer hash code for the contents of the specified file.
        ///https://reference.wolfram.com/language/ref/FileHash.html
        ///</summary>
        public static Engine FileHash(this Engine en, string? name = null)
        {
            return en.Execute("FileHash[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of path elements in the file name "file".
        ///https://reference.wolfram.com/language/ref/FileNameDepth.html
        ///</summary>
        public static Engine FileNameDepth(this Engine en, string? name = null)
        {
            return en.Execute("FileNameDepth[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///drops the last path element in the file name "name".
        ///https://reference.wolfram.com/language/ref/FileNameDrop.html
        ///</summary>
        public static Engine FileNameDrop(this Engine en, string? name = null)
        {
            return en.Execute("FileNameDrop[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///joins the namei together into a file name suitable for your current operating system.
        ///https://reference.wolfram.com/language/ref/FileNameJoin.html
        ///</summary>
        public static Engine FileNameJoin(this Engine en, string? name = null)
        {
            return en.Execute("FileNameJoin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///lists all files in the current working directory whose names match the string pattern form.
        ///https://reference.wolfram.com/language/ref/FileNames.html
        ///</summary>
        public static Engine FileNames(this Engine en, string? name = null)
        {
            return en.Execute("FileNames[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a file name setter which displays as a Browse button and when clicked brings up a system file opening dialog, starting from the location corresponding to name.
        ///https://reference.wolfram.com/language/ref/FileNameSetter.html
        ///</summary>
        public static Engine FileNameSetter(this Engine en, string? name = null)
        {
            return en.Execute("FileNameSetter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///splits a file name into a list of parts.
        ///https://reference.wolfram.com/language/ref/FileNameSplit.html
        ///</summary>
        public static Engine FileNameSplit(this Engine en, string? name = null)
        {
            return en.Execute("FileNameSplit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the last path element in the file name "name".
        ///https://reference.wolfram.com/language/ref/FileNameTake.html
        ///</summary>
        public static Engine FileNameTake(this Engine en, string? name = null)
        {
            return en.Execute("FileNameTake[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a list of file formats that matches the file name "file".
        ///https://reference.wolfram.com/language/ref/FileNameToFormatList.html
        ///</summary>
        public static Engine FileNameToFormatList(this Engine en, string? name = null)
        {
            return en.Execute("FileNameToFormatList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints out the raw textual contents of file.
        ///https://reference.wolfram.com/language/ref/FilePrint.html
        ///</summary>
        public static Engine FilePrint(this Engine en, string? name = null)
        {
            return en.Execute("FilePrint[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the size of a file as a quantity.
        ///https://reference.wolfram.com/language/ref/FileSize.html
        ///</summary>
        public static Engine FileSize(this Engine en, string? name = null)
        {
            return en.Execute("FileSize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject expression that represents a file template to be applied using functions like TemplateApply.
        ///https://reference.wolfram.com/language/ref/FileTemplate.html
        ///</summary>
        public static Engine FileTemplate(this Engine en, string? name = null)
        {
            return en.Execute("FileTemplate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///applies a template, evaluating all template elements it contains, and then writes the result to a temporary file, whose name is returned.
        ///https://reference.wolfram.com/language/ref/FileTemplateApply.html
        ///</summary>
        public static Engine FileTemplateApply(this Engine en, string? name = null)
        {
            return en.Execute("FileTemplateApply[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the type of a file, typically File, Directory, or None.
        ///https://reference.wolfram.com/language/ref/FileType.html
        ///</summary>
        public static Engine FileType(this Engine en, string? name = null)
        {
            return en.Execute("FileType[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a filled curve consisting of segment1 followed by segment2 etc.
        ///https://reference.wolfram.com/language/ref/FilledCurve.html
        ///</summary>
        public static Engine FilledCurve(this Engine en, string? name = null)
        {
            return en.Execute("FilledCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a version of image with all extended minima filled.
        ///https://reference.wolfram.com/language/ref/FillingTransform.html
        ///</summary>
        public static Engine FillingTransform(this Engine en, string? name = null)
        {
            return en.Execute("FillingTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the last known price or value for the financial entity specified by "name".
        ///https://reference.wolfram.com/language/ref/FinancialData.html
        ///</summary>
        public static Engine FinancialData(this Engine en, string? name = null)
        {
            return en.Execute("FinancialData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the examplei that are considered anomalous with respect to the other examples.
        ///https://reference.wolfram.com/language/ref/FindAnomalies.html
        ///</summary>
        public static Engine FindAnomalies(this Engine en, string? name = null)
        {
            return en.Execute("FindAnomalies[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of your unnamed channels.
        ///https://reference.wolfram.com/language/ref/FindChannels.html
        ///</summary>
        public static Engine FindChannels(this Engine en, string? name = null)
        {
            return en.Execute("FindChannels[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a largest clique in the graph g.
        ///https://reference.wolfram.com/language/ref/FindClique.html
        ///</summary>
        public static Engine FindClique(this Engine en, string? name = null)
        {
            return en.Execute("FindClique[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///partitions the ei into clusters of similar elements.
        ///https://reference.wolfram.com/language/ref/FindClusters.html
        ///</summary>
        public static Engine FindClusters(this Engine en, string? name = null)
        {
            return en.Execute("FindClusters[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of cookies associated with the specified domain.
        ///https://reference.wolfram.com/language/ref/FindCookies.html
        ///</summary>
        public static Engine FindCookies(this Engine en, string? name = null)
        {
            return en.Execute("FindCookies[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a cycle in the graph g.
        ///https://reference.wolfram.com/language/ref/FindCycle.html
        ///</summary>
        public static Engine FindCycle(this Engine en, string? name = null)
        {
            return en.Execute("FindCycle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of devices in classes whose names match the string pattern form.
        ///https://reference.wolfram.com/language/ref/FindDevices.html
        ///</summary>
        public static Engine FindDevices(this Engine en, string? name = null)
        {
            return en.Execute("FindDevices[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a simple functional form to fit the distribution of data.
        ///https://reference.wolfram.com/language/ref/FindDistribution.html
        ///</summary>
        public static Engine FindDistribution(this Engine en, string? name = null)
        {
            return en.Execute("FindDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a coloring with minimal size for the edges in the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeColoring.html
        ///</summary>
        public static Engine FindEdgeColoring(this Engine en, string? name = null)
        {
            return en.Execute("FindEdgeColoring[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds an edge cover of the graph g with a minimum number of edges.
        ///https://reference.wolfram.com/language/ref/FindEdgeCover.html
        ///</summary>
        public static Engine FindEdgeCover(this Engine en, string? name = null)
        {
            return en.Execute("FindEdgeCover[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a smallest edge cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindEdgeCut.html
        ///</summary>
        public static Engine FindEdgeCut(this Engine en, string? name = null)
        {
            return en.Execute("FindEdgeCut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds an Eulerian cycle in the graph g.
        ///https://reference.wolfram.com/language/ref/FindEulerianCycle.html
        ///</summary>
        public static Engine FindEulerianCycle(this Engine en, string? name = null)
        {
            return en.Execute("FindEulerianCycle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds only external evaluators for language or system sys.
        ///https://reference.wolfram.com/language/ref/FindExternalEvaluators.html
        ///</summary>
        public static Engine FindExternalEvaluators(this Engine en, string? name = null)
        {
            return en.Execute("FindExternalEvaluators[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to find human faces in image and returns a list of bounding boxes.
        ///https://reference.wolfram.com/language/ref/FindFaces.html
        ///</summary>
        public static Engine FindFaces(this Engine en, string? name = null)
        {
            return en.Execute("FindFaces[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the file with the specified name that would be loaded by Get[name] and related functions.
        ///https://reference.wolfram.com/language/ref/FindFile.html
        ///</summary>
        public static Engine FindFile(this Engine en, string? name = null)
        {
            return en.Execute("FindFile[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a pure function that approximates data.
        ///https://reference.wolfram.com/language/ref/FindFormula.html
        ///</summary>
        public static Engine FindFormula(this Engine en, string? name = null)
        {
            return en.Execute("FindFormula[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds fundamental cycles of the graph g.
        ///https://reference.wolfram.com/language/ref/FindFundamentalCycles.html
        ///</summary>
        public static Engine FindFundamentalCycles(this Engine en, string? name = null)
        {
            return en.Execute("FindFundamentalCycles[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives an estimate of the geo location associated with the IP address given.
        ///https://reference.wolfram.com/language/ref/FindGeoLocation.html
        ///</summary>
        public static Engine FindGeoLocation(this Engine en, string? name = null)
        {
            return en.Execute("FindGeoLocation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds conjectures that appear to hold for the GeometricScene object scene and adds these conjectures to the scene object.
        ///https://reference.wolfram.com/language/ref/FindGeometricConjectures.html
        ///</summary>
        public static Engine FindGeometricConjectures(this Engine en, string? name = null)
        {
            return en.Execute("FindGeometricConjectures[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds geometric transformations that align each of the ptsi with pts1.
        ///https://reference.wolfram.com/language/ref/FindGeometricTransform.html
        ///</summary>
        public static Engine FindGeometricTransform(this Engine en, string? name = null)
        {
            return en.Execute("FindGeometricTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds communities in the graph g.
        ///https://reference.wolfram.com/language/ref/FindGraphCommunities.html
        ///</summary>
        public static Engine FindGraphCommunities(this Engine en, string? name = null)
        {
            return en.Execute("FindGraphCommunities[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a partition of vertices of the graph g.
        ///https://reference.wolfram.com/language/ref/FindGraphPartition.html
        ///</summary>
        public static Engine FindGraphPartition(this Engine en, string? name = null)
        {
            return en.Execute("FindGraphPartition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a Hamiltonian cycle in the graph g.
        ///https://reference.wolfram.com/language/ref/FindHamiltonianCycle.html
        ///</summary>
        public static Engine FindHamiltonianCycle(this Engine en, string? name = null)
        {
            return en.Execute("FindHamiltonianCycle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a Hamiltonian path in the graph g with the smallest total length.
        ///https://reference.wolfram.com/language/ref/FindHamiltonianPath.html
        ///</summary>
        public static Engine FindHamiltonianPath(this Engine en, string? name = null)
        {
            return en.Execute("FindHamiltonianPath[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///detects text in image and returns a single bounding box.
        ///https://reference.wolfram.com/language/ref/FindImageText.html
        ///</summary>
        public static Engine FindImageText(this Engine en, string? name = null)
        {
            return en.Execute("FindImageText[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds an independent edge set of the graph g with a maximum number of edges.
        ///https://reference.wolfram.com/language/ref/FindIndependentEdgeSet.html
        ///</summary>
        public static Engine FindIndependentEdgeSet(this Engine en, string? name = null)
        {
            return en.Execute("FindIndependentEdgeSet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds an independent vertex set of the graph g with a maximum number of vertices.
        ///https://reference.wolfram.com/language/ref/FindIndependentVertexSet.html
        ///</summary>
        public static Engine FindIndependentVertexSet(this Engine en, string? name = null)
        {
            return en.Execute("FindIndependentVertexSet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a list of integers  such that .
        ///https://reference.wolfram.com/language/ref/FindIntegerNullVector.html
        ///</summary>
        public static Engine FindIntegerNullVector(this Engine en, string? name = null)
        {
            return en.Execute("FindIntegerNullVector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a list of molecules with the same chemical formula as chem.
        ///https://reference.wolfram.com/language/ref/FindIsomers.html
        ///</summary>
        public static Engine FindIsomers(this Engine en, string? name = null)
        {
            return en.Execute("FindIsomers[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a dynamic library that can be loaded by LibraryFunctionLoad.
        ///https://reference.wolfram.com/language/ref/FindLibrary.html
        ///</summary>
        public static Engine FindLibrary(this Engine en, string? name = null)
        {
            return en.Execute("FindLibrary[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds if possible the minimal linear recurrence that generates list.
        ///https://reference.wolfram.com/language/ref/FindLinearRecurrence.html
        ///</summary>
        public static Engine FindLinearRecurrence(this Engine en, string? name = null)
        {
            return en.Execute("FindLinearRecurrence[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the maximum cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindMaximumCut.html
        ///</summary>
        public static Engine FindMaximumCut(this Engine en, string? name = null)
        {
            return en.Execute("FindMaximumCut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds defects in the mesh region mreg.
        ///https://reference.wolfram.com/language/ref/FindMeshDefects.html
        ///</summary>
        public static Engine FindMeshDefects(this Engine en, string? name = null)
        {
            return en.Execute("FindMeshDefects[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the minimum cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindMinimumCut.html
        ///</summary>
        public static Engine FindMinimumCut(this Engine en, string? name = null)
        {
            return en.Execute("FindMinimumCut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives positions and values of the detected peaks in list.
        ///https://reference.wolfram.com/language/ref/FindPeaks.html
        ///</summary>
        public static Engine FindPeaks(this Engine en, string? name = null)
        {
            return en.Execute("FindPeaks[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a permutation that produces expr by permuting Sort[expr].
        ///https://reference.wolfram.com/language/ref/FindPermutation.html
        ///</summary>
        public static Engine FindPermutation(this Engine en, string? name = null)
        {
            return en.Execute("FindPermutation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a coloring with minimal size for the faces of the planar graph g.
        ///https://reference.wolfram.com/language/ref/FindPlanarColoring.html
        ///</summary>
        public static Engine FindPlanarColoring(this Engine en, string? name = null)
        {
            return en.Execute("FindPlanarColoring[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a Chinese postman tour in the graph g of minimal length.
        ///https://reference.wolfram.com/language/ref/FindPostmanTour.html
        ///</summary>
        public static Engine FindPostmanTour(this Engine en, string? name = null)
        {
            return en.Execute("FindPostmanTour[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the minimal sublist or subarray that repeats to give list.
        ///https://reference.wolfram.com/language/ref/FindRepeat.html
        ///</summary>
        public static Engine FindRepeat(this Engine en, string? name = null)
        {
            return en.Execute("FindRepeat[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to find a simple function that yields the sequence an when given successive integer arguments.
        ///https://reference.wolfram.com/language/ref/FindSequenceFunction.html
        ///</summary>
        public static Engine FindSequenceFunction(this Engine en, string? name = null)
        {
            return en.Execute("FindSequenceFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to find an ordering of the vi that minimizes the total distance on a tour that visits all the vi once.
        ///https://reference.wolfram.com/language/ref/FindShortestTour.html
        ///</summary>
        public static Engine FindShortestTour(this Engine en, string? name = null)
        {
            return en.Execute("FindShortestTour[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a spanning tree that minimizes the total distance between the vi.
        ///https://reference.wolfram.com/language/ref/FindSpanningTree.html
        ///</summary>
        public static Engine FindSpanningTree(this Engine en, string? name = null)
        {
            return en.Execute("FindSpanningTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///searches for an equilibrium to the model model.
        ///https://reference.wolfram.com/language/ref/FindSystemModelEquilibrium.html
        ///</summary>
        public static Engine FindSystemModelEquilibrium(this Engine en, string? name = null)
        {
            return en.Execute("FindSystemModelEquilibrium[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a global threshold value that partitions the intensity values in image into two intervals.
        ///https://reference.wolfram.com/language/ref/FindThreshold.html
        ///</summary>
        public static Engine FindThreshold(this Engine en, string? name = null)
        {
            return en.Execute("FindThreshold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a coloring with minimal size for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexColoring.html
        ///</summary>
        public static Engine FindVertexColoring(this Engine en, string? name = null)
        {
            return en.Execute("FindVertexColoring[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a vertex cover of the graph g with a minimum number of vertices.
        ///https://reference.wolfram.com/language/ref/FindVertexCover.html
        ///</summary>
        public static Engine FindVertexCover(this Engine en, string? name = null)
        {
            return en.Execute("FindVertexCover[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a smallest vertex cut of the graph g.
        ///https://reference.wolfram.com/language/ref/FindVertexCut.html
        ///</summary>
        public static Engine FindVertexCut(this Engine en, string? name = null)
        {
            return en.Execute("FindVertexCut[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of finite Abelian groups of order n.
        ///https://reference.wolfram.com/language/ref/FiniteAbelianGroupCount.html
        ///</summary>
        public static Engine FiniteAbelianGroupCount(this Engine en, string? name = null)
        {
            return en.Execute("FiniteAbelianGroupCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of finite groups of order n.
        ///https://reference.wolfram.com/language/ref/FiniteGroupCount.html
        ///</summary>
        public static Engine FiniteGroupCount(this Engine en, string? name = null)
        {
            return en.Execute("FiniteGroupCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of finite groups in the specified class.
        ///https://reference.wolfram.com/language/ref/FiniteGroupData.html
        ///</summary>
        public static Engine FiniteGroupData(this Engine en, string? name = null)
        {
            return en.Execute("FiniteGroupData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the first element in expr.
        ///https://reference.wolfram.com/language/ref/First.html
        ///</summary>
        public static Engine First(this Engine en, string? name = null)
        {
            return en.Execute("First[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of FirstCase that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/FirstCase.html
        ///</summary>
        public static Engine FirstCase(this Engine en, string? name = null)
        {
            return en.Execute("FirstCase[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of FirstPosition that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/FirstPosition.html
        ///</summary>
        public static Engine FirstPosition(this Engine en, string? name = null)
        {
            return en.Execute("FirstPosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the variance of data is 1.
        ///https://reference.wolfram.com/language/ref/FisherRatioTest.html
        ///</summary>
        public static Engine FisherRatioTest(this Engine en, string? name = null)
        {
            return en.Execute("FisherRatioTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds a fit vector a that minimizes  for a design matrix m.
        ///https://reference.wolfram.com/language/ref/Fit.html
        ///</summary>
        public static Engine Fit(this Engine en, string? name = null)
        {
            return en.Execute("Fit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the symbolic fitted model obtained from functions like LinearModelFit.
        ///https://reference.wolfram.com/language/ref/FittedModel.html
        ///</summary>
        public static Engine FittedModel(this Engine en, string? name = null)
        {
            return en.Execute("FittedModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///uses the attenuation factor d for the diffuse light.
        ///https://reference.wolfram.com/language/ref/FlatShading.html
        ///</summary>
        public static Engine FlatShading(this Engine en, string? name = null)
        {
            return en.Execute("FlatShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///flattens out nested lists.
        ///https://reference.wolfram.com/language/ref/Flatten.html
        ///</summary>
        public static Engine Flatten(this Engine en, string? name = null)
        {
            return en.Execute("Flatten[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of FlattenAt that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/FlattenAt.html
        ///</summary>
        public static Engine FlattenAt(this Engine en, string? name = null)
        {
            return en.Execute("FlattenAt[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a net layer that flattens its input to level n.
        ///https://reference.wolfram.com/language/ref/FlattenLayer.html
        ///</summary>
        public static Engine FlattenLayer(this Engine en, string? name = null)
        {
            return en.Execute("FlattenLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an exact flat top window function of x.
        ///https://reference.wolfram.com/language/ref/FlatTopWindow.html
        ///</summary>
        public static Engine FlatTopWindow(this Engine en, string? name = null)
        {
            return en.Execute("FlatTopWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an object which flips between displaying expr1 and expr2 each time it is clicked.
        ///https://reference.wolfram.com/language/ref/FlipView.html
        ///</summary>
        public static Engine FlipView(this Engine en, string? name = null)
        {
            return en.Execute("FlipView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the greatest integer less than or equal to x.
        ///https://reference.wolfram.com/language/ref/Floor.html
        ///</summary>
        public static Engine Floor(this Engine en, string? name = null)
        {
            return en.Execute("Floor[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of Fold that can be applied to expressions.
        ///https://reference.wolfram.com/language/ref/Fold.html
        ///</summary>
        public static Engine Fold(this Engine en, string? name = null)
        {
            return en.Execute("Fold[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of FoldList that can be applied to expressions.
        ///https://reference.wolfram.com/language/ref/FoldList.html
        ///</summary>
        public static Engine FoldList(this Engine en, string? name = null)
        {
            return en.Execute("FoldList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as the formatted form of expr. Assigning values to Format[expr] defines print forms for expressions.
        ///https://reference.wolfram.com/language/ref/Format.html
        ///</summary>
        public static Engine Format(this Engine en, string? name = null)
        {
            return en.Execute("Format[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a form with fields having names namei that take data of type typei.
        ///https://reference.wolfram.com/language/ref/FormObject.html
        ///</summary>
        public static Engine FormObject(this Engine en, string? name = null)
        {
            return en.Execute("FormObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the equations for the formula name.
        ///https://reference.wolfram.com/language/ref/FormulaData.html
        ///</summary>
        public static Engine FormulaData(this Engine en, string? name = null)
        {
            return en.Execute("FormulaData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the full names of formulas whose names are consistent with "query".
        ///https://reference.wolfram.com/language/ref/FormulaLookup.html
        ///</summary>
        public static Engine FormulaLookup(this Engine en, string? name = null)
        {
            return en.Execute("FormulaLookup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as a Fortran language version of expr.
        ///https://reference.wolfram.com/language/ref/FortranForm.html
        ///</summary>
        public static Engine FortranForm(this Engine en, string? name = null)
        {
            return en.Execute("FortranForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the discrete Fourier transform of a list of complex numbers.
        ///https://reference.wolfram.com/language/ref/Fourier.html
        ///</summary>
        public static Engine Fourier(this Engine en, string? name = null)
        {
            return en.Execute("Fourier[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the Fourier discrete cosine transform of a list of real numbers.
        ///https://reference.wolfram.com/language/ref/FourierDCT.html
        ///</summary>
        public static Engine FourierDCT(this Engine en, string? name = null)
        {
            return en.Execute("FourierDCT[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an n×n discrete cosine transform matrix of type 2.
        ///https://reference.wolfram.com/language/ref/FourierDCTMatrix.html
        ///</summary>
        public static Engine FourierDCTMatrix(this Engine en, string? name = null)
        {
            return en.Execute("FourierDCTMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the Fourier discrete sine transform of a list of real numbers.
        ///https://reference.wolfram.com/language/ref/FourierDST.html
        ///</summary>
        public static Engine FourierDST(this Engine en, string? name = null)
        {
            return en.Execute("FourierDST[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an n×n discrete sine transform matrix of type 2.
        ///https://reference.wolfram.com/language/ref/FourierDSTMatrix.html
        ///</summary>
        public static Engine FourierDSTMatrix(this Engine en, string? name = null)
        {
            return en.Execute("FourierDSTMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an n×n Fourier matrix.
        ///https://reference.wolfram.com/language/ref/FourierMatrix.html
        ///</summary>
        public static Engine FourierMatrix(this Engine en, string? name = null)
        {
            return en.Execute("FourierMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents fractional Brownian motion process with drift 0, volatility 1, and Hurst index h.
        ///https://reference.wolfram.com/language/ref/FractionalBrownianMotionProcess.html
        ///</summary>
        public static Engine FractionalBrownianMotionProcess(this Engine en, string? name = null)
        {
            return en.Execute("FractionalBrownianMotionProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a fractional Gaussian noise process with drift 0, volatility 1, and Hurst index h.
        ///https://reference.wolfram.com/language/ref/FractionalGaussianNoiseProcess.html
        ///</summary>
        public static Engine FractionalGaussianNoiseProcess(this Engine en, string? name = null)
        {
            return en.Execute("FractionalGaussianNoiseProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the fractional part of x.
        ///https://reference.wolfram.com/language/ref/FractionalPart.html
        ///</summary>
        public static Engine FractionalPart(this Engine en, string? name = null)
        {
            return en.Execute("FractionalPart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents box with a frame drawn around it.
        ///https://reference.wolfram.com/language/ref/FrameBox.html
        ///</summary>
        public static Engine FrameBox(this Engine en, string? name = null)
        {
            return en.Execute("FrameBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays a framed version of expr.
        ///https://reference.wolfram.com/language/ref/Framed.html
        ///</summary>
        public static Engine Framed(this Engine en, string? name = null)
        {
            return en.Execute("Framed[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a video containing frames image1, image2, etc.
        ///https://reference.wolfram.com/language/ref/FrameListVideo.html
        ///</summary>
        public static Engine FrameListVideo(this Engine en, string? name = null)
        {
            return en.Execute("FrameListVideo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of FreeQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/FreeQ.html
        ///</summary>
        public static Engine FreeQ(this Engine en, string? name = null)
        {
            return en.Execute("FreeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a finite impulse response (FIR) filter kernel using a frequency sampling method from amplitude values ai.
        ///https://reference.wolfram.com/language/ref/FrequencySamplingFilterKernel.html
        ///</summary>
        public static Engine FrequencySamplingFilterKernel(this Engine en, string? name = null)
        {
            return en.Execute("FrequencySamplingFilterKernel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Fresnel integral .
        ///https://reference.wolfram.com/language/ref/FresnelC.html
        ///</summary>
        public static Engine FresnelC(this Engine en, string? name = null)
        {
            return en.Execute("FresnelC[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Fresnel auxiliary function .
        ///https://reference.wolfram.com/language/ref/FresnelF.html
        ///</summary>
        public static Engine FresnelF(this Engine en, string? name = null)
        {
            return en.Execute("FresnelF[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Fresnel auxiliary function .
        ///https://reference.wolfram.com/language/ref/FresnelG.html
        ///</summary>
        public static Engine FresnelG(this Engine en, string? name = null)
        {
            return en.Execute("FresnelG[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Fresnel integral .
        ///https://reference.wolfram.com/language/ref/FresnelS.html
        ///</summary>
        public static Engine FresnelS(this Engine en, string? name = null)
        {
            return en.Execute("FresnelS[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Frobenius number of a1,…,an.
        ///https://reference.wolfram.com/language/ref/FrobeniusNumber.html
        ///</summary>
        public static Engine FrobeniusNumber(this Engine en, string? name = null)
        {
            return en.Execute("FrobeniusNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to an absolute time specification as given by AbsoluteTime.
        ///https://reference.wolfram.com/language/ref/FromAbsoluteTime.html
        ///</summary>
        public static Engine FromAbsoluteTime(this Engine en, string? name = null)
        {
            return en.Execute("FromAbsoluteTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a string consisting of the character with integer code n.
        ///https://reference.wolfram.com/language/ref/FromCharacterCode.html
        ///</summary>
        public static Engine FromCharacterCode(this Engine en, string? name = null)
        {
            return en.Execute("FromCharacterCode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reconstructs a number from the list of its continued fraction terms.
        ///https://reference.wolfram.com/language/ref/FromContinuedFraction.html
        ///</summary>
        public static Engine FromContinuedFraction(this Engine en, string? name = null)
        {
            return en.Execute("FromContinuedFraction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to the date represented by "string".
        ///https://reference.wolfram.com/language/ref/FromDateString.html
        ///</summary>
        public static Engine FromDateString(this Engine en, string? name = null)
        {
            return en.Execute("FromDateString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///constructs an integer from the list of its decimal digits.
        ///https://reference.wolfram.com/language/ref/FromDigits.html
        ///</summary>
        public static Engine FromDigits(this Engine en, string? name = null)
        {
            return en.Execute("FromDigits[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts from degrees, minutes, and seconds to decimal degrees.
        ///https://reference.wolfram.com/language/ref/FromDMS.html
        ///</summary>
        public static Engine FromDMS(this Engine en, string? name = null)
        {
            return en.Execute("FromDMS[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a Wolfram Language object corresponding to an entity.
        ///https://reference.wolfram.com/language/ref/FromEntity.html
        ///</summary>
        public static Engine FromEntity(this Engine en, string? name = null)
        {
            return en.Execute("FromEntity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to the Julian date jd.
        ///https://reference.wolfram.com/language/ref/FromJulianDate.html
        ///</summary>
        public static Engine FromJulianDate(this Engine en, string? name = null)
        {
            return en.Execute("FromJulianDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the lowercase letter at position n in the English alphabet.
        ///https://reference.wolfram.com/language/ref/FromLetterNumber.html
        ///</summary>
        public static Engine FromLetterNumber(this Engine en, string? name = null)
        {
            return en.Execute("FromLetterNumber[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the {x,y} Cartesian coordinates corresponding to the polar coordinates {r,θ}.
        ///https://reference.wolfram.com/language/ref/FromPolarCoordinates.html
        ///</summary>
        public static Engine FromPolarCoordinates(this Engine en, string? name = null)
        {
            return en.Execute("FromPolarCoordinates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the value referred to by the pointer p for use in compiled code.
        ///https://reference.wolfram.com/language/ref/FromRawPointer.html
        ///</summary>
        public static Engine FromRawPointer(this Engine en, string? name = null)
        {
            return en.Execute("FromRawPointer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the integer corresponding to the Roman numeral "string".
        ///https://reference.wolfram.com/language/ref/FromRomanNumeral.html
        ///</summary>
        public static Engine FromRomanNumeral(this Engine en, string? name = null)
        {
            return en.Execute("FromRomanNumeral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the {x,y,z} Cartesian coordinates corresponding to the spherical coordinates {r,θ,ϕ}.
        ///https://reference.wolfram.com/language/ref/FromSphericalCoordinates.html
        ///</summary>
        public static Engine FromSphericalCoordinates(this Engine en, string? name = null)
        {
            return en.Execute("FromSphericalCoordinates[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a date object corresponding to a UnixTime specification.
        ///https://reference.wolfram.com/language/ref/FromUnixTime.html
        ///</summary>
        public static Engine FromUnixTime(this Engine en, string? name = null)
        {
            return en.Execute("FromUnixTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sends expr to be executed by the Wolfram System front end.
        ///https://reference.wolfram.com/language/ref/FrontEndExecute.html
        ///</summary>
        public static Engine FrontEndExecute(this Engine en, string? name = null)
        {
            return en.Execute("FrontEndExecute[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an object that represents a front end command token, typically corresponding to a front end menu item, to be executed by FrontEndExecute.
        ///https://reference.wolfram.com/language/ref/FrontEndToken.html
        ///</summary>
        public static Engine FrontEndToken(this Engine en, string? name = null)
        {
            return en.Execute("FrontEndToken[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///executes the specified front end command token, typically corresponding to a front end menu item.
        ///https://reference.wolfram.com/language/ref/FrontEndTokenExecute.html
        ///</summary>
        public static Engine FrontEndTokenExecute(this Engine en, string? name = null)
        {
            return en.Execute("FrontEndTokenExecute[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as the definitions given for symbol, and all symbols on which these depend.
        ///https://reference.wolfram.com/language/ref/FullDefinition.html
        ///</summary>
        public static Engine FullDefinition(this Engine en, string? name = null)
        {
            return en.Execute("FullDefinition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as the full form of expr, with no special syntax.
        ///https://reference.wolfram.com/language/ref/FullForm.html
        ///</summary>
        public static Engine FullForm(this Engine en, string? name = null)
        {
            return en.Execute("FullForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///takes a graphics object, and generates a new one in which objects specified by graphics options are given as explicit lists of graphics primitives.
        ///https://reference.wolfram.com/language/ref/FullGraphics.html
        ///</summary>
        public static Engine FullGraphics(this Engine en, string? name = null)
        {
            return en.Execute("FullGraphics[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the full region .
        ///https://reference.wolfram.com/language/ref/FullRegion.html
        ///</summary>
        public static Engine FullRegion(this Engine en, string? name = null)
        {
            return en.Execute("FullRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tries a wide range of transformations on expr involving elementary and special functions and returns the simplest form it finds.
        ///https://reference.wolfram.com/language/ref/FullSimplify.html
        ///</summary>
        public static Engine FullSimplify(this Engine en, string? name = null)
        {
            return en.Execute("FullSimplify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pure (or "anonymous") function. The formal parameters are # (or #1), #2, etc.
        ///https://reference.wolfram.com/language/ref/Function.html
        ///</summary>
        public static Engine Function(this Engine en, string? name = null)
        {
            return en.Execute("Function[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a compiled code function from a pure function.
        ///https://reference.wolfram.com/language/ref/FunctionCompile.html
        ///</summary>
        public static Engine FunctionCompile(this Engine en, string? name = null)
        {
            return en.Execute("FunctionCompile[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a byte array of binary LLVM code obtained by compiling the function specification fspec.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExportByteArray.html
        ///</summary>
        public static Engine FunctionCompileExportByteArray(this Engine en, string? name = null)
        {
            return en.Execute("FunctionCompileExportByteArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a string of textual LLVM code obtained by compiling the function specification fspec.
        ///https://reference.wolfram.com/language/ref/FunctionCompileExportString.html
        ///</summary>
        public static Engine FunctionCompileExportString(this Engine en, string? name = null)
        {
            return en.Execute("FunctionCompileExportString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tries to expand out special and certain other functions in expr, when possible reducing compound arguments to simpler ones.
        ///https://reference.wolfram.com/language/ref/FunctionExpand.html
        ///</summary>
        public static Engine FunctionExpand(this Engine en, string? name = null)
        {
            return en.Execute("FunctionExpand[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a net layer that applies function f to its input.
        ///https://reference.wolfram.com/language/ref/FunctionLayer.html
        ///</summary>
        public static Engine FunctionLayer(this Engine en, string? name = null)
        {
            return en.Execute("FunctionLayer[" + en.ValidNames.Last() + "]", name);
        }


    }
}
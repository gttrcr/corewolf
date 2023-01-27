namespace CoreWolf
{
    public static class ExtendedSymbolsS
    {
        ///<summary>
        ///is an operator form that yields x===y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/SameAs.html
        ///</summary>
        public static Engine SameAs(this Engine en, string? name = null)
        {
            return en.Execute("SameAs[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///counts the number of possible combinations of variable values that yield True when supplied as arguments to the Boolean function bf.
        ///https://reference.wolfram.com/language/ref/SatisfiabilityCount.html
        ///</summary>
        public static Engine SatisfiabilityCount(this Engine en, string? name = null)
        {
            return en.Execute("SatisfiabilityCount[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to find a choice of variables that makes the Boolean function bf yield True.
        ///https://reference.wolfram.com/language/ref/SatisfiabilityInstances.html
        ///</summary>
        public static Engine SatisfiabilityInstances(this Engine en, string? name = null)
        {
            return en.Execute("SatisfiabilityInstances[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if a combination of values of variables exists that makes the Boolean function bf yield True.
        ///https://reference.wolfram.com/language/ref/SatisfiableQ.html
        ///</summary>
        public static Engine SatisfiableQ(this Engine en, string? name = null)
        {
            return en.Execute("SatisfiableQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a sawtooth wave that varies from 0 to 1 with unit period.
        ///https://reference.wolfram.com/language/ref/SawtoothWave.html
        ///</summary>
        public static Engine SawtoothWave(this Engine en, string? name = null)
        {
            return en.Execute("SawtoothWave[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the position of a graphical object in terms of coordinates scaled to run from 0 to 1 across the whole plot range in each direction.
        ///https://reference.wolfram.com/language/ref/Scaled.html
        ///</summary>
        public static Engine Scaled(this Engine en, string? name = null)
        {
            return en.Execute("Scaled[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the matrix corresponding to scaling by a factor si along each coordinate axis.
        ///https://reference.wolfram.com/language/ref/ScalingMatrix.html
        ///</summary>
        public static Engine ScalingMatrix(this Engine en, string? name = null)
        {
            return en.Execute("ScalingMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a TransformationFunction that represents scaling by a factor si along each coordinate axis from the origin.
        ///https://reference.wolfram.com/language/ref/ScalingTransform.html
        ///</summary>
        public static Engine ScalingTransform(this Engine en, string? name = null)
        {
            return en.Execute("ScalingTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of Scan that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Scan.html
        ///</summary>
        public static Engine Scan(this Engine en, string? name = null)
        {
            return en.Execute("Scan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields the Schur decomposition for a numerical matrix m, given as a list {q,t} where q is an orthonormal matrix and t is a block upper‐triangular matrix.
        ///https://reference.wolfram.com/language/ref/SchurDecomposition.html
        ///</summary>
        public static Engine SchurDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("SchurDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints with all real numbers in expr given in scientific notation.
        ///https://reference.wolfram.com/language/ref/ScientificForm.html
        ///</summary>
        public static Engine ScientificForm(this Engine en, string? name = null)
        {
            return en.Execute("ScientificForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerGi.html
        ///</summary>
        public static Engine ScorerGi(this Engine en, string? name = null)
        {
            return en.Execute("ScorerGi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerGiPrime.html
        ///</summary>
        public static Engine ScorerGiPrime(this Engine en, string? name = null)
        {
            return en.Execute("ScorerGiPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerHi.html
        ///</summary>
        public static Engine ScorerHi(this Engine en, string? name = null)
        {
            return en.Execute("ScorerHi[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the derivative of the Scorer function .
        ///https://reference.wolfram.com/language/ref/ScorerHiPrime.html
        ///</summary>
        public static Engine ScorerHiPrime(this Engine en, string? name = null)
        {
            return en.Execute("ScorerHiPrime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a search index object, as created by CreateSearchIndex.
        ///https://reference.wolfram.com/language/ref/SearchIndexObject.html
        ///</summary>
        public static Engine SearchIndexObject(this Engine en, string? name = null)
        {
            return en.Execute("SearchIndexObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a search engine-style query in TextSearch and related functions.
        ///https://reference.wolfram.com/language/ref/SearchQueryString.html
        ///</summary>
        public static Engine SearchQueryString(this Engine en, string? name = null)
        {
            return en.Execute("SearchQueryString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a result from TextSearch[…] and related functions.
        ///https://reference.wolfram.com/language/ref/SearchResultObject.html
        ///</summary>
        public static Engine SearchResultObject(this Engine en, string? name = null)
        {
            return en.Execute("SearchResultObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the secant of z.
        ///https://reference.wolfram.com/language/ref/Sec.html
        ///</summary>
        public static Engine Sec(this Engine en, string? name = null)
        {
            return en.Execute("Sec[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic secant of z.
        ///https://reference.wolfram.com/language/ref/Sech.html
        ///</summary>
        public static Engine Sech(this Engine en, string? name = null)
        {
            return en.Execute("Sech[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a sector chart from multiple datasets datai.
        ///https://reference.wolfram.com/language/ref/SectorChart.html
        ///</summary>
        public static Engine SectorChart(this Engine en, string? name = null)
        {
            return en.Execute("SectorChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a 3D sector chart from multiple datasets datai.
        ///https://reference.wolfram.com/language/ref/SectorChart3D.html
        ///</summary>
        public static Engine SectorChart3D(this Engine en, string? name = null)
        {
            return en.Execute("SectorChart3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a secured authentication key with credentials and details specified by the association assoc.
        ///https://reference.wolfram.com/language/ref/SecuredAuthenticationKey.html
        ///</summary>
        public static Engine SecuredAuthenticationKey(this Engine en, string? name = null)
        {
            return en.Execute("SecuredAuthenticationKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///retrieves a SecuredAuthenticationKey identified by "name" owned by the currently connected user, if it exists.
        ///https://reference.wolfram.com/language/ref/SecuredAuthenticationKeys.html
        ///</summary>
        public static Engine SecuredAuthenticationKeys(this Engine en, string? name = null)
        {
            return en.Execute("SecuredAuthenticationKeys[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the security certificate issued for a public key.
        ///https://reference.wolfram.com/language/ref/SecurityCertificate.html
        ///</summary>
        public static Engine SecurityCertificate(this Engine en, string? name = null)
        {
            return en.Execute("SecurityCertificate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///resets the pseudorandom generator, using s as a seed.
        ///https://reference.wolfram.com/language/ref/SeedRandom.html
        ///</summary>
        public static Engine SeedRandom(this Engine en, string? name = null)
        {
            return en.Execute("SeedRandom[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of Select that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/Select.html
        ///</summary>
        public static Engine Select(this Engine en, string? name = null)
        {
            return en.Execute("Select[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a list of CellObject expressions corresponding to the currently selected cells in notebook.
        ///https://reference.wolfram.com/language/ref/SelectedCells.html
        ///</summary>
        public static Engine SelectedCells(this Engine en, string? name = null)
        {
            return en.Execute("SelectedCells[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of SelectFirst that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/SelectFirst.html
        ///</summary>
        public static Engine SelectFirst(this Engine en, string? name = null)
        {
            return en.Execute("SelectFirst[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///copies the contents of the current selection in a notebook into a new cell.
        ///https://reference.wolfram.com/language/ref/SelectionCreateCell.html
        ///</summary>
        public static Engine SelectionCreateCell(this Engine en, string? name = null)
        {
            return en.Execute("SelectionCreateCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces the current selection in a notebook with the result obtained by evaluating the contents of the selection in the kernel.
        ///https://reference.wolfram.com/language/ref/SelectionEvaluate.html
        ///</summary>
        public static Engine SelectionEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("SelectionEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///takes the current selection in a notebook and creates a new cell containing the result obtained by evaluating the contents of the selection using the kernel.
        ///https://reference.wolfram.com/language/ref/SelectionEvaluateCreateCell.html
        ///</summary>
        public static Engine SelectionEvaluateCreateCell(this Engine en, string? name = null)
        {
            return en.Execute("SelectionEvaluateCreateCell[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to import a file semantically to give a Dataset object.
        ///https://reference.wolfram.com/language/ref/SemanticImport.html
        ///</summary>
        public static Engine SemanticImport(this Engine en, string? name = null)
        {
            return en.Execute("SemanticImport[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to import a string semantically to give a Dataset object.
        ///https://reference.wolfram.com/language/ref/SemanticImportString.html
        ///</summary>
        public static Engine SemanticImportString(this Engine en, string? name = null)
        {
            return en.Execute("SemanticImportString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to give the best semantic interpretation of the specified free-form string as a Wolfram Language expression.
        ///https://reference.wolfram.com/language/ref/SemanticInterpretation.html
        ///</summary>
        public static Engine SemanticInterpretation(this Engine en, string? name = null)
        {
            return en.Execute("SemanticInterpretation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sends mail consisting of body to the address specified by $CloudUserID.
        ///https://reference.wolfram.com/language/ref/SendMail.html
        ///</summary>
        public static Engine SendMail(this Engine en, string? name = null)
        {
            return en.Execute("SendMail[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a SequencePredictorFunction[…] based on the sequences given.
        ///https://reference.wolfram.com/language/ref/SequencePredict.html
        ///</summary>
        public static Engine SequencePredict(this Engine en, string? name = null)
        {
            return en.Execute("SequencePredict[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a function generated by SequencePredict that predicts the next elements from a sequence.
        ///https://reference.wolfram.com/language/ref/SequencePredictorFunction.html
        ///</summary>
        public static Engine SequencePredictorFunction(this Engine en, string? name = null)
        {
            return en.Execute("SequencePredictorFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of SequenceReplace that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/SequenceReplace.html
        ///</summary>
        public static Engine SequenceReplace(this Engine en, string? name = null)
        {
            return en.Execute("SequenceReplace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a connection to an external service.
        ///https://reference.wolfram.com/language/ref/ServiceConnect.html
        ///</summary>
        public static Engine ServiceConnect(this Engine en, string? name = null)
        {
            return en.Execute("ServiceConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///disconnects from an external service specified by a ServiceObject.
        ///https://reference.wolfram.com/language/ref/ServiceDisconnect.html
        ///</summary>
        public static Engine ServiceDisconnect(this Engine en, string? name = null)
        {
            return en.Execute("ServiceDisconnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///executes ServiceRequest req on an external service.
        ///https://reference.wolfram.com/language/ref/ServiceExecute.html
        ///</summary>
        public static Engine ServiceExecute(this Engine en, string? name = null)
        {
            return en.Execute("ServiceExecute[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a service request, built from association assoc.
        ///https://reference.wolfram.com/language/ref/ServiceRequest.html
        ///</summary>
        public static Engine ServiceRequest(this Engine en, string? name = null)
        {
            return en.Execute("ServiceRequest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits a request to be executed by an external service specified by assoc.
        ///https://reference.wolfram.com/language/ref/ServiceSubmit.html
        ///</summary>
        public static Engine ServiceSubmit(this Engine en, string? name = null)
        {
            return en.Execute("ServiceSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///submits an asynchronous task to evaluate expr in the current session.
        ///https://reference.wolfram.com/language/ref/SessionSubmit.html
        ///</summary>
        public static Engine SessionSubmit(this Engine en, string? name = null)
        {
            return en.Execute("SessionSubmit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///adds full opacity to color.
        ///https://reference.wolfram.com/language/ref/SetAlphaChannel.html
        ///</summary>
        public static Engine SetAlphaChannel(this Engine en, string? name = null)
        {
            return en.Execute("SetAlphaChannel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets the current working directory used for cloud objects to dir.
        ///https://reference.wolfram.com/language/ref/SetCloudDirectory.html
        ///</summary>
        public static Engine SetCloudDirectory(this Engine en, string? name = null)
        {
            return en.Execute("SetCloudDirectory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets cookies with attributes specified by the association assoc, to be used by functions such as URLExecute.
        ///https://reference.wolfram.com/language/ref/SetCookies.html
        ///</summary>
        public static Engine SetCookies(this Engine en, string? name = null)
        {
            return en.Execute("SetCookies[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets the current working directory to dir.
        ///https://reference.wolfram.com/language/ref/SetDirectory.html
        ///</summary>
        public static Engine SetDirectory(this Engine en, string? name = null)
        {
            return en.Execute("SetDirectory[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets the value of an operating system environment variable.
        ///https://reference.wolfram.com/language/ref/SetEnvironment.html
        ///</summary>
        public static Engine SetEnvironment(this Engine en, string? name = null)
        {
            return en.Execute("SetEnvironment[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets the modification and access dates for a file to be the current date.
        ///https://reference.wolfram.com/language/ref/SetFileDate.html
        ///</summary>
        public static Engine SetFileDate(this Engine en, string? name = null)
        {
            return en.Execute("SetFileDate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sets permissions as specified by pers for the cloud object corresponding to the current document.
        ///https://reference.wolfram.com/language/ref/SetPermissions.html
        ///</summary>
        public static Engine SetPermissions(this Engine en, string? name = null)
        {
            return en.Execute("SetPermissions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes the notebook corresponding to obj be the currently selected one in the front end.
        ///https://reference.wolfram.com/language/ref/SetSelectedNotebook.html
        ///</summary>
        public static Engine SetSelectedNotebook(this Engine en, string? name = null)
        {
            return en.Execute("SetSelectedNotebook[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///resets the value for the internal system option with the specified name.
        ///https://reference.wolfram.com/language/ref/SetSystemOptions.html
        ///</summary>
        public static Engine SetSystemOptions(this Engine en, string? name = null)
        {
            return en.Execute("SetSystemOptions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces forms and control objects such as sliders or popup menus in expr by their settings.
        ///https://reference.wolfram.com/language/ref/Setting.html
        ///</summary>
        public static Engine Setting(this Engine en, string? name = null)
        {
            return en.Execute("Setting[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as a shallow form of expr.
        ///https://reference.wolfram.com/language/ref/Shallow.html
        ///</summary>
        public static Engine Shallow(this Engine en, string? name = null)
        {
            return en.Execute("Shallow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Shannon wavelet evaluated on the equally spaced interval {-lim,lim}.
        ///https://reference.wolfram.com/language/ref/ShannonWavelet.html
        ///</summary>
        public static Engine ShannonWavelet(this Engine en, string? name = null)
        {
            return en.Execute("ShannonWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether data is normally distributed using the Shapiro–Wilk test.
        ///https://reference.wolfram.com/language/ref/ShapiroWilkTest.html
        ///</summary>
        public static Engine ShapiroWilkTest(this Engine en, string? name = null)
        {
            return en.Execute("ShapiroWilkTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///changes the way expr is stored internally, to try and minimize the amount of memory used.
        ///https://reference.wolfram.com/language/ref/Share.html
        ///</summary>
        public static Engine Share(this Engine en, string? name = null)
        {
            return en.Execute("Share[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a sharpened version of image.
        ///https://reference.wolfram.com/language/ref/Sharpen.html
        ///</summary>
        public static Engine Sharpen(this Engine en, string? name = null)
        {
            return en.Execute("Sharpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a solid shell of a 3D region reg.
        ///https://reference.wolfram.com/language/ref/ShellRegion.html
        ///</summary>
        public static Engine ShellRegion(this Engine en, string? name = null)
        {
            return en.Execute("ShellRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a matrix that corresponds to an exponential kernel of radius r.
        ///https://reference.wolfram.com/language/ref/ShenCastanMatrix.html
        ///</summary>
        public static Engine ShenCastanMatrix(this Engine en, string? name = null)
        {
            return en.Execute("ShenCastanMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a complete maximum-length sequence for a size n linear-feedback shift register.
        ///https://reference.wolfram.com/language/ref/ShiftRegisterSequence.html
        ///</summary>
        public static Engine ShiftRegisterSequence(this Engine en, string? name = null)
        {
            return en.Execute("ShiftRegisterSequence[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as a short form of expr, less than about one line long.
        ///https://reference.wolfram.com/language/ref/Short.html
        ///</summary>
        public static Engine Short(this Engine en, string? name = null)
        {
            return en.Execute("Short[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a pattern object that matches the shortest sequence consistent with the pattern p.
        ///https://reference.wolfram.com/language/ref/Shortest.html
        ///</summary>
        public static Engine Shortest(this Engine en, string? name = null)
        {
            return en.Execute("Shortest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the short-time Fourier transform (STFT) of data as a ShortTimeFourierData object.
        ///https://reference.wolfram.com/language/ref/ShortTimeFourier.html
        ///</summary>
        public static Engine ShortTimeFourier(this Engine en, string? name = null)
        {
            return en.Execute("ShortTimeFourier[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the result and properties of a short-time Fourier transform (STFT) of a signal.
        ///https://reference.wolfram.com/language/ref/ShortTimeFourierData.html
        ///</summary>
        public static Engine ShortTimeFourierData(this Engine en, string? name = null)
        {
            return en.Execute("ShortTimeFourierData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the right ascension of the local meridian for the specified date.
        ///https://reference.wolfram.com/language/ref/SiderealTime.html
        ///</summary>
        public static Engine SiderealTime(this Engine en, string? name = null)
        {
            return en.Execute("SiderealTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the variances of data1 and data2 are equal.
        ///https://reference.wolfram.com/language/ref/SiegelTukeyTest.html
        ///</summary>
        public static Engine SiegelTukeyTest(this Engine en, string? name = null)
        {
            return en.Execute("SiegelTukeyTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the line segments representing the n-step Sierpiński curve.
        ///https://reference.wolfram.com/language/ref/SierpinskiCurve.html
        ///</summary>
        public static Engine SierpinskiCurve(this Engine en, string? name = null)
        {
            return en.Execute("SierpinskiCurve[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a mesh region representing the n-step Sierpiński triangle.
        ///https://reference.wolfram.com/language/ref/SierpinskiMesh.html
        ///</summary>
        public static Engine SierpinskiMesh(this Engine en, string? name = null)
        {
            return en.Execute("SierpinskiMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives -1, 0, or 1 depending on whether x is negative, zero, or positive.
        ///https://reference.wolfram.com/language/ref/Sign.html
        ///</summary>
        public static Engine Sign(this Engine en, string? name = null)
        {
            return en.Execute("Sign[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the signature of the permutation needed to place the elements of list in canonical order.
        ///https://reference.wolfram.com/language/ref/Signature.html
        ///</summary>
        public static Engine Signature(this Engine en, string? name = null)
        {
            return en.Execute("Signature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the median of data is zero.
        ///https://reference.wolfram.com/language/ref/SignedRankTest.html
        ///</summary>
        public static Engine SignedRankTest(this Engine en, string? name = null)
        {
            return en.Execute("SignedRankTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a RegionDistanceFunction[…] that can be applied repeatedly to different points.
        ///https://reference.wolfram.com/language/ref/SignedRegionDistance.html
        ///</summary>
        public static Engine SignedRegionDistance(this Engine en, string? name = null)
        {
            return en.Execute("SignedRegionDistance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the median of data is zero.
        ///https://reference.wolfram.com/language/ref/SignTest.html
        ///</summary>
        public static Engine SignTest(this Engine en, string? name = null)
        {
            return en.Execute("SignTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the underlying simple graph from the graph g.
        ///https://reference.wolfram.com/language/ref/SimpleGraph.html
        ///</summary>
        public static Engine SimpleGraph(this Engine en, string? name = null)
        {
            return en.Execute("SimpleGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if the graph g is a simple graph and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimpleGraphQ.html
        ///</summary>
        public static Engine SimpleGraphQ(this Engine en, string? name = null)
        {
            return en.Execute("SimpleGraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the polygon poly is simple and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimplePolygonQ.html
        ///</summary>
        public static Engine SimplePolygonQ(this Engine en, string? name = null)
        {
            return en.Execute("SimplePolygonQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the polyhedron poly is simple and False otherwise.
        ///https://reference.wolfram.com/language/ref/SimplePolyhedronQ.html
        ///</summary>
        public static Engine SimplePolyhedronQ(this Engine en, string? name = null)
        {
            return en.Execute("SimplePolyhedronQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the simplex spanned by points pi.
        ///https://reference.wolfram.com/language/ref/Simplex.html
        ///</summary>
        public static Engine Simplex(this Engine en, string? name = null)
        {
            return en.Execute("Simplex[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///performs a sequence of algebraic and other transformations on expr and returns the simplest form it finds.
        ///https://reference.wolfram.com/language/ref/Simplify.html
        ///</summary>
        public static Engine Simplify(this Engine en, string? name = null)
        {
            return en.Execute("Simplify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the sine of z.
        ///https://reference.wolfram.com/language/ref/Sin.html
        ///</summary>
        public static Engine Sin(this Engine en, string? name = null)
        {
            return en.Execute("Sin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives .
        ///https://reference.wolfram.com/language/ref/Sinc.html
        ///</summary>
        public static Engine Sinc(this Engine en, string? name = null)
        {
            return en.Execute("Sinc[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the singular value decomposition for a numerical matrix m as a list of matrices {u,σ,v}, where σ is a diagonal matrix and m can be written as u.σ.ConjugateTranspose[v].
        ///https://reference.wolfram.com/language/ref/SingularValueDecomposition.html
        ///</summary>
        public static Engine SingularValueDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("SingularValueDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of the nonzero singular values of a matrix m.
        ///https://reference.wolfram.com/language/ref/SingularValueList.html
        ///</summary>
        public static Engine SingularValueList(this Engine en, string? name = null)
        {
            return en.Execute("SingularValueList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a plot of the singular values of the transfer function for the system lsys.
        ///https://reference.wolfram.com/language/ref/SingularValuePlot.html
        ///</summary>
        public static Engine SingularValuePlot(this Engine en, string? name = null)
        {
            return en.Execute("SingularValuePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic sine of z.
        ///https://reference.wolfram.com/language/ref/Sinh.html
        ///</summary>
        public static Engine Sinh(this Engine en, string? name = null)
        {
            return en.Execute("Sinh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the hyperbolic sine integral function .
        ///https://reference.wolfram.com/language/ref/SinhIntegral.html
        ///</summary>
        public static Engine SinhIntegral(this Engine en, string? name = null)
        {
            return en.Execute("SinhIntegral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the sine integral function ).
        ///https://reference.wolfram.com/language/ref/SinIntegral.html
        ///</summary>
        public static Engine SinIntegral(this Engine en, string? name = null)
        {
            return en.Execute("SinIntegral[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a sequence of n omitted elements in an expression printed with Short or Shallow. The standard print form for Skeleton is n.
        ///https://reference.wolfram.com/language/ref/Skeleton.html
        ///</summary>
        public static Engine Skeleton(this Engine en, string? name = null)
        {
            return en.Execute("Skeleton[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the skeleton transform of image, in which the value of each skeleton pixel is its distance to the nearest background pixel.
        ///https://reference.wolfram.com/language/ref/SkeletonTransform.html
        ///</summary>
        public static Engine SkeletonTransform(this Engine en, string? name = null)
        {
            return en.Execute("SkeletonTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the coefficient of skewness for the elements in list.
        ///https://reference.wolfram.com/language/ref/Skewness.html
        ///</summary>
        public static Engine Skewness(this Engine en, string? name = null)
        {
            return en.Execute("Skewness[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a slider with setting x in the range 0 to 1.
        ///https://reference.wolfram.com/language/ref/Slider.html
        ///</summary>
        public static Engine Slider(this Engine en, string? name = null)
        {
            return en.Execute("Slider[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a 2D slider with settings x and y in the range 0 to 1.
        ///https://reference.wolfram.com/language/ref/Slider2D.html
        ///</summary>
        public static Engine Slider2D(this Engine en, string? name = null)
        {
            return en.Execute("Slider2D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a slider with setting x in the range 0 to 1.
        ///https://reference.wolfram.com/language/ref/SliderBox.html
        ///</summary>
        public static Engine SliderBox(this Engine en, string? name = null)
        {
            return en.Execute("SliderBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a video iterating through all imagei.
        ///https://reference.wolfram.com/language/ref/SlideShowVideo.html
        ///</summary>
        public static Engine SlideShowVideo(this Engine en, string? name = null)
        {
            return en.Execute("SlideShowVideo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an object in which the expri are set up to be displayed on successive slides.
        ///https://reference.wolfram.com/language/ref/SlideView.html
        ///</summary>
        public static Engine SlideView(this Engine en, string? name = null)
        {
            return en.Execute("SlideView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Smith normal form decomposition of an integer matrix .
        ///https://reference.wolfram.com/language/ref/SmithDecomposition.html
        ///</summary>
        public static Engine SmithDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("SmithDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots a smooth kernel histogram for the PDF of the values xi.
        ///https://reference.wolfram.com/language/ref/SmoothHistogram.html
        ///</summary>
        public static Engine SmoothHistogram(this Engine en, string? name = null)
        {
            return en.Execute("SmoothHistogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a smooth kernel distribution based on the data values xi.
        ///https://reference.wolfram.com/language/ref/SmoothKernelDistribution.html
        ///</summary>
        public static Engine SmoothKernelDistribution(this Engine en, string? name = null)
        {
            return en.Execute("SmoothKernelDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///estimates the point density function  for point data pdata.
        ///https://reference.wolfram.com/language/ref/SmoothPointDensity.html
        ///</summary>
        public static Engine SmoothPointDensity(this Engine en, string? name = null)
        {
            return en.Execute("SmoothPointDensity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the  statistic of the elements in list.
        ///https://reference.wolfram.com/language/ref/SnDispersion.html
        ///</summary>
        public static Engine SnDispersion(this Engine en, string? name = null)
        {
            return en.Execute("SnDispersion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a snippet of text from a document or other content object.
        ///https://reference.wolfram.com/language/ref/Snippet.html
        ///</summary>
        public static Engine Snippet(this Engine en, string? name = null)
        {
            return en.Execute("Snippet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the snub polyhedron of poly by truncating some corners.
        ///https://reference.wolfram.com/language/ref/SnubPolyhedron.html
        ///</summary>
        public static Engine SnubPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("SnubPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a socket connection to the TCP host at the specified address and returns a SocketObject representing the connection.
        ///https://reference.wolfram.com/language/ref/SocketConnect.html
        ///</summary>
        public static Engine SocketConnect(this Engine en, string? name = null)
        {
            return en.Execute("SocketConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///starts listening for active connections defined by spec, but does not set up handler functions, etc.
        ///https://reference.wolfram.com/language/ref/SocketListen.html
        ///</summary>
        public static Engine SocketListen(this Engine en, string? name = null)
        {
            return en.Execute("SocketListen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a socket listener created by SocketListen.
        ///https://reference.wolfram.com/language/ref/SocketListener.html
        ///</summary>
        public static Engine SocketListener(this Engine en, string? name = null)
        {
            return en.Execute("SocketListener[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a network socket connection.
        ///https://reference.wolfram.com/language/ref/SocketObject.html
        ///</summary>
        public static Engine SocketObject(this Engine en, string? name = null)
        {
            return en.Execute("SocketObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens a socket that accepts TCP connections to localhost:port and returns a SocketObject representing the socket.
        ///https://reference.wolfram.com/language/ref/SocketOpen.html
        ///</summary>
        public static Engine SocketOpen(this Engine en, string? name = null)
        {
            return en.Execute("SocketOpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reads the next available message on the specified socket, returning it as a byte array.
        ///https://reference.wolfram.com/language/ref/SocketReadMessage.html
        ///</summary>
        public static Engine SocketReadMessage(this Engine en, string? name = null)
        {
            return en.Execute("SocketReadMessage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests if there is any data immediately available to read from the specified socket.
        ///https://reference.wolfram.com/language/ref/SocketReadyQ.html
        ///</summary>
        public static Engine SocketReadyQ(this Engine en, string? name = null)
        {
            return en.Execute("SocketReadyQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns all sockets connected to your current session, including remote sockets originating outside your current session.
        ///https://reference.wolfram.com/language/ref/Sockets.html
        ///</summary>
        public static Engine Sockets(this Engine en, string? name = null)
        {
            return en.Execute("Sockets[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///waits until there is data ready to read on all of the socketi.
        ///https://reference.wolfram.com/language/ref/SocketWaitAll.html
        ///</summary>
        public static Engine SocketWaitAll(this Engine en, string? name = null)
        {
            return en.Execute("SocketWaitAll[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///waits until there is data ready to read on any of the socketi, then returns that socket.
        ///https://reference.wolfram.com/language/ref/SocketWaitNext.html
        ///</summary>
        public static Engine SocketWaitNext(this Engine en, string? name = null)
        {
            return en.Execute("SocketWaitNext[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a softmax net layer that uses level n as the normalization dimension.
        ///https://reference.wolfram.com/language/ref/SoftmaxLayer.html
        ///</summary>
        public static Engine SoftmaxLayer(this Engine en, string? name = null)
        {
            return en.Execute("SoftmaxLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the time for the next solar eclipse after the specified date.
        ///https://reference.wolfram.com/language/ref/SolarEclipse.html
        ///</summary>
        public static Engine SolarEclipse(this Engine en, string? name = null)
        {
            return en.Execute("SolarEclipse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the solar time angle for the specified location and current date.
        ///https://reference.wolfram.com/language/ref/SolarTime.html
        ///</summary>
        public static Engine SolarTime(this Engine en, string? name = null)
        {
            return en.Execute("SolarTime[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if the 3D region reg is a solid region and False otherwise.
        ///https://reference.wolfram.com/language/ref/SolidRegionQ.html
        ///</summary>
        public static Engine SolidRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("SolidRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///sorts the elements of list into canonical order.
        ///https://reference.wolfram.com/language/ref/Sort.html
        ///</summary>
        public static Engine Sort(this Engine en, string? name = null)
        {
            return en.Execute("Sort[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of SortBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/SortBy.html
        ///</summary>
        public static Engine SortBy(this Engine en, string? name = null)
        {
            return en.Execute("SortBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a sound.
        ///https://reference.wolfram.com/language/ref/Sound.html
        ///</summary>
        public static Engine Sound(this Engine en, string? name = null)
        {
            return en.Execute("Sound[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a music-like sound note with the specified pitch.
        ///https://reference.wolfram.com/language/ref/SoundNote.html
        ///</summary>
        public static Engine SoundNote(this Engine en, string? name = null)
        {
            return en.Execute("SoundNote[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///specifies that e should be collected by the nearest enclosing Reap.
        ///https://reference.wolfram.com/language/ref/Sow.html
        ///</summary>
        public static Engine Sow(this Engine en, string? name = null)
        {
            return en.Execute("Sow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as a spacer w printer's points wide.
        ///https://reference.wolfram.com/language/ref/Spacer.html
        ///</summary>
        public static Engine Spacer(this Engine en, string? name = null)
        {
            return en.Execute("Spacer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a sparse array with all elements zero except for values vi at positions posi.
        ///https://reference.wolfram.com/language/ref/SparseArray.html
        ///</summary>
        public static Engine SparseArray(this Engine en, string? name = null)
        {
            return en.Execute("SparseArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if s is a valid SparseArray object and False otherwise.
        ///https://reference.wolfram.com/language/ref/SparseArrayQ.html
        ///</summary>
        public static Engine SparseArrayQ(this Engine en, string? name = null)
        {
            return en.Execute("SparseArrayQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents values vali associated with disjoint regions regi.
        ///https://reference.wolfram.com/language/ref/SpatialBinnedPointData.html
        ///</summary>
        public static Engine SpatialBinnedPointData(this Engine en, string? name = null)
        {
            return en.Execute("SpatialBinnedPointData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a spatial prediction from values vali given at locations loci.
        ///https://reference.wolfram.com/language/ref/SpatialEstimate.html
        ///</summary>
        public static Engine SpatialEstimate(this Engine en, string? name = null)
        {
            return en.Execute("SpatialEstimate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates the function  that can be applied repeatedly to different radii r.
        ///https://reference.wolfram.com/language/ref/SpatialJ.html
        ///</summary>
        public static Engine SpatialJ(this Engine en, string? name = null)
        {
            return en.Execute("SpatialJ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the spatial median of the elements .
        ///https://reference.wolfram.com/language/ref/SpatialMedian.html
        ///</summary>
        public static Engine SpatialMedian(this Engine en, string? name = null)
        {
            return en.Execute("SpatialMedian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the geometric or geographic region reg can be an observation in spatial statistics.
        ///https://reference.wolfram.com/language/ref/SpatialObservationRegionQ.html
        ///</summary>
        public static Engine SpatialObservationRegionQ(this Engine en, string? name = null)
        {
            return en.Execute("SpatialObservationRegionQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a collection of spatial locations points.
        ///https://reference.wolfram.com/language/ref/SpatialPointData.html
        ///</summary>
        public static Engine SpatialPointData(this Engine en, string? name = null)
        {
            return en.Execute("SpatialPointData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///tests whether the point collection pdata is distributed uniformly over the observation region.
        ///https://reference.wolfram.com/language/ref/SpatialRandomnessTest.html
        ///</summary>
        public static Engine SpatialRandomnessTest(this Engine en, string? name = null)
        {
            return en.Execute("SpatialRandomnessTest[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a net layer that applies an affine transformation to an input of size c×h0×w0 and returns an output of size c×h×w.
        ///https://reference.wolfram.com/language/ref/SpatialTransformationLayer.html
        ///</summary>
        public static Engine SpatialTransformationLayer(this Engine en, string? name = null)
        {
            return en.Execute("SpatialTransformationLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///speaks a spoken representation of the expression expr.
        ///https://reference.wolfram.com/language/ref/Speak.html
        ///</summary>
        public static Engine Speak(this Engine en, string? name = null)
        {
            return en.Execute("Speak[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of SpeakerMatchQ that can be applied to an audio object.
        ///https://reference.wolfram.com/language/ref/SpeakerMatchQ.html
        ///</summary>
        public static Engine SpeakerMatchQ(this Engine en, string? name = null)
        {
            return en.Execute("SpeakerMatchQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives Spearman's rank correlation coefficient  for the matrix m.
        ///https://reference.wolfram.com/language/ref/SpearmanRho.html
        ///</summary>
        public static Engine SpearmanRho(this Engine en, string? name = null)
        {
            return en.Execute("SpearmanRho[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the values of all known properties for an atomic state or state transition.
        ///https://reference.wolfram.com/language/ref/SpectralLineData.html
        ///</summary>
        public static Engine SpectralLineData(this Engine en, string? name = null)
        {
            return en.Execute("SpectralLineData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the spectrogram of list.
        ///https://reference.wolfram.com/language/ref/Spectrogram.html
        ///</summary>
        public static Engine Spectrogram(this Engine en, string? name = null)
        {
            return en.Execute("Spectrogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the spectrogram data of list.
        ///https://reference.wolfram.com/language/ref/SpectrogramArray.html
        ///</summary>
        public static Engine SpectrogramArray(this Engine en, string? name = null)
        {
            return en.Execute("SpectrogramArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that surfaces of 3D graphics objects which follow are to be taken to have specularity s.
        ///https://reference.wolfram.com/language/ref/Specularity.html
        ///</summary>
        public static Engine Specularity(this Engine en, string? name = null)
        {
            return en.Execute("Specularity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an interpreter object that can be applied to a speech input to try to interpret it as an object of the specified form.
        ///https://reference.wolfram.com/language/ref/SpeechInterpreter.html
        ///</summary>
        public static Engine SpeechInterpreter(this Engine en, string? name = null)
        {
            return en.Execute("SpeechInterpreter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///recognizes speech in audio and returns it as a string.
        ///https://reference.wolfram.com/language/ref/SpeechRecognize.html
        ///</summary>
        public static Engine SpeechRecognize(this Engine en, string? name = null)
        {
            return en.Execute("SpeechRecognize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///synthesizes the contents of expr as an Audio object.
        ///https://reference.wolfram.com/language/ref/SpeechSynthesize.html
        ///</summary>
        public static Engine SpeechSynthesize(this Engine en, string? name = null)
        {
            return en.Execute("SpeechSynthesize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of possible spelling corrections for "word".
        ///https://reference.wolfram.com/language/ref/SpellingCorrectionList.html
        ///</summary>
        public static Engine SpellingCorrectionList(this Engine en, string? name = null)
        {
            return en.Execute("SpellingCorrectionList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a unit sphere centered at the point p.
        ///https://reference.wolfram.com/language/ref/Sphere.html
        ///</summary>
        public static Engine Sphere(this Engine en, string? name = null)
        {
            return en.Execute("Sphere[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the positions of n uniformly distributed points on the surface of a unit sphere.
        ///https://reference.wolfram.com/language/ref/SpherePoints.html
        ///</summary>
        public static Engine SpherePoints(this Engine en, string? name = null)
        {
            return en.Execute("SpherePoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an expression that will automatically be spliced into any list in which it appears as the sequence of elements ei.
        ///https://reference.wolfram.com/language/ref/Splice.html
        ///</summary>
        public static Engine Splice(this Engine en, string? name = null)
        {
            return en.Execute("Splice[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///splits list into sublists consisting of runs of identical elements.
        ///https://reference.wolfram.com/language/ref/Split.html
        ///</summary>
        public static Engine Split(this Engine en, string? name = null)
        {
            return en.Execute("Split[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a string of text corresponding to a spoken representation of the expression expr.
        ///https://reference.wolfram.com/language/ref/SpokenString.html
        ///</summary>
        public static Engine SpokenString(this Engine en, string? name = null)
        {
            return en.Execute("SpokenString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///or  gives the square root of z.
        ///https://reference.wolfram.com/language/ref/Sqrt.html
        ///</summary>
        public static Engine Sqrt(this Engine en, string? name = null)
        {
            return en.Execute("Sqrt[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents the displayed object  in notebook expressions.
        ///https://reference.wolfram.com/language/ref/SqrtBox.html
        ///</summary>
        public static Engine SqrtBox(this Engine en, string? name = null)
        {
            return en.Execute("SqrtBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/Square.html
        ///</summary>
        public static Engine Square(this Engine en, string? name = null)
        {
            return en.Execute("Square[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is a square-free polynomial or number, and False otherwise.
        ///https://reference.wolfram.com/language/ref/SquareFreeQ.html
        ///</summary>
        public static Engine SquareFreeQ(this Engine en, string? name = null)
        {
            return en.Execute("SquareFreeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is a square matrix, and False otherwise.
        ///https://reference.wolfram.com/language/ref/SquareMatrixQ.html
        ///</summary>
        public static Engine SquareMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("SquareMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a square array of elements of type spec in an interpreter, API or form specification.
        ///https://reference.wolfram.com/language/ref/SquareRepeatingElement.html
        ///</summary>
        public static Engine SquareRepeatingElement(this Engine en, string? name = null)
        {
            return en.Execute("SquareRepeatingElement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a square wave that alternates between  and  with unit period.
        ///https://reference.wolfram.com/language/ref/SquareWave.html
        ///</summary>
        public static Engine SquareWave(this Engine en, string? name = null)
        {
            return en.Execute("SquareWave[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of expressions currently being evaluated which match the pattern.
        ///https://reference.wolfram.com/language/ref/Stack.html
        ///</summary>
        public static Engine Stack(this Engine en, string? name = null)
        {
            return en.Execute("Stack[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr, starting a fresh evaluation stack.
        ///https://reference.wolfram.com/language/ref/StackBegin.html
        ///</summary>
        public static Engine StackBegin(this Engine en, string? name = null)
        {
            return en.Execute("StackBegin[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr with intermediate expressions in evaluation chains included on the stack.
        ///https://reference.wolfram.com/language/ref/StackComplete.html
        ///</summary>
        public static Engine StackComplete(this Engine en, string? name = null)
        {
            return en.Execute("StackComplete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the time series tseries.
        ///https://reference.wolfram.com/language/ref/StackedDateListPlot.html
        ///</summary>
        public static Engine StackedDateListPlot(this Engine en, string? name = null)
        {
            return en.Execute("StackedDateListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots lines for each of the datai, with the i curve being the accumulation of values in data1 through datai.
        ///https://reference.wolfram.com/language/ref/StackedListPlot.html
        ///</summary>
        public static Engine StackedListPlot(this Engine en, string? name = null)
        {
            return en.Execute("StackedListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///evaluates expr without modifying the evaluation stack.
        ///https://reference.wolfram.com/language/ref/StackInhibit.html
        ///</summary>
        public static Engine StackInhibit(this Engine en, string? name = null)
        {
            return en.Execute("StackInhibit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the sample standard deviation of the elements in list.
        ///https://reference.wolfram.com/language/ref/StandardDeviation.html
        ///</summary>
        public static Engine StandardDeviation(this Engine en, string? name = null)
        {
            return en.Execute("StandardDeviation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///prints as the standard Wolfram Language two-dimensional representation of expr.
        ///https://reference.wolfram.com/language/ref/StandardForm.html
        ///</summary>
        public static Engine StandardForm(this Engine en, string? name = null)
        {
            return en.Execute("StandardForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///shifts and rescales the elements of list to have zero mean and unit sample variance.
        ///https://reference.wolfram.com/language/ref/Standardize.html
        ///</summary>
        public static Engine Standardize(this Engine en, string? name = null)
        {
            return en.Execute("Standardize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the thermodynamic properties of seawater for the specified parameters.
        ///https://reference.wolfram.com/language/ref/StandardOceanData.html
        ///</summary>
        public static Engine StandardOceanData(this Engine en, string? name = null)
        {
            return en.Execute("StandardOceanData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the star graph with n vertices .
        ///https://reference.wolfram.com/language/ref/StarGraph.html
        ///</summary>
        public static Engine StarGraph(this Engine en, string? name = null)
        {
            return en.Execute("StarGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///starts an external session using the external evaluator sys, returning an external session object.
        ///https://reference.wolfram.com/language/ref/StartExternalSession.html
        ///</summary>
        public static Engine StartExternalSession(this Engine en, string? name = null)
        {
            return en.Execute("StartExternalSession[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///executes an external program, yielding a ProcessObject to represent the resulting subprocess.
        ///https://reference.wolfram.com/language/ref/StartProcess.html
        ///</summary>
        public static Engine StartProcess(this Engine en, string? name = null)
        {
            return en.Execute("StartProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///starts a web session using the specified browser.
        ///https://reference.wolfram.com/language/ref/StartWebSession.html
        ///</summary>
        public static Engine StartWebSession(this Engine en, string? name = null)
        {
            return en.Execute("StartWebSession[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the standard state-space model with state matrix a, input matrix b, output matrix c, and transmission matrix d.
        ///https://reference.wolfram.com/language/ref/StateSpaceModel.html
        ///</summary>
        public static Engine StateSpaceModel(this Engine en, string? name = null)
        {
            return en.Execute("StateSpaceModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///linearizes the AffineStateSpaceModel asys by state transformation.
        ///https://reference.wolfram.com/language/ref/StateTransformationLinearize.html
        ///</summary>
        public static Engine StateTransformationLinearize(this Engine en, string? name = null)
        {
            return en.Execute("StateTransformationLinearize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the stationary distribution of the process proc, when it exists.
        ///https://reference.wolfram.com/language/ref/StationaryDistribution.html
        ///</summary>
        public static Engine StationaryDistribution(this Engine en, string? name = null)
        {
            return en.Execute("StationaryDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the stationary wavelet packet transform (SWPT) of an array of data.
        ///https://reference.wolfram.com/language/ref/StationaryWaveletPacketTransform.html
        ///</summary>
        public static Engine StationaryWaveletPacketTransform(this Engine en, string? name = null)
        {
            return en.Execute("StationaryWaveletPacketTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the stationary wavelet transform (SWT) of an array of data.
        ///https://reference.wolfram.com/language/ref/StationaryWaveletTransform.html
        ///</summary>
        public static Engine StationaryWaveletTransform(this Engine en, string? name = null)
        {
            return en.Execute("StationaryWaveletTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of status centralities for the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/StatusCentrality.html
        ///</summary>
        public static Engine StatusCentrality(this Engine en, string? name = null)
        {
            return en.Execute("StatusCentrality[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Stieltjes constant .
        ///https://reference.wolfram.com/language/ref/StieltjesGamma.html
        ///</summary>
        public static Engine StieltjesGamma(this Engine en, string? name = null)
        {
            return en.Execute("StieltjesGamma[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///uses the density d of shading.
        ///https://reference.wolfram.com/language/ref/StippleShading.html
        ///</summary>
        public static Engine StippleShading(this Engine en, string? name = null)
        {
            return en.Execute("StippleShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///converts proc to a standard Stratonovich process whenever possible.
        ///https://reference.wolfram.com/language/ref/StratonovichProcess.html
        ///</summary>
        public static Engine StratonovichProcess(this Engine en, string? name = null)
        {
            return en.Execute("StratonovichProcess[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns an integer that specifies the position of the current point in an open stream.
        ///https://reference.wolfram.com/language/ref/StreamPosition.html
        ///</summary>
        public static Engine StreamPosition(this Engine en, string? name = null)
        {
            return en.Execute("StreamPosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///lists only streams with the specified name.
        ///https://reference.wolfram.com/language/ref/Streams.html
        ///</summary>
        public static Engine Streams(this Engine en, string? name = null)
        {
            return en.Execute("Streams[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringCases that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringCases.html
        ///</summary>
        public static Engine StringCases(this Engine en, string? name = null)
        {
            return en.Execute("StringCases[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringContainsQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringContainsQ.html
        ///</summary>
        public static Engine StringContainsQ(this Engine en, string? name = null)
        {
            return en.Execute("StringContainsQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringDelete that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringDelete.html
        ///</summary>
        public static Engine StringDelete(this Engine en, string? name = null)
        {
            return en.Execute("StringDelete[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringEndsQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringEndsQ.html
        ///</summary>
        public static Engine StringEndsQ(this Engine en, string? name = null)
        {
            return en.Execute("StringEndsQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///attempts to determine what ImportString format could be used to import the string "string".
        ///https://reference.wolfram.com/language/ref/StringFormat.html
        ///</summary>
        public static Engine StringFormat(this Engine en, string? name = null)
        {
            return en.Execute("StringFormat[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringFreeQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringFreeQ.html
        ///</summary>
        public static Engine StringFreeQ(this Engine en, string? name = null)
        {
            return en.Execute("StringFreeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of characters in a string.
        ///https://reference.wolfram.com/language/ref/StringLength.html
        ///</summary>
        public static Engine StringLength(this Engine en, string? name = null)
        {
            return en.Execute("StringLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringMatchQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringMatchQ.html
        ///</summary>
        public static Engine StringMatchQ(this Engine en, string? name = null)
        {
            return en.Execute("StringMatchQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///pads strings with spaces on the left to make them all the same length.
        ///https://reference.wolfram.com/language/ref/StringPadLeft.html
        ///</summary>
        public static Engine StringPadLeft(this Engine en, string? name = null)
        {
            return en.Execute("StringPadLeft[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///pads strings with spaces on the right to make them all the same length.
        ///https://reference.wolfram.com/language/ref/StringPadRight.html
        ///</summary>
        public static Engine StringPadRight(this Engine en, string? name = null)
        {
            return en.Execute("StringPadRight[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringPosition that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringPosition.html
        ///</summary>
        public static Engine StringPosition(this Engine en, string? name = null)
        {
            return en.Execute("StringPosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if expr is a string, and False otherwise.
        ///https://reference.wolfram.com/language/ref/StringQ.html
        ///</summary>
        public static Engine StringQ(this Engine en, string? name = null)
        {
            return en.Execute("StringQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringReplace that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringReplace.html
        ///</summary>
        public static Engine StringReplace(this Engine en, string? name = null)
        {
            return en.Execute("StringReplace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///reverses the order of the characters in "string".
        ///https://reference.wolfram.com/language/ref/StringReverse.html
        ///</summary>
        public static Engine StringReverse(this Engine en, string? name = null)
        {
            return en.Execute("StringReverse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a string by concatenating all the si, with spaces inserted between them.
        ///https://reference.wolfram.com/language/ref/StringRiffle.html
        ///</summary>
        public static Engine StringRiffle(this Engine en, string? name = null)
        {
            return en.Execute("StringRiffle[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///cycles one position to the left.
        ///https://reference.wolfram.com/language/ref/StringRotateLeft.html
        ///</summary>
        public static Engine StringRotateLeft(this Engine en, string? name = null)
        {
            return en.Execute("StringRotateLeft[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///cycles one position to the right.
        ///https://reference.wolfram.com/language/ref/StringRotateRight.html
        ///</summary>
        public static Engine StringRotateRight(this Engine en, string? name = null)
        {
            return en.Execute("StringRotateRight[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a sequence of n omitted characters in a string printed with Short. The standard print form for StringSkeleton is an ellipsis.
        ///https://reference.wolfram.com/language/ref/StringSkeleton.html
        ///</summary>
        public static Engine StringSkeleton(this Engine en, string? name = null)
        {
            return en.Execute("StringSkeleton[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///splits "string" into a list of substrings separated by whitespace.
        ///https://reference.wolfram.com/language/ref/StringSplit.html
        ///</summary>
        public static Engine StringSplit(this Engine en, string? name = null)
        {
            return en.Execute("StringSplit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of StringStartsQ that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/StringStartsQ.html
        ///</summary>
        public static Engine StringStartsQ(this Engine en, string? name = null)
        {
            return en.Execute("StringStartsQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a TemplateObject expression that represents a string template to be applied to arguments.
        ///https://reference.wolfram.com/language/ref/StringTemplate.html
        ///</summary>
        public static Engine StringTemplate(this Engine en, string? name = null)
        {
            return en.Execute("StringTemplate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a byte array corresponding to the UTF-8 encoding of the specified string.
        ///https://reference.wolfram.com/language/ref/StringToByteArray.html
        ///</summary>
        public static Engine StringToByteArray(this Engine en, string? name = null)
        {
            return en.Execute("StringToByteArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens an input stream for reading from a string.
        ///https://reference.wolfram.com/language/ref/StringToStream.html
        ///</summary>
        public static Engine StringToStream(this Engine en, string? name = null)
        {
            return en.Execute("StringToStream[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///trims whitespace from the beginning and end of "string".
        ///https://reference.wolfram.com/language/ref/StringTrim.html
        ///</summary>
        public static Engine StringTrim(this Engine en, string? name = null)
        {
            return en.Execute("StringTrim[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///will strip out unnecessary boxes, spaces, and styles from a format expression.
        ///https://reference.wolfram.com/language/ref/StripBoxes.html
        ///</summary>
        public static Engine StripBoxes(this Engine en, string? name = null)
        {
            return en.Execute("StripBoxes[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the structural importances for all components in the ReliabilityDistribution rdist.
        ///https://reference.wolfram.com/language/ref/StructuralImportance.html
        ///</summary>
        public static Engine StructuralImportance(this Engine en, string? name = null)
        {
            return en.Execute("StructuralImportance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Student  distribution with ν degrees of freedom.
        ///https://reference.wolfram.com/language/ref/StudentTDistribution.html
        ///</summary>
        public static Engine StudentTDistribution(this Engine en, string? name = null)
        {
            return en.Execute("StudentTDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a low-level representation of the contents of a style definition cell.
        ///https://reference.wolfram.com/language/ref/StyleData.html
        ///</summary>
        public static Engine StyleData(this Engine en, string? name = null)
        {
            return en.Execute("StyleData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates the list {0,1/n,2/n,…,1}.
        ///https://reference.wolfram.com/language/ref/Subdivide.html
        ///</summary>
        public static Engine Subdivide(this Engine en, string? name = null)
        {
            return en.Execute("Subdivide[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of permutations of n objects that leave no object fixed.
        ///https://reference.wolfram.com/language/ref/Subfactorial.html
        ///</summary>
        public static Engine Subfactorial(this Engine en, string? name = null)
        {
            return en.Execute("Subfactorial[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr-.
        ///https://reference.wolfram.com/language/ref/SubMinus.html
        ///</summary>
        public static Engine SubMinus(this Engine en, string? name = null)
        {
            return en.Execute("SubMinus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr+.
        ///https://reference.wolfram.com/language/ref/SubPlus.html
        ///</summary>
        public static Engine SubPlus(this Engine en, string? name = null)
        {
            return en.Execute("SubPlus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of all possible subsequences of list.
        ///https://reference.wolfram.com/language/ref/Subsequences.html
        ///</summary>
        public static Engine Subsequences(this Engine en, string? name = null)
        {
            return en.Execute("Subsequences[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of SubsetReplace that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/SubsetReplace.html
        ///</summary>
        public static Engine SubsetReplace(this Engine en, string? name = null)
        {
            return en.Execute("SubsetReplace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of all possible subsets of list.
        ///https://reference.wolfram.com/language/ref/Subsets.html
        ///</summary>
        public static Engine Subsets(this Engine en, string? name = null)
        {
            return en.Execute("Subsets[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr*.
        ///https://reference.wolfram.com/language/ref/SubStar.html
        ///</summary>
        public static Engine SubStar(this Engine en, string? name = null)
        {
            return en.Execute("SubStar[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form of SubstitutionSystem that corresponds to one step of evolution.
        ///https://reference.wolfram.com/language/ref/SubstitutionSystem.html
        ///</summary>
        public static Engine SubstitutionSystem(this Engine en, string? name = null)
        {
            return en.Execute("SubstitutionSystem[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///subtracts the right-hand side of rel from each side, producing a zero right-hand side.
        ///https://reference.wolfram.com/language/ref/SubtractSides.html
        ///</summary>
        public static Engine SubtractSides(this Engine en, string? name = null)
        {
            return en.Execute("SubtractSides[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of transformation rules corresponding to all subvalues (values for f[…][…]…) defined for the symbol f.
        ///https://reference.wolfram.com/language/ref/SubValues.html
        ///</summary>
        public static Engine SubValues(this Engine en, string? name = null)
        {
            return en.Execute("SubValues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the position of the Sun for the specified date.
        ///https://reference.wolfram.com/language/ref/SunPosition.html
        ///</summary>
        public static Engine SunPosition(this Engine en, string? name = null)
        {
            return en.Execute("SunPosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the times of the next sunrise for the specified dates.
        ///https://reference.wolfram.com/language/ref/Sunrise.html
        ///</summary>
        public static Engine Sunrise(this Engine en, string? name = null)
        {
            return en.Execute("Sunrise[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the time of the next sunset for the specified dates.
        ///https://reference.wolfram.com/language/ref/Sunset.html
        ///</summary>
        public static Engine Sunset(this Engine en, string? name = null)
        {
            return en.Execute("Sunset[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr†.
        ///https://reference.wolfram.com/language/ref/SuperDagger.html
        ///</summary>
        public static Engine SuperDagger(this Engine en, string? name = null)
        {
            return en.Execute("SuperDagger[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr-.
        ///https://reference.wolfram.com/language/ref/SuperMinus.html
        ///</summary>
        public static Engine SuperMinus(this Engine en, string? name = null)
        {
            return en.Execute("SuperMinus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr+.
        ///https://reference.wolfram.com/language/ref/SuperPlus.html
        ///</summary>
        public static Engine SuperPlus(this Engine en, string? name = null)
        {
            return en.Execute("SuperPlus[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays as expr*.
        ///https://reference.wolfram.com/language/ref/SuperStar.html
        ///</summary>
        public static Engine SuperStar(this Engine en, string? name = null)
        {
            return en.Execute("SuperStar[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the surface area of the three-dimensional region reg.
        ///https://reference.wolfram.com/language/ref/SurfaceArea.html
        ///</summary>
        public static Engine SurfaceArea(this Engine en, string? name = null)
        {
            return en.Execute("SurfaceArea[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a survival distribution with event times ei.
        ///https://reference.wolfram.com/language/ref/SurvivalDistribution.html
        ///</summary>
        public static Engine SurvivalDistribution(this Engine en, string? name = null)
        {
            return en.Execute("SurvivalDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the survival function as a pure function.
        ///https://reference.wolfram.com/language/ref/SurvivalFunction.html
        ///</summary>
        public static Engine SurvivalFunction(this Engine en, string? name = null)
        {
            return en.Execute("SurvivalFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the symbolic survival model obtained from functions like SurvivalModelFit.
        ///https://reference.wolfram.com/language/ref/SurvivalModel.html
        ///</summary>
        public static Engine SurvivalModel(this Engine en, string? name = null)
        {
            return en.Execute("SurvivalModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a survival model for event times ei.
        ///https://reference.wolfram.com/language/ref/SurvivalModelFit.html
        ///</summary>
        public static Engine SurvivalModelFit(this Engine en, string? name = null)
        {
            return en.Execute("SurvivalModelFit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a legend with inherited colors within visualization functions.
        ///https://reference.wolfram.com/language/ref/SwatchLegend.html
        ///</summary>
        public static Engine SwatchLegend(this Engine en, string? name = null)
        {
            return en.Execute("SwatchLegend[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///refers to a symbol with the specified name.
        ///https://reference.wolfram.com/language/ref/Symbol.html
        ///</summary>
        public static Engine Symbol(this Engine en, string? name = null)
        {
            return en.Execute("Symbol[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the name of the specified symbol.
        ///https://reference.wolfram.com/language/ref/SymbolName.html
        ///</summary>
        public static Engine SymbolName(this Engine en, string? name = null)
        {
            return en.Execute("SymbolName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the Symlet wavelet of order n.
        ///https://reference.wolfram.com/language/ref/SymletWavelet.html
        ///</summary>
        public static Engine SymletWavelet(this Engine en, string? name = null)
        {
            return en.Execute("SymletWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the symmetry of a tensor that is symmetric in the slots si.
        ///https://reference.wolfram.com/language/ref/Symmetric.html
        ///</summary>
        public static Engine Symmetric(this Engine en, string? name = null)
        {
            return en.Execute("Symmetric[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the symmetric group of degree n.
        ///https://reference.wolfram.com/language/ref/SymmetricGroup.html
        ///</summary>
        public static Engine SymmetricGroup(this Engine en, string? name = null)
        {
            return en.Execute("SymmetricGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents all the information needed for encryption, decryption, and other operations in a symmetric cryptographic system.
        ///https://reference.wolfram.com/language/ref/SymmetricKey.html
        ///</summary>
        public static Engine SymmetricKey(this Engine en, string? name = null)
        {
            return en.Execute("SymmetricKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives True if m is explicitly symmetric, and False otherwise.
        ///https://reference.wolfram.com/language/ref/SymmetricMatrixQ.html
        ///</summary>
        public static Engine SymmetricMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("SymmetricMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a symmetrized array version of list.
        ///https://reference.wolfram.com/language/ref/SymmetrizedArray.html
        ///</summary>
        public static Engine SymmetrizedArray(this Engine en, string? name = null)
        {
            return en.Execute("SymmetrizedArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a list of rules posivali of the symmetrized array sa.
        ///https://reference.wolfram.com/language/ref/SymmetrizedArrayRules.html
        ///</summary>
        public static Engine SymmetrizedArrayRules(this Engine en, string? name = null)
        {
            return en.Execute("SymmetrizedArrayRules[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the synonyms associated with the specified word.
        ///https://reference.wolfram.com/language/ref/Synonyms.html
        ///</summary>
        public static Engine Synonyms(this Engine en, string? name = null)
        {
            return en.Execute("Synonyms[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives information used to generate syntax coloring and other advisories when f[…] is entered as input.
        ///https://reference.wolfram.com/language/ref/SyntaxInformation.html
        ///</summary>
        public static Engine SyntaxInformation(this Engine en, string? name = null)
        {
            return en.Execute("SyntaxInformation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///finds the number of characters starting at the beginning of a string that correspond to syntactically correct input for a single Wolfram Language expression.
        ///https://reference.wolfram.com/language/ref/SyntaxLength.html
        ///</summary>
        public static Engine SyntaxLength(this Engine en, string? name = null)
        {
            return en.Execute("SyntaxLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a WSTP packet where integer indicates the position at which a syntax error was detected in the input line.
        ///https://reference.wolfram.com/language/ref/SyntaxPacket.html
        ///</summary>
        public static Engine SyntaxPacket(this Engine en, string? name = null)
        {
            return en.Execute("SyntaxPacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if the string corresponds to syntactically correct input for a single Wolfram Language expression, and returns False otherwise.
        ///https://reference.wolfram.com/language/ref/SyntaxQ.html
        ///</summary>
        public static Engine SyntaxQ(this Engine en, string? name = null)
        {
            return en.Execute("SyntaxQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///replaces missing values in each example by generated values.
        ///https://reference.wolfram.com/language/ref/SynthesizeMissingValues.html
        ///</summary>
        public static Engine SynthesizeMissingValues(this Engine en, string? name = null)
        {
            return en.Execute("SynthesizeMissingValues[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the expression stored under "keyname" in secure storage.
        ///https://reference.wolfram.com/language/ref/SystemCredential.html
        ///</summary>
        public static Engine SystemCredential(this Engine en, string? name = null)
        {
            return en.Execute("SystemCredential[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the list of keys in secure storage that match patt.
        ///https://reference.wolfram.com/language/ref/SystemCredentialKeys.html
        ///</summary>
        public static Engine SystemCredentialKeys(this Engine en, string? name = null)
        {
            return en.Execute("SystemCredentialKeys[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a credential store.
        ///https://reference.wolfram.com/language/ref/SystemCredentialStoreObject.html
        ///</summary>
        public static Engine SystemCredentialStoreObject(this Engine en, string? name = null)
        {
            return en.Execute("SystemCredentialStoreObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///brings up an interactive system dialog and returns the value chosen in the dialog.
        ///https://reference.wolfram.com/language/ref/SystemDialogInput.html
        ///</summary>
        public static Engine SystemDialogInput(this Engine en, string? name = null)
        {
            return en.Execute("SystemDialogInput[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of rules with information about the component "comp".
        ///https://reference.wolfram.com/language/ref/SystemInformation.html
        ///</summary>
        public static Engine SystemInformation(this Engine en, string? name = null)
        {
            return en.Execute("SystemInformation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///downloads and installs the software package pack on your machine.
        ///https://reference.wolfram.com/language/ref/SystemInstall.html
        ///</summary>
        public static Engine SystemInstall(this Engine en, string? name = null)
        {
            return en.Execute("SystemInstall[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a representation of the model "model", usable as input to other functions.
        ///https://reference.wolfram.com/language/ref/SystemModel.html
        ///</summary>
        public static Engine SystemModel(this Engine en, string? name = null)
        {
            return en.Execute("SystemModel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///starts SystemModeler and opens the SystemModel model.
        ///https://reference.wolfram.com/language/ref/SystemModeler.html
        ///</summary>
        public static Engine SystemModeler(this Engine en, string? name = null)
        {
            return en.Execute("SystemModeler[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///lists all example models.
        ///https://reference.wolfram.com/language/ref/SystemModelExamples.html
        ///</summary>
        public static Engine SystemModelExamples(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelExamples[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a linearized StateSpaceModel for model at an equilibrium.
        ///https://reference.wolfram.com/language/ref/SystemModelLinearize.html
        ///</summary>
        public static Engine SystemModelLinearize(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelLinearize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///shows default plots from the SystemModelSimulationData object sim.
        ///https://reference.wolfram.com/language/ref/SystemModelPlot.html
        ///</summary>
        public static Engine SystemModelPlot(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///retrieves the lifetime distribution for model.
        ///https://reference.wolfram.com/language/ref/SystemModelReliability.html
        ///</summary>
        public static Engine SystemModelReliability(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelReliability[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the models matching the string pattern patt.
        ///https://reference.wolfram.com/language/ref/SystemModels.html
        ///</summary>
        public static Engine SystemModels(this Engine en, string? name = null)
        {
            return en.Execute("SystemModels[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///simulates model according to experiment settings.
        ///https://reference.wolfram.com/language/ref/SystemModelSimulate.html
        ///</summary>
        public static Engine SystemModelSimulate(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelSimulate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents simulation data from functions such as SystemModelSimulate etc.
        ///https://reference.wolfram.com/language/ref/SystemModelSimulationData.html
        ///</summary>
        public static Engine SystemModelSimulationData(this Engine en, string? name = null)
        {
            return en.Execute("SystemModelSimulationData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///opens the specified file, URL, or other target with the associated program on your computer system.
        ///https://reference.wolfram.com/language/ref/SystemOpen.html
        ///</summary>
        public static Engine SystemOpen(this Engine en, string? name = null)
        {
            return en.Execute("SystemOpen[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the current setting for the internal system option with the specified name.
        ///https://reference.wolfram.com/language/ref/SystemOptions.html
        ///</summary>
        public static Engine SystemOptions(this Engine en, string? name = null)
        {
            return en.Execute("SystemOptions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives information about all processes running on your computer system.
        ///https://reference.wolfram.com/language/ref/SystemProcessData.html
        ///</summary>
        public static Engine SystemProcessData(this Engine en, string? name = null)
        {
            return en.Execute("SystemProcessData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a list of all processes that are running on your computer system.
        ///https://reference.wolfram.com/language/ref/SystemProcesses.html
        ///</summary>
        public static Engine SystemProcesses(this Engine en, string? name = null)
        {
            return en.Execute("SystemProcesses[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents controller data generated by functions LQGRegulator, PIDTune, etc.
        ///https://reference.wolfram.com/language/ref/SystemsModelControllerData.html
        ///</summary>
        public static Engine SystemsModelControllerData(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelControllerData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a time delay of δ in a StateSpaceModel or TransferFunctionModel.
        ///https://reference.wolfram.com/language/ref/SystemsModelDelay.html
        ///</summary>
        public static Engine SystemsModelDelay(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelDelay[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the number of inputs and outputs of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelDimensions.html
        ///</summary>
        public static Engine SystemsModelDimensions(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelDimensions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///connects the outputs from sys to the inputs with negative feedback.
        ///https://reference.wolfram.com/language/ref/SystemsModelFeedbackConnect.html
        ///</summary>
        public static Engine SystemsModelFeedbackConnect(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelFeedbackConnect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the linearity of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelLinearity.html
        ///</summary>
        public static Engine SystemsModelLinearity(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelLinearity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///merges the systems models sysj.
        ///https://reference.wolfram.com/language/ref/SystemsModelMerge.html
        ///</summary>
        public static Engine SystemsModelMerge(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelMerge[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the order of the state-space model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelOrder.html
        ///</summary>
        public static Engine SystemsModelOrder(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelOrder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the vector-relative orders of the systems model sys.
        ///https://reference.wolfram.com/language/ref/SystemsModelVectorRelativeOrders.html
        ///</summary>
        public static Engine SystemsModelVectorRelativeOrders(this Engine en, string? name = null)
        {
            return en.Execute("SystemsModelVectorRelativeOrders[" + en.ValidNames.Last() + "]", name);
        }


    }
}
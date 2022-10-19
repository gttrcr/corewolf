namespace NetWolf
{
    public static class BuiltinSymbolG
    {
        ///<summary>
        ///filters data by convolving with a Gabor kernel of pixel radius r and wave vector k.
        ///https://reference.wolfram.com/language/ref/GaborFilter.html
        ///</summary>
        public static Engine GaborFilter(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GaborFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses a Gabor kernel with phase shift ϕ.
        ///https://reference.wolfram.com/language/ref/GaborFilter.html
        ///</summary>
        public static Engine GaborFilter(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("GaborFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///uses a Gabor kernel with radius r  and standard deviation σ.
        ///https://reference.wolfram.com/language/ref/GaborFilter.html
        ///</summary>
        public static Engine GaborFilter(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GaborFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a matrix that corresponds to the real part of a Gabor kernel of radius r and wave vector k.
        ///https://reference.wolfram.com/language/ref/GaborMatrix.html
        ///</summary>
        public static Engine GaborMatrix(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GaborMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses phase shift ϕ.
        ///https://reference.wolfram.com/language/ref/GaborMatrix.html
        ///</summary>
        public static Engine GaborMatrix(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GaborMatrix[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses the specified standard deviation σ.
        ///https://reference.wolfram.com/language/ref/GaborMatrix.html
        ///</summary>
        public static Engine GaborMatrix(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GaborMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gabor wavelet of frequency 6.
        ///https://reference.wolfram.com/language/ref/GaborWavelet.html
        ///</summary>
        public static Engine GaborWavelet(this Engine en, string? name = null)
        {
            return en.Execute("GaborWavelet[]", name);
        }

        ///<summary>
        ///represents a Gabor wavelet of frequency w.
        ///https://reference.wolfram.com/language/ref/GaborWavelet.html
        ///</summary>
        public static Engine GaborWavelet(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GaborWavelet[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the gain margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/GainMargins.html
        ///</summary>
        public static Engine GainMargins(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GainMargins[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the gain and phase margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/GainPhaseMargins.html
        ///</summary>
        public static Engine GainPhaseMargins(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GainPhaseMargins[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the galaxy entity.
        ///https://reference.wolfram.com/language/ref/GalaxyData.html
        ///</summary>
        public static Engine GalaxyData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GalaxyData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified galaxy entities.
        ///https://reference.wolfram.com/language/ref/GalaxyData.html
        ///</summary>
        public static Engine GalaxyData(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GalaxyData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/GalaxyData.html
        ///</summary>
        public static Engine GalaxyData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GalaxyData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an object in which the expri are displayed in a browsable gallery layout.
        ///https://reference.wolfram.com/language/ref/GalleryView.html
        ///</summary>
        public static Engine GalleryView(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GalleryView[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is the Euler gamma function .
        ///https://reference.wolfram.com/language/ref/Gamma.html
        ///</summary>
        public static Engine Gamma(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("Gamma[" + arg0 + "]", name);
        }

        ///<summary>
        ///is the incomplete gamma function .
        ///https://reference.wolfram.com/language/ref/Gamma.html
        ///</summary>
        public static Engine Gamma(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("Gamma[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the generalized incomplete gamma function .
        ///https://reference.wolfram.com/language/ref/Gamma.html
        ///</summary>
        public static Engine Gamma(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("Gamma[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a gamma distribution with shape parameter α and scale parameter β.
        ///https://reference.wolfram.com/language/ref/GammaDistribution.html
        ///</summary>
        public static Engine GammaDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GammaDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a generalized gamma distribution with shape parameters α and γ, scale parameter β, and location parameter μ.
        ///https://reference.wolfram.com/language/ref/GammaDistribution.html
        ///</summary>
        public static Engine GammaDistribution(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("GammaDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///is the regularized incomplete gamma function .
        ///https://reference.wolfram.com/language/ref/GammaRegularized.html
        ///</summary>
        public static Engine GammaRegularized(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GammaRegularized[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a generalized autoregressive conditionally heteroscedastic process of orders p and q, driven by a standard white noise.
        ///https://reference.wolfram.com/language/ref/GARCHProcess.html
        ///</summary>
        public static Engine GARCHProcess(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GARCHProcess[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents a GARCH process with initial data init.
        ///https://reference.wolfram.com/language/ref/GARCHProcess.html
        ///</summary>
        public static Engine GARCHProcess(this Engine en, string arg0, List<string> arg1, List<string> arg2, string arg3, string? name = null)
        {
            return en.Execute("GARCHProcess[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a trainable recurrent layer that takes a sequence of vectors and produces a sequence of vectors each of size n.
        ///https://reference.wolfram.com/language/ref/GatedRecurrentLayer.html
        ///</summary>
        public static Engine GatedRecurrentLayer(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GatedRecurrentLayer[" + arg0 + "]", name);
        }

        ///<summary>
        ///includes options for initial weights and other parameters.
        ///https://reference.wolfram.com/language/ref/GatedRecurrentLayer.html
        ///</summary>
        public static Engine GatedRecurrentLayer(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GatedRecurrentLayer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gathers the elements of list into sublists of identical elements.
        ///https://reference.wolfram.com/language/ref/Gather.html
        ///</summary>
        public static Engine Gather(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("Gather[" + arg0 + "]", name);
        }

        ///<summary>
        ///applies test to pairs of elements to determine if they should be considered identical.
        ///https://reference.wolfram.com/language/ref/Gather.html
        ///</summary>
        public static Engine Gather(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("Gather[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gathers into sublists each set of elements in list that gives the same value when f is applied.
        ///https://reference.wolfram.com/language/ref/GatherBy.html
        ///</summary>
        public static Engine GatherBy(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GatherBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gathers list into nested sublists using fi at level i.
        ///https://reference.wolfram.com/language/ref/GatherBy.html
        ///</summary>
        public static Engine GatherBy(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GatherBy[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///filters data by convolving with a Gaussian kernel of radius r.
        ///https://reference.wolfram.com/language/ref/GaussianFilter.html
        ///</summary>
        public static Engine GaussianFilter(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GaussianFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///convolves data with a kernel formed from the ni derivatives of the discrete Gaussian.
        ///https://reference.wolfram.com/language/ref/GaussianFilter.html
        ///</summary>
        public static Engine GaussianFilter(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GaussianFilter[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///uses a Gaussian kernel with radius r and standard deviation σ.
        ///https://reference.wolfram.com/language/ref/GaussianFilter.html
        ///</summary>
        public static Engine GaussianFilter(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GaussianFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses radius ri at level i in data.
        ///https://reference.wolfram.com/language/ref/GaussianFilter.html
        ///</summary>
        public static Engine GaussianFilter(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GaussianFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a matrix that corresponds to a Gaussian kernel of radius r.
        ///https://reference.wolfram.com/language/ref/GaussianMatrix.html
        ///</summary>
        public static Engine GaussianMatrix(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GaussianMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a matrix corresponding to a Gaussian kernel with radius r and standard deviation σ.
        ///https://reference.wolfram.com/language/ref/GaussianMatrix.html
        ///</summary>
        public static Engine GaussianMatrix(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GaussianMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a matrix formed from the n1 derivative of the Gaussian with respect to rows and the n2 derivative with respect to columns.
        ///https://reference.wolfram.com/language/ref/GaussianMatrix.html
        ///</summary>
        public static Engine GaussianMatrix(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GaussianMatrix[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a matrix formed from the sums of the ni1 and ni2 derivatives.
        ///https://reference.wolfram.com/language/ref/GaussianMatrix.html
        ///</summary>
        public static Engine GaussianMatrix(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GaussianMatrix[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives an array corresponding to a Gaussian kernel with radius ri in the i index direction.
        ///https://reference.wolfram.com/language/ref/GaussianMatrix.html
        ///</summary>
        public static Engine GaussianMatrix(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GaussianMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian orthogonal matrix distribution with matrix dimensions {n,n} and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/GaussianOrthogonalMatrixDistribution.html
        ///</summary>
        public static Engine GaussianOrthogonalMatrixDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GaussianOrthogonalMatrixDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian orthogonal matrix distribution with unit scale parameter.
        ///https://reference.wolfram.com/language/ref/GaussianOrthogonalMatrixDistribution.html
        ///</summary>
        public static Engine GaussianOrthogonalMatrixDistribution(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GaussianOrthogonalMatrixDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian symplectic matrix distribution with matrix dimensions {2 n,2 n} over the field of complex numbers and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/GaussianSymplecticMatrixDistribution.html
        ///</summary>
        public static Engine GaussianSymplecticMatrixDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GaussianSymplecticMatrixDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian symplectic matrix distribution with unit scale parameter.
        ///https://reference.wolfram.com/language/ref/GaussianSymplecticMatrixDistribution.html
        ///</summary>
        public static Engine GaussianSymplecticMatrixDistribution(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GaussianSymplecticMatrixDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian unitary matrix distribution with matrix dimensions {n,n} and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/GaussianUnitaryMatrixDistribution.html
        ///</summary>
        public static Engine GaussianUnitaryMatrixDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GaussianUnitaryMatrixDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian unitary matrix distribution with unit scale parameter.
        ///https://reference.wolfram.com/language/ref/GaussianUnitaryMatrixDistribution.html
        ///</summary>
        public static Engine GaussianUnitaryMatrixDistribution(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GaussianUnitaryMatrixDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian window function of x.
        ///https://reference.wolfram.com/language/ref/GaussianWindow.html
        ///</summary>
        public static Engine GaussianWindow(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GaussianWindow[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses standard deviation σ.
        ///https://reference.wolfram.com/language/ref/GaussianWindow.html
        ///</summary>
        public static Engine GaussianWindow(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GaussianWindow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the greatest common divisor of the ni.
        ///https://reference.wolfram.com/language/ref/GCD.html
        ///</summary>
        public static Engine GCD(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GCD[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the Gegenbauer polynomial .
        ///https://reference.wolfram.com/language/ref/GegenbauerC.html
        ///</summary>
        public static Engine GegenbauerC(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GegenbauerC[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the renormalized form .
        ///https://reference.wolfram.com/language/ref/GegenbauerC.html
        ///</summary>
        public static Engine GegenbauerC(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GegenbauerC[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs a generalized linear model of the form  that fits the yi for successive x values 1, 2, ….
        ///https://reference.wolfram.com/language/ref/GeneralizedLinearModelFit.html
        ///</summary>
        public static Engine GeneralizedLinearModelFit(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GeneralizedLinearModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///constructs a generalized linear model of the form  where the fi depend on the variables xk.
        ///https://reference.wolfram.com/language/ref/GeneralizedLinearModelFit.html
        ///</summary>
        public static Engine GeneralizedLinearModelFit(this Engine en, List<string> arg0, List<string> arg1, List<string> arg2, List<string> arg3, string? name = null)
        {
            return en.Execute("GeneralizedLinearModelFit[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///constructs a generalized linear model from the design matrix m and response vector v.
        ///https://reference.wolfram.com/language/ref/GeneralizedLinearModelFit.html
        ///</summary>
        public static Engine GeneralizedLinearModelFit(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeneralizedLinearModelFit[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///randomly generates a PrivateKey and corresponding PublicKey object for use with public-key cryptographic functions.
        ///https://reference.wolfram.com/language/ref/GenerateAsymmetricKeyPair.html
        ///</summary>
        public static Engine GenerateAsymmetricKeyPair(this Engine en, string? name = null)
        {
            return en.Execute("GenerateAsymmetricKeyPair[]", name);
        }

        ///<summary>
        ///randomly generates private and public keys of the specified type.
        ///https://reference.wolfram.com/language/ref/GenerateAsymmetricKeyPair.html
        ///</summary>
        public static Engine GenerateAsymmetricKeyPair(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenerateAsymmetricKeyPair[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a DerivedKey object from the password given.
        ///https://reference.wolfram.com/language/ref/GenerateDerivedKey.html
        ///</summary>
        public static Engine GenerateDerivedKey(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenerateDerivedKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a DerivedKey object from the password and salt given.
        ///https://reference.wolfram.com/language/ref/GenerateDerivedKey.html
        ///</summary>
        public static Engine GenerateDerivedKey(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GenerateDerivedKey[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a digital signature for expr using the specified private key.
        ///https://reference.wolfram.com/language/ref/GenerateDigitalSignature.html
        ///</summary>
        public static Engine GenerateDigitalSignature(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GenerateDigitalSignature[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of GenerateDigitalSignature that can be applied to expressions.
        ///https://reference.wolfram.com/language/ref/GenerateDigitalSignature.html
        ///</summary>
        public static Engine GenerateDigitalSignature(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenerateDigitalSignature[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a document by evaluating all template elements in the notebook nb.
        ///https://reference.wolfram.com/language/ref/GenerateDocument.html
        ///</summary>
        public static Engine GenerateDocument(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenerateDocument[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a document using args to fill template slots.
        ///https://reference.wolfram.com/language/ref/GenerateDocument.html
        ///</summary>
        public static Engine GenerateDocument(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GenerateDocument[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses args to fill template slots and puts the result in output.
        ///https://reference.wolfram.com/language/ref/GenerateDocument.html
        ///</summary>
        public static Engine GenerateDocument(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GenerateDocument[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a digital signature of file using the specified private key.
        ///https://reference.wolfram.com/language/ref/GenerateFileSignature.html
        ///</summary>
        public static Engine GenerateFileSignature(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GenerateFileSignature[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a digital signature of the specified range of bytes in the file.
        ///https://reference.wolfram.com/language/ref/GenerateFileSignature.html
        ///</summary>
        public static Engine GenerateFileSignature(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GenerateFileSignature[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates digital signatures for each specified filei and rangei.
        ///https://reference.wolfram.com/language/ref/GenerateFileSignature.html
        ///</summary>
        public static Engine GenerateFileSignature(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GenerateFileSignature[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of GenerateFileSignature that can be applied to files.
        ///https://reference.wolfram.com/language/ref/GenerateFileSignature.html
        ///</summary>
        public static Engine GenerateFileSignature(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenerateFileSignature[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the HTTPResponse object that is generated when a cloud object containing expr is requested on the web.
        ///https://reference.wolfram.com/language/ref/GenerateHTTPResponse.html
        ///</summary>
        public static Engine GenerateHTTPResponse(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenerateHTTPResponse[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the response for the HTTP request specified by req.
        ///https://reference.wolfram.com/language/ref/GenerateHTTPResponse.html
        ///</summary>
        public static Engine GenerateHTTPResponse(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GenerateHTTPResponse[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a new anonymous SecuredAuthenticationKey owned by the current user ID.
        ///https://reference.wolfram.com/language/ref/GenerateSecuredAuthenticationKey.html
        ///</summary>
        public static Engine GenerateSecuredAuthenticationKey(this Engine en, string? name = null)
        {
            return en.Execute("GenerateSecuredAuthenticationKey[]", name);
        }

        ///<summary>
        ///generates a new SecuredAuthenticationKey with the specified name owned by the current user ID.
        ///https://reference.wolfram.com/language/ref/GenerateSecuredAuthenticationKey.html
        ///</summary>
        public static Engine GenerateSecuredAuthenticationKey(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenerateSecuredAuthenticationKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///randomly generates a SymmetricKey object suitable for use with cryptographic functions.
        ///https://reference.wolfram.com/language/ref/GenerateSymmetricKey.html
        ///</summary>
        public static Engine GenerateSymmetricKey(this Engine en, string? name = null)
        {
            return en.Execute("GenerateSymmetricKey[]", name);
        }

        ///<summary>
        ///derives a SymmetricKey object from the password string given.
        ///https://reference.wolfram.com/language/ref/GenerateSymmetricKey.html
        ///</summary>
        public static Engine GenerateSymmetricKey(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenerateSymmetricKey[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the generating function in x for the sequence whose n series coefficient is given by the expression expr.
        ///https://reference.wolfram.com/language/ref/GeneratingFunction.html
        ///</summary>
        public static Engine GeneratingFunction(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeneratingFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multidimensional generating function in x1, x2, … whose n1, n2, … coefficient is given by expr.
        ///https://reference.wolfram.com/language/ref/GeneratingFunction.html
        ///</summary>
        public static Engine GeneratingFunction(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GeneratingFunction[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///finds the full-dimensional part of the decomposition of the region represented by the inequalities ineqs into cylindrical parts whose directions correspond to the successive xi, together with any hypersurfaces containing the rest of the region.
        ///https://reference.wolfram.com/language/ref/GenericCylindricalDecomposition.html
        ///</summary>
        public static Engine GenericCylindricalDecomposition(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GenericCylindricalDecomposition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the DNA sequence for the specified gene on the reference human genome.
        ///https://reference.wolfram.com/language/ref/GenomeData.html
        ///</summary>
        public static Engine GenomeData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenomeData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the human gene gene.
        ///https://reference.wolfram.com/language/ref/GenomeData.html
        ///</summary>
        public static Engine GenomeData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GenomeData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the sequence from positions n1 to n2 on chromosome chr in the reference human genome.
        ///https://reference.wolfram.com/language/ref/GenomeData.html
        ///</summary>
        public static Engine GenomeData(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GenomeData[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the positions of exact matches for the DNA sequence seq on the reference human genome.
        ///https://reference.wolfram.com/language/ref/GenomeLookup.html
        ///</summary>
        public static Engine GenomeLookup(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GenomeLookup[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns at most n matches.
        ///https://reference.wolfram.com/language/ref/GenomeLookup.html
        ///</summary>
        public static Engine GenomeLookup(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GenomeLookup[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the antipodal position of location loc.
        ///https://reference.wolfram.com/language/ref/GeoAntipode.html
        ///</summary>
        public static Engine GeoAntipode(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoAntipode[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the area of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoArea.html
        ///</summary>
        public static Engine GeoArea(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoArea[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the boundary line of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundary.html
        ///</summary>
        public static Engine GeoBoundary(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoBoundary[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the geo positions that define the bounding rectangle enclosing the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundingBox.html
        ///</summary>
        public static Engine GeoBoundingBox(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoBoundingBox[" + arg0 + "]", name);
        }

        ///<summary>
        ///pads the region on all sides by an amount δ.
        ///https://reference.wolfram.com/language/ref/GeoBoundingBox.html
        ///</summary>
        public static Engine GeoBoundingBox(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoBoundingBox[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the ranges of latitudes and longitudes in the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBounds.html
        ///</summary>
        public static Engine GeoBounds(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoBounds[" + arg0 + "]", name);
        }

        ///<summary>
        ///pads ranges of latitudes and longitudes by ±δ.
        ///https://reference.wolfram.com/language/ref/GeoBounds.html
        ///</summary>
        public static Engine GeoBounds(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoBounds[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents a geo region bounded by parallels latmin, latmax and meridians lonmin, lonmax on the surface of the Earth.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegion.html
        ///</summary>
        public static Engine GeoBoundsRegion(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeoBoundsRegion[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents the latitude-longitude bounding box of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegion.html
        ///</summary>
        public static Engine GeoBoundsRegion(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoBoundsRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///pads the ranges of latitudes and longitudes by ±δ.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegion.html
        ///</summary>
        public static Engine GeoBoundsRegion(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoBoundsRegion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a one-dimensional GeoGraphics primitive that represents the boundary of the region between parallels latmin, latmax and meridians lonmin, lonmax on the surface of the Earth.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegionBoundary.html
        ///</summary>
        public static Engine GeoBoundsRegionBoundary(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeoBoundsRegionBoundary[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents the boundary of the latitude-longitude bounding box of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegionBoundary.html
        ///</summary>
        public static Engine GeoBoundsRegionBoundary(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoBoundsRegionBoundary[" + arg0 + "]", name);
        }

        ///<summary>
        ///pads the ranges of latitudes and longitudes by ±δ.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegionBoundary.html
        ///</summary>
        public static Engine GeoBoundsRegionBoundary(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoBoundsRegionBoundary[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes a geo bubble chart with bubbles centered at the geographic regions regi with sizes vali.
        ///https://reference.wolfram.com/language/ref/GeoBubbleChart.html
        ///</summary>
        public static Engine GeoBubbleChart(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoBubbleChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses a collection of regions regi from regions with corresponding sizes vali from values.
        ///https://reference.wolfram.com/language/ref/GeoBubbleChart.html
        ///</summary>
        public static Engine GeoBubbleChart(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoBubbleChart[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents a circle of radius r centered at the location loc on the surface of the Earth.
        ///https://reference.wolfram.com/language/ref/GeoCircle.html
        ///</summary>
        public static Engine GeoCircle(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoCircle[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a sector of a circle from bearing α1 to bearing α2.
        ///https://reference.wolfram.com/language/ref/GeoCircle.html
        ///</summary>
        public static Engine GeoCircle(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GeoCircle[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///makes a geo contour plot from values vali defined at specified locations loci.
        ///https://reference.wolfram.com/language/ref/GeoContourPlot.html
        ///</summary>
        public static Engine GeoContourPlot(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoContourPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses a collection of locations locs with corresponding values vals.
        ///https://reference.wolfram.com/language/ref/GeoContourPlot.html
        ///</summary>
        public static Engine GeoContourPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoContourPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///makes a geo density plot with colors at the location loci determined by the value vali.
        ///https://reference.wolfram.com/language/ref/GeoDensityPlot.html
        ///</summary>
        public static Engine GeoDensityPlot(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoDensityPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses a collection of locations locs with corresponding values vals.
        ///https://reference.wolfram.com/language/ref/GeoDensityPlot.html
        ///</summary>
        public static Engine GeoDensityPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoDensityPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the fixed point of the geodesic erosion of the marker constrained by the mask.
        ///https://reference.wolfram.com/language/ref/GeodesicErosion.html
        ///</summary>
        public static Engine GeodesicErosion(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeodesicErosion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the geodesic opening of image with respect to the structuring element ker.
        ///https://reference.wolfram.com/language/ref/GeodesicOpening.html
        ///</summary>
        public static Engine GeodesicOpening(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeodesicOpening[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the order‐n geodesic polyhedron.
        ///https://reference.wolfram.com/language/ref/GeodesicPolyhedron.html
        ///</summary>
        public static Engine GeodesicPolyhedron(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeodesicPolyhedron[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the order‐n geodesic polyhedron based on the polyhedron "poly".
        ///https://reference.wolfram.com/language/ref/GeodesicPolyhedron.html
        ///</summary>
        public static Engine GeodesicPolyhedron(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeodesicPolyhedron[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the end position of the geodesic of length d starting from loc with azimuthal direction α.
        ///https://reference.wolfram.com/language/ref/GeoDestination.html
        ///</summary>
        public static Engine GeoDestination(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeoDestination[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for a named geodetic datum or reference ellipsoid.
        ///https://reference.wolfram.com/language/ref/GeodesyData.html
        ///</summary>
        public static Engine GeodesyData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeodesyData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the property for the ellipsoid with semimajor axis a and semiminor axis b.
        ///https://reference.wolfram.com/language/ref/GeodesyData.html
        ///</summary>
        public static Engine GeodesyData(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeodesyData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the property at the specified coordinates.
        ///https://reference.wolfram.com/language/ref/GeodesyData.html
        ///</summary>
        public static Engine GeodesyData(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeodesyData[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the azimuthal direction from one latitude-longitude position on the Earth to another.
        ///https://reference.wolfram.com/language/ref/GeoDirection.html
        ///</summary>
        public static Engine GeoDirection(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeoDirection[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the azimuthal direction between locations specified by position objects or geographic entities.
        ///https://reference.wolfram.com/language/ref/GeoDirection.html
        ///</summary>
        public static Engine GeoDirection(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoDirection[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents a filled disk of radius r centered at the location loc on the surface of the Earth.
        ///https://reference.wolfram.com/language/ref/GeoDisk.html
        ///</summary>
        public static Engine GeoDisk(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoDisk[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a sector of a disk from bearing α1 to bearing α2.
        ///https://reference.wolfram.com/language/ref/GeoDisk.html
        ///</summary>
        public static Engine GeoDisk(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GeoDisk[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///represents a geodesic displacement of length dist and initial bearing α from a geo location.
        ///https://reference.wolfram.com/language/ref/GeoDisplacement.html
        ///</summary>
        public static Engine GeoDisplacement(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoDisplacement[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a displacement of length dist and initial bearing α along a path of type pathtype.
        ///https://reference.wolfram.com/language/ref/GeoDisplacement.html
        ///</summary>
        public static Engine GeoDisplacement(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoDisplacement[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the displacement needed to reach loc2 from loc1 along a path of type pathtype.
        ///https://reference.wolfram.com/language/ref/GeoDisplacement.html
        ///</summary>
        public static Engine GeoDisplacement(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoDisplacement[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the geodesic distance between latitude-longitude positions on the Earth.
        ///https://reference.wolfram.com/language/ref/GeoDistance.html
        ///</summary>
        public static Engine GeoDistance(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeoDistance[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the distance between locations specified by position objects or geographical entities.
        ///https://reference.wolfram.com/language/ref/GeoDistance.html
        ///</summary>
        public static Engine GeoDistance(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the total distance from loc1 to locn through all the intermediate loci.
        ///https://reference.wolfram.com/language/ref/GeoDistance.html
        ///</summary>
        public static Engine GeoDistance(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoDistance[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///returns the list of geodesic distances between consecutive pairs of locations.
        ///https://reference.wolfram.com/language/ref/GeoDistanceList.html
        ///</summary>
        public static Engine GeoDistanceList(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoDistanceList[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the elevation above sea level at $GeoLocation.
        ///https://reference.wolfram.com/language/ref/GeoElevationData.html
        ///</summary>
        public static Engine GeoElevationData(this Engine en, string? name = null)
        {
            return en.Execute("GeoElevationData[]", name);
        }

        ///<summary>
        ///gives the elevation at the geographic location loc.
        ///https://reference.wolfram.com/language/ref/GeoElevationData.html
        ///</summary>
        public static Engine GeoElevationData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoElevationData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an array of elevation values within the bounding box given by {loc1,loc2}.
        ///https://reference.wolfram.com/language/ref/GeoElevationData.html
        ///</summary>
        public static Engine GeoElevationData(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoElevationData[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the elevation of type etype for the location loc.
        ///https://reference.wolfram.com/language/ref/GeoElevationData.html
        ///</summary>
        public static Engine GeoElevationData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoElevationData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the elevation in the specified format.
        ///https://reference.wolfram.com/language/ref/GeoElevationData.html
        ///</summary>
        public static Engine GeoElevationData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoElevationData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a list of the geographic entities of type enttype contained in the extended region reg.
        ///https://reference.wolfram.com/language/ref/GeoEntities.html
        ///</summary>
        public static Engine GeoEntities(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoEntities[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a two-dimensional geographical image.
        ///https://reference.wolfram.com/language/ref/GeoGraphics.html
        ///</summary>
        public static Engine GeoGraphics(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoGraphics[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a plot of the geographic graph with edges ei.
        ///https://reference.wolfram.com/language/ref/GeoGraphPlot.html
        ///</summary>
        public static Engine GeoGraphPlot(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoGraphPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a plot with vertices vi and edges ej.
        ///https://reference.wolfram.com/language/ref/GeoGraphPlot.html
        ///</summary>
        public static Engine GeoGraphPlot(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeoGraphPlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///displays the graph g with vertices at geographic locations on a map.
        ///https://reference.wolfram.com/language/ref/GeoGraphPlot.html
        ///</summary>
        public static Engine GeoGraphPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoGraphPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots the flows between geo locations.
        ///https://reference.wolfram.com/language/ref/GeoGraphValuePlot.html
        ///</summary>
        public static Engine GeoGraphValuePlot(this Engine en, List<string> arg0, List<string> arg1, string arg2, List<string> arg3, string? name = null)
        {
            return en.Execute("GeoGraphValuePlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///plots the values vali for the edges ei.
        ///https://reference.wolfram.com/language/ref/GeoGraphValuePlot.html
        ///</summary>
        public static Engine GeoGraphValuePlot(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeoGraphValuePlot[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///plots the flow for a graph g with associated edge weights.
        ///https://reference.wolfram.com/language/ref/GeoGraphValuePlot.html
        ///</summary>
        public static Engine GeoGraphValuePlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoGraphValuePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the gravitational field data for the current location.
        ///https://reference.wolfram.com/language/ref/GeogravityModelData.html
        ///</summary>
        public static Engine GeogravityModelData(this Engine en, string? name = null)
        {
            return en.Execute("GeogravityModelData[]", name);
        }

        ///<summary>
        ///returns the gravitational field data for a location.
        ///https://reference.wolfram.com/language/ref/GeogravityModelData.html
        ///</summary>
        public static Engine GeogravityModelData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeogravityModelData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the component of the gravitational field.
        ///https://reference.wolfram.com/language/ref/GeogravityModelData.html
        ///</summary>
        public static Engine GeogravityModelData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeogravityModelData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the difference between the angle from north to direction β on the geo grid obtained with projection proj and the actual angle from north to direction β at location loc.
        ///https://reference.wolfram.com/language/ref/GeoGridDirectionDifference.html
        ///</summary>
        public static Engine GeoGridDirectionDifference(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoGridDirectionDifference[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a point {x,y} in a planimetric cartographic grid using the projection proj.
        ///https://reference.wolfram.com/language/ref/GeoGridPosition.html
        ///</summary>
        public static Engine GeoGridPosition(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoGridPosition[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an array of cartographic grid positions.
        ///https://reference.wolfram.com/language/ref/GeoGridPosition.html
        ///</summary>
        public static Engine GeoGridPosition(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoGridPosition[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a point in a cartographic grid obtained by projection from data in the given datum.
        ///https://reference.wolfram.com/language/ref/GeoGridPosition.html
        ///</summary>
        public static Engine GeoGridPosition(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoGridPosition[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the cartographic grid position of the specified geographical entity.
        ///https://reference.wolfram.com/language/ref/GeoGridPosition.html
        ///</summary>
        public static Engine GeoGridPosition(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoGridPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the actual geo area corresponding to a unit area on the geo grid obtained with projection proj, evaluated in the limit of small geo regions around location loc.
        ///https://reference.wolfram.com/language/ref/GeoGridUnitArea.html
        ///</summary>
        public static Engine GeoGridUnitArea(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoGridUnitArea[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the actual geo distance corresponding to a unit distance on the geo grid obtained with projection proj, evaluated in the limit of small displacement from location loc in direction α.
        ///https://reference.wolfram.com/language/ref/GeoGridUnitDistance.html
        ///</summary>
        public static Engine GeoGridUnitDistance(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoGridUnitDistance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a horizontal two-dimensional vector of components vx, vy in the orthonormal frame of the coordinates of the geo projection proj, at geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoGridVector.html
        ///</summary>
        public static Engine GeoGridVector(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoGridVector[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a collection of vectors veci at respective geo locations loci.
        ///https://reference.wolfram.com/language/ref/GeoGridVector.html
        ///</summary>
        public static Engine GeoGridVector(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoGridVector[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a list of geographic objects to be treated as a single object for certain operations.
        ///https://reference.wolfram.com/language/ref/GeoGroup.html
        ///</summary>
        public static Engine GeoGroup(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoGroup[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents the half of the Earth centered at your current geo location.
        ///https://reference.wolfram.com/language/ref/GeoHemisphere.html
        ///</summary>
        public static Engine GeoHemisphere(this Engine en, string? name = null)
        {
            return en.Execute("GeoHemisphere[]", name);
        }

        ///<summary>
        ///represents the half of the Earth centered at the location loc.
        ///https://reference.wolfram.com/language/ref/GeoHemisphere.html
        ///</summary>
        public static Engine GeoHemisphere(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoHemisphere[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a one-dimensional GeoGraphics primitive that represents the boundary line of a hemisphere of the Earth centered at the current geo location.
        ///https://reference.wolfram.com/language/ref/GeoHemisphereBoundary.html
        ///</summary>
        public static Engine GeoHemisphereBoundary(this Engine en, string? name = null)
        {
            return en.Execute("GeoHemisphereBoundary[]", name);
        }

        ///<summary>
        ///represents the boundary line of a hemisphere centered at the location loc.
        ///https://reference.wolfram.com/language/ref/GeoHemisphereBoundary.html
        ///</summary>
        public static Engine GeoHemisphereBoundary(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoHemisphereBoundary[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots a density histogram of the geographic locations locs.
        ///https://reference.wolfram.com/language/ref/GeoHistogram.html
        ///</summary>
        public static Engine GeoHistogram(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoHistogram[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots a density histogram with bins specified by bspec.
        ///https://reference.wolfram.com/language/ref/GeoHistogram.html
        ///</summary>
        public static Engine GeoHistogram(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoHistogram[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots a density histogram with bin densities computed according to the specification hspec.
        ///https://reference.wolfram.com/language/ref/GeoHistogram.html
        ///</summary>
        public static Engine GeoHistogram(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoHistogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///identifies the geographic entities of the type enttype in which the current geo location is contained.
        ///https://reference.wolfram.com/language/ref/GeoIdentify.html
        ///</summary>
        public static Engine GeoIdentify(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoIdentify[" + arg0 + "]", name);
        }

        ///<summary>
        ///identifies the entities in which the location loc is contained.
        ///https://reference.wolfram.com/language/ref/GeoIdentify.html
        ///</summary>
        public static Engine GeoIdentify(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoIdentify[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///identifies the entities of any type in which the current geo location is contained.
        ///https://reference.wolfram.com/language/ref/GeoIdentify.html
        ///</summary>
        public static Engine GeoIdentify(this Engine en, string? name = null)
        {
            return en.Execute("GeoIdentify[]", name);
        }

        ///<summary>
        ///gives a satellite image of the geo region reg.
        ///https://reference.wolfram.com/language/ref/GeoImage.html
        ///</summary>
        public static Engine GeoImage(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoImage[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives an image of the geo region reg with style mapstyle.
        ///https://reference.wolfram.com/language/ref/GeoImage.html
        ///</summary>
        public static Engine GeoImage(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoImage[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the length of the geo path g.
        ///https://reference.wolfram.com/language/ref/GeoLength.html
        ///</summary>
        public static Engine GeoLength(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoLength[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a map on which the locations loci are indicated.
        ///https://reference.wolfram.com/language/ref/GeoListPlot.html
        ///</summary>
        public static Engine GeoListPlot(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoListPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the geological period entity.
        ///https://reference.wolfram.com/language/ref/GeologicalPeriodData.html
        ///</summary>
        public static Engine GeologicalPeriodData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeologicalPeriodData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of property values for the specified period name entities.
        ///https://reference.wolfram.com/language/ref/GeologicalPeriodData.html
        ///</summary>
        public static Engine GeologicalPeriodData(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeologicalPeriodData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified annotation associated with the given property.
        ///https://reference.wolfram.com/language/ref/GeologicalPeriodData.html
        ///</summary>
        public static Engine GeologicalPeriodData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeologicalPeriodData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the current magnetic field data for the current location.
        ///https://reference.wolfram.com/language/ref/GeomagneticModelData.html
        ///</summary>
        public static Engine GeomagneticModelData(this Engine en, string? name = null)
        {
            return en.Execute("GeomagneticModelData[]", name);
        }

        ///<summary>
        ///returns the current magnetic field data for a location.
        ///https://reference.wolfram.com/language/ref/GeomagneticModelData.html
        ///</summary>
        public static Engine GeomagneticModelData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeomagneticModelData[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the magnetic field data for the specified time and location.
        ///https://reference.wolfram.com/language/ref/GeomagneticModelData.html
        ///</summary>
        public static Engine GeomagneticModelData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeomagneticModelData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the component of the magnetic field for the specified time and location.
        ///https://reference.wolfram.com/language/ref/GeomagneticModelData.html
        ///</summary>
        public static Engine GeomagneticModelData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeomagneticModelData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents a marker at the current $GeoLocation.
        ///https://reference.wolfram.com/language/ref/GeoMarker.html
        ///</summary>
        public static Engine GeoMarker(this Engine en, string? name = null)
        {
            return en.Execute("GeoMarker[]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents a marker at the location loc.
        ///https://reference.wolfram.com/language/ref/GeoMarker.html
        ///</summary>
        public static Engine GeoMarker(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoMarker[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents markers at locations loci.
        ///https://reference.wolfram.com/language/ref/GeoMarker.html
        ///</summary>
        public static Engine GeoMarker(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoMarker[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents a custom marker at the location loc.
        ///https://reference.wolfram.com/language/ref/GeoMarker.html
        ///</summary>
        public static Engine GeoMarker(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoMarker[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents custom markers at locations loci.
        ///https://reference.wolfram.com/language/ref/GeoMarker.html
        ///</summary>
        public static Engine GeoMarker(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoMarker[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the assertion that the geometric object obj satisfies prop.
        ///https://reference.wolfram.com/language/ref/GeometricAssertion.html
        ///</summary>
        public static Engine GeometricAssertion(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeometricAssertion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the assertion that the obji satisfy prop.
        ///https://reference.wolfram.com/language/ref/GeometricAssertion.html
        ///</summary>
        public static Engine GeometricAssertion(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeometricAssertion[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the assertion that objs satisfies each of the propi.
        ///https://reference.wolfram.com/language/ref/GeometricAssertion.html
        ///</summary>
        public static Engine GeometricAssertion(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("GeometricAssertion[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents a geometric Brownian motion process with drift μ, volatility σ, and initial value x0.
        ///https://reference.wolfram.com/language/ref/GeometricBrownianMotionProcess.html
        ///</summary>
        public static Engine GeometricBrownianMotionProcess(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeometricBrownianMotionProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a geometric distribution with probability parameter p.
        ///https://reference.wolfram.com/language/ref/GeometricDistribution.html
        ///</summary>
        public static Engine GeometricDistribution(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeometricDistribution[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the geometric mean of the values in list.
        ///https://reference.wolfram.com/language/ref/GeometricMean.html
        ///</summary>
        public static Engine GeometricMean(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeometricMean[" + arg0 + "]", name);
        }

        ///<summary>
        ///filters data by replacing every value by the geometric mean value in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/GeometricMeanFilter.html
        ///</summary>
        public static Engine GeometricMeanFilter(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeometricMeanFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses ri for filtering the dimension in data.
        ///https://reference.wolfram.com/language/ref/GeometricMeanFilter.html
        ///</summary>
        public static Engine GeometricMeanFilter(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeometricMeanFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds positive values of variables vars that minimize the posynomial objective subject to posynomial constraints cons.
        ///https://reference.wolfram.com/language/ref/GeometricOptimization.html
        ///</summary>
        public static Engine GeometricOptimization(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeometricOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///finds the positive vector x=y that minimizes  subject to inequality constraints  and linear equality constraints .
        ///https://reference.wolfram.com/language/ref/GeometricOptimization.html
        ///</summary>
        public static Engine GeometricOptimization(this Engine en, List<string> arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GeometricOptimization[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///specifies what solution property "prop" should be returned.
        ///https://reference.wolfram.com/language/ref/GeometricOptimization.html
        ///</summary>
        public static Engine GeometricOptimization(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeometricOptimization[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an abstract 2D geometric scene defined by the hypotheses hypi in terms of the symbolic points pi.
        ///https://reference.wolfram.com/language/ref/GeometricScene.html
        ///</summary>
        public static Engine GeometricScene(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeometricScene[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///represents a scene whose hypotheses depend on the symbolic scalar quantities ki.
        ///https://reference.wolfram.com/language/ref/GeometricScene.html
        ///</summary>
        public static Engine GeometricScene(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GeometricScene[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a scene together with some conclusions coni about it.
        ///https://reference.wolfram.com/language/ref/GeometricScene.html
        ///</summary>
        public static Engine GeometricScene(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GeometricScene[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///combines several scene instances into one scene object.
        ///https://reference.wolfram.com/language/ref/GeometricScene.html
        ///</summary>
        public static Engine GeometricScene(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeometricScene[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a symbolic representation of a step in the definition of a geometric scene, in which the hypotheses hypi are introduced.
        ///https://reference.wolfram.com/language/ref/GeometricStep.html
        ///</summary>
        public static Engine GeometricStep(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeometricStep[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///labels the step with label when displaying an instance of the geometric scene.
        ///https://reference.wolfram.com/language/ref/GeometricStep.html
        ///</summary>
        public static Engine GeometricStep(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeometricStep[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the geometric object obj satisfies prop.
        ///https://reference.wolfram.com/language/ref/GeometricTest.html
        ///</summary>
        public static Engine GeometricTest(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeometricTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the obji satisfy prop.
        ///https://reference.wolfram.com/language/ref/GeometricTest.html
        ///</summary>
        public static Engine GeometricTest(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeometricTest[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether objs satisfy each of the propi.
        ///https://reference.wolfram.com/language/ref/GeometricTest.html
        ///</summary>
        public static Engine GeometricTest(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("GeometricTest[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///represents the result of applying the transformation function tfun to the geometric objects corresponding to the primitives g.
        ///https://reference.wolfram.com/language/ref/GeometricTransformation.html
        ///</summary>
        public static Engine GeometricTransformation(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeometricTransformation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///effectively replaces every point r by m.r+v.
        ///https://reference.wolfram.com/language/ref/GeometricTransformation.html
        ///</summary>
        public static Engine GeometricTransformation(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GeometricTransformation[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the geographic entity of type enttype closest to the geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoNearest.html
        ///</summary>
        public static Engine GeoNearest(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoNearest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the nearest of the regi.
        ///https://reference.wolfram.com/language/ref/GeoNearest.html
        ///</summary>
        public static Engine GeoNearest(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoNearest[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns n nearest values.
        ///https://reference.wolfram.com/language/ref/GeoNearest.html
        ///</summary>
        public static Engine GeoNearest(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoNearest[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns up to n matches within a radius r of loc.
        ///https://reference.wolfram.com/language/ref/GeoNearest.html
        ///</summary>
        public static Engine GeoNearest(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GeoNearest[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives the value of the property prop about the orientation of the Earth on the given date.
        ///https://reference.wolfram.com/language/ref/GeoOrientationData.html
        ///</summary>
        public static Engine GeoOrientationData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoOrientationData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the specified variant of the property prop on the given date.
        ///https://reference.wolfram.com/language/ref/GeoOrientationData.html
        ///</summary>
        public static Engine GeoOrientationData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoOrientationData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents a path of type pathtype between locations loc1 and loc2.
        ///https://reference.wolfram.com/language/ref/GeoPath.html
        ///</summary>
        public static Engine GeoPath(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoPath[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a disjoint collection of paths of type pathtype.
        ///https://reference.wolfram.com/language/ref/GeoPath.html
        ///</summary>
        public static Engine GeoPath(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoPath[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents a filled polygon whose boundary is formed by geodesic segments between locations loci and loci+1.
        ///https://reference.wolfram.com/language/ref/GeoPolygon.html
        ///</summary>
        public static Engine GeoPolygon(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoPolygon[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///specifies which of the two sides of each boundary polyi is in the interior of the geo polygon.
        ///https://reference.wolfram.com/language/ref/GeoPolygon.html
        ///</summary>
        public static Engine GeoPolygon(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoPolygon[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a geo polygon whose boundary is formed by geo paths of type pathtype.
        ///https://reference.wolfram.com/language/ref/GeoPolygon.html
        ///</summary>
        public static Engine GeoPolygon(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoPolygon[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a geodetic position with latitude lat and longitude lon.
        ///https://reference.wolfram.com/language/ref/GeoPosition.html
        ///</summary>
        public static Engine GeoPosition(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoPosition[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a geodetic position referring to the specified datum.
        ///https://reference.wolfram.com/language/ref/GeoPosition.html
        ///</summary>
        public static Engine GeoPosition(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoPosition[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an array of geodetic positions.
        ///https://reference.wolfram.com/language/ref/GeoPosition.html
        ///</summary>
        public static Engine GeoPosition(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoPosition[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the geodetic position of the specified geographical entity.
        ///https://reference.wolfram.com/language/ref/GeoPosition.html
        ///</summary>
        public static Engine GeoPosition(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoPosition[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a position with local Cartesian coordinates {east,north,up} in a reference system centered at the position p.
        ///https://reference.wolfram.com/language/ref/GeoPositionENU.html
        ///</summary>
        public static Engine GeoPositionENU(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoPositionENU[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an array of positions.
        ///https://reference.wolfram.com/language/ref/GeoPositionENU.html
        ///</summary>
        public static Engine GeoPositionENU(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoPositionENU[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the Cartesian position with respect to p of the specified geographical entity.
        ///https://reference.wolfram.com/language/ref/GeoPositionENU.html
        ///</summary>
        public static Engine GeoPositionENU(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoPositionENU[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a position in a Cartesian geocentric coordinate system.
        ///https://reference.wolfram.com/language/ref/GeoPositionXYZ.html
        ///</summary>
        public static Engine GeoPositionXYZ(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoPositionXYZ[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a point referred to the specified datum.
        ///https://reference.wolfram.com/language/ref/GeoPositionXYZ.html
        ///</summary>
        public static Engine GeoPositionXYZ(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoPositionXYZ[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an array of points in a Cartesian geocentric coordinate system.
        ///https://reference.wolfram.com/language/ref/GeoPositionXYZ.html
        ///</summary>
        public static Engine GeoPositionXYZ(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoPositionXYZ[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the Cartesian geocentric position of the given geographical entity.
        ///https://reference.wolfram.com/language/ref/GeoPositionXYZ.html
        ///</summary>
        public static Engine GeoPositionXYZ(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoPositionXYZ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for the specified cartographic projection.
        ///https://reference.wolfram.com/language/ref/GeoProjectionData.html
        ///</summary>
        public static Engine GeoProjectionData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoProjectionData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the complete options for the default form of the specified projection.
        ///https://reference.wolfram.com/language/ref/GeoProjectionData.html
        ///</summary>
        public static Engine GeoProjectionData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoProjectionData[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot in which the geographic regions regi are colored according to the values vali.
        ///https://reference.wolfram.com/language/ref/GeoRegionValuePlot.html
        ///</summary>
        public static Engine GeoRegionValuePlot(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoRegionValuePlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///uses a collection of regions regi from regions with corresponding values vali from values.
        ///https://reference.wolfram.com/language/ref/GeoRegionValuePlot.html
        ///</summary>
        public static Engine GeoRegionValuePlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoRegionValuePlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots a smooth kernel histogram of the geo locations locs.
        ///https://reference.wolfram.com/language/ref/GeoSmoothHistogram.html
        ///</summary>
        public static Engine GeoSmoothHistogram(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoSmoothHistogram[" + arg0 + "]", name);
        }

        ///<summary>
        ///plots a smooth kernel histogram with estimator specification espec.
        ///https://reference.wolfram.com/language/ref/GeoSmoothHistogram.html
        ///</summary>
        public static Engine GeoSmoothHistogram(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoSmoothHistogram[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///plots the distribution function dfun.
        ///https://reference.wolfram.com/language/ref/GeoSmoothHistogram.html
        ///</summary>
        public static Engine GeoSmoothHistogram(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GeoSmoothHistogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a stream plot from the field of geo vectors vecs.
        ///https://reference.wolfram.com/language/ref/GeoStreamPlot.html
        ///</summary>
        public static Engine GeoStreamPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoStreamPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a separate set of streams for each vecsi.
        ///https://reference.wolfram.com/language/ref/GeoStreamPlot.html
        ///</summary>
        public static Engine GeoStreamPlot(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoStreamPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///displays faces of polygons and other filled geo objects using mapstyle.
        ///https://reference.wolfram.com/language/ref/GeoStyling.html
        ///</summary>
        public static Engine GeoStyling(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoStyling[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses mapstyle with the given graphics directive applied.
        ///https://reference.wolfram.com/language/ref/GeoStyling.html
        ///</summary>
        public static Engine GeoStyling(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoStyling[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a geographic object obj with qualifier qual.
        ///https://reference.wolfram.com/language/ref/GeoVariant.html
        ///</summary>
        public static Engine GeoVariant(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoVariant[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a horizontal two-dimensional vector of magnitude m and bearing α at geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoVector.html
        ///</summary>
        public static Engine GeoVector(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoVector[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a collection of vectors veci at respective geo locations loci.
        ///https://reference.wolfram.com/language/ref/GeoVector.html
        ///</summary>
        public static Engine GeoVector(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoVector[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a horizontal two-dimensional vector of components ve and vn in an orthonormal frame tangent to the Earth at geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoVectorENU.html
        ///</summary>
        public static Engine GeoVectorENU(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoVectorENU[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a collection of vectors veci at respective geo locations loci.
        ///https://reference.wolfram.com/language/ref/GeoVectorENU.html
        ///</summary>
        public static Engine GeoVectorENU(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoVectorENU[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a vector plot from the field of geo vectors vecs.
        ///https://reference.wolfram.com/language/ref/GeoVectorPlot.html
        ///</summary>
        public static Engine GeoVectorPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoVectorPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a separate set of vectors for each vecsi.
        ///https://reference.wolfram.com/language/ref/GeoVectorPlot.html
        ///</summary>
        public static Engine GeoVectorPlot(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoVectorPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a three-dimensional vector of Cartesian components vX, vY, vZ in an orthonormal frame parallel to the geocentric frame, at location loc.
        ///https://reference.wolfram.com/language/ref/GeoVectorXYZ.html
        ///</summary>
        public static Engine GeoVectorXYZ(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoVectorXYZ[" + arg0 + "]", name);
        }

        ///<summary>
        ///represents a collection of vectors veci at respective geo locations loci.
        ///https://reference.wolfram.com/language/ref/GeoVectorXYZ.html
        ///</summary>
        public static Engine GeoVectorXYZ(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoVectorXYZ[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents the region on the surface of the Earth visible from the point of coordinates lat,lon and height h above the reference ellipsoid.
        ///https://reference.wolfram.com/language/ref/GeoVisibleRegion.html
        ///</summary>
        public static Engine GeoVisibleRegion(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoVisibleRegion[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the region visible from the position pos.
        ///https://reference.wolfram.com/language/ref/GeoVisibleRegion.html
        ///</summary>
        public static Engine GeoVisibleRegion(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoVisibleRegion[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a one-dimensional GeoGraphics primitive that represents the boundary of the region on the surface of the Earth visible from the point of coordinates lat,lon and height h above the reference ellipsoid.
        ///https://reference.wolfram.com/language/ref/GeoVisibleRegionBoundary.html
        ///</summary>
        public static Engine GeoVisibleRegionBoundary(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GeoVisibleRegionBoundary[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents the boundary of the region visible from the position pos.
        ///https://reference.wolfram.com/language/ref/GeoVisibleRegionBoundary.html
        ///</summary>
        public static Engine GeoVisibleRegionBoundary(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoVisibleRegionBoundary[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns True if the location loc is contained within the region reg, and False otherwise.
        ///https://reference.wolfram.com/language/ref/GeoWithinQ.html
        ///</summary>
        public static Engine GeoWithinQ(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GeoWithinQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an operator form of GeoWithinQ that can be applied to a location.
        ///https://reference.wolfram.com/language/ref/GeoWithinQ.html
        ///</summary>
        public static Engine GeoWithinQ(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GeoWithinQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as expr, evaluating funi[value,velocity] whenever "gesturei" occurs within the screen space occupied by expr.
        ///https://reference.wolfram.com/language/ref/GestureHandler.html
        ///</summary>
        public static Engine GestureHandler(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GestureHandler[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the setting corresponding to the variable "var" in the operating system environment.
        ///https://reference.wolfram.com/language/ref/GetEnvironment.html
        ///</summary>
        public static Engine GetEnvironment(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GetEnvironment[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of rules, corresponding to specified environment variables.
        ///https://reference.wolfram.com/language/ref/GetEnvironment.html
        ///</summary>
        public static Engine GetEnvironment(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GetEnvironment[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives information about all existing settings in the operating system environment.
        ///https://reference.wolfram.com/language/ref/GetEnvironment.html
        ///</summary>
        public static Engine GetEnvironment(this Engine en, string? name = null)
        {
            return en.Execute("GetEnvironment[]", name);
        }

        ///<summary>
        ///represents a Gibbs point process with density μ and pair-potential function ϕ in .
        ///https://reference.wolfram.com/language/ref/GibbsPointProcess.html
        ///</summary>
        public static Engine GibbsPointProcess(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GibbsPointProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the global clustering coefficient of the graph g.
        ///https://reference.wolfram.com/language/ref/GlobalClusteringCoefficient.html
        ///</summary>
        public static Engine GlobalClusteringCoefficient(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GlobalClusteringCoefficient[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GlobalClusteringCoefficient.html
        ///</summary>
        public static Engine GlobalClusteringCoefficient(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GlobalClusteringCoefficient[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a Gompertz distribution with scale parameter λ and frailty parameter ξ.
        ///https://reference.wolfram.com/language/ref/GompertzMakehamDistribution.html
        ///</summary>
        public static Engine GompertzMakehamDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GompertzMakehamDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gompertz–Makeham distribution with parameters λ, ξ, θ, and α.
        ///https://reference.wolfram.com/language/ref/GompertzMakehamDistribution.html
        ///</summary>
        public static Engine GompertzMakehamDistribution(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("GompertzMakehamDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///is a three-dimensional graphics directive specifying that surfaces that follow are to be drawn with a warm color facing toward the light and a cool color facing away.
        ///https://reference.wolfram.com/language/ref/GoochShading.html
        ///</summary>
        public static Engine GoochShading(this Engine en, string? name = null)
        {
            return en.Execute("GoochShading[]", name);
        }

        ///<summary>
        ///uses cool and warm colors obtained by blending col with slate Blue and Orange.
        ///https://reference.wolfram.com/language/ref/GoochShading.html
        ///</summary>
        public static Engine GoochShading(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GoochShading[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the cool color ccol and the warm color wcol.
        ///https://reference.wolfram.com/language/ref/GoochShading.html
        ///</summary>
        public static Engine GoochShading(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GoochShading[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Goodman–Kruskal  coefficient for the vectors v1 and v2.
        ///https://reference.wolfram.com/language/ref/GoodmanKruskalGamma.html
        ///</summary>
        public static Engine GoodmanKruskalGamma(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GoodmanKruskalGamma[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Goodman–Kruskal  coefficients for the matrix m.
        ///https://reference.wolfram.com/language/ref/GoodmanKruskalGamma.html
        ///</summary>
        public static Engine GoodmanKruskalGamma(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GoodmanKruskalGamma[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the   coefficient for the multivariate symbolic distribution dist.
        ///https://reference.wolfram.com/language/ref/GoodmanKruskalGamma.html
        ///</summary>
        public static Engine GoodmanKruskalGamma(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GoodmanKruskalGamma[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///tests whether the vectors v1 and v2 are independent.
        ///https://reference.wolfram.com/language/ref/GoodmanKruskalGammaTest.html
        ///</summary>
        public static Engine GoodmanKruskalGammaTest(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GoodmanKruskalGammaTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///scans for Label[tag], and transfers control to that point.
        ///https://reference.wolfram.com/language/ref/Goto.html
        ///</summary>
        public static Engine Goto(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("Goto[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a three‐dimensional graphics directive that specifies that faces of polygons and other filled graphics objects are to be drawn to reflect as a smooth surface using a normal‐vector average shading.
        ///https://reference.wolfram.com/language/ref/GouraudShading.html
        ///</summary>
        public static Engine GouraudShading(this Engine en, string? name = null)
        {
            return en.Execute("GouraudShading[]", name);
        }

        ///<summary>
        ///uses the attenuation factor d for the diffuse light.
        ///https://reference.wolfram.com/language/ref/GouraudShading.html
        ///</summary>
        public static Engine GouraudShading(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GouraudShading[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses the attenuation factor s for the specular light.
        ///https://reference.wolfram.com/language/ref/GouraudShading.html
        ///</summary>
        public static Engine GouraudShading(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GouraudShading[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses the attenuation factor a for the ambient light.
        ///https://reference.wolfram.com/language/ref/GouraudShading.html
        ///</summary>
        public static Engine GouraudShading(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GouraudShading[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the gradient .
        ///https://reference.wolfram.com/language/ref/Grad.html
        ///</summary>
        public static Engine Grad(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("Grad[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the gradient in the coordinates chart.
        ///https://reference.wolfram.com/language/ref/Grad.html
        ///</summary>
        public static Engine Grad(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("Grad[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the magnitude of the gradient of data, computed using discrete derivatives of a Gaussian of sample radius r.
        ///https://reference.wolfram.com/language/ref/GradientFilter.html
        ///</summary>
        public static Engine GradientFilter(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GradientFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a Gaussian with standard deviation σ.
        ///https://reference.wolfram.com/language/ref/GradientFilter.html
        ///</summary>
        public static Engine GradientFilter(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GradientFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives a MeshRegion whose gradient best fits the normals at points p1,p2,….
        ///https://reference.wolfram.com/language/ref/GradientFittedMesh.html
        ///</summary>
        public static Engine GradientFittedMesh(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GradientFittedMesh[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the local orientation parallel to the gradient of data, computed using discrete derivatives of a Gaussian of pixel radius r, returning values between  and .
        ///https://reference.wolfram.com/language/ref/GradientOrientationFilter.html
        ///</summary>
        public static Engine GradientOrientationFilter(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GradientOrientationFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses a Gaussian with standard deviation σ.
        ///https://reference.wolfram.com/language/ref/GradientOrientationFilter.html
        ///</summary>
        public static Engine GradientOrientationFilter(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GradientOrientationFilter[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///attempts to parse input according to the grammar defined by grammar.
        ///https://reference.wolfram.com/language/ref/GrammarApply.html
        ///</summary>
        public static Engine GrammarApply(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GrammarApply[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents grammar rules to be deployed to a cloud object that implements the grammar in a form suitable for use with functions like GrammarApply and Interpreter.
        ///https://reference.wolfram.com/language/ref/GrammarRules.html
        ///</summary>
        public static Engine GrammarRules(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GrammarRules[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses grammar definitions defs.
        ///https://reference.wolfram.com/language/ref/GrammarRules.html
        ///</summary>
        public static Engine GrammarRules(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GrammarRules[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a grammar rules pattern object that represents any input of the specified form.
        ///https://reference.wolfram.com/language/ref/GrammarToken.html
        ///</summary>
        public static Engine GrammarToken(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GrammarToken[" + arg0 + "]", name);
        }

        ///<summary>
        ///yields a graph with edges ej.
        ///https://reference.wolfram.com/language/ref/Graph.html
        ///</summary>
        public static Engine Graph(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("Graph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///yields the graph with vertices vi and edges ej.
        ///https://reference.wolfram.com/language/ref/Graph.html
        ///</summary>
        public static Engine Graph(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("Graph[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields a graph from data.
        ///https://reference.wolfram.com/language/ref/Graph.html
        ///</summary>
        public static Engine Graph(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("Graph[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a graph with vertices and edges from the graph g and represented as a 3D plot.
        ///https://reference.wolfram.com/language/ref/Graph3D.html
        ///</summary>
        public static Engine Graph3D(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("Graph3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a graph with edges ej and represented as a 3D plot.
        ///https://reference.wolfram.com/language/ref/Graph3D.html
        ///</summary>
        public static Engine Graph3D(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("Graph3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///creates a graph with vertices vi and edges ej.
        ///https://reference.wolfram.com/language/ref/Graph3D.html
        ///</summary>
        public static Engine Graph3D(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("Graph3D[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the assortativity coefficient of a graph g using vertex degrees.
        ///https://reference.wolfram.com/language/ref/GraphAssortativity.html
        ///</summary>
        public static Engine GraphAssortativity(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphAssortativity[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the assortativity coefficient of the graph g using vertex property "prop".
        ///https://reference.wolfram.com/language/ref/GraphAssortativity.html
        ///</summary>
        public static Engine GraphAssortativity(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphAssortativity[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the assortativity coefficient of the graph g with respect to the vertex partition {{vi 1,vi 2,…},…}.
        ///https://reference.wolfram.com/language/ref/GraphAssortativity.html
        ///</summary>
        public static Engine GraphAssortativity(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GraphAssortativity[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphAssortativity.html
        ///</summary>
        public static Engine GraphAssortativity(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphAssortativity[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the automorphism group of a graph g.
        ///https://reference.wolfram.com/language/ref/GraphAutomorphismGroup.html
        ///</summary>
        public static Engine GraphAutomorphismGroup(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphAutomorphismGroup[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphAutomorphismGroup.html
        ///</summary>
        public static Engine GraphAutomorphismGroup(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphAutomorphismGroup[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the set of vertices with minimum eccentricity in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphCenter.html
        ///</summary>
        public static Engine GraphCenter(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphCenter[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphCenter.html
        ///</summary>
        public static Engine GraphCenter(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphCenter[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the graph complement of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphComplement.html
        ///</summary>
        public static Engine GraphComplement(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphComplement[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphComplement.html
        ///</summary>
        public static Engine GraphComplement(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphComplement[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a graph with the specified name.
        ///https://reference.wolfram.com/language/ref/GraphData.html
        ///</summary>
        public static Engine GraphData(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphData[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the value of the property for the specified graph entity.
        ///https://reference.wolfram.com/language/ref/GraphData.html
        ///</summary>
        public static Engine GraphData(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph density of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDensity.html
        ///</summary>
        public static Engine GraphDensity(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphDensity[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDensity.html
        ///</summary>
        public static Engine GraphDensity(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphDensity[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the greatest distance between any pair of vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDiameter.html
        ///</summary>
        public static Engine GraphDiameter(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphDiameter[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDiameter.html
        ///</summary>
        public static Engine GraphDiameter(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphDiameter[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the graph difference of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphDifference.html
        ///</summary>
        public static Engine GraphDifference(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphDifference[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDifference.html
        ///</summary>
        public static Engine GraphDifference(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphDifference[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph disjoint union of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphDisjointUnion.html
        ///</summary>
        public static Engine GraphDisjointUnion(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphDisjointUnion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the disjoint union of g1, g2, ….
        ///https://reference.wolfram.com/language/ref/GraphDisjointUnion.html
        ///</summary>
        public static Engine GraphDisjointUnion(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GraphDisjointUnion[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDisjointUnion.html
        ///</summary>
        public static Engine GraphDisjointUnion(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphDisjointUnion[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the distance from source vertex s to target vertex t in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistance.html
        ///</summary>
        public static Engine GraphDistance(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GraphDistance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the distance from s to all vertices of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistance.html
        ///</summary>
        public static Engine GraphDistance(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistance.html
        ///</summary>
        public static Engine GraphDistance(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphDistance[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the matrix of distances between vertices for the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistanceMatrix.html
        ///</summary>
        public static Engine GraphDistanceMatrix(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphDistanceMatrix[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the matrix of distances between vertices of maximal distance d in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistanceMatrix.html
        ///</summary>
        public static Engine GraphDistanceMatrix(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphDistanceMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistanceMatrix.html
        ///</summary>
        public static Engine GraphDistanceMatrix(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphDistanceMatrix[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives coordinates of the vertices of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphEmbedding.html
        ///</summary>
        public static Engine GraphEmbedding(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphEmbedding[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives coordinates of the vertices of the graph g using the embedding "emb".
        ///https://reference.wolfram.com/language/ref/GraphEmbedding.html
        ///</summary>
        public static Engine GraphEmbedding(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphEmbedding[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives coordinates in dimension dim of the vertices of the graph g using the embedding "emb".
        ///https://reference.wolfram.com/language/ref/GraphEmbedding.html
        ///</summary>
        public static Engine GraphEmbedding(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GraphEmbedding[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the set of vertices with maximum vertex degree in the underlying simple graph of g.
        ///https://reference.wolfram.com/language/ref/GraphHub.html
        ///</summary>
        public static Engine GraphHub(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphHub[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the set of vertices with maximum vertex in-degree.
        ///https://reference.wolfram.com/language/ref/GraphHub.html
        ///</summary>
        public static Engine GraphHub(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphHub[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphHub.html
        ///</summary>
        public static Engine GraphHub(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphHub[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a two-dimensional graphical image.
        ///https://reference.wolfram.com/language/ref/Graphics.html
        ///</summary>
        public static Engine Graphics(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("Graphics[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a three-dimensional graphical image.
        ///https://reference.wolfram.com/language/ref/Graphics3D.html
        ///</summary>
        public static Engine Graphics3D(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("Graphics3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a graphic in which the gi are laid out in a column, with g1 above g2, etc.
        ///https://reference.wolfram.com/language/ref/GraphicsColumn.html
        ///</summary>
        public static Engine GraphicsColumn(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphicsColumn[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///aligns each element horizontally in the specified way.
        ///https://reference.wolfram.com/language/ref/GraphicsColumn.html
        ///</summary>
        public static Engine GraphicsColumn(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphicsColumn[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///leaves the specified spacing between successive elements.
        ///https://reference.wolfram.com/language/ref/GraphicsColumn.html
        ///</summary>
        public static Engine GraphicsColumn(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GraphicsColumn[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a graphics complex in which coordinates given as integers i in graphics primitives in data are taken to be pti.
        ///https://reference.wolfram.com/language/ref/GraphicsComplex.html
        ///</summary>
        public static Engine GraphicsComplex(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphicsComplex[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a graphic in which the gij are laid out in a two-dimensional grid.
        ///https://reference.wolfram.com/language/ref/GraphicsGrid.html
        ///</summary>
        public static Engine GraphicsGrid(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphicsGrid[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///represents a collection of graphics objects grouped together for purposes of interactive selection in a notebook.
        ///https://reference.wolfram.com/language/ref/GraphicsGroup.html
        ///</summary>
        public static Engine GraphicsGroup(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphicsGroup[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a graphic in which the gi are laid out in a row.
        ///https://reference.wolfram.com/language/ref/GraphicsRow.html
        ///</summary>
        public static Engine GraphicsRow(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphicsRow[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///leaves the specified spacing between successive elements.
        ///https://reference.wolfram.com/language/ref/GraphicsRow.html
        ///</summary>
        public static Engine GraphicsRow(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphicsRow[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph intersection of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphIntersection.html
        ///</summary>
        public static Engine GraphIntersection(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphIntersection[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph intersection of g1, g2, … .
        ///https://reference.wolfram.com/language/ref/GraphIntersection.html
        ///</summary>
        public static Engine GraphIntersection(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GraphIntersection[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphIntersection.html
        ///</summary>
        public static Engine GraphIntersection(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphIntersection[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph join of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphJoin.html
        ///</summary>
        public static Engine GraphJoin(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphJoin[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the link efficiency of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphLinkEfficiency.html
        ///</summary>
        public static Engine GraphLinkEfficiency(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphLinkEfficiency[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphLinkEfficiency.html
        ///</summary>
        public static Engine GraphLinkEfficiency(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphLinkEfficiency[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives vertices that are maximally distant to at least one vertex in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPeriphery.html
        ///</summary>
        public static Engine GraphPeriphery(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphPeriphery[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPeriphery.html
        ///</summary>
        public static Engine GraphPeriphery(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphPeriphery[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a plot of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPlot.html
        ///</summary>
        public static Engine GraphPlot(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphPlot[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a plot of the graph with edges ei.
        ///https://reference.wolfram.com/language/ref/GraphPlot.html
        ///</summary>
        public static Engine GraphPlot(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphPlot[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///generates a 3D plot of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPlot3D.html
        ///</summary>
        public static Engine GraphPlot3D(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphPlot3D[" + arg0 + "]", name);
        }

        ///<summary>
        ///generates a 3D plot of the graph with edges ei.
        ///https://reference.wolfram.com/language/ref/GraphPlot3D.html
        ///</summary>
        public static Engine GraphPlot3D(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphPlot3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the graph-n power of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPower.html
        ///</summary>
        public static Engine GraphPower(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphPower[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPower.html
        ///</summary>
        public static Engine GraphPower(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphPower[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Cartesian product of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphProduct.html
        ///</summary>
        public static Engine GraphProduct(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphProduct[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the product of type "op" for the graphs g1 and g2
        ///https://reference.wolfram.com/language/ref/GraphProduct.html
        ///</summary>
        public static Engine GraphProduct(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GraphProduct[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the distribution of the property expr where the random variable x follows the graph distribution gdist.
        ///https://reference.wolfram.com/language/ref/GraphPropertyDistribution.html
        ///</summary>
        public static Engine GraphPropertyDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphPropertyDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the distribution where x1, x2, … are independent and follow the graph distributions gdist1, gdist2, ….
        ///https://reference.wolfram.com/language/ref/GraphPropertyDistribution.html
        ///</summary>
        public static Engine GraphPropertyDistribution(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GraphPropertyDistribution[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///yields True if g is a valid Graph object and False otherwise.
        ///https://reference.wolfram.com/language/ref/GraphQ.html
        ///</summary>
        public static Engine GraphQ(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphQ[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the minimum eccentricity of the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphRadius.html
        ///</summary>
        public static Engine GraphRadius(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphRadius[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphRadius.html
        ///</summary>
        public static Engine GraphRadius(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphRadius[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the reciprocity of a graph g.
        ///https://reference.wolfram.com/language/ref/GraphReciprocity.html
        ///</summary>
        public static Engine GraphReciprocity(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphReciprocity[" + arg0 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphReciprocity.html
        ///</summary>
        public static Engine GraphReciprocity(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GraphReciprocity[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives the graph sum of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphSum.html
        ///</summary>
        public static Engine GraphSum(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphSum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///constructs a tree from the tree graph g.
        ///https://reference.wolfram.com/language/ref/GraphTree.html
        ///</summary>
        public static Engine GraphTree(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GraphTree[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies what vertex to use as the root.
        ///https://reference.wolfram.com/language/ref/GraphTree.html
        ///</summary>
        public static Engine GraphTree(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphTree[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///applies h to each vertex to get the corresponding data and ordering of subtrees.
        ///https://reference.wolfram.com/language/ref/GraphTree.html
        ///</summary>
        public static Engine GraphTree(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GraphTree[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the graph union of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphUnion.html
        ///</summary>
        public static Engine GraphUnion(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphUnion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph union of g1, g2, ….
        ///https://reference.wolfram.com/language/ref/GraphUnion.html
        ///</summary>
        public static Engine GraphUnion(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GraphUnion[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///uses rules vw to specify the graph g.
        ///https://reference.wolfram.com/language/ref/GraphUnion.html
        ///</summary>
        public static Engine GraphUnion(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GraphUnion[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a color in the grayscale color space with gray level g.
        ///https://reference.wolfram.com/language/ref/GrayLevel.html
        ///</summary>
        public static Engine GrayLevel(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GrayLevel[" + arg0 + "]", name);
        }

        ///<summary>
        ///specifies opacity a.
        ///https://reference.wolfram.com/language/ref/GrayLevel.html
        ///</summary>
        public static Engine GrayLevel(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GrayLevel[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterEqualLess.html
        ///</summary>
        public static Engine GreaterEqualLess(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GreaterEqualLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x≥y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/GreaterEqualThan.html
        ///</summary>
        public static Engine GreaterEqualThan(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GreaterEqualThan[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterFullEqual.html
        ///</summary>
        public static Engine GreaterFullEqual(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GreaterFullEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterGreater.html
        ///</summary>
        public static Engine GreaterGreater(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GreaterGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterLess.html
        ///</summary>
        public static Engine GreaterLess(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GreaterLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterSlantEqual.html
        ///</summary>
        public static Engine GreaterSlantEqual(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GreaterSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x>y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/GreaterThan.html
        ///</summary>
        public static Engine GreaterThan(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GreaterThan[" + arg0 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterTilde.html
        ///</summary>
        public static Engine GreaterTilde(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GreaterTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a Green's function for the linear differential operator ℒ with boundary conditions ℬ in the range xmin to xmax.
        ///https://reference.wolfram.com/language/ref/GreenFunction.html
        ///</summary>
        public static Engine GreenFunction(this Engine en, List<string> arg0, string arg1, List<string> arg2, string arg3, string? name = null)
        {
            return en.Execute("GreenFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives a Green's function for the linear partial differential operator ℒ over the region Ω.
        ///https://reference.wolfram.com/language/ref/GreenFunction.html
        ///</summary>
        public static Engine GreenFunction(this Engine en, List<string> arg0, string arg1, string arg2, List<string> arg3, string? name = null)
        {
            return en.Execute("GreenFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
        }

        ///<summary>
        ///gives a Green's function for the linear time-dependent operator ℒ in the range xmin to xmax.
        ///https://reference.wolfram.com/language/ref/GreenFunction.html
        ///</summary>
        public static Engine GreenFunction(this Engine en, List<string> arg0, string arg1, List<string> arg2, string arg3, List<string> arg4, string? name = null)
        {
            return en.Execute("GreenFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
        }

        ///<summary>
        ///gives a Green's function for the linear time-dependent operator ℒ over the region Ω.
        ///https://reference.wolfram.com/language/ref/GreenFunction.html
        ///</summary>
        public static Engine GreenFunction(this Engine en, List<string> arg0, string arg1, string arg2, string arg3, List<string> arg4, string? name = null)
        {
            return en.Execute("GreenFunction[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
        }

        ///<summary>
        ///is an object that formats with the exprij arranged in a two-dimensional grid.
        ///https://reference.wolfram.com/language/ref/Grid.html
        ///</summary>
        public static Engine Grid(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("Grid[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a two-dimensional grid of boxes or strings in notebook expressions.
        ///https://reference.wolfram.com/language/ref/GridBox.html
        ///</summary>
        public static Engine GridBox(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GridBox[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the grid graph with m×n vertices .
        ///https://reference.wolfram.com/language/ref/GridGraph.html
        ///</summary>
        public static Engine GridGraph(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GridGraph[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///creates a video in which each frame is a grid of frames of all vi at the corresponding time.
        ///https://reference.wolfram.com/language/ref/GridVideo.html
        ///</summary>
        public static Engine GridVideo(this Engine en, List<string> arg0, string? name = null)
        {
            return en.Execute("GridVideo[" + "{" + string.Join(',', arg0) + "}" + "]", name);
        }

        ///<summary>
        ///gives a list of polynomials that form a Gröbner basis for the set of polynomials polyi.
        ///https://reference.wolfram.com/language/ref/GroebnerBasis.html
        ///</summary>
        public static Engine GroebnerBasis(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GroebnerBasis[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds a Gröbner basis in which the yi have been eliminated.
        ///https://reference.wolfram.com/language/ref/GroebnerBasis.html
        ///</summary>
        public static Engine GroebnerBasis(this Engine en, List<string> arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("GroebnerBasis[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///gives an association that groups the elemi into lists associated with distinct keys f[elemi].
        ///https://reference.wolfram.com/language/ref/GroupBy.html
        ///</summary>
        public static Engine GroupBy(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("GroupBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///groups into nested associations using fsi at level i.
        ///https://reference.wolfram.com/language/ref/GroupBy.html
        ///</summary>
        public static Engine GroupBy(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GroupBy[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///applies the function red to reduce lists of values that are generated.
        ///https://reference.wolfram.com/language/ref/GroupBy.html
        ///</summary>
        public static Engine GroupBy(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GroupBy[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents an operator form of GroupBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/GroupBy.html
        ///</summary>
        public static Engine GroupBy(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GroupBy[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the centralizer of the element g in group.
        ///https://reference.wolfram.com/language/ref/GroupCentralizer.html
        ///</summary>
        public static Engine GroupCentralizer(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GroupCentralizer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the element of group determined by the word w in the generators of group.
        ///https://reference.wolfram.com/language/ref/GroupElementFromWord.html
        ///</summary>
        public static Engine GroupElementFromWord(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GroupElementFromWord[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the position of the element g in the list of elements of group.
        ///https://reference.wolfram.com/language/ref/GroupElementPosition.html
        ///</summary>
        public static Engine GroupElementPosition(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GroupElementPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the list of positions of the elements g1,…,gn in group.
        ///https://reference.wolfram.com/language/ref/GroupElementPosition.html
        ///</summary>
        public static Engine GroupElementPosition(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GroupElementPosition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns True if the object g is an element of group and False otherwise.
        ///https://reference.wolfram.com/language/ref/GroupElementQ.html
        ///</summary>
        public static Engine GroupElementQ(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GroupElementQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the list of all elements of group.
        ///https://reference.wolfram.com/language/ref/GroupElements.html
        ///</summary>
        public static Engine GroupElements(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GroupElements[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the elements numbered r1,…,rk in group in the standard order.
        ///https://reference.wolfram.com/language/ref/GroupElements.html
        ///</summary>
        public static Engine GroupElements(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GroupElements[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///decomposes the group element g as a product of generators of group.
        ///https://reference.wolfram.com/language/ref/GroupElementToWord.html
        ///</summary>
        public static Engine GroupElementToWord(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GroupElementToWord[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of generators of group.
        ///https://reference.wolfram.com/language/ref/GroupGenerators.html
        ///</summary>
        public static Engine GroupGenerators(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GroupGenerators[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives a list of all possible groupings of 1,…,n taken k at a time.
        ///https://reference.wolfram.com/language/ref/Groupings.html
        ///</summary>
        public static Engine Groupings(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("Groupings[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives all possible groupings of a1,…,an taken k at a time.
        ///https://reference.wolfram.com/language/ref/Groupings.html
        ///</summary>
        public static Engine Groupings(this Engine en, List<string> arg0, string arg1, string? name = null)
        {
            return en.Execute("Groupings[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the combination of all possible groupings of each of the lists ai,bi,… taken k at a time.
        ///https://reference.wolfram.com/language/ref/Groupings.html
        ///</summary>
        public static Engine Groupings(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("Groupings[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives all possible groupings in which the function fi is applied to ki elements.
        ///https://reference.wolfram.com/language/ref/Groupings.html
        ///</summary>
        public static Engine Groupings(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("Groupings[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///allows at most mi occurrences in a given grouping of fi applied to ki elements.
        ///https://reference.wolfram.com/language/ref/Groupings.html
        ///</summary>
        public static Engine Groupings(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
        {
            return en.Execute("Groupings[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
        }

        ///<summary>
        ///wraps the function h around each grouping generated.
        ///https://reference.wolfram.com/language/ref/Groupings.html
        ///</summary>
        public static Engine Groupings(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("Groupings[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the multiplication table of group as an array.
        ///https://reference.wolfram.com/language/ref/GroupMultiplicationTable.html
        ///</summary>
        public static Engine GroupMultiplicationTable(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GroupMultiplicationTable[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the orbits of the points pi under the action of the elements of group.
        ///https://reference.wolfram.com/language/ref/GroupOrbits.html
        ///</summary>
        public static Engine GroupOrbits(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GroupOrbits[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///finds the orbits under the group action given by a function f.
        ///https://reference.wolfram.com/language/ref/GroupOrbits.html
        ///</summary>
        public static Engine GroupOrbits(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GroupOrbits[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the number of elements of group.
        ///https://reference.wolfram.com/language/ref/GroupOrder.html
        ///</summary>
        public static Engine GroupOrder(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GroupOrder[" + arg0 + "]", name);
        }

        ///<summary>
        ///returns the subgroup of group for which the images of the points pi are still in the list {p1,…,pn}.
        ///https://reference.wolfram.com/language/ref/GroupSetwiseStabilizer.html
        ///</summary>
        public static Engine GroupSetwiseStabilizer(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GroupSetwiseStabilizer[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the setwise stabilizer subgroup under the action given by the function f.
        ///https://reference.wolfram.com/language/ref/GroupSetwiseStabilizer.html
        ///</summary>
        public static Engine GroupSetwiseStabilizer(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GroupSetwiseStabilizer[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns the subgroup of elements of group that move none of the points p1, …, pn.
        ///https://reference.wolfram.com/language/ref/GroupStabilizer.html
        ///</summary>
        public static Engine GroupStabilizer(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GroupStabilizer[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///returns the stabilizer subgroup under the action given by the function f.
        ///https://reference.wolfram.com/language/ref/GroupStabilizer.html
        ///</summary>
        public static Engine GroupStabilizer(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
        {
            return en.Execute("GroupStabilizer[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///returns a list of successive stabilizers in group of the points in a base of group.
        ///https://reference.wolfram.com/language/ref/GroupStabilizerChain.html
        ///</summary>
        public static Engine GroupStabilizerChain(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("GroupStabilizerChain[" + arg0 + "]", name);
        }

        ///<summary>
        ///creates a segmentation from image by growing each markeri.
        ///https://reference.wolfram.com/language/ref/GrowCutComponents.html
        ///</summary>
        public static Engine GrowCutComponents(this Engine en, string arg0, List<string> arg1, string? name = null)
        {
            return en.Execute("GrowCutComponents[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
        }

        ///<summary>
        ///gives the Gudermannian function .
        ///https://reference.wolfram.com/language/ref/Gudermannian.html
        ///</summary>
        public static Engine Gudermannian(this Engine en, string arg0, string? name = null)
        {
            return en.Execute("Gudermannian[" + arg0 + "]", name);
        }

        ///<summary>
        ///filters image using the guide image guide over range-r neighborhoods with pixel-value regularizer ϵ.
        ///https://reference.wolfram.com/language/ref/GuidedFilter.html
        ///</summary>
        public static Engine GuidedFilter(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
        {
            return en.Execute("GuidedFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///filters image so as to reduce noise, using image as the guide.
        ///https://reference.wolfram.com/language/ref/GuidedFilter.html
        ///</summary>
        public static Engine GuidedFilter(this Engine en, string arg0, string arg1, string arg2, string? name = null)
        {
            return en.Execute("GuidedFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents a Gumbel distribution with location parameter α and scale parameter β.
        ///https://reference.wolfram.com/language/ref/GumbelDistribution.html
        ///</summary>
        public static Engine GumbelDistribution(this Engine en, string arg0, string arg1, string? name = null)
        {
            return en.Execute("GumbelDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gumbel distribution with location parameter 0 and scale parameter 1.
        ///https://reference.wolfram.com/language/ref/GumbelDistribution.html
        ///</summary>
        public static Engine GumbelDistribution(this Engine en, string? name = null)
        {
            return en.Execute("GumbelDistribution[]", name);
        }


    }
}
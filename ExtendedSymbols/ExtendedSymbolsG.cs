namespace CoreWolf
{
    public static class ExtendedSymbolsG
    {
        ///<summary>
        ///represents a Gabor wavelet of frequency w.
        ///https://reference.wolfram.com/language/ref/GaborWavelet.html
        ///</summary>
        public static Engine GaborWavelet(this Engine en, string? name = null)
        {
            return en.Execute("GaborWavelet[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the gain margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/GainMargins.html
        ///</summary>
        public static Engine GainMargins(this Engine en, string? name = null)
        {
            return en.Execute("GainMargins[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the gain and phase margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/GainPhaseMargins.html
        ///</summary>
        public static Engine GainPhaseMargins(this Engine en, string? name = null)
        {
            return en.Execute("GainPhaseMargins[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an object in which the expri are displayed in a browsable gallery layout.
        ///https://reference.wolfram.com/language/ref/GalleryView.html
        ///</summary>
        public static Engine GalleryView(this Engine en, string? name = null)
        {
            return en.Execute("GalleryView[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is the Euler gamma function .
        ///https://reference.wolfram.com/language/ref/Gamma.html
        ///</summary>
        public static Engine Gamma(this Engine en, string? name = null)
        {
            return en.Execute("Gamma[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a trainable recurrent layer that takes a sequence of vectors and produces a sequence of vectors each of size n.
        ///https://reference.wolfram.com/language/ref/GatedRecurrentLayer.html
        ///</summary>
        public static Engine GatedRecurrentLayer(this Engine en, string? name = null)
        {
            return en.Execute("GatedRecurrentLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gathers the elements of list into sublists of identical elements.
        ///https://reference.wolfram.com/language/ref/Gather.html
        ///</summary>
        public static Engine Gather(this Engine en, string? name = null)
        {
            return en.Execute("Gather[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a matrix that corresponds to a Gaussian kernel of radius r.
        ///https://reference.wolfram.com/language/ref/GaussianMatrix.html
        ///</summary>
        public static Engine GaussianMatrix(this Engine en, string? name = null)
        {
            return en.Execute("GaussianMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Gaussian orthogonal matrix distribution with unit scale parameter.
        ///https://reference.wolfram.com/language/ref/GaussianOrthogonalMatrixDistribution.html
        ///</summary>
        public static Engine GaussianOrthogonalMatrixDistribution(this Engine en, string? name = null)
        {
            return en.Execute("GaussianOrthogonalMatrixDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Gaussian symplectic matrix distribution with unit scale parameter.
        ///https://reference.wolfram.com/language/ref/GaussianSymplecticMatrixDistribution.html
        ///</summary>
        public static Engine GaussianSymplecticMatrixDistribution(this Engine en, string? name = null)
        {
            return en.Execute("GaussianSymplecticMatrixDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Gaussian unitary matrix distribution with unit scale parameter.
        ///https://reference.wolfram.com/language/ref/GaussianUnitaryMatrixDistribution.html
        ///</summary>
        public static Engine GaussianUnitaryMatrixDistribution(this Engine en, string? name = null)
        {
            return en.Execute("GaussianUnitaryMatrixDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a Gaussian window function of x.
        ///https://reference.wolfram.com/language/ref/GaussianWindow.html
        ///</summary>
        public static Engine GaussianWindow(this Engine en, string? name = null)
        {
            return en.Execute("GaussianWindow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///constructs a generalized linear model from the design matrix m and response vector v.
        ///https://reference.wolfram.com/language/ref/GeneralizedLinearModelFit.html
        ///</summary>
        public static Engine GeneralizedLinearModelFit(this Engine en, string? name = null)
        {
            return en.Execute("GeneralizedLinearModelFit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///randomly generates private and public keys of the specified type.
        ///https://reference.wolfram.com/language/ref/GenerateAsymmetricKeyPair.html
        ///</summary>
        public static Engine GenerateAsymmetricKeyPair(this Engine en, string? name = null)
        {
            return en.Execute("GenerateAsymmetricKeyPair[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a DerivedKey object from the password given.
        ///https://reference.wolfram.com/language/ref/GenerateDerivedKey.html
        ///</summary>
        public static Engine GenerateDerivedKey(this Engine en, string? name = null)
        {
            return en.Execute("GenerateDerivedKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of GenerateDigitalSignature that can be applied to expressions.
        ///https://reference.wolfram.com/language/ref/GenerateDigitalSignature.html
        ///</summary>
        public static Engine GenerateDigitalSignature(this Engine en, string? name = null)
        {
            return en.Execute("GenerateDigitalSignature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a document by evaluating all template elements in the notebook nb.
        ///https://reference.wolfram.com/language/ref/GenerateDocument.html
        ///</summary>
        public static Engine GenerateDocument(this Engine en, string? name = null)
        {
            return en.Execute("GenerateDocument[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of GenerateFileSignature that can be applied to files.
        ///https://reference.wolfram.com/language/ref/GenerateFileSignature.html
        ///</summary>
        public static Engine GenerateFileSignature(this Engine en, string? name = null)
        {
            return en.Execute("GenerateFileSignature[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the HTTPResponse object that is generated when a cloud object containing expr is requested on the web.
        ///https://reference.wolfram.com/language/ref/GenerateHTTPResponse.html
        ///</summary>
        public static Engine GenerateHTTPResponse(this Engine en, string? name = null)
        {
            return en.Execute("GenerateHTTPResponse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a new SecuredAuthenticationKey with the specified name owned by the current user ID.
        ///https://reference.wolfram.com/language/ref/GenerateSecuredAuthenticationKey.html
        ///</summary>
        public static Engine GenerateSecuredAuthenticationKey(this Engine en, string? name = null)
        {
            return en.Execute("GenerateSecuredAuthenticationKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///derives a SymmetricKey object from the password string given.
        ///https://reference.wolfram.com/language/ref/GenerateSymmetricKey.html
        ///</summary>
        public static Engine GenerateSymmetricKey(this Engine en, string? name = null)
        {
            return en.Execute("GenerateSymmetricKey[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the DNA sequence for the specified gene on the reference human genome.
        ///https://reference.wolfram.com/language/ref/GenomeData.html
        ///</summary>
        public static Engine GenomeData(this Engine en, string? name = null)
        {
            return en.Execute("GenomeData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the positions of exact matches for the DNA sequence seq on the reference human genome.
        ///https://reference.wolfram.com/language/ref/GenomeLookup.html
        ///</summary>
        public static Engine GenomeLookup(this Engine en, string? name = null)
        {
            return en.Execute("GenomeLookup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the antipodal position of location loc.
        ///https://reference.wolfram.com/language/ref/GeoAntipode.html
        ///</summary>
        public static Engine GeoAntipode(this Engine en, string? name = null)
        {
            return en.Execute("GeoAntipode[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the area of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoArea.html
        ///</summary>
        public static Engine GeoArea(this Engine en, string? name = null)
        {
            return en.Execute("GeoArea[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the boundary line of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundary.html
        ///</summary>
        public static Engine GeoBoundary(this Engine en, string? name = null)
        {
            return en.Execute("GeoBoundary[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the geo positions that define the bounding rectangle enclosing the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundingBox.html
        ///</summary>
        public static Engine GeoBoundingBox(this Engine en, string? name = null)
        {
            return en.Execute("GeoBoundingBox[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the ranges of latitudes and longitudes in the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBounds.html
        ///</summary>
        public static Engine GeoBounds(this Engine en, string? name = null)
        {
            return en.Execute("GeoBounds[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the latitude-longitude bounding box of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegion.html
        ///</summary>
        public static Engine GeoBoundsRegion(this Engine en, string? name = null)
        {
            return en.Execute("GeoBoundsRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the boundary of the latitude-longitude bounding box of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegionBoundary.html
        ///</summary>
        public static Engine GeoBoundsRegionBoundary(this Engine en, string? name = null)
        {
            return en.Execute("GeoBoundsRegionBoundary[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a geo bubble chart with bubbles centered at the geographic regions regi with sizes vali.
        ///https://reference.wolfram.com/language/ref/GeoBubbleChart.html
        ///</summary>
        public static Engine GeoBubbleChart(this Engine en, string? name = null)
        {
            return en.Execute("GeoBubbleChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a geo contour plot from values vali defined at specified locations loci.
        ///https://reference.wolfram.com/language/ref/GeoContourPlot.html
        ///</summary>
        public static Engine GeoContourPlot(this Engine en, string? name = null)
        {
            return en.Execute("GeoContourPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///makes a geo density plot with colors at the location loci determined by the value vali.
        ///https://reference.wolfram.com/language/ref/GeoDensityPlot.html
        ///</summary>
        public static Engine GeoDensityPlot(this Engine en, string? name = null)
        {
            return en.Execute("GeoDensityPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the order‐n geodesic polyhedron.
        ///https://reference.wolfram.com/language/ref/GeodesicPolyhedron.html
        ///</summary>
        public static Engine GeodesicPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("GeodesicPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a geodesic displacement of length dist and initial bearing α from a geo location.
        ///https://reference.wolfram.com/language/ref/GeoDisplacement.html
        ///</summary>
        public static Engine GeoDisplacement(this Engine en, string? name = null)
        {
            return en.Execute("GeoDisplacement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the total distance from loc1 to locn through all the intermediate loci.
        ///https://reference.wolfram.com/language/ref/GeoDistance.html
        ///</summary>
        public static Engine GeoDistance(this Engine en, string? name = null)
        {
            return en.Execute("GeoDistance[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the list of geodesic distances between consecutive pairs of locations.
        ///https://reference.wolfram.com/language/ref/GeoDistanceList.html
        ///</summary>
        public static Engine GeoDistanceList(this Engine en, string? name = null)
        {
            return en.Execute("GeoDistanceList[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the elevation at the geographic location loc.
        ///https://reference.wolfram.com/language/ref/GeoElevationData.html
        ///</summary>
        public static Engine GeoElevationData(this Engine en, string? name = null)
        {
            return en.Execute("GeoElevationData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a plot of the geographic graph with edges ei.
        ///https://reference.wolfram.com/language/ref/GeoGraphPlot.html
        ///</summary>
        public static Engine GeoGraphPlot(this Engine en, string? name = null)
        {
            return en.Execute("GeoGraphPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots the flow for a graph g with associated edge weights.
        ///https://reference.wolfram.com/language/ref/GeoGraphValuePlot.html
        ///</summary>
        public static Engine GeoGraphValuePlot(this Engine en, string? name = null)
        {
            return en.Execute("GeoGraphValuePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the gravitational field data for a location.
        ///https://reference.wolfram.com/language/ref/GeogravityModelData.html
        ///</summary>
        public static Engine GeogravityModelData(this Engine en, string? name = null)
        {
            return en.Execute("GeogravityModelData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a list of geographic objects to be treated as a single object for certain operations.
        ///https://reference.wolfram.com/language/ref/GeoGroup.html
        ///</summary>
        public static Engine GeoGroup(this Engine en, string? name = null)
        {
            return en.Execute("GeoGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the half of the Earth centered at the location loc.
        ///https://reference.wolfram.com/language/ref/GeoHemisphere.html
        ///</summary>
        public static Engine GeoHemisphere(this Engine en, string? name = null)
        {
            return en.Execute("GeoHemisphere[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents the boundary line of a hemisphere centered at the location loc.
        ///https://reference.wolfram.com/language/ref/GeoHemisphereBoundary.html
        ///</summary>
        public static Engine GeoHemisphereBoundary(this Engine en, string? name = null)
        {
            return en.Execute("GeoHemisphereBoundary[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots a density histogram of the geographic locations locs.
        ///https://reference.wolfram.com/language/ref/GeoHistogram.html
        ///</summary>
        public static Engine GeoHistogram(this Engine en, string? name = null)
        {
            return en.Execute("GeoHistogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///identifies the geographic entities of the type enttype in which the current geo location is contained.
        ///https://reference.wolfram.com/language/ref/GeoIdentify.html
        ///</summary>
        public static Engine GeoIdentify(this Engine en, string? name = null)
        {
            return en.Execute("GeoIdentify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a satellite image of the geo region reg.
        ///https://reference.wolfram.com/language/ref/GeoImage.html
        ///</summary>
        public static Engine GeoImage(this Engine en, string? name = null)
        {
            return en.Execute("GeoImage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the length of the geo path g.
        ///https://reference.wolfram.com/language/ref/GeoLength.html
        ///</summary>
        public static Engine GeoLength(this Engine en, string? name = null)
        {
            return en.Execute("GeoLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a map on which the locations loci are indicated.
        ///https://reference.wolfram.com/language/ref/GeoListPlot.html
        ///</summary>
        public static Engine GeoListPlot(this Engine en, string? name = null)
        {
            return en.Execute("GeoListPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the current magnetic field data for a location.
        ///https://reference.wolfram.com/language/ref/GeomagneticModelData.html
        ///</summary>
        public static Engine GeomagneticModelData(this Engine en, string? name = null)
        {
            return en.Execute("GeomagneticModelData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents a marker at the location loc.
        ///https://reference.wolfram.com/language/ref/GeoMarker.html
        ///</summary>
        public static Engine GeoMarker(this Engine en, string? name = null)
        {
            return en.Execute("GeoMarker[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a geometric distribution with probability parameter p.
        ///https://reference.wolfram.com/language/ref/GeometricDistribution.html
        ///</summary>
        public static Engine GeometricDistribution(this Engine en, string? name = null)
        {
            return en.Execute("GeometricDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the geometric mean of the values in list.
        ///https://reference.wolfram.com/language/ref/GeometricMean.html
        ///</summary>
        public static Engine GeometricMean(this Engine en, string? name = null)
        {
            return en.Execute("GeometricMean[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///combines several scene instances into one scene object.
        ///https://reference.wolfram.com/language/ref/GeometricScene.html
        ///</summary>
        public static Engine GeometricScene(this Engine en, string? name = null)
        {
            return en.Execute("GeometricScene[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a symbolic representation of a step in the definition of a geometric scene, in which the hypotheses hypi are introduced.
        ///https://reference.wolfram.com/language/ref/GeometricStep.html
        ///</summary>
        public static Engine GeometricStep(this Engine en, string? name = null)
        {
            return en.Execute("GeometricStep[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a GeoGraphics primitive that represents a filled polygon whose boundary is formed by geodesic segments between locations loci and loci+1.
        ///https://reference.wolfram.com/language/ref/GeoPolygon.html
        ///</summary>
        public static Engine GeoPolygon(this Engine en, string? name = null)
        {
            return en.Execute("GeoPolygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a geodetic position with latitude lat and longitude lon.
        ///https://reference.wolfram.com/language/ref/GeoPosition.html
        ///</summary>
        public static Engine GeoPosition(this Engine en, string? name = null)
        {
            return en.Execute("GeoPosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a position in a Cartesian geocentric coordinate system.
        ///https://reference.wolfram.com/language/ref/GeoPositionXYZ.html
        ///</summary>
        public static Engine GeoPositionXYZ(this Engine en, string? name = null)
        {
            return en.Execute("GeoPositionXYZ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the complete options for the default form of the specified projection.
        ///https://reference.wolfram.com/language/ref/GeoProjectionData.html
        ///</summary>
        public static Engine GeoProjectionData(this Engine en, string? name = null)
        {
            return en.Execute("GeoProjectionData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a plot in which the geographic regions regi are colored according to the values vali.
        ///https://reference.wolfram.com/language/ref/GeoRegionValuePlot.html
        ///</summary>
        public static Engine GeoRegionValuePlot(this Engine en, string? name = null)
        {
            return en.Execute("GeoRegionValuePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///plots a smooth kernel histogram of the geo locations locs.
        ///https://reference.wolfram.com/language/ref/GeoSmoothHistogram.html
        ///</summary>
        public static Engine GeoSmoothHistogram(this Engine en, string? name = null)
        {
            return en.Execute("GeoSmoothHistogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a stream plot from the field of geo vectors vecs.
        ///https://reference.wolfram.com/language/ref/GeoStreamPlot.html
        ///</summary>
        public static Engine GeoStreamPlot(this Engine en, string? name = null)
        {
            return en.Execute("GeoStreamPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///displays faces of polygons and other filled geo objects using mapstyle.
        ///https://reference.wolfram.com/language/ref/GeoStyling.html
        ///</summary>
        public static Engine GeoStyling(this Engine en, string? name = null)
        {
            return en.Execute("GeoStyling[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a horizontal two-dimensional vector of magnitude m and bearing α at geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoVector.html
        ///</summary>
        public static Engine GeoVector(this Engine en, string? name = null)
        {
            return en.Execute("GeoVector[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a horizontal two-dimensional vector of components ve and vn in an orthonormal frame tangent to the Earth at geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoVectorENU.html
        ///</summary>
        public static Engine GeoVectorENU(this Engine en, string? name = null)
        {
            return en.Execute("GeoVectorENU[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a vector plot from the field of geo vectors vecs.
        ///https://reference.wolfram.com/language/ref/GeoVectorPlot.html
        ///</summary>
        public static Engine GeoVectorPlot(this Engine en, string? name = null)
        {
            return en.Execute("GeoVectorPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a three-dimensional vector of Cartesian components vX, vY, vZ in an orthonormal frame parallel to the geocentric frame, at location loc.
        ///https://reference.wolfram.com/language/ref/GeoVectorXYZ.html
        ///</summary>
        public static Engine GeoVectorXYZ(this Engine en, string? name = null)
        {
            return en.Execute("GeoVectorXYZ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents the region on the surface of the Earth visible from the point of coordinates lat,lon and height h above the reference ellipsoid.
        ///https://reference.wolfram.com/language/ref/GeoVisibleRegion.html
        ///</summary>
        public static Engine GeoVisibleRegion(this Engine en, string? name = null)
        {
            return en.Execute("GeoVisibleRegion[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a one-dimensional GeoGraphics primitive that represents the boundary of the region on the surface of the Earth visible from the point of coordinates lat,lon and height h above the reference ellipsoid.
        ///https://reference.wolfram.com/language/ref/GeoVisibleRegionBoundary.html
        ///</summary>
        public static Engine GeoVisibleRegionBoundary(this Engine en, string? name = null)
        {
            return en.Execute("GeoVisibleRegionBoundary[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of GeoWithinQ that can be applied to a location.
        ///https://reference.wolfram.com/language/ref/GeoWithinQ.html
        ///</summary>
        public static Engine GeoWithinQ(this Engine en, string? name = null)
        {
            return en.Execute("GeoWithinQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the setting corresponding to the variable "var" in the operating system environment.
        ///https://reference.wolfram.com/language/ref/GetEnvironment.html
        ///</summary>
        public static Engine GetEnvironment(this Engine en, string? name = null)
        {
            return en.Execute("GetEnvironment[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the global clustering coefficient of the graph g.
        ///https://reference.wolfram.com/language/ref/GlobalClusteringCoefficient.html
        ///</summary>
        public static Engine GlobalClusteringCoefficient(this Engine en, string? name = null)
        {
            return en.Execute("GlobalClusteringCoefficient[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///uses cool and warm colors obtained by blending col with slate Blue and Orange.
        ///https://reference.wolfram.com/language/ref/GoochShading.html
        ///</summary>
        public static Engine GoochShading(this Engine en, string? name = null)
        {
            return en.Execute("GoochShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Goodman–Kruskal  coefficients for the matrix m.
        ///https://reference.wolfram.com/language/ref/GoodmanKruskalGamma.html
        ///</summary>
        public static Engine GoodmanKruskalGamma(this Engine en, string? name = null)
        {
            return en.Execute("GoodmanKruskalGamma[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///scans for Label[tag], and transfers control to that point.
        ///https://reference.wolfram.com/language/ref/Goto.html
        ///</summary>
        public static Engine Goto(this Engine en, string? name = null)
        {
            return en.Execute("Goto[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///uses the attenuation factor d for the diffuse light.
        ///https://reference.wolfram.com/language/ref/GouraudShading.html
        ///</summary>
        public static Engine GouraudShading(this Engine en, string? name = null)
        {
            return en.Execute("GouraudShading[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a MeshRegion whose gradient best fits the normals at points p1,p2,….
        ///https://reference.wolfram.com/language/ref/GradientFittedMesh.html
        ///</summary>
        public static Engine GradientFittedMesh(this Engine en, string? name = null)
        {
            return en.Execute("GradientFittedMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents grammar rules to be deployed to a cloud object that implements the grammar in a form suitable for use with functions like GrammarApply and Interpreter.
        ///https://reference.wolfram.com/language/ref/GrammarRules.html
        ///</summary>
        public static Engine GrammarRules(this Engine en, string? name = null)
        {
            return en.Execute("GrammarRules[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is a grammar rules pattern object that represents any input of the specified form.
        ///https://reference.wolfram.com/language/ref/GrammarToken.html
        ///</summary>
        public static Engine GrammarToken(this Engine en, string? name = null)
        {
            return en.Execute("GrammarToken[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields a graph with edges ej.
        ///https://reference.wolfram.com/language/ref/Graph.html
        ///</summary>
        public static Engine Graph(this Engine en, string? name = null)
        {
            return en.Execute("Graph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a graph with vertices and edges from the graph g and represented as a 3D plot.
        ///https://reference.wolfram.com/language/ref/Graph3D.html
        ///</summary>
        public static Engine Graph3D(this Engine en, string? name = null)
        {
            return en.Execute("Graph3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the assortativity coefficient of a graph g using vertex degrees.
        ///https://reference.wolfram.com/language/ref/GraphAssortativity.html
        ///</summary>
        public static Engine GraphAssortativity(this Engine en, string? name = null)
        {
            return en.Execute("GraphAssortativity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the automorphism group of a graph g.
        ///https://reference.wolfram.com/language/ref/GraphAutomorphismGroup.html
        ///</summary>
        public static Engine GraphAutomorphismGroup(this Engine en, string? name = null)
        {
            return en.Execute("GraphAutomorphismGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the set of vertices with minimum eccentricity in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphCenter.html
        ///</summary>
        public static Engine GraphCenter(this Engine en, string? name = null)
        {
            return en.Execute("GraphCenter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the graph complement of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphComplement.html
        ///</summary>
        public static Engine GraphComplement(this Engine en, string? name = null)
        {
            return en.Execute("GraphComplement[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives a graph with the specified name.
        ///https://reference.wolfram.com/language/ref/GraphData.html
        ///</summary>
        public static Engine GraphData(this Engine en, string? name = null)
        {
            return en.Execute("GraphData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the graph density of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDensity.html
        ///</summary>
        public static Engine GraphDensity(this Engine en, string? name = null)
        {
            return en.Execute("GraphDensity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the greatest distance between any pair of vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDiameter.html
        ///</summary>
        public static Engine GraphDiameter(this Engine en, string? name = null)
        {
            return en.Execute("GraphDiameter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the matrix of distances between vertices for the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistanceMatrix.html
        ///</summary>
        public static Engine GraphDistanceMatrix(this Engine en, string? name = null)
        {
            return en.Execute("GraphDistanceMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives coordinates of the vertices of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphEmbedding.html
        ///</summary>
        public static Engine GraphEmbedding(this Engine en, string? name = null)
        {
            return en.Execute("GraphEmbedding[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the set of vertices with maximum vertex degree in the underlying simple graph of g.
        ///https://reference.wolfram.com/language/ref/GraphHub.html
        ///</summary>
        public static Engine GraphHub(this Engine en, string? name = null)
        {
            return en.Execute("GraphHub[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a graphic in which the gi are laid out in a column, with g1 above g2, etc.
        ///https://reference.wolfram.com/language/ref/GraphicsColumn.html
        ///</summary>
        public static Engine GraphicsColumn(this Engine en, string? name = null)
        {
            return en.Execute("GraphicsColumn[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a graphic in which the gij are laid out in a two-dimensional grid.
        ///https://reference.wolfram.com/language/ref/GraphicsGrid.html
        ///</summary>
        public static Engine GraphicsGrid(this Engine en, string? name = null)
        {
            return en.Execute("GraphicsGrid[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a collection of graphics objects grouped together for purposes of interactive selection in a notebook.
        ///https://reference.wolfram.com/language/ref/GraphicsGroup.html
        ///</summary>
        public static Engine GraphicsGroup(this Engine en, string? name = null)
        {
            return en.Execute("GraphicsGroup[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a graphic in which the gi are laid out in a row.
        ///https://reference.wolfram.com/language/ref/GraphicsRow.html
        ///</summary>
        public static Engine GraphicsRow(this Engine en, string? name = null)
        {
            return en.Execute("GraphicsRow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the link efficiency of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphLinkEfficiency.html
        ///</summary>
        public static Engine GraphLinkEfficiency(this Engine en, string? name = null)
        {
            return en.Execute("GraphLinkEfficiency[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives vertices that are maximally distant to at least one vertex in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPeriphery.html
        ///</summary>
        public static Engine GraphPeriphery(this Engine en, string? name = null)
        {
            return en.Execute("GraphPeriphery[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a plot of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPlot.html
        ///</summary>
        public static Engine GraphPlot(this Engine en, string? name = null)
        {
            return en.Execute("GraphPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///generates a 3D plot of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPlot3D.html
        ///</summary>
        public static Engine GraphPlot3D(this Engine en, string? name = null)
        {
            return en.Execute("GraphPlot3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///yields True if g is a valid Graph object and False otherwise.
        ///https://reference.wolfram.com/language/ref/GraphQ.html
        ///</summary>
        public static Engine GraphQ(this Engine en, string? name = null)
        {
            return en.Execute("GraphQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the minimum eccentricity of the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphRadius.html
        ///</summary>
        public static Engine GraphRadius(this Engine en, string? name = null)
        {
            return en.Execute("GraphRadius[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the reciprocity of a graph g.
        ///https://reference.wolfram.com/language/ref/GraphReciprocity.html
        ///</summary>
        public static Engine GraphReciprocity(this Engine en, string? name = null)
        {
            return en.Execute("GraphReciprocity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///constructs a tree from the tree graph g.
        ///https://reference.wolfram.com/language/ref/GraphTree.html
        ///</summary>
        public static Engine GraphTree(this Engine en, string? name = null)
        {
            return en.Execute("GraphTree[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents a color in the grayscale color space with gray level g.
        ///https://reference.wolfram.com/language/ref/GrayLevel.html
        ///</summary>
        public static Engine GrayLevel(this Engine en, string? name = null)
        {
            return en.Execute("GrayLevel[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x≥y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/GreaterEqualThan.html
        ///</summary>
        public static Engine GreaterEqualThan(this Engine en, string? name = null)
        {
            return en.Execute("GreaterEqualThan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x>y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/GreaterThan.html
        ///</summary>
        public static Engine GreaterThan(this Engine en, string? name = null)
        {
            return en.Execute("GreaterThan[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the grid graph with m×n vertices .
        ///https://reference.wolfram.com/language/ref/GridGraph.html
        ///</summary>
        public static Engine GridGraph(this Engine en, string? name = null)
        {
            return en.Execute("GridGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a video in which each frame is a grid of frames of all vi at the corresponding time.
        ///https://reference.wolfram.com/language/ref/GridVideo.html
        ///</summary>
        public static Engine GridVideo(this Engine en, string? name = null)
        {
            return en.Execute("GridVideo[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents an operator form of GroupBy that can be applied to an expression.
        ///https://reference.wolfram.com/language/ref/GroupBy.html
        ///</summary>
        public static Engine GroupBy(this Engine en, string? name = null)
        {
            return en.Execute("GroupBy[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the list of all elements of group.
        ///https://reference.wolfram.com/language/ref/GroupElements.html
        ///</summary>
        public static Engine GroupElements(this Engine en, string? name = null)
        {
            return en.Execute("GroupElements[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a list of generators of group.
        ///https://reference.wolfram.com/language/ref/GroupGenerators.html
        ///</summary>
        public static Engine GroupGenerators(this Engine en, string? name = null)
        {
            return en.Execute("GroupGenerators[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the multiplication table of group as an array.
        ///https://reference.wolfram.com/language/ref/GroupMultiplicationTable.html
        ///</summary>
        public static Engine GroupMultiplicationTable(this Engine en, string? name = null)
        {
            return en.Execute("GroupMultiplicationTable[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns the number of elements of group.
        ///https://reference.wolfram.com/language/ref/GroupOrder.html
        ///</summary>
        public static Engine GroupOrder(this Engine en, string? name = null)
        {
            return en.Execute("GroupOrder[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns a list of successive stabilizers in group of the points in a base of group.
        ///https://reference.wolfram.com/language/ref/GroupStabilizerChain.html
        ///</summary>
        public static Engine GroupStabilizerChain(this Engine en, string? name = null)
        {
            return en.Execute("GroupStabilizerChain[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///gives the Gudermannian function .
        ///https://reference.wolfram.com/language/ref/Gudermannian.html
        ///</summary>
        public static Engine Gudermannian(this Engine en, string? name = null)
        {
            return en.Execute("Gudermannian[" + en.ValidNames.Last() + "]", name);
        }


    }
}
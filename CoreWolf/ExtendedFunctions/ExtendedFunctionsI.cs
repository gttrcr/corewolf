namespace CoreWolf
{
    public static class ExtendedFunctionsI
    {
        ///<summary>
        /// gives an iconized form that can be used to stand in for expr in notebook input.
        /// https://reference.wolfram.com/language/ref/Iconize.html
        ///</summary>
        public static Engine Iconize(this Engine en, string? name = null)
        {
            return en.Execute("Iconize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an icosahedron with edge length l.
        /// https://reference.wolfram.com/language/ref/Icosahedron.html
        ///</summary>
        public static Engine Icosahedron(this Engine en, string? name = null)
        {
            return en.Execute("Icosahedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives expr (the identity operation).
        /// https://reference.wolfram.com/language/ref/Identity.html
        ///</summary>
        public static Engine Identity(this Engine en, string? name = null)
        {
            return en.Execute("Identity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the nn identity matrix.
        /// https://reference.wolfram.com/language/ref/IdentityMatrix.html
        ///</summary>
        public static Engine IdentityMatrix(this Engine en, string? name = null)
        {
            return en.Execute("IdentityMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a pattern object that, for purposes of pattern matching, ignores occurrences of Inactive in both patt and the expression being matched.
        /// https://reference.wolfram.com/language/ref/IgnoringInactive.html
        ///</summary>
        public static Engine IgnoringInactive(this Engine en, string? name = null)
        {
            return en.Execute("IgnoringInactive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the imaginary part of the complex number .
        /// https://reference.wolfram.com/language/ref/Im.html
        ///</summary>
        public static Engine Im(this Engine en, string? name = null)
        {
            return en.Execute("Im[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a raster image with pixel values given by the array data.
        /// https://reference.wolfram.com/language/ref/Image.html
        ///</summary>
        public static Engine Image(this Engine en, string? name = null)
        {
            return en.Execute("Image[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a 3D image with pixel values given by the array data.
        /// https://reference.wolfram.com/language/ref/Image3D.html
        ///</summary>
        public static Engine Image3D(this Engine en, string? name = null)
        {
            return en.Execute("Image3D[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// takes a 3D image and returns a 2D image of maximum projection onto the - plane.
        /// https://reference.wolfram.com/language/ref/Image3DProjection.html
        ///</summary>
        public static Engine Image3DProjection(this Engine en, string? name = null)
        {
            return en.Execute("Image3DProjection[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of 2D images corresponding to the slices in the Image3D object image.
        /// https://reference.wolfram.com/language/ref/Image3DSlices.html
        ///</summary>
        public static Engine Image3DSlices(this Engine en, string? name = null)
        {
            return en.Execute("Image3DSlices[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an image in which each pixel represents a sum of all pixels below and to the left of that pixel in image.
        /// https://reference.wolfram.com/language/ref/ImageAccumulate.html
        ///</summary>
        public static Engine ImageAccumulate(this Engine en, string? name = null)
        {
            return en.Execute("ImageAccumulate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// adjusts the levels in image, rescaling them to cover the range 0 to 1.
        /// https://reference.wolfram.com/language/ref/ImageAdjust.html
        ///</summary>
        public static Engine ImageAdjust(this Engine en, string? name = null)
        {
            return en.Execute("ImageAdjust[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uses image1 as the reference image.
        /// https://reference.wolfram.com/language/ref/ImageAlign.html
        ///</summary>
        public static Engine ImageAlign(this Engine en, string? name = null)
        {
            return en.Execute("ImageAlign[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the ratio of height to width for image.
        /// https://reference.wolfram.com/language/ref/ImageAspectRatio.html
        ///</summary>
        public static Engine ImageAspectRatio(this Engine en, string? name = null)
        {
            return en.Execute("ImageAspectRatio[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a net layer that applies random image transformations to produce images of height h and width w.
        /// https://reference.wolfram.com/language/ref/ImageAugmentationLayer.html
        ///</summary>
        public static Engine ImageAugmentationLayer(this Engine en, string? name = null)
        {
            return en.Execute("ImageAugmentationLayer[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an association of lists of bounding boxes for each identified category of objects in image.
        /// https://reference.wolfram.com/language/ref/ImageBoundingBoxes.html
        ///</summary>
        public static Engine ImageBoundingBoxes(this Engine en, string? name = null)
        {
            return en.Execute("ImageBoundingBoxes[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an association of lists of subimages for each identified category of objects in image.
        /// https://reference.wolfram.com/language/ref/ImageCases.html
        ///</summary>
        public static Engine ImageCases(this Engine en, string? name = null)
        {
            return en.Execute("ImageCases[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of channels present in the data for the Image or Image3D object image.
        /// https://reference.wolfram.com/language/ref/ImageChannels.html
        ///</summary>
        public static Engine ImageChannels(this Engine en, string? name = null)
        {
            return en.Execute("ImageChannels[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// clips all channel values in image to lie in the default range.
        /// https://reference.wolfram.com/language/ref/ImageClip.html
        ///</summary>
        public static Engine ImageClip(this Engine en, string? name = null)
        {
            return en.Execute("ImageClip[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a collage of images imagei.
        /// https://reference.wolfram.com/language/ref/ImageCollage.html
        ///</summary>
        public static Engine ImageCollage(this Engine en, string? name = null)
        {
            return en.Execute("ImageCollage[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the name of the color space of image.
        /// https://reference.wolfram.com/language/ref/ImageColorSpace.html
        ///</summary>
        public static Engine ImageColorSpace(this Engine en, string? name = null)
        {
            return en.Execute("ImageColorSpace[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a dataset of identified entities in image.
        /// https://reference.wolfram.com/language/ref/ImageContents.html
        ///</summary>
        public static Engine ImageContents(this Engine en, string? name = null)
        {
            return en.Execute("ImageContents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds corners in image and returns their coordinates.
        /// https://reference.wolfram.com/language/ref/ImageCorners.html
        ///</summary>
        public static Engine ImageCorners(this Engine en, string? name = null)
        {
            return en.Execute("ImageCorners[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// crops image by removing borders of uniform color.
        /// https://reference.wolfram.com/language/ref/ImageCrop.html
        ///</summary>
        public static Engine ImageCrop(this Engine en, string? name = null)
        {
            return en.Execute("ImageCrop[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the array of pixel values in an Image or Image3D object image.
        /// https://reference.wolfram.com/language/ref/ImageData.html
        ///</summary>
        public static Engine ImageData(this Engine en, string? name = null)
        {
            return en.Execute("ImageData[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the pixel dimensions of an Image or Image3D object image.
        /// https://reference.wolfram.com/language/ref/ImageDimensions.html
        ///</summary>
        public static Engine ImageDimensions(this Engine en, string? name = null)
        {
            return en.Execute("ImageDimensions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives estimated horizontal and vertical displacements between consecutive images.
        /// https://reference.wolfram.com/language/ref/ImageDisplacements.html
        ///</summary>
        public static Engine ImageDisplacements(this Engine en, string? name = null)
        {
            return en.Execute("ImageDisplacements[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// combines differently exposed images imagei of the same scene into a single image with overall good exposure.
        /// https://reference.wolfram.com/language/ref/ImageExposureCombine.html
        ///</summary>
        public static Engine ImageExposureCombine(this Engine en, string? name = null)
        {
            return en.Execute("ImageExposureCombine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tracks features from image1 through imagen.
        /// https://reference.wolfram.com/language/ref/ImageFeatureTrack.html
        ///</summary>
        public static Engine ImageFeatureTrack(this Engine en, string? name = null)
        {
            return en.Execute("ImageFeatureTrack[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// combines differently focused images imagei of the same scene to obtain a single well-focused image.
        /// https://reference.wolfram.com/language/ref/ImageFocusCombine.html
        ///</summary>
        public static Engine ImageFocusCombine(this Engine en, string? name = null)
        {
            return en.Execute("ImageFocusCombine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds a segmentation of image, returning an integer matrix in which positive integers label different components.
        /// https://reference.wolfram.com/language/ref/ImageForestingComponents.html
        ///</summary>
        public static Engine ImageForestingComponents(this Engine en, string? name = null)
        {
            return en.Execute("ImageForestingComponents[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the content of image in the form of scalable vector graphics.
        /// https://reference.wolfram.com/language/ref/ImageGraphics.html
        ///</summary>
        public static Engine ImageGraphics(this Engine en, string? name = null)
        {
            return en.Execute("ImageGraphics[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots a histogram of the pixel levels for each channel in image.
        /// https://reference.wolfram.com/language/ref/ImageHistogram.html
        ///</summary>
        public static Engine ImageHistogram(this Engine en, string? name = null)
        {
            return en.Execute("ImageHistogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields the result of attempting to identify what image is a picture of.
        /// https://reference.wolfram.com/language/ref/ImageIdentify.html
        ///</summary>
        public static Engine ImageIdentify(this Engine en, string? name = null)
        {
            return en.Execute("ImageIdentify[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds key features in image and returns their coordinates.
        /// https://reference.wolfram.com/language/ref/ImageKeypoints.html
        ///</summary>
        public static Engine ImageKeypoints(this Engine en, string? name = null)
        {
            return en.Execute("ImageKeypoints[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of pixel values and counts for each channel in image.
        /// https://reference.wolfram.com/language/ref/ImageLevels.html
        ///</summary>
        public static Engine ImageLevels(this Engine en, string? name = null)
        {
            return en.Execute("ImageLevels[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds line segments in image and returns the coordinates of their endpoints.
        /// https://reference.wolfram.com/language/ref/ImageLines.html
        ///</summary>
        public static Engine ImageLines(this Engine en, string? name = null)
        {
            return en.Execute("ImageLines[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a HighlightImage specification that represents a marker at position pos.
        /// https://reference.wolfram.com/language/ref/ImageMarker.html
        ///</summary>
        public static Engine ImageMarker(this Engine en, string? name = null)
        {
            return en.Execute("ImageMarker[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the foreground region in image as a BoundaryMeshRegion object.
        /// https://reference.wolfram.com/language/ref/ImageMesh.html
        ///</summary>
        public static Engine ImageMesh(this Engine en, string? name = null)
        {
            return en.Execute("ImageMesh[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// shows the squared magnitude of the discrete Fourier transform (power spectrum) of image.
        /// https://reference.wolfram.com/language/ref/ImagePeriodogram.html
        ///</summary>
        public static Engine ImagePeriodogram(this Engine en, string? name = null)
        {
            return en.Execute("ImagePeriodogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an association of image positions for each identified category of objects in image.
        /// https://reference.wolfram.com/language/ref/ImagePosition.html
        ///</summary>
        public static Engine ImagePosition(this Engine en, string? name = null)
        {
            return en.Execute("ImagePosition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates a Gaussian image pyramid formed from image.
        /// https://reference.wolfram.com/language/ref/ImagePyramid.html
        ///</summary>
        public static Engine ImagePyramid(this Engine en, string? name = null)
        {
            return en.Execute("ImagePyramid[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields True if image has the form of a valid Image or Image3D object, and False otherwise.
        /// https://reference.wolfram.com/language/ref/ImageQ.html
        ///</summary>
        public static Engine ImageQ(this Engine en, string? name = null)
        {
            return en.Execute("ImageQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// reverses image by top-bottom mirror reflection.
        /// https://reference.wolfram.com/language/ref/ImageReflect.html
        ///</summary>
        public static Engine ImageReflect(this Engine en, string? name = null)
        {
            return en.Execute("ImageReflect[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// rotates image by 90° about its center in the - plane.
        /// https://reference.wolfram.com/language/ref/ImageRotate.html
        ///</summary>
        public static Engine ImageRotate(this Engine en, string? name = null)
        {
            return en.Execute("ImageRotate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns a saliency map for image.
        /// https://reference.wolfram.com/language/ref/ImageSaliencyFilter.html
        ///</summary>
        public static Engine ImageSaliencyFilter(this Engine en, string? name = null)
        {
            return en.Execute("ImageSaliencyFilter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the position of a graphical object in terms of coordinates scaled to run from 0 to 1 across the whole image region in each direction.
        /// https://reference.wolfram.com/language/ref/ImageScaled.html
        ///</summary>
        public static Engine ImageScaled(this Engine en, string? name = null)
        {
            return en.Execute("ImageScaled[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a composed image from an unordered list of imagei.
        /// https://reference.wolfram.com/language/ref/ImageStitch.html
        ///</summary>
        public static Engine ImageStitch(this Engine en, string? name = null)
        {
            return en.Execute("ImageStitch[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the underlying type of values used for each pixel element in the Image or Image3D object image.
        /// https://reference.wolfram.com/language/ref/ImageType.html
        ///</summary>
        public static Engine ImageType(this Engine en, string? name = null)
        {
            return en.Execute("ImageType[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the chrominance of image.
        /// https://reference.wolfram.com/language/ref/ImageVectorscopePlot.html
        ///</summary>
        public static Engine ImageVectorscopePlot(this Engine en, string? name = null)
        {
            return en.Execute("ImageVectorscopePlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// plots the waveform of image.
        /// https://reference.wolfram.com/language/ref/ImageWaveformPlot.html
        ///</summary>
        public static Engine ImageWaveformPlot(this Engine en, string? name = null)
        {
            return en.Execute("ImageWaveformPlot[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// imports data from source, returning a Wolfram Language representation of it.
        /// https://reference.wolfram.com/language/ref/Import.html
        ///</summary>
        public static Engine Import(this Engine en, string? name = null)
        {
            return en.Execute("Import[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// attempts to determine the format automatically.
        /// https://reference.wolfram.com/language/ref/ImportByteArray.html
        ///</summary>
        public static Engine ImportByteArray(this Engine en, string? name = null)
        {
            return en.Execute("ImportByteArray[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a piece of imported data that has no special representation in the Wolfram Language.
        /// https://reference.wolfram.com/language/ref/ImportedObject.html
        ///</summary>
        public static Engine ImportedObject(this Engine en, string? name = null)
        {
            return en.Execute("ImportedObject[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// attempts to determine the format of the string from its contents.
        /// https://reference.wolfram.com/language/ref/ImportString.html
        ///</summary>
        public static Engine ImportString(this Engine en, string? name = null)
        {
            return en.Execute("ImportString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a global object that is assigned to have a delayed value of the n input line.
        /// https://reference.wolfram.com/language/ref/In.html
        ///</summary>
        public static Engine In(this Engine en, string? name = null)
        {
            return en.Execute("In[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// replaces all instances of f with Inactive[f] for symbols f used as heads in expr.
        /// https://reference.wolfram.com/language/ref/Inactivate.html
        ///</summary>
        public static Engine Inactivate(this Engine en, string? name = null)
        {
            return en.Execute("Inactivate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is an inactive form of f.
        /// https://reference.wolfram.com/language/ref/Inactive.html
        ///</summary>
        public static Engine Inactive(this Engine en, string? name = null)
        {
            return en.Execute("Inactive[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the graph with incidence matrix m.
        /// https://reference.wolfram.com/language/ref/IncidenceGraph.html
        ///</summary>
        public static Engine IncidenceGraph(this Engine en, string? name = null)
        {
            return en.Execute("IncidenceGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the vertex-edge incidence matrix of the graph g.
        /// https://reference.wolfram.com/language/ref/IncidenceMatrix.html
        ///</summary>
        public static Engine IncidenceMatrix(this Engine en, string? name = null)
        {
            return en.Execute("IncidenceMatrix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if m is explicitly indefinite, and False otherwise.
        /// https://reference.wolfram.com/language/ref/IndefiniteMatrixQ.html
        ///</summary>
        public static Engine IndefiniteMatrixQ(this Engine en, string? name = null)
        {
            return en.Execute("IndefiniteMatrixQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a physical quantity string with no relationship to other physical quantities used in QuantityVariable.
        /// https://reference.wolfram.com/language/ref/IndependentPhysicalQuantity.html
        ///</summary>
        public static Engine IndependentPhysicalQuantity(this Engine en, string? name = null)
        {
            return en.Execute("IndependentPhysicalQuantity[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a unit string with no relationship to other units within a Quantity.
        /// https://reference.wolfram.com/language/ref/IndependentUnit.html
        ///</summary>
        public static Engine IndependentUnit(this Engine en, string? name = null)
        {
            return en.Execute("IndependentUnit[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the base dimension dim associated with an independent physical quantity or unit.
        /// https://reference.wolfram.com/language/ref/IndependentUnitDimension.html
        ///</summary>
        public static Engine IndependentUnitDimension(this Engine en, string? name = null)
        {
            return en.Execute("IndependentUnitDimension[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// sets tags of edges in the graph g to their edge indices.
        /// https://reference.wolfram.com/language/ref/IndexEdgeTaggedGraph.html
        ///</summary>
        public static Engine IndexEdgeTaggedGraph(this Engine en, string? name = null)
        {
            return en.Execute("IndexEdgeTaggedGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// replaces the vertices of the graph g by its vertex indices.
        /// https://reference.wolfram.com/language/ref/IndexGraph.html
        ///</summary>
        public static Engine IndexGraph(this Engine en, string? name = null)
        {
            return en.Execute("IndexGraph[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// evaluates an "InertExpression", returning a new "InertExpression" in compiled code.
        /// https://reference.wolfram.com/language/ref/InertEvaluate.html
        ///</summary>
        public static Engine InertEvaluate(this Engine en, string? name = null)
        {
            return en.Execute("InertEvaluate[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// creates an inert expression in compiled code.
        /// https://reference.wolfram.com/language/ref/InertExpression.html
        ///</summary>
        public static Engine InertExpression(this Engine en, string? name = null)
        {
            return en.Execute("InertExpression[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns True if expr is an inexact real or complex number, and returns False otherwise.
        /// https://reference.wolfram.com/language/ref/InexactNumberQ.html
        ///</summary>
        public static Engine InexactNumberQ(this Engine en, string? name = null)
        {
            return en.Execute("InexactNumberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the infinite straight line passing through the points p1 and p2.
        /// https://reference.wolfram.com/language/ref/InfiniteLine.html
        ///</summary>
        public static Engine InfiniteLine(this Engine en, string? name = null)
        {
            return en.Execute("InfiniteLine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives an infinite line passing through the points pi.
        /// https://reference.wolfram.com/language/ref/InfiniteLineThrough.html
        ///</summary>
        public static Engine InfiniteLineThrough(this Engine en, string? name = null)
        {
            return en.Execute("InfiniteLineThrough[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the plane passing through the points p1, p2, and p3.
        /// https://reference.wolfram.com/language/ref/InfinitePlane.html
        ///</summary>
        public static Engine InfinitePlane(this Engine en, string? name = null)
        {
            return en.Execute("InfinitePlane[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints with f[e1,e2,…] given in default infix form: e1~f~e2~f~e3….
        /// https://reference.wolfram.com/language/ref/Infix.html
        ///</summary>
        public static Engine Infix(this Engine en, string? name = null)
        {
            return en.Execute("Infix[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// uses the current year as targetdate.
        /// https://reference.wolfram.com/language/ref/InflationAdjust.html
        ///</summary>
        public static Engine InflationAdjust(this Engine en, string? name = null)
        {
            return en.Execute("InflationAdjust[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives information about the expression expr.
        /// https://reference.wolfram.com/language/ref/Information.html
        ///</summary>
        public static Engine Information(this Engine en, string? name = null)
        {
            return en.Execute("Information[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives all persistent initialization objects for symbols matching the string pattern "patt".
        /// https://reference.wolfram.com/language/ref/InitializationObjects.html
        ///</summary>
        public static Engine InitializationObjects(this Engine en, string? name = null)
        {
            return en.Execute("InitializationObjects[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the settable persistent value with which the symbol sym will be initialized.
        /// https://reference.wolfram.com/language/ref/InitializationValue.html
        ///</summary>
        public static Engine InitializationValue(this Engine en, string? name = null)
        {
            return en.Execute("InitializationValue[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// initializes the symbol sym from persistent values on the default persistence path.
        /// https://reference.wolfram.com/language/ref/Initialize.html
        ///</summary>
        public static Engine Initialize(this Engine en, string? name = null)
        {
            return en.Execute("Initialize[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inner polygon of the polygon poly.
        /// https://reference.wolfram.com/language/ref/InnerPolygon.html
        ///</summary>
        public static Engine InnerPolygon(this Engine en, string? name = null)
        {
            return en.Execute("InnerPolygon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inner polyhedron of the polyhedron poly.
        /// https://reference.wolfram.com/language/ref/InnerPolyhedron.html
        ///</summary>
        public static Engine InnerPolyhedron(this Engine en, string? name = null)
        {
            return en.Execute("InnerPolyhedron[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// requests input, displaying prompt as a "prompt".
        /// https://reference.wolfram.com/language/ref/Input.html
        ///</summary>
        public static Engine Input(this Engine en, string? name = null)
        {
            return en.Execute("Input[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an editable input field that currently contains the expression x.
        /// https://reference.wolfram.com/language/ref/InputField.html
        ///</summary>
        public static Engine InputField(this Engine en, string? name = null)
        {
            return en.Execute("InputField[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// prints as a version of expr suitable for input to the Wolfram Language.
        /// https://reference.wolfram.com/language/ref/InputForm.html
        ///</summary>
        public static Engine InputForm(this Engine en, string? name = null)
        {
            return en.Execute("InputForm[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a WSTP packet that contains in string the name to be assigned to the next input.
        /// https://reference.wolfram.com/language/ref/InputNamePacket.html
        ///</summary>
        public static Engine InputNamePacket(this Engine en, string? name = null)
        {
            return en.Execute("InputNamePacket[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// requests input, displaying prompt as a "prompt".
        /// https://reference.wolfram.com/language/ref/InputString.html
        ///</summary>
        public static Engine InputString(this Engine en, string? name = null)
        {
            return en.Execute("InputString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// inserts newline characters into string to make a string in which no line is longer than 78 characters.
        /// https://reference.wolfram.com/language/ref/InsertLinebreaks.html
        ///</summary>
        public static Engine InsertLinebreaks(this Engine en, string? name = null)
        {
            return en.Execute("InsertLinebreaks[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an object obj inset in a graphic.
        /// https://reference.wolfram.com/language/ref/Inset.html
        ///</summary>
        public static Engine Inset(this Engine en, string? name = null)
        {
            return en.Execute("Inset[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the sphere that can be inscribed in the simplex defined by points pi in .
        /// https://reference.wolfram.com/language/ref/Insphere.html
        ///</summary>
        public static Engine Insphere(this Engine en, string? name = null)
        {
            return en.Execute("Insphere[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// starts a WSTP-compatible external program and installs Wolfram Language definitions to call functions in it.
        /// https://reference.wolfram.com/language/ref/Install.html
        ///</summary>
        public static Engine Install(this Engine en, string? name = null)
        {
            return en.Execute("Install[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// installs the web service operations in the WSDL description at the URL given.
        /// https://reference.wolfram.com/language/ref/InstallService.html
        ///</summary>
        public static Engine InstallService(this Engine en, string? name = null)
        {
            return en.Execute("InstallService[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a global object that is assigned to be the text of the n input line.
        /// https://reference.wolfram.com/language/ref/InString.html
        ///</summary>
        public static Engine InString(this Engine en, string? name = null)
        {
            return en.Execute("InString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of the decimal digits in the integer n.
        /// https://reference.wolfram.com/language/ref/IntegerDigits.html
        ///</summary>
        public static Engine IntegerDigits(this Engine en, string? name = null)
        {
            return en.Execute("IntegerDigits[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the number of digits in the base 10 representation of the integer n.
        /// https://reference.wolfram.com/language/ref/IntegerLength.html
        ///</summary>
        public static Engine IntegerLength(this Engine en, string? name = null)
        {
            return en.Execute("IntegerLength[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a string containing the full English name of the integer n.
        /// https://reference.wolfram.com/language/ref/IntegerName.html
        ///</summary>
        public static Engine IntegerName(this Engine en, string? name = null)
        {
            return en.Execute("IntegerName[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the integer part of x.
        /// https://reference.wolfram.com/language/ref/IntegerPart.html
        ///</summary>
        public static Engine IntegerPart(this Engine en, string? name = null)
        {
            return en.Execute("IntegerPart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a list of all possible ways to partition the integer n into smaller integers.
        /// https://reference.wolfram.com/language/ref/IntegerPartitions.html
        ///</summary>
        public static Engine IntegerPartitions(this Engine en, string? name = null)
        {
            return en.Execute("IntegerPartitions[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives True if expr is an integer, and False otherwise.
        /// https://reference.wolfram.com/language/ref/IntegerQ.html
        ///</summary>
        public static Engine IntegerQ(this Engine en, string? name = null)
        {
            return en.Execute("IntegerQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the integer whose digits are reversed with respect to those of the integer n.
        /// https://reference.wolfram.com/language/ref/IntegerReverse.html
        ///</summary>
        public static Engine IntegerReverse(this Engine en, string? name = null)
        {
            return en.Execute("IntegerReverse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a string consisting of the decimal digits in the integer n.
        /// https://reference.wolfram.com/language/ref/IntegerString.html
        ///</summary>
        public static Engine IntegerString(this Engine en, string? name = null)
        {
            return en.Execute("IntegerString[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// makes a financial chart for the financial entity "name" over the daterange.
        /// https://reference.wolfram.com/language/ref/InteractiveTradingChart.html
        ///</summary>
        public static Engine InteractiveTradingChart(this Engine en, string? name = null)
        {
            return en.Execute("InteractiveTradingChart[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// yields the internally balanced decomposition of the state-space model ssm.
        /// https://reference.wolfram.com/language/ref/InternallyBalancedDecomposition.html
        ///</summary>
        public static Engine InternallyBalancedDecomposition(this Engine en, string? name = null)
        {
            return en.Execute("InternallyBalancedDecomposition[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// constructs an interpolation of the function values fi, assumed to correspond to x values 1, 2, … .
        /// https://reference.wolfram.com/language/ref/Interpolation.html
        ///</summary>
        public static Engine Interpolation(this Engine en, string? name = null)
        {
            return en.Execute("Interpolation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an interpreter object that can be applied to an input to try to interpret it as an object of the specified form.
        /// https://reference.wolfram.com/language/ref/Interpreter.html
        ///</summary>
        public static Engine Interpreter(this Engine en, string? name = null)
        {
            return en.Execute("Interpreter[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the difference between the upper and lower quartiles for the elements in list.
        /// https://reference.wolfram.com/language/ref/InterquartileRange.html
        ///</summary>
        public static Engine InterquartileRange(this Engine en, string? name = null)
        {
            return en.Execute("InterquartileRange[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of IntersectingQ that can be applied to another list.
        /// https://reference.wolfram.com/language/ref/IntersectingQ.html
        ///</summary>
        public static Engine IntersectingQ(this Engine en, string? name = null)
        {
            return en.Execute("IntersectingQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the range of values between min and max.
        /// https://reference.wolfram.com/language/ref/Interval.html
        ///</summary>
        public static Engine Interval(this Engine en, string? name = null)
        {
            return en.Execute("Interval[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an operator form of IntervalMemberQ that can be applied to a number.
        /// https://reference.wolfram.com/language/ref/IntervalMemberQ.html
        ///</summary>
        public static Engine IntervalMemberQ(this Engine en, string? name = null)
        {
            return en.Execute("IntervalMemberQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents a slider with setting {xmin,xmax} in the range 0 to 1.
        /// https://reference.wolfram.com/language/ref/IntervalSlider.html
        ///</summary>
        public static Engine IntervalSlider(this Engine en, string? name = null)
        {
            return en.Execute("IntervalSlider[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse of a square matrix m.
        /// https://reference.wolfram.com/language/ref/Inverse.html
        ///</summary>
        public static Engine Inverse(this Engine en, string? name = null)
        {
            return en.Execute("Inverse[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents an inverse  distribution with ν degrees of freedom.
        /// https://reference.wolfram.com/language/ref/InverseChiSquareDistribution.html
        ///</summary>
        public static Engine InverseChiSquareDistribution(this Engine en, string? name = null)
        {
            return en.Execute("InverseChiSquareDistribution[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse continuous wavelet transform of a ContinuousWaveletData object cwd.
        /// https://reference.wolfram.com/language/ref/InverseContinuousWaveletTransform.html
        ///</summary>
        public static Engine InverseContinuousWaveletTransform(this Engine en, string? name = null)
        {
            return en.Execute("InverseContinuousWaveletTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse distance transform of image, returning the result as a binary image.
        /// https://reference.wolfram.com/language/ref/InverseDistanceTransform.html
        ///</summary>
        public static Engine InverseDistanceTransform(this Engine en, string? name = null)
        {
            return en.Execute("InverseDistanceTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the parameter m corresponding to the nome q in an elliptic function.
        /// https://reference.wolfram.com/language/ref/InverseEllipticNomeQ.html
        ///</summary>
        public static Engine InverseEllipticNomeQ(this Engine en, string? name = null)
        {
            return en.Execute("InverseEllipticNomeQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse error function obtained as the solution for z in .
        /// https://reference.wolfram.com/language/ref/InverseErf.html
        ///</summary>
        public static Engine InverseErf(this Engine en, string? name = null)
        {
            return en.Execute("InverseErf[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse complementary error function obtained as the solution for z in .
        /// https://reference.wolfram.com/language/ref/InverseErfc.html
        ///</summary>
        public static Engine InverseErfc(this Engine en, string? name = null)
        {
            return en.Execute("InverseErfc[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// finds the discrete inverse Fourier transform of a list of complex numbers.
        /// https://reference.wolfram.com/language/ref/InverseFourier.html
        ///</summary>
        public static Engine InverseFourier(this Engine en, string? name = null)
        {
            return en.Execute("InverseFourier[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// represents the inverse of the function f, defined so that InverseFunction[f][y] gives the value of x for which f[x] is equal to y.
        /// https://reference.wolfram.com/language/ref/InverseFunction.html
        ///</summary>
        public static Engine InverseFunction(this Engine en, string? name = null)
        {
            return en.Execute("InverseFunction[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse Gudermannian function .
        /// https://reference.wolfram.com/language/ref/InverseGudermannian.html
        ///</summary>
        public static Engine InverseGudermannian(this Engine en, string? name = null)
        {
            return en.Execute("InverseGudermannian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse haversine function .
        /// https://reference.wolfram.com/language/ref/InverseHaversine.html
        ///</summary>
        public static Engine InverseHaversine(this Engine en, string? name = null)
        {
            return en.Execute("InverseHaversine[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// reconstructs an image from an ImagePyramid object pyr.
        /// https://reference.wolfram.com/language/ref/InverseImagePyramid.html
        ///</summary>
        public static Engine InverseImagePyramid(this Engine en, string? name = null)
        {
            return en.Execute("InverseImagePyramid[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// returns the inverse of permutation perm.
        /// https://reference.wolfram.com/language/ref/InversePermutation.html
        ///</summary>
        public static Engine InversePermutation(this Engine en, string? name = null)
        {
            return en.Execute("InversePermutation[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse discrete Radon transform of image.
        /// https://reference.wolfram.com/language/ref/InverseRadon.html
        ///</summary>
        public static Engine InverseRadon(this Engine en, string? name = null)
        {
            return en.Execute("InverseRadon[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// takes the series s, and gives a series for the inverse of the function represented by s.
        /// https://reference.wolfram.com/language/ref/InverseSeries.html
        ///</summary>
        public static Engine InverseSeries(this Engine en, string? name = null)
        {
            return en.Execute("InverseSeries[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// reconstructs the signal from short-time Fourier data.
        /// https://reference.wolfram.com/language/ref/InverseShortTimeFourier.html
        ///</summary>
        public static Engine InverseShortTimeFourier(this Engine en, string? name = null)
        {
            return en.Execute("InverseShortTimeFourier[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// reconstructs the signal from the magnitude spectrogram data.
        /// https://reference.wolfram.com/language/ref/InverseSpectrogram.html
        ///</summary>
        public static Engine InverseSpectrogram(this Engine en, string? name = null)
        {
            return en.Execute("InverseSpectrogram[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the inverse wavelet transform of a DiscreteWaveletData object dwd.
        /// https://reference.wolfram.com/language/ref/InverseWaveletTransform.html
        ///</summary>
        public static Engine InverseWaveletTransform(this Engine en, string? name = null)
        {
            return en.Execute("InverseWaveletTransform[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// displays as space that is the same size as the formatted version of expr.
        /// https://reference.wolfram.com/language/ref/Invisible.html
        ///</summary>
        public static Engine Invisible(this Engine en, string? name = null)
        {
            return en.Execute("Invisible[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// is a symbolic representation of an IPv4 or IPv6 IP address.
        /// https://reference.wolfram.com/language/ref/IPAddress.html
        ///</summary>
        public static Engine IPAddress(this Engine en, string? name = null)
        {
            return en.Execute("IPAddress[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// tests whether poly is an irreducible polynomial over the rationals.
        /// https://reference.wolfram.com/language/ref/IrreduciblePolynomialQ.html
        ///</summary>
        public static Engine IrreduciblePolynomialQ(this Engine en, string? name = null)
        {
            return en.Execute("IrreduciblePolynomialQ[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives a rational isolating interval for the algebraic number a.
        /// https://reference.wolfram.com/language/ref/IsolatingInterval.html
        ///</summary>
        public static Engine IsolatingInterval(this Engine en, string? name = null)
        {
            return en.Execute("IsolatingInterval[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// converts proc to a standard Ito process whenever possible.
        /// https://reference.wolfram.com/language/ref/ItoProcess.html
        ///</summary>
        public static Engine ItoProcess(this Engine en, string? name = null)
        {
            return en.Execute("ItoProcess[" + en.ValidNames.Last() + "]", name);
        }


    }
}
namespace NetWolf
{
    public static class BuiltinSymbolI
    {
		///<summary>
		///generates an icon of the specified type assuming the value given.
		///https://reference.wolfram.com/language/ref/IconData.html
		///</summary>
		public static Engine IconData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IconData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an iconized form that can be used to stand in for expr in notebook input.
		///https://reference.wolfram.com/language/ref/Iconize.html
		///</summary>
		public static Engine Iconize(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Iconize[" + arg0 + "]", name);
		}

		///<summary>
		///displays with the specified name in the icon.
		///https://reference.wolfram.com/language/ref/Iconize.html
		///</summary>
		public static Engine Iconize(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Iconize[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a regular icosahedron centered at the origin with unit edge length.
		///https://reference.wolfram.com/language/ref/Icosahedron.html
		///</summary>
		public static Engine Icosahedron(this Engine en, string? name = null)
		{
				return en.Execute("Icosahedron[]", name);
		}

		///<summary>
		///represents an icosahedron with edge length l.
		///https://reference.wolfram.com/language/ref/Icosahedron.html
		///</summary>
		public static Engine Icosahedron(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Icosahedron[" + arg0 + "]", name);
		}

		///<summary>
		///represents an icosahedron rotated by an angle θ with respect to the z axis and angle ϕ with respect to the y axis.
		///https://reference.wolfram.com/language/ref/Icosahedron.html
		///</summary>
		public static Engine Icosahedron(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Icosahedron[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives expr (the identity operation).
		///https://reference.wolfram.com/language/ref/Identity.html
		///</summary>
		public static Engine Identity(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Identity[" + arg0 + "]", name);
		}

		///<summary>
		///gives the nn identity matrix.
		///https://reference.wolfram.com/language/ref/IdentityMatrix.html
		///</summary>
		public static Engine IdentityMatrix(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IdentityMatrix[" + arg0 + "]", name);
		}

		///<summary>
		///gives t if condition evaluates to True, and f if it evaluates to False.
		///https://reference.wolfram.com/language/ref/If.html
		///</summary>
		public static Engine If(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("If[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives u if condition evaluates to neither True nor False.
		///https://reference.wolfram.com/language/ref/If.html
		///</summary>
		public static Engine If(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("If[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///is a pattern object that, for purposes of pattern matching, ignores occurrences of Inactive in both patt and the expression being matched.
		///https://reference.wolfram.com/language/ref/IgnoringInactive.html
		///</summary>
		public static Engine IgnoringInactive(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IgnoringInactive[" + arg0 + "]", name);
		}

		///<summary>
		///gives the imaginary part of the complex number .
		///https://reference.wolfram.com/language/ref/Im.html
		///</summary>
		public static Engine Im(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Im[" + arg0 + "]", name);
		}

		///<summary>
		///represents a raster image with pixel values given by the array data.
		///https://reference.wolfram.com/language/ref/Image.html
		///</summary>
		public static Engine Image(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Image[" + arg0 + "]", name);
		}

		///<summary>
		///gives an image that uses the specified options.
		///https://reference.wolfram.com/language/ref/Image.html
		///</summary>
		public static Engine Image(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Image[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a 3D image with pixel values given by the array data.
		///https://reference.wolfram.com/language/ref/Image3D.html
		///</summary>
		public static Engine Image3D(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Image3D[" + arg0 + "]", name);
		}

		///<summary>
		///creates a 3D image from a list of 2D images.
		///https://reference.wolfram.com/language/ref/Image3D.html
		///</summary>
		public static Engine Image3D(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Image3D[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///creates a 3D image of the specified data type.
		///https://reference.wolfram.com/language/ref/Image3D.html
		///</summary>
		public static Engine Image3D(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Image3D[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///takes a 3D image and returns a 2D image of maximum projection onto the - plane.
		///https://reference.wolfram.com/language/ref/Image3DProjection.html
		///</summary>
		public static Engine Image3DProjection(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Image3DProjection[" + arg0 + "]", name);
		}

		///<summary>
		///performs a projection in the direction specified by dir.
		///https://reference.wolfram.com/language/ref/Image3DProjection.html
		///</summary>
		public static Engine Image3DProjection(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Image3DProjection[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///specifies the projection mode.
		///https://reference.wolfram.com/language/ref/Image3DProjection.html
		///</summary>
		public static Engine Image3DProjection(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Image3DProjection[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives a list of 2D images corresponding to the slices in the Image3D object image.
		///https://reference.wolfram.com/language/ref/Image3DSlices.html
		///</summary>
		public static Engine Image3DSlices(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Image3DSlices[" + arg0 + "]", name);
		}

		///<summary>
		///gives the n slice as a 2D image.
		///https://reference.wolfram.com/language/ref/Image3DSlices.html
		///</summary>
		public static Engine Image3DSlices(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Image3DSlices[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///extracts the specified slices si.
		///https://reference.wolfram.com/language/ref/Image3DSlices.html
		///</summary>
		public static Engine Image3DSlices(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Image3DSlices[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///takes slices in dimension d.
		///https://reference.wolfram.com/language/ref/Image3DSlices.html
		///</summary>
		public static Engine Image3DSlices(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Image3DSlices[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives an image in which each pixel represents a sum of all pixels below and to the left of that pixel in image.
		///https://reference.wolfram.com/language/ref/ImageAccumulate.html
		///</summary>
		public static Engine ImageAccumulate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageAccumulate[" + arg0 + "]", name);
		}

		///<summary>
		///adds an amount x to each channel value in image.
		///https://reference.wolfram.com/language/ref/ImageAdd.html
		///</summary>
		public static Engine ImageAdd(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageAdd[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///adds all expri to image, where each expri can be either an image, a number, or a color value.
		///https://reference.wolfram.com/language/ref/ImageAdd.html
		///</summary>
		public static Engine ImageAdd(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageAdd[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///adjusts the levels in image, rescaling them to cover the range 0 to 1.
		///https://reference.wolfram.com/language/ref/ImageAdjust.html
		///</summary>
		public static Engine ImageAdjust(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageAdjust[" + arg0 + "]", name);
		}

		///<summary>
		///adjusts the image according to the correction specification corr.
		///https://reference.wolfram.com/language/ref/ImageAdjust.html
		///</summary>
		public static Engine ImageAdjust(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageAdjust[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///first rescales so that the range of input values inmin to inmax is mapped to 0 to 1.
		///https://reference.wolfram.com/language/ref/ImageAdjust.html
		///</summary>
		public static Engine ImageAdjust(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ImageAdjust[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///rescales so that the range of input values inmin to inmax is mapped to outmin to outmax.
		///https://reference.wolfram.com/language/ref/ImageAdjust.html
		///</summary>
		public static Engine ImageAdjust(this Engine en, string arg0, string arg1, List<string> arg2, List<string> arg3, string? name = null)
		{
				return en.Execute("ImageAdjust[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
		}

		///<summary>
		///returns a version of image that is aligned with the reference image ref.
		///https://reference.wolfram.com/language/ref/ImageAlign.html
		///</summary>
		public static Engine ImageAlign(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageAlign[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the result of aligning each of the imagei with the reference image ref.
		///https://reference.wolfram.com/language/ref/ImageAlign.html
		///</summary>
		public static Engine ImageAlign(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageAlign[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///uses image1 as the reference image.
		///https://reference.wolfram.com/language/ref/ImageAlign.html
		///</summary>
		public static Engine ImageAlign(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageAlign[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///applies the function f to the list of channel values for each pixel in image.
		///https://reference.wolfram.com/language/ref/ImageApply.html
		///</summary>
		public static Engine ImageApply(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageApply[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///applies f to the sequence of corresponding pixel values taken from each imagei.
		///https://reference.wolfram.com/language/ref/ImageApply.html
		///</summary>
		public static Engine ImageApply(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageApply[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///applies the function f to the list of channel values for each pixel in image, giving the row and column index of each pixel as a second argument to f.
		///https://reference.wolfram.com/language/ref/ImageApplyIndexed.html
		///</summary>
		public static Engine ImageApplyIndexed(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageApplyIndexed[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///applies f to the sequence of corresponding pixel values taken from each imagei, giving the corresponding row and column index of pixels as the last argument to f.
		///https://reference.wolfram.com/language/ref/ImageApplyIndexed.html
		///</summary>
		public static Engine ImageApplyIndexed(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageApplyIndexed[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the ratio of height to width for image.
		///https://reference.wolfram.com/language/ref/ImageAspectRatio.html
		///</summary>
		public static Engine ImageAspectRatio(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageAspectRatio[" + arg0 + "]", name);
		}

		///<summary>
		///assembles a single image from an array of images.
		///https://reference.wolfram.com/language/ref/ImageAssemble.html
		///</summary>
		public static Engine ImageAssemble(this Engine en, List<string> arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ImageAssemble[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///assembles images using the fitting method.
		///https://reference.wolfram.com/language/ref/ImageAssemble.html
		///</summary>
		public static Engine ImageAssemble(this Engine en, List<string> arg0, string arg1, List<string> arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageAssemble[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
		}

		///<summary>
		///represents a net layer that applies random image transformations to produce images of height h and width w.
		///https://reference.wolfram.com/language/ref/ImageAugmentationLayer.html
		///</summary>
		public static Engine ImageAugmentationLayer(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageAugmentationLayer[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives an association of lists of bounding boxes for each identified category of objects in image.
		///https://reference.wolfram.com/language/ref/ImageBoundingBoxes.html
		///</summary>
		public static Engine ImageBoundingBoxes(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageBoundingBoxes[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of bounding boxes for subimages identified as an instance of the specified category.
		///https://reference.wolfram.com/language/ref/ImageBoundingBoxes.html
		///</summary>
		public static Engine ImageBoundingBoxes(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageBoundingBoxes[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///opens a graphical user interface for capturing images from connected cameras.
		///https://reference.wolfram.com/language/ref/ImageCapture.html
		///</summary>
		public static Engine ImageCapture(this Engine en, string? name = null)
		{
				return en.Execute("ImageCapture[]", name);
		}

		///<summary>
		///gives an association of lists of subimages for each identified category of objects in image.
		///https://reference.wolfram.com/language/ref/ImageCases.html
		///</summary>
		public static Engine ImageCases(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageCases[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of subimages identified as an instance of the specified category.
		///https://reference.wolfram.com/language/ref/ImageCases.html
		///</summary>
		public static Engine ImageCases(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageCases[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an association with lists of subimages identified as being instances of each of the categoryi.
		///https://reference.wolfram.com/language/ref/ImageCases.html
		///</summary>
		public static Engine ImageCases(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageCases[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the number of channels present in the data for the Image or Image3D object image.
		///https://reference.wolfram.com/language/ref/ImageChannels.html
		///</summary>
		public static Engine ImageChannels(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageChannels[" + arg0 + "]", name);
		}

		///<summary>
		///clips all channel values in image to lie in the default range.
		///https://reference.wolfram.com/language/ref/ImageClip.html
		///</summary>
		public static Engine ImageClip(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageClip[" + arg0 + "]", name);
		}

		///<summary>
		///clips channel values to lie in the range from min to max.
		///https://reference.wolfram.com/language/ref/ImageClip.html
		///</summary>
		public static Engine ImageClip(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageClip[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives vmin for values below min and vmax for values above max.
		///https://reference.wolfram.com/language/ref/ImageClip.html
		///</summary>
		public static Engine ImageClip(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ImageClip[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///creates a collage of images imagei.
		///https://reference.wolfram.com/language/ref/ImageCollage.html
		///</summary>
		public static Engine ImageCollage(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageCollage[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///also creates a collage of images imagei based on their corresponding weights wi.
		///https://reference.wolfram.com/language/ref/ImageCollage.html
		///</summary>
		public static Engine ImageCollage(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageCollage[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///also creates a collage of images imagei based on their corresponding weights wi.
		///https://reference.wolfram.com/language/ref/ImageCollage.html
		///</summary>
		public static Engine ImageCollage(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageCollage[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///uses the fitting method to create the collage.
		///https://reference.wolfram.com/language/ref/ImageCollage.html
		///</summary>
		public static Engine ImageCollage(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageCollage[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the name of the color space of image.
		///https://reference.wolfram.com/language/ref/ImageColorSpace.html
		///</summary>
		public static Engine ImageColorSpace(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageColorSpace[" + arg0 + "]", name);
		}

		///<summary>
		///gives the result of overlaying overlay onto image.
		///https://reference.wolfram.com/language/ref/ImageCompose.html
		///</summary>
		public static Engine ImageCompose(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageCompose[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the result of alpha blending overlay into image using blending fraction α.
		///https://reference.wolfram.com/language/ref/ImageCompose.html
		///</summary>
		public static Engine ImageCompose(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageCompose[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///places the center of overlay at position pos in image.
		///https://reference.wolfram.com/language/ref/ImageCompose.html
		///</summary>
		public static Engine ImageCompose(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageCompose[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///places the point opos in overlay at position pos in image.
		///https://reference.wolfram.com/language/ref/ImageCompose.html
		///</summary>
		public static Engine ImageCompose(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageCompose[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///uses the compositing fractions fk and the specified compositing mode.
		///https://reference.wolfram.com/language/ref/ImageCompose.html
		///</summary>
		public static Engine ImageCompose(this Engine en, string arg0, string arg1, string arg2, string arg3, List<string> arg4, string? name = null)
		{
				return en.Execute("ImageCompose[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + "{" + string.Join(',', arg4) + "}" + "]", name);
		}

		///<summary>
		///returns True if an instance of the specified category is detected in image.
		///https://reference.wolfram.com/language/ref/ImageContainsQ.html
		///</summary>
		public static Engine ImageContainsQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageContainsQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns True if at least one instance of each of the categoryi is detected in image.
		///https://reference.wolfram.com/language/ref/ImageContainsQ.html
		///</summary>
		public static Engine ImageContainsQ(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageContainsQ[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives a dataset of identified entities in image.
		///https://reference.wolfram.com/language/ref/ImageContents.html
		///</summary>
		public static Engine ImageContents(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageContents[" + arg0 + "]", name);
		}

		///<summary>
		///gives a dataset that only contains entities in the specified category.
		///https://reference.wolfram.com/language/ref/ImageContents.html
		///</summary>
		public static Engine ImageContents(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageContents[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///includes the properties prop for each identified object.
		///https://reference.wolfram.com/language/ref/ImageContents.html
		///</summary>
		public static Engine ImageContents(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageContents[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the convolution of image with kernel ker.
		///https://reference.wolfram.com/language/ref/ImageConvolve.html
		///</summary>
		public static Engine ImageConvolve(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageConvolve[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the n×n co-occurrence matrix for image.
		///https://reference.wolfram.com/language/ref/ImageCooccurrence.html
		///</summary>
		public static Engine ImageCooccurrence(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageCooccurrence[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///computes a co-occurrence matrix for arbitrary spatial relationships specified by a kernel ker.
		///https://reference.wolfram.com/language/ref/ImageCooccurrence.html
		///</summary>
		public static Engine ImageCooccurrence(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageCooccurrence[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///finds corners in image and returns their coordinates.
		///https://reference.wolfram.com/language/ref/ImageCorners.html
		///</summary>
		public static Engine ImageCorners(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageCorners[" + arg0 + "]", name);
		}

		///<summary>
		///finds corners at a pixel range r.
		///https://reference.wolfram.com/language/ref/ImageCorners.html
		///</summary>
		public static Engine ImageCorners(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageCorners[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses a threshold t for selecting corners.
		///https://reference.wolfram.com/language/ref/ImageCorners.html
		///</summary>
		public static Engine ImageCorners(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageCorners[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns corners that are at least d+1 pixels apart.
		///https://reference.wolfram.com/language/ref/ImageCorners.html
		///</summary>
		public static Engine ImageCorners(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageCorners[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the correlation of image with kernel ker.
		///https://reference.wolfram.com/language/ref/ImageCorrelate.html
		///</summary>
		public static Engine ImageCorrelate(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageCorrelate[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///computes a generalized correlation in which the function f is used in place of Dot.
		///https://reference.wolfram.com/language/ref/ImageCorrelate.html
		///</summary>
		public static Engine ImageCorrelate(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageCorrelate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///finds a set of matching interest points in image1 and image2 and returns their pixel coordinates.
		///https://reference.wolfram.com/language/ref/ImageCorrespondingPoints.html
		///</summary>
		public static Engine ImageCorrespondingPoints(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageCorrespondingPoints[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///crops image by removing borders of uniform color.
		///https://reference.wolfram.com/language/ref/ImageCrop.html
		///</summary>
		public static Engine ImageCrop(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageCrop[" + arg0 + "]", name);
		}

		///<summary>
		///crops image based on the size specification size.
		///https://reference.wolfram.com/language/ref/ImageCrop.html
		///</summary>
		public static Engine ImageCrop(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageCrop[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///crops image by removing pixels from sides specified by spec.
		///https://reference.wolfram.com/language/ref/ImageCrop.html
		///</summary>
		public static Engine ImageCrop(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageCrop[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the array of pixel values in an Image or Image3D object image.
		///https://reference.wolfram.com/language/ref/ImageData.html
		///</summary>
		public static Engine ImageData(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageData[" + arg0 + "]", name);
		}

		///<summary>
		///gives the array of pixel values converted to the specified type.
		///https://reference.wolfram.com/language/ref/ImageData.html
		///</summary>
		public static Engine ImageData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a deconvolution of image using kernel ker.
		///https://reference.wolfram.com/language/ref/ImageDeconvolve.html
		///</summary>
		public static Engine ImageDeconvolve(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageDeconvolve[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///reconstructs a color image using the specified color filter array cfa.
		///https://reference.wolfram.com/language/ref/ImageDemosaic.html
		///</summary>
		public static Engine ImageDemosaic(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageDemosaic[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///aligns the top-left pixel of the pattern with the {row,col} pixel of image.
		///https://reference.wolfram.com/language/ref/ImageDemosaic.html
		///</summary>
		public static Engine ImageDemosaic(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ImageDemosaic[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives an image in which each pixel is the absolute difference of the corresponding pixels in image1 and image2.
		///https://reference.wolfram.com/language/ref/ImageDifference.html
		///</summary>
		public static Engine ImageDifference(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageDifference[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the pixel dimensions of an Image or Image3D object image.
		///https://reference.wolfram.com/language/ref/ImageDimensions.html
		///</summary>
		public static Engine ImageDimensions(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageDimensions[" + arg0 + "]", name);
		}

		///<summary>
		///gives estimated horizontal and vertical displacements between consecutive images.
		///https://reference.wolfram.com/language/ref/ImageDisplacements.html
		///</summary>
		public static Engine ImageDisplacements(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageDisplacements[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///uses flow as an initial estimate for displacement between image1 and image2.
		///https://reference.wolfram.com/language/ref/ImageDisplacements.html
		///</summary>
		public static Engine ImageDisplacements(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageDisplacements[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns a distance measure between image1 and image2.
		///https://reference.wolfram.com/language/ref/ImageDistance.html
		///</summary>
		public static Engine ImageDistance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageDistance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///places the center of image2 at position pos in image1.
		///https://reference.wolfram.com/language/ref/ImageDistance.html
		///</summary>
		public static Engine ImageDistance(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageDistance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///places the point pos2 of image2 at position pos1 in image1.
		///https://reference.wolfram.com/language/ref/ImageDistance.html
		///</summary>
		public static Engine ImageDistance(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageDistance[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///applies the specified image effect to image.
		///https://reference.wolfram.com/language/ref/ImageEffect.html
		///</summary>
		public static Engine ImageEffect(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageEffect[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses parameters params.
		///https://reference.wolfram.com/language/ref/ImageEffect.html
		///</summary>
		public static Engine ImageEffect(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageEffect[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///combines differently exposed images imagei of the same scene into a single image with overall good exposure.
		///https://reference.wolfram.com/language/ref/ImageExposureCombine.html
		///</summary>
		public static Engine ImageExposureCombine(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageExposureCombine[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///creates a low or a high dynamic range image based on the specified mode.
		///https://reference.wolfram.com/language/ref/ImageExposureCombine.html
		///</summary>
		public static Engine ImageExposureCombine(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageExposureCombine[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///tracks features from image1 through imagen.
		///https://reference.wolfram.com/language/ref/ImageFeatureTrack.html
		///</summary>
		public static Engine ImageFeatureTrack(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageFeatureTrack[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///tracks features starting from the initial set of points pts in image1.
		///https://reference.wolfram.com/language/ref/ImageFeatureTrack.html
		///</summary>
		public static Engine ImageFeatureTrack(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageFeatureTrack[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///applies the function f to the list of channel values for each pixel of the image stored in inputfile and stores the result in outputfile.
		///https://reference.wolfram.com/language/ref/ImageFileApply.html
		///</summary>
		public static Engine ImageFileApply(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageFileApply[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///applies the function f to the range r neighborhood of each pixel in each channel of the image stored in inputfile and stores the result in outputfile.
		///https://reference.wolfram.com/language/ref/ImageFileFilter.html
		///</summary>
		public static Engine ImageFileFilter(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageFileFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///applies the function f to the list of channel values for each pixel of the image stored in inputfile.
		///https://reference.wolfram.com/language/ref/ImageFileScan.html
		///</summary>
		public static Engine ImageFileScan(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageFileScan[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///applies the function f to the range-r neighborhood of each pixel in each channel of image.
		///https://reference.wolfram.com/language/ref/ImageFilter.html
		///</summary>
		public static Engine ImageFilter(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///combines differently focused images imagei of the same scene to obtain a single well-focused image.
		///https://reference.wolfram.com/language/ref/ImageFocusCombine.html
		///</summary>
		public static Engine ImageFocusCombine(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageFocusCombine[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///finds a segmentation of image, returning an integer matrix in which positive integers label different components.
		///https://reference.wolfram.com/language/ref/ImageForestingComponents.html
		///</summary>
		public static Engine ImageForestingComponents(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageForestingComponents[" + arg0 + "]", name);
		}

		///<summary>
		///tries to find a segmentation into components that include pixels indicated by marker.
		///https://reference.wolfram.com/language/ref/ImageForestingComponents.html
		///</summary>
		public static Engine ImageForestingComponents(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageForestingComponents[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///finds components that are connected at a pixel scale given by r.
		///https://reference.wolfram.com/language/ref/ImageForestingComponents.html
		///</summary>
		public static Engine ImageForestingComponents(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageForestingComponents[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives an image in which each pixel at position f[{x,y}] corresponds to the position {x,y} in image.
		///https://reference.wolfram.com/language/ref/ImageForwardTransformation.html
		///</summary>
		public static Engine ImageForwardTransformation(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageForwardTransformation[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an image of the specified size.
		///https://reference.wolfram.com/language/ref/ImageForwardTransformation.html
		///</summary>
		public static Engine ImageForwardTransformation(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageForwardTransformation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns the content of image in the form of scalable vector graphics.
		///https://reference.wolfram.com/language/ref/ImageGraphics.html
		///</summary>
		public static Engine ImageGraphics(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageGraphics[" + arg0 + "]", name);
		}

		///<summary>
		///uses up to n colors for the vector graphics.
		///https://reference.wolfram.com/language/ref/ImageGraphics.html
		///</summary>
		public static Engine ImageGraphics(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageGraphics[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///plots a histogram of the pixel levels for each channel in image.
		///https://reference.wolfram.com/language/ref/ImageHistogram.html
		///</summary>
		public static Engine ImageHistogram(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageHistogram[" + arg0 + "]", name);
		}

		///<summary>
		///uses bin specification bspec.
		///https://reference.wolfram.com/language/ref/ImageHistogram.html
		///</summary>
		public static Engine ImageHistogram(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageHistogram[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///plots the histogram of the pixel values in the given range.
		///https://reference.wolfram.com/language/ref/ImageHistogram.html
		///</summary>
		public static Engine ImageHistogram(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageHistogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///yields the result of attempting to identify what image is a picture of.
		///https://reference.wolfram.com/language/ref/ImageIdentify.html
		///</summary>
		public static Engine ImageIdentify(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageIdentify[" + arg0 + "]", name);
		}

		///<summary>
		///restricts the identification of image to objects within the specified category.
		///https://reference.wolfram.com/language/ref/ImageIdentify.html
		///</summary>
		public static Engine ImageIdentify(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageIdentify[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of up to n possible identifications.
		///https://reference.wolfram.com/language/ref/ImageIdentify.html
		///</summary>
		public static Engine ImageIdentify(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageIdentify[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the specified property for each identification.
		///https://reference.wolfram.com/language/ref/ImageIdentify.html
		///</summary>
		public static Engine ImageIdentify(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageIdentify[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives True if image appears to be an instance of the object obj, and gives False otherwise.
		///https://reference.wolfram.com/language/ref/ImageInstanceQ.html
		///</summary>
		public static Engine ImageInstanceQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageInstanceQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///assumes that the image is of something in the category cat.
		///https://reference.wolfram.com/language/ref/ImageInstanceQ.html
		///</summary>
		public static Engine ImageInstanceQ(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageInstanceQ[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///finds key features in image and returns their coordinates.
		///https://reference.wolfram.com/language/ref/ImageKeypoints.html
		///</summary>
		public static Engine ImageKeypoints(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageKeypoints[" + arg0 + "]", name);
		}

		///<summary>
		///gives the specified property prop for each keypoint.
		///https://reference.wolfram.com/language/ref/ImageKeypoints.html
		///</summary>
		public static Engine ImageKeypoints(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageKeypoints[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of pixel values and counts for each channel in image.
		///https://reference.wolfram.com/language/ref/ImageLevels.html
		///</summary>
		public static Engine ImageLevels(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageLevels[" + arg0 + "]", name);
		}

		///<summary>
		///bins pixel values using bin specification bspec.
		///https://reference.wolfram.com/language/ref/ImageLevels.html
		///</summary>
		public static Engine ImageLevels(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageLevels[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives counts for bins in the given range.
		///https://reference.wolfram.com/language/ref/ImageLevels.html
		///</summary>
		public static Engine ImageLevels(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageLevels[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///finds line segments in image and returns the coordinates of their endpoints.
		///https://reference.wolfram.com/language/ref/ImageLines.html
		///</summary>
		public static Engine ImageLines(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageLines[" + arg0 + "]", name);
		}

		///<summary>
		///uses the threshold t for selecting image lines.
		///https://reference.wolfram.com/language/ref/ImageLines.html
		///</summary>
		public static Engine ImageLines(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageLines[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses the parameter d to control the distinctness of the detected lines.
		///https://reference.wolfram.com/language/ref/ImageLines.html
		///</summary>
		public static Engine ImageLines(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageLines[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///is a HighlightImage specification that represents a marker at position pos.
		///https://reference.wolfram.com/language/ref/ImageMarker.html
		///</summary>
		public static Engine ImageMarker(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageMarker[" + arg0 + "]", name);
		}

		///<summary>
		///represents a custom marker at position pos.
		///https://reference.wolfram.com/language/ref/ImageMarker.html
		///</summary>
		public static Engine ImageMarker(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageMarker[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents multiple marker positions posi.
		///https://reference.wolfram.com/language/ref/ImageMarker.html
		///</summary>
		public static Engine ImageMarker(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageMarker[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns the value of property "prop" for the entire image.
		///https://reference.wolfram.com/language/ref/ImageMeasurements.html
		///</summary>
		public static Engine ImageMeasurements(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageMeasurements[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns the values in the specified output format.
		///https://reference.wolfram.com/language/ref/ImageMeasurements.html
		///</summary>
		public static Engine ImageMeasurements(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageMeasurements[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns measurements for all imagei.
		///https://reference.wolfram.com/language/ref/ImageMeasurements.html
		///</summary>
		public static Engine ImageMeasurements(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageMeasurements[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns the foreground region in image as a BoundaryMeshRegion object.
		///https://reference.wolfram.com/language/ref/ImageMesh.html
		///</summary>
		public static Engine ImageMesh(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageMesh[" + arg0 + "]", name);
		}

		///<summary>
		///multiplies each channel value in image by a factor x.
		///https://reference.wolfram.com/language/ref/ImageMultiply.html
		///</summary>
		public static Engine ImageMultiply(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageMultiply[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///multiplies all expri with image, where each expri can be either an image, a number, or a color value.
		///https://reference.wolfram.com/language/ref/ImageMultiply.html
		///</summary>
		public static Engine ImageMultiply(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageMultiply[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///pads image on all sides with m background pixels.
		///https://reference.wolfram.com/language/ref/ImagePad.html
		///</summary>
		public static Engine ImagePad(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImagePad[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///pads image on all sides using the value or method specified by padding.
		///https://reference.wolfram.com/language/ref/ImagePad.html
		///</summary>
		public static Engine ImagePad(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImagePad[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///pads image with the specified numbers of pixels on each side.
		///https://reference.wolfram.com/language/ref/ImagePad.html
		///</summary>
		public static Engine ImagePad(this Engine en, string arg0, List<string> arg1, List<string> arg2, string arg3, string? name = null)
		{
				return en.Execute("ImagePad[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
		}

		///<summary>
		///pads a 3D image with the specified numbers of pixels.
		///https://reference.wolfram.com/language/ref/ImagePad.html
		///</summary>
		public static Engine ImagePad(this Engine en, string arg0, List<string> arg1, List<string> arg2, List<string> arg3, string arg4, string? name = null)
		{
				return en.Execute("ImagePad[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + ", " + arg4 + "]", name);
		}

		///<summary>
		///partitions an image into an array of ss-pixel subimages.
		///https://reference.wolfram.com/language/ref/ImagePartition.html
		///</summary>
		public static Engine ImagePartition(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImagePartition[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///partitions an image into an array of subimages of pixel width w and pixel height h.
		///https://reference.wolfram.com/language/ref/ImagePartition.html
		///</summary>
		public static Engine ImagePartition(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImagePartition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///uses pixel offsets dw and dh.
		///https://reference.wolfram.com/language/ref/ImagePartition.html
		///</summary>
		public static Engine ImagePartition(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ImagePartition[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///shows the squared magnitude of the discrete Fourier transform (power spectrum) of image.
		///https://reference.wolfram.com/language/ref/ImagePeriodogram.html
		///</summary>
		public static Engine ImagePeriodogram(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImagePeriodogram[" + arg0 + "]", name);
		}

		///<summary>
		///shows the average of power spectra of non-overlapping partitions of size n×n.
		///https://reference.wolfram.com/language/ref/ImagePeriodogram.html
		///</summary>
		public static Engine ImagePeriodogram(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImagePeriodogram[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses partitions with offset d.
		///https://reference.wolfram.com/language/ref/ImagePeriodogram.html
		///</summary>
		public static Engine ImagePeriodogram(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImagePeriodogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///applies a smoothing window wfun to each partition.
		///https://reference.wolfram.com/language/ref/ImagePeriodogram.html
		///</summary>
		public static Engine ImagePeriodogram(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImagePeriodogram[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///pads partitions with zeros to length m prior to the computation of the transform.
		///https://reference.wolfram.com/language/ref/ImagePeriodogram.html
		///</summary>
		public static Engine ImagePeriodogram(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
		{
				return en.Execute("ImagePeriodogram[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
		}

		///<summary>
		///applies a linear fractional transform specified by a matrix m to the positions of each pixel in image.
		///https://reference.wolfram.com/language/ref/ImagePerspectiveTransformation.html
		///</summary>
		public static Engine ImagePerspectiveTransformation(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImagePerspectiveTransformation[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an image of the specified size.
		///https://reference.wolfram.com/language/ref/ImagePerspectiveTransformation.html
		///</summary>
		public static Engine ImagePerspectiveTransformation(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImagePerspectiveTransformation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives an association of image positions for each identified category of objects in image.
		///https://reference.wolfram.com/language/ref/ImagePosition.html
		///</summary>
		public static Engine ImagePosition(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImagePosition[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of image positions for subimages identified as instances of the specified category.
		///https://reference.wolfram.com/language/ref/ImagePosition.html
		///</summary>
		public static Engine ImagePosition(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImagePosition[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///creates a Gaussian image pyramid formed from image.
		///https://reference.wolfram.com/language/ref/ImagePyramid.html
		///</summary>
		public static Engine ImagePyramid(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImagePyramid[" + arg0 + "]", name);
		}

		///<summary>
		///returns a Gaussian or Laplacian pyramid depending of the specified pyrtype.
		///https://reference.wolfram.com/language/ref/ImagePyramid.html
		///</summary>
		public static Engine ImagePyramid(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImagePyramid[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns up to n levels of the pyramid.
		///https://reference.wolfram.com/language/ref/ImagePyramid.html
		///</summary>
		public static Engine ImagePyramid(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImagePyramid[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns pyramid levels down to image dimensions given by size.
		///https://reference.wolfram.com/language/ref/ImagePyramid.html
		///</summary>
		public static Engine ImagePyramid(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ImagePyramid[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///returns a pyramid with successive levels downsampled by factor s.
		///https://reference.wolfram.com/language/ref/ImagePyramid.html
		///</summary>
		public static Engine ImagePyramid(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImagePyramid[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///applies f to all images in the ImagePyramid object pyr.
		///https://reference.wolfram.com/language/ref/ImagePyramidApply.html
		///</summary>
		public static Engine ImagePyramidApply(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImagePyramidApply[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///applies f to the sequence of corresponding levels taken from each pyri.
		///https://reference.wolfram.com/language/ref/ImagePyramidApply.html
		///</summary>
		public static Engine ImagePyramidApply(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImagePyramidApply[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///yields True if image has the form of a valid Image or Image3D object, and False otherwise.
		///https://reference.wolfram.com/language/ref/ImageQ.html
		///</summary>
		public static Engine ImageQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageQ[" + arg0 + "]", name);
		}

		///<summary>
		///recolors pixels in image specified by region using the specified color.
		///https://reference.wolfram.com/language/ref/ImageRecolor.html
		///</summary>
		public static Engine ImageRecolor(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageRecolor[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///recolors multiple regions.
		///https://reference.wolfram.com/language/ref/ImageRecolor.html
		///</summary>
		public static Engine ImageRecolor(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageRecolor[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///reverses image by top-bottom mirror reflection.
		///https://reference.wolfram.com/language/ref/ImageReflect.html
		///</summary>
		public static Engine ImageReflect(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageReflect[" + arg0 + "]", name);
		}

		///<summary>
		///reverses image by reflecting it so that the specified side goes to the opposite side.
		///https://reference.wolfram.com/language/ref/ImageReflect.html
		///</summary>
		public static Engine ImageReflect(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageReflect[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a resized version of image that is width pixels wide.
		///https://reference.wolfram.com/language/ref/ImageResize.html
		///</summary>
		public static Engine ImageResize(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageResize[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a resized version of image with a maximum pixel width or height given by size.
		///https://reference.wolfram.com/language/ref/ImageResize.html
		///</summary>
		public static Engine ImageResize(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageResize[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///attempts to restyle image so as to follow the graphical style of sample.
		///https://reference.wolfram.com/language/ref/ImageRestyle.html
		///</summary>
		public static Engine ImageRestyle(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageRestyle[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///attempts to restyle image using a blend of the graphical styles of the samplei.
		///https://reference.wolfram.com/language/ref/ImageRestyle.html
		///</summary>
		public static Engine ImageRestyle(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageRestyle[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///rotates image by 90° about its center in the - plane.
		///https://reference.wolfram.com/language/ref/ImageRotate.html
		///</summary>
		public static Engine ImageRotate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageRotate[" + arg0 + "]", name);
		}

		///<summary>
		///rotates image by θ radians.
		///https://reference.wolfram.com/language/ref/ImageRotate.html
		///</summary>
		public static Engine ImageRotate(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageRotate[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///rotates a 3D image around the 3D vector w.
		///https://reference.wolfram.com/language/ref/ImageRotate.html
		///</summary>
		public static Engine ImageRotate(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageRotate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives an image of the specified size.
		///https://reference.wolfram.com/language/ref/ImageRotate.html
		///</summary>
		public static Engine ImageRotate(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageRotate[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns a saliency map for image.
		///https://reference.wolfram.com/language/ref/ImageSaliencyFilter.html
		///</summary>
		public static Engine ImageSaliencyFilter(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageSaliencyFilter[" + arg0 + "]", name);
		}

		///<summary>
		///gives the position of a graphical object in terms of coordinates scaled to run from 0 to 1 across the whole image region in each direction.
		///https://reference.wolfram.com/language/ref/ImageScaled.html
		///</summary>
		public static Engine ImageScaled(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageScaled[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives a position obtained by starting at ordinary coordinates {x0,y0}, then moving by an image‐scaled offset {dx,dy}.
		///https://reference.wolfram.com/language/ref/ImageScaled.html
		///</summary>
		public static Engine ImageScaled(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageScaled[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///evaluates f applied to each pixel of image in turn.
		///https://reference.wolfram.com/language/ref/ImageScan.html
		///</summary>
		public static Engine ImageScan(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageScan[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a composed image from an unordered list of imagei.
		///https://reference.wolfram.com/language/ref/ImageStitch.html
		///</summary>
		public static Engine ImageStitch(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("ImageStitch[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///returns a stitched image from a matrix of images imageij, according to their array position.
		///https://reference.wolfram.com/language/ref/ImageStitch.html
		///</summary>
		public static Engine ImageStitch(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageStitch[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///subtracts a constant amount x from each channel value in image.
		///https://reference.wolfram.com/language/ref/ImageSubtract.html
		///</summary>
		public static Engine ImageSubtract(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageSubtract[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///subtracts all expri from image, where each expri can be either an image, a number, or a color value.
		///https://reference.wolfram.com/language/ref/ImageSubtract.html
		///</summary>
		public static Engine ImageSubtract(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImageSubtract[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives an image consisting of the first n rows of image.
		///https://reference.wolfram.com/language/ref/ImageTake.html
		///</summary>
		public static Engine ImageTake(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageTake[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives rows row1 through row2.
		///https://reference.wolfram.com/language/ref/ImageTake.html
		///</summary>
		public static Engine ImageTake(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImageTake[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the image that spans row1 to row2 and col1 to col2.
		///https://reference.wolfram.com/language/ref/ImageTake.html
		///</summary>
		public static Engine ImageTake(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ImageTake[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the 3D image consisting of the specified slices, rows, and columns.
		///https://reference.wolfram.com/language/ref/ImageTake.html
		///</summary>
		public static Engine ImageTake(this Engine en, string arg0, List<string> arg1, List<string> arg2, List<string> arg3, string? name = null)
		{
				return en.Execute("ImageTake[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
		}

		///<summary>
		///gives an image in which each pixel at position p corresponds to the position f[p] in image.
		///https://reference.wolfram.com/language/ref/ImageTransformation.html
		///</summary>
		public static Engine ImageTransformation(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageTransformation[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an image of the specified size.
		///https://reference.wolfram.com/language/ref/ImageTransformation.html
		///</summary>
		public static Engine ImageTransformation(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageTransformation[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the smallest subimage of image that includes the specified region of interest roi.
		///https://reference.wolfram.com/language/ref/ImageTrim.html
		///</summary>
		public static Engine ImageTrim(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageTrim[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///adds a margin of size r back to the resulting image.
		///https://reference.wolfram.com/language/ref/ImageTrim.html
		///</summary>
		public static Engine ImageTrim(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageTrim[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///extracts multiple subimages specified by roii from image.
		///https://reference.wolfram.com/language/ref/ImageTrim.html
		///</summary>
		public static Engine ImageTrim(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageTrim[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the underlying type of values used for each pixel element in the Image or Image3D object image.
		///https://reference.wolfram.com/language/ref/ImageType.html
		///</summary>
		public static Engine ImageType(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageType[" + arg0 + "]", name);
		}

		///<summary>
		///gives the interpolated value of image at position pos.
		///https://reference.wolfram.com/language/ref/ImageValue.html
		///</summary>
		public static Engine ImageValue(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageValue[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the value converted to the specified type.
		///https://reference.wolfram.com/language/ref/ImageValue.html
		///</summary>
		public static Engine ImageValue(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageValue[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns a list of pixel positions in image that exactly match the value val.
		///https://reference.wolfram.com/language/ref/ImageValuePositions.html
		///</summary>
		public static Engine ImageValuePositions(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageValuePositions[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns all pixel positions that have values within a distance d from val.
		///https://reference.wolfram.com/language/ref/ImageValuePositions.html
		///</summary>
		public static Engine ImageValuePositions(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImageValuePositions[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///plots the chrominance of image.
		///https://reference.wolfram.com/language/ref/ImageVectorscopePlot.html
		///</summary>
		public static Engine ImageVectorscopePlot(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageVectorscopePlot[" + arg0 + "]", name);
		}

		///<summary>
		///plots the waveform of image.
		///https://reference.wolfram.com/language/ref/ImageWaveformPlot.html
		///</summary>
		public static Engine ImageWaveformPlot(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImageWaveformPlot[" + arg0 + "]", name);
		}

		///<summary>
		///plots the waveform of image in colorspace.
		///https://reference.wolfram.com/language/ref/ImageWaveformPlot.html
		///</summary>
		public static Engine ImageWaveformPlot(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImageWaveformPlot[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the partial derivative , assuming that the variable y represents an implicit function defined by the equation eqn.
		///https://reference.wolfram.com/language/ref/ImplicitD.html
		///</summary>
		public static Engine ImplicitD(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ImplicitD[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the partial derivative , assuming that the variable y represents an implicit function defined by the equation eqn.
		///https://reference.wolfram.com/language/ref/ImplicitD.html
		///</summary>
		public static Engine ImplicitD(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ImplicitD[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the partial derivative , assuming that the variables y1,…,yk represent implicit functions defined by the system of equations eqn1∧…∧eqnk.
		///https://reference.wolfram.com/language/ref/ImplicitD.html
		///</summary>
		public static Engine ImplicitD(this Engine en, string arg0, List<string> arg1, List<string> arg2, string arg3, string? name = null)
		{
				return en.Execute("ImplicitD[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the multiple derivative .
		///https://reference.wolfram.com/language/ref/ImplicitD.html
		///</summary>
		public static Engine ImplicitD(this Engine en, string arg0, string arg1, string arg2, List<string> arg3, string? name = null)
		{
				return en.Execute("ImplicitD[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
		}

		///<summary>
		///gives the partial derivative .
		///https://reference.wolfram.com/language/ref/ImplicitD.html
		///</summary>
		public static Engine ImplicitD(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string arg5, string? name = null)
		{
				return en.Execute("ImplicitD[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + "]", name);
		}

		///<summary>
		///gives the multiple partial derivative .
		///https://reference.wolfram.com/language/ref/ImplicitD.html
		///</summary>
		public static Engine ImplicitD(this Engine en, string arg0, string arg1, string arg2, List<string> arg3, List<string> arg4, string arg5, string? name = null)
		{
				return en.Execute("ImplicitD[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + "{" + string.Join(',', arg3) + "}" + ", " + "{" + string.Join(',', arg4) + "}" + ", " + arg5 + "]", name);
		}

		///<summary>
		///represents a region in  that satisfies the conditions cond.
		///https://reference.wolfram.com/language/ref/ImplicitRegion.html
		///</summary>
		public static Engine ImplicitRegion(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("ImplicitRegion[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents the logical implication .
		///https://reference.wolfram.com/language/ref/Implies.html
		///</summary>
		public static Engine Implies(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Implies[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///imports data from source, returning a Wolfram Language representation of it.
		///https://reference.wolfram.com/language/ref/Import.html
		///</summary>
		public static Engine Import(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Import[" + arg0 + "]", name);
		}

		///<summary>
		///takes the file to be in the specified format "fmt".
		///https://reference.wolfram.com/language/ref/Import.html
		///</summary>
		public static Engine Import(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Import[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses the specified options.
		///https://reference.wolfram.com/language/ref/Import.html
		///</summary>
		public static Engine Import(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Import[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///imports data in the specified format from a ByteArray object.
		///https://reference.wolfram.com/language/ref/ImportByteArray.html
		///</summary>
		public static Engine ImportByteArray(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImportByteArray[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///attempts to determine the format automatically.
		///https://reference.wolfram.com/language/ref/ImportByteArray.html
		///</summary>
		public static Engine ImportByteArray(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImportByteArray[" + arg0 + "]", name);
		}

		///<summary>
		///represents a piece of imported data that has no special representation in the Wolfram Language.
		///https://reference.wolfram.com/language/ref/ImportedObject.html
		///</summary>
		public static Engine ImportedObject(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImportedObject[" + arg0 + "]", name);
		}

		///<summary>
		///imports data in the specified format from a string.
		///https://reference.wolfram.com/language/ref/ImportString.html
		///</summary>
		public static Engine ImportString(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImportString[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///attempts to determine the format of the string from its contents.
		///https://reference.wolfram.com/language/ref/ImportString.html
		///</summary>
		public static Engine ImportString(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ImportString[" + arg0 + "]", name);
		}

		///<summary>
		///gives the improvement importances for all components in the ReliabilityDistribution rdist at time t.
		///https://reference.wolfram.com/language/ref/ImprovementImportance.html
		///</summary>
		public static Engine ImprovementImportance(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("ImprovementImportance[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is a global object that is assigned to have a delayed value of the n input line.
		///https://reference.wolfram.com/language/ref/In.html
		///</summary>
		public static Engine In(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("In[" + arg0 + "]", name);
		}

		///<summary>
		///replaces all instances of f with Inactive[f] for symbols f used as heads in expr.
		///https://reference.wolfram.com/language/ref/Inactivate.html
		///</summary>
		public static Engine Inactivate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Inactivate[" + arg0 + "]", name);
		}

		///<summary>
		///inactivates all symbols in expr that match the pattern patt.
		///https://reference.wolfram.com/language/ref/Inactivate.html
		///</summary>
		public static Engine Inactivate(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Inactivate[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is an inactive form of f.
		///https://reference.wolfram.com/language/ref/Inactive.html
		///</summary>
		public static Engine Inactive(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Inactive[" + arg0 + "]", name);
		}

		///<summary>
		///gives the graph with incidence matrix m.
		///https://reference.wolfram.com/language/ref/IncidenceGraph.html
		///</summary>
		public static Engine IncidenceGraph(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IncidenceGraph[" + arg0 + "]", name);
		}

		///<summary>
		///gives the graph with vertices vi and incidence matrix m.
		///https://reference.wolfram.com/language/ref/IncidenceGraph.html
		///</summary>
		public static Engine IncidenceGraph(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("IncidenceGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of edges incident to vertex v.
		///https://reference.wolfram.com/language/ref/IncidenceList.html
		///</summary>
		public static Engine IncidenceList(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IncidenceList[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of incident edges d steps away.
		///https://reference.wolfram.com/language/ref/IncidenceList.html
		///</summary>
		public static Engine IncidenceList(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IncidenceList[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///uses rules vw to specify the graph g.
		///https://reference.wolfram.com/language/ref/IncidenceList.html
		///</summary>
		public static Engine IncidenceList(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("IncidenceList[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the vertex-edge incidence matrix of the graph g.
		///https://reference.wolfram.com/language/ref/IncidenceMatrix.html
		///</summary>
		public static Engine IncidenceMatrix(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IncidenceMatrix[" + arg0 + "]", name);
		}

		///<summary>
		///uses rules vw to specify the graph g.
		///https://reference.wolfram.com/language/ref/IncidenceMatrix.html
		///</summary>
		public static Engine IncidenceMatrix(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("IncidenceMatrix[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives True if m is explicitly indefinite, and False otherwise.
		///https://reference.wolfram.com/language/ref/IndefiniteMatrixQ.html
		///</summary>
		public static Engine IndefiniteMatrixQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IndefiniteMatrixQ[" + arg0 + "]", name);
		}

		///<summary>
		///tests whether the vectors v1 and v2 are independent.
		///https://reference.wolfram.com/language/ref/IndependenceTest.html
		///</summary>
		public static Engine IndependenceTest(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IndependenceTest[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields True if the edge list elist is an independent edge set of the graph g, and False otherwise.
		///https://reference.wolfram.com/language/ref/IndependentEdgeSetQ.html
		///</summary>
		public static Engine IndependentEdgeSetQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IndependentEdgeSetQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a physical quantity string with no relationship to other physical quantities used in QuantityVariable.
		///https://reference.wolfram.com/language/ref/IndependentPhysicalQuantity.html
		///</summary>
		public static Engine IndependentPhysicalQuantity(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IndependentPhysicalQuantity[" + arg0 + "]", name);
		}

		///<summary>
		///represents a unit string with no relationship to other units within a Quantity.
		///https://reference.wolfram.com/language/ref/IndependentUnit.html
		///</summary>
		public static Engine IndependentUnit(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IndependentUnit[" + arg0 + "]", name);
		}

		///<summary>
		///represents the base dimension dim associated with an independent physical quantity or unit.
		///https://reference.wolfram.com/language/ref/IndependentUnitDimension.html
		///</summary>
		public static Engine IndependentUnitDimension(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IndependentUnitDimension[" + arg0 + "]", name);
		}

		///<summary>
		///yields True if the vertex list vlist is an independent vertex set in the graph g, and False otherwise.
		///https://reference.wolfram.com/language/ref/IndependentVertexSetQ.html
		///</summary>
		public static Engine IndependentVertexSetQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IndependentVertexSetQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the component of expr with index i and formats as expri.
		///https://reference.wolfram.com/language/ref/Indexed.html
		///</summary>
		public static Engine Indexed(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Indexed[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the component with indices i, j, … and formats as expri,j,….
		///https://reference.wolfram.com/language/ref/Indexed.html
		///</summary>
		public static Engine Indexed(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Indexed[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///sets tags of edges in the graph g to their edge indices.
		///https://reference.wolfram.com/language/ref/IndexEdgeTaggedGraph.html
		///</summary>
		public static Engine IndexEdgeTaggedGraph(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IndexEdgeTaggedGraph[" + arg0 + "]", name);
		}

		///<summary>
		///sets tags of edges to r,r+1,…
		///https://reference.wolfram.com/language/ref/IndexEdgeTaggedGraph.html
		///</summary>
		public static Engine IndexEdgeTaggedGraph(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IndexEdgeTaggedGraph[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///replaces the vertices of the graph g by its vertex indices.
		///https://reference.wolfram.com/language/ref/IndexGraph.html
		///</summary>
		public static Engine IndexGraph(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IndexGraph[" + arg0 + "]", name);
		}

		///<summary>
		///replaces the vertices with integers r,  r+1, ….
		///https://reference.wolfram.com/language/ref/IndexGraph.html
		///</summary>
		public static Engine IndexGraph(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IndexGraph[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses rules vw to specify the graph g.
		///https://reference.wolfram.com/language/ref/IndexGraph.html
		///</summary>
		public static Engine IndexGraph(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("IndexGraph[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///evaluates an "InertExpression", returning a new "InertExpression" in compiled code.
		///https://reference.wolfram.com/language/ref/InertEvaluate.html
		///</summary>
		public static Engine InertEvaluate(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InertEvaluate[" + arg0 + "]", name);
		}

		///<summary>
		///creates an inert expression in compiled code.
		///https://reference.wolfram.com/language/ref/InertExpression.html
		///</summary>
		public static Engine InertExpression(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InertExpression[" + arg0 + "]", name);
		}

		///<summary>
		///returns True if expr is an inexact real or complex number, and returns False otherwise.
		///https://reference.wolfram.com/language/ref/InexactNumberQ.html
		///</summary>
		public static Engine InexactNumberQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InexactNumberQ[" + arg0 + "]", name);
		}

		///<summary>
		///represents the infinite straight line passing through the points p1 and p2.
		///https://reference.wolfram.com/language/ref/InfiniteLine.html
		///</summary>
		public static Engine InfiniteLine(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("InfiniteLine[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents the infinite straight line passing through the point p in the direction v.
		///https://reference.wolfram.com/language/ref/InfiniteLine.html
		///</summary>
		public static Engine InfiniteLine(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InfiniteLine[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives an infinite line passing through the points pi.
		///https://reference.wolfram.com/language/ref/InfiniteLineThrough.html
		///</summary>
		public static Engine InfiniteLineThrough(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("InfiniteLineThrough[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents the plane passing through the points p1, p2, and p3.
		///https://reference.wolfram.com/language/ref/InfinitePlane.html
		///</summary>
		public static Engine InfinitePlane(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("InfinitePlane[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents the plane passing through the point p in the directions v1 and v2.
		///https://reference.wolfram.com/language/ref/InfinitePlane.html
		///</summary>
		public static Engine InfinitePlane(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InfinitePlane[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///prints with f[e1,e2,…] given in default infix form: e1~f~e2~f~e3….
		///https://reference.wolfram.com/language/ref/Infix.html
		///</summary>
		public static Engine Infix(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Infix[" + arg0 + "]", name);
		}

		///<summary>
		///prints with arguments separated by h: e1 h e2 h e3….
		///https://reference.wolfram.com/language/ref/Infix.html
		///</summary>
		public static Engine Infix(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Infix[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///attempts to adjust the specified quantity purchasing power to targetdate.
		///https://reference.wolfram.com/language/ref/InflationAdjust.html
		///</summary>
		public static Engine InflationAdjust(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InflationAdjust[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///uses the current year as targetdate.
		///https://reference.wolfram.com/language/ref/InflationAdjust.html
		///</summary>
		public static Engine InflationAdjust(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InflationAdjust[" + arg0 + "]", name);
		}

		///<summary>
		///gives information about the expression expr.
		///https://reference.wolfram.com/language/ref/Information.html
		///</summary>
		public static Engine Information(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Information[" + arg0 + "]", name);
		}

		///<summary>
		///gives the value of the property prop for expr.
		///https://reference.wolfram.com/language/ref/Information.html
		///</summary>
		public static Engine Information(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Information[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives information about all of the expri.
		///https://reference.wolfram.com/language/ref/Information.html
		///</summary>
		public static Engine Information(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("Information[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an inhomogeneous Poisson point process with density function  in .
		///https://reference.wolfram.com/language/ref/InhomogeneousPoissonPointProcess.html
		///</summary>
		public static Engine InhomogeneousPoissonPointProcess(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InhomogeneousPoissonPointProcess[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an inhomogeneous Poisson process with intensity λ[t] given as a function of t.
		///https://reference.wolfram.com/language/ref/InhomogeneousPoissonProcess.html
		///</summary>
		public static Engine InhomogeneousPoissonProcess(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InhomogeneousPoissonProcess[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the persistent object where InitializationValue[sym,loc] is stored.
		///https://reference.wolfram.com/language/ref/InitializationObject.html
		///</summary>
		public static Engine InitializationObject(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InitializationObject[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the list of all persistent initialization objects in all locations in $PersistencePath.
		///https://reference.wolfram.com/language/ref/InitializationObjects.html
		///</summary>
		public static Engine InitializationObjects(this Engine en, string? name = null)
		{
				return en.Execute("InitializationObjects[]", name);
		}

		///<summary>
		///gives all persistent initialization objects for symbols matching the string pattern "patt".
		///https://reference.wolfram.com/language/ref/InitializationObjects.html
		///</summary>
		public static Engine InitializationObjects(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InitializationObjects[" + arg0 + "]", name);
		}

		///<summary>
		///gives all matching persistent initialization objects in the persistence location loc.
		///https://reference.wolfram.com/language/ref/InitializationObjects.html
		///</summary>
		public static Engine InitializationObjects(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InitializationObjects[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives all matching persistent initialization objects in all the loci.
		///https://reference.wolfram.com/language/ref/InitializationObjects.html
		///</summary>
		public static Engine InitializationObjects(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InitializationObjects[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents the settable persistent value with which the symbol sym will be initialized.
		///https://reference.wolfram.com/language/ref/InitializationValue.html
		///</summary>
		public static Engine InitializationValue(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InitializationValue[" + arg0 + "]", name);
		}

		///<summary>
		///specifies the persistence locations to search for a possible initialization value.
		///https://reference.wolfram.com/language/ref/InitializationValue.html
		///</summary>
		public static Engine InitializationValue(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InitializationValue[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///initializes the symbol sym from persistent values on the default persistence path.
		///https://reference.wolfram.com/language/ref/Initialize.html
		///</summary>
		public static Engine Initialize(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Initialize[" + arg0 + "]", name);
		}

		///<summary>
		///initializes the symbol sym from persistent values on the persistence path {loc1,…}.
		///https://reference.wolfram.com/language/ref/Initialize.html
		///</summary>
		public static Engine Initialize(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Initialize[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///is a generalization of Dot in which f plays the role of multiplication and g of addition.
		///https://reference.wolfram.com/language/ref/Inner.html
		///</summary>
		public static Engine Inner(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Inner[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the inner polygon of the polygon poly.
		///https://reference.wolfram.com/language/ref/InnerPolygon.html
		///</summary>
		public static Engine InnerPolygon(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InnerPolygon[" + arg0 + "]", name);
		}

		///<summary>
		///gives the inner polyhedron of the polyhedron poly.
		///https://reference.wolfram.com/language/ref/InnerPolyhedron.html
		///</summary>
		public static Engine InnerPolyhedron(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InnerPolyhedron[" + arg0 + "]", name);
		}

		///<summary>
		///retouches parts of image that correspond to nonzero elements in region.
		///https://reference.wolfram.com/language/ref/Inpaint.html
		///</summary>
		public static Engine Inpaint(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Inpaint[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///interactively reads in one Wolfram Language expression.
		///https://reference.wolfram.com/language/ref/Input.html
		///</summary>
		public static Engine Input(this Engine en, string? name = null)
		{
				return en.Execute("Input[]", name);
		}

		///<summary>
		///requests input, displaying prompt as a "prompt".
		///https://reference.wolfram.com/language/ref/Input.html
		///</summary>
		public static Engine Input(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Input[" + arg0 + "]", name);
		}

		///<summary>
		///in a notebook front end uses init as the initial contents of the input field.
		///https://reference.wolfram.com/language/ref/Input.html
		///</summary>
		public static Engine Input(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Input[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a blank editable input field.
		///https://reference.wolfram.com/language/ref/InputField.html
		///</summary>
		public static Engine InputField(this Engine en, string? name = null)
		{
				return en.Execute("InputField[]", name);
		}

		///<summary>
		///represents an editable input field that currently contains the expression x.
		///https://reference.wolfram.com/language/ref/InputField.html
		///</summary>
		public static Engine InputField(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InputField[" + arg0 + "]", name);
		}

		///<summary>
		///represents an input field whose contents are taken to be a string.
		///https://reference.wolfram.com/language/ref/InputField.html
		///</summary>
		public static Engine InputField(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InputField[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///prints as a version of expr suitable for input to the Wolfram Language.
		///https://reference.wolfram.com/language/ref/InputForm.html
		///</summary>
		public static Engine InputForm(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InputForm[" + arg0 + "]", name);
		}

		///<summary>
		///is a WSTP packet that contains in string the name to be assigned to the next input.
		///https://reference.wolfram.com/language/ref/InputNamePacket.html
		///</summary>
		public static Engine InputNamePacket(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InputNamePacket[" + arg0 + "]", name);
		}

		///<summary>
		///gives the current notebook into which keyboard input in the front end will be directed.
		///https://reference.wolfram.com/language/ref/InputNotebook.html
		///</summary>
		public static Engine InputNotebook(this Engine en, string? name = null)
		{
				return en.Execute("InputNotebook[]", name);
		}

		///<summary>
		///is a WSTP packet that indicates a prompt for input as generated by Input.
		///https://reference.wolfram.com/language/ref/InputPacket.html
		///</summary>
		public static Engine InputPacket(this Engine en, string? name = null)
		{
				return en.Execute("InputPacket[]", name);
		}

		///<summary>
		///is an object that represents an input stream for functions such as Read and Find.
		///https://reference.wolfram.com/language/ref/InputStream.html
		///</summary>
		public static Engine InputStream(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InputStream[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///interactively reads in a character string.
		///https://reference.wolfram.com/language/ref/InputString.html
		///</summary>
		public static Engine InputString(this Engine en, string? name = null)
		{
				return en.Execute("InputString[]", name);
		}

		///<summary>
		///requests input, displaying prompt as a "prompt".
		///https://reference.wolfram.com/language/ref/InputString.html
		///</summary>
		public static Engine InputString(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InputString[" + arg0 + "]", name);
		}

		///<summary>
		///in a notebook front end uses init as the initial contents of the input field.
		///https://reference.wolfram.com/language/ref/InputString.html
		///</summary>
		public static Engine InputString(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InputString[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is a WSTP packet that requests input in string form.
		///https://reference.wolfram.com/language/ref/InputStringPacket.html
		///</summary>
		public static Engine InputStringPacket(this Engine en, string? name = null)
		{
				return en.Execute("InputStringPacket[]", name);
		}

		///<summary>
		///inserts elem at position n in list. If n is negative, the position is counted from the end.
		///https://reference.wolfram.com/language/ref/Insert.html
		///</summary>
		public static Engine Insert(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Insert[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///inserts elem at position {i,j,…} in expr.
		///https://reference.wolfram.com/language/ref/Insert.html
		///</summary>
		public static Engine Insert(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("Insert[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///inserts elem at several positions.
		///https://reference.wolfram.com/language/ref/Insert.html
		///</summary>
		public static Engine Insert(this Engine en, string arg0, string arg1, List<string> arg2, List<string> arg3, string? name = null)
		{
				return en.Execute("Insert[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + ", " + "{" + string.Join(',', arg3) + "}" + "]", name);
		}

		///<summary>
		///represents an operator form of Insert that can be applied to an expression.
		///https://reference.wolfram.com/language/ref/Insert.html
		///</summary>
		public static Engine Insert(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Insert[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///inserts newline characters into string to make a string in which no line is longer than 78 characters.
		///https://reference.wolfram.com/language/ref/InsertLinebreaks.html
		///</summary>
		public static Engine InsertLinebreaks(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InsertLinebreaks[" + arg0 + "]", name);
		}

		///<summary>
		///inserts newline characters to make no line longer than n characters.
		///https://reference.wolfram.com/language/ref/InsertLinebreaks.html
		///</summary>
		public static Engine InsertLinebreaks(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InsertLinebreaks[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an object obj inset in a graphic.
		///https://reference.wolfram.com/language/ref/Inset.html
		///</summary>
		public static Engine Inset(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Inset[" + arg0 + "]", name);
		}

		///<summary>
		///specifies that the inset should be placed at position pos in the graphic.
		///https://reference.wolfram.com/language/ref/Inset.html
		///</summary>
		public static Engine Inset(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Inset[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///aligns the inset so that position opos in the object lies at position pos in the enclosing graphic.
		///https://reference.wolfram.com/language/ref/Inset.html
		///</summary>
		public static Engine Inset(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Inset[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///specifies the size of the inset in the coordinate system of the enclosing graphic.
		///https://reference.wolfram.com/language/ref/Inset.html
		///</summary>
		public static Engine Inset(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("Inset[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///specifies that the axes of the inset should be oriented in directions dirs.
		///https://reference.wolfram.com/language/ref/Inset.html
		///</summary>
		public static Engine Inset(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
		{
				return en.Execute("Inset[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
		}

		///<summary>
		///gives the sphere that can be inscribed in the simplex defined by points pi in .
		///https://reference.wolfram.com/language/ref/Insphere.html
		///</summary>
		public static Engine Insphere(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Insphere[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///gives the insphere of a polyhedron or polygon poly.
		///https://reference.wolfram.com/language/ref/Insphere.html
		///</summary>
		public static Engine Insphere(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Insphere[" + arg0 + "]", name);
		}

		///<summary>
		///starts a WSTP-compatible external program and installs Wolfram Language definitions to call functions in it.
		///https://reference.wolfram.com/language/ref/Install.html
		///</summary>
		public static Engine Install(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Install[" + arg0 + "]", name);
		}

		///<summary>
		///installs the web service operations in the WSDL description at the URL given.
		///https://reference.wolfram.com/language/ref/InstallService.html
		///</summary>
		public static Engine InstallService(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InstallService[" + arg0 + "]", name);
		}

		///<summary>
		///installs web service operations, creating functions in the specified context.
		///https://reference.wolfram.com/language/ref/InstallService.html
		///</summary>
		public static Engine InstallService(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InstallService[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///is a global object that is assigned to be the text of the n input line.
		///https://reference.wolfram.com/language/ref/InString.html
		///</summary>
		public static Engine InString(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InString[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of the decimal digits in the integer n.
		///https://reference.wolfram.com/language/ref/IntegerDigits.html
		///</summary>
		public static Engine IntegerDigits(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntegerDigits[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of the base b digits in the integer n.
		///https://reference.wolfram.com/language/ref/IntegerDigits.html
		///</summary>
		public static Engine IntegerDigits(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntegerDigits[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///pads the list on the left with zeros to give a list of length len.
		///https://reference.wolfram.com/language/ref/IntegerDigits.html
		///</summary>
		public static Engine IntegerDigits(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IntegerDigits[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the highest power of b that divides n.
		///https://reference.wolfram.com/language/ref/IntegerExponent.html
		///</summary>
		public static Engine IntegerExponent(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntegerExponent[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the number of digits in the base 10 representation of the integer n.
		///https://reference.wolfram.com/language/ref/IntegerLength.html
		///</summary>
		public static Engine IntegerLength(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntegerLength[" + arg0 + "]", name);
		}

		///<summary>
		///gives the number of digits in the base b representation of n.
		///https://reference.wolfram.com/language/ref/IntegerLength.html
		///</summary>
		public static Engine IntegerLength(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntegerLength[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a string containing the full English name of the integer n.
		///https://reference.wolfram.com/language/ref/IntegerName.html
		///</summary>
		public static Engine IntegerName(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntegerName[" + arg0 + "]", name);
		}

		///<summary>
		///gives a string conforming to the given qualifications.
		///https://reference.wolfram.com/language/ref/IntegerName.html
		///</summary>
		public static Engine IntegerName(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntegerName[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the integer part of x.
		///https://reference.wolfram.com/language/ref/IntegerPart.html
		///</summary>
		public static Engine IntegerPart(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntegerPart[" + arg0 + "]", name);
		}

		///<summary>
		///gives a list of all possible ways to partition the integer n into smaller integers.
		///https://reference.wolfram.com/language/ref/IntegerPartitions.html
		///</summary>
		public static Engine IntegerPartitions(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntegerPartitions[" + arg0 + "]", name);
		}

		///<summary>
		///gives partitions into at most k integers.
		///https://reference.wolfram.com/language/ref/IntegerPartitions.html
		///</summary>
		public static Engine IntegerPartitions(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntegerPartitions[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives partitions into exactly k integers.
		///https://reference.wolfram.com/language/ref/IntegerPartitions.html
		///</summary>
		public static Engine IntegerPartitions(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("IntegerPartitions[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives partitions involving only the si.
		///https://reference.wolfram.com/language/ref/IntegerPartitions.html
		///</summary>
		public static Engine IntegerPartitions(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("IntegerPartitions[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///limits the result to the first m partitions.
		///https://reference.wolfram.com/language/ref/IntegerPartitions.html
		///</summary>
		public static Engine IntegerPartitions(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("IntegerPartitions[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives True if expr is an integer, and False otherwise.
		///https://reference.wolfram.com/language/ref/IntegerQ.html
		///</summary>
		public static Engine IntegerQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntegerQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives the integer whose digits are reversed with respect to those of the integer n.
		///https://reference.wolfram.com/language/ref/IntegerReverse.html
		///</summary>
		public static Engine IntegerReverse(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntegerReverse[" + arg0 + "]", name);
		}

		///<summary>
		///gives the integer whose digits in base b are reversed with respect to those of n.
		///https://reference.wolfram.com/language/ref/IntegerReverse.html
		///</summary>
		public static Engine IntegerReverse(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntegerReverse[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the integer with reversed digits after padding n with zeros on the left to have len digits.
		///https://reference.wolfram.com/language/ref/IntegerReverse.html
		///</summary>
		public static Engine IntegerReverse(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IntegerReverse[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives a string consisting of the decimal digits in the integer n.
		///https://reference.wolfram.com/language/ref/IntegerString.html
		///</summary>
		public static Engine IntegerString(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntegerString[" + arg0 + "]", name);
		}

		///<summary>
		///gives a string consisting of the base-b digits in the integer n.
		///https://reference.wolfram.com/language/ref/IntegerString.html
		///</summary>
		public static Engine IntegerString(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntegerString[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///pads the string on the left with zero digits to give a string of length len.
		///https://reference.wolfram.com/language/ref/IntegerString.html
		///</summary>
		public static Engine IntegerString(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IntegerString[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the indefinite integral .
		///https://reference.wolfram.com/language/ref/Integrate.html
		///</summary>
		public static Engine Integrate(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Integrate[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the definite integral .
		///https://reference.wolfram.com/language/ref/Integrate.html
		///</summary>
		public static Engine Integrate(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Integrate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the multiple integral .
		///https://reference.wolfram.com/language/ref/Integrate.html
		///</summary>
		public static Engine Integrate(this Engine en, string arg0, List<string> arg1, List<string> arg2, string arg3, string? name = null)
		{
				return en.Execute("Integrate[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + ", " + arg3 + "]", name);
		}

		///<summary>
		///changes the variable in integral to the new variable u using the transformation trans.
		///https://reference.wolfram.com/language/ref/IntegrateChangeVariables.html
		///</summary>
		public static Engine IntegrateChangeVariables(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IntegrateChangeVariables[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///changes the variables to the new variables u, v, ….
		///https://reference.wolfram.com/language/ref/IntegrateChangeVariables.html
		///</summary>
		public static Engine IntegrateChangeVariables(this Engine en, string arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("IntegrateChangeVariables[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///makes a chart showing prices and volume for each date.
		///https://reference.wolfram.com/language/ref/InteractiveTradingChart.html
		///</summary>
		public static Engine InteractiveTradingChart(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InteractiveTradingChart[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///makes a financial chart for the financial entity "name" over the daterange.
		///https://reference.wolfram.com/language/ref/InteractiveTradingChart.html
		///</summary>
		public static Engine InteractiveTradingChart(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("InteractiveTradingChart[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///makes a financial chart with indicators ind1, ind2, … .
		///https://reference.wolfram.com/language/ref/InteractiveTradingChart.html
		///</summary>
		public static Engine InteractiveTradingChart(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InteractiveTradingChart[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///is a construct that behaves as if it were expri when it is in an interface environment with width sizei.
		///https://reference.wolfram.com/language/ref/InterfaceSwitched.html
		///</summary>
		public static Engine InterfaceSwitched(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InterfaceSwitched[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///behaves as if it were expri when the value of the interface parameter param corresponds to keyi.
		///https://reference.wolfram.com/language/ref/InterfaceSwitched.html
		///</summary>
		public static Engine InterfaceSwitched(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("InterfaceSwitched[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///yields the internally balanced decomposition of the state-space model ssm.
		///https://reference.wolfram.com/language/ref/InternallyBalancedDecomposition.html
		///</summary>
		public static Engine InternallyBalancedDecomposition(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InternallyBalancedDecomposition[" + arg0 + "]", name);
		}

		///<summary>
		///represents an approximate function whose values are found by interpolation.
		///https://reference.wolfram.com/language/ref/InterpolatingFunction.html
		///</summary>
		public static Engine InterpolatingFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InterpolatingFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///constructs an interpolating polynomial in x which reproduces the function values  at successive integer values 1, 2, … of .
		///https://reference.wolfram.com/language/ref/InterpolatingPolynomial.html
		///</summary>
		public static Engine InterpolatingPolynomial(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("InterpolatingPolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///constructs an interpolating polynomial for the function values  corresponding to  values .
		///https://reference.wolfram.com/language/ref/InterpolatingPolynomial.html
		///</summary>
		public static Engine InterpolatingPolynomial(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("InterpolatingPolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///constructs a multidimensional interpolating polynomial in the variables x, y, ….
		///https://reference.wolfram.com/language/ref/InterpolatingPolynomial.html
		///</summary>
		public static Engine InterpolatingPolynomial(this Engine en, List<string> arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InterpolatingPolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///constructs an interpolating polynomial that reproduces derivatives as well as function values.
		///https://reference.wolfram.com/language/ref/InterpolatingPolynomial.html
		///</summary>
		public static Engine InterpolatingPolynomial(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InterpolatingPolynomial[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///constructs an interpolation of the function values fi, assumed to correspond to x values 1, 2, … .
		///https://reference.wolfram.com/language/ref/Interpolation.html
		///</summary>
		public static Engine Interpolation(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Interpolation[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///constructs an interpolation of the function values fi corresponding to x values xi.
		///https://reference.wolfram.com/language/ref/Interpolation.html
		///</summary>
		public static Engine Interpolation(this Engine en, List<string> arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("Interpolation[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///find an interpolation of data at the point x.
		///https://reference.wolfram.com/language/ref/Interpolation.html
		///</summary>
		public static Engine Interpolation(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Interpolation[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an object that displays as e, but is interpreted as the unevaluated form of expr if supplied as input.
		///https://reference.wolfram.com/language/ref/Interpretation.html
		///</summary>
		public static Engine Interpretation(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Interpretation[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///allows local variables x, y, … in e and expr.
		///https://reference.wolfram.com/language/ref/Interpretation.html
		///</summary>
		public static Engine Interpretation(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Interpretation[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///is a low-level box construct that displays as boxes but is interpreted on input as expr.
		///https://reference.wolfram.com/language/ref/InterpretationBox.html
		///</summary>
		public static Engine InterpretationBox(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InterpretationBox[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an interpreter object that can be applied to an input to try to interpret it as an object of the specified form.
		///https://reference.wolfram.com/language/ref/Interpreter.html
		///</summary>
		public static Engine Interpreter(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Interpreter[" + arg0 + "]", name);
		}

		///<summary>
		///returns the interpreted object only if applying test to it yields True; otherwise it returns a Failure object.
		///https://reference.wolfram.com/language/ref/Interpreter.html
		///</summary>
		public static Engine Interpreter(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Interpreter[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///returns the result of applying the function fail if the test fails.
		///https://reference.wolfram.com/language/ref/Interpreter.html
		///</summary>
		public static Engine Interpreter(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Interpreter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the difference between the upper and lower quartiles for the elements in list.
		///https://reference.wolfram.com/language/ref/InterquartileRange.html
		///</summary>
		public static Engine InterquartileRange(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InterquartileRange[" + arg0 + "]", name);
		}

		///<summary>
		///generates an interrupt.
		///https://reference.wolfram.com/language/ref/Interrupt.html
		///</summary>
		public static Engine Interrupt(this Engine en, string? name = null)
		{
				return en.Execute("Interrupt[]", name);
		}

		///<summary>
		///represents an entity class containing all the entities common to all classi.
		///https://reference.wolfram.com/language/ref/IntersectedEntityClass.html
		///</summary>
		public static Engine IntersectedEntityClass(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IntersectedEntityClass[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///yields True if list1 and list2 have at least one element in common, and False otherwise.
		///https://reference.wolfram.com/language/ref/IntersectingQ.html
		///</summary>
		public static Engine IntersectingQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntersectingQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an operator form of IntersectingQ that can be applied to another list.
		///https://reference.wolfram.com/language/ref/IntersectingQ.html
		///</summary>
		public static Engine IntersectingQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntersectingQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives a sorted list of the elements common to all the listi.
		///https://reference.wolfram.com/language/ref/Intersection.html
		///</summary>
		public static Engine Intersection(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("Intersection[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents the range of values between min and max.
		///https://reference.wolfram.com/language/ref/Interval.html
		///</summary>
		public static Engine Interval(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("Interval[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///represents the union of the ranges min1 to max1, min2 to max2, ….
		///https://reference.wolfram.com/language/ref/Interval.html
		///</summary>
		public static Engine Interval(this Engine en, List<string> arg0, List<string> arg1, string arg2, string? name = null)
		{
				return en.Execute("Interval[" + "{" + string.Join(',', arg0) + "}" + ", " + "{" + string.Join(',', arg1) + "}" + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the interval representing all points common to each of the intervali.
		///https://reference.wolfram.com/language/ref/IntervalIntersection.html
		///</summary>
		public static Engine IntervalIntersection(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IntervalIntersection[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives True if the number x lies within the specified interval, and False otherwise.
		///https://reference.wolfram.com/language/ref/IntervalMemberQ.html
		///</summary>
		public static Engine IntervalMemberQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IntervalMemberQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an operator form of IntervalMemberQ that can be applied to a number.
		///https://reference.wolfram.com/language/ref/IntervalMemberQ.html
		///</summary>
		public static Engine IntervalMemberQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntervalMemberQ[" + arg0 + "]", name);
		}

		///<summary>
		///represents a slider with setting {xmin,xmax} in the range 0 to 1.
		///https://reference.wolfram.com/language/ref/IntervalSlider.html
		///</summary>
		public static Engine IntervalSlider(this Engine en, List<string> arg0, string? name = null)
		{
				return en.Execute("IntervalSlider[" + "{" + string.Join(',', arg0) + "}" + "]", name);
		}

		///<summary>
		///takes the setting to be the dynamically updated current value of int, with the value of int being reset if the slider is moved.
		///https://reference.wolfram.com/language/ref/IntervalSlider.html
		///</summary>
		public static Engine IntervalSlider(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IntervalSlider[" + arg0 + "]", name);
		}

		///<summary>
		///represents a slider with range min to max.
		///https://reference.wolfram.com/language/ref/IntervalSlider.html
		///</summary>
		public static Engine IntervalSlider(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("IntervalSlider[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives an interval containing the set of all points in any of the intervali.
		///https://reference.wolfram.com/language/ref/IntervalUnion.html
		///</summary>
		public static Engine IntervalUnion(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IntervalUnion[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the inverse of a square matrix m.
		///https://reference.wolfram.com/language/ref/Inverse.html
		///</summary>
		public static Engine Inverse(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Inverse[" + arg0 + "]", name);
		}

		///<summary>
		///gives the inverse of the regularized incomplete beta function.
		///https://reference.wolfram.com/language/ref/InverseBetaRegularized.html
		///</summary>
		public static Engine InverseBetaRegularized(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseBetaRegularized[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the inverse bilateral Laplace transform of expr.
		///https://reference.wolfram.com/language/ref/InverseBilateralLaplaceTransform.html
		///</summary>
		public static Engine InverseBilateralLaplaceTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseBilateralLaplaceTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the multidimensional inverse bilateral Laplace transform of expr.
		///https://reference.wolfram.com/language/ref/InverseBilateralLaplaceTransform.html
		///</summary>
		public static Engine InverseBilateralLaplaceTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseBilateralLaplaceTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the inverse bilateral Z transform of expr.
		///https://reference.wolfram.com/language/ref/InverseBilateralZTransform.html
		///</summary>
		public static Engine InverseBilateralZTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseBilateralZTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the multidimensional inverse bilateral Z transform of expr.
		///https://reference.wolfram.com/language/ref/InverseBilateralZTransform.html
		///</summary>
		public static Engine InverseBilateralZTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseBilateralZTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the inverse of the cumulative distribution function for the distribution dist as a function of the variable q.
		///https://reference.wolfram.com/language/ref/InverseCDF.html
		///</summary>
		public static Engine InverseCDF(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseCDF[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an inverse  distribution with ν degrees of freedom.
		///https://reference.wolfram.com/language/ref/InverseChiSquareDistribution.html
		///</summary>
		public static Engine InverseChiSquareDistribution(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseChiSquareDistribution[" + arg0 + "]", name);
		}

		///<summary>
		///represents a scaled inverse  distribution with ν degrees of freedom and scale ξ.
		///https://reference.wolfram.com/language/ref/InverseChiSquareDistribution.html
		///</summary>
		public static Engine InverseChiSquareDistribution(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseChiSquareDistribution[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse continuous wavelet transform of a ContinuousWaveletData object cwd.
		///https://reference.wolfram.com/language/ref/InverseContinuousWaveletTransform.html
		///</summary>
		public static Engine InverseContinuousWaveletTransform(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseContinuousWaveletTransform[" + arg0 + "]", name);
		}

		///<summary>
		///gives the inverse transform using the wavelet wave.
		///https://reference.wolfram.com/language/ref/InverseContinuousWaveletTransform.html
		///</summary>
		public static Engine InverseContinuousWaveletTransform(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseContinuousWaveletTransform[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse transform from the wavelet coefficients specified by octvoc.
		///https://reference.wolfram.com/language/ref/InverseContinuousWaveletTransform.html
		///</summary>
		public static Engine InverseContinuousWaveletTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseContinuousWaveletTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the inverse distance transform of image, returning the result as a binary image.
		///https://reference.wolfram.com/language/ref/InverseDistanceTransform.html
		///</summary>
		public static Engine InverseDistanceTransform(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseDistanceTransform[" + arg0 + "]", name);
		}

		///<summary>
		///gives the parameter m corresponding to the nome q in an elliptic function.
		///https://reference.wolfram.com/language/ref/InverseEllipticNomeQ.html
		///</summary>
		public static Engine InverseEllipticNomeQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseEllipticNomeQ[" + arg0 + "]", name);
		}

		///<summary>
		///gives the inverse error function obtained as the solution for z in .
		///https://reference.wolfram.com/language/ref/InverseErf.html
		///</summary>
		public static Engine InverseErf(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseErf[" + arg0 + "]", name);
		}

		///<summary>
		///gives the inverse complementary error function obtained as the solution for z in .
		///https://reference.wolfram.com/language/ref/InverseErfc.html
		///</summary>
		public static Engine InverseErfc(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseErfc[" + arg0 + "]", name);
		}

		///<summary>
		///finds the discrete inverse Fourier transform of a list of complex numbers.
		///https://reference.wolfram.com/language/ref/InverseFourier.html
		///</summary>
		public static Engine InverseFourier(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseFourier[" + arg0 + "]", name);
		}

		///<summary>
		///returns the specified positions of the discrete inverse Fourier transform.
		///https://reference.wolfram.com/language/ref/InverseFourier.html
		///</summary>
		public static Engine InverseFourier(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InverseFourier[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the symbolic inverse Fourier cosine transform of expr.
		///https://reference.wolfram.com/language/ref/InverseFourierCosTransform.html
		///</summary>
		public static Engine InverseFourierCosTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseFourierCosTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the multidimensional inverse Fourier cosine transform of expr.
		///https://reference.wolfram.com/language/ref/InverseFourierCosTransform.html
		///</summary>
		public static Engine InverseFourierCosTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseFourierCosTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the inverse discrete-time Fourier transform of expr.
		///https://reference.wolfram.com/language/ref/InverseFourierSequenceTransform.html
		///</summary>
		public static Engine InverseFourierSequenceTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseFourierSequenceTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the multidimensional inverse Fourier sequence transform.
		///https://reference.wolfram.com/language/ref/InverseFourierSequenceTransform.html
		///</summary>
		public static Engine InverseFourierSequenceTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseFourierSequenceTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the symbolic inverse Fourier sine transform of expr.
		///https://reference.wolfram.com/language/ref/InverseFourierSinTransform.html
		///</summary>
		public static Engine InverseFourierSinTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseFourierSinTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the multidimensional inverse Fourier sine transform of expr.
		///https://reference.wolfram.com/language/ref/InverseFourierSinTransform.html
		///</summary>
		public static Engine InverseFourierSinTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseFourierSinTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the symbolic inverse Fourier transform of expr.
		///https://reference.wolfram.com/language/ref/InverseFourierTransform.html
		///</summary>
		public static Engine InverseFourierTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseFourierTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the multidimensional inverse Fourier transform of expr.
		///https://reference.wolfram.com/language/ref/InverseFourierTransform.html
		///</summary>
		public static Engine InverseFourierTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseFourierTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///represents the inverse of the function f, defined so that InverseFunction[f][y] gives the value of x for which f[x] is equal to y.
		///https://reference.wolfram.com/language/ref/InverseFunction.html
		///</summary>
		public static Engine InverseFunction(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseFunction[" + arg0 + "]", name);
		}

		///<summary>
		///represents the inverse with respect to the n  argument when there are tot arguments in all.
		///https://reference.wolfram.com/language/ref/InverseFunction.html
		///</summary>
		public static Engine InverseFunction(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///represents an inverse gamma distribution with shape parameter α and scale parameter β.
		///https://reference.wolfram.com/language/ref/InverseGammaDistribution.html
		///</summary>
		public static Engine InverseGammaDistribution(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseGammaDistribution[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a generalized inverse gamma distribution with shape parameters α and γ, scale parameter β, and location parameter μ.
		///https://reference.wolfram.com/language/ref/InverseGammaDistribution.html
		///</summary>
		public static Engine InverseGammaDistribution(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("InverseGammaDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the inverse of the regularized incomplete gamma function.
		///https://reference.wolfram.com/language/ref/InverseGammaRegularized.html
		///</summary>
		public static Engine InverseGammaRegularized(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseGammaRegularized[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an inverse Gaussian distribution with mean μ and scale parameter λ.
		///https://reference.wolfram.com/language/ref/InverseGaussianDistribution.html
		///</summary>
		public static Engine InverseGaussianDistribution(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseGaussianDistribution[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents a generalized inverse Gaussian distribution with parameters μ, λ, and θ.
		///https://reference.wolfram.com/language/ref/InverseGaussianDistribution.html
		///</summary>
		public static Engine InverseGaussianDistribution(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseGaussianDistribution[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the inverse Gudermannian function .
		///https://reference.wolfram.com/language/ref/InverseGudermannian.html
		///</summary>
		public static Engine InverseGudermannian(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseGudermannian[" + arg0 + "]", name);
		}

		///<summary>
		///gives the inverse Hankel transform of order 0 for expr.
		///https://reference.wolfram.com/language/ref/InverseHankelTransform.html
		///</summary>
		public static Engine InverseHankelTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseHankelTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the inverse Hankel transform of order ν for expr.
		///https://reference.wolfram.com/language/ref/InverseHankelTransform.html
		///</summary>
		public static Engine InverseHankelTransform(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("InverseHankelTransform[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the inverse haversine function .
		///https://reference.wolfram.com/language/ref/InverseHaversine.html
		///</summary>
		public static Engine InverseHaversine(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseHaversine[" + arg0 + "]", name);
		}

		///<summary>
		///reconstructs an image from an ImagePyramid object pyr.
		///https://reference.wolfram.com/language/ref/InverseImagePyramid.html
		///</summary>
		public static Engine InverseImagePyramid(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseImagePyramid[" + arg0 + "]", name);
		}

		///<summary>
		///assumes the specified pyramid type pyrtype.
		///https://reference.wolfram.com/language/ref/InverseImagePyramid.html
		///</summary>
		public static Engine InverseImagePyramid(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseImagePyramid[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///reconstructs up to pyramid level n.
		///https://reference.wolfram.com/language/ref/InverseImagePyramid.html
		///</summary>
		public static Engine InverseImagePyramid(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseImagePyramid[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///reconstructs up to the smallest pyramid level larger than the specified size.
		///https://reference.wolfram.com/language/ref/InverseImagePyramid.html
		///</summary>
		public static Engine InverseImagePyramid(this Engine en, string arg0, string arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseImagePyramid[" + arg0 + ", " + arg1 + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiCD.html
		///</summary>
		public static Engine InverseJacobiCD(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiCD[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiCN.html
		///</summary>
		public static Engine InverseJacobiCN(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiCN[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiCS.html
		///</summary>
		public static Engine InverseJacobiCS(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiCS[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiDC.html
		///</summary>
		public static Engine InverseJacobiDC(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiDC[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiDN.html
		///</summary>
		public static Engine InverseJacobiDN(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiDN[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiDS.html
		///</summary>
		public static Engine InverseJacobiDS(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiDS[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiNC.html
		///</summary>
		public static Engine InverseJacobiNC(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiNC[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiND.html
		///</summary>
		public static Engine InverseJacobiND(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiND[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiNS.html
		///</summary>
		public static Engine InverseJacobiNS(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiNS[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiSC.html
		///</summary>
		public static Engine InverseJacobiSC(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiSC[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiSD.html
		///</summary>
		public static Engine InverseJacobiSD(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiSD[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Jacobi elliptic function .
		///https://reference.wolfram.com/language/ref/InverseJacobiSN.html
		///</summary>
		public static Engine InverseJacobiSN(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseJacobiSN[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the symbolic inverse Laplace transform of F[s] in the variable s as f[t] in the variable t.
		///https://reference.wolfram.com/language/ref/InverseLaplaceTransform.html
		///</summary>
		public static Engine InverseLaplaceTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseLaplaceTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the numeric inverse Laplace transform at the numerical value .
		///https://reference.wolfram.com/language/ref/InverseLaplaceTransform.html
		///</summary>
		public static Engine InverseLaplaceTransform(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseLaplaceTransform[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the multidimensional inverse Laplace transform of F[s1,…,sn].
		///https://reference.wolfram.com/language/ref/InverseLaplaceTransform.html
		///</summary>
		public static Engine InverseLaplaceTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseLaplaceTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///gives the inverse Mellin transform of expr.
		///https://reference.wolfram.com/language/ref/InverseMellinTransform.html
		///</summary>
		public static Engine InverseMellinTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseMellinTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///returns the inverse of permutation perm.
		///https://reference.wolfram.com/language/ref/InversePermutation.html
		///</summary>
		public static Engine InversePermutation(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InversePermutation[" + arg0 + "]", name);
		}

		///<summary>
		///gives the inverse discrete Radon transform of image.
		///https://reference.wolfram.com/language/ref/InverseRadon.html
		///</summary>
		public static Engine InverseRadon(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseRadon[" + arg0 + "]", name);
		}

		///<summary>
		///specifies the width w and the height h of the resulting image.
		///https://reference.wolfram.com/language/ref/InverseRadon.html
		///</summary>
		public static Engine InverseRadon(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InverseRadon[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///gives the inverse Radon transform of expr.
		///https://reference.wolfram.com/language/ref/InverseRadonTransform.html
		///</summary>
		public static Engine InverseRadonTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseRadonTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///takes the series s, and gives a series for the inverse of the function represented by s.
		///https://reference.wolfram.com/language/ref/InverseSeries.html
		///</summary>
		public static Engine InverseSeries(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseSeries[" + arg0 + "]", name);
		}

		///<summary>
		///uses the variable x in the inverse series.
		///https://reference.wolfram.com/language/ref/InverseSeries.html
		///</summary>
		public static Engine InverseSeries(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseSeries[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///reconstructs the signal from short-time Fourier data.
		///https://reference.wolfram.com/language/ref/InverseShortTimeFourier.html
		///</summary>
		public static Engine InverseShortTimeFourier(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseShortTimeFourier[" + arg0 + "]", name);
		}

		///<summary>
		///assumes the spectrogram data was computed with partitions of length n.
		///https://reference.wolfram.com/language/ref/InverseShortTimeFourier.html
		///</summary>
		public static Engine InverseShortTimeFourier(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseShortTimeFourier[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///assumes partitions with offset d.
		///https://reference.wolfram.com/language/ref/InverseShortTimeFourier.html
		///</summary>
		public static Engine InverseShortTimeFourier(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseShortTimeFourier[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///assumes a smoothing window wfun was applied to each partition.
		///https://reference.wolfram.com/language/ref/InverseShortTimeFourier.html
		///</summary>
		public static Engine InverseShortTimeFourier(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("InverseShortTimeFourier[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///reconstructs the signal from the magnitude spectrogram data.
		///https://reference.wolfram.com/language/ref/InverseSpectrogram.html
		///</summary>
		public static Engine InverseSpectrogram(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseSpectrogram[" + arg0 + "]", name);
		}

		///<summary>
		///assumes the spectrogram data was computed with partitions of length n.
		///https://reference.wolfram.com/language/ref/InverseSpectrogram.html
		///</summary>
		public static Engine InverseSpectrogram(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseSpectrogram[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///assumes partitions with offset d.
		///https://reference.wolfram.com/language/ref/InverseSpectrogram.html
		///</summary>
		public static Engine InverseSpectrogram(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseSpectrogram[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///assumes a smoothing window wfun was applied to each partition.
		///https://reference.wolfram.com/language/ref/InverseSpectrogram.html
		///</summary>
		public static Engine InverseSpectrogram(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("InverseSpectrogram[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///gives the inverse of the survival function for the distribution dist as a function of the variable q.
		///https://reference.wolfram.com/language/ref/InverseSurvivalFunction.html
		///</summary>
		public static Engine InverseSurvivalFunction(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseSurvivalFunction[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents the inverse transformed region , where reg is a region and f is a function.
		///https://reference.wolfram.com/language/ref/InverseTransformedRegion.html
		///</summary>
		public static Engine InverseTransformedRegion(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseTransformedRegion[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the inverse wavelet transform of a DiscreteWaveletData object dwd.
		///https://reference.wolfram.com/language/ref/InverseWaveletTransform.html
		///</summary>
		public static Engine InverseWaveletTransform(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("InverseWaveletTransform[" + arg0 + "]", name);
		}

		///<summary>
		///gives the inverse transform using the wavelet wave.
		///https://reference.wolfram.com/language/ref/InverseWaveletTransform.html
		///</summary>
		public static Engine InverseWaveletTransform(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseWaveletTransform[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse transform from the wavelet coefficients specified by wind.
		///https://reference.wolfram.com/language/ref/InverseWaveletTransform.html
		///</summary>
		public static Engine InverseWaveletTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseWaveletTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives a value of u for which the Weierstrass function  is equal to p.
		///https://reference.wolfram.com/language/ref/InverseWeierstrassP.html
		///</summary>
		public static Engine InverseWeierstrassP(this Engine en, string arg0, List<string> arg1, string? name = null)
		{
				return en.Execute("InverseWeierstrassP[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + "]", name);
		}

		///<summary>
		///represents an inverse Wishart matrix distribution with ν degrees of freedom and covariance matrix Σ.
		///https://reference.wolfram.com/language/ref/InverseWishartMatrixDistribution.html
		///</summary>
		public static Engine InverseWishartMatrixDistribution(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("InverseWishartMatrixDistribution[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the inverse Z transform of expr.
		///https://reference.wolfram.com/language/ref/InverseZTransform.html
		///</summary>
		public static Engine InverseZTransform(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("InverseZTransform[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives the multiple inverse Z transform of expr.
		///https://reference.wolfram.com/language/ref/InverseZTransform.html
		///</summary>
		public static Engine InverseZTransform(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("InverseZTransform[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///displays as space that is the same size as the formatted version of expr.
		///https://reference.wolfram.com/language/ref/Invisible.html
		///</summary>
		public static Engine Invisible(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("Invisible[" + arg0 + "]", name);
		}

		///<summary>
		///is a symbolic representation of an IPv4 or IPv6 IP address.
		///https://reference.wolfram.com/language/ref/IPAddress.html
		///</summary>
		public static Engine IPAddress(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IPAddress[" + arg0 + "]", name);
		}

		///<summary>
		///tests whether poly is an irreducible polynomial over the rationals.
		///https://reference.wolfram.com/language/ref/IrreduciblePolynomialQ.html
		///</summary>
		public static Engine IrreduciblePolynomialQ(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IrreduciblePolynomialQ[" + arg0 + "]", name);
		}

		///<summary>
		///tests whether poly is irreducible modulo a prime p.
		///https://reference.wolfram.com/language/ref/IrreduciblePolynomialQ.html
		///</summary>
		public static Engine IrreduciblePolynomialQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IrreduciblePolynomialQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the island entity.
		///https://reference.wolfram.com/language/ref/IslandData.html
		///</summary>
		public static Engine IslandData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IslandData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives a list of property values for the specified island entities.
		///https://reference.wolfram.com/language/ref/IslandData.html
		///</summary>
		public static Engine IslandData(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("IslandData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the specified annotation associated with the given property.
		///https://reference.wolfram.com/language/ref/IslandData.html
		///</summary>
		public static Engine IslandData(this Engine en, string arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("IslandData[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///gives a rational isolating interval for the algebraic number a.
		///https://reference.wolfram.com/language/ref/IsolatingInterval.html
		///</summary>
		public static Engine IsolatingInterval(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("IsolatingInterval[" + arg0 + "]", name);
		}

		///<summary>
		///gives an isolating interval of width at most dx.
		///https://reference.wolfram.com/language/ref/IsolatingInterval.html
		///</summary>
		public static Engine IsolatingInterval(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IsolatingInterval[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields True if the graphs g1 and g2 are isomorphic, and False otherwise.
		///https://reference.wolfram.com/language/ref/IsomorphicGraphQ.html
		///</summary>
		public static Engine IsomorphicGraphQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IsomorphicGraphQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///yields True if the graph g1 is isomorphic to a subgraph of the graph g2.
		///https://reference.wolfram.com/language/ref/IsomorphicSubgraphQ.html
		///</summary>
		public static Engine IsomorphicSubgraphQ(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IsomorphicSubgraphQ[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the value of the specified property for the isotope with atomic number Z and mass number A.
		///https://reference.wolfram.com/language/ref/IsotopeData.html
		///</summary>
		public static Engine IsotopeData(this Engine en, List<string> arg0, string arg1, string? name = null)
		{
				return en.Execute("IsotopeData[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + "]", name);
		}

		///<summary>
		///gives the value of the property for the named isotope.
		///https://reference.wolfram.com/language/ref/IsotopeData.html
		///</summary>
		public static Engine IsotopeData(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("IsotopeData[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an item within constructs such as Grid, Overlay, and Manipulate that displays with expr as the content, and with the specified options applied to the region containing expr.
		///https://reference.wolfram.com/language/ref/Item.html
		///</summary>
		public static Engine Item(this Engine en, string arg0, string arg1, string? name = null)
		{
				return en.Execute("Item[" + arg0 + ", " + arg1 + "]", name);
		}

		///<summary>
		///represents an Ito process , where .
		///https://reference.wolfram.com/language/ref/ItoProcess.html
		///</summary>
		public static Engine ItoProcess(this Engine en, List<string> arg0, string arg1, string arg2, string? name = null)
		{
				return en.Execute("ItoProcess[" + "{" + string.Join(',', arg0) + "}" + ", " + arg1 + ", " + arg2 + "]", name);
		}

		///<summary>
		///uses initial condition .
		///https://reference.wolfram.com/language/ref/ItoProcess.html
		///</summary>
		public static Engine ItoProcess(this Engine en, string arg0, List<string> arg1, List<string> arg2, string? name = null)
		{
				return en.Execute("ItoProcess[" + arg0 + ", " + "{" + string.Join(',', arg1) + "}" + ", " + "{" + string.Join(',', arg2) + "}" + "]", name);
		}

		///<summary>
		///uses a Wiener process , with covariance Σ.
		///https://reference.wolfram.com/language/ref/ItoProcess.html
		///</summary>
		public static Engine ItoProcess(this Engine en, string arg0, string arg1, string arg2, string arg3, string? name = null)
		{
				return en.Execute("ItoProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
		}

		///<summary>
		///converts proc to a standard Ito process whenever possible.
		///https://reference.wolfram.com/language/ref/ItoProcess.html
		///</summary>
		public static Engine ItoProcess(this Engine en, string arg0, string? name = null)
		{
				return en.Execute("ItoProcess[" + arg0 + "]", name);
		}

		///<summary>
		///represents an Ito process specified by a stochastic differential equation sdeqns, output expression expr, with state x and time t, driven by w following the process dproc.
		///https://reference.wolfram.com/language/ref/ItoProcess.html
		///</summary>
		public static Engine ItoProcess(this Engine en, string arg0, string arg1, string arg2, string arg3, string arg4, string? name = null)
		{
				return en.Execute("ItoProcess[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + "]", name);
		}


    }
}
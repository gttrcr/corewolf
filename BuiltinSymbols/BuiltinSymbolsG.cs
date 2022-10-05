namespace NetWolf
{
    public static class BuiltinSymbolG
    {
        ///<summary>
        ///gives the geodesic closing of image with respect to the structuring element ker.
        ///https://reference.wolfram.com/language/ref/GeodesicClosing.html
        ///</summary>
        public static Engine GeodesicClosing(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeodesicClosing[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that surfaces of 3D graphics objects that follow are to be taken to glow with color col. 
        ///https://reference.wolfram.com/language/ref/Glow.html
        ///</summary>
        public static Engine Glow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Glow[" + arg0 + "]", name);
        }

        ///<summary>
        ///is a graphics directive which specifies that surfaces of 3D graphics objects that follow are to be taken to glow with color col. 
        ///https://reference.wolfram.com/language/ref/Glow.html
        ///</summary>
        public static Engine Glow(this Engine en, string? name = null)
        {
            return en.Execute("Glow[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///returns True if the object g is an element of group and False otherwise.
        ///https://reference.wolfram.com/language/ref/GroupElementQ.html
        ///</summary>
        public static Engine GroupElementQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupElementQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the fixed point of the geodesic dilation of the marker constrained by the mask.
        ///https://reference.wolfram.com/language/ref/GeodesicDilation.html
        ///</summary>
        public static Engine GeodesicDilation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeodesicDilation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the geodesic opening of image with respect to the structuring element ker.
        ///https://reference.wolfram.com/language/ref/GeodesicOpening.html
        ///</summary>
        public static Engine GeodesicOpening(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeodesicOpening[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the order‐n geodesic polyhedron.
        ///https://reference.wolfram.com/language/ref/GeodesicPolyhedron.html
        ///</summary>
        public static Engine GeodesicPolyhedron(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeodesicPolyhedron[" + arg0 + "]", name);
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
        ///returns the list of all elements of group.
        ///https://reference.wolfram.com/language/ref/GroupElements.html
        ///</summary>
        public static Engine GroupElements(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GroupElements[" + arg0 + "]", name);
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
        ///gives a list of all possible groupings of 1,…,n taken k at a time. 
        ///https://reference.wolfram.com/language/ref/Groupings.html
        ///</summary>
        public static Engine Groupings(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Groupings[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gompertz distribution with scale parameter λ and frailty parameter ξ.
        ///https://reference.wolfram.com/language/ref/GompertzMakehamDistribution.html
        ///</summary>
        public static Engine GompertzMakehamDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GompertzMakehamDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the multiplication table of group as an array.
        ///https://reference.wolfram.com/language/ref/GroupMultiplicationTable.html
        ///</summary>
        public static Engine GroupMultiplicationTable(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GroupMultiplicationTable[" + arg0 + "]", name);
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
        ///gives the end position of the geodesic of length d starting from loc with azimuthal direction α.
        ///https://reference.wolfram.com/language/ref/GeoDestination.html
        ///</summary>
        public static Engine GeoDestination(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoDestination[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the azimuthal direction from one latitude-longitude position on the Earth to another.
        ///https://reference.wolfram.com/language/ref/GeoDirection.html
        ///</summary>
        public static Engine GeoDirection(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoDirection[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///decomposes the group element g as a product of generators of group.
        ///https://reference.wolfram.com/language/ref/GroupElementToWord.html
        ///</summary>
        public static Engine GroupElementToWord(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupElementToWord[" + arg0 + ", " + arg1 + "]", name);
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
        ///returns the orbits of the points pi under the action of the elements of group.
        ///https://reference.wolfram.com/language/ref/GroupOrbits.html
        ///</summary>
        public static Engine GroupOrbits(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupOrbits[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the value of the specified property for a named geodetic datum or reference ellipsoid.
        ///https://reference.wolfram.com/language/ref/GeodesyData.html
        ///</summary>
        public static Engine GeodesyData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeodesyData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns a list of generators of group. 
        ///https://reference.wolfram.com/language/ref/GroupGenerators.html
        ///</summary>
        public static Engine GroupGenerators(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GroupGenerators[" + arg0 + "]", name);
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
        ///returns the number of elements of group.
        ///https://reference.wolfram.com/language/ref/GroupOrder.html
        ///</summary>
        public static Engine GroupOrder(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GroupOrder[" + arg0 + "]", name);
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
        ///gives the fixed point of the geodesic erosion of the marker constrained by the mask.
        ///https://reference.wolfram.com/language/ref/GeodesicErosion.html
        ///</summary>
        public static Engine GeodesicErosion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeodesicErosion[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the Goodman–Kruskal  coefficient for the vectors v1 and v2.
        ///https://reference.wolfram.com/language/ref/GoodmanKruskalGamma.html
        ///</summary>
        public static Engine GoodmanKruskalGamma(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GoodmanKruskalGamma[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///scans for Label[tag], and transfers control to that point. 
        ///https://reference.wolfram.com/language/ref/Goto.html
        ///</summary>
        public static Engine Goto(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Goto[" + arg0 + "]", name);
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
        ///returns a list of successive stabilizers in group of the points in a base of group.
        ///https://reference.wolfram.com/language/ref/GroupStabilizerChain.html
        ///</summary>
        public static Engine GroupStabilizerChain(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GroupStabilizerChain[" + arg0 + "]", name);
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
        ///gives a MeshRegion whose gradient best fits the normals at points p1,p2,….
        ///https://reference.wolfram.com/language/ref/GradientFittedMesh.html
        ///</summary>
        public static Engine GradientFittedMesh(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GradientFittedMesh[" + arg0 + "]", name);
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
        ///represents a geodesic displacement of length dist and initial bearing α from a geo location.
        ///https://reference.wolfram.com/language/ref/GeoDisplacement.html
        ///</summary>
        public static Engine GeoDisplacement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoDisplacement[" + arg0 + "]", name);
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
        ///tests whether the vectors v1 and v2 are independent.
        ///https://reference.wolfram.com/language/ref/GoodmanKruskalGammaTest.html
        ///</summary>
        public static Engine GoodmanKruskalGammaTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GoodmanKruskalGammaTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the subgroup of elements of group that move none of the points p1, …, pn.
        ///https://reference.wolfram.com/language/ref/GroupStabilizer.html
        ///</summary>
        public static Engine GroupStabilizer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupStabilizer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Gudermannian function .
        ///https://reference.wolfram.com/language/ref/Gudermannian.html
        ///</summary>
        public static Engine Gudermannian(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Gudermannian[" + arg0 + "]", name);
        }

        ///<summary>
        ///gives the Gudermannian function .
        ///https://reference.wolfram.com/language/ref/Gudermannian.html
        ///</summary>
        public static Engine Gudermannian(this Engine en, string? name = null)
        {
            return en.Execute("Gudermannian[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///represents grammar rules to be deployed to a cloud object that implements the grammar in a form suitable for use with functions like GrammarApply and Interpreter.
        ///https://reference.wolfram.com/language/ref/GrammarRules.html
        ///</summary>
        public static Engine GrammarRules(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GrammarRules[" + arg0 + "]", name);
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
        ///creates a segmentation from image by growing each markeri. 
        ///https://reference.wolfram.com/language/ref/GrowCutComponents.html
        ///</summary>
        public static Engine GrowCutComponents(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GrowCutComponents[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the gradient .
        ///https://reference.wolfram.com/language/ref/Grad.html
        ///</summary>
        public static Engine Grad(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Grad[" + arg0 + ", " + arg1 + "]", name);
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
        ///represents a two-dimensional geographical image.
        ///https://reference.wolfram.com/language/ref/GeoGraphics.html
        ///</summary>
        public static Engine GeoGraphics(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoGraphics[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives a list of the geographic entities of type enttype contained in the extended region reg.
        ///https://reference.wolfram.com/language/ref/GeoEntities.html
        ///</summary>
        public static Engine GeoEntities(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoEntities[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gumbel distribution with location parameter α and scale parameter β.
        ///https://reference.wolfram.com/language/ref/GumbelDistribution.html
        ///</summary>
        public static Engine GumbelDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GumbelDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the list of geodesic distances between consecutive pairs of locations.
        ///https://reference.wolfram.com/language/ref/GeoDistanceList.html
        ///</summary>
        public static Engine GeoDistanceList(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoDistanceList[" + arg0 + "]", name);
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
        ///returns the subgroup of group for which the images of the points pi are still in the list {p1,…,pn}.
        ///https://reference.wolfram.com/language/ref/GroupSetwiseStabilizer.html
        ///</summary>
        public static Engine GroupSetwiseStabilizer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupSetwiseStabilizer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///attempts to parse input according to the grammar defined by grammar.
        ///https://reference.wolfram.com/language/ref/GrammarApply.html
        ///</summary>
        public static Engine GrammarApply(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GrammarApply[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the local orientation parallel to the gradient of data, computed using discrete derivatives of a Gaussian of pixel radius r, returning values between  and .
        ///https://reference.wolfram.com/language/ref/GradientOrientationFilter.html
        ///</summary>
        public static Engine GradientOrientationFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GradientOrientationFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the magnitude of the gradient of data, computed using discrete derivatives of a Gaussian of sample radius r.
        ///https://reference.wolfram.com/language/ref/GradientFilter.html
        ///</summary>
        public static Engine GradientFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GradientFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the geodesic distance between latitude-longitude positions on the Earth.
        ///https://reference.wolfram.com/language/ref/GeoDistance.html
        ///</summary>
        public static Engine GeoDistance(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoDistance[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///filters image using the guide image guide over range-r neighborhoods with pixel-value regularizer ϵ.
        ///https://reference.wolfram.com/language/ref/GuidedFilter.html
        ///</summary>
        public static Engine GuidedFilter(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("GuidedFilter[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///generates a plot of the geographic graph with edges ei.
        ///https://reference.wolfram.com/language/ref/GeoGraphPlot.html
        ///</summary>
        public static Engine GeoGraphPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoGraphPlot[" + arg0 + "]", name);
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
        ///gives a matrix that corresponds to the real part of a Gabor kernel of radius r and wave vector k.
        ///https://reference.wolfram.com/language/ref/GaborMatrix.html
        ///</summary>
        public static Engine GaborMatrix(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GaborMatrix[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        /// gives the gain margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/GainMargins.html
        ///</summary>
        public static Engine GainMargins(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GainMargins[" + arg0 + "]", name);
        }

        ///<summary>
        /// gives the gain margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/GainMargins.html
        ///</summary>
        public static Engine GainMargins(this Engine en, string? name = null)
        {
            return en.Execute("GainMargins[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        /// gives the gain and phase margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/GainPhaseMargins.html
        ///</summary>
        public static Engine GainPhaseMargins(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GainPhaseMargins[" + arg0 + "]", name);
        }

        ///<summary>
        /// gives the gain and phase margins of the linear time-invariant system lsys.
        ///https://reference.wolfram.com/language/ref/GainPhaseMargins.html
        ///</summary>
        public static Engine GainPhaseMargins(this Engine en, string? name = null)
        {
            return en.Execute("GainPhaseMargins[" + en.ValidNames.Last() + "]", name);
        }

        ///<summary>
        ///creates a graph with vertices and edges from the graph g and represented as a 3D plot.
        ///https://reference.wolfram.com/language/ref/Graph3D.html
        ///</summary>
        public static Engine Graph3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Graph3D[" + arg0 + "]", name);
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
        ///returns the gravitational field data for the current location.
        ///https://reference.wolfram.com/language/ref/GeogravityModelData.html
        ///</summary>
        public static Engine GeogravityModelData(this Engine en, string? name = null)
        {
            return en.Execute("GeogravityModelData[]", name);
        }

        ///<summary>
        ///represents a horizontal two-dimensional vector of components vx, vy in the orthonormal frame of the coordinates of the geo projection proj, at geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoGridVector.html
        ///</summary>
        public static Engine GeoGridVector(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoGridVector[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the greatest distance between any pair of vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDiameter.html
        ///</summary>
        public static Engine GraphDiameter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphDiameter[" + arg0 + "]", name);
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
        ///gives a satellite image of the geo region reg.
        ///https://reference.wolfram.com/language/ref/GeoImage.html
        ///</summary>
        public static Engine GeoImage(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoImage[" + arg0 + "]", name);
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
        ///represents a geometric distribution with probability parameter p. 
        ///https://reference.wolfram.com/language/ref/GeometricDistribution.html
        ///</summary>
        public static Engine GeometricDistribution(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeometricDistribution[" + arg0 + "]", name);
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
        ///filters data by replacing every value by the geometric mean value in its range-r neighborhood.
        ///https://reference.wolfram.com/language/ref/GeometricMeanFilter.html
        ///</summary>
        public static Engine GeometricMeanFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeometricMeanFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph difference of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphDifference.html
        ///</summary>
        public static Engine GraphDifference(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphDifference[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a 3D plot of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPlot3D.html
        ///</summary>
        public static Engine GraphPlot3D(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphPlot3D[" + arg0 + "]", name);
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
        ///gives the assortativity coefficient of a graph g using vertex degrees.
        ///https://reference.wolfram.com/language/ref/GraphAssortativity.html
        ///</summary>
        public static Engine GraphAssortativity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphAssortativity[" + arg0 + "]", name);
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
        ///represents a generalized autoregressive conditionally heteroscedastic process of orders p and q, driven by a standard white noise.
        ///https://reference.wolfram.com/language/ref/GARCHProcess.html
        ///</summary>
        public static Engine GARCHProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GARCHProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a digital signature of file using the specified private key.
        ///https://reference.wolfram.com/language/ref/GenerateFileSignature.html
        ///</summary>
        public static Engine GenerateFileSignature(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GenerateFileSignature[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///yields a graph with edges ej.
        ///https://reference.wolfram.com/language/ref/Graph.html
        ///</summary>
        public static Engine Graph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Graph[" + arg0 + "]", name);
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
        ///yields True if g is a valid Graph object and False otherwise.
        ///https://reference.wolfram.com/language/ref/GraphQ.html
        ///</summary>
        public static Engine GraphQ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphQ[" + arg0 + "]", name);
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
        ///represents a horizontal two-dimensional vector of components ve and vn in an orthonormal frame tangent to the Earth at geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoVectorENU.html
        ///</summary>
        public static Engine GeoVectorENU(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoVectorENU[" + arg0 + "]", name);
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
        ///gives the graph intersection of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphIntersection.html
        ///</summary>
        public static Engine GraphIntersection(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphIntersection[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a list of geographic objects to be treated as a single object for certain operations.
        ///https://reference.wolfram.com/language/ref/GeoGroup.html
        ///</summary>
        public static Engine GeoGroup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoGroup[" + arg0 + "]", name);
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
        ///represents a Gaussian symplectic matrix distribution with matrix dimensions {2 n,2 n} over the field of complex numbers and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/GaussianSymplecticMatrixDistribution.html
        ///</summary>
        public static Engine GaussianSymplecticMatrixDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GaussianSymplecticMatrixDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterLess.html
        ///</summary>
        public static Engine GreaterLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GreaterLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the set of vertices with maximum vertex degree in the underlying simple graph of g.
        ///https://reference.wolfram.com/language/ref/GraphHub.html
        ///</summary>
        public static Engine GraphHub(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphHub[" + arg0 + "]", name);
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
        ///generates a vector plot from the field of geo vectors vecs.
        ///https://reference.wolfram.com/language/ref/GeoVectorPlot.html
        ///</summary>
        public static Engine GeoVectorPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoVectorPlot[" + arg0 + "]", name);
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
        ///gives the graph join of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphJoin.html
        ///</summary>
        public static Engine GraphJoin(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphJoin[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a graphic in which the gi are laid out in a column, with g1 above g2, etc. 
        ///https://reference.wolfram.com/language/ref/GraphicsColumn.html
        ///</summary>
        public static Engine GraphicsColumn(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphicsColumn[" + arg0 + "]", name);
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
        ///is a GeoGraphics primitive that represents a path of type pathtype between locations loc1 and loc2.
        ///https://reference.wolfram.com/language/ref/GeoPath.html
        ///</summary>
        public static Engine GeoPath(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoPath[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the area of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoArea.html
        ///</summary>
        public static Engine GeoArea(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoArea[" + arg0 + "]", name);
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
        ///randomly generates a PrivateKey and corresponding PublicKey object for use with public-key cryptographic functions.
        ///https://reference.wolfram.com/language/ref/GenerateAsymmetricKeyPair.html
        ///</summary>
        public static Engine GenerateAsymmetricKeyPair(this Engine en, string? name = null)
        {
            return en.Execute("GenerateAsymmetricKeyPair[]", name);
        }

        ///<summary>
        ///makes a geo bubble chart with bubbles centered at the geographic regions regi with sizes vali.
        ///https://reference.wolfram.com/language/ref/GeoBubbleChart.html
        ///</summary>
        public static Engine GeoBubbleChart(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoBubbleChart[" + arg0 + "]", name);
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
        ///finds the full-dimensional part of the decomposition of the region represented by the inequalities ineqs into cylindrical parts whose directions correspond to the successive xi, together with any hypersurfaces containing the rest of the region.
        ///https://reference.wolfram.com/language/ref/GenericCylindricalDecomposition.html
        ///</summary>
        public static Engine GenericCylindricalDecomposition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GenericCylindricalDecomposition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the automorphism group of a graph g.
        ///https://reference.wolfram.com/language/ref/GraphAutomorphismGroup.html
        ///</summary>
        public static Engine GraphAutomorphismGroup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphAutomorphismGroup[" + arg0 + "]", name);
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
        ///is an object that formats with the exprij arranged in a two-dimensional grid. 
        ///https://reference.wolfram.com/language/ref/Grid.html
        ///</summary>
        public static Engine Grid(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("Grid[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterGreater.html
        ///</summary>
        public static Engine GreaterGreater(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GreaterGreater[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///returns the boundary line of the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundary.html
        ///</summary>
        public static Engine GeoBoundary(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoBoundary[" + arg0 + "]", name);
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
        ///gives the antipodal position of location loc.
        ///https://reference.wolfram.com/language/ref/GeoAntipode.html
        ///</summary>
        public static Engine GeoAntipode(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoAntipode[" + arg0 + "]", name);
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
        ///is a two-dimensional GeoGraphics primitive that represents the region on the surface of the Earth visible from the point of coordinates lat,lon and height h above the reference ellipsoid.
        ///https://reference.wolfram.com/language/ref/GeoVisibleRegion.html
        ///</summary>
        public static Engine GeoVisibleRegion(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoVisibleRegion[" + arg0 + "]", name);
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
        ///represents a Gaussian orthogonal matrix distribution with matrix dimensions {n,n} and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/GaussianOrthogonalMatrixDistribution.html
        ///</summary>
        public static Engine GaussianOrthogonalMatrixDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GaussianOrthogonalMatrixDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph disjoint union of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphDisjointUnion.html
        ///</summary>
        public static Engine GraphDisjointUnion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphDisjointUnion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a low-level box construct that represents a two-dimensional grid of boxes or strings in notebook expressions.
        ///https://reference.wolfram.com/language/ref/GridBox.html
        ///</summary>
        public static Engine GridBox(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GridBox[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///represents the result of applying the transformation function tfun to the geometric objects corresponding to the primitives g.
        ///https://reference.wolfram.com/language/ref/GeometricTransformation.html
        ///</summary>
        public static Engine GeometricTransformation(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeometricTransformation[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the geometric mean of the values in list.
        ///https://reference.wolfram.com/language/ref/GeometricMean.html
        ///</summary>
        public static Engine GeometricMean(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeometricMean[" + arg0 + "]", name);
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
        ///gives the value of the specified property for the galaxy entity.
        ///https://reference.wolfram.com/language/ref/GalaxyData.html
        ///</summary>
        public static Engine GalaxyData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GalaxyData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the length of the geo path g.
        ///https://reference.wolfram.com/language/ref/GeoLength.html
        ///</summary>
        public static Engine GeoLength(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoLength[" + arg0 + "]", name);
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
        ///gives the minimum eccentricity of the vertices in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphRadius.html
        ///</summary>
        public static Engine GraphRadius(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphRadius[" + arg0 + "]", name);
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
        ///represents a Gaussian window function of x.
        ///https://reference.wolfram.com/language/ref/GaussianWindow.html
        ///</summary>
        public static Engine GaussianWindow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GaussianWindow[" + arg0 + "]", name);
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
        ///generates a stream plot from the field of geo vectors vecs.
        ///https://reference.wolfram.com/language/ref/GeoStreamPlot.html
        ///</summary>
        public static Engine GeoStreamPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoStreamPlot[" + arg0 + "]", name);
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
        ///gives the difference between the angle from north to direction β on the geo grid obtained with projection proj and the actual angle from north to direction β at location loc.
        ///https://reference.wolfram.com/language/ref/GeoGridDirectionDifference.html
        ///</summary>
        public static Engine GeoGridDirectionDifference(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GeoGridDirectionDifference[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///displays faces of polygons and other filled geo objects using mapstyle.
        ///https://reference.wolfram.com/language/ref/GeoStyling.html
        ///</summary>
        public static Engine GeoStyling(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoStyling[" + arg0 + "]", name);
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
        ///gives the value of the specified property for the specified cartographic projection.
        ///https://reference.wolfram.com/language/ref/GeoProjectionData.html
        ///</summary>
        public static Engine GeoProjectionData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoProjectionData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a horizontal two-dimensional vector of magnitude m and bearing α at geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoVector.html
        ///</summary>
        public static Engine GeoVector(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoVector[" + arg0 + "]", name);
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
        ///gives the grid graph with m×n vertices .
        ///https://reference.wolfram.com/language/ref/GridGraph.html
        ///</summary>
        public static Engine GridGraph(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GridGraph[" + arg0 + "]", name);
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
        ///plots a smooth kernel histogram of the geo locations locs.
        ///https://reference.wolfram.com/language/ref/GeoSmoothHistogram.html
        ///</summary>
        public static Engine GeoSmoothHistogram(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoSmoothHistogram[" + arg0 + "]", name);
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
        ///gives the setting corresponding to the variable "var" in the operating system environment.
        ///https://reference.wolfram.com/language/ref/GetEnvironment.html
        ///</summary>
        public static Engine GetEnvironment(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GetEnvironment[" + arg0 + "]", name);
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
        ///gives the value of the specified property for the geological period entity.
        ///https://reference.wolfram.com/language/ref/GeologicalPeriodData.html
        ///</summary>
        public static Engine GeologicalPeriodData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeologicalPeriodData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x>y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/GreaterThan.html
        ///</summary>
        public static Engine GreaterThan(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GreaterThan[" + arg0 + "]", name);
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
        ///represents a color in the grayscale color space with gray level g.
        ///https://reference.wolfram.com/language/ref/GrayLevel.html
        ///</summary>
        public static Engine GrayLevel(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GrayLevel[" + arg0 + "]", name);
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
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterSlantEqual.html
        ///</summary>
        public static Engine GreaterSlantEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GreaterSlantEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the geo positions that define the bounding rectangle enclosing the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBoundingBox.html
        ///</summary>
        public static Engine GeoBoundingBox(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoBoundingBox[" + arg0 + "]", name);
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
        ///represents a trainable recurrent layer that takes a sequence of vectors and produces a sequence of vectors each of size n.
        ///https://reference.wolfram.com/language/ref/GatedRecurrentLayer.html
        ///</summary>
        public static Engine GatedRecurrentLayer(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GatedRecurrentLayer[" + arg0 + "]", name);
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
        ///gives a Green's function for the linear differential operator ℒ with boundary conditions ℬ in the range xmin to xmax. 
        ///https://reference.wolfram.com/language/ref/GreenFunction.html
        ///</summary>
        public static Engine GreenFunction(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("GreenFunction[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///gives the graph-n power of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPower.html
        ///</summary>
        public static Engine GraphPower(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphPower[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a two-dimensional graphical image. 
        ///https://reference.wolfram.com/language/ref/Graphics.html
        ///</summary>
        public static Engine Graphics(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Graphics[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the HTTPResponse object that is generated when a cloud object containing expr is requested on the web.
        ///https://reference.wolfram.com/language/ref/GenerateHTTPResponse.html
        ///</summary>
        public static Engine GenerateHTTPResponse(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GenerateHTTPResponse[" + arg0 + "]", name);
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
        ///represents a point {x,y} in a planimetric cartographic grid using the projection proj.
        ///https://reference.wolfram.com/language/ref/GeoGridPosition.html
        ///</summary>
        public static Engine GeoGridPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoGridPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a one-dimensional GeoGraphics primitive that represents the boundary of the region on the surface of the Earth visible from the point of coordinates lat,lon and height h above the reference ellipsoid.
        ///https://reference.wolfram.com/language/ref/GeoVisibleRegionBoundary.html
        ///</summary>
        public static Engine GeoVisibleRegionBoundary(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoVisibleRegionBoundary[" + arg0 + "]", name);
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
        ///is a GeoGraphics primitive that represents a filled polygon whose boundary is formed by geodesic segments between locations loci and loci+1.
        ///https://reference.wolfram.com/language/ref/GeoPolygon.html
        ///</summary>
        public static Engine GeoPolygon(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoPolygon[" + arg0 + "]", name);
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
        ///represents a three-dimensional vector of Cartesian components vX, vY, vZ in an orthonormal frame parallel to the geocentric frame, at location loc.
        ///https://reference.wolfram.com/language/ref/GeoVectorXYZ.html
        ///</summary>
        public static Engine GeoVectorXYZ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoVectorXYZ[" + arg0 + "]", name);
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
        ///filters data by convolving with a Gabor kernel of pixel radius r and wave vector k.
        ///https://reference.wolfram.com/language/ref/GaborFilter.html
        ///</summary>
        public static Engine GaborFilter(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GaborFilter[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
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
        ///gives the Cartesian product of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphProduct.html
        ///</summary>
        public static Engine GraphProduct(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphProduct[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the DNA sequence for the specified gene on the reference human genome.
        ///https://reference.wolfram.com/language/ref/GenomeData.html
        ///</summary>
        public static Engine GenomeData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GenomeData[" + arg0 + "]", name);
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
        ///finds positive values of variables vars that minimize the posynomial objective subject to posynomial constraints cons.
        ///https://reference.wolfram.com/language/ref/GeometricOptimization.html
        ///</summary>
        public static Engine GeometricOptimization(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GeometricOptimization[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives an association that groups the elemi into lists associated with distinct keys f[elemi].
        ///https://reference.wolfram.com/language/ref/GroupBy.html
        ///</summary>
        public static Engine GroupBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a graphics complex in which coordinates given as integers i in graphics primitives in data are taken to be pti. 
        ///https://reference.wolfram.com/language/ref/GraphicsComplex.html
        ///</summary>
        public static Engine GraphicsComplex(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphicsComplex[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gaussian unitary matrix distribution with matrix dimensions {n,n} and scale parameter σ.
        ///https://reference.wolfram.com/language/ref/GaussianUnitaryMatrixDistribution.html
        ///</summary>
        public static Engine GaussianUnitaryMatrixDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GaussianUnitaryMatrixDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///generates a map on which the locations loci are indicated.
        ///https://reference.wolfram.com/language/ref/GeoListPlot.html
        ///</summary>
        public static Engine GeoListPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoListPlot[" + arg0 + "]", name);
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
        ///gives the distance from source vertex s to target vertex t in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistance.html
        ///</summary>
        public static Engine GraphDistance(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GraphDistance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///is a two-dimensional GeoGraphics primitive that represents a circle of radius r centered at the location loc on the surface of the Earth.
        ///https://reference.wolfram.com/language/ref/GeoCircle.html
        ///</summary>
        public static Engine GeoCircle(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoCircle[" + arg0 + ", " + arg1 + "]", name);
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
        ///plots the flows between geo locations.
        ///https://reference.wolfram.com/language/ref/GeoGraphValuePlot.html
        ///</summary>
        public static Engine GeoGraphValuePlot(this Engine en, object arg0, object arg1, object arg2, object arg3, string? name = null)
        {
            return en.Execute("GeoGraphValuePlot[" + arg0 + ", " + arg1 + ", " + arg2 + ", " + arg3 + "]", name);
        }

        ///<summary>
        ///returns the geographic entity of type enttype closest to the geo location loc.
        ///https://reference.wolfram.com/language/ref/GeoNearest.html
        ///</summary>
        public static Engine GeoNearest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoNearest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a Gibbs point process with density μ and pair-potential function ϕ in .
        ///https://reference.wolfram.com/language/ref/GibbsPointProcess.html
        ///</summary>
        public static Engine GibbsPointProcess(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GibbsPointProcess[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the ranges of latitudes and longitudes in the geo region g.
        ///https://reference.wolfram.com/language/ref/GeoBounds.html
        ///</summary>
        public static Engine GeoBounds(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoBounds[" + arg0 + "]", name);
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
        ///gives the reciprocity of a graph g.
        ///https://reference.wolfram.com/language/ref/GraphReciprocity.html
        ///</summary>
        public static Engine GraphReciprocity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphReciprocity[" + arg0 + "]", name);
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
        ///represents a three-dimensional graphical image. 
        ///https://reference.wolfram.com/language/ref/Graphics3D.html
        ///</summary>
        public static Engine Graphics3D(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("Graphics3D[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the greatest common divisor of the ni. 
        ///https://reference.wolfram.com/language/ref/GCD.html
        ///</summary>
        public static Engine GCD(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GCD[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a graphic in which the gij are laid out in a two-dimensional grid.
        ///https://reference.wolfram.com/language/ref/GraphicsGrid.html
        ///</summary>
        public static Engine GraphicsGrid(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphicsGrid[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is a grammar rules pattern object that represents any input of the specified form. 
        ///https://reference.wolfram.com/language/ref/GrammarToken.html
        ///</summary>
        public static Engine GrammarToken(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GrammarToken[" + arg0 + "]", name);
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
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterTilde.html
        ///</summary>
        public static Engine GreaterTilde(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GreaterTilde[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gathers the elements of list into sublists of identical elements.
        ///https://reference.wolfram.com/language/ref/Gather.html
        ///</summary>
        public static Engine Gather(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Gather[" + arg0 + "]", name);
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
        ///returns the centralizer of the element g in group.
        ///https://reference.wolfram.com/language/ref/GroupCentralizer.html
        ///</summary>
        public static Engine GroupCentralizer(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupCentralizer[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns True if the location loc is contained within the region reg, and False otherwise.
        ///https://reference.wolfram.com/language/ref/GeoWithinQ.html
        ///</summary>
        public static Engine GeoWithinQ(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoWithinQ[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents the distribution of the property expr where the random variable x follows the graph distribution gdist.
        ///https://reference.wolfram.com/language/ref/GraphPropertyDistribution.html
        ///</summary>
        public static Engine GraphPropertyDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphPropertyDistribution[" + arg0 + ", " + arg1 + "]", name);
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
        ///returns the positions of exact matches for the DNA sequence seq on the reference human genome.
        ///https://reference.wolfram.com/language/ref/GenomeLookup.html
        ///</summary>
        public static Engine GenomeLookup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GenomeLookup[" + arg0 + "]", name);
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
        ///generates a DerivedKey object from the password given.
        ///https://reference.wolfram.com/language/ref/GenerateDerivedKey.html
        ///</summary>
        public static Engine GenerateDerivedKey(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GenerateDerivedKey[" + arg0 + "]", name);
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
        ///filters data by convolving with a Gaussian kernel of radius r.
        ///https://reference.wolfram.com/language/ref/GaussianFilter.html
        ///</summary>
        public static Engine GaussianFilter(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GaussianFilter[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an abstract 2D geometric scene defined by the hypotheses hypi in terms of the symbolic points pi.
        ///https://reference.wolfram.com/language/ref/GeometricScene.html
        ///</summary>
        public static Engine GeometricScene(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeometricScene[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///makes a geo contour plot from values vali defined at specified locations loci.
        ///https://reference.wolfram.com/language/ref/GeoContourPlot.html
        ///</summary>
        public static Engine GeoContourPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoContourPlot[" + arg0 + "]", name);
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
        ///generates a new anonymous SecuredAuthenticationKey owned by the current user ID.
        ///https://reference.wolfram.com/language/ref/GenerateSecuredAuthenticationKey.html
        ///</summary>
        public static Engine GenerateSecuredAuthenticationKey(this Engine en, string? name = null)
        {
            return en.Execute("GenerateSecuredAuthenticationKey[]", name);
        }

        ///<summary>
        ///gives the set of vertices with minimum eccentricity in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphCenter.html
        ///</summary>
        public static Engine GraphCenter(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphCenter[" + arg0 + "]", name);
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
        ///represents a geographic object obj with qualifier qual.
        ///https://reference.wolfram.com/language/ref/GeoVariant.html
        ///</summary>
        public static Engine GeoVariant(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoVariant[" + arg0 + ", " + arg1 + "]", name);
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
        ///gives the link efficiency of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphLinkEfficiency.html
        ///</summary>
        public static Engine GraphLinkEfficiency(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphLinkEfficiency[" + arg0 + "]", name);
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
        ///gives the matrix of distances between vertices for the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDistanceMatrix.html
        ///</summary>
        public static Engine GraphDistanceMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphDistanceMatrix[" + arg0 + "]", name);
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
        ///is a two-dimensional GeoGraphics primitive that represents a geo region bounded by parallels latmin, latmax and meridians lonmin, lonmax on the surface of the Earth.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegion.html
        ///</summary>
        public static Engine GeoBoundsRegion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoBoundsRegion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a geodetic position with latitude lat and longitude lon.
        ///https://reference.wolfram.com/language/ref/GeoPosition.html
        ///</summary>
        public static Engine GeoPosition(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoPosition[" + arg0 + "]", name);
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
        ///gives the value of the property prop about the orientation of the Earth on the given date.
        ///https://reference.wolfram.com/language/ref/GeoOrientationData.html
        ///</summary>
        public static Engine GeoOrientationData(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoOrientationData[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents an object in which the expri are displayed in a browsable gallery layout.
        ///https://reference.wolfram.com/language/ref/GalleryView.html
        ///</summary>
        public static Engine GalleryView(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GalleryView[" + arg0 + "]", name);
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
        ///represents a collection of graphics objects grouped together for purposes of interactive selection in a notebook. 
        ///https://reference.wolfram.com/language/ref/GraphicsGroup.html
        ///</summary>
        public static Engine GraphicsGroup(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphicsGroup[" + arg0 + "]", name);
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
        ///generates a plot in which the geographic regions regi are colored according to the values vali.
        ///https://reference.wolfram.com/language/ref/GeoRegionValuePlot.html
        ///</summary>
        public static Engine GeoRegionValuePlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoRegionValuePlot[" + arg0 + "]", name);
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
        ///gathers into sublists each set of elements in list that gives the same value when f is applied.
        ///https://reference.wolfram.com/language/ref/GatherBy.html
        ///</summary>
        public static Engine GatherBy(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GatherBy[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///returns the element of group determined by the word w in the generators of group.
        ///https://reference.wolfram.com/language/ref/GroupElementFromWord.html
        ///</summary>
        public static Engine GroupElementFromWord(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupElementFromWord[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the Gegenbauer polynomial . 
        ///https://reference.wolfram.com/language/ref/GegenbauerC.html
        ///</summary>
        public static Engine GegenbauerC(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GegenbauerC[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the graph sum of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphSum.html
        ///</summary>
        public static Engine GraphSum(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphSum[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterEqualLess.html
        ///</summary>
        public static Engine GreaterEqualLess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GreaterEqualLess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a symbolic representation of a step in the definition of a geometric scene, in which the hypotheses hypi are introduced. 
        ///https://reference.wolfram.com/language/ref/GeometricStep.html
        ///</summary>
        public static Engine GeometricStep(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeometricStep[" + arg0 + "]", name);
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
        ///creates a video in which each frame is a grid of frames of all vi at the corresponding time.
        ///https://reference.wolfram.com/language/ref/GridVideo.html
        ///</summary>
        public static Engine GridVideo(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GridVideo[" + arg0 + "]", name);
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
        ///plots a density histogram of the geographic locations locs.
        ///https://reference.wolfram.com/language/ref/GeoHistogram.html
        ///</summary>
        public static Engine GeoHistogram(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoHistogram[" + arg0 + "]", name);
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
        ///makes a geo density plot with colors at the location loci determined by the value vali.
        ///https://reference.wolfram.com/language/ref/GeoDensityPlot.html
        ///</summary>
        public static Engine GeoDensityPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoDensityPlot[" + arg0 + "]", name);
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
        ///randomly generates a SymmetricKey object suitable for use with cryptographic functions.
        ///https://reference.wolfram.com/language/ref/GenerateSymmetricKey.html
        ///</summary>
        public static Engine GenerateSymmetricKey(this Engine en, string? name = null)
        {
            return en.Execute("GenerateSymmetricKey[]", name);
        }

        ///<summary>
        ///generates a digital signature for expr using the specified private key.
        ///https://reference.wolfram.com/language/ref/GenerateDigitalSignature.html
        ///</summary>
        public static Engine GenerateDigitalSignature(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GenerateDigitalSignature[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph complement of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphComplement.html
        ///</summary>
        public static Engine GraphComplement(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphComplement[" + arg0 + "]", name);
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
        ///represents the assertion that the geometric object obj satisfies prop.
        ///https://reference.wolfram.com/language/ref/GeometricAssertion.html
        ///</summary>
        public static Engine GeometricAssertion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeometricAssertion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives vertices that are maximally distant to at least one vertex in the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPeriphery.html
        ///</summary>
        public static Engine GraphPeriphery(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphPeriphery[" + arg0 + "]", name);
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
        ///is a one-dimensional GeoGraphics primitive that represents the boundary of the region between parallels latmin, latmax and meridians lonmin, lonmax on the surface of the Earth.
        ///https://reference.wolfram.com/language/ref/GeoBoundsRegionBoundary.html
        ///</summary>
        public static Engine GeoBoundsRegionBoundary(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoBoundsRegionBoundary[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the global clustering coefficient of the graph g.
        ///https://reference.wolfram.com/language/ref/GlobalClusteringCoefficient.html
        ///</summary>
        public static Engine GlobalClusteringCoefficient(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GlobalClusteringCoefficient[" + arg0 + "]", name);
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
        ///gives coordinates of the vertices of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphEmbedding.html
        ///</summary>
        public static Engine GraphEmbedding(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphEmbedding[" + arg0 + "]", name);
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
        ///generates a graphic in which the gi are laid out in a row.
        ///https://reference.wolfram.com/language/ref/GraphicsRow.html
        ///</summary>
        public static Engine GraphicsRow(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphicsRow[" + arg0 + "]", name);
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
        ///displays as expr, evaluating funi[value,velocity] whenever "gesturei" occurs within the screen space occupied by expr.
        ///https://reference.wolfram.com/language/ref/GestureHandler.html
        ///</summary>
        public static Engine GestureHandler(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GestureHandler[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is the Euler gamma function . 
        ///https://reference.wolfram.com/language/ref/Gamma.html
        ///</summary>
        public static Engine Gamma(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("Gamma[" + arg0 + "]", name);
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
        ///returns the position of the element g in the list of elements of group.
        ///https://reference.wolfram.com/language/ref/GroupElementPosition.html
        ///</summary>
        public static Engine GroupElementPosition(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroupElementPosition[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///is an operator form that yields x≥y when applied to an expression x.
        ///https://reference.wolfram.com/language/ref/GreaterEqualThan.html
        ///</summary>
        public static Engine GreaterEqualThan(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GreaterEqualThan[" + arg0 + "]", name);
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
        ///constructs a tree from the tree graph g.
        ///https://reference.wolfram.com/language/ref/GraphTree.html
        ///</summary>
        public static Engine GraphTree(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphTree[" + arg0 + "]", name);
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
        ///gives a matrix that corresponds to a Gaussian kernel of radius r. 
        ///https://reference.wolfram.com/language/ref/GaussianMatrix.html
        ///</summary>
        public static Engine GaussianMatrix(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GaussianMatrix[" + arg0 + "]", name);
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
        ///gives a list of polynomials that form a Gröbner basis for the set of polynomials polyi. 
        ///https://reference.wolfram.com/language/ref/GroebnerBasis.html
        ///</summary>
        public static Engine GroebnerBasis(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GroebnerBasis[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///identifies the geographic entities of the type enttype in which the current geo location is contained.
        ///https://reference.wolfram.com/language/ref/GeoIdentify.html
        ///</summary>
        public static Engine GeoIdentify(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoIdentify[" + arg0 + "]", name);
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
        ///gives the generating function in x for the sequence whose n series coefficient is given by the expression expr.
        ///https://reference.wolfram.com/language/ref/GeneratingFunction.html
        ///</summary>
        public static Engine GeneratingFunction(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GeneratingFunction[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a document by evaluating all template elements in the notebook nb.
        ///https://reference.wolfram.com/language/ref/GenerateDocument.html
        ///</summary>
        public static Engine GenerateDocument(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GenerateDocument[" + arg0 + "]", name);
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
        ///represents a geometric Brownian motion process with drift μ, volatility σ, and initial value x0.
        ///https://reference.wolfram.com/language/ref/GeometricBrownianMotionProcess.html
        ///</summary>
        public static Engine GeometricBrownianMotionProcess(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GeometricBrownianMotionProcess[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///generates a plot of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphPlot.html
        ///</summary>
        public static Engine GraphPlot(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphPlot[" + arg0 + "]", name);
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
        ///represents a position in a Cartesian geocentric coordinate system.
        ///https://reference.wolfram.com/language/ref/GeoPositionXYZ.html
        ///</summary>
        public static Engine GeoPositionXYZ(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GeoPositionXYZ[" + arg0 + "]", name);
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
        ///displays as .
        ///https://reference.wolfram.com/language/ref/GreaterFullEqual.html
        ///</summary>
        public static Engine GreaterFullEqual(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GreaterFullEqual[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives a graph with the specified name.
        ///https://reference.wolfram.com/language/ref/GraphData.html
        ///</summary>
        public static Engine GraphData(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphData[" + arg0 + "]", name);
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
        ///constructs a generalized linear model of the form  that fits the yi for successive x values 1, 2, ….
        ///https://reference.wolfram.com/language/ref/GeneralizedLinearModelFit.html
        ///</summary>
        public static Engine GeneralizedLinearModelFit(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GeneralizedLinearModelFit[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }

        ///<summary>
        ///gives the graph union of the graphs g1 and g2.
        ///https://reference.wolfram.com/language/ref/GraphUnion.html
        ///</summary>
        public static Engine GraphUnion(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GraphUnion[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///tests whether the geometric object obj satisfies prop.
        ///https://reference.wolfram.com/language/ref/GeometricTest.html
        ///</summary>
        public static Engine GeometricTest(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeometricTest[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///represents a gamma distribution with shape parameter α and scale parameter β.
        ///https://reference.wolfram.com/language/ref/GammaDistribution.html
        ///</summary>
        public static Engine GammaDistribution(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GammaDistribution[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the actual geo area corresponding to a unit area on the geo grid obtained with projection proj, evaluated in the limit of small geo regions around location loc.
        ///https://reference.wolfram.com/language/ref/GeoGridUnitArea.html
        ///</summary>
        public static Engine GeoGridUnitArea(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GeoGridUnitArea[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the graph density of the graph g.
        ///https://reference.wolfram.com/language/ref/GraphDensity.html
        ///</summary>
        public static Engine GraphDensity(this Engine en, object arg0, string? name = null)
        {
            return en.Execute("GraphDensity[" + arg0 + "]", name);
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
        ///is the regularized incomplete gamma function . 
        ///https://reference.wolfram.com/language/ref/GammaRegularized.html
        ///</summary>
        public static Engine GammaRegularized(this Engine en, object arg0, object arg1, string? name = null)
        {
            return en.Execute("GammaRegularized[" + arg0 + ", " + arg1 + "]", name);
        }

        ///<summary>
        ///gives the actual geo distance corresponding to a unit distance on the geo grid obtained with projection proj, evaluated in the limit of small displacement from location loc in direction α.
        ///https://reference.wolfram.com/language/ref/GeoGridUnitDistance.html
        ///</summary>
        public static Engine GeoGridUnitDistance(this Engine en, object arg0, object arg1, object arg2, string? name = null)
        {
            return en.Execute("GeoGridUnitDistance[" + arg0 + ", " + arg1 + ", " + arg2 + "]", name);
        }


    }
}
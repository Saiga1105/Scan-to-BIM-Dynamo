using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.DesignScript.Runtime;
using Autodesk.DesignScript.Geometry;
using rv = Autodesk.Revit.DB;
using Autodesk.Revit.DB.PointClouds;
using mw = MATLAB;
using Rhino;
using rc = Rhino.Geometry;

namespace Saiga.PointClouds  /// this is our main namespace
{
    /// <summary>
    /// Imports an .rcs point cloud 
    /// </summary>
    public class ImportFile   /// this is our nested namespace
    {
        /// <summary>
        /// Imports an .rcs point cloud 
        /// </summary>
        /// <param fileName="fileName">Full file path of the point cloud to import </param>
        /// <returns>pointCloud</returns>
        public static string ImportE57 (string fileName)
        {
            float x = 2.5F, y = 0.0F, z = 0.0F;
            var coord= new rv.XYZ( x,  y,  z);
            var test = new rv.PointClouds.CloudPoint(x, y, z,255);
            rc.PointCloud pointCloud = new rc.PointCloud();

            return String.Format("E57 imported", fileName);

        }

        public static string ImportRCS(string fileName)
        {
            float x = 2.5F, y = 0.0F, z = 0.0F;
            var coord = new rv.XYZ(x, y, z);
            var test = new rv.PointClouds.CloudPoint(x, y, z, 255);
            rc.PointCloud pointCloud = new rc.PointCloud();

            return String.Format("RCS imported", fileName);

        }

    }
}

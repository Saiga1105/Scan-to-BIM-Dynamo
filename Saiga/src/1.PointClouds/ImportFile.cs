﻿using System;
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

namespace PointClouds  /// this is our main namespace
{
    /// <summary>
    /// Imports an .rcs point cloud 
    /// </summary>
    public static class ImportFile   /// this is our nested namespace
    {
        /// <summary>
        /// Imports an .E57 point cloud 
        /// </summary>
        /// <param name="fileName"> Full file path of the point cloud to import </param>
        /// <returns name = "My_first_outputName"> output1</returns>
        /// <search>example,curve</search>
        public static string ImportE57 (string fileName)
        {
            float x = 2.5F, y = 0.0F, z = 0.0F;
            var coord= new rv.XYZ( x,  y,  z);
            var test = new rv.PointClouds.CloudPoint(x, y, z,255);
            rc.PointCloud pointCloud = new rc.PointCloud();

            return String.Format("E57 imported", fileName);

        }
        /// <summary>
        /// Imports an .RCS point cloud 
        /// </summary>
        /// <param name="fileName"> Full file path of the point cloud to import </param>
        /// <returns name = "My_first_outputName"> output1</returns>
        /// <search>example,curve</search>
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.DesignScript.Runtime;
using Autodesk.DesignScript.Geometry;
using rv=Autodesk.Revit.DB;
using Autodesk.Revit.DB.PointClouds;
using mw = MATLAB;
using Rhino;
using rc = Rhino.Geometry;


namespace PointClouds
{
    /// <summary>
    /// Retrieve points from box selection
    /// </summary>
    public static class Selection 
    {
        /// <summary>
        /// Returns a pointCloud within a boundingBox selection. API is restricted to 1M points per boundingBox
        /// </summary>
        /// <param name="fileName">Full file path of the point cloud to import </param>
        /// <returns name = "My_first_outputName"> output1</returns>
        /// <search>example,curve</search>
        public static string BoundingBoxSelection( string fileName)
        {
            float x = 2.5F, y = 0.0F, z = 0.0F;
            var coord= new rv.XYZ( x,  y,  z);
            var test = new CloudPoint(x, y, z,255);
            

            return String.Format("I've selected a point cloud!", fileName);
        }
       
    }
}

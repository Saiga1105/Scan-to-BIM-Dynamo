using System;
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
    /// Get statistics of point cloud
    /// </summary>
    public static class Statistics 
    {
        /// <summary>
        /// Get statistics of point cloud
        /// </summary>
        /// <param name="fileName">Full file path of the point cloud to import </param>
        /// <returns name = "My_first_outputName"> output1</returns>
        /// <returns name = "My_second_outputName"> output2</returns>
        /// <search>example,curve</search>
        [MultiReturn(new[] { "output1", "output2" })]
        public static Dictionary<string, object> GetStatistics ( string fileName)
        {
            float x = 2.5F, y = 0.0F, z = 0.0F;
            var coord= new rv.XYZ( x,  y,  z);
            var test = new CloudPoint(x, y, z,255);

            var output1 = "test";
            var output2 = new Object();

            return new Dictionary<string, object> {
                { "output1", (output1) },
                { "output2", (output2) }
            };
        }
       
    }
}

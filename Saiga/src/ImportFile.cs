using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.DesignScript.Runtime;
using Autodesk.DesignScript.Geometry;

namespace Saiga
{
    /// <summary>
    /// Hello World basic sample
    /// </summary>
    public static class PointCloud
    {
        /// <summary>
        /// Imports an .rcs point cloud 
        /// </summary>
        /// <param fileName="fileName">Full file path of the point cloud to import </param>
        /// <returns>pointCloud</returns>
        public static string ImportFile(string fileName)
        {
            return String.Format("Hello {0}!", fileName);
        }
    }
}

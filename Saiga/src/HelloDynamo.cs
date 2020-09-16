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
    public static class HelloDynamo
    {
        /// <summary>
        /// Prints a friendly greeting
        /// </summary>
        /// <param name="name">Name of the person to greet</param>
        /// <returns name = "My_first_outputName"> output1</returns>
        /// <search>example,curve</search>
        public static string SayHello(string name) // here you can specify default and any Autodesk.DesignScript.Geometry
        {
            return String.Format("Hello {0}!", name);
        }
    }
}

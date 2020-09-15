# Scan-to-BIM Dynamo package

![Overview](https://github.com/Saiga1105/Scan-to-BIM-Grasshopper/blob/master/Pics/Overview.PNG)

This toolbox includes functions for the reconstruction of BIM geometry.
It features a general modular pipeline with the following steps

0. **General**: Some utility functions for mesh and point cloud mutation.
1. **Point clouds**: Point cloud tools i.e. cleanup, registration, etc.
3. **Structure**: Detect and model the base structure i.e. walls, slabs, ceilings, columns, beams
4. **Windows/Doors**: Detect and model window and door objects from object libraries
5. **Appliances**: Detect and model appliance objects from HVAC, MEP and FM libraries
 
The **Example** files contain example .dyn workflows for each step.  
The **Samples** contains some meshes and point clouds for each step.

Step 1-3 are based on Matlab code. To develop the native matlab functions, use the related toolboxes (see Related Toolboxes Section)

### Install & Use
* Clone all repositories (LFS does not support regular download)
* install matlab runtime 9.4.1 (2019b)
* start Revit
* enter commandline ... and add ...\bin folder (where you just built the plugin)
* Restart Revit and Dynamo
* Reference a point cloud (e.g. Samples\E003.rcs)
* open a .dyn workflow (e.g. Examples\Classification\Classification_1.dyn)
* reference the point clouds in the geometry node on the left
* bake the classified geometry on the right

### Contribute
There are several large files in this repository (matlab .dll's and sample files)
Use github's Large File System (LFS) to push changes to the origin.

* Install Vstudio 2019
* Install Visual Studio SDK
* Install .NET Framework 4.7.2 Developer Pack
* Install GIT
* Install LFS GIT
* Clone all repositories (LFS does not support regular download)
* install VSIX extension for Dynamo template https://github.com/alvpickmans/Dynamo-Dev-Starter-Kit.git
* install latest Dynamo Sandbox https://dynamobuilds.com/ (more functionality than Revit's current Dynamo)

* install matlab runtime 9.4.1 (2019b)
* Open project solution
* Add reference paths (properties of C# project Scan2BIM)
* build solution
* start Revit
* enter commandline GrassHopperDevelopersettings and add \bin folder (where you just built the plugin)
* Restart Rhino and Grasshopper

* make sure the .dll files are tracked after commiting
	* git lfs track '*.dll'
	* git lfs track '*.mat'
	* git lfs track '*.3dm'
	* git lfs track '*.obj'
	* git lfs track '*.stl'
	* git lfs track '*.json'
	* git lfs track '*.rdf'
	
### License 
If you use this software in a publication, please cite the work using the following information:

Bassier M., Vergauwen M. (2019) Clustering of Wall Geometry from Unstructured Point Clouds Using Conditional Random Fields. 
Remote Sensing, 11(13), 1586; https://doi.org/10.3390/rs11131586

Courtesy of the **KU Leuven research group in Geomatics**, TC BOUW, Department of Civil Engineering, KU Leuven, Belgium. https://iiw.kuleuven.be/onderzoek/geomatics

Do not use for commercial purposes.

### Dependencies
* GIT LFS https://git-lfs.github.com/
* M. Schmidt. UGM: A Matlab toolbox for probabilistic undirected graphical models. http://www.cs.ubc.ca/~schmidtm/Software/UGM.html, 2007.
* MATLAB Runtime version 9.4 (R2018a). You can download it at http://www.mathworks.com/products/compiler/mcr/index.html


### Related Toolboxes
This plug in consumes the following Open Source toolbox from the same author.

* Scan-to-BIM-Matlab  


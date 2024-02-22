## Overview
In the context of this project, a CMG cell encapsulate various features of cellular images and masks in the CMG file format.
Each cell contains the follow features:

1. Mode: Represents the mode of the cell.
2. Number of Color Maps: Indicates the number of color maps in the cell.
3. Class: Represents the class of the cell.
4. Screen Coordinates (ScreenX, ScreenY): The screen coordinates of the cell.
5. Stage Coordinates (StageX, StageY, StageZ): The stage coordinates of the cell.
6. Resolution: Indicates the resolution of the cell.
7. Thresholds (LowThreshold, MidThreshold): Threshold values of the cell.
8. Group: Represents the group of the cell.
9. Dimensions (Width, Height): Width and height of the cell.
10. Accession: Accession number of the cell.
11. Iod: Represents the iod of the cell.
12. Fluor: Fluorescnece of the cell.
13. RGB Fractions (RedFaction, GreenFaction, BlueFaction): RGB fractions of the cell.
14. Index: Index of the cell.
15. Objective: Objective information of the cell.
16. Calibrated: calibration information of the cell.
17. Stack Coordinates (StackXInt, StackYInt): Stack coordinates of the cell.
18. Number of Bit Maps (NbBitMap): Number of bitmaps in the cell.
19. Cassette Position: position of the cassette.
20. VorX, VorY: Voronoi coordinates of the cell.
21. Best Focus Frame: Best focus frame of the cell.
22. Background Float: Background floating point value of the cell.
23. Primary Colour Channel: Primary color channel of the cell.
24. Layer: layer information of the cell.
25. Points: points information of the cell.
26. Number of features (NumFeature): Number of features in the cell.
27. RGB Order: RGB order of the cell.
28. Images: Array of byte arrays representing the images of the cell.
29. Masks: Array of byte arrays representing the masks of the cell.

These features collectively provide comprehensive information about cellular images and masks stored in the CMG file format. The provided classes and methods can be used to read, write, manipulate, and analyze CMG files according to requirements. 
In particular, this code was written as part of a bigger deep-learning project to segment images of cells for the purpose of detecting abnormalities (indicative of cancerous cells).





 

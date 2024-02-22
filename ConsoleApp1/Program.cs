using System.Reflection.Emit;

//namespace CMGReadAndWrite
//{
//    // class representing main Program
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //string path = @"C:\Users\axiong\Desktop\testwriteCMG\testCmg100.cmg";
//            //CMGCell[] cells = CMGReader.ReadFromFile(path);
//            //Console.WriteLine(cells.Length);

//            //if (cells != null && cells.Length > 0)
//            //{
//            //    int cellNumber = 1;
//            //    // Display information or perform operations with CMGCell objects
//            //    foreach (CMGCell cell in cells)
//            //    {
//            //        Console.WriteLine($"CMG Cell {cellNumber} Features:");
//            //        Console.WriteLine($"Mode: {cell.Mode}");
//            //        Console.WriteLine($"NB Color Map: {cell.NbColorMap}");
//            //        Console.WriteLine($"Class: {cell.Class}");
//            //        Console.WriteLine($"ScreenX: {cell.Screenx}");
//            //        Console.WriteLine($"ScreenY: {cell.Screeny}");
//            //        Console.WriteLine($"StageX: {cell.Stagex}");
//            //        Console.WriteLine($"StageY: {cell.Stagey}");
//            //        Console.WriteLine($"StageZ: {cell.Stagez}");
//            //        Console.WriteLine($"Resolution: {cell.Resolution}");
//            //        Console.WriteLine($"LowThreshold: {cell.LowThreshold}");
//            //        Console.WriteLine($"MidThreshold: {cell.MidThreshold}");
//            //        Console.WriteLine($"Group: {cell.Group}");
//            //        Console.WriteLine($"Width: {cell.Width}");
//            //        Console.WriteLine($"Height: {cell.Height}");
//            //        Console.WriteLine($"Accession: {cell.Accession}");
//            //        Console.WriteLine($"Iod: {cell.Iod}");
//            //        Console.WriteLine($"Fluor: {cell.Fluor}");
//            //        Console.WriteLine($"Diagnosis: {cell.Diagnosis}");
//            //        Console.WriteLine($"RedFaction: {cell.RedFaction}");
//            //        Console.WriteLine($"GreenFaction: {cell.GreenFaction}");
//            //        Console.WriteLine($"BlueFaction: {cell.BlueFaction}");
//            //        Console.WriteLine($"Index: {cell.Index}");
//            //        Console.WriteLine($"Objective: {cell.Objective}");
//            //        Console.WriteLine($"Calibrated: {cell.Calibrated}");
//            //        Console.WriteLine($"StackXInt: {cell.StackXInt}");
//            //        Console.WriteLine($"StackYInt: {cell.StackYInt}");
//            //        Console.WriteLine($"NbBitMap: {cell.NbBitMap}");
//            //        Console.WriteLine($"CassettePosition: {cell.CassettePosition}");
//            //        Console.WriteLine($"VorX: {cell.Vorx}");
//            //        Console.WriteLine($"VorY: {cell.Vory}");
//            //        Console.WriteLine($"BestFocusFrame: {cell.BestFocusFrame}");
//            //        Console.WriteLine($"BackgroundFloat: {cell.BackgroundFloat}");
//            //        Console.WriteLine($"PrimaryColourChannel: {cell.PrimaryColourChannel}");
//            //        Console.WriteLine($"Layer: {cell.Layer}");
//            //        Console.WriteLine($"Points: {cell.Points}");
//            //        Console.WriteLine($"NumFeature: {cell.NumFeature}");
//            //        Console.WriteLine($"RGBOrder: {cell.RGBOrder}");
//            //        Console.WriteLine();

//            //        cellNumber++;
//            //    }
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Failed to read CMG file");
//            //}


//            //// writing to file
//            //string writePath = @"C:\Users\axiong\Desktop\testwriteCMG";
//            //CMGWriter cmgWriter = new CMGWriter();
//            //cmgWriter.WriteCMG(cells, writePath, "TESTWRITE");
//            //Console.WriteLine("Successfully written to CMG file");


//            //// CMGCellList implementation
//            //CMGCellList cellList = new CMGCellList();

//            //// Add a CMGCell to the list
//            //int screenX = 100;
//            //int screenY = 100;
//            //int width = 50;
//            //int height = 50;
//            //byte[] image = new byte[width * height]; // example image data
//            //byte[] mask = new byte[width * height]; // example mask data
//            //byte[] layer = new byte[2];
//            //byte[] points = new byte[9];
//            //byte[] RGBOrder = new byte[3];

//            //cellList.Add(screenX, screenY, width, height, image, mask, layer, points, RGBOrder);
//            //cellList.Add(200, 200, 100, 100, new byte[10000], new byte[10000], new byte[2], new byte[9], new byte[3]);

//            //// save the list of CMGCells to a file
//            //string savePath = @"C:\Users\axiong\Desktop\testwriteCMG";
//            //string saveFileName = "testsave";
//            //cellList.SaveToFile(savePath, saveFileName);

//            //Console.WriteLine("Successfully saved to file.");

//        }
//    }
//}


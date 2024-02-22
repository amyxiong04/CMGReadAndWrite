using System;
using System.Collections.Generic;
using System.IO;

public class CMGCellList
{
    private List<CMGCell> cells;

    public CMGCellList()
    {
        cells = new List<CMGCell>();
    }

    public void SetCells(CMGCell[] newCells)
    {
        cells.Clear();
        cells.AddRange(newCells);
    }

    public CMGCell[] GetCells()
    {
        return cells.ToArray();
    }

    public void DisplayFeatures()
    {
            int cellNumber = 1;
            // Display information or perform operations with CMGCell objects
            foreach (CMGCell cell in cells)
            {
                Console.WriteLine($"CMG Cell {cellNumber} Features:");
                Console.WriteLine($"Mode: {cell.Mode}");
                Console.WriteLine($"NB Color Map: {cell.NbColorMap}");
                Console.WriteLine($"Class: {cell.Class}");
                Console.WriteLine($"ScreenX: {cell.Screenx}");
                Console.WriteLine($"ScreenY: {cell.Screeny}");
                Console.WriteLine($"StageX: {cell.Stagex}");
                Console.WriteLine($"StageY: {cell.Stagey}");
                Console.WriteLine($"StageZ: {cell.Stagez}");
                Console.WriteLine($"Resolution: {cell.Resolution}");
                Console.WriteLine($"LowThreshold: {cell.LowThreshold}");
                Console.WriteLine($"MidThreshold: {cell.MidThreshold}");
                Console.WriteLine($"Group: {cell.Group}");
                Console.WriteLine($"Width: {cell.Width}");
                Console.WriteLine($"Height: {cell.Height}");
                Console.WriteLine($"Accession: {cell.Accession}");
                Console.WriteLine($"Iod: {cell.Iod}");
                Console.WriteLine($"Fluor: {cell.Fluor}");
                Console.WriteLine($"Diagnosis: {cell.Diagnosis}");
                Console.WriteLine($"RedFaction: {cell.RedFaction}");
                Console.WriteLine($"GreenFaction: {cell.GreenFaction}");
                Console.WriteLine($"BlueFaction: {cell.BlueFaction}");
                Console.WriteLine($"Index: {cell.Index}");
                Console.WriteLine($"Objective: {cell.Objective}");
                Console.WriteLine($"Calibrated: {cell.Calibrated}");
                Console.WriteLine($"StackXInt: {cell.StackXInt}");
                Console.WriteLine($"StackYInt: {cell.StackYInt}");
                Console.WriteLine($"NbBitMap: {cell.NbBitMap}");
                Console.WriteLine($"CassettePosition: {cell.CassettePosition}");
                Console.WriteLine($"VorX: {cell.Vorx}");
                Console.WriteLine($"VorY: {cell.Vory}");
                Console.WriteLine($"BestFocusFrame: {cell.BestFocusFrame}");
                Console.WriteLine($"BackgroundFloat: {cell.BackgroundFloat}");
                Console.WriteLine($"PrimaryColourChannel: {cell.PrimaryColourChannel}");
                Console.WriteLine($"Layer: {cell.Layer}");
                Console.WriteLine($"Points: {cell.Points}");
                Console.WriteLine($"NumFeature: {cell.NumFeature}");
                Console.WriteLine($"RGBOrder: {cell.RGBOrder}");
                Console.WriteLine();
                Console.WriteLine();


                cellNumber++;
            }
        }

    public void Add(int screenX, int screenY, int width, int height, byte[] image, byte[] mask, byte[] layer, byte[] points, byte[] RGBOrder)
    {
        // Create a new CMGCell object and add it to the list
        CMGCell newCell = new CMGCell()
        {
            Screenx = (uint)screenX,
            Screeny = (uint)screenY,
            Width = (uint)width,
            Height = (uint)height,
            Images = new byte[][] { image },
            Masks = new byte[][] { mask },
            Layer = layer,
            Points = points,
            RGBOrder = RGBOrder
        };

        cells.Add(newCell);
    }

    public void SaveToFile(string path, string filename)
    {
        string cmgPath = Path.Combine(path, filename + ".cmg");

        using (BinaryWriter cmgFile = new BinaryWriter(File.Open(cmgPath, FileMode.Create)))
        {
            // create an instance of CMGWriter
            CMGWriter cmgWriter = new CMGWriter();

            // write the cells to the CMG file
            foreach (var cell in cells)
            {
                cmgWriter.WriteCellData(cmgFile, cell);
            }
        }
    }
}
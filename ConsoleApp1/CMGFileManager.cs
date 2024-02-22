using System;
using System.Collections.Generic;
using System.IO;

public class CMGFileManager
{
    private CMGCellList cellList;
    private CMGReader cmgReader;
    private CMGWriter cmgWriter;

    // constructor for cmg file manager
    public CMGFileManager()
    {
        cellList = new CMGCellList();
        cmgReader = new CMGReader();
        cmgWriter = new CMGWriter();
    }

    public void Add(int screenX, int screenY, int width, int height, byte[] image, byte[] mask, byte[] layer, byte[] points, byte[] rgbOrder)
    {
        cellList.Add(screenX, screenY, width, height, image, mask, layer, points, rgbOrder);
    }

    public void Save(string path)
    {
        cmgWriter.WriteCMG(cellList.GetCells(), Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("CMG file successfully saved to: " + path);
    }

    public void ReadFromFile(string path)
    {
        CMGCell[] newCells = CMGReader.ReadFromFile(path);
        cellList.SetCells(newCells);
    }

    public void DisplayFeatures()
    {
        cellList.DisplayFeatures();
    }
}

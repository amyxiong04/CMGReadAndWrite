using System;

// example main class demonstrating how to use the functions

class Program
{
    static void Main(string[] args)
    {
        // Creates an instance of CMGFileManager
        CMGFileManager cmgFileManager = new CMGFileManager();

        // Testing the Add function (adds a cmg cell with features specified in the params)
        cmgFileManager.Add(200, 200, 100, 100, new byte[10000], new byte[10000], new byte[2], new byte[9], new byte[3]);

        // Testing the DisplayFeatures function (displays the features of each cell in the file manager)
        cmgFileManager.DisplayFeatures();

        // Testing the Save function (takes in directory including the name of what you wish to save the file as)
        cmgFileManager.Save(@"C:\Users\axiong\Desktop\testwriteCMG\test.cmg");

        // Testing the Read function (reads the file specified in the path)
        cmgFileManager.ReadFromFile(@"C:\Users\axiong\Desktop\testwriteCMG\testCmg100.cmg"); // read test file with 100 cmg cells
        cmgFileManager.DisplayFeatures();                                                    // display the features of all 100 cells 
        cmgFileManager.Save(@"C:\Users\axiong\Desktop\testwriteCMG\testsaveCmg100.cmg");     // save this file under a new name to ensure save function works as expected

    }
}

using System;
using System.IO;

class CreateDirectory
{
    static void Main()
    {
        CreateDirectory folder = new CreateDirectory();
        folder.CreateDirectories();
    }

    public void CreateDirectories()
    {

        string rootFolderPath = "Nepal";
        Directory.CreateDirectory(rootFolderPath);
        string[] subfolders = { "Mechi", "Koshi", "Sagarmatha", "Janakpur", "Bagmati", "Narayani", "Gandaki", "Lumbini", "Dhaulagiri", "Rapti" };
        foreach (string sub in subfolders)
        {
            var v1 = "folderPath" + "/" + sub;
            string subfolderPath = v1;
            Directory.CreateDirectory(subfolderPath);
            string filePath = subfolderPath + "/" + "test.txt";
            File.WriteAllText(filePath, sub);
        }
    }
}
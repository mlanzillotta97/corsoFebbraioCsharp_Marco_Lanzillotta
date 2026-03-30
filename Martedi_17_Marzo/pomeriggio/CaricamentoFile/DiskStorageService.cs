using System;
using System.IO;

public class DiskStorageService : IStorageService
{
    public void Save(string fileName, string content)
    {
        File.WriteAllText(fileName, content);
        Console.WriteLine($"[DiskStorageService] File salvato su disco: {fileName}");
    }
}
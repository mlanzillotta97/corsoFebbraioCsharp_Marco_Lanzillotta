using System;
using System.Collections.Generic;

public class MemoryStorageService : IStorageService
{
    private Dictionary<string, string> storage = new Dictionary<string, string>();

    public void Save(string fileName, string content)
    {
        storage[fileName] = content;
        Console.WriteLine($"[MemoryStorageService] File salvato in memoria: {fileName}");
    }
}
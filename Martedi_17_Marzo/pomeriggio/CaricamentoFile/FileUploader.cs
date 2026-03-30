using System;

public class FileUploader
{
    // Setter Injection
    public IStorageService? StorageService { get; set; }

    public void Upload(string fileName, string content)
    {
        if (StorageService == null)
        {
            Console.WriteLine("StorageService non impostato!");
            return;
        }

        StorageService.Save(fileName, content);
    }
}
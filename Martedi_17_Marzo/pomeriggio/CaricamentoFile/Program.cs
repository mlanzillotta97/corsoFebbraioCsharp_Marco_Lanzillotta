using System;

class Program
{
    static void Main()
    {
        FileUploader uploader = new FileUploader();

        // 🔹 Uso DiskStorageService
        uploader.StorageService = new DiskStorageService();
        uploader.Upload("file.txt", "Contenuto di esempio");

        Console.WriteLine();

        // 🔹 Uso MemoryStorageService
        uploader.StorageService = new MemoryStorageService();
        uploader.Upload("file2.txt", "Altro contenuto");
    }
}
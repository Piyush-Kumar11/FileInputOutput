using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileInputOutput
{
    internal class FileSample

    {
        static string path = @"C:\Users\Piyush\Desktop\C# Programs\FileInputOutput\NewTextFile.txt";
        public void FileCreation()
        {
            FileStream file = null;
            try
            {
                file = File.Create(path);
                Console.WriteLine("File Created!");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Path not found!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception occured: " + e.Message);
            }
            finally
            {
                file.Close();
            }
        }

        public void FileExistence()
        {
            if (File.Exists(path))
                Console.WriteLine("File exists!");
            else
                Console.WriteLine("File doesn't exists!");
        }

        public void FileWrite()
        {
            File.WriteAllText(path, "Hello This is a normal text file!!!");
            Console.WriteLine("File written successfully");

        }

        public void FileRead()
        {
            string[] files = File.ReadAllLines(path);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        public void FileDelete()
        {
            File.Delete(path);
            Console.WriteLine("File deleted successfully");
        }

        public void MoveFile()
        {
            string newPath = @"C:\Users\Piyush\Desktop\C# Programs\FileInputOutput\New Files\AnotherTextFile.txt";
            File.Move(path, newPath );
            Console.WriteLine("File moved successfully!");
        }

        public void CopyFile()
        {
            string oldPath = @"C:\Users\Piyush\Desktop\C# Programs\FileInputOutput\New Files\AnotherTextFile.txt";
            string newPath = @"C:\Users\Piyush\Desktop\C# Programs\FileInputOutput\CopiedTextFile.txt";
            File.Copy(oldPath, newPath ,overwrite:true);
            Console.WriteLine("File copied successfully!");
        }

        public void RenameFile()
        {
            string path = @"C:\Users\Piyush\Desktop\C# Programs\FileInputOutput\CopiedTextFile.txt";
            string newName = @"C:\Users\Piyush\Desktop\C# Programs\FileInputOutput\NewTextFile.txt";
            File.Move(path, newName);
            Console.WriteLine("File renamed successfully!");
        }

        public void FileAppend()
        {
            File.AppendAllText(path, "\nThis text is appended!");
            Console.WriteLine("Text appended to file successfully");
        }

        public void FileInformation()
        {
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                Console.WriteLine($"File Name: {fileInfo.Name}");
                Console.WriteLine($"File Size: {fileInfo.Length} bytes");
                Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
                Console.WriteLine($"Last Access Time: {fileInfo.LastAccessTime}");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

    }
}

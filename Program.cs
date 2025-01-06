using System;

namespace FileInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSample file = new FileSample();
            //file.FileCreation();
            //file.FileExistence();
            //file.FileWrite();
            //file.FileRead();
            //file.FileDelete();
            //file.MoveFile();
            //file.CopyFile();
            //file.RenameFile();
            //file.FileAppend();
            //file.FileInformation();

            StreamRWSample stream = new StreamRWSample();
            //stream.WriteIntoAFile();
            //stream.ReadFromAFile();
            stream.ReadFileWithBuffer();
            //stream.AppendToAFile();
            //stream.ReadEntireFile();


        }
    }
}

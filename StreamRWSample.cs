using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileInputOutput
{
    internal class StreamRWSample
    {
        static string path = @"C:\Users\Piyush\Desktop\C# Programs\FileInputOutput\StreamText.txt";

        public void WriteIntoAFile()
        {
            try
            {
                // Use a 'using' block to ensure the StreamWriter is closed properly
                using (StreamWriter writer = new StreamWriter(path))
                {
                    Console.WriteLine("Enter the number of lines you want to write: ");
                    int lineLength = int.Parse(Console.ReadLine());

                    for (int i = 0; i < lineLength; i++)
                    {
                        Console.WriteLine("Enter for line " + (i + 1));
                        string line = Console.ReadLine();
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("Done with writing into a file!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void ReadFromAFile()
        {
            try
            {
                // Use a 'using' block to ensure the StreamWriter is closed properly
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void ReadFileWithBuffer()
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                using (StreamReader reader = new StreamReader(bufferedStream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }


        public void AppendToAFile()
        {
            try
            {
                //without overwriting, writes into an existing file
                using (StreamWriter writer = new StreamWriter(path, append: true))
                {
                    Console.WriteLine("Enter the number of lines you want to append: ");
                    int lineLength = int.Parse(Console.ReadLine());

                    for (int i = 0; i < lineLength; i++)
                    {
                        Console.WriteLine("Enter for line " + (i + 1));
                        string line = Console.ReadLine();
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("Done appending to the file!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void ReadEntireFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("File Content:");
                    Console.WriteLine(content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

    }
}

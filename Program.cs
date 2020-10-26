using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Files_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring paths.
            Console.Write("Enter Source Directory: ");
            string sourcePath = Console.ReadLine();
            Console.Write("Enter Destination Directory: ");
            string destinationPath = Console.ReadLine();
            //Fetching all files from the directory.
            string[] files = Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories);
            //Looping all files found in the directory.
            for (int i = 0; i < files.Length; i++)
            {   
                //Fetching each file.
                string sourceFile = files[i];            
                //Fetching filepath from file.
                string filePath = sourceFile.Substring(0, sourceFile.LastIndexOf("\\"));
                //Fetching filename from file.
                string fileName = sourceFile.Replace(filePath, "").Substring(1);
                //Fetching extension from filename.
                string extension = fileName.Contains(".") ? fileName.Substring(fileName.LastIndexOf(".")+1) : "No Extension";
                //Creating destination path.
                string destinationFilePath = destinationPath + "\\" + extension.ToUpper();
                //Creatind directory using destination path.
                Directory.CreateDirectory(destinationFilePath);
                //Checking if the current file and destination file are same
                if (sourceFile.Equals(destinationFilePath + "\\" + fileName))
                {
                    //Skiping the current file.
                    continue;
                }
                //Using count to automatically rename files with numbers.
                int count = 1;
                //Creating destination filename using original filename.
                string destinationFileName = fileName;
                //Checking if the destination filename exists in the source path and destination path.
                while ((File.Exists(destinationFilePath + "\\" + destinationFileName))||(File.Exists(filePath + "\\" + destinationFileName)))
                {
                    //If exists
                    //Fetching extension from filename.
                    extension = fileName.Contains(".") ? fileName.Substring(fileName.LastIndexOf(".")) : "";
                    //Checking if extension is empty or null.
                    if (string.IsNullOrEmpty(extension))
                    {
                        //If yes, creating destination filename without extension.
                        destinationFileName = fileName + "_" + count;
                    }
                    else
                    {
                        //If no, creating destination filename with extension.
                        destinationFileName = fileName.Substring(0, fileName.LastIndexOf(extension)) + "_" + count + extension;
                    }
                    //Updating the count.
                    count++;

                }
                //Replace the filename in source directory if same filename exists in destination directory.
                File.Move(sourceFile, filePath + "\\" + destinationFileName);
                //Move files from source directory to destination directory.
                File.Move(filePath + "\\" + destinationFileName, destinationFilePath + "\\" + destinationFileName);
                //Displaying Progress.
                Console.Write("\rProgress : {0} %",((((float)i + 1)/ (float)files.Length) * 100).ToString("0.00"));
                //Wait for 1 second (or) Remove the below step to skip delays.
                Thread.Sleep(30);
            }
            Console.WriteLine("\nHere are your files.. Enjoy !! ");
            Process.Start("explorer.exe", destinationPath);
        }
    }
}
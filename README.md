
I work a lot and save many different sessions to trace back my work, I am also music lover and I love to capture memories when I explore. But all these photos, videos, music, data etc., stack up together making it difficult for me to pick right file at time. So, I have got an idea to create a File Manager to trace my own work and gives me suggestions based on my usage.
</br>
</br>
## Getting Started

This project is based on .NET Core 3.1. The required installation files can be found here:
https://dotnet.microsoft.com/download/dotnet-core/3.1

The check the version of .NET, Use the below command:
```
dotnet --version
```
</br>

Currently, This project supports only sorting of files based on extensions. Use these commands in cmd/shell to sort the files:
```
<Path_To_Repository> dotnet build        //Build the program to see if any errors are present
<Path_To_Repository> dotnet run          //Run the program  
Enter Source Directory:                  //Path to where files are located
Enter Destination Directory:             //Provide path to where the sorted files to be stored
Progress:                                //Progress can be seen here
Here are your files..Enjoy !!            //Program has ended and Destination Directory is opened to check files
```
![image](https://user-images.githubusercontent.com/30994244/97233151-78c45280-1804-11eb-9487-0fd05102b440.png)


## Features to be Added:
1. Comparison of files using MD5 Sum.
2. Duplicates Removal.
3. Graphical User Interface based on Avalonia.
4. Conversion of Images, Videos, Documents etc to other formats.
5. Many more........

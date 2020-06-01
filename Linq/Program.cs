using System;
using System.Collections.Generic;
using System.IO;
//bilgisayarda ki kalsörleri sorgulayan ve sıraya sokan bir program
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Windows";
            ShowLargeFilesWithoutLinq(Path);
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
           DirectoryInfo directory=new DirectoryInfo(path);
           FileInfo[] files = directory.GetFiles();
           Array.Sort(files, new FileInfoComparer());
           //bütün dosyaları sıralmak istersek
           /*foreach (FileInfo file  in files)
           {
               Console.WriteLine($"{file.Name} : {file.Length}");
           }*/
           
          
           //sadece ilk 5 dosyayı sıralamak istersek
           for (int i = 0; i < 5; i++)
           {
               FileInfo file = files[i];
               
               //ismi yazdırdıktan sonra isimle beraber toplam 20 boşluk sonra diğer yazılcak şeye geçer yani ":" iki noktaya daha  sonra dosyanın botunun toplamda 10 olacak şekilde ->
               //-> sağ tarafa dayalı şekilde yazdırır 
               Console.WriteLine($"{file.Name ,-20} : {file.Length,10:N0}");
           }
        }
    }

    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            //y nin uzunluğunu x ile karşılaştırma 
            return y.Length.CompareTo(x.Length);
        }
    }
}

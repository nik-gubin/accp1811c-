using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("I/O");

            //информация о дисках
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var d in drives)
            {
                Console.WriteLine($"{d.VolumeLabel} {d.Name} {d.RootDirectory} {d.TotalSize / 1024 / 1024} {d.AvailableFreeSpace / 1024 / 1024}");
            }
            //работа с директориями
            Directory.CreateDirectory("dir1");//создание
            Directory.Delete("dir1");//удаление

            Directory.CreateDirectory("c:\\windows\\dir1");
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;//текущая директория
            Console.WriteLine(baseDir);

            DirectoryInfo dir = new DirectoryInfo("c:\\dir1");
            dir.Attributes = FileAttributes.Normal;//изменение аритибут
            dir.CreationTime = new DateTime(9999, 1, 1);
            Console.WriteLine(dir.Attributes);

            //создание файлов
            File.Create("c:\\dir1\\aaaa.txt");
            File.Create("c:\\dir1\\bbbb.aaa");

            //переименовка файлов
            File.Move("c:\\dir1\\bbbb.aaa", "c:\\dir1\\aaaa.bbb");

            //информация о файлах
            FileInfo file = new FileInfo("c:\\dir1\\aaaa.txt");
            Console.WriteLine(file.Extension);
            Console.WriteLine(file.Length);
            FileInfo[] files = file.Directory.GetFiles();

            //FileStream fileStream = new FileStream();
            //fileStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine("-------------------------------------");
            //чтение из файла
            using (StreamReader reader = new StreamReader("c:\\dir1\\aaaa.txt"))
            {
                string s = reader.ReadLine();
                Console.WriteLine(s);
                Console.WriteLine("-------------------------------------");
                string fullString = reader.ReadToEnd();
                Console.WriteLine(fullString);

            }
            //доступные кодировки
            foreach (var item in Encoding.GetEncodings())
            {
                Console.WriteLine(item.Name);
            }
            //чтение из файла
            using (StreamReader reader = new StreamReader("c:\\dir1\\aaaa.txt", Encoding.GetEncoding("windows-1251")))
            {
                Console.WriteLine("-------------------------------------");
                string fullString = reader.ReadToEnd();
                Console.WriteLine(fullString);
                // StreamWriter writer = new StreamWriter();

                using (StreamWriter writer = new StreamWriter("c:\\dir1\\aaaa1.txt"))
                {
                    writer.WriteLine(fullString);
                }
            }

            //запись в файл
            using (StreamWriter writer = new StreamWriter("c:\\dir1\\aaaa.txt", true, Encoding.GetEncoding("windows-1251")))
            {
                writer.WriteLine("привет!!!!!!!");
                writer.WriteLine(writer);
            }

            //упаковка в zip
            ZipFile.CreateFromDirectory("c:\\dir1", "dir1.zip");
            //распаковка из zip
            ZipFile.ExtractToDirectory("dir1.zip", "dddd");
            */
            //работа с Word
            var app = new Word.Application();
            object f = AppDomain.CurrentDomain.BaseDirectory + "\\test.docx";
            var doc = app.Documents.Open(f);
            doc.Activate();
            doc.Content.Font.Color = Word.WdColor.wdColorPink;
            doc.ExportAsFixedFormat("as.pdf", Word.WdExportFormat.wdExportFormatPDF);
            doc.Close();


        }
    }
}

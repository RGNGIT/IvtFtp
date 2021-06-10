using System;
using System.IO;
using System.Collections.Generic;

namespace _IvtFtp
{

    public class FileManager
    {

        public String WriteFile(byte[] CurrentFile, Uri ServerUri, String FileName)
        {
            try
            {
                File.WriteAllBytes($@"DurkaDownloads\{FileName}", CurrentFile);
                
                return "Файл успешно записан!";
            }
            catch(DirectoryNotFoundException)
            {
                Directory.CreateDirectory("DurkaDownloads");
                WriteFile(CurrentFile, ServerUri, FileName);
                return "Директория создана и файл успешно записан!";
            }
            catch(Exception e)
            {
                return $"Произошло исключение по коду: {e}";
            }
        }

        public String LogWriteFile(List<String> LogWrite)
        {
            try
            {
                File.WriteAllLines(@"log.rgn", LogWrite);
                return "Лог записан и открыт!";
            }
            catch(Exception e)
            {
                return $"Произошло исключение по коду: {e}";
            }
        }

        // Далее экспериментальная часть

        public String ReadSerializedFile(out byte[] CurrentFile, String Path)
        {
            try
            {
                CurrentFile = File.ReadAllBytes(Path);
                return $"Считывание и сериализация файла '{Path}' успешно произведены! ({CurrentFile.Length} байт)";
            }
            catch(Exception e)
            {
                CurrentFile = null;
                return $"Произошло исключение по коду: {e}";
            }
        }

    }

}

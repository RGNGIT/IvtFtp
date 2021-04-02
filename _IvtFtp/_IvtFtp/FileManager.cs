using System;
using System.IO;
using System.Collections.Generic;

namespace _IvtFtp
{

    public static class FileManager
    {

        public static String WriteFile(byte[] CurrentFile, Uri ServerUri, String FileName)
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

        public static String LogWriteFile(List<String> LogWrite)
        {
            try
            {
                File.WriteAllLines(@"log.rgn", LogWrite);
                return "Лог записан! Чекай корневую директорию программы на наличие файла 'log.rgn'";
            }
            catch(Exception e)
            {
                return $"Произошло исключение по коду: {e}";
            }
        }

    }

}

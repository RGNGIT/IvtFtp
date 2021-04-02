using System;
using System.IO;
using System.Collections.Generic;

namespace _IvtFtp
{

    public static class FileManager
    {

        private static String GetType(String Path)
        {
            String Temp = String.Empty;
            String Reverse = String.Empty;
            for(int i = Path.Length - 1; Path[i] != '.'; i--)
            {
                Temp += Path[i];
            }
            for (int i = Temp.Length - 1; i >= 0; i--)
            {
                Reverse += Temp[i];
            }
            return Reverse;
        }

        public static String WriteFile(byte[] CurrentFile, Uri ServerUri)
        {
            try
            {
                File.WriteAllBytes($@"File.{GetType(ServerUri.ToString())}", CurrentFile);
                return "Файл успешно записан!";
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

using System;
using System.IO;
using System.Net;
using System.Collections.Generic;

namespace _IvtFtp
{

    static public class FtpClient
    {

        private static List<String> StatusList = new List<String>();
        private static NetworkCredential CurrentCredential;

        public static List<String> GetStatusList
        {
            get
            {
                return StatusList;
            }
        }

        public static NetworkCredential SetCredential
        {
            set
            {
                CurrentCredential = value;
            }
        }

        public static bool OnDeleteFileFromServer(Uri ServerUri) // (Схема) Параметр формата ftp URL ((Главное зеркало)ftp://ftp.19ivt.ru + Имя Файла + Расширение)
        {
            if(ServerUri.Scheme != Uri.UriSchemeFtp) // Если файл недоступен по протоколу FTP
            {
                StatusList.Add("Файл недоступен по протоколу FTP");
                StatusList.Add(MemManager.DFGCMemClean("OnDeleteFileFromServer()"));
                return false;
            }
            else
            {
                FtpWebRequest Request = WebRequest.Create(ServerUri) as FtpWebRequest;
                Request.Credentials = CurrentCredential;
                Request.Method = WebRequestMethods.Ftp.DeleteFile;
                FtpWebResponse Response = Request.GetResponse() as FtpWebResponse;
                StatusList.Add($"Статус удаления файла '{ServerUri}': {Response.StatusDescription}");
                Response.Close();
                StatusList.Add(MemManager.DFGCMemClean("OnDeleteFileFromServer()"));
                return true;
            }
        }

        public static byte[] OnGetFileFromServer(Uri ServerUri) // Получание сериализованного потока байтов файла
        {
            if(ServerUri.Scheme != Uri.UriSchemeFtp)
            {
                StatusList.Add("Файл недоступен по протоколу FTP!");
                StatusList.Add(MemManager.DFGCMemClean("FtpClient.OnGetFileFromServer()"));
                return null;
            } 
            else
            {
                WebClient Request = new WebClient();
                Request.Credentials = CurrentCredential;
                try
                {
                    byte[] FileData = Request.DownloadData(ServerUri.ToString());
                    StatusList.Add($"Сериализованый поток байтов файла '{ServerUri}' успешно загружен! ({FileData.Length} байт)");
                    StatusList.Add(MemManager.DFGCMemClean("FtpClient.OnGetFileFromServer()"));
                    return FileData;
                }
                catch(Exception e)
                {
                    StatusList.Add($"Произошло исключение по коду: {e}");
                    StatusList.Add(MemManager.DFGCMemClean("FtpClient.OnGetFileFromServer()"));
                    return null;
                }
            }
        }

        public static List<String> OnGetDirList(Uri ServerUri)
        {
            try
            {
                List<String> Temp = new List<String>();
                FtpWebRequest Request = WebRequest.Create(ServerUri) as FtpWebRequest;
                Request.Method = WebRequestMethods.Ftp.ListDirectory;
                Request.Credentials = CurrentCredential;
                FtpWebResponse Response = Request.GetResponse() as FtpWebResponse;
                Stream ResponseStream = Response.GetResponseStream();
                StreamReader Reader = new StreamReader(ResponseStream);
                while (Reader.Peek() != -1)
                {
                    Temp.Add(Reader.ReadLine());
                }
                StatusList.Add($"Список файлов сервера успешно обновлен!");
                StatusList.Add(MemManager.DFGCMemClean("FtpClient.OnGetDirList()"));
                return Temp;
            }
            catch(Exception e)
            {
                StatusList.Add($"Произошло исключение по коду: {e}");
                StatusList.Add(MemManager.DFGCMemClean("FtpClient.OnGetDirList()"));
                return null;
            }
        }

        public static void OnUploadFileToServer(Uri ServerUri)
        {
            try
            {
                byte[] CurrentFile;
                StatusList.Add(FileManager.ReadSerializedFile(out CurrentFile, ServerUri.ToString()));
                WebClient Request = new WebClient();
                Request.UploadData("ftp://ftp.19ivt.ru/files", CurrentFile);
                StatusList.Add($"Файл успешно загружен на сервер!");
            }
            catch(Exception e)
            {
                StatusList.Add($"Произошло исключение по коду: {e}");
                return;
            }
        }

    }

}

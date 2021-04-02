using System;
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
                return false;
            }
            else
            {
                FtpWebRequest Request = WebRequest.Create(ServerUri) as FtpWebRequest;
                Request.Credentials = CurrentCredential;
                Request.Method = WebRequestMethods.Ftp.DeleteFile;
                FtpWebResponse Response = Request.GetResponse() as FtpWebResponse;
                StatusList.Add($"Статус удаления файла: {Response.StatusDescription}");
                Response.Close();
                return true;
            }
        }

        public static byte[] OnGetFileFromServer(Uri ServerUri) // Получание сериализованного потока байтов файла
        {
            if(ServerUri.Scheme != Uri.UriSchemeFtp)
            {
                StatusList.Add("Файл недоступен по протоколу FTP!");
                return null;
            } 
            else
            {
                WebClient Request = new WebClient();
                Request.Credentials = CurrentCredential;
                try
                {
                    byte[] FileData = Request.DownloadData(ServerUri.ToString());
                    StatusList.Add($"Сериализованый поток байтов файла '{ServerUri}' успешно загружен!");
                    return FileData;
                }
                catch(Exception e)
                {
                    StatusList.Add($"Произошло исключение по коду: {e}");
                    return null;
                }
            }
        }

    }

}

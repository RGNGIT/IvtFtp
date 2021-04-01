using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

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

        public static List<String> OnGetFilesNamesFromServer(Uri ServerUri)
        {
            List<String> Temp = new List<String>();
            if(ServerUri.Scheme != Uri.UriSchemeFtp)
            {
                StatusList.Add("Файл недоступен по протоколу FTP!");
                return Temp;
            } 
            else
            {
                WebClient Request = new WebClient();
                Request.Credentials = CurrentCredential;
                try
                {
                    byte[] FileData = Request.DownloadData(ServerUri.ToString());
                    Temp.Add(Encoding.UTF8.GetString(FileData));
                }
                catch(Exception e)
                {
                    StatusList.Add($"Произошло исключение по коду: {e}");
                    return Temp;
                }
            }
            return Temp;
        }

    }

}

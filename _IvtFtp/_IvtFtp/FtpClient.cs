using System;
using System.IO;
using System.Net;
using System.Collections.Generic;

namespace _IvtFtp
{

    public class FtpClient
    {

        private List<String> StatusList = new List<String>();
        private NetworkCredential CurrentCredential;
        private bool ToShow;

        public List<String> GetStatusList
        {
            get
            {
                return StatusList;
            }
        }

        public NetworkCredential SetCredential
        {
            set
            {
                CurrentCredential = value;
            }
        }

        public FtpClient(NetworkCredential CurrentCredential, bool ToShow)
        {
            this.CurrentCredential = CurrentCredential;
            this.ToShow = ToShow;
        }

        public bool OnDeleteFileFromServer(Uri ServerUri) // (Схема) Параметр формата ftp URL ((Главное зеркало)ftp://ftp.19ivt.ru + Имя Файла + Расширение)
        {
            MemManager memManager = new MemManager(ToShow);
            if (ServerUri.Scheme != Uri.UriSchemeFtp) // Если файл недоступен по протоколу FTP
            {
                StatusList.Add("Файл недоступен по протоколу FTP");
                StatusList.Add(memManager.DFGCMemClean("OnDeleteFileFromServer()"));
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
                StatusList.Add(memManager.DFGCMemClean("OnDeleteFileFromServer()"));
                return true;
            }
        }

        public byte[] OnGetFileFromServer(Uri ServerUri) // Получание сериализованного потока байтов файла
        {
            MemManager memManager = new MemManager(ToShow);
            if (ServerUri.Scheme != Uri.UriSchemeFtp)
            {
                StatusList.Add("Файл недоступен по протоколу FTP!");
                StatusList.Add(memManager.DFGCMemClean("FtpClient.OnGetFileFromServer()"));
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
                    StatusList.Add(memManager.DFGCMemClean("FtpClient.OnGetFileFromServer()"));
                    return FileData;
                }
                catch(Exception e)
                {
                    StatusList.Add($"Произошло исключение по коду: {e}");
                    StatusList.Add(memManager.DFGCMemClean("FtpClient.OnGetFileFromServer()"));
                    return null;
                }
            }
        }

        public List<String> OnGetDirList(Uri ServerUri)
        {
            MemManager memManager = new MemManager(ToShow);
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
                StatusList.Add(memManager.DFGCMemClean("FtpClient.OnGetDirList()"));
                return Temp;
            }
            catch(Exception e)
            {
                StatusList.Add($"Произошло исключение по коду: {e}");
                StatusList.Add(memManager.DFGCMemClean("FtpClient.OnGetDirList()"));
                return null;
            }
        }

        public void OnUploadFileToServer(Uri ServerUri)
        {
            FileManager fileManager = new FileManager();
            try
            {
                byte[] CurrentFile;
                StatusList.Add(fileManager.ReadSerializedFile(out CurrentFile, ServerUri.ToString()));
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

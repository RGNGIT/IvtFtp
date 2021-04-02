using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _IvtFtp
{

    public partial class Main : Form
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private String Login = "testuser";
        private String Password = "12345678";
        private String URL = "ftp://ftp.19ivt.ru/files/";

        public Main()
        {
            InitializeComponent();
            dataGridFilesToLoad.AllowDrop = true;
            dataGridFilesToLoad.DragDrop += new DragEventHandler(Files_DragDrop);
            dataGridFilesToLoad.DragEnter += new DragEventHandler(Files_DragEnter);
        }

        static String Version = "0.1";
        List<String> LogWrite = new List<String>() 
        { 
            $"[DurkaFiles v{Version} by RGN]",
            $"[First initialized at {DateTime.Now}]"
        };

        void ApplyCredentialsOnStart()
        {
            FtpClient.SetCredential = new System.Net.NetworkCredential(Login, Password);
            LogOutput($"Настройки авторизации успешно применены! (System.Net.NetworkCredential({Login}, {Password}))");
        }

        void FtpResponseLogOutput()
        {
            foreach(String i in FtpClient.GetStatusList) 
            {
                LogOutput(i);
            }
            FtpClient.GetStatusList.Clear();
        }

        public void LogOutput(String Message)
        {
            LogWrite.Add($"<{DateTime.Now}> {Message}");
            LogBox.Items.Add(LogWrite[LogWrite.Count - 1]);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Debug();
            AllocConsole();
            LogOutput("FTP-клиент дурки успешно стартанул!");
            ApplyCredentialsOnStart();
            UpdateNetExplorer();
        }

        private void Files_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void Files_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] Path = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string FilePath in Path)
                {
                    dataGridFilesToLoad.Rows.Add(FilePath);
                    LogOutput($"[{dataGridFilesToLoad.Name}]: Файл/Каталог '{FilePath}' добавлен в очередь к загрузке");
                }
            }
        }

        void Debug()
        {

        }

        private void OnClearLog(object sender, EventArgs e)
        {
            LogWrite.Clear();
            LogBox.Items.Clear();
        }

        private void OnFileOutput(object sender, EventArgs e)
        {
            LogOutput(FileManager.LogWriteFile(LogWrite));
        }

        private void OnDeleteToUploadFiles(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridFilesToLoad.SelectedRows)
            {
                dataGridFilesToLoad.Rows.Remove(row);
            }
        }

        // Управление серверными запросами

        private void OnCallDeleteFromServer(object sender, EventArgs e) // Вызов удаления файла с сервера
        {
            foreach (DataGridViewRow row in dataGridExplorer.SelectedRows)
            {
                Uri CurrentUri = new Uri(URL + row.Cells[0].Value.ToString());
                FtpClient.OnDeleteFileFromServer(CurrentUri);
                FtpResponseLogOutput();
            }
            UpdateNetExplorer();
        }

        private void OnUpdateList(object sender, EventArgs e) // Обновление списка файлов
        {
            UpdateNetExplorer();
        }

        void UpdateNetExplorer()
        {
            dataGridExplorer.Rows.Clear();
            foreach (String i in FtpClient.OnGetDirList(new Uri(URL)))
            {
                dataGridExplorer.Rows.Add(i);
            }
            FtpResponseLogOutput();
        }

        private void OnDownloadFile(object sender, EventArgs e) // Загрузка файла
        {
            foreach (DataGridViewRow row in dataGridExplorer.SelectedRows)
            {
                Uri CurrentUri = new Uri(URL + row.Cells[0].Value.ToString());
                byte[] CurrentFile = FtpClient.OnGetFileFromServer(CurrentUri);
                FtpResponseLogOutput();
                LogOutput(FileManager.WriteFile(CurrentFile, CurrentUri, row.Cells[0].Value.ToString()));
            }
        }

    }
}

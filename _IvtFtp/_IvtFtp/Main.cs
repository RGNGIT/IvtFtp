﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _IvtFtp
{

    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        List<String> LogWrite = new List<String>();

        public void LogOutput(String Message)
        {
            LogWrite.Add($"<{DateTime.Today}> {Message}");
            LogBox.Items.Add(LogWrite[LogWrite.Count - 1]);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void Main_Load(object sender, EventArgs e)
        {
            AllocConsole();
            LogOutput("FTP-клиент дурки успешно стартанул!");
        }

        private void OnClearLog(object sender, EventArgs e)
        {
            LogWrite.Clear();
            LogBox.Items.Clear();
        }

        private void OnFileOutput(object sender, EventArgs e)
        {
            File.WriteAllLines(@"log.rgn", LogWrite);
        }

    }
}

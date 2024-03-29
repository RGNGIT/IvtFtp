﻿namespace _IvtFtp
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxGCLog = new System.Windows.Forms.CheckBox();
            this.labelPing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxServers = new System.Windows.Forms.ComboBox();
            this.FileOutput = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelWorkStatus = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelFromServer = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonDeleteUpload = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.dataGridExplorer = new System.Windows.Forms.DataGridView();
            this._pathexplorer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridFilesToLoad = new System.Windows.Forms.DataGridView();
            this._path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilesToLoad)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.checkBoxGCLog);
            this.tabPage2.Controls.Add(this.labelPing);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBoxServers);
            this.tabPage2.Controls.Add(this.FileOutput);
            this.tabPage2.Controls.Add(this.buttonClearLog);
            this.tabPage2.Controls.Add(this.LogBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лог";
            // 
            // checkBoxGCLog
            // 
            this.checkBoxGCLog.AutoSize = true;
            this.checkBoxGCLog.Checked = true;
            this.checkBoxGCLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGCLog.Location = new System.Drawing.Point(616, 6);
            this.checkBoxGCLog.Name = "checkBoxGCLog";
            this.checkBoxGCLog.Size = new System.Drawing.Size(178, 17);
            this.checkBoxGCLog.TabIndex = 6;
            this.checkBoxGCLog.Text = "Показать лог очистки памяти";
            this.checkBoxGCLog.UseVisualStyleBackColor = true;
            this.checkBoxGCLog.CheckedChanged += new System.EventHandler(this.GCCheck);
            // 
            // labelPing
            // 
            this.labelPing.AutoSize = true;
            this.labelPing.Location = new System.Drawing.Point(180, 405);
            this.labelPing.Name = "labelPing";
            this.labelPing.Size = new System.Drawing.Size(48, 13);
            this.labelPing.TabIndex = 5;
            this.labelPing.Text = "$Pinging";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сервер";
            // 
            // comboBoxServers
            // 
            this.comboBoxServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServers.FormattingEnabled = true;
            this.comboBoxServers.Items.AddRange(new object[] {
            "ftp.19ivt.ru"});
            this.comboBoxServers.Location = new System.Drawing.Point(53, 401);
            this.comboBoxServers.Name = "comboBoxServers";
            this.comboBoxServers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServers.TabIndex = 3;
            // 
            // FileOutput
            // 
            this.FileOutput.Location = new System.Drawing.Point(574, 400);
            this.FileOutput.Name = "FileOutput";
            this.FileOutput.Size = new System.Drawing.Size(107, 23);
            this.FileOutput.TabIndex = 2;
            this.FileOutput.Text = "Вывести в файл";
            this.FileOutput.UseVisualStyleBackColor = true;
            this.FileOutput.Click += new System.EventHandler(this.OnFileOutput);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(687, 400);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(107, 23);
            this.buttonClearLog.TabIndex = 1;
            this.buttonClearLog.Text = "Очистить лог";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.OnClearLog);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.Silver;
            this.LogBox.FormattingEnabled = true;
            this.LogBox.Location = new System.Drawing.Point(6, 6);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(788, 381);
            this.LogBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.labelWorkStatus);
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Controls.Add(this.buttonDelFromServer);
            this.tabPage1.Controls.Add(this.buttonDownload);
            this.tabPage1.Controls.Add(this.buttonDeleteUpload);
            this.tabPage1.Controls.Add(this.buttonUpload);
            this.tabPage1.Controls.Add(this.dataGridExplorer);
            this.tabPage1.Controls.Add(this.dataGridFilesToLoad);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиент";
            // 
            // labelWorkStatus
            // 
            this.labelWorkStatus.AutoSize = true;
            this.labelWorkStatus.Location = new System.Drawing.Point(149, 405);
            this.labelWorkStatus.Name = "labelWorkStatus";
            this.labelWorkStatus.Size = new System.Drawing.Size(43, 13);
            this.labelWorkStatus.TabIndex = 9;
            this.labelWorkStatus.Text = "$Status";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(550, 400);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(101, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.OnUpdateList);
            // 
            // buttonDelFromServer
            // 
            this.buttonDelFromServer.Location = new System.Drawing.Point(657, 400);
            this.buttonDelFromServer.Name = "buttonDelFromServer";
            this.buttonDelFromServer.Size = new System.Drawing.Size(137, 23);
            this.buttonDelFromServer.TabIndex = 7;
            this.buttonDelFromServer.Text = "Удалить с сервера";
            this.buttonDelFromServer.UseVisualStyleBackColor = true;
            this.buttonDelFromServer.Click += new System.EventHandler(this.OnCallDeleteFromServer);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(407, 400);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(137, 23);
            this.buttonDownload.TabIndex = 6;
            this.buttonDownload.Text = "Выгрузить на комп";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.OnDownloadFile);
            // 
            // buttonDeleteUpload
            // 
            this.buttonDeleteUpload.Location = new System.Drawing.Point(254, 400);
            this.buttonDeleteUpload.Name = "buttonDeleteUpload";
            this.buttonDeleteUpload.Size = new System.Drawing.Size(137, 23);
            this.buttonDeleteUpload.TabIndex = 4;
            this.buttonDeleteUpload.Text = "Удалить выбранное";
            this.buttonDeleteUpload.UseVisualStyleBackColor = true;
            this.buttonDeleteUpload.Click += new System.EventHandler(this.OnDeleteToUploadFiles);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(6, 400);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(137, 23);
            this.buttonUpload.TabIndex = 3;
            this.buttonUpload.Text = "Выгрузить на сервер";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // dataGridExplorer
            // 
            this.dataGridExplorer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridExplorer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExplorer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._pathexplorer});
            this.dataGridExplorer.Location = new System.Drawing.Point(407, 6);
            this.dataGridExplorer.Name = "dataGridExplorer";
            this.dataGridExplorer.Size = new System.Drawing.Size(387, 381);
            this.dataGridExplorer.TabIndex = 2;
            // 
            // _pathexplorer
            // 
            this._pathexplorer.HeaderText = "Файл/Каталог";
            this._pathexplorer.Name = "_pathexplorer";
            this._pathexplorer.Width = 344;
            // 
            // dataGridFilesToLoad
            // 
            this.dataGridFilesToLoad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridFilesToLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilesToLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._path});
            this.dataGridFilesToLoad.Location = new System.Drawing.Point(6, 6);
            this.dataGridFilesToLoad.Name = "dataGridFilesToLoad";
            this.dataGridFilesToLoad.Size = new System.Drawing.Size(385, 381);
            this.dataGridFilesToLoad.TabIndex = 1;
            // 
            // _path
            // 
            this._path.HeaderText = "Файл/Каталог";
            this._path.Name = "_path";
            this._path.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._path.Width = 342;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "DurkaFiles";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilesToLoad)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button FileOutput;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.ListBox LogBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelFromServer;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonDeleteUpload;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.DataGridView dataGridExplorer;
        private System.Windows.Forms.DataGridViewTextBoxColumn _pathexplorer;
        private System.Windows.Forms.DataGridView dataGridFilesToLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn _path;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBoxServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPing;
        private System.Windows.Forms.Label labelWorkStatus;
        private System.Windows.Forms.CheckBox checkBoxGCLog;
    }
}


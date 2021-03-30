namespace _IvtFtp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FileOutput = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиент";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
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
            // FileOutput
            // 
            this.FileOutput.Location = new System.Drawing.Point(568, 400);
            this.FileOutput.Name = "FileOutput";
            this.FileOutput.Size = new System.Drawing.Size(107, 23);
            this.FileOutput.TabIndex = 2;
            this.FileOutput.Text = "Вывести в файл";
            this.FileOutput.UseVisualStyleBackColor = true;
            this.FileOutput.Click += new System.EventHandler(this.OnFileOutput);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(681, 400);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox LogBox;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button FileOutput;
    }
}


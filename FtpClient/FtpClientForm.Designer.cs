namespace FtpClient
{
    partial class FtpClientForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.grpBoxUpload = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewFilename = new System.Windows.Forms.TextBox();
            this.txtCurrentFilename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNewDir = new System.Windows.Forms.TextBox();
            this.btnewDir = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnFTPSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFileDetailList = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.grpBoxUpload.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(6, 42);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(178, 21);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtUpload
            // 
            this.txtUpload.Location = new System.Drawing.Point(6, 18);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(539, 21);
            this.txtUpload.TabIndex = 1;
            // 
            // grpBoxUpload
            // 
            this.grpBoxUpload.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxUpload.Controls.Add(this.txtUpload);
            this.grpBoxUpload.Controls.Add(this.btnUpload);
            this.grpBoxUpload.Controls.Add(this.btndelete);
            this.grpBoxUpload.Controls.Add(this.btnDownload);
            this.grpBoxUpload.Location = new System.Drawing.Point(12, 11);
            this.grpBoxUpload.Name = "grpBoxUpload";
            this.grpBoxUpload.Size = new System.Drawing.Size(551, 73);
            this.grpBoxUpload.TabIndex = 2;
            this.grpBoxUpload.TabStop = false;
            this.grpBoxUpload.Text = "基本操作";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(369, 42);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(176, 21);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(190, 42);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(173, 21);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "下载";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtNewFilename);
            this.groupBox5.Controls.Add(this.txtCurrentFilename);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(13, 90);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(550, 96);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "文件重命名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "新文件名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "旧文件名";
            // 
            // txtNewFilename
            // 
            this.txtNewFilename.Location = new System.Drawing.Point(68, 42);
            this.txtNewFilename.Name = "txtNewFilename";
            this.txtNewFilename.Size = new System.Drawing.Size(476, 21);
            this.txtNewFilename.TabIndex = 2;
            // 
            // txtCurrentFilename
            // 
            this.txtCurrentFilename.Location = new System.Drawing.Point(68, 18);
            this.txtCurrentFilename.Name = "txtCurrentFilename";
            this.txtCurrentFilename.Size = new System.Drawing.Size(476, 21);
            this.txtCurrentFilename.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(539, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "重命名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.txtNewDir);
            this.groupBox6.Controls.Add(this.btnewDir);
            this.groupBox6.Location = new System.Drawing.Point(12, 191);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(551, 73);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "新建目录";
            // 
            // txtNewDir
            // 
            this.txtNewDir.Location = new System.Drawing.Point(6, 18);
            this.txtNewDir.Name = "txtNewDir";
            this.txtNewDir.Size = new System.Drawing.Size(539, 21);
            this.txtNewDir.TabIndex = 1;
            // 
            // btnewDir
            // 
            this.btnewDir.Location = new System.Drawing.Point(6, 42);
            this.btnewDir.Name = "btnewDir";
            this.btnewDir.Size = new System.Drawing.Size(539, 21);
            this.btnewDir.TabIndex = 0;
            this.btnewDir.Text = "创建目录";
            this.btnewDir.UseVisualStyleBackColor = true;
            this.btnewDir.Click += new System.EventHandler(this.btnewDir_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.txtPassword);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txtUsername);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txtServerIP);
            this.groupBox7.Controls.Add(this.btnFTPSave);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(13, 429);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(550, 85);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "服务器设置";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(381, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 21);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "密码";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(193, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 21);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "用户名";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(5, 30);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(163, 21);
            this.txtServerIP.TabIndex = 1;
            this.txtServerIP.TextChanged += new System.EventHandler(this.txtServerIP_TextChanged);
            // 
            // btnFTPSave
            // 
            this.btnFTPSave.Enabled = false;
            this.btnFTPSave.Location = new System.Drawing.Point(5, 56);
            this.btnFTPSave.Name = "btnFTPSave";
            this.btnFTPSave.Size = new System.Drawing.Size(539, 21);
            this.btnFTPSave.TabIndex = 0;
            this.btnFTPSave.Text = "连接";
            this.btnFTPSave.UseVisualStyleBackColor = true;
            this.btnFTPSave.Click += new System.EventHandler(this.btnFTPSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "服务器IP";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnFileDetailList);
            this.groupBox2.Controls.Add(this.lstFiles);
            this.groupBox2.Location = new System.Drawing.Point(13, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 154);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "列出文件";
            // 
            // btnFileDetailList
            // 
            this.btnFileDetailList.Location = new System.Drawing.Point(7, 123);
            this.btnFileDetailList.Name = "btnFileDetailList";
            this.btnFileDetailList.Size = new System.Drawing.Size(537, 21);
            this.btnFileDetailList.TabIndex = 2;
            this.btnFileDetailList.Text = "列出文件信息";
            this.btnFileDetailList.UseVisualStyleBackColor = true;
            this.btnFileDetailList.Click += new System.EventHandler(this.btnFileDetailList_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 12;
            this.lstFiles.Location = new System.Drawing.Point(7, 18);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(537, 100);
            this.lstFiles.TabIndex = 1;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // FtpClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(579, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpBoxUpload);
            this.Name = "FtpClientForm";
            this.Text = "FTP 客户端 : Server - ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxUpload.ResumeLayout(false);
            this.grpBoxUpload.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtUpload;
        private System.Windows.Forms.GroupBox grpBoxUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNewFilename;
        private System.Windows.Forms.TextBox txtCurrentFilename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNewDir;
        private System.Windows.Forms.Button btnewDir;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnFTPSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFileDetailList;
        private System.Windows.Forms.ListBox lstFiles;
    }
}


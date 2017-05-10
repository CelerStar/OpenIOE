namespace channel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxServerIP = new System.Windows.Forms.TextBox();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.textBoxReceiveMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConnectOpenIOE = new System.Windows.Forms.Button();
            this.buttonClsRec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExiOpenIOE = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBoxEnter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.Location = new System.Drawing.Point(17, 491);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(327, 41);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.TabStop = false;
            this.buttonSend.Text = "发送数据";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.Location = new System.Drawing.Point(143, 12);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.Size = new System.Drawing.Size(201, 28);
            this.textBoxServerIP.TabIndex = 2;
            this.textBoxServerIP.Text = "121.42.182.188";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Location = new System.Drawing.Point(143, 48);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(200, 28);
            this.textBoxServerPort.TabIndex = 3;
            this.textBoxServerPort.Text = "8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "服务器地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "服务器端口";
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(17, 167);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(327, 318);
            this.textBoxMsg.TabIndex = 8;
            // 
            // textBoxReceiveMsg
            // 
            this.textBoxReceiveMsg.Location = new System.Drawing.Point(375, 88);
            this.textBoxReceiveMsg.Multiline = true;
            this.textBoxReceiveMsg.Name = "textBoxReceiveMsg";
            this.textBoxReceiveMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceiveMsg.Size = new System.Drawing.Size(391, 397);
            this.textBoxReceiveMsg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(371, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "接送区";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "发送区";
            // 
            // buttonConnectOpenIOE
            // 
            this.buttonConnectOpenIOE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonConnectOpenIOE.Location = new System.Drawing.Point(17, 82);
            this.buttonConnectOpenIOE.Name = "buttonConnectOpenIOE";
            this.buttonConnectOpenIOE.Size = new System.Drawing.Size(157, 41);
            this.buttonConnectOpenIOE.TabIndex = 17;
            this.buttonConnectOpenIOE.TabStop = false;
            this.buttonConnectOpenIOE.Text = "连接服务器";
            this.buttonConnectOpenIOE.UseVisualStyleBackColor = true;
            this.buttonConnectOpenIOE.Click += new System.EventHandler(this.buttonConnectOpenIOE_Click);
            // 
            // buttonClsRec
            // 
            this.buttonClsRec.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClsRec.Location = new System.Drawing.Point(555, 491);
            this.buttonClsRec.Name = "buttonClsRec";
            this.buttonClsRec.Size = new System.Drawing.Size(211, 41);
            this.buttonClsRec.TabIndex = 18;
            this.buttonClsRec.TabStop = false;
            this.buttonClsRec.Text = "清空接收区";
            this.buttonClsRec.UseVisualStyleBackColor = true;
            this.buttonClsRec.Click += new System.EventHandler(this.buttonClsRec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(632, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonExiOpenIOE
            // 
            this.buttonExiOpenIOE.Enabled = false;
            this.buttonExiOpenIOE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExiOpenIOE.Location = new System.Drawing.Point(187, 82);
            this.buttonExiOpenIOE.Name = "buttonExiOpenIOE";
            this.buttonExiOpenIOE.Size = new System.Drawing.Size(157, 41);
            this.buttonExiOpenIOE.TabIndex = 21;
            this.buttonExiOpenIOE.TabStop = false;
            this.buttonExiOpenIOE.Text = "断开服务器";
            this.buttonExiOpenIOE.UseVisualStyleBackColor = true;
            this.buttonExiOpenIOE.Click += new System.EventHandler(this.buttonExiOpenIOE_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(702, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // checkBoxEnter
            // 
            this.checkBoxEnter.AutoSize = true;
            this.checkBoxEnter.Location = new System.Drawing.Point(375, 502);
            this.checkBoxEnter.Name = "checkBoxEnter";
            this.checkBoxEnter.Size = new System.Drawing.Size(142, 22);
            this.checkBoxEnter.TabIndex = 24;
            this.checkBoxEnter.Text = "自动添加换行";
            this.checkBoxEnter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.checkBoxEnter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonExiOpenIOE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClsRec);
            this.Controls.Add(this.buttonConnectOpenIOE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxReceiveMsg);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServerPort);
            this.Controls.Add(this.textBoxServerIP);
            this.Controls.Add(this.buttonSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OpenIOE TCP 调试助手";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxServerIP;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.TextBox textBoxReceiveMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConnectOpenIOE;
        private System.Windows.Forms.Button buttonClsRec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExiOpenIOE;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxEnter;
    }
}


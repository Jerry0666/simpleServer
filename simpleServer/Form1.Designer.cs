namespace simpleServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            StatusLab = new Label();
            label3 = new Label();
            txtIP = new TextBox();
            label4 = new Label();
            txtPort = new TextBox();
            dataLog = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 71);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Status:";
            label1.Click += label1_Click;
            // 
            // StatusLab
            // 
            StatusLab.AutoSize = true;
            StatusLab.Location = new Point(278, 71);
            StatusLab.Name = "StatusLab";
            StatusLab.Size = new Size(95, 25);
            StatusLab.TabIndex = 1;
            StatusLab.Text = "Stopped";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 122);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 2;
            label3.Text = "IP:";
            label3.Click += label3_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(278, 114);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(125, 33);
            txtIP.TabIndex = 3;
            txtIP.Text = "127.0.0.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 163);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 4;
            label4.Text = "Port:";
            label4.Click += label4_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(278, 163);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 33);
            txtPort.TabIndex = 5;
            txtPort.Text = "13000";
            // 
            // dataLog
            // 
            dataLog.Location = new Point(121, 274);
            dataLog.Multiline = true;
            dataLog.Name = "dataLog";
            dataLog.ScrollBars = ScrollBars.Vertical;
            dataLog.Size = new Size(329, 222);
            dataLog.TabIndex = 6;
            dataLog.WordWrap = false;
            // 
            // button1
            // 
            button1.Location = new Point(157, 220);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 592);
            Controls.Add(button1);
            Controls.Add(dataLog);
            Controls.Add(txtPort);
            Controls.Add(label4);
            Controls.Add(txtIP);
            Controls.Add(label3);
            Controls.Add(StatusLab);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label StatusLab;
        private Label label3;
        private TextBox txtIP;
        private Label label4;
        private TextBox txtPort;
        private TextBox dataLog;
        private Button button1;
    }
}

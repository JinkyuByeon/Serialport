﻿
namespace day1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_disconnect = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.label_send = new System.Windows.Forms.Label();
            this.label_receive = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(40, 47);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 20);
            this.comboBox_port.TabIndex = 0;
            this.comboBox_port.Tag = "comboBox_port";
            // 
            // button_connect
            // 
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_connect.Location = new System.Drawing.Point(14, 210);
            this.button_connect.Name = "button_connect";
            this.button_connect.Padding = new System.Windows.Forms.Padding(200);
            this.button_connect.Size = new System.Drawing.Size(81, 47);
            this.button_connect.TabIndex = 1;
            this.button_connect.Tag = "button_connect";
            this.button_connect.Text = "연결하기";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button_disconnect
            // 
            this.button_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_disconnect.Location = new System.Drawing.Point(140, 210);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(81, 47);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.Tag = "button_disconnect";
            this.button_disconnect.Text = "연결끊기";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(338, 364);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(316, 21);
            this.textBox_send.TabIndex = 3;
            this.textBox_send.Tag = "textBox_send";
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(338, 59);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.Size = new System.Drawing.Size(413, 249);
            this.richTextBox_received.TabIndex = 4;
            this.richTextBox_received.Tag = "richTextBox_received";
            this.richTextBox_received.Text = "";
            // 
            // label_send
            // 
            this.label_send.AutoSize = true;
            this.label_send.Location = new System.Drawing.Point(336, 343);
            this.label_send.Name = "label_send";
            this.label_send.Size = new System.Drawing.Size(29, 12);
            this.label_send.TabIndex = 5;
            this.label_send.Text = "송신";
            // 
            // label_receive
            // 
            this.label_receive.AutoSize = true;
            this.label_receive.Location = new System.Drawing.Point(336, 35);
            this.label_receive.Name = "label_receive";
            this.label_receive.Size = new System.Drawing.Size(29, 12);
            this.label_receive.TabIndex = 6;
            this.label_receive.Text = "수신";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(38, 32);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(90, 12);
            this.label_port.TabIndex = 7;
            this.label_port.Tag = "label_port";
            this.label_port.Text = "COM 포트 설정";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(676, 364);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 8;
            this.button_send.Tag = "button_send";
            this.button_send.Text = "보내기";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 296);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(53, 12);
            this.label_status.TabIndex = 9;
            this.label_status.Tag = "label_status";
            this.label_status.Text = "연결상태";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_receive);
            this.Controls.Add(this.label_send);
            this.Controls.Add(this.richTextBox_received);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.comboBox_port);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.RichTextBox richTextBox_received;
        private System.Windows.Forms.Label label_send;
        private System.Windows.Forms.Label label_receive;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label_status;
    }
}


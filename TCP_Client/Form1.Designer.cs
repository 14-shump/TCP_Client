
namespace TCP_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Receive = new System.Windows.Forms.TextBox();
            this.lbl_Receive = new System.Windows.Forms.Label();
            this.txt_Cmd = new System.Windows.Forms.TextBox();
            this.lbl_Cmd = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Receive
            // 
            this.txt_Receive.Location = new System.Drawing.Point(12, 98);
            this.txt_Receive.Multiline = true;
            this.txt_Receive.Name = "txt_Receive";
            this.txt_Receive.ReadOnly = true;
            this.txt_Receive.Size = new System.Drawing.Size(475, 138);
            this.txt_Receive.TabIndex = 0;
            // 
            // lbl_Receive
            // 
            this.lbl_Receive.AutoSize = true;
            this.lbl_Receive.Location = new System.Drawing.Point(12, 83);
            this.lbl_Receive.Name = "lbl_Receive";
            this.lbl_Receive.Size = new System.Drawing.Size(53, 12);
            this.lbl_Receive.TabIndex = 1;
            this.lbl_Receive.Text = "受信内容";
            // 
            // txt_Cmd
            // 
            this.txt_Cmd.Location = new System.Drawing.Point(14, 61);
            this.txt_Cmd.Name = "txt_Cmd";
            this.txt_Cmd.Size = new System.Drawing.Size(367, 19);
            this.txt_Cmd.TabIndex = 2;
            // 
            // lbl_Cmd
            // 
            this.lbl_Cmd.AutoSize = true;
            this.lbl_Cmd.Location = new System.Drawing.Point(12, 46);
            this.lbl_Cmd.Name = "lbl_Cmd";
            this.lbl_Cmd.Size = new System.Drawing.Size(40, 12);
            this.lbl_Cmd.TabIndex = 3;
            this.lbl_Cmd.Text = "コマンド";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(387, 61);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 19);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "送信";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(387, 24);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(100, 19);
            this.btn_Connect.TabIndex = 7;
            this.btn_Connect.Text = "接続";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(12, 9);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(51, 12);
            this.lbl_IP.TabIndex = 6;
            this.lbl_IP.Text = "IPアドレス";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(14, 24);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(261, 19);
            this.txt_IP.TabIndex = 5;
            this.txt_IP.Text = "192.168.10.107";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(279, 9);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(33, 12);
            this.lbl_Port.TabIndex = 9;
            this.lbl_Port.Text = "ポート";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(281, 24);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 19);
            this.txt_Port.TabIndex = 8;
            this.txt_Port.Text = "4000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 250);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.lbl_Cmd);
            this.Controls.Add(this.txt_Cmd);
            this.Controls.Add(this.lbl_Receive);
            this.Controls.Add(this.txt_Receive);
            this.Name = "Form1";
            this.Text = "TCP_Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Receive;
        private System.Windows.Forms.Label lbl_Receive;
        private System.Windows.Forms.TextBox txt_Cmd;
        private System.Windows.Forms.Label lbl_Cmd;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.TextBox txt_Port;
    }
}

